// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

using Microsoft.PowerShell.Commands;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Remoting
{
    public sealed class PSSessionConfigurationData
    {
        public static bool IsServerManager;

        public List<string> ModulesToImport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1638, 687, 762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 723, 747);

                    return _modulesToImport;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1638, 687, 762);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1638, 627, 773);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1638, 627, 773);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal List<object> ModulesToImportInternal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1638, 855, 938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 891, 923);

                    return _modulesToImportInternal;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1638, 855, 938);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1638, 785, 949);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1638, 785, 949);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string PrivateData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1638, 1058, 1129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 1094, 1114);

                    return _privateData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1638, 1058, 1129);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1638, 1008, 1237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1638, 1008, 1237);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            internal set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1638, 1145, 1226);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 1190, 1211);

                    _privateData = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1638, 1145, 1226);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1638, 1008, 1237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1638, 1008, 1237);
                }
            }
        }

        private PSSessionConfigurationData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1638, 1325, 1383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 5085, 5101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 5133, 5157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 5185, 5197);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1638, 1325, 1383);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1638, 1325, 1383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1638, 1325, 1383);
            }
        }

        internal static string Unescape(string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1638, 1395, 1743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 1461, 1501);

                StringBuilder
                sb = f_1638_1480_1500(s)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 1515, 1539);

                f_1638_1515_1538(sb, "&lt;", "<");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 1553, 1577);

                f_1638_1553_1576(sb, "&gt;", ">");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 1591, 1618);

                f_1638_1591_1617(sb, "&quot;", "\"");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 1632, 1658);

                f_1638_1632_1657(sb, "&apos;", "'");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 1672, 1697);

                f_1638_1672_1696(sb, "&amp;", "&");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 1711, 1732);

                return f_1638_1718_1731(sb);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1638, 1395, 1743);

                System.Text.StringBuilder
                f_1638_1480_1500(string
                value)
                {
                    var return_v = new System.Text.StringBuilder(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 1480, 1500);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1638_1515_1538(System.Text.StringBuilder
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 1515, 1538);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1638_1553_1576(System.Text.StringBuilder
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 1553, 1576);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1638_1591_1617(System.Text.StringBuilder
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 1591, 1617);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1638_1632_1657(System.Text.StringBuilder
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 1632, 1657);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1638_1672_1696(System.Text.StringBuilder
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 1672, 1696);
                    return return_v;
                }


                string
                f_1638_1718_1731(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 1718, 1731);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1638, 1395, 1743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1638, 1395, 1743);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSSessionConfigurationData Create(string configurationData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1638, 1755, 4978);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 1855, 1931);

                PSSessionConfigurationData
                configuration = f_1638_1898_1930()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 1947, 2013) || true) && (f_1638_1951_1990(configurationData))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1638, 1947, 2013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 1992, 2013);

                    return configuration;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1638, 1947, 2013);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 2029, 2077);

                configurationData = f_1638_2049_2076(configurationData);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 2093, 2465);

                XmlReaderSettings
                readerSettings = new XmlReaderSettings
                {
                    CheckCharacters = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => false, 1638, 2128, 2464),
                    IgnoreComments = true,
                    IgnoreProcessingInstructions = true,
                    MaxCharactersInDocument = 10000,
                    XmlResolver = null,
                    ConformanceLevel = ConformanceLevel.Fragment
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 2481, 4870);
                using (XmlReader
                reader = f_1638_2507_2576(f_1638_2524_2559(configurationData), readerSettings)
                )
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 2673, 4855) || true) && (f_1638_2677_2719(reader, SessionConfigToken))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1638, 2673, 4855);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 2761, 2817);

                        bool
                        isParamFound = f_1638_2781_2816(reader, ParamToken)
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 2839, 4836) || true) && (isParamFound)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1638, 2839, 4836);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 2908, 3249) || true) && (!f_1638_2913_2946(reader, NameToken))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1638, 2908, 3249);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 3004, 3222);

                                    throw f_1638_3010_3221(configurationData, f_1638_3097_3152(), NameToken, ValueToken, ParamToken);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1638, 2908, 3249);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 3277, 3310);

                                string
                                optionName = f_1638_3297_3309(reader)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 3338, 4681) || true) && (f_1638_3342_3421(optionName, PrivateDataToken, StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1638, 3338, 4681);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 3598, 3962) || true) && (f_1638_3602_3642(reader, PrivateDataToken))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1638, 3598, 3962);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 3708, 3751);

                                        string
                                        privateData = f_1638_3729_3750(reader)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 3787, 3856);

                                        f_1638_3787_3855(PrivateDataToken, configuration._privateData);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 3890, 3931);

                                        configuration._privateData = privateData;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1638, 3598, 3962);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1638, 3338, 4681);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1638, 3338, 4681);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 4076, 4512) || true) && (!f_1638_4081_4115(reader, ValueToken))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1638, 4076, 4512);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 4181, 4481);

                                        throw f_1638_4187_4480(configurationData, f_1638_4315_4370(), NameToken, ValueToken, ParamToken);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1638, 4076, 4512);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 4544, 4578);

                                    string
                                    optionValue = f_1638_4565_4577(reader)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 4608, 4654);

                                    f_1638_4608_4653(configuration, optionName, optionValue);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1638, 3338, 4681);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 4763, 4813);

                                isParamFound = f_1638_4778_4812(reader, ParamToken);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1638, 2839, 4836);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1638, 2839, 4836);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1638, 2839, 4836);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1638, 2673, 4855);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1638, 2481, 4870);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 4886, 4930);

                f_1638_4886_4929(
                            configuration);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 4946, 4967);

                return configuration;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1638, 1755, 4978);

                System.Management.Automation.Remoting.PSSessionConfigurationData
                f_1638_1898_1930()
                {
                    var return_v = new System.Management.Automation.Remoting.PSSessionConfigurationData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 1898, 1930);
                    return return_v;
                }


                bool
                f_1638_1951_1990(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 1951, 1990);
                    return return_v;
                }


                string
                f_1638_2049_2076(string
                s)
                {
                    var return_v = Unescape(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 2049, 2076);
                    return return_v;
                }


                System.IO.StringReader
                f_1638_2524_2559(string
                s)
                {
                    var return_v = new System.IO.StringReader(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 2524, 2559);
                    return return_v;
                }


                System.Xml.XmlReader
                f_1638_2507_2576(System.IO.StringReader
                input, System.Xml.XmlReaderSettings
                settings)
                {
                    var return_v = XmlReader.Create((System.IO.TextReader)input, settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 2507, 2576);
                    return return_v;
                }


                bool
                f_1638_2677_2719(System.Xml.XmlReader
                this_param, string
                name)
                {
                    var return_v = this_param.ReadToFollowing(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 2677, 2719);
                    return return_v;
                }


                bool
                f_1638_2781_2816(System.Xml.XmlReader
                this_param, string
                name)
                {
                    var return_v = this_param.ReadToDescendant(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 2781, 2816);
                    return return_v;
                }


                bool
                f_1638_2913_2946(System.Xml.XmlReader
                this_param, string
                name)
                {
                    var return_v = this_param.MoveToAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 2913, 2946);
                    return return_v;
                }


                string
                f_1638_3097_3152()
                {
                    var return_v = RemotingErrorIdStrings.NoAttributesFoundForParamElement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1638, 3097, 3152);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1638_3010_3221(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 3010, 3221);
                    return return_v;
                }


                string
                f_1638_3297_3309(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1638, 3297, 3309);
                    return return_v;
                }


                bool
                f_1638_3342_3421(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 3342, 3421);
                    return return_v;
                }


                bool
                f_1638_3602_3642(System.Xml.XmlReader
                this_param, string
                name)
                {
                    var return_v = this_param.ReadToFollowing(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 3602, 3642);
                    return return_v;
                }


                string
                f_1638_3729_3750(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.ReadOuterXml();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 3729, 3750);
                    return return_v;
                }


                int
                f_1638_3787_3855(string
                optionName, string
                originalValue)
                {
                    AssertValueNotAssigned(optionName, (object)originalValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 3787, 3855);
                    return 0;
                }


                bool
                f_1638_4081_4115(System.Xml.XmlReader
                this_param, string
                name)
                {
                    var return_v = this_param.MoveToAttribute(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 4081, 4115);
                    return return_v;
                }


                string
                f_1638_4315_4370()
                {
                    var return_v = RemotingErrorIdStrings.NoAttributesFoundForParamElement;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1638, 4315, 4370);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1638_4187_4480(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 4187, 4480);
                    return return_v;
                }


                string
                f_1638_4565_4577(System.Xml.XmlReader
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1638, 4565, 4577);
                    return return_v;
                }


                int
                f_1638_4608_4653(System.Management.Automation.Remoting.PSSessionConfigurationData
                this_param, string
                optionName, string
                optionValue)
                {
                    this_param.Update(optionName, optionValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 4608, 4653);
                    return 0;
                }


                bool
                f_1638_4778_4812(System.Xml.XmlReader
                this_param, string
                name)
                {
                    var return_v = this_param.ReadToFollowing(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 4778, 4812);
                    return return_v;
                }


                int
                f_1638_4886_4929(System.Management.Automation.Remoting.PSSessionConfigurationData
                this_param)
                {
                    this_param.CreateCollectionIfNecessary();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 4886, 4929);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1638, 1755, 4978);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1638, 1755, 4978);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private List<string> _modulesToImport;

        private List<object> _modulesToImportInternal;

        private string _privateData;

        private static void AssertValueNotAssigned(string optionName, object originalValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1638, 5557, 5918);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 5665, 5907) || true) && (originalValue != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1638, 5665, 5907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 5724, 5892);

                    throw f_1638_5730_5891(optionName, f_1638_5798_5858(), optionName, SessionConfigToken);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1638, 5665, 5907);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1638, 5557, 5918);

                string
                f_1638_5798_5858()
                {
                    var return_v = RemotingErrorIdStrings.DuplicateInitializationParameterFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1638, 5798, 5858);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1638_5730_5891(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 5730, 5891);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1638, 5557, 5918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1638, 5557, 5918);
            }
        }

        private void Update(string optionName, string optionValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1638, 6406, 8051);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 6489, 8040);

                switch (f_1638_6497_6526(optionName))
                {

                    case ModulesToImportToken:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1638, 6489, 8040);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 6635, 6698);

                            f_1638_6635_6697(ModulesToImportToken, _modulesToImport);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 6724, 6762);

                            _modulesToImport = f_1638_6743_6761();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 6788, 6834);

                            _modulesToImportInternal = f_1638_6815_6833();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 6860, 6959);

                            object[]
                            modulesToImport = f_1638_6887_6958(optionValue, new[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 6985, 7798);
                                foreach (var module in f_1638_7008_7023_I(modulesToImport))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1638, 6985, 7798);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 7081, 7106);

                                    var
                                    s = module as string
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 7136, 7771) || true) && (s != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1638, 7136, 7771);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 7215, 7246);

                                        f_1638_7215_7245(_modulesToImport, f_1638_7236_7244(s));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 7282, 7320);

                                        ModuleSpecification
                                        moduleSpec = null
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 7354, 7740) || true) && (f_1638_7358_7405(s, out moduleSpec))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1638, 7354, 7740);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 7479, 7520);

                                            f_1638_7479_7519(_modulesToImportInternal, moduleSpec);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1638, 7354, 7740);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1638, 7354, 7740);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 7666, 7705);

                                            f_1638_7666_7704(_modulesToImportInternal, f_1638_7695_7703(s));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1638, 7354, 7740);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1638, 7136, 7771);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1638, 6985, 7798);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1638, 1, 814);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1638, 1, 814);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1638, 7845, 7851);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1638, 6489, 8040);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1638, 6489, 8040);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 7926, 7972);

                            f_1638_7926_7971(false, "Unknown option specified");
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1638, 8019, 8025);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1638, 6489, 8040);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1638, 6406, 8051);

                string
                f_1638_6497_6526(string
                this_param)
                {
                    var return_v = this_param.ToLowerInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 6497, 6526);
                    return return_v;
                }


                int
                f_1638_6635_6697(string
                optionName, System.Collections.Generic.List<string>
                originalValue)
                {
                    AssertValueNotAssigned(optionName, (object)originalValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 6635, 6697);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1638_6743_6761()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 6743, 6761);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1638_6815_6833()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 6815, 6833);
                    return return_v;
                }


                string[]
                f_1638_6887_6958(string
                this_param, string[]
                separator, System.StringSplitOptions
                options)
                {
                    var return_v = this_param.Split(separator, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 6887, 6958);
                    return return_v;
                }


                string
                f_1638_7236_7244(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 7236, 7244);
                    return return_v;
                }


                int
                f_1638_7215_7245(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 7215, 7245);
                    return 0;
                }


                bool
                f_1638_7358_7405(string
                input, out Microsoft.PowerShell.Commands.ModuleSpecification
                result)
                {
                    var return_v = ModuleSpecification.TryParse(input, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 7358, 7405);
                    return return_v;
                }


                int
                f_1638_7479_7519(System.Collections.Generic.List<object>
                this_param, Microsoft.PowerShell.Commands.ModuleSpecification
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 7479, 7519);
                    return 0;
                }


                string
                f_1638_7695_7703(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 7695, 7703);
                    return return_v;
                }


                int
                f_1638_7666_7704(System.Collections.Generic.List<object>
                this_param, string
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 7666, 7704);
                    return 0;
                }


                object[]
                f_1638_7008_7023_I(object[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 7008, 7023);
                    return return_v;
                }


                int
                f_1638_7926_7971(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 7926, 7971);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1638, 6406, 8051);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1638, 6406, 8051);
            }
        }

        private void CreateCollectionIfNecessary()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1638, 8063, 8307);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 8130, 8198) || true) && (_modulesToImport == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1638, 8130, 8198);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 8160, 8198);

                    _modulesToImport = f_1638_8179_8197();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1638, 8130, 8198);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 8212, 8296) || true) && (_modulesToImportInternal == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1638, 8212, 8296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 8250, 8296);

                    _modulesToImportInternal = f_1638_8277_8295();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1638, 8212, 8296);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1638, 8063, 8307);

                System.Collections.Generic.List<string>
                f_1638_8179_8197()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 8179, 8197);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1638_8277_8295()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1638, 8277, 8295);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1638, 8063, 8307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1638, 8063, 8307);
            }
        }

        private const string
        SessionConfigToken = "SessionConfigurationData"
        ;

        internal const string
        ModulesToImportToken = "modulestoimport"
        ;

        internal const string
        PrivateDataToken = "PrivateData"
        ;

        internal const string
        InProcActivityToken = "InProcActivity"
        ;

        private const string
        ParamToken = "Param"
        ;

        private const string
        NameToken = "Name"
        ;

        private const string
        ValueToken = "Value"
        ;

        static PSSessionConfigurationData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1638, 386, 8796);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 515, 530);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 8340, 8387);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 8420, 8460);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 8493, 8525);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 8558, 8596);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 8628, 8648);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 8680, 8698);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1638, 8730, 8750);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1638, 386, 8796);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1638, 386, 8796);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1638, 386, 8796);
    }
}
