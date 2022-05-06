// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;

using Dbg = System.Management.Automation.Diagnostics;

//using System.Runtime.Serialization;
//using System.ComponentModel;
//using System.Runtime.InteropServices;
//using System.Globalization;
//using System.Management.Automation;
//using System.Reflection;

namespace System.Management.Automation.Host
{
    public class
        FieldDescription
    {
        public
                FieldDescription(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1459, 1392, 1747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 14037, 14048);
                this.name = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 14074, 14094);
                this.label = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 14120, 14144);
                this.parameterTypeName = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 14170, 14198);
                this.parameterTypeFullName = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 14224, 14256);
                this.parameterAssemblyFullName = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 14282, 14308);
                this.helpMessage = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 14332, 14350);
                this.isMandatory = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 14380, 14399);
                this.defaultValue = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 14440, 14478);
                this.metadata = f_1459_14451_14478();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 14502, 14536);
                this.modifiedByRemotingProtocol = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 14560, 14584);
                this.isFromRemoteHost = false;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 1521, 1703) || true) && (f_1459_1525_1551(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1459, 1521, 1703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 1585, 1688);

                    throw f_1459_1591_1687("name", f_1459_1634_1678(), "name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1459, 1521, 1703);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 1719, 1736);

                this.name = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1459, 1392, 1747);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1459, 1392, 1747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1459, 1392, 1747);
            }
        }

        public string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1459, 1890, 1953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 1926, 1938);

                    return name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1459, 1890, 1953);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1459, 1847, 1964);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1459, 1847, 1964);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public
                void
                SetParameterType(System.Type parameterType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1459, 2423, 2868);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 2521, 2657) || true) && (parameterType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1459, 2521, 2657);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 2580, 2642);

                    throw f_1459_2586_2641("parameterType");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1459, 2521, 2657);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 2673, 2714);

                f_1459_2673_2713(this, f_1459_2694_2712(parameterType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 2728, 2777);

                f_1459_2728_2776(this, f_1459_2753_2775(parameterType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 2791, 2857);

                f_1459_2791_2856(this, f_1459_2820_2855(parameterType));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1459, 2423, 2868);

                System.Management.Automation.PSArgumentNullException
                f_1459_2586_2641(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1459, 2586, 2641);
                    return return_v;
                }


                string
                f_1459_2694_2712(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1459, 2694, 2712);
                    return return_v;
                }


                int
                f_1459_2673_2713(System.Management.Automation.Host.FieldDescription
                this_param, string
                nameOfType)
                {
                    this_param.SetParameterTypeName(nameOfType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1459, 2673, 2713);
                    return 0;
                }


                string
                f_1459_2753_2775(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1459, 2753, 2775);
                    return return_v;
                }


                int
                f_1459_2728_2776(System.Management.Automation.Host.FieldDescription
                this_param, string
                fullNameOfType)
                {
                    this_param.SetParameterTypeFullName(fullNameOfType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1459, 2728, 2776);
                    return 0;
                }


                string
                f_1459_2820_2855(System.Type
                this_param)
                {
                    var return_v = this_param.AssemblyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1459, 2820, 2855);
                    return return_v;
                }


                int
                f_1459_2791_2856(System.Management.Automation.Host.FieldDescription
                this_param, string
                fullNameOfAssembly)
                {
                    this_param.SetParameterAssemblyFullName(fullNameOfAssembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1459, 2791, 2856);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1459, 2423, 2868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1459, 2423, 2868);
            }
        }

        public
                string
                ParameterTypeName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1459, 3505, 3822);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 3541, 3762) || true) && (f_1459_3545_3584(parameterTypeName))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1459, 3541, 3762);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 3710, 3743);

                        f_1459_3710_3742(this, typeof(string));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1459, 3541, 3762);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 3782, 3807);

                    return parameterTypeName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1459, 3505, 3822);

                    bool
                    f_1459_3545_3584(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1459, 3545, 3584);
                        return return_v;
                    }


                    int
                    f_1459_3710_3742(System.Management.Automation.Host.FieldDescription
                    this_param, System.Type
                    parameterType)
                    {
                        this_param.SetParameterType(parameterType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1459, 3710, 3742);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1459, 3431, 3833);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1459, 3431, 3833);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public
                string
                ParameterTypeFullName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1459, 4393, 4718);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 4429, 4654) || true) && (f_1459_4433_4476(parameterTypeFullName))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1459, 4429, 4654);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 4602, 4635);

                        f_1459_4602_4634(this, typeof(string));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1459, 4429, 4654);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 4674, 4703);

                    return parameterTypeFullName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1459, 4393, 4718);

                    bool
                    f_1459_4433_4476(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1459, 4433, 4476);
                        return return_v;
                    }


                    int
                    f_1459_4602_4634(System.Management.Automation.Host.FieldDescription
                    this_param, System.Type
                    parameterType)
                    {
                        this_param.SetParameterType(parameterType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1459, 4602, 4634);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1459, 4315, 4729);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1459, 4315, 4729);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public
                string
                ParameterAssemblyFullName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1459, 5492, 5825);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 5528, 5757) || true) && (f_1459_5532_5579(parameterAssemblyFullName))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1459, 5528, 5757);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 5705, 5738);

                        f_1459_5705_5737(this, typeof(string));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1459, 5528, 5757);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 5777, 5810);

                    return parameterAssemblyFullName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1459, 5492, 5825);

                    bool
                    f_1459_5532_5579(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1459, 5532, 5579);
                        return return_v;
                    }


                    int
                    f_1459_5705_5737(System.Management.Automation.Host.FieldDescription
                    this_param, System.Type
                    parameterType)
                    {
                        this_param.SetParameterType(parameterType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1459, 5705, 5737);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1459, 5410, 5836);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1459, 5410, 5836);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public
                string
                Label
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1459, 7277, 7415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 7313, 7367);

                    f_1459_7313_7366(label != null, "label should not be null");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 7387, 7400);

                    return label;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1459, 7277, 7415);

                    int
                    f_1459_7313_7366(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1459, 7313, 7366);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1459, 7215, 7659);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1459, 7215, 7659);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1459, 7431, 7648);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 7467, 7599) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1459, 7467, 7599);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 7526, 7580);

                        throw f_1459_7532_7579("value");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1459, 7467, 7599);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 7619, 7633);

                    label = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1459, 7431, 7648);

                    System.Management.Automation.PSArgumentNullException
                    f_1459_7532_7579(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1459, 7532, 7579);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1459, 7215, 7659);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1459, 7215, 7659);
                }
            }
        }

        public
                string
                HelpMessage
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1459, 8224, 8380);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 8260, 8326);

                    f_1459_8260_8325(helpMessage != null, "helpMessage should not be null");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 8346, 8365);

                    return helpMessage;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1459, 8224, 8380);

                    int
                    f_1459_8260_8325(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1459, 8260, 8325);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1459, 8156, 8630);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1459, 8156, 8630);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1459, 8396, 8619);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 8432, 8564) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1459, 8432, 8564);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 8491, 8545);

                        throw f_1459_8497_8544("value");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1459, 8432, 8564);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 8584, 8604);

                    helpMessage = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1459, 8396, 8619);

                    System.Management.Automation.PSArgumentNullException
                    f_1459_8497_8544(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1459, 8497, 8544);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1459, 8156, 8630);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1459, 8156, 8630);
                }
            }
        }

        public
                bool
                IsMandatory
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1459, 8833, 8903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 8869, 8888);

                    return isMandatory;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1459, 8833, 8903);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1459, 8767, 9001);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1459, 8767, 9001);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1459, 8919, 8990);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 8955, 8975);

                    isMandatory = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1459, 8919, 8990);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1459, 8767, 9001);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1459, 8767, 9001);
                }
            }
        }

        public
                PSObject
                DefaultValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1459, 9740, 9811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 9776, 9796);

                    return defaultValue;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1459, 9740, 9811);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1459, 9669, 9949);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1459, 9669, 9949);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1459, 9827, 9938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 9902, 9923);

                    defaultValue = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1459, 9827, 9938);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1459, 9669, 9949);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1459, 9669, 9949);
                }
            }
        }

        public
                Collection<Attribute>
                Attributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1459, 10419, 10487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 10425, 10485);

                    return metadata ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.ObjectModel.Collection<System.Attribute>>(1459, 10432, 10484) ?? (metadata = f_1459_10456_10483()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1459, 10419, 10487);

                    System.Collections.ObjectModel.Collection<System.Attribute>
                    f_1459_10456_10483()
                    {
                        var return_v = new System.Collections.ObjectModel.Collection<System.Attribute>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1459, 10456, 10483);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1459, 10337, 10498);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1459, 10337, 10498);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal
                void
                SetParameterTypeName(string nameOfType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1459, 10816, 11170);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 10912, 11112) || true) && (f_1459_10916_10948(nameOfType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1459, 10912, 11112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 10982, 11097);

                    throw f_1459_10988_11096("nameOfType", f_1459_11037_11081(), "nameOfType");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1459, 10912, 11112);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 11128, 11159);

                parameterTypeName = nameOfType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1459, 10816, 11170);

                bool
                f_1459_10916_10948(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1459, 10916, 10948);
                    return return_v;
                }


                string
                f_1459_11037_11081()
                {
                    var return_v = DescriptionsStrings.NullOrEmptyErrorTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1459, 11037, 11081);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1459_10988_11096(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1459, 10988, 11096);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1459, 10816, 11170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1459, 10816, 11170);
            }
        }

        internal
                void
                SetParameterTypeFullName(string fullNameOfType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1459, 11496, 11878);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 11600, 11812) || true) && (f_1459_11604_11640(fullNameOfType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1459, 11600, 11812);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 11674, 11797);

                    throw f_1459_11680_11796("fullNameOfType", f_1459_11733_11777(), "fullNameOfType");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1459, 11600, 11812);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 11828, 11867);

                parameterTypeFullName = fullNameOfType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1459, 11496, 11878);

                bool
                f_1459_11604_11640(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1459, 11604, 11640);
                    return return_v;
                }


                string
                f_1459_11733_11777()
                {
                    var return_v = DescriptionsStrings.NullOrEmptyErrorTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1459, 11733, 11777);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1459_11680_11796(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1459, 11680, 11796);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1459, 11496, 11878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1459, 11496, 11878);
            }
        }

        internal
                void
                SetParameterAssemblyFullName(string fullNameOfAssembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1459, 12212, 12622);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 12324, 12548) || true) && (f_1459_12328_12368(fullNameOfAssembly))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1459, 12324, 12548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 12402, 12533);

                    throw f_1459_12408_12532("fullNameOfAssembly", f_1459_12465_12509(), "fullNameOfAssembly");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1459, 12324, 12548);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 12564, 12611);

                parameterAssemblyFullName = fullNameOfAssembly;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1459, 12212, 12622);

                bool
                f_1459_12328_12368(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1459, 12328, 12368);
                    return return_v;
                }


                string
                f_1459_12465_12509()
                {
                    var return_v = DescriptionsStrings.NullOrEmptyErrorTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1459, 12465, 12509);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1459_12408_12532(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1459, 12408, 12532);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1459, 12212, 12622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1459, 12212, 12622);
            }
        }

        internal bool ModifiedByRemotingProtocol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1459, 13061, 13146);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 13097, 13131);

                    return modifiedByRemotingProtocol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1459, 13061, 13146);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1459, 12996, 13259);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1459, 12996, 13259);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1459, 13162, 13248);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 13198, 13233);

                    modifiedByRemotingProtocol = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1459, 13162, 13248);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1459, 12996, 13259);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1459, 12996, 13259);
                }
            }
        }

        internal bool IsFromRemoteHost
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1459, 13651, 13726);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 13687, 13711);

                    return isFromRemoteHost;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1459, 13651, 13726);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1459, 13596, 13829);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1459, 13596, 13829);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1459, 13742, 13818);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1459, 13778, 13803);

                    isFromRemoteHost = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1459, 13742, 13818);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1459, 13596, 13829);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1459, 13596, 13829);
                }
            }
        }

        private readonly string name;

        private string label;

        private string parameterTypeName;

        private string parameterTypeFullName;

        private string parameterAssemblyFullName;

        private string helpMessage;

        private bool isMandatory;

        private PSObject defaultValue;

        private Collection<Attribute> metadata;

        private bool modifiedByRemotingProtocol;

        private bool isFromRemoteHost;

        static FieldDescription()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1459, 930, 14614);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1459, 930, 14614);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1459, 930, 14614);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1459, 930, 14614);

        bool
        f_1459_1525_1551(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1459, 1525, 1551);
            return return_v;
        }


        string
        f_1459_1634_1678()
        {
            var return_v = DescriptionsStrings.NullOrEmptyErrorTemplate;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1459, 1634, 1678);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1459_1591_1687(string
        paramName, string
        resourceString, params object[]
        args)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1459, 1591, 1687);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<System.Attribute>
        f_1459_14451_14478()
        {
            var return_v = new System.Collections.ObjectModel.Collection<System.Attribute>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1459, 14451, 14478);
            return return_v;
        }

    }
}

