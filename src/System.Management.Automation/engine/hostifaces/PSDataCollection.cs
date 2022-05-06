// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis; // for fxcop
using System.Reflection;
using System.Runtime.Serialization;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    public sealed class DataAddedEventArgs : EventArgs
    {
        internal DataAddedEventArgs(Guid psInstanceId, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1480, 1131, 1288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 1446, 1471);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 1213, 1249);

                PowerShellInstanceId = psInstanceId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 1263, 1277);

                Index = index;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1480, 1131, 1288);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 1131, 1288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 1131, 1288);
            }
        }

        public int Index { get; }

        public Guid PowerShellInstanceId { get; }

        static DataAddedEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1480, 593, 1747);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1480, 593, 1747);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 593, 1747);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1480, 593, 1747);
    }
    public sealed class DataAddingEventArgs : EventArgs
    {
        internal DataAddingEventArgs(Guid psInstanceId, object itemAdded)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1480, 2429, 2602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 2754, 2786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 2519, 2555);

                PowerShellInstanceId = psInstanceId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 2569, 2591);

                ItemAdded = itemAdded;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1480, 2429, 2602);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 2429, 2602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 2429, 2602);
            }
        }

        public object ItemAdded { get; }

        public Guid PowerShellInstanceId { get; }

        static DataAddingEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1480, 1885, 3062);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1480, 1885, 3062);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 1885, 3062);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1480, 1885, 3062);
    }
    [Serializable]
    public class PSDataCollection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IList, ICollection, IEnumerable, IDisposable, ISerializable
    {
        private IList<T> _data;

        private ManualResetEvent _readWaitHandle;

        private bool _isOpen;

        private bool _releaseOnEnumeration;

        private bool _isEnumerated;

        private int _refCount;

        private bool _isDisposed;

        private bool _blockingEnumerator;

        private bool _refCountIncrementedForBlockingEnumerator;

        private int _countNewData;

        private int _dataAddedFrequency;

        private Guid _sourceGuid;

        public PSDataCollection() :
            // LAFHIS : IMPROVE BASE CALLS
            //this(f_1480_4517_4530_C(f_1480_4517_4530()))
            this(f_1480_4517_4530())
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1480, 4484, 4553);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1480, 4484, 4553);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 4484, 4553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 4484, 4553);
            }
        }

        public PSDataCollection(IEnumerable<T> items) : this(f_1480_5244_5262_C(f_1480_5244_5262(items)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1480, 5191, 5315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 5288, 5304);

                f_1480_5288_5303(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1480, 5191, 5315);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 5191, 5315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 5191, 5315);
            }
        }

        public PSDataCollection(int capacity) : this(f_1480_5850_5871_C(f_1480_5850_5871(capacity)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1480, 5805, 5894);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1480, 5805, 5894);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 5805, 5894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 5805, 5894);
            }
        }



        /// <summary>
        /// Wrap the argument in a PSDataCollection.
        /// </summary>
        /// <param name="valueToConvert">The value to convert.</param>
        /// <returns>New collection of value, marked as Complete.</returns>
        [SuppressMessage("Microsoft.Usage", "CA2225:OperatorOverloadsHaveNamedAlternates",
            Justification = "There are already alternates to the implicit casts, ToXXX and FromXXX methods are unnecessary and redundant")]
        public static implicit operator PSDataCollection<T>(bool valueToConvert)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1480, 6213, 6614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 6543, 6603);

                return f_1480_6550_6602(valueToConvert);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1480, 6213, 6614);

                System.Management.Automation.PSDataCollection<T>
                f_1480_6550_6602(bool
                valueToConvert)
                {
                    var return_v = CreateAndInitializeFromExplicitValue((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 6550, 6602);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 6213, 6614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 6213, 6614);
            }
        }
        /// <summary>
        /// Wrap the argument in a PSDataCollection.
        /// </summary>
        /// <param name="valueToConvert">The value to convert.</param>
        /// <returns>New collection of value, marked as Complete.</returns>
        [SuppressMessage("Microsoft.Usage", "CA2225:OperatorOverloadsHaveNamedAlternates",
            Justification = "There are already alternates to the implicit casts, ToXXX and FromXXX methods are unnecessary and redundant")]
        public static implicit operator PSDataCollection<T>(string valueToConvert)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1480, 6876, 7279);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 7208, 7268);

                return f_1480_7215_7267(valueToConvert);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1480, 6876, 7279);

                System.Management.Automation.PSDataCollection<T>
                f_1480_7215_7267(string
                valueToConvert)
                {
                    var return_v = CreateAndInitializeFromExplicitValue((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 7215, 7267);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 6876, 7279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 6876, 7279);
            }
        }
        /// <summary>
        /// Wrap the argument in a PSDataCollection.
        /// </summary>
        /// <param name="valueToConvert">The value to convert.</param>
        /// <returns>New collection of value, marked as Complete.</returns>
        [SuppressMessage("Microsoft.Usage", "CA2225:OperatorOverloadsHaveNamedAlternates",
            Justification = "There are already alternates to the implicit casts, ToXXX and FromXXX methods are unnecessary and redundant")]
        public static implicit operator PSDataCollection<T>(int valueToConvert)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1480, 7541, 7941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 7870, 7930);

                return f_1480_7877_7929(valueToConvert);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1480, 7541, 7941);

                System.Management.Automation.PSDataCollection<T>
                f_1480_7877_7929(int
                valueToConvert)
                {
                    var return_v = CreateAndInitializeFromExplicitValue((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 7877, 7929);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 7541, 7941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 7541, 7941);
            }
        }
        /// <summary>
        /// Wrap the argument in a PSDataCollection.
        /// </summary>
        /// <param name="valueToConvert">The value to convert.</param>
        /// <returns>New collection of value, marked as Complete.</returns>
        [SuppressMessage("Microsoft.Usage", "CA2225:OperatorOverloadsHaveNamedAlternates",
            Justification = "There are already alternates to the implicit casts, ToXXX and FromXXX methods are unnecessary and redundant")]
        public static implicit operator PSDataCollection<T>(byte valueToConvert)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1480, 8203, 8604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 8533, 8593);

                return f_1480_8540_8592(valueToConvert);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1480, 8203, 8604);

                System.Management.Automation.PSDataCollection<T>
                f_1480_8540_8592(byte
                valueToConvert)
                {
                    var return_v = CreateAndInitializeFromExplicitValue((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 8540, 8592);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 8203, 8604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 8203, 8604);
            }
        }
        private static PSDataCollection<T> CreateAndInitializeFromExplicitValue(object valueToConvert)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1480, 8616, 8927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 8735, 8788);

                PSDataCollection<T>
                psdc = f_1480_8762_8787()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 8802, 8860);

                f_1480_8802_8859(psdc, f_1480_8811_8858(valueToConvert));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 8874, 8890);

                f_1480_8874_8889(psdc);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 8904, 8916);

                return psdc;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1480, 8616, 8927);

                System.Management.Automation.PSDataCollection<T>
                f_1480_8762_8787()
                {
                    var return_v = new System.Management.Automation.PSDataCollection<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 8762, 8787);
                    return return_v;
                }


                T
                f_1480_8811_8858(object
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<T>(valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 8811, 8858);
                    return return_v;
                }


                int
                f_1480_8802_8859(System.Management.Automation.PSDataCollection<T>
                this_param, T
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 8802, 8859);
                    return 0;
                }


                int
                f_1480_8874_8889(System.Management.Automation.PSDataCollection<T>
                this_param)
                {
                    this_param.Complete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 8874, 8889);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 8616, 8927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 8616, 8927);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Wrap the argument in a PSDataCollection.
        /// </summary>
        /// <param name="valueToConvert">The value to convert.</param>
        /// <returns>New collection of value, marked as Complete.</returns>
        [SuppressMessage("Microsoft.Usage", "CA2225:OperatorOverloadsHaveNamedAlternates",
            Justification = "There are already alternates to the implicit casts, ToXXX and FromXXX methods are unnecessary and redundant")]
        public static implicit operator PSDataCollection<T>(Hashtable valueToConvert)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1480, 9189, 9716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 9524, 9577);

                PSDataCollection<T>
                psdc = f_1480_9551_9576()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 9591, 9649);

                f_1480_9591_9648(psdc, f_1480_9600_9647(valueToConvert));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 9663, 9679);

                f_1480_9663_9678(psdc);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 9693, 9705);

                return psdc;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1480, 9189, 9716);

                System.Management.Automation.PSDataCollection<T>
                f_1480_9551_9576()
                {
                    var return_v = new System.Management.Automation.PSDataCollection<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 9551, 9576);
                    return return_v;
                }


                T
                f_1480_9600_9647(System.Collections.Hashtable
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<T>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 9600, 9647);
                    return return_v;
                }


                int
                f_1480_9591_9648(System.Management.Automation.PSDataCollection<T>
                this_param, T
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 9591, 9648);
                    return 0;
                }


                int
                f_1480_9663_9678(System.Management.Automation.PSDataCollection<T>
                this_param)
                {
                    this_param.Complete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 9663, 9678);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 9189, 9716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 9189, 9716);
            }
        }
        /// <summary>
        /// Wrap the argument in a PSDataCollection.
        /// </summary>
        /// <param name="valueToConvert">The value to convert.</param>
        /// <returns>New collection of value, marked as Complete.</returns>
        [SuppressMessage("Microsoft.Usage", "CA2225:OperatorOverloadsHaveNamedAlternates",
            Justification = "There are already alternates to the implicit casts, ToXXX and FromXXX methods are unnecessary and redundant")]
        public static implicit operator PSDataCollection<T>(T valueToConvert)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1480, 9978, 10497);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 10305, 10358);

                PSDataCollection<T>
                psdc = f_1480_10332_10357()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 10372, 10430);

                f_1480_10372_10429(psdc, f_1480_10381_10428(valueToConvert));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 10444, 10460);

                f_1480_10444_10459(psdc);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 10474, 10486);

                return psdc;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1480, 9978, 10497);

                System.Management.Automation.PSDataCollection<T>
                f_1480_10332_10357()
                {
                    var return_v = new System.Management.Automation.PSDataCollection<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 10332, 10357);
                    return return_v;
                }


                T
                f_1480_10381_10428(T
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<T>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 10381, 10428);
                    return return_v;
                }


                int
                f_1480_10372_10429(System.Management.Automation.PSDataCollection<T>
                this_param, T
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 10372, 10429);
                    return 0;
                }


                int
                f_1480_10444_10459(System.Management.Automation.PSDataCollection<T>
                this_param)
                {
                    this_param.Complete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 10444, 10459);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 9978, 10497);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 9978, 10497);
            }
        }
        /// <summary>
        /// Wrap the argument in a PSDataCollection.
        /// </summary>
        /// <param name="arrayToConvert">The value to convert.</param>
        /// <returns>New collection of value, marked as Complete.</returns>
        [SuppressMessage("Microsoft.Usage", "CA2225:OperatorOverloadsHaveNamedAlternates",
            Justification = "There are already alternates to the implicit casts, ToXXX and FromXXX methods are unnecessary and redundant")]
        public static implicit operator PSDataCollection<T>(object[] arrayToConvert)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1480, 10759, 11444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 11093, 11146);

                PSDataCollection<T>
                psdc = f_1480_11120_11145()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 11160, 11375) || true) && (arrayToConvert != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 11160, 11375);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 11220, 11360);
                        foreach (var ae in f_1480_11239_11253_I(arrayToConvert))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 11220, 11360);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 11295, 11341);

                            f_1480_11295_11340(psdc, f_1480_11304_11339(ae));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 11220, 11360);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1480, 1, 141);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1480, 1, 141);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 11160, 11375);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 11391, 11407);

                f_1480_11391_11406(
                            psdc);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 11421, 11433);

                return psdc;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1480, 10759, 11444);

                System.Management.Automation.PSDataCollection<T>
                f_1480_11120_11145()
                {
                    var return_v = new System.Management.Automation.PSDataCollection<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 11120, 11145);
                    return return_v;
                }


                T
                f_1480_11304_11339(object
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<T>(valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 11304, 11339);
                    return return_v;
                }


                int
                f_1480_11295_11340(System.Management.Automation.PSDataCollection<T>
                this_param, T
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 11295, 11340);
                    return 0;
                }


                object[]
                f_1480_11239_11253_I(object[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 11239, 11253);
                    return return_v;
                }


                int
                f_1480_11391_11406(System.Management.Automation.PSDataCollection<T>
                this_param)
                {
                    this_param.Complete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 11391, 11406);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 10759, 11444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 10759, 11444);
            }
        }
        internal PSDataCollection(IList<T> listToUse)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1480, 12019, 12118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 3437, 3442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 3478, 3493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 3517, 3531);
                this._isOpen = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 3555, 3576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 3600, 3613);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 3734, 3743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 3769, 3788);
                this._isDisposed = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 3943, 3970);
                this._blockingEnumerator = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 4144, 4193);
                this._refCountIncrementedForBlockingEnumerator = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 4218, 4235);
                this._countNewData = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 4258, 4281);
                this._dataAddedFrequency = 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 4305, 4329);
                this._sourceGuid = Guid.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 16022, 16045);
                this._serializeInput = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 16369, 16441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 22000, 22047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 47734, 47744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 58311, 58362);
                this.SyncObject = f_1480_58349_58361();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 12089, 12107);

                _data = listToUse;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1480, 12019, 12118);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 12019, 12118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 12019, 12118);
            }
        }

        protected PSDataCollection(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1480, 12417, 13182);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 3437, 3442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 3478, 3493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 3517, 3531);
                this._isOpen = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 3555, 3576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 3600, 3613);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 3734, 3743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 3769, 3788);
                this._isDisposed = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 3943, 3970);
                this._blockingEnumerator = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 4144, 4193);
                this._refCountIncrementedForBlockingEnumerator = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 4218, 4235);
                this._countNewData = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 4258, 4281);
                this._dataAddedFrequency = 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 4305, 4329);
                this._sourceGuid = Guid.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 16022, 16045);
                this._serializeInput = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 16369, 16441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 22000, 22047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 47734, 47744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 58311, 58362);
                this.SyncObject = f_1480_58349_58361();
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 12518, 12636) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 12518, 12636);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 12568, 12621);

                    throw f_1480_12574_12620("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 12518, 12636);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 12652, 12725);

                IList<T>
                listToUse = f_1480_12673_12712(info, "Data", typeof(IList<T>)) as IList<T>
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 12741, 12864) || true) && (listToUse == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 12741, 12864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 12796, 12849);

                    throw f_1480_12802_12848("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 12741, 12864);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 12880, 12898);

                _data = listToUse;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 12914, 12974);

                _blockingEnumerator = f_1480_12936_12973(info, "BlockingEnumerator");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 12988, 13042);

                _dataAddedFrequency = f_1480_13010_13041(info, "DataAddedCount");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 13056, 13121);

                EnumeratorNeverBlocks = f_1480_13080_13120(info, "EnumeratorNeverBlocks");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 13135, 13171);

                _isOpen = f_1480_13145_13170(info, "IsOpen");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1480, 12417, 13182);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 12417, 13182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 12417, 13182);
            }
        }



        /// <summary>
        /// Event fired when objects are being added to the underlying buffer.
        /// </summary>
        public event EventHandler<DataAddingEventArgs>
DataAdding
;

        /// <summary>
        /// Event fired when objects are done being added to the underlying buffer.
        /// </summary>
        public event EventHandler<DataAddedEventArgs>
DataAdded
;

        /// <summary>
        /// Event fired when the buffer is completed.
        /// </summary>
        public event EventHandler
Completed
;

        public bool IsOpen
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 13989, 14132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 14031, 14041);
                    lock (f_1480_14031_14041())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 14083, 14098);

                        return _isOpen;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 13989, 14132);

                    object
                    f_1480_14031_14041()
                    {
                        var return_v = SyncObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 14031, 14041);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 13946, 14143);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 13946, 14143);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int DataAddedCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 14563, 14598);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 14569, 14596);

                    return _dataAddedFrequency;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 14563, 14598);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 14513, 15312);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 14513, 15312);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 14614, 15301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 14650, 14678);

                    bool
                    raiseDataAdded = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 14702, 14712);
                    lock (f_1480_14702_14712())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 14754, 14782);

                        _dataAddedFrequency = value;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 14804, 14983) || true) && (_countNewData >= _dataAddedFrequency)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 14804, 14983);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 14894, 14916);

                            raiseDataAdded = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 14942, 14960);

                            _countNewData = 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 14804, 14983);
                        }
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 15022, 15286) || true) && (raiseDataAdded)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 15022, 15286);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 15216, 15267);

                        f_1480_15216_15266(this, _lastPsInstanceId, _lastIndex);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 15022, 15286);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 14614, 15301);

                    object
                    f_1480_14702_14712()
                    {
                        var return_v = SyncObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 14702, 14712);
                        return return_v;
                    }


                    int
                    f_1480_15216_15266(System.Management.Automation.PSDataCollection<T>
                    this_param, System.Guid
                    psInstanceId, int
                    index)
                    {
                        this_param.RaiseDataAddedEvent(psInstanceId, index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 15216, 15266);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 14513, 15312);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 14513, 15312);
                }
            }
        }

        public bool SerializeInput
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 15539, 15613);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 15575, 15598);

                    return _serializeInput;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 15539, 15613);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 15488, 15997);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 15488, 15997);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 15629, 15986);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 15665, 15927) || true) && (typeof(T) != typeof(PSObject))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 15665, 15927);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 15829, 15908);

                        throw f_1480_15835_15907(f_1480_15861_15906());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 15665, 15927);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 15947, 15971);

                    _serializeInput = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 15629, 15986);

                    string
                    f_1480_15861_15906()
                    {
                        var return_v = PSDataBufferStrings.SerializationNotSupported;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 15861, 15906);
                        return return_v;
                    }


                    System.NotSupportedException
                    f_1480_15835_15907(string
                    message)
                    {
                        var return_v = new System.NotSupportedException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 15835, 15907);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 15488, 15997);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 15488, 15997);
                }
            }
        }

        private bool _serializeInput;

        public bool IsAutoGenerated
        {
            get; set;
        }

        internal Guid SourceId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 16636, 16783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 16678, 16688);
                    lock (f_1480_16678_16688())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 16730, 16749);

                        return _sourceGuid;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 16636, 16783);

                    object
                    f_1480_16678_16688()
                    {
                        var return_v = SyncObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 16678, 16688);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 16589, 16958);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 16589, 16958);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 16799, 16947);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 16841, 16851);
                    lock (f_1480_16841_16851())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 16893, 16913);

                        _sourceGuid = value;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 16799, 16947);

                    object
                    f_1480_16841_16851()
                    {
                        var return_v = SyncObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 16841, 16851);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 16589, 16958);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 16589, 16958);
                }
            }
        }

        internal bool ReleaseOnEnumeration
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 17236, 17393);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 17278, 17288);
                    lock (f_1480_17278_17288())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 17330, 17359);

                        return _releaseOnEnumeration;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 17236, 17393);

                    object
                    f_1480_17278_17288()
                    {
                        var return_v = SyncObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 17278, 17288);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 17177, 17578);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 17177, 17578);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 17409, 17567);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 17451, 17461);
                    lock (f_1480_17451_17461())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 17503, 17533);

                        _releaseOnEnumeration = value;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 17409, 17567);

                    object
                    f_1480_17451_17461()
                    {
                        var return_v = SyncObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 17451, 17461);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 17177, 17578);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 17177, 17578);
                }
            }
        }

        internal bool IsEnumerated
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 17806, 17955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 17848, 17858);
                    lock (f_1480_17848_17858())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 17900, 17921);

                        return _isEnumerated;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 17806, 17955);

                    object
                    f_1480_17848_17858()
                    {
                        var return_v = SyncObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 17848, 17858);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 17755, 18132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 17755, 18132);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 17971, 18121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 18013, 18023);
                    lock (f_1480_18013_18023())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 18065, 18087);

                        _isEnumerated = value;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 17971, 18121);

                    object
                    f_1480_18013_18023()
                    {
                        var return_v = SyncObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 18013, 18023);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 17755, 18132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 17755, 18132);
                }
            }
        }

        public void Complete()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 18331, 20086);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 18378, 18403);

                bool
                raiseEvents = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 18417, 18445);

                bool
                raiseDataAdded = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 18538, 18548);
                    // Close the buffer
                    lock (f_1480_18538_18548())
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 18590, 19128) || true) && (_isOpen)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 18590, 19128);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 18651, 18667);

                            _isOpen = false;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 18693, 18712);

                            raiseEvents = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 18872, 18901);

                            f_1480_18872_18900(f_1480_18889_18899());

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 18929, 19105) || true) && (_countNewData > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 18929, 19105);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 19008, 19030);

                                raiseDataAdded = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 19060, 19078);

                                _countNewData = 0;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 18929, 19105);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 18590, 19128);
                        }
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1480, 19176, 20075);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 19274, 19910) || true) && (raiseEvents)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 19274, 19910);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 19331, 19523) || true) && (_readWaitHandle != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 19331, 19523);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 19478, 19500);

                            f_1480_19478_19499(                        // unblock any readers waiting on the handle
                                                    _readWaitHandle);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 19331, 19523);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 19695, 19734);

                        EventHandler
                        tempCompleted = Completed
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 19756, 19891) || true) && (tempCompleted != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 19756, 19891);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 19831, 19868);

                            f_1480_19831_19867(tempCompleted, this, EventArgs.Empty);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 19756, 19891);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 19274, 19910);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 19930, 20060) || true) && (raiseDataAdded)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 19930, 20060);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 19990, 20041);

                        f_1480_19990_20040(this, _lastPsInstanceId, _lastIndex);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 19930, 20060);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1480, 19176, 20075);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 18331, 20086);

                object
                f_1480_18538_18548()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 18538, 18548);
                    return return_v;
                }


                object
                f_1480_18889_18899()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 18889, 18899);
                    return return_v;
                }


                int
                f_1480_18872_18900(object
                obj)
                {
                    Monitor.PulseAll(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 18872, 18900);
                    return 0;
                }


                bool
                f_1480_19478_19499(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 19478, 19499);
                    return return_v;
                }


                int
                f_1480_19831_19867(System.EventHandler
                this_param, System.Management.Automation.PSDataCollection<T>
                sender, System.EventArgs
                e)
                {
                    this_param.Invoke((object)sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 19831, 19867);
                    return 0;
                }


                int
                f_1480_19990_20040(System.Management.Automation.PSDataCollection<T>
                this_param, System.Guid
                psInstanceId, int
                index)
                {
                    this_param.RaiseDataAddedEvent(psInstanceId, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 19990, 20040);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 18331, 20086);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 18331, 20086);
            }
        }

        public bool BlockingEnumerator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 20627, 20782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 20669, 20679);
                    lock (f_1480_20669_20679())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 20721, 20748);

                        return _blockingEnumerator;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 20627, 20782);

                    object
                    f_1480_20669_20679()
                    {
                        var return_v = SyncObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 20669, 20679);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 20572, 21823);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 20572, 21823);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 20798, 21812);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 20840, 20850);
                    lock (f_1480_20840_20850())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 20892, 20920);

                        _blockingEnumerator = value;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 20944, 21778) || true) && (_blockingEnumerator)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 20944, 21778);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 21017, 21236) || true) && (!_refCountIncrementedForBlockingEnumerator)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 21017, 21236);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 21121, 21170);

                                _refCountIncrementedForBlockingEnumerator = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 21200, 21209);

                                f_1480_21200_21208(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 21017, 21236);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 20944, 21778);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 20944, 21778);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 21530, 21755) || true) && (_refCountIncrementedForBlockingEnumerator)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 21530, 21755);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 21633, 21683);

                                _refCountIncrementedForBlockingEnumerator = false;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 21713, 21728);

                                f_1480_21713_21727(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 21530, 21755);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 20944, 21778);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 20798, 21812);

                    object
                    f_1480_20840_20850()
                    {
                        var return_v = SyncObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 20840, 20850);
                        return return_v;
                    }


                    int
                    f_1480_21200_21208(System.Management.Automation.PSDataCollection<T>
                    this_param)
                    {
                        this_param.AddRef();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 21200, 21208);
                        return 0;
                    }


                    int
                    f_1480_21713_21727(System.Management.Automation.PSDataCollection<T>
                    this_param)
                    {
                        this_param.DecrementRef();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 21713, 21727);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 20572, 21823);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 20572, 21823);
                }
            }
        }

        public bool EnumeratorNeverBlocks { get; set; }



        /// <summary>
        /// Gets or sets the element at the specified index.
        /// </summary>
        /// <param name="index">
        /// The zero-based index of the element to get or set.
        /// </param>
        /// <exception cref="InvalidOperationException">
        /// Objects cannot be added to a closed buffer.
        /// Make sure the buffer is open for Add and Insert
        /// operations to succeed.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// index is less than 0.
        /// (or)
        /// index is equal to or greater than Count.
        /// </exception>
        public T this[int index]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 22833, 22981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 22875, 22885);
                    lock (f_1480_22875_22885())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 22927, 22947);

                        return f_1480_22934_22946(_data, index);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 22833, 22981);

                    object
                    f_1480_22875_22885()
                    {
                        var return_v = SyncObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 22875, 22885);
                        return return_v;
                    }


                    T
                    f_1480_22934_22946(System.Collections.Generic.IList<T>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 22934, 22946);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 22833, 22981);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 22833, 22981);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 22997, 23599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 23039, 23049);
                    lock (f_1480_23039_23049())
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 23091, 23358) || true) && ((index < 0) || (DynAbs.Tracing.TraceSender.Expression_False(1480, 23095, 23132) || (index >= f_1480_23120_23131(_data))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 23091, 23358);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 23182, 23335);

                            throw f_1480_23188_23334("index", index, f_1480_23278_23313(), 0, f_1480_23318_23329(_data) - 1);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 23091, 23358);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 23382, 23520) || true) && (_serializeInput)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 23382, 23520);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 23451, 23497);

                            value = (T)(object)f_1480_23470_23496(this, value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 23382, 23520);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 23544, 23565);

                        _data[index] = value;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 22997, 23599);

                    object
                    f_1480_23039_23049()
                    {
                        var return_v = SyncObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 23039, 23049);
                        return return_v;
                    }


                    int
                    f_1480_23120_23131(System.Collections.Generic.IList<T>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 23120, 23131);
                        return return_v;
                    }


                    string
                    f_1480_23278_23313()
                    {
                        var return_v = PSDataBufferStrings.IndexOutOfRange;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 23278, 23313);
                        return return_v;
                    }


                    int
                    f_1480_23318_23329(System.Collections.Generic.IList<T>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 23318, 23329);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentOutOfRangeException
                    f_1480_23188_23334(string
                    paramName, int
                    actualValue, string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue, resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 23188, 23334);
                        return return_v;
                    }


                    System.Management.Automation.PSObject
                    f_1480_23470_23496(System.Management.Automation.PSDataCollection<T>
                    this_param, T
                    value)
                    {
                        var return_v = this_param.GetSerializedObject((object)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 23470, 23496);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 22997, 23599);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 22997, 23599);
                }
            }
        }

        public int IndexOf(T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 23958, 24114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 24015, 24025);
                lock (f_1480_24015_24025())
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 24059, 24088);

                    return f_1480_24066_24087(this, item);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 23958, 24114);

                object
                f_1480_24015_24025()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 24015, 24025);
                    return return_v;
                }


                int
                f_1480_24066_24087(System.Management.Automation.PSDataCollection<T>
                this_param, T
                item)
                {
                    var return_v = this_param.InternalIndexOf(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 24066, 24087);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 23958, 24114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 23958, 24114);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Insert(int index, T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 24881, 25110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 24949, 24959);
                lock (f_1480_24949_24959())
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 24993, 25037);

                    f_1480_24993_25036(this, Guid.Empty, index, item);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 25068, 25099);

                f_1480_25068_25098(this, Guid.Empty, index);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 24881, 25110);

                object
                f_1480_24949_24959()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 24949, 24959);
                    return return_v;
                }


                int
                f_1480_24993_25036(System.Management.Automation.PSDataCollection<T>
                this_param, System.Guid
                psInstanceId, int
                index, T
                item)
                {
                    this_param.InternalInsertItem(psInstanceId, index, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 24993, 25036);
                    return 0;
                }


                int
                f_1480_25068_25098(System.Management.Automation.PSDataCollection<T>
                this_param, System.Guid
                psInstanceId, int
                index)
                {
                    this_param.RaiseEvents(psInstanceId, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 25068, 25098);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 24881, 25110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 24881, 25110);
            }
        }

        public void RemoveAt(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 25477, 25898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 25539, 25549);
                lock (f_1480_25539_25549())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 25583, 25834) || true) && ((index < 0) || (DynAbs.Tracing.TraceSender.Expression_False(1480, 25587, 25624) || (index >= f_1480_25612_25623(_data))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 25583, 25834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 25666, 25815);

                        throw f_1480_25672_25814("index", index, f_1480_25758_25793(), 0, f_1480_25798_25809(_data) - 1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 25583, 25834);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 25854, 25872);

                    f_1480_25854_25871(this, index);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 25477, 25898);

                object
                f_1480_25539_25549()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 25539, 25549);
                    return return_v;
                }


                int
                f_1480_25612_25623(System.Collections.Generic.IList<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 25612, 25623);
                    return return_v;
                }


                string
                f_1480_25758_25793()
                {
                    var return_v = PSDataBufferStrings.IndexOutOfRange;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 25758, 25793);
                    return return_v;
                }


                int
                f_1480_25798_25809(System.Collections.Generic.IList<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 25798, 25809);
                    return return_v;
                }


                System.Management.Automation.PSArgumentOutOfRangeException
                f_1480_25672_25814(string
                paramName, int
                actualValue, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 25672, 25814);
                    return return_v;
                }


                int
                f_1480_25854_25871(System.Management.Automation.PSDataCollection<T>
                this_param, int
                index)
                {
                    this_param.RemoveItem(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 25854, 25871);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 25477, 25898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 25477, 25898);
            }
        }

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 26135, 26387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 26177, 26187);
                    lock (f_1480_26177_26187())
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 26229, 26353) || true) && (_data == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 26229, 26353);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 26273, 26282);

                            return 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 26229, 26353);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 26229, 26353);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 26334, 26353);

                            return f_1480_26341_26352(_data);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 26229, 26353);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 26135, 26387);

                    object
                    f_1480_26177_26187()
                    {
                        var return_v = SyncObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 26177, 26187);
                        return return_v;
                    }


                    int
                    f_1480_26341_26352(System.Collections.Generic.IList<T>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 26341, 26352);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 26094, 26398);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 26094, 26398);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 26574, 26638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 26610, 26623);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 26574, 26638);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 26527, 26649);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 26527, 26649);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void Add(T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 27079, 27168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 27127, 27157);

                f_1480_27127_27156(this, Guid.Empty, item);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 27079, 27168);

                int
                f_1480_27127_27156(System.Management.Automation.PSDataCollection<T>
                this_param, System.Guid
                psInstanceId, T
                item)
                {
                    this_param.InternalAdd(psInstanceId, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 27127, 27156);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 27079, 27168);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 27079, 27168);
            }
        }

        public void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 27275, 27487);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 27325, 27335);
                lock (f_1480_27325_27335())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 27369, 27461) || true) && (_data != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 27369, 27461);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 27428, 27442);

                        f_1480_27428_27441(_data);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 27369, 27461);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 27275, 27487);

                object
                f_1480_27325_27335()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 27325, 27335);
                    return return_v;
                }


                int
                f_1480_27428_27441(System.Collections.Generic.IList<T>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 27428, 27441);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 27275, 27487);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 27275, 27487);
            }
        }

        public bool Contains(T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 27863, 28164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 27922, 27932);
                lock (f_1480_27922_27932())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 27966, 28090) || true) && (_serializeInput)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 27966, 28090);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 28027, 28071);

                        item = (T)(object)f_1480_28045_28070(this, item);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 27966, 28090);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 28110, 28138);

                    return f_1480_28117_28137(_data, item);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 27863, 28164);

                object
                f_1480_27922_27932()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 27922, 27932);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1480_28045_28070(System.Management.Automation.PSDataCollection<T>
                this_param, T
                value)
                {
                    var return_v = this_param.GetSerializedObject((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 28045, 28070);
                    return return_v;
                }


                bool
                f_1480_28117_28137(System.Collections.Generic.IList<T>
                this_param, T
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 28117, 28137);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 27863, 28164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 27863, 28164);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 29333, 29511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 29409, 29419);
                lock (f_1480_29409_29419())
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 29453, 29485);

                    f_1480_29453_29484(_data, array, arrayIndex);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 29333, 29511);

                object
                f_1480_29409_29419()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 29409, 29419);
                    return return_v;
                }


                int
                f_1480_29453_29484(System.Collections.Generic.IList<T>
                this_param, T[]
                array, int
                arrayIndex)
                {
                    this_param.CopyTo(array, arrayIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 29453, 29484);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 29333, 29511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 29333, 29511);
            }
        }

        public bool Remove(T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 29888, 30222);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 29945, 29955);
                lock (f_1480_29945_29955())
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 29989, 30023);

                    int
                    index = f_1480_30001_30022(this, item)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 30041, 30128) || true) && (index < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 30041, 30128);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 30096, 30109);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 30041, 30128);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 30148, 30166);

                    f_1480_30148_30165(this, index);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 30184, 30196);

                    return true;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 29888, 30222);

                object
                f_1480_29945_29955()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 29945, 29955);
                    return return_v;
                }


                int
                f_1480_30001_30022(System.Management.Automation.PSDataCollection<T>
                this_param, T
                item)
                {
                    var return_v = this_param.InternalIndexOf(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 30001, 30022);
                    return return_v;
                }


                int
                f_1480_30148_30165(System.Management.Automation.PSDataCollection<T>
                this_param, int
                index)
                {
                    this_param.RemoveItem(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 30148, 30165);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 29888, 30222);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 29888, 30222);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerator<T> GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 30571, 30714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 30633, 30703);

                return f_1480_30640_30702(this, f_1480_30680_30701());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 30571, 30714);

                bool
                f_1480_30680_30701()
                {
                    var return_v = EnumeratorNeverBlocks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 30680, 30701);
                    return return_v;
                }


                System.Management.Automation.PSDataCollectionEnumerator<T>
                f_1480_30640_30702(System.Management.Automation.PSDataCollection<T>
                collection, bool
                neverBlock)
                {
                    var return_v = new System.Management.Automation.PSDataCollectionEnumerator<T>(collection, neverBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 30640, 30702);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 30571, 30714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 30571, 30714);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int IList.Add(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 31532, 31798);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 31584, 31627);

                f_1480_31584_31626(value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 31641, 31665);

                int
                index = f_1480_31653_31664(_data)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 31679, 31713);

                f_1480_31679_31712(this, Guid.Empty, value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 31727, 31758);

                f_1480_31727_31757(this, Guid.Empty, index);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 31774, 31787);

                return index;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 31532, 31798);

                int
                f_1480_31584_31626(object
                value)
                {
                    PSDataCollection<T>.VerifyValueType(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 31584, 31626);
                    return 0;
                }


                int
                f_1480_31653_31664(System.Collections.Generic.IList<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 31653, 31664);
                    return return_v;
                }


                int
                f_1480_31679_31712(System.Management.Automation.PSDataCollection<T>
                this_param, System.Guid
                psInstanceId, object
                item)
                {
                    this_param.InternalAdd(psInstanceId, (T)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 31679, 31712);
                    return 0;
                }


                int
                f_1480_31727_31757(System.Management.Automation.PSDataCollection<T>
                this_param, System.Guid
                psInstanceId, int
                index)
                {
                    this_param.RaiseEvents(psInstanceId, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 31727, 31757);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 31532, 31798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 31532, 31798);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool IList.Contains(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 32416, 32568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 32474, 32517);

                f_1480_32474_32516(value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 32531, 32557);

                return f_1480_32538_32556(this, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 32416, 32568);

                int
                f_1480_32474_32516(object
                value)
                {
                    PSDataCollection<T>.VerifyValueType(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 32474, 32516);
                    return 0;
                }


                bool
                f_1480_32538_32556(System.Management.Automation.PSDataCollection<T>
                this_param, object
                item)
                {
                    var return_v = this_param.Contains((T)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 32538, 32556);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 32416, 32568);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 32416, 32568);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int IList.IndexOf(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 33155, 33304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 33211, 33254);

                f_1480_33211_33253(value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 33268, 33293);

                return f_1480_33275_33292(this, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 33155, 33304);

                int
                f_1480_33211_33253(object
                value)
                {
                    PSDataCollection<T>.VerifyValueType(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 33211, 33253);
                    return 0;
                }


                int
                f_1480_33275_33292(System.Management.Automation.PSDataCollection<T>
                this_param, object
                item)
                {
                    var return_v = this_param.IndexOf((T)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 33275, 33292);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 33155, 33304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 33155, 33304);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        void IList.Insert(int index, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 34008, 34167);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 34075, 34118);

                f_1480_34075_34117(value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 34132, 34156);

                f_1480_34132_34155(this, index, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 34008, 34167);

                int
                f_1480_34075_34117(object
                value)
                {
                    PSDataCollection<T>.VerifyValueType(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 34075, 34117);
                    return 0;
                }


                int
                f_1480_34132_34155(System.Management.Automation.PSDataCollection<T>
                this_param, int
                index, object
                item)
                {
                    this_param.Insert(index, (T)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 34132, 34155);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 34008, 34167);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 34008, 34167);
            }
        }

        void IList.Remove(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 34649, 34790);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 34705, 34748);

                f_1480_34705_34747(value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 34762, 34779);

                f_1480_34762_34778(this, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 34649, 34790);

                int
                f_1480_34705_34747(object
                value)
                {
                    PSDataCollection<T>.VerifyValueType(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 34705, 34747);
                    return 0;
                }


                bool
                f_1480_34762_34778(System.Management.Automation.PSDataCollection<T>
                this_param, object
                item)
                {
                    var return_v = this_param.Remove((T)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 34762, 34778);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 34649, 34790);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 34649, 34790);
            }
        }

        bool IList.IsFixedSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 34974, 35038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 35010, 35023);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 34974, 35038);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 34927, 35049);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 34927, 35049);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IList.IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 35228, 35292);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 35264, 35277);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 35228, 35292);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 35182, 35303);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 35182, 35303);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        /// <summary>
        /// Gets or sets the element at the specified index.
        /// </summary>
        /// <param name="index">
        /// The zero-based index of the element to get or set.
        /// </param>
        /// <exception cref="IndexOutOfRangeException">
        /// index is less than 0.
        /// (or)
        /// index is equal to or greater than Count.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// value reference is null.
        /// (or)
        /// value is not of the correct generic type T for the buffer.
        /// </exception>
        object IList.this[int index]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 35991, 36061);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 36027, 36046);

                    return f_1480_36034_36045(this, index);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 35991, 36061);

                    T
                    f_1480_36034_36045(System.Management.Automation.PSDataCollection<T>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 36034, 36045);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 35991, 36061);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 35991, 36061);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 36077, 36212);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 36113, 36156);

                    f_1480_36113_36155(value);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 36174, 36197);

                    this[index] = (T)value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 36077, 36212);

                    int
                    f_1480_36113_36155(object
                    value)
                    {
                        PSDataCollection<T>.VerifyValueType(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 36113, 36155);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 36077, 36212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 36077, 36212);
                }
            }
        }

        bool ICollection.IsSynchronized
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 36478, 36541);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 36514, 36526);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 36478, 36541);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 36422, 36552);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 36422, 36552);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        object ICollection.SyncRoot
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 36746, 36815);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 36782, 36800);

                    return f_1480_36789_36799();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 36746, 36815);

                    object
                    f_1480_36789_36799()
                    {
                        var return_v = SyncObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 36789, 36799);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 36694, 36826);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 36694, 36826);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        void ICollection.CopyTo(Array array, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 37915, 38095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 37993, 38003);
                lock (f_1480_37993_38003())
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 38037, 38069);

                    f_1480_38037_38068(_data, array, index);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 37915, 38095);

                object
                f_1480_37993_38003()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 37993, 38003);
                    return return_v;
                }


                int
                f_1480_38037_38068(System.Collections.Generic.IList<T>
                this_param, System.Array
                array, int
                arrayIndex)
                {
                    this_param.CopyTo((T[])array, arrayIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 38037, 38068);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 37915, 38095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 37915, 38095);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 38407, 38552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 38471, 38541);

                return f_1480_38478_38540(this, f_1480_38518_38539());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 38407, 38552);

                bool
                f_1480_38518_38539()
                {
                    var return_v = EnumeratorNeverBlocks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 38518, 38539);
                    return return_v;
                }


                System.Management.Automation.PSDataCollectionEnumerator<T>
                f_1480_38478_38540(System.Management.Automation.PSDataCollection<T>
                collection, bool
                neverBlock)
                {
                    var return_v = new System.Management.Automation.PSDataCollectionEnumerator<T>(collection, neverBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 38478, 38540);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 38407, 38552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 38407, 38552);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Collection<T> ReadAll()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 39159, 39249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 39214, 39238);

                return f_1480_39221_39237(this, 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 39159, 39249);

                System.Collections.ObjectModel.Collection<T>
                f_1480_39221_39237(System.Management.Automation.PSDataCollection<T>
                this_param, int
                readCount)
                {
                    var return_v = this_param.ReadAndRemove(readCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 39221, 39237);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 39159, 39249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 39159, 39249);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<T> ReadAndRemove(int readCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 39877, 41336);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 39953, 40008);

                f_1480_39953_40007(_data != null, "Collection cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 40024, 40083);

                f_1480_40024_40082(readCount >= 0, "ReadCount cannot be negative");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 40099, 40168);

                int
                resolvedReadCount = ((DynAbs.Tracing.TraceSender.Conditional_F1(1480, 40124, 40137) || ((readCount > 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1480, 40140, 40149)) || DynAbs.Tracing.TraceSender.Conditional_F3(1480, 40152, 40166))) ? readCount : Int32.MaxValue)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 40190, 40200);

                lock (f_1480_40190_40200())
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 40325, 40368);

                    Collection<T>
                    result = f_1480_40348_40367()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 40397, 40402);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 40388, 40752) || true) && (i < resolvedReadCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 40427, 40430)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 40388, 40752))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 40388, 40752);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 40472, 40733) || true) && (f_1480_40476_40487(_data) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 40472, 40733);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 40541, 40562);

                                f_1480_40541_40561(result, f_1480_40552_40560(_data, 0));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 40588, 40606);

                                f_1480_40588_40605(_data, 0);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 40472, 40733);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 40472, 40733);
                                DynAbs.Tracing.TraceSender.TraceBreak(1480, 40704, 40710);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 40472, 40733);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1480, 1, 365);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1480, 1, 365);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 40772, 41276) || true) && (_readWaitHandle != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 40772, 41276);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 40841, 41257) || true) && (f_1480_40845_40856(_data) > 0 || (DynAbs.Tracing.TraceSender.Expression_False(1480, 40845, 40872) || !_isOpen))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 40841, 41257);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 40983, 41005);

                            f_1480_40983_41004(                        // release all the waiting threads.
                                                    _readWaitHandle);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 40841, 41257);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 40841, 41257);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 41210, 41234);

                            f_1480_41210_41233(                        // reset the handle so that future
                                                                       // threads will block
                                                    _readWaitHandle);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 40841, 41257);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 40772, 41276);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 41296, 41310);

                    return result;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 39877, 41336);

                int
                f_1480_39953_40007(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 39953, 40007);
                    return 0;
                }


                int
                f_1480_40024_40082(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 40024, 40082);
                    return 0;
                }


                object
                f_1480_40190_40200()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 40190, 40200);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<T>
                f_1480_40348_40367()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 40348, 40367);
                    return return_v;
                }


                int
                f_1480_40476_40487(System.Collections.Generic.IList<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 40476, 40487);
                    return return_v;
                }


                T
                f_1480_40552_40560(System.Collections.Generic.IList<T>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 40552, 40560);
                    return return_v;
                }


                int
                f_1480_40541_40561(System.Collections.ObjectModel.Collection<T>
                this_param, T
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 40541, 40561);
                    return 0;
                }


                int
                f_1480_40588_40605(System.Collections.Generic.IList<T>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 40588, 40605);
                    return 0;
                }


                int
                f_1480_40845_40856(System.Collections.Generic.IList<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 40845, 40856);
                    return return_v;
                }


                bool
                f_1480_40983_41004(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 40983, 41004);
                    return return_v;
                }


                bool
                f_1480_41210_41233(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Reset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 41210, 41233);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 39877, 41336);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 39877, 41336);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal T ReadAndRemoveAt0()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 41348, 41698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 41402, 41423);

                T
                value = default(T)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 41445, 41455);

                lock (f_1480_41445_41455())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 41489, 41643) || true) && (_data != null && (DynAbs.Tracing.TraceSender.Expression_True(1480, 41493, 41525) && f_1480_41510_41521(_data) > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 41489, 41643);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 41567, 41584);

                        value = f_1480_41575_41583(_data, 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 41606, 41624);

                        f_1480_41606_41623(_data, 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 41489, 41643);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 41674, 41687);

                return value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 41348, 41698);

                object
                f_1480_41445_41455()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 41445, 41455);
                    return return_v;
                }


                int
                f_1480_41510_41521(System.Collections.Generic.IList<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 41510, 41521);
                    return return_v;
                }


                T
                f_1480_41575_41583(System.Collections.Generic.IList<T>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 41575, 41583);
                    return return_v;
                }


                int
                f_1480_41606_41623(System.Collections.Generic.IList<T>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 41606, 41623);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 41348, 41698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 41348, 41698);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ps", Justification = "PS signifies PowerShell and is used at many places in the product.")]
        protected virtual void InsertItem(Guid psInstanceId, int index, T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 42509, 43024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 42802, 42843);

                f_1480_42802_42842(this, psInstanceId, item);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 42859, 42971) || true) && (_serializeInput)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 42859, 42971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 42912, 42956);

                    item = (T)(object)f_1480_42930_42955(this, item);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 42859, 42971);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 42987, 43013);

                f_1480_42987_43012(
                            _data, index, item);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 42509, 43024);

                int
                f_1480_42802_42842(System.Management.Automation.PSDataCollection<T>
                this_param, System.Guid
                psInstanceId, T
                itemAdded)
                {
                    this_param.RaiseDataAddingEvent(psInstanceId, (object)itemAdded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 42802, 42842);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1480_42930_42955(System.Management.Automation.PSDataCollection<T>
                this_param, T
                value)
                {
                    var return_v = this_param.GetSerializedObject((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 42930, 42955);
                    return return_v;
                }


                int
                f_1480_42987_43012(System.Collections.Generic.IList<T>
                this_param, int
                index, T
                item)
                {
                    this_param.Insert(index, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 42987, 43012);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 42509, 43024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 42509, 43024);
            }
        }

        protected virtual void RemoveItem(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 43475, 43577);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 43544, 43566);

                f_1480_43544_43565(_data, index);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 43475, 43577);

                int
                f_1480_43544_43565(System.Collections.Generic.IList<T>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 43544, 43565);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 43475, 43577);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 43475, 43577);
            }
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 43946, 44489);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 44054, 44172) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 44054, 44172);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 44104, 44157);

                    throw f_1480_44110_44156("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 44054, 44172);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 44188, 44217);

                f_1480_44188_44216(
                            info, "Data", _data);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 44231, 44288);

                f_1480_44231_44287(info, "BlockingEnumerator", _blockingEnumerator);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 44302, 44355);

                f_1480_44302_44354(info, "DataAddedCount", _dataAddedFrequency);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 44369, 44431);

                f_1480_44369_44430(info, "EnumeratorNeverBlocks", f_1480_44408_44429());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 44445, 44478);

                f_1480_44445_44477(info, "IsOpen", _isOpen);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 43946, 44489);

                System.Management.Automation.PSArgumentNullException
                f_1480_44110_44156(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 44110, 44156);
                    return return_v;
                }


                int
                f_1480_44188_44216(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, System.Collections.Generic.IList<T>
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 44188, 44216);
                    return 0;
                }


                int
                f_1480_44231_44287(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, bool
                value)
                {
                    this_param.AddValue(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 44231, 44287);
                    return 0;
                }


                int
                f_1480_44302_44354(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, int
                value)
                {
                    this_param.AddValue(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 44302, 44354);
                    return 0;
                }


                bool
                f_1480_44408_44429()
                {
                    var return_v = EnumeratorNeverBlocks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 44408, 44429);
                    return return_v;
                }


                int
                f_1480_44369_44430(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, bool
                value)
                {
                    this_param.AddValue(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 44369, 44430);
                    return 0;
                }


                int
                f_1480_44445_44477(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, bool
                value)
                {
                    this_param.AddValue(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 44445, 44477);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 43946, 44489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 43946, 44489);
            }
        }

        internal WaitHandle WaitHandle
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 44798, 45406);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 44834, 45348) || true) && (_readWaitHandle == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 44834, 45348);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 44909, 44919);
                        lock (f_1480_44909_44919())
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 44969, 45306) || true) && (_readWaitHandle == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 44969, 45306);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 45211, 45279);

                                _readWaitHandle = f_1480_45229_45278(f_1480_45250_45261(_data) > 0 || (DynAbs.Tracing.TraceSender.Expression_False(1480, 45250, 45277) || !_isOpen));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 44969, 45306);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 44834, 45348);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 45368, 45391);

                    return _readWaitHandle;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 44798, 45406);

                    object
                    f_1480_44909_44919()
                    {
                        var return_v = SyncObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 44909, 44919);
                        return return_v;
                    }


                    int
                    f_1480_45250_45261(System.Collections.Generic.IList<T>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 45250, 45261);
                        return return_v;
                    }


                    System.Threading.ManualResetEvent
                    f_1480_45229_45278(bool
                    initialState)
                    {
                        var return_v = new System.Threading.ManualResetEvent(initialState);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 45229, 45278);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 44743, 45417);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 44743, 45417);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void RaiseEvents(Guid psInstanceId, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 45890, 47669);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 45969, 45997);

                bool
                raiseDataAdded = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 46017, 46027);
                lock (f_1480_46017_46027())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 46061, 46639) || true) && (_readWaitHandle != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 46061, 46639);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 46204, 46620) || true) && (f_1480_46208_46219(_data) > 0 || (DynAbs.Tracing.TraceSender.Expression_False(1480, 46208, 46235) || !_isOpen))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 46204, 46620);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 46346, 46368);

                            f_1480_46346_46367(                        // release all the waiting threads.
                                                    _readWaitHandle);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 46204, 46620);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 46204, 46620);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 46573, 46597);

                            f_1480_46573_46596(                        // reset the handle so that future
                                                                       // threads will block
                                                    _readWaitHandle);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 46204, 46620);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 46061, 46639);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 46775, 46804);

                    f_1480_46775_46803(f_1480_46792_46802());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 46824, 46840);

                    _countNewData++;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 46858, 47392) || true) && (_countNewData >= _dataAddedFrequency || (DynAbs.Tracing.TraceSender.Expression_False(1480, 46862, 46933) || (_countNewData > 0 && (DynAbs.Tracing.TraceSender.Expression_True(1480, 46903, 46932) && !_isOpen))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 46858, 47392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 46975, 46997);

                        raiseDataAdded = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 47019, 47037);

                        _countNewData = 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 46858, 47392);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 46858, 47392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 47299, 47332);

                        _lastPsInstanceId = psInstanceId;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 47354, 47373);

                        _lastIndex = index;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 46858, 47392);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 47423, 47658) || true) && (raiseDataAdded)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 47423, 47658);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 47602, 47643);

                    f_1480_47602_47642(this, psInstanceId, index);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 47423, 47658);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 45890, 47669);

                object
                f_1480_46017_46027()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 46017, 46027);
                    return return_v;
                }


                int
                f_1480_46208_46219(System.Collections.Generic.IList<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 46208, 46219);
                    return return_v;
                }


                bool
                f_1480_46346_46367(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 46346, 46367);
                    return return_v;
                }


                bool
                f_1480_46573_46596(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Reset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 46573, 46596);
                    return return_v;
                }


                object
                f_1480_46792_46802()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 46792, 46802);
                    return return_v;
                }


                int
                f_1480_46775_46803(object
                obj)
                {
                    Monitor.PulseAll(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 46775, 46803);
                    return 0;
                }


                int
                f_1480_47602_47642(System.Management.Automation.PSDataCollection<T>
                this_param, System.Guid
                psInstanceId, int
                index)
                {
                    this_param.RaiseDataAddedEvent(psInstanceId, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 47602, 47642);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 45890, 47669);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 45890, 47669);
            }
        }

        private Guid _lastPsInstanceId;

        private int _lastIndex;

        private void RaiseDataAddingEvent(Guid psInstanceId, object itemAdded)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 47757, 48218);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 47985, 48047);

                EventHandler<DataAddingEventArgs>
                tempDataAdding = DataAdding
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 48061, 48207) || true) && (tempDataAdding != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 48061, 48207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 48121, 48192);

                    f_1480_48121_48191(tempDataAdding, this, f_1480_48142_48190(psInstanceId, itemAdded));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 48061, 48207);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 47757, 48218);

                System.Management.Automation.DataAddingEventArgs
                f_1480_48142_48190(System.Guid
                psInstanceId, object
                itemAdded)
                {
                    var return_v = new System.Management.Automation.DataAddingEventArgs(psInstanceId, itemAdded);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 48142, 48190);
                    return return_v;
                }


                int
                f_1480_48121_48191(System.EventHandler<System.Management.Automation.DataAddingEventArgs>
                this_param, System.Management.Automation.PSDataCollection<T>
                sender, System.Management.Automation.DataAddingEventArgs
                e)
                {
                    this_param.Invoke((object)sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 48121, 48191);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 47757, 48218);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 47757, 48218);
            }
        }

        private void RaiseDataAddedEvent(Guid psInstanceId, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 48230, 48672);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 48449, 48508);

                EventHandler<DataAddedEventArgs>
                tempDataAdded = DataAdded
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 48522, 48661) || true) && (tempDataAdded != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 48522, 48661);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 48581, 48646);

                    f_1480_48581_48645(tempDataAdded, this, f_1480_48601_48644(psInstanceId, index));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 48522, 48661);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 48230, 48672);

                System.Management.Automation.DataAddedEventArgs
                f_1480_48601_48644(System.Guid
                psInstanceId, int
                index)
                {
                    var return_v = new System.Management.Automation.DataAddedEventArgs(psInstanceId, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 48601, 48644);
                    return return_v;
                }


                int
                f_1480_48581_48645(System.EventHandler<System.Management.Automation.DataAddedEventArgs>
                this_param, System.Management.Automation.PSDataCollection<T>
                sender, System.Management.Automation.DataAddedEventArgs
                e)
                {
                    this_param.Invoke((object)sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 48581, 48645);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 48230, 48672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 48230, 48672);
            }
        }

        private void InternalInsertItem(Guid psInstanceId, int index, T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 49763, 50073);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 49857, 50008) || true) && (!_isOpen)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 49857, 50008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 49903, 49993);

                    throw f_1480_49909_49992(f_1480_49952_49991());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 49857, 50008);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 50024, 50062);

                f_1480_50024_50061(this, psInstanceId, index, item);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 49763, 50073);

                string
                f_1480_49952_49991()
                {
                    var return_v = PSDataBufferStrings.WriteToClosedBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 49952, 49991);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1480_49909_49992(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 49909, 49992);
                    return return_v;
                }


                int
                f_1480_50024_50061(System.Management.Automation.PSDataCollection<T>
                this_param, System.Guid
                psInstanceId, int
                index, T
                item)
                {
                    this_param.InsertItem(psInstanceId, index, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 50024, 50061);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 49763, 50073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 49763, 50073);
            }
        }

        internal void InternalAdd(Guid psInstanceId, T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 50706, 51334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 50891, 50906);

                int
                index = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 50928, 50938);

                lock (f_1480_50928_50938())
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 51112, 51132);

                    index = f_1480_51120_51131(_data);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 51150, 51196);

                    f_1480_51150_51195(this, psInstanceId, index, item);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 51227, 51323) || true) && (index > -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 51227, 51323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 51275, 51308);

                    f_1480_51275_51307(this, psInstanceId, index);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 51227, 51323);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 50706, 51334);

                object
                f_1480_50928_50938()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 50928, 50938);
                    return return_v;
                }


                int
                f_1480_51120_51131(System.Collections.Generic.IList<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 51120, 51131);
                    return return_v;
                }


                int
                f_1480_51150_51195(System.Management.Automation.PSDataCollection<T>
                this_param, System.Guid
                psInstanceId, int
                index, T
                item)
                {
                    this_param.InternalInsertItem(psInstanceId, index, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 51150, 51195);
                    return 0;
                }


                int
                f_1480_51275_51307(System.Management.Automation.PSDataCollection<T>
                this_param, System.Guid
                psInstanceId, int
                index)
                {
                    this_param.RaiseEvents(psInstanceId, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 51275, 51307);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 50706, 51334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 50706, 51334);
            }
        }

        internal void InternalAddRange(Guid psInstanceId, ICollection collection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 52036, 53036);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 52134, 52264) || true) && (collection == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 52134, 52264);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 52190, 52249);

                    throw f_1480_52196_52248("collection");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 52134, 52264);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 52280, 52295);

                int
                index = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 52309, 52334);

                bool
                raiseEvents = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 52356, 52366);

                lock (f_1480_52356_52366())
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 52400, 52563) || true) && (!_isOpen)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 52400, 52563);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 52454, 52544);

                        throw f_1480_52460_52543(f_1480_52503_52542());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 52400, 52563);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 52583, 52603);

                    index = f_1480_52591_52602(_data);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 52623, 52897);
                        foreach (object o in f_1480_52644_52654_I(collection))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 52623, 52897);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 52696, 52740);

                            f_1480_52696_52739(this, psInstanceId, f_1480_52721_52732(_data), o);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 52859, 52878);

                            raiseEvents = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 52623, 52897);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1480, 1, 275);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1480, 1, 275);
                    }
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 52928, 53025) || true) && (raiseEvents)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 52928, 53025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 52977, 53010);

                    f_1480_52977_53009(this, psInstanceId, index);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 52928, 53025);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 52036, 53036);

                System.Management.Automation.PSArgumentNullException
                f_1480_52196_52248(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 52196, 52248);
                    return return_v;
                }


                object
                f_1480_52356_52366()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 52356, 52366);
                    return return_v;
                }


                string
                f_1480_52503_52542()
                {
                    var return_v = PSDataBufferStrings.WriteToClosedBuffer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 52503, 52542);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1480_52460_52543(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 52460, 52543);
                    return return_v;
                }


                int
                f_1480_52591_52602(System.Collections.Generic.IList<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 52591, 52602);
                    return return_v;
                }


                int
                f_1480_52721_52732(System.Collections.Generic.IList<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 52721, 52732);
                    return return_v;
                }


                int
                f_1480_52696_52739(System.Management.Automation.PSDataCollection<T>
                this_param, System.Guid
                psInstanceId, int
                index, object
                item)
                {
                    this_param.InsertItem(psInstanceId, index, (T)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 52696, 52739);
                    return 0;
                }


                System.Collections.ICollection
                f_1480_52644_52654_I(System.Collections.ICollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 52644, 52654);
                    return return_v;
                }


                int
                f_1480_52977_53009(System.Management.Automation.PSDataCollection<T>
                this_param, System.Guid
                psInstanceId, int
                index)
                {
                    this_param.RaiseEvents(psInstanceId, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 52977, 53009);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 52036, 53036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 52036, 53036);
            }
        }

        internal void AddRef()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 53233, 53368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 53286, 53296);
                lock (f_1480_53286_53296())
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 53330, 53342);

                    _refCount++;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 53233, 53368);

                object
                f_1480_53286_53296()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 53286, 53296);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 53233, 53368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 53233, 53368);
            }
        }

        internal void DecrementRef()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 53565, 54301);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 53624, 53634);
                lock (f_1480_53624_53634())
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 53668, 53721);

                    f_1480_53668_53720(_refCount > 0, "RefCount cannot be <= 0");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 53741, 53753);

                    _refCount--;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 53771, 53842) || true) && (_refCount != 0 && (DynAbs.Tracing.TraceSender.Expression_True(1480, 53775, 53833) && (!_blockingEnumerator || (DynAbs.Tracing.TraceSender.Expression_False(1480, 53794, 53832) || _refCount != 1))))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 53771, 53842);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 53835, 53842);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 53771, 53842);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 53920, 54030) || true) && (_readWaitHandle != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 53920, 54030);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 53989, 54011);

                        f_1480_53989_54010(_readWaitHandle);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 53920, 54030);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 54246, 54275);

                    f_1480_54246_54274(f_1480_54263_54273());
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 53565, 54301);

                object
                f_1480_53624_53634()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 53624, 53634);
                    return return_v;
                }


                int
                f_1480_53668_53720(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 53668, 53720);
                    return 0;
                }


                bool
                f_1480_53989_54010(System.Threading.ManualResetEvent
                this_param)
                {
                    var return_v = this_param.Set();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 53989, 54010);
                    return return_v;
                }


                object
                f_1480_54263_54273()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 54263, 54273);
                    return return_v;
                }


                int
                f_1480_54246_54274(object
                obj)
                {
                    Monitor.PulseAll(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 54246, 54274);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 53565, 54301);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 53565, 54301);
            }
        }

        private int InternalIndexOf(T item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 54734, 55199);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 54794, 54906) || true) && (_serializeInput)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 54794, 54906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 54847, 54891);

                    item = (T)(object)f_1480_54865_54890(this, item);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 54794, 54906);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 54922, 54946);

                int
                count = f_1480_54934_54945(_data)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 54969, 54978);
                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 54960, 55162) || true) && (index < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 54995, 55002)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 54960, 55162))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 54960, 55162);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 55036, 55147) || true) && (f_1480_55040_55073(f_1480_55054_55066(_data, index), item))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 55036, 55147);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 55115, 55128);

                            return index;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 55036, 55147);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1480, 1, 203);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1480, 1, 203);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 55178, 55188);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 54734, 55199);

                System.Management.Automation.PSObject
                f_1480_54865_54890(System.Management.Automation.PSDataCollection<T>
                this_param, T
                value)
                {
                    var return_v = this_param.GetSerializedObject((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 54865, 54890);
                    return return_v;
                }


                int
                f_1480_54934_54945(System.Collections.Generic.IList<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 54934, 54945);
                    return return_v;
                }


                T
                f_1480_55054_55066(System.Collections.Generic.IList<T>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 55054, 55066);
                    return return_v;
                }


                bool
                f_1480_55040_55073(T
                objA, T
                objB)
                {
                    var return_v = object.Equals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 55040, 55073);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 54734, 55199);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 54734, 55199);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void VerifyValueType(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1480, 55614, 56290);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 55688, 56279) || true) && (value == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 55688, 56279);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 55739, 55919) || true) && (f_1480_55743_55764(typeof(T)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 55739, 55919);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 55806, 55900);

                        throw f_1480_55812_55899("value", f_1480_55860_55898());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 55739, 55919);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 55688, 56279);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 55688, 56279);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 55953, 56279) || true) && (!(value is T))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 55953, 56279);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 56004, 56264);

                        throw f_1480_56010_56263("value", f_1480_56054_56100(), f_1480_56160_56184(f_1480_56160_56175(value)), f_1480_56244_56262(typeof(T)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 55953, 56279);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 55688, 56279);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1480, 55614, 56290);

                bool
                f_1480_55743_55764(System.Type
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 55743, 55764);
                    return return_v;
                }


                string
                f_1480_55860_55898()
                {
                    var return_v = PSDataBufferStrings.ValueNullReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 55860, 55898);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1480_55812_55899(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 55812, 55899);
                    return return_v;
                }


                string
                f_1480_56054_56100()
                {
                    var return_v = PSDataBufferStrings.CannotConvertToGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 56054, 56100);
                    return return_v;
                }


                System.Type
                f_1480_56160_56175(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 56160, 56175);
                    return return_v;
                }


                string
                f_1480_56160_56184(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 56160, 56184);
                    return return_v;
                }


                string
                f_1480_56244_56262(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 56244, 56262);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1480_56010_56263(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 56010, 56263);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 55614, 56290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 55614, 56290);
            }
        }

        private PSObject GetSerializedObject(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 56368, 57228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 56619, 56655);

                PSObject
                result = value as PSObject
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 56730, 57217) || true) && (f_1480_56734_56772(this, result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 56730, 57217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 56806, 56820);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 56730, 57217);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 56730, 57217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 56886, 56964);

                    object
                    deserialized = f_1480_56908_56963(f_1480_56933_56962(value))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 56982, 57202) || true) && (deserialized == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 56982, 57202);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 57048, 57060);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 56982, 57202);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 56982, 57202);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 57142, 57183);

                        return f_1480_57149_57182(deserialized);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 56982, 57202);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 56730, 57217);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 56368, 57228);

                bool
                f_1480_56734_56772(System.Management.Automation.PSDataCollection<T>
                this_param, System.Management.Automation.PSObject
                result)
                {
                    var return_v = this_param.SerializationWouldHaveNoEffect(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 56734, 56772);
                    return return_v;
                }


                string
                f_1480_56933_56962(object
                source)
                {
                    var return_v = PSSerializer.Serialize(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 56933, 56962);
                    return return_v;
                }


                object
                f_1480_56908_56963(string
                source)
                {
                    var return_v = PSSerializer.Deserialize(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 56908, 56963);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1480_57149_57182(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 57149, 57182);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 56368, 57228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 56368, 57228);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool SerializationWouldHaveNoEffect(PSObject result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 57240, 58206);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 57325, 57404) || true) && (result == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 57325, 57404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 57377, 57389);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 57325, 57404);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 57420, 57462);

                object
                baseObject = f_1480_57440_57461(result)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 57476, 57559) || true) && (baseObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 57476, 57559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 57532, 57544);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 57476, 57559);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 57628, 57754) || true) && (f_1480_57632_57693(f_1480_57672_57692(baseObject)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 57628, 57754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 57727, 57739);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 57628, 57754);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 57811, 57937) || true) && (baseObject is Microsoft.Management.Infrastructure.CimInstance)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 57811, 57937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 57910, 57922);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 57811, 57937);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 58019, 58166) || true) && (f_1480_58023_58105(f_1480_58023_58042(f_1480_58023_58039(result), 0), "Deserialized", StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 58019, 58166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 58139, 58151);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 58019, 58166);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 58182, 58195);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 57240, 58206);

                object
                f_1480_57440_57461(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = PSObject.Base((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 57440, 57461);
                    return return_v;
                }


                System.Type
                f_1480_57672_57692(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 57672, 57692);
                    return return_v;
                }


                bool
                f_1480_57632_57693(System.Type
                input)
                {
                    var return_v = InternalSerializer.IsPrimitiveKnownType(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 57632, 57693);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1480_58023_58039(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 58023, 58039);
                    return return_v;
                }


                string
                f_1480_58023_58042(System.Collections.ObjectModel.Collection<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 58023, 58042);
                    return return_v;
                }


                bool
                f_1480_58023_58105(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 58023, 58105);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 57240, 58206);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 57240, 58206);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object SyncObject { get; }

        internal int RefCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 58506, 58574);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 58542, 58559);

                    return _refCount;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 58506, 58574);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 58460, 58747);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 58460, 58747);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 58590, 58736);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 58632, 58642);
                    lock (f_1480_58632_58642())
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 58684, 58702);

                        _refCount = value;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 58590, 58736);

                    object
                    f_1480_58632_58642()
                    {
                        var return_v = SyncObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 58632, 58642);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 58460, 58747);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 58460, 58747);
                }
            }
        }

        internal bool PulseIdleEvent
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 58990, 59025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 58996, 59023);

                    return (IdleEvent != null);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 58990, 59025);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 58937, 59036);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 58937, 59036);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal event EventHandler<EventArgs>
IdleEvent
;

        internal void FireIdleEvent()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 59190, 59288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 59244, 59277);

                f_1480_59244_59276(IdleEvent, this, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 59190, 59288);

                int
                f_1480_59244_59276(System.EventHandler<System.EventArgs>
                eventHandler, System.Management.Automation.PSDataCollection<T>
                sender, System.EventArgs
                eventArgs)
                {
                    eventHandler.SafeInvoke<System.EventArgs>((object)sender, eventArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 59244, 59276);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 59190, 59288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 59190, 59288);
            }
        }

        internal void Pulse()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 59383, 59534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 59435, 59445);
                lock (f_1480_59435_59445())
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 59479, 59508);

                    f_1480_59479_59507(f_1480_59496_59506());
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 59383, 59534);

                object
                f_1480_59435_59445()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 59435, 59445);
                    return return_v;
                }


                object
                f_1480_59496_59506()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 59496, 59506);
                    return return_v;
                }


                int
                f_1480_59479_59507(object
                obj)
                {
                    Monitor.PulseAll(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 59479, 59507);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 59383, 59534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 59383, 59534);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 59692, 59805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 59738, 59752);

                f_1480_59738_59751(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 59768, 59794);

                f_1480_59768_59793(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 59692, 59805);

                int
                f_1480_59738_59751(System.Management.Automation.PSDataCollection<T>
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 59738, 59751);
                    return 0;
                }


                int
                f_1480_59768_59793(System.Management.Automation.PSDataCollection<T>
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 59768, 59793);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 59692, 59805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 59692, 59805);
            }
        }

        protected void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 59989, 60874);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 60052, 60863) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 60052, 60863);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 60099, 60182) || true) && (_isDisposed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 60099, 60182);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 60156, 60163);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 60099, 60182);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 60208, 60218);

                    lock (f_1480_60208_60218())
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 60260, 60355) || true) && (_isDisposed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 60260, 60355);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 60325, 60332);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 60260, 60355);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 60379, 60398);

                        _isDisposed = true;
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 60437, 60448);

                    f_1480_60437_60447(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 60474, 60484);

                    lock (f_1480_60474_60484())
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 60526, 60701) || true) && (_readWaitHandle != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 60526, 60701);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 60603, 60629);

                            f_1480_60603_60628(_readWaitHandle);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 60655, 60678);

                            _readWaitHandle = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 60526, 60701);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 60725, 60829) || true) && (_data != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 60725, 60829);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 60792, 60806);

                            f_1480_60792_60805(_data);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 60725, 60829);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 60052, 60863);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 59989, 60874);

                object
                f_1480_60208_60218()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 60208, 60218);
                    return return_v;
                }


                int
                f_1480_60437_60447(System.Management.Automation.PSDataCollection<T>
                this_param)
                {
                    this_param.Complete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 60437, 60447);
                    return 0;
                }


                object
                f_1480_60474_60484()
                {
                    var return_v = SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 60474, 60484);
                    return return_v;
                }


                int
                f_1480_60603_60628(System.Threading.ManualResetEvent
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 60603, 60628);
                    return 0;
                }


                int
                f_1480_60792_60805(System.Collections.Generic.IList<T>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 60792, 60805);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 59989, 60874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 59989, 60874);
            }
        }

        static PSDataCollection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1480, 3215, 60923);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1480, 3215, 60923);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 3215, 60923);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1480, 3215, 60923);

        static System.Collections.Generic.List<T>
        f_1480_4517_4530()
        {
            // LAFHIS
            DynAbs.Tracing.TraceSender.TraceBaseCall(1480, 4484, 4553);

            var return_v = new System.Collections.Generic.List<T>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 4517, 4530);
            return return_v;
        }


        static System.Collections.Generic.IList<T>
        f_1480_4517_4530_C(System.Collections.Generic.IList<T>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1480, 4484, 4553);
            return return_v;
        }


        static System.Collections.Generic.List<T>
        f_1480_5244_5262(System.Collections.Generic.IEnumerable<T>
        collection)
        {
            var return_v = new System.Collections.Generic.List<T>(collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 5244, 5262);
            return return_v;
        }


        int
        f_1480_5288_5303(System.Management.Automation.PSDataCollection<T>
        this_param)
        {
            this_param.Complete();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 5288, 5303);
            return 0;
        }


        static System.Collections.Generic.IList<T>
        f_1480_5244_5262_C(System.Collections.Generic.IList<T>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1480, 5191, 5315);
            return return_v;
        }


        static System.Collections.Generic.List<T>
        f_1480_5850_5871(int
        capacity)
        {
            var return_v = new System.Collections.Generic.List<T>(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 5850, 5871);
            return return_v;
        }


        static System.Collections.Generic.IList<T>
        f_1480_5850_5871_C(System.Collections.Generic.IList<T>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1480, 5805, 5894);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1480_12574_12620(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 12574, 12620);
            return return_v;
        }


        object?
        f_1480_12673_12712(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name, System.Type
        type)
        {
            var return_v = this_param.GetValue(name, type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 12673, 12712);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1480_12802_12848(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 12802, 12848);
            return return_v;
        }


        bool
        f_1480_12936_12973(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetBoolean(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 12936, 12973);
            return return_v;
        }


        int
        f_1480_13010_13041(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetInt32(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 13010, 13041);
            return return_v;
        }


        bool
        f_1480_13080_13120(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetBoolean(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 13080, 13120);
            return return_v;
        }


        bool
        f_1480_13145_13170(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetBoolean(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 13145, 13170);
            return return_v;
        }


        object
        f_1480_58349_58361()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 58349, 58361);
            return return_v;
        }

    }


    /// <summary>
    /// Interface to support PSDataCollectionEnumerator.
    /// Needed to provide a way to get to the non-blocking
    /// MoveNext implementation.
    /// </summary>
    /// <typeparam name="W"></typeparam>
    internal interface IBlockingEnumerator<out W> : IEnumerator<W>
    {

        bool MoveNext(bool block);
    }
    internal sealed class PSDataCollectionEnumerator<W> : IBlockingEnumerator<W>
    {
        private W _currentElement;

        private int _index;

        private PSDataCollection<W> _collToEnumerate;

        private bool _neverBlock;

        internal PSDataCollectionEnumerator(PSDataCollection<W> collection, bool neverBlock)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1480, 62245, 62820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 61735, 61750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 61773, 61779);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 61818, 61834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 61858, 61869);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 62354, 62431);

                f_1480_62354_62430(collection != null, "Collection cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 62445, 62605);

                f_1480_62445_62604(f_1480_62456_62488_M(!collection.ReleaseOnEnumeration) || (DynAbs.Tracing.TraceSender.Expression_False(1480, 62456, 62516) || f_1480_62492_62516_M(!collection.IsEnumerated)), "shouldn't enumerate more than once if ReleaseOnEnumeration is true");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 62621, 62651);

                _collToEnumerate = collection;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 62665, 62676);

                _index = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 62690, 62719);

                _currentElement = default(W);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 62733, 62770);

                _collToEnumerate.IsEnumerated = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 62784, 62809);

                _neverBlock = neverBlock;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1480, 62245, 62820);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 62245, 62820);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 62245, 62820);
            }
        }

        W IEnumerator<W>.Current
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 63371, 63445);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 63407, 63430);

                    return _currentElement;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 63371, 63445);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 63322, 63456);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 63322, 63456);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public object Current
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 63941, 64015);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 63977, 64000);

                    return _currentElement;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 63941, 64015);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 63895, 64026);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 63895, 64026);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool MoveNext()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 64537, 64633);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 64584, 64622);

                return f_1480_64591_64621(this, _neverBlock == false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 64537, 64633);

                bool
                f_1480_64591_64621(System.Management.Automation.PSDataCollectionEnumerator<W>
                this_param, bool
                block)
                {
                    var return_v = this_param.MoveNext(block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 64591, 64621);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 64537, 64633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 64537, 64633);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool MoveNext(bool block)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 65014, 66771);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 65077, 65104);
                lock (f_1480_65077_65104(_collToEnumerate))
                {
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 65138, 66745);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 65181, 65597) || true) && (_index < f_1480_65194_65216(_collToEnumerate))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 65181, 65597);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 65266, 65309);

                                    _currentElement = f_1480_65284_65308(_collToEnumerate, _index);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 65335, 65499) || true) && (f_1480_65339_65376(_collToEnumerate))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 65335, 65499);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 65434, 65472);

                                        _collToEnumerate[_index] = default(W);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 65335, 65499);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 65527, 65536);

                                    _index++;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 65562, 65574);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 65181, 65597);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 65783, 65935) || true) && ((0 == f_1480_65793_65818(_collToEnumerate)) || (DynAbs.Tracing.TraceSender.Expression_False(1480, 65787, 65849) || (f_1480_65824_65848_M(!_collToEnumerate.IsOpen))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 65783, 65935);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 65899, 65912);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 65783, 65935);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 65959, 66712) || true) && (block)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 65959, 66712);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 66018, 66578) || true) && (f_1480_66022_66053(_collToEnumerate))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 66018, 66578);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 66111, 66144);

                                        f_1480_66111_66143(_collToEnumerate);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 66174, 66216);

                                        f_1480_66174_66215(f_1480_66187_66214(_collToEnumerate));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 66018, 66578);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 66018, 66578);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 66509, 66551);

                                        f_1480_66509_66550(f_1480_66522_66549(_collToEnumerate));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 66018, 66578);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 65959, 66712);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 65959, 66712);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 66676, 66689);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 65959, 66712);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 65138, 66745);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 65138, 66745) || true) && (true)
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1480, 65138, 66745);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1480, 65138, 66745);
                        }
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 65014, 66771);

                object
                f_1480_65077_65104(System.Management.Automation.PSDataCollection<W>
                this_param)
                {
                    var return_v = this_param.SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 65077, 65104);
                    return return_v;
                }


                int
                f_1480_65194_65216(System.Management.Automation.PSDataCollection<W>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 65194, 65216);
                    return return_v;
                }


                W
                f_1480_65284_65308(System.Management.Automation.PSDataCollection<W>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 65284, 65308);
                    return return_v;
                }


                bool
                f_1480_65339_65376(System.Management.Automation.PSDataCollection<W>
                this_param)
                {
                    var return_v = this_param.ReleaseOnEnumeration;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 65339, 65376);
                    return return_v;
                }


                int
                f_1480_65793_65818(System.Management.Automation.PSDataCollection<W>
                this_param)
                {
                    var return_v = this_param.RefCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 65793, 65818);
                    return return_v;
                }


                bool
                f_1480_65824_65848_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 65824, 65848);
                    return return_v;
                }


                bool
                f_1480_66022_66053(System.Management.Automation.PSDataCollection<W>
                this_param)
                {
                    var return_v = this_param.PulseIdleEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 66022, 66053);
                    return return_v;
                }


                int
                f_1480_66111_66143(System.Management.Automation.PSDataCollection<W>
                this_param)
                {
                    this_param.FireIdleEvent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 66111, 66143);
                    return 0;
                }


                object
                f_1480_66187_66214(System.Management.Automation.PSDataCollection<W>
                this_param)
                {
                    var return_v = this_param.SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 66187, 66214);
                    return return_v;
                }


                bool
                f_1480_66174_66215(object
                obj)
                {
                    var return_v = Monitor.Wait(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 66174, 66215);
                    return return_v;
                }


                object
                f_1480_66522_66549(System.Management.Automation.PSDataCollection<W>
                this_param)
                {
                    var return_v = this_param.SyncObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 66522, 66549);
                    return return_v;
                }


                bool
                f_1480_66509_66550(object
                obj)
                {
                    var return_v = Monitor.Wait(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 66509, 66550);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 65014, 66771);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 65014, 66771);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Reset()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 66956, 67065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 67000, 67029);

                _currentElement = default(W);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 67043, 67054);

                _index = 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 66956, 67065);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 66956, 67065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 66956, 67065);
            }
        }

        void IDisposable.Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 67124, 67172);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 67124, 67172);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 67124, 67172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 67124, 67172);
            }
        }

        static PSDataCollectionEnumerator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1480, 61600, 67201);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1480, 61600, 67201);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 61600, 67201);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1480, 61600, 67201);

        int
        f_1480_62354_62430(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 62354, 62430);
            return 0;
        }


        bool
        f_1480_62456_62488_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 62456, 62488);
            return return_v;
        }


        bool
        f_1480_62492_62516_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 62492, 62516);
            return return_v;
        }


        int
        f_1480_62445_62604(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 62445, 62604);
            return 0;
        }

    }
    internal sealed class PSInformationalBuffers
    {
        private Guid _psInstanceId;

        internal PSInformationalBuffers(Guid psInstanceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1480, 67899, 68449);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 68926, 68934);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 69350, 69357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 69761, 69766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 69939, 70001);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 70177, 70247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 67974, 68077);

                f_1480_67974_68076(psInstanceId != Guid.Empty, "PowerShell instance id cannot be Guid.Empty");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 68093, 68122);

                _psInstanceId = psInstanceId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 68136, 68186);

                progress = f_1480_68147_68185();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 68200, 68248);

                verbose = f_1480_68210_68247();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 68262, 68306);

                debug = f_1480_68270_68305();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 68320, 68368);

                Warning = f_1480_68330_68367();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 68382, 68438);

                Information = f_1480_68396_68437();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1480, 67899, 68449);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 67899, 68449);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 67899, 68449);
            }
        }

        internal PSDataCollection<ProgressRecord> Progress
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 68753, 68777);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 68759, 68775);

                    return progress;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 68753, 68777);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 68678, 68872);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 68678, 68872);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 68793, 68861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 68829, 68846);

                    progress = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 68793, 68861);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 68678, 68872);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 68678, 68872);
                }
            }
        }

        internal PSDataCollection<ProgressRecord> progress;

        internal PSDataCollection<VerboseRecord> Verbose
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 69180, 69203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 69186, 69201);

                    return verbose;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 69180, 69203);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 69107, 69297);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 69107, 69297);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 69219, 69286);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 69255, 69271);

                    verbose = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 69219, 69286);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 69107, 69297);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 69107, 69297);
                }
            }
        }

        internal PSDataCollection<VerboseRecord> verbose;

        internal PSDataCollection<DebugRecord> Debug
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 69597, 69618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 69603, 69616);

                    return debug;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 69597, 69618);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 69528, 69710);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 69528, 69710);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 69634, 69699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 69670, 69684);

                    debug = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 69634, 69699);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 69528, 69710);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 69528, 69710);
                }
            }
        }

        internal PSDataCollection<DebugRecord> debug;

        internal PSDataCollection<WarningRecord> Warning { get; set; }

        internal PSDataCollection<InformationRecord> Information { get; set; }

        internal void AddProgress(ProgressRecord item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 70473, 70666);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 70544, 70655) || true) && (progress != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 70544, 70655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 70598, 70640);

                    f_1480_70598_70639(progress, _psInstanceId, item);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 70544, 70655);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 70473, 70666);

                int
                f_1480_70598_70639(System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
                this_param, System.Guid
                psInstanceId, System.Management.Automation.ProgressRecord
                item)
                {
                    this_param.InternalAdd(psInstanceId, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 70598, 70639);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 70473, 70666);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 70473, 70666);
            }
        }

        internal void AddVerbose(VerboseRecord item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 70891, 71080);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 70960, 71069) || true) && (verbose != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 70960, 71069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 71013, 71054);

                    f_1480_71013_71053(verbose, _psInstanceId, item);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 70960, 71069);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 70891, 71080);

                int
                f_1480_71013_71053(System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
                this_param, System.Guid
                psInstanceId, System.Management.Automation.VerboseRecord
                item)
                {
                    this_param.InternalAdd(psInstanceId, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 71013, 71053);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 70891, 71080);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 70891, 71080);
            }
        }

        internal void AddDebug(DebugRecord item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 71303, 71484);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 71368, 71473) || true) && (debug != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 71368, 71473);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 71419, 71458);

                    f_1480_71419_71457(debug, _psInstanceId, item);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 71368, 71473);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 71303, 71484);

                int
                f_1480_71419_71457(System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
                this_param, System.Guid
                psInstanceId, System.Management.Automation.DebugRecord
                item)
                {
                    this_param.InternalAdd(psInstanceId, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 71419, 71457);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 71303, 71484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 71303, 71484);
            }
        }

        internal void AddWarning(WarningRecord item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 71709, 71898);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 71778, 71887) || true) && (f_1480_71782_71789() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 71778, 71887);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 71831, 71872);

                    f_1480_71831_71871(f_1480_71831_71838(), _psInstanceId, item);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 71778, 71887);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 71709, 71898);

                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1480_71782_71789()
                {
                    var return_v = Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 71782, 71789);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                f_1480_71831_71838()
                {
                    var return_v = Warning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 71831, 71838);
                    return return_v;
                }


                int
                f_1480_71831_71871(System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
                this_param, System.Guid
                psInstanceId, System.Management.Automation.WarningRecord
                item)
                {
                    this_param.InternalAdd(psInstanceId, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 71831, 71871);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 71709, 71898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 71709, 71898);
            }
        }

        internal void AddInformation(InformationRecord item)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1480, 72127, 72332);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 72204, 72321) || true) && (f_1480_72208_72219() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1480, 72204, 72321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1480, 72261, 72306);

                    f_1480_72261_72305(f_1480_72261_72272(), _psInstanceId, item);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1480, 72204, 72321);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1480, 72127, 72332);

                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1480_72208_72219()
                {
                    var return_v = Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 72208, 72219);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                f_1480_72261_72272()
                {
                    var return_v = Information;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1480, 72261, 72272);
                    return return_v;
                }


                int
                f_1480_72261_72305(System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
                this_param, System.Guid
                psInstanceId, System.Management.Automation.InformationRecord
                item)
                {
                    this_param.InternalAdd(psInstanceId, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 72261, 72305);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1480, 72127, 72332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 72127, 72332);
            }
        }

        static PSInformationalBuffers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1480, 67418, 72361);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1480, 67418, 72361);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1480, 67418, 72361);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1480, 67418, 72361);

        int
        f_1480_67974_68076(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 67974, 68076);
            return 0;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>
        f_1480_68147_68185()
        {
            var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.ProgressRecord>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 68147, 68185);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>
        f_1480_68210_68247()
        {
            var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.VerboseRecord>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 68210, 68247);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>
        f_1480_68270_68305()
        {
            var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.DebugRecord>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 68270, 68305);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>
        f_1480_68330_68367()
        {
            var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.WarningRecord>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 68330, 68367);
            return return_v;
        }


        System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>
        f_1480_68396_68437()
        {
            var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.InformationRecord>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1480, 68396, 68437);
            return return_v;
        }

    }
}
