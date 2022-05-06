// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Management.Automation;
using System.Xml;

namespace Microsoft.PowerShell.Commands
{
    internal class FormatXmlWriter
    {
        private XmlWriter _writer;

        private bool _exportScriptBlock;

        private FormatXmlWriter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1096, 533, 562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 471, 478);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 502, 520);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1096, 533, 562);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1096, 533, 562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1096, 533, 562);
            }
        }

        internal static void WriteToPs1Xml(PSCmdlet cmdlet, List<ExtendedTypeDefinition> typeDefinitions,
                    string filepath, bool force, bool noclobber, bool writeScriptBlock, bool isLiteralPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1096, 1248, 2528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 1471, 1497);

                StreamWriter
                streamWriter
                = default(StreamWriter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 1511, 1533);

                FileStream
                fileStream
                = default(FileStream);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 1547, 1565);

                FileInfo
                fileInfo
                = default(FileInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 1579, 1744);

                f_1096_1579_1743(cmdlet, filepath, "ascii", true, false, force, noclobber, out fileStream, out streamWriter, out fileInfo, isLiteralPath);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 1796, 1835);

                    var
                    settings = f_1096_1811_1834()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 1853, 1876);

                    settings.Indent = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 1894, 1922);

                    settings.IndentChars = "  ";
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 1940, 1976);

                    settings.NewLineOnAttributes = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 1996, 2371);
                    using (XmlWriter
                    xmlWriter = f_1096_2025_2065(streamWriter, settings)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 2107, 2295);

                        var
                        writer = new FormatXmlWriter
                        {
                            _writer = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => xmlWriter, 1096, 2120, 2294),
                            _exportScriptBlock = writeScriptBlock
                        }
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 2317, 2352);

                        f_1096_2317_2351(writer, typeDefinitions);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1096, 1996, 2371);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1096, 2400, 2517);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 2440, 2463);

                    f_1096_2440_2462(streamWriter);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 2481, 2502);

                    f_1096_2481_2501(fileStream);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1096, 2400, 2517);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1096, 1248, 2528);

                int
                f_1096_1579_1743(System.Management.Automation.PSCmdlet
                cmdlet, string
                filePath, string
                encoding, bool
                defaultEncoding, bool
                Append, bool
                Force, bool
                NoClobber, out System.IO.FileStream
                fileStream, out System.IO.StreamWriter
                streamWriter, out System.IO.FileInfo
                readOnlyFileInfo, bool
                isLiteralPath)
                {
                    PathUtils.MasterStreamOpen(cmdlet, filePath, encoding, defaultEncoding, Append, Force, NoClobber, out fileStream, out streamWriter, out readOnlyFileInfo, isLiteralPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 1579, 1743);
                    return 0;
                }


                System.Xml.XmlWriterSettings
                f_1096_1811_1834()
                {
                    var return_v = new System.Xml.XmlWriterSettings();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 1811, 1834);
                    return return_v;
                }


                System.Xml.XmlWriter
                f_1096_2025_2065(System.IO.StreamWriter
                output, System.Xml.XmlWriterSettings
                settings)
                {
                    var return_v = XmlWriter.Create((System.IO.TextWriter)output, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 2025, 2065);
                    return return_v;
                }


                int
                f_1096_2317_2351(Microsoft.PowerShell.Commands.FormatXmlWriter
                this_param, System.Collections.Generic.List<System.Management.Automation.ExtendedTypeDefinition>
                typeDefinitions)
                {
                    this_param.WriteToXml((System.Collections.Generic.IEnumerable<System.Management.Automation.ExtendedTypeDefinition>)typeDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 2317, 2351);
                    return 0;
                }


                int
                f_1096_2440_2462(System.IO.StreamWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 2440, 2462);
                    return 0;
                }


                int
                f_1096_2481_2501(System.IO.FileStream
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 2481, 2501);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1096, 1248, 2528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1096, 1248, 2528);
            }
        }

        internal static void WriteToXml(XmlWriter writer, IEnumerable<ExtendedTypeDefinition> typeDefinitions, bool writeScriptBlock)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1096, 2540, 2861);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 2690, 2792);

                var
                formatXmlWriter = new FormatXmlWriter { _exportScriptBlock = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => writeScriptBlock, 1096, 2712, 2791), _writer = writer }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 2806, 2850);

                f_1096_2806_2849(formatXmlWriter, typeDefinitions);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1096, 2540, 2861);

                int
                f_1096_2806_2849(Microsoft.PowerShell.Commands.FormatXmlWriter
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.ExtendedTypeDefinition>
                typeDefinitions)
                {
                    this_param.WriteToXml(typeDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 2806, 2849);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1096, 2540, 2861);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1096, 2540, 2861);
            }
        }

        internal void WriteToXml(IEnumerable<ExtendedTypeDefinition> typeDefinitions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1096, 2873, 5798);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 2975, 3040);

                var
                views = f_1096_2987_3039()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 3054, 3116);

                var
                formatdefs = f_1096_3071_3115()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 3132, 3967);
                    foreach (ExtendedTypeDefinition typedefinition in f_1096_3182_3197_I(typeDefinitions))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 3132, 3967);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 3231, 3952);
                            foreach (FormatViewDefinition viewdefinition in f_1096_3279_3314_I(f_1096_3279_3314(typedefinition)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 3231, 3952);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 3356, 3394);

                                List<ExtendedTypeDefinition>
                                viewList
                                = default(List<ExtendedTypeDefinition>);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 3416, 3671) || true) && (!f_1096_3421_3479(views, f_1096_3439_3464(viewdefinition), out viewList))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 3416, 3671);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 3529, 3575);

                                    viewList = f_1096_3540_3574();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 3601, 3648);

                                    f_1096_3601_3647(views, f_1096_3611_3636(viewdefinition), viewList);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 3416, 3671);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 3695, 3880) || true) && (!f_1096_3700_3749(formatdefs, f_1096_3723_3748(viewdefinition)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 3695, 3880);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 3799, 3857);

                                    f_1096_3799_3856(formatdefs, f_1096_3814_3839(viewdefinition), viewdefinition);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 3695, 3880);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 3904, 3933);

                                f_1096_3904_3932(
                                                    viewList, typedefinition);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 3231, 3952);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1096, 1, 722);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1096, 1, 722);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 3132, 3967);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1096, 1, 836);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1096, 1, 836);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 3983, 4026);

                f_1096_3983_4025(
                            _writer, "Configuration");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 4042, 4087);

                f_1096_4042_4086(
                            _writer, "ViewDefinitions");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 4101, 5661);
                    foreach (var pair in f_1096_4122_4132_I(formatdefs))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 4101, 5661);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 4166, 4185);

                        Guid
                        id = pair.Key
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 4203, 4247);

                        FormatViewDefinition
                        formatdef = pair.Value
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 4267, 4301);

                        f_1096_4267_4300(
                                        _writer, "View");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 4319, 4370);

                        f_1096_4319_4369(_writer, "Name", f_1096_4354_4368(formatdef));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 4388, 4432);

                        f_1096_4388_4431(_writer, "ViewSelectedBy");
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 4450, 4626);
                            foreach (ExtendedTypeDefinition definition in f_1096_4496_4505_I(f_1096_4496_4505(views, id)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 4450, 4626);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 4547, 4607);

                                f_1096_4547_4606(_writer, "TypeName", f_1096_4586_4605(definition));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 4450, 4626);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1096, 1, 177);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1096, 1, 177);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 4646, 4693);

                        f_1096_4646_4692(
                                        _writer);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 4713, 4753);

                        var
                        groupBy = f_1096_4727_4752(f_1096_4727_4744(formatdef))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 4771, 5370) || true) && (groupBy != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 4771, 5370);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 4832, 4869);

                            f_1096_4832_4868(_writer, "GroupBy");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 4891, 4929);

                            f_1096_4891_4928(this, f_1096_4909_4927(groupBy));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 4951, 5115) || true) && (!f_1096_4956_4991(f_1096_4977_4990(groupBy)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 4951, 5115);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 5041, 5092);

                                f_1096_5041_5091(_writer, "Label", f_1096_5077_5090(groupBy));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 4951, 5115);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 5139, 5287) || true) && (f_1096_5143_5164(groupBy) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 5139, 5287);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 5222, 5264);

                                f_1096_5222_5263(this, f_1096_5241_5262(groupBy));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 5139, 5287);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 5311, 5351);

                            f_1096_5311_5350(
                                                _writer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 4771, 5370);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 5390, 5536) || true) && (f_1096_5394_5421(f_1096_5394_5411(formatdef)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 5390, 5536);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 5463, 5517);

                            f_1096_5463_5516(_writer, "OutOfBand", string.Empty);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 5390, 5536);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 5556, 5591);

                        f_1096_5556_5590(f_1096_5556_5573(formatdef), this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 5609, 5646);

                        f_1096_5609_5645(_writer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 4101, 5661);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1096, 1, 1561);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1096, 1, 1561);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 5677, 5725);

                f_1096_5677_5724(
                            _writer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 5741, 5787);

                f_1096_5741_5786(
                            _writer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1096, 2873, 5798);

                System.Collections.Generic.Dictionary<System.Guid, System.Collections.Generic.List<System.Management.Automation.ExtendedTypeDefinition>>
                f_1096_2987_3039()
                {
                    var return_v = new System.Collections.Generic.Dictionary<System.Guid, System.Collections.Generic.List<System.Management.Automation.ExtendedTypeDefinition>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 2987, 3039);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.FormatViewDefinition>
                f_1096_3071_3115()
                {
                    var return_v = new System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.FormatViewDefinition>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 3071, 3115);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.FormatViewDefinition>
                f_1096_3279_3314(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.FormatViewDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 3279, 3314);
                    return return_v;
                }


                System.Guid
                f_1096_3439_3464(System.Management.Automation.FormatViewDefinition
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 3439, 3464);
                    return return_v;
                }


                bool
                f_1096_3421_3479(System.Collections.Generic.Dictionary<System.Guid, System.Collections.Generic.List<System.Management.Automation.ExtendedTypeDefinition>>
                this_param, System.Guid
                key, out System.Collections.Generic.List<System.Management.Automation.ExtendedTypeDefinition>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 3421, 3479);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.ExtendedTypeDefinition>
                f_1096_3540_3574()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.ExtendedTypeDefinition>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 3540, 3574);
                    return return_v;
                }


                System.Guid
                f_1096_3611_3636(System.Management.Automation.FormatViewDefinition
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 3611, 3636);
                    return return_v;
                }


                int
                f_1096_3601_3647(System.Collections.Generic.Dictionary<System.Guid, System.Collections.Generic.List<System.Management.Automation.ExtendedTypeDefinition>>
                this_param, System.Guid
                key, System.Collections.Generic.List<System.Management.Automation.ExtendedTypeDefinition>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 3601, 3647);
                    return 0;
                }


                System.Guid
                f_1096_3723_3748(System.Management.Automation.FormatViewDefinition
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 3723, 3748);
                    return return_v;
                }


                bool
                f_1096_3700_3749(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.FormatViewDefinition>
                this_param, System.Guid
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 3700, 3749);
                    return return_v;
                }


                System.Guid
                f_1096_3814_3839(System.Management.Automation.FormatViewDefinition
                this_param)
                {
                    var return_v = this_param.InstanceId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 3814, 3839);
                    return return_v;
                }


                int
                f_1096_3799_3856(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.FormatViewDefinition>
                this_param, System.Guid
                key, System.Management.Automation.FormatViewDefinition
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 3799, 3856);
                    return 0;
                }


                int
                f_1096_3904_3932(System.Collections.Generic.List<System.Management.Automation.ExtendedTypeDefinition>
                this_param, System.Management.Automation.ExtendedTypeDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 3904, 3932);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.FormatViewDefinition>
                f_1096_3279_3314_I(System.Collections.Generic.List<System.Management.Automation.FormatViewDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 3279, 3314);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ExtendedTypeDefinition>
                f_1096_3182_3197_I(System.Collections.Generic.IEnumerable<System.Management.Automation.ExtendedTypeDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 3182, 3197);
                    return return_v;
                }


                int
                f_1096_3983_4025(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 3983, 4025);
                    return 0;
                }


                int
                f_1096_4042_4086(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 4042, 4086);
                    return 0;
                }


                int
                f_1096_4267_4300(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 4267, 4300);
                    return 0;
                }


                string
                f_1096_4354_4368(System.Management.Automation.FormatViewDefinition
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 4354, 4368);
                    return return_v;
                }


                int
                f_1096_4319_4369(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 4319, 4369);
                    return 0;
                }


                int
                f_1096_4388_4431(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 4388, 4431);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.ExtendedTypeDefinition>
                f_1096_4496_4505(System.Collections.Generic.Dictionary<System.Guid, System.Collections.Generic.List<System.Management.Automation.ExtendedTypeDefinition>>
                this_param, System.Guid
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 4496, 4505);
                    return return_v;
                }


                string
                f_1096_4586_4605(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 4586, 4605);
                    return return_v;
                }


                int
                f_1096_4547_4606(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 4547, 4606);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.ExtendedTypeDefinition>
                f_1096_4496_4505_I(System.Collections.Generic.List<System.Management.Automation.ExtendedTypeDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 4496, 4505);
                    return return_v;
                }


                int
                f_1096_4646_4692(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 4646, 4692);
                    return 0;
                }


                System.Management.Automation.PSControl
                f_1096_4727_4744(System.Management.Automation.FormatViewDefinition
                this_param)
                {
                    var return_v = this_param.Control;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 4727, 4744);
                    return return_v;
                }


                System.Management.Automation.PSControlGroupBy
                f_1096_4727_4752(System.Management.Automation.PSControl
                this_param)
                {
                    var return_v = this_param.GroupBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 4727, 4752);
                    return return_v;
                }


                int
                f_1096_4832_4868(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 4832, 4868);
                    return 0;
                }


                System.Management.Automation.DisplayEntry
                f_1096_4909_4927(System.Management.Automation.PSControlGroupBy
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 4909, 4927);
                    return return_v;
                }


                int
                f_1096_4891_4928(Microsoft.PowerShell.Commands.FormatXmlWriter
                this_param, System.Management.Automation.DisplayEntry
                displayEntry)
                {
                    this_param.WriteDisplayEntry(displayEntry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 4891, 4928);
                    return 0;
                }


                string
                f_1096_4977_4990(System.Management.Automation.PSControlGroupBy
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 4977, 4990);
                    return return_v;
                }


                bool
                f_1096_4956_4991(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 4956, 4991);
                    return return_v;
                }


                string
                f_1096_5077_5090(System.Management.Automation.PSControlGroupBy
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 5077, 5090);
                    return return_v;
                }


                int
                f_1096_5041_5091(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 5041, 5091);
                    return 0;
                }


                System.Management.Automation.CustomControl
                f_1096_5143_5164(System.Management.Automation.PSControlGroupBy
                this_param)
                {
                    var return_v = this_param.CustomControl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 5143, 5164);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1096_5241_5262(System.Management.Automation.PSControlGroupBy
                this_param)
                {
                    var return_v = this_param.CustomControl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 5241, 5262);
                    return return_v;
                }


                int
                f_1096_5222_5263(Microsoft.PowerShell.Commands.FormatXmlWriter
                this_param, System.Management.Automation.CustomControl
                customControl)
                {
                    this_param.WriteCustomControl(customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 5222, 5263);
                    return 0;
                }


                int
                f_1096_5311_5350(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 5311, 5350);
                    return 0;
                }


                System.Management.Automation.PSControl
                f_1096_5394_5411(System.Management.Automation.FormatViewDefinition
                this_param)
                {
                    var return_v = this_param.Control;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 5394, 5411);
                    return return_v;
                }


                bool
                f_1096_5394_5421(System.Management.Automation.PSControl
                this_param)
                {
                    var return_v = this_param.OutOfBand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 5394, 5421);
                    return return_v;
                }


                int
                f_1096_5463_5516(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 5463, 5516);
                    return 0;
                }


                System.Management.Automation.PSControl
                f_1096_5556_5573(System.Management.Automation.FormatViewDefinition
                this_param)
                {
                    var return_v = this_param.Control;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 5556, 5573);
                    return return_v;
                }


                int
                f_1096_5556_5590(System.Management.Automation.PSControl
                this_param, Microsoft.PowerShell.Commands.FormatXmlWriter
                writer)
                {
                    this_param.WriteToXml(writer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 5556, 5590);
                    return 0;
                }


                int
                f_1096_5609_5645(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 5609, 5645);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.FormatViewDefinition>
                f_1096_4122_4132_I(System.Collections.Generic.Dictionary<System.Guid, System.Management.Automation.FormatViewDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 4122, 4132);
                    return return_v;
                }


                int
                f_1096_5677_5724(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 5677, 5724);
                    return 0;
                }


                int
                f_1096_5741_5786(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 5741, 5786);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1096, 2873, 5798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1096, 2873, 5798);
            }
        }

        internal void WriteTableControl(TableControl tableControl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1096, 5810, 8794);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 5893, 5935);

                f_1096_5893_5934(_writer, "TableControl");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 5949, 6076) || true) && (f_1096_5953_5974(tableControl))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 5949, 6076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 6008, 6061);

                    f_1096_6008_6060(_writer, "AutoSize", string.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 5949, 6076);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 6092, 6235) || true) && (f_1096_6096_6125(tableControl))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 6092, 6235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 6159, 6220);

                    f_1096_6159_6219(_writer, "HideTableHeaders", string.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 6092, 6235);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 6251, 6293);

                f_1096_6251_6292(
                            _writer, "TableHeaders");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 6307, 7130);
                    foreach (TableControlColumnHeader columnheader in f_1096_6357_6377_I(f_1096_6357_6377(tableControl)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 6307, 7130);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 6411, 6458);

                        f_1096_6411_6457(_writer, "TableColumnHeader");

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 6476, 6638) || true) && (!f_1096_6481_6521(f_1096_6502_6520(columnheader)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 6476, 6638);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 6563, 6619);

                            f_1096_6563_6618(_writer, "Label", f_1096_6599_6617(columnheader));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 6476, 6638);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 6658, 6840) || true) && (f_1096_6662_6680(columnheader) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 6658, 6840);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 6726, 6821);

                            f_1096_6726_6820(_writer, "Width", f_1096_6762_6819(f_1096_6762_6780(columnheader), f_1096_6790_6818()));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 6658, 6840);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 6860, 7045) || true) && (f_1096_6864_6886(columnheader) != Alignment.Undefined)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 6860, 7045);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 6951, 7026);

                            f_1096_6951_7025(_writer, "Alignment", f_1096_6991_7024(f_1096_6991_7013(columnheader)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 6860, 7045);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 7065, 7115);

                        f_1096_7065_7114(
                                        _writer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 6307, 7130);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1096, 1, 824);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1096, 1, 824);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 7146, 7191);

                f_1096_7146_7190(
                            _writer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 7207, 7252);

                f_1096_7207_7251(
                            _writer, "TableRowEntries");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 7266, 8658);
                    foreach (TableControlRow row in f_1096_7298_7315_I(f_1096_7298_7315(tableControl)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 7266, 8658);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 7349, 7392);

                        f_1096_7349_7391(_writer, "TableRowEntry");

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 7410, 7576) || true) && (f_1096_7414_7422(row))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 7410, 7576);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 7464, 7498);

                            f_1096_7464_7497(_writer, "Wrap");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 7520, 7557);

                            f_1096_7520_7556(_writer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 7410, 7576);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 7596, 7720) || true) && (f_1096_7600_7614(row) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 7596, 7720);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 7664, 7701);

                            f_1096_7664_7700(this, f_1096_7685_7699(row));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 7596, 7720);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 7740, 7786);

                        f_1096_7740_7785(
                                        _writer, "TableColumnItems");
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 7804, 8512);
                            foreach (TableControlColumn coldefn in f_1096_7843_7854_I(f_1096_7843_7854(row)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 7804, 8512);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 7896, 7941);

                                f_1096_7896_7940(_writer, "TableColumnItem");

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 7963, 8150) || true) && (f_1096_7967_7984(coldefn) != Alignment.Undefined)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 7963, 8150);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 8057, 8127);

                                    f_1096_8057_8126(_writer, "Alignment", f_1096_8097_8125(f_1096_8097_8114(coldefn)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 7963, 8150);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 8174, 8359) || true) && (!f_1096_8179_8221(f_1096_8200_8220(coldefn)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 8174, 8359);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 8271, 8336);

                                    f_1096_8271_8335(_writer, "FormatString", f_1096_8314_8334(coldefn));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 8174, 8359);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 8383, 8423);

                                f_1096_8383_8422(this, f_1096_8401_8421(coldefn));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 8445, 8493);

                                f_1096_8445_8492(_writer);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 7804, 8512);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1096, 1, 709);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1096, 1, 709);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 8532, 8580);

                        f_1096_8532_8579(
                                        _writer);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 8598, 8643);

                        f_1096_8598_8642(_writer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 7266, 8658);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1096, 1, 1393);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1096, 1, 1393);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 8674, 8722);

                f_1096_8674_8721(
                            _writer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 8738, 8783);

                f_1096_8738_8782(
                            _writer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1096, 5810, 8794);

                int
                f_1096_5893_5934(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 5893, 5934);
                    return 0;
                }


                bool
                f_1096_5953_5974(System.Management.Automation.TableControl
                this_param)
                {
                    var return_v = this_param.AutoSize;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 5953, 5974);
                    return return_v;
                }


                int
                f_1096_6008_6060(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 6008, 6060);
                    return 0;
                }


                bool
                f_1096_6096_6125(System.Management.Automation.TableControl
                this_param)
                {
                    var return_v = this_param.HideTableHeaders;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 6096, 6125);
                    return return_v;
                }


                int
                f_1096_6159_6219(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 6159, 6219);
                    return 0;
                }


                int
                f_1096_6251_6292(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 6251, 6292);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.TableControlColumnHeader>
                f_1096_6357_6377(System.Management.Automation.TableControl
                this_param)
                {
                    var return_v = this_param.Headers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 6357, 6377);
                    return return_v;
                }


                int
                f_1096_6411_6457(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 6411, 6457);
                    return 0;
                }


                string
                f_1096_6502_6520(System.Management.Automation.TableControlColumnHeader
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 6502, 6520);
                    return return_v;
                }


                bool
                f_1096_6481_6521(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 6481, 6521);
                    return return_v;
                }


                string
                f_1096_6599_6617(System.Management.Automation.TableControlColumnHeader
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 6599, 6617);
                    return return_v;
                }


                int
                f_1096_6563_6618(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 6563, 6618);
                    return 0;
                }


                int
                f_1096_6662_6680(System.Management.Automation.TableControlColumnHeader
                this_param)
                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 6662, 6680);
                    return return_v;
                }


                int
                f_1096_6762_6780(System.Management.Automation.TableControlColumnHeader
                this_param)
                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 6762, 6780);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1096_6790_6818()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 6790, 6818);
                    return return_v;
                }


                string
                f_1096_6762_6819(int
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 6762, 6819);
                    return return_v;
                }


                int
                f_1096_6726_6820(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 6726, 6820);
                    return 0;
                }


                System.Management.Automation.Alignment
                f_1096_6864_6886(System.Management.Automation.TableControlColumnHeader
                this_param)
                {
                    var return_v = this_param.Alignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 6864, 6886);
                    return return_v;
                }


                System.Management.Automation.Alignment
                f_1096_6991_7013(System.Management.Automation.TableControlColumnHeader
                this_param)
                {
                    var return_v = this_param.Alignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 6991, 7013);
                    return return_v;
                }


                string
                f_1096_6991_7024(System.Management.Automation.Alignment
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 6991, 7024);
                    return return_v;
                }


                int
                f_1096_6951_7025(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 6951, 7025);
                    return 0;
                }


                int
                f_1096_7065_7114(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 7065, 7114);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.TableControlColumnHeader>
                f_1096_6357_6377_I(System.Collections.Generic.List<System.Management.Automation.TableControlColumnHeader>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 6357, 6377);
                    return return_v;
                }


                int
                f_1096_7146_7190(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 7146, 7190);
                    return 0;
                }


                int
                f_1096_7207_7251(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 7207, 7251);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.TableControlRow>
                f_1096_7298_7315(System.Management.Automation.TableControl
                this_param)
                {
                    var return_v = this_param.Rows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 7298, 7315);
                    return return_v;
                }


                int
                f_1096_7349_7391(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 7349, 7391);
                    return 0;
                }


                bool
                f_1096_7414_7422(System.Management.Automation.TableControlRow
                this_param)
                {
                    var return_v = this_param.Wrap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 7414, 7422);
                    return return_v;
                }


                int
                f_1096_7464_7497(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 7464, 7497);
                    return 0;
                }


                int
                f_1096_7520_7556(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 7520, 7556);
                    return 0;
                }


                System.Management.Automation.EntrySelectedBy
                f_1096_7600_7614(System.Management.Automation.TableControlRow
                this_param)
                {
                    var return_v = this_param.SelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 7600, 7614);
                    return return_v;
                }


                System.Management.Automation.EntrySelectedBy
                f_1096_7685_7699(System.Management.Automation.TableControlRow
                this_param)
                {
                    var return_v = this_param.SelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 7685, 7699);
                    return return_v;
                }


                int
                f_1096_7664_7700(Microsoft.PowerShell.Commands.FormatXmlWriter
                this_param, System.Management.Automation.EntrySelectedBy
                entrySelectedBy)
                {
                    this_param.WriteEntrySelectedBy(entrySelectedBy);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 7664, 7700);
                    return 0;
                }


                int
                f_1096_7740_7785(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 7740, 7785);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.TableControlColumn>
                f_1096_7843_7854(System.Management.Automation.TableControlRow
                this_param)
                {
                    var return_v = this_param.Columns;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 7843, 7854);
                    return return_v;
                }


                int
                f_1096_7896_7940(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 7896, 7940);
                    return 0;
                }


                System.Management.Automation.Alignment
                f_1096_7967_7984(System.Management.Automation.TableControlColumn
                this_param)
                {
                    var return_v = this_param.Alignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 7967, 7984);
                    return return_v;
                }


                System.Management.Automation.Alignment
                f_1096_8097_8114(System.Management.Automation.TableControlColumn
                this_param)
                {
                    var return_v = this_param.Alignment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 8097, 8114);
                    return return_v;
                }


                string
                f_1096_8097_8125(System.Management.Automation.Alignment
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 8097, 8125);
                    return return_v;
                }


                int
                f_1096_8057_8126(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 8057, 8126);
                    return 0;
                }


                string
                f_1096_8200_8220(System.Management.Automation.TableControlColumn
                this_param)
                {
                    var return_v = this_param.FormatString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 8200, 8220);
                    return return_v;
                }


                bool
                f_1096_8179_8221(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 8179, 8221);
                    return return_v;
                }


                string
                f_1096_8314_8334(System.Management.Automation.TableControlColumn
                this_param)
                {
                    var return_v = this_param.FormatString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 8314, 8334);
                    return return_v;
                }


                int
                f_1096_8271_8335(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 8271, 8335);
                    return 0;
                }


                System.Management.Automation.DisplayEntry
                f_1096_8401_8421(System.Management.Automation.TableControlColumn
                this_param)
                {
                    var return_v = this_param.DisplayEntry;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 8401, 8421);
                    return return_v;
                }


                int
                f_1096_8383_8422(Microsoft.PowerShell.Commands.FormatXmlWriter
                this_param, System.Management.Automation.DisplayEntry
                displayEntry)
                {
                    this_param.WriteDisplayEntry(displayEntry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 8383, 8422);
                    return 0;
                }


                int
                f_1096_8445_8492(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 8445, 8492);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.TableControlColumn>
                f_1096_7843_7854_I(System.Collections.Generic.List<System.Management.Automation.TableControlColumn>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 7843, 7854);
                    return return_v;
                }


                int
                f_1096_8532_8579(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 8532, 8579);
                    return 0;
                }


                int
                f_1096_8598_8642(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 8598, 8642);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.TableControlRow>
                f_1096_7298_7315_I(System.Collections.Generic.List<System.Management.Automation.TableControlRow>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 7298, 7315);
                    return return_v;
                }


                int
                f_1096_8674_8721(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 8674, 8721);
                    return 0;
                }


                int
                f_1096_8738_8782(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 8738, 8782);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1096, 5810, 8794);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1096, 5810, 8794);
            }
        }

        internal void WriteListControl(ListControl listControl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1096, 8806, 10903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 8886, 8927);

                f_1096_8886_8926(_writer, "ListControl");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 8941, 8982);

                f_1096_8941_8981(_writer, "ListEntries");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 9048, 10774);
                    foreach (ListControlEntry entry in f_1096_9083_9102_I(f_1096_9083_9102(listControl)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 9048, 10774);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 9136, 9175);

                        f_1096_9136_9174(_writer, "ListEntry");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 9252, 9296);

                        f_1096_9252_9295(this, f_1096_9273_9294(entry));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 9316, 10697) || true) && (f_1096_9320_9337(f_1096_9320_9331(entry)) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 9316, 10697);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 9383, 9422);

                            f_1096_9383_9421(_writer, "ListItems");
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 9491, 10612);
                                foreach (ListControlEntryItem item in f_1096_9529_9540_I(f_1096_9529_9540(entry)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 9491, 10612);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 9590, 9628);

                                    f_1096_9590_9627(_writer, "ListItem");

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 9656, 9826) || true) && (!f_1096_9661_9693(f_1096_9682_9692(item)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 9656, 9826);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 9751, 9799);

                                        f_1096_9751_9798(_writer, "Label", f_1096_9787_9797(item));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 9656, 9826);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 9854, 10045) || true) && (!f_1096_9859_9898(f_1096_9880_9897(item)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 9854, 10045);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 9956, 10018);

                                        f_1096_9956_10017(_writer, "FormatString", f_1096_9999_10016(item));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 9854, 10045);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 10073, 10411) || true) && (f_1096_10077_10104(item) != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 10073, 10411);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 10170, 10222);

                                        f_1096_10170_10221(_writer, "ItemSelectionCondition");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 10252, 10299);

                                        f_1096_10252_10298(this, f_1096_10270_10297(item));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 10329, 10384);

                                        f_1096_10329_10383(_writer);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 10073, 10411);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 10483, 10520);

                                    f_1096_10483_10519(this, f_1096_10501_10518(item));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 10548, 10589);

                                    f_1096_10548_10588(
                                                            _writer);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 9491, 10612);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1096, 1, 1122);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1096, 1, 1122);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 10636, 10678);

                            f_1096_10636_10677(
                                                _writer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 9316, 10697);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 10717, 10759);

                        f_1096_10717_10758(
                                        _writer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 9048, 10774);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1096, 1, 1727);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1096, 1, 1727);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 10790, 10834);

                f_1096_10790_10833(
                            _writer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 10848, 10892);

                f_1096_10848_10891(_writer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1096, 8806, 10903);

                int
                f_1096_8886_8926(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 8886, 8926);
                    return 0;
                }


                int
                f_1096_8941_8981(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 8941, 8981);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.ListControlEntry>
                f_1096_9083_9102(System.Management.Automation.ListControl
                this_param)
                {
                    var return_v = this_param.Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 9083, 9102);
                    return return_v;
                }


                int
                f_1096_9136_9174(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 9136, 9174);
                    return 0;
                }


                System.Management.Automation.EntrySelectedBy
                f_1096_9273_9294(System.Management.Automation.ListControlEntry
                this_param)
                {
                    var return_v = this_param.EntrySelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 9273, 9294);
                    return return_v;
                }


                int
                f_1096_9252_9295(Microsoft.PowerShell.Commands.FormatXmlWriter
                this_param, System.Management.Automation.EntrySelectedBy
                entrySelectedBy)
                {
                    this_param.WriteEntrySelectedBy(entrySelectedBy);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 9252, 9295);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>
                f_1096_9320_9331(System.Management.Automation.ListControlEntry
                this_param)
                {
                    var return_v = this_param.Items;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 9320, 9331);
                    return return_v;
                }


                int
                f_1096_9320_9337(System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 9320, 9337);
                    return return_v;
                }


                int
                f_1096_9383_9421(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 9383, 9421);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>
                f_1096_9529_9540(System.Management.Automation.ListControlEntry
                this_param)
                {
                    var return_v = this_param.Items;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 9529, 9540);
                    return return_v;
                }


                int
                f_1096_9590_9627(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 9590, 9627);
                    return 0;
                }


                string
                f_1096_9682_9692(System.Management.Automation.ListControlEntryItem
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 9682, 9692);
                    return return_v;
                }


                bool
                f_1096_9661_9693(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 9661, 9693);
                    return return_v;
                }


                string
                f_1096_9787_9797(System.Management.Automation.ListControlEntryItem
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 9787, 9797);
                    return return_v;
                }


                int
                f_1096_9751_9798(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 9751, 9798);
                    return 0;
                }


                string
                f_1096_9880_9897(System.Management.Automation.ListControlEntryItem
                this_param)
                {
                    var return_v = this_param.FormatString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 9880, 9897);
                    return return_v;
                }


                bool
                f_1096_9859_9898(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 9859, 9898);
                    return return_v;
                }


                string
                f_1096_9999_10016(System.Management.Automation.ListControlEntryItem
                this_param)
                {
                    var return_v = this_param.FormatString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 9999, 10016);
                    return return_v;
                }


                int
                f_1096_9956_10017(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 9956, 10017);
                    return 0;
                }


                System.Management.Automation.DisplayEntry
                f_1096_10077_10104(System.Management.Automation.ListControlEntryItem
                this_param)
                {
                    var return_v = this_param.ItemSelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 10077, 10104);
                    return return_v;
                }


                int
                f_1096_10170_10221(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 10170, 10221);
                    return 0;
                }


                System.Management.Automation.DisplayEntry
                f_1096_10270_10297(System.Management.Automation.ListControlEntryItem
                this_param)
                {
                    var return_v = this_param.ItemSelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 10270, 10297);
                    return return_v;
                }


                int
                f_1096_10252_10298(Microsoft.PowerShell.Commands.FormatXmlWriter
                this_param, System.Management.Automation.DisplayEntry
                displayEntry)
                {
                    this_param.WriteDisplayEntry(displayEntry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 10252, 10298);
                    return 0;
                }


                int
                f_1096_10329_10383(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 10329, 10383);
                    return 0;
                }


                System.Management.Automation.DisplayEntry
                f_1096_10501_10518(System.Management.Automation.ListControlEntryItem
                this_param)
                {
                    var return_v = this_param.DisplayEntry;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 10501, 10518);
                    return return_v;
                }


                int
                f_1096_10483_10519(Microsoft.PowerShell.Commands.FormatXmlWriter
                this_param, System.Management.Automation.DisplayEntry
                displayEntry)
                {
                    this_param.WriteDisplayEntry(displayEntry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 10483, 10519);
                    return 0;
                }


                int
                f_1096_10548_10588(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 10548, 10588);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>
                f_1096_9529_9540_I(System.Collections.Generic.List<System.Management.Automation.ListControlEntryItem>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 9529, 9540);
                    return return_v;
                }


                int
                f_1096_10636_10677(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 10636, 10677);
                    return 0;
                }


                int
                f_1096_10717_10758(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 10717, 10758);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.ListControlEntry>
                f_1096_9083_9102_I(System.Collections.Generic.List<System.Management.Automation.ListControlEntry>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 9083, 9102);
                    return return_v;
                }


                int
                f_1096_10790_10833(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 10790, 10833);
                    return 0;
                }


                int
                f_1096_10848_10891(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 10848, 10891);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1096, 8806, 10903);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1096, 8806, 10903);
            }
        }

        private void WriteEntrySelectedBy(EntrySelectedBy entrySelectedBy)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1096, 10915, 12150);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 11006, 12139) || true) && (entrySelectedBy != null && (DynAbs.Tracing.TraceSender.Expression_True(1096, 11010, 11244) && ((f_1096_11056_11081(entrySelectedBy) != null && (DynAbs.Tracing.TraceSender.Expression_True(1096, 11056, 11128) && f_1096_11093_11124(f_1096_11093_11118(entrySelectedBy)) > 0)) || (DynAbs.Tracing.TraceSender.Expression_False(1096, 11055, 11243) || (f_1096_11152_11186(entrySelectedBy) != null && (DynAbs.Tracing.TraceSender.Expression_True(1096, 11152, 11242) && f_1096_11198_11238(f_1096_11198_11232(entrySelectedBy)) > 0))))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 11006, 12139);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 11278, 11323);

                    f_1096_11278_11322(_writer, "EntrySelectedBy");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 11343, 11616) || true) && (f_1096_11347_11372(entrySelectedBy) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 11343, 11616);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 11422, 11597);
                            foreach (string typename in f_1096_11450_11475_I(f_1096_11450_11475(entrySelectedBy)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 11422, 11597);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 11525, 11574);

                                f_1096_11525_11573(_writer, "TypeName", typename);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 11422, 11597);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1096, 1, 176);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1096, 1, 176);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 11343, 11616);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 11636, 12056) || true) && (f_1096_11640_11674(entrySelectedBy) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 11636, 12056);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 11724, 12037);
                            foreach (var condition in f_1096_11750_11784_I(f_1096_11750_11784(entrySelectedBy)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 11724, 12037);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 11834, 11882);

                                f_1096_11834_11881(_writer, "SelectionCondition");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 11908, 11937);

                                f_1096_11908_11936(this, condition);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 11963, 12014);

                                f_1096_11963_12013(_writer);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 11724, 12037);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1096, 1, 314);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1096, 1, 314);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 11636, 12056);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 12076, 12124);

                    f_1096_12076_12123(
                                    _writer);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 11006, 12139);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1096, 10915, 12150);

                System.Collections.Generic.List<string>
                f_1096_11056_11081(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 11056, 11081);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1096_11093_11118(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 11093, 11118);
                    return return_v;
                }


                int
                f_1096_11093_11124(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 11093, 11124);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                f_1096_11152_11186(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.SelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 11152, 11186);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                f_1096_11198_11232(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.SelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 11198, 11232);
                    return return_v;
                }


                int
                f_1096_11198_11238(System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 11198, 11238);
                    return return_v;
                }


                int
                f_1096_11278_11322(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 11278, 11322);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1096_11347_11372(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 11347, 11372);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1096_11450_11475(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 11450, 11475);
                    return return_v;
                }


                int
                f_1096_11525_11573(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 11525, 11573);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1096_11450_11475_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 11450, 11475);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                f_1096_11640_11674(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.SelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 11640, 11674);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                f_1096_11750_11784(System.Management.Automation.EntrySelectedBy
                this_param)
                {
                    var return_v = this_param.SelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 11750, 11784);
                    return return_v;
                }


                int
                f_1096_11834_11881(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 11834, 11881);
                    return 0;
                }


                int
                f_1096_11908_11936(Microsoft.PowerShell.Commands.FormatXmlWriter
                this_param, System.Management.Automation.DisplayEntry
                displayEntry)
                {
                    this_param.WriteDisplayEntry(displayEntry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 11908, 11936);
                    return 0;
                }


                int
                f_1096_11963_12013(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 11963, 12013);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                f_1096_11750_11784_I(System.Collections.Generic.List<System.Management.Automation.DisplayEntry>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 11750, 11784);
                    return return_v;
                }


                int
                f_1096_12076_12123(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 12076, 12123);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1096, 10915, 12150);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1096, 10915, 12150);
            }
        }

        internal void WriteWideControl(WideControl wideControl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1096, 12162, 13456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 12242, 12283);

                f_1096_12242_12282(_writer, "WideControl");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 12299, 12478) || true) && (f_1096_12303_12322(wideControl) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 12299, 12478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 12360, 12463);

                    f_1096_12360_12462(_writer, "ColumnNumber", f_1096_12403_12461(f_1096_12403_12422(wideControl), f_1096_12432_12460()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 12299, 12478);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 12494, 12620) || true) && (f_1096_12498_12518(wideControl))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 12494, 12620);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 12552, 12605);

                    f_1096_12552_12604(_writer, "AutoSize", string.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 12494, 12620);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 12636, 12677);

                f_1096_12636_12676(
                            _writer, "WideEntries");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 12691, 13325);
                    foreach (WideControlEntryItem entry in f_1096_12730_12749_I(f_1096_12730_12749(wideControl)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 12691, 13325);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 12783, 12822);

                        f_1096_12783_12821(_writer, "WideEntry");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 12842, 12886);

                        f_1096_12842_12885(this, f_1096_12863_12884(entry));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 12906, 12944);

                        f_1096_12906_12943(
                                        _writer, "WideItem");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 12962, 13000);

                        f_1096_12962_12999(this, f_1096_12980_12998(entry));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 13018, 13187) || true) && (!f_1096_13023_13063(f_1096_13044_13062(entry)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 13018, 13187);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 13105, 13168);

                            f_1096_13105_13167(_writer, "FormatString", f_1096_13148_13166(entry));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 13018, 13187);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 13207, 13248);

                        f_1096_13207_13247(
                                        _writer);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 13268, 13310);

                        f_1096_13268_13309(
                                        _writer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 12691, 13325);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1096, 1, 635);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1096, 1, 635);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 13341, 13385);

                f_1096_13341_13384(
                            _writer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 13401, 13445);

                f_1096_13401_13444(
                            _writer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1096, 12162, 13456);

                int
                f_1096_12242_12282(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 12242, 12282);
                    return 0;
                }


                uint
                f_1096_12303_12322(System.Management.Automation.WideControl
                this_param)
                {
                    var return_v = this_param.Columns;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 12303, 12322);
                    return return_v;
                }


                uint
                f_1096_12403_12422(System.Management.Automation.WideControl
                this_param)
                {
                    var return_v = this_param.Columns;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 12403, 12422);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1096_12432_12460()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 12432, 12460);
                    return return_v;
                }


                string
                f_1096_12403_12461(uint
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 12403, 12461);
                    return return_v;
                }


                int
                f_1096_12360_12462(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 12360, 12462);
                    return 0;
                }


                bool
                f_1096_12498_12518(System.Management.Automation.WideControl
                this_param)
                {
                    var return_v = this_param.AutoSize;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 12498, 12518);
                    return return_v;
                }


                int
                f_1096_12552_12604(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 12552, 12604);
                    return 0;
                }


                int
                f_1096_12636_12676(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 12636, 12676);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
                f_1096_12730_12749(System.Management.Automation.WideControl
                this_param)
                {
                    var return_v = this_param.Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 12730, 12749);
                    return return_v;
                }


                int
                f_1096_12783_12821(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 12783, 12821);
                    return 0;
                }


                System.Management.Automation.EntrySelectedBy
                f_1096_12863_12884(System.Management.Automation.WideControlEntryItem
                this_param)
                {
                    var return_v = this_param.EntrySelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 12863, 12884);
                    return return_v;
                }


                int
                f_1096_12842_12885(Microsoft.PowerShell.Commands.FormatXmlWriter
                this_param, System.Management.Automation.EntrySelectedBy
                entrySelectedBy)
                {
                    this_param.WriteEntrySelectedBy(entrySelectedBy);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 12842, 12885);
                    return 0;
                }


                int
                f_1096_12906_12943(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 12906, 12943);
                    return 0;
                }


                System.Management.Automation.DisplayEntry
                f_1096_12980_12998(System.Management.Automation.WideControlEntryItem
                this_param)
                {
                    var return_v = this_param.DisplayEntry;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 12980, 12998);
                    return return_v;
                }


                int
                f_1096_12962_12999(Microsoft.PowerShell.Commands.FormatXmlWriter
                this_param, System.Management.Automation.DisplayEntry
                displayEntry)
                {
                    this_param.WriteDisplayEntry(displayEntry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 12962, 12999);
                    return 0;
                }


                string
                f_1096_13044_13062(System.Management.Automation.WideControlEntryItem
                this_param)
                {
                    var return_v = this_param.FormatString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 13044, 13062);
                    return return_v;
                }


                bool
                f_1096_13023_13063(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 13023, 13063);
                    return return_v;
                }


                string
                f_1096_13148_13166(System.Management.Automation.WideControlEntryItem
                this_param)
                {
                    var return_v = this_param.FormatString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 13148, 13166);
                    return return_v;
                }


                int
                f_1096_13105_13167(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 13105, 13167);
                    return 0;
                }


                int
                f_1096_13207_13247(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 13207, 13247);
                    return 0;
                }


                int
                f_1096_13268_13309(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 13268, 13309);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
                f_1096_12730_12749_I(System.Collections.Generic.List<System.Management.Automation.WideControlEntryItem>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 12730, 12749);
                    return return_v;
                }


                int
                f_1096_13341_13384(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 13341, 13384);
                    return 0;
                }


                int
                f_1096_13401_13444(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 13401, 13444);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1096, 12162, 13456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1096, 12162, 13456);
            }
        }

        internal void WriteDisplayEntry(DisplayEntry displayEntry)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1096, 13468, 14052);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 13551, 14041) || true) && (f_1096_13555_13577(displayEntry) == DisplayEntryValueType.Property)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 13551, 14041);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 13645, 13708);

                    f_1096_13645_13707(_writer, "PropertyName", f_1096_13688_13706(displayEntry));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 13551, 14041);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 13551, 14041);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 13742, 14041) || true) && (f_1096_13746_13768(displayEntry) == DisplayEntryValueType.ScriptBlock)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 13742, 14041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 13839, 13880);

                        f_1096_13839_13879(_writer, "ScriptBlock");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 13898, 13964);

                        f_1096_13898_13963(_writer, (DynAbs.Tracing.TraceSender.Conditional_F1(1096, 13917, 13935) || ((_exportScriptBlock && DynAbs.Tracing.TraceSender.Conditional_F2(1096, 13938, 13956)) || DynAbs.Tracing.TraceSender.Conditional_F3(1096, 13959, 13962))) ? f_1096_13938_13956(displayEntry) : ";");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 13982, 14026);

                        f_1096_13982_14025(_writer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 13742, 14041);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 13551, 14041);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1096, 13468, 14052);

                System.Management.Automation.DisplayEntryValueType
                f_1096_13555_13577(System.Management.Automation.DisplayEntry
                this_param)
                {
                    var return_v = this_param.ValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 13555, 13577);
                    return return_v;
                }


                string
                f_1096_13688_13706(System.Management.Automation.DisplayEntry
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 13688, 13706);
                    return return_v;
                }


                int
                f_1096_13645_13707(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 13645, 13707);
                    return 0;
                }


                System.Management.Automation.DisplayEntryValueType
                f_1096_13746_13768(System.Management.Automation.DisplayEntry
                this_param)
                {
                    var return_v = this_param.ValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 13746, 13768);
                    return return_v;
                }


                int
                f_1096_13839_13879(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 13839, 13879);
                    return 0;
                }


                string
                f_1096_13938_13956(System.Management.Automation.DisplayEntry
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 13938, 13956);
                    return return_v;
                }


                int
                f_1096_13898_13963(System.Xml.XmlWriter
                this_param, string
                value)
                {
                    this_param.WriteValue(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 13898, 13963);
                    return 0;
                }


                int
                f_1096_13982_14025(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 13982, 14025);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1096, 13468, 14052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1096, 13468, 14052);
            }
        }

        internal void WriteCustomControl(CustomControl customControl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1096, 14064, 14911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 14150, 14193);

                f_1096_14150_14192(_writer, "CustomControl");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 14209, 14252);

                f_1096_14209_14251(
                            _writer, "CustomEntries");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 14266, 14778);
                    foreach (var entry in f_1096_14288_14309_I(f_1096_14288_14309(customControl)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 14266, 14778);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 14343, 14384);

                        f_1096_14343_14383(_writer, "CustomEntry");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 14402, 14441);

                        f_1096_14402_14440(this, f_1096_14423_14439(entry));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 14459, 14499);

                        f_1096_14459_14498(_writer, "CustomItem");
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 14517, 14638);
                            foreach (var item in f_1096_14538_14555_I(f_1096_14538_14555(entry)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 14517, 14638);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 14597, 14619);

                                f_1096_14597_14618(this, item);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 14517, 14638);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1096, 1, 122);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1096, 1, 122);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 14658, 14701);

                        f_1096_14658_14700(
                                        _writer);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 14719, 14763);

                        f_1096_14719_14762(_writer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 14266, 14778);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1096, 1, 513);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1096, 1, 513);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 14794, 14840);

                f_1096_14794_14839(
                            _writer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 14854, 14900);

                f_1096_14854_14899(_writer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1096, 14064, 14911);

                int
                f_1096_14150_14192(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 14150, 14192);
                    return 0;
                }


                int
                f_1096_14209_14251(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 14209, 14251);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.CustomControlEntry>
                f_1096_14288_14309(System.Management.Automation.CustomControl
                this_param)
                {
                    var return_v = this_param.Entries;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 14288, 14309);
                    return return_v;
                }


                int
                f_1096_14343_14383(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 14343, 14383);
                    return 0;
                }


                System.Management.Automation.EntrySelectedBy
                f_1096_14423_14439(System.Management.Automation.CustomControlEntry
                this_param)
                {
                    var return_v = this_param.SelectedBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 14423, 14439);
                    return return_v;
                }


                int
                f_1096_14402_14440(Microsoft.PowerShell.Commands.FormatXmlWriter
                this_param, System.Management.Automation.EntrySelectedBy
                entrySelectedBy)
                {
                    this_param.WriteEntrySelectedBy(entrySelectedBy);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 14402, 14440);
                    return 0;
                }


                int
                f_1096_14459_14498(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 14459, 14498);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                f_1096_14538_14555(System.Management.Automation.CustomControlEntry
                this_param)
                {
                    var return_v = this_param.CustomItems;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 14538, 14555);
                    return return_v;
                }


                int
                f_1096_14597_14618(Microsoft.PowerShell.Commands.FormatXmlWriter
                this_param, System.Management.Automation.CustomItemBase
                item)
                {
                    this_param.WriteCustomItem(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 14597, 14618);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                f_1096_14538_14555_I(System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 14538, 14555);
                    return return_v;
                }


                int
                f_1096_14658_14700(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 14658, 14700);
                    return 0;
                }


                int
                f_1096_14719_14762(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 14719, 14762);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.CustomControlEntry>
                f_1096_14288_14309_I(System.Collections.Generic.List<System.Management.Automation.CustomControlEntry>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 14288, 14309);
                    return return_v;
                }


                int
                f_1096_14794_14839(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 14794, 14839);
                    return 0;
                }


                int
                f_1096_14854_14899(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 14854, 14899);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1096, 14064, 14911);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1096, 14064, 14911);
            }
        }

        internal void WriteCustomItem(CustomItemBase item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1096, 14923, 17627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 14998, 15038);

                var
                newline = item as CustomItemNewline
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 15052, 15298) || true) && (newline != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 15052, 15298);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 15114, 15119);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 15105, 15256) || true) && (i < f_1096_15125_15138(newline))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 15140, 15143)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 15105, 15256))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 15105, 15256);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 15185, 15237);

                            f_1096_15185_15236(_writer, "NewLine", string.Empty);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1096, 1, 152);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1096, 1, 152);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 15276, 15283);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 15052, 15298);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 15314, 15348);

                var
                text = item as CustomItemText
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 15362, 15498) || true) && (text != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 15362, 15498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 15412, 15458);

                    f_1096_15412_15457(_writer, "Text", f_1096_15447_15456(text));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 15476, 15483);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 15362, 15498);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 15514, 15554);

                var
                expr = item as CustomItemExpression
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 15568, 16557) || true) && (expr != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 15568, 16557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 15618, 15665);

                    f_1096_15618_15664(_writer, "ExpressionBinding");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 15683, 15836) || true) && (f_1096_15687_15711(expr))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 15683, 15836);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 15753, 15817);

                        f_1096_15753_15816(_writer, "EnumerateCollection", string.Empty);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 15683, 15836);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 15856, 16154) || true) && (f_1096_15860_15887(expr) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 15856, 16154);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 15937, 15989);

                        f_1096_15937_15988(_writer, "ItemSelectionCondition");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 16011, 16058);

                        f_1096_16011_16057(this, f_1096_16029_16056(expr));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 16080, 16135);

                        f_1096_16080_16134(_writer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 15856, 16154);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 16174, 16297) || true) && (f_1096_16178_16193(expr) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 16174, 16297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 16243, 16278);

                        f_1096_16243_16277(this, f_1096_16261_16276(expr));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 16174, 16297);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 16317, 16447) || true) && (f_1096_16321_16339(expr) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 16317, 16447);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 16389, 16428);

                        f_1096_16389_16427(this, f_1096_16408_16426(expr));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 16317, 16447);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 16467, 16517);

                    f_1096_16467_16516(
                                    _writer);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 16535, 16542);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 15568, 16557);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 16573, 16607);

                var
                frame = (CustomItemFrame)item
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 16621, 16656);

                f_1096_16621_16655(_writer, "Frame");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 16670, 16812) || true) && (f_1096_16674_16690(frame) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 16670, 16812);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 16714, 16812);

                    f_1096_16714_16811(_writer, "LeftIndent", f_1096_16755_16810(f_1096_16755_16771(frame), f_1096_16781_16809()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 16670, 16812);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 16826, 16971) || true) && (f_1096_16830_16847(frame) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 16826, 16971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 16871, 16971);

                    f_1096_16871_16970(_writer, "RightIndent", f_1096_16913_16969(f_1096_16913_16930(frame), f_1096_16940_16968()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 16826, 16971);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 16985, 17145) || true) && (f_1096_16989_17011(frame) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 16985, 17145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 17035, 17145);

                    f_1096_17035_17144(_writer, "FirstLineHanging", f_1096_17082_17143(f_1096_17082_17104(frame), f_1096_17114_17142()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 16985, 17145);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 17159, 17316) || true) && (f_1096_17163_17184(frame) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 17159, 17316);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 17208, 17316);

                    f_1096_17208_17315(_writer, "FirstLineIndent", f_1096_17254_17314(f_1096_17254_17275(frame), f_1096_17285_17313()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 17159, 17316);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 17332, 17372);

                f_1096_17332_17371(
                            _writer, "CustomItem");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 17386, 17505);
                    foreach (var frameItem in f_1096_17412_17429_I(f_1096_17412_17429(frame)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1096, 17386, 17505);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 17463, 17490);

                        f_1096_17463_17489(this, frameItem);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1096, 17386, 17505);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1096, 1, 120);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1096, 1, 120);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 17521, 17564);

                f_1096_17521_17563(
                            _writer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1096, 17578, 17616);

                f_1096_17578_17615(_writer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1096, 14923, 17627);

                int
                f_1096_15125_15138(System.Management.Automation.CustomItemNewline
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 15125, 15138);
                    return return_v;
                }


                int
                f_1096_15185_15236(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 15185, 15236);
                    return 0;
                }


                string
                f_1096_15447_15456(System.Management.Automation.CustomItemText
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 15447, 15456);
                    return return_v;
                }


                int
                f_1096_15412_15457(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 15412, 15457);
                    return 0;
                }


                int
                f_1096_15618_15664(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 15618, 15664);
                    return 0;
                }


                bool
                f_1096_15687_15711(System.Management.Automation.CustomItemExpression
                this_param)
                {
                    var return_v = this_param.EnumerateCollection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 15687, 15711);
                    return return_v;
                }


                int
                f_1096_15753_15816(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 15753, 15816);
                    return 0;
                }


                System.Management.Automation.DisplayEntry
                f_1096_15860_15887(System.Management.Automation.CustomItemExpression
                this_param)
                {
                    var return_v = this_param.ItemSelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 15860, 15887);
                    return return_v;
                }


                int
                f_1096_15937_15988(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 15937, 15988);
                    return 0;
                }


                System.Management.Automation.DisplayEntry
                f_1096_16029_16056(System.Management.Automation.CustomItemExpression
                this_param)
                {
                    var return_v = this_param.ItemSelectionCondition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 16029, 16056);
                    return return_v;
                }


                int
                f_1096_16011_16057(Microsoft.PowerShell.Commands.FormatXmlWriter
                this_param, System.Management.Automation.DisplayEntry
                displayEntry)
                {
                    this_param.WriteDisplayEntry(displayEntry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 16011, 16057);
                    return 0;
                }


                int
                f_1096_16080_16134(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 16080, 16134);
                    return 0;
                }


                System.Management.Automation.DisplayEntry
                f_1096_16178_16193(System.Management.Automation.CustomItemExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 16178, 16193);
                    return return_v;
                }


                System.Management.Automation.DisplayEntry
                f_1096_16261_16276(System.Management.Automation.CustomItemExpression
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 16261, 16276);
                    return return_v;
                }


                int
                f_1096_16243_16277(Microsoft.PowerShell.Commands.FormatXmlWriter
                this_param, System.Management.Automation.DisplayEntry
                displayEntry)
                {
                    this_param.WriteDisplayEntry(displayEntry);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 16243, 16277);
                    return 0;
                }


                System.Management.Automation.CustomControl
                f_1096_16321_16339(System.Management.Automation.CustomItemExpression
                this_param)
                {
                    var return_v = this_param.CustomControl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 16321, 16339);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1096_16408_16426(System.Management.Automation.CustomItemExpression
                this_param)
                {
                    var return_v = this_param.CustomControl;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 16408, 16426);
                    return return_v;
                }


                int
                f_1096_16389_16427(Microsoft.PowerShell.Commands.FormatXmlWriter
                this_param, System.Management.Automation.CustomControl
                customControl)
                {
                    this_param.WriteCustomControl(customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 16389, 16427);
                    return 0;
                }


                int
                f_1096_16467_16516(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 16467, 16516);
                    return 0;
                }


                int
                f_1096_16621_16655(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 16621, 16655);
                    return 0;
                }


                uint
                f_1096_16674_16690(System.Management.Automation.CustomItemFrame
                this_param)
                {
                    var return_v = this_param.LeftIndent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 16674, 16690);
                    return return_v;
                }


                uint
                f_1096_16755_16771(System.Management.Automation.CustomItemFrame
                this_param)
                {
                    var return_v = this_param.LeftIndent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 16755, 16771);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1096_16781_16809()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 16781, 16809);
                    return return_v;
                }


                string
                f_1096_16755_16810(uint
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 16755, 16810);
                    return return_v;
                }


                int
                f_1096_16714_16811(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 16714, 16811);
                    return 0;
                }


                uint
                f_1096_16830_16847(System.Management.Automation.CustomItemFrame
                this_param)
                {
                    var return_v = this_param.RightIndent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 16830, 16847);
                    return return_v;
                }


                uint
                f_1096_16913_16930(System.Management.Automation.CustomItemFrame
                this_param)
                {
                    var return_v = this_param.RightIndent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 16913, 16930);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1096_16940_16968()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 16940, 16968);
                    return return_v;
                }


                string
                f_1096_16913_16969(uint
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 16913, 16969);
                    return return_v;
                }


                int
                f_1096_16871_16970(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 16871, 16970);
                    return 0;
                }


                uint
                f_1096_16989_17011(System.Management.Automation.CustomItemFrame
                this_param)
                {
                    var return_v = this_param.FirstLineHanging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 16989, 17011);
                    return return_v;
                }


                uint
                f_1096_17082_17104(System.Management.Automation.CustomItemFrame
                this_param)
                {
                    var return_v = this_param.FirstLineHanging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 17082, 17104);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1096_17114_17142()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 17114, 17142);
                    return return_v;
                }


                string
                f_1096_17082_17143(uint
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 17082, 17143);
                    return return_v;
                }


                int
                f_1096_17035_17144(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 17035, 17144);
                    return 0;
                }


                uint
                f_1096_17163_17184(System.Management.Automation.CustomItemFrame
                this_param)
                {
                    var return_v = this_param.FirstLineIndent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 17163, 17184);
                    return return_v;
                }


                uint
                f_1096_17254_17275(System.Management.Automation.CustomItemFrame
                this_param)
                {
                    var return_v = this_param.FirstLineIndent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 17254, 17275);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1096_17285_17313()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 17285, 17313);
                    return return_v;
                }


                string
                f_1096_17254_17314(uint
                this_param, System.Globalization.CultureInfo
                provider)
                {
                    var return_v = this_param.ToString((System.IFormatProvider)provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 17254, 17314);
                    return return_v;
                }


                int
                f_1096_17208_17315(System.Xml.XmlWriter
                this_param, string
                localName, string
                value)
                {
                    this_param.WriteElementString(localName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 17208, 17315);
                    return 0;
                }


                int
                f_1096_17332_17371(System.Xml.XmlWriter
                this_param, string
                localName)
                {
                    this_param.WriteStartElement(localName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 17332, 17371);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                f_1096_17412_17429(System.Management.Automation.CustomItemFrame
                this_param)
                {
                    var return_v = this_param.CustomItems;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1096, 17412, 17429);
                    return return_v;
                }


                int
                f_1096_17463_17489(Microsoft.PowerShell.Commands.FormatXmlWriter
                this_param, System.Management.Automation.CustomItemBase
                item)
                {
                    this_param.WriteCustomItem(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 17463, 17489);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                f_1096_17412_17429_I(System.Collections.Generic.List<System.Management.Automation.CustomItemBase>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 17412, 17429);
                    return return_v;
                }


                int
                f_1096_17521_17563(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 17521, 17563);
                    return 0;
                }


                int
                f_1096_17578_17615(System.Xml.XmlWriter
                this_param)
                {
                    this_param.WriteEndElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1096, 17578, 17615);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1096, 14923, 17627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1096, 14923, 17627);
            }
        }

        static FormatXmlWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1096, 406, 17634);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1096, 406, 17634);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1096, 406, 17634);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1096, 406, 17634);
    }
}
