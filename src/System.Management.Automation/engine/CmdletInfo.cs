// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation.Language;
using System.Text;

namespace System.Management.Automation
{
    public class CmdletInfo : CommandInfo
    {
        internal CmdletInfo(
                    string name,
                    Type implementingType,
                    string helpFile,
                    PSSnapInInfo PSSnapin,
                    ExecutionContext context)
        : base(f_1242_1469_1473_C(name), CommandTypes.Cmdlet, context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1242, 1261, 2492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 5466, 5486);
                this._verb = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 5733, 5753);
                this._noun = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 6837, 6865);
                this._helpFilePath = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 7282, 7291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 8343, 8351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 8631, 8655);
                this._implementingType = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 13404, 13422);
                this._outputType = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 14074, 14107);
                this._options = ScopedItemOptions.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 18805, 18820);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 1529, 1657) || true) && (f_1242_1533_1559(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 1529, 1657);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 1593, 1642);

                    throw f_1242_1599_1641("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 1529, 1657);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 1725, 2019) || true) && (!f_1242_1730_1773(name, out _verb, out _noun))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 1725, 2019);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 1807, 2004);

                    throw
                    f_1242_1834_2003("name", f_1242_1928_1971(), name);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 1725, 2019);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 2035, 2072);

                _implementingType = implementingType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 2086, 2111);

                _helpFilePath = helpFile;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 2125, 2146);

                _PSSnapin = PSSnapin;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 2160, 2198);

                _options = ScopedItemOptions.ReadOnly;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 2425, 2481);

                this.DefiningLanguageMode = PSLanguageMode.FullLanguage;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1242, 1261, 2492);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 1261, 2492);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 1261, 2492);
            }
        }

        internal CmdletInfo(CmdletInfo other)
        : base(f_1242_2682_2687_C(other))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1242, 2624, 2980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 5466, 5486);
                this._verb = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 5733, 5753);
                this._noun = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 6837, 6865);
                this._helpFilePath = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 7282, 7291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 8343, 8351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 8631, 8655);
                this._implementingType = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 13404, 13422);
                this._outputType = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 14074, 14107);
                this._options = ScopedItemOptions.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 18805, 18820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 2713, 2733);

                _verb = other._verb;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 2747, 2767);

                _noun = other._noun;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 2781, 2825);

                _implementingType = other._implementingType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 2839, 2875);

                _helpFilePath = other._helpFilePath;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 2889, 2917);

                _PSSnapin = other._PSSnapin;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 2931, 2969);

                _options = ScopedItemOptions.ReadOnly;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1242, 2624, 2980);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 2624, 2980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 2624, 2980);
            }
        }

        internal override CommandInfo CreateGetCommandCopy(object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1242, 3221, 3476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 3316, 3355);

                CmdletInfo
                copy = f_1242_3334_3354(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 3369, 3398);

                copy.IsGetCommandCopy = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 3412, 3439);

                copy.Arguments = arguments;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 3453, 3465);

                return copy;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1242, 3221, 3476);

                System.Management.Automation.CmdletInfo
                f_1242_3334_3354(System.Management.Automation.CmdletInfo
                other)
                {
                    var return_v = new System.Management.Automation.CmdletInfo(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 3334, 3354);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 3221, 3476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 3221, 3476);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CmdletInfo(string name, Type implementingType)
        : base(f_1242_4002_4006_C(name), CommandTypes.Cmdlet, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1242, 3928, 5159);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 5466, 5486);
                this._verb = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 5733, 5753);
                this._noun = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 6837, 6865);
                this._helpFilePath = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 7282, 7291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 8343, 8351);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 8631, 8655);
                this._implementingType = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 13404, 13422);
                this._outputType = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 14074, 14107);
                this._options = ScopedItemOptions.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 18805, 18820);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 4059, 4191) || true) && (f_1242_4063_4089(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 4059, 4191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 4123, 4176);

                    throw f_1242_4129_4175("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 4059, 4191);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 4207, 4337) || true) && (implementingType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 4207, 4337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 4269, 4322);

                    throw f_1242_4275_4321("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 4207, 4337);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 4353, 4607) || true) && (!f_1242_4358_4407(typeof(Cmdlet), implementingType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 4353, 4607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 4441, 4592);

                    throw f_1242_4447_4591(f_1242_4490_4543(), "implementingType", f_1242_4565_4590(implementingType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 4353, 4607);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 4675, 4969) || true) && (!f_1242_4680_4723(name, out _verb, out _noun))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 4675, 4969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 4757, 4954);

                    throw
                    f_1242_4784_4953("name", f_1242_4878_4921(), name);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 4675, 4969);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 4985, 5022);

                _implementingType = implementingType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 5036, 5065);

                _helpFilePath = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 5079, 5096);

                _PSSnapin = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 5110, 5148);

                _options = ScopedItemOptions.ReadOnly;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1242, 3928, 5159);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 3928, 5159);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 3928, 5159);
            }
        }

        public string Verb
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1242, 5364, 5428);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 5400, 5413);

                    return _verb;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1242, 5364, 5428);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 5321, 5439);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 5321, 5439);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _verb;

        public string Noun
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1242, 5631, 5695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 5667, 5680);

                    return _noun;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1242, 5631, 5695);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 5588, 5706);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 5588, 5706);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _noun;

        internal static bool SplitCmdletName(string name, out string verb, out string noun)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1242, 5766, 6470);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 5874, 5901);

                noun = verb = string.Empty;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 5915, 5977) || true) && (f_1242_5919_5945(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 5915, 5977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 5964, 5977);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 5915, 5977);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 5993, 6007);

                int
                index = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 6030, 6035);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 6021, 6239) || true) && (i < f_1242_6041_6052(name))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 6054, 6057)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 6021, 6239))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 6021, 6239);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 6091, 6224) || true) && (f_1242_6095_6125(f_1242_6117_6124(name, i)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 6091, 6224);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 6167, 6177);

                            index = i;
                            DynAbs.Tracing.TraceSender.TraceBreak(1242, 6199, 6205);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 6091, 6224);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1242, 1, 219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1242, 1, 219);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 6255, 6430) || true) && (index > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 6255, 6430);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 6302, 6334);

                    verb = f_1242_6309_6333(name, 0, index);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 6352, 6385);

                    noun = f_1242_6359_6384(name, index + 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 6403, 6415);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 6255, 6430);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 6446, 6459);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1242, 5766, 6470);

                bool
                f_1242_5919_5945(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 5919, 5945);
                    return return_v;
                }


                int
                f_1242_6041_6052(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 6041, 6052);
                    return return_v;
                }


                char
                f_1242_6117_6124(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 6117, 6124);
                    return return_v;
                }


                bool
                f_1242_6095_6125(char
                c)
                {
                    var return_v = c.IsDash();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 6095, 6125);
                    return return_v;
                }


                string
                f_1242_6309_6333(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 6309, 6333);
                    return return_v;
                }


                string
                f_1242_6359_6384(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 6359, 6384);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 5766, 6470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 5766, 6470);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string HelpFile
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1242, 6629, 6701);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 6665, 6686);

                    return _helpFilePath;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1242, 6629, 6701);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 6582, 6810);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 6582, 6810);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            internal set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1242, 6717, 6799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 6762, 6784);

                    _helpFilePath = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1242, 6717, 6799);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 6582, 6810);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 6582, 6810);
                }
            }
        }

        private string _helpFilePath;

        internal override HelpCategory HelpCategory
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1242, 6946, 6981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 6952, 6979);

                    return HelpCategory.Cmdlet;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1242, 6946, 6981);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 6878, 6992);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 6878, 6992);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PSSnapInInfo PSSnapIn
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1242, 7170, 7238);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 7206, 7223);

                    return _PSSnapin;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1242, 7170, 7238);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 7117, 7249);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 7117, 7249);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private PSSnapInInfo _PSSnapin;

        internal string PSSnapInName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1242, 7477, 7707);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 7513, 7534);

                    string
                    result = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 7552, 7658) || true) && (_PSSnapin != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 7552, 7658);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 7615, 7639);

                        result = f_1242_7624_7638(_PSSnapin);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 7552, 7658);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 7678, 7692);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1242, 7477, 7707);

                    string
                    f_1242_7624_7638(System.Management.Automation.PSSnapInInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 7624, 7638);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 7424, 7718);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 7424, 7718);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Version Version
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1242, 7871, 8304);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 7907, 8253) || true) && (_version == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 7907, 8253);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 7969, 8234) || true) && (f_1242_7973_7979() != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 7969, 8234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 8037, 8061);

                            _version = DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.Version, 1242, 8048, 8060);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 7969, 8234);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 7969, 8234);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 8111, 8234) || true) && (_PSSnapin != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 8111, 8234);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 8182, 8211);

                                _version = f_1242_8193_8210(_PSSnapin);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 8111, 8234);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 7969, 8234);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 7907, 8253);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 8273, 8289);

                    return _version;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1242, 7871, 8304);

                    System.Management.Automation.PSModuleInfo
                    f_1242_7973_7979()
                    {
                        var return_v = Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 7973, 7979);
                        return return_v;
                    }


                    System.Version
                    f_1242_8193_8210(System.Management.Automation.PSSnapInInfo
                    this_param)
                    {
                        var return_v = this_param.Version;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 8193, 8210);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 7815, 8315);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 7815, 8315);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Version _version;

        public Type ImplementingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1242, 8519, 8595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 8555, 8580);

                    return _implementingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1242, 8519, 8595);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 8466, 8606);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 8466, 8606);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Type _implementingType;

        public override string Definition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1242, 8819, 10169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 8855, 8900);

                    StringBuilder
                    synopsis = f_1242_8880_8899()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 8920, 10107) || true) && (f_1242_8924_8945(this) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 8920, 10107);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 8995, 9588);
                            foreach (CommandParameterSetInfo parameterSet in f_1242_9044_9057_I(f_1242_9044_9057()))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 8995, 9588);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 9107, 9129);

                                f_1242_9107_9128(synopsis);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 9155, 9565);

                                f_1242_9155_9564(synopsis, f_1242_9205_9563(f_1242_9253_9300(), "{0}{1}{2} {3}", _verb, StringLiterals.CommandVerbNounSeparator, _noun, f_1242_9539_9562(parameterSet)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 8995, 9588);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1242, 1, 594);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1242, 1, 594);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 8920, 10107);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 8920, 10107);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 9764, 10088);

                        f_1242_9764_10087(                    // Skip the synopsis documentation if the cmdlet hasn't been loaded yet.
                                            synopsis, f_1242_9810_10086(f_1242_9854_9901(), "{0}{1}{2}", _verb, StringLiterals.CommandVerbNounSeparator, _noun));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 8920, 10107);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 10127, 10154);

                    return f_1242_10134_10153(synopsis);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1242, 8819, 10169);

                    System.Text.StringBuilder
                    f_1242_8880_8899()
                    {
                        var return_v = new System.Text.StringBuilder();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 8880, 8899);
                        return return_v;
                    }


                    System.Type
                    f_1242_8924_8945(System.Management.Automation.CmdletInfo
                    this_param)
                    {
                        var return_v = this_param.ImplementingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 8924, 8945);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>
                    f_1242_9044_9057()
                    {
                        var return_v = ParameterSets;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 9044, 9057);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_1242_9107_9128(System.Text.StringBuilder
                    this_param)
                    {
                        var return_v = this_param.AppendLine();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 9107, 9128);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1242_9253_9300()
                    {
                        var return_v = System.Globalization.CultureInfo.CurrentCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 9253, 9300);
                        return return_v;
                    }


                    string
                    f_1242_9539_9562(System.Management.Automation.CommandParameterSetInfo
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 9539, 9562);
                        return return_v;
                    }


                    string
                    f_1242_9205_9563(System.Globalization.CultureInfo
                    provider, string
                    format, params object?[]
                    args)
                    {
                        var return_v = string.Format((System.IFormatProvider)provider, format, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 9205, 9563);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_1242_9155_9564(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.AppendLine(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 9155, 9564);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>
                    f_1242_9044_9057_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 9044, 9057);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1242_9854_9901()
                    {
                        var return_v = System.Globalization.CultureInfo.CurrentCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 9854, 9901);
                        return return_v;
                    }


                    string
                    f_1242_9810_10086(System.Globalization.CultureInfo
                    provider, string
                    format, string
                    arg0, char
                    arg1, string
                    arg2)
                    {
                        var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 9810, 10086);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_1242_9764_10087(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.AppendLine(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 9764, 10087);
                        return return_v;
                    }


                    string
                    f_1242_10134_10153(System.Text.StringBuilder
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 10134, 10153);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 8761, 10180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 8761, 10180);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string DefaultParameterSet
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1242, 10354, 10457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 10390, 10442);

                    return f_1242_10397_10441(f_1242_10397_10417(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1242, 10354, 10457);

                    System.Management.Automation.CommandMetadata
                    f_1242_10397_10417(System.Management.Automation.CmdletInfo
                    this_param)
                    {
                        var return_v = this_param.CommandMetadata;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 10397, 10417);
                        return return_v;
                    }


                    string
                    f_1242_10397_10441(System.Management.Automation.CommandMetadata
                    this_param)
                    {
                        var return_v = this_param.DefaultParameterSetName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 10397, 10441);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 10296, 10468);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 10296, 10468);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ReadOnlyCollection<PSTypeName> OutputType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1242, 10671, 13356);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 10707, 11243) || true) && (_outputType == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 10707, 11243);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 10772, 10809);

                        _outputType = f_1242_10786_10808();

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 10833, 11224) || true) && (f_1242_10837_10853() != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 10833, 11224);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 10911, 11201);
                                foreach (object o in f_1242_10932_11004_I(f_1242_10932_11004(f_1242_10932_10948(), typeof(OutputTypeAttribute), false)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 10911, 11201);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 11062, 11112);

                                    OutputTypeAttribute
                                    attr = (OutputTypeAttribute)o
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 11142, 11174);

                                    f_1242_11142_11173(_outputType, f_1242_11163_11172(attr));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 10911, 11201);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1242, 1, 291);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1242, 1, 291);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 10833, 11224);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 10707, 11243);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 11263, 11319);

                    List<PSTypeName>
                    providerTypes = f_1242_11296_11318()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 11339, 13266) || true) && (f_1242_11343_11350() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 11339, 13266);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 11400, 11429);

                        ProviderInfo
                        provider = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 11451, 12653) || true) && (f_1242_11455_11464() != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 11451, 12653);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 11856, 11861);
                                // See if we have a path argument - we only consider named arguments -Path and -LiteralPath,
                                // and only if they are fully specified (no prefixes allowed, so we don't need to deal with
                                // ambiguities that the parameter binder would resolve for us.

                                for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 11847, 12630) || true) && (i < f_1242_11867_11883(f_1242_11867_11876()) - 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 11889, 11892)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 11847, 12630))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 11847, 12630);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 11950, 11983);

                                    var
                                    arg = f_1242_11960_11969()[i] as string
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 12013, 12603) || true) && (arg != null && (DynAbs.Tracing.TraceSender.Expression_True(1242, 12017, 12223) && (f_1242_12066_12121(arg, "-Path", StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1242, 12066, 12222) || (f_1242_12159_12221(arg, "-LiteralPath", StringComparison.OrdinalIgnoreCase))))))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 12013, 12603);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 12289, 12327);

                                        var
                                        path = f_1242_12300_12309()[i + 1] as string
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 12361, 12572) || true) && (path != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 12361, 12572);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 12451, 12537);

                                            f_1242_12451_12536(f_1242_12451_12476(f_1242_12451_12471(f_1242_12451_12458())), path, true, out provider);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 12361, 12572);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 12013, 12603);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1242, 1, 784);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1242, 1, 784);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 11451, 12653);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 12677, 12931) || true) && (provider == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 12677, 12931);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 12846, 12908);

                            provider = f_1242_12857_12907(f_1242_12857_12898(f_1242_12857_12882(f_1242_12857_12877(f_1242_12857_12864()))));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 12677, 12931);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 12955, 13000);

                        f_1242_12955_12999(
                                            provider, f_1242_12979_12983(), providerTypes);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 13022, 13247) || true) && (f_1242_13026_13045(providerTypes) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 13022, 13247);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 13099, 13141);

                            f_1242_13099_13140(providerTypes, 0, _outputType);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 13167, 13224);

                            return f_1242_13174_13223(providerTypes);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 13022, 13247);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 11339, 13266);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 13286, 13341);

                    return f_1242_13293_13340(_outputType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1242, 10671, 13356);

                    System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                    f_1242_10786_10808()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.PSTypeName>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 10786, 10808);
                        return return_v;
                    }


                    System.Type
                    f_1242_10837_10853()
                    {
                        var return_v = ImplementingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 10837, 10853);
                        return return_v;
                    }


                    System.Type
                    f_1242_10932_10948()
                    {
                        var return_v = ImplementingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 10932, 10948);
                        return return_v;
                    }


                    object[]
                    f_1242_10932_11004(System.Type
                    this_param, System.Type
                    attributeType, bool
                    inherit)
                    {
                        var return_v = this_param.GetCustomAttributes(attributeType, inherit);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 10932, 11004);
                        return return_v;
                    }


                    System.Management.Automation.PSTypeName[]
                    f_1242_11163_11172(System.Management.Automation.OutputTypeAttribute
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 11163, 11172);
                        return return_v;
                    }


                    int
                    f_1242_11142_11173(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                    this_param, System.Management.Automation.PSTypeName[]
                    collection)
                    {
                        this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>)collection);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 11142, 11173);
                        return 0;
                    }


                    object[]
                    f_1242_10932_11004_I(object[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 10932, 11004);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                    f_1242_11296_11318()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.PSTypeName>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 11296, 11318);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1242_11343_11350()
                    {
                        var return_v = Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 11343, 11350);
                        return return_v;
                    }


                    object[]
                    f_1242_11455_11464()
                    {
                        var return_v = Arguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 11455, 11464);
                        return return_v;
                    }


                    object[]
                    f_1242_11867_11876()
                    {
                        var return_v = Arguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 11867, 11876);
                        return return_v;
                    }


                    int
                    f_1242_11867_11883(object[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 11867, 11883);
                        return return_v;
                    }


                    object[]
                    f_1242_11960_11969()
                    {
                        var return_v = Arguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 11960, 11969);
                        return return_v;
                    }


                    bool
                    f_1242_12066_12121(string
                    this_param, string
                    value, System.StringComparison
                    comparisonType)
                    {
                        var return_v = this_param.Equals(value, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 12066, 12121);
                        return return_v;
                    }


                    bool
                    f_1242_12159_12221(string
                    this_param, string
                    value, System.StringComparison
                    comparisonType)
                    {
                        var return_v = this_param.Equals(value, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 12159, 12221);
                        return return_v;
                    }


                    object[]
                    f_1242_12300_12309()
                    {
                        var return_v = Arguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 12300, 12309);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1242_12451_12458()
                    {
                        var return_v = Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 12451, 12458);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1242_12451_12471(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.SessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 12451, 12471);
                        return return_v;
                    }


                    System.Management.Automation.PathIntrinsics
                    f_1242_12451_12476(System.Management.Automation.SessionState
                    this_param)
                    {
                        var return_v = this_param.Path;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 12451, 12476);
                        return return_v;
                    }


                    System.Collections.ObjectModel.Collection<string>
                    f_1242_12451_12536(System.Management.Automation.PathIntrinsics
                    this_param, string
                    path, bool
                    allowNonexistingPaths, out System.Management.Automation.ProviderInfo
                    provider)
                    {
                        var return_v = this_param.GetResolvedProviderPathFromPSPath(path, allowNonexistingPaths, out provider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 12451, 12536);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1242_12857_12864()
                    {
                        var return_v = Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 12857, 12864);
                        return return_v;
                    }


                    System.Management.Automation.SessionState
                    f_1242_12857_12877(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.SessionState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 12857, 12877);
                        return return_v;
                    }


                    System.Management.Automation.PathIntrinsics
                    f_1242_12857_12882(System.Management.Automation.SessionState
                    this_param)
                    {
                        var return_v = this_param.Path;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 12857, 12882);
                        return return_v;
                    }


                    System.Management.Automation.PathInfo
                    f_1242_12857_12898(System.Management.Automation.PathIntrinsics
                    this_param)
                    {
                        var return_v = this_param.CurrentLocation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 12857, 12898);
                        return return_v;
                    }


                    System.Management.Automation.ProviderInfo
                    f_1242_12857_12907(System.Management.Automation.PathInfo
                    this_param)
                    {
                        var return_v = this_param.Provider;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 12857, 12907);
                        return return_v;
                    }


                    string
                    f_1242_12979_12983()
                    {
                        var return_v = Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 12979, 12983);
                        return return_v;
                    }


                    int
                    f_1242_12955_12999(System.Management.Automation.ProviderInfo
                    this_param, string
                    cmdletname, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                    listToAppend)
                    {
                        this_param.GetOutputTypes(cmdletname, listToAppend);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 12955, 12999);
                        return 0;
                    }


                    int
                    f_1242_13026_13045(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 13026, 13045);
                        return return_v;
                    }


                    int
                    f_1242_13099_13140(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                    this_param, int
                    index, System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                    collection)
                    {
                        this_param.InsertRange(index, (System.Collections.Generic.IEnumerable<System.Management.Automation.PSTypeName>)collection);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 13099, 13140);
                        return 0;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
                    f_1242_13174_13223(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                    list)
                    {
                        var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>((System.Collections.Generic.IList<System.Management.Automation.PSTypeName>)list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 13174, 13223);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
                    f_1242_13293_13340(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
                    list)
                    {
                        var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>((System.Collections.Generic.IList<System.Management.Automation.PSTypeName>)list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 13293, 13340);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 10589, 13367);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 10589, 13367);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private List<PSTypeName> _outputType;

        public ScopedItemOptions Options
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1242, 13866, 13933);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 13902, 13918);

                    return _options;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1242, 13866, 13933);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 13809, 14036);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 13809, 14036);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1242, 13949, 14025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 13985, 14010);

                    f_1242_13985_14009(this, value, false);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1242, 13949, 14025);

                    int
                    f_1242_13985_14009(System.Management.Automation.CmdletInfo
                    this_param, System.Management.Automation.ScopedItemOptions
                    newOptions, bool
                    force)
                    {
                        this_param.SetOptions(newOptions, force);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 13985, 14009);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 13809, 14036);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 13809, 14036);
                }
            }
        }

        private ScopedItemOptions _options;

        internal void SetOptions(ScopedItemOptions newOptions, bool force)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1242, 14532, 15254);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 14761, 15205) || true) && ((_options & ScopedItemOptions.ReadOnly) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 14761, 15205);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 14843, 15162);

                    SessionStateUnauthorizedAccessException
                    e =
                    f_1242_14908_15161(f_1242_14982_14986(), SessionStateCategory.Cmdlet, "CmdletIsReadOnly", f_1242_15124_15160())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 15182, 15190);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 14761, 15205);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 15221, 15243);

                _options = newOptions;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1242, 14532, 15254);

                string
                f_1242_14982_14986()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 14982, 14986);
                    return return_v;
                }


                string
                f_1242_15124_15160()
                {
                    var return_v = SessionStateStrings.CmdletIsReadOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 15124, 15160);
                    return return_v;
                }


                System.Management.Automation.SessionStateUnauthorizedAccessException
                f_1242_14908_15161(string
                itemName, System.Management.Automation.SessionStateCategory
                sessionStateCategory, string
                errorIdAndResourceId, string
                resourceStr)
                {
                    var return_v = new System.Management.Automation.SessionStateUnauthorizedAccessException(itemName, sessionStateCategory, errorIdAndResourceId, resourceStr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 14908, 15161);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 14532, 15254);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 14532, 15254);
            }
        }

        private static string GetFullName(string moduleName, string cmdletName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1242, 15469, 15857);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 15565, 15639);

                f_1242_15565_15638(cmdletName != null, "cmdletName != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 15653, 15680);

                string
                result = cmdletName
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 15694, 15816) || true) && (!f_1242_15699_15731(moduleName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 15694, 15816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 15765, 15801);

                    result = moduleName + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ('\\').ToString(), 1242, 15787, 15791) + result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 15694, 15816);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 15832, 15846);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1242, 15469, 15857);

                int
                f_1242_15565_15638(bool
                condition, string
                message)
                {
                    System.Diagnostics.Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 15565, 15638);
                    return 0;
                }


                bool
                f_1242_15699_15731(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 15699, 15731);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 15469, 15857);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 15469, 15857);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetFullName(CmdletInfo cmdletInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1242, 15991, 16142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 16072, 16131);

                return f_1242_16079_16130(f_1242_16091_16112(cmdletInfo), f_1242_16114_16129(cmdletInfo));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1242, 15991, 16142);

                string
                f_1242_16091_16112(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 16091, 16112);
                    return return_v;
                }


                string
                f_1242_16114_16129(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 16114, 16129);
                    return return_v;
                }


                string
                f_1242_16079_16130(string
                moduleName, string
                cmdletName)
                {
                    var return_v = GetFullName(moduleName, cmdletName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 16079, 16130);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 15991, 16142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 15991, 16142);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetFullName(PSObject psObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1242, 16276, 17328);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 16437, 17317) || true) && (f_1242_16441_16460(psObject) is CmdletInfo)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 16437, 17317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 16508, 16564);

                    CmdletInfo
                    cmdletInfo = (CmdletInfo)f_1242_16544_16563(psObject)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 16582, 16613);

                    return f_1242_16589_16612(cmdletInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 16437, 17317);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 16437, 17317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 16877, 16935);

                    PSPropertyInfo
                    nameProperty = f_1242_16907_16934(f_1242_16907_16926(psObject), "Name")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 16953, 17019);

                    PSPropertyInfo
                    psSnapInProperty = f_1242_16987_17018(f_1242_16987_17006(psObject), "PSSnapIn")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 17037, 17122);

                    string
                    nameString = (DynAbs.Tracing.TraceSender.Conditional_F1(1242, 17057, 17077) || ((nameProperty == null && DynAbs.Tracing.TraceSender.Conditional_F2(1242, 17080, 17092)) || DynAbs.Tracing.TraceSender.Conditional_F3(1242, 17095, 17121))) ? string.Empty : (string)f_1242_17103_17121(nameProperty)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 17140, 17237);

                    string
                    psSnapInString = (DynAbs.Tracing.TraceSender.Conditional_F1(1242, 17164, 17188) || ((psSnapInProperty == null && DynAbs.Tracing.TraceSender.Conditional_F2(1242, 17191, 17203)) || DynAbs.Tracing.TraceSender.Conditional_F3(1242, 17206, 17236))) ? string.Empty : (string)f_1242_17214_17236(psSnapInProperty)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 17255, 17302);

                    return f_1242_17262_17301(psSnapInString, nameString);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 16437, 17317);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1242, 16276, 17328);

                object
                f_1242_16441_16460(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 16441, 16460);
                    return return_v;
                }


                object
                f_1242_16544_16563(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 16544, 16563);
                    return return_v;
                }


                string
                f_1242_16589_16612(System.Management.Automation.CmdletInfo
                cmdletInfo)
                {
                    var return_v = GetFullName(cmdletInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 16589, 16612);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1242_16907_16926(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 16907, 16926);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1242_16907_16934(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 16907, 16934);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1242_16987_17006(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 16987, 17006);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1242_16987_17018(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 16987, 17018);
                    return return_v;
                }


                object
                f_1242_17103_17121(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 17103, 17121);
                    return return_v;
                }


                object
                f_1242_17214_17236(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 17214, 17236);
                    return return_v;
                }


                string
                f_1242_17262_17301(string
                moduleName, string
                cmdletName)
                {
                    var return_v = GetFullName(moduleName, cmdletName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 17262, 17301);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 16276, 17328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 16276, 17328);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string FullName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1242, 17511, 17587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 17547, 17572);

                    return f_1242_17554_17571(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1242, 17511, 17587);

                    string
                    f_1242_17554_17571(System.Management.Automation.CmdletInfo
                    cmdletInfo)
                    {
                        var return_v = GetFullName(cmdletInfo);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 17554, 17571);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 17462, 17598);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 17462, 17598);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override CommandMetadata CommandMetadata
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1242, 18574, 18758);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 18610, 18743);

                    return _cmdletMetadata ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.CommandMetadata>(1242, 18617, 18742) ?? (_cmdletMetadata = f_1242_18679_18741(f_1242_18699_18708(this), f_1242_18710_18731(this), f_1242_18733_18740())));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1242, 18574, 18758);

                    string
                    f_1242_18699_18708(System.Management.Automation.CmdletInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 18699, 18708);
                        return return_v;
                    }


                    System.Type
                    f_1242_18710_18731(System.Management.Automation.CmdletInfo
                    this_param)
                    {
                        var return_v = this_param.ImplementingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 18710, 18731);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1242_18733_18740()
                    {
                        var return_v = Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 18733, 18740);
                        return return_v;
                    }


                    System.Management.Automation.CommandMetadata
                    f_1242_18679_18741(string
                    commandName, System.Type
                    cmdletType, System.Management.Automation.ExecutionContext
                    context)
                    {
                        var return_v = CommandMetadata.Get(commandName, cmdletType, context);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 18679, 18741);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 18500, 18769);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 18500, 18769);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private CommandMetadata _cmdletMetadata;

        internal override bool ImplementsDynamicParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1242, 18908, 19229);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 18944, 19214) || true) && (f_1242_18948_18964() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 18944, 19214);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 19014, 19100);

                        return (f_1242_19022_19090(f_1242_19022_19038(), f_1242_19052_19083(typeof(IDynamicParameters)), true) != null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 18944, 19214);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1242, 18944, 19214);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1242, 19182, 19195);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1242, 18944, 19214);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1242, 18908, 19229);

                    System.Type
                    f_1242_18948_18964()
                    {
                        var return_v = ImplementingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 18948, 18964);
                        return return_v;
                    }


                    System.Type
                    f_1242_19022_19038()
                    {
                        var return_v = ImplementingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 19022, 19038);
                        return return_v;
                    }


                    string
                    f_1242_19052_19083(System.Type
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 19052, 19083);
                        return return_v;
                    }


                    System.Type?
                    f_1242_19022_19090(System.Type
                    this_param, string
                    name, bool
                    ignoreCase)
                    {
                        var return_v = this_param.GetInterface(name, ignoreCase);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 19022, 19090);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1242, 18833, 19240);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 18833, 19240);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static CmdletInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1242, 414, 19294);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1242, 414, 19294);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1242, 414, 19294);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1242, 414, 19294);

        bool
        f_1242_1533_1559(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 1533, 1559);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1242_1599_1641(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 1599, 1641);
            return return_v;
        }


        bool
        f_1242_1730_1773(string
        name, out string
        verb, out string
        noun)
        {
            var return_v = SplitCmdletName(name, out verb, out noun);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 1730, 1773);
            return return_v;
        }


        string
        f_1242_1928_1971()
        {
            var return_v = DiscoveryExceptions.InvalidCmdletNameFormat;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 1928, 1971);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1242_1834_2003(string
        paramName, string
        resourceString, params object[]
        args)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 1834, 2003);
            return return_v;
        }


        static string
        f_1242_1469_1473_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1242, 1261, 2492);
            return return_v;
        }


        static System.Management.Automation.CommandInfo
        f_1242_2682_2687_C(System.Management.Automation.CommandInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1242, 2624, 2980);
            return return_v;
        }


        bool
        f_1242_4063_4089(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 4063, 4089);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1242_4129_4175(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 4129, 4175);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1242_4275_4321(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 4275, 4321);
            return return_v;
        }


        bool
        f_1242_4358_4407(System.Type
        this_param, System.Type
        c)
        {
            var return_v = this_param.IsAssignableFrom(c);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 4358, 4407);
            return return_v;
        }


        string
        f_1242_4490_4543()
        {
            var return_v = DiscoveryExceptions.CmdletDoesNotDeriveFromCmdletType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 4490, 4543);
            return return_v;
        }


        string
        f_1242_4565_4590(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 4565, 4590);
            return return_v;
        }


        System.Management.Automation.PSInvalidOperationException
        f_1242_4447_4591(string
        resourceString, params object[]
        args)
        {
            var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 4447, 4591);
            return return_v;
        }


        bool
        f_1242_4680_4723(string
        name, out string
        verb, out string
        noun)
        {
            var return_v = SplitCmdletName(name, out verb, out noun);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 4680, 4723);
            return return_v;
        }


        string
        f_1242_4878_4921()
        {
            var return_v = DiscoveryExceptions.InvalidCmdletNameFormat;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1242, 4878, 4921);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1242_4784_4953(string
        paramName, string
        resourceString, params object[]
        args)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1242, 4784, 4953);
            return return_v;
        }


        static string
        f_1242_4002_4006_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1242, 3928, 5159);
            return return_v;
        }

    }
}
