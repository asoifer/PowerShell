// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed partial class TypeInfoDataBase
    { }
    internal sealed partial class AppliesTo
    {
        internal void AddAppliesToType(string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1119, 639, 837);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1119, 711, 750);

                TypeReference
                tr = f_1119_730_749()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1119, 766, 785);

                tr.name = typeName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1119, 799, 826);

                f_1119_799_825(this.referenceList, tr);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1119, 639, 837);

                Microsoft.PowerShell.Commands.Internal.Format.TypeReference
                f_1119_730_749()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1119, 730, 749);
                    return return_v;
                }


                int
                f_1119_799_825(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeReference
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.TypeOrGroupReference)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1119, 799, 825);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1119, 639, 837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1119, 639, 837);
            }
        }
    }

}
