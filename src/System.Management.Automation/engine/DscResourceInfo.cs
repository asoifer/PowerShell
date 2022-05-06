// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Management.Automation
{
    /// <summary>
    /// Enumerated values for DSC resource implementation type.
    /// </summary>
    public enum ImplementedAsType
    {
        /// <summary>
        /// DSC resource implementation type not known.
        /// </summary>
        None = 0,

        /// <summary>
        /// DSC resource is implemented using PowerShell module.
        /// </summary>
        PowerShell = 1,

        /// <summary>
        /// DSC resource is implemented using a CIM provider.
        /// </summary>
        Binary = 2,

        /// <summary>
        /// DSC resource is a composite and implemented using configuration keyword.
        /// </summary>
        Composite = 3
    }
    public class DscResourceInfo
    {
        internal DscResourceInfo(string name, string friendlyName, string path, string parentPath, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1266, 1553, 1960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1266, 2058, 2098);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1266, 2203, 2243);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1266, 2368, 2408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1266, 2791, 2823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1266, 3158, 3196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1266, 3337, 3389);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1266, 3508, 3547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1266, 3660, 3743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1266, 4266, 4315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1266, 4427, 4488);
                this.HelpFile = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1266, 1694, 1711);

                this.Name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1266, 1725, 1758);

                this.FriendlyName = friendlyName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1266, 1772, 1789);

                this.Path = path;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1266, 1803, 1832);

                this.ParentPath = parentPath;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1266, 1846, 1949);

                this.Properties = f_1266_1864_1948(f_1266_1912_1947());
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1266, 1553, 1960);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1266, 1553, 1960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1266, 1553, 1960);
            }
        }

        public string Name { get; private set; }

        public string ResourceType { get; set; }

        public string FriendlyName { get; set; }

        public string Path { get; set; }

        public string ParentPath { get; set; }

        public ImplementedAsType ImplementedAs { get; set; }

        public string CompanyName { get; set; }

        public ReadOnlyCollection<DscResourcePropertyInfo> Properties { get; private set; }

        public void UpdateProperties(IList<DscResourcePropertyInfo> properties)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1266, 3917, 4143);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1266, 4013, 4132) || true) && (properties != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1266, 4013, 4132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1266, 4054, 4132);

                    this.Properties = f_1266_4072_4131(properties);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1266, 4013, 4132);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1266, 3917, 4143);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.DscResourcePropertyInfo>
                f_1266_4072_4131(System.Collections.Generic.IList<System.Management.Automation.DscResourcePropertyInfo>
                list)
                {
                    var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.DscResourcePropertyInfo>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1266, 4072, 4131);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1266, 3917, 4143);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1266, 3917, 4143);
            }
        }

        public PSModuleInfo Module { get; internal set; }

        public string HelpFile { get; internal set; }

        static DscResourceInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1266, 1017, 4518);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1266, 1017, 4518);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1266, 1017, 4518);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1266, 1017, 4518);

        System.Collections.Generic.List<System.Management.Automation.DscResourcePropertyInfo>
        f_1266_1912_1947()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.DscResourcePropertyInfo>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1266, 1912, 1947);
            return return_v;
        }


        System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.DscResourcePropertyInfo>
        f_1266_1864_1948(System.Collections.Generic.List<System.Management.Automation.DscResourcePropertyInfo>
        list)
        {
            var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.DscResourcePropertyInfo>((System.Collections.Generic.IList<System.Management.Automation.DscResourcePropertyInfo>)list);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1266, 1864, 1948);
            return return_v;
        }

    }
    public sealed class DscResourcePropertyInfo
    {
        internal DscResourcePropertyInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1266, 4805, 4940);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1266, 5047, 5079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1266, 5186, 5226);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1266, 5372, 5409);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1266, 5518, 5580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1266, 4864, 4929);

                this.Values = f_1266_4878_4928(f_1266_4909_4927());
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1266, 4805, 4940);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1266, 4805, 4940);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1266, 4805, 4940);
            }
        }

        public string Name { get; set; }

        public string PropertyType { get; set; }

        public bool IsMandatory { get; set; }

        public ReadOnlyCollection<string> Values { get; private set; }

        internal void UpdateValues(IList<string> values)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1266, 5592, 5766);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1266, 5665, 5755) || true) && (values != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1266, 5665, 5755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1266, 5702, 5755);

                    this.Values = f_1266_5716_5754(values);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1266, 5665, 5755);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1266, 5592, 5766);

                System.Collections.ObjectModel.ReadOnlyCollection<string>
                f_1266_5716_5754(System.Collections.Generic.IList<string>
                list)
                {
                    var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<string>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1266, 5716, 5754);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1266, 5592, 5766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1266, 5592, 5766);
            }
        }

        static DscResourcePropertyInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1266, 4620, 5773);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1266, 4620, 5773);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1266, 4620, 5773);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1266, 4620, 5773);

        System.Collections.Generic.List<string>
        f_1266_4909_4927()
        {
            var return_v = new System.Collections.Generic.List<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1266, 4909, 4927);
            return return_v;
        }


        System.Collections.ObjectModel.ReadOnlyCollection<string>
        f_1266_4878_4928(System.Collections.Generic.List<string>
        list)
        {
            var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<string>((System.Collections.Generic.IList<string>)list);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1266, 4878, 4928);
            return return_v;
        }

    }
}
