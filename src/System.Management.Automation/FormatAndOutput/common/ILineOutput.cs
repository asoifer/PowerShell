// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Globalization;
using System.IO;
using System.Management.Automation;
using System.Text;

// interfaces for host interaction

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal class DisplayCells
    {
        internal virtual int Length(string str)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1097, 823, 920);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 887, 909);

                return f_1097_894_908(this, str, 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1097, 823, 920);

                int
                f_1097_894_908(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str, int
                offset)
                {
                    var return_v = this_param.Length(str, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 894, 908);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 823, 920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 823, 920);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual int Length(string str, int offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1097, 932, 1193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 1008, 1023);

                int
                length = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 1039, 1143);
                    foreach (char c in f_1097_1058_1061_I(str))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1097, 1039, 1143);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 1095, 1128);

                        length += f_1097_1105_1127(c);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1097, 1039, 1143);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1097, 1, 105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1097, 1, 105);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 1159, 1182);

                return length - offset;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1097, 932, 1193);

                int
                f_1097_1105_1127(char
                c)
                {
                    var return_v = LengthInBufferCells(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 1105, 1127);
                    return return_v;
                }


                string
                f_1097_1058_1061_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 1058, 1061);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 932, 1193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 932, 1193);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual int Length(char character)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1097, 1205, 1262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 1251, 1260);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1097, 1205, 1262);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 1205, 1262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 1205, 1262);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual int GetHeadSplitLength(string str, int displayCells)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1097, 1274, 1427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 1368, 1416);

                return f_1097_1375_1415(this, str, 0, displayCells);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1097, 1274, 1427);

                int
                f_1097_1375_1415(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str, int
                offset, int
                displayCells)
                {
                    var return_v = this_param.GetHeadSplitLength(str, offset, displayCells);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 1375, 1415);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 1274, 1427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 1274, 1427);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual int GetHeadSplitLength(string str, int offset, int displayCells)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1097, 1439, 1649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 1545, 1575);

                int
                len = f_1097_1555_1565(str) - offset
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 1589, 1638);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1097, 1596, 1616) || (((len < displayCells) && DynAbs.Tracing.TraceSender.Conditional_F2(1097, 1619, 1622)) || DynAbs.Tracing.TraceSender.Conditional_F3(1097, 1625, 1637))) ? len : displayCells;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1097, 1439, 1649);

                int
                f_1097_1555_1565(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1097, 1555, 1565);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 1439, 1649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 1439, 1649);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual int GetTailSplitLength(string str, int displayCells)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1097, 1661, 1814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 1755, 1803);

                return f_1097_1762_1802(this, str, 0, displayCells);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1097, 1661, 1814);

                int
                f_1097_1762_1802(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str, int
                offset, int
                displayCells)
                {
                    var return_v = this_param.GetTailSplitLength(str, offset, displayCells);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 1762, 1802);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 1661, 1814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 1661, 1814);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual int GetTailSplitLength(string str, int offset, int displayCells)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1097, 1826, 2036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 1932, 1962);

                int
                len = f_1097_1942_1952(str) - offset
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 1976, 2025);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1097, 1983, 2003) || (((len < displayCells) && DynAbs.Tracing.TraceSender.Conditional_F2(1097, 2006, 2009)) || DynAbs.Tracing.TraceSender.Conditional_F3(1097, 2012, 2024))) ? len : displayCells;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1097, 1826, 2036);

                int
                f_1097_1942_1952(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1097, 1942, 1952);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 1826, 2036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 1826, 2036);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static int LengthInBufferCells(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1097, 2075, 3407);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 2336, 3102);

                bool
                isWide = c >= 0x1100 && (DynAbs.Tracing.TraceSender.Expression_True(1097, 2350, 3101) && (c <= 0x115f || (DynAbs.Tracing.TraceSender.Expression_False(1097, 2383, 2462) || c == 0x2329) || (DynAbs.Tracing.TraceSender.Expression_False(1097, 2383, 2477) || c == 0x232a) || (DynAbs.Tracing.TraceSender.Expression_False(1097, 2383, 2574) || ((uint)(c - 0x2e80) <= (0xa4cf - 0x2e80) && (DynAbs.Tracing.TraceSender.Expression_True(1097, 2500, 2573) && c != 0x303f))) || (DynAbs.Tracing.TraceSender.Expression_False(1097, 2383, 2654) || ((uint)(c - 0xac00) <= (0xd7a3 - 0xac00))) || (DynAbs.Tracing.TraceSender.Expression_False(1097, 2383, 2740) || ((uint)(c - 0xf900) <= (0xfaff - 0xf900))) || (DynAbs.Tracing.TraceSender.Expression_False(1097, 2383, 2838) || ((uint)(c - 0xfe10) <= (0xfe19 - 0xfe10))) || (DynAbs.Tracing.TraceSender.Expression_False(1097, 2383, 2922) || ((uint)(c - 0xfe30) <= (0xfe6f - 0xfe30))) || (DynAbs.Tracing.TraceSender.Expression_False(1097, 2383, 3015) || ((uint)(c - 0xff00) <= (0xff60 - 0xff00))) || (DynAbs.Tracing.TraceSender.Expression_False(1097, 2383, 3100) || ((uint)(c - 0xffe0) <= (0xffe6 - 0xffe0)))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 3368, 3396);

                return 1 + ((DynAbs.Tracing.TraceSender.Conditional_F1(1097, 3380, 3386) || ((isWide && DynAbs.Tracing.TraceSender.Conditional_F2(1097, 3389, 3390)) || DynAbs.Tracing.TraceSender.Conditional_F3(1097, 3393, 3394))) ? 1 : 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1097, 2075, 3407);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 2075, 3407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 2075, 3407);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected int GetSplitLengthInternalHelper(string str, int offset, int displayCells, bool head)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1097, 4015, 5482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 4135, 4167);

                int
                filledDisplayCellsCount = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 4219, 4243);

                int
                charactersAdded = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 4290, 4313);

                int
                currCharDisplayLen
                = default(int);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 4349, 4390);

                int
                k = (DynAbs.Tracing.TraceSender.Conditional_F1(1097, 4357, 4363) || (((head) && DynAbs.Tracing.TraceSender.Conditional_F2(1097, 4366, 4372)) || DynAbs.Tracing.TraceSender.Conditional_F3(1097, 4375, 4389))) ? offset : f_1097_4375_4385(str) - 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 4404, 4450);

                int
                kFinal = (DynAbs.Tracing.TraceSender.Conditional_F1(1097, 4417, 4423) || (((head) && DynAbs.Tracing.TraceSender.Conditional_F2(1097, 4426, 4440)) || DynAbs.Tracing.TraceSender.Conditional_F3(1097, 4443, 4449))) ? f_1097_4426_4436(str) - 1 : offset
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 4464, 5432) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1097, 4464, 5432);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 4509, 4631) || true) && ((head && (DynAbs.Tracing.TraceSender.Expression_True(1097, 4514, 4534) && (k > kFinal))) || (DynAbs.Tracing.TraceSender.Expression_False(1097, 4513, 4564) || ((!head) && (DynAbs.Tracing.TraceSender.Expression_True(1097, 4540, 4563) && (k < kFinal)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1097, 4509, 4631);
                            DynAbs.Tracing.TraceSender.TraceBreak(1097, 4606, 4612);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1097, 4509, 4631);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 4719, 4760);

                        currCharDisplayLen = f_1097_4740_4759(this, f_1097_4752_4758(str, k));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 4780, 4998) || true) && (filledDisplayCellsCount + currCharDisplayLen > displayCells)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1097, 4780, 4998);
                            DynAbs.Tracing.TraceSender.TraceBreak(1097, 4973, 4979);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1097, 4780, 4998);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 5056, 5102);

                        filledDisplayCellsCount += currCharDisplayLen;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 5120, 5138);

                        charactersAdded++;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 5202, 5366) || true) && (filledDisplayCellsCount == displayCells)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1097, 5202, 5366);
                            DynAbs.Tracing.TraceSender.TraceBreak(1097, 5341, 5347);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1097, 5202, 5366);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 5386, 5417);

                        k = (DynAbs.Tracing.TraceSender.Conditional_F1(1097, 5390, 5396) || (((head) && DynAbs.Tracing.TraceSender.Conditional_F2(1097, 5399, 5406)) || DynAbs.Tracing.TraceSender.Conditional_F3(1097, 5409, 5416))) ? (k + 1) : (k - 1);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1097, 4464, 5432);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1097, 4464, 5432);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1097, 4464, 5432);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 5448, 5471);

                return charactersAdded;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1097, 4015, 5482);

                int
                f_1097_4375_4385(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1097, 4375, 4385);
                    return return_v;
                }


                int
                f_1097_4426_4436(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1097, 4426, 4436);
                    return return_v;
                }


                char
                f_1097_4752_4758(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1097, 4752, 4758);
                    return return_v;
                }


                int
                f_1097_4740_4759(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, char
                character)
                {
                    var return_v = this_param.Length(character);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 4740, 4759);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 4015, 5482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 4015, 5482);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public DisplayCells()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1097, 779, 5511);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1097, 779, 5511);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 779, 5511);
        }


        static DisplayCells()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1097, 779, 5511);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1097, 779, 5511);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 779, 5511);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1097, 779, 5511);
    }
    internal abstract class LineOutput
    {
        internal virtual bool RequiresBuffering
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1097, 6673, 6694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 6679, 6692);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1097, 6673, 6694);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 6631, 6696);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 6631, 6696);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        /// <summary>
        /// Delegate the implementor of ExecuteBufferPlayBack should
        /// call to cause the playback to happen when ready to execute.
        /// </summary>
        internal delegate void DoPlayBackCall();

        internal virtual void ExecuteBufferPlayBack(DoPlayBackCall playback)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1097, 7098, 7170);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1097, 7098, 7170);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 7098, 7170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 7098, 7170);
            }
        }

        internal abstract int ColumnNumber { get; }

        internal abstract int RowNumber { get; }

        internal abstract void WriteLine(string s);

        internal WriteStreamType WriteStream
        {
            get;
            set;
        }

        internal void StopProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1097, 8017, 8102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 8072, 8091);

                _isStopping = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1097, 8017, 8102);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 8017, 8102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 8017, 8102);
            }
        }

        private bool _isStopping;

        internal void CheckStopProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1097, 8151, 8315);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 8211, 8253) || true) && (!_isStopping)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1097, 8211, 8253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 8246, 8253);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1097, 8211, 8253);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 8267, 8304);

                throw f_1097_8273_8303();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1097, 8151, 8315);

                System.Management.Automation.PipelineStoppedException
                f_1097_8273_8303()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 8273, 8303);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 8151, 8315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 8151, 8315);
            }
        }

        internal virtual DisplayCells DisplayCells
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1097, 8534, 8722);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 8570, 8592);

                    f_1097_8570_8591(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 8679, 8707);

                    return _displayCellsDefault;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1097, 8534, 8722);

                    int
                    f_1097_8570_8591(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                    this_param)
                    {
                        this_param.CheckStopProcessing();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 8570, 8591);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 8467, 8733);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 8467, 8733);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected static DisplayCells _displayCellsDefault;

        public LineOutput()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1097, 6419, 9042);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 7752, 7846);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 8127, 8138);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1097, 6419, 9042);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 6419, 9042);
        }


        static LineOutput()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1097, 6419, 9042);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 8993, 9034);
            _displayCellsDefault = f_1097_9016_9034();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1097, 6419, 9042);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 6419, 9042);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1097, 6419, 9042);

        static Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
        f_1097_9016_9034()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.DisplayCells();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 9016, 9034);
            return return_v;
        }

    }
    internal class WriteLineHelper
    {
        /// <summary>
        /// Delegate definition.
        /// </summary>
        /// <param name="s">String to write.</param>
        internal delegate void WriteCallback(string s);

        private WriteCallback _writeCall;

        private WriteCallback _writeLineCall;

        private bool _lineWrap;

        internal WriteLineHelper(bool lineWrap, WriteCallback wlc, WriteCallback wc, DisplayCells displayCells)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1097, 10624, 11119);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 9732, 9749);
                this._writeCall = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 9952, 9973);
                this._writeLineCall = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 10021, 10030);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 13970, 13983);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 10752, 10838) || true) && (wlc == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1097, 10752, 10838);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 10786, 10838);

                    throw f_1097_10792_10837("wlc");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1097, 10752, 10838);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 10852, 10956) || true) && (displayCells == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1097, 10852, 10956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 10895, 10956);

                    throw f_1097_10901_10955("displayCells");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1097, 10852, 10956);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 10972, 11001);

                _displayCells = displayCells;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 11015, 11036);

                _writeLineCall = wlc;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 11050, 11073);

                _writeCall = wc ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.PowerShell.Commands.Internal.Format.WriteLineHelper.WriteCallback>(1097, 11063, 11072) ?? wlc);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 11087, 11108);

                _lineWrap = lineWrap;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1097, 10624, 11119);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 10624, 11119);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 10624, 11119);
            }
        }

        internal void WriteLine(string s, int cols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1097, 11344, 11450);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 11412, 11439);

                f_1097_11412_11438(this, s, cols);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1097, 11344, 11450);

                int
                f_1097_11412_11438(Microsoft.PowerShell.Commands.Internal.Format.WriteLineHelper
                this_param, string
                val, int
                cols)
                {
                    this_param.WriteLineInternal(val, cols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 11412, 11438);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 11344, 11450);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 11344, 11450);
            }
        }

        private void WriteLineInternal(string val, int cols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1097, 11714, 13937);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 11791, 11914) || true) && (f_1097_11795_11820(val))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1097, 11791, 11914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 11854, 11874);

                    f_1097_11854_11873(this, val);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 11892, 11899);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1097, 11791, 11914);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 12005, 12109) || true) && (!_lineWrap)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1097, 12005, 12109);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 12053, 12069);

                    f_1097_12053_12068(this, val);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 12087, 12094);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1097, 12005, 12109);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 12163, 12221);

                string[]
                lines = f_1097_12180_12220(val)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 12303, 12308);

                    // process the substrings as separate lines
                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 12294, 13926) || true) && (k < f_1097_12314_12326(lines))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 12328, 12331)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1097, 12294, 13926))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1097, 12294, 13926);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 12426, 12477);

                        int
                        displayLength = f_1097_12446_12476(_displayCells, lines[k])
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 12497, 12745) || true) && (displayLength < cols)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1097, 12497, 12745);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 12670, 12695);

                            f_1097_12670_12694(this, lines[k]);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 12717, 12726);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1097, 12497, 12745);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 12765, 13007) || true) && (displayLength == cols)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1097, 12765, 13007);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 12936, 12957);

                            f_1097_12936_12956(this, lines[k]);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 12979, 12988);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1097, 12765, 13007);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 13116, 13136);

                        string
                        s = lines[k]
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 13156, 13911) || true) && (true)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1097, 13156, 13911);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 13358, 13415);

                                int
                                splitLen = f_1097_13373_13414(_displayCells, s, cols)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 13437, 13487);

                                f_1097_13437_13486(this, f_1097_13455_13479(s, 0, splitLen), cols);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 13593, 13619);

                                s = f_1097_13597_13618(s, splitLen);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 13641, 13892) || true) && (f_1097_13645_13668(_displayCells, s) <= cols)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1097, 13641, 13892);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 13810, 13837);

                                    f_1097_13810_13836(this, s, cols);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1097, 13863, 13869);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1097, 13641, 13892);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1097, 13156, 13911);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1097, 13156, 13911);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1097, 13156, 13911);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1097, 1, 1633);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1097, 1, 1633);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1097, 11714, 13937);

                bool
                f_1097_11795_11820(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 11795, 11820);
                    return return_v;
                }


                int
                f_1097_11854_11873(Microsoft.PowerShell.Commands.Internal.Format.WriteLineHelper
                this_param, string
                s)
                {
                    this_param._writeLineCall(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 11854, 11873);
                    return 0;
                }


                int
                f_1097_12053_12068(Microsoft.PowerShell.Commands.Internal.Format.WriteLineHelper
                this_param, string
                s)
                {
                    this_param._writeCall(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 12053, 12068);
                    return 0;
                }


                string[]
                f_1097_12180_12220(string
                s)
                {
                    var return_v = StringManipulationHelper.SplitLines(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 12180, 12220);
                    return return_v;
                }


                int
                f_1097_12314_12326(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1097, 12314, 12326);
                    return return_v;
                }


                int
                f_1097_12446_12476(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str)
                {
                    var return_v = this_param.Length(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 12446, 12476);
                    return return_v;
                }


                int
                f_1097_12670_12694(Microsoft.PowerShell.Commands.Internal.Format.WriteLineHelper
                this_param, string
                s)
                {
                    this_param._writeLineCall(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 12670, 12694);
                    return 0;
                }


                int
                f_1097_12936_12956(Microsoft.PowerShell.Commands.Internal.Format.WriteLineHelper
                this_param, string
                s)
                {
                    this_param._writeCall(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 12936, 12956);
                    return 0;
                }


                int
                f_1097_13373_13414(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str, int
                displayCells)
                {
                    var return_v = this_param.GetHeadSplitLength(str, displayCells);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 13373, 13414);
                    return return_v;
                }


                string
                f_1097_13455_13479(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 13455, 13479);
                    return return_v;
                }


                int
                f_1097_13437_13486(Microsoft.PowerShell.Commands.Internal.Format.WriteLineHelper
                this_param, string
                val, int
                cols)
                {
                    this_param.WriteLineInternal(val, cols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 13437, 13486);
                    return 0;
                }


                string
                f_1097_13597_13618(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 13597, 13618);
                    return return_v;
                }


                int
                f_1097_13645_13668(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str)
                {
                    var return_v = this_param.Length(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 13645, 13668);
                    return return_v;
                }


                int
                f_1097_13810_13836(Microsoft.PowerShell.Commands.Internal.Format.WriteLineHelper
                this_param, string
                val, int
                cols)
                {
                    this_param.WriteLineInternal(val, cols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 13810, 13836);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 11714, 13937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 11714, 13937);
            }
        }

        private DisplayCells _displayCells;

        static WriteLineHelper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1097, 9274, 13991);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1097, 9274, 13991);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 9274, 13991);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1097, 9274, 13991);

        System.Management.Automation.PSArgumentNullException
        f_1097_10792_10837(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 10792, 10837);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1097_10901_10955(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 10901, 10955);
            return return_v;
        }

    }
    internal class TextWriterLineOutput : LineOutput
    {
        internal override int ColumnNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1097, 14464, 14571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 14500, 14522);

                    f_1097_14500_14521(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 14540, 14556);

                    return _columns;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1097, 14464, 14571);

                    int
                    f_1097_14500_14521(Microsoft.PowerShell.Commands.Internal.Format.TextWriterLineOutput
                    this_param)
                    {
                        this_param.CheckStopProcessing();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 14500, 14521);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 14405, 14582);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 14405, 14582);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int RowNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1097, 14798, 14899);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 14834, 14856);

                    f_1097_14834_14855(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 14874, 14884);

                    return -1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1097, 14798, 14899);

                    int
                    f_1097_14834_14855(Microsoft.PowerShell.Commands.Internal.Format.TextWriterLineOutput
                    this_param)
                    {
                        this_param.CheckStopProcessing();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 14834, 14855);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 14742, 14910);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 14742, 14910);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void WriteLine(string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1097, 15073, 15360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 15140, 15162);

                f_1097_15140_15161(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 15176, 15349) || true) && (_suppressNewline)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1097, 15176, 15349);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 15230, 15247);

                    f_1097_15230_15246(_writer, s);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1097, 15176, 15349);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1097, 15176, 15349);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 15313, 15334);

                    f_1097_15313_15333(_writer, s);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1097, 15176, 15349);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1097, 15073, 15360);

                int
                f_1097_15140_15161(Microsoft.PowerShell.Commands.Internal.Format.TextWriterLineOutput
                this_param)
                {
                    this_param.CheckStopProcessing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 15140, 15161);
                    return 0;
                }


                int
                f_1097_15230_15246(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 15230, 15246);
                    return 0;
                }


                int
                f_1097_15313_15333(System.IO.TextWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 15313, 15333);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 15073, 15360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 15073, 15360);
            }
        }

        internal TextWriterLineOutput(TextWriter writer, int columns)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1097, 15688, 15835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 16478, 16490);
                this._columns = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 16522, 16536);
                this._writer = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 16562, 16586);
                this._suppressNewline = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 15774, 15791);

                _writer = writer;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 15805, 15824);

                _columns = columns;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1097, 15688, 15835);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 15688, 15835);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 15688, 15835);
            }
        }

        internal TextWriterLineOutput(TextWriter writer, int columns, bool suppressNewline)
        : this(f_1097_16367_16373_C(writer), columns)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1097, 16263, 16454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 16408, 16443);

                _suppressNewline = suppressNewline;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1097, 16263, 16454);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 16263, 16454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 16263, 16454);
            }
        }

        private int _columns;

        private TextWriter _writer;

        private bool _suppressNewline;

        static TextWriterLineOutput()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1097, 14154, 16594);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1097, 14154, 16594);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 14154, 16594);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1097, 14154, 16594);

        static System.IO.TextWriter
        f_1097_16367_16373_C(System.IO.TextWriter
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1097, 16263, 16454);
            return return_v;
        }

    }
    internal class StreamingTextWriter : TextWriter
    {
        [TraceSource("StreamingTextWriter", "StreamingTextWriter")]
        private static PSTraceSource s_tracer;

        internal StreamingTextWriter(WriteLineCallback writeCall, CultureInfo culture)
        : base(f_1097_17446_17453_C(culture))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1097, 17347, 17627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 18219, 18236);
                this._writeCall = null;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 17479, 17577) || true) && (writeCall == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1097, 17479, 17577);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 17519, 17577);

                    throw f_1097_17525_17576("writeCall");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1097, 17479, 17577);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 17593, 17616);

                _writeCall = writeCall;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1097, 17347, 17627);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 17347, 17627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 17347, 17627);
            }
        }

        public override Encoding Encoding
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1097, 17715, 17752);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 17721, 17750);

                    return f_1097_17728_17749();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1097, 17715, 17752);

                    System.Text.UnicodeEncoding
                    f_1097_17728_17749()
                    {
                        var return_v = new System.Text.UnicodeEncoding();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 17728, 17749);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 17679, 17754);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 17679, 17754);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void WriteLine(string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1097, 17766, 17856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 17831, 17845);

                f_1097_17831_17844(this, s);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1097, 17766, 17856);

                int
                f_1097_17831_17844(Microsoft.PowerShell.Commands.Internal.Format.StreamingTextWriter
                this_param, string
                s)
                {
                    this_param._writeCall(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 17831, 17844);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1097, 17766, 17856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 17766, 17856);
            }
        }


        /// <summary>
        /// Delegate definition.
        /// </summary>
        /// <param name="s">String to write.</param>
        internal delegate void WriteLineCallback(string s);

        private WriteLineCallback _writeCall;

        static StreamingTextWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1097, 16800, 18244);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1097, 16986, 17066);
            s_tracer = f_1097_16997_17066("StreamingTextWriter", "StreamingTextWriter");
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1097, 16800, 18244);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1097, 16800, 18244);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1097, 16800, 18244);

        static System.Management.Automation.PSTraceSource
        f_1097_16997_17066(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 16997, 17066);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1097_17525_17576(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1097, 17525, 17576);
            return return_v;
        }


        static System.IFormatProvider
        f_1097_17446_17453_C(System.IFormatProvider
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1097, 17347, 17627);
            return return_v;
        }

    }
}
