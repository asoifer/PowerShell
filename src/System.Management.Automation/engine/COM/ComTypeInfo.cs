// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Management.Automation.Internal;
using System.Runtime.InteropServices;

using COM = System.Runtime.InteropServices.ComTypes;

namespace System.Management.Automation
{
    internal class ComTypeInfo
    {
        internal const int
        DISPID_NEWENUM = -4
        ;

        internal const int
        DISPID_DEFAULTMEMBER = 0
        ;

        private Dictionary<string, ComProperty> _properties;

        private Dictionary<string, ComMethod> _methods;

        private COM.ITypeInfo _typeinfo;

        private Guid _guid;

        internal ComTypeInfo(COM.ITypeInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1381, 1574, 1957);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 1228, 1246);
                this._properties = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 1295, 1310);
                this._methods = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 1343, 1359);
                this._typeinfo = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 1383, 1401);
                this._guid = Guid.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 2924, 2988);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 1639, 1656);

                _typeinfo = info;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 1670, 1754);

                _properties = f_1381_1684_1753(f_1381_1720_1752());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 1768, 1847);

                _methods = f_1381_1779_1846(f_1381_1813_1845());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 1863, 1946) || true) && (_typeinfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1381, 1863, 1946);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 1918, 1931);

                    f_1381_1918_1930(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1381, 1863, 1946);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1381, 1574, 1957);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1381, 1574, 1957);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1381, 1574, 1957);
            }
        }

        internal Dictionary<string, ComProperty> Properties
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1381, 2149, 2219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 2185, 2204);

                    return _properties;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1381, 2149, 2219);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1381, 2073, 2230);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1381, 2073, 2230);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Dictionary<string, ComMethod> Methods
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1381, 2414, 2481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 2450, 2466);

                    return _methods;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1381, 2414, 2481);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1381, 2343, 2492);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1381, 2343, 2492);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal string Clsid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1381, 2667, 2742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 2703, 2727);

                    return _guid.ToString();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1381, 2667, 2742);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1381, 2621, 2753);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1381, 2621, 2753);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal COM.INVOKEKIND? NewEnumInvokeKind { get; private set; }

        private void Initialize()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1381, 3093, 5086);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 3143, 5075) || true) && (_typeinfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1381, 3143, 5075);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 3198, 3245);

                    COM.TYPEATTR
                    typeattr = f_1381_3222_3244(_typeinfo)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 3322, 3344);

                    _guid = typeattr.guid;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 3373, 3378);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 3364, 5060) || true) && (i < typeattr.cFuncs)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 3401, 3404)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1381, 3364, 5060))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1381, 3364, 5060);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 3446, 3496);

                            COM.FUNCDESC
                            funcdesc = f_1381_3470_3495(_typeinfo, i)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 3518, 3597) || true) && (funcdesc.memid == DISPID_NEWENUM)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1381, 3518, 3597);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 3558, 3595);

                                NewEnumInvokeKind = funcdesc.invkind;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1381, 3518, 3597);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 3621, 4410) || true) && ((funcdesc.wFuncFlags & 0x1) == 0x1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1381, 3621, 4410);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 4378, 4387);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1381, 3621, 4410);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 4434, 4500);

                            string
                            strName = f_1381_4451_4499(_typeinfo, funcdesc)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 4524, 5041);

                            switch (funcdesc.invkind)
                            {

                                case COM.INVOKEKIND.INVOKE_PROPERTYGET:
                                case COM.INVOKEKIND.INVOKE_PROPERTYPUT:
                                case COM.INVOKEKIND.INVOKE_PROPERTYPUTREF:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1381, 4524, 5041);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 4800, 4834);

                                    f_1381_4800_4833(this, strName, funcdesc, i);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1381, 4864, 4870);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1381, 4524, 5041);

                                case COM.INVOKEKIND.INVOKE_FUNC:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1381, 4524, 5041);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 4960, 4982);

                                    f_1381_4960_4981(this, strName, i);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1381, 5012, 5018);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1381, 4524, 5041);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1381, 1, 1697);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1381, 1, 1697);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1381, 3143, 5075);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1381, 3093, 5086);

                System.Runtime.InteropServices.ComTypes.TYPEATTR
                f_1381_3222_3244(System.Runtime.InteropServices.ComTypes.ITypeInfo
                typeinfo)
                {
                    var return_v = GetTypeAttr(typeinfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 3222, 3244);
                    return return_v;
                }


                System.Runtime.InteropServices.ComTypes.FUNCDESC
                f_1381_3470_3495(System.Runtime.InteropServices.ComTypes.ITypeInfo
                typeinfo, int
                index)
                {
                    var return_v = GetFuncDesc(typeinfo, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 3470, 3495);
                    return return_v;
                }


                string
                f_1381_4451_4499(System.Runtime.InteropServices.ComTypes.ITypeInfo
                typeinfo, System.Runtime.InteropServices.ComTypes.FUNCDESC
                funcdesc)
                {
                    var return_v = ComUtil.GetNameFromFuncDesc(typeinfo, funcdesc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 4451, 4499);
                    return return_v;
                }


                int
                f_1381_4800_4833(System.Management.Automation.ComTypeInfo
                this_param, string
                strName, System.Runtime.InteropServices.ComTypes.FUNCDESC
                funcdesc, int
                index)
                {
                    this_param.AddProperty(strName, funcdesc, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 4800, 4833);
                    return 0;
                }


                int
                f_1381_4960_4981(System.Management.Automation.ComTypeInfo
                this_param, string
                strName, int
                index)
                {
                    this_param.AddMethod(strName, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 4960, 4981);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1381, 3093, 5086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1381, 3093, 5086);
            }
        }

        [SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", Justification = "Code uses the out parameter of 'GetTypeInfo' to check if the call succeeded.")]
        internal static ComTypeInfo GetDispatchTypeInfo(object comObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1381, 5434, 6854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 5701, 5727);

                ComTypeInfo
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 5741, 5781);

                IDispatch
                disp = comObject as IDispatch
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 5795, 6813) || true) && (disp != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1381, 5795, 6813);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 5845, 5875);

                    COM.ITypeInfo
                    typeinfo = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 5893, 5930);

                    f_1381_5893_5929(disp, 0, 0, out typeinfo);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 5948, 6798) || true) && (typeinfo != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1381, 5948, 6798);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 6010, 6056);

                        COM.TYPEATTR
                        typeattr = f_1381_6034_6055(typeinfo)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 6080, 6380) || true) && ((typeattr.typekind == COM.TYPEKIND.TKIND_INTERFACE))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1381, 6080, 6380);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 6289, 6357);

                            typeinfo = f_1381_6300_6356(typeinfo);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1381, 6080, 6380);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 6404, 6720) || true) && ((typeattr.typekind == COM.TYPEKIND.TKIND_COCLASS))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1381, 6404, 6720);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 6637, 6697);

                            typeinfo = f_1381_6648_6696(typeinfo);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1381, 6404, 6720);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 6744, 6779);

                        result = f_1381_6753_6778(typeinfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1381, 5948, 6798);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1381, 5795, 6813);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 6829, 6843);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1381, 5434, 6854);

                int
                f_1381_5893_5929(System.Management.Automation.IDispatch
                this_param, int
                iTInfo, int
                lcid, out System.Runtime.InteropServices.ComTypes.ITypeInfo
                ppTInfo)
                {
                    var return_v = this_param.GetTypeInfo(iTInfo, lcid, out ppTInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 5893, 5929);
                    return return_v;
                }


                System.Runtime.InteropServices.ComTypes.TYPEATTR
                f_1381_6034_6055(System.Runtime.InteropServices.ComTypes.ITypeInfo
                typeinfo)
                {
                    var return_v = GetTypeAttr(typeinfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 6034, 6055);
                    return return_v;
                }


                System.Runtime.InteropServices.ComTypes.ITypeInfo
                f_1381_6300_6356(System.Runtime.InteropServices.ComTypes.ITypeInfo
                typeinfo)
                {
                    var return_v = GetDispatchTypeInfoFromCustomInterfaceTypeInfo(typeinfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 6300, 6356);
                    return return_v;
                }


                System.Runtime.InteropServices.ComTypes.ITypeInfo
                f_1381_6648_6696(System.Runtime.InteropServices.ComTypes.ITypeInfo
                typeinfo)
                {
                    var return_v = GetDispatchTypeInfoFromCoClassTypeInfo(typeinfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 6648, 6696);
                    return return_v;
                }


                System.Management.Automation.ComTypeInfo
                f_1381_6753_6778(System.Runtime.InteropServices.ComTypes.ITypeInfo
                info)
                {
                    var return_v = new System.Management.Automation.ComTypeInfo(info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 6753, 6778);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1381, 5434, 6854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1381, 5434, 6854);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddProperty(string strName, COM.FUNCDESC funcdesc, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1381, 6866, 7310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 6965, 6982);

                ComProperty
                prop
                = default(ComProperty);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 6996, 7181) || true) && (!f_1381_7001_7043(_properties, strName, out prop))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1381, 6996, 7181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 7077, 7120);

                    prop = f_1381_7084_7119(_typeinfo, strName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 7138, 7166);

                    _properties[strName] = prop;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1381, 6996, 7181);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 7197, 7299) || true) && (prop != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1381, 7197, 7299);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 7247, 7284);

                    f_1381_7247_7283(prop, funcdesc, index);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1381, 7197, 7299);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1381, 6866, 7310);

                bool
                f_1381_7001_7043(System.Collections.Generic.Dictionary<string, System.Management.Automation.ComProperty>
                this_param, string
                key, out System.Management.Automation.ComProperty
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 7001, 7043);
                    return return_v;
                }


                System.Management.Automation.ComProperty
                f_1381_7084_7119(System.Runtime.InteropServices.ComTypes.ITypeInfo
                typeinfo, string
                name)
                {
                    var return_v = new System.Management.Automation.ComProperty(typeinfo, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 7084, 7119);
                    return return_v;
                }


                int
                f_1381_7247_7283(System.Management.Automation.ComProperty
                this_param, System.Runtime.InteropServices.ComTypes.FUNCDESC
                desc, int
                index)
                {
                    this_param.UpdateFuncDesc(desc, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 7247, 7283);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1381, 6866, 7310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1381, 6866, 7310);
            }
        }

        private void AddMethod(string strName, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1381, 7322, 7730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 7396, 7413);

                ComMethod
                method
                = default(ComMethod);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 7427, 7610) || true) && (!f_1381_7432_7473(_methods, strName, out method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1381, 7427, 7610);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 7507, 7550);

                    method = f_1381_7516_7549(_typeinfo, strName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 7568, 7595);

                    _methods[strName] = method;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1381, 7427, 7610);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 7626, 7719) || true) && (method != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1381, 7626, 7719);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 7678, 7704);

                    f_1381_7678_7703(method, index);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1381, 7626, 7719);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1381, 7322, 7730);

                bool
                f_1381_7432_7473(System.Collections.Generic.Dictionary<string, System.Management.Automation.ComMethod>
                this_param, string
                key, out System.Management.Automation.ComMethod
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 7432, 7473);
                    return return_v;
                }


                System.Management.Automation.ComMethod
                f_1381_7516_7549(System.Runtime.InteropServices.ComTypes.ITypeInfo
                typeinfo, string
                name)
                {
                    var return_v = new System.Management.Automation.ComMethod(typeinfo, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 7516, 7549);
                    return return_v;
                }


                int
                f_1381_7678_7703(System.Management.Automation.ComMethod
                this_param, int
                index)
                {
                    this_param.AddFuncDesc(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 7678, 7703);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1381, 7322, 7730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1381, 7322, 7730);
            }
        }

        [ArchitectureSensitive]
        internal static COM.TYPEATTR GetTypeAttr(COM.ITypeInfo typeinfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1381, 7975, 8341);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 8097, 8114);

                IntPtr
                pTypeAttr
                = default(IntPtr);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 8128, 8164);

                f_1381_8128_8163(typeinfo, out pTypeAttr);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 8178, 8250);

                COM.TYPEATTR
                typeattr = f_1381_8202_8249(pTypeAttr)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 8264, 8300);

                f_1381_8264_8299(typeinfo, pTypeAttr);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 8314, 8330);

                return typeattr;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1381, 7975, 8341);

                int
                f_1381_8128_8163(System.Runtime.InteropServices.ComTypes.ITypeInfo
                this_param, out System.IntPtr
                ppTypeAttr)
                {
                    this_param.GetTypeAttr(out ppTypeAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 8128, 8163);
                    return 0;
                }


                System.Runtime.InteropServices.ComTypes.TYPEATTR
                f_1381_8202_8249(System.IntPtr
                ptr)
                {
                    var return_v = Marshal.PtrToStructure<COM.TYPEATTR>(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 8202, 8249);
                    return return_v;
                }


                int
                f_1381_8264_8299(System.Runtime.InteropServices.ComTypes.ITypeInfo
                this_param, System.IntPtr
                pTypeAttr)
                {
                    this_param.ReleaseTypeAttr(pTypeAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 8264, 8299);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1381, 7975, 8341);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1381, 7975, 8341);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [ArchitectureSensitive]
        internal static COM.FUNCDESC GetFuncDesc(COM.ITypeInfo typeinfo, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1381, 8520, 8904);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 8653, 8670);

                IntPtr
                pFuncDesc
                = default(IntPtr);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 8684, 8727);

                f_1381_8684_8726(typeinfo, index, out pFuncDesc);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 8741, 8813);

                COM.FUNCDESC
                funcdesc = f_1381_8765_8812(pFuncDesc)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 8827, 8863);

                f_1381_8827_8862(typeinfo, pFuncDesc);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 8877, 8893);

                return funcdesc;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1381, 8520, 8904);

                int
                f_1381_8684_8726(System.Runtime.InteropServices.ComTypes.ITypeInfo
                this_param, int
                index, out System.IntPtr
                ppFuncDesc)
                {
                    this_param.GetFuncDesc(index, out ppFuncDesc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 8684, 8726);
                    return 0;
                }


                System.Runtime.InteropServices.ComTypes.FUNCDESC
                f_1381_8765_8812(System.IntPtr
                ptr)
                {
                    var return_v = Marshal.PtrToStructure<COM.FUNCDESC>(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 8765, 8812);
                    return return_v;
                }


                int
                f_1381_8827_8862(System.Runtime.InteropServices.ComTypes.ITypeInfo
                this_param, System.IntPtr
                pFuncDesc)
                {
                    this_param.ReleaseFuncDesc(pFuncDesc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 8827, 8862);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1381, 8520, 8904);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1381, 8520, 8904);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static COM.ITypeInfo GetDispatchTypeInfoFromCustomInterfaceTypeInfo(COM.ITypeInfo typeinfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1381, 9041, 9915);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 9166, 9175);

                int
                href
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 9189, 9219);

                COM.ITypeInfo
                dispinfo = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 9335, 9379);

                    f_1381_9335_9378(                // We need the typeinfo for Dispatch Interface
                                    typeinfo, -1, out href);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 9397, 9441);

                    f_1381_9397_9440(typeinfo, href, out dispinfo);
                }
                catch (COMException ce)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1381, 9470, 9872);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 9678, 9857) || true) && (f_1381_9682_9692(ce) != ComUtil.TYPE_E_ELEMENTNOTFOUND)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1381, 9678, 9857);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 9832, 9838);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1381, 9678, 9857);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1381, 9470, 9872);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 9888, 9904);

                return dispinfo;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1381, 9041, 9915);

                int
                f_1381_9335_9378(System.Runtime.InteropServices.ComTypes.ITypeInfo
                this_param, int
                index, out int
                href)
                {
                    this_param.GetRefTypeOfImplType(index, out href);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 9335, 9378);
                    return 0;
                }


                int
                f_1381_9397_9440(System.Runtime.InteropServices.ComTypes.ITypeInfo
                this_param, int
                hRef, out System.Runtime.InteropServices.ComTypes.ITypeInfo
                ppTI)
                {
                    this_param.GetRefTypeInfo(hRef, out ppTI);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 9397, 9440);
                    return 0;
                }


                int
                f_1381_9682_9692(System.Runtime.InteropServices.COMException
                this_param)
                {
                    var return_v = this_param.HResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1381, 9682, 9692);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1381, 9041, 9915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1381, 9041, 9915);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static COM.ITypeInfo GetDispatchTypeInfoFromCoClassTypeInfo(COM.ITypeInfo typeinfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1381, 10225, 11714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 10416, 10462);

                COM.TYPEATTR
                typeattr = f_1381_10440_10461(typeinfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 10476, 10508);

                int
                count = typeattr.cImplTypes
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 10522, 10531);

                int
                href
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 10545, 10580);

                COM.ITypeInfo
                interfaceinfo = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 10668, 10673);

                    // For each interface implemented by this coclass
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 10659, 11675) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 10686, 10689)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1381, 10659, 11675))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1381, 10659, 11675);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 10769, 10812);

                        f_1381_10769_10811(                // Get the type information?
                                        typeinfo, i, out href);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 10830, 10879);

                        f_1381_10830_10878(typeinfo, href, out interfaceinfo);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 10897, 10935);

                        typeattr = f_1381_10908_10934(interfaceinfo);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 11025, 11159) || true) && (typeattr.typekind == COM.TYPEKIND.TKIND_DISPATCH)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1381, 11025, 11159);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 11119, 11140);

                            return interfaceinfo;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1381, 11025, 11159);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 11230, 11660) || true) && ((typeattr.wTypeFlags & COM.TYPEFLAGS.TYPEFLAG_FDUAL) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1381, 11230, 11660);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 11333, 11411);

                            interfaceinfo = f_1381_11349_11410(interfaceinfo);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 11433, 11471);

                            typeattr = f_1381_11444_11470(interfaceinfo);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 11495, 11641) || true) && (typeattr.typekind == COM.TYPEKIND.TKIND_DISPATCH)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1381, 11495, 11641);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 11597, 11618);

                                return interfaceinfo;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1381, 11495, 11641);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1381, 11230, 11660);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1381, 1, 1017);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1381, 1, 1017);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 11691, 11703);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1381, 10225, 11714);

                System.Runtime.InteropServices.ComTypes.TYPEATTR
                f_1381_10440_10461(System.Runtime.InteropServices.ComTypes.ITypeInfo
                typeinfo)
                {
                    var return_v = GetTypeAttr(typeinfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 10440, 10461);
                    return return_v;
                }


                int
                f_1381_10769_10811(System.Runtime.InteropServices.ComTypes.ITypeInfo
                this_param, int
                index, out int
                href)
                {
                    this_param.GetRefTypeOfImplType(index, out href);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 10769, 10811);
                    return 0;
                }


                int
                f_1381_10830_10878(System.Runtime.InteropServices.ComTypes.ITypeInfo
                this_param, int
                hRef, out System.Runtime.InteropServices.ComTypes.ITypeInfo
                ppTI)
                {
                    this_param.GetRefTypeInfo(hRef, out ppTI);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 10830, 10878);
                    return 0;
                }


                System.Runtime.InteropServices.ComTypes.TYPEATTR
                f_1381_10908_10934(System.Runtime.InteropServices.ComTypes.ITypeInfo
                typeinfo)
                {
                    var return_v = GetTypeAttr(typeinfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 10908, 10934);
                    return return_v;
                }


                System.Runtime.InteropServices.ComTypes.ITypeInfo
                f_1381_11349_11410(System.Runtime.InteropServices.ComTypes.ITypeInfo
                typeinfo)
                {
                    var return_v = GetDispatchTypeInfoFromCustomInterfaceTypeInfo(typeinfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 11349, 11410);
                    return return_v;
                }


                System.Runtime.InteropServices.ComTypes.TYPEATTR
                f_1381_11444_11470(System.Runtime.InteropServices.ComTypes.ITypeInfo
                typeinfo)
                {
                    var return_v = GetTypeAttr(typeinfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 11444, 11470);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1381, 10225, 11714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1381, 10225, 11714);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ComTypeInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1381, 464, 11721);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 796, 815);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1381, 1073, 1097);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1381, 464, 11721);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1381, 464, 11721);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1381, 464, 11721);

        System.StringComparer
        f_1381_1720_1752()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1381, 1720, 1752);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, System.Management.Automation.ComProperty>
        f_1381_1684_1753(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.ComProperty>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 1684, 1753);
            return return_v;
        }


        System.StringComparer
        f_1381_1813_1845()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1381, 1813, 1845);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, System.Management.Automation.ComMethod>
        f_1381_1779_1846(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.ComMethod>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 1779, 1846);
            return return_v;
        }


        int
        f_1381_1918_1930(System.Management.Automation.ComTypeInfo
        this_param)
        {
            this_param.Initialize();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1381, 1918, 1930);
            return 0;
        }

    }
}

