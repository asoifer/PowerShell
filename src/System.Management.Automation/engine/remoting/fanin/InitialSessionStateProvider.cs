// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Automation.Internal;
using System.Management.Automation.Runspaces;
using System.Management.Automation.Tracing;
using System.Reflection;
using System.Threading;
using System.Xml;

using Microsoft.PowerShell.Commands;
using Microsoft.Win32;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
    internal class ConfigurationDataFromXML
    {
        internal const string
        INITPARAMETERSTOKEN = "InitializationParameters"
        ;

        internal const string
        PARAMTOKEN = "Param"
        ;

        internal const string
        NAMETOKEN = "Name"
        ;

        internal const string
        VALUETOKEN = "Value"
        ;

        internal const string
        APPBASETOKEN = "applicationbase"
        ;

        internal const string
        ASSEMBLYTOKEN = "assemblyname"
        ;

        internal const string
        SHELLCONFIGTYPETOKEN = "pssessionconfigurationtypename"
        ;

        internal const string
        STARTUPSCRIPTTOKEN = "startupscript"
        ;

        internal const string
        MAXRCVDOBJSIZETOKEN = "psmaximumreceivedobjectsizemb"
        ;

        internal const string
        MAXRCVDOBJSIZETOKEN_CamelCase = "PSMaximumReceivedObjectSizeMB"
        ;

        internal const string
        MAXRCVDCMDSIZETOKEN = "psmaximumreceiveddatasizepercommandmb"
        ;

        internal const string
        MAXRCVDCMDSIZETOKEN_CamelCase = "PSMaximumReceivedDataSizePerCommandMB"
        ;

        internal const string
        THREADOPTIONSTOKEN = "pssessionthreadoptions"
        ;

        internal const string
        THREADAPTSTATETOKEN = "pssessionthreadapartmentstate"
        ;

        internal const string
        SESSIONCONFIGTOKEN = "sessionconfigurationdata"
        ;

        internal const string
        PSVERSIONTOKEN = "PSVersion"
        ;

        internal const string
        MAXPSVERSIONTOKEN = "MaxPSVersion"
        ;

        internal const string
        MODULESTOIMPORT = "ModulesToImport"
        ;

        internal const string
        HOSTMODE = "hostmode"
        ;

        internal const string
        CONFIGFILEPATH = "configfilepath"
        ;

        internal const string
        CONFIGFILEPATH_CamelCase = "ConfigFilePath"
        ;

        internal string StartupScript;

        internal string InitializationScriptForOutOfProcessRunspace;

        internal string ApplicationBase;

        internal string AssemblyName;

        internal string EndPointConfigurationTypeName;

        internal Type EndPointConfigurationType;

        internal int? MaxReceivedObjectSizeMB;

        internal int? MaxReceivedCommandSizeMB;

        internal PSThreadOptions? ShellThreadOptions;

        internal ApartmentState? ShellThreadApartmentState;

        internal PSSessionConfigurationData SessionConfigurationData;

        internal string ConfigFilePath;

        private void Update(string optionName, string optionValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1634, 3874, 7510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 3957, 7499);

                switch (f_1634_3965_3994(optionName))
                {

                    case APPBASETOKEN:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 3957, 7499);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 4068, 4122);

                        f_1634_4068_4121(this, APPBASETOKEN, ApplicationBase);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 4310, 4380);

                        ApplicationBase = f_1634_4328_4379(optionValue);
                        DynAbs.Tracing.TraceSender.TraceBreak(1634, 4402, 4408);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 3957, 7499);

                    case ASSEMBLYTOKEN:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 3957, 7499);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 4467, 4519);

                        f_1634_4467_4518(this, ASSEMBLYTOKEN, AssemblyName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 4541, 4568);

                        AssemblyName = optionValue;
                        DynAbs.Tracing.TraceSender.TraceBreak(1634, 4590, 4596);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 3957, 7499);

                    case SHELLCONFIGTYPETOKEN:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 3957, 7499);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 4662, 4738);

                        f_1634_4662_4737(this, SHELLCONFIGTYPETOKEN, EndPointConfigurationTypeName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 4760, 4804);

                        EndPointConfigurationTypeName = optionValue;
                        DynAbs.Tracing.TraceSender.TraceBreak(1634, 4826, 4832);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 3957, 7499);

                    case STARTUPSCRIPTTOKEN:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 3957, 7499);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 4896, 4954);

                        f_1634_4896_4953(this, STARTUPSCRIPTTOKEN, StartupScript);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 4976, 5305) || true) && (!f_1634_4981_5045(optionValue, ".ps1", StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 4976, 5305);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 5095, 5282);

                            throw f_1634_5101_5281(STARTUPSCRIPTTOKEN, f_1634_5185_5231(), STARTUPSCRIPTTOKEN);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 4976, 5305);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 5463, 5531);

                        StartupScript = f_1634_5479_5530(optionValue);
                        DynAbs.Tracing.TraceSender.TraceBreak(1634, 5553, 5559);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 3957, 7499);

                    case MAXRCVDOBJSIZETOKEN:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 3957, 7499);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 5624, 5693);

                        f_1634_5624_5692(this, MAXRCVDOBJSIZETOKEN, MaxReceivedObjectSizeMB);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 5715, 5773);

                        MaxReceivedObjectSizeMB = f_1634_5741_5772(optionValue);
                        DynAbs.Tracing.TraceSender.TraceBreak(1634, 5795, 5801);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 3957, 7499);

                    case MAXRCVDCMDSIZETOKEN:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 3957, 7499);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 5866, 5936);

                        f_1634_5866_5935(this, MAXRCVDCMDSIZETOKEN, MaxReceivedCommandSizeMB);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 5958, 6017);

                        MaxReceivedCommandSizeMB = f_1634_5985_6016(optionValue);
                        DynAbs.Tracing.TraceSender.TraceBreak(1634, 6039, 6045);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 3957, 7499);

                    case THREADOPTIONSTOKEN:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 3957, 7499);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 6109, 6172);

                        f_1634_6109_6171(this, THREADOPTIONSTOKEN, ShellThreadOptions);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 6194, 6355);

                        ShellThreadOptions = (PSThreadOptions)f_1634_6232_6354(optionValue, typeof(PSThreadOptions), f_1634_6325_6353());
                        DynAbs.Tracing.TraceSender.TraceBreak(1634, 6377, 6383);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 3957, 7499);

                    case THREADAPTSTATETOKEN:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 3957, 7499);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 6448, 6519);

                        f_1634_6448_6518(this, THREADAPTSTATETOKEN, ShellThreadApartmentState);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 6541, 6707);

                        ShellThreadApartmentState = (ApartmentState)f_1634_6585_6706(optionValue, typeof(ApartmentState), f_1634_6677_6705());
                        DynAbs.Tracing.TraceSender.TraceBreak(1634, 6729, 6735);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 3957, 7499);

                    case SESSIONCONFIGTOKEN:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 3957, 7499);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 6826, 6895);

                            f_1634_6826_6894(this, SESSIONCONFIGTOKEN, SessionConfigurationData);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 6921, 6995);

                            SessionConfigurationData = f_1634_6948_6994(optionValue);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1634, 7042, 7048);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 3957, 7499);

                    case CONFIGFILEPATH:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 3957, 7499);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 7135, 7190);

                            f_1634_7135_7189(this, CONFIGFILEPATH, ConfigFilePath);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 7216, 7256);

                            ConfigFilePath = f_1634_7233_7255(optionValue);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1634, 7303, 7309);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 3957, 7499);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 3957, 7499);
                        DynAbs.Tracing.TraceSender.TraceBreak(1634, 7478, 7484);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 3957, 7499);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1634, 3874, 7510);

                string
                f_1634_3965_3994(string
                this_param)
                {
                    var return_v = this_param.ToLowerInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 3965, 3994);
                    return return_v;
                }


                int
                f_1634_4068_4121(System.Management.Automation.Remoting.ConfigurationDataFromXML
                this_param, string
                optionName, string
                originalValue)
                {
                    this_param.AssertValueNotAssigned(optionName, (object)originalValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 4068, 4121);
                    return 0;
                }


                string
                f_1634_4328_4379(string
                name)
                {
                    var return_v = Environment.ExpandEnvironmentVariables(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 4328, 4379);
                    return return_v;
                }


                int
                f_1634_4467_4518(System.Management.Automation.Remoting.ConfigurationDataFromXML
                this_param, string
                optionName, string
                originalValue)
                {
                    this_param.AssertValueNotAssigned(optionName, (object)originalValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 4467, 4518);
                    return 0;
                }


                int
                f_1634_4662_4737(System.Management.Automation.Remoting.ConfigurationDataFromXML
                this_param, string
                optionName, string
                originalValue)
                {
                    this_param.AssertValueNotAssigned(optionName, (object)originalValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 4662, 4737);
                    return 0;
                }


                int
                f_1634_4896_4953(System.Management.Automation.Remoting.ConfigurationDataFromXML
                this_param, string
                optionName, string
                originalValue)
                {
                    this_param.AssertValueNotAssigned(optionName, (object)originalValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 4896, 4953);
                    return 0;
                }


                bool
                f_1634_4981_5045(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 4981, 5045);
                    return return_v;
                }


                string
                f_1634_5185_5231()
                {
                    var return_v = RemotingErrorIdStrings.StartupScriptNotCorrect;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 5185, 5231);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1634_5101_5281(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 5101, 5281);
                    return return_v;
                }


                string
                f_1634_5479_5530(string
                name)
                {
                    var return_v = Environment.ExpandEnvironmentVariables(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 5479, 5530);
                    return return_v;
                }


                int
                f_1634_5624_5692(System.Management.Automation.Remoting.ConfigurationDataFromXML
                this_param, string
                optionName, int?
                originalValue)
                {
                    this_param.AssertValueNotAssigned(optionName, (object)originalValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 5624, 5692);
                    return 0;
                }


                int?
                f_1634_5741_5772(string
                optionValueInMB)
                {
                    var return_v = GetIntValueInBytes(optionValueInMB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 5741, 5772);
                    return return_v;
                }


                int
                f_1634_5866_5935(System.Management.Automation.Remoting.ConfigurationDataFromXML
                this_param, string
                optionName, int?
                originalValue)
                {
                    this_param.AssertValueNotAssigned(optionName, (object)originalValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 5866, 5935);
                    return 0;
                }


                int?
                f_1634_5985_6016(string
                optionValueInMB)
                {
                    var return_v = GetIntValueInBytes(optionValueInMB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 5985, 6016);
                    return return_v;
                }


                int
                f_1634_6109_6171(System.Management.Automation.Remoting.ConfigurationDataFromXML
                this_param, string
                optionName, System.Management.Automation.Runspaces.PSThreadOptions?
                originalValue)
                {
                    this_param.AssertValueNotAssigned(optionName, (object)originalValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 6109, 6171);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1634_6325_6353()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 6325, 6353);
                    return return_v;
                }


                object
                f_1634_6232_6354(string
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 6232, 6354);
                    return return_v;
                }


                int
                f_1634_6448_6518(System.Management.Automation.Remoting.ConfigurationDataFromXML
                this_param, string
                optionName, System.Threading.ApartmentState?
                originalValue)
                {
                    this_param.AssertValueNotAssigned(optionName, (object)originalValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 6448, 6518);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1634_6677_6705()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 6677, 6705);
                    return return_v;
                }


                object
                f_1634_6585_6706(string
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 6585, 6706);
                    return return_v;
                }


                int
                f_1634_6826_6894(System.Management.Automation.Remoting.ConfigurationDataFromXML
                this_param, string
                optionName, System.Management.Automation.Remoting.PSSessionConfigurationData
                originalValue)
                {
                    this_param.AssertValueNotAssigned(optionName, (object)originalValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 6826, 6894);
                    return 0;
                }


                System.Management.Automation.Remoting.PSSessionConfigurationData
                f_1634_6948_6994(string
                configurationData)
                {
                    var return_v = PSSessionConfigurationData.Create(configurationData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 6948, 6994);
                    return return_v;
                }


                int
                f_1634_7135_7189(System.Management.Automation.Remoting.ConfigurationDataFromXML
                this_param, string
                optionName, string
                originalValue)
                {
                    this_param.AssertValueNotAssigned(optionName, (object)originalValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 7135, 7189);
                    return 0;
                }


                string
                f_1634_7233_7255(string
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 7233, 7255);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 3874, 7510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 3874, 7510);
            }
        }

        private void AssertValueNotAssigned(string optionName, object originalValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1634, 7869, 8224);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 7970, 8213) || true) && (originalValue != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 7970, 8213);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 8029, 8198);

                    throw f_1634_8035_8197(optionName, f_1634_8103_8163(), optionName, INITPARAMETERSTOKEN);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 7970, 8213);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1634, 7869, 8224);

                string
                f_1634_8103_8163()
                {
                    var return_v = RemotingErrorIdStrings.DuplicateInitializationParameterFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 8103, 8163);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1634_8035_8197(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 8035, 8197);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 7869, 8224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 7869, 8224);
            }
        }

        private static int? GetIntValueInBytes(string optionValueInMB)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 8624, 9260);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 8711, 8730);

                int?
                result = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 8780, 8945);

                    double
                    variableValue = (double)f_1634_8811_8944(optionValueInMB, typeof(double), f_1634_8894_8943())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 8965, 9020);

                    result = unchecked((int)(variableValue * 1024 * 1024));
                }
                catch (InvalidCastException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 9068, 9126);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 9068, 9126);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 9142, 9219) || true) && (result < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 9142, 9219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 9190, 9204);

                    result = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 9142, 9219);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 9235, 9249);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 8624, 9260);

                System.Globalization.CultureInfo
                f_1634_8894_8943()
                {
                    var return_v = System.Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 8894, 8943);
                    return return_v;
                }


                object
                f_1634_8811_8944(string
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 8811, 8944);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 8624, 9260);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 8624, 9260);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ConfigurationDataFromXML Create(string initializationParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 10813, 13717);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 10918, 10983);

                ConfigurationDataFromXML
                result = f_1634_10952_10982()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 10997, 11110) || true) && (f_1634_11001_11047(initializationParameters))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 10997, 11110);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 11081, 11095);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 10997, 11110);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 11126, 11185);

                XmlReaderSettings
                readerSettings = f_1634_11161_11184()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 11199, 11238);

                readerSettings.CheckCharacters = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 11252, 11289);

                readerSettings.IgnoreComments = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 11303, 11354);

                readerSettings.IgnoreProcessingInstructions = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 11368, 11415);

                readerSettings.MaxCharactersInDocument = 10000;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 11429, 11489);

                readerSettings.ConformanceLevel = ConformanceLevel.Fragment;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 11622, 13239);
                using (XmlReader
                reader = f_1634_11648_11724(f_1634_11665_11707(initializationParameters), readerSettings)
                )
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 11821, 13224) || true) && (f_1634_11825_11868(reader, INITPARAMETERSTOKEN))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 11821, 13224);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 11910, 11966);

                        bool
                        isParamFound = f_1634_11930_11965(reader, PARAMTOKEN)
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 11988, 13205) || true) && (isParamFound)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 11988, 13205);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 12057, 12405) || true) && (!f_1634_12062_12095(reader, NAMETOKEN))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 12057, 12405);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 12153, 12378);

                                    throw f_1634_12159_12377(initializationParameters, f_1634_12253_12308(), NAMETOKEN, VALUETOKEN, PARAMTOKEN);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 12057, 12405);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 12433, 12466);

                                string
                                optionName = f_1634_12453_12465(reader)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 12494, 12923) || true) && (!f_1634_12499_12533(reader, VALUETOKEN))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 12494, 12923);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 12591, 12896);

                                    throw f_1634_12597_12895(initializationParameters, f_1634_12731_12786(), NAMETOKEN, VALUETOKEN, PARAMTOKEN);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 12494, 12923);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 12951, 12985);

                                string
                                optionValue = f_1634_12972_12984(reader)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 13011, 13050);

                                f_1634_13011_13049(result, optionName, optionValue);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 13132, 13182);

                                isParamFound = f_1634_13147_13181(reader, PARAMTOKEN);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 11988, 13205);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 11988, 13205);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 11988, 13205);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 11821, 13224);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1634, 11622, 13239);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 13318, 13489) || true) && (result.MaxReceivedObjectSizeMB == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 13318, 13489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 13394, 13474);

                    result.MaxReceivedObjectSizeMB = BaseTransportManager.MaximumReceivedObjectSize;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 13318, 13489);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 13505, 13676) || true) && (result.MaxReceivedCommandSizeMB == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 13505, 13676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 13582, 13661);

                    result.MaxReceivedCommandSizeMB = BaseTransportManager.MaximumReceivedDataSize;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 13505, 13676);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 13692, 13706);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 10813, 13717);

                System.Management.Automation.Remoting.ConfigurationDataFromXML
                f_1634_10952_10982()
                {
                    var return_v = new System.Management.Automation.Remoting.ConfigurationDataFromXML();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 10952, 10982);
                    return return_v;
                }


                bool
                f_1634_11001_11047(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 11001, 11047);
                    return return_v;
                }


                System.Xml.XmlReaderSettings
                f_1634_11161_11184()
                {
                    var return_v = new System.Xml.XmlReaderSettings();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 11161, 11184);
                    return return_v;
                }


                System.IO.StringReader
                f_1634_11665_11707(string
                s)
                {
                    var return_v = new System.IO.StringReader(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 11665, 11707);
                    return return_v;
                }


                System.Xml.XmlReader
                f_1634_11648_11724(System.IO.StringReader
                input, System.Xml.XmlReaderSettings
                settings)
                {
                    var return_v = XmlReader.Create((System.IO.TextReader)input, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 11648, 11724);
                    return return_v;
                }


                bool
                f_1634_11825_11868(System.Xml.XmlReader
                this_param, string
                name)
                {
                    var return_v = this_param.ReadToFollowing(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 11825, 11868);
                    return return_v;
                }


                bool
                f_1634_11930_11965(System.Xml.XmlReader
                this_param, string
                name)
                {
                    var return_v = this_param.ReadToDescendant(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 11930, 11965);
                    return return_v;
                }


                bool
                f_1634_12062_12095(System.Xml.XmlReader
                this_param, string
                name)
                {
                    var return_v = this_param.MoveToAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 12062, 12095);
                    return return_v;
                }


                string
                f_1634_12253_12308()
                {
                    var return_v = RemotingErrorIdStrings.NoAttributesFoundForParamElement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 12253, 12308);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1634_12159_12377(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 12159, 12377);
                    return return_v;
                }


                string
                f_1634_12453_12465(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 12453, 12465);
                    return return_v;
                }


                bool
                f_1634_12499_12533(System.Xml.XmlReader
                this_param, string
                name)
                {
                    var return_v = this_param.MoveToAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 12499, 12533);
                    return return_v;
                }


                string
                f_1634_12731_12786()
                {
                    var return_v = RemotingErrorIdStrings.NoAttributesFoundForParamElement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 12731, 12786);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1634_12597_12895(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 12597, 12895);
                    return return_v;
                }


                string
                f_1634_12972_12984(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 12972, 12984);
                    return return_v;
                }


                int
                f_1634_13011_13049(System.Management.Automation.Remoting.ConfigurationDataFromXML
                this_param, string
                optionName, string
                optionValue)
                {
                    this_param.Update(optionName, optionValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 13011, 13049);
                    return 0;
                }


                bool
                f_1634_13147_13181(System.Xml.XmlReader
                this_param, string
                name)
                {
                    var return_v = this_param.ReadToFollowing(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 13147, 13181);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 10813, 13717);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 10813, 13717);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PSSessionConfiguration CreateEndPointConfigurationInstance()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1634, 13976, 14923);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 14106, 14189);

                    return (PSSessionConfiguration)f_1634_14137_14188(EndPointConfigurationType);
                }
                catch (TypeLoadException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 14218, 14273);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 14218, 14273);
                }
                catch (ArgumentException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 14287, 14342);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 14287, 14342);
                }
                catch (MissingMethodException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 14356, 14416);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 14356, 14416);
                }
                catch (InvalidCastException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 14430, 14488);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 14430, 14488);
                }
                catch (TargetInvocationException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 14502, 14565);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 14502, 14565);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 14718, 14912);

                throw f_1634_14724_14911("typeToLoad", f_1634_14773_14812(), EndPointConfigurationTypeName, ConfigurationDataFromXML.INITPARAMETERSTOKEN);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1634, 13976, 14923);

                object?
                f_1634_14137_14188(System.Type
                type)
                {
                    var return_v = Activator.CreateInstance(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 14137, 14188);
                    return return_v;
                }


                string
                f_1634_14773_14812()
                {
                    var return_v = RemotingErrorIdStrings.UnableToLoadType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 14773, 14812);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1634_14724_14911(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 14724, 14911);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 13976, 14923);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 13976, 14923);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ConfigurationDataFromXML()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1634, 958, 14930);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 2633, 2646);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 2751, 2794);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 2821, 2836);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 2863, 2875);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 2902, 2931);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 2956, 2981);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 3006, 3029);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 3054, 3078);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 3194, 3212);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 3248, 3273);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 3320, 3344);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 3371, 3385);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1634, 958, 14930);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 958, 14930);
        }


        static ConfigurationDataFromXML()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1634, 958, 14930);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 1076, 1124);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 1157, 1177);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 1210, 1228);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 1261, 1281);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 1314, 1346);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 1379, 1409);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 1442, 1497);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 1530, 1566);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 1599, 1652);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 1685, 1748);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 1781, 1842);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 1875, 1946);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 1979, 2024);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 2057, 2110);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 2143, 2190);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 2223, 2251);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 2284, 2318);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 2351, 2386);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 2419, 2440);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 2473, 2506);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 2539, 2582);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1634, 958, 14930);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 958, 14930);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1634, 958, 14930);
    }
    public abstract class PSSessionConfiguration : IDisposable
    {
        [TraceSourceAttribute("ServerRemoteSession", "ServerRemoteSession")]
        private static readonly PSTraceSource s_tracer;

        public abstract InitialSessionState GetInitialSessionState(PSSenderInfo senderInfo);

        public virtual InitialSessionState GetInitialSessionState(PSSessionConfigurationData sessionConfigurationData,
                    PSSenderInfo senderInfo, string configProviderId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1634, 16253, 16498);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 16451, 16487);

                throw f_1634_16457_16486();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1634, 16253, 16498);

                System.NotImplementedException
                f_1634_16457_16486()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 16457, 16486);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 16253, 16498);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 16253, 16498);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual int? GetMaximumReceivedObjectSize(PSSenderInfo senderInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1634, 16879, 17042);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 16977, 17031);

                return BaseTransportManager.MaximumReceivedObjectSize;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1634, 16879, 17042);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 16879, 17042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 16879, 17042);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual int? GetMaximumReceivedDataSizePerCommand(PSSenderInfo senderInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1634, 17448, 17617);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 17554, 17606);

                return BaseTransportManager.MaximumReceivedDataSize;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1634, 17448, 17617);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 17448, 17617);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 17448, 17617);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual PSPrimitiveDictionary GetApplicationPrivateData(PSSenderInfo senderInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1634, 18344, 18479);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 18456, 18468);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1634, 18344, 18479);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 18344, 18479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 18344, 18479);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1634, 18773, 18884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 18819, 18833);

                f_1634_18819_18832(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 18847, 18873);

                f_1634_18847_18872(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1634, 18773, 18884);

                int
                f_1634_18819_18832(System.Management.Automation.Remoting.PSSessionConfiguration
                this_param, bool
                isDisposing)
                {
                    this_param.Dispose(isDisposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 18819, 18832);
                    return 0;
                }


                int
                f_1634_18847_18872(System.Management.Automation.Remoting.PSSessionConfiguration
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 18847, 18872);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 18773, 18884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 18773, 18884);
            }
        }

        protected virtual void Dispose(bool isDisposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1634, 18991, 19061);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1634, 18991, 19061);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 18991, 19061);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 18991, 19061);
            }
        }

        internal static ConfigurationDataFromXML LoadEndPointConfiguration(string shellId,
                    string initializationParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 19945, 20712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 20098, 20141);

                ConfigurationDataFromXML
                configData = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 20157, 20324) || true) && (!f_1634_20162_20219(s_ssnStateProviders, initializationParameters))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 20157, 20324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 20253, 20309);

                    f_1634_20253_20308(shellId, initializationParameters);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 20157, 20324);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 20346, 20358);

                lock (s_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 20392, 20652) || true) && (!f_1634_20397_20470(s_ssnStateProviders, initializationParameters, out configData))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 20392, 20652);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 20512, 20633);

                        throw f_1634_20518_20632(f_1634_20561_20622(), shellId);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 20392, 20652);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 20683, 20701);

                return configData;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 19945, 20712);

                bool
                f_1634_20162_20219(System.Collections.Generic.Dictionary<string, System.Management.Automation.Remoting.ConfigurationDataFromXML>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 20162, 20219);
                    return return_v;
                }


                int
                f_1634_20253_20308(string
                shellId, string
                initializationParameters)
                {
                    LoadRSConfigProvider(shellId, initializationParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 20253, 20308);
                    return 0;
                }


                bool
                f_1634_20397_20470(System.Collections.Generic.Dictionary<string, System.Management.Automation.Remoting.ConfigurationDataFromXML>
                this_param, string
                key, out System.Management.Automation.Remoting.ConfigurationDataFromXML
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 20397, 20470);
                    return return_v;
                }


                string
                f_1634_20561_20622()
                {
                    var return_v = RemotingErrorIdStrings.NonExistentInitialSessionStateProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 20561, 20622);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1634_20518_20632(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 20518, 20632);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 19945, 20712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 19945, 20712);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void LoadRSConfigProvider(string shellId, string initializationParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 20724, 21601);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 20838, 20934);

                ConfigurationDataFromXML
                configData = f_1634_20876_20933(initializationParameters)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 20950, 21154);

                Type
                endPointConfigType = f_1634_20976_21153(shellId, configData.ApplicationBase, configData.AssemblyName, configData.EndPointConfigurationTypeName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 21168, 21252);

                f_1634_21168_21251(endPointConfigType != null, "EndPointConfiguration type cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 21266, 21324);

                configData.EndPointConfigurationType = endPointConfigType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 21344, 21356);
                lock (s_syncObject)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 21390, 21575) || true) && (!f_1634_21395_21452(s_ssnStateProviders, initializationParameters))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 21390, 21575);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 21494, 21556);

                        f_1634_21494_21555(s_ssnStateProviders, initializationParameters, configData);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 21390, 21575);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 20724, 21601);

                System.Management.Automation.Remoting.ConfigurationDataFromXML
                f_1634_20876_20933(string
                initializationParameters)
                {
                    var return_v = ConfigurationDataFromXML.Create(initializationParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 20876, 20933);
                    return return_v;
                }


                System.Type
                f_1634_20976_21153(string
                shellId, string
                applicationBase, string
                assemblyName, string
                typeToLoad)
                {
                    var return_v = LoadAndAnalyzeAssembly(shellId, applicationBase, assemblyName, typeToLoad);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 20976, 21153);
                    return return_v;
                }


                int
                f_1634_21168_21251(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 21168, 21251);
                    return 0;
                }


                bool
                f_1634_21395_21452(System.Collections.Generic.Dictionary<string, System.Management.Automation.Remoting.ConfigurationDataFromXML>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 21395, 21452);
                    return return_v;
                }


                int
                f_1634_21494_21555(System.Collections.Generic.Dictionary<string, System.Management.Automation.Remoting.ConfigurationDataFromXML>
                this_param, string
                key, System.Management.Automation.Remoting.ConfigurationDataFromXML
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 21494, 21555);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 20724, 21601);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 20724, 21601);
            }
        }

        private static Type LoadAndAnalyzeAssembly(string shellId, string applicationBase,
                    string assemblyName, string typeToLoad)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 22260, 25558);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 22420, 22928) || true) && ((f_1634_22425_22459(assemblyName) && (DynAbs.Tracing.TraceSender.Expression_True(1634, 22425, 22496) && !f_1634_22464_22496(typeToLoad))) || (DynAbs.Tracing.TraceSender.Expression_False(1634, 22424, 22592) || (!f_1634_22521_22555(assemblyName) && (DynAbs.Tracing.TraceSender.Expression_True(1634, 22520, 22591) && f_1634_22559_22591(typeToLoad)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 22420, 22928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 22626, 22913);

                    throw f_1634_22632_22912(f_1634_22675_22715(), ConfigurationDataFromXML.ASSEMBLYTOKEN, ConfigurationDataFromXML.SHELLCONFIGTYPETOKEN, ConfigurationDataFromXML.INITPARAMETERSTOKEN);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 22420, 22928);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 22944, 22969);

                Assembly
                assembly = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 22983, 23663) || true) && (!f_1634_22988_23022(assemblyName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 22983, 23663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 23056, 23271);

                    f_1634_23056_23270(PSEventId.LoadingPSCustomShellAssembly, PSOpcode.Connect, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, assemblyName, shellId);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 23291, 23362);

                    assembly = f_1634_23302_23361(applicationBase, assemblyName);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 23380, 23648) || true) && (assembly == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 23380, 23648);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 23442, 23629);

                        throw f_1634_23448_23628("assemblyName", f_1634_23499_23542(), assemblyName, ConfigurationDataFromXML.INITPARAMETERSTOKEN);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 23380, 23648);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 22983, 23663);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 23751, 25363) || true) && (assembly != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 23751, 25363);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 23849, 24066);

                        f_1634_23849_24065(PSEventId.LoadingPSCustomShellType, PSOpcode.Connect, PSTask.None, PSKeyword.Transport | PSKeyword.UseAlwaysAnalytic, typeToLoad, shellId);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 24090, 24143);

                        Type
                        type = f_1634_24102_24142(assembly, typeToLoad, true, true)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 24165, 24437) || true) && (type == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 24165, 24437);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 24231, 24414);

                            throw f_1634_24237_24413("typeToLoad", f_1634_24286_24325(), typeToLoad, ConfigurationDataFromXML.INITPARAMETERSTOKEN);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 24165, 24437);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 24461, 24473);

                        return type;
                    }
                    catch (ReflectionTypeLoadException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 24510, 24583);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 24510, 24583);
                    }
                    catch (TypeLoadException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 24601, 24664);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 24601, 24664);
                    }
                    catch (ArgumentException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 24682, 24745);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 24682, 24745);
                    }
                    catch (MissingMethodException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 24763, 24831);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 24763, 24831);
                    }
                    catch (InvalidCastException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 24849, 24915);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 24849, 24915);
                    }
                    catch (TargetInvocationException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 24933, 25004);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 24933, 25004);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 25169, 25348);

                    throw f_1634_25175_25347("typeToLoad", f_1634_25224_25263(), typeToLoad, ConfigurationDataFromXML.INITPARAMETERSTOKEN);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 23751, 25363);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 25495, 25547);

                return typeof(DefaultRemotePowerShellConfiguration);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 22260, 25558);

                bool
                f_1634_22425_22459(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 22425, 22459);
                    return return_v;
                }


                bool
                f_1634_22464_22496(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 22464, 22496);
                    return return_v;
                }


                bool
                f_1634_22521_22555(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 22521, 22555);
                    return return_v;
                }


                bool
                f_1634_22559_22591(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 22559, 22591);
                    return return_v;
                }


                string
                f_1634_22675_22715()
                {
                    var return_v = RemotingErrorIdStrings.TypeNeedsAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 22675, 22715);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1634_22632_22912(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 22632, 22912);
                    return return_v;
                }


                bool
                f_1634_22988_23022(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 22988, 23022);
                    return return_v;
                }


                int
                f_1634_23056_23270(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticVerbose(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 23056, 23270);
                    return 0;
                }


                System.Reflection.Assembly
                f_1634_23302_23361(string
                applicationBase, string
                assemblyName)
                {
                    var return_v = LoadSsnStateProviderAssembly(applicationBase, assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 23302, 23361);
                    return return_v;
                }


                string
                f_1634_23499_23542()
                {
                    var return_v = RemotingErrorIdStrings.UnableToLoadAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 23499, 23542);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1634_23448_23628(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 23448, 23628);
                    return return_v;
                }


                int
                f_1634_23849_24065(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticVerbose(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 23849, 24065);
                    return 0;
                }


                System.Type?
                f_1634_24102_24142(System.Reflection.Assembly
                this_param, string
                name, bool
                throwOnError, bool
                ignoreCase)
                {
                    var return_v = this_param.GetType(name, throwOnError, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 24102, 24142);
                    return return_v;
                }


                string
                f_1634_24286_24325()
                {
                    var return_v = RemotingErrorIdStrings.UnableToLoadType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 24286, 24325);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1634_24237_24413(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 24237, 24413);
                    return return_v;
                }


                string
                f_1634_25224_25263()
                {
                    var return_v = RemotingErrorIdStrings.UnableToLoadType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 25224, 25263);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1634_25175_25347(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 25175, 25347);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 22260, 25558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 22260, 25558);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", MessageId = "System.Reflection.Assembly.LoadFrom")]
        private static Assembly LoadSsnStateProviderAssembly(string applicationBase, string assemblyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 26106, 31362);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 26372, 26452);

                f_1634_26372_26451(!f_1634_26384_26418(assemblyName), "AssemblyName cannot be null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 26468, 26508);

                string
                originalDirectory = string.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 26524, 28374) || true) && (!f_1634_26529_26566(applicationBase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 26524, 28374);
                    // changing current working directory allows CLR loader to load dependent assemblies
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 26746, 26798);

                        originalDirectory = f_1634_26766_26797();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 26820, 26867);

                        f_1634_26820_26866(applicationBase);
                    }
                    catch (ArgumentException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 26904, 27126);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 26972, 27107);

                        f_1634_26972_27106(s_tracer, "Not able to change current working directory to {0}: {1}", applicationBase, f_1634_27096_27105(e));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 26904, 27126);
                    }
                    catch (PathTooLongException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 27144, 27372);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 27215, 27353);

                        f_1634_27215_27352(s_tracer, "Not able to change current working directory to {0}: {1}", applicationBase, f_1634_27342_27351(e));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 27144, 27372);
                    }
                    catch (FileNotFoundException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 27390, 27616);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 27462, 27597);

                        f_1634_27462_27596(s_tracer, "Not able to change current working directory to {0}: {1}", applicationBase, f_1634_27586_27595(e));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 27390, 27616);
                    }
                    catch (IOException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 27634, 27850);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 27696, 27831);

                        f_1634_27696_27830(s_tracer, "Not able to change current working directory to {0}: {1}", applicationBase, f_1634_27820_27829(e));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 27634, 27850);
                    }
                    catch (System.Security.SecurityException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 27868, 28109);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 27952, 28090);

                        f_1634_27952_28089(s_tracer, "Not able to change current working directory to {0}: {1}", applicationBase, f_1634_28079_28088(e));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 27868, 28109);
                    }
                    catch (UnauthorizedAccessException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 28127, 28359);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 28205, 28340);

                        f_1634_28205_28339(s_tracer, "Not able to change current working directory to {0}: {1}", applicationBase, f_1634_28329_28338(e));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 28127, 28359);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 26524, 28374);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 28549, 28572);

                Assembly
                result = null
                ;
                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 28666, 28721);

                        result = f_1634_28675_28720(f_1634_28689_28719(assemblyName));
                    }
                    catch (FileLoadException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 28758, 28930);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 28826, 28911);

                        f_1634_28826_28910(s_tracer, "Not able to load assembly {0}: {1}", assemblyName, f_1634_28900_28909(e));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 28758, 28930);
                    }
                    catch (BadImageFormatException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 28948, 29126);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 29022, 29107);

                        f_1634_29022_29106(s_tracer, "Not able to load assembly {0}: {1}", assemblyName, f_1634_29096_29105(e));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 28948, 29126);
                    }
                    catch (FileNotFoundException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 29144, 29320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 29216, 29301);

                        f_1634_29216_29300(s_tracer, "Not able to load assembly {0}: {1}", assemblyName, f_1634_29290_29299(e));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 29144, 29320);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 29340, 29433) || true) && (result != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 29340, 29433);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 29400, 29414);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 29340, 29433);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 29453, 29523);

                    f_1634_29453_29522(
                                    s_tracer, "Loading assembly from path {0}", applicationBase);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 29585, 29605);

                        string
                        assemblyPath
                        = default(string);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 29627, 30334) || true) && (!f_1634_29632_29663(assemblyName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 29627, 30334);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 29713, 30125) || true) && (!f_1634_29718_29755(applicationBase) && (DynAbs.Tracing.TraceSender.Expression_True(1634, 29717, 29792) && f_1634_29759_29792(applicationBase)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 29713, 30125);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 29850, 29909);

                                assemblyPath = f_1634_29865_29908(applicationBase, assemblyName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 29713, 30125);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 29713, 30125);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 30023, 30098);

                                assemblyPath = f_1634_30038_30097(f_1634_30051_30082(), assemblyName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 29713, 30125);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 29627, 30334);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 29627, 30334);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 30283, 30311);

                            assemblyPath = assemblyName;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 29627, 30334);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 30358, 30399);

                        result = f_1634_30367_30398(assemblyPath);
                    }
                    catch (FileLoadException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 30436, 30608);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 30504, 30589);

                        f_1634_30504_30588(s_tracer, "Not able to load assembly {0}: {1}", assemblyName, f_1634_30578_30587(e));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 30436, 30608);
                    }
                    catch (BadImageFormatException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 30626, 30804);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 30700, 30785);

                        f_1634_30700_30784(s_tracer, "Not able to load assembly {0}: {1}", assemblyName, f_1634_30774_30783(e));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 30626, 30804);
                    }
                    catch (FileNotFoundException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 30822, 30998);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 30894, 30979);

                        f_1634_30894_30978(s_tracer, "Not able to load assembly {0}: {1}", assemblyName, f_1634_30968_30977(e));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 30822, 30998);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1634, 31027, 31321);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 31067, 31306) || true) && (!f_1634_31072_31109(applicationBase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 31067, 31306);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 31238, 31287);

                        f_1634_31238_31286(originalDirectory);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 31067, 31306);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1634, 31027, 31321);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 31337, 31351);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 26106, 31362);

                bool
                f_1634_26384_26418(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 26384, 26418);
                    return return_v;
                }


                int
                f_1634_26372_26451(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 26372, 26451);
                    return 0;
                }


                bool
                f_1634_26529_26566(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 26529, 26566);
                    return return_v;
                }


                string
                f_1634_26766_26797()
                {
                    var return_v = Directory.GetCurrentDirectory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 26766, 26797);
                    return return_v;
                }


                int
                f_1634_26820_26866(string
                path)
                {
                    Directory.SetCurrentDirectory(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 26820, 26866);
                    return 0;
                }


                string
                f_1634_27096_27105(System.ArgumentException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 27096, 27105);
                    return return_v;
                }


                int
                f_1634_26972_27106(System.Management.Automation.PSTraceSource
                this_param, string
                warningMessageFormat, params object[]
                args)
                {
                    this_param.TraceWarning(warningMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 26972, 27106);
                    return 0;
                }


                string
                f_1634_27342_27351(System.IO.PathTooLongException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 27342, 27351);
                    return return_v;
                }


                int
                f_1634_27215_27352(System.Management.Automation.PSTraceSource
                this_param, string
                warningMessageFormat, params object[]
                args)
                {
                    this_param.TraceWarning(warningMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 27215, 27352);
                    return 0;
                }


                string
                f_1634_27586_27595(System.IO.FileNotFoundException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 27586, 27595);
                    return return_v;
                }


                int
                f_1634_27462_27596(System.Management.Automation.PSTraceSource
                this_param, string
                warningMessageFormat, params object[]
                args)
                {
                    this_param.TraceWarning(warningMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 27462, 27596);
                    return 0;
                }


                string
                f_1634_27820_27829(System.IO.IOException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 27820, 27829);
                    return return_v;
                }


                int
                f_1634_27696_27830(System.Management.Automation.PSTraceSource
                this_param, string
                warningMessageFormat, params object[]
                args)
                {
                    this_param.TraceWarning(warningMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 27696, 27830);
                    return 0;
                }


                string
                f_1634_28079_28088(System.Security.SecurityException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 28079, 28088);
                    return return_v;
                }


                int
                f_1634_27952_28089(System.Management.Automation.PSTraceSource
                this_param, string
                warningMessageFormat, params object[]
                args)
                {
                    this_param.TraceWarning(warningMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 27952, 28089);
                    return 0;
                }


                string
                f_1634_28329_28338(System.UnauthorizedAccessException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 28329, 28338);
                    return return_v;
                }


                int
                f_1634_28205_28339(System.Management.Automation.PSTraceSource
                this_param, string
                warningMessageFormat, params object[]
                args)
                {
                    this_param.TraceWarning(warningMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 28205, 28339);
                    return 0;
                }


                System.Reflection.AssemblyName
                f_1634_28689_28719(string
                assemblyName)
                {
                    var return_v = new System.Reflection.AssemblyName(assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 28689, 28719);
                    return return_v;
                }


                System.Reflection.Assembly
                f_1634_28675_28720(System.Reflection.AssemblyName
                assemblyRef)
                {
                    var return_v = Assembly.Load(assemblyRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 28675, 28720);
                    return return_v;
                }


                string
                f_1634_28900_28909(System.IO.FileLoadException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 28900, 28909);
                    return return_v;
                }


                int
                f_1634_28826_28910(System.Management.Automation.PSTraceSource
                this_param, string
                warningMessageFormat, params object[]
                args)
                {
                    this_param.TraceWarning(warningMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 28826, 28910);
                    return 0;
                }


                string
                f_1634_29096_29105(System.BadImageFormatException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 29096, 29105);
                    return return_v;
                }


                int
                f_1634_29022_29106(System.Management.Automation.PSTraceSource
                this_param, string
                warningMessageFormat, params object[]
                args)
                {
                    this_param.TraceWarning(warningMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 29022, 29106);
                    return 0;
                }


                string
                f_1634_29290_29299(System.IO.FileNotFoundException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 29290, 29299);
                    return return_v;
                }


                int
                f_1634_29216_29300(System.Management.Automation.PSTraceSource
                this_param, string
                warningMessageFormat, params object[]
                args)
                {
                    this_param.TraceWarning(warningMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 29216, 29300);
                    return 0;
                }


                int
                f_1634_29453_29522(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 29453, 29522);
                    return 0;
                }


                bool
                f_1634_29632_29663(string
                path)
                {
                    var return_v = Path.IsPathRooted(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 29632, 29663);
                    return return_v;
                }


                bool
                f_1634_29718_29755(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 29718, 29755);
                    return return_v;
                }


                bool
                f_1634_29759_29792(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 29759, 29792);
                    return return_v;
                }


                string
                f_1634_29865_29908(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 29865, 29908);
                    return return_v;
                }


                string
                f_1634_30051_30082()
                {
                    var return_v = Directory.GetCurrentDirectory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 30051, 30082);
                    return return_v;
                }


                string
                f_1634_30038_30097(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 30038, 30097);
                    return return_v;
                }


                System.Reflection.Assembly
                f_1634_30367_30398(string
                assemblyFile)
                {
                    var return_v = Assembly.LoadFrom(assemblyFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 30367, 30398);
                    return return_v;
                }


                string
                f_1634_30578_30587(System.IO.FileLoadException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 30578, 30587);
                    return return_v;
                }


                int
                f_1634_30504_30588(System.Management.Automation.PSTraceSource
                this_param, string
                warningMessageFormat, params object[]
                args)
                {
                    this_param.TraceWarning(warningMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 30504, 30588);
                    return 0;
                }


                string
                f_1634_30774_30783(System.BadImageFormatException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 30774, 30783);
                    return return_v;
                }


                int
                f_1634_30700_30784(System.Management.Automation.PSTraceSource
                this_param, string
                warningMessageFormat, params object[]
                args)
                {
                    this_param.TraceWarning(warningMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 30700, 30784);
                    return 0;
                }


                string
                f_1634_30968_30977(System.IO.FileNotFoundException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 30968, 30977);
                    return return_v;
                }


                int
                f_1634_30894_30978(System.Management.Automation.PSTraceSource
                this_param, string
                warningMessageFormat, params object[]
                args)
                {
                    this_param.TraceWarning(warningMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 30894, 30978);
                    return 0;
                }


                bool
                f_1634_31072_31109(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 31072, 31109);
                    return return_v;
                }


                int
                f_1634_31238_31286(string
                path)
                {
                    Directory.SetCurrentDirectory(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 31238, 31286);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 26106, 31362);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 26106, 31362);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static RegistryKey GetConfigurationProvidersRegistryKey()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 31503, 32160);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 31629, 31689);

                    RegistryKey
                    monadRootKey = f_1634_31656_31688()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 31707, 31812);

                    RegistryKey
                    versionRoot = f_1634_31733_31811(monadRootKey, f_1634_31780_31810())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 31830, 31909);

                    RegistryKey
                    configProviderKey = f_1634_31862_31908(versionRoot, configProvidersKeyName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 31927, 31952);

                    return configProviderKey;
                }
                catch (ArgumentException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 31981, 32036);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 31981, 32036);
                }
                catch (System.Security.SecurityException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 32050, 32121);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 32050, 32121);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 32137, 32149);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 31503, 32160);

                Microsoft.Win32.RegistryKey
                f_1634_31656_31688()
                {
                    var return_v = PSSnapInReader.GetMonadRootKey();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 31656, 31688);
                    return return_v;
                }


                string
                f_1634_31780_31810()
                {
                    var return_v = Utils.GetCurrentMajorVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 31780, 31810);
                    return return_v;
                }


                Microsoft.Win32.RegistryKey
                f_1634_31733_31811(Microsoft.Win32.RegistryKey
                rootKey, string
                psVersion)
                {
                    var return_v = PSSnapInReader.GetVersionRootKey(rootKey, psVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 31733, 31811);
                    return return_v;
                }


                Microsoft.Win32.RegistryKey
                f_1634_31862_31908(Microsoft.Win32.RegistryKey
                this_param, string
                name)
                {
                    var return_v = this_param.OpenSubKey(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 31862, 31908);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 31503, 32160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 31503, 32160);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string
                ReadStringValue(RegistryKey registryKey, string name, bool mandatory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 33062, 34266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 33187, 33272);

                f_1634_33187_33271(!f_1634_33199_33225(name), "caller should validate the name parameter");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 33286, 33370);

                f_1634_33286_33369(registryKey != null, "Caller should validate the registryKey parameter");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 33386, 33428);

                object
                value = f_1634_33401_33427(registryKey, name)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 33442, 33799) || true) && (value == null && (DynAbs.Tracing.TraceSender.Expression_True(1634, 33446, 33480) && mandatory == true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 33442, 33799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 33514, 33644);

                    f_1634_33514_33643(s_tracer, "Mandatory property {0} not specified for registry key {1}", name, f_1634_33626_33642(registryKey));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 33662, 33784);

                    throw f_1634_33668_33783("name", f_1634_33711_33758(), name, f_1634_33766_33782(registryKey));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 33442, 33799);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 33815, 33842);

                string
                s = value as string
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 33856, 34230) || true) && (f_1634_33860_33883(s) && (DynAbs.Tracing.TraceSender.Expression_True(1634, 33860, 33904) && mandatory == true))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 33856, 34230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 33938, 34067);

                    f_1634_33938_34066(s_tracer, "Value is null or empty for mandatory property {0} in {1}", name, f_1634_34049_34065(registryKey));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 34085, 34215);

                    throw f_1634_34091_34214("name", f_1634_34134_34189(), name, f_1634_34197_34213(registryKey));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 33856, 34230);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 34246, 34255);

                return s;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 33062, 34266);

                bool
                f_1634_33199_33225(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 33199, 33225);
                    return return_v;
                }


                int
                f_1634_33187_33271(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 33187, 33271);
                    return 0;
                }


                int
                f_1634_33286_33369(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 33286, 33369);
                    return 0;
                }


                object
                f_1634_33401_33427(Microsoft.Win32.RegistryKey
                this_param, string
                name)
                {
                    var return_v = this_param.GetValue(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 33401, 33427);
                    return return_v;
                }


                string
                f_1634_33626_33642(Microsoft.Win32.RegistryKey
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 33626, 33642);
                    return return_v;
                }


                int
                f_1634_33514_33643(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 33514, 33643);
                    return 0;
                }


                string
                f_1634_33711_33758()
                {
                    var return_v = RemotingErrorIdStrings.MandatoryValueNotPresent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 33711, 33758);
                    return return_v;
                }


                string
                f_1634_33766_33782(Microsoft.Win32.RegistryKey
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 33766, 33782);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1634_33668_33783(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 33668, 33783);
                    return return_v;
                }


                bool
                f_1634_33860_33883(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 33860, 33883);
                    return return_v;
                }


                string
                f_1634_34049_34065(Microsoft.Win32.RegistryKey
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 34049, 34065);
                    return return_v;
                }


                int
                f_1634_33938_34066(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 33938, 34066);
                    return 0;
                }


                string
                f_1634_34134_34189()
                {
                    var return_v = RemotingErrorIdStrings.MandatoryValueNotInCorrectFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 34134, 34189);
                    return return_v;
                }


                string
                f_1634_34197_34213(Microsoft.Win32.RegistryKey
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 34197, 34213);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1634_34091_34214(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 34091, 34214);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 33062, 34266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 33062, 34266);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const string
        configProvidersKeyName = "PSConfigurationProviders"
        ;

        private const string
        configProviderApplicationBaseKeyName = "ApplicationBase"
        ;

        private const string
        configProviderAssemblyNameKeyName = "AssemblyName"
        ;

        private static Dictionary<string, ConfigurationDataFromXML> s_ssnStateProviders;

        private static object s_syncObject;

        public PSSessionConfiguration()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1634, 15099, 34798);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1634, 15099, 34798);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 15099, 34798);
        }


        static PSSessionConfiguration()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1634, 15099, 34798);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 15408, 15488);
            s_tracer = f_1634_15419_15488("ServerRemoteSession", "ServerRemoteSession");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 34299, 34350);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 34382, 34438);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 34470, 34520);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 34591, 34708);
            s_ssnStateProviders = f_1634_34626_34708(f_1634_34675_34707());
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 34741, 34768);
            s_syncObject = f_1634_34756_34768();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1634, 15099, 34798);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 15099, 34798);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1634, 15099, 34798);

        static System.Management.Automation.PSTraceSource
        f_1634_15419_15488(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 15419, 15488);
            return return_v;
        }


        static System.StringComparer
        f_1634_34675_34707()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 34675, 34707);
            return return_v;
        }


        static System.Collections.Generic.Dictionary<string, System.Management.Automation.Remoting.ConfigurationDataFromXML>
        f_1634_34626_34708(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.Remoting.ConfigurationDataFromXML>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 34626, 34708);
            return return_v;
        }


        static object
        f_1634_34756_34768()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 34756, 34768);
            return return_v;
        }

    }
    internal sealed class DefaultRemotePowerShellConfiguration : PSSessionConfiguration
    {
        public override InitialSessionState GetInitialSessionState(PSSenderInfo senderInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1634, 35119, 35587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 35227, 35293);

                InitialSessionState
                result = f_1634_35256_35292()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 35367, 35546) || true) && (f_1634_35371_35398(senderInfo) != null && (DynAbs.Tracing.TraceSender.Expression_True(1634, 35371, 35490) && f_1634_35410_35490(f_1634_35410_35437(senderInfo), "MSP=7a83d074-bb86-4e52-aa3e-6cc73cc066c8")))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 35367, 35546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 35494, 35544);

                    PSSessionConfigurationData.IsServerManager = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 35367, 35546);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 35562, 35576);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1634, 35119, 35587);

                System.Management.Automation.Runspaces.InitialSessionState
                f_1634_35256_35292()
                {
                    var return_v = InitialSessionState.CreateDefault2();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 35256, 35292);
                    return return_v;
                }


                string
                f_1634_35371_35398(System.Management.Automation.Remoting.PSSenderInfo
                this_param)
                {
                    var return_v = this_param.ConnectionString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 35371, 35398);
                    return return_v;
                }


                string
                f_1634_35410_35437(System.Management.Automation.Remoting.PSSenderInfo
                this_param)
                {
                    var return_v = this_param.ConnectionString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 35410, 35437);
                    return return_v;
                }


                bool
                f_1634_35410_35490(string
                this_param, string
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 35410, 35490);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 35119, 35587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 35119, 35587);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override InitialSessionState GetInitialSessionState(PSSessionConfigurationData sessionConfigurationData, PSSenderInfo senderInfo, string configProviderId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1634, 35599, 37600);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 35785, 35900) || true) && (sessionConfigurationData == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 35785, 35900);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 35840, 35900);

                    throw f_1634_35846_35899("sessionConfigurationData");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 35785, 35900);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 35916, 36003) || true) && (senderInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 35916, 36003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 35957, 36003);

                    throw f_1634_35963_36002("senderInfo");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 35916, 36003);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 36019, 36118) || true) && (configProviderId == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 36019, 36118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 36066, 36118);

                    throw f_1634_36072_36117("configProviderId");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 36019, 36118);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 36134, 36206);

                InitialSessionState
                sessionState = f_1634_36169_36205()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 36302, 37298) || true) && (sessionConfigurationData != null && (DynAbs.Tracing.TraceSender.Expression_True(1634, 36306, 36398) && f_1634_36342_36390(sessionConfigurationData) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 36302, 37298);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 36432, 37283);
                        foreach (var module in f_1634_36455_36503_I(f_1634_36455_36503(sessionConfigurationData)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 36432, 37283);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 36545, 36579);

                            var
                            moduleName = module as string
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 36601, 37264) || true) && (moduleName != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 36601, 37264);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 36673, 36737);

                                moduleName = f_1634_36686_36736(moduleName);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 36765, 36815);

                                f_1634_36765_36814(
                                                        sessionState, new[] { moduleName });
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 36601, 37264);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 36601, 37264);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 36913, 36960);

                                var
                                moduleSpec = module as ModuleSpecification
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 36986, 37241) || true) && (moduleSpec != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 36986, 37241);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 37066, 37139);

                                    var
                                    modulesToImport = new Collection<ModuleSpecification> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => moduleSpec, 1634, 37088, 37138) }
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 37169, 37214);

                                    f_1634_37169_37213(sessionState, modulesToImport);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 36986, 37241);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 36601, 37264);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 36432, 37283);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 852);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 852);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 36302, 37298);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 37374, 37553) || true) && (f_1634_37378_37405(senderInfo) != null && (DynAbs.Tracing.TraceSender.Expression_True(1634, 37378, 37497) && f_1634_37417_37497(f_1634_37417_37444(senderInfo), "MSP=7a83d074-bb86-4e52-aa3e-6cc73cc066c8")))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 37374, 37553);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 37501, 37551);

                    PSSessionConfigurationData.IsServerManager = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 37374, 37553);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 37569, 37589);

                return sessionState;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1634, 35599, 37600);

                System.ArgumentNullException
                f_1634_35846_35899(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 35846, 35899);
                    return return_v;
                }


                System.ArgumentNullException
                f_1634_35963_36002(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 35963, 36002);
                    return return_v;
                }


                System.ArgumentNullException
                f_1634_36072_36117(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 36072, 36117);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_1634_36169_36205()
                {
                    var return_v = InitialSessionState.CreateDefault2();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 36169, 36205);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1634_36342_36390(System.Management.Automation.Remoting.PSSessionConfigurationData
                this_param)
                {
                    var return_v = this_param.ModulesToImportInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 36342, 36390);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1634_36455_36503(System.Management.Automation.Remoting.PSSessionConfigurationData
                this_param)
                {
                    var return_v = this_param.ModulesToImportInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 36455, 36503);
                    return return_v;
                }


                string
                f_1634_36686_36736(string
                name)
                {
                    var return_v = Environment.ExpandEnvironmentVariables(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 36686, 36736);
                    return return_v;
                }


                int
                f_1634_36765_36814(System.Management.Automation.Runspaces.InitialSessionState
                this_param, params string[]
                name)
                {
                    this_param.ImportPSModule(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 36765, 36814);
                    return 0;
                }


                int
                f_1634_37169_37213(System.Management.Automation.Runspaces.InitialSessionState
                this_param, System.Collections.ObjectModel.Collection<Microsoft.PowerShell.Commands.ModuleSpecification>
                modules)
                {
                    this_param.ImportPSModule((System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.ModuleSpecification>)modules);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 37169, 37213);
                    return 0;
                }


                System.Collections.Generic.List<object>
                f_1634_36455_36503_I(System.Collections.Generic.List<object>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 36455, 36503);
                    return return_v;
                }


                string
                f_1634_37378_37405(System.Management.Automation.Remoting.PSSenderInfo
                this_param)
                {
                    var return_v = this_param.ConnectionString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 37378, 37405);
                    return return_v;
                }


                string
                f_1634_37417_37444(System.Management.Automation.Remoting.PSSenderInfo
                this_param)
                {
                    var return_v = this_param.ConnectionString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 37417, 37444);
                    return return_v;
                }


                bool
                f_1634_37417_37497(string
                this_param, string
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 37417, 37497);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 35599, 37600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 35599, 37600);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public DefaultRemotePowerShellConfiguration()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1634, 34892, 37607);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1634, 34892, 37607);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 34892, 37607);
        }


        static DefaultRemotePowerShellConfiguration()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1634, 34892, 37607);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1634, 34892, 37607);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 34892, 37607);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1634, 34892, 37607);
    }


    /// <summary>
    /// Specifies type of initial session state to use. Valid values are Empty and Default.
    /// </summary>
    public enum SessionType
    {
        /// <summary>
        /// Empty session state.
        /// </summary>
        Empty,

        /// <summary>
        /// Restricted remote server.
        /// </summary>
        RestrictedRemoteServer,

        /// <summary>
        /// Default session state.
        /// </summary>
        Default
    }
    internal class ConfigTypeEntry
    {
        internal delegate bool TypeValidationCallback(string key, object obj, PSCmdlet cmdlet, string path);

        internal string Key;

        internal TypeValidationCallback ValidationCallback;

        internal ConfigTypeEntry(string key, TypeValidationCallback callback)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1634, 38627, 38796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 38418, 38421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 38464, 38482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 38721, 38736);

                this.Key = key;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 38750, 38785);

                this.ValidationCallback = callback;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1634, 38627, 38796);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 38627, 38796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 38627, 38796);
            }
        }

        static ConfigTypeEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1634, 38243, 38803);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1634, 38243, 38803);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 38243, 38803);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1634, 38243, 38803);
    }
    internal static class ConfigFileConstants
    {
        internal static readonly string AliasDefinitions;

        internal static readonly string AliasDescriptionToken;

        internal static readonly string AliasNameToken;

        internal static readonly string AliasOptionsToken;

        internal static readonly string AliasValueToken;

        internal static readonly string AssembliesToLoad;

        internal static readonly string Author;

        internal static readonly string CompanyName;

        internal static readonly string Copyright;

        internal static readonly string Description;

        internal static readonly string EnforceInputParameterValidation;

        internal static readonly string EnvironmentVariables;

        internal static readonly string ExecutionPolicy;

        internal static readonly string FormatsToProcess;

        internal static readonly string FunctionDefinitions;

        internal static readonly string FunctionNameToken;

        internal static readonly string FunctionOptionsToken;

        internal static readonly string FunctionValueToken;

        internal static readonly string GMSAAccount;

        internal static readonly string Guid;

        internal static readonly string LanguageMode;

        internal static readonly string ModulesToImport;

        internal static readonly string MountUserDrive;

        internal static readonly string PowerShellVersion;

        internal static readonly string RequiredGroups;

        internal static readonly string RoleDefinitions;

        internal static readonly string SchemaVersion;

        internal static readonly string ScriptsToProcess;

        internal static readonly string SessionType;

        internal static readonly string RoleCapabilities;

        internal static readonly string RoleCapabilityFiles;

        internal static readonly string RunAsVirtualAccount;

        internal static readonly string RunAsVirtualAccountGroups;

        internal static readonly string TranscriptDirectory;

        internal static readonly string TypesToProcess;

        internal static readonly string UserDriveMaxSize;

        internal static readonly string VariableDefinitions;

        internal static readonly string VariableNameToken;

        internal static readonly string VariableValueToken;

        internal static readonly string VisibleAliases;

        internal static readonly string VisibleCmdlets;

        internal static readonly string VisibleFunctions;

        internal static readonly string VisibleProviders;

        internal static readonly string VisibleExternalCommands;

        internal static ConfigTypeEntry[] ConfigFileKeys;

        internal static bool IsValidKey(DictionaryEntry de, PSCmdlet cmdlet, string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 47758, 48578);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 47864, 47886);

                bool
                validKey = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 47902, 48357);
                    foreach (ConfigTypeEntry configEntry in f_1634_47942_47956_I(ConfigFileKeys))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 47902, 48357);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 47990, 48342) || true) && (f_1634_47994_48079(configEntry.Key, f_1634_48025_48042(de.Key), StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 47990, 48342);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 48121, 48137);

                            validKey = true;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 48161, 48323) || true) && (f_1634_48165_48238(configEntry, f_1634_48196_48213(de.Key), de.Value, cmdlet, path))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 48161, 48323);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 48288, 48300);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 48161, 48323);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 47990, 48342);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 47902, 48357);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 456);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 456);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 48373, 48538) || true) && (!validKey)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 48373, 48538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 48420, 48523);

                    f_1634_48420_48522(cmdlet, f_1634_48440_48521(f_1634_48458_48495(), f_1634_48497_48514(de.Key), path));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 48373, 48538);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 48554, 48567);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 47758, 48578);

                string?
                f_1634_48025_48042(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 48025, 48042);
                    return return_v;
                }


                bool
                f_1634_47994_48079(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 47994, 48079);
                    return return_v;
                }


                string?
                f_1634_48196_48213(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 48196, 48213);
                    return return_v;
                }


                bool
                f_1634_48165_48238(System.Management.Automation.Remoting.ConfigTypeEntry
                this_param, string
                key, object
                obj, System.Management.Automation.PSCmdlet
                cmdlet, string
                path)
                {
                    var return_v = this_param.ValidationCallback(key, obj, cmdlet, path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 48165, 48238);
                    return return_v;
                }


                System.Management.Automation.Remoting.ConfigTypeEntry[]
                f_1634_47942_47956_I(System.Management.Automation.Remoting.ConfigTypeEntry[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 47942, 47956);
                    return return_v;
                }


                string
                f_1634_48458_48495()
                {
                    var return_v = RemotingErrorIdStrings.DISCInvalidKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 48458, 48495);
                    return return_v;
                }


                string?
                f_1634_48497_48514(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 48497, 48514);
                    return return_v;
                }


                string
                f_1634_48440_48521(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 48440, 48521);
                    return return_v;
                }


                int
                f_1634_48420_48522(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 48420, 48522);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 47758, 48578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 47758, 48578);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ISSValidationCallback(string key, object obj, PSCmdlet cmdlet, string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 48834, 49622);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 48954, 48983);

                string
                value = obj as string
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 48999, 49345) || true) && (!f_1634_49004_49031(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 48999, 49345);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 49109, 49154);

                        f_1634_49109_49153(typeof(SessionType), value, true);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 49178, 49190);

                        return true;
                    }
                    catch (ArgumentException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 49227, 49330);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 49227, 49330);
                        // Do nothing here
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 48999, 49345);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 49361, 49582);

                f_1634_49361_49581(
                            cmdlet, f_1634_49381_49580(f_1634_49399_49445(), key, f_1634_49452_49480(typeof(SessionType)), f_1634_49499_49573(typeof(SessionType)), path));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 49598, 49611);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 48834, 49622);

                bool
                f_1634_49004_49031(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 49004, 49031);
                    return return_v;
                }


                object
                f_1634_49109_49153(System.Type
                enumType, string
                value, bool
                ignoreCase)
                {
                    var return_v = Enum.Parse(enumType, value, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 49109, 49153);
                    return return_v;
                }


                string
                f_1634_49399_49445()
                {
                    var return_v = RemotingErrorIdStrings.DISCTypeMustBeValidEnum;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 49399, 49445);
                    return return_v;
                }


                string
                f_1634_49452_49480(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 49452, 49480);
                    return return_v;
                }


                string
                f_1634_49499_49573(System.Type
                enumType)
                {
                    var return_v = LanguagePrimitives.EnumSingleTypeConverter.EnumValues(enumType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 49499, 49573);
                    return return_v;
                }


                string
                f_1634_49381_49580(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 49381, 49580);
                    return return_v;
                }


                int
                f_1634_49361_49581(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 49361, 49581);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 48834, 49622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 48834, 49622);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool LanguageModeValidationCallback(string key, object obj, PSCmdlet cmdlet, string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 49878, 50684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 50007, 50036);

                string
                value = obj as string
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 50052, 50401) || true) && (!f_1634_50057_50084(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 50052, 50401);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 50162, 50210);

                        f_1634_50162_50209(typeof(PSLanguageMode), value, true);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 50234, 50246);

                        return true;
                    }
                    catch (ArgumentException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 50283, 50386);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 50283, 50386);
                        // Do nothing here
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 50052, 50401);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 50417, 50644);

                f_1634_50417_50643(
                            cmdlet, f_1634_50437_50642(f_1634_50455_50501(), key, f_1634_50508_50539(typeof(PSLanguageMode)), f_1634_50558_50635(typeof(PSLanguageMode)), path));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 50660, 50673);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 49878, 50684);

                bool
                f_1634_50057_50084(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 50057, 50084);
                    return return_v;
                }


                object
                f_1634_50162_50209(System.Type
                enumType, string
                value, bool
                ignoreCase)
                {
                    var return_v = Enum.Parse(enumType, value, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 50162, 50209);
                    return return_v;
                }


                string
                f_1634_50455_50501()
                {
                    var return_v = RemotingErrorIdStrings.DISCTypeMustBeValidEnum;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 50455, 50501);
                    return return_v;
                }


                string
                f_1634_50508_50539(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 50508, 50539);
                    return return_v;
                }


                string
                f_1634_50558_50635(System.Type
                enumType)
                {
                    var return_v = LanguagePrimitives.EnumSingleTypeConverter.EnumValues(enumType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 50558, 50635);
                    return return_v;
                }


                string
                f_1634_50437_50642(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 50437, 50642);
                    return return_v;
                }


                int
                f_1634_50417_50643(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 50417, 50643);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 49878, 50684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 49878, 50684);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ExecutionPolicyValidationCallback(string key, object obj, PSCmdlet cmdlet, string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 50940, 51770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 51072, 51101);

                string
                value = obj as string
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 51117, 51473) || true) && (!f_1634_51122_51149(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 51117, 51473);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 51227, 51282);

                        f_1634_51227_51281(DISCUtils.ExecutionPolicyType, value, true);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 51306, 51318);

                        return true;
                    }
                    catch (ArgumentException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 51355, 51458);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 51355, 51458);
                        // Do nothing here
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 51117, 51473);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 51489, 51730);

                f_1634_51489_51729(
                            cmdlet, f_1634_51509_51728(f_1634_51527_51573(), key, f_1634_51580_51618(DISCUtils.ExecutionPolicyType), f_1634_51637_51721(DISCUtils.ExecutionPolicyType), path));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 51746, 51759);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 50940, 51770);

                bool
                f_1634_51122_51149(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 51122, 51149);
                    return return_v;
                }


                object
                f_1634_51227_51281(System.Type
                enumType, string
                value, bool
                ignoreCase)
                {
                    var return_v = Enum.Parse(enumType, value, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 51227, 51281);
                    return return_v;
                }


                string
                f_1634_51527_51573()
                {
                    var return_v = RemotingErrorIdStrings.DISCTypeMustBeValidEnum;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 51527, 51573);
                    return return_v;
                }


                string
                f_1634_51580_51618(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 51580, 51618);
                    return return_v;
                }


                string
                f_1634_51637_51721(System.Type
                enumType)
                {
                    var return_v = LanguagePrimitives.EnumSingleTypeConverter.EnumValues(enumType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 51637, 51721);
                    return return_v;
                }


                string
                f_1634_51509_51728(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 51509, 51728);
                    return return_v;
                }


                int
                f_1634_51489_51729(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 51489, 51729);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 50940, 51770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 50940, 51770);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HashtableTypeValidationCallback(string key, object obj, PSCmdlet cmdlet, string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 52026, 52439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 52156, 52190);

                Hashtable
                hash = obj as Hashtable
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 52206, 52400) || true) && (hash == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 52206, 52400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 52256, 52354);

                    f_1634_52256_52353(cmdlet, f_1634_52276_52352(f_1634_52294_52340(), key, path));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 52372, 52385);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 52206, 52400);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 52416, 52428);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 52026, 52439);

                string
                f_1634_52294_52340()
                {
                    var return_v = RemotingErrorIdStrings.DISCTypeMustBeHashtable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 52294, 52340);
                    return return_v;
                }


                string
                f_1634_52276_52352(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 52276, 52352);
                    return return_v;
                }


                int
                f_1634_52256_52353(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 52256, 52353);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 52026, 52439);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 52026, 52439);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool AliasDefinitionsTypeValidationCallback(string key, object obj, PSCmdlet cmdlet, string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 52695, 54551);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 52832, 52911);

                Hashtable[]
                hashtables = f_1634_52857_52910(obj)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 52927, 53132) || true) && (hashtables == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 52927, 53132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 52983, 53086);

                    f_1634_52983_53085(cmdlet, f_1634_53003_53084(f_1634_53021_53072(), key, path));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 53104, 53117);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 52927, 53132);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 53148, 54512);
                    foreach (Hashtable hashtable in f_1634_53180_53190_I(hashtables))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 53148, 54512);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 53224, 53475) || true) && (!f_1634_53229_53266(hashtable, AliasNameToken))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 53224, 53475);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 53308, 53421);

                            f_1634_53308_53420(cmdlet, f_1634_53328_53419(f_1634_53346_53391(), key, AliasNameToken, path));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 53443, 53456);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 53224, 53475);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 53495, 53748) || true) && (!f_1634_53500_53538(hashtable, AliasValueToken))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 53495, 53748);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 53580, 53694);

                            f_1634_53580_53693(cmdlet, f_1634_53600_53692(f_1634_53618_53663(), key, AliasValueToken, path));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 53716, 53729);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 53495, 53748);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 53768, 54497);
                            foreach (string aliasKey in f_1634_53796_53810_I(f_1634_53796_53810(hashtable)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 53768, 54497);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 53852, 54478) || true) && (!f_1634_53857_53932(aliasKey, AliasNameToken, StringComparison.OrdinalIgnoreCase) && (DynAbs.Tracing.TraceSender.Expression_True(1634, 53856, 54037) && !f_1634_53961_54037(aliasKey, AliasValueToken, StringComparison.OrdinalIgnoreCase)) && (DynAbs.Tracing.TraceSender.Expression_True(1634, 53856, 54148) && !f_1634_54066_54148(aliasKey, AliasDescriptionToken, StringComparison.OrdinalIgnoreCase)) && (DynAbs.Tracing.TraceSender.Expression_True(1634, 53856, 54255) && !f_1634_54177_54255(aliasKey, AliasOptionsToken, StringComparison.OrdinalIgnoreCase)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 53852, 54478);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 54305, 54416);

                                    f_1634_54305_54415(cmdlet, f_1634_54325_54414(f_1634_54343_54392(), aliasKey, key, path));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 54442, 54455);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 53852, 54478);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 53768, 54497);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 730);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 730);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 53148, 54512);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 1365);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 1365);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 54528, 54540);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 52695, 54551);

                System.Collections.Hashtable[]
                f_1634_52857_52910(object
                hashObj)
                {
                    var return_v = DISCPowerShellConfiguration.TryGetHashtableArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 52857, 52910);
                    return return_v;
                }


                string
                f_1634_53021_53072()
                {
                    var return_v = RemotingErrorIdStrings.DISCTypeMustBeHashtableArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 53021, 53072);
                    return return_v;
                }


                string
                f_1634_53003_53084(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 53003, 53084);
                    return return_v;
                }


                int
                f_1634_52983_53085(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 52983, 53085);
                    return 0;
                }


                bool
                f_1634_53229_53266(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 53229, 53266);
                    return return_v;
                }


                string
                f_1634_53346_53391()
                {
                    var return_v = RemotingErrorIdStrings.DISCTypeMustContainKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 53346, 53391);
                    return return_v;
                }


                string
                f_1634_53328_53419(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 53328, 53419);
                    return return_v;
                }


                int
                f_1634_53308_53420(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 53308, 53420);
                    return 0;
                }


                bool
                f_1634_53500_53538(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 53500, 53538);
                    return return_v;
                }


                string
                f_1634_53618_53663()
                {
                    var return_v = RemotingErrorIdStrings.DISCTypeMustContainKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 53618, 53663);
                    return return_v;
                }


                string
                f_1634_53600_53692(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 53600, 53692);
                    return return_v;
                }


                int
                f_1634_53580_53693(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 53580, 53693);
                    return 0;
                }


                System.Collections.ICollection
                f_1634_53796_53810(System.Collections.Hashtable
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 53796, 53810);
                    return return_v;
                }


                bool
                f_1634_53857_53932(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 53857, 53932);
                    return return_v;
                }


                bool
                f_1634_53961_54037(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 53961, 54037);
                    return return_v;
                }


                bool
                f_1634_54066_54148(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 54066, 54148);
                    return return_v;
                }


                bool
                f_1634_54177_54255(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 54177, 54255);
                    return return_v;
                }


                string
                f_1634_54343_54392()
                {
                    var return_v = RemotingErrorIdStrings.DISCTypeContainsInvalidKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 54343, 54392);
                    return return_v;
                }


                string
                f_1634_54325_54414(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 54325, 54414);
                    return return_v;
                }


                int
                f_1634_54305_54415(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 54305, 54415);
                    return 0;
                }


                System.Collections.ICollection
                f_1634_53796_53810_I(System.Collections.ICollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 53796, 53810);
                    return return_v;
                }


                System.Collections.Hashtable[]
                f_1634_53180_53190_I(System.Collections.Hashtable[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 53180, 53190);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 52695, 54551);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 52695, 54551);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool FunctionDefinitionsTypeValidationCallback(string key, object obj, PSCmdlet cmdlet, string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 54807, 56886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 54947, 55026);

                Hashtable[]
                hashtables = f_1634_54972_55025(obj)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 55042, 55247) || true) && (hashtables == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 55042, 55247);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 55098, 55201);

                    f_1634_55098_55200(cmdlet, f_1634_55118_55199(f_1634_55136_55187(), key, path));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 55219, 55232);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 55042, 55247);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 55263, 56847);
                    foreach (Hashtable hashtable in f_1634_55295_55305_I(hashtables))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 55263, 56847);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 55339, 55596) || true) && (!f_1634_55344_55384(hashtable, FunctionNameToken))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 55339, 55596);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 55426, 55542);

                            f_1634_55426_55541(cmdlet, f_1634_55446_55540(f_1634_55464_55509(), key, FunctionNameToken, path));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 55564, 55577);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 55339, 55596);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 55616, 55875) || true) && (!f_1634_55621_55662(hashtable, FunctionValueToken))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 55616, 55875);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 55704, 55821);

                            f_1634_55704_55820(cmdlet, f_1634_55724_55819(f_1634_55742_55787(), key, FunctionValueToken, path));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 55843, 55856);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 55616, 55875);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 55895, 56168) || true) && ((f_1634_55900_55929(hashtable, FunctionValueToken) as ScriptBlock) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 55895, 56168);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 55995, 56114);

                            f_1634_55995_56113(cmdlet, f_1634_56015_56112(f_1634_56033_56080(), FunctionValueToken, key, path));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 56136, 56149);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 55895, 56168);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 56188, 56832);
                            foreach (string functionKey in f_1634_56219_56233_I(f_1634_56219_56233(hashtable)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 56188, 56832);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 56275, 56813) || true) && (!f_1634_56280_56361(functionKey, FunctionNameToken, StringComparison.OrdinalIgnoreCase) && (DynAbs.Tracing.TraceSender.Expression_True(1634, 56279, 56473) && !f_1634_56391_56473(functionKey, FunctionValueToken, StringComparison.OrdinalIgnoreCase)) && (DynAbs.Tracing.TraceSender.Expression_True(1634, 56279, 56587) && !f_1634_56503_56587(functionKey, FunctionOptionsToken, StringComparison.OrdinalIgnoreCase)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 56275, 56813);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 56637, 56751);

                                    f_1634_56637_56750(cmdlet, f_1634_56657_56749(f_1634_56675_56724(), functionKey, key, path));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 56777, 56790);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 56275, 56813);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 56188, 56832);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 645);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 645);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 55263, 56847);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 1585);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 1585);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 56863, 56875);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 54807, 56886);

                System.Collections.Hashtable[]
                f_1634_54972_55025(object
                hashObj)
                {
                    var return_v = DISCPowerShellConfiguration.TryGetHashtableArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 54972, 55025);
                    return return_v;
                }


                string
                f_1634_55136_55187()
                {
                    var return_v = RemotingErrorIdStrings.DISCTypeMustBeHashtableArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 55136, 55187);
                    return return_v;
                }


                string
                f_1634_55118_55199(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 55118, 55199);
                    return return_v;
                }


                int
                f_1634_55098_55200(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 55098, 55200);
                    return 0;
                }


                bool
                f_1634_55344_55384(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 55344, 55384);
                    return return_v;
                }


                string
                f_1634_55464_55509()
                {
                    var return_v = RemotingErrorIdStrings.DISCTypeMustContainKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 55464, 55509);
                    return return_v;
                }


                string
                f_1634_55446_55540(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 55446, 55540);
                    return return_v;
                }


                int
                f_1634_55426_55541(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 55426, 55541);
                    return 0;
                }


                bool
                f_1634_55621_55662(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 55621, 55662);
                    return return_v;
                }


                string
                f_1634_55742_55787()
                {
                    var return_v = RemotingErrorIdStrings.DISCTypeMustContainKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 55742, 55787);
                    return return_v;
                }


                string
                f_1634_55724_55819(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 55724, 55819);
                    return return_v;
                }


                int
                f_1634_55704_55820(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 55704, 55820);
                    return 0;
                }


                object
                f_1634_55900_55929(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 55900, 55929);
                    return return_v;
                }


                string
                f_1634_56033_56080()
                {
                    var return_v = RemotingErrorIdStrings.DISCKeyMustBeScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 56033, 56080);
                    return return_v;
                }


                string
                f_1634_56015_56112(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 56015, 56112);
                    return return_v;
                }


                int
                f_1634_55995_56113(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 55995, 56113);
                    return 0;
                }


                System.Collections.ICollection
                f_1634_56219_56233(System.Collections.Hashtable
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 56219, 56233);
                    return return_v;
                }


                bool
                f_1634_56280_56361(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 56280, 56361);
                    return return_v;
                }


                bool
                f_1634_56391_56473(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 56391, 56473);
                    return return_v;
                }


                bool
                f_1634_56503_56587(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 56503, 56587);
                    return return_v;
                }


                string
                f_1634_56675_56724()
                {
                    var return_v = RemotingErrorIdStrings.DISCTypeContainsInvalidKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 56675, 56724);
                    return return_v;
                }


                string
                f_1634_56657_56749(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 56657, 56749);
                    return return_v;
                }


                int
                f_1634_56637_56750(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 56637, 56750);
                    return 0;
                }


                System.Collections.ICollection
                f_1634_56219_56233_I(System.Collections.ICollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 56219, 56233);
                    return return_v;
                }


                System.Collections.Hashtable[]
                f_1634_55295_55305_I(System.Collections.Hashtable[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 55295, 55305);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 54807, 56886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 54807, 56886);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool VariableDefinitionsTypeValidationCallback(string key, object obj, PSCmdlet cmdlet, string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 57142, 58814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 57282, 57361);

                Hashtable[]
                hashtables = f_1634_57307_57360(obj)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 57377, 57582) || true) && (hashtables == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 57377, 57582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 57433, 57536);

                    f_1634_57433_57535(cmdlet, f_1634_57453_57534(f_1634_57471_57522(), key, path));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 57554, 57567);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 57377, 57582);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 57598, 58775);
                    foreach (Hashtable hashtable in f_1634_57630_57640_I(hashtables))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 57598, 58775);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 57674, 57931) || true) && (!f_1634_57679_57719(hashtable, VariableNameToken))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 57674, 57931);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 57761, 57877);

                            f_1634_57761_57876(cmdlet, f_1634_57781_57875(f_1634_57799_57844(), key, VariableNameToken, path));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 57899, 57912);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 57674, 57931);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 57951, 58210) || true) && (!f_1634_57956_57997(hashtable, VariableValueToken))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 57951, 58210);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 58039, 58156);

                            f_1634_58039_58155(cmdlet, f_1634_58059_58154(f_1634_58077_58122(), key, VariableValueToken, path));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 58178, 58191);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 57951, 58210);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 58230, 58760);
                            foreach (string variableKey in f_1634_58261_58275_I(f_1634_58261_58275(hashtable)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 58230, 58760);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 58317, 58741) || true) && (!f_1634_58322_58403(variableKey, VariableNameToken, StringComparison.OrdinalIgnoreCase) && (DynAbs.Tracing.TraceSender.Expression_True(1634, 58321, 58515) && !f_1634_58433_58515(variableKey, VariableValueToken, StringComparison.OrdinalIgnoreCase)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 58317, 58741);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 58565, 58679);

                                    f_1634_58565_58678(cmdlet, f_1634_58585_58677(f_1634_58603_58652(), variableKey, key, path));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 58705, 58718);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 58317, 58741);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 58230, 58760);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 531);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 531);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 57598, 58775);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 1178);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 1178);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 58791, 58803);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 57142, 58814);

                System.Collections.Hashtable[]
                f_1634_57307_57360(object
                hashObj)
                {
                    var return_v = DISCPowerShellConfiguration.TryGetHashtableArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 57307, 57360);
                    return return_v;
                }


                string
                f_1634_57471_57522()
                {
                    var return_v = RemotingErrorIdStrings.DISCTypeMustBeHashtableArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 57471, 57522);
                    return return_v;
                }


                string
                f_1634_57453_57534(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 57453, 57534);
                    return return_v;
                }


                int
                f_1634_57433_57535(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 57433, 57535);
                    return 0;
                }


                bool
                f_1634_57679_57719(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 57679, 57719);
                    return return_v;
                }


                string
                f_1634_57799_57844()
                {
                    var return_v = RemotingErrorIdStrings.DISCTypeMustContainKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 57799, 57844);
                    return return_v;
                }


                string
                f_1634_57781_57875(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 57781, 57875);
                    return return_v;
                }


                int
                f_1634_57761_57876(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 57761, 57876);
                    return 0;
                }


                bool
                f_1634_57956_57997(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 57956, 57997);
                    return return_v;
                }


                string
                f_1634_58077_58122()
                {
                    var return_v = RemotingErrorIdStrings.DISCTypeMustContainKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 58077, 58122);
                    return return_v;
                }


                string
                f_1634_58059_58154(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 58059, 58154);
                    return return_v;
                }


                int
                f_1634_58039_58155(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 58039, 58155);
                    return 0;
                }


                System.Collections.ICollection
                f_1634_58261_58275(System.Collections.Hashtable
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 58261, 58275);
                    return return_v;
                }


                bool
                f_1634_58322_58403(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 58322, 58403);
                    return return_v;
                }


                bool
                f_1634_58433_58515(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 58433, 58515);
                    return return_v;
                }


                string
                f_1634_58603_58652()
                {
                    var return_v = RemotingErrorIdStrings.DISCTypeContainsInvalidKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 58603, 58652);
                    return return_v;
                }


                string
                f_1634_58585_58677(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 58585, 58677);
                    return return_v;
                }


                int
                f_1634_58565_58678(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 58565, 58678);
                    return 0;
                }


                System.Collections.ICollection
                f_1634_58261_58275_I(System.Collections.ICollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 58261, 58275);
                    return return_v;
                }


                System.Collections.Hashtable[]
                f_1634_57630_57640_I(System.Collections.Hashtable[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 57630, 57640);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 57142, 58814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 57142, 58814);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool StringTypeValidationCallback(string key, object obj, PSCmdlet cmdlet, string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 59107, 59468);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 59234, 59429) || true) && (!(obj is string))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 59234, 59429);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 59288, 59383);

                    f_1634_59288_59382(cmdlet, f_1634_59308_59381(f_1634_59326_59369(), key, path));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 59401, 59414);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 59234, 59429);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 59445, 59457);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 59107, 59468);

                string
                f_1634_59326_59369()
                {
                    var return_v = RemotingErrorIdStrings.DISCTypeMustBeString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 59326, 59369);
                    return return_v;
                }


                string
                f_1634_59308_59381(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 59308, 59381);
                    return return_v;
                }


                int
                f_1634_59288_59382(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 59288, 59382);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 59107, 59468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 59107, 59468);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool StringArrayTypeValidationCallback(string key, object obj, PSCmdlet cmdlet, string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 59767, 60180);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 59899, 60141) || true) && (f_1634_59903_59953(obj) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 59899, 60141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 59995, 60095);

                    f_1634_59995_60094(cmdlet, f_1634_60015_60093(f_1634_60033_60081(), key, path));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 60113, 60126);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 59899, 60141);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 60157, 60169);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 59767, 60180);

                string[]
                f_1634_59903_59953(object
                hashObj)
                {
                    var return_v = DISCPowerShellConfiguration.TryGetStringArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 59903, 59953);
                    return return_v;
                }


                string
                f_1634_60033_60081()
                {
                    var return_v = RemotingErrorIdStrings.DISCTypeMustBeStringArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 60033, 60081);
                    return return_v;
                }


                string
                f_1634_60015_60093(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 60015, 60093);
                    return return_v;
                }


                int
                f_1634_59995_60094(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 59995, 60094);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 59767, 60180);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 59767, 60180);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool BooleanTypeValidationCallback(string key, object obj, PSCmdlet cmdlet, string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 60192, 60553);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 60320, 60514) || true) && (!(obj is bool))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 60320, 60514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 60372, 60468);

                    f_1634_60372_60467(cmdlet, f_1634_60392_60466(f_1634_60410_60454(), key, path));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 60486, 60499);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 60320, 60514);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 60530, 60542);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 60192, 60553);

                string
                f_1634_60410_60454()
                {
                    var return_v = RemotingErrorIdStrings.DISCTypeMustBeBoolean;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 60410, 60454);
                    return return_v;
                }


                string
                f_1634_60392_60466(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 60392, 60466);
                    return return_v;
                }


                int
                f_1634_60372_60467(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 60372, 60467);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 60192, 60553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 60192, 60553);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IntegerTypeValidationCallback(string key, object obj, PSCmdlet cmdlet, string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 60565, 60943);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 60693, 60904) || true) && (!(obj is int) && (DynAbs.Tracing.TraceSender.Expression_True(1634, 60697, 60728) && !(obj is long)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 60693, 60904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 60762, 60858);

                    f_1634_60762_60857(cmdlet, f_1634_60782_60856(f_1634_60800_60844(), key, path));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 60876, 60889);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 60693, 60904);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 60920, 60932);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 60565, 60943);

                string
                f_1634_60800_60844()
                {
                    var return_v = RemotingErrorIdStrings.DISCTypeMustBeInteger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 60800, 60844);
                    return return_v;
                }


                string
                f_1634_60782_60856(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 60782, 60856);
                    return return_v;
                }


                int
                f_1634_60762_60857(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 60762, 60857);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 60565, 60943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 60565, 60943);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool StringOrHashtableArrayTypeValidationCallback(string key, object obj, PSCmdlet cmdlet, string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 61279, 61780);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 61422, 61741) || true) && (f_1634_61426_61536(obj, new Type[] { typeof(string), typeof(Hashtable) }) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 61422, 61741);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 61578, 61695);

                    f_1634_61578_61694(cmdlet, f_1634_61598_61693(f_1634_61616_61681(), key, path));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 61713, 61726);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 61422, 61741);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 61757, 61769);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 61279, 61780);

                object[]
                f_1634_61426_61536(object
                hashObj, System.Type[]
                types)
                {
                    var return_v = DISCPowerShellConfiguration.TryGetObjectsOfType<object>(hashObj, (System.Collections.Generic.IEnumerable<System.Type>)types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 61426, 61536);
                    return return_v;
                }


                string
                f_1634_61616_61681()
                {
                    var return_v = RemotingErrorIdStrings.DISCTypeMustBeStringOrHashtableArrayInFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 61616, 61681);
                    return return_v;
                }


                string
                f_1634_61598_61693(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 61598, 61693);
                    return return_v;
                }


                int
                f_1634_61578_61694(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 61578, 61694);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 61279, 61780);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 61279, 61780);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ConfigFileConstants()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1634, 38889, 61787);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 38979, 39016);
            AliasDefinitions = "AliasDefinitions";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 39059, 39096);
            AliasDescriptionToken = "Description";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 39139, 39162);
            AliasNameToken = "Name";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 39205, 39234);
            AliasOptionsToken = "Options";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 39277, 39302);
            AliasValueToken = "Value";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 39345, 39382);
            AssembliesToLoad = "AssembliesToLoad";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 39425, 39442);
            Author = "Author";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 39485, 39512);
            CompanyName = "CompanyName";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 39555, 39578);
            Copyright = "Copyright";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 39621, 39648);
            Description = "Description";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 39691, 39758);
            EnforceInputParameterValidation = "EnforceInputParameterValidation";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 39801, 39846);
            EnvironmentVariables = "EnvironmentVariables";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 39889, 39924);
            ExecutionPolicy = "ExecutionPolicy";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 39967, 40004);
            FormatsToProcess = "FormatsToProcess";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 40047, 40090);
            FunctionDefinitions = "FunctionDefinitions";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 40133, 40159);
            FunctionNameToken = "Name";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 40202, 40234);
            FunctionOptionsToken = "Options";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 40277, 40311);
            FunctionValueToken = "ScriptBlock";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 40354, 40396);
            GMSAAccount = "GroupManagedServiceAccount";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 40439, 40452);
            Guid = "GUID";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 40495, 40524);
            LanguageMode = "LanguageMode";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 40567, 40602);
            ModulesToImport = "ModulesToImport";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 40645, 40678);
            MountUserDrive = "MountUserDrive";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 40721, 40760);
            PowerShellVersion = "PowerShellVersion";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 40803, 40836);
            RequiredGroups = "RequiredGroups";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 40879, 40914);
            RoleDefinitions = "RoleDefinitions";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 40957, 40988);
            SchemaVersion = "SchemaVersion";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 41031, 41068);
            ScriptsToProcess = "ScriptsToProcess";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 41111, 41138);
            SessionType = "SessionType";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 41181, 41218);
            RoleCapabilities = "RoleCapabilities";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 41261, 41304);
            RoleCapabilityFiles = "RoleCapabilityFiles";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 41347, 41390);
            RunAsVirtualAccount = "RunAsVirtualAccount";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 41433, 41488);
            RunAsVirtualAccountGroups = "RunAsVirtualAccountGroups";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 41531, 41574);
            TranscriptDirectory = "TranscriptDirectory";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 41617, 41650);
            TypesToProcess = "TypesToProcess";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 41693, 41734);
            UserDriveMaxSize = "UserDriveMaximumSize";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 41777, 41820);
            VariableDefinitions = "VariableDefinitions";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 41863, 41889);
            VariableNameToken = "Name";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 41932, 41960);
            VariableValueToken = "Value";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 42003, 42036);
            VisibleAliases = "VisibleAliases";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 42079, 42112);
            VisibleCmdlets = "VisibleCmdlets";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 42155, 42192);
            VisibleFunctions = "VisibleFunctions";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 42235, 42272);
            VisibleProviders = "VisibleProviders";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 42315, 42366);
            VisibleExternalCommands = "VisibleExternalCommands";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 42413, 47489);
            ConfigFileKeys = new ConfigTypeEntry[] {
f_1634_42467_42602(AliasDefinitions, new ConfigTypeEntry.TypeValidationCallback(AliasDefinitionsTypeValidationCallback)),
f_1634_42617_42747(AssembliesToLoad, new ConfigTypeEntry.TypeValidationCallback(StringArrayTypeValidationCallback)),
f_1634_42762_42887(Author, new ConfigTypeEntry.TypeValidationCallback(StringTypeValidationCallback)),
f_1634_42902_43027(CompanyName, new ConfigTypeEntry.TypeValidationCallback(StringTypeValidationCallback)),
f_1634_43042_43167(Copyright, new ConfigTypeEntry.TypeValidationCallback(StringTypeValidationCallback)),
f_1634_43182_43307(Description, new ConfigTypeEntry.TypeValidationCallback(StringTypeValidationCallback)),
f_1634_43322_43448(EnforceInputParameterValidation, new ConfigTypeEntry.TypeValidationCallback(BooleanTypeValidationCallback)),
f_1634_43463_43591(EnvironmentVariables, new ConfigTypeEntry.TypeValidationCallback(HashtableTypeValidationCallback)),
f_1634_43606_43736(ExecutionPolicy, new ConfigTypeEntry.TypeValidationCallback(ExecutionPolicyValidationCallback)),
f_1634_43751_43881(FormatsToProcess, new ConfigTypeEntry.TypeValidationCallback(StringArrayTypeValidationCallback)),
f_1634_43896_44034(FunctionDefinitions, new ConfigTypeEntry.TypeValidationCallback(FunctionDefinitionsTypeValidationCallback)),
f_1634_44049_44174(GMSAAccount, new ConfigTypeEntry.TypeValidationCallback(StringTypeValidationCallback)),
f_1634_44189_44314(Guid, new ConfigTypeEntry.TypeValidationCallback(StringTypeValidationCallback)),
f_1634_44329_44456(LanguageMode, new ConfigTypeEntry.TypeValidationCallback(LanguageModeValidationCallback)),
f_1634_44471_44612(ModulesToImport, new ConfigTypeEntry.TypeValidationCallback(StringOrHashtableArrayTypeValidationCallback)),
f_1634_44627_44753(MountUserDrive, new ConfigTypeEntry.TypeValidationCallback(BooleanTypeValidationCallback)),
f_1634_44768_44893(PowerShellVersion, new ConfigTypeEntry.TypeValidationCallback(StringTypeValidationCallback)),
f_1634_44908_45036(RequiredGroups, new ConfigTypeEntry.TypeValidationCallback(HashtableTypeValidationCallback)),
f_1634_45051_45181(RoleCapabilities, new ConfigTypeEntry.TypeValidationCallback(StringArrayTypeValidationCallback)),
f_1634_45196_45326(RoleCapabilityFiles, new ConfigTypeEntry.TypeValidationCallback(StringArrayTypeValidationCallback)),
f_1634_45341_45469(RoleDefinitions, new ConfigTypeEntry.TypeValidationCallback(HashtableTypeValidationCallback)),
f_1634_45484_45610(RunAsVirtualAccount, new ConfigTypeEntry.TypeValidationCallback(BooleanTypeValidationCallback)),
f_1634_45625_45755(RunAsVirtualAccountGroups, new ConfigTypeEntry.TypeValidationCallback(StringArrayTypeValidationCallback)),
f_1634_45770_45895(SchemaVersion, new ConfigTypeEntry.TypeValidationCallback(StringTypeValidationCallback)),
f_1634_45910_46040(ScriptsToProcess, new ConfigTypeEntry.TypeValidationCallback(StringArrayTypeValidationCallback)),
f_1634_46055_46173(SessionType, new ConfigTypeEntry.TypeValidationCallback(ISSValidationCallback)),
f_1634_46188_46313(TranscriptDirectory, new ConfigTypeEntry.TypeValidationCallback(StringTypeValidationCallback)),
f_1634_46328_46458(TypesToProcess, new ConfigTypeEntry.TypeValidationCallback(StringArrayTypeValidationCallback)),
f_1634_46473_46599(UserDriveMaxSize, new ConfigTypeEntry.TypeValidationCallback(IntegerTypeValidationCallback)),
f_1634_46614_46752(VariableDefinitions, new ConfigTypeEntry.TypeValidationCallback(VariableDefinitionsTypeValidationCallback)),
f_1634_46767_46897(VisibleAliases, new ConfigTypeEntry.TypeValidationCallback(StringArrayTypeValidationCallback)),
f_1634_46912_47042(VisibleCmdlets, new ConfigTypeEntry.TypeValidationCallback(StringArrayTypeValidationCallback)),
f_1634_47057_47187(VisibleFunctions, new ConfigTypeEntry.TypeValidationCallback(StringArrayTypeValidationCallback)),
f_1634_47202_47332(VisibleProviders, new ConfigTypeEntry.TypeValidationCallback(StringArrayTypeValidationCallback)),
f_1634_47347_47477(VisibleExternalCommands, new ConfigTypeEntry.TypeValidationCallback(StringArrayTypeValidationCallback)),
        };
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1634, 38889, 61787);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 38889, 61787);
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_42467_42602(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 42467, 42602);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_42617_42747(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 42617, 42747);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_42762_42887(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 42762, 42887);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_42902_43027(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 42902, 43027);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_43042_43167(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 43042, 43167);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_43182_43307(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 43182, 43307);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_43322_43448(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 43322, 43448);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_43463_43591(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 43463, 43591);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_43606_43736(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 43606, 43736);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_43751_43881(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 43751, 43881);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_43896_44034(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 43896, 44034);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_44049_44174(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 44049, 44174);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_44189_44314(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 44189, 44314);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_44329_44456(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 44329, 44456);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_44471_44612(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 44471, 44612);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_44627_44753(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 44627, 44753);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_44768_44893(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 44768, 44893);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_44908_45036(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 44908, 45036);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_45051_45181(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 45051, 45181);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_45196_45326(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 45196, 45326);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_45341_45469(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 45341, 45469);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_45484_45610(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 45484, 45610);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_45625_45755(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 45625, 45755);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_45770_45895(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 45770, 45895);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_45910_46040(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 45910, 46040);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_46055_46173(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 46055, 46173);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_46188_46313(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 46188, 46313);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_46328_46458(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 46328, 46458);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_46473_46599(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 46473, 46599);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_46614_46752(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 46614, 46752);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_46767_46897(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 46767, 46897);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_46912_47042(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 46912, 47042);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_47057_47187(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 47057, 47187);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_47202_47332(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 47202, 47332);
            return return_v;
        }


        static System.Management.Automation.Remoting.ConfigTypeEntry
        f_1634_47347_47477(string
        key, System.Management.Automation.Remoting.ConfigTypeEntry.TypeValidationCallback
        callback)
        {
            var return_v = new System.Management.Automation.Remoting.ConfigTypeEntry(key, callback);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 47347, 47477);
            return return_v;
        }

    }
    internal static class DISCUtils
    {
        internal static Type ExecutionPolicyType;

        private static readonly HashSet<string> s_allowedRoleCapabilityKeys;

        internal static ExternalScriptInfo GetScriptInfoForFile(ExecutionContext context, string fileName, out string scriptName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 63292, 64332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 63438, 63478);

                scriptName = f_1634_63451_63477(fileName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 63492, 63578);

                ExternalScriptInfo
                scriptInfo = f_1634_63524_63577(scriptName, fileName, context)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 63762, 64287) || true) && (!f_1634_63767_63831(scriptName, ".psd1", StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 63762, 64287);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 63865, 63998);

                    f_1634_63865_63997(f_1634_63865_63893(context), scriptInfo, CommandOrigin.Internal, f_1634_63969_63996(context));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 64078, 64123);

                    f_1634_64078_64122(scriptInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 64237, 64272);

                    scriptInfo.SignatureChecked = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 63762, 64287);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 64303, 64321);

                return scriptInfo;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 63292, 64332);

                string?
                f_1634_63451_63477(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 63451, 63477);
                    return return_v;
                }


                System.Management.Automation.ExternalScriptInfo
                f_1634_63524_63577(string
                name, string
                path, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.ExternalScriptInfo(name, path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 63524, 63577);
                    return return_v;
                }


                bool
                f_1634_63767_63831(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 63767, 63831);
                    return return_v;
                }


                System.Management.Automation.AuthorizationManager
                f_1634_63865_63893(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.AuthorizationManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 63865, 63893);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1634_63969_63996(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 63969, 63996);
                    return return_v;
                }


                int
                f_1634_63865_63997(System.Management.Automation.AuthorizationManager
                this_param, System.Management.Automation.ExternalScriptInfo
                commandInfo, System.Management.Automation.CommandOrigin
                origin, System.Management.Automation.Internal.Host.InternalHost
                host)
                {
                    this_param.ShouldRunInternal((System.Management.Automation.CommandInfo)commandInfo, origin, (System.Management.Automation.Host.PSHost)host);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 63865, 63997);
                    return 0;
                }


                int
                f_1634_64078_64122(System.Management.Automation.ExternalScriptInfo
                scriptInfo)
                {
                    CommandDiscovery.VerifyPSVersion(scriptInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 64078, 64122);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 63292, 64332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 63292, 64332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Hashtable LoadConfigFile(ExecutionContext context, ExternalScriptInfo scriptInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 64647, 65718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 64769, 64783);

                object
                result
                = default(object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 64797, 64885);

                object
                oldPSScriptRoot = f_1634_64822_64884(context, SpecialVariables.PSScriptRootVarPath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 64899, 64989);

                object
                oldPSCommandPath = f_1634_64925_64988(context, SpecialVariables.PSCommandPathVarPath)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 65118, 65222);

                    f_1634_65118_65221(                // Set the PSScriptRoot variable in the modules session state
                                    context, SpecialVariables.PSScriptRootVarPath, f_1634_65176_65220(f_1634_65198_65219(scriptInfo)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 65242, 65324);

                    f_1634_65242_65323(
                                    context, SpecialVariables.PSCommandPathVarPath, f_1634_65301_65322(scriptInfo));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 65344, 65410);

                    result = f_1634_65353_65409(f_1634_65367_65408(f_1634_65367_65389(scriptInfo)));
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1634, 65439, 65664);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 65479, 65554);

                    f_1634_65479_65553(context, SpecialVariables.PSScriptRootVarPath, oldPSScriptRoot);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 65572, 65649);

                    f_1634_65572_65648(context, SpecialVariables.PSCommandPathVarPath, oldPSCommandPath);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1634, 65439, 65664);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 65680, 65707);

                return result as Hashtable;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 64647, 65718);

                object
                f_1634_64822_64884(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path)
                {
                    var return_v = this_param.GetVariableValue(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 64822, 64884);
                    return return_v;
                }


                object
                f_1634_64925_64988(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path)
                {
                    var return_v = this_param.GetVariableValue(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 64925, 64988);
                    return return_v;
                }


                string
                f_1634_65198_65219(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.Definition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 65198, 65219);
                    return return_v;
                }


                string?
                f_1634_65176_65220(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 65176, 65220);
                    return return_v;
                }


                int
                f_1634_65118_65221(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, string
                newValue)
                {
                    this_param.SetVariable(path, (object)newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 65118, 65221);
                    return 0;
                }


                string
                f_1634_65301_65322(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.Definition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 65301, 65322);
                    return return_v;
                }


                int
                f_1634_65242_65323(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, string
                newValue)
                {
                    this_param.SetVariable(path, (object)newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 65242, 65323);
                    return 0;
                }


                System.Management.Automation.ScriptBlock
                f_1634_65367_65389(System.Management.Automation.ExternalScriptInfo
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 65367, 65389);
                    return return_v;
                }


                object
                f_1634_65367_65408(System.Management.Automation.ScriptBlock
                this_param, params object[]
                args)
                {
                    var return_v = this_param.InvokeReturnAsIs(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 65367, 65408);
                    return return_v;
                }


                object
                f_1634_65353_65409(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 65353, 65409);
                    return return_v;
                }


                int
                f_1634_65479_65553(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, object
                newValue)
                {
                    this_param.SetVariable(path, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 65479, 65553);
                    return 0;
                }


                int
                f_1634_65572_65648(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path, object
                newValue)
                {
                    this_param.SetVariable(path, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 65572, 65648);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 64647, 65718);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 64647, 65718);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool VerifyConfigTable(Hashtable table, PSCmdlet cmdlet, string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 66042, 67196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 66152, 66182);

                bool
                hasSchemaVersion = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 66198, 66614);
                    foreach (DictionaryEntry de in f_1634_66229_66234_I(table))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 66198, 66614);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 66268, 66395) || true) && (!f_1634_66273_66321(de, cmdlet, path))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 66268, 66395);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 66363, 66376);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 66268, 66395);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 66415, 66599) || true) && (f_1634_66419_66514(f_1634_66419_66436(de.Key), ConfigFileConstants.SchemaVersion, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 66415, 66599);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 66556, 66580);

                            hasSchemaVersion = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 66415, 66599);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 66198, 66614);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 417);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 417);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 66630, 66825) || true) && (!hasSchemaVersion)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 66630, 66825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 66685, 66779);

                    f_1634_66685_66778(cmdlet, f_1634_66705_66777(f_1634_66723_66770(), path));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 66797, 66810);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 66630, 66825);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 66877, 66933);

                    f_1634_66877_66932(f_1634_66899_66918(cmdlet), table, path);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 66951, 66983);

                    f_1634_66951_66982(table, path);
                }
                catch (InvalidOperationException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 67012, 67157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 67080, 67111);

                    f_1634_67080_67110(cmdlet, f_1634_67100_67109(e));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 67129, 67142);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 67012, 67157);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 67173, 67185);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 66042, 67196);

                bool
                f_1634_66273_66321(System.Collections.DictionaryEntry
                de, System.Management.Automation.PSCmdlet
                cmdlet, string
                path)
                {
                    var return_v = ConfigFileConstants.IsValidKey(de, cmdlet, path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 66273, 66321);
                    return return_v;
                }


                string?
                f_1634_66419_66436(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 66419, 66436);
                    return return_v;
                }


                bool
                f_1634_66419_66514(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 66419, 66514);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1634_66229_66234_I(System.Collections.Hashtable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 66229, 66234);
                    return return_v;
                }


                string
                f_1634_66723_66770()
                {
                    var return_v = RemotingErrorIdStrings.DISCMissingSchemaVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 66723, 66770);
                    return return_v;
                }


                string
                f_1634_66705_66777(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 66705, 66777);
                    return return_v;
                }


                int
                f_1634_66685_66778(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 66685, 66778);
                    return 0;
                }


                System.Management.Automation.SessionState
                f_1634_66899_66918(System.Management.Automation.PSCmdlet
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 66899, 66918);
                    return return_v;
                }


                int
                f_1634_66877_66932(System.Management.Automation.SessionState
                state, System.Collections.Hashtable
                table, string
                filePath)
                {
                    ValidateAbsolutePaths(state, table, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 66877, 66932);
                    return 0;
                }


                int
                f_1634_66951_66982(System.Collections.Hashtable
                table, string
                filePath)
                {
                    ValidateExtensions(table, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 66951, 66982);
                    return 0;
                }


                string
                f_1634_67100_67109(System.InvalidOperationException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 67100, 67109);
                    return return_v;
                }


                int
                f_1634_67080_67110(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 67080, 67110);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 66042, 67196);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 66042, 67196);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ValidatePS1XMLExtension(string key, string[] paths, string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 67255, 68217);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 67368, 67441) || true) && (paths == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 67368, 67441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 67419, 67426);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 67368, 67441);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 67457, 68206);
                    foreach (string path in f_1634_67481_67486_I(paths))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 67457, 68206);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 67564, 67611);

                            string
                            ext = f_1634_67577_67610(path)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 67635, 67891) || true) && (!f_1634_67640_67697(ext, ".ps1xml", StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 67635, 67891);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 67747, 67868);

                                throw f_1634_67753_67867(f_1634_67783_67866(f_1634_67801_67844(), key, ext, ".ps1xml"));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 67635, 67891);
                            }
                        }
                        catch (ArgumentException argumentException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 67928, 68191);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 68012, 68172);

                            throw f_1634_68018_68171(f_1634_68048_68151(f_1634_68066_68135(), key, filePath), argumentException);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 67928, 68191);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 67457, 68206);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 750);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 750);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 67255, 68217);

                string?
                f_1634_67577_67610(string
                path)
                {
                    var return_v = System.IO.Path.GetExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 67577, 67610);
                    return return_v;
                }


                bool
                f_1634_67640_67697(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 67640, 67697);
                    return return_v;
                }


                string
                f_1634_67801_67844()
                {
                    var return_v = RemotingErrorIdStrings.DISCInvalidExtension;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 67801, 67844);
                    return return_v;
                }


                string
                f_1634_67783_67866(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 67783, 67866);
                    return return_v;
                }


                System.InvalidOperationException
                f_1634_67753_67867(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 67753, 67867);
                    return return_v;
                }


                string
                f_1634_68066_68135()
                {
                    var return_v = RemotingErrorIdStrings.ErrorParsingTheKeyInPSSessionConfigurationFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 68066, 68135);
                    return return_v;
                }


                string
                f_1634_68048_68151(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 68048, 68151);
                    return return_v;
                }


                System.InvalidOperationException
                f_1634_68018_68171(string
                message, System.ArgumentException
                innerException)
                {
                    var return_v = new System.InvalidOperationException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 68018, 68171);
                    return return_v;
                }


                string[]
                f_1634_67481_67486_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 67481, 67486);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 67255, 68217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 67255, 68217);
            }
        }

        private static void ValidatePS1OrPSM1Extension(string key, string[] paths, string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 68276, 69527);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 68392, 68465) || true) && (paths == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 68392, 68465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 68443, 68450);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 68392, 68465);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 68481, 69516);
                    foreach (string path in f_1634_68505_68510_I(paths))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 68481, 69516);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 68588, 68635);

                            string
                            ext = f_1634_68601_68634(path)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 68659, 69201) || true) && (!f_1634_68664_68756(ext, StringLiterals.PowerShellScriptFileExtension, StringComparison.OrdinalIgnoreCase) && (DynAbs.Tracing.TraceSender.Expression_True(1634, 68663, 68878) && !f_1634_68786_68878(ext, StringLiterals.PowerShellModuleFileExtension, StringComparison.OrdinalIgnoreCase)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 68659, 69201);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 68928, 69178);

                                throw f_1634_68934_69177(f_1634_68964_69176(f_1634_68982_69025(), key, ext, f_1634_69066_69175(", ", StringLiterals.PowerShellScriptFileExtension, StringLiterals.PowerShellModuleFileExtension)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 68659, 69201);
                            }
                        }
                        catch (ArgumentException argumentException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 69238, 69501);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 69322, 69482);

                            throw f_1634_69328_69481(f_1634_69358_69461(f_1634_69376_69445(), key, filePath), argumentException);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 69238, 69501);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 68481, 69516);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 1036);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 1036);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 68276, 69527);

                string?
                f_1634_68601_68634(string
                path)
                {
                    var return_v = System.IO.Path.GetExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 68601, 68634);
                    return return_v;
                }


                bool
                f_1634_68664_68756(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 68664, 68756);
                    return return_v;
                }


                bool
                f_1634_68786_68878(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 68786, 68878);
                    return return_v;
                }


                string
                f_1634_68982_69025()
                {
                    var return_v = RemotingErrorIdStrings.DISCInvalidExtension;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 68982, 69025);
                    return return_v;
                }


                string
                f_1634_69066_69175(string
                separator, params string?[]
                value)
                {
                    var return_v = string.Join(separator, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 69066, 69175);
                    return return_v;
                }


                string
                f_1634_68964_69176(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 68964, 69176);
                    return return_v;
                }


                System.InvalidOperationException
                f_1634_68934_69177(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 68934, 69177);
                    return return_v;
                }


                string
                f_1634_69376_69445()
                {
                    var return_v = RemotingErrorIdStrings.ErrorParsingTheKeyInPSSessionConfigurationFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 69376, 69445);
                    return return_v;
                }


                string
                f_1634_69358_69461(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 69358, 69461);
                    return return_v;
                }


                System.InvalidOperationException
                f_1634_69328_69481(string
                message, System.ArgumentException
                innerException)
                {
                    var return_v = new System.InvalidOperationException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 69328, 69481);
                    return return_v;
                }


                string[]
                f_1634_68505_68510_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 68505, 68510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 68276, 69527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 68276, 69527);
            }
        }

        internal static void ValidateExtensions(Hashtable table, string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 69673, 70627);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 69771, 70037) || true) && (f_1634_69775_69828(table, ConfigFileConstants.TypesToProcess))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 69771, 70037);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 69862, 70022);

                    f_1634_69862_70021(ConfigFileConstants.TypesToProcess, f_1634_69922_70010(f_1634_69968_70009(table, ConfigFileConstants.TypesToProcess)), filePath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 69771, 70037);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 70053, 70325) || true) && (f_1634_70057_70112(table, ConfigFileConstants.FormatsToProcess))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 70053, 70325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 70146, 70310);

                    f_1634_70146_70309(ConfigFileConstants.FormatsToProcess, f_1634_70208_70298(f_1634_70254_70297(table, ConfigFileConstants.FormatsToProcess)), filePath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 70053, 70325);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 70341, 70616) || true) && (f_1634_70345_70400(table, ConfigFileConstants.ScriptsToProcess))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 70341, 70616);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 70434, 70601);

                    f_1634_70434_70600(ConfigFileConstants.ScriptsToProcess, f_1634_70499_70589(f_1634_70545_70588(table, ConfigFileConstants.ScriptsToProcess)), filePath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 70341, 70616);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 69673, 70627);

                bool
                f_1634_69775_69828(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 69775, 69828);
                    return return_v;
                }


                object
                f_1634_69968_70009(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 69968, 70009);
                    return return_v;
                }


                string[]
                f_1634_69922_70010(object
                hashObj)
                {
                    var return_v = DISCPowerShellConfiguration.TryGetStringArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 69922, 70010);
                    return return_v;
                }


                int
                f_1634_69862_70021(string
                key, string[]
                paths, string
                filePath)
                {
                    ValidatePS1XMLExtension(key, paths, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 69862, 70021);
                    return 0;
                }


                bool
                f_1634_70057_70112(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 70057, 70112);
                    return return_v;
                }


                object
                f_1634_70254_70297(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 70254, 70297);
                    return return_v;
                }


                string[]
                f_1634_70208_70298(object
                hashObj)
                {
                    var return_v = DISCPowerShellConfiguration.TryGetStringArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 70208, 70298);
                    return return_v;
                }


                int
                f_1634_70146_70309(string
                key, string[]
                paths, string
                filePath)
                {
                    ValidatePS1XMLExtension(key, paths, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 70146, 70309);
                    return 0;
                }


                bool
                f_1634_70345_70400(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 70345, 70400);
                    return return_v;
                }


                object
                f_1634_70545_70588(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 70545, 70588);
                    return return_v;
                }


                string[]
                f_1634_70499_70589(object
                hashObj)
                {
                    var return_v = DISCPowerShellConfiguration.TryGetStringArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 70499, 70589);
                    return return_v;
                }


                int
                f_1634_70434_70600(string
                key, string[]
                paths, string
                filePath)
                {
                    ValidatePS1OrPSM1Extension(key, paths, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 70434, 70600);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 69673, 70627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 69673, 70627);
            }
        }

        internal static void ValidateAbsolutePaths(SessionState state, Hashtable table, string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 70868, 71854);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 70989, 71259) || true) && (f_1634_70993_71046(table, ConfigFileConstants.TypesToProcess))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 70989, 71259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 71080, 71244);

                    f_1634_71080_71243(state, ConfigFileConstants.TypesToProcess, f_1634_71144_71232(f_1634_71190_71231(table, ConfigFileConstants.TypesToProcess)), filePath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 70989, 71259);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 71275, 71551) || true) && (f_1634_71279_71334(table, ConfigFileConstants.FormatsToProcess))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 71275, 71551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 71368, 71536);

                    f_1634_71368_71535(state, ConfigFileConstants.FormatsToProcess, f_1634_71434_71524(f_1634_71480_71523(table, ConfigFileConstants.FormatsToProcess)), filePath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 71275, 71551);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 71567, 71843) || true) && (f_1634_71571_71626(table, ConfigFileConstants.ScriptsToProcess))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 71567, 71843);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 71660, 71828);

                    f_1634_71660_71827(state, ConfigFileConstants.ScriptsToProcess, f_1634_71726_71816(f_1634_71772_71815(table, ConfigFileConstants.ScriptsToProcess)), filePath);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 71567, 71843);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 70868, 71854);

                bool
                f_1634_70993_71046(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 70993, 71046);
                    return return_v;
                }


                object
                f_1634_71190_71231(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 71190, 71231);
                    return return_v;
                }


                string[]
                f_1634_71144_71232(object
                hashObj)
                {
                    var return_v = DISCPowerShellConfiguration.TryGetStringArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 71144, 71232);
                    return return_v;
                }


                int
                f_1634_71080_71243(System.Management.Automation.SessionState
                state, string
                key, string[]
                paths, string
                filePath)
                {
                    ValidateAbsolutePath(state, key, paths, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 71080, 71243);
                    return 0;
                }


                bool
                f_1634_71279_71334(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 71279, 71334);
                    return return_v;
                }


                object
                f_1634_71480_71523(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 71480, 71523);
                    return return_v;
                }


                string[]
                f_1634_71434_71524(object
                hashObj)
                {
                    var return_v = DISCPowerShellConfiguration.TryGetStringArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 71434, 71524);
                    return return_v;
                }


                int
                f_1634_71368_71535(System.Management.Automation.SessionState
                state, string
                key, string[]
                paths, string
                filePath)
                {
                    ValidateAbsolutePath(state, key, paths, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 71368, 71535);
                    return 0;
                }


                bool
                f_1634_71571_71626(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 71571, 71626);
                    return return_v;
                }


                object
                f_1634_71772_71815(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 71772, 71815);
                    return return_v;
                }


                string[]
                f_1634_71726_71816(object
                hashObj)
                {
                    var return_v = DISCPowerShellConfiguration.TryGetStringArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 71726, 71816);
                    return return_v;
                }


                int
                f_1634_71660_71827(System.Management.Automation.SessionState
                state, string
                key, string[]
                paths, string
                filePath)
                {
                    ValidateAbsolutePath(state, key, paths, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 71660, 71827);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 70868, 71854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 70868, 71854);
            }
        }

        internal static void ValidateAbsolutePath(SessionState state, string key, string[] paths, string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 72133, 72707);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 72264, 72337) || true) && (paths == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 72264, 72337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 72315, 72322);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 72264, 72337);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 72353, 72370);

                string
                driveName
                = default(string);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 72384, 72696);
                    foreach (string path in f_1634_72408_72413_I(paths))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 72384, 72696);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 72447, 72681) || true) && (!f_1634_72452_72496(f_1634_72452_72462(state), path, out driveName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 72447, 72681);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 72538, 72662);

                            throw f_1634_72544_72661(f_1634_72574_72660(f_1634_72592_72638(), key, path, filePath));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 72447, 72681);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 72384, 72696);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 313);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 313);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 72133, 72707);

                System.Management.Automation.PathIntrinsics
                f_1634_72452_72462(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 72452, 72462);
                    return return_v;
                }


                bool
                f_1634_72452_72496(System.Management.Automation.PathIntrinsics
                this_param, string
                path, out string
                driveName)
                {
                    var return_v = this_param.IsPSAbsolute(path, out driveName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 72452, 72496);
                    return return_v;
                }


                string
                f_1634_72592_72638()
                {
                    var return_v = RemotingErrorIdStrings.DISCPathsMustBeAbsolute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 72592, 72638);
                    return return_v;
                }


                string
                f_1634_72574_72660(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 72574, 72660);
                    return return_v;
                }


                System.InvalidOperationException
                f_1634_72544_72661(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 72544, 72661);
                    return return_v;
                }


                string[]
                f_1634_72408_72413_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 72408, 72413);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 72133, 72707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 72133, 72707);
            }
        }

        internal static void ValidateRoleDefinitions(IDictionary roleDefinitions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 73152, 75510);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 73250, 75499);
                    foreach (var roleKey in f_1634_73274_73294_I(f_1634_73274_73294(roleDefinitions)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 73250, 75499);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 73328, 73703) || true) && (!(roleKey is string))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 73328, 73703);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 73394, 73563);

                            var
                            invalidOperationEx = f_1634_73419_73562(f_1634_73477_73561(f_1634_73491_73532(), f_1634_73534_73560(f_1634_73534_73551(roleKey))))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 73585, 73637);

                            f_1634_73585_73636(invalidOperationEx, "InvalidRoleKeyType");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 73659, 73684);

                            throw invalidOperationEx;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 73328, 73703);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 73896, 73965);

                        IDictionary
                        roleDefinition = f_1634_73925_73949(roleDefinitions, roleKey) as IDictionary
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 73983, 74353) || true) && (roleDefinition == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 73983, 74353);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 74051, 74203);

                            var
                            invalidOperationEx = f_1634_74076_74202(f_1634_74134_74201(f_1634_74152_74191(), roleKey))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 74225, 74287);

                            f_1634_74225_74286(invalidOperationEx, "InvalidRoleEntryNotHashtable");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 74309, 74334);

                            throw invalidOperationEx;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 73983, 74353);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 74373, 75484);
                            foreach (var key in f_1634_74393_74412_I(f_1634_74393_74412(roleDefinition)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 74373, 75484);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 74520, 74561);

                                string
                                roleCapabilityKey = key as string
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 74583, 75003) || true) && (roleCapabilityKey == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 74583, 75003);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 74662, 74841);

                                    var
                                    invalidOperationEx = f_1634_74687_74840(f_1634_74749_74839(f_1634_74763_74814(), f_1634_74816_74838(f_1634_74816_74829(key))))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 74867, 74929);

                                    f_1634_74867_74928(invalidOperationEx, "InvalidRoleCapabilityKeyType");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 74955, 74980);

                                    throw invalidOperationEx;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 74583, 75003);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 75027, 75465) || true) && (!f_1634_75032_75087(s_allowedRoleCapabilityKeys, roleCapabilityKey))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 75027, 75465);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 75137, 75307);

                                    var
                                    invalidOperationEx = f_1634_75162_75306(f_1634_75224_75305(f_1634_75238_75285(), roleCapabilityKey))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 75333, 75391);

                                    f_1634_75333_75390(invalidOperationEx, "InvalidRoleCapabilityKey");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 75417, 75442);

                                    throw invalidOperationEx;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 75027, 75465);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 74373, 75484);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 1112);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 1112);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 73250, 75499);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 2250);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 2250);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 73152, 75510);

                System.Collections.ICollection
                f_1634_73274_73294(System.Collections.IDictionary
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 73274, 73294);
                    return return_v;
                }


                string
                f_1634_73491_73532()
                {
                    var return_v = RemotingErrorIdStrings.InvalidRoleKeyType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 73491, 73532);
                    return return_v;
                }


                System.Type
                f_1634_73534_73551(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 73534, 73551);
                    return return_v;
                }


                string
                f_1634_73534_73560(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 73534, 73560);
                    return return_v;
                }


                string
                f_1634_73477_73561(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 73477, 73561);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1634_73419_73562(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 73419, 73562);
                    return return_v;
                }


                int
                f_1634_73585_73636(System.Management.Automation.PSInvalidOperationException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 73585, 73636);
                    return 0;
                }


                object
                f_1634_73925_73949(System.Collections.IDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 73925, 73949);
                    return return_v;
                }


                string
                f_1634_74152_74191()
                {
                    var return_v = RemotingErrorIdStrings.InvalidRoleValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 74152, 74191);
                    return return_v;
                }


                string
                f_1634_74134_74201(string
                formatSpec, object
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 74134, 74201);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1634_74076_74202(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 74076, 74202);
                    return return_v;
                }


                int
                f_1634_74225_74286(System.Management.Automation.PSInvalidOperationException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 74225, 74286);
                    return 0;
                }


                System.Collections.ICollection
                f_1634_74393_74412(System.Collections.IDictionary
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 74393, 74412);
                    return return_v;
                }


                string
                f_1634_74763_74814()
                {
                    var return_v = RemotingErrorIdStrings.InvalidRoleCapabilityKeyType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 74763, 74814);
                    return return_v;
                }


                System.Type
                f_1634_74816_74829(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 74816, 74829);
                    return return_v;
                }


                string
                f_1634_74816_74838(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 74816, 74838);
                    return return_v;
                }


                string
                f_1634_74749_74839(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 74749, 74839);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1634_74687_74840(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 74687, 74840);
                    return return_v;
                }


                int
                f_1634_74867_74928(System.Management.Automation.PSInvalidOperationException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 74867, 74928);
                    return 0;
                }


                bool
                f_1634_75032_75087(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 75032, 75087);
                    return return_v;
                }


                string
                f_1634_75238_75285()
                {
                    var return_v = RemotingErrorIdStrings.InvalidRoleCapabilityKey;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 75238, 75285);
                    return return_v;
                }


                string
                f_1634_75224_75305(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 75224, 75305);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1634_75162_75306(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 75162, 75306);
                    return return_v;
                }


                int
                f_1634_75333_75390(System.Management.Automation.PSInvalidOperationException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 75333, 75390);
                    return 0;
                }


                System.Collections.ICollection
                f_1634_74393_74412_I(System.Collections.ICollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 74393, 74412);
                    return return_v;
                }


                System.Collections.ICollection
                f_1634_73274_73294_I(System.Collections.ICollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 73274, 73294);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 73152, 75510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 73152, 75510);
            }
        }

        static DISCUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1634, 61889, 75517);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 61990, 62016);
            ExecutionPolicyType = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 62232, 62877);
            s_allowedRoleCapabilityKeys = new HashSet<string>(f_1634_62282_62314())
        {
            DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "RoleCapabilities",1634,62262,62877),            "RoleCapabilityFiles",            "ModulesToImport",            "VisibleAliases",            "VisibleCmdlets",            "VisibleFunctions",            "VisibleExternalCommands",            "VisibleProviders",            "ScriptsToProcess",            "AliasDefinitions",            "FunctionDefinitions",            "VariableDefinitions",            "EnvironmentVariables",            "TypesToProcess",            "FormatsToProcess",            "AssembliesToLoad"
        };
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1634, 61889, 75517);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 61889, 75517);
        }


        static System.StringComparer
        f_1634_62282_62314()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 62282, 62314);
            return return_v;
        }

    }
    internal sealed class DISCPowerShellConfiguration : PSSessionConfiguration
    {
        private string _configFile;

        private Hashtable _configHash;

        internal Hashtable ConfigHash
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1634, 76053, 76080);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 76059, 76078);

                    return _configHash;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1634, 76053, 76080);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 75999, 76091);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 75999, 76091);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal DISCPowerShellConfiguration(string configFile, Func<string, bool> roleVerifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1634, 76681, 78190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 75782, 75793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 75822, 75833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 76794, 76819);

                _configFile = configFile;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 76833, 76937) || true) && (roleVerifier == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 76833, 76937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 76891, 76922);

                    roleVerifier = (role) => false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 76833, 76937);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 76953, 77004);

                Runspace
                backupRunspace = f_1634_76979_77003()
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 77056, 77116);

                    Runspace.DefaultRunspace = f_1634_77083_77115();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 77134, 77166);

                    f_1634_77134_77165(f_1634_77134_77158());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 77186, 77204);

                    string
                    scriptName
                    = default(string);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 77222, 77373);

                    ExternalScriptInfo
                    script = f_1634_77250_77372(f_1634_77281_77322(f_1634_77281_77305()), configFile, out scriptName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 77393, 77483);

                    _configHash = f_1634_77407_77482(f_1634_77432_77473(f_1634_77432_77456()), script);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 77501, 77544);

                    f_1634_77501_77543(this, roleVerifier);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 77562, 77600);

                    f_1634_77562_77599(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 77620, 77653);

                    f_1634_77620_77652(f_1634_77620_77644());
                }
                catch (PSSecurityException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 77682, 78068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 77744, 77853);

                    string
                    message = f_1634_77761_77852(f_1634_77779_77839(), configFile)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 77871, 77949);

                    PSInvalidOperationException
                    ioe = f_1634_77905_77948(message, e)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 77967, 78023);

                    f_1634_77967_78022(ioe, "InvalidPSSessionConfigurationFilePath");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 78043, 78053);

                    throw ioe;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 77682, 78068);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1634, 78082, 78179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 78122, 78164);

                    Runspace.DefaultRunspace = backupRunspace;
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1634, 78082, 78179);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1634, 76681, 78190);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 76681, 78190);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 76681, 78190);
            }
        }

        private void MergeRoleRulesIntoConfigHash(Func<string, bool> roleVerifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1634, 78312, 80244);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 78411, 80233) || true) && (f_1634_78415_78475(_configHash, ConfigFileConstants.RoleDefinitions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 78411, 80233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 78559, 78647);

                    IDictionary
                    roleEntry = f_1634_78583_78631(_configHash, ConfigFileConstants.RoleDefinitions) as IDictionary
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 78665, 79067) || true) && (roleEntry == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 78665, 79067);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 78728, 78845);

                        string
                        message = f_1634_78745_78844(f_1634_78763_78802(), f_1634_78804_78843(f_1634_78804_78834(f_1634_78804_78824(_configHash, "Roles"))))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 78867, 78942);

                        PSInvalidOperationException
                        ioe = f_1634_78901_78941(message)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 78964, 79016);

                        f_1634_78964_79015(ioe, "InvalidRoleDefinitionNotHashtable");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 79038, 79048);

                        throw ioe;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 78665, 79067);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 79159, 79204);

                    f_1634_79159_79203(roleEntry);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 79275, 80218);
                        foreach (object role in f_1634_79299_79313_I(f_1634_79299_79313(roleEntry)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 79275, 80218);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 79428, 80199) || true) && (f_1634_79432_79461(roleVerifier, f_1634_79445_79460(role)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 79428, 80199);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 79576, 79640);

                                IDictionary
                                roleCustomizations = f_1634_79609_79624(roleEntry, role) as IDictionary
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 79668, 80098) || true) && (roleCustomizations == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 79668, 80098);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 79756, 79849);

                                    string
                                    message = f_1634_79773_79848(f_1634_79791_79830(), f_1634_79832_79847(role))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 79879, 79954);

                                    PSInvalidOperationException
                                    ioe = f_1634_79913_79953(message)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 79984, 80031);

                                    f_1634_79984_80030(ioe, "InvalidRoleValueNotHashtable");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 80061, 80071);

                                    throw ioe;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 79668, 80098);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 80126, 80176);

                                f_1634_80126_80175(this, roleCustomizations);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 79428, 80199);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 79275, 80218);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 944);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 944);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 78411, 80233);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1634, 78312, 80244);

                bool
                f_1634_78415_78475(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 78415, 78475);
                    return return_v;
                }


                object
                f_1634_78583_78631(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 78583, 78631);
                    return return_v;
                }


                string
                f_1634_78763_78802()
                {
                    var return_v = RemotingErrorIdStrings.InvalidRoleEntry;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 78763, 78802);
                    return return_v;
                }


                object
                f_1634_78804_78824(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 78804, 78824);
                    return return_v;
                }


                System.Type
                f_1634_78804_78834(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 78804, 78834);
                    return return_v;
                }


                string
                f_1634_78804_78843(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 78804, 78843);
                    return return_v;
                }


                string
                f_1634_78745_78844(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 78745, 78844);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1634_78901_78941(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 78901, 78941);
                    return return_v;
                }


                int
                f_1634_78964_79015(System.Management.Automation.PSInvalidOperationException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 78964, 79015);
                    return 0;
                }


                int
                f_1634_79159_79203(System.Collections.IDictionary
                roleDefinitions)
                {
                    DISCUtils.ValidateRoleDefinitions(roleDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 79159, 79203);
                    return 0;
                }


                System.Collections.ICollection
                f_1634_79299_79313(System.Collections.IDictionary
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 79299, 79313);
                    return return_v;
                }


                string?
                f_1634_79445_79460(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 79445, 79460);
                    return return_v;
                }


                bool
                f_1634_79432_79461(System.Func<string, bool>
                this_param, string
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 79432, 79461);
                    return return_v;
                }


                object
                f_1634_79609_79624(System.Collections.IDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 79609, 79624);
                    return return_v;
                }


                string
                f_1634_79791_79830()
                {
                    var return_v = RemotingErrorIdStrings.InvalidRoleValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 79791, 79830);
                    return return_v;
                }


                string?
                f_1634_79832_79847(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 79832, 79847);
                    return return_v;
                }


                string
                f_1634_79773_79848(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 79773, 79848);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1634_79913_79953(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 79913, 79953);
                    return return_v;
                }


                int
                f_1634_79984_80030(System.Management.Automation.PSInvalidOperationException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 79984, 80030);
                    return 0;
                }


                int
                f_1634_80126_80175(System.Management.Automation.Remoting.DISCPowerShellConfiguration
                this_param, System.Collections.IDictionary
                childConfigHash)
                {
                    this_param.MergeConfigHashIntoConfigHash(childConfigHash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 80126, 80175);
                    return 0;
                }


                System.Collections.ICollection
                f_1634_79299_79313_I(System.Collections.ICollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 79299, 79313);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 78312, 80244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 78312, 80244);
            }
        }

        private const string
        PSRCExtension = ".psrc"
        ;

        private void MergeRoleCapabilitiesIntoConfigHash()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1634, 80428, 83632);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 80503, 80547);

                List<string>
                psrcFiles = f_1634_80528_80546()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 80563, 81643) || true) && (f_1634_80567_80628(_configHash, ConfigFileConstants.RoleCapabilities))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 80563, 81643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 80662, 80759);

                    string[]
                    roleCapabilities = f_1634_80690_80758(f_1634_80708_80757(_configHash, ConfigFileConstants.RoleCapabilities))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 80779, 81628) || true) && (roleCapabilities != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 80779, 81628);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 80849, 81609);
                            foreach (string roleCapability in f_1634_80883_80899_I(roleCapabilities))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 80849, 81609);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 80949, 81015);

                                string
                                roleCapabilityPath = f_1634_80977_81014(this, roleCapability)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 81041, 81524) || true) && (f_1634_81045_81085(roleCapabilityPath))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 81041, 81524);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 81143, 81277);

                                    string
                                    message = f_1634_81160_81276(f_1634_81178_81227(), roleCapability, roleCapability + PSRCExtension)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 81307, 81382);

                                    PSInvalidOperationException
                                    ioe = f_1634_81341_81381(message)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 81412, 81457);

                                    f_1634_81412_81456(ioe, "CouldNotFindRoleCapability");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 81487, 81497);

                                    throw ioe;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 81041, 81524);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 81552, 81586);

                                f_1634_81552_81585(
                                                        psrcFiles, roleCapabilityPath);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 80849, 81609);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 761);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 761);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 80779, 81628);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 80563, 81643);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 81659, 83210) || true) && (f_1634_81663_81726(f_1634_81663_81673(), ConfigFileConstants.RoleCapabilityFiles))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 81659, 83210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 81760, 81862);

                    string[]
                    roleCapabilityFiles = f_1634_81791_81861(f_1634_81809_81860(f_1634_81809_81819(), ConfigFileConstants.RoleCapabilityFiles))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 81880, 83195) || true) && (roleCapabilityFiles != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 81880, 83195);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 81953, 83176);
                            foreach (var roleCapabilityFilePath in f_1634_81992_82011_I(roleCapabilityFiles))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 81953, 83176);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 82061, 82596) || true) && (!f_1634_82066_82165(f_1634_82066_82107(roleCapabilityFilePath), PSRCExtension, StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 82061, 82596);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 82223, 82341);

                                    string
                                    message = f_1634_82240_82340(f_1634_82258_82315(), roleCapabilityFilePath)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 82371, 82446);

                                    PSInvalidOperationException
                                    ioe = f_1634_82405_82445(message)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 82476, 82529);

                                    f_1634_82476_82528(ioe, "InvalidRoleCapabilityFileExtension");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 82559, 82569);

                                    throw ioe;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 82061, 82596);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 82624, 83087) || true) && (!f_1634_82629_82664(roleCapabilityFilePath))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 82624, 83087);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 82722, 82836);

                                    string
                                    message = f_1634_82739_82835(f_1634_82757_82810(), roleCapabilityFilePath)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 82866, 82941);

                                    PSInvalidOperationException
                                    ioe = f_1634_82900_82940(message)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 82971, 83020);

                                    f_1634_82971_83019(ioe, "CouldNotFindRoleCapabilityFile");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 83050, 83060);

                                    throw ioe;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 82624, 83087);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 83115, 83153);

                                f_1634_83115_83152(
                                                        psrcFiles, roleCapabilityFilePath);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 81953, 83176);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 1224);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 1224);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 81880, 83195);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 81659, 83210);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 83226, 83621);
                    foreach (var roleCapabilityFile in f_1634_83261_83270_I(psrcFiles))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 83226, 83621);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 83304, 83420);

                        DISCPowerShellConfiguration
                        roleCapabilityConfiguration = f_1634_83362_83419(roleCapabilityFile, null)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 83438, 83524);

                        IDictionary
                        roleCapabilityConfigurationItems = f_1634_83485_83523(roleCapabilityConfiguration)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 83542, 83606);

                        f_1634_83542_83605(this, roleCapabilityConfigurationItems);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 83226, 83621);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 396);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 396);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1634, 80428, 83632);

                System.Collections.Generic.List<string>
                f_1634_80528_80546()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 80528, 80546);
                    return return_v;
                }


                bool
                f_1634_80567_80628(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 80567, 80628);
                    return return_v;
                }


                object
                f_1634_80708_80757(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 80708, 80757);
                    return return_v;
                }


                string[]
                f_1634_80690_80758(object
                hashObj)
                {
                    var return_v = TryGetStringArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 80690, 80758);
                    return return_v;
                }


                string
                f_1634_80977_81014(System.Management.Automation.Remoting.DISCPowerShellConfiguration
                this_param, string
                roleCapability)
                {
                    var return_v = this_param.GetRoleCapabilityPath(roleCapability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 80977, 81014);
                    return return_v;
                }


                bool
                f_1634_81045_81085(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 81045, 81085);
                    return return_v;
                }


                string
                f_1634_81178_81227()
                {
                    var return_v = RemotingErrorIdStrings.CouldNotFindRoleCapability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 81178, 81227);
                    return return_v;
                }


                string
                f_1634_81160_81276(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 81160, 81276);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1634_81341_81381(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 81341, 81381);
                    return return_v;
                }


                int
                f_1634_81412_81456(System.Management.Automation.PSInvalidOperationException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 81412, 81456);
                    return 0;
                }


                int
                f_1634_81552_81585(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 81552, 81585);
                    return 0;
                }


                string[]
                f_1634_80883_80899_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 80883, 80899);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1634_81663_81673()
                {
                    var return_v = ConfigHash;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 81663, 81673);
                    return return_v;
                }


                bool
                f_1634_81663_81726(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 81663, 81726);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1634_81809_81819()
                {
                    var return_v = ConfigHash;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 81809, 81819);
                    return return_v;
                }


                object
                f_1634_81809_81860(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 81809, 81860);
                    return return_v;
                }


                string[]
                f_1634_81791_81861(object
                hashObj)
                {
                    var return_v = TryGetStringArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 81791, 81861);
                    return return_v;
                }


                string?
                f_1634_82066_82107(string
                path)
                {
                    var return_v = Path.GetExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 82066, 82107);
                    return return_v;
                }


                bool
                f_1634_82066_82165(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 82066, 82165);
                    return return_v;
                }


                string
                f_1634_82258_82315()
                {
                    var return_v = RemotingErrorIdStrings.InvalidRoleCapabilityFileExtension;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 82258, 82315);
                    return return_v;
                }


                string
                f_1634_82240_82340(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 82240, 82340);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1634_82405_82445(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 82405, 82445);
                    return return_v;
                }


                int
                f_1634_82476_82528(System.Management.Automation.PSInvalidOperationException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 82476, 82528);
                    return 0;
                }


                bool
                f_1634_82629_82664(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 82629, 82664);
                    return return_v;
                }


                string
                f_1634_82757_82810()
                {
                    var return_v = RemotingErrorIdStrings.CouldNotFindRoleCapabilityFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 82757, 82810);
                    return return_v;
                }


                string
                f_1634_82739_82835(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 82739, 82835);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1634_82900_82940(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 82900, 82940);
                    return return_v;
                }


                int
                f_1634_82971_83019(System.Management.Automation.PSInvalidOperationException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 82971, 83019);
                    return 0;
                }


                int
                f_1634_83115_83152(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 83115, 83152);
                    return 0;
                }


                string[]
                f_1634_81992_82011_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 81992, 82011);
                    return return_v;
                }


                System.Management.Automation.Remoting.DISCPowerShellConfiguration
                f_1634_83362_83419(string
                configFile, System.Func<string, bool>
                roleVerifier)
                {
                    var return_v = new System.Management.Automation.Remoting.DISCPowerShellConfiguration(configFile, roleVerifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 83362, 83419);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1634_83485_83523(System.Management.Automation.Remoting.DISCPowerShellConfiguration
                this_param)
                {
                    var return_v = this_param.ConfigHash;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 83485, 83523);
                    return return_v;
                }


                int
                f_1634_83542_83605(System.Management.Automation.Remoting.DISCPowerShellConfiguration
                this_param, System.Collections.IDictionary
                childConfigHash)
                {
                    this_param.MergeConfigHashIntoConfigHash(childConfigHash);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 83542, 83605);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1634_83261_83270_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 83261, 83270);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 80428, 83632);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 80428, 83632);
            }
        }

        private void MergeConfigHashIntoConfigHash(IDictionary childConfigHash)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1634, 83737, 85524);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 83833, 85513);
                    foreach (object customization in f_1634_83866_83886_I(f_1634_83866_83886(childConfigHash)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 83833, 85513);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 83920, 83974);

                        string
                        customizationString = f_1634_83949_83973(customization)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 83994, 84038);

                        var
                        customizationValue = f_1634_84019_84037()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 84130, 84786) || true) && (f_1634_84134_84178(_configHash, customizationString))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 84130, 84786);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 84220, 84321);

                            IEnumerable
                            existingValueAsCollection = f_1634_84260_84320(f_1634_84293_84319(_configHash, customization))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 84343, 84767) || true) && (existingValueAsCollection != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 84343, 84767);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 84430, 84595);
                                    foreach (object value in f_1634_84455_84480_I(existingValueAsCollection))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 84430, 84595);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 84538, 84568);

                                        f_1634_84538_84567(customizationValue, value);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 84430, 84595);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 166);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 166);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 84343, 84767);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 84343, 84767);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 84693, 84744);

                                f_1634_84693_84743(customizationValue, f_1634_84716_84742(_configHash, customization));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 84343, 84767);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 84130, 84786);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 84861, 84961);

                        IEnumerable
                        newValueAsCollection = f_1634_84896_84960(f_1634_84929_84959(childConfigHash, customization))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 84979, 85357) || true) && (newValueAsCollection != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 84979, 85357);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 85053, 85201);
                                foreach (object value in f_1634_85078_85098_I(newValueAsCollection))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 85053, 85201);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 85148, 85178);

                                    f_1634_85148_85177(customizationValue, value);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 85053, 85201);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 149);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 149);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 84979, 85357);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 84979, 85357);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 85283, 85338);

                            f_1634_85283_85337(customizationValue, f_1634_85306_85336(childConfigHash, customization));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 84979, 85357);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 85440, 85498);

                        _configHash[customization] = f_1634_85469_85497(customizationValue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 83833, 85513);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 1681);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 1681);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1634, 83737, 85524);

                System.Collections.ICollection
                f_1634_83866_83886(System.Collections.IDictionary
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 83866, 83886);
                    return return_v;
                }


                string?
                f_1634_83949_83973(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 83949, 83973);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1634_84019_84037()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 84019, 84037);
                    return return_v;
                }


                bool
                f_1634_84134_84178(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 84134, 84178);
                    return return_v;
                }


                object
                f_1634_84293_84319(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 84293, 84319);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1634_84260_84320(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerable(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 84260, 84320);
                    return return_v;
                }


                int
                f_1634_84538_84567(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 84538, 84567);
                    return 0;
                }


                System.Collections.IEnumerable
                f_1634_84455_84480_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 84455, 84480);
                    return return_v;
                }


                object
                f_1634_84716_84742(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 84716, 84742);
                    return return_v;
                }


                int
                f_1634_84693_84743(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 84693, 84743);
                    return 0;
                }


                object
                f_1634_84929_84959(System.Collections.IDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 84929, 84959);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1634_84896_84960(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerable(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 84896, 84960);
                    return return_v;
                }


                int
                f_1634_85148_85177(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 85148, 85177);
                    return 0;
                }


                System.Collections.IEnumerable
                f_1634_85078_85098_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 85078, 85098);
                    return return_v;
                }


                object
                f_1634_85306_85336(System.Collections.IDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 85306, 85336);
                    return return_v;
                }


                int
                f_1634_85283_85337(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 85283, 85337);
                    return 0;
                }


                object[]
                f_1634_85469_85497(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 85469, 85497);
                    return return_v;
                }


                System.Collections.ICollection
                f_1634_83866_83886_I(System.Collections.ICollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 83866, 83886);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 83737, 85524);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 83737, 85524);
            }
        }

        private string GetRoleCapabilityPath(string roleCapability)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1634, 85536, 87475);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 85620, 85644);

                string
                moduleName = "*"
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 85658, 85913) || true) && (f_1634_85662_85690(roleCapability, '\\') != -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 85658, 85913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 85730, 85804);

                    string[]
                    components = f_1634_85752_85803(roleCapability, Utils.Separators.Backslash, 2)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 85822, 85849);

                    moduleName = components[0];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 85867, 85898);

                    roleCapability = components[1];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 85658, 85913);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 85990, 86084);

                string[]
                modulePaths = f_1634_86013_86083(f_1634_86013_86045(), Utils.Separators.PathSeparator)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 86098, 87436);
                    foreach (string path in f_1634_86122_86133_I(modulePaths))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 86098, 87436);
                        try
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 86274, 87010);
                                foreach (string directory in f_1634_86303_86351_I(f_1634_86303_86351(path, moduleName)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 86274, 87010);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 86401, 86475);

                                    string
                                    roleCapabilitiesPath = f_1634_86431_86474(directory, "RoleCapabilities")
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 86501, 86987) || true) && (f_1634_86505_86543(roleCapabilitiesPath))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 86501, 86987);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 86727, 86960);
                                            foreach (string roleCapabilityPath in f_1634_86765_86837_I(f_1634_86765_86837(roleCapabilitiesPath, roleCapability + ".psrc")))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 86727, 86960);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 86903, 86929);

                                                return roleCapabilityPath;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 86727, 86960);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 234);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 234);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 86501, 86987);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 86274, 87010);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 737);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 737);
                            }
                        }
                        catch (IOException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 87047, 87217);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 87047, 87217);
                            // Could not enumerate the directories for a broken module path element. Just try the next.
                        }
                        catch (UnauthorizedAccessException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1634, 87235, 87421);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1634, 87235, 87421);
                            // Could not enumerate the directories for a broken module path element. Just try the next.
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 86098, 87436);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 1339);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 1339);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 87452, 87464);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1634, 85536, 87475);

                int
                f_1634_85662_85690(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 85662, 85690);
                    return return_v;
                }


                string[]
                f_1634_85752_85803(string
                this_param, char[]
                separator, int
                count)
                {
                    var return_v = this_param.Split(separator, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 85752, 85803);
                    return return_v;
                }


                string
                f_1634_86013_86045()
                {
                    var return_v = ModuleIntrinsics.GetModulePath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 86013, 86045);
                    return return_v;
                }


                string[]
                f_1634_86013_86083(string
                this_param, params char[]
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 86013, 86083);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1634_86303_86351(string
                path, string
                searchPattern)
                {
                    var return_v = Directory.EnumerateDirectories(path, searchPattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 86303, 86351);
                    return return_v;
                }


                string
                f_1634_86431_86474(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 86431, 86474);
                    return return_v;
                }


                bool
                f_1634_86505_86543(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 86505, 86543);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1634_86765_86837(string
                path, string
                searchPattern)
                {
                    var return_v = Directory.EnumerateFiles(path, searchPattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 86765, 86837);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1634_86765_86837_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 86765, 86837);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1634_86303_86351_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 86303, 86351);
                    return return_v;
                }


                string[]
                f_1634_86122_86133_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 86122, 86133);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 85536, 87475);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 85536, 87475);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override InitialSessionState GetInitialSessionState(PSSenderInfo senderInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1634, 87693, 109829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 87801, 87832);

                InitialSessionState
                iss = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 87897, 87984);

                string
                initialSessionState = f_1634_87926_87983(_configHash, ConfigFileConstants.SessionType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 87998, 88044);

                SessionType
                sessionType = SessionType.Default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 88058, 88157);

                bool
                cmdletVisibilityApplied = f_1634_88089_88156(this, ConfigFileConstants.VisibleCmdlets)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 88171, 88274);

                bool
                functionVisibilityApplied = f_1634_88204_88273(this, ConfigFileConstants.VisibleFunctions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 88288, 88386);

                bool
                aliasVisibilityApplied = f_1634_88318_88385(this, ConfigFileConstants.VisibleAliases)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 88400, 88503);

                bool
                providerVisibilityApplied = f_1634_88433_88502(this, ConfigFileConstants.VisibleProviders)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 88517, 88567);

                bool
                processDefaultSessionStateVisibility = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 88583, 89492) || true) && (!f_1634_88588_88629(initialSessionState))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 88583, 89492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 88663, 88749);

                    sessionType = (SessionType)f_1634_88690_88748(typeof(SessionType), initialSessionState, true);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 88769, 89306) || true) && (sessionType == SessionType.Empty)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 88769, 89306);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 88847, 88882);

                        iss = f_1634_88853_88881();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 88769, 89306);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 88769, 89306);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 88924, 89306) || true) && (sessionType == SessionType.RestrictedRemoteServer)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 88924, 89306);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 89019, 89096);

                            iss = f_1634_89025_89095(SessionCapabilities.RemoteServer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 88924, 89306);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 88924, 89306);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 89178, 89221);

                            iss = f_1634_89184_89220();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 89243, 89287);

                            processDefaultSessionStateVisibility = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 88924, 89306);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 88769, 89306);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 88583, 89492);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 88583, 89492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 89372, 89415);

                    iss = f_1634_89378_89414();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 89433, 89477);

                    processDefaultSessionStateVisibility = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 88583, 89492);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 89508, 90244) || true) && (cmdletVisibilityApplied || (DynAbs.Tracing.TraceSender.Expression_False(1634, 89512, 89564) || functionVisibilityApplied) || (DynAbs.Tracing.TraceSender.Expression_False(1634, 89512, 89590) || aliasVisibilityApplied) || (DynAbs.Tracing.TraceSender.Expression_False(1634, 89512, 89619) || providerVisibilityApplied) || (DynAbs.Tracing.TraceSender.Expression_False(1634, 89512, 89716) || f_1634_89640_89716(this, ConfigFileConstants.VisibleExternalCommands)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 89508, 90244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 89750, 89817);

                    iss.DefaultCommandVisibility = SessionStateEntryVisibility.Private;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 89977, 90229) || true) && (processDefaultSessionStateVisibility)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 89977, 90229);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 90059, 90210);
                            foreach (var cmd in f_1634_90079_90091_I(f_1634_90079_90091(iss)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 90059, 90210);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 90141, 90187);

                                cmd.Visibility = f_1634_90158_90186(iss);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 90059, 90210);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 152);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 152);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 89977, 90229);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 89508, 90244);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 90290, 91543) || true) && (providerVisibilityApplied)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 90290, 91543);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 90353, 90443);

                    string[]
                    providers = f_1634_90374_90442(f_1634_90392_90441(_configHash, ConfigFileConstants.VisibleProviders))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 90463, 91528) || true) && (providers != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 90463, 91528);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 90526, 90640);

                        System.Collections.Generic.HashSet<string>
                        addedProviders = f_1634_90586_90639(f_1634_90606_90638())
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 90662, 91509);
                            foreach (string provider in f_1634_90690_90699_I(providers))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 90662, 91509);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 90749, 91486) || true) && (!f_1634_90754_90784(provider))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 90749, 91486);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 90932, 90990);

                                    var
                                    providersFound = f_1634_90953_90989(f_1634_90953_90966(iss), provider)
                                    ;
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 91022, 91459);
                                        foreach (var providerFound in f_1634_91052_91066_I(providersFound))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 91022, 91459);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 91132, 91428) || true) && (!f_1634_91137_91180(addedProviders, f_1634_91161_91179(providerFound)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 91132, 91428);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 91254, 91293);

                                                f_1634_91254_91292(addedProviders, f_1634_91273_91291(providerFound));
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 91331, 91393);

                                                providerFound.Visibility = SessionStateEntryVisibility.Public;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 91132, 91428);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 91022, 91459);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 438);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 438);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 90749, 91486);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 90662, 91509);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 848);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 848);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 90463, 91528);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 90290, 91543);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 91604, 92083) || true) && (f_1634_91608_91669(_configHash, ConfigFileConstants.AssembliesToLoad))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 91604, 92083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 91703, 91794);

                    string[]
                    assemblies = f_1634_91725_91793(f_1634_91743_91792(_configHash, ConfigFileConstants.AssembliesToLoad))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 91814, 92068) || true) && (assemblies != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 91814, 92068);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 91878, 92049);
                            foreach (string assembly in f_1634_91906_91916_I(assemblies))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 91878, 92049);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 91966, 92026);

                                f_1634_91966_92025(f_1634_91966_91980(iss), f_1634_91985_92024(assembly));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 91878, 92049);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 172);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 172);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 91814, 92068);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 91604, 92083);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 92099, 95384) || true) && (f_1634_92103_92163(_configHash, ConfigFileConstants.ModulesToImport))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 92099, 95384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 92197, 92408);

                    object[]
                    modules = f_1634_92216_92407(f_1634_92244_92292(_configHash, ConfigFileConstants.ModulesToImport), new Type[] { typeof(string), typeof(Hashtable) })
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 92426, 92932) || true) && ((f_1634_92431_92479(_configHash, ConfigFileConstants.ModulesToImport) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1634, 92430, 92509) && (modules == null)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 92426, 92932);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 92551, 92709);

                        string
                        message = f_1634_92568_92708(f_1634_92586_92645(), ConfigFileConstants.ModulesToImport)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 92731, 92806);

                        PSInvalidOperationException
                        ioe = f_1634_92765_92805(message)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 92828, 92879);

                        f_1634_92828_92878(ioe, "InvalidModulesToImportKeyEntries");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 92903, 92913);

                        throw ioe;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 92426, 92932);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 92952, 95369) || true) && (modules != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 92952, 95369);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 93013, 93101);

                        Collection<ModuleSpecification>
                        modulesToImport = f_1634_93063_93100()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 93123, 95290);
                            foreach (object module in f_1634_93149_93156_I(modules))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 93123, 95290);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 93206, 93244);

                                ModuleSpecification
                                moduleSpec = null
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 93270, 93307);

                                string
                                moduleName = module as string
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 93333, 93859) || true) && (!f_1634_93338_93370(moduleName))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 93333, 93859);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 93428, 93477);

                                    moduleSpec = f_1634_93441_93476(moduleName);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 93333, 93859);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 93333, 93859);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 93591, 93634);

                                    Hashtable
                                    moduleHash = module as Hashtable
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 93664, 93832) || true) && (moduleHash != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 93664, 93832);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 93752, 93801);

                                        moduleSpec = f_1634_93765_93800(moduleHash);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 93664, 93832);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 93333, 93859);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 93957, 95267) || true) && (moduleSpec != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 93957, 95267);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 94037, 95240) || true) && (f_1634_94041_94186(InitialSessionState.CoreModule, f_1634_94087_94102(moduleSpec), StringComparison.OrdinalIgnoreCase))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 94037, 95240);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 94252, 94890) || true) && (sessionType == SessionType.Empty)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 94252, 94890);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 94830, 94855);

                                            f_1634_94830_94854(                                    // Win8: 627752 Cannot load microsoft.powershell.core module as part of DISC
                                                                                                   // Convert Microsoft.PowerShell.Core module -> Microsoft.PowerShell.Core snapin.
                                                                                                   // Doing this Import only in SessionType.Empty case, because other cases already do this.
                                                                                                   // In V3, Microsoft.PowerShell.Core module is not installed externally.
                                                                                iss);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 94252, 94890);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 94037, 95240);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 94037, 95240);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 95177, 95209);

                                        f_1634_95177_95208(modulesToImport, moduleSpec);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 94037, 95240);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 93957, 95267);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 93123, 95290);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 2168);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 2168);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 95314, 95350);

                        f_1634_95314_95349(
                                            iss, modulesToImport);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 92952, 95369);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 92099, 95384);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 95431, 96270) || true) && (f_1634_95435_95494(_configHash, ConfigFileConstants.VisibleCmdlets))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 95431, 96270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 95528, 95738);

                    object[]
                    cmdlets = f_1634_95547_95737(f_1634_95575_95622(_configHash, ConfigFileConstants.VisibleCmdlets), new Type[] { typeof(string), typeof(Hashtable) })
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 95758, 96198) || true) && (cmdlets == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 95758, 96198);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 95819, 95976);

                        string
                        message = f_1634_95836_95975(f_1634_95854_95913(), ConfigFileConstants.VisibleCmdlets)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 95998, 96073);

                        PSInvalidOperationException
                        ioe = f_1634_96032_96072(message)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 96095, 96145);

                        f_1634_96095_96144(ioe, "InvalidVisibleCmdletsKeyEntries");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 96169, 96179);

                        throw ioe;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 95758, 96198);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 96218, 96255);

                    f_1634_96218_96254(iss, cmdlets);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 95431, 96270);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 96286, 97361) || true) && (f_1634_96290_96351(_configHash, ConfigFileConstants.AliasDefinitions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 96286, 97361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 96385, 96479);

                    Hashtable[]
                    aliases = f_1634_96407_96478(f_1634_96428_96477(_configHash, ConfigFileConstants.AliasDefinitions))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 96499, 97346) || true) && (aliases != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 96499, 97346);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 96560, 97327);
                            foreach (Hashtable alias in f_1634_96588_96595_I(aliases))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 96560, 97327);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 96645, 96736);

                                SessionStateAliasEntry
                                entry = f_1634_96676_96735(this, alias, aliasVisibilityApplied)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 96764, 97304) || true) && (entry != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 96764, 97304);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 97024, 97221) || true) && (f_1634_97028_97052(f_1634_97028_97040(iss), f_1634_97041_97051(entry)) != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 97024, 97221);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 97126, 97190);

                                        f_1634_97126_97189(f_1634_97126_97138(iss), f_1634_97146_97156(entry), typeof(SessionStateAliasEntry));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 97024, 97221);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 97253, 97277);

                                    f_1634_97253_97276(f_1634_97253_97265(iss), entry);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 96764, 97304);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 96560, 97327);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 768);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 768);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 96499, 97346);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 96286, 97361);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 97377, 98850) || true) && (f_1634_97381_97440(_configHash, ConfigFileConstants.VisibleAliases))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 97377, 98850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 97474, 97588);

                    string[]
                    aliases = f_1634_97493_97587(f_1634_97539_97586(_configHash, ConfigFileConstants.VisibleAliases))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 97608, 98835) || true) && (aliases != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 97608, 98835);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 97669, 98816);
                            foreach (string alias in f_1634_97694_97701_I(aliases))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 97669, 98816);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 97751, 98793) || true) && (!f_1634_97756_97783(alias))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 97751, 98793);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 97841, 97860);

                                    bool
                                    found = false
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 97978, 98066);

                                    Collection<SessionStateCommandEntry>
                                    existingEntries = f_1634_98033_98065(f_1634_98033_98045(iss), alias)
                                    ;
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 98096, 98532);
                                        foreach (SessionStateCommandEntry existingEntry in f_1634_98147_98162_I(existingEntries))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 98096, 98532);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 98228, 98501) || true) && (f_1634_98232_98257(existingEntry) == CommandTypes.Alias)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 98228, 98501);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 98353, 98415);

                                                existingEntry.Visibility = SessionStateEntryVisibility.Public;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 98453, 98466);

                                                found = true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 98228, 98501);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 98096, 98532);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 437);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 437);
                                    }
                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 98564, 98766) || true) && (!found || (DynAbs.Tracing.TraceSender.Expression_False(1634, 98568, 98627) || f_1634_98578_98627(alias)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 98564, 98766);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 98693, 98735);

                                        f_1634_98693_98734(f_1634_98693_98723(iss), alias);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 98564, 98766);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 97751, 98793);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 97669, 98816);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 1148);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 1148);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 97608, 98835);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 97377, 98850);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 98866, 99554) || true) && (f_1634_98870_98934(_configHash, ConfigFileConstants.FunctionDefinitions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 98866, 99554);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 98968, 99067);

                    Hashtable[]
                    functions = f_1634_98992_99066(f_1634_99013_99065(_configHash, ConfigFileConstants.FunctionDefinitions))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 99087, 99539) || true) && (functions != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 99087, 99539);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 99150, 99520);
                            foreach (Hashtable function in f_1634_99181_99190_I(functions))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 99150, 99520);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 99240, 99343);

                                SessionStateFunctionEntry
                                entry = f_1634_99274_99342(this, function, functionVisibilityApplied)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 99371, 99497) || true) && (entry != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 99371, 99497);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 99446, 99470);

                                    f_1634_99446_99469(f_1634_99446_99458(iss), entry);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 99371, 99497);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 99150, 99520);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 371);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 371);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 99087, 99539);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 98866, 99554);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 99570, 100423) || true) && (f_1634_99574_99635(_configHash, ConfigFileConstants.VisibleFunctions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 99570, 100423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 99669, 99883);

                    object[]
                    functions = f_1634_99690_99882(f_1634_99718_99767(_configHash, ConfigFileConstants.VisibleFunctions), new Type[] { typeof(string), typeof(Hashtable) })
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 99903, 100349) || true) && (functions == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 99903, 100349);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 99966, 100125);

                        string
                        message = f_1634_99983_100124(f_1634_100001_100060(), ConfigFileConstants.VisibleFunctions)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 100147, 100222);

                        PSInvalidOperationException
                        ioe = f_1634_100181_100221(message)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 100244, 100296);

                        f_1634_100244_100295(ioe, "InvalidVisibleFunctionsKeyEntries");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 100320, 100330);

                        throw ioe;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 99903, 100349);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 100369, 100408);

                    f_1634_100369_100407(iss, functions);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 99570, 100423);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 100439, 101486) || true) && (f_1634_100443_100507(_configHash, ConfigFileConstants.VariableDefinitions))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 100439, 101486);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 100541, 100640);

                    Hashtable[]
                    variables = f_1634_100565_100639(f_1634_100586_100638(_configHash, ConfigFileConstants.VariableDefinitions))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 100660, 101471) || true) && (variables != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 100660, 101471);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 100723, 101452);
                            foreach (Hashtable variable in f_1634_100754_100763_I(variables))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 100723, 101452);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 100813, 101152) || true) && (f_1634_100817_100877(variable, ConfigFileConstants.VariableValueToken) && (DynAbs.Tracing.TraceSender.Expression_True(1634, 100817, 100985) && ((f_1634_100912_100960(variable, ConfigFileConstants.VariableValueToken) as ScriptBlock) != null)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 100813, 101152);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 101043, 101086);

                                    f_1634_101043_101085(f_1634_101043_101071(iss), variable);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 101116, 101125);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 100813, 101152);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 101180, 101274);

                                SessionStateVariableEntry
                                entry = f_1634_101214_101273(this, variable, f_1634_101256_101272(iss))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 101302, 101429) || true) && (entry != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 101302, 101429);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 101377, 101402);

                                    f_1634_101377_101401(f_1634_101377_101390(iss), entry);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 101302, 101429);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 100723, 101452);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 730);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 730);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 100660, 101471);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 100439, 101486);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 101502, 102267) || true) && (f_1634_101506_101571(_configHash, ConfigFileConstants.EnvironmentVariables))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 101502, 102267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 101605, 101709);

                    Hashtable[]
                    variablesList = f_1634_101633_101708(f_1634_101654_101707(_configHash, ConfigFileConstants.EnvironmentVariables))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 101729, 102252) || true) && (variablesList != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 101729, 102252);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 101796, 102233);
                            foreach (Hashtable variables in f_1634_101828_101841_I(variablesList))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 101796, 102233);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 101891, 102210);
                                    foreach (DictionaryEntry variable in f_1634_101928_101937_I(variables))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 101891, 102210);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 101995, 102117);

                                        SessionStateVariableEntry
                                        entry = f_1634_102029_102116(f_1634_102059_102082(variable.Key), f_1634_102084_102109(variable.Value), null)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 102147, 102183);

                                        f_1634_102147_102182(f_1634_102147_102171(iss), entry);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 101891, 102210);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 320);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 320);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 101796, 102233);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 438);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 438);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 101729, 102252);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 101502, 102267);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 102316, 102903) || true) && (f_1634_102320_102379(_configHash, ConfigFileConstants.TypesToProcess))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 102316, 102903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 102413, 102525);

                    string[]
                    types = f_1634_102430_102524(f_1634_102476_102523(_configHash, ConfigFileConstants.TypesToProcess))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 102545, 102888) || true) && (types != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 102545, 102888);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 102604, 102869);
                            foreach (string type in f_1634_102628_102633_I(types))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 102604, 102869);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 102683, 102846) || true) && (!f_1634_102688_102714(type))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 102683, 102846);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 102772, 102819);

                                    f_1634_102772_102818(f_1634_102772_102781(iss), f_1634_102786_102817(type));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 102683, 102846);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 102604, 102869);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 266);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 266);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 102545, 102888);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 102316, 102903);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 102954, 103561) || true) && (f_1634_102958_103019(_configHash, ConfigFileConstants.FormatsToProcess))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 102954, 103561);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 103053, 103169);

                    string[]
                    formats = f_1634_103072_103168(f_1634_103118_103167(_configHash, ConfigFileConstants.FormatsToProcess))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 103189, 103546) || true) && (formats != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 103189, 103546);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 103250, 103527);
                            foreach (string format in f_1634_103276_103283_I(formats))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 103250, 103527);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 103333, 103504) || true) && (!f_1634_103338_103366(format))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 103333, 103504);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 103424, 103477);

                                    f_1634_103424_103476(f_1634_103424_103435(iss), f_1634_103440_103475(format));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 103333, 103504);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 103250, 103527);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 278);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 278);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 103189, 103546);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 102954, 103561);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 103615, 104857) || true) && (f_1634_103619_103687(_configHash, ConfigFileConstants.VisibleExternalCommands))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 103615, 104857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 103721, 103825);

                    string[]
                    externalCommands = f_1634_103749_103824(f_1634_103767_103823(_configHash, ConfigFileConstants.VisibleExternalCommands))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 103843, 104842) || true) && (externalCommands != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 103843, 104842);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 103913, 104823);
                            foreach (string command in f_1634_103940_103956_I(externalCommands))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 103913, 104823);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 104006, 104800) || true) && (f_1634_104010_104070(command, ".ps1", StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 104006, 104800);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 104128, 104253);

                                    f_1634_104128_104252(f_1634_104128_104140(iss), f_1634_104179_104251(command, SessionStateEntryVisibility.Public));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 104006, 104800);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 104006, 104800);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 104367, 104611) || true) && (command == "*")
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 104367, 104611);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 104451, 104580);

                                        f_1634_104451_104579(f_1634_104451_104463(iss), f_1634_104506_104578(command, SessionStateEntryVisibility.Public));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 104367, 104611);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 104643, 104773);

                                    f_1634_104643_104772(f_1634_104643_104655(iss), f_1634_104694_104771(command, SessionStateEntryVisibility.Public));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 104006, 104800);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 103913, 104823);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 911);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 911);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 103843, 104842);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 103615, 104857);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 104914, 105520) || true) && (f_1634_104918_104979(_configHash, ConfigFileConstants.ScriptsToProcess))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 104914, 105520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 105013, 105136);

                    string[]
                    startupScripts = f_1634_105039_105135(f_1634_105085_105134(_configHash, ConfigFileConstants.ScriptsToProcess))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 105156, 105505) || true) && (startupScripts != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 105156, 105505);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 105224, 105486);
                            foreach (string script in f_1634_105250_105264_I(startupScripts))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 105224, 105486);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 105314, 105463) || true) && (!f_1634_105319_105347(script))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 105314, 105463);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 105405, 105436);

                                    f_1634_105405_105435(f_1634_105405_105423(iss), script);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 105314, 105463);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 105224, 105486);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 263);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 263);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 105156, 105505);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 104914, 105520);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 105579, 107315) || true) && (cmdletVisibilityApplied || (DynAbs.Tracing.TraceSender.Expression_False(1634, 105583, 105635) || functionVisibilityApplied) || (DynAbs.Tracing.TraceSender.Expression_False(1634, 105583, 105661) || aliasVisibilityApplied) || (DynAbs.Tracing.TraceSender.Expression_False(1634, 105583, 105690) || providerVisibilityApplied))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 105579, 107315);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 105724, 106071) || true) && (sessionType == SessionType.Default)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 105724, 106071);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 105984, 106052);

                        f_1634_105984_106051(                    // autoloading preference is none, so modules cannot be autoloaded. Since the session type is default,
                                                                 // load PowerShell default modules
                                            iss, f_1634_106007_106050(InitialSessionState.EngineModules));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 105724, 106071);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 106091, 106550) || true) && (cmdletVisibilityApplied)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 106091, 106550);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 106280, 106334);

                        var
                        importModuleEntry = f_1634_106304_106333(f_1634_106304_106316(iss), "Import-Module")
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 106356, 106531) || true) && (f_1634_106360_106383(importModuleEntry) == 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 106356, 106531);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 106438, 106508);

                            f_1634_106438_106458(importModuleEntry, 0).Visibility = SessionStateEntryVisibility.Private;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 106356, 106531);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 106091, 106550);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 106570, 107034) || true) && (aliasVisibilityApplied)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 106570, 107034);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 106758, 106808);

                        var
                        importModuleAliasEntry = f_1634_106787_106807(f_1634_106787_106799(iss), "ipmo")
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 106830, 107015) || true) && (f_1634_106834_106862(importModuleAliasEntry) == 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 106830, 107015);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 106917, 106992);

                            f_1634_106917_106942(importModuleAliasEntry, 0).Visibility = SessionStateEntryVisibility.Private;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 106830, 107015);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 106570, 107034);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 107054, 107121);

                    iss.DefaultCommandVisibility = SessionStateEntryVisibility.Private;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 107139, 107300);

                    f_1634_107139_107299(f_1634_107139_107152(iss), f_1634_107157_107298(SpecialVariables.PSModuleAutoLoading, PSModuleAutoLoadingPreference.None, string.Empty, ScopedItemOptions.None));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 105579, 107315);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 107372, 107780) || true) && (f_1634_107376_107436(_configHash, ConfigFileConstants.ExecutionPolicy))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 107372, 107780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 107470, 107709);

                    Microsoft.PowerShell.ExecutionPolicy
                    executionPolicy = (Microsoft.PowerShell.ExecutionPolicy)f_1634_107563_107708(typeof(Microsoft.PowerShell.ExecutionPolicy), f_1634_107642_107701(f_1634_107642_107690(_configHash, ConfigFileConstants.ExecutionPolicy)), true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 107727, 107765);

                    iss.ExecutionPolicy = executionPolicy;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 107372, 107780);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 107834, 108248) || true) && (f_1634_107838_107895(_configHash, ConfigFileConstants.LanguageMode))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 107834, 108248);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 107929, 108183);

                    System.Management.Automation.PSLanguageMode
                    languageMode = (System.Management.Automation.PSLanguageMode)f_1634_108033_108182(typeof(System.Management.Automation.PSLanguageMode), f_1634_108119_108175(f_1634_108119_108164(_configHash, ConfigFileConstants.LanguageMode)), true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 108201, 108233);

                    iss.LanguageMode = languageMode;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 107834, 108248);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 108309, 108516) || true) && (f_1634_108313_108377(_configHash, ConfigFileConstants.TranscriptDirectory))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 108309, 108516);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 108411, 108501);

                    iss.TranscriptDirectory = f_1634_108437_108500(f_1634_108437_108489(_configHash, ConfigFileConstants.TranscriptDirectory));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 108309, 108516);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 108567, 109791) || true) && (f_1634_108571_108630(_configHash, ConfigFileConstants.MountUserDrive))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 108567, 109791);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 108664, 109776) || true) && (f_1634_108668_108764(f_1634_108686_108733(_configHash, ConfigFileConstants.MountUserDrive), f_1634_108735_108763()) == true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 108664, 109776);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 108814, 108842);

                        iss.UserDriveEnabled = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 108864, 108952);

                        iss.UserDriveUserName = (DynAbs.Tracing.TraceSender.Conditional_F1(1634, 108888, 108908) || (((senderInfo != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1634, 108911, 108944)) || DynAbs.Tracing.TraceSender.Conditional_F3(1634, 108947, 108951))) ? f_1634_108911_108944(f_1634_108911_108939(f_1634_108911_108930(senderInfo))) : null;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 109038, 109446) || true) && (f_1634_109042_109103(_configHash, ConfigFileConstants.UserDriveMaxSize))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 109038, 109446);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 109153, 109244);

                            long
                            userDriveMaxSize = f_1634_109177_109243(f_1634_109193_109242(_configHash, ConfigFileConstants.UserDriveMaxSize))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 109270, 109423) || true) && (userDriveMaxSize > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 109270, 109423);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 109352, 109396);

                                iss.UserDriveMaximumSize = userDriveMaxSize;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 109270, 109423);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 109038, 109446);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 109578, 109621);

                        iss.EnforceInputParameterValidation = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 109717, 109757);

                        f_1634_109717_109756(iss);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 108664, 109776);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 108567, 109791);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 109807, 109818);

                return iss;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1634, 87693, 109829);

                string
                f_1634_87926_87983(System.Collections.Hashtable
                table, string
                key)
                {
                    var return_v = TryGetValue(table, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 87926, 87983);
                    return return_v;
                }


                bool
                f_1634_88089_88156(System.Management.Automation.Remoting.DISCPowerShellConfiguration
                this_param, string
                configFileKey)
                {
                    var return_v = this_param.IsNonDefaultVisibilitySpecified(configFileKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 88089, 88156);
                    return return_v;
                }


                bool
                f_1634_88204_88273(System.Management.Automation.Remoting.DISCPowerShellConfiguration
                this_param, string
                configFileKey)
                {
                    var return_v = this_param.IsNonDefaultVisibilitySpecified(configFileKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 88204, 88273);
                    return return_v;
                }


                bool
                f_1634_88318_88385(System.Management.Automation.Remoting.DISCPowerShellConfiguration
                this_param, string
                configFileKey)
                {
                    var return_v = this_param.IsNonDefaultVisibilitySpecified(configFileKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 88318, 88385);
                    return return_v;
                }


                bool
                f_1634_88433_88502(System.Management.Automation.Remoting.DISCPowerShellConfiguration
                this_param, string
                configFileKey)
                {
                    var return_v = this_param.IsNonDefaultVisibilitySpecified(configFileKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 88433, 88502);
                    return return_v;
                }


                bool
                f_1634_88588_88629(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 88588, 88629);
                    return return_v;
                }


                object
                f_1634_88690_88748(System.Type
                enumType, string
                value, bool
                ignoreCase)
                {
                    var return_v = Enum.Parse(enumType, value, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 88690, 88748);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_1634_88853_88881()
                {
                    var return_v = InitialSessionState.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 88853, 88881);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_1634_89025_89095(System.Management.Automation.SessionCapabilities
                sessionCapabilities)
                {
                    var return_v = InitialSessionState.CreateRestricted(sessionCapabilities);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 89025, 89095);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_1634_89184_89220()
                {
                    var return_v = InitialSessionState.CreateDefault2();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 89184, 89220);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionState
                f_1634_89378_89414()
                {
                    var return_v = InitialSessionState.CreateDefault2();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 89378, 89414);
                    return return_v;
                }


                bool
                f_1634_89640_89716(System.Management.Automation.Remoting.DISCPowerShellConfiguration
                this_param, string
                configFileKey)
                {
                    var return_v = this_param.IsNonDefaultVisibilitySpecified(configFileKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 89640, 89716);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1634_90079_90091(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 90079, 90091);
                    return return_v;
                }


                System.Management.Automation.SessionStateEntryVisibility
                f_1634_90158_90186(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.DefaultCommandVisibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 90158, 90186);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1634_90079_90091_I(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 90079, 90091);
                    return return_v;
                }


                object
                f_1634_90392_90441(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 90392, 90441);
                    return return_v;
                }


                string[]
                f_1634_90374_90442(object
                hashObj)
                {
                    var return_v = TryGetStringArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 90374, 90442);
                    return return_v;
                }


                System.StringComparer
                f_1634_90606_90638()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 90606, 90638);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1634_90586_90639(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 90586, 90639);
                    return return_v;
                }


                bool
                f_1634_90754_90784(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 90754, 90784);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateProviderEntry>
                f_1634_90953_90966(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Providers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 90953, 90966);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateProviderEntry>
                f_1634_90953_90989(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateProviderEntry>
                this_param, string
                name)
                {
                    var return_v = this_param.LookUpByName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 90953, 90989);
                    return return_v;
                }


                string
                f_1634_91161_91179(System.Management.Automation.Runspaces.SessionStateProviderEntry
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 91161, 91179);
                    return return_v;
                }


                bool
                f_1634_91137_91180(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 91137, 91180);
                    return return_v;
                }


                string
                f_1634_91273_91291(System.Management.Automation.Runspaces.SessionStateProviderEntry
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 91273, 91291);
                    return return_v;
                }


                bool
                f_1634_91254_91292(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 91254, 91292);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateProviderEntry>
                f_1634_91052_91066_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateProviderEntry>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 91052, 91066);
                    return return_v;
                }


                string[]
                f_1634_90690_90699_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 90690, 90699);
                    return return_v;
                }


                bool
                f_1634_91608_91669(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 91608, 91669);
                    return return_v;
                }


                object
                f_1634_91743_91792(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 91743, 91792);
                    return return_v;
                }


                string[]
                f_1634_91725_91793(object
                hashObj)
                {
                    var return_v = TryGetStringArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 91725, 91793);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateAssemblyEntry>
                f_1634_91966_91980(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Assemblies;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 91966, 91980);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateAssemblyEntry
                f_1634_91985_92024(string
                name)
                {
                    var return_v = new System.Management.Automation.Runspaces.SessionStateAssemblyEntry(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 91985, 92024);
                    return return_v;
                }


                int
                f_1634_91966_92025(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateAssemblyEntry>
                this_param, System.Management.Automation.Runspaces.SessionStateAssemblyEntry
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 91966, 92025);
                    return 0;
                }


                string[]
                f_1634_91906_91916_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 91906, 91916);
                    return return_v;
                }


                bool
                f_1634_92103_92163(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 92103, 92163);
                    return return_v;
                }


                object
                f_1634_92244_92292(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 92244, 92292);
                    return return_v;
                }


                object[]
                f_1634_92216_92407(object
                hashObj, System.Type[]
                types)
                {
                    var return_v = TryGetObjectsOfType<object>(hashObj, (System.Collections.Generic.IEnumerable<System.Type>)types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 92216, 92407);
                    return return_v;
                }


                object
                f_1634_92431_92479(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 92431, 92479);
                    return return_v;
                }


                string
                f_1634_92586_92645()
                {
                    var return_v = RemotingErrorIdStrings.DISCTypeMustBeStringOrHashtableArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 92586, 92645);
                    return return_v;
                }


                string
                f_1634_92568_92708(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 92568, 92708);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1634_92765_92805(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 92765, 92805);
                    return return_v;
                }


                int
                f_1634_92828_92878(System.Management.Automation.PSInvalidOperationException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 92828, 92878);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<Microsoft.PowerShell.Commands.ModuleSpecification>
                f_1634_93063_93100()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<Microsoft.PowerShell.Commands.ModuleSpecification>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 93063, 93100);
                    return return_v;
                }


                bool
                f_1634_93338_93370(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 93338, 93370);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification
                f_1634_93441_93476(string
                moduleName)
                {
                    var return_v = new Microsoft.PowerShell.Commands.ModuleSpecification(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 93441, 93476);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification
                f_1634_93765_93800(System.Collections.Hashtable
                moduleSpecification)
                {
                    var return_v = new Microsoft.PowerShell.Commands.ModuleSpecification(moduleSpecification);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 93765, 93800);
                    return return_v;
                }


                string
                f_1634_94087_94102(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 94087, 94102);
                    return return_v;
                }


                bool
                f_1634_94041_94186(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 94041, 94186);
                    return return_v;
                }


                System.Management.Automation.PSSnapInInfo
                f_1634_94830_94854(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.ImportCorePSSnapIn();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 94830, 94854);
                    return return_v;
                }


                int
                f_1634_95177_95208(System.Collections.ObjectModel.Collection<Microsoft.PowerShell.Commands.ModuleSpecification>
                this_param, Microsoft.PowerShell.Commands.ModuleSpecification
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 95177, 95208);
                    return 0;
                }


                object[]
                f_1634_93149_93156_I(object[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 93149, 93156);
                    return return_v;
                }


                int
                f_1634_95314_95349(System.Management.Automation.Runspaces.InitialSessionState
                this_param, System.Collections.ObjectModel.Collection<Microsoft.PowerShell.Commands.ModuleSpecification>
                modules)
                {
                    this_param.ImportPSModule((System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.ModuleSpecification>)modules);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 95314, 95349);
                    return 0;
                }


                bool
                f_1634_95435_95494(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 95435, 95494);
                    return return_v;
                }


                object
                f_1634_95575_95622(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 95575, 95622);
                    return return_v;
                }


                object[]
                f_1634_95547_95737(object
                hashObj, System.Type[]
                types)
                {
                    var return_v = TryGetObjectsOfType<object>(hashObj, (System.Collections.Generic.IEnumerable<System.Type>)types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 95547, 95737);
                    return return_v;
                }


                string
                f_1634_95854_95913()
                {
                    var return_v = RemotingErrorIdStrings.DISCTypeMustBeStringOrHashtableArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 95854, 95913);
                    return return_v;
                }


                string
                f_1634_95836_95975(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 95836, 95975);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1634_96032_96072(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 96032, 96072);
                    return return_v;
                }


                int
                f_1634_96095_96144(System.Management.Automation.PSInvalidOperationException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 96095, 96144);
                    return 0;
                }


                int
                f_1634_96218_96254(System.Management.Automation.Runspaces.InitialSessionState
                iss, object[]
                commands)
                {
                    ProcessVisibleCommands(iss, commands);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 96218, 96254);
                    return 0;
                }


                bool
                f_1634_96290_96351(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 96290, 96351);
                    return return_v;
                }


                object
                f_1634_96428_96477(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 96428, 96477);
                    return return_v;
                }


                System.Collections.Hashtable[]
                f_1634_96407_96478(object
                hashObj)
                {
                    var return_v = TryGetHashtableArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 96407, 96478);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateAliasEntry
                f_1634_96676_96735(System.Management.Automation.Remoting.DISCPowerShellConfiguration
                this_param, System.Collections.Hashtable
                alias, bool
                isAliasVisibilityDefined)
                {
                    var return_v = this_param.CreateSessionStateAliasEntry(alias, isAliasVisibilityDefined);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 96676, 96735);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1634_97028_97040(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 97028, 97040);
                    return return_v;
                }


                string
                f_1634_97041_97051(System.Management.Automation.Runspaces.SessionStateAliasEntry
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 97041, 97051);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1634_97028_97052(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 97028, 97052);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1634_97126_97138(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 97126, 97138);
                    return return_v;
                }


                string
                f_1634_97146_97156(System.Management.Automation.Runspaces.SessionStateAliasEntry
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 97146, 97156);
                    return return_v;
                }


                int
                f_1634_97126_97189(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                this_param, string
                name, System.Type
                type)
                {
                    this_param.Remove(name, (object)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 97126, 97189);
                    return 0;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1634_97253_97265(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 97253, 97265);
                    return return_v;
                }


                int
                f_1634_97253_97276(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                this_param, System.Management.Automation.Runspaces.SessionStateAliasEntry
                item)
                {
                    this_param.Add((System.Management.Automation.Runspaces.SessionStateCommandEntry)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 97253, 97276);
                    return 0;
                }


                System.Collections.Hashtable[]
                f_1634_96588_96595_I(System.Collections.Hashtable[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 96588, 96595);
                    return return_v;
                }


                bool
                f_1634_97381_97440(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 97381, 97440);
                    return return_v;
                }


                object
                f_1634_97539_97586(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 97539, 97586);
                    return return_v;
                }


                string[]
                f_1634_97493_97587(object
                hashObj)
                {
                    var return_v = DISCPowerShellConfiguration.TryGetStringArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 97493, 97587);
                    return return_v;
                }


                bool
                f_1634_97756_97783(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 97756, 97783);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1634_98033_98045(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 98033, 98045);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1634_98033_98065(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                this_param, string
                name)
                {
                    var return_v = this_param.LookUpByName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 98033, 98065);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1634_98232_98257(System.Management.Automation.Runspaces.SessionStateCommandEntry
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 98232, 98257);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1634_98147_98162_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 98147, 98162);
                    return return_v;
                }


                bool
                f_1634_98578_98627(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 98578, 98627);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1634_98693_98723(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.UnresolvedCommandsToExpose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 98693, 98723);
                    return return_v;
                }


                bool
                f_1634_98693_98734(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 98693, 98734);
                    return return_v;
                }


                string[]
                f_1634_97694_97701_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 97694, 97701);
                    return return_v;
                }


                bool
                f_1634_98870_98934(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 98870, 98934);
                    return return_v;
                }


                object
                f_1634_99013_99065(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 99013, 99065);
                    return return_v;
                }


                System.Collections.Hashtable[]
                f_1634_98992_99066(object
                hashObj)
                {
                    var return_v = TryGetHashtableArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 98992, 99066);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateFunctionEntry
                f_1634_99274_99342(System.Management.Automation.Remoting.DISCPowerShellConfiguration
                this_param, System.Collections.Hashtable
                function, bool
                isFunctionVisibilityDefined)
                {
                    var return_v = this_param.CreateSessionStateFunctionEntry(function, isFunctionVisibilityDefined);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 99274, 99342);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1634_99446_99458(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 99446, 99458);
                    return return_v;
                }


                int
                f_1634_99446_99469(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                this_param, System.Management.Automation.Runspaces.SessionStateFunctionEntry
                item)
                {
                    this_param.Add((System.Management.Automation.Runspaces.SessionStateCommandEntry)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 99446, 99469);
                    return 0;
                }


                System.Collections.Hashtable[]
                f_1634_99181_99190_I(System.Collections.Hashtable[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 99181, 99190);
                    return return_v;
                }


                bool
                f_1634_99574_99635(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 99574, 99635);
                    return return_v;
                }


                object
                f_1634_99718_99767(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 99718, 99767);
                    return return_v;
                }


                object[]
                f_1634_99690_99882(object
                hashObj, System.Type[]
                types)
                {
                    var return_v = TryGetObjectsOfType<object>(hashObj, (System.Collections.Generic.IEnumerable<System.Type>)types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 99690, 99882);
                    return return_v;
                }


                string
                f_1634_100001_100060()
                {
                    var return_v = RemotingErrorIdStrings.DISCTypeMustBeStringOrHashtableArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 100001, 100060);
                    return return_v;
                }


                string
                f_1634_99983_100124(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 99983, 100124);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1634_100181_100221(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 100181, 100221);
                    return return_v;
                }


                int
                f_1634_100244_100295(System.Management.Automation.PSInvalidOperationException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 100244, 100295);
                    return 0;
                }


                int
                f_1634_100369_100407(System.Management.Automation.Runspaces.InitialSessionState
                iss, object[]
                commands)
                {
                    ProcessVisibleCommands(iss, commands);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 100369, 100407);
                    return 0;
                }


                bool
                f_1634_100443_100507(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 100443, 100507);
                    return return_v;
                }


                object
                f_1634_100586_100638(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 100586, 100638);
                    return return_v;
                }


                System.Collections.Hashtable[]
                f_1634_100565_100639(object
                hashObj)
                {
                    var return_v = TryGetHashtableArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 100565, 100639);
                    return return_v;
                }


                bool
                f_1634_100817_100877(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 100817, 100877);
                    return return_v;
                }


                object
                f_1634_100912_100960(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 100912, 100960);
                    return return_v;
                }


                System.Collections.Generic.List<System.Collections.Hashtable>
                f_1634_101043_101071(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.DynamicVariablesToDefine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 101043, 101071);
                    return return_v;
                }


                int
                f_1634_101043_101085(System.Collections.Generic.List<System.Collections.Hashtable>
                this_param, System.Collections.Hashtable
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 101043, 101085);
                    return 0;
                }


                System.Management.Automation.PSLanguageMode
                f_1634_101256_101272(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 101256, 101272);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateVariableEntry
                f_1634_101214_101273(System.Management.Automation.Remoting.DISCPowerShellConfiguration
                this_param, System.Collections.Hashtable
                variable, System.Management.Automation.PSLanguageMode
                languageMode)
                {
                    var return_v = this_param.CreateSessionStateVariableEntry(variable, languageMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 101214, 101273);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateVariableEntry>
                f_1634_101377_101390(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 101377, 101390);
                    return return_v;
                }


                int
                f_1634_101377_101401(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateVariableEntry>
                this_param, System.Management.Automation.Runspaces.SessionStateVariableEntry
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 101377, 101401);
                    return 0;
                }


                System.Collections.Hashtable[]
                f_1634_100754_100763_I(System.Collections.Hashtable[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 100754, 100763);
                    return return_v;
                }


                bool
                f_1634_101506_101571(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 101506, 101571);
                    return return_v;
                }


                object
                f_1634_101654_101707(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 101654, 101707);
                    return return_v;
                }


                System.Collections.Hashtable[]
                f_1634_101633_101708(object
                hashObj)
                {
                    var return_v = TryGetHashtableArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 101633, 101708);
                    return return_v;
                }


                string?
                f_1634_102059_102082(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 102059, 102082);
                    return return_v;
                }


                string?
                f_1634_102084_102109(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 102084, 102109);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateVariableEntry
                f_1634_102029_102116(string
                name, string
                value, string
                description)
                {
                    var return_v = new System.Management.Automation.Runspaces.SessionStateVariableEntry(name, (object)value, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 102029, 102116);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateVariableEntry>
                f_1634_102147_102171(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.EnvironmentVariables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 102147, 102171);
                    return return_v;
                }


                int
                f_1634_102147_102182(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateVariableEntry>
                this_param, System.Management.Automation.Runspaces.SessionStateVariableEntry
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 102147, 102182);
                    return 0;
                }


                System.Collections.Hashtable
                f_1634_101928_101937_I(System.Collections.Hashtable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 101928, 101937);
                    return return_v;
                }


                System.Collections.Hashtable[]
                f_1634_101828_101841_I(System.Collections.Hashtable[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 101828, 101841);
                    return return_v;
                }


                bool
                f_1634_102320_102379(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 102320, 102379);
                    return return_v;
                }


                object
                f_1634_102476_102523(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 102476, 102523);
                    return return_v;
                }


                string[]
                f_1634_102430_102524(object
                hashObj)
                {
                    var return_v = DISCPowerShellConfiguration.TryGetStringArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 102430, 102524);
                    return return_v;
                }


                bool
                f_1634_102688_102714(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 102688, 102714);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateTypeEntry>
                f_1634_102772_102781(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Types;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 102772, 102781);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateTypeEntry
                f_1634_102786_102817(string
                fileName)
                {
                    var return_v = new System.Management.Automation.Runspaces.SessionStateTypeEntry(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 102786, 102817);
                    return return_v;
                }


                int
                f_1634_102772_102818(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateTypeEntry>
                this_param, System.Management.Automation.Runspaces.SessionStateTypeEntry
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 102772, 102818);
                    return 0;
                }


                string[]
                f_1634_102628_102633_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 102628, 102633);
                    return return_v;
                }


                bool
                f_1634_102958_103019(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 102958, 103019);
                    return return_v;
                }


                object
                f_1634_103118_103167(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 103118, 103167);
                    return return_v;
                }


                string[]
                f_1634_103072_103168(object
                hashObj)
                {
                    var return_v = DISCPowerShellConfiguration.TryGetStringArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 103072, 103168);
                    return return_v;
                }


                bool
                f_1634_103338_103366(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 103338, 103366);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateFormatEntry>
                f_1634_103424_103435(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Formats;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 103424, 103435);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateFormatEntry
                f_1634_103440_103475(string
                fileName)
                {
                    var return_v = new System.Management.Automation.Runspaces.SessionStateFormatEntry(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 103440, 103475);
                    return return_v;
                }


                int
                f_1634_103424_103476(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateFormatEntry>
                this_param, System.Management.Automation.Runspaces.SessionStateFormatEntry
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 103424, 103476);
                    return 0;
                }


                string[]
                f_1634_103276_103283_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 103276, 103283);
                    return return_v;
                }


                bool
                f_1634_103619_103687(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 103619, 103687);
                    return return_v;
                }


                object
                f_1634_103767_103823(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 103767, 103823);
                    return return_v;
                }


                string[]
                f_1634_103749_103824(object
                hashObj)
                {
                    var return_v = TryGetStringArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 103749, 103824);
                    return return_v;
                }


                bool
                f_1634_104010_104070(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.EndsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 104010, 104070);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1634_104128_104140(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 104128, 104140);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateScriptEntry
                f_1634_104179_104251(string
                path, System.Management.Automation.SessionStateEntryVisibility
                visibility)
                {
                    var return_v = new System.Management.Automation.Runspaces.SessionStateScriptEntry(path, visibility);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 104179, 104251);
                    return return_v;
                }


                int
                f_1634_104128_104252(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                this_param, System.Management.Automation.Runspaces.SessionStateScriptEntry
                item)
                {
                    this_param.Add((System.Management.Automation.Runspaces.SessionStateCommandEntry)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 104128, 104252);
                    return 0;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1634_104451_104463(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 104451, 104463);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateScriptEntry
                f_1634_104506_104578(string
                path, System.Management.Automation.SessionStateEntryVisibility
                visibility)
                {
                    var return_v = new System.Management.Automation.Runspaces.SessionStateScriptEntry(path, visibility);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 104506, 104578);
                    return return_v;
                }


                int
                f_1634_104451_104579(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                this_param, System.Management.Automation.Runspaces.SessionStateScriptEntry
                item)
                {
                    this_param.Add((System.Management.Automation.Runspaces.SessionStateCommandEntry)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 104451, 104579);
                    return 0;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1634_104643_104655(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 104643, 104655);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateApplicationEntry
                f_1634_104694_104771(string
                path, System.Management.Automation.SessionStateEntryVisibility
                visibility)
                {
                    var return_v = new System.Management.Automation.Runspaces.SessionStateApplicationEntry(path, visibility);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 104694, 104771);
                    return return_v;
                }


                int
                f_1634_104643_104772(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                this_param, System.Management.Automation.Runspaces.SessionStateApplicationEntry
                item)
                {
                    this_param.Add((System.Management.Automation.Runspaces.SessionStateCommandEntry)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 104643, 104772);
                    return 0;
                }


                string[]
                f_1634_103940_103956_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 103940, 103956);
                    return return_v;
                }


                bool
                f_1634_104918_104979(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 104918, 104979);
                    return return_v;
                }


                object
                f_1634_105085_105134(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 105085, 105134);
                    return return_v;
                }


                string[]
                f_1634_105039_105135(object
                hashObj)
                {
                    var return_v = DISCPowerShellConfiguration.TryGetStringArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 105039, 105135);
                    return return_v;
                }


                bool
                f_1634_105319_105347(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 105319, 105347);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1634_105405_105423(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.StartupScripts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 105405, 105423);
                    return return_v;
                }


                bool
                f_1634_105405_105435(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 105405, 105435);
                    return return_v;
                }


                string[]
                f_1634_105250_105264_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 105250, 105264);
                    return return_v;
                }


                string[]
                f_1634_106007_106050(System.Collections.Generic.HashSet<string>
                source)
                {
                    var return_v = source.ToArray<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 106007, 106050);
                    return return_v;
                }


                int
                f_1634_105984_106051(System.Management.Automation.Runspaces.InitialSessionState
                this_param, string[]
                name)
                {
                    this_param.ImportPSCoreModule(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 105984, 106051);
                    return 0;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1634_106304_106316(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 106304, 106316);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1634_106304_106333(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 106304, 106333);
                    return return_v;
                }


                int
                f_1634_106360_106383(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 106360, 106383);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateCommandEntry
                f_1634_106438_106458(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 106438, 106458);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1634_106787_106799(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 106787, 106799);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1634_106787_106807(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 106787, 106807);
                    return return_v;
                }


                int
                f_1634_106834_106862(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 106834, 106862);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateCommandEntry
                f_1634_106917_106942(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 106917, 106942);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateVariableEntry>
                f_1634_107139_107152(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 107139, 107152);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateVariableEntry
                f_1634_107157_107298(string
                name, System.Management.Automation.PSModuleAutoLoadingPreference
                value, string
                description, System.Management.Automation.ScopedItemOptions
                options)
                {
                    var return_v = new System.Management.Automation.Runspaces.SessionStateVariableEntry(name, (object)value, description, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 107157, 107298);
                    return return_v;
                }


                int
                f_1634_107139_107299(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateVariableEntry>
                this_param, System.Management.Automation.Runspaces.SessionStateVariableEntry
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 107139, 107299);
                    return 0;
                }


                bool
                f_1634_107376_107436(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 107376, 107436);
                    return return_v;
                }


                object
                f_1634_107642_107690(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 107642, 107690);
                    return return_v;
                }


                string?
                f_1634_107642_107701(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 107642, 107701);
                    return return_v;
                }


                object
                f_1634_107563_107708(System.Type
                enumType, string
                value, bool
                ignoreCase)
                {
                    var return_v = Enum.Parse(enumType, value, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 107563, 107708);
                    return return_v;
                }


                bool
                f_1634_107838_107895(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 107838, 107895);
                    return return_v;
                }


                object
                f_1634_108119_108164(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 108119, 108164);
                    return return_v;
                }


                string?
                f_1634_108119_108175(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 108119, 108175);
                    return return_v;
                }


                object
                f_1634_108033_108182(System.Type
                enumType, string
                value, bool
                ignoreCase)
                {
                    var return_v = Enum.Parse(enumType, value, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 108033, 108182);
                    return return_v;
                }


                bool
                f_1634_108313_108377(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 108313, 108377);
                    return return_v;
                }


                object
                f_1634_108437_108489(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 108437, 108489);
                    return return_v;
                }


                string?
                f_1634_108437_108500(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 108437, 108500);
                    return return_v;
                }


                bool
                f_1634_108571_108630(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 108571, 108630);
                    return return_v;
                }


                object
                f_1634_108686_108733(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 108686, 108733);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1634_108735_108763()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 108735, 108763);
                    return return_v;
                }


                bool
                f_1634_108668_108764(object
                value, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = Convert.ToBoolean(value, (System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 108668, 108764);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSPrincipal
                f_1634_108911_108930(System.Management.Automation.Remoting.PSSenderInfo
                this_param)
                {
                    var return_v = this_param.UserInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 108911, 108930);
                    return return_v;
                }


                System.Management.Automation.Remoting.PSIdentity
                f_1634_108911_108939(System.Management.Automation.Remoting.PSPrincipal
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 108911, 108939);
                    return return_v;
                }


                string
                f_1634_108911_108944(System.Management.Automation.Remoting.PSIdentity
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 108911, 108944);
                    return return_v;
                }


                bool
                f_1634_109042_109103(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 109042, 109103);
                    return return_v;
                }


                object
                f_1634_109193_109242(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 109193, 109242);
                    return return_v;
                }


                long
                f_1634_109177_109243(object
                value)
                {
                    var return_v = Convert.ToInt64(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 109177, 109243);
                    return return_v;
                }


                int
                f_1634_109717_109756(System.Management.Automation.Runspaces.InitialSessionState
                iss)
                {
                    ProcessCopyItemFunctionDefinitions(iss);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 109717, 109756);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 87693, 109829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 87693, 109829);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ProcessCopyItemFunctionDefinitions(InitialSessionState iss)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 109912, 110865);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 110070, 110422);
                    foreach (var copyToRemoteFn in f_1634_110101_110156_I(f_1634_110101_110156()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 110070, 110422);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 110190, 110357);

                        var
                        functionEntry = f_1634_110210_110356(f_1634_110262_110284(copyToRemoteFn, "Name") as string, f_1634_110317_110345(copyToRemoteFn, "Definition") as string)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 110375, 110407);

                        f_1634_110375_110406(f_1634_110375_110387(iss), functionEntry);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 110070, 110422);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 353);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 353);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 110494, 110854);
                    foreach (var copyFromRemoteFn in f_1634_110527_110584_I(f_1634_110527_110584()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 110494, 110854);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 110618, 110789);

                        var
                        functionEntry = f_1634_110638_110788(f_1634_110690_110714(copyFromRemoteFn, "Name") as string, f_1634_110747_110777(copyFromRemoteFn, "Definition") as string)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 110807, 110839);

                        f_1634_110807_110838(f_1634_110807_110819(iss), functionEntry);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 110494, 110854);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 361);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 361);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 109912, 110865);

                System.Collections.Generic.IEnumerable<System.Collections.Hashtable>
                f_1634_110101_110156()
                {
                    var return_v = CopyFileRemoteUtils.GetAllCopyToRemoteScriptFunctions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 110101, 110156);
                    return return_v;
                }


                object
                f_1634_110262_110284(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 110262, 110284);
                    return return_v;
                }


                object
                f_1634_110317_110345(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 110317, 110345);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateFunctionEntry
                f_1634_110210_110356(object
                name, object
                definition)
                {
                    var return_v = new System.Management.Automation.Runspaces.SessionStateFunctionEntry((string)name, (string)definition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 110210, 110356);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1634_110375_110387(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 110375, 110387);
                    return return_v;
                }


                int
                f_1634_110375_110406(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                this_param, System.Management.Automation.Runspaces.SessionStateFunctionEntry
                item)
                {
                    this_param.Add((System.Management.Automation.Runspaces.SessionStateCommandEntry)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 110375, 110406);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Hashtable>
                f_1634_110101_110156_I(System.Collections.Generic.IEnumerable<System.Collections.Hashtable>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 110101, 110156);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Hashtable>
                f_1634_110527_110584()
                {
                    var return_v = CopyFileRemoteUtils.GetAllCopyFromRemoteScriptFunctions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 110527, 110584);
                    return return_v;
                }


                object
                f_1634_110690_110714(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 110690, 110714);
                    return return_v;
                }


                object
                f_1634_110747_110777(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 110747, 110777);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateFunctionEntry
                f_1634_110638_110788(object
                name, object
                definition)
                {
                    var return_v = new System.Management.Automation.Runspaces.SessionStateFunctionEntry((string)name, (string)definition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 110638, 110788);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1634_110807_110819(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 110807, 110819);
                    return return_v;
                }


                int
                f_1634_110807_110838(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                this_param, System.Management.Automation.Runspaces.SessionStateFunctionEntry
                item)
                {
                    this_param.Add((System.Management.Automation.Runspaces.SessionStateCommandEntry)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 110807, 110838);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Hashtable>
                f_1634_110527_110584_I(System.Collections.Generic.IEnumerable<System.Collections.Hashtable>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 110527, 110584);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 109912, 110865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 109912, 110865);
            }
        }

        private static void ProcessVisibleCommands(InitialSessionState iss, object[] commands)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 110877, 113509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 111560, 111681);

                Dictionary<string, Hashtable>
                commandModifications = f_1634_111613_111680(f_1634_111647_111679())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 111845, 111936);

                HashSet<string>
                commandModuleNames = f_1634_111882_111935(f_1634_111902_111934())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 111950, 112098);
                    foreach (var moduleSpec in f_1634_111977_112009_I(f_1634_111977_112009(iss)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 111950, 112098);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 112043, 112083);

                        f_1634_112043_112082(commandModuleNames, f_1634_112066_112081(moduleSpec));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 111950, 112098);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 149);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 149);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 112114, 113191);
                    foreach (object commandObject in f_1634_112147_112155_I(commands))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 112114, 113191);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 112189, 112284) || true) && (commandObject == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 112189, 112284);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 112256, 112265);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 112189, 112284);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 112373, 112414);

                        string
                        command = commandObject as string
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 112432, 113176) || true) && (!f_1634_112437_112466(command))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 112432, 113176);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 112508, 112564);

                            f_1634_112508_112563(iss, command, commandModuleNames);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 112432, 113176);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 112432, 113176);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 112898, 112961);

                            IDictionary
                            commandModification = commandObject as IDictionary
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 112983, 113157) || true) && (commandModification != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 112983, 113157);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 113064, 113134);

                                f_1634_113064_113133(commandModifications, commandModification);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 112983, 113157);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 112432, 113176);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 112114, 113191);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 1078);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 1078);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 113357, 113498);
                    foreach (var pair in f_1634_113378_113398_I(commandModifications))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 113357, 113498);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 113432, 113483);

                        f_1634_113432_113482(f_1634_113432_113456(iss), pair.Key, pair.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 113357, 113498);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 142);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 142);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 110877, 113509);

                System.StringComparer
                f_1634_111647_111679()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 111647, 111679);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Hashtable>
                f_1634_111613_111680(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Collections.Hashtable>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 111613, 111680);
                    return return_v;
                }


                System.StringComparer
                f_1634_111902_111934()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 111902, 111934);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1634_111882_111935(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 111882, 111935);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<Microsoft.PowerShell.Commands.ModuleSpecification>
                f_1634_111977_112009(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.ModuleSpecificationsToImport;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 111977, 112009);
                    return return_v;
                }


                string
                f_1634_112066_112081(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 112066, 112081);
                    return return_v;
                }


                bool
                f_1634_112043_112082(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 112043, 112082);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<Microsoft.PowerShell.Commands.ModuleSpecification>
                f_1634_111977_112009_I(System.Collections.ObjectModel.Collection<Microsoft.PowerShell.Commands.ModuleSpecification>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 111977, 112009);
                    return return_v;
                }


                bool
                f_1634_112437_112466(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 112437, 112466);
                    return return_v;
                }


                int
                f_1634_112508_112563(System.Management.Automation.Runspaces.InitialSessionState
                iss, string
                command, System.Collections.Generic.HashSet<string>
                moduleNames)
                {
                    ProcessVisibleCommand(iss, command, moduleNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 112508, 112563);
                    return 0;
                }


                int
                f_1634_113064_113133(System.Collections.Generic.Dictionary<string, System.Collections.Hashtable>
                commandModifications, System.Collections.IDictionary
                commandModification)
                {
                    ProcessCommandModification(commandModifications, commandModification);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 113064, 113133);
                    return 0;
                }


                object[]
                f_1634_112147_112155_I(object[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 112147, 112155);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Hashtable>
                f_1634_113432_113456(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.CommandModifications;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 113432, 113456);
                    return return_v;
                }


                int
                f_1634_113432_113482(System.Collections.Generic.Dictionary<string, System.Collections.Hashtable>
                this_param, string
                key, System.Collections.Hashtable
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 113432, 113482);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Collections.Hashtable>
                f_1634_113378_113398_I(System.Collections.Generic.Dictionary<string, System.Collections.Hashtable>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 113378, 113398);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 110877, 113509);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 110877, 113509);
            }
        }

        private static void ProcessCommandModification(Dictionary<string, Hashtable> commandModifications, IDictionary commandModification)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 113521, 117565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 113677, 113736);

                string
                commandName = f_1634_113698_113725(commandModification, "Name") as string
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 113750, 113780);

                Hashtable[]
                parameters = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 113796, 114434) || true) && (f_1634_113800_113842(commandModification, "Parameters"))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 113796, 114434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 113876, 113945);

                    parameters = f_1634_113889_113944(f_1634_113910_113943(commandModification, "Parameters"));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 113965, 114419) || true) && (parameters != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 113965, 114419);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 114112, 114400);
                            foreach (Hashtable parameter in f_1634_114144_114154_I(parameters))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 114112, 114400);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 114204, 114377) || true) && (!f_1634_114209_114238(parameter, "Name"))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 114204, 114377);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 114296, 114314);

                                    parameters = null;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1634, 114344, 114350);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 114204, 114377);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 114112, 114400);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 289);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 289);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 113965, 114419);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 113796, 114434);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 114516, 115252) || true) && ((commandName == null) || (DynAbs.Tracing.TraceSender.Expression_False(1634, 114520, 114565) || (parameters == null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 114516, 115252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 114599, 114633);

                    string
                    hashtableKey = commandName
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 114651, 114923) || true) && (f_1634_114655_114689(hashtableKey))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 114651, 114923);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 114731, 114795);

                        IEnumerator
                        errorKey = f_1634_114754_114794(f_1634_114754_114778(commandModification))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 114817, 114837);

                        f_1634_114817_114836(errorKey);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 114861, 114904);

                        hashtableKey = f_1634_114876_114903(f_1634_114876_114892(errorKey));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 114651, 114923);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 114943, 115046);

                    string
                    message = f_1634_114960_115045(f_1634_114978_115030(), hashtableKey)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 115064, 115139);

                    PSInvalidOperationException
                    ioe = f_1634_115098_115138(message)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 115157, 115207);

                    f_1634_115157_115206(ioe, "InvalidVisibleCommandKeyEntries");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 115227, 115237);

                    throw ioe;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 114516, 115252);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 115361, 115394);

                Hashtable
                parameterModifications
                = default(Hashtable);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 115408, 115685) || true) && (!f_1634_115413_115486(commandModifications, commandName, out parameterModifications))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 115408, 115685);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 115520, 115593);

                    parameterModifications = f_1634_115545_115592(f_1634_115559_115591());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 115611, 115670);

                    commandModifications[commandName] = parameterModifications;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 115408, 115685);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 115701, 117554);
                    foreach (IDictionary parameter in f_1634_115735_115745_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 115701, 117554);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 115878, 115930);

                        string
                        parameterName = f_1634_115901_115929(f_1634_115901_115918(parameter, "Name"))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 115948, 116040);

                        Hashtable
                        currentParameterModification = f_1634_115989_116026(parameterModifications, parameterName) as Hashtable
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 116058, 116329) || true) && (currentParameterModification == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 116058, 116329);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 116140, 116219);

                            currentParameterModification = f_1634_116171_116218(f_1634_116185_116217());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 116241, 116310);

                            parameterModifications[parameterName] = currentParameterModification;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 116058, 116329);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 116349, 117539);
                            foreach (string parameterModification in f_1634_116390_116404_I(f_1634_116390_116404(parameter)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 116349, 117539);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 116446, 116612) || true) && (f_1634_116450_116530("Name", parameterModification, StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 116446, 116612);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 116580, 116589);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 116446, 116612);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 116731, 116977) || true) && (!f_1634_116736_116796(currentParameterModification, parameterModification))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 116731, 116977);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 116846, 116954);

                                    currentParameterModification[parameterModification] = f_1634_116900_116953(f_1634_116920_116952());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 116731, 116977);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 117001, 117122);

                                HashSet<string>
                                currentParameterModificationValue = (HashSet<string>)f_1634_117070_117121(currentParameterModification, parameterModification)
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 117146, 117520);
                                    foreach (string parameterModificationValue in f_1634_117192_117243_I(f_1634_117192_117243(f_1634_117210_117242(parameter, parameterModification))))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 117146, 117520);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 117293, 117497) || true) && (!f_1634_117298_117346(parameterModificationValue))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 117293, 117497);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 117404, 117470);

                                            f_1634_117404_117469(currentParameterModificationValue, parameterModificationValue);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 117293, 117497);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 117146, 117520);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 375);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 375);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 116349, 117539);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 1191);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 1191);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 115701, 117554);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 1854);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 1854);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 113521, 117565);

                object
                f_1634_113698_113725(System.Collections.IDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 113698, 113725);
                    return return_v;
                }


                bool
                f_1634_113800_113842(System.Collections.IDictionary
                this_param, string
                key)
                {
                    var return_v = this_param.Contains((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 113800, 113842);
                    return return_v;
                }


                object
                f_1634_113910_113943(System.Collections.IDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 113910, 113943);
                    return return_v;
                }


                System.Collections.Hashtable[]
                f_1634_113889_113944(object
                hashObj)
                {
                    var return_v = TryGetHashtableArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 113889, 113944);
                    return return_v;
                }


                bool
                f_1634_114209_114238(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 114209, 114238);
                    return return_v;
                }


                System.Collections.Hashtable[]
                f_1634_114144_114154_I(System.Collections.Hashtable[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 114144, 114154);
                    return return_v;
                }


                bool
                f_1634_114655_114689(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 114655, 114689);
                    return return_v;
                }


                System.Collections.ICollection
                f_1634_114754_114778(System.Collections.IDictionary
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 114754, 114778);
                    return return_v;
                }


                System.Collections.IEnumerator
                f_1634_114754_114794(System.Collections.ICollection
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 114754, 114794);
                    return return_v;
                }


                bool
                f_1634_114817_114836(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 114817, 114836);
                    return return_v;
                }


                object
                f_1634_114876_114892(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 114876, 114892);
                    return return_v;
                }


                string?
                f_1634_114876_114903(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 114876, 114903);
                    return return_v;
                }


                string
                f_1634_114978_115030()
                {
                    var return_v = RemotingErrorIdStrings.DISCCommandModificationSyntax;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 114978, 115030);
                    return return_v;
                }


                string
                f_1634_114960_115045(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 114960, 115045);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1634_115098_115138(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 115098, 115138);
                    return return_v;
                }


                int
                f_1634_115157_115206(System.Management.Automation.PSInvalidOperationException
                this_param, string
                errorId)
                {
                    this_param.SetErrorId(errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 115157, 115206);
                    return 0;
                }


                bool
                f_1634_115413_115486(System.Collections.Generic.Dictionary<string, System.Collections.Hashtable>
                this_param, string
                key, out System.Collections.Hashtable
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 115413, 115486);
                    return return_v;
                }


                System.StringComparer
                f_1634_115559_115591()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 115559, 115591);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1634_115545_115592(System.StringComparer
                equalityComparer)
                {
                    var return_v = new System.Collections.Hashtable((System.Collections.IEqualityComparer)equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 115545, 115592);
                    return return_v;
                }


                object
                f_1634_115901_115918(System.Collections.IDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 115901, 115918);
                    return return_v;
                }


                string?
                f_1634_115901_115929(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 115901, 115929);
                    return return_v;
                }


                object
                f_1634_115989_116026(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 115989, 116026);
                    return return_v;
                }


                System.StringComparer
                f_1634_116185_116217()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 116185, 116217);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1634_116171_116218(System.StringComparer
                equalityComparer)
                {
                    var return_v = new System.Collections.Hashtable((System.Collections.IEqualityComparer)equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 116171, 116218);
                    return return_v;
                }


                System.Collections.ICollection
                f_1634_116390_116404(System.Collections.IDictionary
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 116390, 116404);
                    return return_v;
                }


                bool
                f_1634_116450_116530(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 116450, 116530);
                    return return_v;
                }


                bool
                f_1634_116736_116796(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.Contains((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 116736, 116796);
                    return return_v;
                }


                System.StringComparer
                f_1634_116920_116952()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 116920, 116952);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1634_116900_116953(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 116900, 116953);
                    return return_v;
                }


                object
                f_1634_117070_117121(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 117070, 117121);
                    return return_v;
                }


                object
                f_1634_117210_117242(System.Collections.IDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 117210, 117242);
                    return return_v;
                }


                string[]
                f_1634_117192_117243(object
                hashObj)
                {
                    var return_v = TryGetStringArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 117192, 117243);
                    return return_v;
                }


                bool
                f_1634_117298_117346(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 117298, 117346);
                    return return_v;
                }


                bool
                f_1634_117404_117469(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 117404, 117469);
                    return return_v;
                }


                string[]
                f_1634_117192_117243_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 117192, 117243);
                    return return_v;
                }


                System.Collections.ICollection
                f_1634_116390_116404_I(System.Collections.ICollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 116390, 116404);
                    return return_v;
                }


                System.Collections.Hashtable[]
                f_1634_115735_115745_I(System.Collections.Hashtable[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 115735, 115745);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 113521, 117565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 113521, 117565);
            }
        }

        private static void ProcessVisibleCommand(InitialSessionState iss, string command, HashSet<string> moduleNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 117577, 119359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 117713, 117732);

                bool
                found = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 117998, 119174) || true) && (f_1634_118002_118023(command, '\\') < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 117998, 119174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 118137, 118227);

                    Collection<SessionStateCommandEntry>
                    existingEntries = f_1634_118192_118226(f_1634_118192_118204(iss), command)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 118245, 118656);
                        foreach (SessionStateCommandEntry existingEntry in f_1634_118296_118311_I(existingEntries))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 118245, 118656);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 118353, 118637) || true) && ((f_1634_118358_118383(existingEntry) == CommandTypes.Cmdlet) || (DynAbs.Tracing.TraceSender.Expression_False(1634, 118357, 118463) || (f_1634_118412_118437(existingEntry) == CommandTypes.Function)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 118353, 118637);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 118513, 118575);

                                existingEntry.Visibility = SessionStateEntryVisibility.Public;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 118601, 118614);

                                found = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 118353, 118637);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 118245, 118656);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 412);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 412);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 117998, 119174);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 117998, 119174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 118824, 118842);

                    string
                    moduleName
                    = default(string);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 118860, 118908);

                    f_1634_118860_118907(command, out moduleName);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 118926, 119159) || true) && (!f_1634_118931_118963(moduleName) && (DynAbs.Tracing.TraceSender.Expression_True(1634, 118930, 119000) && !f_1634_118968_119000(moduleNames, moduleName)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 118926, 119159);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 119042, 119070);

                        f_1634_119042_119069(moduleNames, moduleName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 119092, 119140);

                        f_1634_119092_119139(iss, new string[] { moduleName });
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 118926, 119159);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 117998, 119174);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 119190, 119348) || true) && (!found || (DynAbs.Tracing.TraceSender.Expression_False(1634, 119194, 119255) || f_1634_119204_119255(command)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 119190, 119348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 119289, 119333);

                    f_1634_119289_119332(f_1634_119289_119319(iss), command);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 119190, 119348);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 117577, 119359);

                int
                f_1634_118002_118023(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 118002, 118023);
                    return return_v;
                }


                System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1634_118192_118204(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 118192, 118204);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1634_118192_118226(System.Management.Automation.Runspaces.InitialSessionStateEntryCollection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                this_param, string
                name)
                {
                    var return_v = this_param.LookUpByName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 118192, 118226);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1634_118358_118383(System.Management.Automation.Runspaces.SessionStateCommandEntry
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 118358, 118383);
                    return return_v;
                }


                System.Management.Automation.CommandTypes
                f_1634_118412_118437(System.Management.Automation.Runspaces.SessionStateCommandEntry
                this_param)
                {
                    var return_v = this_param.CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 118412, 118437);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                f_1634_118296_118311_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Runspaces.SessionStateCommandEntry>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 118296, 118311);
                    return return_v;
                }


                string
                f_1634_118860_118907(string
                commandName, out string
                moduleName)
                {
                    var return_v = Utils.ParseCommandName(commandName, out moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 118860, 118907);
                    return return_v;
                }


                bool
                f_1634_118931_118963(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 118931, 118963);
                    return return_v;
                }


                bool
                f_1634_118968_119000(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 118968, 119000);
                    return return_v;
                }


                bool
                f_1634_119042_119069(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 119042, 119069);
                    return return_v;
                }


                int
                f_1634_119092_119139(System.Management.Automation.Runspaces.InitialSessionState
                this_param, params string[]
                name)
                {
                    this_param.ImportPSModule(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 119092, 119139);
                    return 0;
                }


                bool
                f_1634_119204_119255(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 119204, 119255);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1634_119289_119319(System.Management.Automation.Runspaces.InitialSessionState
                this_param)
                {
                    var return_v = this_param.UnresolvedCommandsToExpose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 119289, 119319);
                    return return_v;
                }


                bool
                f_1634_119289_119332(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 119289, 119332);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 117577, 119359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 117577, 119359);
            }
        }

        private SessionStateAliasEntry CreateSessionStateAliasEntry(Hashtable alias, bool isAliasVisibilityDefined)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1634, 119455, 120755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 119587, 119656);

                string
                name = f_1634_119601_119655(alias, ConfigFileConstants.AliasNameToken)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 119672, 119763) || true) && (f_1634_119676_119702(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 119672, 119763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 119736, 119748);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 119672, 119763);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 119779, 119850);

                string
                value = f_1634_119794_119849(alias, ConfigFileConstants.AliasValueToken)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 119866, 119958) || true) && (f_1634_119870_119897(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 119866, 119958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 119931, 119943);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 119866, 119958);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 119974, 120057);

                string
                description = f_1634_119995_120056(alias, ConfigFileConstants.AliasDescriptionToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 120073, 120124);

                ScopedItemOptions
                options = ScopedItemOptions.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 120140, 120221);

                string
                optionsString = f_1634_120163_120220(alias, ConfigFileConstants.AliasOptionsToken)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 120237, 120414) || true) && (!f_1634_120242_120277(optionsString))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 120237, 120414);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 120311, 120399);

                    options = (ScopedItemOptions)f_1634_120340_120398(typeof(ScopedItemOptions), optionsString, true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 120237, 120414);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 120430, 120507);

                SessionStateEntryVisibility
                visibility = SessionStateEntryVisibility.Private
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 120521, 120647) || true) && (!isAliasVisibilityDefined)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 120521, 120647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 120584, 120632);

                    visibility = SessionStateEntryVisibility.Public;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 120521, 120647);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 120663, 120744);

                return f_1634_120670_120743(name, value, description, options, visibility);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1634, 119455, 120755);

                string
                f_1634_119601_119655(System.Collections.Hashtable
                table, string
                key)
                {
                    var return_v = TryGetValue(table, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 119601, 119655);
                    return return_v;
                }


                bool
                f_1634_119676_119702(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 119676, 119702);
                    return return_v;
                }


                string
                f_1634_119794_119849(System.Collections.Hashtable
                table, string
                key)
                {
                    var return_v = TryGetValue(table, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 119794, 119849);
                    return return_v;
                }


                bool
                f_1634_119870_119897(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 119870, 119897);
                    return return_v;
                }


                string
                f_1634_119995_120056(System.Collections.Hashtable
                table, string
                key)
                {
                    var return_v = TryGetValue(table, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 119995, 120056);
                    return return_v;
                }


                string
                f_1634_120163_120220(System.Collections.Hashtable
                table, string
                key)
                {
                    var return_v = TryGetValue(table, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 120163, 120220);
                    return return_v;
                }


                bool
                f_1634_120242_120277(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 120242, 120277);
                    return return_v;
                }


                object
                f_1634_120340_120398(System.Type
                enumType, string
                value, bool
                ignoreCase)
                {
                    var return_v = Enum.Parse(enumType, value, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 120340, 120398);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateAliasEntry
                f_1634_120670_120743(string
                name, string
                definition, string
                description, System.Management.Automation.ScopedItemOptions
                options, System.Management.Automation.SessionStateEntryVisibility
                visibility)
                {
                    var return_v = new System.Management.Automation.Runspaces.SessionStateAliasEntry(name, definition, description, options, visibility);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 120670, 120743);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 119455, 120755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 119455, 120755);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SessionStateFunctionEntry CreateSessionStateFunctionEntry(Hashtable function, bool isFunctionVisibilityDefined)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1634, 120886, 122290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 121030, 121105);

                string
                name = f_1634_121044_121104(function, ConfigFileConstants.FunctionNameToken)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 121121, 121212) || true) && (f_1634_121125_121151(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 121121, 121212);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 121185, 121197);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 121121, 121212);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 121228, 121305);

                string
                value = f_1634_121243_121304(function, ConfigFileConstants.FunctionValueToken)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 121321, 121413) || true) && (f_1634_121325_121352(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 121321, 121413);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 121386, 121398);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 121321, 121413);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 121429, 121480);

                ScopedItemOptions
                options = ScopedItemOptions.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 121496, 121583);

                string
                optionsString = f_1634_121519_121582(function, ConfigFileConstants.FunctionOptionsToken)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 121599, 121776) || true) && (!f_1634_121604_121639(optionsString))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 121599, 121776);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 121673, 121761);

                    options = (ScopedItemOptions)f_1634_121702_121760(typeof(ScopedItemOptions), optionsString, true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 121599, 121776);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 121792, 121844);

                ScriptBlock
                newFunction = f_1634_121818_121843(value)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 121858, 121913);

                newFunction.LanguageMode = PSLanguageMode.FullLanguage;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 121929, 122014);

                SessionStateEntryVisibility
                functionVisibility = SessionStateEntryVisibility.Private
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 122028, 122165) || true) && (!isFunctionVisibilityDefined)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 122028, 122165);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 122094, 122150);

                    functionVisibility = SessionStateEntryVisibility.Public;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 122028, 122165);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 122181, 122279);

                return f_1634_122188_122278(name, value, options, functionVisibility, newFunction, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1634, 120886, 122290);

                string
                f_1634_121044_121104(System.Collections.Hashtable
                table, string
                key)
                {
                    var return_v = TryGetValue(table, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 121044, 121104);
                    return return_v;
                }


                bool
                f_1634_121125_121151(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 121125, 121151);
                    return return_v;
                }


                string
                f_1634_121243_121304(System.Collections.Hashtable
                table, string
                key)
                {
                    var return_v = TryGetValue(table, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 121243, 121304);
                    return return_v;
                }


                bool
                f_1634_121325_121352(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 121325, 121352);
                    return return_v;
                }


                string
                f_1634_121519_121582(System.Collections.Hashtable
                table, string
                key)
                {
                    var return_v = TryGetValue(table, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 121519, 121582);
                    return return_v;
                }


                bool
                f_1634_121604_121639(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 121604, 121639);
                    return return_v;
                }


                object
                f_1634_121702_121760(System.Type
                enumType, string
                value, bool
                ignoreCase)
                {
                    var return_v = Enum.Parse(enumType, value, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 121702, 121760);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1634_121818_121843(string
                script)
                {
                    var return_v = ScriptBlock.Create(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 121818, 121843);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateFunctionEntry
                f_1634_122188_122278(string
                name, string
                definition, System.Management.Automation.ScopedItemOptions
                options, System.Management.Automation.SessionStateEntryVisibility
                visibility, System.Management.Automation.ScriptBlock
                scriptBlock, string
                helpFile)
                {
                    var return_v = new System.Management.Automation.Runspaces.SessionStateFunctionEntry(name, definition, options, visibility, scriptBlock, helpFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 122188, 122278);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 120886, 122290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 120886, 122290);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SessionStateVariableEntry CreateSessionStateVariableEntry(Hashtable variable, PSLanguageMode languageMode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1634, 122388, 123787);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 122527, 122602);

                string
                name = f_1634_122541_122601(variable, ConfigFileConstants.VariableNameToken)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 122618, 122709) || true) && (f_1634_122622_122648(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 122618, 122709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 122682, 122694);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 122618, 122709);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 122725, 122802);

                string
                value = f_1634_122740_122801(variable, ConfigFileConstants.VariableValueToken)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 122818, 122910) || true) && (f_1634_122822_122849(value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 122818, 122910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 122883, 122895);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 122818, 122910);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 122926, 123012);

                string
                description = f_1634_122947_123011(variable, ConfigFileConstants.AliasDescriptionToken)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 123028, 123079);

                ScopedItemOptions
                options = ScopedItemOptions.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 123095, 123179);

                string
                optionsString = f_1634_123118_123178(variable, ConfigFileConstants.AliasOptionsToken)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 123195, 123372) || true) && (!f_1634_123200_123235(optionsString))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 123195, 123372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 123269, 123357);

                    options = (ScopedItemOptions)f_1634_123298_123356(typeof(ScopedItemOptions), optionsString, true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 123195, 123372);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 123388, 123465);

                SessionStateEntryVisibility
                visibility = SessionStateEntryVisibility.Private
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 123479, 123623) || true) && (languageMode == PSLanguageMode.FullLanguage)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 123479, 123623);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 123560, 123608);

                    visibility = SessionStateEntryVisibility.Public;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 123479, 123623);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 123639, 123776);

                return f_1634_123646_123775(name, value, description, options, f_1634_123711_123762(), visibility);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1634, 122388, 123787);

                string
                f_1634_122541_122601(System.Collections.Hashtable
                table, string
                key)
                {
                    var return_v = TryGetValue(table, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 122541, 122601);
                    return return_v;
                }


                bool
                f_1634_122622_122648(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 122622, 122648);
                    return return_v;
                }


                string
                f_1634_122740_122801(System.Collections.Hashtable
                table, string
                key)
                {
                    var return_v = TryGetValue(table, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 122740, 122801);
                    return return_v;
                }


                bool
                f_1634_122822_122849(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 122822, 122849);
                    return return_v;
                }


                string
                f_1634_122947_123011(System.Collections.Hashtable
                table, string
                key)
                {
                    var return_v = TryGetValue(table, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 122947, 123011);
                    return return_v;
                }


                string
                f_1634_123118_123178(System.Collections.Hashtable
                table, string
                key)
                {
                    var return_v = TryGetValue(table, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 123118, 123178);
                    return return_v;
                }


                bool
                f_1634_123200_123235(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 123200, 123235);
                    return return_v;
                }


                object
                f_1634_123298_123356(System.Type
                enumType, string
                value, bool
                ignoreCase)
                {
                    var return_v = Enum.Parse(enumType, value, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 123298, 123356);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1634_123711_123762()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Attribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 123711, 123762);
                    return return_v;
                }


                System.Management.Automation.Runspaces.SessionStateVariableEntry
                f_1634_123646_123775(string
                name, string
                value, string
                description, System.Management.Automation.ScopedItemOptions
                options, System.Collections.ObjectModel.Collection<System.Attribute>
                attributes, System.Management.Automation.SessionStateEntryVisibility
                visibility)
                {
                    var return_v = new System.Management.Automation.Runspaces.SessionStateVariableEntry(name, (object)value, description, options, attributes, visibility);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 123646, 123775);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 122388, 123787);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 122388, 123787);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsNonDefaultVisibilitySpecified(string configFileKey)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1634, 124036, 124547);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 124127, 124507) || true) && (f_1634_124131_124169(_configHash, configFileKey))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 124127, 124507);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 124203, 124318);

                    string[]
                    commands =
                    f_1634_124244_124317(f_1634_124290_124316(_configHash, configFileKey))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 124338, 124460) || true) && ((commands == null) || (DynAbs.Tracing.TraceSender.Expression_False(1634, 124342, 124386) || (f_1634_124365_124380(commands) == 0)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 124338, 124460);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 124428, 124441);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 124338, 124460);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 124480, 124492);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 124127, 124507);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 124523, 124536);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1634, 124036, 124547);

                bool
                f_1634_124131_124169(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 124131, 124169);
                    return return_v;
                }


                object
                f_1634_124290_124316(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 124290, 124316);
                    return return_v;
                }


                string[]
                f_1634_124244_124317(object
                hashObj)
                {
                    var return_v = DISCPowerShellConfiguration.TryGetStringArray(hashObj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 124244, 124317);
                    return return_v;
                }


                int
                f_1634_124365_124380(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 124365, 124380);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 124036, 124547);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 124036, 124547);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string TryGetValue(Hashtable table, string key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 124776, 125015);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 124864, 124968) || true) && (f_1634_124868_124890(table, key))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 124864, 124968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 124924, 124953);

                    return f_1634_124931_124952(f_1634_124931_124941(table, key));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 124864, 124968);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 124984, 125004);

                return string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 124776, 125015);

                bool
                f_1634_124868_124890(System.Collections.Hashtable
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 124868, 124890);
                    return return_v;
                }


                object
                f_1634_124931_124941(System.Collections.Hashtable
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 124931, 124941);
                    return return_v;
                }


                string?
                f_1634_124931_124952(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 124931, 124952);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 124776, 125015);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 124776, 125015);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Hashtable[] TryGetHashtableArray(object hashObj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 125214, 126319);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 125331, 125374);

                Hashtable
                hashtable = hashObj as Hashtable
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 125390, 125487) || true) && (hashtable != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 125390, 125487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 125445, 125472);

                    return new[] { hashtable };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 125390, 125487);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 125540, 125587);

                Hashtable[]
                hashArray = hashObj as Hashtable[]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 125603, 126275) || true) && (hashArray == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 125603, 126275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 125707, 125747);

                    object[]
                    objArray = hashObj as object[]
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 125767, 126260) || true) && (objArray != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 125767, 126260);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 125829, 125872);

                        hashArray = new Hashtable[f_1634_125855_125870(objArray)];
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 125905, 125910);

                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 125896, 126241) || true) && (i < f_1634_125916_125932(hashArray))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 125934, 125937)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 125896, 126241))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 125896, 126241);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 125987, 126029);

                                Hashtable
                                hash = objArray[i] as Hashtable
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 126057, 126170) || true) && (hash == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 126057, 126170);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 126131, 126143);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 126057, 126170);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 126198, 126218);

                                hashArray[i] = hash;
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 346);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 346);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 125767, 126260);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 125603, 126275);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 126291, 126308);

                return hashArray;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 125214, 126319);

                int
                f_1634_125855_125870(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 125855, 125870);
                    return return_v;
                }


                int
                f_1634_125916_125932(System.Collections.Hashtable[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 125916, 125932);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 125214, 126319);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 125214, 126319);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string[] TryGetStringArray(object hashObj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 126517, 127240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 126600, 126636);

                object[]
                objs = hashObj as object[]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 126652, 127009) || true) && (objs == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 126652, 127009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 126734, 126765);

                    object
                    obj = hashObj as object
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 126785, 126994) || true) && (obj != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 126785, 126994);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 126842, 126881);

                        return new string[] { f_1634_126864_126878(obj) };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 126785, 126994);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 126785, 126994);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 126963, 126975);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 126785, 126994);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 126652, 127009);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 127025, 127067);

                string[]
                result = new string[f_1634_127054_127065(objs)]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 127092, 127097);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 127083, 127199) || true) && (i < f_1634_127103_127114(objs))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 127116, 127119)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 127083, 127199))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 127083, 127199);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 127153, 127184);

                        result[i] = f_1634_127165_127183(objs[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 117);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 127215, 127229);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 126517, 127240);

                string?
                f_1634_126864_126878(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 126864, 126878);
                    return return_v;
                }


                int
                f_1634_127054_127065(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 127054, 127065);
                    return return_v;
                }


                int
                f_1634_127103_127114(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 127103, 127114);
                    return return_v;
                }


                string?
                f_1634_127165_127183(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 127165, 127183);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 126517, 127240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 126517, 127240);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static T[] TryGetObjectsOfType<T>(object hashObj, IEnumerable<Type> types) where T : class
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1634, 127252, 128364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 127376, 127412);

                object[]
                objs = hashObj as object[]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 127426, 127913) || true) && (objs == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 127426, 127913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 127508, 127529);

                    object
                    obj = hashObj
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 127547, 127866) || true) && (obj != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 127547, 127866);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 127604, 127847);
                            foreach (Type type in f_1634_127626_127631_I(types))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 127604, 127847);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 127681, 127824) || true) && (f_1634_127685_127711(f_1634_127685_127698(obj), type))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 127681, 127824);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 127769, 127797);

                                    return new T[] { obj as T };
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 127681, 127824);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 127604, 127847);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 244);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 244);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 127547, 127866);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 127886, 127898);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 127426, 127913);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 127929, 127961);

                T[]
                result = new T[f_1634_127948_127959(objs)]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 127984, 127989);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 127975, 128323) || true) && (i < f_1634_127995_128006(objs))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 128008, 128011)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 127975, 128323))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 127975, 128323);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 128045, 128056);

                        int
                        i1 = i
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 128074, 128308) || true) && (f_1634_128078_128128(types, type => objs[i1].GetType().Equals(type)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 128074, 128308);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 128170, 128195);

                            result[i] = objs[i] as T;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 128074, 128308);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1634, 128074, 128308);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 128277, 128289);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1634, 128074, 128308);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1634, 1, 349);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1634, 1, 349);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 128339, 128353);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1634, 127252, 128364);

                System.Type
                f_1634_127685_127698(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 127685, 127698);
                    return return_v;
                }


                bool
                f_1634_127685_127711(System.Type
                this_param, System.Type
                o)
                {
                    var return_v = this_param.Equals(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 127685, 127711);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Type>
                f_1634_127626_127631_I(System.Collections.Generic.IEnumerable<System.Type>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 127626, 127631);
                    return return_v;
                }


                int
                f_1634_127948_127959(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 127948, 127959);
                    return return_v;
                }


                int
                f_1634_127995_128006(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 127995, 128006);
                    return return_v;
                }


                bool
                f_1634_128078_128128(System.Collections.Generic.IEnumerable<System.Type>
                source, System.Func<System.Type, bool>
                predicate)
                {
                    var return_v = source.Any<System.Type>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 128078, 128128);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1634, 127252, 128364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 127252, 128364);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DISCPowerShellConfiguration()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1634, 75676, 128371);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1634, 80394, 80417);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1634, 75676, 128371);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1634, 75676, 128371);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1634, 75676, 128371);

        System.Management.Automation.Runspaces.Runspace
        f_1634_76979_77003()
        {
            var return_v = Runspace.DefaultRunspace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 76979, 77003);
            return return_v;
        }


        System.Management.Automation.Runspaces.Runspace
        f_1634_77083_77115()
        {
            var return_v = RunspaceFactory.CreateRunspace();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 77083, 77115);
            return return_v;
        }


        System.Management.Automation.Runspaces.Runspace
        f_1634_77134_77158()
        {
            var return_v = Runspace.DefaultRunspace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 77134, 77158);
            return return_v;
        }


        int
        f_1634_77134_77165(System.Management.Automation.Runspaces.Runspace
        this_param)
        {
            this_param.Open();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 77134, 77165);
            return 0;
        }


        System.Management.Automation.Runspaces.Runspace
        f_1634_77281_77305()
        {
            var return_v = Runspace.DefaultRunspace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 77281, 77305);
            return return_v;
        }


        System.Management.Automation.ExecutionContext
        f_1634_77281_77322(System.Management.Automation.Runspaces.Runspace
        this_param)
        {
            var return_v = this_param.ExecutionContext;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 77281, 77322);
            return return_v;
        }


        System.Management.Automation.ExternalScriptInfo
        f_1634_77250_77372(System.Management.Automation.ExecutionContext
        context, string
        fileName, out string
        scriptName)
        {
            var return_v = DISCUtils.GetScriptInfoForFile(context, fileName, out scriptName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 77250, 77372);
            return return_v;
        }


        System.Management.Automation.Runspaces.Runspace
        f_1634_77432_77456()
        {
            var return_v = Runspace.DefaultRunspace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 77432, 77456);
            return return_v;
        }


        System.Management.Automation.ExecutionContext
        f_1634_77432_77473(System.Management.Automation.Runspaces.Runspace
        this_param)
        {
            var return_v = this_param.ExecutionContext;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 77432, 77473);
            return return_v;
        }


        System.Collections.Hashtable
        f_1634_77407_77482(System.Management.Automation.ExecutionContext
        context, System.Management.Automation.ExternalScriptInfo
        scriptInfo)
        {
            var return_v = DISCUtils.LoadConfigFile(context, scriptInfo);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 77407, 77482);
            return return_v;
        }


        int
        f_1634_77501_77543(System.Management.Automation.Remoting.DISCPowerShellConfiguration
        this_param, System.Func<string, bool>
        roleVerifier)
        {
            this_param.MergeRoleRulesIntoConfigHash(roleVerifier);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 77501, 77543);
            return 0;
        }


        int
        f_1634_77562_77599(System.Management.Automation.Remoting.DISCPowerShellConfiguration
        this_param)
        {
            this_param.MergeRoleCapabilitiesIntoConfigHash();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 77562, 77599);
            return 0;
        }


        System.Management.Automation.Runspaces.Runspace
        f_1634_77620_77644()
        {
            var return_v =
                            Runspace.DefaultRunspace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 77620, 77644);
            return return_v;
        }


        int
        f_1634_77620_77652(System.Management.Automation.Runspaces.Runspace
        this_param)
        {
            this_param.Close();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 77620, 77652);
            return 0;
        }


        string
        f_1634_77779_77839()
        {
            var return_v = RemotingErrorIdStrings.InvalidPSSessionConfigurationFilePath;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1634, 77779, 77839);
            return return_v;
        }


        string
        f_1634_77761_77852(string
        formatSpec, string
        o)
        {
            var return_v = StringUtil.Format(formatSpec, (object)o);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 77761, 77852);
            return return_v;
        }


        System.Management.Automation.PSInvalidOperationException
        f_1634_77905_77948(string
        message, System.Management.Automation.PSSecurityException
        innerException)
        {
            var return_v = new System.Management.Automation.PSInvalidOperationException(message, (System.Exception)innerException);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 77905, 77948);
            return return_v;
        }


        int
        f_1634_77967_78022(System.Management.Automation.PSInvalidOperationException
        this_param, string
        errorId)
        {
            this_param.SetErrorId(errorId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1634, 77967, 78022);
            return 0;
        }

    }
}
