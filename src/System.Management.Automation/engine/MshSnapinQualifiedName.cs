// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    internal class PSSnapinQualifiedName
    {
        private PSSnapinQualifiedName(string[] splitName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1297, 373, 1721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 2903, 2912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 3182, 3195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 3456, 3466);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 447, 509);

                f_1297_447_508(splitName != null, "splitName should not be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 523, 626);

                f_1297_523_625(f_1297_534_550(splitName) == 1 || (DynAbs.Tracing.TraceSender.Expression_False(1297, 534, 580) || f_1297_559_575(splitName) == 2), "splitName should contain 1 or 2 elements");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 642, 1238) || true) && (f_1297_646_662(splitName) == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1297, 642, 1238);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 701, 727);

                    _shortName = splitName[0];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1297, 642, 1238);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1297, 642, 1238);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 761, 1238) || true) && (f_1297_765_781(splitName) == 2)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1297, 761, 1238);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 820, 949) || true) && (!f_1297_825_859(splitName[0]))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1297, 820, 949);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 901, 930);

                            _psSnapinName = splitName[0];
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1297, 820, 949);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 969, 995);

                        _shortName = splitName[1];
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1297, 761, 1238);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1297, 761, 1238);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 1174, 1223);

                        throw f_1297_1180_1222("name");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1297, 761, 1238);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1297, 642, 1238);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 1294, 1710) || true) && (!f_1297_1299_1334(_psSnapinName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1297, 1294, 1710);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 1368, 1606);

                    _fullName =
                    f_1297_1401_1605(f_1297_1441_1490(), "{0}\\{1}", _psSnapinName, _shortName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1297, 1294, 1710);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1297, 1294, 1710);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 1672, 1695);

                    _fullName = _shortName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1297, 1294, 1710);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1297, 373, 1721);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1297, 373, 1721);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1297, 373, 1721);
            }
        }

        internal static PSSnapinQualifiedName GetInstance(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1297, 2013, 2646);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 2100, 2147) || true) && (name == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1297, 2100, 2147);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 2135, 2147);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1297, 2100, 2147);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 2161, 2197);

                PSSnapinQualifiedName
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 2211, 2271);

                string[]
                splitName = f_1297_2232_2270(name, Utils.Separators.Backslash)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 2285, 2365) || true) && (f_1297_2289_2305(splitName) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(1297, 2289, 2334) || f_1297_2314_2330(splitName) > 2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1297, 2285, 2365);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 2353, 2365);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1297, 2285, 2365);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 2379, 2425);

                result = f_1297_2388_2424(splitName);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 2502, 2605) || true) && (f_1297_2506_2544(f_1297_2527_2543(result)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1297, 2502, 2605);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 2578, 2590);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1297, 2502, 2605);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 2621, 2635);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1297, 2013, 2646);

                string[]
                f_1297_2232_2270(string
                this_param, params char[]
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1297, 2232, 2270);
                    return return_v;
                }


                int
                f_1297_2289_2305(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1297, 2289, 2305);
                    return return_v;
                }


                int
                f_1297_2314_2330(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1297, 2314, 2330);
                    return return_v;
                }


                System.Management.Automation.PSSnapinQualifiedName
                f_1297_2388_2424(string[]
                splitName)
                {
                    var return_v = new System.Management.Automation.PSSnapinQualifiedName(splitName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1297, 2388, 2424);
                    return return_v;
                }


                string
                f_1297_2527_2543(System.Management.Automation.PSSnapinQualifiedName
                this_param)
                {
                    var return_v = this_param.ShortName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1297, 2527, 2543);
                    return return_v;
                }


                bool
                f_1297_2506_2544(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1297, 2506, 2544);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1297, 2013, 2646);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1297, 2013, 2646);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string FullName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1297, 2797, 2865);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 2833, 2850);

                    return _fullName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1297, 2797, 2865);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1297, 2748, 2876);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1297, 2748, 2876);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _fullName;

        internal string PSSnapInName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1297, 3072, 3144);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 3108, 3129);

                    return _psSnapinName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1297, 3072, 3144);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1297, 3019, 3155);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1297, 3019, 3155);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _psSnapinName;

        internal string ShortName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1297, 3349, 3418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 3385, 3403);

                    return _shortName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1297, 3349, 3418);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1297, 3299, 3429);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1297, 3299, 3429);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _shortName;

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1297, 3651, 3737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1297, 3709, 3726);

                return _fullName;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1297, 3651, 3737);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1297, 3651, 3737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1297, 3651, 3737);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSSnapinQualifiedName()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1297, 320, 3744);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1297, 320, 3744);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1297, 320, 3744);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1297, 320, 3744);

        int
        f_1297_447_508(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1297, 447, 508);
            return 0;
        }


        int
        f_1297_534_550(string[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1297, 534, 550);
            return return_v;
        }


        int
        f_1297_559_575(string[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1297, 559, 575);
            return return_v;
        }


        int
        f_1297_523_625(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1297, 523, 625);
            return 0;
        }


        int
        f_1297_646_662(string[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1297, 646, 662);
            return return_v;
        }


        int
        f_1297_765_781(string[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1297, 765, 781);
            return return_v;
        }


        bool
        f_1297_825_859(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1297, 825, 859);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1297_1180_1222(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1297, 1180, 1222);
            return return_v;
        }


        bool
        f_1297_1299_1334(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1297, 1299, 1334);
            return return_v;
        }


        System.Globalization.CultureInfo
        f_1297_1441_1490()
        {
            var return_v = System.Globalization.CultureInfo.InvariantCulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1297, 1441, 1490);
            return return_v;
        }


        string
        f_1297_1401_1605(System.Globalization.CultureInfo
        provider, string
        format, string
        arg0, string
        arg1)
        {
            var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1297, 1401, 1605);
            return return_v;
        }

    }
}

