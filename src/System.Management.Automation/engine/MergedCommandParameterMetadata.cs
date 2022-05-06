// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Management.Automation.Language;
using System.Text;

namespace System.Management.Automation
{
    internal class MergedCommandParameterMetadata
    {
        internal List<MergedCompiledCommandParameter> ReplaceMetadata(MergedCommandParameterMetadata metadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1288, 1097, 2543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 1224, 1280);

                var
                result = f_1288_1237_1279()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 1340, 1368);

                f_1288_1340_1367(
                            // Replace bindable parameters
                            _bindableParameters);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 1382, 1619);
                    foreach (KeyValuePair<string, MergedCompiledCommandParameter> entry in f_1288_1453_1480_I(f_1288_1453_1480(metadata)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 1382, 1619);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 1514, 1562);

                        f_1288_1514_1561(_bindableParameters, entry.Key, entry.Value);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 1580, 1604);

                        f_1288_1580_1603(result, entry.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 1382, 1619);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1288, 1, 238);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1288, 1, 238);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 1635, 1662);

                f_1288_1635_1661(
                            _aliasedParameters);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 1676, 1869);
                    foreach (KeyValuePair<string, MergedCompiledCommandParameter> entry in f_1288_1747_1773_I(f_1288_1747_1773(metadata)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 1676, 1869);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 1807, 1854);

                        f_1288_1807_1853(_aliasedParameters, entry.Key, entry.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 1676, 1869);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1288, 1, 194);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1288, 1, 194);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 1930, 1991);

                _defaultParameterSetName = metadata._defaultParameterSetName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 2005, 2080);

                _nextAvailableParameterSetIndex = metadata._nextAvailableParameterSetIndex;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 2096, 2121);

                f_1288_2096_2120(
                            _parameterSetMap);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 2135, 2194);

                var
                parameterSetMapInList = (List<string>)_parameterSetMap
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 2208, 2266);

                f_1288_2208_2265(parameterSetMapInList, metadata._parameterSetMap);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 2282, 2502);

                f_1288_2282_2501(f_1288_2301_2318() == _nextAvailableParameterSetIndex, "After replacement with the metadata of the new parameters, ParameterSetCount should be equal to nextAvailableParameterSetIndex");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 2518, 2532);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1288, 1097, 2543);

                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1288_1237_1279()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 1237, 1279);
                    return return_v;
                }


                int
                f_1288_1340_1367(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 1340, 1367);
                    return 0;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1288_1453_1480(System.Management.Automation.MergedCommandParameterMetadata
                this_param)
                {
                    var return_v = this_param.BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 1453, 1480);
                    return return_v;
                }


                int
                f_1288_1514_1561(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key, System.Management.Automation.MergedCompiledCommandParameter
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 1514, 1561);
                    return 0;
                }


                int
                f_1288_1580_1603(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 1580, 1603);
                    return 0;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1288_1453_1480_I(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 1453, 1480);
                    return return_v;
                }


                int
                f_1288_1635_1661(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 1635, 1661);
                    return 0;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1288_1747_1773(System.Management.Automation.MergedCommandParameterMetadata
                this_param)
                {
                    var return_v = this_param.AliasedParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 1747, 1773);
                    return return_v;
                }


                int
                f_1288_1807_1853(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key, System.Management.Automation.MergedCompiledCommandParameter
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 1807, 1853);
                    return 0;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1288_1747_1773_I(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 1747, 1773);
                    return return_v;
                }


                int
                f_1288_2096_2120(System.Collections.Generic.IList<string>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 2096, 2120);
                    return 0;
                }


                int
                f_1288_2208_2265(System.Collections.Generic.List<string>
                this_param, System.Collections.Generic.IList<string>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<string>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 2208, 2265);
                    return 0;
                }


                int
                f_1288_2301_2318()
                {
                    var return_v = ParameterSetCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 2301, 2318);
                    return return_v;
                }


                int
                f_1288_2282_2501(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 2282, 2501);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1288, 1097, 2543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1288, 1097, 2543);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<MergedCompiledCommandParameter> AddMetadataForBinder(
                    InternalParameterMetadata parameterMetadata,
                    ParameterBinderAssociation binderAssociation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1288, 3379, 7004);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 3594, 3738) || true) && (parameterMetadata == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 3594, 3738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 3657, 3723);

                    throw f_1288_3663_3722("parameterMetadata");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 3594, 3738);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 3754, 3872);

                Collection<MergedCompiledCommandParameter>
                result =
                f_1288_3823_3871()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 3939, 6963);
                    foreach (KeyValuePair<string, CompiledCommandParameter> bindableParameter in f_1288_4016_4052_I(f_1288_4016_4052(parameterMetadata)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 3939, 6963);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 4086, 4553) || true) && (f_1288_4090_4144(_bindableParameters, bindableParameter.Key))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 4086, 4553);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 4186, 4496);

                            MetadataException
                            exception =
                            f_1288_4241_4495("ParameterNameAlreadyExistsForCommand", null, f_1288_4397_4442(), bindableParameter.Key)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 4518, 4534);

                            throw exception;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 4086, 4553);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 4652, 5211) || true) && (f_1288_4656_4709(_aliasedParameters, bindableParameter.Key))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 4652, 5211);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 4751, 5154);

                            MetadataException
                            exception =
                            f_1288_4806_5153("ParameterNameConflictsWithAlias", null, f_1288_4957_4997(), bindableParameter.Key, f_1288_5080_5152(bindableParameter.Key, _aliasedParameters))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 5176, 5192);

                            throw exception;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 4652, 5211);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 5231, 5380);

                        MergedCompiledCommandParameter
                        mergedParameter =
                        f_1288_5301_5379(bindableParameter.Value, binderAssociation)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 5400, 5464);

                        f_1288_5400_5463(
                                        _bindableParameters, bindableParameter.Key, mergedParameter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 5482, 5510);

                        f_1288_5482_5509(result, mergedParameter);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 5573, 6948);
                            foreach (string aliasName in f_1288_5602_5633_I(f_1288_5602_5633(bindableParameter.Value)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 5573, 6948);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 5675, 6163) || true) && (f_1288_5679_5720(_aliasedParameters, aliasName))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 5675, 6163);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 5770, 6098);

                                    MetadataException
                                    exception =
                                    f_1288_5829_6097("AliasParameterNameAlreadyExistsForCommand", null, f_1288_6002_6052(), aliasName)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 6124, 6140);

                                    throw exception;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 5675, 6163);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 6270, 6854) || true) && (f_1288_6274_6316(_bindableParameters, aliasName))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 6270, 6854);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 6366, 6789);

                                    MetadataException
                                    exception =
                                    f_1288_6425_6788("ParameterNameConflictsWithAlias", null, f_1288_6588_6628(), f_1288_6663_6724(aliasName, _bindableParameters), f_1288_6759_6787(bindableParameter.Value))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 6815, 6831);

                                    throw exception;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 6270, 6854);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 6878, 6929);

                                f_1288_6878_6928(
                                                    _aliasedParameters, aliasName, mergedParameter);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 5573, 6948);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1288, 1, 1376);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1288, 1, 1376);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 3939, 6963);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1288, 1, 3025);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1288, 1, 3025);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 6979, 6993);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1288, 3379, 7004);

                System.Management.Automation.PSArgumentNullException
                f_1288_3663_3722(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 3663, 3722);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1288_3823_3871()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 3823, 3871);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.CompiledCommandParameter>
                f_1288_4016_4052(System.Management.Automation.InternalParameterMetadata
                this_param)
                {
                    var return_v = this_param.BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 4016, 4052);
                    return return_v;
                }


                bool
                f_1288_4090_4144(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 4090, 4144);
                    return return_v;
                }


                string
                f_1288_4397_4442()
                {
                    var return_v = Metadata.ParameterNameAlreadyExistsForCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 4397, 4442);
                    return return_v;
                }


                System.Management.Automation.MetadataException
                f_1288_4241_4495(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.MetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 4241, 4495);
                    return return_v;
                }


                bool
                f_1288_4656_4709(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 4656, 4709);
                    return return_v;
                }


                string
                f_1288_4957_4997()
                {
                    var return_v = Metadata.ParameterNameConflictsWithAlias;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 4957, 4997);
                    return return_v;
                }


                string
                f_1288_5080_5152(string
                key, System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                dict)
                {
                    var return_v = RetrieveParameterNameForAlias(key, dict);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 5080, 5152);
                    return return_v;
                }


                System.Management.Automation.MetadataException
                f_1288_4806_5153(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.MetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 4806, 5153);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1288_5301_5379(System.Management.Automation.CompiledCommandParameter
                parameter, System.Management.Automation.ParameterBinderAssociation
                binderAssociation)
                {
                    var return_v = new System.Management.Automation.MergedCompiledCommandParameter(parameter, binderAssociation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 5301, 5379);
                    return return_v;
                }


                int
                f_1288_5400_5463(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key, System.Management.Automation.MergedCompiledCommandParameter
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 5400, 5463);
                    return 0;
                }


                int
                f_1288_5482_5509(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 5482, 5509);
                    return 0;
                }


                string[]
                f_1288_5602_5633(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Aliases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 5602, 5633);
                    return return_v;
                }


                bool
                f_1288_5679_5720(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 5679, 5720);
                    return return_v;
                }


                string
                f_1288_6002_6052()
                {
                    var return_v = Metadata.AliasParameterNameAlreadyExistsForCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 6002, 6052);
                    return return_v;
                }


                System.Management.Automation.MetadataException
                f_1288_5829_6097(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.MetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 5829, 6097);
                    return return_v;
                }


                bool
                f_1288_6274_6316(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 6274, 6316);
                    return return_v;
                }


                string
                f_1288_6588_6628()
                {
                    var return_v = Metadata.ParameterNameConflictsWithAlias;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 6588, 6628);
                    return return_v;
                }


                string
                f_1288_6663_6724(string
                key, System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                dict)
                {
                    var return_v = RetrieveParameterNameForAlias(key, dict);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 6663, 6724);
                    return return_v;
                }


                string
                f_1288_6759_6787(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 6759, 6787);
                    return return_v;
                }


                System.Management.Automation.MetadataException
                f_1288_6425_6788(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.MetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 6425, 6788);
                    return return_v;
                }


                int
                f_1288_6878_6928(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key, System.Management.Automation.MergedCompiledCommandParameter
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 6878, 6928);
                    return 0;
                }


                string[]
                f_1288_5602_5633_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 5602, 5633);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.CompiledCommandParameter>
                f_1288_4016_4052_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.CompiledCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 4016, 4052);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1288, 3379, 7004);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1288, 3379, 7004);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private uint _nextAvailableParameterSetIndex;

        internal int ParameterSetCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1288, 7540, 7621);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 7576, 7606);

                    return f_1288_7583_7605(_parameterSetMap);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1288, 7540, 7621);

                    int
                    f_1288_7583_7605(System.Collections.Generic.IList<string>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 7583, 7605);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1288, 7485, 7632);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1288, 7485, 7632);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal uint AllParameterSetFlags
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1288, 7819, 7907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 7855, 7892);

                    return (1u << f_1288_7869_7886()) - 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1288, 7819, 7907);

                    int
                    f_1288_7869_7886()
                    {
                        var return_v = ParameterSetCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 7869, 7886);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1288, 7760, 7918);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1288, 7760, 7918);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private IList<string> _parameterSetMap;

        private string _defaultParameterSetName;

        private int AddParameterSetToMap(string parameterSetName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1288, 9488, 10913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 9570, 9585);

                int
                index = -1
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 9599, 10873) || true) && (!f_1288_9604_9642(parameterSetName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 9599, 10873);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 9676, 9727);

                    index = f_1288_9684_9726(_parameterSetMap, parameterSetName);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 9814, 10858) || true) && (index == -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 9814, 10858);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 9871, 10395) || true) && (_nextAvailableParameterSetIndex == uint.MaxValue)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 9871, 10395);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 10044, 10321);

                            ParsingMetadataException
                            parsingException =
                            f_1288_10117_10320("ParsingTooManyParameterSets", null, f_1288_10283_10319())
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 10349, 10372);

                            throw parsingException;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 9871, 10395);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 10419, 10458);

                        f_1288_10419_10457(
                                            _parameterSetMap, parameterSetName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 10480, 10531);

                        index = f_1288_10488_10530(_parameterSetMap, parameterSetName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 10555, 10781);

                        f_1288_10555_10780(index == _nextAvailableParameterSetIndex, "AddParameterSetToMap should always add the parameter set name to the map at the nextAvailableParameterSetIndex");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 10805, 10839);

                        _nextAvailableParameterSetIndex++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 9814, 10858);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 9599, 10873);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 10889, 10902);

                return index;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1288, 9488, 10913);

                bool
                f_1288_9604_9642(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 9604, 9642);
                    return return_v;
                }


                int
                f_1288_9684_9726(System.Collections.Generic.IList<string>
                this_param, string
                item)
                {
                    var return_v = this_param.IndexOf(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 9684, 9726);
                    return return_v;
                }


                string
                f_1288_10283_10319()
                {
                    var return_v = Metadata.ParsingTooManyParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 10283, 10319);
                    return return_v;
                }


                System.Management.Automation.ParsingMetadataException
                f_1288_10117_10320(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ParsingMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 10117, 10320);
                    return return_v;
                }


                int
                f_1288_10419_10457(System.Collections.Generic.IList<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 10419, 10457);
                    return 0;
                }


                int
                f_1288_10488_10530(System.Collections.Generic.IList<string>
                this_param, string
                item)
                {
                    var return_v = this_param.IndexOf(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 10488, 10530);
                    return return_v;
                }


                int
                f_1288_10555_10780(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 10555, 10780);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1288, 9488, 10913);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1288, 9488, 10913);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal uint GenerateParameterSetMappingFromMetadata(string defaultParameterSetName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1288, 11616, 14498);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 11776, 11801);

                f_1288_11776_11800(            // First clear the parameter set map
                            _parameterSetMap);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 11815, 11851);

                _nextAvailableParameterSetIndex = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 11867, 11900);

                uint
                defaultParameterSetFlag = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 11916, 12282) || true) && (!f_1288_11921_11966(defaultParameterSetName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 11916, 12282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 12000, 12051);

                    _defaultParameterSetName = defaultParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 12148, 12206);

                    int
                    index = f_1288_12160_12205(this, defaultParameterSetName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 12224, 12267);

                    defaultParameterSetFlag = (uint)1 << index;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 11916, 12282);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 12393, 14440);
                    foreach (MergedCompiledCommandParameter parameter in f_1288_12446_12471_I(f_1288_12446_12471(f_1288_12446_12464())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 12393, 14440);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 12654, 12684);

                        uint
                        parameterSetBitField = 0
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 12704, 14289);
                            foreach (var keyValuePair in f_1288_12733_12769_I(f_1288_12733_12769(f_1288_12733_12752(parameter))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 12704, 14289);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 12811, 12851);

                                var
                                parameterSetName = keyValuePair.Key
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 12873, 12915);

                                var
                                parameterSetData = keyValuePair.Value
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 12937, 14270) || true) && (f_1288_12941_13045(parameterSetName, ParameterAttribute.AllParameterSets, StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 12937, 14270);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 13209, 13247);

                                    parameterSetData.ParameterSetFlag = 0;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 13273, 13309);

                                    parameterSetData.IsInAllSets = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 13335, 13374);

                                    f_1288_13335_13354(parameter).IsInAllSets = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 12937, 14270);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 12937, 14270);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 13561, 13612);

                                    int
                                    index = f_1288_13573_13611(this, parameterSetName)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 13640, 13830);

                                    f_1288_13640_13829(index >= 0, "AddParameterSetToMap should always be able to add the parameter set name, if not it should throw");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 13927, 13967);

                                    uint
                                    parameterSetBit = (uint)1 << index
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 14052, 14092);

                                    parameterSetBitField |= parameterSetBit;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 14195, 14247);

                                    parameterSetData.ParameterSetFlag = parameterSetBit;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 12937, 14270);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 12704, 14289);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1288, 1, 1586);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1288, 1, 1586);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 14364, 14425);

                        f_1288_14364_14383(parameter).ParameterSetFlags = parameterSetBitField;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 12393, 14440);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1288, 1, 2048);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1288, 1, 2048);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 14456, 14487);

                return defaultParameterSetFlag;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1288, 11616, 14498);

                int
                f_1288_11776_11800(System.Collections.Generic.IList<string>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 11776, 11800);
                    return 0;
                }


                bool
                f_1288_11921_11966(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 11921, 11966);
                    return return_v;
                }


                int
                f_1288_12160_12205(System.Management.Automation.MergedCommandParameterMetadata
                this_param, string
                parameterSetName)
                {
                    var return_v = this_param.AddParameterSetToMap(parameterSetName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 12160, 12205);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1288_12446_12464()
                {
                    var return_v = BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 12446, 12464);
                    return return_v;
                }


                System.Collections.Generic.ICollection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1288_12446_12471(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 12446, 12471);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1288_12733_12752(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 12733, 12752);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1288_12733_12769(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 12733, 12769);
                    return return_v;
                }


                bool
                f_1288_12941_13045(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 12941, 13045);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1288_13335_13354(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 13335, 13354);
                    return return_v;
                }


                int
                f_1288_13573_13611(System.Management.Automation.MergedCommandParameterMetadata
                this_param, string
                parameterSetName)
                {
                    var return_v = this_param.AddParameterSetToMap(parameterSetName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 13573, 13611);
                    return return_v;
                }


                int
                f_1288_13640_13829(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 13640, 13829);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1288_12733_12769_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetSpecificMetadata>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 12733, 12769);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1288_14364_14383(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 14364, 14383);
                    return return_v;
                }


                System.Collections.Generic.ICollection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1288_12446_12471_I(System.Collections.Generic.ICollection<System.Management.Automation.MergedCompiledCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 12446, 12471);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1288, 11616, 14498);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1288, 11616, 14498);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetParameterSetName(uint parameterSet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1288, 14847, 16293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 14926, 14967);

                string
                result = _defaultParameterSetName
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 14983, 15109) || true) && (f_1288_14987_15015(result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 14983, 15109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 15049, 15094);

                    result = ParameterAttribute.AllParameterSets;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 14983, 15109);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 15125, 16252) || true) && (parameterSet != uint.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1288, 15129, 15179) && parameterSet != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 15125, 16252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 15366, 15380);

                    int
                    index = 0
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 15400, 15512) || true) && (((parameterSet >> index) & 0x1) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 15400, 15512);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 15485, 15493);

                            ++index;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 15400, 15512);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1288, 15400, 15512);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1288, 15400, 15512);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 15666, 16237) || true) && (((parameterSet >> (index + 1)) & 0x1) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 15666, 16237);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 15854, 16114) || true) && (index < f_1288_15866_15888(_parameterSetMap))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 15854, 16114);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 15938, 15971);

                            result = f_1288_15947_15970(_parameterSetMap, index);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 15854, 16114);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 15854, 16114);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 16069, 16091);

                            result = string.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 15854, 16114);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 15666, 16237);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 15666, 16237);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 16196, 16218);

                        result = string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 15666, 16237);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 15125, 16252);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 16268, 16282);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1288, 14847, 16293);

                bool
                f_1288_14987_15015(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 14987, 15015);
                    return return_v;
                }


                int
                f_1288_15866_15888(System.Collections.Generic.IList<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 15866, 15888);
                    return return_v;
                }


                string
                f_1288_15947_15970(System.Collections.Generic.IList<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 15947, 15970);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1288, 14847, 16293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1288, 14847, 16293);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string RetrieveParameterNameForAlias(
                    string key,
                    IDictionary<string, MergedCompiledCommandParameter> dict)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1288, 16570, 17196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 16743, 16798);

                MergedCompiledCommandParameter
                mergedParam = f_1288_16788_16797(dict, key)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 16812, 17149) || true) && (mergedParam != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 16812, 17149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 16869, 16932);

                    CompiledCommandParameter
                    compiledParam = f_1288_16910_16931(mergedParam)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 16950, 17134) || true) && (compiledParam != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 16950, 17134);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 17017, 17115) || true) && (!f_1288_17022_17062(f_1288_17043_17061(compiledParam)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 17017, 17115);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 17089, 17115);

                            return f_1288_17096_17114(compiledParam);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 17017, 17115);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 16950, 17134);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 16812, 17149);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 17165, 17185);

                return string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1288, 16570, 17196);

                System.Management.Automation.MergedCompiledCommandParameter
                f_1288_16788_16797(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 16788, 16797);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1288_16910_16931(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 16910, 16931);
                    return return_v;
                }


                string
                f_1288_17043_17061(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 17043, 17061);
                    return return_v;
                }


                bool
                f_1288_17022_17062(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 17022, 17062);
                    return return_v;
                }


                string
                f_1288_17096_17114(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 17096, 17114);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1288, 16570, 17196);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1288, 16570, 17196);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal MergedCompiledCommandParameter GetMatchingParameter(
                    string name,
                    bool throwOnParameterNotFound,
                    bool tryExactMatching,
                    InvocationInfo invocationInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1288, 18283, 23663);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 18519, 18647) || true) && (f_1288_18523_18549(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 18519, 18647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 18583, 18632);

                    throw f_1288_18589_18631("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 18519, 18647);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 18663, 18793);

                Collection<MergedCompiledCommandParameter>
                matchingParameters =
                f_1288_18744_18792()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 18857, 18984) || true) && (f_1288_18861_18872(name) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(1288, 18861, 18910) && f_1288_18880_18910(f_1288_18902_18909(name, 0))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 18857, 18984);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 18944, 18969);

                    name = f_1288_18951_18968(name, 1);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 18857, 18984);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 19061, 19816);
                    foreach (string parameterName in f_1288_19094_19118_I(f_1288_19094_19118(_bindableParameters)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 19061, 19816);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 19152, 19801) || true) && (f_1288_19156_19253(f_1288_19156_19196(f_1288_19156_19184()), parameterName, name, CompareOptions.IgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 19152, 19801);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 19416, 19782) || true) && (tryExactMatching && (DynAbs.Tracing.TraceSender.Expression_True(1288, 19420, 19510) && f_1288_19440_19510(parameterName, name, StringComparison.OrdinalIgnoreCase)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 19416, 19782);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 19560, 19602);

                                return f_1288_19567_19601(_bindableParameters, parameterName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 19416, 19782);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 19416, 19782);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 19700, 19759);

                                f_1288_19700_19758(matchingParameters, f_1288_19723_19757(_bindableParameters, parameterName));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 19416, 19782);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 19152, 19801);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 19061, 19816);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1288, 1, 756);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1288, 1, 756);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 19872, 20776);
                    foreach (string parameterName in f_1288_19905_19928_I(f_1288_19905_19928(_aliasedParameters)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 19872, 20776);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 19962, 20761) || true) && (f_1288_19966_20063(f_1288_19966_20006(f_1288_19966_19994()), parameterName, name, CompareOptions.IgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 19962, 20761);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 20226, 20742) || true) && (tryExactMatching && (DynAbs.Tracing.TraceSender.Expression_True(1288, 20230, 20320) && f_1288_20250_20320(parameterName, name, StringComparison.OrdinalIgnoreCase)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 20226, 20742);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 20370, 20411);

                                return f_1288_20377_20410(_aliasedParameters, parameterName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 20226, 20742);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 20226, 20742);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 20509, 20719) || true) && (!f_1288_20514_20576(matchingParameters, f_1288_20542_20575(_aliasedParameters, parameterName)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 20509, 20719);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 20634, 20692);

                                    f_1288_20634_20691(matchingParameters, f_1288_20657_20690(_aliasedParameters, parameterName));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 20509, 20719);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 20226, 20742);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 19962, 20761);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 19872, 20776);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1288, 1, 905);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1288, 1, 905);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 20792, 23435) || true) && (f_1288_20796_20820(matchingParameters) > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 20792, 23435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 20933, 21067);

                    Collection<MergedCompiledCommandParameter>
                    filteredParameters =
                    f_1288_21018_21066()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 21087, 21552);
                        foreach (MergedCompiledCommandParameter matchingParameter in f_1288_21148_21166_I(matchingParameters))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 21087, 21552);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 21208, 21533) || true) && ((f_1288_21213_21248(matchingParameter) == ParameterBinderAssociation.DeclaredFormalParameters) || (DynAbs.Tracing.TraceSender.Expression_False(1288, 21212, 21418) || (f_1288_21334_21369(matchingParameter) == ParameterBinderAssociation.DynamicParameters)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 21208, 21533);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 21468, 21510);

                                f_1288_21468_21509(filteredParameters, matchingParameter);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 21208, 21533);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 21087, 21552);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1288, 1, 466);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1288, 1, 466);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 21572, 22720) || true) && (tryExactMatching && (DynAbs.Tracing.TraceSender.Expression_True(1288, 21576, 21625) && f_1288_21596_21620(filteredParameters) == 1))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 21572, 22720);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 21667, 21707);

                        matchingParameters = filteredParameters;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 21572, 22720);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 21572, 22720);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 21789, 21841);

                        StringBuilder
                        possibleMatches = f_1288_21821_21840()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 21865, 22129);
                            foreach (MergedCompiledCommandParameter matchingParameter in f_1288_21926_21944_I(matchingParameters))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 21865, 22129);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 21994, 22023);

                                f_1288_21994_22022(possibleMatches, " -");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 22049, 22106);

                                f_1288_22049_22105(possibleMatches, f_1288_22072_22104(f_1288_22072_22099(matchingParameter)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 21865, 22129);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1288, 1, 265);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1288, 1, 265);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 22153, 22661);

                        ParameterBindingException
                        exception =
                        f_1288_22216_22660(ErrorCategory.InvalidArgument, invocationInfo, null, name, null, null, f_1288_22521_22562(), "AmbiguousParameter", possibleMatches)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 22685, 22701);

                        throw exception;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 21572, 22720);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 20792, 23435);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 20792, 23435);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 22754, 23435) || true) && (f_1288_22758_22782(matchingParameters) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 22754, 23435);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 22821, 23420) || true) && (throwOnParameterNotFound)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 22821, 23420);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 22891, 23361);

                            ParameterBindingException
                            exception =
                            f_1288_22954_23360(ErrorCategory.InvalidArgument, invocationInfo, null, name, null, null, f_1288_23259_23304(), "NamedParameterNotFound")
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 23385, 23401);

                            throw exception;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 22821, 23420);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 22754, 23435);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 20792, 23435);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 23451, 23496);

                MergedCompiledCommandParameter
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 23510, 23622) || true) && (f_1288_23514_23538(matchingParameters) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 23510, 23622);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 23576, 23607);

                    result = f_1288_23585_23606(matchingParameters, 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 23510, 23622);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 23638, 23652);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1288, 18283, 23663);

                bool
                f_1288_18523_18549(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 18523, 18549);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1288_18589_18631(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 18589, 18631);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1288_18744_18792()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 18744, 18792);
                    return return_v;
                }


                int
                f_1288_18861_18872(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 18861, 18872);
                    return return_v;
                }


                char
                f_1288_18902_18909(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 18902, 18909);
                    return return_v;
                }


                bool
                f_1288_18880_18910(char
                c)
                {
                    var return_v = c.IsDash();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 18880, 18910);
                    return return_v;
                }


                string
                f_1288_18951_18968(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 18951, 18968);
                    return return_v;
                }


                System.Collections.Generic.ICollection<string>
                f_1288_19094_19118(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 19094, 19118);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1288_19156_19184()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 19156, 19184);
                    return return_v;
                }


                System.Globalization.CompareInfo
                f_1288_19156_19196(System.Globalization.CultureInfo
                this_param)
                {
                    var return_v = this_param.CompareInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 19156, 19196);
                    return return_v;
                }


                bool
                f_1288_19156_19253(System.Globalization.CompareInfo
                this_param, string
                source, string
                prefix, System.Globalization.CompareOptions
                options)
                {
                    var return_v = this_param.IsPrefix(source, prefix, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 19156, 19253);
                    return return_v;
                }


                bool
                f_1288_19440_19510(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 19440, 19510);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1288_19567_19601(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 19567, 19601);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1288_19723_19757(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 19723, 19757);
                    return return_v;
                }


                int
                f_1288_19700_19758(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 19700, 19758);
                    return 0;
                }


                System.Collections.Generic.ICollection<string>
                f_1288_19094_19118_I(System.Collections.Generic.ICollection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 19094, 19118);
                    return return_v;
                }


                System.Collections.Generic.ICollection<string>
                f_1288_19905_19928(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 19905, 19928);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1288_19966_19994()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 19966, 19994);
                    return return_v;
                }


                System.Globalization.CompareInfo
                f_1288_19966_20006(System.Globalization.CultureInfo
                this_param)
                {
                    var return_v = this_param.CompareInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 19966, 20006);
                    return return_v;
                }


                bool
                f_1288_19966_20063(System.Globalization.CompareInfo
                this_param, string
                source, string
                prefix, System.Globalization.CompareOptions
                options)
                {
                    var return_v = this_param.IsPrefix(source, prefix, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 19966, 20063);
                    return return_v;
                }


                bool
                f_1288_20250_20320(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 20250, 20320);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1288_20377_20410(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 20377, 20410);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1288_20542_20575(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 20542, 20575);
                    return return_v;
                }


                bool
                f_1288_20514_20576(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 20514, 20576);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1288_20657_20690(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 20657, 20690);
                    return return_v;
                }


                int
                f_1288_20634_20691(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 20634, 20691);
                    return 0;
                }


                System.Collections.Generic.ICollection<string>
                f_1288_19905_19928_I(System.Collections.Generic.ICollection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 19905, 19928);
                    return return_v;
                }


                int
                f_1288_20796_20820(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 20796, 20820);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1288_21018_21066()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 21018, 21066);
                    return return_v;
                }


                System.Management.Automation.ParameterBinderAssociation
                f_1288_21213_21248(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.BinderAssociation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 21213, 21248);
                    return return_v;
                }


                System.Management.Automation.ParameterBinderAssociation
                f_1288_21334_21369(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.BinderAssociation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 21334, 21369);
                    return return_v;
                }


                int
                f_1288_21468_21509(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 21468, 21509);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1288_21148_21166_I(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 21148, 21166);
                    return return_v;
                }


                int
                f_1288_21596_21620(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 21596, 21620);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1288_21821_21840()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 21821, 21840);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1288_21994_22022(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 21994, 22022);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1288_22072_22099(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 22072, 22099);
                    return return_v;
                }


                string
                f_1288_22072_22104(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 22072, 22104);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1288_22049_22105(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 22049, 22105);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1288_21926_21944_I(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 21926, 21944);
                    return return_v;
                }


                string
                f_1288_22521_22562()
                {
                    var return_v = ParameterBinderStrings.AmbiguousParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 22521, 22562);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1288_22216_22660(System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingException(errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 22216, 22660);
                    return return_v;
                }


                int
                f_1288_22758_22782(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 22758, 22782);
                    return return_v;
                }


                string
                f_1288_23259_23304()
                {
                    var return_v = ParameterBinderStrings.NamedParameterNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 23259, 23304);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1288_22954_23360(System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingException(errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 22954, 23360);
                    return return_v;
                }


                int
                f_1288_23514_23538(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 23514, 23538);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1288_23585_23606(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 23585, 23606);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1288, 18283, 23663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1288, 18283, 23663);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<MergedCompiledCommandParameter> GetParametersInParameterSet(uint parameterSetFlag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1288, 24107, 24742);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 24234, 24352);

                Collection<MergedCompiledCommandParameter>
                result =
                f_1288_24303_24351()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 24368, 24701);
                    foreach (MergedCompiledCommandParameter parameter in f_1288_24421_24446_I(f_1288_24421_24446(f_1288_24421_24439())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 24368, 24701);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 24480, 24686) || true) && ((parameterSetFlag & f_1288_24504_24541(f_1288_24504_24523(parameter))) != 0 || (DynAbs.Tracing.TraceSender.Expression_False(1288, 24484, 24603) || f_1288_24572_24603(f_1288_24572_24591(parameter))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1288, 24480, 24686);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 24645, 24667);

                            f_1288_24645_24666(result, parameter);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 24480, 24686);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1288, 24368, 24701);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1288, 1, 334);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1288, 1, 334);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 24717, 24731);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1288, 24107, 24742);

                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1288_24303_24351()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 24303, 24351);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1288_24421_24439()
                {
                    var return_v = BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 24421, 24439);
                    return return_v;
                }


                System.Collections.Generic.ICollection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1288_24421_24446(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 24421, 24446);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1288_24504_24523(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 24504, 24523);
                    return return_v;
                }


                uint
                f_1288_24504_24541(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 24504, 24541);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1288_24572_24591(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 24572, 24591);
                    return return_v;
                }


                bool
                f_1288_24572_24603(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.IsInAllSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 24572, 24603);
                    return return_v;
                }


                int
                f_1288_24645_24666(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 24645, 24666);
                    return 0;
                }


                System.Collections.Generic.ICollection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1288_24421_24446_I(System.Collections.Generic.ICollection<System.Management.Automation.MergedCompiledCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 24421, 24446);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1288, 24107, 24742);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1288, 24107, 24742);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IDictionary<string, MergedCompiledCommandParameter> BindableParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1288, 25094, 25129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 25100, 25127);

                    return _bindableParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1288, 25094, 25129);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1288, 25012, 25131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1288, 25012, 25131);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private IDictionary<string, MergedCompiledCommandParameter> _bindableParameters;

        internal IDictionary<string, MergedCompiledCommandParameter> AliasedParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1288, 25656, 25690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 25662, 25688);

                    return _aliasedParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1288, 25656, 25690);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1288, 25575, 25692);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1288, 25575, 25692);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private IDictionary<string, MergedCompiledCommandParameter> _aliasedParameters;

        internal void MakeReadOnly()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1288, 25899, 26269);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 25952, 26058);

                _bindableParameters = f_1288_25974_26057(_bindableParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 26072, 26176);

                _aliasedParameters = f_1288_26093_26175(_aliasedParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 26190, 26258);

                _parameterSetMap = f_1288_26209_26257(_parameterSetMap);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1288, 25899, 26269);

                System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1288_25974_26057(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                dictionary)
                {
                    var return_v = new System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>(dictionary);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 25974, 26057);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1288_26093_26175(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                dictionary)
                {
                    var return_v = new System.Collections.ObjectModel.ReadOnlyDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>(dictionary);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 26093, 26175);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<string>
                f_1288_26209_26257(System.Collections.Generic.IList<string>
                list)
                {
                    var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<string>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 26209, 26257);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1288, 25899, 26269);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1288, 25899, 26269);
            }
        }

        internal void ResetReadOnly()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1288, 26281, 26622);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 26335, 26467);

                _bindableParameters = f_1288_26357_26466(_bindableParameters, f_1288_26433_26465());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 26481, 26611);

                _aliasedParameters = f_1288_26502_26610(_aliasedParameters, f_1288_26577_26609());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1288, 26281, 26622);

                System.StringComparer
                f_1288_26433_26465()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 26433, 26465);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1288_26357_26466(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                dictionary, System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>(dictionary, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 26357, 26466);
                    return return_v;
                }


                System.StringComparer
                f_1288_26577_26609()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 26577, 26609);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1288_26502_26610(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                dictionary, System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>(dictionary, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 26502, 26610);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1288, 26281, 26622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1288, 26281, 26622);
            }
        }

        public MergedCommandParameterMetadata()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1288, 318, 26629);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 7311, 7342);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 8295, 8332);
            this._parameterSetMap = f_1288_8314_8332();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 8459, 8483);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 25203, 25326);
            this._bindableParameters = f_1288_25238_25326(f_1288_25293_25325());
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 25764, 25886);
            this._aliasedParameters = f_1288_25798_25886(f_1288_25853_25885());
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1288, 318, 26629);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1288, 318, 26629);
        }


        static MergedCommandParameterMetadata()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1288, 318, 26629);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1288, 318, 26629);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1288, 318, 26629);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1288, 318, 26629);

        System.Collections.Generic.List<string>
        f_1288_8314_8332()
        {
            var return_v = new System.Collections.Generic.List<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 8314, 8332);
            return return_v;
        }


        System.StringComparer
        f_1288_25293_25325()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 25293, 25325);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
        f_1288_25238_25326(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 25238, 25326);
            return return_v;
        }


        System.StringComparer
        f_1288_25853_25885()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 25853, 25885);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
        f_1288_25798_25886(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 25798, 25886);
            return return_v;
        }

    }
    internal class MergedCompiledCommandParameter
    {
        internal MergedCompiledCommandParameter(
                        CompiledCommandParameter parameter,
                        ParameterBinderAssociation binderAssociation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1288, 27306, 27676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 27805, 27870);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 28024, 28099);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 27487, 27567);

                f_1288_27487_27566(parameter != null, "caller to verify parameter is not null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 27581, 27608);

                this.Parameter = parameter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 27622, 27665);

                this.BinderAssociation = binderAssociation;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1288, 27306, 27676);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1288, 27306, 27676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1288, 27306, 27676);
            }
        }

        internal CompiledCommandParameter Parameter { get; private set; }

        internal ParameterBinderAssociation BinderAssociation { get; private set; }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1288, 28111, 28208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1288, 28169, 28197);

                return f_1288_28176_28196(f_1288_28176_28185());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1288, 28111, 28208);

                System.Management.Automation.CompiledCommandParameter
                f_1288_28176_28185()
                {
                    var return_v = Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1288, 28176, 28185);
                    return return_v;
                }


                string
                f_1288_28176_28196(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 28176, 28196);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1288, 28111, 28208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1288, 28111, 28208);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MergedCompiledCommandParameter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1288, 26815, 28215);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1288, 26815, 28215);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1288, 26815, 28215);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1288, 26815, 28215);

        int
        f_1288_27487_27566(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1288, 27487, 27566);
            return 0;
        }

    }

    /// <summary>
    /// This enum is used in the MergedCompiledCommandParameter class
    /// to associate a particular CompiledCommandParameter with the
    /// appropriate ParameterBinder.
    /// </summary>
    internal enum ParameterBinderAssociation
    {
        /// <summary>
        /// The parameter was declared as a formal parameter in the command type.
        /// </summary>
        DeclaredFormalParameters,

        /// <summary>
        /// The parameter was declared as a dynamic parameter for the command.
        /// </summary>
        DynamicParameters,

        /// <summary>
        /// The parameter is a common parameter found in the CommonParameters class.
        /// </summary>
        CommonParameters,

        /// <summary>
        /// The parameter is a ShouldProcess parameter found in the ShouldProcessParameters class.
        /// </summary>
        ShouldProcessParameters,

        /// <summary>
        /// The parameter is a transactions parameter found in the TransactionParameters class.
        /// </summary>
        TransactionParameters,

        /// <summary>
        /// The parameter is a Paging parameter found in the PagingParameters class.
        /// </summary>
        PagingParameters,
    }
}

