// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace System.Management.Automation
{
    internal class ParameterSetPromptingData
    {
        internal ParameterSetPromptingData(uint parameterSet, bool isDefaultSet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1308, 478, 656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1308, 793, 828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1308, 940, 980);
                this.ParameterSet = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1308, 1388, 1601);
                this.PipelineableMandatoryParameters = f_1308_1522_1600();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1308, 1769, 1989);
                this.PipelineableMandatoryByValueParameters = f_1308_1910_1988();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1308, 2165, 2392);
                this.PipelineableMandatoryByPropertyNameParameters = f_1308_2313_2391();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1308, 2557, 2773);
                this.NonpipelineableMandatoryParameters = f_1308_2694_2772();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1308, 575, 603);

                ParameterSet = parameterSet;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1308, 617, 645);

                IsDefaultSet = isDefaultSet;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1308, 478, 656);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1308, 478, 656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1308, 478, 656);
            }
        }

        internal bool IsDefaultSet { get; }

        internal uint ParameterSet { get; }

        internal bool IsAllSet
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1308, 1174, 1219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1308, 1180, 1217);

                    return f_1308_1187_1199() == uint.MaxValue;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1308, 1174, 1219);

                    uint
                    f_1308_1187_1199()
                    {
                        var return_v = ParameterSet;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1308, 1187, 1199);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1308, 1127, 1230);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1308, 1127, 1230);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Dictionary<MergedCompiledCommandParameter, ParameterSetSpecificMetadata> PipelineableMandatoryParameters
        { get; }

        internal Dictionary<MergedCompiledCommandParameter, ParameterSetSpecificMetadata> PipelineableMandatoryByValueParameters
        { get; }

        internal Dictionary<MergedCompiledCommandParameter, ParameterSetSpecificMetadata> PipelineableMandatoryByPropertyNameParameters
        { get; }

        internal Dictionary<MergedCompiledCommandParameter, ParameterSetSpecificMetadata> NonpipelineableMandatoryParameters
        { get; }

        static ParameterSetPromptingData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1308, 421, 2780);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1308, 421, 2780);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1308, 421, 2780);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1308, 421, 2780);

        System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
        f_1308_1522_1600()
        {
            var return_v = new System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1308, 1522, 1600);
            return return_v;
        }


        System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
        f_1308_1910_1988()
        {
            var return_v = new System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1308, 1910, 1988);
            return return_v;
        }


        System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
        f_1308_2313_2391()
        {
            var return_v = new System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1308, 2313, 2391);
            return return_v;
        }


        System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
        f_1308_2694_2772()
        {
            var return_v = new System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1308, 2694, 2772);
            return return_v;
        }

    }
}

