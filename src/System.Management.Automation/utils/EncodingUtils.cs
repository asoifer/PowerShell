// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using System.Management.Automation.Internal;

namespace System.Management.Automation
{
    internal static class EncodingConversion
    {
        internal const string
        Unknown = "unknown"
        ;

        internal const string
        String = "string"
        ;

        internal const string
        Unicode = "unicode"
        ;

        internal const string
        BigEndianUnicode = "bigendianunicode"
        ;

        internal const string
        Ascii = "ascii"
        ;

        internal const string
        Utf8 = "utf8"
        ;

        internal const string
        Utf8NoBom = "utf8NoBOM"
        ;

        internal const string
        Utf8Bom = "utf8BOM"
        ;

        internal const string
        Utf7 = "utf7"
        ;

        internal const string
        Utf32 = "utf32"
        ;

        internal const string
        Default = "default"
        ;

        internal const string
        OEM = "oem"
        ;

        internal static readonly string[] TabCompletionResults;

        internal static Dictionary<string, Encoding> encodingMap;

        internal static Encoding Convert(Cmdlet cmdlet, string encoding)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1008, 2262, 3380);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 2351, 2529) || true) && (f_1008_2355_2385(encoding))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1008, 2351, 2529);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 2476, 2514);

                    return f_1008_2483_2513();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1008, 2351, 2529);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 2545, 2568);

                Encoding
                foundEncoding
                = default(Encoding);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 2582, 2708) || true) && (f_1008_2586_2638(encodingMap, encoding, out foundEncoding))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1008, 2582, 2708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 2672, 2693);

                    return foundEncoding;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1008, 2582, 2708);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 2780, 2849);

                string
                validEncodingValues = f_1008_2809_2848(", ", TabCompletionResults)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 2863, 2978);

                string
                msg = f_1008_2876_2977(f_1008_2894_2945(), encoding, validEncodingValues)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 2994, 3220);

                ErrorRecord
                errorRecord = f_1008_3020_3219(f_1008_3054_3100("Encoding"), "WriteToFileEncodingUnknown", ErrorCategory.InvalidArgument, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 3236, 3285);

                errorRecord.ErrorDetails = f_1008_3263_3284(msg);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 3299, 3341);

                f_1008_3299_3340(cmdlet, errorRecord);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 3357, 3369);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1008, 2262, 3380);

                bool
                f_1008_2355_2385(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1008, 2355, 2385);
                    return return_v;
                }


                System.Text.Encoding
                f_1008_2483_2513()
                {
                    var return_v = ClrFacade.GetDefaultEncoding();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1008, 2483, 2513);
                    return return_v;
                }


                bool
                f_1008_2586_2638(System.Collections.Generic.Dictionary<string, System.Text.Encoding>
                this_param, string
                key, out System.Text.Encoding
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1008, 2586, 2638);
                    return return_v;
                }


                string
                f_1008_2809_2848(string
                separator, params string[]
                value)
                {
                    var return_v = string.Join(separator, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1008, 2809, 2848);
                    return return_v;
                }


                string
                f_1008_2894_2945()
                {
                    var return_v = PathUtilsStrings.OutFile_WriteToFileEncodingUnknown;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1008, 2894, 2945);
                    return return_v;
                }


                string
                f_1008_2876_2977(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1008, 2876, 2977);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1008_3054_3100(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1008, 3054, 3100);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1008_3020_3219(System.Management.Automation.PSArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1008, 3020, 3219);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1008_3263_3284(string
                message)
                {
                    var return_v = new System.Management.Automation.ErrorDetails(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1008, 3263, 3284);
                    return return_v;
                }


                int
                f_1008_3299_3340(System.Management.Automation.Cmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1008, 3299, 3340);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1008, 2262, 3380);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1008, 2262, 3380);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EncodingConversion()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1008, 299, 3387);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 378, 397);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 430, 447);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 480, 499);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 532, 569);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 602, 617);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 650, 663);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 696, 719);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 752, 771);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 804, 817);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 850, 865);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 898, 917);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 950, 961);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 1006, 1139);
            TabCompletionResults = new string[]{
                Ascii, BigEndianUnicode, OEM, Unicode, Utf7, Utf8, Utf8Bom, Utf8NoBom, Utf32
            };
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 1197, 1970);
            encodingMap = new Dictionary<string, Encoding>(f_1008_1244_1276())
        {
            { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => Ascii,1008,1211,1970),f_1008_1311_1337()},            { BigEndianUnicode, f_1008_1374_1411()},            { Default, f_1008_1439_1469()},            { OEM, f_1008_1493_1519()},            { Unicode, f_1008_1547_1575()},            { Utf7, f_1008_1600_1625()},            { Utf8, f_1008_1650_1680()},            { Utf8Bom, f_1008_1708_1733()},            { Utf8NoBom, f_1008_1763_1793()},            { Utf32, f_1008_1819_1845()},            { String, f_1008_1872_1900()},            { Unknown, f_1008_1928_1956()}        };
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1008, 299, 3387);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1008, 299, 3387);
        }


        static System.StringComparer
        f_1008_1244_1276()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1008, 1244, 1276);
            return return_v;
        }


        static System.Text.Encoding
        f_1008_1311_1337()
        {
            var return_v = System.Text.Encoding.ASCII;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1008, 1311, 1337);
            return return_v;
        }


        static System.Text.Encoding
        f_1008_1374_1411()
        {
            var return_v = System.Text.Encoding.BigEndianUnicode;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1008, 1374, 1411);
            return return_v;
        }


        static System.Text.Encoding
        f_1008_1439_1469()
        {
            var return_v = ClrFacade.GetDefaultEncoding();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1008, 1439, 1469);
            return return_v;
        }


        static System.Text.Encoding
        f_1008_1493_1519()
        {
            var return_v = ClrFacade.GetOEMEncoding();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1008, 1493, 1519);
            return return_v;
        }


        static System.Text.Encoding
        f_1008_1547_1575()
        {
            var return_v = System.Text.Encoding.Unicode;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1008, 1547, 1575);
            return return_v;
        }


        static System.Text.Encoding
        f_1008_1600_1625()
        {
            var return_v = System.Text.Encoding.UTF7;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1008, 1600, 1625);
            return return_v;
        }


        static System.Text.Encoding
        f_1008_1650_1680()
        {
            var return_v = ClrFacade.GetDefaultEncoding();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1008, 1650, 1680);
            return return_v;
        }


        static System.Text.Encoding
        f_1008_1708_1733()
        {
            var return_v = System.Text.Encoding.UTF8;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1008, 1708, 1733);
            return return_v;
        }


        static System.Text.Encoding
        f_1008_1763_1793()
        {
            var return_v = ClrFacade.GetDefaultEncoding();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1008, 1763, 1793);
            return return_v;
        }


        static System.Text.Encoding
        f_1008_1819_1845()
        {
            var return_v = System.Text.Encoding.UTF32;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1008, 1819, 1845);
            return return_v;
        }


        static System.Text.Encoding
        f_1008_1872_1900()
        {
            var return_v = System.Text.Encoding.Unicode;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1008, 1872, 1900);
            return return_v;
        }


        static System.Text.Encoding
        f_1008_1928_1956()
        {
            var return_v = System.Text.Encoding.Unicode;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1008, 1928, 1956);
            return return_v;
        }

    }
    internal sealed class ArgumentToEncodingTransformationAttribute : ArgumentTransformationAttribute
    {
        public override object Transform(EngineIntrinsics engineIntrinsics, object inputData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1008, 3860, 4561);
                System.Text.Encoding foundEncoding = default(System.Text.Encoding);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 3970, 4517);

                switch (inputData)
                {

                    case string stringName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1008, 3970, 4517);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 4066, 4396) || true) && (f_1008_4070_4152(EncodingConversion.encodingMap, stringName, out foundEncoding))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1008, 4066, 4396);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 4202, 4223);

                            return foundEncoding;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1008, 4066, 4396);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1008, 4066, 4396);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 4321, 4373);

                            return f_1008_4328_4372(stringName);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1008, 4066, 4396);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1008, 3970, 4517);

                    case int intName:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1008, 3970, 4517);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 4453, 4502);

                        return f_1008_4460_4501(intName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1008, 3970, 4517);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1008, 4533, 4550);

                return inputData;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1008, 3860, 4561);

                bool
                f_1008_4070_4152(System.Collections.Generic.Dictionary<string, System.Text.Encoding>
                this_param, string
                key, out System.Text.Encoding
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1008, 4070, 4152);
                    return return_v;
                }


                System.Text.Encoding
                f_1008_4328_4372(string
                name)
                {
                    var return_v = System.Text.Encoding.GetEncoding(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1008, 4328, 4372);
                    return return_v;
                }


                System.Text.Encoding
                f_1008_4460_4501(int
                codepage)
                {
                    var return_v = System.Text.Encoding.GetEncoding(codepage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1008, 4460, 4501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1008, 3860, 4561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1008, 3860, 4561);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ArgumentToEncodingTransformationAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1008, 3746, 4568);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1008, 3746, 4568);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1008, 3746, 4568);
        }


        static ArgumentToEncodingTransformationAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1008, 3746, 4568);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1008, 3746, 4568);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1008, 3746, 4568);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1008, 3746, 4568);
    }
    internal sealed class ArgumentEncodingCompletionsAttribute : ArgumentCompletionsAttribute
    {
        public ArgumentEncodingCompletionsAttribute() : base(
        f_1008_4878_4902_C(EncodingConversion.Ascii), EncodingConversion.BigEndianUnicode, EncodingConversion.OEM, EncodingConversion.Unicode, EncodingConversion.Utf7, EncodingConversion.Utf8, EncodingConversion.Utf8Bom, EncodingConversion.Utf8NoBom, EncodingConversion.Utf32
                )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1008, 4811, 5253);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1008, 4811, 5253);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1008, 4811, 5253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1008, 4811, 5253);
            }
        }

        static ArgumentEncodingCompletionsAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1008, 4705, 5260);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1008, 4705, 5260);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1008, 4705, 5260);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1008, 4705, 5260);

        static string
        f_1008_4878_4902_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1008, 4811, 5253);
            return return_v;
        }

    }
}
