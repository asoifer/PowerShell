// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Schema;

using Microsoft.PowerShell.Cmdletization.Xml;
using System.Management.Automation;
using System.Management.Automation.Language;
using Microsoft.PowerShell.Commands;
using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell.Cmdletization
{
    internal sealed class ScriptWriter
    {
        private static readonly XmlReaderSettings s_xmlReaderSettings;

        static ScriptWriter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1067, 860, 3241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 828, 847);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 7712, 8178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 42056, 42096);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 42143, 42183);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 42232, 42274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 42326, 42367);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 42419, 42461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 42515, 42571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 42603, 42648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 84983, 86318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 86352, 86674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 86764, 87170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 100538, 100574);
                s_enumCompilationLock = f_1067_100562_100574();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 102897, 102953);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 102986, 103024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 103057, 103108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 103141, 103189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 972, 1031);

                ScriptWriter.s_xmlReaderSettings = f_1067_1007_1030();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 1078, 1134);

                ScriptWriter.s_xmlReaderSettings.CheckCharacters = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 1148, 1200);

                ScriptWriter.s_xmlReaderSettings.CloseInput = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 1214, 1292);

                ScriptWriter.s_xmlReaderSettings.ConformanceLevel = ConformanceLevel.Document;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 1306, 1361);

                ScriptWriter.s_xmlReaderSettings.IgnoreComments = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 1375, 1444);

                ScriptWriter.s_xmlReaderSettings.IgnoreProcessingInstructions = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 1458, 1516);

                ScriptWriter.s_xmlReaderSettings.IgnoreWhitespace = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 1530, 1597);

                ScriptWriter.s_xmlReaderSettings.MaxCharactersFromEntities = 16384;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 1649, 1726);

                ScriptWriter.s_xmlReaderSettings.MaxCharactersInDocument = 128 * 1024 * 1024;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 2015, 2085);

                ScriptWriter.s_xmlReaderSettings.DtdProcessing = DtdProcessing.Ignore;
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1067, 860, 3241);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 860, 3241);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 860, 3241);
            }
        }



        [Flags]
        internal enum GenerationOptions
        {
            TypesPs1Xml = 1,
            FormatPs1Xml = 2,
            HelpXml = 4,
        }

        private readonly PowerShellMetadata _cmdletizationMetadata;

        private readonly string _moduleName;

        private readonly Type _objectModelWrapper;

        private readonly Type _objectInstanceType;

        private readonly InvocationInfo _invocationInfo;

        private readonly GenerationOptions _generationOptions;

        internal ScriptWriter(
                    TextReader cmdletizationXmlReader,
                    string moduleName,
                    string defaultObjectModelWrapper,
                    InvocationInfo invocationInfo,
                    GenerationOptions generationOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1067, 3881, 7607);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 3574, 3596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 3631, 3642);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 3675, 3694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 3727, 3746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 3789, 3804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 3850, 3868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 18064, 18141);
                this._staticMethodMetadataToUniqueId = f_1067_18098_18141();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 4149, 4252);

                f_1067_4149_4251(cmdletizationXmlReader != null, "Caller should verify that cmdletizationXmlReader != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 4266, 4360);

                f_1067_4266_4359(!f_1067_4278_4310(moduleName), "Caller should verify that moduleName != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 4374, 4461);

                f_1067_4374_4460(invocationInfo != null, "Caller should verify that invocationInfo != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 4475, 4599);

                f_1067_4475_4598(!f_1067_4487_4534(defaultObjectModelWrapper), "Caller should verify that defaultObjectModelWrapper != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 4615, 4712);

                XmlReader
                xmlReader = f_1067_4637_4711(cmdletizationXmlReader, ScriptWriter.s_xmlReaderSettings)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 4762, 4817);

                    var
                    xmlSerializer = f_1067_4782_4816()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 4835, 4917);

                    _cmdletizationMetadata = (PowerShellMetadata)f_1067_4880_4916(xmlSerializer, xmlReader);
                }
                catch (InvalidOperationException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1067, 4946, 6038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 5014, 5090);

                    XmlSchemaException
                    schemaException = f_1067_5051_5067(e) as XmlSchemaException
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 5108, 5319) || true) && (schemaException != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 5108, 5319);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 5177, 5300);

                        throw f_1067_5183_5299(f_1067_5200_5223(schemaException), schemaException, f_1067_5242_5268(schemaException), f_1067_5270_5298(schemaException));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 5108, 5319);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 5339, 5400);

                    XmlException
                    xmlException = f_1067_5367_5383(e) as XmlException
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 5418, 5522) || true) && (xmlException != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 5418, 5522);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 5484, 5503);

                        throw xmlException;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 5418, 5522);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 5542, 5997) || true) && (f_1067_5546_5562(e) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 5542, 5997);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 5612, 5891);

                        string
                        message = f_1067_5629_5890(f_1067_5669_5695(), f_1067_5722_5802(), f_1067_5829_5838(e), f_1067_5865_5889(f_1067_5865_5881(e)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 5915, 5978);

                        throw f_1067_5921_5977(message, f_1067_5960_5976(e));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 5542, 5997);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 6017, 6023);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1067, 4946, 6038);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 6054, 6158);

                string
                objectModelWrapperName = f_1067_6086_6128(f_1067_6086_6114(_cmdletizationMetadata)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1067, 6086, 6157) ?? defaultObjectModelWrapper)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 6172, 6297);

                _objectModelWrapper = (Type)f_1067_6200_6296(objectModelWrapperName, typeof(Type), f_1067_6267_6295());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 6311, 6668) || true) && (f_1067_6315_6348(_objectModelWrapper))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 6311, 6668);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 6382, 6603);

                    string
                    message = f_1067_6399_6602(f_1067_6435_6461(), f_1067_6484_6556(), objectModelWrapperName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 6621, 6653);

                    throw f_1067_6627_6652(message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 6311, 6668);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 6684, 6720);

                Type
                baseType = _objectModelWrapper
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 6734, 7383) || true) && ((f_1067_6742_6765_M(!baseType.IsGenericType)) || (DynAbs.Tracing.TraceSender.Expression_False(1067, 6741, 6832) || f_1067_6770_6805(baseType) != typeof(CmdletAdapter<>)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 6734, 7383);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 6866, 6895);

                        baseType = f_1067_6877_6894(baseType);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 6913, 7368) || true) && (baseType == typeof(object))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 6913, 7368);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 6985, 7295);

                            string
                            message = f_1067_7002_7294(f_1067_7042_7068(), f_1067_7095_7185(), objectModelWrapperName, f_1067_7261_7293(typeof(CmdletAdapter<>)))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 7317, 7349);

                            throw f_1067_7323_7348(message);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 6913, 7368);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 6734, 7383);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 6734, 7383);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 6734, 7383);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 7399, 7455);

                _objectInstanceType = f_1067_7421_7451(baseType)[0];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 7471, 7496);

                _moduleName = moduleName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 7510, 7543);

                _invocationInfo = invocationInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 7557, 7596);

                _generationOptions = generationOptions;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1067, 3881, 7607);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 3881, 7607);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 3881, 7607);
            }
        }

        private const string
        HeaderTemplate = @"
#requires -version 3.0

try {{ Microsoft.PowerShell.Core\Set-StrictMode -Off }} catch {{ }}

$script:MyModule = $MyInvocation.MyCommand.ScriptBlock.Module

$script:ClassName = '{0}'
$script:ClassVersion = '{1}'
$script:ModuleVersion = '{2}'
$script:ObjectModelWrapper = [{3}]

$script:PrivateData = [System.Collections.Generic.Dictionary[string,string]]::new()

Microsoft.PowerShell.Core\Export-ModuleMember -Function @()
        "
        ;

        private void WriteModulePreamble(TextWriter output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 8191, 9325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 8267, 8782);

                f_1067_8267_8781(output, ScriptWriter.HeaderTemplate, f_1067_8348_8434(f_1067_8395_8433(f_1067_8395_8423(_cmdletizationMetadata))), f_1067_8453_8558(f_1067_8500_8541(f_1067_8500_8528(_cmdletizationMetadata)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1067, 8500, 8557) ?? string.Empty)), f_1067_8577_8685(f_1067_8624_8684(f_1067_8624_8673(f_1067_8636_8672(f_1067_8636_8664(_cmdletizationMetadata))))), f_1067_8704_8780(f_1067_8751_8779(_objectModelWrapper)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 8798, 9314) || true) && (f_1067_8802_8855(f_1067_8802_8830(_cmdletizationMetadata)) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 8798, 9314);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 8897, 9299);
                        foreach (ClassMetadataData data in f_1067_8932_8985_I(f_1067_8932_8985(f_1067_8932_8960(_cmdletizationMetadata))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 8897, 9299);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 9027, 9280);

                            f_1067_9027_9279(output, "$script:PrivateData.Add('{0}', '{1}')", f_1067_9136_9193(f_1067_9183_9192(data)), f_1067_9220_9278(f_1067_9267_9277(data)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 8897, 9299);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 403);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 403);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 8798, 9314);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 8191, 9325);

                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_8395_8423(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 8395, 8423);
                    return return_v;
                }


                string
                f_1067_8395_8433(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.ClassName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 8395, 8433);
                    return return_v;
                }


                string
                f_1067_8348_8434(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 8348, 8434);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_8500_8528(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 8500, 8528);
                    return return_v;
                }


                string
                f_1067_8500_8541(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.ClassVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 8500, 8541);
                    return return_v;
                }


                string
                f_1067_8453_8558(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 8453, 8558);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_8636_8664(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 8636, 8664);
                    return return_v;
                }


                string
                f_1067_8636_8672(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 8636, 8672);
                    return return_v;
                }


                System.Version
                f_1067_8624_8673(string
                version)
                {
                    var return_v = new System.Version(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 8624, 8673);
                    return return_v;
                }


                string
                f_1067_8624_8684(System.Version
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 8624, 8684);
                    return return_v;
                }


                string
                f_1067_8577_8685(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 8577, 8685);
                    return return_v;
                }


                string
                f_1067_8751_8779(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 8751, 8779);
                    return return_v;
                }


                string
                f_1067_8704_8780(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 8704, 8780);
                    return return_v;
                }


                int
                f_1067_8267_8781(System.IO.TextWriter
                this_param, string
                format, params object?[]
                arg)
                {
                    this_param.WriteLine(format, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 8267, 8781);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_8802_8830(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 8802, 8830);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataData[]
                f_1067_8802_8855(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.CmdletAdapterPrivateData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 8802, 8855);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_8932_8960(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 8932, 8960);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataData[]
                f_1067_8932_8985(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.CmdletAdapterPrivateData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 8932, 8985);
                    return return_v;
                }


                string
                f_1067_9183_9192(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataData
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 9183, 9192);
                    return return_v;
                }


                string
                f_1067_9136_9193(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 9136, 9193);
                    return return_v;
                }


                string
                f_1067_9267_9277(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataData
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 9267, 9277);
                    return return_v;
                }


                string
                f_1067_9220_9278(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 9220, 9278);
                    return return_v;
                }


                int
                f_1067_9027_9279(System.IO.TextWriter
                this_param, string
                format, string
                arg0, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 9027, 9279);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataData[]
                f_1067_8932_8985_I(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataData[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 8932, 8985);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 8191, 9325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 8191, 9325);
            }
        }

        private void WriteBindCommonParametersFunction(TextWriter output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 9337, 10143);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 9427, 9612);

                f_1067_9427_9611(output, @"
function __cmdletization_BindCommonParameters
{
    param(
        $__cmdletization_objectModelWrapper,
        $myPSBoundParameters
    )
                ");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 9628, 10073);
                    foreach (ParameterMetadata commonParameter in f_1067_9674_9707_I(f_1067_9674_9707(f_1067_9674_9700(this))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 9628, 10073);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 9741, 10058);

                        f_1067_9741_10057(output, @"
        if ($myPSBoundParameters.ContainsKey('{0}')) {{
            $__cmdletization_objectModelWrapper.PSObject.Properties['{0}'].Value = $myPSBoundParameters['{0}']
        }}
                    ", f_1067_9988_10056(f_1067_10035_10055(commonParameter)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 9628, 10073);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 446);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 446);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 10089, 10132);

                f_1067_10089_10131(
                            output, @"
}
                ");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 9337, 10143);

                int
                f_1067_9427_9611(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 9427, 9611);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                f_1067_9674_9700(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param)
                {
                    var return_v = this_param.GetCommonParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 9674, 9700);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>.ValueCollection
                f_1067_9674_9707(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 9674, 9707);
                    return return_v;
                }


                string
                f_1067_10035_10055(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 10035, 10055);
                    return return_v;
                }


                string
                f_1067_9988_10056(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 9988, 10056);
                    return return_v;
                }


                int
                f_1067_9741_10057(System.IO.TextWriter
                this_param, string
                format, string
                arg0)
                {
                    this_param.WriteLine(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 9741, 10057);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>.ValueCollection
                f_1067_9674_9707_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 9674, 9707);
                    return return_v;
                }


                int
                f_1067_10089_10131(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 10089, 10131);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 9337, 10143);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 9337, 10143);
            }
        }

        private string GetCmdletName(CommonCmdletMetadata cmdletMetadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 10155, 10421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 10245, 10323);

                string
                noun = f_1067_10259_10278(cmdletMetadata) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1067, 10259, 10322) ?? f_1067_10282_10322(f_1067_10282_10310(_cmdletizationMetadata)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 10337, 10371);

                string
                verb = f_1067_10351_10370(cmdletMetadata)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 10385, 10410);

                return verb + "-" + noun;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 10155, 10421);

                string
                f_1067_10259_10278(Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                this_param)
                {
                    var return_v = this_param.Noun;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 10259, 10278);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_10282_10310(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 10282, 10310);
                    return return_v;
                }


                string
                f_1067_10282_10322(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.DefaultNoun;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 10282, 10322);
                    return return_v;
                }


                string
                f_1067_10351_10370(Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                this_param)
                {
                    var return_v = this_param.Verb;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 10351, 10370);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 10155, 10421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 10155, 10421);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetCmdletAttributes(CommonCmdletMetadata cmdletMetadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 10433, 11515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 10630, 10680);

                StringBuilder
                attributes = f_1067_10657_10679(150)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 10694, 10931) || true) && (f_1067_10698_10720(cmdletMetadata) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 10694, 10931);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 10762, 10916);

                    f_1067_10762_10915(attributes, "[Alias('" + f_1067_10793_10906("','", f_1067_10812_10905(f_1067_10812_10834(cmdletMetadata), alias => CodeGeneration.EscapeSingleQuotedStringContent(alias))) + "')]");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 10694, 10931);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 10947, 11459) || true) && (f_1067_10951_10974(cmdletMetadata) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 10947, 11459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 11016, 11232);

                    string
                    obsoleteMsg = (DynAbs.Tracing.TraceSender.Conditional_F1(1067, 11037, 11078) || (((f_1067_11038_11069(f_1067_11038_11061(cmdletMetadata)) != null)
                    && DynAbs.Tracing.TraceSender.Conditional_F2(1067, 11102, 11195)) || DynAbs.Tracing.TraceSender.Conditional_F3(1067, 11219, 11231))) ? ("'" + f_1067_11109_11188(f_1067_11156_11187(f_1067_11156_11179(cmdletMetadata))) + "'")
                    : string.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 11250, 11328);

                    string
                    newline = (DynAbs.Tracing.TraceSender.Conditional_F1(1067, 11267, 11290) || (((f_1067_11268_11285(attributes) > 0) && DynAbs.Tracing.TraceSender.Conditional_F2(1067, 11293, 11312)) || DynAbs.Tracing.TraceSender.Conditional_F3(1067, 11315, 11327))) ? f_1067_11293_11312() : string.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 11346, 11444);

                    f_1067_11346_11443(attributes, f_1067_11370_11398(), "{0}[Obsolete({1})]", newline, obsoleteMsg);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 10947, 11459);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 11475, 11504);

                return f_1067_11482_11503(attributes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 10433, 11515);

                System.Text.StringBuilder
                f_1067_10657_10679(int
                capacity)
                {
                    var return_v = new System.Text.StringBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 10657, 10679);
                    return return_v;
                }


                string[]
                f_1067_10698_10720(Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                this_param)
                {
                    var return_v = this_param.Aliases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 10698, 10720);
                    return return_v;
                }


                string[]
                f_1067_10812_10834(Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                this_param)
                {
                    var return_v = this_param.Aliases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 10812, 10834);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1067_10812_10905(string[]
                source, System.Func<string, string>
                selector)
                {
                    var return_v = source.Select<string, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 10812, 10905);
                    return return_v;
                }


                string
                f_1067_10793_10906(string
                separator, System.Collections.Generic.IEnumerable<string>
                values)
                {
                    var return_v = string.Join(separator, values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 10793, 10906);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1067_10762_10915(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 10762, 10915);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ObsoleteAttributeMetadata
                f_1067_10951_10974(Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                this_param)
                {
                    var return_v = this_param.Obsolete;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 10951, 10974);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ObsoleteAttributeMetadata
                f_1067_11038_11061(Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                this_param)
                {
                    var return_v = this_param.Obsolete;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 11038, 11061);
                    return return_v;
                }


                string
                f_1067_11038_11069(Microsoft.PowerShell.Cmdletization.Xml.ObsoleteAttributeMetadata
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 11038, 11069);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ObsoleteAttributeMetadata
                f_1067_11156_11179(Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                this_param)
                {
                    var return_v = this_param.Obsolete;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 11156, 11179);
                    return return_v;
                }


                string
                f_1067_11156_11187(Microsoft.PowerShell.Cmdletization.Xml.ObsoleteAttributeMetadata
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 11156, 11187);
                    return return_v;
                }


                string
                f_1067_11109_11188(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 11109, 11188);
                    return return_v;
                }


                int
                f_1067_11268_11285(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 11268, 11285);
                    return return_v;
                }


                string
                f_1067_11293_11312()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 11293, 11312);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_11370_11398()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 11370, 11398);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1067_11346_11443(System.Text.StringBuilder
                this_param, System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = this_param.AppendFormat((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 11346, 11443);
                    return return_v;
                }


                string
                f_1067_11482_11503(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 11482, 11503);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 10433, 11515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 10433, 11515);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Dictionary<string, ParameterMetadata> GetCommonParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 11527, 15523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 11619, 11752);

                Dictionary<string, ParameterMetadata>
                commonParameters = f_1067_11676_11751(f_1067_11718_11750())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 11768, 11880);

                InternalParameterMetadata
                internalParameterMetadata = f_1067_11822_11879(_objectModelWrapper, false)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 11894, 14299);
                    foreach (CompiledCommandParameter compiledCommandParameter in f_1067_11956_12007_I(f_1067_11956_12007(f_1067_11956_12000(internalParameterMetadata))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 11894, 14299);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 12041, 12127);

                        ParameterMetadata
                        parameterMetadata = f_1067_12079_12126(compiledCommandParameter)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 12145, 14200);
                            foreach (ParameterSetMetadata psetMetadata in f_1067_12191_12229_I(f_1067_12191_12229(f_1067_12191_12222(parameterMetadata))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 12145, 14200);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 12271, 12806) || true) && (f_1067_12275_12305(psetMetadata))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 12271, 12806);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 12355, 12725);

                                    string
                                    message = f_1067_12372_12724(f_1067_12416_12444(), f_1067_12475_12561(), f_1067_12592_12620(_objectModelWrapper), f_1067_12651_12673(parameterMetadata), "ValueFromPipeline")
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 12751, 12783);

                                    throw f_1067_12757_12782(message);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 12271, 12806);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 12830, 13393) || true) && (f_1067_12834_12878(psetMetadata))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 12830, 13393);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 12928, 13312);

                                    string
                                    message = f_1067_12945_13311(f_1067_12989_13017(), f_1067_13048_13134(), f_1067_13165_13193(_objectModelWrapper), f_1067_13224_13246(parameterMetadata), "ValueFromPipelineByPropertyName")
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 13338, 13370);

                                    throw f_1067_13344_13369(message);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 12830, 13393);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 13417, 13972) || true) && (f_1067_13421_13461(psetMetadata))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 13417, 13972);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 13511, 13891);

                                    string
                                    message = f_1067_13528_13890(f_1067_13572_13600(), f_1067_13631_13717(), f_1067_13748_13776(_objectModelWrapper), f_1067_13807_13829(parameterMetadata), "ValueFromRemainingArguments")
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 13917, 13949);

                                    throw f_1067_13923_13948(message);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 13417, 13972);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 13996, 14035);

                                psetMetadata.ValueFromPipeline = false;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 14057, 14110);

                                psetMetadata.ValueFromPipelineByPropertyName = false;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 14132, 14181);

                                psetMetadata.ValueFromRemainingArguments = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 12145, 14200);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 2056);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 2056);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 14220, 14284);

                        f_1067_14220_14283(
                                        commonParameters, f_1067_14241_14263(parameterMetadata), parameterMetadata);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 11894, 14299);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 2406);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 2406);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 14315, 14391);

                List<string>
                commonParameterSets = f_1067_14350_14390(commonParameters)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 14405, 14780) || true) && (f_1067_14409_14434(commonParameterSets) > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 14405, 14780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 14472, 14715);

                    string
                    message = f_1067_14489_14714(f_1067_14525_14553(), f_1067_14576_14662(), f_1067_14685_14713(_objectModelWrapper))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 14733, 14765);

                    throw f_1067_14739_14764(message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 14405, 14780);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 14796, 15472);
                    foreach (ParameterMetadata parameter in f_1067_14836_14859_I(f_1067_14836_14859(commonParameters)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 14796, 15472);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 14893, 15457) || true) && ((f_1067_14898_14927(f_1067_14898_14921(parameter)) == 1) && (DynAbs.Tracing.TraceSender.Expression_True(1067, 14897, 15011) && (f_1067_14938_15010(f_1067_14938_14961(parameter), ParameterAttribute.AllParameterSets))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 14893, 15457);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 15053, 15161);

                            ParameterSetMetadata
                            oldParameterSetMetadata = f_1067_15100_15160(f_1067_15100_15123(parameter), ParameterAttribute.AllParameterSets)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 15185, 15217);

                            f_1067_15185_15216(f_1067_15185_15208(parameter));
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 15239, 15438);
                                foreach (string parameterSetName in f_1067_15275_15294_I(commonParameterSets))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 15239, 15438);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 15344, 15415);

                                    f_1067_15344_15414(f_1067_15344_15367(parameter), parameterSetName, oldParameterSetMetadata);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 15239, 15438);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 200);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 200);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 14893, 15457);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 14796, 15472);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 677);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 677);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 15488, 15512);

                return commonParameters;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 11527, 15523);

                System.StringComparer
                f_1067_11718_11750()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 11718, 11750);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                f_1067_11676_11751(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 11676, 11751);
                    return return_v;
                }


                System.Management.Automation.InternalParameterMetadata
                f_1067_11822_11879(System.Type
                type, bool
                processingDynamicParameters)
                {
                    var return_v = new System.Management.Automation.InternalParameterMetadata(type, processingDynamicParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 11822, 11879);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.CompiledCommandParameter>
                f_1067_11956_12000(System.Management.Automation.InternalParameterMetadata
                this_param)
                {
                    var return_v = this_param.BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 11956, 12000);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.CompiledCommandParameter>.ValueCollection
                f_1067_11956_12007(System.Collections.Generic.Dictionary<string, System.Management.Automation.CompiledCommandParameter>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 11956, 12007);
                    return return_v;
                }


                System.Management.Automation.ParameterMetadata
                f_1067_12079_12126(System.Management.Automation.CompiledCommandParameter
                cmdParameterMD)
                {
                    var return_v = new System.Management.Automation.ParameterMetadata(cmdParameterMD);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 12079, 12126);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1067_12191_12222(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 12191, 12222);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>.ValueCollection
                f_1067_12191_12229(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 12191, 12229);
                    return return_v;
                }


                bool
                f_1067_12275_12305(System.Management.Automation.ParameterSetMetadata
                this_param)
                {
                    var return_v = this_param.ValueFromPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 12275, 12305);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_12416_12444()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 12416, 12444);
                    return return_v;
                }


                string
                f_1067_12475_12561()
                {
                    var return_v = CmdletizationCoreResources.ScriptWriter_ObjectModelWrapperUsesIgnoredParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 12475, 12561);
                    return return_v;
                }


                string
                f_1067_12592_12620(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 12592, 12620);
                    return return_v;
                }


                string
                f_1067_12651_12673(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 12651, 12673);
                    return return_v;
                }


                string
                f_1067_12372_12724(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 12372, 12724);
                    return return_v;
                }


                System.Xml.XmlException
                f_1067_12757_12782(string
                message)
                {
                    var return_v = new System.Xml.XmlException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 12757, 12782);
                    return return_v;
                }


                bool
                f_1067_12834_12878(System.Management.Automation.ParameterSetMetadata
                this_param)
                {
                    var return_v = this_param.ValueFromPipelineByPropertyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 12834, 12878);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_12989_13017()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 12989, 13017);
                    return return_v;
                }


                string
                f_1067_13048_13134()
                {
                    var return_v = CmdletizationCoreResources.ScriptWriter_ObjectModelWrapperUsesIgnoredParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 13048, 13134);
                    return return_v;
                }


                string
                f_1067_13165_13193(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 13165, 13193);
                    return return_v;
                }


                string
                f_1067_13224_13246(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 13224, 13246);
                    return return_v;
                }


                string
                f_1067_12945_13311(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 12945, 13311);
                    return return_v;
                }


                System.Xml.XmlException
                f_1067_13344_13369(string
                message)
                {
                    var return_v = new System.Xml.XmlException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 13344, 13369);
                    return return_v;
                }


                bool
                f_1067_13421_13461(System.Management.Automation.ParameterSetMetadata
                this_param)
                {
                    var return_v = this_param.ValueFromRemainingArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 13421, 13461);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_13572_13600()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 13572, 13600);
                    return return_v;
                }


                string
                f_1067_13631_13717()
                {
                    var return_v = CmdletizationCoreResources.ScriptWriter_ObjectModelWrapperUsesIgnoredParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 13631, 13717);
                    return return_v;
                }


                string
                f_1067_13748_13776(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 13748, 13776);
                    return return_v;
                }


                string
                f_1067_13807_13829(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 13807, 13829);
                    return return_v;
                }


                string
                f_1067_13528_13890(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 13528, 13890);
                    return return_v;
                }


                System.Xml.XmlException
                f_1067_13923_13948(string
                message)
                {
                    var return_v = new System.Xml.XmlException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 13923, 13948);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>.ValueCollection
                f_1067_12191_12229_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 12191, 12229);
                    return return_v;
                }


                string
                f_1067_14241_14263(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 14241, 14263);
                    return return_v;
                }


                int
                f_1067_14220_14283(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                this_param, string
                key, System.Management.Automation.ParameterMetadata
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 14220, 14283);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.CompiledCommandParameter>.ValueCollection
                f_1067_11956_12007_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.CompiledCommandParameter>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 11956, 12007);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1067_14350_14390(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                commonParameters)
                {
                    var return_v = GetCommonParameterSets(commonParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 14350, 14390);
                    return return_v;
                }


                int
                f_1067_14409_14434(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 14409, 14434);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_14525_14553()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 14525, 14553);
                    return return_v;
                }


                string
                f_1067_14576_14662()
                {
                    var return_v = CmdletizationCoreResources.ScriptWriter_ObjectModelWrapperDefinesMultipleParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 14576, 14662);
                    return return_v;
                }


                string
                f_1067_14685_14713(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 14685, 14713);
                    return return_v;
                }


                string
                f_1067_14489_14714(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 14489, 14714);
                    return return_v;
                }


                System.Xml.XmlException
                f_1067_14739_14764(string
                message)
                {
                    var return_v = new System.Xml.XmlException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 14739, 14764);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>.ValueCollection
                f_1067_14836_14859(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 14836, 14859);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1067_14898_14921(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 14898, 14921);
                    return return_v;
                }


                int
                f_1067_14898_14927(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 14898, 14927);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1067_14938_14961(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 14938, 14961);
                    return return_v;
                }


                bool
                f_1067_14938_15010(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 14938, 15010);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1067_15100_15123(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 15100, 15123);
                    return return_v;
                }


                System.Management.Automation.ParameterSetMetadata
                f_1067_15100_15160(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 15100, 15160);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1067_15185_15208(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 15185, 15208);
                    return return_v;
                }


                int
                f_1067_15185_15216(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 15185, 15216);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1067_15344_15367(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 15344, 15367);
                    return return_v;
                }


                int
                f_1067_15344_15414(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param, string
                key, System.Management.Automation.ParameterSetMetadata
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 15344, 15414);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1067_15275_15294_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 15275, 15294);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>.ValueCollection
                f_1067_14836_14859_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 14836, 14859);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 11527, 15523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 11527, 15523);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static List<string> GetCommonParameterSets(Dictionary<string, ParameterMetadata> commonParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1067, 15535, 16652);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 15666, 15778);

                Dictionary<string, object>
                parameterSetNames = f_1067_15713_15777(f_1067_15744_15776())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 15792, 16210);
                    foreach (ParameterMetadata parameter in f_1067_15832_15855_I(f_1067_15832_15855(commonParameters)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 15792, 16210);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 15889, 16195);
                            foreach (string parameterSetName in f_1067_15925_15953_I(f_1067_15925_15953(f_1067_15925_15948(parameter))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 15889, 16195);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 15995, 16176) || true) && (!f_1067_16000_16060(parameterSetName, ParameterAttribute.AllParameterSets))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 15995, 16176);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 16110, 16153);

                                    parameterSetNames[parameterSetName] = null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 15995, 16176);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 15889, 16195);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 307);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 307);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 15792, 16210);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 419);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 419);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 16226, 16372) || true) && (f_1067_16230_16253(parameterSetNames) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 16226, 16372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 16292, 16357);

                    f_1067_16292_16356(parameterSetNames, ParameterAttribute.AllParameterSets, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 16226, 16372);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 16388, 16451);

                List<string>
                result = f_1067_16410_16450(f_1067_16427_16449(parameterSetNames))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 16465, 16501);

                f_1067_16465_16500(result, f_1067_16477_16499());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 16627, 16641);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1067, 15535, 16652);

                System.StringComparer
                f_1067_15744_15776()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 15744, 15776);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>
                f_1067_15713_15777(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, object>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 15713, 15777);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>.ValueCollection
                f_1067_15832_15855(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 15832, 15855);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1067_15925_15948(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 15925, 15948);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>.KeyCollection
                f_1067_15925_15953(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 15925, 15953);
                    return return_v;
                }


                bool
                f_1067_16000_16060(string
                this_param, string
                value)
                {
                    var return_v = this_param.Equals(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 16000, 16060);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>.KeyCollection
                f_1067_15925_15953_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>.KeyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 15925, 15953);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>.ValueCollection
                f_1067_15832_15855_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 15832, 15855);
                    return return_v;
                }


                int
                f_1067_16230_16253(System.Collections.Generic.Dictionary<string, object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 16230, 16253);
                    return return_v;
                }


                int
                f_1067_16292_16356(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key, object
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 16292, 16356);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, object>.KeyCollection
                f_1067_16427_16449(System.Collections.Generic.Dictionary<string, object>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 16427, 16449);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1067_16410_16450(System.Collections.Generic.Dictionary<string, object>.KeyCollection
                collection)
                {
                    var return_v = new System.Collections.Generic.List<string>((System.Collections.Generic.IEnumerable<string>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 16410, 16450);
                    return return_v;
                }


                System.StringComparer
                f_1067_16477_16499()
                {
                    var return_v = StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 16477, 16499);
                    return return_v;
                }


                int
                f_1067_16465_16500(System.Collections.Generic.List<string>
                this_param, System.StringComparer
                comparer)
                {
                    this_param.Sort((System.Collections.Generic.IComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 16465, 16500);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 15535, 16652);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 15535, 16652);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetMethodParameterSet(StaticMethodMetadata staticMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 16664, 16968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 16760, 16843);

                f_1067_16760_16842(staticMethod != null, "Caller should verify that staticMethod != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 16857, 16957);

                return f_1067_16864_16895(staticMethod) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1067, 16864, 16956) ?? f_1067_16899_16956(this, staticMethod));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 16664, 16968);

                int
                f_1067_16760_16842(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 16760, 16842);
                    return 0;
                }


                string
                f_1067_16864_16895(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodMetadata
                this_param)
                {
                    var return_v = this_param.CmdletParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 16864, 16895);
                    return return_v;
                }


                string
                f_1067_16899_16956(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.StaticMethodMetadata
                methodMetadata)
                {
                    var return_v = this_param.GetMethodParameterSet((Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadata)methodMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 16899, 16956);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 16664, 16968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 16664, 16968);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private List<string> GetMethodParameterSets(StaticCmdletMetadata staticCmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 16980, 18006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 17083, 17195);

                Dictionary<string, object>
                parameterSetNames = f_1067_17130_17194(f_1067_17161_17193())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 17211, 17931);
                    foreach (StaticMethodMetadata method in f_1067_17251_17270_I(f_1067_17251_17270(staticCmdlet)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 17211, 17931);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 17304, 17360);

                        string
                        parameterSetName = f_1067_17330_17359(this, method)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 17378, 17850) || true) && (f_1067_17382_17429(parameterSetNames, parameterSetName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 17378, 17850);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 17471, 17777);

                            string
                            message = f_1067_17488_17776(f_1067_17528_17556(), f_1067_17583_17658(), f_1067_17685_17732(this, f_1067_17704_17731(staticCmdlet)), parameterSetName)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 17799, 17831);

                            throw f_1067_17805_17830(message);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 17378, 17850);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 17870, 17916);

                        f_1067_17870_17915(
                                        parameterSetNames, parameterSetName, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 17211, 17931);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 721);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 721);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 17947, 17995);

                return f_1067_17954_17994(f_1067_17971_17993(parameterSetNames));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 16980, 18006);

                System.StringComparer
                f_1067_17161_17193()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 17161, 17193);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>
                f_1067_17130_17194(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, object>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 17130, 17194);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.StaticMethodMetadata[]
                f_1067_17251_17270(Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadata
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 17251, 17270);
                    return return_v;
                }


                string
                f_1067_17330_17359(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.StaticMethodMetadata
                staticMethod)
                {
                    var return_v = this_param.GetMethodParameterSet(staticMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 17330, 17359);
                    return return_v;
                }


                bool
                f_1067_17382_17429(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 17382, 17429);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_17528_17556()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 17528, 17556);
                    return return_v;
                }


                string
                f_1067_17583_17658()
                {
                    var return_v = CmdletizationCoreResources.ScriptWriter_DuplicateParameterSetInStaticCmdlet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 17583, 17658);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadataCmdletMetadata
                f_1067_17704_17731(Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadata
                this_param)
                {
                    var return_v = this_param.CmdletMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 17704, 17731);
                    return return_v;
                }


                string
                f_1067_17685_17732(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadataCmdletMetadata
                cmdletMetadata)
                {
                    var return_v = this_param.GetCmdletName((Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata)cmdletMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 17685, 17732);
                    return return_v;
                }


                string
                f_1067_17488_17776(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 17488, 17776);
                    return return_v;
                }


                System.Xml.XmlException
                f_1067_17805_17830(string
                message)
                {
                    var return_v = new System.Xml.XmlException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 17805, 17830);
                    return return_v;
                }


                int
                f_1067_17870_17915(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key, object
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 17870, 17915);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.StaticMethodMetadata[]
                f_1067_17251_17270_I(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodMetadata[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 17251, 17270);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>.KeyCollection
                f_1067_17971_17993(System.Collections.Generic.Dictionary<string, object>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 17971, 17993);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1067_17954_17994(System.Collections.Generic.Dictionary<string, object>.KeyCollection
                collection)
                {
                    var return_v = new System.Collections.Generic.List<string>((System.Collections.Generic.IEnumerable<string>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 17954, 17994);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 16980, 18006);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 16980, 18006);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Dictionary<CommonMethodMetadata, int> _staticMethodMetadataToUniqueId;

        private string GetMethodParameterSet(CommonMethodMetadata methodMetadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 18154, 18709);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 18252, 18339);

                f_1067_18252_18338(methodMetadata != null, "Caller should verify that instanceMethod != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 18355, 18368);

                int
                uniqueId
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 18382, 18638) || true) && (!f_1067_18387_18460(_staticMethodMetadataToUniqueId, methodMetadata, out uniqueId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 18382, 18638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 18494, 18543);

                    uniqueId = f_1067_18505_18542(_staticMethodMetadataToUniqueId);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 18561, 18623);

                    f_1067_18561_18622(_staticMethodMetadataToUniqueId, methodMetadata, uniqueId);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 18382, 18638);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 18654, 18698);

                return f_1067_18661_18686(methodMetadata) + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (uniqueId).ToString(), 1067, 18689, 18697);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 18154, 18709);

                int
                f_1067_18252_18338(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 18252, 18338);
                    return 0;
                }


                bool
                f_1067_18387_18460(System.Collections.Generic.Dictionary<Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadata, int>
                this_param, Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadata
                key, out int
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 18387, 18460);
                    return return_v;
                }


                int
                f_1067_18505_18542(System.Collections.Generic.Dictionary<Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadata, int>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 18505, 18542);
                    return return_v;
                }


                int
                f_1067_18561_18622(System.Collections.Generic.Dictionary<Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadata, int>
                this_param, Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadata
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 18561, 18622);
                    return 0;
                }


                string
                f_1067_18661_18686(Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadata
                this_param)
                {
                    var return_v = this_param.MethodName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 18661, 18686);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 18154, 18709);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 18154, 18709);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private List<string> GetMethodParameterSets(InstanceCmdletMetadata instanceCmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 18721, 19215);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 18828, 18940);

                Dictionary<string, object>
                parameterSetNames = f_1067_18875_18939(f_1067_18906_18938())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 18956, 19010);

                InstanceMethodMetadata
                method = f_1067_18988_19009(instanceCmdlet)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 19024, 19080);

                string
                parameterSetName = f_1067_19050_19079(this, method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 19094, 19140);

                f_1067_19094_19139(parameterSetNames, parameterSetName, null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 19156, 19204);

                return f_1067_19163_19203(f_1067_19180_19202(parameterSetNames));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 18721, 19215);

                System.StringComparer
                f_1067_18906_18938()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 18906, 18938);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>
                f_1067_18875_18939(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, object>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 18875, 18939);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodMetadata
                f_1067_18988_19009(Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 18988, 19009);
                    return return_v;
                }


                string
                f_1067_19050_19079(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodMetadata
                methodMetadata)
                {
                    var return_v = this_param.GetMethodParameterSet((Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadata)methodMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 19050, 19079);
                    return return_v;
                }


                int
                f_1067_19094_19139(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key, object
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 19094, 19139);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, object>.KeyCollection
                f_1067_19180_19202(System.Collections.Generic.Dictionary<string, object>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 19180, 19202);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1067_19163_19203(System.Collections.Generic.Dictionary<string, object>.KeyCollection
                collection)
                {
                    var return_v = new System.Collections.Generic.List<string>((System.Collections.Generic.IEnumerable<string>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 19163, 19203);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 18721, 19215);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 18721, 19215);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private GetCmdletParameters GetGetCmdletParameters(InstanceCmdletMetadata instanceCmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 19227, 20050);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 19341, 19951) || true) && (instanceCmdlet == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 19341, 19951);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 19401, 19721) || true) && ((f_1067_19406_19460(f_1067_19406_19450(f_1067_19406_19434(_cmdletizationMetadata))) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1067, 19405, 19578) && (f_1067_19495_19569(f_1067_19495_19549(f_1067_19495_19539(f_1067_19495_19523(_cmdletizationMetadata)))) != null)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 19401, 19721);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 19620, 19702);

                        return f_1067_19627_19701(f_1067_19627_19681(f_1067_19627_19671(f_1067_19627_19655(_cmdletizationMetadata))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 19401, 19721);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 19341, 19951);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 19341, 19951);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 19787, 19936) || true) && (f_1067_19791_19825(instanceCmdlet) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 19787, 19936);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 19875, 19917);

                        return f_1067_19882_19916(instanceCmdlet);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 19787, 19936);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 19341, 19951);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 19967, 20039);

                return f_1067_19974_20038(f_1067_19974_20018(f_1067_19974_20002(_cmdletizationMetadata)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 19227, 20050);

                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_19406_19434(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 19406, 19434);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataInstanceCmdlets
                f_1067_19406_19450(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.InstanceCmdlets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 19406, 19450);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.GetCmdletMetadata
                f_1067_19406_19460(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataInstanceCmdlets
                this_param)
                {
                    var return_v = this_param.GetCmdlet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 19406, 19460);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_19495_19523(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 19495, 19523);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataInstanceCmdlets
                f_1067_19495_19539(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.InstanceCmdlets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 19495, 19539);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.GetCmdletMetadata
                f_1067_19495_19549(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataInstanceCmdlets
                this_param)
                {
                    var return_v = this_param.GetCmdlet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 19495, 19549);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                f_1067_19495_19569(Microsoft.PowerShell.Cmdletization.Xml.GetCmdletMetadata
                this_param)
                {
                    var return_v = this_param.GetCmdletParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 19495, 19569);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_19627_19655(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 19627, 19655);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataInstanceCmdlets
                f_1067_19627_19671(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.InstanceCmdlets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 19627, 19671);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.GetCmdletMetadata
                f_1067_19627_19681(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataInstanceCmdlets
                this_param)
                {
                    var return_v = this_param.GetCmdlet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 19627, 19681);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                f_1067_19627_19701(Microsoft.PowerShell.Cmdletization.Xml.GetCmdletMetadata
                this_param)
                {
                    var return_v = this_param.GetCmdletParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 19627, 19701);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                f_1067_19791_19825(Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata
                this_param)
                {
                    var return_v = this_param.GetCmdletParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 19791, 19825);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                f_1067_19882_19916(Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata
                this_param)
                {
                    var return_v = this_param.GetCmdletParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 19882, 19916);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_19974_20002(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 19974, 20002);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataInstanceCmdlets
                f_1067_19974_20018(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.InstanceCmdlets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 19974, 20018);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                f_1067_19974_20038(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataInstanceCmdlets
                this_param)
                {
                    var return_v = this_param.GetCmdletParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 19974, 20038);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 19227, 20050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 19227, 20050);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private List<string> GetQueryParameterSets(InstanceCmdletMetadata instanceCmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 20062, 23287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 20168, 20280);

                Dictionary<string, object>
                parameterSetNames = f_1067_20215_20279(f_1067_20246_20278())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 20296, 20370);

                var
                parameters = f_1067_20313_20369()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 20384, 20416);

                bool
                anyQueryParameters = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 20432, 20513);

                GetCmdletParameters
                getCmdletParameters = f_1067_20474_20512(this, instanceCmdlet)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 20527, 21235) || true) && (f_1067_20531_20570(getCmdletParameters) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 20527, 21235);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 20612, 21220);
                        foreach (PropertyMetadata property in f_1067_20650_20689_I(f_1067_20650_20689(getCmdletParameters)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 20612, 21220);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 20731, 21201) || true) && (f_1067_20735_20749(property) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 20731, 21201);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 20807, 21178);
                                    foreach (PropertyQuery query in f_1067_20839_20853_I(f_1067_20839_20853(property)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 20807, 21178);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 20911, 20937);

                                        anyQueryParameters = true;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 20967, 21151) || true) && (f_1067_20971_21000(query) != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 20967, 21151);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 21074, 21120);

                                            f_1067_21074_21119(parameters, f_1067_21089_21118(query));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 20967, 21151);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 20807, 21178);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 372);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 372);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 20731, 21201);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 20612, 21220);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 609);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 609);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 20527, 21235);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 21251, 21880) || true) && (f_1067_21255_21296(getCmdletParameters) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 21251, 21880);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 21338, 21865);
                        foreach (Association association in f_1067_21374_21415_I(f_1067_21374_21415(getCmdletParameters)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 21338, 21865);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 21457, 21846) || true) && (f_1067_21461_21491(association) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 21457, 21846);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 21549, 21575);

                                anyQueryParameters = true;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 21601, 21823) || true) && (f_1067_21605_21659(f_1067_21605_21635(association)) != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 21601, 21823);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 21725, 21796);

                                    f_1067_21725_21795(parameters, f_1067_21740_21794(f_1067_21740_21770(association)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 21601, 21823);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 21457, 21846);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 21338, 21865);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 528);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 528);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 21251, 21880);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 21896, 22323) || true) && (f_1067_21900_21932(getCmdletParameters) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 21896, 22323);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 21974, 22308);
                        foreach (QueryOption option in f_1067_22005_22037_I(f_1067_22005_22037(getCmdletParameters)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 21974, 22308);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 22079, 22105);

                            anyQueryParameters = true;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 22127, 22289) || true) && (f_1067_22131_22161(option) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 22127, 22289);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 22219, 22266);

                                f_1067_22219_22265(parameters, f_1067_22234_22264(option));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 22127, 22289);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 21974, 22308);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 335);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 335);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 21896, 22323);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 22339, 22748);
                    foreach (CmdletParameterMetadataForGetCmdletParameter parameter in f_1067_22406_22416_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 22339, 22748);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 22450, 22733) || true) && (f_1067_22454_22483(parameter) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 22450, 22733);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 22533, 22714);
                                foreach (string parameterSetName in f_1067_22569_22598_I(f_1067_22569_22598(parameter)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 22533, 22714);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 22648, 22691);

                                    parameterSetNames[parameterSetName] = null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 22533, 22714);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 182);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 182);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 22450, 22733);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 22339, 22748);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 410);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 410);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 22764, 23046) || true) && (anyQueryParameters && (DynAbs.Tracing.TraceSender.Expression_True(1067, 22768, 22820) && (f_1067_22791_22814(parameterSetNames) == 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 22764, 23046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 22854, 22924);

                    f_1067_22854_22923(parameterSetNames, ScriptWriter.SingleQueryParameterSetName, null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 22942, 23031);

                    getCmdletParameters.DefaultCmdletParameterSet = ScriptWriter.SingleQueryParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 22764, 23046);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 23062, 23212) || true) && (instanceCmdlet != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 23062, 23212);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 23122, 23197);

                    f_1067_23122_23196(parameterSetNames, ScriptWriter.InputObjectQueryParameterSetName, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 23062, 23212);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 23228, 23276);

                return f_1067_23235_23275(f_1067_23252_23274(parameterSetNames));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 20062, 23287);

                System.StringComparer
                f_1067_20246_20278()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 20246, 20278);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>
                f_1067_20215_20279(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, object>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 20215, 20279);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter>
                f_1067_20313_20369()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 20313, 20369);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                f_1067_20474_20512(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata
                instanceCmdlet)
                {
                    var return_v = this_param.GetGetCmdletParameters(instanceCmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 20474, 20512);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.PropertyMetadata[]
                f_1067_20531_20570(Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                this_param)
                {
                    var return_v = this_param.QueryableProperties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 20531, 20570);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.PropertyMetadata[]
                f_1067_20650_20689(Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                this_param)
                {
                    var return_v = this_param.QueryableProperties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 20650, 20689);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.PropertyQuery[]
                f_1067_20735_20749(Microsoft.PowerShell.Cmdletization.Xml.PropertyMetadata
                this_param)
                {
                    var return_v = this_param.Items;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 20735, 20749);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.PropertyQuery[]
                f_1067_20839_20853(Microsoft.PowerShell.Cmdletization.Xml.PropertyMetadata
                this_param)
                {
                    var return_v = this_param.Items;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 20839, 20853);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletFilteringParameter
                f_1067_20971_21000(Microsoft.PowerShell.Cmdletization.Xml.PropertyQuery
                this_param)
                {
                    var return_v = this_param.CmdletParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 20971, 21000);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletFilteringParameter
                f_1067_21089_21118(Microsoft.PowerShell.Cmdletization.Xml.PropertyQuery
                this_param)
                {
                    var return_v = this_param.CmdletParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 21089, 21118);
                    return return_v;
                }


                int
                f_1067_21074_21119(System.Collections.Generic.List<Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter>
                this_param, Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletFilteringParameter
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 21074, 21119);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.PropertyQuery[]
                f_1067_20839_20853_I(Microsoft.PowerShell.Cmdletization.Xml.PropertyQuery[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 20839, 20853);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.PropertyMetadata[]
                f_1067_20650_20689_I(Microsoft.PowerShell.Cmdletization.Xml.PropertyMetadata[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 20650, 20689);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.Association[]
                f_1067_21255_21296(Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                this_param)
                {
                    var return_v = this_param.QueryableAssociations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 21255, 21296);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.Association[]
                f_1067_21374_21415(Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                this_param)
                {
                    var return_v = this_param.QueryableAssociations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 21374, 21415);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.AssociationAssociatedInstance
                f_1067_21461_21491(Microsoft.PowerShell.Cmdletization.Xml.Association
                this_param)
                {
                    var return_v = this_param.AssociatedInstance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 21461, 21491);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.AssociationAssociatedInstance
                f_1067_21605_21635(Microsoft.PowerShell.Cmdletization.Xml.Association
                this_param)
                {
                    var return_v = this_param.AssociatedInstance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 21605, 21635);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletFilteringParameter
                f_1067_21605_21659(Microsoft.PowerShell.Cmdletization.Xml.AssociationAssociatedInstance
                this_param)
                {
                    var return_v = this_param.CmdletParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 21605, 21659);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.AssociationAssociatedInstance
                f_1067_21740_21770(Microsoft.PowerShell.Cmdletization.Xml.Association
                this_param)
                {
                    var return_v = this_param.AssociatedInstance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 21740, 21770);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletFilteringParameter
                f_1067_21740_21794(Microsoft.PowerShell.Cmdletization.Xml.AssociationAssociatedInstance
                this_param)
                {
                    var return_v = this_param.CmdletParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 21740, 21794);
                    return return_v;
                }


                int
                f_1067_21725_21795(System.Collections.Generic.List<Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter>
                this_param, Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletFilteringParameter
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 21725, 21795);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.Association[]
                f_1067_21374_21415_I(Microsoft.PowerShell.Cmdletization.Xml.Association[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 21374, 21415);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.QueryOption[]
                f_1067_21900_21932(Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                this_param)
                {
                    var return_v = this_param.QueryOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 21900, 21932);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.QueryOption[]
                f_1067_22005_22037(Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                this_param)
                {
                    var return_v = this_param.QueryOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 22005, 22037);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter
                f_1067_22131_22161(Microsoft.PowerShell.Cmdletization.Xml.QueryOption
                this_param)
                {
                    var return_v = this_param.CmdletParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 22131, 22161);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter
                f_1067_22234_22264(Microsoft.PowerShell.Cmdletization.Xml.QueryOption
                this_param)
                {
                    var return_v = this_param.CmdletParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 22234, 22264);
                    return return_v;
                }


                int
                f_1067_22219_22265(System.Collections.Generic.List<Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter>
                this_param, Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 22219, 22265);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.QueryOption[]
                f_1067_22005_22037_I(Microsoft.PowerShell.Cmdletization.Xml.QueryOption[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 22005, 22037);
                    return return_v;
                }


                string[]
                f_1067_22454_22483(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter
                this_param)
                {
                    var return_v = this_param.CmdletParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 22454, 22483);
                    return return_v;
                }


                string[]
                f_1067_22569_22598(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter
                this_param)
                {
                    var return_v = this_param.CmdletParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 22569, 22598);
                    return return_v;
                }


                string[]
                f_1067_22569_22598_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 22569, 22598);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter>
                f_1067_22406_22416_I(System.Collections.Generic.List<Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 22406, 22416);
                    return return_v;
                }


                int
                f_1067_22791_22814(System.Collections.Generic.Dictionary<string, object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 22791, 22814);
                    return return_v;
                }


                int
                f_1067_22854_22923(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key, object
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 22854, 22923);
                    return 0;
                }


                int
                f_1067_23122_23196(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key, object
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 23122, 23196);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, object>.KeyCollection
                f_1067_23252_23274(System.Collections.Generic.Dictionary<string, object>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 23252, 23274);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1067_23235_23275(System.Collections.Generic.Dictionary<string, object>.KeyCollection
                collection)
                {
                    var return_v = new System.Collections.Generic.List<string>((System.Collections.Generic.IEnumerable<string>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 23235, 23275);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 20062, 23287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 20062, 23287);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Type GetDotNetType(TypeMetadata typeMetadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 23299, 24440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 23377, 23455);

                f_1067_23377_23454(typeMetadata != null, "Caller should verify typeMetadata != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 23471, 23489);

                string
                psTypeText
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 23503, 23883);

                List<EnumMetadataEnum>
                matchingEnums = f_1067_23542_23882(f_1067_23542_23855((f_1067_23543_23571(_cmdletizationMetadata) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum[]>(1067, 23543, 23611) ?? f_1067_23575_23611()))
                , e => Regex.IsMatch(
                                    typeMetadata.PSType,
                                    string.Format(CultureInfo.InvariantCulture, @"\b{0}\b", Regex.Escape(e.EnumName)),
                                    RegexOptions.CultureInvariant)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 23897, 23980);

                EnumMetadataEnum
                matchingEnum = (DynAbs.Tracing.TraceSender.Conditional_F1(1067, 23929, 23953) || ((f_1067_23929_23948(matchingEnums) == 1 && DynAbs.Tracing.TraceSender.Conditional_F2(1067, 23956, 23972)) || DynAbs.Tracing.TraceSender.Conditional_F3(1067, 23975, 23979))) ? f_1067_23956_23972(matchingEnums, 0) : null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 23994, 24272) || true) && (matchingEnum != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 23994, 24272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 24052, 24158);

                    psTypeText = f_1067_24065_24157(f_1067_24065_24084(typeMetadata), f_1067_24093_24114(matchingEnum), f_1067_24116_24156(matchingEnum));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 23994, 24272);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 23994, 24272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 24224, 24257);

                    psTypeText = f_1067_24237_24256(typeMetadata);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 23994, 24272);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 24288, 24397);

                Type
                dotNetType = (Type)f_1067_24312_24396(psTypeText, typeof(Type), f_1067_24367_24395())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 24411, 24429);

                return dotNetType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 23299, 24440);

                int
                f_1067_23377_23454(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 23377, 23454);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum[]
                f_1067_23543_23571(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Enums;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 23543, 23571);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum>
                f_1067_23575_23611()
                {
                    var return_v = Enumerable.Empty<EnumMetadataEnum>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 23575, 23611);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum>
                f_1067_23542_23855(System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum>
                source, System.Func<Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 23542, 23855);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum>
                f_1067_23542_23882(System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum>
                source)
                {
                    var return_v = source.ToList<Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 23542, 23882);
                    return return_v;
                }


                int
                f_1067_23929_23948(System.Collections.Generic.List<Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 23929, 23948);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum
                f_1067_23956_23972(System.Collections.Generic.List<Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 23956, 23972);
                    return return_v;
                }


                string
                f_1067_24065_24084(Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                this_param)
                {
                    var return_v = this_param.PSType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 24065, 24084);
                    return return_v;
                }


                string
                f_1067_24093_24114(Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum
                this_param)
                {
                    var return_v = this_param.EnumName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 24093, 24114);
                    return return_v;
                }


                string
                f_1067_24116_24156(Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum
                enumMetadata)
                {
                    var return_v = EnumWriter.GetEnumFullName(enumMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 24116, 24156);
                    return return_v;
                }


                string
                f_1067_24065_24157(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 24065, 24157);
                    return return_v;
                }


                string
                f_1067_24237_24256(Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                this_param)
                {
                    var return_v = this_param.PSType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 24237, 24256);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_24367_24395()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 24367, 24395);
                    return return_v;
                }


                object
                f_1067_24312_24396(string
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 24312, 24396);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 23299, 24440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 23299, 24440);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ParameterMetadata GetParameter(
                    string parameterSetName,
                    string objectModelParameterName,
                    TypeMetadata parameterTypeMetadata,
                    CmdletParameterMetadata parameterCmdletization,
                    bool isValueFromPipeline,
                    bool isValueFromPipelineByPropertyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 24452, 31150);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 24802, 24823);

                string
                parameterName
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 24837, 25133) || true) && ((parameterCmdletization != null) && (DynAbs.Tracing.TraceSender.Expression_True(1067, 24841, 24931) && (!f_1067_24879_24930(f_1067_24900_24929(parameterCmdletization)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 24837, 25133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 24965, 25011);

                    parameterName = f_1067_24981_25010(parameterCmdletization);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 24837, 25133);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 24837, 25133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 25077, 25118);

                    parameterName = objectModelParameterName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 24837, 25133);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 25149, 25224);

                ParameterMetadata
                parameterMetadata = f_1067_25187_25223(parameterName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 25238, 25309);

                parameterMetadata.ParameterType = f_1067_25272_25308(this, parameterTypeMetadata);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 25323, 25496) || true) && (f_1067_25327_25387(typeof(PSCredential), f_1067_25355_25386(parameterMetadata)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 25323, 25496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 25421, 25481);

                    f_1067_25421_25480(f_1067_25421_25449(parameterMetadata), f_1067_25454_25479());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 25323, 25496);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 25512, 25691) || true) && (f_1067_25516_25545(parameterTypeMetadata) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 25512, 25691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 25587, 25676);

                    f_1067_25587_25675(f_1067_25587_25615(parameterMetadata), f_1067_25620_25674(f_1067_25644_25673(parameterTypeMetadata)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 25512, 25691);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 25707, 29942) || true) && (parameterCmdletization != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 25707, 29942);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 25775, 26160) || true) && (f_1067_25779_25809(parameterCmdletization) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 25775, 26160);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 25859, 26141);
                            foreach (string alias in f_1067_25884_25914_I(f_1067_25884_25914(parameterCmdletization)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 25859, 26141);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 25964, 26118) || true) && (!f_1067_25969_25996(alias))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 25964, 26118);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 26054, 26091);

                                    f_1067_26054_26090(f_1067_26054_26079(parameterMetadata), alias);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 25964, 26118);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 25859, 26141);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 283);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 283);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 25775, 26160);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 26180, 26366) || true) && (f_1067_26184_26227(parameterCmdletization) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 26180, 26366);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 26277, 26347);

                        f_1067_26277_26346(f_1067_26277_26305(parameterMetadata), f_1067_26310_26345());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 26180, 26366);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 26386, 26564) || true) && (f_1067_26390_26429(parameterCmdletization) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 26386, 26564);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 26479, 26545);

                        f_1067_26479_26544(f_1067_26479_26507(parameterMetadata), f_1067_26512_26543());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 26386, 26564);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 26584, 26748) || true) && (f_1067_26588_26620(parameterCmdletization) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 26584, 26748);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 26670, 26729);

                        f_1067_26670_26728(f_1067_26670_26698(parameterMetadata), f_1067_26703_26727());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 26584, 26748);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 26768, 27250) || true) && (f_1067_26772_26808(parameterCmdletization) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 26768, 27250);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 26858, 26987);

                        int
                        min = (int)f_1067_26873_26986(f_1067_26902_26942(f_1067_26902_26938(parameterCmdletization)), typeof(int), f_1067_26957_26985())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 27009, 27138);

                        int
                        max = (int)f_1067_27024_27137(f_1067_27053_27093(f_1067_27053_27089(parameterCmdletization)), typeof(int), f_1067_27108_27136())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 27160, 27231);

                        f_1067_27160_27230(f_1067_27160_27188(parameterMetadata), f_1067_27193_27229(min, max));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 26768, 27250);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 27270, 27756) || true) && (f_1067_27274_27311(parameterCmdletization) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 27270, 27756);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 27361, 27491);

                        int
                        min = (int)f_1067_27376_27490(f_1067_27405_27446(f_1067_27405_27442(parameterCmdletization)), typeof(int), f_1067_27461_27489())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 27513, 27643);

                        int
                        max = (int)f_1067_27528_27642(f_1067_27557_27598(f_1067_27557_27594(parameterCmdletization)), typeof(int), f_1067_27613_27641())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 27665, 27737);

                        f_1067_27665_27736(f_1067_27665_27693(parameterMetadata), f_1067_27698_27735(min, max));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 27270, 27756);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 27776, 28092) || true) && (f_1067_27780_27811(parameterCmdletization) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 27776, 28092);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 27861, 27926);

                        string
                        obsoleteMessage = f_1067_27886_27925(f_1067_27886_27917(parameterCmdletization))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 27948, 28073);

                        f_1067_27948_28072(f_1067_27948_27976(parameterMetadata), (DynAbs.Tracing.TraceSender.Conditional_F1(1067, 27981, 28004) || ((obsoleteMessage != null && DynAbs.Tracing.TraceSender.Conditional_F2(1067, 28007, 28045)) || DynAbs.Tracing.TraceSender.Conditional_F3(1067, 28048, 28071))) ? f_1067_28007_28045(obsoleteMessage) : f_1067_28048_28071());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 27776, 28092);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 28112, 28288) || true) && (f_1067_28116_28154(parameterCmdletization) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 28112, 28288);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 28204, 28269);

                        f_1067_28204_28268(f_1067_28204_28232(parameterMetadata), f_1067_28237_28267());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 28112, 28288);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 28308, 28498) || true) && (f_1067_28312_28357(parameterCmdletization) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 28308, 28498);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 28407, 28479);

                        f_1067_28407_28478(f_1067_28407_28435(parameterMetadata), f_1067_28440_28477());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 28308, 28498);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 28518, 29451) || true) && (f_1067_28522_28558(parameterCmdletization) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 28518, 29451);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 28608, 28661);

                        Type
                        parameterType = f_1067_28629_28660(parameterMetadata)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 28683, 28700);

                        Type
                        elementType
                        = default(Type);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 28722, 29039) || true) && (parameterType == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 28722, 29039);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 28797, 28826);

                            elementType = typeof(string);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 28722, 29039);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 28722, 29039);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 28924, 29016);

                            elementType = (DynAbs.Tracing.TraceSender.Conditional_F1(1067, 28938, 28966) || ((f_1067_28938_28966(parameterType) && DynAbs.Tracing.TraceSender.Conditional_F2(1067, 28969, 28999)) || DynAbs.Tracing.TraceSender.Conditional_F3(1067, 29002, 29015))) ? f_1067_28969_28999(parameterType) : parameterType;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 28722, 29039);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 29063, 29190);

                        object
                        min = f_1067_29076_29189(f_1067_29105_29145(f_1067_29105_29141(parameterCmdletization)), elementType, f_1067_29160_29188())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 29212, 29339);

                        object
                        max = f_1067_29225_29338(f_1067_29254_29294(f_1067_29254_29290(parameterCmdletization)), elementType, f_1067_29309_29337())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 29361, 29432);

                        f_1067_29361_29431(f_1067_29361_29389(parameterMetadata), f_1067_29394_29430(min, max));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 28518, 29451);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 29471, 29927) || true) && (f_1067_29475_29509(parameterCmdletization) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 29471, 29927);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 29559, 29607);

                        List<string>
                        allowedValues = f_1067_29588_29606()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 29629, 29800);
                            foreach (string allowedValue in f_1067_29661_29695_I(f_1067_29661_29695(parameterCmdletization)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 29629, 29800);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 29745, 29777);

                                f_1067_29745_29776(allowedValues, allowedValue);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 29629, 29800);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 172);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 172);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 29824, 29908);

                        f_1067_29824_29907(f_1067_29824_29852(parameterMetadata), f_1067_29857_29906(f_1067_29882_29905(allowedValues)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 29471, 29927);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 25707, 29942);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 29958, 29986);

                int
                position = int.MinValue
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 30000, 30055);

                ParameterSetMetadata.ParameterFlags
                parameterFlags = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 30069, 30622) || true) && (parameterCmdletization != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 30069, 30622);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 30137, 30377) || true) && (!f_1067_30142_30195(f_1067_30163_30194(parameterCmdletization)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 30137, 30377);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 30237, 30358);

                        position = (int)f_1067_30253_30357(f_1067_30282_30313(parameterCmdletization), typeof(int), f_1067_30328_30356());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 30137, 30377);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 30397, 30607) || true) && (f_1067_30401_30444(parameterCmdletization) && (DynAbs.Tracing.TraceSender.Expression_True(1067, 30401, 30482) && f_1067_30448_30482(parameterCmdletization)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 30397, 30607);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 30524, 30588);

                        parameterFlags |= ParameterSetMetadata.ParameterFlags.Mandatory;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 30397, 30607);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 30069, 30622);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 30638, 30782) || true) && (isValueFromPipeline)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 30638, 30782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 30695, 30767);

                    parameterFlags |= ParameterSetMetadata.ParameterFlags.ValueFromPipeline;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 30638, 30782);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 30798, 30970) || true) && (isValueFromPipelineByPropertyName)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 30798, 30970);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 30869, 30955);

                    parameterFlags |= ParameterSetMetadata.ParameterFlags.ValueFromPipelineByPropertyName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 30798, 30970);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 30986, 31098);

                f_1067_30986_31097(f_1067_30986_31017(parameterMetadata), parameterSetName, f_1067_31040_31096(position, parameterFlags, null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 31114, 31139);

                return parameterMetadata;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 24452, 31150);

                string
                f_1067_24900_24929(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.PSName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 24900, 24929);
                    return return_v;
                }


                bool
                f_1067_24879_24930(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 24879, 24930);
                    return return_v;
                }


                string
                f_1067_24981_25010(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.PSName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 24981, 25010);
                    return return_v;
                }


                System.Management.Automation.ParameterMetadata
                f_1067_25187_25223(string
                name)
                {
                    var return_v = new System.Management.Automation.ParameterMetadata(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 25187, 25223);
                    return return_v;
                }


                System.Type
                f_1067_25272_25308(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                typeMetadata)
                {
                    var return_v = this_param.GetDotNetType(typeMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 25272, 25308);
                    return return_v;
                }


                System.Type
                f_1067_25355_25386(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 25355, 25386);
                    return return_v;
                }


                bool
                f_1067_25327_25387(System.Type
                this_param, System.Type
                o)
                {
                    var return_v = this_param.Equals(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 25327, 25387);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1067_25421_25449(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 25421, 25449);
                    return return_v;
                }


                System.Management.Automation.CredentialAttribute
                f_1067_25454_25479()
                {
                    var return_v = new System.Management.Automation.CredentialAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 25454, 25479);
                    return return_v;
                }


                int
                f_1067_25421_25480(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.CredentialAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 25421, 25480);
                    return 0;
                }


                string
                f_1067_25516_25545(Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                this_param)
                {
                    var return_v = this_param.ETSType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 25516, 25545);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1067_25587_25615(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 25587, 25615);
                    return return_v;
                }


                string
                f_1067_25644_25673(Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                this_param)
                {
                    var return_v = this_param.ETSType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 25644, 25673);
                    return return_v;
                }


                System.Management.Automation.PSTypeNameAttribute
                f_1067_25620_25674(string
                psTypeName)
                {
                    var return_v = new System.Management.Automation.PSTypeNameAttribute(psTypeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 25620, 25674);
                    return return_v;
                }


                int
                f_1067_25587_25675(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.PSTypeNameAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 25587, 25675);
                    return 0;
                }


                string[]
                f_1067_25779_25809(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.Aliases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 25779, 25809);
                    return return_v;
                }


                string[]
                f_1067_25884_25914(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.Aliases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 25884, 25914);
                    return return_v;
                }


                bool
                f_1067_25969_25996(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 25969, 25996);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1067_26054_26079(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Aliases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 26054, 26079);
                    return return_v;
                }


                int
                f_1067_26054_26090(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 26054, 26090);
                    return 0;
                }


                string[]
                f_1067_25884_25914_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 25884, 25914);
                    return return_v;
                }


                object
                f_1067_26184_26227(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.AllowEmptyCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 26184, 26227);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1067_26277_26305(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 26277, 26305);
                    return return_v;
                }


                System.Management.Automation.AllowEmptyCollectionAttribute
                f_1067_26310_26345()
                {
                    var return_v = new System.Management.Automation.AllowEmptyCollectionAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 26310, 26345);
                    return return_v;
                }


                int
                f_1067_26277_26346(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.AllowEmptyCollectionAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 26277, 26346);
                    return 0;
                }


                object
                f_1067_26390_26429(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.AllowEmptyString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 26390, 26429);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1067_26479_26507(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 26479, 26507);
                    return return_v;
                }


                System.Management.Automation.AllowEmptyStringAttribute
                f_1067_26512_26543()
                {
                    var return_v = new System.Management.Automation.AllowEmptyStringAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 26512, 26543);
                    return return_v;
                }


                int
                f_1067_26479_26544(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.AllowEmptyStringAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 26479, 26544);
                    return 0;
                }


                object
                f_1067_26588_26620(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.AllowNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 26588, 26620);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1067_26670_26698(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 26670, 26698);
                    return return_v;
                }


                System.Management.Automation.AllowNullAttribute
                f_1067_26703_26727()
                {
                    var return_v = new System.Management.Automation.AllowNullAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 26703, 26727);
                    return return_v;
                }


                int
                f_1067_26670_26728(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.AllowNullAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 26670, 26728);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataValidateCount
                f_1067_26772_26808(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.ValidateCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 26772, 26808);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataValidateCount
                f_1067_26902_26938(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.ValidateCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 26902, 26938);
                    return return_v;
                }


                string
                f_1067_26902_26942(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataValidateCount
                this_param)
                {
                    var return_v = this_param.Min;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 26902, 26942);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_26957_26985()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 26957, 26985);
                    return return_v;
                }


                object
                f_1067_26873_26986(string
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 26873, 26986);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataValidateCount
                f_1067_27053_27089(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.ValidateCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 27053, 27089);
                    return return_v;
                }


                string
                f_1067_27053_27093(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataValidateCount
                this_param)
                {
                    var return_v = this_param.Max;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 27053, 27093);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_27108_27136()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 27108, 27136);
                    return return_v;
                }


                object
                f_1067_27024_27137(string
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 27024, 27137);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1067_27160_27188(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 27160, 27188);
                    return return_v;
                }


                System.Management.Automation.ValidateCountAttribute
                f_1067_27193_27229(int
                minLength, int
                maxLength)
                {
                    var return_v = new System.Management.Automation.ValidateCountAttribute(minLength, maxLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 27193, 27229);
                    return return_v;
                }


                int
                f_1067_27160_27230(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ValidateCountAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 27160, 27230);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataValidateLength
                f_1067_27274_27311(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.ValidateLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 27274, 27311);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataValidateLength
                f_1067_27405_27442(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.ValidateLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 27405, 27442);
                    return return_v;
                }


                string
                f_1067_27405_27446(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataValidateLength
                this_param)
                {
                    var return_v = this_param.Min;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 27405, 27446);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_27461_27489()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 27461, 27489);
                    return return_v;
                }


                object
                f_1067_27376_27490(string
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 27376, 27490);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataValidateLength
                f_1067_27557_27594(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.ValidateLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 27557, 27594);
                    return return_v;
                }


                string
                f_1067_27557_27598(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataValidateLength
                this_param)
                {
                    var return_v = this_param.Max;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 27557, 27598);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_27613_27641()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 27613, 27641);
                    return return_v;
                }


                object
                f_1067_27528_27642(string
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 27528, 27642);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1067_27665_27693(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 27665, 27693);
                    return return_v;
                }


                System.Management.Automation.ValidateLengthAttribute
                f_1067_27698_27735(int
                minLength, int
                maxLength)
                {
                    var return_v = new System.Management.Automation.ValidateLengthAttribute(minLength, maxLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 27698, 27735);
                    return return_v;
                }


                int
                f_1067_27665_27736(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ValidateLengthAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 27665, 27736);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ObsoleteAttributeMetadata
                f_1067_27780_27811(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.Obsolete;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 27780, 27811);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ObsoleteAttributeMetadata
                f_1067_27886_27917(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.Obsolete;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 27886, 27917);
                    return return_v;
                }


                string
                f_1067_27886_27925(Microsoft.PowerShell.Cmdletization.Xml.ObsoleteAttributeMetadata
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 27886, 27925);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1067_27948_27976(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 27948, 27976);
                    return return_v;
                }


                System.ObsoleteAttribute
                f_1067_28007_28045(string
                message)
                {
                    var return_v = new System.ObsoleteAttribute(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 28007, 28045);
                    return return_v;
                }


                System.ObsoleteAttribute
                f_1067_28048_28071()
                {
                    var return_v = new System.ObsoleteAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 28048, 28071);
                    return return_v;
                }


                int
                f_1067_27948_28072(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.ObsoleteAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 27948, 28072);
                    return 0;
                }


                object
                f_1067_28116_28154(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.ValidateNotNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 28116, 28154);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1067_28204_28232(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 28204, 28232);
                    return return_v;
                }


                System.Management.Automation.ValidateNotNullAttribute
                f_1067_28237_28267()
                {
                    var return_v = new System.Management.Automation.ValidateNotNullAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 28237, 28267);
                    return return_v;
                }


                int
                f_1067_28204_28268(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ValidateNotNullAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 28204, 28268);
                    return 0;
                }


                object
                f_1067_28312_28357(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.ValidateNotNullOrEmpty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 28312, 28357);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1067_28407_28435(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 28407, 28435);
                    return return_v;
                }


                System.Management.Automation.ValidateNotNullOrEmptyAttribute
                f_1067_28440_28477()
                {
                    var return_v = new System.Management.Automation.ValidateNotNullOrEmptyAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 28440, 28477);
                    return return_v;
                }


                int
                f_1067_28407_28478(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ValidateNotNullOrEmptyAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 28407, 28478);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataValidateRange
                f_1067_28522_28558(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.ValidateRange;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 28522, 28558);
                    return return_v;
                }


                System.Type
                f_1067_28629_28660(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 28629, 28660);
                    return return_v;
                }


                bool
                f_1067_28938_28966(System.Type
                this_param)
                {
                    var return_v = this_param.HasElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 28938, 28966);
                    return return_v;
                }


                System.Type?
                f_1067_28969_28999(System.Type
                this_param)
                {
                    var return_v = this_param.GetElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 28969, 28999);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataValidateRange
                f_1067_29105_29141(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.ValidateRange;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 29105, 29141);
                    return return_v;
                }


                string
                f_1067_29105_29145(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataValidateRange
                this_param)
                {
                    var return_v = this_param.Min;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 29105, 29145);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_29160_29188()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 29160, 29188);
                    return return_v;
                }


                object
                f_1067_29076_29189(string
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 29076, 29189);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataValidateRange
                f_1067_29254_29290(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.ValidateRange;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 29254, 29290);
                    return return_v;
                }


                string
                f_1067_29254_29294(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataValidateRange
                this_param)
                {
                    var return_v = this_param.Max;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 29254, 29294);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_29309_29337()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 29309, 29337);
                    return return_v;
                }


                object
                f_1067_29225_29338(string
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 29225, 29338);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1067_29361_29389(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 29361, 29389);
                    return return_v;
                }


                System.Management.Automation.ValidateRangeAttribute
                f_1067_29394_29430(object
                minRange, object
                maxRange)
                {
                    var return_v = new System.Management.Automation.ValidateRangeAttribute(minRange, maxRange);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 29394, 29430);
                    return return_v;
                }


                int
                f_1067_29361_29431(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ValidateRangeAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 29361, 29431);
                    return 0;
                }


                string[]
                f_1067_29475_29509(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.ValidateSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 29475, 29509);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1067_29588_29606()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 29588, 29606);
                    return return_v;
                }


                string[]
                f_1067_29661_29695(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.ValidateSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 29661, 29695);
                    return return_v;
                }


                int
                f_1067_29745_29776(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 29745, 29776);
                    return 0;
                }


                string[]
                f_1067_29661_29695_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 29661, 29695);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1067_29824_29852(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 29824, 29852);
                    return return_v;
                }


                string[]
                f_1067_29882_29905(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 29882, 29905);
                    return return_v;
                }


                System.Management.Automation.ValidateSetAttribute
                f_1067_29857_29906(params string[]
                validValues)
                {
                    var return_v = new System.Management.Automation.ValidateSetAttribute(validValues);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 29857, 29906);
                    return return_v;
                }


                int
                f_1067_29824_29907(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ValidateSetAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 29824, 29907);
                    return 0;
                }


                string
                f_1067_30163_30194(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 30163, 30194);
                    return return_v;
                }


                bool
                f_1067_30142_30195(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 30142, 30195);
                    return return_v;
                }


                string
                f_1067_30282_30313(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 30282, 30313);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_30328_30356()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 30328, 30356);
                    return return_v;
                }


                object
                f_1067_30253_30357(string
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 30253, 30357);
                    return return_v;
                }


                bool
                f_1067_30401_30444(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.IsMandatorySpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 30401, 30444);
                    return return_v;
                }


                bool
                f_1067_30448_30482(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata
                this_param)
                {
                    var return_v = this_param.IsMandatory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 30448, 30482);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1067_30986_31017(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 30986, 31017);
                    return return_v;
                }


                System.Management.Automation.ParameterSetMetadata
                f_1067_31040_31096(int
                position, System.Management.Automation.ParameterSetMetadata.ParameterFlags
                flags, string
                helpMessage)
                {
                    var return_v = new System.Management.Automation.ParameterSetMetadata(position, flags, helpMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 31040, 31096);
                    return return_v;
                }


                int
                f_1067_30986_31097(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param, string
                key, System.Management.Automation.ParameterSetMetadata
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 30986, 31097);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 24452, 31150);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 24452, 31150);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ParameterMetadata GetParameter(
                    string parameterSetName,
                    string objectModelParameterName,
                    TypeMetadata parameterType,
                    CmdletParameterMetadataForInstanceMethodParameter parameterCmdletization)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 31162, 31845);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 31438, 31834);

                return f_1067_31445_31833(this, parameterSetName, objectModelParameterName, parameterType, parameterCmdletization, false, parameterCmdletization != null && (DynAbs.Tracing.TraceSender.Expression_True(1067, 31677, 31774) && f_1067_31711_31774(parameterCmdletization)) && (DynAbs.Tracing.TraceSender.Expression_True(1067, 31677, 31832) && f_1067_31778_31832(parameterCmdletization)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 31162, 31845);

                bool
                f_1067_31711_31774(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForInstanceMethodParameter
                this_param)
                {
                    var return_v = this_param.ValueFromPipelineByPropertyNameSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 31711, 31774);
                    return return_v;
                }


                bool
                f_1067_31778_31832(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForInstanceMethodParameter
                this_param)
                {
                    var return_v = this_param.ValueFromPipelineByPropertyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 31778, 31832);
                    return return_v;
                }


                System.Management.Automation.ParameterMetadata
                f_1067_31445_31833(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, string
                parameterSetName, string
                objectModelParameterName, Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                parameterTypeMetadata, Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForInstanceMethodParameter
                parameterCmdletization, bool
                isValueFromPipeline, bool
                isValueFromPipelineByPropertyName)
                {
                    var return_v = this_param.GetParameter(parameterSetName, objectModelParameterName, parameterTypeMetadata, (Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata)parameterCmdletization, isValueFromPipeline, isValueFromPipelineByPropertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 31445, 31833);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 31162, 31845);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 31162, 31845);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ParameterMetadata GetParameter(
                    IEnumerable<string> queryParameterSets,
                    string objectModelParameterName,
                    TypeMetadata parameterType,
                    CmdletParameterMetadataForGetCmdletParameter parameterCmdletization)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 31857, 33532);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 32143, 32674);

                ParameterMetadata
                result = f_1067_32170_32673(this, ParameterAttribute.AllParameterSets, objectModelParameterName, parameterType, parameterCmdletization, parameterCmdletization != null && (DynAbs.Tracing.TraceSender.Expression_True(1067, 32371, 32454) && f_1067_32405_32454(parameterCmdletization)) && (DynAbs.Tracing.TraceSender.Expression_True(1067, 32371, 32498) && f_1067_32458_32498(parameterCmdletization)), parameterCmdletization != null && (DynAbs.Tracing.TraceSender.Expression_True(1067, 32517, 32614) && f_1067_32551_32614(parameterCmdletization)) && (DynAbs.Tracing.TraceSender.Expression_True(1067, 32517, 32672) && f_1067_32618_32672(parameterCmdletization)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 32690, 32792);

                ParameterSetMetadata
                parameterSetMetadata = f_1067_32734_32791(f_1067_32734_32754(result), ParameterAttribute.AllParameterSets)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 32806, 32835);

                f_1067_32806_32834(f_1067_32806_32826(result));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 32849, 33107) || true) && (parameterCmdletization != null && (DynAbs.Tracing.TraceSender.Expression_True(1067, 32853, 32937) && f_1067_32887_32929(parameterCmdletization) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1067, 32853, 32994) && f_1067_32941_32990(f_1067_32941_32983(parameterCmdletization)) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 32849, 33107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 33028, 33092);

                    queryParameterSets = f_1067_33049_33091(parameterCmdletization);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 32849, 33107);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 33123, 33491);
                    foreach (string parameterSetName in f_1067_33159_33177_I(queryParameterSets))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 33123, 33491);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 33211, 33391) || true) && (f_1067_33215_33321(parameterSetName, ScriptWriter.InputObjectQueryParameterSetName, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 33211, 33391);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 33363, 33372);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 33211, 33391);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 33411, 33476);

                        f_1067_33411_33475(f_1067_33411_33431(result), parameterSetName, parameterSetMetadata);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 33123, 33491);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 369);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 369);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 33507, 33521);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 31857, 33532);

                bool
                f_1067_32405_32454(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter
                this_param)
                {
                    var return_v = this_param.ValueFromPipelineSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 32405, 32454);
                    return return_v;
                }


                bool
                f_1067_32458_32498(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter
                this_param)
                {
                    var return_v = this_param.ValueFromPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 32458, 32498);
                    return return_v;
                }


                bool
                f_1067_32551_32614(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter
                this_param)
                {
                    var return_v = this_param.ValueFromPipelineByPropertyNameSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 32551, 32614);
                    return return_v;
                }


                bool
                f_1067_32618_32672(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter
                this_param)
                {
                    var return_v = this_param.ValueFromPipelineByPropertyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 32618, 32672);
                    return return_v;
                }


                System.Management.Automation.ParameterMetadata
                f_1067_32170_32673(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, string
                parameterSetName, string
                objectModelParameterName, Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                parameterTypeMetadata, Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter
                parameterCmdletization, bool
                isValueFromPipeline, bool
                isValueFromPipelineByPropertyName)
                {
                    var return_v = this_param.GetParameter(parameterSetName, objectModelParameterName, parameterTypeMetadata, (Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata)parameterCmdletization, isValueFromPipeline, isValueFromPipelineByPropertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 32170, 32673);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1067_32734_32754(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 32734, 32754);
                    return return_v;
                }


                System.Management.Automation.ParameterSetMetadata
                f_1067_32734_32791(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 32734, 32791);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1067_32806_32826(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 32806, 32826);
                    return return_v;
                }


                int
                f_1067_32806_32834(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 32806, 32834);
                    return 0;
                }


                string[]
                f_1067_32887_32929(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter
                this_param)
                {
                    var return_v = this_param.CmdletParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 32887, 32929);
                    return return_v;
                }


                string[]
                f_1067_32941_32983(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter
                this_param)
                {
                    var return_v = this_param.CmdletParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 32941, 32983);
                    return return_v;
                }


                int
                f_1067_32941_32990(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 32941, 32990);
                    return return_v;
                }


                string[]
                f_1067_33049_33091(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter
                this_param)
                {
                    var return_v = this_param.CmdletParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 33049, 33091);
                    return return_v;
                }


                bool
                f_1067_33215_33321(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 33215, 33321);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1067_33411_33431(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 33411, 33431);
                    return return_v;
                }


                int
                f_1067_33411_33475(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param, string
                key, System.Management.Automation.ParameterSetMetadata
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 33411, 33475);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1067_33159_33177_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 33159, 33177);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 31857, 33532);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 31857, 33532);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ParameterMetadata GetParameter(
                    string parameterSetName,
                    string objectModelParameterName,
                    TypeMetadata parameterType,
                    CmdletParameterMetadataForStaticMethodParameter parameterCmdletization)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 33544, 34321);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 33818, 34310);

                return f_1067_33825_34309(this, parameterSetName, objectModelParameterName, parameterType, parameterCmdletization, parameterCmdletization != null && (DynAbs.Tracing.TraceSender.Expression_True(1067, 34007, 34090) && f_1067_34041_34090(parameterCmdletization)) && (DynAbs.Tracing.TraceSender.Expression_True(1067, 34007, 34134) && f_1067_34094_34134(parameterCmdletization)), parameterCmdletization != null && (DynAbs.Tracing.TraceSender.Expression_True(1067, 34153, 34250) && f_1067_34187_34250(parameterCmdletization)) && (DynAbs.Tracing.TraceSender.Expression_True(1067, 34153, 34308) && f_1067_34254_34308(parameterCmdletization)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 33544, 34321);

                bool
                f_1067_34041_34090(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForStaticMethodParameter
                this_param)
                {
                    var return_v = this_param.ValueFromPipelineSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 34041, 34090);
                    return return_v;
                }


                bool
                f_1067_34094_34134(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForStaticMethodParameter
                this_param)
                {
                    var return_v = this_param.ValueFromPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 34094, 34134);
                    return return_v;
                }


                bool
                f_1067_34187_34250(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForStaticMethodParameter
                this_param)
                {
                    var return_v = this_param.ValueFromPipelineByPropertyNameSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 34187, 34250);
                    return return_v;
                }


                bool
                f_1067_34254_34308(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForStaticMethodParameter
                this_param)
                {
                    var return_v = this_param.ValueFromPipelineByPropertyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 34254, 34308);
                    return return_v;
                }


                System.Management.Automation.ParameterMetadata
                f_1067_33825_34309(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, string
                parameterSetName, string
                objectModelParameterName, Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                parameterTypeMetadata, Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForStaticMethodParameter
                parameterCmdletization, bool
                isValueFromPipeline, bool
                isValueFromPipelineByPropertyName)
                {
                    var return_v = this_param.GetParameter(parameterSetName, objectModelParameterName, parameterTypeMetadata, (Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadata)parameterCmdletization, isValueFromPipeline, isValueFromPipelineByPropertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 33825, 34309);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 33544, 34321);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 33544, 34321);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void SetParameters(CommandMetadata commandMetadata, params Dictionary<string, ParameterMetadata>[] allParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 34333, 36178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 34479, 34514);

                f_1067_34479_34513(f_1067_34479_34505(commandMetadata));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 34528, 36167);
                    foreach (Dictionary<string, ParameterMetadata> parameters in f_1067_34589_34602_I(allParameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 34528, 36167);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 34636, 36152);
                            foreach (KeyValuePair<string, ParameterMetadata> parameter in f_1067_34698_34708_I(parameters))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 34636, 36152);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 34750, 36046) || true) && (f_1067_34754_34807(f_1067_34754_34780(commandMetadata), parameter.Key))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 34750, 36046);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 34857, 36023) || true) && (f_1067_34861_34914(f_1067_34861_34887(this), parameter.Key))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 34857, 36023);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 34972, 35368);

                                        string
                                        message = f_1067_34989_35367(f_1067_35037_35065(), f_1067_35118_35200(), parameter.Key, f_1067_35283_35303(commandMetadata), f_1067_35338_35366(_objectModelWrapper))
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 35398, 35430);

                                        throw f_1067_35404_35429(message);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 34857, 36023);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 34857, 36023);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 35544, 35934);

                                        string
                                        message = f_1067_35561_35933(f_1067_35609_35637(), f_1067_35690_35771(), parameter.Key, f_1067_35854_35874(commandMetadata), "<GetCmdletParameters>")
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 35964, 35996);

                                        throw f_1067_35970_35995(message);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 34857, 36023);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 34750, 36046);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 36070, 36133);

                                f_1067_36070_36132(f_1067_36070_36096(commandMetadata), parameter.Key, parameter.Value);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 34636, 36152);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 1517);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 1517);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 34528, 36167);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 1640);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 1640);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 34333, 36178);

                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                f_1067_34479_34505(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 34479, 34505);
                    return return_v;
                }


                int
                f_1067_34479_34513(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 34479, 34513);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                f_1067_34754_34780(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 34754, 34780);
                    return return_v;
                }


                bool
                f_1067_34754_34807(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 34754, 34807);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                f_1067_34861_34887(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param)
                {
                    var return_v = this_param.GetCommonParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 34861, 34887);
                    return return_v;
                }


                bool
                f_1067_34861_34914(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 34861, 34914);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_35037_35065()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 35037, 35065);
                    return return_v;
                }


                string
                f_1067_35118_35200()
                {
                    var return_v = CmdletizationCoreResources.ScriptWriter_ParameterNameConflictsWithCommonParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 35118, 35200);
                    return return_v;
                }


                string
                f_1067_35283_35303(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 35283, 35303);
                    return return_v;
                }


                string
                f_1067_35338_35366(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 35338, 35366);
                    return return_v;
                }


                string
                f_1067_34989_35367(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 34989, 35367);
                    return return_v;
                }


                System.Xml.XmlException
                f_1067_35404_35429(string
                message)
                {
                    var return_v = new System.Xml.XmlException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 35404, 35429);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_35609_35637()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 35609, 35637);
                    return return_v;
                }


                string
                f_1067_35690_35771()
                {
                    var return_v = CmdletizationCoreResources.ScriptWriter_ParameterNameConflictsWithQueryParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 35690, 35771);
                    return return_v;
                }


                string
                f_1067_35854_35874(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 35854, 35874);
                    return return_v;
                }


                string
                f_1067_35561_35933(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 35561, 35933);
                    return return_v;
                }


                System.Xml.XmlException
                f_1067_35970_35995(string
                message)
                {
                    var return_v = new System.Xml.XmlException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 35970, 35995);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                f_1067_36070_36096(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 36070, 36096);
                    return return_v;
                }


                int
                f_1067_36070_36132(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                this_param, string
                key, System.Management.Automation.ParameterMetadata
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 36070, 36132);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                f_1067_34698_34708_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 34698, 34708);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>[]
                f_1067_34589_34602_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 34589, 34602);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 34333, 36178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 34333, 36178);
            }
        }

        private CommandMetadata GetCommandMetadata(CommonCmdletMetadata cmdletMetadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 36190, 38188);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 36294, 36332);

                string
                defaultParameterSetName = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 36346, 36457);

                StaticCmdletMetadataCmdletMetadata
                staticCmdletMetadata = cmdletMetadata as StaticCmdletMetadataCmdletMetadata
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 36471, 36759) || true) && (staticCmdletMetadata != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 36471, 36759);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 36537, 36744) || true) && (!f_1067_36542_36610(f_1067_36563_36609(staticCmdletMetadata)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 36537, 36744);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 36652, 36725);

                        defaultParameterSetName = f_1067_36678_36724(staticCmdletMetadata);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 36537, 36744);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 36471, 36759);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 36775, 36843);

                var
                confirmImpact = System.Management.Automation.ConfirmImpact.None
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 36857, 37041) || true) && (f_1067_36861_36898(cmdletMetadata))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 36857, 37041);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 36932, 37026);

                    confirmImpact = (System.Management.Automation.ConfirmImpact)(int)f_1067_36997_37025(cmdletMetadata);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 36857, 37041);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 37057, 37184);

                Dictionary<string, ParameterMetadata>
                parameters = f_1067_37108_37183(f_1067_37150_37182())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 37200, 37975);

                CommandMetadata
                commandMetadata = f_1067_37234_37974(name: f_1067_37297_37331(this, cmdletMetadata), commandType: CommandTypes.Cmdlet, isProxyForCmdlet: true, defaultParameterSetName: defaultParameterSetName, supportsShouldProcess: confirmImpact != System.Management.Automation.ConfirmImpact.None, confirmImpact: confirmImpact, supportsPaging: false, supportsTransactions: false, positionalBinding: false, parameters: parameters)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 37991, 38138) || true) && (!f_1067_37996_38040(f_1067_38017_38039(cmdletMetadata)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 37991, 38138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 38074, 38123);

                    commandMetadata.HelpUri = f_1067_38100_38122(cmdletMetadata);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 37991, 38138);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 38154, 38177);

                return commandMetadata;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 36190, 38188);

                string
                f_1067_36563_36609(Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadataCmdletMetadata
                this_param)
                {
                    var return_v = this_param.DefaultCmdletParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 36563, 36609);
                    return return_v;
                }


                bool
                f_1067_36542_36610(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 36542, 36610);
                    return return_v;
                }


                string
                f_1067_36678_36724(Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadataCmdletMetadata
                this_param)
                {
                    var return_v = this_param.DefaultCmdletParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 36678, 36724);
                    return return_v;
                }


                bool
                f_1067_36861_36898(Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                this_param)
                {
                    var return_v = this_param.ConfirmImpactSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 36861, 36898);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ConfirmImpact
                f_1067_36997_37025(Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                this_param)
                {
                    var return_v = this_param.ConfirmImpact;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 36997, 37025);
                    return return_v;
                }


                System.StringComparer
                f_1067_37150_37182()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 37150, 37182);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                f_1067_37108_37183(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 37108, 37183);
                    return return_v;
                }


                string
                f_1067_37297_37331(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                cmdletMetadata)
                {
                    var return_v = this_param.GetCmdletName(cmdletMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 37297, 37331);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1067_37234_37974(string
                name, System.Management.Automation.CommandTypes
                commandType, bool
                isProxyForCmdlet, string
                defaultParameterSetName, bool
                supportsShouldProcess, System.Management.Automation.ConfirmImpact
                confirmImpact, bool
                supportsPaging, bool
                supportsTransactions, bool
                positionalBinding, System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                parameters)
                {
                    var return_v = new System.Management.Automation.CommandMetadata(name: name, commandType: commandType, isProxyForCmdlet: isProxyForCmdlet, defaultParameterSetName: defaultParameterSetName, supportsShouldProcess: supportsShouldProcess, confirmImpact: confirmImpact, supportsPaging: supportsPaging, supportsTransactions: supportsTransactions, positionalBinding: positionalBinding, parameters: parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 37234, 37974);
                    return return_v;
                }


                string
                f_1067_38017_38039(Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                this_param)
                {
                    var return_v = this_param.HelpUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 38017, 38039);
                    return return_v;
                }


                bool
                f_1067_37996_38040(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 37996, 38040);
                    return return_v;
                }


                string
                f_1067_38100_38122(Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                this_param)
                {
                    var return_v = this_param.HelpUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 38100, 38122);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 36190, 38188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 36190, 38188);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string EscapeModuleNameForHelpComment(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1067, 38200, 38764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 38290, 38352);

                f_1067_38290_38351(name != null, "Caller should verify name != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 38368, 38422);

                StringBuilder
                result = f_1067_38391_38421(f_1067_38409_38420(name))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 38436, 38712);
                    foreach (char c in f_1067_38455_38459_I(name))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 38436, 38712);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 38493, 38697) || true) && ((f_1067_38498_38517("\"'`$#", c) == (-1)) && (DynAbs.Tracing.TraceSender.Expression_True(1067, 38497, 38571) && (!f_1067_38553_38570(c))) && (DynAbs.Tracing.TraceSender.Expression_True(1067, 38497, 38619) && (!f_1067_38598_38618(c))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 38493, 38697);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 38661, 38678);

                            f_1067_38661_38677(result, c);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 38493, 38697);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 38436, 38712);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 277);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 277);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 38728, 38753);

                return f_1067_38735_38752(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1067, 38200, 38764);

                int
                f_1067_38290_38351(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 38290, 38351);
                    return 0;
                }


                int
                f_1067_38409_38420(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 38409, 38420);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1067_38391_38421(int
                capacity)
                {
                    var return_v = new System.Text.StringBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 38391, 38421);
                    return return_v;
                }


                int
                f_1067_38498_38517(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 38498, 38517);
                    return return_v;
                }


                bool
                f_1067_38553_38570(char
                c)
                {
                    var return_v = char.IsControl(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 38553, 38570);
                    return return_v;
                }


                bool
                f_1067_38598_38618(char
                c)
                {
                    var return_v = char.IsWhiteSpace(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 38598, 38618);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1067_38661_38677(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 38661, 38677);
                    return return_v;
                }


                string
                f_1067_38455_38459_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 38455, 38459);
                    return return_v;
                }


                string
                f_1067_38735_38752(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 38735, 38752);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 38200, 38764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 38200, 38764);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static List<List<string>> GetCombinations(params IEnumerable<string>[] x)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1067, 38776, 40202);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 38882, 38939);

                f_1067_38882_38938(x != null, "Caller to verify that x != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 38953, 39016);

                f_1067_38953_39015(f_1067_38964_38972(x) > 0, "Caller to verify that x.Length > 0");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 39032, 40191) || true) && (f_1067_39036_39044(x) == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 39032, 40191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 39083, 39136);

                    List<List<string>>
                    result = f_1067_39111_39135()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 39154, 39367);
                        foreach (string s in f_1067_39175_39179_I(x[0]))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 39154, 39367);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 39221, 39265);

                            List<string>
                            subresult = f_1067_39246_39264()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 39287, 39304);

                            f_1067_39287_39303(subresult, s);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 39326, 39348);

                            f_1067_39326_39347(result, subresult);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 39154, 39367);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 214);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 214);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 39387, 39401);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 39032, 40191);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 39032, 40191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 39467, 39536);

                    IEnumerable<string>[]
                    smallX = new IEnumerable<string>[f_1067_39522_39530(x) - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 39554, 39597);

                    f_1067_39554_39596(x, 0, smallX, 0, f_1067_39582_39595(smallX));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 39615, 39672);

                    List<List<string>>
                    smallResult = f_1067_39648_39671(smallX)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 39692, 39745);

                    List<List<string>>
                    result = f_1067_39720_39744()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 39763, 40142);
                        foreach (List<string> smallSubresult in f_1067_39803_39814_I(smallResult))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 39763, 40142);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 39856, 40123);
                                foreach (string s in f_1067_39877_39892_I(x[f_1067_39879_39887(x) - 1]))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 39856, 40123);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 39942, 40003);

                                    List<string>
                                    newsubresult = f_1067_39970_40002(smallSubresult)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 40029, 40049);

                                    f_1067_40029_40048(newsubresult, s);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 40075, 40100);

                                    f_1067_40075_40099(result, newsubresult);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 39856, 40123);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 268);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 268);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 39763, 40142);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 380);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 380);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 40162, 40176);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 39032, 40191);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1067, 38776, 40202);

                int
                f_1067_38882_38938(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 38882, 38938);
                    return 0;
                }


                int
                f_1067_38964_38972(System.Collections.Generic.IEnumerable<string>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 38964, 38972);
                    return return_v;
                }


                int
                f_1067_38953_39015(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 38953, 39015);
                    return 0;
                }


                int
                f_1067_39036_39044(System.Collections.Generic.IEnumerable<string>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 39036, 39044);
                    return return_v;
                }


                System.Collections.Generic.List<System.Collections.Generic.List<string>>
                f_1067_39111_39135()
                {
                    var return_v = new System.Collections.Generic.List<System.Collections.Generic.List<string>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 39111, 39135);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1067_39246_39264()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 39246, 39264);
                    return return_v;
                }


                int
                f_1067_39287_39303(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 39287, 39303);
                    return 0;
                }


                int
                f_1067_39326_39347(System.Collections.Generic.List<System.Collections.Generic.List<string>>
                this_param, System.Collections.Generic.List<string>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 39326, 39347);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1067_39175_39179_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 39175, 39179);
                    return return_v;
                }


                int
                f_1067_39522_39530(System.Collections.Generic.IEnumerable<string>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 39522, 39530);
                    return return_v;
                }


                int
                f_1067_39582_39595(System.Collections.Generic.IEnumerable<string>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 39582, 39595);
                    return return_v;
                }


                int
                f_1067_39554_39596(System.Collections.Generic.IEnumerable<string>[]
                sourceArray, int
                sourceIndex, System.Collections.Generic.IEnumerable<string>[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 39554, 39596);
                    return 0;
                }


                System.Collections.Generic.List<System.Collections.Generic.List<string>>
                f_1067_39648_39671(params System.Collections.Generic.IEnumerable<string>[]
                x)
                {
                    var return_v = GetCombinations(x);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 39648, 39671);
                    return return_v;
                }


                System.Collections.Generic.List<System.Collections.Generic.List<string>>
                f_1067_39720_39744()
                {
                    var return_v = new System.Collections.Generic.List<System.Collections.Generic.List<string>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 39720, 39744);
                    return return_v;
                }


                int
                f_1067_39879_39887(System.Collections.Generic.IEnumerable<string>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 39879, 39887);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1067_39970_40002(System.Collections.Generic.List<string>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<string>((System.Collections.Generic.IEnumerable<string>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 39970, 40002);
                    return return_v;
                }


                int
                f_1067_40029_40048(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 40029, 40048);
                    return 0;
                }


                int
                f_1067_40075_40099(System.Collections.Generic.List<System.Collections.Generic.List<string>>
                this_param, System.Collections.Generic.List<string>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 40075, 40099);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1067_39877_39892_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 39877, 39892);
                    return return_v;
                }


                System.Collections.Generic.List<System.Collections.Generic.List<string>>
                f_1067_39803_39814_I(System.Collections.Generic.List<System.Collections.Generic.List<string>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 39803, 39814);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 38776, 40202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 38776, 40202);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void EnsureOrderOfPositionalParameters(
                    Dictionary<string, ParameterMetadata> beforeParameters,
                    Dictionary<string, ParameterMetadata> afterParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1067, 40214, 42023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 40430, 40467);

                int
                maxBeforePosition = int.MinValue
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 40481, 40825);
                    foreach (ParameterMetadata beforeParameter in f_1067_40527_40550_I(f_1067_40527_40550(beforeParameters)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 40481, 40825);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 40584, 40810);
                            foreach (ParameterSetMetadata beforeParameterSet in f_1067_40636_40672_I(f_1067_40636_40672(f_1067_40636_40665(beforeParameter))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 40584, 40810);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 40714, 40791);

                                maxBeforePosition = f_1067_40734_40790(f_1067_40743_40770(beforeParameterSet), maxBeforePosition);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 40584, 40810);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 227);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 227);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 40481, 40825);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 345);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 345);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 40841, 40877);

                int
                minAfterPosition = int.MaxValue
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 40891, 41347);
                    foreach (ParameterMetadata afterParameter in f_1067_40936_40958_I(f_1067_40936_40958(afterParameters)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 40891, 41347);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 40992, 41332);
                            foreach (ParameterSetMetadata afterParameterSet in f_1067_41043_41078_I(f_1067_41043_41078(f_1067_41043_41071(afterParameter))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 40992, 41332);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 41120, 41313) || true) && (f_1067_41124_41150(afterParameterSet) != int.MinValue)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 41120, 41313);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 41216, 41290);

                                    minAfterPosition = f_1067_41235_41289(f_1067_41244_41270(afterParameterSet), minAfterPosition);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 41120, 41313);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 40992, 41332);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 341);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 341);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 40891, 41347);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 457);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 457);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 41363, 42012) || true) && ((maxBeforePosition >= 0) && (DynAbs.Tracing.TraceSender.Expression_True(1067, 41367, 41434) && (minAfterPosition <= maxBeforePosition)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 41363, 42012);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 41468, 41513);

                    int
                    delta = (1001 - minAfterPosition % 1000)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 41531, 41997);
                        foreach (ParameterMetadata afterParameter in f_1067_41576_41598_I(f_1067_41576_41598(afterParameters)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 41531, 41997);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 41640, 41978);
                                foreach (ParameterSetMetadata afterParameterSet in f_1067_41691_41726_I(f_1067_41691_41726(f_1067_41691_41719(afterParameter))))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 41640, 41978);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 41776, 41955) || true) && (f_1067_41780_41806(afterParameterSet) != int.MinValue)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 41776, 41955);
                                        checked
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 41890, 41926);

                                            afterParameterSet.Position += DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => delta, 1067, 41890, 41916);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 41776, 41955);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 41640, 41978);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 339);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 339);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 41531, 41997);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 467);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 467);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 41363, 42012);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1067, 40214, 42023);

                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>.ValueCollection
                f_1067_40527_40550(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 40527, 40550);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1067_40636_40665(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 40636, 40665);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>.ValueCollection
                f_1067_40636_40672(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 40636, 40672);
                    return return_v;
                }


                int
                f_1067_40743_40770(System.Management.Automation.ParameterSetMetadata
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 40743, 40770);
                    return return_v;
                }


                int
                f_1067_40734_40790(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 40734, 40790);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>.ValueCollection
                f_1067_40636_40672_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 40636, 40672);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>.ValueCollection
                f_1067_40527_40550_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 40527, 40550);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>.ValueCollection
                f_1067_40936_40958(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 40936, 40958);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1067_41043_41071(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 41043, 41071);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>.ValueCollection
                f_1067_41043_41078(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 41043, 41078);
                    return return_v;
                }


                int
                f_1067_41124_41150(System.Management.Automation.ParameterSetMetadata
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 41124, 41150);
                    return return_v;
                }


                int
                f_1067_41244_41270(System.Management.Automation.ParameterSetMetadata
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 41244, 41270);
                    return return_v;
                }


                int
                f_1067_41235_41289(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 41235, 41289);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>.ValueCollection
                f_1067_41043_41078_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 41043, 41078);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>.ValueCollection
                f_1067_40936_40958_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 40936, 40958);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>.ValueCollection
                f_1067_41576_41598(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 41576, 41598);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1067_41691_41719(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 41691, 41719);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>.ValueCollection
                f_1067_41691_41726(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 41691, 41726);
                    return return_v;
                }


                int
                f_1067_41780_41806(System.Management.Automation.ParameterSetMetadata
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 41780, 41806);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>.ValueCollection
                f_1067_41691_41726_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 41691, 41726);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>.ValueCollection
                f_1067_41576_41598_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 41576, 41598);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 40214, 42023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 40214, 42023);
            }
        }

        private const string
        StaticCommonParameterSetTemplate = "{1}"
        ;

        private const string
        StaticMethodParameterSetTemplate = "{0}"
        ;

        private const string
        InstanceCommonParameterSetTemplate = "{1}"
        ;

        private const string
        InstanceQueryParameterSetTemplate = "{0}"
        ;

        private const string
        InstanceMethodParameterSetTemplate = "{2}"
        ;

        private const string
        InputObjectQueryParameterSetName = "InputObject (cdxml)"
        ;

        private const string
        SingleQueryParameterSetName = "Query (cdxml)"
        ;

        private static void MultiplyParameterSets(
                    Dictionary<string, ParameterMetadata> parameters,
                    string parameterSetNameTemplate, // {0} is the original parameter set, other ones are taken from the otherParameterSets array
                    params IEnumerable<string>[] otherParameterSets)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1067, 42661, 44124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 42992, 43062);

                List<List<string>>
                combinations = f_1067_43026_43061(otherParameterSets)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 43078, 44113);
                    foreach (ParameterMetadata parameter in f_1067_43118_43135_I(f_1067_43118_43135(parameters)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 43078, 44113);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 43169, 43315);

                        List<KeyValuePair<string, ParameterSetMetadata>>
                        oldParameterSets = f_1067_43237_43314(f_1067_43290_43313(parameter))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 43335, 43367);

                        f_1067_43335_43366(f_1067_43335_43358(parameter));
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 43385, 44098);
                            foreach (KeyValuePair<string, ParameterSetMetadata> oldParameterSet in f_1067_43456_43472_I(oldParameterSets))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 43385, 44098);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 43514, 44079);
                                    foreach (List<string> combination in f_1067_43551_43563_I(combinations))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 43514, 44079);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 43613, 43682);

                                        string[]
                                        formattingArray = new string[f_1067_43651_43676(otherParameterSets) + 1]
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 43708, 43749);

                                        formattingArray[0] = oldParameterSet.Key;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 43775, 43814);

                                        f_1067_43775_43813(combination, formattingArray, 1);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 43840, 43956);

                                        string
                                        newParameterSetName = f_1067_43869_43955(f_1067_43883_43911(), parameterSetNameTemplate, formattingArray)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 43984, 44056);

                                        f_1067_43984_44055(f_1067_43984_44007(parameter), newParameterSetName, oldParameterSet.Value);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 43514, 44079);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 566);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 566);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 43385, 44098);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 714);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 714);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 43078, 44113);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 1036);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 1036);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1067, 42661, 44124);

                System.Collections.Generic.List<System.Collections.Generic.List<string>>
                f_1067_43026_43061(params System.Collections.Generic.IEnumerable<string>[]
                x)
                {
                    var return_v = GetCombinations(x);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 43026, 43061);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>.ValueCollection
                f_1067_43118_43135(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 43118, 43135);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1067_43290_43313(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 43290, 43313);
                    return return_v;
                }


                System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, System.Management.Automation.ParameterSetMetadata>>
                f_1067_43237_43314(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, System.Management.Automation.ParameterSetMetadata>>((System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Management.Automation.ParameterSetMetadata>>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 43237, 43314);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1067_43335_43358(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 43335, 43358);
                    return return_v;
                }


                int
                f_1067_43335_43366(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 43335, 43366);
                    return 0;
                }


                int
                f_1067_43651_43676(System.Collections.Generic.IEnumerable<string>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 43651, 43676);
                    return return_v;
                }


                int
                f_1067_43775_43813(System.Collections.Generic.List<string>
                this_param, string[]
                array, int
                arrayIndex)
                {
                    this_param.CopyTo(array, arrayIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 43775, 43813);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1067_43883_43911()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 43883, 43911);
                    return return_v;
                }


                string
                f_1067_43869_43955(System.Globalization.CultureInfo
                provider, string
                format, params string[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object?[])args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 43869, 43955);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1067_43984_44007(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 43984, 44007);
                    return return_v;
                }


                int
                f_1067_43984_44055(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param, string
                key, System.Management.Automation.ParameterSetMetadata
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 43984, 44055);
                    return 0;
                }


                System.Collections.Generic.List<System.Collections.Generic.List<string>>
                f_1067_43551_43563_I(System.Collections.Generic.List<System.Collections.Generic.List<string>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 43551, 43563);
                    return return_v;
                }


                System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, System.Management.Automation.ParameterSetMetadata>>
                f_1067_43456_43472_I(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, System.Management.Automation.ParameterSetMetadata>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 43456, 43472);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>.ValueCollection
                f_1067_43118_43135_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 43118, 43135);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 42661, 44124);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 42661, 44124);
            }
        }

        private static IEnumerable<string> MultiplyParameterSets(
                    string mainParameterSet,
                    string parameterSetNameTemplate, // {0} is the original parameter set, other ones are taken from the otherParameterSets array
                    params IEnumerable<string>[] otherParameterSets)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1067, 44136, 45103);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 44457, 44498);

                List<string>
                result = f_1067_44479_44497()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 44514, 44584);

                List<List<string>>
                combinations = f_1067_44548_44583(otherParameterSets)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 44598, 45062);
                    foreach (List<string> combination in f_1067_44635_44647_I(combinations))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 44598, 45062);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 44681, 44750);

                        string[]
                        formattingArray = new string[f_1067_44719_44744(otherParameterSets) + 1]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 44768, 44806);

                        formattingArray[0] = mainParameterSet;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 44824, 44863);

                        f_1067_44824_44862(combination, formattingArray, 1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 44881, 44997);

                        string
                        newParameterSetName = f_1067_44910_44996(f_1067_44924_44952(), parameterSetNameTemplate, formattingArray)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 45015, 45047);

                        f_1067_45015_45046(result, newParameterSetName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 44598, 45062);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 465);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 465);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 45078, 45092);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1067, 44136, 45103);

                System.Collections.Generic.List<string>
                f_1067_44479_44497()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 44479, 44497);
                    return return_v;
                }


                System.Collections.Generic.List<System.Collections.Generic.List<string>>
                f_1067_44548_44583(params System.Collections.Generic.IEnumerable<string>[]
                x)
                {
                    var return_v = GetCombinations(x);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 44548, 44583);
                    return return_v;
                }


                int
                f_1067_44719_44744(System.Collections.Generic.IEnumerable<string>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 44719, 44744);
                    return return_v;
                }


                int
                f_1067_44824_44862(System.Collections.Generic.List<string>
                this_param, string[]
                array, int
                arrayIndex)
                {
                    this_param.CopyTo(array, arrayIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 44824, 44862);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1067_44924_44952()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 44924, 44952);
                    return return_v;
                }


                string
                f_1067_44910_44996(System.Globalization.CultureInfo
                provider, string
                format, params string[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object?[])args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 44910, 44996);
                    return return_v;
                }


                int
                f_1067_45015_45046(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 45015, 45046);
                    return 0;
                }


                System.Collections.Generic.List<System.Collections.Generic.List<string>>
                f_1067_44635_44647_I(System.Collections.Generic.List<System.Collections.Generic.List<string>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 44635, 44647);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 44136, 45103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 44136, 45103);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static MethodParameterBindings GetMethodParameterKind(InstanceMethodParameterMetadata methodParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1067, 45115, 45979);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 45250, 45334);

                f_1067_45250_45333(methodParameter != null, "Caller should verify methodParameter != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 45350, 45387);

                MethodParameterBindings
                bindings = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 45401, 45540) || true) && (f_1067_45405_45444(methodParameter) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 45401, 45540);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 45486, 45525);

                    bindings |= MethodParameterBindings.In;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 45401, 45540);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 45556, 45936) || true) && (f_1067_45560_45596(methodParameter) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 45556, 45936);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 45638, 45921) || true) && (f_1067_45642_45688(f_1067_45642_45678(methodParameter)) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 45638, 45921);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 45738, 45778);

                        bindings |= MethodParameterBindings.Out;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 45638, 45921);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 45638, 45921);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 45860, 45902);

                        bindings |= MethodParameterBindings.Error;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 45638, 45921);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 45556, 45936);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 45952, 45968);

                return bindings;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1067, 45115, 45979);

                int
                f_1067_45250_45333(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 45250, 45333);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForInstanceMethodParameter
                f_1067_45405_45444(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.CmdletParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 45405, 45444);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletOutputMetadata
                f_1067_45560_45596(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.CmdletOutputMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 45560, 45596);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletOutputMetadata
                f_1067_45642_45678(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.CmdletOutputMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 45642, 45678);
                    return return_v;
                }


                object
                f_1067_45642_45688(Microsoft.PowerShell.Cmdletization.Xml.CmdletOutputMetadata
                this_param)
                {
                    var return_v = this_param.ErrorCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 45642, 45688);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 45115, 45979);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 45115, 45979);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static MethodParameterBindings GetMethodParameterKind(StaticMethodParameterMetadata methodParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1067, 45991, 46853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 46124, 46208);

                f_1067_46124_46207(methodParameter != null, "Caller should verify methodParameter != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 46224, 46261);

                MethodParameterBindings
                bindings = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 46275, 46414) || true) && (f_1067_46279_46318(methodParameter) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 46275, 46414);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 46360, 46399);

                    bindings |= MethodParameterBindings.In;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 46275, 46414);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 46430, 46810) || true) && (f_1067_46434_46470(methodParameter) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 46430, 46810);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 46512, 46795) || true) && (f_1067_46516_46562(f_1067_46516_46552(methodParameter)) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 46512, 46795);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 46612, 46652);

                        bindings |= MethodParameterBindings.Out;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 46512, 46795);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 46512, 46795);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 46734, 46776);

                        bindings |= MethodParameterBindings.Error;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 46512, 46795);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 46430, 46810);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 46826, 46842);

                return bindings;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1067, 45991, 46853);

                int
                f_1067_46124_46207(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 46124, 46207);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForStaticMethodParameter
                f_1067_46279_46318(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.CmdletParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 46279, 46318);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletOutputMetadata
                f_1067_46434_46470(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.CmdletOutputMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 46434, 46470);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletOutputMetadata
                f_1067_46516_46552(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.CmdletOutputMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 46516, 46552);
                    return return_v;
                }


                object
                f_1067_46516_46562(Microsoft.PowerShell.Cmdletization.Xml.CmdletOutputMetadata
                this_param)
                {
                    var return_v = this_param.ErrorCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 46516, 46562);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 45991, 46853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 45991, 46853);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static MethodParameterBindings GetMethodParameterKind(CommonMethodMetadataReturnValue returnValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1067, 46865, 47554);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 46996, 47072);

                f_1067_46996_47071(returnValue != null, "Caller should verify returnValue != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 47088, 47125);

                MethodParameterBindings
                bindings = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 47139, 47511) || true) && (f_1067_47143_47175(returnValue) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 47139, 47511);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 47217, 47496) || true) && (f_1067_47221_47263(f_1067_47221_47253(returnValue)) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 47217, 47496);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 47313, 47353);

                        bindings |= MethodParameterBindings.Out;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 47217, 47496);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 47217, 47496);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 47435, 47477);

                        bindings |= MethodParameterBindings.Error;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 47217, 47496);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 47139, 47511);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 47527, 47543);

                return bindings;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1067, 46865, 47554);

                int
                f_1067_46996_47071(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 46996, 47071);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletOutputMetadata
                f_1067_47143_47175(Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                this_param)
                {
                    var return_v = this_param.CmdletOutputMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 47143, 47175);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletOutputMetadata
                f_1067_47221_47253(Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                this_param)
                {
                    var return_v = this_param.CmdletOutputMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 47221, 47253);
                    return return_v;
                }


                object
                f_1067_47221_47263(Microsoft.PowerShell.Cmdletization.Xml.CmdletOutputMetadata
                this_param)
                {
                    var return_v = this_param.ErrorCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 47221, 47263);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 46865, 47554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 46865, 47554);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void GenerateSingleMethodParameterProcessing(
                    TextWriter output,
                    string prefix,
                    string cmdletParameterName,
                    Type cmdletParameterType,
                    string etsParameterTypeName,
                    string cmdletParameterDefaultValue,
                    string methodParameterName,
                    MethodParameterBindings methodParameterBindings)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1067, 47566, 52008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 47985, 48051);

                f_1067_47985_48050(output != null, "Called should verify output != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 48065, 48131);

                f_1067_48065_48130(prefix != null, "Called should verify output != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 48214, 48296);

                string
                cmdletParameterTypeName = f_1067_48247_48295((cmdletParameterType ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Type>(1067, 48248, 48285) ?? typeof(object))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 48310, 48402);

                f_1067_48310_48401(methodParameterName != null, "Caller should verify methodParameterName != null");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 48418, 49368) || true) && (cmdletParameterDefaultValue != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 48418, 49368);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 48491, 48872);

                    f_1067_48491_48871(output, "{0}[object]$__cmdletization_defaultValue = [System.Management.Automation.LanguagePrimitives]::ConvertTo('{1}', '{2}')", prefix, f_1067_48701_48776(cmdletParameterDefaultValue), f_1067_48799_48870(cmdletParameterTypeName));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 48890, 49019);

                    f_1067_48890_49018(output, "{0}[object]$__cmdletization_defaultValueIsPresent = $true", prefix);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 48418, 49368);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 48418, 49368);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 49085, 49205);

                    f_1067_49085_49204(output, "{0}[object]$__cmdletization_defaultValue = $null", prefix);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 49223, 49353);

                    f_1067_49223_49352(output, "{0}[object]$__cmdletization_defaultValueIsPresent = $false", prefix);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 48418, 49368);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 49384, 50719) || true) && (MethodParameterBindings.In == (methodParameterBindings & MethodParameterBindings.In))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 49384, 50719);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 49506, 49616);

                    f_1067_49506_49615(cmdletParameterName != null, "Called should verify cmdletParameterName!=null for 'in' parameters");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 49636, 49846);

                    f_1067_49636_49845(
                                    output, "{0}if ($PSBoundParameters.ContainsKey('{1}')) {{", prefix, f_1067_49777_49844(cmdletParameterName));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 49864, 50059);

                    f_1067_49864_50058(output, "{0}  [object]$__cmdletization_value = ${{{1}}}", prefix, f_1067_50003_50057(cmdletParameterName));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 50077, 50644);

                    f_1067_50077_50643(output, "{0}  $__cmdletization_methodParameter = [Microsoft.PowerShell.Cmdletization.MethodParameter]@{{Name = '{1}'; ParameterType = '{2}'; Bindings = '{3}'; Value = $__cmdletization_value; IsValuePresent = $true}}", prefix, f_1067_50376_50443(methodParameterName), f_1067_50466_50537(cmdletParameterTypeName), f_1067_50560_50642(f_1067_50607_50641(methodParameterBindings)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 50662, 50704);

                    f_1067_50662_50703(output, "{0}}} else {{", prefix);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 49384, 50719);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 50735, 51322);

                f_1067_50735_51321(
                            output, "{0}  $__cmdletization_methodParameter = [Microsoft.PowerShell.Cmdletization.MethodParameter]@{{Name = '{1}'; ParameterType = '{2}'; Bindings = '{3}'; Value = $__cmdletization_defaultValue; IsValuePresent = $__cmdletization_defaultValueIsPresent}}", prefix, f_1067_51062_51129(methodParameterName), f_1067_51148_51219(cmdletParameterTypeName), f_1067_51238_51320(f_1067_51285_51319(methodParameterBindings)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 51338, 51509) || true) && (MethodParameterBindings.In == (methodParameterBindings & MethodParameterBindings.In))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 51338, 51509);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 51460, 51494);

                    f_1067_51460_51493(output, "{0}}}", prefix);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 51338, 51509);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 51525, 51845) || true) && (!f_1067_51530_51572(etsParameterTypeName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 51525, 51845);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 51606, 51830);

                    f_1067_51606_51829(output, "{0}$__cmdletization_methodParameter.ParameterTypeName = '{1}'", prefix, f_1067_51760_51828(etsParameterTypeName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 51525, 51845);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 51861, 51964);

                f_1067_51861_51963(
                            output, "{0}$__cmdletization_methodParameters.Add($__cmdletization_methodParameter)", prefix);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 51978, 51997);

                f_1067_51978_51996(output);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1067, 47566, 52008);

                int
                f_1067_47985_48050(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 47985, 48050);
                    return 0;
                }


                int
                f_1067_48065_48130(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 48065, 48130);
                    return 0;
                }


                string
                f_1067_48247_48295(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 48247, 48295);
                    return return_v;
                }


                int
                f_1067_48310_48401(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 48310, 48401);
                    return 0;
                }


                string
                f_1067_48701_48776(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 48701, 48776);
                    return return_v;
                }


                string
                f_1067_48799_48870(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 48799, 48870);
                    return return_v;
                }


                int
                f_1067_48491_48871(System.IO.TextWriter
                this_param, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 48491, 48871);
                    return 0;
                }


                int
                f_1067_48890_49018(System.IO.TextWriter
                this_param, string
                format, string
                arg0)
                {
                    this_param.WriteLine(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 48890, 49018);
                    return 0;
                }


                int
                f_1067_49085_49204(System.IO.TextWriter
                this_param, string
                format, string
                arg0)
                {
                    this_param.WriteLine(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 49085, 49204);
                    return 0;
                }


                int
                f_1067_49223_49352(System.IO.TextWriter
                this_param, string
                format, string
                arg0)
                {
                    this_param.WriteLine(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 49223, 49352);
                    return 0;
                }


                int
                f_1067_49506_49615(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 49506, 49615);
                    return 0;
                }


                string
                f_1067_49777_49844(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 49777, 49844);
                    return return_v;
                }


                int
                f_1067_49636_49845(System.IO.TextWriter
                this_param, string
                format, string
                arg0, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 49636, 49845);
                    return 0;
                }


                string
                f_1067_50003_50057(string
                value)
                {
                    var return_v = CodeGeneration.EscapeVariableName(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 50003, 50057);
                    return return_v;
                }


                int
                f_1067_49864_50058(System.IO.TextWriter
                this_param, string
                format, string
                arg0, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 49864, 50058);
                    return 0;
                }


                string
                f_1067_50376_50443(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 50376, 50443);
                    return return_v;
                }


                string
                f_1067_50466_50537(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 50466, 50537);
                    return return_v;
                }


                string
                f_1067_50607_50641(Microsoft.PowerShell.Cmdletization.MethodParameterBindings
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 50607, 50641);
                    return return_v;
                }


                string
                f_1067_50560_50642(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 50560, 50642);
                    return return_v;
                }


                int
                f_1067_50077_50643(System.IO.TextWriter
                this_param, string
                format, params object?[]
                arg)
                {
                    this_param.WriteLine(format, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 50077, 50643);
                    return 0;
                }


                int
                f_1067_50662_50703(System.IO.TextWriter
                this_param, string
                format, string
                arg0)
                {
                    this_param.WriteLine(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 50662, 50703);
                    return 0;
                }


                string
                f_1067_51062_51129(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 51062, 51129);
                    return return_v;
                }


                string
                f_1067_51148_51219(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 51148, 51219);
                    return return_v;
                }


                string
                f_1067_51285_51319(Microsoft.PowerShell.Cmdletization.MethodParameterBindings
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 51285, 51319);
                    return return_v;
                }


                string
                f_1067_51238_51320(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 51238, 51320);
                    return return_v;
                }


                int
                f_1067_50735_51321(System.IO.TextWriter
                this_param, string
                format, params object?[]
                arg)
                {
                    this_param.WriteLine(format, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 50735, 51321);
                    return 0;
                }


                int
                f_1067_51460_51493(System.IO.TextWriter
                this_param, string
                format, string
                arg0)
                {
                    this_param.WriteLine(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 51460, 51493);
                    return 0;
                }


                bool
                f_1067_51530_51572(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 51530, 51572);
                    return return_v;
                }


                string
                f_1067_51760_51828(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 51760, 51828);
                    return return_v;
                }


                int
                f_1067_51606_51829(System.IO.TextWriter
                this_param, string
                format, string
                arg0, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 51606, 51829);
                    return 0;
                }


                int
                f_1067_51861_51963(System.IO.TextWriter
                this_param, string
                format, string
                arg0)
                {
                    this_param.WriteLine(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 51861, 51963);
                    return 0;
                }


                int
                f_1067_51978_51996(System.IO.TextWriter
                this_param)
                {
                    this_param.WriteLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 51978, 51996);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 47566, 52008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 47566, 52008);
            }
        }

        private void GenerateMethodParametersProcessing(
                    StaticCmdletMetadata staticCmdlet,
                    IEnumerable<string> commonParameterSets,
                    out string scriptCode,
                    out Dictionary<string, ParameterMetadata> methodParameters,
                    out string outputTypeAttributeDeclaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 52020, 60647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 52360, 52455);

                methodParameters = f_1067_52379_52454(f_1067_52421_52453());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 52469, 52543);

                StringBuilder
                outputTypeAttributeDeclarationBuilder = f_1067_52523_52542()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 52557, 52626);

                StringWriter
                output = f_1067_52579_52625(f_1067_52596_52624())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 52642, 52797);

                f_1067_52642_52796(
                            output, "      $__cmdletization_methodParameters = [System.Collections.Generic.List[Microsoft.PowerShell.Cmdletization.MethodParameter]]::new()");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 52811, 52830);

                f_1067_52811_52829(output);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 52846, 52900);

                bool
                multipleMethods = f_1067_52869_52895(f_1067_52869_52888(staticCmdlet)) > 1
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 52914, 53054) || true) && (multipleMethods)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 52914, 53054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 52967, 53039);

                    f_1067_52967_53038(output, "      switch -exact ($PSCmdlet.ParameterSetName) { ");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 52914, 53054);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 53070, 60383);
                    foreach (StaticMethodMetadata method in f_1067_53110_53129_I(f_1067_53110_53129(staticCmdlet)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 53070, 60383);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 53163, 53923) || true) && (multipleMethods)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 53163, 53923);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 53224, 53253);

                            f_1067_53224_53252(output, "        { @(");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 53275, 53305);

                            bool
                            firstParameterSet = true
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 53327, 53841);
                                foreach (string parameterSetName in f_1067_53418_53559_I(f_1067_53418_53559(f_1067_53474_53503(this, method), StaticMethodParameterSetTemplate, commonParameterSets)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 53327, 53841);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 53609, 53652) || true) && (!firstParameterSet)
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 53609, 53652);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 53633, 53652);

                                        f_1067_53633_53651(output, ", ");
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 53609, 53652);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 53678, 53704);

                                    firstParameterSet = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 53730, 53818);

                                    f_1067_53730_53817(output, "'{0}'", f_1067_53752_53816(parameterSetName));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 53327, 53841);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 515);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 515);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 53865, 53904);

                            f_1067_53865_53903(
                                                output, ") -contains $_ } {");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 53163, 53923);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 53943, 53994);

                        List<Type>
                        typesOfOutParameters = f_1067_53977_53993()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 54012, 54070);

                        List<string>
                        etsTypesOfOutParameters = f_1067_54051_54069()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 54088, 57363) || true) && (f_1067_54092_54109(method) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 54088, 57363);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 54159, 57344);
                                foreach (StaticMethodParameterMetadata methodParameter in f_1067_54217_54234_I(f_1067_54217_54234(method)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 54159, 57344);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 54284, 54318);

                                    string
                                    cmdletParameterName = null
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 54344, 56294) || true) && (f_1067_54348_54387(methodParameter) != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 54344, 56294);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 54453, 54509);

                                        string
                                        parameterSetName = f_1067_54479_54508(this, method)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 54539, 54835);

                                        ParameterMetadata
                                        parameterMetadata = f_1067_54577_54834(this, parameterSetName, f_1067_54675_54704(methodParameter), f_1067_54739_54759(methodParameter), f_1067_54794_54833(methodParameter))
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 54865, 54910);

                                        cmdletParameterName = f_1067_54887_54909(parameterMetadata);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 54942, 54981);

                                        ParameterMetadata
                                        oldParameterMetadata
                                        = default(ParameterMetadata);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 55011, 56267) || true) && (f_1067_55015_55093(methodParameters, f_1067_55044_55066(parameterMetadata), out oldParameterMetadata))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 55011, 56267);
                                            try
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 55235, 55343);

                                                f_1067_55235_55342(f_1067_55235_55269(oldParameterMetadata), parameterSetName, f_1067_55292_55341(f_1067_55292_55323(parameterMetadata), parameterSetName));
                                            }
                                            catch (ArgumentException e)
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1067, 55412, 56042);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 55512, 55934);

                                                string
                                                message = f_1067_55529_55933(f_1067_55585_55613(), f_1067_55718_55785(), "<StaticCmdlets>...<Cmdlet>...<Method>", f_1067_55910_55932(parameterMetadata))
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 55972, 56007);

                                                throw f_1067_55978_56006(message, e);
                                                DynAbs.Tracing.TraceSender.TraceExitCatch(1067, 55412, 56042);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 55011, 56267);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 55011, 56267);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 56172, 56236);

                                            f_1067_56172_56235(methodParameters, f_1067_56193_56215(parameterMetadata), parameterMetadata);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 55011, 56267);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 54344, 56294);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 56322, 56412);

                                    MethodParameterBindings
                                    methodParameterBindings = f_1067_56372_56411(methodParameter)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 56438, 56503);

                                    Type
                                    dotNetTypeOfParameter = f_1067_56467_56502(this, f_1067_56481_56501(methodParameter))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 56529, 56982);

                                    f_1067_56529_56981(output, "        ", cmdletParameterName, dotNetTypeOfParameter, f_1067_56779_56807(f_1067_56779_56799(methodParameter)), f_1067_56838_56866(methodParameter), f_1067_56897_56926(methodParameter), methodParameterBindings);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 57010, 57321) || true) && (MethodParameterBindings.Out == (methodParameterBindings & MethodParameterBindings.Out))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 57010, 57321);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 57158, 57206);

                                        f_1067_57158_57205(typesOfOutParameters, dotNetTypeOfParameter);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 57236, 57294);

                                        f_1067_57236_57293(etsTypesOfOutParameters, f_1067_57264_57292(f_1067_57264_57284(methodParameter)));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 57010, 57321);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 54159, 57344);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 3186);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 3186);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 54088, 57363);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 57383, 58984) || true) && (f_1067_57387_57405(method) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 57383, 58984);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 57455, 57548);

                            MethodParameterBindings
                            methodParameterBindings = f_1067_57505_57547(f_1067_57528_57546(method))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 57570, 57638);

                            Type
                            dotNetTypeOfParameter = f_1067_57599_57637(this, f_1067_57613_57636(f_1067_57613_57631(method)))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 57660, 58118);

                            f_1067_57660_58117(output, "      $__cmdletization_returnValue = [Microsoft.PowerShell.Cmdletization.MethodParameter]@{{ Name = 'ReturnValue'; ParameterType = '{0}'; Bindings = '{1}'; Value = $null; IsValuePresent = $false }}", f_1067_57929_58007(f_1067_57976_58006(dotNetTypeOfParameter)), f_1067_58034_58116(f_1067_58081_58115(methodParameterBindings)));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 58142, 58498) || true) && (!f_1067_58147_58200(f_1067_58168_58199(f_1067_58168_58191(f_1067_58168_58186(method)))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 58142, 58498);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 58250, 58475);

                                f_1067_58250_58474(output, "      $__cmdletization_methodParameter.ParameterTypeName = '{0}'", f_1067_58394_58473(f_1067_58441_58472(f_1067_58441_58464(f_1067_58441_58459(method)))));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 58142, 58498);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 58522, 58820) || true) && (MethodParameterBindings.Out == (methodParameterBindings & MethodParameterBindings.Out))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 58522, 58820);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 58662, 58710);

                                f_1067_58662_58709(typesOfOutParameters, dotNetTypeOfParameter);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 58736, 58797);

                                f_1067_58736_58796(etsTypesOfOutParameters, f_1067_58764_58795(f_1067_58764_58787(f_1067_58764_58782(method))));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 58522, 58820);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 57383, 58984);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 57383, 58984);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 58902, 58965);

                            f_1067_58902_58964(output, "      $__cmdletization_returnValue = $null");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 57383, 58984);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 59004, 59315);

                        f_1067_59004_59314(
                                        output, "      $__cmdletization_methodInvocationInfo = [Microsoft.PowerShell.Cmdletization.MethodInvocationInfo]::new('{0}', $__cmdletization_methodParameters, $__cmdletization_returnValue)", f_1067_59248_59313(f_1067_59295_59312(method)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 59333, 59448);

                        f_1067_59333_59447(output, "      $__cmdletization_objectModelWrapper.ProcessRecord($__cmdletization_methodInvocationInfo)");

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 59468, 59578) || true) && (multipleMethods)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 59468, 59578);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 59529, 59559);

                            f_1067_59529_59558(output, "        }");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 59468, 59578);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 59598, 60368) || true) && (f_1067_59602_59628(typesOfOutParameters) == 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 59598, 60368);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 59675, 59889);

                            f_1067_59675_59888(outputTypeAttributeDeclarationBuilder, f_1067_59752_59780(), "[OutputType([{0}])]", f_1067_59855_59887(f_1067_59855_59878(typesOfOutParameters, 0)));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 59913, 60349) || true) && ((f_1067_59918_59947(etsTypesOfOutParameters) == 1) && (DynAbs.Tracing.TraceSender.Expression_True(1067, 59917, 60008) && (!f_1067_59959_60007(f_1067_59980_60006(etsTypesOfOutParameters, 0)))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 59913, 60349);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 60058, 60326);

                                f_1067_60058_60325(outputTypeAttributeDeclarationBuilder, f_1067_60139_60167(), "[OutputType('{0}')]", f_1067_60250_60324(f_1067_60297_60323(etsTypesOfOutParameters, 0)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 59913, 60349);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 59598, 60368);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 53070, 60383);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 7314);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 7314);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 60399, 60493) || true) && (multipleMethods)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 60399, 60493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 60452, 60478);

                    f_1067_60452_60477(output, "    }");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 60399, 60493);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 60509, 60540);

                scriptCode = f_1067_60522_60539(output);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 60554, 60636);

                outputTypeAttributeDeclaration = f_1067_60587_60635(outputTypeAttributeDeclarationBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 52020, 60647);

                System.StringComparer
                f_1067_52421_52453()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 52421, 52453);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                f_1067_52379_52454(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 52379, 52454);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1067_52523_52542()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 52523, 52542);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_52596_52624()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 52596, 52624);
                    return return_v;
                }


                System.IO.StringWriter
                f_1067_52579_52625(System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = new System.IO.StringWriter((System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 52579, 52625);
                    return return_v;
                }


                int
                f_1067_52642_52796(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 52642, 52796);
                    return 0;
                }


                int
                f_1067_52811_52829(System.IO.StringWriter
                this_param)
                {
                    this_param.WriteLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 52811, 52829);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.StaticMethodMetadata[]
                f_1067_52869_52888(Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadata
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 52869, 52888);
                    return return_v;
                }


                int
                f_1067_52869_52895(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodMetadata[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 52869, 52895);
                    return return_v;
                }


                int
                f_1067_52967_53038(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 52967, 53038);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.StaticMethodMetadata[]
                f_1067_53110_53129(Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadata
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 53110, 53129);
                    return return_v;
                }


                int
                f_1067_53224_53252(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 53224, 53252);
                    return 0;
                }


                string
                f_1067_53474_53503(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.StaticMethodMetadata
                staticMethod)
                {
                    var return_v = this_param.GetMethodParameterSet(staticMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 53474, 53503);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1067_53418_53559(string
                mainParameterSet, string
                parameterSetNameTemplate, params System.Collections.Generic.IEnumerable<string>[]
                otherParameterSets)
                {
                    var return_v = MultiplyParameterSets(mainParameterSet, parameterSetNameTemplate, otherParameterSets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 53418, 53559);
                    return return_v;
                }


                int
                f_1067_53633_53651(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 53633, 53651);
                    return 0;
                }


                string
                f_1067_53752_53816(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 53752, 53816);
                    return return_v;
                }


                int
                f_1067_53730_53817(System.IO.StringWriter
                this_param, string
                format, string
                arg0)
                {
                    this_param.Write(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 53730, 53817);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1067_53418_53559_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 53418, 53559);
                    return return_v;
                }


                int
                f_1067_53865_53903(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 53865, 53903);
                    return 0;
                }


                System.Collections.Generic.List<System.Type>
                f_1067_53977_53993()
                {
                    var return_v = new System.Collections.Generic.List<System.Type>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 53977, 53993);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1067_54051_54069()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 54051, 54069);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.StaticMethodParameterMetadata[]
                f_1067_54092_54109(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodMetadata
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 54092, 54109);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.StaticMethodParameterMetadata[]
                f_1067_54217_54234(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodMetadata
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 54217, 54234);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForStaticMethodParameter
                f_1067_54348_54387(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.CmdletParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 54348, 54387);
                    return return_v;
                }


                string
                f_1067_54479_54508(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.StaticMethodMetadata
                staticMethod)
                {
                    var return_v = this_param.GetMethodParameterSet(staticMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 54479, 54508);
                    return return_v;
                }


                string
                f_1067_54675_54704(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 54675, 54704);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                f_1067_54739_54759(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 54739, 54759);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForStaticMethodParameter
                f_1067_54794_54833(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.CmdletParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 54794, 54833);
                    return return_v;
                }


                System.Management.Automation.ParameterMetadata
                f_1067_54577_54834(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, string
                parameterSetName, string
                objectModelParameterName, Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                parameterType, Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForStaticMethodParameter
                parameterCmdletization)
                {
                    var return_v = this_param.GetParameter(parameterSetName, objectModelParameterName, parameterType, parameterCmdletization);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 54577, 54834);
                    return return_v;
                }


                string
                f_1067_54887_54909(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 54887, 54909);
                    return return_v;
                }


                string
                f_1067_55044_55066(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 55044, 55066);
                    return return_v;
                }


                bool
                f_1067_55015_55093(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                this_param, string
                key, out System.Management.Automation.ParameterMetadata
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 55015, 55093);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1067_55235_55269(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 55235, 55269);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1067_55292_55323(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 55292, 55323);
                    return return_v;
                }


                System.Management.Automation.ParameterSetMetadata
                f_1067_55292_55341(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 55292, 55341);
                    return return_v;
                }


                int
                f_1067_55235_55342(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param, string
                key, System.Management.Automation.ParameterSetMetadata
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 55235, 55342);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1067_55585_55613()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 55585, 55613);
                    return return_v;
                }


                string
                f_1067_55718_55785()
                {
                    var return_v = CmdletizationCoreResources.ScriptWriter_DuplicateQueryParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 55718, 55785);
                    return return_v;
                }


                string
                f_1067_55910_55932(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 55910, 55932);
                    return return_v;
                }


                string
                f_1067_55529_55933(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 55529, 55933);
                    return return_v;
                }


                System.Xml.XmlException
                f_1067_55978_56006(string
                message, System.ArgumentException
                innerException)
                {
                    var return_v = new System.Xml.XmlException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 55978, 56006);
                    return return_v;
                }


                string
                f_1067_56193_56215(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 56193, 56215);
                    return return_v;
                }


                int
                f_1067_56172_56235(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                this_param, string
                key, System.Management.Automation.ParameterMetadata
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 56172, 56235);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.MethodParameterBindings
                f_1067_56372_56411(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodParameterMetadata
                methodParameter)
                {
                    var return_v = GetMethodParameterKind(methodParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 56372, 56411);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                f_1067_56481_56501(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 56481, 56501);
                    return return_v;
                }


                System.Type
                f_1067_56467_56502(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                typeMetadata)
                {
                    var return_v = this_param.GetDotNetType(typeMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 56467, 56502);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                f_1067_56779_56799(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 56779, 56799);
                    return return_v;
                }


                string
                f_1067_56779_56807(Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                this_param)
                {
                    var return_v = this_param.ETSType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 56779, 56807);
                    return return_v;
                }


                string
                f_1067_56838_56866(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.DefaultValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 56838, 56866);
                    return return_v;
                }


                string
                f_1067_56897_56926(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 56897, 56926);
                    return return_v;
                }


                int
                f_1067_56529_56981(System.IO.StringWriter
                output, string
                prefix, string
                cmdletParameterName, System.Type
                cmdletParameterType, string
                etsParameterTypeName, string
                cmdletParameterDefaultValue, string
                methodParameterName, Microsoft.PowerShell.Cmdletization.MethodParameterBindings
                methodParameterBindings)
                {
                    GenerateSingleMethodParameterProcessing((System.IO.TextWriter)output, prefix, cmdletParameterName, cmdletParameterType, etsParameterTypeName, cmdletParameterDefaultValue, methodParameterName, methodParameterBindings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 56529, 56981);
                    return 0;
                }


                int
                f_1067_57158_57205(System.Collections.Generic.List<System.Type>
                this_param, System.Type
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 57158, 57205);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                f_1067_57264_57284(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 57264, 57284);
                    return return_v;
                }


                string
                f_1067_57264_57292(Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                this_param)
                {
                    var return_v = this_param.ETSType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 57264, 57292);
                    return return_v;
                }


                int
                f_1067_57236_57293(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 57236, 57293);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.StaticMethodParameterMetadata[]
                f_1067_54217_54234_I(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodParameterMetadata[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 54217, 54234);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                f_1067_57387_57405(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodMetadata
                this_param)
                {
                    var return_v = this_param.ReturnValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 57387, 57405);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                f_1067_57528_57546(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodMetadata
                this_param)
                {
                    var return_v = this_param.ReturnValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 57528, 57546);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.MethodParameterBindings
                f_1067_57505_57547(Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                returnValue)
                {
                    var return_v = GetMethodParameterKind(returnValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 57505, 57547);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                f_1067_57613_57631(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodMetadata
                this_param)
                {
                    var return_v = this_param.ReturnValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 57613, 57631);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                f_1067_57613_57636(Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 57613, 57636);
                    return return_v;
                }


                System.Type
                f_1067_57599_57637(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                typeMetadata)
                {
                    var return_v = this_param.GetDotNetType(typeMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 57599, 57637);
                    return return_v;
                }


                string
                f_1067_57976_58006(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 57976, 58006);
                    return return_v;
                }


                string
                f_1067_57929_58007(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 57929, 58007);
                    return return_v;
                }


                string
                f_1067_58081_58115(Microsoft.PowerShell.Cmdletization.MethodParameterBindings
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 58081, 58115);
                    return return_v;
                }


                string
                f_1067_58034_58116(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 58034, 58116);
                    return return_v;
                }


                int
                f_1067_57660_58117(System.IO.StringWriter
                this_param, string
                format, string
                arg0, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 57660, 58117);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                f_1067_58168_58186(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodMetadata
                this_param)
                {
                    var return_v = this_param.ReturnValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 58168, 58186);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                f_1067_58168_58191(Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 58168, 58191);
                    return return_v;
                }


                string
                f_1067_58168_58199(Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                this_param)
                {
                    var return_v = this_param.ETSType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 58168, 58199);
                    return return_v;
                }


                bool
                f_1067_58147_58200(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 58147, 58200);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                f_1067_58441_58459(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodMetadata
                this_param)
                {
                    var return_v = this_param.ReturnValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 58441, 58459);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                f_1067_58441_58464(Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 58441, 58464);
                    return return_v;
                }


                string
                f_1067_58441_58472(Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                this_param)
                {
                    var return_v = this_param.ETSType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 58441, 58472);
                    return return_v;
                }


                string
                f_1067_58394_58473(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 58394, 58473);
                    return return_v;
                }


                int
                f_1067_58250_58474(System.IO.StringWriter
                this_param, string
                format, string
                arg0)
                {
                    this_param.WriteLine(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 58250, 58474);
                    return 0;
                }


                int
                f_1067_58662_58709(System.Collections.Generic.List<System.Type>
                this_param, System.Type
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 58662, 58709);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                f_1067_58764_58782(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodMetadata
                this_param)
                {
                    var return_v = this_param.ReturnValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 58764, 58782);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                f_1067_58764_58787(Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 58764, 58787);
                    return return_v;
                }


                string
                f_1067_58764_58795(Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                this_param)
                {
                    var return_v = this_param.ETSType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 58764, 58795);
                    return return_v;
                }


                int
                f_1067_58736_58796(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 58736, 58796);
                    return 0;
                }


                int
                f_1067_58902_58964(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 58902, 58964);
                    return 0;
                }


                string
                f_1067_59295_59312(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodMetadata
                this_param)
                {
                    var return_v = this_param.MethodName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 59295, 59312);
                    return return_v;
                }


                string
                f_1067_59248_59313(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 59248, 59313);
                    return return_v;
                }


                int
                f_1067_59004_59314(System.IO.StringWriter
                this_param, string
                format, string
                arg0)
                {
                    this_param.WriteLine(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 59004, 59314);
                    return 0;
                }


                int
                f_1067_59333_59447(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 59333, 59447);
                    return 0;
                }


                int
                f_1067_59529_59558(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 59529, 59558);
                    return 0;
                }


                int
                f_1067_59602_59628(System.Collections.Generic.List<System.Type>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 59602, 59628);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_59752_59780()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 59752, 59780);
                    return return_v;
                }


                System.Type
                f_1067_59855_59878(System.Collections.Generic.List<System.Type>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 59855, 59878);
                    return return_v;
                }


                string
                f_1067_59855_59887(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 59855, 59887);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1067_59675_59888(System.Text.StringBuilder
                this_param, System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 59675, 59888);
                    return return_v;
                }


                int
                f_1067_59918_59947(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 59918, 59947);
                    return return_v;
                }


                string
                f_1067_59980_60006(System.Collections.Generic.List<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 59980, 60006);
                    return return_v;
                }


                bool
                f_1067_59959_60007(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 59959, 60007);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_60139_60167()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 60139, 60167);
                    return return_v;
                }


                string
                f_1067_60297_60323(System.Collections.Generic.List<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 60297, 60323);
                    return return_v;
                }


                string
                f_1067_60250_60324(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 60250, 60324);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1067_60058_60325(System.Text.StringBuilder
                this_param, System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 60058, 60325);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.StaticMethodMetadata[]
                f_1067_53110_53129_I(Microsoft.PowerShell.Cmdletization.Xml.StaticMethodMetadata[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 53110, 53129);
                    return return_v;
                }


                int
                f_1067_60452_60477(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 60452, 60477);
                    return 0;
                }


                string
                f_1067_60522_60539(System.IO.StringWriter
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 60522, 60539);
                    return return_v;
                }


                string
                f_1067_60587_60635(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 60587, 60635);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 52020, 60647);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 52020, 60647);
            }
        }

        private void GenerateMethodParametersProcessing(
                    InstanceCmdletMetadata instanceCmdlet,
                    IEnumerable<string> commonParameterSets,
                    IEnumerable<string> queryParameterSets,
                    out string scriptCode,
                    out Dictionary<string, ParameterMetadata> methodParameters,
                    out string outputTypeAttributeDeclaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 60659, 68722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 61056, 61151);

                methodParameters = f_1067_61075_61150(f_1067_61117_61149());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 61165, 61211);

                outputTypeAttributeDeclaration = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 61225, 61294);

                StringWriter
                output = f_1067_61247_61293(f_1067_61264_61292())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 61310, 61463);

                f_1067_61310_61462(
                            output, "    $__cmdletization_methodParameters = [System.Collections.Generic.List[Microsoft.PowerShell.Cmdletization.MethodParameter]]::new()");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 61477, 61547);

                f_1067_61477_61546(output, "    switch -exact ($PSCmdlet.ParameterSetName) { ");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 61563, 61617);

                InstanceMethodMetadata
                method = f_1067_61595_61616(instanceCmdlet)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 61631, 61660);

                f_1067_61631_61659(output, "        { @(");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 61674, 61704);

                bool
                firstParameterSet = true
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 61718, 62125);
                    foreach (string parameterSetName in f_1067_61754_61883_I(f_1067_61754_61883(f_1067_61776_61805(this, method), InstanceMethodParameterSetTemplate, commonParameterSets, queryParameterSets)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 61718, 62125);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 61917, 61960) || true) && (!firstParameterSet)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 61917, 61960);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 61941, 61960);

                            f_1067_61941_61959(output, ", ");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 61917, 61960);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 61978, 62004);

                        firstParameterSet = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 62022, 62110);

                        f_1067_62022_62109(output, "'{0}'", f_1067_62044_62108(parameterSetName));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 61718, 62125);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 408);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 408);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 62141, 62180);

                f_1067_62141_62179(
                            output, ") -contains $_ } {");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 62196, 62247);

                List<Type>
                typesOfOutParameters = f_1067_62230_62246()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 62261, 62319);

                List<string>
                etsTypesOfOutParameters = f_1067_62300_62318()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 62333, 64820) || true) && (f_1067_62337_62354(method) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 62333, 64820);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 62396, 64805);
                        foreach (InstanceMethodParameterMetadata methodParameter in f_1067_62456_62473_I(f_1067_62456_62473(method)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 62396, 64805);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 62515, 62549);

                            string
                            cmdletParameterName = null
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 62571, 63821) || true) && (f_1067_62575_62614(methodParameter) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 62571, 63821);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 62672, 62965);

                                ParameterMetadata
                                parameterMetadata = f_1067_62710_62964(this, f_1067_62753_62782(this, method), f_1067_62813_62842(methodParameter), f_1067_62873_62893(methodParameter), f_1067_62924_62963(methodParameter))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 62991, 63036);

                                cmdletParameterName = f_1067_63013_63035(parameterMetadata);

                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 63124, 63188);

                                    f_1067_63124_63187(methodParameters, f_1067_63145_63167(parameterMetadata), parameterMetadata);
                                }
                                catch (ArgumentException e)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1067, 63241, 63798);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 63325, 63706);

                                    string
                                    message = f_1067_63342_63705(f_1067_63390_63418(), f_1067_63515_63582(), "<InstanceCmdlets>...<Cmdlet>", f_1067_63682_63704(parameterMetadata))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 63736, 63771);

                                    throw f_1067_63742_63770(message, e);
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1067, 63241, 63798);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 62571, 63821);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 63845, 63935);

                            MethodParameterBindings
                            methodParameterBindings = f_1067_63895_63934(methodParameter)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 63957, 64022);

                            Type
                            dotNetTypeOfParameter = f_1067_63986_64021(this, f_1067_64000_64020(methodParameter))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 64044, 64467);

                            f_1067_64044_64466(output, "          ", cmdletParameterName, dotNetTypeOfParameter, f_1067_64276_64304(f_1067_64276_64296(methodParameter)), f_1067_64331_64359(methodParameter), f_1067_64386_64415(methodParameter), methodParameterBindings);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 64491, 64786) || true) && (MethodParameterBindings.Out == (methodParameterBindings & MethodParameterBindings.Out))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 64491, 64786);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 64631, 64679);

                                f_1067_64631_64678(typesOfOutParameters, dotNetTypeOfParameter);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 64705, 64763);

                                f_1067_64705_64762(etsTypesOfOutParameters, f_1067_64733_64761(f_1067_64733_64753(methodParameter)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 64491, 64786);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 62396, 64805);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 2410);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 2410);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 62333, 64820);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 64836, 66345) || true) && (f_1067_64840_64858(method) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 64836, 66345);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 64900, 64993);

                    MethodParameterBindings
                    methodParameterBindings = f_1067_64950_64992(f_1067_64973_64991(method))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 65011, 65079);

                    Type
                    dotNetTypeOfParameter = f_1067_65040_65078(this, f_1067_65054_65077(f_1067_65054_65072(method)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 65097, 65543);

                    f_1067_65097_65542(output, "      $__cmdletization_returnValue = [Microsoft.PowerShell.Cmdletization.MethodParameter]@{{ Name = 'ReturnValue'; ParameterType = '{0}'; Bindings = '{1}'; Value = $null; IsValuePresent = $false }}", f_1067_65358_65436(f_1067_65405_65435(dotNetTypeOfParameter)), f_1067_65459_65541(f_1067_65506_65540(methodParameterBindings)));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 65563, 65899) || true) && (!f_1067_65568_65621(f_1067_65589_65620(f_1067_65589_65612(f_1067_65589_65607(method)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 65563, 65899);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 65663, 65880);

                        f_1067_65663_65879(output, "      $__cmdletization_methodParameter.ParameterTypeName = '{0}'", f_1067_65799_65878(f_1067_65846_65877(f_1067_65846_65869(f_1067_65846_65864(method)))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 65563, 65899);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 65919, 66201) || true) && (MethodParameterBindings.Out == (methodParameterBindings & MethodParameterBindings.Out))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 65919, 66201);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 66051, 66099);

                        f_1067_66051_66098(typesOfOutParameters, dotNetTypeOfParameter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 66121, 66182);

                        f_1067_66121_66181(etsTypesOfOutParameters, f_1067_66149_66180(f_1067_66149_66172(f_1067_66149_66167(method))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 65919, 66201);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 64836, 66345);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 64836, 66345);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 66267, 66330);

                    f_1067_66267_66329(output, "      $__cmdletization_returnValue = $null");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 64836, 66345);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 66361, 66664);

                f_1067_66361_66663(
                            output, "      $__cmdletization_methodInvocationInfo = [Microsoft.PowerShell.Cmdletization.MethodInvocationInfo]::new('{0}', $__cmdletization_methodParameters, $__cmdletization_returnValue)", f_1067_66597_66662(f_1067_66644_66661(method)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 66680, 67047) || true) && (f_1067_66684_66710(typesOfOutParameters) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 66680, 67047);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 66749, 66883);

                    f_1067_66749_66882(output, "      $__cmdletization_passThru = $PSBoundParameters.ContainsKey('PassThru') -and $PassThru");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 66680, 67047);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 66680, 67047);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 66949, 67032);

                    f_1067_66949_67031(output, "      $__cmdletization_passThru = $false");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 66680, 67047);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 67063, 67148);

                f_1067_67063_67147(
                            output, "            if ($PSBoundParameters.ContainsKey('InputObject')) {");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 67162, 67351);

                f_1067_67162_67350(output, "                foreach ($x in $InputObject) { $__cmdletization_objectModelWrapper.ProcessRecord($x, $__cmdletization_methodInvocationInfo, $__cmdletization_PassThru) }");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 67365, 67406);

                f_1067_67365_67405(output, "            } else {");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 67420, 67603);

                f_1067_67420_67602(output, "                $__cmdletization_objectModelWrapper.ProcessRecord($__cmdletization_queryBuilder, $__cmdletization_methodInvocationInfo, $__cmdletization_PassThru)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 67617, 67651);

                f_1067_67617_67650(output, "            }");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 67665, 67695);

                f_1067_67665_67694(output, "        }");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 67709, 67735);

                f_1067_67709_67734(output, "    }");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 67751, 67782);

                scriptCode = f_1067_67764_67781(output);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 67798, 68711) || true) && (f_1067_67802_67828(typesOfOutParameters) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 67798, 68711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 67902, 67968);

                    outputTypeAttributeDeclaration = f_1067_67935_67967(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 67798, 68711);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 67798, 68711);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 68002, 68711) || true) && (f_1067_68006_68032(typesOfOutParameters) == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 68002, 68711);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 68071, 68269);

                        outputTypeAttributeDeclaration = f_1067_68104_68268(f_1067_68140_68168(), "[OutputType([{0}])]", f_1067_68235_68267(f_1067_68235_68258(typesOfOutParameters, 0)));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 68287, 68696) || true) && ((f_1067_68292_68321(etsTypesOfOutParameters) == 1) && (DynAbs.Tracing.TraceSender.Expression_True(1067, 68291, 68382) && (!f_1067_68333_68381(f_1067_68354_68380(etsTypesOfOutParameters, 0)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 68287, 68696);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 68424, 68677);

                            outputTypeAttributeDeclaration += f_1067_68458_68676(f_1067_68498_68526(), "[OutputType('{0}')]", f_1067_68601_68675(f_1067_68648_68674(etsTypesOfOutParameters, 0)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 68287, 68696);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 68002, 68711);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 67798, 68711);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 60659, 68722);

                System.StringComparer
                f_1067_61117_61149()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 61117, 61149);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                f_1067_61075_61150(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 61075, 61150);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_61264_61292()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 61264, 61292);
                    return return_v;
                }


                System.IO.StringWriter
                f_1067_61247_61293(System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = new System.IO.StringWriter((System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 61247, 61293);
                    return return_v;
                }


                int
                f_1067_61310_61462(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 61310, 61462);
                    return 0;
                }


                int
                f_1067_61477_61546(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 61477, 61546);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodMetadata
                f_1067_61595_61616(Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 61595, 61616);
                    return return_v;
                }


                int
                f_1067_61631_61659(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 61631, 61659);
                    return 0;
                }


                string
                f_1067_61776_61805(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodMetadata
                methodMetadata)
                {
                    var return_v = this_param.GetMethodParameterSet((Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadata)methodMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 61776, 61805);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1067_61754_61883(string
                mainParameterSet, string
                parameterSetNameTemplate, params System.Collections.Generic.IEnumerable<string>[]
                otherParameterSets)
                {
                    var return_v = MultiplyParameterSets(mainParameterSet, parameterSetNameTemplate, otherParameterSets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 61754, 61883);
                    return return_v;
                }


                int
                f_1067_61941_61959(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 61941, 61959);
                    return 0;
                }


                string
                f_1067_62044_62108(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 62044, 62108);
                    return return_v;
                }


                int
                f_1067_62022_62109(System.IO.StringWriter
                this_param, string
                format, string
                arg0)
                {
                    this_param.Write(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 62022, 62109);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1067_61754_61883_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 61754, 61883);
                    return return_v;
                }


                int
                f_1067_62141_62179(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 62141, 62179);
                    return 0;
                }


                System.Collections.Generic.List<System.Type>
                f_1067_62230_62246()
                {
                    var return_v = new System.Collections.Generic.List<System.Type>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 62230, 62246);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1067_62300_62318()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 62300, 62318);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodParameterMetadata[]
                f_1067_62337_62354(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodMetadata
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 62337, 62354);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodParameterMetadata[]
                f_1067_62456_62473(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodMetadata
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 62456, 62473);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForInstanceMethodParameter
                f_1067_62575_62614(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.CmdletParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 62575, 62614);
                    return return_v;
                }


                string
                f_1067_62753_62782(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodMetadata
                methodMetadata)
                {
                    var return_v = this_param.GetMethodParameterSet((Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadata)methodMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 62753, 62782);
                    return return_v;
                }


                string
                f_1067_62813_62842(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 62813, 62842);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                f_1067_62873_62893(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 62873, 62893);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForInstanceMethodParameter
                f_1067_62924_62963(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.CmdletParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 62924, 62963);
                    return return_v;
                }


                System.Management.Automation.ParameterMetadata
                f_1067_62710_62964(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, string
                parameterSetName, string
                objectModelParameterName, Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                parameterType, Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForInstanceMethodParameter
                parameterCmdletization)
                {
                    var return_v = this_param.GetParameter(parameterSetName, objectModelParameterName, parameterType, parameterCmdletization);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 62710, 62964);
                    return return_v;
                }


                string
                f_1067_63013_63035(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 63013, 63035);
                    return return_v;
                }


                string
                f_1067_63145_63167(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 63145, 63167);
                    return return_v;
                }


                int
                f_1067_63124_63187(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                this_param, string
                key, System.Management.Automation.ParameterMetadata
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 63124, 63187);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1067_63390_63418()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 63390, 63418);
                    return return_v;
                }


                string
                f_1067_63515_63582()
                {
                    var return_v = CmdletizationCoreResources.ScriptWriter_DuplicateQueryParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 63515, 63582);
                    return return_v;
                }


                string
                f_1067_63682_63704(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 63682, 63704);
                    return return_v;
                }


                string
                f_1067_63342_63705(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 63342, 63705);
                    return return_v;
                }


                System.Xml.XmlException
                f_1067_63742_63770(string
                message, System.ArgumentException
                innerException)
                {
                    var return_v = new System.Xml.XmlException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 63742, 63770);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.MethodParameterBindings
                f_1067_63895_63934(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodParameterMetadata
                methodParameter)
                {
                    var return_v = GetMethodParameterKind(methodParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 63895, 63934);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                f_1067_64000_64020(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 64000, 64020);
                    return return_v;
                }


                System.Type
                f_1067_63986_64021(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                typeMetadata)
                {
                    var return_v = this_param.GetDotNetType(typeMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 63986, 64021);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                f_1067_64276_64296(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 64276, 64296);
                    return return_v;
                }


                string
                f_1067_64276_64304(Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                this_param)
                {
                    var return_v = this_param.ETSType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 64276, 64304);
                    return return_v;
                }


                string
                f_1067_64331_64359(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.DefaultValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 64331, 64359);
                    return return_v;
                }


                string
                f_1067_64386_64415(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 64386, 64415);
                    return return_v;
                }


                int
                f_1067_64044_64466(System.IO.StringWriter
                output, string
                prefix, string
                cmdletParameterName, System.Type
                cmdletParameterType, string
                etsParameterTypeName, string
                cmdletParameterDefaultValue, string
                methodParameterName, Microsoft.PowerShell.Cmdletization.MethodParameterBindings
                methodParameterBindings)
                {
                    GenerateSingleMethodParameterProcessing((System.IO.TextWriter)output, prefix, cmdletParameterName, cmdletParameterType, etsParameterTypeName, cmdletParameterDefaultValue, methodParameterName, methodParameterBindings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 64044, 64466);
                    return 0;
                }


                int
                f_1067_64631_64678(System.Collections.Generic.List<System.Type>
                this_param, System.Type
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 64631, 64678);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                f_1067_64733_64753(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 64733, 64753);
                    return return_v;
                }


                string
                f_1067_64733_64761(Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                this_param)
                {
                    var return_v = this_param.ETSType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 64733, 64761);
                    return return_v;
                }


                int
                f_1067_64705_64762(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 64705, 64762);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodParameterMetadata[]
                f_1067_62456_62473_I(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodParameterMetadata[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 62456, 62473);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                f_1067_64840_64858(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodMetadata
                this_param)
                {
                    var return_v = this_param.ReturnValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 64840, 64858);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                f_1067_64973_64991(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodMetadata
                this_param)
                {
                    var return_v = this_param.ReturnValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 64973, 64991);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.MethodParameterBindings
                f_1067_64950_64992(Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                returnValue)
                {
                    var return_v = GetMethodParameterKind(returnValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 64950, 64992);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                f_1067_65054_65072(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodMetadata
                this_param)
                {
                    var return_v = this_param.ReturnValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 65054, 65072);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                f_1067_65054_65077(Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 65054, 65077);
                    return return_v;
                }


                System.Type
                f_1067_65040_65078(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                typeMetadata)
                {
                    var return_v = this_param.GetDotNetType(typeMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 65040, 65078);
                    return return_v;
                }


                string
                f_1067_65405_65435(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 65405, 65435);
                    return return_v;
                }


                string
                f_1067_65358_65436(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 65358, 65436);
                    return return_v;
                }


                string
                f_1067_65506_65540(Microsoft.PowerShell.Cmdletization.MethodParameterBindings
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 65506, 65540);
                    return return_v;
                }


                string
                f_1067_65459_65541(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 65459, 65541);
                    return return_v;
                }


                int
                f_1067_65097_65542(System.IO.StringWriter
                this_param, string
                format, string
                arg0, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 65097, 65542);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                f_1067_65589_65607(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodMetadata
                this_param)
                {
                    var return_v = this_param.ReturnValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 65589, 65607);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                f_1067_65589_65612(Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 65589, 65612);
                    return return_v;
                }


                string
                f_1067_65589_65620(Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                this_param)
                {
                    var return_v = this_param.ETSType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 65589, 65620);
                    return return_v;
                }


                bool
                f_1067_65568_65621(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 65568, 65621);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                f_1067_65846_65864(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodMetadata
                this_param)
                {
                    var return_v = this_param.ReturnValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 65846, 65864);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                f_1067_65846_65869(Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 65846, 65869);
                    return return_v;
                }


                string
                f_1067_65846_65877(Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                this_param)
                {
                    var return_v = this_param.ETSType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 65846, 65877);
                    return return_v;
                }


                string
                f_1067_65799_65878(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 65799, 65878);
                    return return_v;
                }


                int
                f_1067_65663_65879(System.IO.StringWriter
                this_param, string
                format, string
                arg0)
                {
                    this_param.WriteLine(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 65663, 65879);
                    return 0;
                }


                int
                f_1067_66051_66098(System.Collections.Generic.List<System.Type>
                this_param, System.Type
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 66051, 66098);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                f_1067_66149_66167(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodMetadata
                this_param)
                {
                    var return_v = this_param.ReturnValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 66149, 66167);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                f_1067_66149_66172(Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 66149, 66172);
                    return return_v;
                }


                string
                f_1067_66149_66180(Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                this_param)
                {
                    var return_v = this_param.ETSType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 66149, 66180);
                    return return_v;
                }


                int
                f_1067_66121_66181(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 66121, 66181);
                    return 0;
                }


                int
                f_1067_66267_66329(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 66267, 66329);
                    return 0;
                }


                string
                f_1067_66644_66661(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodMetadata
                this_param)
                {
                    var return_v = this_param.MethodName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 66644, 66661);
                    return return_v;
                }


                string
                f_1067_66597_66662(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 66597, 66662);
                    return return_v;
                }


                int
                f_1067_66361_66663(System.IO.StringWriter
                this_param, string
                format, string
                arg0)
                {
                    this_param.WriteLine(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 66361, 66663);
                    return 0;
                }


                int
                f_1067_66684_66710(System.Collections.Generic.List<System.Type>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 66684, 66710);
                    return return_v;
                }


                int
                f_1067_66749_66882(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 66749, 66882);
                    return 0;
                }


                int
                f_1067_66949_67031(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 66949, 67031);
                    return 0;
                }


                int
                f_1067_67063_67147(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 67063, 67147);
                    return 0;
                }


                int
                f_1067_67162_67350(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 67162, 67350);
                    return 0;
                }


                int
                f_1067_67365_67405(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 67365, 67405);
                    return 0;
                }


                int
                f_1067_67420_67602(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 67420, 67602);
                    return 0;
                }


                int
                f_1067_67617_67650(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 67617, 67650);
                    return 0;
                }


                int
                f_1067_67665_67694(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 67665, 67694);
                    return 0;
                }


                int
                f_1067_67709_67734(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 67709, 67734);
                    return 0;
                }


                string
                f_1067_67764_67781(System.IO.StringWriter
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 67764, 67781);
                    return return_v;
                }


                int
                f_1067_67802_67828(System.Collections.Generic.List<System.Type>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 67802, 67828);
                    return return_v;
                }


                string
                f_1067_67935_67967(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param)
                {
                    var return_v = this_param.GetOutputAttributeForGetCmdlet();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 67935, 67967);
                    return return_v;
                }


                int
                f_1067_68006_68032(System.Collections.Generic.List<System.Type>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 68006, 68032);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_68140_68168()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 68140, 68168);
                    return return_v;
                }


                System.Type
                f_1067_68235_68258(System.Collections.Generic.List<System.Type>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 68235, 68258);
                    return return_v;
                }


                string
                f_1067_68235_68267(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 68235, 68267);
                    return return_v;
                }


                string
                f_1067_68104_68268(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 68104, 68268);
                    return return_v;
                }


                int
                f_1067_68292_68321(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 68292, 68321);
                    return return_v;
                }


                string
                f_1067_68354_68380(System.Collections.Generic.List<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 68354, 68380);
                    return return_v;
                }


                bool
                f_1067_68333_68381(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 68333, 68381);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_68498_68526()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 68498, 68526);
                    return return_v;
                }


                string
                f_1067_68648_68674(System.Collections.Generic.List<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 68648, 68674);
                    return return_v;
                }


                string
                f_1067_68601_68675(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 68601, 68675);
                    return return_v;
                }


                string
                f_1067_68458_68676(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 68458, 68676);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 60659, 68722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 60659, 68722);
            }
        }

        private void GenerateIfBoundParameter(
                    IEnumerable<string> commonParameterSets,
                    IEnumerable<string> methodParameterSets,
                    ParameterMetadata cmdletParameterMetadata,
                    TextWriter output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 68734, 69812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 68993, 69142);

                f_1067_68993_69141(output, "    if ($PSBoundParameters.ContainsKey('{0}') -and (@(", f_1067_69064_69140(f_1067_69111_69139(cmdletParameterMetadata)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 69156, 69186);

                bool
                firstParameterSet = true
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 69200, 69721);
                    foreach (string queryParameterSetName in f_1067_69241_69283_I(f_1067_69241_69283(f_1067_69241_69278(cmdletParameterMetadata))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 69200, 69721);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 69302, 69721);
                            foreach (string parameterSetName in f_1067_69338_69459_I(f_1067_69338_69459(queryParameterSetName, InstanceQueryParameterSetTemplate, commonParameterSets, methodParameterSets)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 69302, 69721);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 69501, 69544) || true) && (!firstParameterSet)
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 69501, 69544);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 69525, 69544);

                                    f_1067_69525_69543(output, ", ");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 69501, 69544);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 69566, 69592);

                                firstParameterSet = false;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 69614, 69702);

                                f_1067_69614_69701(output, "'{0}'", f_1067_69636_69700(parameterSetName));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 69302, 69721);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 420);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 420);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 69200, 69721);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 522);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 522);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 69737, 69801);

                f_1067_69737_69800(
                            output, ") -contains $PSCmdlet.ParameterSetName )) {");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 68734, 69812);

                string
                f_1067_69111_69139(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 69111, 69139);
                    return return_v;
                }


                string
                f_1067_69064_69140(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 69064, 69140);
                    return return_v;
                }


                int
                f_1067_68993_69141(System.IO.TextWriter
                this_param, string
                format, string
                arg0)
                {
                    this_param.Write(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 68993, 69141);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1067_69241_69278(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 69241, 69278);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>.KeyCollection
                f_1067_69241_69283(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 69241, 69283);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1067_69338_69459(string
                mainParameterSet, string
                parameterSetNameTemplate, params System.Collections.Generic.IEnumerable<string>[]
                otherParameterSets)
                {
                    var return_v = MultiplyParameterSets(mainParameterSet, parameterSetNameTemplate, otherParameterSets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 69338, 69459);
                    return return_v;
                }


                int
                f_1067_69525_69543(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 69525, 69543);
                    return 0;
                }


                string
                f_1067_69636_69700(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 69636, 69700);
                    return return_v;
                }


                int
                f_1067_69614_69701(System.IO.TextWriter
                this_param, string
                format, string
                arg0)
                {
                    this_param.Write(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 69614, 69701);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1067_69338_69459_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 69338, 69459);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>.KeyCollection
                f_1067_69241_69283_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>.KeyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 69241, 69283);
                    return return_v;
                }


                int
                f_1067_69737_69800(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 69737, 69800);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 68734, 69812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 68734, 69812);
            }
        }

        private ParameterMetadata GenerateQueryClause(
                    IEnumerable<string> commonParameterSets,
                    IEnumerable<string> queryParameterSets,
                    IEnumerable<string> methodParameterSets,
                    string queryBuilderMethodName,
                    PropertyMetadata property,
                    PropertyQuery query,
                    TextWriter output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 69824, 72921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 70206, 70421);

                ParameterMetadata
                cmdletParameterMetadata = f_1067_70250_70420(this, queryParameterSets, f_1067_70318_70339(property), f_1067_70358_70371(property), f_1067_70390_70419(query))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 70437, 70526);

                WildcardablePropertyQuery
                wildcardablePropertyQuery = query as WildcardablePropertyQuery
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 70540, 70953) || true) && ((wildcardablePropertyQuery != null) && (DynAbs.Tracing.TraceSender.Expression_True(1067, 70544, 70625) && (f_1067_70584_70624_M(!cmdletParameterMetadata.SwitchParameter))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 70540, 70953);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 70659, 70824) || true) && (f_1067_70663_70700(cmdletParameterMetadata) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 70659, 70824);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 70750, 70805);

                        cmdletParameterMetadata.ParameterType = typeof(object);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 70659, 70824);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 70844, 70938);

                    cmdletParameterMetadata.ParameterType = f_1067_70884_70937(f_1067_70884_70921(cmdletParameterMetadata));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 70540, 70953);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 70969, 71069);

                f_1067_70969_71068(this, commonParameterSets, methodParameterSets, cmdletParameterMetadata, output);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 71085, 71199);

                string
                localVariableName = (DynAbs.Tracing.TraceSender.Conditional_F1(1067, 71112, 71145) || ((wildcardablePropertyQuery == null && DynAbs.Tracing.TraceSender.Conditional_F2(1067, 71148, 71171)) || DynAbs.Tracing.TraceSender.Conditional_F3(1067, 71174, 71198))) ? "__cmdletization_value" : "__cmdletization_values"
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 71213, 71760) || true) && (wildcardablePropertyQuery == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 71213, 71760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 71284, 71484);

                    f_1067_71284_71483(output, "        [object]${0} = ${{{1}}}", localVariableName, f_1067_71419_71482(f_1067_71453_71481(cmdletParameterMetadata)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 71213, 71760);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 71213, 71760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 71550, 71745);

                    f_1067_71550_71744(output, "        ${0} = @(${{{1}}})", localVariableName, f_1067_71680_71743(f_1067_71714_71742(cmdletParameterMetadata)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 71213, 71760);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 71776, 72029);

                f_1067_71776_72028(
                            output, "        $__cmdletization_queryBuilder.{0}('{1}', ${2}", queryBuilderMethodName, f_1067_71922_71991(f_1067_71969_71990(property)), localVariableName);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 72043, 72821) || true) && (wildcardablePropertyQuery == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 72043, 72821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 72114, 72248);

                    f_1067_72114_72247(output, ", '{0}')", f_1067_72186_72246(f_1067_72216_72245(query)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 72043, 72821);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 72043, 72821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 72314, 72592);

                    bool
                    allowGlobbing =
                                        (f_1067_72357_72406_M(!wildcardablePropertyQuery.AllowGlobbingSpecified) && (DynAbs.Tracing.TraceSender.Expression_True(1067, 72357, 72472) && f_1067_72410_72472(f_1067_72410_72447(cmdletParameterMetadata), typeof(string[])))) || (DynAbs.Tracing.TraceSender.Expression_False(1067, 72356, 72591) || (f_1067_72499_72547(wildcardablePropertyQuery) && (DynAbs.Tracing.TraceSender.Expression_True(1067, 72499, 72590) && f_1067_72551_72590(wildcardablePropertyQuery))))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 72610, 72806);

                    f_1067_72610_72805(output, ", {0}, '{1}')", (DynAbs.Tracing.TraceSender.Conditional_F1(1067, 72687, 72700) || ((allowGlobbing && DynAbs.Tracing.TraceSender.Conditional_F2(1067, 72703, 72710)) || DynAbs.Tracing.TraceSender.Conditional_F3(1067, 72713, 72721))) ? "$true" : "$false", f_1067_72744_72804(f_1067_72774_72803(query)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 72043, 72821);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 72837, 72863);

                f_1067_72837_72862(
                            output, "    }");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 72879, 72910);

                return cmdletParameterMetadata;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 69824, 72921);

                string
                f_1067_70318_70339(Microsoft.PowerShell.Cmdletization.Xml.PropertyMetadata
                this_param)
                {
                    var return_v = this_param.PropertyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 70318, 70339);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                f_1067_70358_70371(Microsoft.PowerShell.Cmdletization.Xml.PropertyMetadata
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 70358, 70371);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletFilteringParameter
                f_1067_70390_70419(Microsoft.PowerShell.Cmdletization.Xml.PropertyQuery
                this_param)
                {
                    var return_v = this_param.CmdletParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 70390, 70419);
                    return return_v;
                }


                System.Management.Automation.ParameterMetadata
                f_1067_70250_70420(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, System.Collections.Generic.IEnumerable<string>
                queryParameterSets, string
                objectModelParameterName, Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                parameterType, Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletFilteringParameter
                parameterCmdletization)
                {
                    var return_v = this_param.GetParameter(queryParameterSets, objectModelParameterName, parameterType, (Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter)parameterCmdletization);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 70250, 70420);
                    return return_v;
                }


                bool
                f_1067_70584_70624_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 70584, 70624);
                    return return_v;
                }


                System.Type
                f_1067_70663_70700(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 70663, 70700);
                    return return_v;
                }


                System.Type
                f_1067_70884_70921(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 70884, 70921);
                    return return_v;
                }


                System.Type
                f_1067_70884_70937(System.Type
                this_param)
                {
                    var return_v = this_param.MakeArrayType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 70884, 70937);
                    return return_v;
                }


                int
                f_1067_70969_71068(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, System.Collections.Generic.IEnumerable<string>
                commonParameterSets, System.Collections.Generic.IEnumerable<string>
                methodParameterSets, System.Management.Automation.ParameterMetadata
                cmdletParameterMetadata, System.IO.TextWriter
                output)
                {
                    this_param.GenerateIfBoundParameter(commonParameterSets, methodParameterSets, cmdletParameterMetadata, output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 70969, 71068);
                    return 0;
                }


                string
                f_1067_71453_71481(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 71453, 71481);
                    return return_v;
                }


                string
                f_1067_71419_71482(string
                value)
                {
                    var return_v = CodeGeneration.EscapeVariableName(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 71419, 71482);
                    return return_v;
                }


                int
                f_1067_71284_71483(System.IO.TextWriter
                this_param, string
                format, string
                arg0, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 71284, 71483);
                    return 0;
                }


                string
                f_1067_71714_71742(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 71714, 71742);
                    return return_v;
                }


                string
                f_1067_71680_71743(string
                value)
                {
                    var return_v = CodeGeneration.EscapeVariableName(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 71680, 71743);
                    return return_v;
                }


                int
                f_1067_71550_71744(System.IO.TextWriter
                this_param, string
                format, string
                arg0, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 71550, 71744);
                    return 0;
                }


                string
                f_1067_71969_71990(Microsoft.PowerShell.Cmdletization.Xml.PropertyMetadata
                this_param)
                {
                    var return_v = this_param.PropertyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 71969, 71990);
                    return return_v;
                }


                string
                f_1067_71922_71991(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 71922, 71991);
                    return return_v;
                }


                int
                f_1067_71776_72028(System.IO.TextWriter
                this_param, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    this_param.Write(format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 71776, 72028);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletFilteringParameter
                f_1067_72216_72245(Microsoft.PowerShell.Cmdletization.Xml.PropertyQuery
                this_param)
                {
                    var return_v = this_param.CmdletParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 72216, 72245);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.BehaviorOnNoMatch
                f_1067_72186_72246(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletFilteringParameter
                cmdletParameterMetadata)
                {
                    var return_v = GetBehaviorWhenNoMatchesFound(cmdletParameterMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 72186, 72246);
                    return return_v;
                }


                int
                f_1067_72114_72247(System.IO.TextWriter
                this_param, string
                format, Microsoft.PowerShell.Cmdletization.BehaviorOnNoMatch
                arg0)
                {
                    this_param.WriteLine(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 72114, 72247);
                    return 0;
                }


                bool
                f_1067_72357_72406_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 72357, 72406);
                    return return_v;
                }


                System.Type
                f_1067_72410_72447(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 72410, 72447);
                    return return_v;
                }


                bool
                f_1067_72410_72472(System.Type
                this_param, System.Type
                o)
                {
                    var return_v = this_param.Equals(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 72410, 72472);
                    return return_v;
                }


                bool
                f_1067_72499_72547(Microsoft.PowerShell.Cmdletization.Xml.WildcardablePropertyQuery
                this_param)
                {
                    var return_v = this_param.AllowGlobbingSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 72499, 72547);
                    return return_v;
                }


                bool
                f_1067_72551_72590(Microsoft.PowerShell.Cmdletization.Xml.WildcardablePropertyQuery
                this_param)
                {
                    var return_v = this_param.AllowGlobbing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 72551, 72590);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletFilteringParameter
                f_1067_72774_72803(Microsoft.PowerShell.Cmdletization.Xml.PropertyQuery
                this_param)
                {
                    var return_v = this_param.CmdletParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 72774, 72803);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.BehaviorOnNoMatch
                f_1067_72744_72804(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletFilteringParameter
                cmdletParameterMetadata)
                {
                    var return_v = GetBehaviorWhenNoMatchesFound(cmdletParameterMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 72744, 72804);
                    return return_v;
                }


                int
                f_1067_72610_72805(System.IO.TextWriter
                this_param, string
                format, string
                arg0, Microsoft.PowerShell.Cmdletization.BehaviorOnNoMatch
                arg1)
                {
                    this_param.WriteLine(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 72610, 72805);
                    return 0;
                }


                int
                f_1067_72837_72862(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 72837, 72862);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 69824, 72921);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 69824, 72921);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BehaviorOnNoMatch GetBehaviorWhenNoMatchesFound(CmdletParameterMetadataForGetCmdletFilteringParameter cmdletParameterMetadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1067, 72933, 73536);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 73099, 73272) || true) && ((cmdletParameterMetadata == null) || (DynAbs.Tracing.TraceSender.Expression_False(1067, 73103, 73190) || (f_1067_73141_73189_M(!cmdletParameterMetadata.ErrorOnNoMatchSpecified))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 73099, 73272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 73224, 73257);

                    return BehaviorOnNoMatch.Default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 73099, 73272);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 73288, 73525) || true) && (f_1067_73292_73330(cmdletParameterMetadata))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 73288, 73525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 73364, 73402);

                    return BehaviorOnNoMatch.ReportErrors;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 73288, 73525);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 73288, 73525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 73468, 73510);

                    return BehaviorOnNoMatch.SilentlyContinue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 73288, 73525);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1067, 72933, 73536);

                bool
                f_1067_73141_73189_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 73141, 73189);
                    return return_v;
                }


                bool
                f_1067_73292_73330(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletFilteringParameter
                this_param)
                {
                    var return_v = this_param.ErrorOnNoMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 73292, 73330);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 72933, 73536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 72933, 73536);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ParameterMetadata GenerateAssociationClause(
                    IEnumerable<string> commonParameterSets,
                    IEnumerable<string> queryParameterSets,
                    IEnumerable<string> methodParameterSets,
                    Association associationMetadata,
                    AssociationAssociatedInstance associatedInstanceMetadata,
                    TextWriter output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 73548, 75127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 73935, 74198);

                ParameterMetadata
                cmdletParameterMetadata = f_1067_73979_74197(this, queryParameterSets, f_1067_74047_74077(associationMetadata), f_1067_74096_74127(associatedInstanceMetadata), f_1067_74146_74196(associatedInstanceMetadata))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 74212, 74283);

                f_1067_74212_74282(f_1067_74212_74246(cmdletParameterMetadata), f_1067_74251_74281());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 74299, 74399);

                f_1067_74299_74398(this, commonParameterSets, methodParameterSets, cmdletParameterMetadata, output);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 74415, 75027);

                f_1067_74415_75026(
                            output, "    $__cmdletization_queryBuilder.FilterByAssociatedInstance(${{{0}}}, '{1}', '{2}', '{3}', '{4}')", f_1067_74569_74632(f_1067_74603_74631(cmdletParameterMetadata)), f_1067_74651_74731(f_1067_74698_74730(associationMetadata)), f_1067_74750_74828(f_1067_74797_74827(associationMetadata)), f_1067_74847_74925(f_1067_74894_74924(associationMetadata)), f_1067_74944_75025(f_1067_74974_75024(associatedInstanceMetadata)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 75043, 75069);

                f_1067_75043_75068(
                            output, "    }");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 75085, 75116);

                return cmdletParameterMetadata;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 73548, 75127);

                string
                f_1067_74047_74077(Microsoft.PowerShell.Cmdletization.Xml.Association
                this_param)
                {
                    var return_v = this_param.SourceRole;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 74047, 74077);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                f_1067_74096_74127(Microsoft.PowerShell.Cmdletization.Xml.AssociationAssociatedInstance
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 74096, 74127);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletFilteringParameter
                f_1067_74146_74196(Microsoft.PowerShell.Cmdletization.Xml.AssociationAssociatedInstance
                this_param)
                {
                    var return_v = this_param.CmdletParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 74146, 74196);
                    return return_v;
                }


                System.Management.Automation.ParameterMetadata
                f_1067_73979_74197(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, System.Collections.Generic.IEnumerable<string>
                queryParameterSets, string
                objectModelParameterName, Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                parameterType, Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletFilteringParameter
                parameterCmdletization)
                {
                    var return_v = this_param.GetParameter(queryParameterSets, objectModelParameterName, parameterType, (Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter)parameterCmdletization);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 73979, 74197);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1067_74212_74246(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 74212, 74246);
                    return return_v;
                }


                System.Management.Automation.ValidateNotNullAttribute
                f_1067_74251_74281()
                {
                    var return_v = new System.Management.Automation.ValidateNotNullAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 74251, 74281);
                    return return_v;
                }


                int
                f_1067_74212_74282(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ValidateNotNullAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 74212, 74282);
                    return 0;
                }


                int
                f_1067_74299_74398(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, System.Collections.Generic.IEnumerable<string>
                commonParameterSets, System.Collections.Generic.IEnumerable<string>
                methodParameterSets, System.Management.Automation.ParameterMetadata
                cmdletParameterMetadata, System.IO.TextWriter
                output)
                {
                    this_param.GenerateIfBoundParameter(commonParameterSets, methodParameterSets, cmdletParameterMetadata, output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 74299, 74398);
                    return 0;
                }


                string
                f_1067_74603_74631(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 74603, 74631);
                    return return_v;
                }


                string
                f_1067_74569_74632(string
                value)
                {
                    var return_v = CodeGeneration.EscapeVariableName(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 74569, 74632);
                    return return_v;
                }


                string
                f_1067_74698_74730(Microsoft.PowerShell.Cmdletization.Xml.Association
                this_param)
                {
                    var return_v = this_param.Association1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 74698, 74730);
                    return return_v;
                }


                string
                f_1067_74651_74731(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 74651, 74731);
                    return return_v;
                }


                string
                f_1067_74797_74827(Microsoft.PowerShell.Cmdletization.Xml.Association
                this_param)
                {
                    var return_v = this_param.SourceRole;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 74797, 74827);
                    return return_v;
                }


                string
                f_1067_74750_74828(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 74750, 74828);
                    return return_v;
                }


                string
                f_1067_74894_74924(Microsoft.PowerShell.Cmdletization.Xml.Association
                this_param)
                {
                    var return_v = this_param.ResultRole;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 74894, 74924);
                    return return_v;
                }


                string
                f_1067_74847_74925(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 74847, 74925);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletFilteringParameter
                f_1067_74974_75024(Microsoft.PowerShell.Cmdletization.Xml.AssociationAssociatedInstance
                this_param)
                {
                    var return_v = this_param.CmdletParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 74974, 75024);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.BehaviorOnNoMatch
                f_1067_74944_75025(Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletFilteringParameter
                cmdletParameterMetadata)
                {
                    var return_v = GetBehaviorWhenNoMatchesFound(cmdletParameterMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 74944, 75025);
                    return return_v;
                }


                int
                f_1067_74415_75026(System.IO.TextWriter
                this_param, string
                format, params object?[]
                arg)
                {
                    this_param.WriteLine(format, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 74415, 75026);
                    return 0;
                }


                int
                f_1067_75043_75068(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 75043, 75068);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 73548, 75127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 73548, 75127);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ParameterMetadata GenerateOptionClause(
                    IEnumerable<string> commonParameterSets,
                    IEnumerable<string> queryParameterSets,
                    IEnumerable<string> methodParameterSets,
                    QueryOption queryOptionMetadata,
                    TextWriter output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 75139, 76214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 75450, 75699);

                ParameterMetadata
                cmdletParameterMetadata = f_1067_75494_75698(this, queryParameterSets, f_1067_75562_75592(queryOptionMetadata), f_1067_75611_75635(queryOptionMetadata), f_1067_75654_75697(queryOptionMetadata))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 75715, 75815);

                f_1067_75715_75814(this, commonParameterSets, methodParameterSets, cmdletParameterMetadata, output);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 75831, 76114);

                f_1067_75831_76113(
                            output, "    $__cmdletization_queryBuilder.AddQueryOption('{0}', ${{{1}}})", f_1067_75952_76030(f_1067_75999_76029(queryOptionMetadata)), f_1067_76049_76112(f_1067_76083_76111(cmdletParameterMetadata)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 76130, 76156);

                f_1067_76130_76155(
                            output, "    }");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 76172, 76203);

                return cmdletParameterMetadata;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 75139, 76214);

                string
                f_1067_75562_75592(Microsoft.PowerShell.Cmdletization.Xml.QueryOption
                this_param)
                {
                    var return_v = this_param.OptionName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 75562, 75592);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                f_1067_75611_75635(Microsoft.PowerShell.Cmdletization.Xml.QueryOption
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 75611, 75635);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter
                f_1067_75654_75697(Microsoft.PowerShell.Cmdletization.Xml.QueryOption
                this_param)
                {
                    var return_v = this_param.CmdletParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 75654, 75697);
                    return return_v;
                }


                System.Management.Automation.ParameterMetadata
                f_1067_75494_75698(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, System.Collections.Generic.IEnumerable<string>
                queryParameterSets, string
                objectModelParameterName, Microsoft.PowerShell.Cmdletization.Xml.TypeMetadata
                parameterType, Microsoft.PowerShell.Cmdletization.Xml.CmdletParameterMetadataForGetCmdletParameter
                parameterCmdletization)
                {
                    var return_v = this_param.GetParameter(queryParameterSets, objectModelParameterName, parameterType, parameterCmdletization);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 75494, 75698);
                    return return_v;
                }


                int
                f_1067_75715_75814(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, System.Collections.Generic.IEnumerable<string>
                commonParameterSets, System.Collections.Generic.IEnumerable<string>
                methodParameterSets, System.Management.Automation.ParameterMetadata
                cmdletParameterMetadata, System.IO.TextWriter
                output)
                {
                    this_param.GenerateIfBoundParameter(commonParameterSets, methodParameterSets, cmdletParameterMetadata, output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 75715, 75814);
                    return 0;
                }


                string
                f_1067_75999_76029(Microsoft.PowerShell.Cmdletization.Xml.QueryOption
                this_param)
                {
                    var return_v = this_param.OptionName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 75999, 76029);
                    return return_v;
                }


                string
                f_1067_75952_76030(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 75952, 76030);
                    return return_v;
                }


                string
                f_1067_76083_76111(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 76083, 76111);
                    return return_v;
                }


                string
                f_1067_76049_76112(string
                value)
                {
                    var return_v = CodeGeneration.EscapeVariableName(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 76049, 76112);
                    return return_v;
                }


                int
                f_1067_75831_76113(System.IO.TextWriter
                this_param, string
                format, string
                arg0, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 75831, 76113);
                    return 0;
                }


                int
                f_1067_76130_76155(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 76130, 76155);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 75139, 76214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 75139, 76214);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GenerateQueryParametersProcessing(
                    InstanceCmdletMetadata instanceCmdlet,
                    IEnumerable<string> commonParameterSets,
                    IEnumerable<string> queryParameterSets,
                    IEnumerable<string> methodParameterSets,
                    out string scriptCode,
                    out Dictionary<string, ParameterMetadata> queryParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 76226, 84950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 76619, 76713);

                queryParameters = f_1067_76637_76712(f_1067_76679_76711());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 76727, 76796);

                StringWriter
                output = f_1067_76749_76795(f_1067_76766_76794())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 76812, 76922);

                f_1067_76812_76921(
                            output, "    $__cmdletization_queryBuilder = $__cmdletization_objectModelWrapper.GetQueryBuilder()");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 76938, 77019);

                GetCmdletParameters
                getCmdletParameters = f_1067_76980_77018(this, instanceCmdlet)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 77033, 79975) || true) && (f_1067_77037_77076(getCmdletParameters) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 77033, 79975);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 77118, 79960);
                        foreach (PropertyMetadata property in f_1067_77156_77223_I(f_1067_77156_77223(f_1067_77156_77195(getCmdletParameters), p => p.Items != null)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 77118, 79960);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 77274, 77279);
                                for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 77265, 79941) || true) && (i < f_1067_77285_77306(f_1067_77285_77299(property)))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 77308, 77311)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 77265, 79941))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 77265, 79941);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 77361, 77379);

                                    string
                                    methodName
                                    = default(string);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 77405, 78424);

                                    switch (f_1067_77413_77438(property)[i])
                                    {

                                        case ItemsChoiceType.RegularQuery:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 77405, 78424);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 77567, 77599);

                                            methodName = "FilterByProperty";
                                            DynAbs.Tracing.TraceSender.TraceBreak(1067, 77633, 77639);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 77405, 78424);

                                        case ItemsChoiceType.ExcludeQuery:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 77405, 78424);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 77737, 77770);

                                            methodName = "ExcludeByProperty";
                                            DynAbs.Tracing.TraceSender.TraceBreak(1067, 77804, 77810);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 77405, 78424);

                                        case ItemsChoiceType.MinValueQuery:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 77405, 78424);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 77909, 77949);

                                            methodName = "FilterByMinPropertyValue";
                                            DynAbs.Tracing.TraceSender.TraceBreak(1067, 77983, 77989);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 77405, 78424);

                                        case ItemsChoiceType.MaxValueQuery:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 77405, 78424);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 78088, 78128);

                                            methodName = "FilterByMaxPropertyValue";
                                            DynAbs.Tracing.TraceSender.TraceBreak(1067, 78162, 78168);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 77405, 78424);

                                        default:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 77405, 78424);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 78240, 78292);

                                            f_1067_78240_78291(false, "Unrecognized query xml element");
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 78326, 78357);

                                            methodName = "NotAValidMethod";
                                            DynAbs.Tracing.TraceSender.TraceBreak(1067, 78391, 78397);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 77405, 78424);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 78452, 78651);

                                    ParameterMetadata
                                    parameterMetadata = f_1067_78490_78650(this, commonParameterSets, queryParameterSets, methodParameterSets, methodName, property, f_1067_78624_78638(property)[i], output)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 78679, 79164);

                                    switch (f_1067_78687_78712(property)[i])
                                    {

                                        case ItemsChoiceType.RegularQuery:
                                        case ItemsChoiceType.ExcludeQuery:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 78679, 79164);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 78905, 78970);

                                            f_1067_78905_78969(f_1067_78905_78933(parameterMetadata), f_1067_78938_78968());
                                            DynAbs.Tracing.TraceSender.TraceBreak(1067, 79004, 79010);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 78679, 79164);

                                        default:
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 78679, 79164);
                                            DynAbs.Tracing.TraceSender.TraceBreak(1067, 79131, 79137);

                                            break;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 78679, 79164);
                                    }

                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 79252, 79315);

                                        f_1067_79252_79314(queryParameters, f_1067_79272_79294(parameterMetadata), parameterMetadata);
                                    }
                                    catch (ArgumentException e)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1067, 79368, 79918);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 79452, 79826);

                                        string
                                        message = f_1067_79469_79825(f_1067_79517_79545(), f_1067_79642_79709(), "<GetCmdletParameters>", f_1067_79802_79824(parameterMetadata))
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 79856, 79891);

                                        throw f_1067_79862_79890(message, e);
                                        DynAbs.Tracing.TraceSender.TraceExitCatch(1067, 79368, 79918);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 2677);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 2677);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 77118, 79960);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 2843);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 2843);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 77033, 79975);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 79991, 81177) || true) && (f_1067_79995_80036(getCmdletParameters) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 79991, 81177);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 80078, 81162);
                        foreach (Association association in f_1067_80114_80196_I(f_1067_80114_80196(f_1067_80114_80155(getCmdletParameters), a => a.AssociatedInstance != null)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 80078, 81162);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 80238, 80443);

                            ParameterMetadata
                            parameterMetadata = f_1067_80276_80442(this, commonParameterSets, queryParameterSets, methodParameterSets, association, f_1067_80403_80433(association), output)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 80517, 80580);

                                f_1067_80517_80579(queryParameters, f_1067_80537_80559(parameterMetadata), parameterMetadata);
                            }
                            catch (ArgumentException e)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1067, 80625, 81143);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 80701, 81059);

                                string
                                message = f_1067_80718_81058(f_1067_80762_80790(), f_1067_80883_80950(), "<GetCmdletParameters>", f_1067_81035_81057(parameterMetadata))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 81085, 81120);

                                throw f_1067_81091_81119(message, e);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1067, 80625, 81143);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 80078, 81162);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 1085);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 1085);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 79991, 81177);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 81193, 82283) || true) && (f_1067_81197_81229(getCmdletParameters) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 81193, 82283);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 81271, 82268);
                        foreach (QueryOption queryOption in f_1067_81307_81339_I(f_1067_81307_81339(getCmdletParameters)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 81271, 82268);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 81381, 81549);

                            ParameterMetadata
                            parameterMetadata = f_1067_81419_81548(this, commonParameterSets, queryParameterSets, methodParameterSets, queryOption, output)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 81623, 81686);

                                f_1067_81623_81685(queryParameters, f_1067_81643_81665(parameterMetadata), parameterMetadata);
                            }
                            catch (ArgumentException e)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1067, 81731, 82249);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 81807, 82165);

                                string
                                message = f_1067_81824_82164(f_1067_81868_81896(), f_1067_81989_82056(), "<GetCmdletParameters>", f_1067_82141_82163(parameterMetadata))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 82191, 82226);

                                throw f_1067_82197_82225(message, e);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1067, 81731, 82249);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 81271, 82268);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 998);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 998);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 81193, 82283);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 82299, 84859) || true) && (instanceCmdlet != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 82299, 84859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 82359, 82474);

                    ParameterMetadata
                    inputObjectParameter = f_1067_82400_82473("InputObject", f_1067_82437_82472(_objectInstanceType))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 82494, 82603);

                    ParameterSetMetadata.ParameterFlags
                    inputObjectFlags = ParameterSetMetadata.ParameterFlags.ValueFromPipeline
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 82621, 82777) || true) && (f_1067_82625_82646(queryParameters) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 82621, 82777);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 82692, 82758);

                        inputObjectFlags |= ParameterSetMetadata.ParameterFlags.Mandatory;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 82621, 82777);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 82797, 82836);

                    string
                    psTypeNameOfInputObjectElements
                    = default(string);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 82854, 84152) || true) && (f_1067_82858_82952(f_1067_82858_82886(_objectModelWrapper), "Microsoft.PowerShell.Cmdletization.Cim.CimCmdletAdapter"))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 82854, 84152);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 82994, 83078);

                        int
                        indexOfLastBackslash = f_1067_83021_83077(f_1067_83021_83059(f_1067_83021_83049(_cmdletizationMetadata)), '\\')
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 83100, 83186);

                        int
                        indexOfLastForwardSlash = f_1067_83130_83185(f_1067_83130_83168(f_1067_83130_83158(_cmdletizationMetadata)), '/')
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 83208, 83291);

                        int
                        indexOfLastSeparator = f_1067_83235_83290(indexOfLastBackslash, indexOfLastForwardSlash)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 83313, 83535);

                        string
                        cimClassName = f_1067_83335_83534(f_1067_83335_83373(f_1067_83335_83363(_cmdletizationMetadata)), indexOfLastSeparator + 1, f_1067_83461_83506(f_1067_83461_83499(f_1067_83461_83489(_cmdletizationMetadata))) - indexOfLastSeparator - 1)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 83557, 83791);

                        psTypeNameOfInputObjectElements = f_1067_83591_83790(f_1067_83631_83659(), "{0}#{1}", f_1067_83722_83750(_objectInstanceType), cimClassName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 82854, 84152);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 82854, 84152);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 83873, 84133);

                        psTypeNameOfInputObjectElements = f_1067_83907_84132(f_1067_83947_83975(), "{0}#{1}", f_1067_84038_84066(_objectInstanceType), f_1067_84093_84131(f_1067_84093_84121(_cmdletizationMetadata)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 82854, 84152);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 84172, 84266);

                    f_1067_84172_84265(f_1067_84172_84203(inputObjectParameter), f_1067_84208_84264(psTypeNameOfInputObjectElements));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 84286, 84354);

                    f_1067_84286_84353(f_1067_84286_84317(inputObjectParameter), f_1067_84322_84352());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 84372, 84415);

                    f_1067_84372_84414(f_1067_84372_84406(inputObjectParameter));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 84433, 84617);

                    ParameterSetMetadata
                    inputObjectPSet = f_1067_84472_84616(int.MinValue, inputObjectFlags, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 84654, 84757);

                    f_1067_84654_84756(f_1067_84654_84688(inputObjectParameter), ScriptWriter.InputObjectQueryParameterSetName, inputObjectPSet);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 84775, 84844);

                    f_1067_84775_84843(queryParameters, f_1067_84795_84820(inputObjectParameter), inputObjectParameter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 82299, 84859);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 84875, 84894);

                f_1067_84875_84893(
                            output);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 84908, 84939);

                scriptCode = f_1067_84921_84938(output);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 76226, 84950);

                System.StringComparer
                f_1067_76679_76711()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 76679, 76711);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                f_1067_76637_76712(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 76637, 76712);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_76766_76794()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 76766, 76794);
                    return return_v;
                }


                System.IO.StringWriter
                f_1067_76749_76795(System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = new System.IO.StringWriter((System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 76749, 76795);
                    return return_v;
                }


                int
                f_1067_76812_76921(System.IO.StringWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 76812, 76921);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                f_1067_76980_77018(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata
                instanceCmdlet)
                {
                    var return_v = this_param.GetGetCmdletParameters(instanceCmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 76980, 77018);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.PropertyMetadata[]
                f_1067_77037_77076(Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                this_param)
                {
                    var return_v = this_param.QueryableProperties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 77037, 77076);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.PropertyMetadata[]
                f_1067_77156_77195(Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                this_param)
                {
                    var return_v = this_param.QueryableProperties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 77156, 77195);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.Xml.PropertyMetadata>
                f_1067_77156_77223(Microsoft.PowerShell.Cmdletization.Xml.PropertyMetadata[]
                source, System.Func<Microsoft.PowerShell.Cmdletization.Xml.PropertyMetadata, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.PowerShell.Cmdletization.Xml.PropertyMetadata>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 77156, 77223);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.PropertyQuery[]
                f_1067_77285_77299(Microsoft.PowerShell.Cmdletization.Xml.PropertyMetadata
                this_param)
                {
                    var return_v = this_param.Items;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 77285, 77299);
                    return return_v;
                }


                int
                f_1067_77285_77306(Microsoft.PowerShell.Cmdletization.Xml.PropertyQuery[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 77285, 77306);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ItemsChoiceType[]
                f_1067_77413_77438(Microsoft.PowerShell.Cmdletization.Xml.PropertyMetadata
                this_param)
                {
                    var return_v = this_param.ItemsElementName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 77413, 77438);
                    return return_v;
                }


                int
                f_1067_78240_78291(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 78240, 78291);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.PropertyQuery[]
                f_1067_78624_78638(Microsoft.PowerShell.Cmdletization.Xml.PropertyMetadata
                this_param)
                {
                    var return_v = this_param.Items;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 78624, 78638);
                    return return_v;
                }


                System.Management.Automation.ParameterMetadata
                f_1067_78490_78650(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, System.Collections.Generic.IEnumerable<string>
                commonParameterSets, System.Collections.Generic.IEnumerable<string>
                queryParameterSets, System.Collections.Generic.IEnumerable<string>
                methodParameterSets, string
                queryBuilderMethodName, Microsoft.PowerShell.Cmdletization.Xml.PropertyMetadata
                property, Microsoft.PowerShell.Cmdletization.Xml.PropertyQuery
                query, System.IO.StringWriter
                output)
                {
                    var return_v = this_param.GenerateQueryClause(commonParameterSets, queryParameterSets, methodParameterSets, queryBuilderMethodName, property, query, (System.IO.TextWriter)output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 78490, 78650);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ItemsChoiceType[]
                f_1067_78687_78712(Microsoft.PowerShell.Cmdletization.Xml.PropertyMetadata
                this_param)
                {
                    var return_v = this_param.ItemsElementName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 78687, 78712);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1067_78905_78933(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 78905, 78933);
                    return return_v;
                }


                System.Management.Automation.ValidateNotNullAttribute
                f_1067_78938_78968()
                {
                    var return_v = new System.Management.Automation.ValidateNotNullAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 78938, 78968);
                    return return_v;
                }


                int
                f_1067_78905_78969(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ValidateNotNullAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 78905, 78969);
                    return 0;
                }


                string
                f_1067_79272_79294(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 79272, 79294);
                    return return_v;
                }


                int
                f_1067_79252_79314(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                this_param, string
                key, System.Management.Automation.ParameterMetadata
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 79252, 79314);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1067_79517_79545()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 79517, 79545);
                    return return_v;
                }


                string
                f_1067_79642_79709()
                {
                    var return_v = CmdletizationCoreResources.ScriptWriter_DuplicateQueryParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 79642, 79709);
                    return return_v;
                }


                string
                f_1067_79802_79824(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 79802, 79824);
                    return return_v;
                }


                string
                f_1067_79469_79825(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 79469, 79825);
                    return return_v;
                }


                System.Xml.XmlException
                f_1067_79862_79890(string
                message, System.ArgumentException
                innerException)
                {
                    var return_v = new System.Xml.XmlException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 79862, 79890);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.Xml.PropertyMetadata>
                f_1067_77156_77223_I(System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.Xml.PropertyMetadata>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 77156, 77223);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.Association[]
                f_1067_79995_80036(Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                this_param)
                {
                    var return_v = this_param.QueryableAssociations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 79995, 80036);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.Association[]
                f_1067_80114_80155(Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                this_param)
                {
                    var return_v = this_param.QueryableAssociations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 80114, 80155);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.Xml.Association>
                f_1067_80114_80196(Microsoft.PowerShell.Cmdletization.Xml.Association[]
                source, System.Func<Microsoft.PowerShell.Cmdletization.Xml.Association, bool>
                predicate)
                {
                    var return_v = source.Where<Microsoft.PowerShell.Cmdletization.Xml.Association>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 80114, 80196);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.AssociationAssociatedInstance
                f_1067_80403_80433(Microsoft.PowerShell.Cmdletization.Xml.Association
                this_param)
                {
                    var return_v = this_param.AssociatedInstance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 80403, 80433);
                    return return_v;
                }


                System.Management.Automation.ParameterMetadata
                f_1067_80276_80442(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, System.Collections.Generic.IEnumerable<string>
                commonParameterSets, System.Collections.Generic.IEnumerable<string>
                queryParameterSets, System.Collections.Generic.IEnumerable<string>
                methodParameterSets, Microsoft.PowerShell.Cmdletization.Xml.Association
                associationMetadata, Microsoft.PowerShell.Cmdletization.Xml.AssociationAssociatedInstance
                associatedInstanceMetadata, System.IO.StringWriter
                output)
                {
                    var return_v = this_param.GenerateAssociationClause(commonParameterSets, queryParameterSets, methodParameterSets, associationMetadata, associatedInstanceMetadata, (System.IO.TextWriter)output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 80276, 80442);
                    return return_v;
                }


                string
                f_1067_80537_80559(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 80537, 80559);
                    return return_v;
                }


                int
                f_1067_80517_80579(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                this_param, string
                key, System.Management.Automation.ParameterMetadata
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 80517, 80579);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1067_80762_80790()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 80762, 80790);
                    return return_v;
                }


                string
                f_1067_80883_80950()
                {
                    var return_v = CmdletizationCoreResources.ScriptWriter_DuplicateQueryParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 80883, 80950);
                    return return_v;
                }


                string
                f_1067_81035_81057(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 81035, 81057);
                    return return_v;
                }


                string
                f_1067_80718_81058(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 80718, 81058);
                    return return_v;
                }


                System.Xml.XmlException
                f_1067_81091_81119(string
                message, System.ArgumentException
                innerException)
                {
                    var return_v = new System.Xml.XmlException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 81091, 81119);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.Xml.Association>
                f_1067_80114_80196_I(System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.Xml.Association>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 80114, 80196);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.QueryOption[]
                f_1067_81197_81229(Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                this_param)
                {
                    var return_v = this_param.QueryOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 81197, 81229);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.QueryOption[]
                f_1067_81307_81339(Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                this_param)
                {
                    var return_v = this_param.QueryOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 81307, 81339);
                    return return_v;
                }


                System.Management.Automation.ParameterMetadata
                f_1067_81419_81548(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, System.Collections.Generic.IEnumerable<string>
                commonParameterSets, System.Collections.Generic.IEnumerable<string>
                queryParameterSets, System.Collections.Generic.IEnumerable<string>
                methodParameterSets, Microsoft.PowerShell.Cmdletization.Xml.QueryOption
                queryOptionMetadata, System.IO.StringWriter
                output)
                {
                    var return_v = this_param.GenerateOptionClause(commonParameterSets, queryParameterSets, methodParameterSets, queryOptionMetadata, (System.IO.TextWriter)output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 81419, 81548);
                    return return_v;
                }


                string
                f_1067_81643_81665(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 81643, 81665);
                    return return_v;
                }


                int
                f_1067_81623_81685(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                this_param, string
                key, System.Management.Automation.ParameterMetadata
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 81623, 81685);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1067_81868_81896()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 81868, 81896);
                    return return_v;
                }


                string
                f_1067_81989_82056()
                {
                    var return_v = CmdletizationCoreResources.ScriptWriter_DuplicateQueryParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 81989, 82056);
                    return return_v;
                }


                string
                f_1067_82141_82163(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 82141, 82163);
                    return return_v;
                }


                string
                f_1067_81824_82164(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 81824, 82164);
                    return return_v;
                }


                System.Xml.XmlException
                f_1067_82197_82225(string
                message, System.ArgumentException
                innerException)
                {
                    var return_v = new System.Xml.XmlException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 82197, 82225);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.QueryOption[]
                f_1067_81307_81339_I(Microsoft.PowerShell.Cmdletization.Xml.QueryOption[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 81307, 81339);
                    return return_v;
                }


                System.Type
                f_1067_82437_82472(System.Type
                this_param)
                {
                    var return_v = this_param.MakeArrayType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 82437, 82472);
                    return return_v;
                }


                System.Management.Automation.ParameterMetadata
                f_1067_82400_82473(string
                name, System.Type
                parameterType)
                {
                    var return_v = new System.Management.Automation.ParameterMetadata(name, parameterType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 82400, 82473);
                    return return_v;
                }


                int
                f_1067_82625_82646(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 82625, 82646);
                    return return_v;
                }


                string
                f_1067_82858_82886(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 82858, 82886);
                    return return_v;
                }


                bool
                f_1067_82858_82952(string
                this_param, string
                value)
                {
                    var return_v = this_param.Equals(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 82858, 82952);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_83021_83049(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 83021, 83049);
                    return return_v;
                }


                string
                f_1067_83021_83059(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.ClassName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 83021, 83059);
                    return return_v;
                }


                int
                f_1067_83021_83077(string
                this_param, char
                value)
                {
                    var return_v = this_param.LastIndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 83021, 83077);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_83130_83158(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 83130, 83158);
                    return return_v;
                }


                string
                f_1067_83130_83168(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.ClassName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 83130, 83168);
                    return return_v;
                }


                int
                f_1067_83130_83185(string
                this_param, char
                value)
                {
                    var return_v = this_param.LastIndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 83130, 83185);
                    return return_v;
                }


                int
                f_1067_83235_83290(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 83235, 83290);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_83335_83363(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 83335, 83363);
                    return return_v;
                }


                string
                f_1067_83335_83373(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.ClassName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 83335, 83373);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_83461_83489(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 83461, 83489);
                    return return_v;
                }


                string
                f_1067_83461_83499(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.ClassName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 83461, 83499);
                    return return_v;
                }


                int
                f_1067_83461_83506(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 83461, 83506);
                    return return_v;
                }


                string
                f_1067_83335_83534(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 83335, 83534);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_83631_83659()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 83631, 83659);
                    return return_v;
                }


                string
                f_1067_83722_83750(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 83722, 83750);
                    return return_v;
                }


                string
                f_1067_83591_83790(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 83591, 83790);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_83947_83975()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 83947, 83975);
                    return return_v;
                }


                string
                f_1067_84038_84066(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 84038, 84066);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_84093_84121(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 84093, 84121);
                    return return_v;
                }


                string
                f_1067_84093_84131(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.ClassName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 84093, 84131);
                    return return_v;
                }


                string
                f_1067_83907_84132(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 83907, 84132);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1067_84172_84203(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 84172, 84203);
                    return return_v;
                }


                System.Management.Automation.PSTypeNameAttribute
                f_1067_84208_84264(string
                psTypeName)
                {
                    var return_v = new System.Management.Automation.PSTypeNameAttribute(psTypeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 84208, 84264);
                    return return_v;
                }


                int
                f_1067_84172_84265(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.PSTypeNameAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 84172, 84265);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1067_84286_84317(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 84286, 84317);
                    return return_v;
                }


                System.Management.Automation.ValidateNotNullAttribute
                f_1067_84322_84352()
                {
                    var return_v = new System.Management.Automation.ValidateNotNullAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 84322, 84352);
                    return return_v;
                }


                int
                f_1067_84286_84353(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ValidateNotNullAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 84286, 84353);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1067_84372_84406(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 84372, 84406);
                    return return_v;
                }


                int
                f_1067_84372_84414(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 84372, 84414);
                    return 0;
                }


                System.Management.Automation.ParameterSetMetadata
                f_1067_84472_84616(int
                position, System.Management.Automation.ParameterSetMetadata.ParameterFlags
                flags, string
                helpMessage)
                {
                    var return_v = new System.Management.Automation.ParameterSetMetadata(position, flags, helpMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 84472, 84616);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1067_84654_84688(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 84654, 84688);
                    return return_v;
                }


                int
                f_1067_84654_84756(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param, string
                key, System.Management.Automation.ParameterSetMetadata
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 84654, 84756);
                    return 0;
                }


                string
                f_1067_84795_84820(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 84795, 84820);
                    return return_v;
                }


                int
                f_1067_84775_84843(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                this_param, string
                key, System.Management.Automation.ParameterMetadata
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 84775, 84843);
                    return 0;
                }


                int
                f_1067_84875_84893(System.IO.StringWriter
                this_param)
                {
                    this_param.WriteLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 84875, 84893);
                    return 0;
                }


                string
                f_1067_84921_84938(System.IO.StringWriter
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 84921, 84938);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 76226, 84950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 76226, 84950);
            }
        }

        private const string
        CmdletBeginBlockTemplate = @"
function {0}
{{
    {1}
    {2}
    {3}

    param(
    {4})

    DynamicParam {{
        try
        {{
            if (-not $__cmdletization_exceptionHasBeenThrown)
            {{
                $__cmdletization_objectModelWrapper = $script:ObjectModelWrapper::new()
                $__cmdletization_objectModelWrapper.Initialize($PSCmdlet, $script:ClassName, $script:ClassVersion, $script:ModuleVersion, $script:PrivateData)

                if ($__cmdletization_objectModelWrapper -is [System.Management.Automation.IDynamicParameters])
                {{
                    ([System.Management.Automation.IDynamicParameters]$__cmdletization_objectModelWrapper).GetDynamicParameters()
                }}
            }}
        }}
        catch
        {{
            $__cmdletization_exceptionHasBeenThrown = $true
            throw
        }}
    }}

    Begin {{
        $__cmdletization_exceptionHasBeenThrown = $false
        try
        {{
            __cmdletization_BindCommonParameters $__cmdletization_objectModelWrapper $PSBoundParameters
            $__cmdletization_objectModelWrapper.BeginProcessing()
        }}
        catch
        {{
            $__cmdletization_exceptionHasBeenThrown = $true
            throw
        }}
    }}
        "
        ;

        private const string
        CmdletProcessBlockTemplate = @"
    Process {{
        try
        {{
            if (-not $__cmdletization_exceptionHasBeenThrown)
            {{
{0}
            }}
        }}
        catch
        {{
            $__cmdletization_exceptionHasBeenThrown = $true
            throw
        }}
    }}
        "
        ;

        private const string
        CmdletEndBlockTemplate = @"
    End {{
        try
        {{
            if (-not $__cmdletization_exceptionHasBeenThrown)
            {{
                $__cmdletization_objectModelWrapper.EndProcessing()
            }}
        }}
        catch
        {{
            throw
        }}
    }}

    {0}
}}
Microsoft.PowerShell.Core\Export-ModuleMember -Function '{1}' -Alias '*'
        "
        ;

        private string GetHelpDirectiveForExternalHelp()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 87183, 87707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 87256, 87299);

                StringBuilder
                output = f_1067_87279_87298()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 87315, 87655) || true) && (GenerationOptions.HelpXml == (_generationOptions & GenerationOptions.HelpXml))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 87315, 87655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 87430, 87640);

                    f_1067_87430_87639(output, f_1067_87472_87500(), "# .EXTERNALHELP {0}.cdxml-Help.xml", f_1067_87582_87638(_moduleName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 87315, 87655);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 87671, 87696);

                return f_1067_87678_87695(output);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 87183, 87707);

                System.Text.StringBuilder
                f_1067_87279_87298()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 87279, 87298);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_87472_87500()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 87472, 87500);
                    return return_v;
                }


                string
                f_1067_87582_87638(string
                name)
                {
                    var return_v = ScriptWriter.EscapeModuleNameForHelpComment(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 87582, 87638);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1067_87430_87639(System.Text.StringBuilder
                this_param, System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 87430, 87639);
                    return return_v;
                }


                string
                f_1067_87678_87695(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 87678, 87695);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 87183, 87707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 87183, 87707);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void WriteCmdlet(TextWriter output, StaticCmdletMetadata staticCmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 87719, 90469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 87822, 87901);

                string
                attributeString = f_1067_87847_87900(this, f_1067_87872_87899(staticCmdlet))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 87917, 88001);

                Dictionary<string, ParameterMetadata>
                commonParameters = f_1067_87974_88000(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 88015, 88091);

                List<string>
                commonParameterSets = f_1067_88050_88090(commonParameters)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 88105, 88258);

                f_1067_88105_88257(commonParameterSets != null && (DynAbs.Tracing.TraceSender.Expression_True(1067, 88116, 88178) && (f_1067_88148_88173(commonParameterSets) > 0)), "Verifying stuff returned by GetCommonParameterSets");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 88274, 88329);

                Dictionary<string, ParameterMetadata>
                methodParameters
                = default(Dictionary<string, ParameterMetadata>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 88343, 88373);

                string
                methodProcessingScript
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 88387, 88425);

                string
                outputTypeAttributeDeclaration
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 88439, 88595);

                f_1067_88439_88594(this, staticCmdlet, commonParameterSets, out methodProcessingScript, out methodParameters, out outputTypeAttributeDeclaration);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 88609, 88681);

                List<string>
                methodParameterSets = f_1067_88644_88680(this, staticCmdlet)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 88697, 88784);

                CommandMetadata
                commandMetadata = f_1067_88731_88783(this, f_1067_88755_88782(staticCmdlet))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 88798, 89098) || true) && (!f_1067_88803_88864(f_1067_88824_88863(commandMetadata)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 88798, 89098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 88898, 89083);

                    commandMetadata.DefaultParameterSetName = f_1067_88940_89082(f_1067_88954_88982(), StaticMethodParameterSetTemplate, f_1067_89018_89057(commandMetadata), f_1067_89059_89081(commonParameterSets, 0));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 88798, 89098);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 89114, 89209);

                f_1067_89114_89208(commonParameters, StaticCommonParameterSetTemplate, methodParameterSets);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 89223, 89318);

                f_1067_89223_89317(methodParameters, StaticMethodParameterSetTemplate, commonParameterSets);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 89332, 89402);

                f_1067_89332_89401(commonParameters, methodParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 89416, 89483);

                f_1067_89416_89482(this, commandMetadata, methodParameters, commonParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 89499, 89730);

                f_1067_89499_89729(f_1067_89528_89653(f_1067_89542_89562(commandMetadata), @"[\p{Ll}\p{Lu}\p{Lt}\p{Lo}\p{Lm}]{1,100}-[\p{Ll}\p{Lu}\p{Lt}\p{Lo}\p{Lm}\p{Nd}]{1,100}"), "Command name doesn't need escaping - validated via xsd");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 89744, 90103);

                f_1067_89744_90102(output, CmdletBeginBlockTemplate, f_1067_89830_89850(commandMetadata), f_1067_89877_89932(commandMetadata), attributeString, outputTypeAttributeDeclaration, f_1067_90058_90101(commandMetadata));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 90119, 90223);

                f_1067_90119_90222(
                            output, CmdletProcessBlockTemplate, methodProcessingScript);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 90239, 90458);

                f_1067_90239_90457(
                            output, CmdletEndBlockTemplate, f_1067_90323_90361(                /* 0 */ this), f_1067_90388_90456(f_1067_90435_90455(commandMetadata)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 87719, 90469);

                Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadataCmdletMetadata
                f_1067_87872_87899(Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadata
                this_param)
                {
                    var return_v = this_param.CmdletMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 87872, 87899);
                    return return_v;
                }


                string
                f_1067_87847_87900(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadataCmdletMetadata
                cmdletMetadata)
                {
                    var return_v = this_param.GetCmdletAttributes((Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata)cmdletMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 87847, 87900);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                f_1067_87974_88000(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param)
                {
                    var return_v = this_param.GetCommonParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 87974, 88000);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1067_88050_88090(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                commonParameters)
                {
                    var return_v = GetCommonParameterSets(commonParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 88050, 88090);
                    return return_v;
                }


                int
                f_1067_88148_88173(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 88148, 88173);
                    return return_v;
                }


                int
                f_1067_88105_88257(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 88105, 88257);
                    return 0;
                }


                int
                f_1067_88439_88594(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadata
                staticCmdlet, System.Collections.Generic.List<string>
                commonParameterSets, out string
                scriptCode, out System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                methodParameters, out string
                outputTypeAttributeDeclaration)
                {
                    this_param.GenerateMethodParametersProcessing(staticCmdlet, (System.Collections.Generic.IEnumerable<string>)commonParameterSets, out scriptCode, out methodParameters, out outputTypeAttributeDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 88439, 88594);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1067_88644_88680(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadata
                staticCmdlet)
                {
                    var return_v = this_param.GetMethodParameterSets(staticCmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 88644, 88680);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadataCmdletMetadata
                f_1067_88755_88782(Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadata
                this_param)
                {
                    var return_v = this_param.CmdletMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 88755, 88782);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1067_88731_88783(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadataCmdletMetadata
                cmdletMetadata)
                {
                    var return_v = this_param.GetCommandMetadata((Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata)cmdletMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 88731, 88783);
                    return return_v;
                }


                string
                f_1067_88824_88863(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.DefaultParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 88824, 88863);
                    return return_v;
                }


                bool
                f_1067_88803_88864(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 88803, 88864);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_88954_88982()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 88954, 88982);
                    return return_v;
                }


                string
                f_1067_89018_89057(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.DefaultParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 89018, 89057);
                    return return_v;
                }


                string
                f_1067_89059_89081(System.Collections.Generic.List<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 89059, 89081);
                    return return_v;
                }


                string
                f_1067_88940_89082(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 88940, 89082);
                    return return_v;
                }


                int
                f_1067_89114_89208(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                parameters, string
                parameterSetNameTemplate, params System.Collections.Generic.IEnumerable<string>[]
                otherParameterSets)
                {
                    MultiplyParameterSets(parameters, parameterSetNameTemplate, otherParameterSets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 89114, 89208);
                    return 0;
                }


                int
                f_1067_89223_89317(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                parameters, string
                parameterSetNameTemplate, params System.Collections.Generic.IEnumerable<string>[]
                otherParameterSets)
                {
                    MultiplyParameterSets(parameters, parameterSetNameTemplate, otherParameterSets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 89223, 89317);
                    return 0;
                }


                int
                f_1067_89332_89401(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                beforeParameters, System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                afterParameters)
                {
                    EnsureOrderOfPositionalParameters(beforeParameters, afterParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 89332, 89401);
                    return 0;
                }


                int
                f_1067_89416_89482(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, System.Management.Automation.CommandMetadata
                commandMetadata, params System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>[]
                allParameters)
                {
                    this_param.SetParameters(commandMetadata, allParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 89416, 89482);
                    return 0;
                }


                string
                f_1067_89542_89562(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 89542, 89562);
                    return return_v;
                }


                bool
                f_1067_89528_89653(string
                input, string
                pattern)
                {
                    var return_v = Regex.IsMatch(input, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 89528, 89653);
                    return return_v;
                }


                int
                f_1067_89499_89729(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 89499, 89729);
                    return 0;
                }


                string
                f_1067_89830_89850(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 89830, 89850);
                    return return_v;
                }


                string
                f_1067_89877_89932(System.Management.Automation.CommandMetadata
                commandMetadata)
                {
                    var return_v = ProxyCommand.GetCmdletBindingAttribute(commandMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 89877, 89932);
                    return return_v;
                }


                string
                f_1067_90058_90101(System.Management.Automation.CommandMetadata
                commandMetadata)
                {
                    var return_v = ProxyCommand.GetParamBlock(commandMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 90058, 90101);
                    return return_v;
                }


                int
                f_1067_89744_90102(System.IO.TextWriter
                this_param, string
                format, params object?[]
                arg)
                {
                    this_param.WriteLine(format, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 89744, 90102);
                    return 0;
                }


                int
                f_1067_90119_90222(System.IO.TextWriter
                this_param, string
                format, string
                arg0)
                {
                    this_param.WriteLine(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 90119, 90222);
                    return 0;
                }


                string
                f_1067_90323_90361(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param)
                {
                    var return_v = this_param.GetHelpDirectiveForExternalHelp();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 90323, 90361);
                    return return_v;
                }


                string
                f_1067_90435_90455(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 90435, 90455);
                    return return_v;
                }


                string
                f_1067_90388_90456(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 90388, 90456);
                    return return_v;
                }


                int
                f_1067_90239_90457(System.IO.TextWriter
                this_param, string
                format, string
                arg0, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 90239, 90457);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 87719, 90469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 87719, 90469);
            }
        }

        private static void AddPassThruParameter(IDictionary<string, ParameterMetadata> commonParameters, InstanceCmdletMetadata instanceCmdletMetadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1067, 90481, 92348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 90650, 90736);

                f_1067_90650_90735(commonParameters != null, "Caller should verify commonParameters != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 90750, 90848);

                f_1067_90750_90847(instanceCmdletMetadata != null, "Caller should verify instanceCmdletMetadata != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 90864, 90901);

                bool
                outParametersArePresent = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 90915, 91405) || true) && (f_1067_90919_90959(f_1067_90919_90948(instanceCmdletMetadata)) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 90915, 91405);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 91001, 91390);
                        foreach (InstanceMethodParameterMetadata parameter in f_1067_91055_91095_I(f_1067_91055_91095(f_1067_91055_91084(instanceCmdletMetadata))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 91001, 91390);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 91137, 91371) || true) && ((f_1067_91142_91172(parameter) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1067, 91141, 91235) && (f_1067_91186_91226(f_1067_91186_91216(parameter)) == null)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 91137, 91371);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 91285, 91316);

                                outParametersArePresent = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1067, 91342, 91348);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 91137, 91371);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 91001, 91390);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 390);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 390);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 90915, 91405);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 91421, 91798) || true) && (f_1067_91425_91466(f_1067_91425_91454(instanceCmdletMetadata)) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 91421, 91798);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 91508, 91783) || true) && ((f_1067_91513_91575(f_1067_91513_91554(f_1067_91513_91542(instanceCmdletMetadata))) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1067, 91512, 91691) && (f_1067_91610_91682(f_1067_91610_91672(f_1067_91610_91651(f_1067_91610_91639(instanceCmdletMetadata)))) == null)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 91508, 91783);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 91733, 91764);

                        outParametersArePresent = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 91508, 91783);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 91421, 91798);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 91814, 92337) || true) && (!outParametersArePresent)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 91814, 92337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 91876, 91973);

                    ParameterMetadata
                    passThruParameter = f_1067_91914_91972("PassThru", typeof(SwitchParameter))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 91991, 92031);

                    f_1067_91991_92030(f_1067_91991_92022(passThruParameter));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 92049, 92133);

                    ParameterSetMetadata
                    passThruPSet = f_1067_92085_92132(int.MinValue, 0, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 92151, 92238);

                    f_1067_92151_92237(f_1067_92151_92182(passThruParameter), ParameterAttribute.AllParameterSets, passThruPSet);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 92258, 92322);

                    f_1067_92258_92321(
                                    commonParameters, f_1067_92279_92301(passThruParameter), passThruParameter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 91814, 92337);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1067, 90481, 92348);

                int
                f_1067_90650_90735(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 90650, 90735);
                    return 0;
                }


                int
                f_1067_90750_90847(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 90750, 90847);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodMetadata
                f_1067_90919_90948(Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 90919, 90948);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodParameterMetadata[]
                f_1067_90919_90959(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodMetadata
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 90919, 90959);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodMetadata
                f_1067_91055_91084(Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 91055, 91084);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodParameterMetadata[]
                f_1067_91055_91095(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodMetadata
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 91055, 91095);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletOutputMetadata
                f_1067_91142_91172(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.CmdletOutputMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 91142, 91172);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletOutputMetadata
                f_1067_91186_91216(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodParameterMetadata
                this_param)
                {
                    var return_v = this_param.CmdletOutputMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 91186, 91216);
                    return return_v;
                }


                object
                f_1067_91186_91226(Microsoft.PowerShell.Cmdletization.Xml.CmdletOutputMetadata
                this_param)
                {
                    var return_v = this_param.ErrorCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 91186, 91226);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodParameterMetadata[]
                f_1067_91055_91095_I(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodParameterMetadata[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 91055, 91095);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodMetadata
                f_1067_91425_91454(Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 91425, 91454);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                f_1067_91425_91466(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodMetadata
                this_param)
                {
                    var return_v = this_param.ReturnValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 91425, 91466);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodMetadata
                f_1067_91513_91542(Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 91513, 91542);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                f_1067_91513_91554(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodMetadata
                this_param)
                {
                    var return_v = this_param.ReturnValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 91513, 91554);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletOutputMetadata
                f_1067_91513_91575(Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                this_param)
                {
                    var return_v = this_param.CmdletOutputMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 91513, 91575);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodMetadata
                f_1067_91610_91639(Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 91610, 91639);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                f_1067_91610_91651(Microsoft.PowerShell.Cmdletization.Xml.InstanceMethodMetadata
                this_param)
                {
                    var return_v = this_param.ReturnValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 91610, 91651);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CmdletOutputMetadata
                f_1067_91610_91672(Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadataReturnValue
                this_param)
                {
                    var return_v = this_param.CmdletOutputMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 91610, 91672);
                    return return_v;
                }


                object
                f_1067_91610_91682(Microsoft.PowerShell.Cmdletization.Xml.CmdletOutputMetadata
                this_param)
                {
                    var return_v = this_param.ErrorCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 91610, 91682);
                    return return_v;
                }


                System.Management.Automation.ParameterMetadata
                f_1067_91914_91972(string
                name, System.Type
                parameterType)
                {
                    var return_v = new System.Management.Automation.ParameterMetadata(name, parameterType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 91914, 91972);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1067_91991_92022(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 91991, 92022);
                    return return_v;
                }


                int
                f_1067_91991_92030(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 91991, 92030);
                    return 0;
                }


                System.Management.Automation.ParameterSetMetadata
                f_1067_92085_92132(int
                position, int
                flags, string
                helpMessage)
                {
                    var return_v = new System.Management.Automation.ParameterSetMetadata(position, (System.Management.Automation.ParameterSetMetadata.ParameterFlags)flags, helpMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 92085, 92132);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1067_92151_92182(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 92151, 92182);
                    return return_v;
                }


                int
                f_1067_92151_92237(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param, string
                key, System.Management.Automation.ParameterSetMetadata
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 92151, 92237);
                    return 0;
                }


                string
                f_1067_92279_92301(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 92279, 92301);
                    return return_v;
                }


                int
                f_1067_92258_92321(System.Collections.Generic.IDictionary<string, System.Management.Automation.ParameterMetadata>
                this_param, string
                key, System.Management.Automation.ParameterMetadata
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 92258, 92321);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 90481, 92348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 90481, 92348);
            }
        }

        private void WriteCmdlet(TextWriter output, InstanceCmdletMetadata instanceCmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 92360, 95903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 92467, 92548);

                string
                attributeString = f_1067_92492_92547(this, f_1067_92517_92546(instanceCmdlet))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 92564, 92648);

                Dictionary<string, ParameterMetadata>
                commonParameters = f_1067_92621_92647(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 92662, 92738);

                List<string>
                commonParameterSets = f_1067_92697_92737(commonParameters)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 92752, 92826);

                List<string>
                methodParameterSets = f_1067_92787_92825(this, instanceCmdlet)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 92840, 92912);

                List<string>
                queryParameterSets = f_1067_92874_92911(this, instanceCmdlet)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 92928, 92982);

                Dictionary<string, ParameterMetadata>
                queryParameters
                = default(Dictionary<string, ParameterMetadata>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 92996, 93025);

                string
                queryProcessingScript
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 93039, 93199);

                f_1067_93039_93198(this, instanceCmdlet, commonParameterSets, queryParameterSets, methodParameterSets, out queryProcessingScript, out queryParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 93215, 93270);

                Dictionary<string, ParameterMetadata>
                methodParameters
                = default(Dictionary<string, ParameterMetadata>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 93284, 93314);

                string
                methodProcessingScript
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 93328, 93366);

                string
                outputTypeAttributeDeclaration
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 93380, 93558);

                f_1067_93380_93557(this, instanceCmdlet, commonParameterSets, queryParameterSets, out methodProcessingScript, out methodParameters, out outputTypeAttributeDeclaration);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 93574, 93663);

                CommandMetadata
                commandMetadata = f_1067_93608_93662(this, f_1067_93632_93661(instanceCmdlet))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 93677, 93763);

                GetCmdletParameters
                getCmdletParameters = f_1067_93719_93762(this, instanceCmdlet)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 93777, 94157) || true) && (!f_1067_93782_93849(f_1067_93803_93848(getCmdletParameters)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 93777, 94157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 93883, 93971);

                    commandMetadata.DefaultParameterSetName = f_1067_93925_93970(getCmdletParameters);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 93777, 94157);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 93777, 94157);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 94005, 94157) || true) && (f_1067_94009_94033(queryParameterSets) == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 94005, 94157);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 94072, 94142);

                        commandMetadata.DefaultParameterSetName = f_1067_94114_94141(queryParameterSets);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 94005, 94157);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 93777, 94157);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 94173, 94228);

                f_1067_94173_94227(commonParameters, instanceCmdlet);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 94242, 94359);

                f_1067_94242_94358(commonParameters, InstanceCommonParameterSetTemplate, queryParameterSets, methodParameterSets);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 94373, 94489);

                f_1067_94373_94488(queryParameters, InstanceQueryParameterSetTemplate, commonParameterSets, methodParameterSets);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 94503, 94620);

                f_1067_94503_94619(methodParameters, InstanceMethodParameterSetTemplate, commonParameterSets, queryParameterSets);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 94634, 94703);

                f_1067_94634_94702(commonParameters, queryParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 94717, 94786);

                f_1067_94717_94785(queryParameters, methodParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 94800, 94884);

                f_1067_94800_94883(this, commandMetadata, queryParameters, methodParameters, commonParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 94900, 95131);

                f_1067_94900_95130(f_1067_94929_95054(f_1067_94943_94963(commandMetadata), @"[\p{Ll}\p{Lu}\p{Lt}\p{Lo}\p{Lm}]{1,100}-[\p{Ll}\p{Lu}\p{Lt}\p{Lo}\p{Lm}\p{Nd}]{1,100}"), "Command name doesn't need escaping - validated via xsd");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 95145, 95504);

                f_1067_95145_95503(output, CmdletBeginBlockTemplate, f_1067_95231_95251(commandMetadata), f_1067_95278_95333(commandMetadata), attributeString, outputTypeAttributeDeclaration, f_1067_95459_95502(commandMetadata));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 95520, 95657);

                f_1067_95520_95656(
                            output, CmdletProcessBlockTemplate, queryProcessingScript + "\r\n" + methodProcessingScript);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 95673, 95892);

                f_1067_95673_95891(
                            output, CmdletEndBlockTemplate, f_1067_95757_95795(                /* 0 */ this), f_1067_95822_95890(f_1067_95869_95889(commandMetadata)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 92360, 95903);

                Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                f_1067_92517_92546(Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata
                this_param)
                {
                    var return_v = this_param.CmdletMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 92517, 92546);
                    return return_v;
                }


                string
                f_1067_92492_92547(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                cmdletMetadata)
                {
                    var return_v = this_param.GetCmdletAttributes(cmdletMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 92492, 92547);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                f_1067_92621_92647(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param)
                {
                    var return_v = this_param.GetCommonParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 92621, 92647);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1067_92697_92737(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                commonParameters)
                {
                    var return_v = GetCommonParameterSets(commonParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 92697, 92737);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1067_92787_92825(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata
                instanceCmdlet)
                {
                    var return_v = this_param.GetMethodParameterSets(instanceCmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 92787, 92825);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1067_92874_92911(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata
                instanceCmdlet)
                {
                    var return_v = this_param.GetQueryParameterSets(instanceCmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 92874, 92911);
                    return return_v;
                }


                int
                f_1067_93039_93198(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata
                instanceCmdlet, System.Collections.Generic.List<string>
                commonParameterSets, System.Collections.Generic.List<string>
                queryParameterSets, System.Collections.Generic.List<string>
                methodParameterSets, out string
                scriptCode, out System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                queryParameters)
                {
                    this_param.GenerateQueryParametersProcessing(instanceCmdlet, (System.Collections.Generic.IEnumerable<string>)commonParameterSets, (System.Collections.Generic.IEnumerable<string>)queryParameterSets, (System.Collections.Generic.IEnumerable<string>)methodParameterSets, out scriptCode, out queryParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 93039, 93198);
                    return 0;
                }


                int
                f_1067_93380_93557(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata
                instanceCmdlet, System.Collections.Generic.List<string>
                commonParameterSets, System.Collections.Generic.List<string>
                queryParameterSets, out string
                scriptCode, out System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                methodParameters, out string
                outputTypeAttributeDeclaration)
                {
                    this_param.GenerateMethodParametersProcessing(instanceCmdlet, (System.Collections.Generic.IEnumerable<string>)commonParameterSets, (System.Collections.Generic.IEnumerable<string>)queryParameterSets, out scriptCode, out methodParameters, out outputTypeAttributeDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 93380, 93557);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                f_1067_93632_93661(Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata
                this_param)
                {
                    var return_v = this_param.CmdletMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 93632, 93661);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1067_93608_93662(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                cmdletMetadata)
                {
                    var return_v = this_param.GetCommandMetadata(cmdletMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 93608, 93662);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                f_1067_93719_93762(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata
                instanceCmdlet)
                {
                    var return_v = this_param.GetGetCmdletParameters(instanceCmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 93719, 93762);
                    return return_v;
                }


                string
                f_1067_93803_93848(Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                this_param)
                {
                    var return_v = this_param.DefaultCmdletParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 93803, 93848);
                    return return_v;
                }


                bool
                f_1067_93782_93849(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 93782, 93849);
                    return return_v;
                }


                string
                f_1067_93925_93970(Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                this_param)
                {
                    var return_v = this_param.DefaultCmdletParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 93925, 93970);
                    return return_v;
                }


                int
                f_1067_94009_94033(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 94009, 94033);
                    return return_v;
                }


                string
                f_1067_94114_94141(System.Collections.Generic.List<string>
                source)
                {
                    var return_v = source.Single<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 94114, 94141);
                    return return_v;
                }


                int
                f_1067_94173_94227(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                commonParameters, Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata
                instanceCmdletMetadata)
                {
                    AddPassThruParameter((System.Collections.Generic.IDictionary<string, System.Management.Automation.ParameterMetadata>)commonParameters, instanceCmdletMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 94173, 94227);
                    return 0;
                }


                int
                f_1067_94242_94358(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                parameters, string
                parameterSetNameTemplate, params System.Collections.Generic.IEnumerable<string>[]
                otherParameterSets)
                {
                    MultiplyParameterSets(parameters, parameterSetNameTemplate, otherParameterSets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 94242, 94358);
                    return 0;
                }


                int
                f_1067_94373_94488(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                parameters, string
                parameterSetNameTemplate, params System.Collections.Generic.IEnumerable<string>[]
                otherParameterSets)
                {
                    MultiplyParameterSets(parameters, parameterSetNameTemplate, otherParameterSets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 94373, 94488);
                    return 0;
                }


                int
                f_1067_94503_94619(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                parameters, string
                parameterSetNameTemplate, params System.Collections.Generic.IEnumerable<string>[]
                otherParameterSets)
                {
                    MultiplyParameterSets(parameters, parameterSetNameTemplate, otherParameterSets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 94503, 94619);
                    return 0;
                }


                int
                f_1067_94634_94702(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                beforeParameters, System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                afterParameters)
                {
                    EnsureOrderOfPositionalParameters(beforeParameters, afterParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 94634, 94702);
                    return 0;
                }


                int
                f_1067_94717_94785(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                beforeParameters, System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                afterParameters)
                {
                    EnsureOrderOfPositionalParameters(beforeParameters, afterParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 94717, 94785);
                    return 0;
                }


                int
                f_1067_94800_94883(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, System.Management.Automation.CommandMetadata
                commandMetadata, params System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>[]
                allParameters)
                {
                    this_param.SetParameters(commandMetadata, allParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 94800, 94883);
                    return 0;
                }


                string
                f_1067_94943_94963(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 94943, 94963);
                    return return_v;
                }


                bool
                f_1067_94929_95054(string
                input, string
                pattern)
                {
                    var return_v = Regex.IsMatch(input, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 94929, 95054);
                    return return_v;
                }


                int
                f_1067_94900_95130(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 94900, 95130);
                    return 0;
                }


                string
                f_1067_95231_95251(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 95231, 95251);
                    return return_v;
                }


                string
                f_1067_95278_95333(System.Management.Automation.CommandMetadata
                commandMetadata)
                {
                    var return_v = ProxyCommand.GetCmdletBindingAttribute(commandMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 95278, 95333);
                    return return_v;
                }


                string
                f_1067_95459_95502(System.Management.Automation.CommandMetadata
                commandMetadata)
                {
                    var return_v = ProxyCommand.GetParamBlock(commandMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 95459, 95502);
                    return return_v;
                }


                int
                f_1067_95145_95503(System.IO.TextWriter
                this_param, string
                format, params object?[]
                arg)
                {
                    this_param.WriteLine(format, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 95145, 95503);
                    return 0;
                }


                int
                f_1067_95520_95656(System.IO.TextWriter
                this_param, string
                format, string
                arg0)
                {
                    this_param.WriteLine(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 95520, 95656);
                    return 0;
                }


                string
                f_1067_95757_95795(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param)
                {
                    var return_v = this_param.GetHelpDirectiveForExternalHelp();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 95757, 95795);
                    return return_v;
                }


                string
                f_1067_95869_95889(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 95869, 95889);
                    return return_v;
                }


                string
                f_1067_95822_95890(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 95822, 95890);
                    return return_v;
                }


                int
                f_1067_95673_95891(System.IO.TextWriter
                this_param, string
                format, string
                arg0, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 95673, 95891);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 92360, 95903);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 92360, 95903);
            }
        }

        private string GetOutputAttributeForGetCmdlet()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 95915, 96691);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 95987, 96030);

                StringBuilder
                result = f_1067_96010_96029()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 96044, 96247);

                f_1067_96044_96246(result, f_1067_96082_96110(), "[OutputType([{0}])]", f_1067_96169_96245(f_1067_96216_96244(_objectInstanceType)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 96261, 96281);

                f_1067_96261_96280(result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 96295, 96607);

                f_1067_96295_96606(result, f_1067_96333_96361(), "[OutputType('{0}#{1}')]", f_1067_96424_96500(f_1067_96471_96499(_objectInstanceType)), f_1067_96519_96605(f_1067_96566_96604(f_1067_96566_96594(_cmdletizationMetadata))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 96621, 96641);

                f_1067_96621_96640(result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 96655, 96680);

                return f_1067_96662_96679(result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 95915, 96691);

                System.Text.StringBuilder
                f_1067_96010_96029()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 96010, 96029);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_96082_96110()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 96082, 96110);
                    return return_v;
                }


                string
                f_1067_96216_96244(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 96216, 96244);
                    return return_v;
                }


                string
                f_1067_96169_96245(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 96169, 96245);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1067_96044_96246(System.Text.StringBuilder
                this_param, System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 96044, 96246);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1067_96261_96280(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 96261, 96280);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_96333_96361()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 96333, 96361);
                    return return_v;
                }


                string
                f_1067_96471_96499(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 96471, 96499);
                    return return_v;
                }


                string
                f_1067_96424_96500(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 96424, 96500);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_96566_96594(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 96566, 96594);
                    return return_v;
                }


                string
                f_1067_96566_96604(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.ClassName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 96566, 96604);
                    return return_v;
                }


                string
                f_1067_96519_96605(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 96519, 96605);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1067_96295_96606(System.Text.StringBuilder
                this_param, System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = this_param.AppendFormat((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 96295, 96606);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1067_96621_96640(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.AppendLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 96621, 96640);
                    return return_v;
                }


                string
                f_1067_96662_96679(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 96662, 96679);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 95915, 96691);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 95915, 96691);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CommonCmdletMetadata GetGetCmdletMetadata()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 96703, 97576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 96779, 96897);

                f_1067_96779_96896(f_1067_96790_96834(f_1067_96790_96818(_cmdletizationMetadata)) != null, "Caller should verify presence of instance cmdlets");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 96911, 96947);

                CommonCmdletMetadata
                cmdletMetadata
                = default(CommonCmdletMetadata);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 96961, 97410) || true) && (f_1067_96965_97019(f_1067_96965_97009(f_1067_96965_96993(_cmdletizationMetadata))) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 96961, 97410);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 97061, 97148);

                    cmdletMetadata = f_1067_97078_97147(f_1067_97078_97132(f_1067_97078_97122(f_1067_97078_97106(_cmdletizationMetadata))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 96961, 97410);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 96961, 97410);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 97214, 97258);

                    cmdletMetadata = f_1067_97231_97257();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 97276, 97339);

                    cmdletMetadata.Noun = f_1067_97298_97338(f_1067_97298_97326(_cmdletizationMetadata));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 97357, 97395);

                    cmdletMetadata.Verb = VerbsCommon.Get;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 96961, 97410);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 97426, 97529);

                f_1067_97426_97528(cmdletMetadata != null, "xsd should ensure that cmdlet metadata element is always present");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 97543, 97565);

                return cmdletMetadata;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 96703, 97576);

                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_96790_96818(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 96790, 96818);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataInstanceCmdlets
                f_1067_96790_96834(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.InstanceCmdlets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 96790, 96834);
                    return return_v;
                }


                int
                f_1067_96779_96896(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 96779, 96896);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_96965_96993(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 96965, 96993);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataInstanceCmdlets
                f_1067_96965_97009(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.InstanceCmdlets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 96965, 97009);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.GetCmdletMetadata
                f_1067_96965_97019(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataInstanceCmdlets
                this_param)
                {
                    var return_v = this_param.GetCmdlet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 96965, 97019);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_97078_97106(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 97078, 97106);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataInstanceCmdlets
                f_1067_97078_97122(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.InstanceCmdlets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 97078, 97122);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.GetCmdletMetadata
                f_1067_97078_97132(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataInstanceCmdlets
                this_param)
                {
                    var return_v = this_param.GetCmdlet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 97078, 97132);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                f_1067_97078_97147(Microsoft.PowerShell.Cmdletization.Xml.GetCmdletMetadata
                this_param)
                {
                    var return_v = this_param.CmdletMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 97078, 97147);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                f_1067_97231_97257()
                {
                    var return_v = new Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 97231, 97257);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_97298_97326(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 97298, 97326);
                    return return_v;
                }


                string
                f_1067_97298_97338(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.DefaultNoun;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 97298, 97338);
                    return return_v;
                }


                int
                f_1067_97426_97528(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 97426, 97528);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 96703, 97576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 96703, 97576);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void WriteGetCmdlet(TextWriter output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 97588, 100504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 97659, 97743);

                Dictionary<string, ParameterMetadata>
                commonParameters = f_1067_97716_97742(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 97757, 97833);

                List<string>
                commonParameterSets = f_1067_97792_97832(commonParameters)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 97847, 97901);

                List<string>
                methodParameterSets = f_1067_97882_97900()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 97915, 97953);

                f_1067_97915_97952(methodParameterSets, string.Empty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 97967, 98029);

                List<string>
                queryParameterSets = f_1067_98001_98028(this, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 98045, 98099);

                Dictionary<string, ParameterMetadata>
                queryParameters
                = default(Dictionary<string, ParameterMetadata>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 98113, 98142);

                string
                queryProcessingScript
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 98156, 98306);

                f_1067_98156_98305(this, null, commonParameterSets, queryParameterSets, methodParameterSets, out queryProcessingScript, out queryParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 98322, 98388);

                CommonCmdletMetadata
                cmdletMetadata = f_1067_98360_98387(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 98402, 98505);

                f_1067_98402_98504(cmdletMetadata != null, "xsd should ensure that cmdlet metadata element is always present");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 98519, 98593);

                CommandMetadata
                commandMetadata = f_1067_98553_98592(this, cmdletMetadata)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 98607, 98673);

                string
                attributeString = f_1067_98632_98672(this, cmdletMetadata)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 98689, 98765);

                GetCmdletParameters
                getCmdletParameters = f_1067_98731_98764(this, null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 98779, 98988) || true) && (!f_1067_98784_98851(f_1067_98805_98850(getCmdletParameters)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 98779, 98988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 98885, 98973);

                    commandMetadata.DefaultParameterSetName = f_1067_98927_98972(getCmdletParameters);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 98779, 98988);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 99004, 99121);

                f_1067_99004_99120(commonParameters, InstanceCommonParameterSetTemplate, queryParameterSets, methodParameterSets);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 99135, 99251);

                f_1067_99135_99250(queryParameters, InstanceQueryParameterSetTemplate, commonParameterSets, methodParameterSets);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 99265, 99334);

                f_1067_99265_99333(commonParameters, queryParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 99348, 99414);

                f_1067_99348_99413(this, commandMetadata, queryParameters, commonParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 99430, 99661);

                f_1067_99430_99660(f_1067_99459_99584(f_1067_99473_99493(commandMetadata), @"[\p{Ll}\p{Lu}\p{Lt}\p{Lo}\p{Lm}]{1,100}-[\p{Ll}\p{Lu}\p{Lt}\p{Lo}\p{Lm}\p{Nd}]{1,100}"), "Command name doesn't need escaping - validated via xsd");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 99675, 100041);

                f_1067_99675_100040(output, CmdletBeginBlockTemplate, f_1067_99761_99781(commandMetadata), f_1067_99808_99863(commandMetadata), attributeString, f_1067_99932_99969(                /* 3 */ this), f_1067_99996_100039(commandMetadata));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 100057, 100258);

                f_1067_100057_100257(
                            output, CmdletProcessBlockTemplate, queryProcessingScript + "\r\n" + "    $__cmdletization_objectModelWrapper.ProcessRecord($__cmdletization_queryBuilder)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 100274, 100493);

                f_1067_100274_100492(
                            output, CmdletEndBlockTemplate, f_1067_100358_100396(                /* 0 */ this), f_1067_100423_100491(f_1067_100470_100490(commandMetadata)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 97588, 100504);

                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                f_1067_97716_97742(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param)
                {
                    var return_v = this_param.GetCommonParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 97716, 97742);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1067_97792_97832(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                commonParameters)
                {
                    var return_v = GetCommonParameterSets(commonParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 97792, 97832);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1067_97882_97900()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 97882, 97900);
                    return return_v;
                }


                int
                f_1067_97915_97952(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 97915, 97952);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1067_98001_98028(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata
                instanceCmdlet)
                {
                    var return_v = this_param.GetQueryParameterSets(instanceCmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 98001, 98028);
                    return return_v;
                }


                int
                f_1067_98156_98305(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata
                instanceCmdlet, System.Collections.Generic.List<string>
                commonParameterSets, System.Collections.Generic.List<string>
                queryParameterSets, System.Collections.Generic.List<string>
                methodParameterSets, out string
                scriptCode, out System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                queryParameters)
                {
                    this_param.GenerateQueryParametersProcessing(instanceCmdlet, (System.Collections.Generic.IEnumerable<string>)commonParameterSets, (System.Collections.Generic.IEnumerable<string>)queryParameterSets, (System.Collections.Generic.IEnumerable<string>)methodParameterSets, out scriptCode, out queryParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 98156, 98305);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                f_1067_98360_98387(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param)
                {
                    var return_v = this_param.GetGetCmdletMetadata();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 98360, 98387);
                    return return_v;
                }


                int
                f_1067_98402_98504(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 98402, 98504);
                    return 0;
                }


                System.Management.Automation.CommandMetadata
                f_1067_98553_98592(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                cmdletMetadata)
                {
                    var return_v = this_param.GetCommandMetadata(cmdletMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 98553, 98592);
                    return return_v;
                }


                string
                f_1067_98632_98672(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                cmdletMetadata)
                {
                    var return_v = this_param.GetCmdletAttributes(cmdletMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 98632, 98672);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                f_1067_98731_98764(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata
                instanceCmdlet)
                {
                    var return_v = this_param.GetGetCmdletParameters(instanceCmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 98731, 98764);
                    return return_v;
                }


                string
                f_1067_98805_98850(Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                this_param)
                {
                    var return_v = this_param.DefaultCmdletParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 98805, 98850);
                    return return_v;
                }


                bool
                f_1067_98784_98851(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 98784, 98851);
                    return return_v;
                }


                string
                f_1067_98927_98972(Microsoft.PowerShell.Cmdletization.Xml.GetCmdletParameters
                this_param)
                {
                    var return_v = this_param.DefaultCmdletParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 98927, 98972);
                    return return_v;
                }


                int
                f_1067_99004_99120(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                parameters, string
                parameterSetNameTemplate, params System.Collections.Generic.IEnumerable<string>[]
                otherParameterSets)
                {
                    MultiplyParameterSets(parameters, parameterSetNameTemplate, otherParameterSets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 99004, 99120);
                    return 0;
                }


                int
                f_1067_99135_99250(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                parameters, string
                parameterSetNameTemplate, params System.Collections.Generic.IEnumerable<string>[]
                otherParameterSets)
                {
                    MultiplyParameterSets(parameters, parameterSetNameTemplate, otherParameterSets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 99135, 99250);
                    return 0;
                }


                int
                f_1067_99265_99333(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                beforeParameters, System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                afterParameters)
                {
                    EnsureOrderOfPositionalParameters(beforeParameters, afterParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 99265, 99333);
                    return 0;
                }


                int
                f_1067_99348_99413(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, System.Management.Automation.CommandMetadata
                commandMetadata, params System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>[]
                allParameters)
                {
                    this_param.SetParameters(commandMetadata, allParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 99348, 99413);
                    return 0;
                }


                string
                f_1067_99473_99493(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 99473, 99493);
                    return return_v;
                }


                bool
                f_1067_99459_99584(string
                input, string
                pattern)
                {
                    var return_v = Regex.IsMatch(input, pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 99459, 99584);
                    return return_v;
                }


                int
                f_1067_99430_99660(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 99430, 99660);
                    return 0;
                }


                string
                f_1067_99761_99781(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 99761, 99781);
                    return return_v;
                }


                string
                f_1067_99808_99863(System.Management.Automation.CommandMetadata
                commandMetadata)
                {
                    var return_v = ProxyCommand.GetCmdletBindingAttribute(commandMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 99808, 99863);
                    return return_v;
                }


                string
                f_1067_99932_99969(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param)
                {
                    var return_v = this_param.GetOutputAttributeForGetCmdlet();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 99932, 99969);
                    return return_v;
                }


                string
                f_1067_99996_100039(System.Management.Automation.CommandMetadata
                commandMetadata)
                {
                    var return_v = ProxyCommand.GetParamBlock(commandMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 99996, 100039);
                    return return_v;
                }


                int
                f_1067_99675_100040(System.IO.TextWriter
                this_param, string
                format, params object?[]
                arg)
                {
                    this_param.WriteLine(format, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 99675, 100040);
                    return 0;
                }


                int
                f_1067_100057_100257(System.IO.TextWriter
                this_param, string
                format, string
                arg0)
                {
                    this_param.WriteLine(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 100057, 100257);
                    return 0;
                }


                string
                f_1067_100358_100396(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param)
                {
                    var return_v = this_param.GetHelpDirectiveForExternalHelp();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 100358, 100396);
                    return return_v;
                }


                string
                f_1067_100470_100490(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 100470, 100490);
                    return return_v;
                }


                string
                f_1067_100423_100491(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 100423, 100491);
                    return return_v;
                }


                int
                f_1067_100274_100492(System.IO.TextWriter
                this_param, string
                format, string
                arg0, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 100274, 100492);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 97588, 100504);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 97588, 100504);
            }
        }

        private static object s_enumCompilationLock;

        private static void CompileEnum(EnumMetadataEnum enumMetadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1067, 100585, 101537);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 100708, 100771);

                    string
                    enumFullName = f_1067_100730_100770(enumMetadata)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 100797, 100818);

                    lock (s_enumCompilationLock)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 100860, 100885);

                        Type
                        alreadyExistingType
                        = default(Type);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 100907, 101118) || true) && (!f_1067_100912_101012(enumFullName, f_1067_100958_100986(), out alreadyExistingType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 100907, 101118);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 101062, 101095);

                            f_1067_101062_101094(enumMetadata);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 100907, 101118);
                        }
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1067, 101166, 101526);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 101218, 101453);

                    var
                    errorMessage = f_1067_101237_101452(f_1067_101273_101301(), f_1067_101324_101375(), f_1067_101398_101419(enumMetadata), f_1067_101442_101451(e))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 101471, 101511);

                    throw f_1067_101477_101510(errorMessage, e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1067, 101166, 101526);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1067, 100585, 101537);

                string
                f_1067_100730_100770(Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum
                enumMetadata)
                {
                    var return_v = EnumWriter.GetEnumFullName(enumMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 100730, 100770);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1067_100958_100986()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 100958, 100986);
                    return return_v;
                }


                bool
                f_1067_100912_101012(string
                valueToConvert, System.Globalization.CultureInfo
                formatProvider, out System.Type
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo((object)valueToConvert, (System.IFormatProvider)formatProvider, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 100912, 101012);
                    return return_v;
                }


                int
                f_1067_101062_101094(Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum
                enumMetadata)
                {
                    EnumWriter.Compile(enumMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 101062, 101094);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1067_101273_101301()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 101273, 101301);
                    return return_v;
                }


                string
                f_1067_101324_101375()
                {
                    var return_v = CmdletizationCoreResources.ScriptWriter_InvalidEnum;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 101324, 101375);
                    return return_v;
                }


                string
                f_1067_101398_101419(Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum
                this_param)
                {
                    var return_v = this_param.EnumName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 101398, 101419);
                    return return_v;
                }


                string
                f_1067_101442_101451(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 101442, 101451);
                    return return_v;
                }


                string
                f_1067_101237_101452(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 101237, 101452);
                    return return_v;
                }


                System.Xml.XmlException
                f_1067_101477_101510(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.Xml.XmlException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 101477, 101510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 100585, 101537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 100585, 101537);
            }
        }

        internal void WriteScriptModule(TextWriter output)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 101549, 102804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 101624, 101657);

                f_1067_101624_101656(this, output);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 101671, 101718);

                f_1067_101671_101717(this, output);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 101734, 101980) || true) && (f_1067_101738_101766(_cmdletizationMetadata) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 101734, 101980);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 101808, 101965);
                        foreach (EnumMetadataEnum enumMetadata in f_1067_101850_101878_I(f_1067_101850_101878(_cmdletizationMetadata)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 101808, 101965);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 101920, 101946);

                            f_1067_101920_101945(enumMetadata);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 101808, 101965);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 158);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 158);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 101734, 101980);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 101996, 102287) || true) && (f_1067_102000_102042(f_1067_102000_102028(_cmdletizationMetadata)) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 101996, 102287);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 102084, 102272);
                        foreach (StaticCmdletMetadata staticCmdlet in f_1067_102130_102172_I(f_1067_102130_102172(f_1067_102130_102158(_cmdletizationMetadata))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 102084, 102272);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 102214, 102253);

                            f_1067_102214_102252(this, output, staticCmdlet);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 102084, 102272);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 189);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 189);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 101996, 102287);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 102303, 102793) || true) && (f_1067_102307_102351(f_1067_102307_102335(_cmdletizationMetadata)) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 102303, 102793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 102393, 102421);

                    f_1067_102393_102420(this, output);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 102439, 102778) || true) && (f_1067_102443_102494(f_1067_102443_102487(f_1067_102443_102471(_cmdletizationMetadata))) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 102439, 102778);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 102544, 102759);
                            foreach (InstanceCmdletMetadata instanceCmdlet in f_1067_102594_102645_I(f_1067_102594_102645(f_1067_102594_102638(f_1067_102594_102622(_cmdletizationMetadata)))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 102544, 102759);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 102695, 102736);

                                f_1067_102695_102735(this, output, instanceCmdlet);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 102544, 102759);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 216);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 216);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 102439, 102778);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 102303, 102793);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 101549, 102804);

                int
                f_1067_101624_101656(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, System.IO.TextWriter
                output)
                {
                    this_param.WriteModulePreamble(output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 101624, 101656);
                    return 0;
                }


                int
                f_1067_101671_101717(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, System.IO.TextWriter
                output)
                {
                    this_param.WriteBindCommonParametersFunction(output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 101671, 101717);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum[]
                f_1067_101738_101766(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Enums;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 101738, 101766);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum[]
                f_1067_101850_101878(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Enums;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 101850, 101878);
                    return return_v;
                }


                int
                f_1067_101920_101945(Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum
                enumMetadata)
                {
                    CompileEnum(enumMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 101920, 101945);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum[]
                f_1067_101850_101878_I(Microsoft.PowerShell.Cmdletization.Xml.EnumMetadataEnum[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 101850, 101878);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_102000_102028(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 102000, 102028);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadata[]
                f_1067_102000_102042(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.StaticCmdlets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 102000, 102042);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_102130_102158(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 102130, 102158);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadata[]
                f_1067_102130_102172(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.StaticCmdlets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 102130, 102172);
                    return return_v;
                }


                int
                f_1067_102214_102252(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, System.IO.TextWriter
                output, Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadata
                staticCmdlet)
                {
                    this_param.WriteCmdlet(output, staticCmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 102214, 102252);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadata[]
                f_1067_102130_102172_I(Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadata[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 102130, 102172);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_102307_102335(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 102307, 102335);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataInstanceCmdlets
                f_1067_102307_102351(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.InstanceCmdlets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 102307, 102351);
                    return return_v;
                }


                int
                f_1067_102393_102420(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, System.IO.TextWriter
                output)
                {
                    this_param.WriteGetCmdlet(output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 102393, 102420);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_102443_102471(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 102443, 102471);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataInstanceCmdlets
                f_1067_102443_102487(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.InstanceCmdlets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 102443, 102487);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata[]
                f_1067_102443_102494(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataInstanceCmdlets
                this_param)
                {
                    var return_v = this_param.Cmdlet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 102443, 102494);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_102594_102622(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 102594, 102622);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataInstanceCmdlets
                f_1067_102594_102638(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.InstanceCmdlets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 102594, 102638);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata[]
                f_1067_102594_102645(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataInstanceCmdlets
                this_param)
                {
                    var return_v = this_param.Cmdlet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 102594, 102645);
                    return return_v;
                }


                int
                f_1067_102695_102735(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, System.IO.TextWriter
                output, Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata
                instanceCmdlet)
                {
                    this_param.WriteCmdlet(output, instanceCmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 102695, 102735);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata[]
                f_1067_102594_102645_I(Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 102594, 102645);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 101549, 102804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 101549, 102804);
            }
        }

        internal const string
        PrivateDataKey_CmdletsOverObjects = "CmdletsOverObjects"
        ;

        internal const string
        PrivateDataKey_ClassName = "ClassName"
        ;

        internal const string
        PrivateDataKey_ObjectModelWrapper = "CmdletAdapter"
        ;

        internal const string
        PrivateDataKey_DefaultSession = "DefaultSession"
        ;

        internal void PopulatePSModuleInfo(PSModuleInfo moduleInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 103202, 103936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 103286, 103327);

                f_1067_103286_103326(moduleInfo, ModuleType.Cim);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 103341, 103414);

                f_1067_103341_103413(moduleInfo, f_1067_103363_103412(f_1067_103375_103411(f_1067_103375_103403(_cmdletizationMetadata))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 103430, 103508);

                Hashtable
                cmdletizationData = f_1067_103460_103507(f_1067_103474_103506())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 103522, 103610);

                f_1067_103522_103609(cmdletizationData, PrivateDataKey_ClassName, f_1067_103570_103608(f_1067_103570_103598(_cmdletizationMetadata)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 103624, 103702);

                f_1067_103624_103701(cmdletizationData, PrivateDataKey_ObjectModelWrapper, _objectModelWrapper);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 103718, 103790);

                Hashtable
                privateData = f_1067_103742_103789(f_1067_103756_103788())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 103804, 103874);

                f_1067_103804_103873(privateData, PrivateDataKey_CmdletsOverObjects, cmdletizationData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 103888, 103925);

                moduleInfo.PrivateData = privateData;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 103202, 103936);

                int
                f_1067_103286_103326(System.Management.Automation.PSModuleInfo
                this_param, System.Management.Automation.ModuleType
                moduleType)
                {
                    this_param.SetModuleType(moduleType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 103286, 103326);
                    return 0;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_103375_103403(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 103375, 103403);
                    return return_v;
                }


                string
                f_1067_103375_103411(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 103375, 103411);
                    return return_v;
                }


                System.Version
                f_1067_103363_103412(string
                version)
                {
                    var return_v = new System.Version(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 103363, 103412);
                    return return_v;
                }


                int
                f_1067_103341_103413(System.Management.Automation.PSModuleInfo
                this_param, System.Version
                version)
                {
                    this_param.SetVersion(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 103341, 103413);
                    return 0;
                }


                System.StringComparer
                f_1067_103474_103506()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 103474, 103506);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1067_103460_103507(System.StringComparer
                equalityComparer)
                {
                    var return_v = new System.Collections.Hashtable((System.Collections.IEqualityComparer)equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 103460, 103507);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_103570_103598(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 103570, 103598);
                    return return_v;
                }


                string
                f_1067_103570_103608(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.ClassName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 103570, 103608);
                    return return_v;
                }


                int
                f_1067_103522_103609(System.Collections.Hashtable
                this_param, string
                key, string
                value)
                {
                    this_param.Add((object)key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 103522, 103609);
                    return 0;
                }


                int
                f_1067_103624_103701(System.Collections.Hashtable
                this_param, string
                key, System.Type
                value)
                {
                    this_param.Add((object)key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 103624, 103701);
                    return 0;
                }


                System.StringComparer
                f_1067_103756_103788()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 103756, 103788);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1067_103742_103789(System.StringComparer
                equalityComparer)
                {
                    var return_v = new System.Collections.Hashtable((System.Collections.IEqualityComparer)equalityComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 103742, 103789);
                    return return_v;
                }


                int
                f_1067_103804_103873(System.Collections.Hashtable
                this_param, string
                key, System.Collections.Hashtable
                value)
                {
                    this_param.Add((object)key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 103804, 103873);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 103202, 103936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 103202, 103936);
            }
        }

        internal void ReportExportedCommands(PSModuleInfo moduleInfo, string prefix)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1067, 103948, 105866);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 104049, 104147) || true) && (f_1067_104053_104086(f_1067_104053_104080(moduleInfo)) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 104049, 104147);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 104125, 104132);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 104049, 104147);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 104163, 104222);

                moduleInfo.DeclaredAliasExports = f_1067_104197_104221();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 104236, 104298);

                moduleInfo.DeclaredFunctionExports = f_1067_104273_104297();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 104314, 104407);

                IEnumerable<CommonCmdletMetadata>
                cmdletMetadatas = f_1067_104366_104406()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 104421, 104917) || true) && (f_1067_104425_104469(f_1067_104425_104453(_cmdletizationMetadata)) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 104421, 104917);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 104511, 104581);

                    cmdletMetadatas = f_1067_104529_104580(cmdletMetadatas, f_1067_104552_104579(this));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 104599, 104902) || true) && (f_1067_104603_104654(f_1067_104603_104647(f_1067_104603_104631(_cmdletizationMetadata))) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 104599, 104902);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 104704, 104883);

                        cmdletMetadatas =
                        f_1067_104747_104882(cmdletMetadatas, f_1067_104800_104881(f_1067_104800_104851(f_1067_104800_104844(f_1067_104800_104828(_cmdletizationMetadata))), c => c.CmdletMetadata));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 104599, 104902);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 104421, 104917);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 104933, 105198) || true) && (f_1067_104937_104979(f_1067_104937_104965(_cmdletizationMetadata)) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 104933, 105198);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 105021, 105183);

                    cmdletMetadatas =
                    f_1067_105060_105182(cmdletMetadatas, f_1067_105109_105181(f_1067_105109_105151(f_1067_105109_105137(_cmdletizationMetadata)), c => c.CmdletMetadata));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 104933, 105198);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 105214, 105855);
                    foreach (CommonCmdletMetadata cmdletMetadata in f_1067_105262_105277_I(cmdletMetadatas))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 105214, 105855);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 105311, 105618) || true) && (f_1067_105315_105337(cmdletMetadata) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 105311, 105618);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 105387, 105599);
                                foreach (string alias in f_1067_105412_105434_I(f_1067_105412_105434(cmdletMetadata)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1067, 105387, 105599);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 105484, 105576);

                                    f_1067_105484_105575(moduleInfo.DeclaredAliasExports, f_1067_105520_105574(alias, prefix));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 105387, 105599);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 213);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 213);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 105311, 105618);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 105638, 105712);

                        CommandMetadata
                        commandMetadata = f_1067_105672_105711(this, cmdletMetadata)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1067, 105730, 105840);

                        f_1067_105730_105839(moduleInfo.DeclaredFunctionExports, f_1067_105769_105838(f_1067_105809_105829(commandMetadata), prefix));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1067, 105214, 105855);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1067, 1, 642);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1067, 1, 642);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1067, 103948, 105866);

                System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandInfo>
                f_1067_104053_104080(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.ExportedCommands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 104053, 104080);
                    return return_v;
                }


                int
                f_1067_104053_104086(System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 104053, 104086);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1067_104197_104221()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 104197, 104221);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1067_104273_104297()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 104273, 104297);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata>
                f_1067_104366_104406()
                {
                    var return_v = Enumerable.Empty<CommonCmdletMetadata>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 104366, 104406);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_104425_104453(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 104425, 104453);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataInstanceCmdlets
                f_1067_104425_104469(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.InstanceCmdlets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 104425, 104469);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                f_1067_104552_104579(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param)
                {
                    var return_v = this_param.GetGetCmdletMetadata();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 104552, 104579);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata>
                f_1067_104529_104580(System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata>
                source, Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                element)
                {
                    var return_v = source.Append<Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata>(element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 104529, 104580);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_104603_104631(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 104603, 104631);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataInstanceCmdlets
                f_1067_104603_104647(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.InstanceCmdlets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 104603, 104647);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata[]
                f_1067_104603_104654(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataInstanceCmdlets
                this_param)
                {
                    var return_v = this_param.Cmdlet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 104603, 104654);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_104800_104828(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 104800, 104828);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataInstanceCmdlets
                f_1067_104800_104844(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.InstanceCmdlets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 104800, 104844);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata[]
                f_1067_104800_104851(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadataInstanceCmdlets
                this_param)
                {
                    var return_v = this_param.Cmdlet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 104800, 104851);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata>
                f_1067_104800_104881(Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata[]
                source, System.Func<Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata, Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata>
                selector)
                {
                    var return_v = source.Select<Microsoft.PowerShell.Cmdletization.Xml.InstanceCmdletMetadata, Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 104800, 104881);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata>
                f_1067_104747_104882(System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata>
                first, System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata>
                second)
                {
                    var return_v = first.Concat<Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata>(second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 104747, 104882);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_104937_104965(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 104937, 104965);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadata[]
                f_1067_104937_104979(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.StaticCmdlets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 104937, 104979);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                f_1067_105109_105137(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
                this_param)
                {
                    var return_v = this_param.Class;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 105109, 105137);
                    return return_v;
                }


                Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadata[]
                f_1067_105109_105151(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
                this_param)
                {
                    var return_v = this_param.StaticCmdlets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 105109, 105151);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadataCmdletMetadata>
                f_1067_105109_105181(Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadata[]
                source, System.Func<Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadata, Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadataCmdletMetadata>
                selector)
                {
                    var return_v = source.Select<Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadata, Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadataCmdletMetadata>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 105109, 105181);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata>
                f_1067_105060_105182(System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata>
                first, System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.Xml.StaticCmdletMetadataCmdletMetadata>
                second)
                {
                    var return_v = first.Concat<Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata>((System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 105060, 105182);
                    return return_v;
                }


                string[]
                f_1067_105315_105337(Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                this_param)
                {
                    var return_v = this_param.Aliases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 105315, 105337);
                    return return_v;
                }


                string[]
                f_1067_105412_105434(Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                this_param)
                {
                    var return_v = this_param.Aliases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 105412, 105434);
                    return return_v;
                }


                string
                f_1067_105520_105574(string
                commandName, string
                prefix)
                {
                    var return_v = ModuleCmdletBase.AddPrefixToCommandName(commandName, prefix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 105520, 105574);
                    return return_v;
                }


                int
                f_1067_105484_105575(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 105484, 105575);
                    return 0;
                }


                string[]
                f_1067_105412_105434_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 105412, 105434);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1067_105672_105711(Microsoft.PowerShell.Cmdletization.ScriptWriter
                this_param, Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata
                cmdletMetadata)
                {
                    var return_v = this_param.GetCommandMetadata(cmdletMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 105672, 105711);
                    return return_v;
                }


                string
                f_1067_105809_105829(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 105809, 105829);
                    return return_v;
                }


                string
                f_1067_105769_105838(string
                commandName, string
                prefix)
                {
                    var return_v = ModuleCmdletBase.AddPrefixToCommandName(commandName, prefix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 105769, 105838);
                    return return_v;
                }


                int
                f_1067_105730_105839(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 105730, 105839);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata>
                f_1067_105262_105277_I(System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Cmdletization.Xml.CommonCmdletMetadata>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 105262, 105277);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1067, 103948, 105866);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1067, 103948, 105866);
            }
        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1067, 667, 105908);

        static System.Xml.XmlReaderSettings
        f_1067_1007_1030()
        {
            var return_v = new System.Xml.XmlReaderSettings();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 1007, 1030);
            return return_v;
        }


        int
        f_1067_4149_4251(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 4149, 4251);
            return 0;
        }


        bool
        f_1067_4278_4310(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 4278, 4310);
            return return_v;
        }


        int
        f_1067_4266_4359(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 4266, 4359);
            return 0;
        }


        int
        f_1067_4374_4460(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 4374, 4460);
            return 0;
        }


        bool
        f_1067_4487_4534(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 4487, 4534);
            return return_v;
        }


        int
        f_1067_4475_4598(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 4475, 4598);
            return 0;
        }


        System.Xml.XmlReader
        f_1067_4637_4711(System.IO.TextReader
        input, System.Xml.XmlReaderSettings
        settings)
        {
            var return_v = XmlReader.Create(input, settings);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 4637, 4711);
            return return_v;
        }


        Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadataSerializer
        f_1067_4782_4816()
        {
            var return_v = new Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadataSerializer();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 4782, 4816);
            return return_v;
        }


        object
        f_1067_4880_4916(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadataSerializer
        this_param, System.Xml.XmlReader
        reader)
        {
            var return_v = this_param.Deserialize(reader);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 4880, 4916);
            return return_v;
        }


        System.Exception
        f_1067_5051_5067(System.InvalidOperationException
        this_param)
        {
            var return_v = this_param.InnerException;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 5051, 5067);
            return return_v;
        }


        string
        f_1067_5200_5223(System.Xml.Schema.XmlSchemaException
        this_param)
        {
            var return_v = this_param.Message;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 5200, 5223);
            return return_v;
        }


        int
        f_1067_5242_5268(System.Xml.Schema.XmlSchemaException
        this_param)
        {
            var return_v = this_param.LineNumber;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 5242, 5268);
            return return_v;
        }


        int
        f_1067_5270_5298(System.Xml.Schema.XmlSchemaException
        this_param)
        {
            var return_v = this_param.LinePosition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 5270, 5298);
            return return_v;
        }


        System.Xml.XmlException
        f_1067_5183_5299(string
        message, System.Xml.Schema.XmlSchemaException
        innerException, int
        lineNumber, int
        linePosition)
        {
            var return_v = new System.Xml.XmlException(message, (System.Exception)innerException, lineNumber, linePosition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 5183, 5299);
            return return_v;
        }


        System.Exception
        f_1067_5367_5383(System.InvalidOperationException
        this_param)
        {
            var return_v = this_param.InnerException;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 5367, 5383);
            return return_v;
        }


        System.Exception
        f_1067_5546_5562(System.InvalidOperationException
        this_param)
        {
            var return_v = this_param.InnerException;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 5546, 5562);
            return return_v;
        }


        System.Globalization.CultureInfo
        f_1067_5669_5695()
        {
            var return_v = CultureInfo.CurrentCulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 5669, 5695);
            return return_v;
        }


        string
        f_1067_5722_5802()
        {
            var return_v = CmdletizationCoreResources.ScriptWriter_ConcatenationOfDeserializationExceptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 5722, 5802);
            return return_v;
        }


        string
        f_1067_5829_5838(System.InvalidOperationException
        this_param)
        {
            var return_v = this_param.Message;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 5829, 5838);
            return return_v;
        }


        System.Exception
        f_1067_5865_5881(System.InvalidOperationException
        this_param)
        {
            var return_v = this_param.InnerException;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 5865, 5881);
            return return_v;
        }


        string
        f_1067_5865_5889(System.Exception
        this_param)
        {
            var return_v = this_param.Message;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 5865, 5889);
            return return_v;
        }


        string
        f_1067_5629_5890(System.Globalization.CultureInfo
        provider, string
        format, string
        arg0, string
        arg1)
        {
            var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 5629, 5890);
            return return_v;
        }


        System.Exception
        f_1067_5960_5976(System.InvalidOperationException
        this_param)
        {
            var return_v = this_param.InnerException;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 5960, 5976);
            return return_v;
        }


        System.InvalidOperationException
        f_1067_5921_5977(string
        message, System.Exception
        innerException)
        {
            var return_v = new System.InvalidOperationException(message, innerException);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 5921, 5977);
            return return_v;
        }


        Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
        f_1067_6086_6114(Microsoft.PowerShell.Cmdletization.Xml.PowerShellMetadata
        this_param)
        {
            var return_v = this_param.Class;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 6086, 6114);
            return return_v;
        }


        string
        f_1067_6086_6128(Microsoft.PowerShell.Cmdletization.Xml.ClassMetadata
        this_param)
        {
            var return_v = this_param.CmdletAdapter;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 6086, 6128);
            return return_v;
        }


        System.Globalization.CultureInfo
        f_1067_6267_6295()
        {
            var return_v = CultureInfo.InvariantCulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 6267, 6295);
            return return_v;
        }


        object
        f_1067_6200_6296(string
        valueToConvert, System.Type
        resultType, System.Globalization.CultureInfo
        formatProvider)
        {
            var return_v = LanguagePrimitives.ConvertTo((object)valueToConvert, resultType, (System.IFormatProvider)formatProvider);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 6200, 6296);
            return return_v;
        }


        bool
        f_1067_6315_6348(System.Type
        this_param)
        {
            var return_v = this_param.IsGenericType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 6315, 6348);
            return return_v;
        }


        System.Globalization.CultureInfo
        f_1067_6435_6461()
        {
            var return_v = CultureInfo.CurrentCulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 6435, 6461);
            return return_v;
        }


        string
        f_1067_6484_6556()
        {
            var return_v = CmdletizationCoreResources.ScriptWriter_ObjectModelWrapperIsStillGeneric;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 6484, 6556);
            return return_v;
        }


        string
        f_1067_6399_6602(System.Globalization.CultureInfo
        provider, string
        format, string
        arg0)
        {
            var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 6399, 6602);
            return return_v;
        }


        System.Xml.XmlException
        f_1067_6627_6652(string
        message)
        {
            var return_v = new System.Xml.XmlException(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 6627, 6652);
            return return_v;
        }


        bool
        f_1067_6742_6765_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 6742, 6765);
            return return_v;
        }


        System.Type
        f_1067_6770_6805(System.Type
        this_param)
        {
            var return_v = this_param.GetGenericTypeDefinition();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 6770, 6805);
            return return_v;
        }


        System.Type
        f_1067_6877_6894(System.Type
        this_param)
        {
            var return_v = this_param.BaseType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 6877, 6894);
            return return_v;
        }


        System.Globalization.CultureInfo
        f_1067_7042_7068()
        {
            var return_v = CultureInfo.CurrentCulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 7042, 7068);
            return return_v;
        }


        string
        f_1067_7095_7185()
        {
            var return_v = CmdletizationCoreResources.ScriptWriter_ObjectModelWrapperNotDerivedFromObjectModelWrapper;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 7095, 7185);
            return return_v;
        }


        string
        f_1067_7261_7293(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1067, 7261, 7293);
            return return_v;
        }


        string
        f_1067_7002_7294(System.Globalization.CultureInfo
        provider, string
        format, string
        arg0, string
        arg1)
        {
            var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 7002, 7294);
            return return_v;
        }


        System.Xml.XmlException
        f_1067_7323_7348(string
        message)
        {
            var return_v = new System.Xml.XmlException(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 7323, 7348);
            return return_v;
        }


        System.Type[]
        f_1067_7421_7451(System.Type
        this_param)
        {
            var return_v = this_param.GetGenericArguments();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 7421, 7451);
            return return_v;
        }


        System.Collections.Generic.Dictionary<Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadata, int>
        f_1067_18098_18141()
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.PowerShell.Cmdletization.Xml.CommonMethodMetadata, int>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 18098, 18141);
            return return_v;
        }


        static object
        f_1067_100562_100574()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1067, 100562, 100574);
            return return_v;
        }

    }
}
