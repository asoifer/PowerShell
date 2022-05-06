// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Reflection;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed class FormatObjectDeserializer
    {
        internal TerminatingErrorContext TerminatingErrorContext { get; private set; }

        private const string
        TabExpansionString = "    "
        ;

        internal FormatObjectDeserializer(TerminatingErrorContext errorContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1089, 822, 968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 559, 637);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 918, 957);

                TerminatingErrorContext = errorContext;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1089, 822, 968);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 822, 968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 822, 968);
            }
        }

        internal bool IsFormatInfoData(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 980, 2994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 1048, 1094);

                var
                fid = f_1089_1058_1075(so) as FormatInfoData
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 1108, 1729) || true) && (fid != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 1108, 1729);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 1157, 1438) || true) && (fid is FormatStartData || (DynAbs.Tracing.TraceSender.Expression_False(1089, 1161, 1228) || fid is FormatEndData) || (DynAbs.Tracing.TraceSender.Expression_False(1089, 1161, 1274) || fid is GroupStartData) || (DynAbs.Tracing.TraceSender.Expression_False(1089, 1161, 1318) || fid is GroupEndData) || (DynAbs.Tracing.TraceSender.Expression_False(1089, 1161, 1365) || fid is FormatEntryData))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 1157, 1438);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 1407, 1419);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 1157, 1438);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 1552, 1683);

                    f_1089_1552_1682(this, f_1089_1581_1624(fid), so, "FormatObjectDeserializerDeserializeInvalidClassId");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 1701, 1714);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 1108, 1729);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 1926, 2050) || true) && (!f_1089_1931_1988(so, typeof(FormatInfoData)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 1926, 2050);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 2022, 2035);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 1926, 2050);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 2066, 2141);

                string
                classId = f_1089_2083_2130(so, FormatInfoData.classidProperty) as string
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 2157, 2314) || true) && (classId == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 2157, 2314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 2286, 2299);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 2157, 2314);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 2415, 2753) || true) && (f_1089_2419_2458(classId, FormatStartData.CLSID) || (DynAbs.Tracing.TraceSender.Expression_False(1089, 2419, 2516) || f_1089_2479_2516(classId, FormatEndData.CLSID)) || (DynAbs.Tracing.TraceSender.Expression_False(1089, 2419, 2575) || f_1089_2537_2575(classId, GroupStartData.CLSID)) || (DynAbs.Tracing.TraceSender.Expression_False(1089, 2419, 2632) || f_1089_2596_2632(classId, GroupEndData.CLSID)) || (DynAbs.Tracing.TraceSender.Expression_False(1089, 2419, 2692) || f_1089_2653_2692(classId, FormatEntryData.CLSID)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 2415, 2753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 2726, 2738);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 2415, 2753);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 2856, 2956);

                f_1089_2856_2955(this, classId, so, "FormatObjectDeserializerIsFormatInfoDataInvalidClassId");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 2970, 2983);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 980, 2994);

                object
                f_1089_1058_1075(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = PSObject.Base((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 1058, 1075);
                    return return_v;
                }


                string
                f_1089_1581_1624(Microsoft.PowerShell.Commands.Internal.Format.FormatInfoData
                this_param)
                {
                    var return_v = this_param.ClassId2e4f51ef21dd47e99d3c952918aff9cd;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1089, 1581, 1624);
                    return return_v;
                }


                int
                f_1089_1552_1682(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, string
                classId, System.Management.Automation.PSObject
                obj, string
                errorId)
                {
                    this_param.ProcessUnknownInvalidClassId(classId, (object)obj, errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 1552, 1682);
                    return 0;
                }


                bool
                f_1089_1931_1988(System.Management.Automation.PSObject
                o, System.Type
                type)
                {
                    var return_v = Deserializer.IsInstanceOfType((object)o, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 1931, 1988);
                    return return_v;
                }


                object
                f_1089_2083_2130(System.Management.Automation.PSObject
                so, string
                name)
                {
                    var return_v = GetProperty(so, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 2083, 2130);
                    return return_v;
                }


                bool
                f_1089_2419_2458(string
                x, string
                y)
                {
                    var return_v = IsClass(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 2419, 2458);
                    return return_v;
                }


                bool
                f_1089_2479_2516(string
                x, string
                y)
                {
                    var return_v = IsClass(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 2479, 2516);
                    return return_v;
                }


                bool
                f_1089_2537_2575(string
                x, string
                y)
                {
                    var return_v = IsClass(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 2537, 2575);
                    return return_v;
                }


                bool
                f_1089_2596_2632(string
                x, string
                y)
                {
                    var return_v = IsClass(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 2596, 2632);
                    return return_v;
                }


                bool
                f_1089_2653_2692(string
                x, string
                y)
                {
                    var return_v = IsClass(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 2653, 2692);
                    return return_v;
                }


                int
                f_1089_2856_2955(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, string
                classId, System.Management.Automation.PSObject
                obj, string
                errorId)
                {
                    this_param.ProcessUnknownInvalidClassId(classId, (object)obj, errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 2856, 2955);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 980, 2994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 980, 2994);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object Deserialize(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 3432, 5488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 3497, 3543);

                var
                fid = f_1089_3507_3524(so) as FormatInfoData
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 3557, 4176) || true) && (fid != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 3557, 4176);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 3606, 3886) || true) && (fid is FormatStartData || (DynAbs.Tracing.TraceSender.Expression_False(1089, 3610, 3677) || fid is FormatEndData) || (DynAbs.Tracing.TraceSender.Expression_False(1089, 3610, 3723) || fid is GroupStartData) || (DynAbs.Tracing.TraceSender.Expression_False(1089, 3610, 3767) || fid is GroupEndData) || (DynAbs.Tracing.TraceSender.Expression_False(1089, 3610, 3814) || fid is FormatEntryData))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 3606, 3886);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 3856, 3867);

                        return fid;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 3606, 3886);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 4000, 4131);

                    f_1089_4000_4130(this, f_1089_4029_4072(fid), so, "FormatObjectDeserializerDeserializeInvalidClassId");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 4149, 4161);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 3557, 4176);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 4373, 4494) || true) && (!f_1089_4378_4435(so, typeof(FormatInfoData)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 4373, 4494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 4469, 4479);

                    return so;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 4373, 4494);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 4510, 4585);

                string
                classId = f_1089_4527_4574(so, FormatInfoData.classidProperty) as string
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 4601, 4797) || true) && (classId == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 4601, 4797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 4772, 4782);

                    return so;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 4601, 4797);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 4898, 5253) || true) && (f_1089_4902_4941(classId, FormatStartData.CLSID) || (DynAbs.Tracing.TraceSender.Expression_False(1089, 4902, 4999) || f_1089_4962_4999(classId, FormatEndData.CLSID)) || (DynAbs.Tracing.TraceSender.Expression_False(1089, 4902, 5058) || f_1089_5020_5058(classId, GroupStartData.CLSID)) || (DynAbs.Tracing.TraceSender.Expression_False(1089, 4902, 5115) || f_1089_5079_5115(classId, GroupEndData.CLSID)) || (DynAbs.Tracing.TraceSender.Expression_False(1089, 4902, 5175) || f_1089_5136_5175(classId, FormatEntryData.CLSID)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 4898, 5253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 5209, 5238);

                    return f_1089_5216_5237(this, so);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 4898, 5253);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 5356, 5451);

                f_1089_5356_5450(this, classId, so, "FormatObjectDeserializerDeserializeInvalidClassId");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 5465, 5477);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 3432, 5488);

                object
                f_1089_3507_3524(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = PSObject.Base((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 3507, 3524);
                    return return_v;
                }


                string
                f_1089_4029_4072(Microsoft.PowerShell.Commands.Internal.Format.FormatInfoData
                this_param)
                {
                    var return_v = this_param.ClassId2e4f51ef21dd47e99d3c952918aff9cd;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1089, 4029, 4072);
                    return return_v;
                }


                int
                f_1089_4000_4130(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, string
                classId, System.Management.Automation.PSObject
                obj, string
                errorId)
                {
                    this_param.ProcessUnknownInvalidClassId(classId, (object)obj, errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 4000, 4130);
                    return 0;
                }


                bool
                f_1089_4378_4435(System.Management.Automation.PSObject
                o, System.Type
                type)
                {
                    var return_v = Deserializer.IsInstanceOfType((object)o, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 4378, 4435);
                    return return_v;
                }


                object
                f_1089_4527_4574(System.Management.Automation.PSObject
                so, string
                name)
                {
                    var return_v = GetProperty(so, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 4527, 4574);
                    return return_v;
                }


                bool
                f_1089_4902_4941(string
                x, string
                y)
                {
                    var return_v = IsClass(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 4902, 4941);
                    return return_v;
                }


                bool
                f_1089_4962_4999(string
                x, string
                y)
                {
                    var return_v = IsClass(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 4962, 4999);
                    return return_v;
                }


                bool
                f_1089_5020_5058(string
                x, string
                y)
                {
                    var return_v = IsClass(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 5020, 5058);
                    return return_v;
                }


                bool
                f_1089_5079_5115(string
                x, string
                y)
                {
                    var return_v = IsClass(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 5079, 5115);
                    return return_v;
                }


                bool
                f_1089_5136_5175(string
                x, string
                y)
                {
                    var return_v = IsClass(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 5136, 5175);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatInfoData
                f_1089_5216_5237(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so)
                {
                    var return_v = this_param.DeserializeObject(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 5216, 5237);
                    return return_v;
                }


                int
                f_1089_5356_5450(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, string
                classId, System.Management.Automation.PSObject
                obj, string
                errorId)
                {
                    this_param.ProcessUnknownInvalidClassId(classId, (object)obj, errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 5356, 5450);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 3432, 5488);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 3432, 5488);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ProcessUnknownInvalidClassId(string classId, object obj, string errorId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 5500, 6175);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 5610, 5694);

                string
                msg = f_1089_5623_5693(f_1089_5641_5683(), classId)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 5710, 6021);

                ErrorRecord
                errorRecord = f_1089_5736_6020(f_1089_5798_5843("classId"), errorId, ErrorCategory.InvalidData, obj)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 6037, 6086);

                errorRecord.ErrorDetails = f_1089_6064_6085(msg);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 6100, 6164);

                f_1089_6100_6163(f_1089_6100_6128(this), errorRecord);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 5500, 6175);

                string
                f_1089_5641_5683()
                {
                    var return_v = FormatAndOut_format_xxx.FOD_ClassIdInvalid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1089, 5641, 5683);
                    return return_v;
                }


                string
                f_1089_5623_5693(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 5623, 5693);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1089_5798_5843(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 5798, 5843);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1089_5736_6020(System.Management.Automation.PSArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 5736, 6020);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1089_6064_6085(string
                message)
                {
                    var return_v = new System.Management.Automation.ErrorDetails(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 6064, 6085);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                f_1089_6100_6128(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param)
                {
                    var return_v = this_param.TerminatingErrorContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1089, 6100, 6128);
                    return return_v;
                }


                int
                f_1089_6100_6163(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 6100, 6163);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 5500, 6175);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 5500, 6175);
            }
        }

        private static bool IsClass(string x, string y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1089, 6219, 6371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 6291, 6360);

                return f_1089_6298_6354(x, y, StringComparison.OrdinalIgnoreCase) == 0;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1089, 6219, 6371);

                int
                f_1089_6298_6354(string
                strA, string
                strB, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Compare(strA, strB, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 6298, 6354);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 6219, 6371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 6219, 6371);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object GetProperty(PSObject so, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1089, 7726, 8166);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 7811, 7853);

                PSMemberInfo
                member = f_1089_7833_7852(f_1089_7833_7846(so), name)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 7867, 7946) || true) && (member == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 7867, 7946);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 7919, 7931);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 7867, 7946);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 8135, 8155);

                return f_1089_8142_8154(member);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1089, 7726, 8166);

                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1089_7833_7846(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1089, 7833, 7846);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1089_7833_7852(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1089, 7833, 7852);
                    return return_v;
                }


                object
                f_1089_8142_8154(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1089, 8142, 8154);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 7726, 8166);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 7726, 8166);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal FormatInfoData DeserializeMemberObject(PSObject so, string property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 8212, 9149);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 8314, 8359);

                object
                memberRaw = f_1089_8333_8358(so, property)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 8373, 8425) || true) && (memberRaw == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 8373, 8425);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 8413, 8425);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 8373, 8425);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 8439, 9065) || true) && (so == memberRaw)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 8439, 9065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 8492, 8580);

                    string
                    msg = f_1089_8505_8579(f_1089_8523_8568(), property)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 8600, 8899);

                    ErrorRecord
                    errorRecord = f_1089_8626_8898(f_1089_8676_8722("property"), "FormatObjectDeserializerRecursiveProperty", ErrorCategory.InvalidData, so)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 8919, 8968);

                    errorRecord.ErrorDetails = f_1089_8946_8967(msg);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 8986, 9050);

                    f_1089_8986_9049(f_1089_8986_9014(this), errorRecord);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 8439, 9065);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 9081, 9138);

                return f_1089_9088_9137(this, f_1089_9106_9136(memberRaw));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 8212, 9149);

                object
                f_1089_8333_8358(System.Management.Automation.PSObject
                so, string
                name)
                {
                    var return_v = GetProperty(so, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 8333, 8358);
                    return return_v;
                }


                string
                f_1089_8523_8568()
                {
                    var return_v = FormatAndOut_format_xxx.FOD_RecursiveProperty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1089, 8523, 8568);
                    return return_v;
                }


                string
                f_1089_8505_8579(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 8505, 8579);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1089_8676_8722(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 8676, 8722);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1089_8626_8898(System.Management.Automation.PSArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.PSObject
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 8626, 8898);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1089_8946_8967(string
                message)
                {
                    var return_v = new System.Management.Automation.ErrorDetails(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 8946, 8967);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                f_1089_8986_9014(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param)
                {
                    var return_v = this_param.TerminatingErrorContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1089, 8986, 9014);
                    return return_v;
                }


                int
                f_1089_8986_9049(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 8986, 9049);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1089_9106_9136(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 9106, 9136);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatInfoData
                f_1089_9088_9137(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so)
                {
                    var return_v = this_param.DeserializeObject(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 9088, 9137);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 8212, 9149);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 8212, 9149);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal FormatInfoData DeserializeMandatoryMemberObject(PSObject so, string property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 9161, 9414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 9272, 9331);

                FormatInfoData
                fid = f_1089_9293_9330(this, so, property)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 9345, 9378);

                f_1089_9345_9377(this, fid, property);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 9392, 9403);

                return fid;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 9161, 9414);

                Microsoft.PowerShell.Commands.Internal.Format.FormatInfoData
                f_1089_9293_9330(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeMemberObject(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 9293, 9330);
                    return return_v;
                }


                int
                f_1089_9345_9377(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatInfoData
                obj, string
                name)
                {
                    this_param.VerifyDataNotNull((object)obj, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 9345, 9377);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 9161, 9414);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 9161, 9414);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private object DeserializeMemberVariable(PSObject so, string property, System.Type t, bool cannotBeNull)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 9426, 10401);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 9555, 9597);

                object
                objRaw = f_1089_9571_9596(so, property)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 9611, 9682) || true) && (cannotBeNull)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 9611, 9682);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 9646, 9682);

                    f_1089_9646_9681(this, objRaw, property);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 9611, 9682);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 9698, 10360) || true) && (objRaw != null && (DynAbs.Tracing.TraceSender.Expression_True(1089, 9702, 9741) && t != f_1089_9725_9741(objRaw)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 9698, 10360);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 9775, 9873);

                    string
                    msg = f_1089_9788_9872(f_1089_9806_9853(), f_1089_9855_9861(t), property)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 9893, 10194);

                    ErrorRecord
                    errorRecord = f_1089_9919_10193(f_1089_9969_10015("property"), "FormatObjectDeserializerInvalidPropertyType", ErrorCategory.InvalidData, so)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 10214, 10263);

                    errorRecord.ErrorDetails = f_1089_10241_10262(msg);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 10281, 10345);

                    f_1089_10281_10344(f_1089_10281_10309(this), errorRecord);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 9698, 10360);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 10376, 10390);

                return objRaw;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 9426, 10401);

                object
                f_1089_9571_9596(System.Management.Automation.PSObject
                so, string
                name)
                {
                    var return_v = GetProperty(so, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 9571, 9596);
                    return return_v;
                }


                int
                f_1089_9646_9681(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, object
                obj, string
                name)
                {
                    this_param.VerifyDataNotNull(obj, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 9646, 9681);
                    return 0;
                }


                System.Type
                f_1089_9725_9741(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 9725, 9741);
                    return return_v;
                }


                string
                f_1089_9806_9853()
                {
                    var return_v = FormatAndOut_format_xxx.FOD_InvalidPropertyType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1089, 9806, 9853);
                    return return_v;
                }


                string
                f_1089_9855_9861(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1089, 9855, 9861);
                    return return_v;
                }


                string
                f_1089_9788_9872(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 9788, 9872);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1089_9969_10015(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 9969, 10015);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1089_9919_10193(System.Management.Automation.PSArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.PSObject
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 9919, 10193);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1089_10241_10262(string
                message)
                {
                    var return_v = new System.Management.Automation.ErrorDetails(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 10241, 10262);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                f_1089_10281_10309(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param)
                {
                    var return_v = this_param.TerminatingErrorContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1089, 10281, 10309);
                    return return_v;
                }


                int
                f_1089_10281_10344(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 10281, 10344);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 9426, 10401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 9426, 10401);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string DeserializeStringMemberVariableRaw(PSObject so, string property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 10736, 10949);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 10841, 10938);

                return (string)f_1089_10856_10937(this, so, property, typeof(string), false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 10736, 10949);

                object
                f_1089_10856_10937(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property, System.Type
                t, bool
                cannotBeNull)
                {
                    var return_v = this_param.DeserializeMemberVariable(so, property, t, cannotBeNull);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 10856, 10937);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 10736, 10949);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 10736, 10949);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string DeserializeStringMemberVariable(PSObject so, string property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 11282, 11661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 11384, 11487);

                string
                val = (string)f_1089_11405_11486(this, so, property, typeof(string), false)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 11532, 11591) || true) && (f_1089_11536_11561(val))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 11532, 11591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 11580, 11591);

                    return val;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 11532, 11591);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 11605, 11650);

                return f_1089_11612_11649(val, "\t", TabExpansionString);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 11282, 11661);

                object
                f_1089_11405_11486(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property, System.Type
                t, bool
                cannotBeNull)
                {
                    var return_v = this_param.DeserializeMemberVariable(so, property, t, cannotBeNull);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 11405, 11486);
                    return return_v;
                }


                bool
                f_1089_11536_11561(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 11536, 11561);
                    return return_v;
                }


                string
                f_1089_11612_11649(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 11612, 11649);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 11282, 11661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 11282, 11661);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int DeserializeIntMemberVariable(PSObject so, string property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 11673, 11870);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 11769, 11859);

                return (int)f_1089_11781_11858(this, so, property, typeof(int), true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 11673, 11870);

                object
                f_1089_11781_11858(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property, System.Type
                t, bool
                cannotBeNull)
                {
                    var return_v = this_param.DeserializeMemberVariable(so, property, t, cannotBeNull);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 11781, 11858);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 11673, 11870);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 11673, 11870);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool DeserializeBoolMemberVariable(PSObject so, string property, bool cannotBeNull = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 11882, 12150);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 12006, 12084);

                var
                val = f_1089_12016_12083(this, so, property, typeof(bool), cannotBeNull)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 12098, 12139);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1089, 12105, 12118) || (((val == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1089, 12121, 12126)) || DynAbs.Tracing.TraceSender.Conditional_F3(1089, 12129, 12138))) ? false : (bool)val;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 11882, 12150);

                object
                f_1089_12016_12083(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property, System.Type
                t, bool
                cannotBeNull)
                {
                    var return_v = this_param.DeserializeMemberVariable(so, property, t, cannotBeNull);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 12016, 12083);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 11882, 12150);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 11882, 12150);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal WriteStreamType DeserializeWriteStreamTypeMemberVariable(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 12162, 13020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 12265, 12317);

                object
                wsTypeValue = f_1089_12286_12316(so, "writeStream")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 12331, 12431) || true) && (wsTypeValue == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 12331, 12431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 12388, 12416);

                    return WriteStreamType.None;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 12331, 12431);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 12447, 12473);

                WriteStreamType
                rtnWSType
                = default(WriteStreamType);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 12487, 12976) || true) && (wsTypeValue is WriteStreamType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 12487, 12976);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 12555, 12596);

                    rtnWSType = (WriteStreamType)wsTypeValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 12487, 12976);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 12487, 12976);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 12630, 12976) || true) && (wsTypeValue is string)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 12630, 12976);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 12689, 12862) || true) && (!f_1089_12694_12768(wsTypeValue as string, true, out rtnWSType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 12689, 12862);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 12810, 12843);

                            rtnWSType = WriteStreamType.None;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 12689, 12862);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 12630, 12976);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 12630, 12976);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 12928, 12961);

                        rtnWSType = WriteStreamType.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 12630, 12976);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 12487, 12976);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 12992, 13009);

                return rtnWSType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 12162, 13020);

                object
                f_1089_12286_12316(System.Management.Automation.PSObject
                so, string
                name)
                {
                    var return_v = GetProperty(so, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 12286, 12316);
                    return return_v;
                }


                bool
                f_1089_12694_12768(object
                value, bool
                ignoreCase, out System.Management.Automation.WriteStreamType
                result)
                {
                    var return_v = Enum.TryParse<WriteStreamType>((string)value, ignoreCase, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 12694, 12768);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 12162, 13020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 12162, 13020);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal FormatInfoData DeserializeObject(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 13066, 13330);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 13145, 13218);

                FormatInfoData
                fid = f_1089_13166_13217(so, this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 13234, 13294) || true) && (fid != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 13234, 13294);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 13268, 13294);

                    f_1089_13268_13293(fid, so, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 13234, 13294);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 13308, 13319);

                return fid;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 13066, 13330);

                Microsoft.PowerShell.Commands.Internal.Format.FormatInfoData
                f_1089_13166_13217(System.Management.Automation.PSObject
                so, Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                deserializer)
                {
                    var return_v = FormatInfoDataClassFactory.CreateInstance(so, deserializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 13166, 13217);
                    return return_v;
                }


                int
                f_1089_13268_13293(Microsoft.PowerShell.Commands.Internal.Format.FormatInfoData
                this_param, System.Management.Automation.PSObject
                so, Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                deserializer)
                {
                    this_param.Deserialize(so, deserializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 13268, 13293);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 13066, 13330);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 13066, 13330);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void VerifyDataNotNull(object obj, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 13342, 14054);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 13423, 13464) || true) && (obj != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 13423, 13464);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 13457, 13464);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 13423, 13464);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 13480, 13561);

                string
                msg = f_1089_13493_13560(f_1089_13511_13553(), name)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 13577, 13900);

                ErrorRecord
                errorRecord = f_1089_13603_13899(f_1089_13665_13688(), "FormatObjectDeserializerNullDataMember", ErrorCategory.InvalidData, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 13916, 13965);

                errorRecord.ErrorDetails = f_1089_13943_13964(msg);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 13979, 14043);

                f_1089_13979_14042(f_1089_13979_14007(this), errorRecord);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 13342, 14054);

                string
                f_1089_13511_13553()
                {
                    var return_v = FormatAndOut_format_xxx.FOD_NullDataMember;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1089, 13511, 13553);
                    return return_v;
                }


                string
                f_1089_13493_13560(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 13493, 13560);
                    return return_v;
                }


                System.ArgumentException
                f_1089_13665_13688()
                {
                    var return_v = new System.ArgumentException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 13665, 13688);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1089_13603_13899(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 13603, 13899);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1089_13943_13964(string
                message)
                {
                    var return_v = new System.Management.Automation.ErrorDetails(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 13943, 13964);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                f_1089_13979_14007(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param)
                {
                    var return_v = this_param.TerminatingErrorContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1089, 13979, 14007);
                    return return_v;
                }


                int
                f_1089_13979_14042(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 13979, 14042);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 13342, 14054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 13342, 14054);
            }
        }

        static FormatObjectDeserializer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1089, 496, 14061);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 782, 809);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1089, 496, 14061);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 496, 14061);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1089, 496, 14061);
    }
    internal static class FormatInfoDataClassFactory
    {
        static FormatInfoDataClassFactory()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1089, 14134, 16210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 20243, 20257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 14194, 16199);

                s_constructors = new Dictionary<string, Func<FormatInfoData>>
            {
                {DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => FormatStartData.CLSID,1089,14211,16198),() => new FormatStartData()},                {FormatEndData.CLSID,         () => new FormatEndData()},                {GroupStartData.CLSID,        () => new GroupStartData()},                {GroupEndData.CLSID,          () => new GroupEndData()},                {FormatEntryData.CLSID,       () => new FormatEntryData()},                {WideViewHeaderInfo.CLSID,    () => new WideViewHeaderInfo()},                {TableHeaderInfo.CLSID,       () => new TableHeaderInfo()},                {TableColumnInfo.CLSID,       () => new TableColumnInfo()},                {ListViewHeaderInfo.CLSID,    () => new ListViewHeaderInfo()},                {ListViewEntry.CLSID,         () => new ListViewEntry()},                {ListViewField.CLSID,         () => new ListViewField()},                {TableRowEntry.CLSID,         () => new TableRowEntry()},                {WideViewEntry.CLSID,         () => new WideViewEntry()},                {ComplexViewHeaderInfo.CLSID, () => new ComplexViewHeaderInfo()},                {ComplexViewEntry.CLSID,      () => new ComplexViewEntry()},                {GroupingEntry.CLSID,         () => new GroupingEntry()},                {PageHeaderEntry.CLSID,       () => new PageHeaderEntry()},                {PageFooterEntry.CLSID,       () => new PageFooterEntry()},                {AutosizeInfo.CLSID,          () => new AutosizeInfo()},                {FormatNewLine.CLSID,         () => new FormatNewLine()},                {FrameInfo.CLSID,             () => new FrameInfo()},                {FormatTextField.CLSID,       () => new FormatTextField()},                {FormatPropertyField.CLSID,   () => new FormatPropertyField()},                {FormatEntry.CLSID,           () => new FormatEntry()},                {RawTextFormatEntry.CLSID,    () => new RawTextFormatEntry()}
            };
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1089, 14134, 16210);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 14134, 16210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 14134, 16210);
            }
        }

        internal static FormatInfoData CreateInstance(PSObject so, FormatObjectDeserializer deserializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1089, 16256, 17500);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 16378, 16492) || true) && (so == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 16378, 16492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 16426, 16477);

                    throw f_1089_16432_16476("so");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 16378, 16492);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 16578, 16678);

                string
                classId = f_1089_16595_16667(so, FormatInfoData.classidProperty) as string
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 16692, 17389) || true) && (classId == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 16692, 17389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 16745, 16828);

                    string
                    msg = f_1089_16758_16827(f_1089_16776_16826())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 16848, 17215);

                    ErrorRecord
                    errorRecord = f_1089_16874_17214(f_1089_16940_16985("classid"), "FormatObjectDeserializerInvalidClassidProperty", ErrorCategory.InvalidData, so)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 17235, 17284);

                    errorRecord.ErrorDetails = f_1089_17262_17283(msg);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 17302, 17374);

                    f_1089_17302_17373(f_1089_17302_17338(deserializer), errorRecord);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 16692, 17389);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 17405, 17464);

                FormatInfoData
                fid = f_1089_17426_17463(classId, deserializer)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 17478, 17489);

                return fid;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1089, 16256, 17500);

                System.Management.Automation.PSArgumentNullException
                f_1089_16432_16476(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 16432, 16476);
                    return return_v;
                }


                object
                f_1089_16595_16667(System.Management.Automation.PSObject
                so, string
                name)
                {
                    var return_v = FormatObjectDeserializer.GetProperty(so, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 16595, 16667);
                    return return_v;
                }


                string
                f_1089_16776_16826()
                {
                    var return_v = FormatAndOut_format_xxx.FOD_InvalidClassidProperty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1089, 16776, 16826);
                    return return_v;
                }


                string
                f_1089_16758_16827(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 16758, 16827);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1089_16940_16985(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 16940, 16985);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1089_16874_17214(System.Management.Automation.PSArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.PSObject
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 16874, 17214);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1089_17262_17283(string
                message)
                {
                    var return_v = new System.Management.Automation.ErrorDetails(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 17262, 17283);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                f_1089_17302_17338(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param)
                {
                    var return_v = this_param.TerminatingErrorContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1089, 17302, 17338);
                    return return_v;
                }


                int
                f_1089_17302_17373(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 17302, 17373);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatInfoData
                f_1089_17426_17463(string
                clsid, Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                deserializer)
                {
                    var return_v = CreateInstance(clsid, deserializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 17426, 17463);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 16256, 17500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 16256, 17500);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static FormatInfoData CreateInstance(string clsid, FormatObjectDeserializer deserializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1089, 17548, 19463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 17670, 17696);

                Func<FormatInfoData>
                ctor
                = default(Func<FormatInfoData>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 17710, 17923) || true) && (!f_1089_17715_17758(s_constructors, clsid, out ctor))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 17710, 17923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 17792, 17878);

                    f_1089_17792_17877(f_1089_17812_17855("clsid"), clsid, deserializer);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 17896, 17908);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 17710, 17923);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 17975, 18003);

                    FormatInfoData
                    fid = f_1089_17996_18002(ctor)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 18021, 18032);

                    return fid;
                }
                catch (ArgumentException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1089, 18061, 18180);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 18121, 18165);

                    f_1089_18121_18164(e, clsid, deserializer);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1089, 18061, 18180);
                }
                catch (NotSupportedException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1089, 18194, 18317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 18258, 18302);

                    f_1089_18258_18301(e, clsid, deserializer);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1089, 18194, 18317);
                }
                catch (TargetInvocationException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1089, 18331, 18458);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 18399, 18443);

                    f_1089_18399_18442(e, clsid, deserializer);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1089, 18331, 18458);
                }
                catch (MemberAccessException e) // also MethodAccessException and MissingMethodException
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1089, 18472, 18652);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 18593, 18637);

                    f_1089_18593_18636(e, clsid, deserializer);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1089, 18472, 18652);
                }
                catch (System.Runtime.InteropServices.InvalidComObjectException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1089, 18666, 18824);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 18765, 18809);

                    f_1089_18765_18808(e, clsid, deserializer);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1089, 18666, 18824);
                }
                catch (System.Runtime.InteropServices.COMException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1089, 18838, 18983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 18924, 18968);

                    f_1089_18924_18967(e, clsid, deserializer);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1089, 18838, 18983);
                }
                catch (TypeLoadException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1089, 18997, 19116);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 19057, 19101);

                    f_1089_19057_19100(e, clsid, deserializer);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1089, 18997, 19116);
                }
                catch (Exception e) // will rethrow
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1089, 19130, 19424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 19198, 19385);

                    f_1089_19198_19384(false, "Unexpected Activator.CreateInstance error in FormatInfoDataClassFactory.CreateInstance: "
                                            + f_1089_19363_19383(f_1089_19363_19374(e)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 19403, 19409);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1089, 19130, 19424);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 19440, 19452);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1089, 17548, 19463);

                bool
                f_1089_17715_17758(System.Collections.Generic.Dictionary<string, System.Func<Microsoft.PowerShell.Commands.Internal.Format.FormatInfoData>>
                this_param, string
                key, out System.Func<Microsoft.PowerShell.Commands.Internal.Format.FormatInfoData>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 17715, 17758);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1089_17812_17855(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 17812, 17855);
                    return return_v;
                }


                int
                f_1089_17792_17877(System.Management.Automation.PSArgumentException
                e, string
                clsid, Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                deserializer)
                {
                    CreateInstanceError((System.Exception)e, clsid, deserializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 17792, 17877);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatInfoData
                f_1089_17996_18002(System.Func<Microsoft.PowerShell.Commands.Internal.Format.FormatInfoData>
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 17996, 18002);
                    return return_v;
                }


                int
                f_1089_18121_18164(System.ArgumentException
                e, string
                clsid, Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                deserializer)
                {
                    CreateInstanceError((System.Exception)e, clsid, deserializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 18121, 18164);
                    return 0;
                }


                int
                f_1089_18258_18301(System.NotSupportedException
                e, string
                clsid, Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                deserializer)
                {
                    CreateInstanceError((System.Exception)e, clsid, deserializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 18258, 18301);
                    return 0;
                }


                int
                f_1089_18399_18442(System.Reflection.TargetInvocationException
                e, string
                clsid, Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                deserializer)
                {
                    CreateInstanceError((System.Exception)e, clsid, deserializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 18399, 18442);
                    return 0;
                }


                int
                f_1089_18593_18636(System.MemberAccessException
                e, string
                clsid, Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                deserializer)
                {
                    CreateInstanceError((System.Exception)e, clsid, deserializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 18593, 18636);
                    return 0;
                }


                int
                f_1089_18765_18808(System.Runtime.InteropServices.InvalidComObjectException
                e, string
                clsid, Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                deserializer)
                {
                    CreateInstanceError((System.Exception)e, clsid, deserializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 18765, 18808);
                    return 0;
                }


                int
                f_1089_18924_18967(System.Runtime.InteropServices.COMException
                e, string
                clsid, Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                deserializer)
                {
                    CreateInstanceError((System.Exception)e, clsid, deserializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 18924, 18967);
                    return 0;
                }


                int
                f_1089_19057_19100(System.TypeLoadException
                e, string
                clsid, Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                deserializer)
                {
                    CreateInstanceError((System.Exception)e, clsid, deserializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 19057, 19100);
                    return 0;
                }


                System.Type
                f_1089_19363_19374(System.Exception
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 19363, 19374);
                    return return_v;
                }


                string
                f_1089_19363_19383(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1089, 19363, 19383);
                    return return_v;
                }


                int
                f_1089_19198_19384(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 19198, 19384);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 17548, 19463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 17548, 19463);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void CreateInstanceError(Exception e, string clsid, FormatObjectDeserializer deserializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1089, 19475, 20166);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 19605, 19687);

                string
                msg = f_1089_19618_19686(f_1089_19636_19678(), clsid)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 19703, 20004);

                ErrorRecord
                errorRecord = f_1089_19729_20003(e, "FormatObjectDeserializerInvalidClassid", ErrorCategory.InvalidData, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 20020, 20069);

                errorRecord.ErrorDetails = f_1089_20047_20068(msg);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 20083, 20155);

                f_1089_20083_20154(f_1089_20083_20119(deserializer), errorRecord);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1089, 19475, 20166);

                string
                f_1089_19636_19678()
                {
                    var return_v = FormatAndOut_format_xxx.FOD_InvalidClassid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1089, 19636, 19678);
                    return return_v;
                }


                string
                f_1089_19618_19686(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 19618, 19686);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1089_19729_20003(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 19729, 20003);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1089_20047_20068(string
                message)
                {
                    var return_v = new System.Management.Automation.ErrorDetails(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 20047, 20068);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                f_1089_20083_20119(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param)
                {
                    var return_v = this_param.TerminatingErrorContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1089, 20083, 20119);
                    return return_v;
                }


                int
                f_1089_20083_20154(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 20083, 20154);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 19475, 20166);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 19475, 20166);
            }
        }

        private static readonly Dictionary<string, Func<FormatInfoData>> s_constructors;
    }
    internal static class FormatInfoDataListDeserializer<T> where T : FormatInfoData
    {
        private static void ReadListHelper(IEnumerable en, List<T> lst, FormatObjectDeserializer deserializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1089, 20370, 20864);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 20497, 20546);

                f_1089_20497_20545(deserializer, en, "enumerable");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 20560, 20853);
                    foreach (object obj in f_1089_20583_20585_I(en))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 20560, 20853);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 20619, 20703);

                        FormatInfoData
                        fid = f_1089_20640_20702(deserializer, f_1089_20671_20701(obj))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 20721, 20740);

                        T
                        entry = fid as T
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 20758, 20805);

                        f_1089_20758_20804(deserializer, entry, "entry");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 20823, 20838);

                        f_1089_20823_20837(lst, entry);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 20560, 20853);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1089, 1, 294);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1089, 1, 294);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1089, 20370, 20864);

                int
                f_1089_20497_20545(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Collections.IEnumerable
                obj, string
                name)
                {
                    this_param.VerifyDataNotNull((object)obj, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 20497, 20545);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1089_20671_20701(object
                obj)
                {
                    var return_v = PSObjectHelper.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 20671, 20701);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatInfoData
                f_1089_20640_20702(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so)
                {
                    var return_v = this_param.DeserializeObject(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 20640, 20702);
                    return return_v;
                }


                int
                f_1089_20758_20804(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, T
                obj, string
                name)
                {
                    this_param.VerifyDataNotNull((object)obj, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 20758, 20804);
                    return 0;
                }


                int
                f_1089_20823_20837(System.Collections.Generic.List<T>
                this_param, T
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 20823, 20837);
                    return 0;
                }


                System.Collections.IEnumerable
                f_1089_20583_20585_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 20583, 20585);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 20370, 20864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 20370, 20864);
            }
        }

        internal static void ReadList(PSObject so, string property, List<T> lst, FormatObjectDeserializer deserializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1089, 20876, 21314);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 21012, 21128) || true) && (lst == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1089, 21012, 21128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 21061, 21113);

                    throw f_1089_21067_21112("lst");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1089, 21012, 21128);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 21144, 21214);

                object
                memberRaw = f_1089_21163_21213(so, property)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 21228, 21303);

                f_1089_21228_21302(f_1089_21243_21282(memberRaw), lst, deserializer);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1089, 20876, 21314);

                System.Management.Automation.PSArgumentNullException
                f_1089_21067_21112(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 21067, 21112);
                    return return_v;
                }


                object
                f_1089_21163_21213(System.Management.Automation.PSObject
                so, string
                name)
                {
                    var return_v = FormatObjectDeserializer.GetProperty(so, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 21163, 21213);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1089_21243_21282(object
                obj)
                {
                    var return_v = PSObjectHelper.GetEnumerable(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 21243, 21282);
                    return return_v;
                }


                int
                f_1089_21228_21302(System.Collections.IEnumerable
                en, System.Collections.Generic.List<T>
                lst, Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                deserializer)
                {
                    ReadListHelper(en, lst, deserializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 21228, 21302);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 20876, 21314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 20876, 21314);
            }
        }

        static FormatInfoDataListDeserializer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1089, 20273, 21321);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1089, 20273, 21321);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 20273, 21321);
        }

    }
    internal abstract partial class FormatInfoData
    {
        internal virtual void Deserialize(PSObject so, FormatObjectDeserializer deserializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 21439, 21528);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 21439, 21528);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 21439, 21528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 21439, 21528);
            }
        }
    }
    internal abstract partial class ControlInfoData : PacketInfoData
    {
        internal override void Deserialize(PSObject so, FormatObjectDeserializer deserializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 21624, 21914);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 21735, 21770);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Deserialize(so, deserializer), 1089, 21735, 21769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 21809, 21903);

                this.groupingEntry = (GroupingEntry)f_1089_21845_21902(deserializer, so, "groupingEntry");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 21624, 21914);

                Microsoft.PowerShell.Commands.Internal.Format.FormatInfoData
                f_1089_21845_21902(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeMemberObject(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 21845, 21902);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 21624, 21914);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 21624, 21914);
            }
        }
    }
    internal abstract partial class StartData : ControlInfoData
    {
        internal override void Deserialize(PSObject so, FormatObjectDeserializer deserializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 22005, 22258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 22116, 22151);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Deserialize(so, deserializer), 1089, 22116, 22150);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 22165, 22247);

                this.shapeInfo = (ShapeInfo)f_1089_22193_22246(deserializer, so, "shapeInfo");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 22005, 22258);

                Microsoft.PowerShell.Commands.Internal.Format.FormatInfoData
                f_1089_22193_22246(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeMemberObject(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 22193, 22246);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 22005, 22258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 22005, 22258);
            }
        }
    }
    internal sealed partial class AutosizeInfo : FormatInfoData
    {
        internal override void Deserialize(PSObject so, FormatObjectDeserializer deserializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 22349, 22600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 22460, 22495);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Deserialize(so, deserializer), 1089, 22460, 22494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 22509, 22589);

                this.objectCount = f_1089_22528_22588(deserializer, so, "objectCount");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 22349, 22600);

                int
                f_1089_22528_22588(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeIntMemberVariable(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 22528, 22588);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 22349, 22600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 22349, 22600);
            }
        }
    }
    internal sealed partial class FormatStartData : StartData
    {
        internal override void Deserialize(PSObject so, FormatObjectDeserializer deserializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 22689, 23349);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 22800, 22835);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Deserialize(so, deserializer), 1089, 22800, 22834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 22945, 23005);

                f_1089_22945_23004(            // for the base class the shapeInfo is optional, but it's mandatory for this class
                            deserializer, this.shapeInfo, "shapeInfo");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 23019, 23119);

                this.pageHeaderEntry = (PageHeaderEntry)f_1089_23059_23118(deserializer, so, "pageHeaderEntry");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 23133, 23233);

                this.pageFooterEntry = (PageFooterEntry)f_1089_23173_23232(deserializer, so, "pageFooterEntry");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 23247, 23338);

                this.autosizeInfo = (AutosizeInfo)f_1089_23281_23337(deserializer, so, "autosizeInfo");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 22689, 23349);

                int
                f_1089_22945_23004(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ShapeInfo
                obj, string
                name)
                {
                    this_param.VerifyDataNotNull((object)obj, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 22945, 23004);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatInfoData
                f_1089_23059_23118(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeMemberObject(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 23059, 23118);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatInfoData
                f_1089_23173_23232(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeMemberObject(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 23173, 23232);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatInfoData
                f_1089_23281_23337(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeMemberObject(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 23281, 23337);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 22689, 23349);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 22689, 23349);
            }
        }
    }
    internal sealed partial class FormatEntryData : PacketInfoData
    {
        internal override void Deserialize(PSObject so, FormatObjectDeserializer deserializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 23443, 23955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 23554, 23589);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Deserialize(so, deserializer), 1089, 23554, 23588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 23603, 23712);

                this.formatEntryInfo = (FormatEntryInfo)f_1089_23643_23711(deserializer, so, "formatEntryInfo");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 23726, 23803);

                this.outOfBand = f_1089_23743_23802(deserializer, so, "outOfBand");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 23817, 23894);

                this.writeStream = f_1089_23836_23893(deserializer, so);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 23908, 23944);

                this.isHelpObject = f_1089_23928_23943(so);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 23443, 23955);

                Microsoft.PowerShell.Commands.Internal.Format.FormatInfoData
                f_1089_23643_23711(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeMandatoryMemberObject(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 23643, 23711);
                    return return_v;
                }


                bool
                f_1089_23743_23802(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeBoolMemberVariable(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 23743, 23802);
                    return return_v;
                }


                System.Management.Automation.WriteStreamType
                f_1089_23836_23893(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so)
                {
                    var return_v = this_param.DeserializeWriteStreamTypeMemberVariable(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 23836, 23893);
                    return return_v;
                }


                bool
                f_1089_23928_23943(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.IsHelpObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1089, 23928, 23943);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 23443, 23955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 23443, 23955);
            }
        }
    }
    internal sealed partial class WideViewHeaderInfo : ShapeInfo
    {
        internal override void Deserialize(PSObject so, FormatObjectDeserializer deserializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 24047, 24292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 24158, 24193);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Deserialize(so, deserializer), 1089, 24158, 24192);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 24209, 24281);

                this.columns = f_1089_24224_24280(deserializer, so, "columns");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 24047, 24292);

                int
                f_1089_24224_24280(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeIntMemberVariable(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 24224, 24280);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 24047, 24292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 24047, 24292);
            }
        }
    }
    internal sealed partial class TableHeaderInfo : ShapeInfo
    {
        internal override void Deserialize(PSObject so, FormatObjectDeserializer deserializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 24381, 25155);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 24492, 24527);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Deserialize(so, deserializer), 1089, 24492, 24526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 24809, 24913);

                this.repeatHeader = f_1089_24829_24912(deserializer, so, "repeatHeader", cannotBeNull: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 24927, 25006);

                this.hideHeader = f_1089_24945_25005(deserializer, so, "hideHeader");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 25020, 25144);

                f_1089_25020_25143(so, "tableColumnInfoList", this.tableColumnInfoList, deserializer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 24381, 25155);

                bool
                f_1089_24829_24912(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property, bool
                cannotBeNull)
                {
                    var return_v = this_param.DeserializeBoolMemberVariable(so, property, cannotBeNull: cannotBeNull);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 24829, 24912);
                    return return_v;
                }


                bool
                f_1089_24945_25005(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeBoolMemberVariable(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 24945, 25005);
                    return return_v;
                }


                int
                f_1089_25020_25143(System.Management.Automation.PSObject
                so, string
                property, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo>
                lst, Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                deserializer)
                {
                    FormatInfoDataListDeserializer<TableColumnInfo>.ReadList(so, property, lst, deserializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 25020, 25143);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 24381, 25155);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 24381, 25155);
            }
        }
    }
    internal sealed partial class TableColumnInfo : FormatInfoData
    {
        internal override void Deserialize(PSObject so, FormatObjectDeserializer deserializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 25249, 25762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 25360, 25395);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Deserialize(so, deserializer), 1089, 25360, 25394);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 25409, 25477);

                this.width = f_1089_25422_25476(deserializer, so, "width");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 25491, 25567);

                this.alignment = f_1089_25508_25566(deserializer, so, "alignment");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 25581, 25652);

                this.label = f_1089_25594_25651(deserializer, so, "label");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 25666, 25751);

                this.propertyName = f_1089_25686_25750(deserializer, so, "propertyName");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 25249, 25762);

                int
                f_1089_25422_25476(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeIntMemberVariable(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 25422, 25476);
                    return return_v;
                }


                int
                f_1089_25508_25566(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeIntMemberVariable(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 25508, 25566);
                    return return_v;
                }


                string
                f_1089_25594_25651(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeStringMemberVariable(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 25594, 25651);
                    return return_v;
                }


                string
                f_1089_25686_25750(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeStringMemberVariable(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 25686, 25750);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 25249, 25762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 25249, 25762);
            }
        }
    }
    internal sealed partial class RawTextFormatEntry : FormatEntryInfo
    {
        internal override void Deserialize(PSObject so, FormatObjectDeserializer deserializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 25860, 26103);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 25971, 26006);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Deserialize(so, deserializer), 1089, 25971, 26005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 26020, 26092);

                this.text = f_1089_26032_26091(deserializer, so, "text");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 25860, 26103);

                string
                f_1089_26032_26091(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeStringMemberVariableRaw(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 26032, 26091);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 25860, 26103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 25860, 26103);
            }
        }
    }
    internal abstract partial class FreeFormatEntry : FormatEntryInfo
    {
        internal override void Deserialize(PSObject so, FormatObjectDeserializer deserializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 26200, 26483);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 26311, 26346);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Deserialize(so, deserializer), 1089, 26311, 26345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 26360, 26472);

                f_1089_26360_26471(so, "formatValueList", this.formatValueList, deserializer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 26200, 26483);

                int
                f_1089_26360_26471(System.Management.Automation.PSObject
                so, string
                property, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                lst, Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                deserializer)
                {
                    FormatInfoDataListDeserializer<FormatValue>.ReadList(so, property, lst, deserializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 26360, 26471);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 26200, 26483);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 26200, 26483);
            }
        }
    }
    internal sealed partial class ListViewEntry : FormatEntryInfo
    {
        internal override void Deserialize(PSObject so, FormatObjectDeserializer deserializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 26576, 26865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 26687, 26722);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Deserialize(so, deserializer), 1089, 26687, 26721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 26736, 26854);

                f_1089_26736_26853(so, "listViewFieldList", this.listViewFieldList, deserializer);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 26576, 26865);

                int
                f_1089_26736_26853(System.Management.Automation.PSObject
                so, string
                property, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListViewField>
                lst, Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                deserializer)
                {
                    FormatInfoDataListDeserializer<ListViewField>.ReadList(so, property, lst, deserializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 26736, 26853);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 26576, 26865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 26576, 26865);
            }
        }
    }
    internal sealed partial class ListViewField : FormatInfoData
    {
        internal override void Deserialize(PSObject so, FormatObjectDeserializer deserializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 26957, 27433);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 27068, 27103);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Deserialize(so, deserializer), 1089, 27068, 27102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 27117, 27188);

                this.label = f_1089_27130_27187(deserializer, so, "label");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 27202, 27287);

                this.propertyName = f_1089_27222_27286(deserializer, so, "propertyName");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 27301, 27422);

                this.formatPropertyField = (FormatPropertyField)f_1089_27349_27421(deserializer, so, "formatPropertyField");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 26957, 27433);

                string
                f_1089_27130_27187(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeStringMemberVariable(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 27130, 27187);
                    return return_v;
                }


                string
                f_1089_27222_27286(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeStringMemberVariable(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 27222, 27286);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatInfoData
                f_1089_27349_27421(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeMandatoryMemberObject(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 27349, 27421);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 26957, 27433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 26957, 27433);
            }
        }
    }
    internal sealed partial class TableRowEntry : FormatEntryInfo
    {
        internal override void Deserialize(PSObject so, FormatObjectDeserializer deserializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 27526, 27924);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 27637, 27672);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Deserialize(so, deserializer), 1089, 27637, 27671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 27686, 27822);

                f_1089_27686_27821(so, "formatPropertyFieldList", this.formatPropertyFieldList, deserializer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 27836, 27913);

                this.multiLine = f_1089_27853_27912(deserializer, so, "multiLine");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 27526, 27924);

                int
                f_1089_27686_27821(System.Management.Automation.PSObject
                so, string
                property, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField>
                lst, Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                deserializer)
                {
                    FormatInfoDataListDeserializer<FormatPropertyField>.ReadList(so, property, lst, deserializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 27686, 27821);
                    return 0;
                }


                bool
                f_1089_27853_27912(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeBoolMemberVariable(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 27853, 27912);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 27526, 27924);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 27526, 27924);
            }
        }
    }
    internal sealed partial class WideViewEntry : FormatEntryInfo
    {
        internal override void Deserialize(PSObject so, FormatObjectDeserializer deserializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 28017, 28309);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 28128, 28163);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Deserialize(so, deserializer), 1089, 28128, 28162);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 28177, 28298);

                this.formatPropertyField = (FormatPropertyField)f_1089_28225_28297(deserializer, so, "formatPropertyField");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 28017, 28309);

                Microsoft.PowerShell.Commands.Internal.Format.FormatInfoData
                f_1089_28225_28297(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeMandatoryMemberObject(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 28225, 28297);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 28017, 28309);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 28017, 28309);
            }
        }
    }
    internal sealed partial class FormatTextField : FormatValue
    {
        internal override void Deserialize(PSObject so, FormatObjectDeserializer deserializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 28400, 28640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 28511, 28546);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Deserialize(so, deserializer), 1089, 28511, 28545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 28560, 28629);

                this.text = f_1089_28572_28628(deserializer, so, "text");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 28400, 28640);

                string
                f_1089_28572_28628(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeStringMemberVariable(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 28572, 28628);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 28400, 28640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 28400, 28640);
            }
        }
    }
    internal sealed partial class FormatPropertyField : FormatValue
    {
        internal override void Deserialize(PSObject so, FormatObjectDeserializer deserializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 28735, 29083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 28846, 28881);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Deserialize(so, deserializer), 1089, 28846, 28880);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 28895, 28982);

                this.propertyValue = f_1089_28916_28981(deserializer, so, "propertyValue");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 28996, 29072);

                this.alignment = f_1089_29013_29071(deserializer, so, "alignment");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 28735, 29083);

                string
                f_1089_28916_28981(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeStringMemberVariable(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 28916, 28981);
                    return return_v;
                }


                int
                f_1089_29013_29071(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeIntMemberVariable(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 29013, 29071);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 28735, 29083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 28735, 29083);
            }
        }
    }
    internal sealed partial class FormatEntry : FormatValue
    {
        internal override void Deserialize(PSObject so, FormatObjectDeserializer deserializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 29170, 29549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 29281, 29316);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Deserialize(so, deserializer), 1089, 29281, 29315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 29330, 29442);

                f_1089_29330_29441(so, "formatValueList", this.formatValueList, deserializer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 29456, 29538);

                this.frameInfo = (FrameInfo)f_1089_29484_29537(deserializer, so, "frameInfo");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 29170, 29549);

                int
                f_1089_29330_29441(System.Management.Automation.PSObject
                so, string
                property, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                lst, Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                deserializer)
                {
                    FormatInfoDataListDeserializer<FormatValue>.ReadList(so, property, lst, deserializer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 29330, 29441);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatInfoData
                f_1089_29484_29537(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeMemberObject(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 29484, 29537);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 29170, 29549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 29170, 29549);
            }
        }
    }
    internal sealed partial class FrameInfo : FormatInfoData
    {
        internal override void Deserialize(PSObject so, FormatObjectDeserializer deserializer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1089, 29637, 30090);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 29748, 29783);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Deserialize(so, deserializer), 1089, 29748, 29782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 29797, 29885);

                this.leftIndentation = f_1089_29820_29884(deserializer, so, "leftIndentation");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 29899, 29989);

                this.rightIndentation = f_1089_29923_29988(deserializer, so, "rightIndentation");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1089, 30003, 30079);

                this.firstLine = f_1089_30020_30078(deserializer, so, "firstLine");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1089, 29637, 30090);

                int
                f_1089_29820_29884(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeIntMemberVariable(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 29820, 29884);
                    return return_v;
                }


                int
                f_1089_29923_29988(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeIntMemberVariable(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 29923, 29988);
                    return return_v;
                }


                int
                f_1089_30020_30078(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so, string
                property)
                {
                    var return_v = this_param.DeserializeIntMemberVariable(so, property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1089, 30020, 30078);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1089, 29637, 30090);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1089, 29637, 30090);
            }
        }
    }
}

