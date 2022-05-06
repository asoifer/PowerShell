// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Management.Automation
{
    public sealed class PSClassInfo
    {
        internal PSClassInfo(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1321, 527, 613);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1321, 704, 744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1321, 852, 926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1321, 1404, 1453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1321, 1565, 1626);
                this.HelpFile = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1321, 585, 602);

                this.Name = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1321, 527, 613);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1321, 527, 613);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1321, 527, 613);
            }
        }

        public string Name { get; private set; }

        public ReadOnlyCollection<PSClassMemberInfo> Members { get; private set; }

        public void UpdateMembers(IList<PSClassMemberInfo> members)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1321, 1088, 1287);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1321, 1172, 1276) || true) && (members != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1321, 1172, 1276);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1321, 1210, 1276);

                    this.Members = f_1321_1225_1275(members);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1321, 1172, 1276);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1321, 1088, 1287);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSClassMemberInfo>
                f_1321_1225_1275(System.Collections.Generic.IList<System.Management.Automation.PSClassMemberInfo>
                list)
                {
                    var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSClassMemberInfo>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1321, 1225, 1275);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1321, 1088, 1287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1321, 1088, 1287);
            }
        }

        public PSModuleInfo Module { get; internal set; }

        public string HelpFile { get; internal set; }

        static PSClassInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1321, 304, 1633);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1321, 304, 1633);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1321, 304, 1633);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1321, 304, 1633);
    }
    public sealed class PSClassMemberInfo
    {
        internal PSClassMemberInfo(string name, string memberType, string defaultValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1321, 1898, 2223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1321, 2328, 2368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1321, 2473, 2517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1321, 2617, 2665);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1321, 2002, 2091) || true) && (f_1321_2006_2032(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1321, 2002, 2091);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1321, 2051, 2091);

                    throw f_1321_2057_2090("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1321, 2002, 2091);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1321, 2107, 2124);

                this.Name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1321, 2138, 2165);

                this.TypeName = memberType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1321, 2179, 2212);

                this.DefaultValue = defaultValue;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1321, 1898, 2223);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1321, 1898, 2223);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1321, 1898, 2223);
            }
        }

        public string Name { get; private set; }

        public string TypeName { get; private set; }

        public string DefaultValue { get; private set; }

        static PSClassMemberInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1321, 1725, 2672);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1321, 1725, 2672);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1321, 1725, 2672);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1321, 1725, 2672);

        bool
        f_1321_2006_2032(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1321, 2006, 2032);
            return return_v;
        }


        System.ArgumentNullException
        f_1321_2057_2090(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1321, 2057, 2090);
            return return_v;
        }

    }
}
