// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Management.Automation;
using System.Xml;

using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell
{
    internal class Serialization
    {        /// <summary>
             /// Describes the format of the data streamed between minishells, e.g. the allowed arguments to the minishell
             /// -outputformat and -inputformat command line parameters.
             /// </summary>

        internal enum DataFormat
        {
            /// <summary>
            /// Text format -- i.e. stream text just as out-default would display it.
            /// </summary>

            Text = 0,

            /// <summary>
            /// XML-serialized format.
            /// </summary>

            XML = 1,

            /// <summary>
            /// Indicates that the data should be discarded instead of processed.
            /// </summary>
            None = 2
        }

        protected
                Serialization(DataFormat dataFormat, string streamName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(126, 1248, 1506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 1595, 1605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 1637, 1643);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 1347, 1416);

                f_126_1347_1415(!f_126_1359_1391(streamName), "stream needs a name");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 1432, 1452);

                format = dataFormat;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 1466, 1495);

                this.streamName = streamName;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(126, 1248, 1506);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(126, 1248, 1506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(126, 1248, 1506);
            }
        }

        protected static string XmlCliTag;

        protected string streamName;

        protected DataFormat format;

        static Serialization()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(126, 458, 1651);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 1542, 1565);
            XmlCliTag = "#< CLIXML";
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(126, 458, 1651);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(126, 458, 1651);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(126, 458, 1651);

        bool
        f_126_1359_1391(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 1359, 1391);
            return return_v;
        }


        int
        f_126_1347_1415(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 1347, 1415);
            return 0;
        }

    }
    internal
        class WrappedSerializer : Serialization
    {
        internal
                WrappedSerializer(DataFormat dataFormat, string streamName, TextWriter output)
        : base(f_126_1859_1869_C(dataFormat), streamName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(126, 1729, 2668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 4055, 4065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 4094, 4104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 4134, 4148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 4172, 4189);
                this._firstCall = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 1907, 1964);

                f_126_1907_1963(output != null, "output should have a value");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 1980, 2000);

                textWriter = output;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 2014, 2657);

                switch (format)
                {

                    case DataFormat.XML:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 2014, 2657);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 2104, 2157);

                        XmlWriterSettings
                        settings = f_126_2133_2156()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 2179, 2212);

                        settings.CheckCharacters = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 2234, 2269);

                        settings.OmitXmlDeclaration = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 2291, 2343);

                        _xmlWriter = f_126_2304_2342(textWriter, settings);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 2365, 2409);

                        _xmlSerializer = f_126_2382_2408(_xmlWriter);
                        DynAbs.Tracing.TraceSender.TraceBreak(126, 2431, 2437);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(126, 2014, 2657);

                    case DataFormat.Text:
                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 2014, 2657);
                        DynAbs.Tracing.TraceSender.TraceBreak(126, 2636, 2642);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(126, 2014, 2657);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(126, 1729, 2668);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(126, 1729, 2668);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(126, 1729, 2668);
            }
        }

        internal
                void
                Serialize(object o)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(126, 2680, 2797);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 2756, 2786);

                f_126_2756_2785(this, o, this.streamName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(126, 2680, 2797);

                int
                f_126_2756_2785(Microsoft.PowerShell.WrappedSerializer
                this_param, object
                o, string
                streamName)
                {
                    this_param.Serialize(o, streamName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 2756, 2785);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(126, 2680, 2797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(126, 2680, 2797);
            }
        }

        internal
                void
                Serialize(object o, string streamName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(126, 2809, 3503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 2904, 3492);

                switch (format)
                {

                    case DataFormat.None:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 2904, 3492);
                        DynAbs.Tracing.TraceSender.TraceBreak(126, 2995, 3001);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(126, 2904, 3492);

                    case DataFormat.XML:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 2904, 3492);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 3061, 3239) || true) && (_firstCall)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 3061, 3239);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 3125, 3144);

                            _firstCall = false;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 3170, 3216);

                            f_126_3170_3215(textWriter, Serialization.XmlCliTag);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(126, 3061, 3239);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 3263, 3303);

                        f_126_3263_3302(
                                            _xmlSerializer, o, streamName);
                        DynAbs.Tracing.TraceSender.TraceBreak(126, 3325, 3331);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(126, 2904, 3492);

                    case DataFormat.Text:
                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 2904, 3492);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 3418, 3449);

                        f_126_3418_3448(textWriter, f_126_3435_3447(o));
                        DynAbs.Tracing.TraceSender.TraceBreak(126, 3471, 3477);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(126, 2904, 3492);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(126, 2809, 3503);

                int
                f_126_3170_3215(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 3170, 3215);
                    return 0;
                }


                int
                f_126_3263_3302(System.Management.Automation.Serializer
                this_param, object
                source, string
                streamName)
                {
                    this_param.Serialize(source, streamName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 3263, 3302);
                    return 0;
                }


                string?
                f_126_3435_3447(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 3435, 3447);
                    return return_v;
                }


                int
                f_126_3418_3448(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 3418, 3448);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(126, 2809, 3503);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(126, 2809, 3503);
            }
        }

        internal
                void
                End()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(126, 3515, 4023);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 3577, 4012);

                switch (format)
                {

                    case DataFormat.None:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 3577, 4012);
                        DynAbs.Tracing.TraceSender.TraceBreak(126, 3703, 3709);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(126, 3577, 4012);

                    case DataFormat.XML:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 3577, 4012);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 3771, 3793);

                        f_126_3771_3792(_xmlSerializer);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 3815, 3837);

                        _xmlSerializer = null;
                        DynAbs.Tracing.TraceSender.TraceBreak(126, 3859, 3865);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(126, 3577, 4012);

                    case DataFormat.Text:
                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 3577, 4012);
                        DynAbs.Tracing.TraceSender.TraceBreak(126, 3991, 3997);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(126, 3577, 4012);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(126, 3515, 4023);

                int
                f_126_3771_3792(System.Management.Automation.Serializer
                this_param)
                {
                    this_param.Done();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 3771, 3792);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(126, 3515, 4023);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(126, 3515, 4023);
            }
        }

        internal TextWriter textWriter;

        private XmlWriter _xmlWriter;

        private Serializer _xmlSerializer;

        private bool _firstCall;

        static WrappedSerializer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(126, 1659, 4197);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(126, 1659, 4197);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(126, 1659, 4197);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(126, 1659, 4197);

        int
        f_126_1907_1963(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 1907, 1963);
            return 0;
        }


        System.Xml.XmlWriterSettings
        f_126_2133_2156()
        {
            var return_v = new System.Xml.XmlWriterSettings();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 2133, 2156);
            return return_v;
        }


        System.Xml.XmlWriter
        f_126_2304_2342(System.IO.TextWriter
        output, System.Xml.XmlWriterSettings
        settings)
        {
            var return_v = XmlWriter.Create(output, settings);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 2304, 2342);
            return return_v;
        }


        System.Management.Automation.Serializer
        f_126_2382_2408(System.Xml.XmlWriter
        writer)
        {
            var return_v = new System.Management.Automation.Serializer(writer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 2382, 2408);
            return return_v;
        }


        static Microsoft.PowerShell.Serialization.DataFormat
        f_126_1859_1869_C(Microsoft.PowerShell.Serialization.DataFormat
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(126, 1729, 2668);
            return return_v;
        }

    }
    internal
        class WrappedDeserializer : Serialization
    {
        internal
                WrappedDeserializer(DataFormat dataFormat, string streamName, TextReader input)
        : base(f_126_4408_4418_C(dataFormat), streamName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(126, 4277, 5444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 7635, 7645);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 7674, 7684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 7716, 7732);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 7758, 7768);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 7792, 7798);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 4456, 4511);

                f_126_4456_4510(input != null, "input should have a value");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 4586, 4645) || true) && (dataFormat == DataFormat.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 4586, 4645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 4638, 4645);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(126, 4586, 4645);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 4661, 4680);

                textReader = input;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 4694, 4729);

                _firstLine = f_126_4707_4728(textReader);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 4743, 4959) || true) && (f_126_4747_4834(_firstLine, Serialization.XmlCliTag, StringComparison.OrdinalIgnoreCase) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 4743, 4959);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 4916, 4944);

                    dataFormat = DataFormat.XML;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(126, 4743, 4959);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 4975, 5433);

                switch (format)
                {

                    case DataFormat.XML:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 4975, 5433);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 5065, 5153);

                        _xmlReader = f_126_5078_5152(textReader, new XmlReaderSettings { XmlResolver = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => (XmlResolver)null, 126, 5107, 5151) });
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 5175, 5223);

                        _xmlDeserializer = f_126_5194_5222(_xmlReader);
                        DynAbs.Tracing.TraceSender.TraceBreak(126, 5245, 5251);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(126, 4975, 5433);

                    case DataFormat.Text:
                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 4975, 5433);
                        DynAbs.Tracing.TraceSender.TraceBreak(126, 5412, 5418);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(126, 4975, 5433);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(126, 4277, 5444);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(126, 4277, 5444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(126, 4277, 5444);
            }
        }

        internal
                object
                Deserialize()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(126, 5456, 6566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 5528, 5537);

                object
                o
                = default(object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 5551, 6530);

                switch (format)
                {

                    case DataFormat.None:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 5551, 6530);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 5642, 5656);

                        _atEnd = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 5678, 5690);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(126, 5551, 6530);

                    case DataFormat.XML:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 5551, 6530);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 5752, 5766);

                        string
                        unused
                        = default(string);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 5788, 5833);

                        o = f_126_5792_5832(_xmlDeserializer, out unused);
                        DynAbs.Tracing.TraceSender.TraceBreak(126, 5855, 5861);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(126, 5551, 6530);

                    case DataFormat.Text:
                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 5551, 6530);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 5950, 6045) || true) && (_atEnd)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 5950, 6045);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 6010, 6022);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(126, 5950, 6045);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 6069, 6485) || true) && (_firstLine != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 6069, 6485);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 6141, 6156);

                            o = _firstLine;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 6182, 6200);

                            _firstLine = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(126, 6069, 6485);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 6069, 6485);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 6298, 6324);

                            o = f_126_6302_6323(textReader);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 6350, 6462) || true) && (o == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 6350, 6462);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 6421, 6435);

                                _atEnd = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(126, 6350, 6462);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(126, 6069, 6485);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(126, 6509, 6515);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(126, 5551, 6530);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 6546, 6555);

                return o;
                DynAbs.Tracing.TraceSender.TraceExitMethod(126, 5456, 6566);

                object
                f_126_5792_5832(System.Management.Automation.Deserializer
                this_param, out string
                streamName)
                {
                    var return_v = this_param.Deserialize(out streamName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 5792, 5832);
                    return return_v;
                }


                string?
                f_126_6302_6323(System.IO.TextReader
                this_param)
                {
                    var return_v = this_param.ReadLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 6302, 6323);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(126, 5456, 6566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(126, 5456, 6566);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal
                bool
                AtEnd
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(126, 6640, 7255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 6676, 6696);

                    bool
                    result = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 6714, 7206);

                    switch (format)
                    {

                        case DataFormat.None:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 6714, 7206);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 6817, 6831);

                            _atEnd = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 6857, 6871);

                            result = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(126, 6897, 6903);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(126, 6714, 7206);

                        case DataFormat.XML:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 6714, 7206);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 6973, 7006);

                            result = f_126_6982_7005(_xmlDeserializer);
                            DynAbs.Tracing.TraceSender.TraceBreak(126, 7032, 7038);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(126, 6714, 7206);

                        case DataFormat.Text:
                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 6714, 7206);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 7139, 7155);

                            result = _atEnd;
                            DynAbs.Tracing.TraceSender.TraceBreak(126, 7181, 7187);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(126, 6714, 7206);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 7226, 7240);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(126, 6640, 7255);

                    bool
                    f_126_6982_7005(System.Management.Automation.Deserializer
                    this_param)
                    {
                        var return_v = this_param.Done();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 6982, 7005);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(126, 6578, 7266);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(126, 6578, 7266);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal
                void
                End()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(126, 7278, 7603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(126, 7340, 7592);

                switch (format)
                {

                    case DataFormat.None:
                    case DataFormat.XML:
                    case DataFormat.Text:
                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(126, 7340, 7592);
                        DynAbs.Tracing.TraceSender.TraceBreak(126, 7571, 7577);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(126, 7340, 7592);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(126, 7278, 7603);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(126, 7278, 7603);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(126, 7278, 7603);
            }
        }

        internal TextReader textReader;

        private XmlReader _xmlReader;

        private Deserializer _xmlDeserializer;

        private string _firstLine;

        private bool _atEnd;

        static WrappedDeserializer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(126, 4205, 7806);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(126, 4205, 7806);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(126, 4205, 7806);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(126, 4205, 7806);

        int
        f_126_4456_4510(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 4456, 4510);
            return 0;
        }


        string
        f_126_4707_4728(System.IO.TextReader
        this_param)
        {
            var return_v = this_param.ReadLine();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 4707, 4728);
            return return_v;
        }


        int
        f_126_4747_4834(string
        strA, string
        strB, System.StringComparison
        comparisonType)
        {
            var return_v = string.Compare(strA, strB, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 4747, 4834);
            return return_v;
        }


        System.Xml.XmlReader
        f_126_5078_5152(System.IO.TextReader
        input, System.Xml.XmlReaderSettings
        settings)
        {
            var return_v = XmlReader.Create(input, settings);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 5078, 5152);
            return return_v;
        }


        System.Management.Automation.Deserializer
        f_126_5194_5222(System.Xml.XmlReader
        reader)
        {
            var return_v = new System.Management.Automation.Deserializer(reader);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(126, 5194, 5222);
            return return_v;
        }


        static Microsoft.PowerShell.Serialization.DataFormat
        f_126_4408_4418_C(Microsoft.PowerShell.Serialization.DataFormat
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(126, 4277, 5444);
            return return_v;
        }

    }
}   // namespace

