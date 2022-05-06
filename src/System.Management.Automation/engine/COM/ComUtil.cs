// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.ObjectModel;
using System.Management.Automation.ComInterop;
using System.Runtime.InteropServices;
using System.Text;

using COM = System.Runtime.InteropServices.ComTypes;

// Stops compiler from warning about unknown warnings. Prefast warning numbers are not recognized by C# compiler
#pragma warning disable 1634, 1691

namespace System.Management.Automation
{
    internal class ComUtil
    {
        internal const int
        DISP_E_MEMBERNOTFOUND = unchecked((int)0x80020003)
        ;

        internal const int
        DISP_E_UNKNOWNNAME = unchecked((int)0x80020006)
        ;

        internal const int
        TYPE_E_ELEMENTNOTFOUND = unchecked((int)0x8002802b)
        ;

        internal static string GetMethodSignatureFromFuncDesc(COM.ITypeInfo typeinfo, COM.FUNCDESC funcdesc, bool isPropertyPut)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1382, 1585, 4402);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 1730, 1774);

                StringBuilder
                builder = f_1382_1754_1773()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 1835, 1873);

                int
                namesCount = funcdesc.cParams + 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 1887, 1937);

                string[]
                names = new string[funcdesc.cParams + 1]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 1951, 2020);

                f_1382_1951_2019(typeinfo, funcdesc.memid, names, namesCount, out namesCount);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 2036, 2291) || true) && (!isPropertyPut)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 2036, 2291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 2146, 2226);

                    string
                    retstring = f_1382_2165_2225(typeinfo, funcdesc.elemdescFunc.tdesc)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 2244, 2276);

                    f_1382_2244_2275(builder, retstring + " ");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 2036, 2291);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 2348, 2373);

                f_1382_2348_2372(
                            // Append the function name
                            builder, names[0]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 2387, 2408);

                f_1382_2387_2407(builder, " (");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 2424, 2487);

                IntPtr
                ElementDescriptionArrayPtr = funcdesc.lprgelemdescParam
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 2501, 2561);

                int
                ElementDescriptionSize = f_1382_2530_2560()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 2586, 2591);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 2577, 4313) || true) && (i < funcdesc.cParams)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 2615, 2618)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 2577, 4313))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 2577, 4313);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 2652, 2684);

                        COM.ELEMDESC
                        ElementDescription
                        = default(COM.ELEMDESC);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 2702, 2740);

                        int
                        ElementDescriptionArrayByteOffset
                        = default(int);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 2758, 2791);

                        IntPtr
                        ElementDescriptionPointer
                        = default(IntPtr);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 2811, 2851);

                        ElementDescription = f_1382_2832_2850();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 2869, 2932);

                        ElementDescriptionArrayByteOffset = i * ElementDescriptionSize;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 3163, 3548) || true) && (IntPtr.Size == 4)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 3163, 3548);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 3225, 3336);

                            ElementDescriptionPointer = (IntPtr)(ElementDescriptionArrayPtr.ToInt32() + ElementDescriptionArrayByteOffset);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 3163, 3548);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 3163, 3548);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 3418, 3529);

                            ElementDescriptionPointer = (IntPtr)(ElementDescriptionArrayPtr.ToInt64() + ElementDescriptionArrayByteOffset);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 3163, 3548);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 3599, 3684);

                        ElementDescription = f_1382_3620_3683(ElementDescriptionPointer);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 3704, 3783);

                        string
                        paramstring = f_1382_3725_3782(typeinfo, ElementDescription.tdesc)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 3803, 4298) || true) && (i == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1382, 3807, 3830) && isPropertyPut))
                        ) // use the type of the first argument as the return type

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 3803, 4298);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 3929, 3966);

                            f_1382_3929_3965(builder, 0, paramstring + " ");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 3803, 4298);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 3803, 4298);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 4048, 4076);

                            f_1382_4048_4075(builder, paramstring);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 4098, 4133);

                            f_1382_4098_4132(builder, " " + names[i + 1]);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 4157, 4279) || true) && (i < funcdesc.cParams - 1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 4157, 4279);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 4235, 4256);

                                f_1382_4235_4255(builder, ", ");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 4157, 4279);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 3803, 4298);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1382, 1, 1737);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1382, 1, 1737);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 4329, 4349);

                f_1382_4329_4348(
                            builder, ")");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 4365, 4391);

                return f_1382_4372_4390(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1382, 1585, 4402);

                System.Text.StringBuilder
                f_1382_1754_1773()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 1754, 1773);
                    return return_v;
                }


                int
                f_1382_1951_2019(System.Runtime.InteropServices.ComTypes.ITypeInfo
                this_param, int
                memid, string[]
                rgBstrNames, int
                cMaxNames, out int
                pcNames)
                {
                    this_param.GetNames(memid, rgBstrNames, cMaxNames, out pcNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 1951, 2019);
                    return 0;
                }


                string
                f_1382_2165_2225(System.Runtime.InteropServices.ComTypes.ITypeInfo
                typeinfo, System.Runtime.InteropServices.ComTypes.TYPEDESC
                typedesc)
                {
                    var return_v = GetStringFromTypeDesc(typeinfo, typedesc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 2165, 2225);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1382_2244_2275(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 2244, 2275);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1382_2348_2372(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 2348, 2372);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1382_2387_2407(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 2387, 2407);
                    return return_v;
                }


                int
                f_1382_2530_2560()
                {
                    var return_v = Marshal.SizeOf<COM.ELEMDESC>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 2530, 2560);
                    return return_v;
                }


                System.Runtime.InteropServices.ComTypes.ELEMDESC
                f_1382_2832_2850()
                {
                    var return_v = new System.Runtime.InteropServices.ComTypes.ELEMDESC();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 2832, 2850);
                    return return_v;
                }


                System.Runtime.InteropServices.ComTypes.ELEMDESC
                f_1382_3620_3683(System.IntPtr
                ptr)
                {
                    var return_v = Marshal.PtrToStructure<COM.ELEMDESC>(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 3620, 3683);
                    return return_v;
                }


                string
                f_1382_3725_3782(System.Runtime.InteropServices.ComTypes.ITypeInfo
                typeinfo, System.Runtime.InteropServices.ComTypes.TYPEDESC
                typedesc)
                {
                    var return_v = GetStringFromTypeDesc(typeinfo, typedesc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 3725, 3782);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1382_3929_3965(System.Text.StringBuilder
                this_param, int
                index, string
                value)
                {
                    var return_v = this_param.Insert(index, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 3929, 3965);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1382_4048_4075(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 4048, 4075);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1382_4098_4132(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 4098, 4132);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1382_4235_4255(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 4235, 4255);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1382_4329_4348(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 4329, 4348);
                    return return_v;
                }


                string
                f_1382_4372_4390(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 4372, 4390);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1382, 1585, 4402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1382, 1585, 4402);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetNameFromFuncDesc(COM.ITypeInfo typeinfo, COM.FUNCDESC funcdesc)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1382, 4752, 5110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 4915, 4947);

                string
                strName
                = default(string),
                strDoc
                = default(string),
                strHelp
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 4961, 4968);

                int
                id
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 4982, 5070);

                f_1382_4982_5069(typeinfo, funcdesc.memid, out strName, out strDoc, out id, out strHelp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 5084, 5099);

                return strName;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1382, 4752, 5110);

                int
                f_1382_4982_5069(System.Runtime.InteropServices.ComTypes.ITypeInfo
                this_param, int
                index, out string
                strName, out string
                strDocString, out int
                dwHelpContext, out string
                strHelpFile)
                {
                    this_param.GetDocumentation(index, out strName, out strDocString, out dwHelpContext, out strHelpFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 4982, 5069);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1382, 4752, 5110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1382, 4752, 5110);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetStringFromCustomType(COM.ITypeInfo typeinfo, IntPtr refptr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1382, 5450, 6161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 5559, 5586);

                COM.ITypeInfo
                custtypeinfo
                = default(COM.ITypeInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 5600, 5643);

                int
                reftype = unchecked((int)(long)refptr)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 5779, 5830);

                f_1382_5779_5829(
                            typeinfo, reftype, out custtypeinfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 5846, 6107) || true) && (custtypeinfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 5846, 6107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 5904, 5936);

                    string
                    strName
                    = default(string),
                    strDoc
                    = default(string),
                    strHelp
                    = default(string);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 5954, 5961);

                    int
                    id
                    = default(int);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 5979, 6059);

                    f_1382_5979_6058(custtypeinfo, -1, out strName, out strDoc, out id, out strHelp);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 6077, 6092);

                    return strName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 5846, 6107);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 6123, 6150);

                return "UnknownCustomtype";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1382, 5450, 6161);

                int
                f_1382_5779_5829(System.Runtime.InteropServices.ComTypes.ITypeInfo
                this_param, int
                hRef, out System.Runtime.InteropServices.ComTypes.ITypeInfo
                ppTI)
                {
                    this_param.GetRefTypeInfo(hRef, out ppTI);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 5779, 5829);
                    return 0;
                }


                int
                f_1382_5979_6058(System.Runtime.InteropServices.ComTypes.ITypeInfo
                this_param, int
                index, out string
                strName, out string
                strDocString, out int
                dwHelpContext, out string
                strHelpFile)
                {
                    this_param.GetDocumentation(index, out strName, out strDocString, out dwHelpContext, out strHelpFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 5979, 6058);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1382, 5450, 6161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1382, 5450, 6161);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetStringFromTypeDesc(COM.ITypeInfo typeinfo, COM.TYPEDESC typedesc)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1382, 6771, 9657);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 6886, 7121) || true) && ((VarEnum)typedesc.vt == VarEnum.VT_PTR)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 6886, 7121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 6962, 7040);

                    COM.TYPEDESC
                    refdesc = f_1382_6985_7039(typedesc.lpValue)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 7058, 7106);

                    return f_1382_7065_7105(typeinfo, refdesc);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 6886, 7121);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 7137, 7399) || true) && ((VarEnum)typedesc.vt == VarEnum.VT_SAFEARRAY)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7137, 7399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 7219, 7297);

                    COM.TYPEDESC
                    refdesc = f_1382_7242_7296(typedesc.lpValue)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 7315, 7384);

                    return "SAFEARRAY(" + f_1382_7337_7377(typeinfo, refdesc) + ")";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7137, 7399);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 7415, 7573) || true) && ((VarEnum)typedesc.vt == VarEnum.VT_USERDEFINED)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7415, 7573);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 7499, 7558);

                    return f_1382_7506_7557(typeinfo, typedesc.lpValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7415, 7573);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 7589, 9646);

                switch ((VarEnum)typedesc.vt)
                {

                    case VarEnum.VT_I1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7589, 9646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 7692, 7706);

                        return "char";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7589, 9646);

                    case VarEnum.VT_I2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7589, 9646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 7767, 7782);

                        return "short";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7589, 9646);

                    case VarEnum.VT_I4:
                    case VarEnum.VT_INT:
                    case VarEnum.VT_HRESULT:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7589, 9646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 7923, 7936);

                        return "int";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7589, 9646);

                    case VarEnum.VT_I8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7589, 9646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 7997, 8012);

                        return "int64";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7589, 9646);

                    case VarEnum.VT_R4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7589, 9646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 8073, 8088);

                        return "float";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7589, 9646);

                    case VarEnum.VT_R8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7589, 9646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 8149, 8165);

                        return "double";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7589, 9646);

                    case VarEnum.VT_UI1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7589, 9646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 8227, 8241);

                        return "byte";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7589, 9646);

                    case VarEnum.VT_UI2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7589, 9646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 8303, 8319);

                        return "ushort";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7589, 9646);

                    case VarEnum.VT_UI4:
                    case VarEnum.VT_UINT:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7589, 9646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 8420, 8434);

                        return "uint";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7589, 9646);

                    case VarEnum.VT_UI8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7589, 9646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 8496, 8512);

                        return "uint64";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7589, 9646);

                    case VarEnum.VT_BSTR:
                    case VarEnum.VT_LPSTR:
                    case VarEnum.VT_LPWSTR:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7589, 9646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 8656, 8672);

                        return "string";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7589, 9646);

                    case VarEnum.VT_DATE:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7589, 9646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 8735, 8749);

                        return "Date";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7589, 9646);

                    case VarEnum.VT_BOOL:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7589, 9646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 8812, 8826);

                        return "bool";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7589, 9646);

                    case VarEnum.VT_CY:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7589, 9646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 8887, 8905);

                        return "currency";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7589, 9646);

                    case VarEnum.VT_DECIMAL:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7589, 9646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 8971, 8988);

                        return "decimal";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7589, 9646);

                    case VarEnum.VT_CLSID:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7589, 9646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 9052, 9067);

                        return "clsid";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7589, 9646);

                    case VarEnum.VT_DISPATCH:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7589, 9646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 9134, 9153);

                        return "IDispatch";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7589, 9646);

                    case VarEnum.VT_UNKNOWN:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7589, 9646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 9219, 9237);

                        return "IUnknown";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7589, 9646);

                    case VarEnum.VT_VARIANT:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7589, 9646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 9303, 9320);

                        return "Variant";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7589, 9646);

                    case VarEnum.VT_VOID:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7589, 9646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 9383, 9397);

                        return "void";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7589, 9646);

                    case VarEnum.VT_ARRAY:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7589, 9646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 9461, 9479);

                        return "object[]";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7589, 9646);

                    case VarEnum.VT_EMPTY:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7589, 9646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 9543, 9563);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7589, 9646);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 7589, 9646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 9613, 9631);

                        return "Unknown!";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 7589, 9646);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1382, 6771, 9657);

                System.Runtime.InteropServices.ComTypes.TYPEDESC
                f_1382_6985_7039(System.IntPtr
                ptr)
                {
                    var return_v = Marshal.PtrToStructure<COM.TYPEDESC>(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 6985, 7039);
                    return return_v;
                }


                string
                f_1382_7065_7105(System.Runtime.InteropServices.ComTypes.ITypeInfo
                typeinfo, System.Runtime.InteropServices.ComTypes.TYPEDESC
                typedesc)
                {
                    var return_v = GetStringFromTypeDesc(typeinfo, typedesc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 7065, 7105);
                    return return_v;
                }


                System.Runtime.InteropServices.ComTypes.TYPEDESC
                f_1382_7242_7296(System.IntPtr
                ptr)
                {
                    var return_v = Marshal.PtrToStructure<COM.TYPEDESC>(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 7242, 7296);
                    return return_v;
                }


                string
                f_1382_7337_7377(System.Runtime.InteropServices.ComTypes.ITypeInfo
                typeinfo, System.Runtime.InteropServices.ComTypes.TYPEDESC
                typedesc)
                {
                    var return_v = GetStringFromTypeDesc(typeinfo, typedesc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 7337, 7377);
                    return return_v;
                }


                string
                f_1382_7506_7557(System.Runtime.InteropServices.ComTypes.ITypeInfo
                typeinfo, System.IntPtr
                refptr)
                {
                    var return_v = GetStringFromCustomType(typeinfo, refptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 7506, 7557);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1382, 6771, 9657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1382, 6771, 9657);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Type GetTypeFromTypeDesc(COM.TYPEDESC typedesc)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1382, 9922, 10114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 10010, 10044);

                VarEnum
                vt = (VarEnum)typedesc.vt
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 10058, 10103);

                return f_1382_10065_10102(vt);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1382, 9922, 10114);

                System.Type
                f_1382_10065_10102(System.Runtime.InteropServices.VarEnum
                vt)
                {
                    var return_v = VarEnumSelector.GetTypeForVarEnum(vt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 10065, 10102);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1382, 9922, 10114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1382, 9922, 10114);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ComMethodInformation GetMethodInformation(COM.FUNCDESC funcdesc, bool skipLastParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1382, 10282, 10988);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 10410, 10477);

                Type
                returntype = f_1382_10428_10476(funcdesc.elemdescFunc.tdesc)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 10491, 10580);

                ParameterInformation[]
                parameters = f_1382_10527_10579(funcdesc, skipLastParameter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 10594, 10619);

                bool
                hasOptional = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 10633, 10851);
                    foreach (ParameterInformation p in f_1382_10668_10678_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 10633, 10851);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 10712, 10836) || true) && (p.isOptional)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 10712, 10836);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 10770, 10789);

                            hasOptional = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(1382, 10811, 10817);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 10712, 10836);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 10633, 10851);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1382, 1, 219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1382, 1, 219);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 10867, 10977);

                return f_1382_10874_10976(false, hasOptional, parameters, returntype, funcdesc.memid, funcdesc.invkind);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1382, 10282, 10988);

                System.Type
                f_1382_10428_10476(System.Runtime.InteropServices.ComTypes.TYPEDESC
                typedesc)
                {
                    var return_v = GetTypeFromTypeDesc(typedesc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 10428, 10476);
                    return return_v;
                }


                System.Management.Automation.ParameterInformation[]
                f_1382_10527_10579(System.Runtime.InteropServices.ComTypes.FUNCDESC
                funcdesc, bool
                skipLastParameter)
                {
                    var return_v = GetParameterInformation(funcdesc, skipLastParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 10527, 10579);
                    return return_v;
                }


                System.Management.Automation.ParameterInformation[]
                f_1382_10668_10678_I(System.Management.Automation.ParameterInformation[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 10668, 10678);
                    return return_v;
                }


                System.Management.Automation.ComMethodInformation
                f_1382_10874_10976(bool
                hasvarargs, bool
                hasoptional, System.Management.Automation.ParameterInformation[]
                arguments, System.Type
                returnType, int
                dispId, System.Runtime.InteropServices.ComTypes.INVOKEKIND
                invokekind)
                {
                    var return_v = new System.Management.Automation.ComMethodInformation(hasvarargs, hasoptional, arguments, returnType, dispId, invokekind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 10874, 10976);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1382, 10282, 10988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1382, 10282, 10988);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ParameterInformation[] GetParameterInformation(COM.FUNCDESC funcdesc, bool skipLastParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1382, 11116, 13659);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 11250, 11281);

                int
                cParams = funcdesc.cParams
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 11295, 11518) || true) && (skipLastParameter)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 11295, 11518);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 11350, 11475);

                    f_1382_11350_11474(cParams > 0, "skipLastParameter is only true for property setters where there is at least one parameter");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 11493, 11503);

                    cParams--;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 11295, 11518);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 11534, 11604);

                ParameterInformation[]
                parameters = new ParameterInformation[cParams]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 11620, 11683);

                IntPtr
                ElementDescriptionArrayPtr = funcdesc.lprgelemdescParam
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 11697, 11757);

                int
                ElementDescriptionSize = f_1382_11726_11756()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 11782, 11787);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 11773, 13614) || true) && (i < cParams)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 11802, 11805)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 11773, 13614))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 11773, 13614);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 11839, 11871);

                        COM.ELEMDESC
                        ElementDescription
                        = default(COM.ELEMDESC);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 11889, 11927);

                        int
                        ElementDescriptionArrayByteOffset
                        = default(int);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 11945, 11978);

                        IntPtr
                        ElementDescriptionPointer
                        = default(IntPtr);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 11996, 12019);

                        bool
                        fOptional = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 12039, 12079);

                        ElementDescription = f_1382_12060_12078();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 12097, 12160);

                        ElementDescriptionArrayByteOffset = i * ElementDescriptionSize;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 12391, 12776) || true) && (IntPtr.Size == 4)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 12391, 12776);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 12453, 12564);

                            ElementDescriptionPointer = (IntPtr)(ElementDescriptionArrayPtr.ToInt32() + ElementDescriptionArrayByteOffset);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 12391, 12776);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 12391, 12776);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 12646, 12757);

                            ElementDescriptionPointer = (IntPtr)(ElementDescriptionArrayPtr.ToInt64() + ElementDescriptionArrayByteOffset);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 12391, 12776);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 12829, 12914);

                        ElementDescription = f_1382_12850_12913(ElementDescriptionPointer);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 12980, 13046);

                        Type
                        type = f_1382_12992_13045(ElementDescription.tdesc)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 13064, 13091);

                        object
                        defaultvalue = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 13168, 13383) || true) && ((ElementDescription.desc.paramdesc.wParamFlags & COM.PARAMFLAG.PARAMFLAG_FOPT) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 13168, 13383);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 13297, 13314);

                            fOptional = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 13336, 13364);

                            defaultvalue = Type.Missing;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 13168, 13383);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 13403, 13501);

                        bool
                        fByRef = (ElementDescription.desc.paramdesc.wParamFlags & COM.PARAMFLAG.PARAMFLAG_FOUT) != 0
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 13519, 13599);

                        parameters[i] = f_1382_13535_13598(type, fOptional, defaultvalue, fByRef);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1382, 1, 1842);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1382, 1, 1842);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 13630, 13648);

                return parameters;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1382, 11116, 13659);

                int
                f_1382_11350_11474(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 11350, 11474);
                    return 0;
                }


                int
                f_1382_11726_11756()
                {
                    var return_v = Marshal.SizeOf<COM.ELEMDESC>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 11726, 11756);
                    return return_v;
                }


                System.Runtime.InteropServices.ComTypes.ELEMDESC
                f_1382_12060_12078()
                {
                    var return_v = new System.Runtime.InteropServices.ComTypes.ELEMDESC();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 12060, 12078);
                    return return_v;
                }


                System.Runtime.InteropServices.ComTypes.ELEMDESC
                f_1382_12850_12913(System.IntPtr
                ptr)
                {
                    var return_v = Marshal.PtrToStructure<COM.ELEMDESC>(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 12850, 12913);
                    return return_v;
                }


                System.Type
                f_1382_12992_13045(System.Runtime.InteropServices.ComTypes.TYPEDESC
                typedesc)
                {
                    var return_v = ComUtil.GetTypeFromTypeDesc(typedesc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 12992, 13045);
                    return return_v;
                }


                System.Management.Automation.ParameterInformation
                f_1382_13535_13598(System.Type
                parameterType, bool
                isOptional, object
                defaultValue, bool
                isByRef)
                {
                    var return_v = new System.Management.Automation.ParameterInformation(parameterType, isOptional, defaultValue, isByRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 13535, 13598);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1382, 11116, 13659);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1382, 11116, 13659);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ComMethodInformation[] GetMethodInformationArray(COM.ITypeInfo typeInfo, Collection<int> methods, bool skipLastParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1382, 13867, 14641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 14030, 14062);

                int
                methodCount = f_1382_14048_14061(methods)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 14076, 14090);

                int
                count = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 14104, 14179);

                ComMethodInformation[]
                returnValue = new ComMethodInformation[methodCount]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 14195, 14595);
                    foreach (int index in f_1382_14217_14224_I(methods))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 14195, 14595);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 14258, 14275);

                        IntPtr
                        pFuncDesc
                        = default(IntPtr);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 14293, 14336);

                        f_1382_14293_14335(typeInfo, index, out pFuncDesc);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 14354, 14426);

                        COM.FUNCDESC
                        funcdesc = f_1382_14378_14425(pFuncDesc)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 14444, 14526);

                        returnValue[count++] = f_1382_14467_14525(funcdesc, skipLastParameters);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 14544, 14580);

                        f_1382_14544_14579(typeInfo, pFuncDesc);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 14195, 14595);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1382, 1, 401);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1382, 1, 401);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 14611, 14630);

                return returnValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1382, 13867, 14641);

                int
                f_1382_14048_14061(System.Collections.ObjectModel.Collection<int>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1382, 14048, 14061);
                    return return_v;
                }


                int
                f_1382_14293_14335(System.Runtime.InteropServices.ComTypes.ITypeInfo
                this_param, int
                index, out System.IntPtr
                ppFuncDesc)
                {
                    this_param.GetFuncDesc(index, out ppFuncDesc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 14293, 14335);
                    return 0;
                }


                System.Runtime.InteropServices.ComTypes.FUNCDESC
                f_1382_14378_14425(System.IntPtr
                ptr)
                {
                    var return_v = Marshal.PtrToStructure<COM.FUNCDESC>(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 14378, 14425);
                    return return_v;
                }


                System.Management.Automation.ComMethodInformation
                f_1382_14467_14525(System.Runtime.InteropServices.ComTypes.FUNCDESC
                funcdesc, bool
                skipLastParameter)
                {
                    var return_v = ComUtil.GetMethodInformation(funcdesc, skipLastParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 14467, 14525);
                    return return_v;
                }


                int
                f_1382_14544_14579(System.Runtime.InteropServices.ComTypes.ITypeInfo
                this_param, System.IntPtr
                pFuncDesc)
                {
                    this_param.ReleaseFuncDesc(pFuncDesc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 14544, 14579);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<int>
                f_1382_14217_14224_I(System.Collections.ObjectModel.Collection<int>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 14217, 14224);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1382, 13867, 14641);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1382, 13867, 14641);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ComUtil()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1382, 631, 14648);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1382, 631, 14648);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1382, 631, 14648);
        }


        static ComUtil()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1382, 631, 14648);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 754, 804);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 895, 942);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 1038, 1089);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1382, 631, 14648);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1382, 631, 14648);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1382, 631, 14648);
    }
    internal class ComEnumerator : IEnumerator
    {
        private COM.IEnumVARIANT _enumVariant;

        private object[] _element;

        private ComEnumerator(COM.IEnumVARIANT enumVariant)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1382, 14911, 15064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 14850, 14862);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 14890, 14898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 14987, 15014);

                _enumVariant = enumVariant;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 15028, 15053);

                _element = new object[1];
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1382, 14911, 15064);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1382, 14911, 15064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1382, 14911, 15064);
            }
        }

        public object Current
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1382, 15122, 15149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 15128, 15147);

                    return _element[0];
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1382, 15122, 15149);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1382, 15076, 15160);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1382, 15076, 15160);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool MoveNext()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1382, 15172, 15353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 15219, 15238);

                _element[0] = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 15252, 15309);

                int
                result = f_1382_15265_15308(_enumVariant, 1, _element, IntPtr.Zero)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 15323, 15342);

                return result == 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1382, 15172, 15353);

                int
                f_1382_15265_15308(System.Runtime.InteropServices.ComTypes.IEnumVARIANT
                this_param, int
                celt, object[]
                rgVar, System.IntPtr
                pceltFetched)
                {
                    var return_v = this_param.Next(celt, rgVar, pceltFetched);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 15265, 15308);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1382, 15172, 15353);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1382, 15172, 15353);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Reset()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1382, 15365, 15474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 15409, 15428);

                _element[0] = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 15442, 15463);

                f_1382_15442_15462(_enumVariant);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1382, 15365, 15474);

                int
                f_1382_15442_15462(System.Runtime.InteropServices.ComTypes.IEnumVARIANT
                this_param)
                {
                    var return_v = this_param.Reset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 15442, 15462);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1382, 15365, 15474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1382, 15365, 15474);
            }
        }

        internal static ComEnumerator Create(object comObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1382, 15742, 16211);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 15821, 15896) || true) && (comObject == null || (DynAbs.Tracing.TraceSender.Expression_False(1382, 15825, 15878) || f_1382_15846_15878_M(!f_1382_15847_15866(comObject).IsCOMObject)))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1382, 15821, 15896);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 15882, 15894);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1382, 15821, 15896);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 16071, 16119);

                var
                enumVariant = comObject as COM.IEnumVARIANT
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1382, 16133, 16200);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1382, 16140, 16159) || ((enumVariant != null && DynAbs.Tracing.TraceSender.Conditional_F2(1382, 16162, 16192)) || DynAbs.Tracing.TraceSender.Conditional_F3(1382, 16195, 16199))) ? f_1382_16162_16192(enumVariant) : null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1382, 15742, 16211);

                System.Type
                f_1382_15847_15866(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 15847, 15866);
                    return return_v;
                }


                bool
                f_1382_15846_15878_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1382, 15846, 15878);
                    return return_v;
                }


                System.Management.Automation.ComEnumerator
                f_1382_16162_16192(System.Runtime.InteropServices.ComTypes.IEnumVARIANT
                enumVariant)
                {
                    var return_v = new System.Management.Automation.ComEnumerator(enumVariant);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1382, 16162, 16192);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1382, 15742, 16211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1382, 15742, 16211);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ComEnumerator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1382, 14766, 16218);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1382, 14766, 16218);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1382, 14766, 16218);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1382, 14766, 16218);
    }
}
