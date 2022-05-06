// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// This file contains the definitions for the objects
// used in the communication protocol between formatting
// and output commands. the format/xxx commands instantiate
// these objects and write them to the pipeline. The out-xxx
// commands read them from the pipeline.
//
// NOTE:
// Since format/xxx and out-xxx commands can be separated by
// serialization boundaries, the structure of these objects
// must adhere to the Monad serialization constraints.
//
// Since the out-xxx commands heavily access these objects and
// there is an up front need for protocol validation, the out-xxx
// commands do deserialize the objects back from the property bag
// representation that mig have been introduced by serialization.
//
// There is also the need to preserve type information across serialization
// boundaries, therefore the objects provide a GUID based machanism to
// preserve the information.
//

using System.Collections.Generic;
using System.Management.Automation;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal abstract partial class FormatInfoData
    {
        internal const string
        classidProperty = "ClassId2e4f51ef21dd47e99d3c952918aff9cd"
        ;

        public abstract string ClassId2e4f51ef21dd47e99d3c952918aff9cd { get; }

        public FormatInfoData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 1393, 2100);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 1393, 2100);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 1393, 2100);
        }


        static FormatInfoData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 1393, 2100);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 1652, 1711);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 1393, 2100);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 1393, 2100);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 1393, 2100);
    }
    internal abstract class PacketInfoData : FormatInfoData
    {
        public PacketInfoData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 2160, 2229);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 2160, 2229);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 2160, 2229);
        }


        static PacketInfoData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 2160, 2229);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 2160, 2229);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 2160, 2229);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 2160, 2229);
    }
    internal abstract partial class ControlInfoData : PacketInfoData
    {
        public GroupingEntry groupingEntry;

        public ControlInfoData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 2237, 2480);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 2452, 2472);
            this.groupingEntry = null;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 2237, 2480);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 2237, 2480);
        }


        static ControlInfoData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 2237, 2480);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 2237, 2480);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 2237, 2480);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 2237, 2480);
    }
    internal abstract partial class StartData : ControlInfoData
    {
        public ShapeInfo shapeInfo;

        public StartData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 2488, 2755);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 2738, 2747);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 2488, 2755);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 2488, 2755);
        }


        static StartData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 2488, 2755);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 2488, 2755);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 2488, 2755);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 2488, 2755);
    }
    internal sealed partial class FormatStartData : StartData
    {
        internal const string
        CLSID = "033ecb2bc07a4d43b5ef94ed5a35d280"
        ;

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 3072, 3093);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 3078, 3091);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 3072, 3093);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 3007, 3095);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 3007, 3095);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PageHeaderEntry pageHeaderEntry;

        public PageFooterEntry pageFooterEntry;

        public AutosizeInfo autosizeInfo;

        public FormatStartData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 2856, 3649);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 3200, 3215);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 3321, 3336);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 3629, 3641);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 2856, 3649);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 2856, 3649);
        }


        static FormatStartData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 2856, 3649);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 2952, 2994);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 2856, 3649);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 2856, 3649);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 2856, 3649);
    }
    internal sealed class FormatEndData : ControlInfoData
    {
        internal const string
        CLSID = "cf522b78d86c486691226b40aa69e95c"
        ;

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 3959, 3980);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 3965, 3978);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 3959, 3980);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 3894, 3982);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 3894, 3982);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public FormatEndData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 3747, 3989);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 3747, 3989);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 3747, 3989);
        }


        static FormatEndData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 3747, 3989);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 3839, 3881);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 3747, 3989);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 3747, 3989);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 3747, 3989);
    }
    internal sealed class GroupStartData : StartData
    {
        internal const string
        CLSID = "9e210fe47d09416682b841769c78b8a3"
        ;

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 4307, 4328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 4313, 4326);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 4307, 4328);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 4242, 4330);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 4242, 4330);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public GroupStartData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 4100, 4337);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 4100, 4337);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 4100, 4337);
        }


        static GroupStartData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 4100, 4337);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 4187, 4229);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 4100, 4337);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 4100, 4337);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 4100, 4337);
    }
    internal sealed class GroupEndData : ControlInfoData
    {
        internal const string
        CLSID = "4ec4f0187cb04f4cb6973460dfe252df"
        ;

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 4651, 4672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 4657, 4670);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 4651, 4672);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 4586, 4674);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 4586, 4674);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public GroupEndData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 4440, 4681);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 4440, 4681);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 4440, 4681);
        }


        static GroupEndData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 4440, 4681);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 4531, 4573);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 4440, 4681);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 4440, 4681);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 4440, 4681);
    }
    internal sealed partial class FormatEntryData : PacketInfoData
    {
        internal const string
        CLSID = "27c87ef9bbda4f709f6b4002fa4af63c"
        ;

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 5025, 5046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 5031, 5044);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 5025, 5046);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 4960, 5048);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 4960, 5048);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public FormatEntryInfo formatEntryInfo;

        public bool outOfBand;

        public WriteStreamType writeStream;

        internal bool isHelpObject;

        public FormatEntryData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 4804, 5447);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 5262, 5284);
            this.formatEntryInfo = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 5309, 5326);
            this.outOfBand = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 5360, 5394);
            this.writeStream = WriteStreamType.None;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 5419, 5439);
            this.isHelpObject = false;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 4804, 5447);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 4804, 5447);
        }


        static FormatEntryData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 4804, 5447);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 4905, 4947);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 4804, 5447);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 4804, 5447);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 4804, 5447);
    }
    internal abstract class ShapeInfo : FormatInfoData
    {
        public ShapeInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 5505, 5569);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 5505, 5569);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 5505, 5569);
        }


        static ShapeInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 5505, 5569);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 5505, 5569);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 5505, 5569);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 5505, 5569);
    }
    internal sealed partial class WideViewHeaderInfo : ShapeInfo
    {
        internal const string
        CLSID = "b2e2775d33d544c794d0081f27021b5c"
        ;

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 5796, 5817);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 5802, 5815);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 5796, 5817);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 5731, 5819);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 5731, 5819);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int columns;

        public WideViewHeaderInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 5577, 6165);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 6146, 6157);
            this.columns = 0;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 5577, 6165);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 5577, 6165);
        }


        static WideViewHeaderInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 5577, 6165);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 5676, 5718);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 5577, 6165);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 5577, 6165);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 5577, 6165);
    }
    internal sealed partial class TableHeaderInfo : ShapeInfo
    {
        internal const string
        CLSID = "e3b7a39c089845d388b2e84c5d38f5dd"
        ;

        public TableHeaderInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 6324, 6434);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 6558, 6568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 6591, 6603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 6643, 6662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 6373, 6423);

                tableColumnInfoList = f_1088_6395_6422();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 6324, 6434);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 6324, 6434);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 6324, 6434);
            }
        }

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 6511, 6532);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 6517, 6530);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 6511, 6532);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 6446, 6534);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 6446, 6534);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool hideHeader;

        public bool repeatHeader;

        public List<TableColumnInfo> tableColumnInfoList;

        static TableHeaderInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 6173, 6670);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 6269, 6311);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 6173, 6670);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 6173, 6670);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 6173, 6670);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo>
        f_1088_6395_6422()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1088, 6395, 6422);
            return return_v;
        }

    }
    internal sealed partial class TableColumnInfo : FormatInfoData
    {
        internal const string
        CLSID = "7572aa4155ec4558817a615acf7dd92e"
        ;

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 6899, 6920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 6905, 6918);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 6899, 6920);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 6834, 6922);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 6834, 6922);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int width;

        public int alignment;

        public string label;

        public string propertyName;

        public TableColumnInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 6678, 7265);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 7113, 7122);
            this.width = 0;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 7146, 7176);
            this.alignment = TextAlignment.Left;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 7201, 7213);
            this.label = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 7238, 7257);
            this.propertyName = null;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 6678, 7265);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 6678, 7265);
        }


        static TableColumnInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 6678, 7265);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 6779, 6821);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 6678, 7265);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 6678, 7265);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 6678, 7265);
    }
    internal sealed class ListViewHeaderInfo : ShapeInfo
    {
        internal const string
        CLSID = "830bdcb24c1642258724e441512233a4"
        ;

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 7484, 7505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 7490, 7503);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 7484, 7505);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 7419, 7507);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 7419, 7507);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ListViewHeaderInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 7273, 7514);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 7273, 7514);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 7273, 7514);
        }


        static ListViewHeaderInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 7273, 7514);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 7364, 7406);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 7273, 7514);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 7273, 7514);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 7273, 7514);
    }
    internal sealed class ComplexViewHeaderInfo : ShapeInfo
    {
        internal const string
        CLSID = "5197dd85ca6f4cce9ae9e6fd6ded9d76"
        ;

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 7736, 7757);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 7742, 7755);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 7736, 7757);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 7671, 7759);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 7671, 7759);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ComplexViewHeaderInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 7522, 7766);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 7522, 7766);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 7522, 7766);
        }


        static ComplexViewHeaderInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 7522, 7766);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 7616, 7658);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 7522, 7766);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 7522, 7766);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 7522, 7766);
    }
    internal abstract class FormatEntryInfo : FormatInfoData
    {
        public FormatEntryInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 7834, 7904);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 7834, 7904);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 7834, 7904);
        }


        static FormatEntryInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 7834, 7904);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 7834, 7904);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 7834, 7904);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 7834, 7904);
    }
    internal sealed partial class RawTextFormatEntry : FormatEntryInfo
    {
        internal const string
        CLSID = "29ED81BA914544d4BC430F027EE053E9"
        ;

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 8137, 8158);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 8143, 8156);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 8137, 8158);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 8072, 8160);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 8072, 8160);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string text;

        public RawTextFormatEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 7912, 8205);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 8186, 8197);
            this.text = null;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 7912, 8205);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 7912, 8205);
        }


        static RawTextFormatEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 7912, 8205);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 8017, 8059);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 7912, 8205);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 7912, 8205);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 7912, 8205);
    }
    internal abstract partial class FreeFormatEntry : FormatEntryInfo
    {
        public List<FormatValue> formatValueList;

        public FreeFormatEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 8213, 8369);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 8320, 8361);
            this.formatValueList = f_1088_8338_8361();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 8213, 8369);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 8213, 8369);
        }


        static FreeFormatEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 8213, 8369);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 8213, 8369);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 8213, 8369);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 8213, 8369);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
        f_1088_8338_8361()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1088, 8338, 8361);
            return return_v;
        }

    }
    internal sealed partial class ListViewEntry : FormatEntryInfo
    {
        internal const string
        CLSID = "cf58f450baa848ef8eb3504008be6978"
        ;

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 8597, 8618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 8603, 8616);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 8597, 8618);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 8532, 8620);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 8532, 8620);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public List<ListViewField> listViewFieldList;

        public ListViewEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 8377, 8712);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 8659, 8704);
            this.listViewFieldList = f_1088_8679_8704();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 8377, 8712);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 8377, 8712);
        }


        static ListViewEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 8377, 8712);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 8477, 8519);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 8377, 8712);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 8377, 8712);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 8377, 8712);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListViewField>
        f_1088_8679_8704()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListViewField>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1088, 8679, 8704);
            return return_v;
        }

    }
    internal sealed partial class ListViewField : FormatInfoData
    {
        internal const string
        CLSID = "b761477330ce4fb2a665999879324d73"
        ;

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 8939, 8960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 8945, 8958);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 8939, 8960);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 8874, 8962);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 8874, 8962);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string label;

        public string propertyName;

        public FormatPropertyField formatPropertyField;

        public ListViewField()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 8720, 9137);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 8988, 9000);
            this.label = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 9025, 9044);
            this.propertyName = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 9082, 9129);
            this.formatPropertyField = f_1088_9104_9129();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 8720, 9137);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 8720, 9137);
        }


        static ListViewField()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 8720, 9137);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 8819, 8861);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 8720, 9137);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 8720, 9137);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 8720, 9137);

        Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField
        f_1088_9104_9129()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1088, 9104, 9129);
            return return_v;
        }

    }
    internal sealed partial class TableRowEntry : FormatEntryInfo
    {
        internal const string
        CLSID = "0e59526e2dd441aa91e7fc952caf4a36"
        ;

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 9365, 9386);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 9371, 9384);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 9365, 9386);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 9300, 9388);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 9300, 9388);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public List<FormatPropertyField> formatPropertyFieldList;

        public bool multiLine;

        public TableRowEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 9145, 9538);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 9433, 9490);
            this.formatPropertyFieldList = f_1088_9459_9490();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 9513, 9530);
            this.multiLine = false;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 9145, 9538);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 9145, 9538);
        }


        static TableRowEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 9145, 9538);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 9245, 9287);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 9145, 9538);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 9145, 9538);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 9145, 9538);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField>
        f_1088_9459_9490()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1088, 9459, 9490);
            return return_v;
        }

    }
    internal sealed partial class WideViewEntry : FormatEntryInfo
    {
        internal const string
        CLSID = "59bf79de63354a7b9e4d1697940ff188"
        ;

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 9766, 9787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 9772, 9785);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 9766, 9787);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 9701, 9789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 9701, 9789);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public FormatPropertyField formatPropertyField;

        public WideViewEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 9546, 9883);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 9828, 9875);
            this.formatPropertyField = f_1088_9850_9875();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 9546, 9883);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 9546, 9883);
        }


        static WideViewEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 9546, 9883);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 9646, 9688);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 9546, 9883);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 9546, 9883);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 9546, 9883);

        Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField
        f_1088_9850_9875()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1088, 9850, 9875);
            return return_v;
        }

    }
    internal sealed class ComplexViewEntry : FreeFormatEntry
    {
        internal const string
        CLSID = "22e7ef3c896449d4a6f2dedea05dd737"
        ;

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 10106, 10127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 10112, 10125);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 10106, 10127);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 10041, 10129);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 10041, 10129);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ComplexViewEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 9891, 10136);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 9891, 10136);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 9891, 10136);
        }


        static ComplexViewEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 9891, 10136);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 9986, 10028);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 9891, 10136);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 9891, 10136);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 9891, 10136);
    }
    internal sealed class GroupingEntry : FreeFormatEntry
    {
        internal const string
        CLSID = "919820b7eadb48be8e202c5afa5c2716"
        ;

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 10356, 10377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 10362, 10375);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 10356, 10377);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 10291, 10379);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 10291, 10379);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public GroupingEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 10144, 10386);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 10144, 10386);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 10144, 10386);
        }


        static GroupingEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 10144, 10386);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 10236, 10278);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 10144, 10386);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 10144, 10386);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 10144, 10386);
    }
    internal sealed class PageHeaderEntry : FreeFormatEntry
    {
        internal const string
        CLSID = "dd1290a5950b4b27aa76d9f06199c3b3"
        ;

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 10608, 10629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 10614, 10627);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 10608, 10629);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 10543, 10631);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 10543, 10631);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PageHeaderEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 10394, 10638);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 10394, 10638);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 10394, 10638);
        }


        static PageHeaderEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 10394, 10638);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 10488, 10530);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 10394, 10638);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 10394, 10638);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 10394, 10638);
    }
    internal sealed class PageFooterEntry : FreeFormatEntry
    {
        internal const string
        CLSID = "93565e84730645c79d4af091123eecbc"
        ;

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 10860, 10881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 10866, 10879);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 10860, 10881);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 10795, 10883);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 10795, 10883);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PageFooterEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 10646, 10890);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 10646, 10890);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 10646, 10890);
        }


        static PageFooterEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 10646, 10890);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 10740, 10782);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 10646, 10890);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 10646, 10890);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 10646, 10890);
    }
    internal sealed partial class AutosizeInfo : FormatInfoData
    {
        internal const string
        CLSID = "a27f094f0eec4d64845801a4c06a32ae"
        ;

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 11116, 11137);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 11122, 11135);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 11116, 11137);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 11051, 11139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 11051, 11139);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int objectCount;

        public AutosizeInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 10898, 11374);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 11351, 11366);
            this.objectCount = 0;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 10898, 11374);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 10898, 11374);
        }


        static AutosizeInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 10898, 11374);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 10996, 11038);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 10898, 11374);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 10898, 11374);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 10898, 11374);
    }
    internal abstract class FormatValue : FormatInfoData
    {
        public FormatValue()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 11429, 11495);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 11429, 11495);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 11429, 11495);
        }


        static FormatValue()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 11429, 11495);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 11429, 11495);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 11429, 11495);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 11429, 11495);
    }
    internal sealed class FormatNewLine : FormatValue
    {
        internal const string
        CLSID = "de7e8b96fbd84db5a43aa82eb34580ec"
        ;

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 11711, 11732);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 11717, 11730);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 11711, 11732);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 11646, 11734);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 11646, 11734);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public FormatNewLine()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 11503, 11741);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 11503, 11741);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 11503, 11741);
        }


        static FormatNewLine()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 11503, 11741);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 11591, 11633);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 11503, 11741);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 11503, 11741);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 11503, 11741);
    }
    internal sealed partial class FormatTextField : FormatValue
    {
        internal const string
        CLSID = "b8d9e369024a43a580b9e0c9279e3354"
        ;

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 11967, 11988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 11973, 11986);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 11967, 11988);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 11902, 11990);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 11902, 11990);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string text;

        public FormatTextField()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 11749, 12028);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 12016, 12020);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 11749, 12028);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 11749, 12028);
        }


        static FormatTextField()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 11749, 12028);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 11847, 11889);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 11749, 12028);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 11749, 12028);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 11749, 12028);
    }
    internal sealed partial class FormatPropertyField : FormatValue
    {
        internal const string
        CLSID = "78b102e894f742aca8c1d6737b6ff86a"
        ;

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 12258, 12279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 12264, 12277);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 12258, 12279);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 12193, 12281);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 12193, 12281);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string propertyValue;

        public int alignment;

        public FormatPropertyField()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 12036, 12392);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 12307, 12327);
            this.propertyValue = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 12349, 12384);
            this.alignment = TextAlignment.Undefined;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 12036, 12392);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 12036, 12392);
        }


        static FormatPropertyField()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 12036, 12392);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 12138, 12180);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 12036, 12392);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 12036, 12392);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 12036, 12392);
    }
    internal sealed partial class FormatEntry : FormatValue
    {
        internal const string
        CLSID = "fba029a113a5458d932a2ed4871fadf2"
        ;

        public FormatEntry()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 12549, 12647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 12784, 12799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 12944, 12953);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 12594, 12636);

                formatValueList = f_1088_12612_12635();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 12549, 12647);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 12549, 12647);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 12549, 12647);
            }
        }

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 12724, 12745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 12730, 12743);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 12724, 12745);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 12659, 12747);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 12659, 12747);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public List<FormatValue> formatValueList;

        public FrameInfo frameInfo;

        static FormatEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 12400, 12961);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 12494, 12536);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 12400, 12961);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 12400, 12961);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 12400, 12961);

        System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
        f_1088_12612_12635()
        {
            var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1088, 12612, 12635);
            return return_v;
        }

    }
    internal sealed partial class FrameInfo : FormatInfoData
    {
        internal const string
        CLSID = "091C9E762E33499eBE318901B6EFB733"
        ;

        public override string ClassId2e4f51ef21dd47e99d3c952918aff9cd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1088, 13184, 13205);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 13190, 13203);

                    return CLSID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1088, 13184, 13205);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1088, 13119, 13207);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 13119, 13207);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int leftIndentation;

        public int rightIndentation;

        public int firstLine;

        public FrameInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1088, 12969, 13334);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 13230, 13249);
            this.leftIndentation = 0;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 13271, 13291);
            this.rightIndentation = 0;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 13313, 13326);
            this.firstLine = 0;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1088, 12969, 13334);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 12969, 13334);
        }


        static FrameInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1088, 12969, 13334);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1088, 13064, 13106);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1088, 12969, 13334);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1088, 12969, 13334);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1088, 12969, 13334);
    }

}
