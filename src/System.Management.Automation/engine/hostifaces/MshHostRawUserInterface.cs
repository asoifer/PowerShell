// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Globalization;

#pragma warning disable 1634, 1691 // Stops compiler from warning about unknown warnings

namespace System.Management.Automation.Host
{

    public
        struct Coordinates
    {

        private int x;

        private int y;

        public int X
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 925, 942);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 931, 940);

                    return x;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 925, 942);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 888, 987);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 888, 987);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 958, 976);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 964, 974);

                    x = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 958, 976);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 888, 987);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 888, 987);
                }
            }
        }

        public int Y
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 1128, 1145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 1134, 1143);

                    return y;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 1128, 1145);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 1091, 1190);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 1091, 1190);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 1161, 1179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 1167, 1177);

                    y = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 1161, 1179);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 1091, 1190);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 1091, 1190);
                }
            }
        }

        public
                Coordinates(int x, int y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1471, 1510, 1623);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 1576, 1587);

                this.x = x;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 1601, 1612);

                this.y = y;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1471, 1510, 1623);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 1510, 1623);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 1510, 1623);
            }
        }

        public override
                string
                ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 1866, 2021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 1942, 2010);

                return f_1471_1949_2009(f_1471_1963_1991(), "{0},{1}", X, Y);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 1866, 2021);

                System.Globalization.CultureInfo
                f_1471_1963_1991()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 1963, 1991);
                    return return_v;
                }


                string
                f_1471_1949_2009(System.Globalization.CultureInfo
                provider, string
                format, int
                arg0, int
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 1949, 2009);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 1866, 2021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 1866, 2021);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override
                bool
                Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 2448, 2714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 2530, 2550);

                bool
                result = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 2566, 2673) || true) && (obj is Coordinates)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 2566, 2673);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 2622, 2658);

                    result = this == ((Coordinates)obj);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 2566, 2673);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 2689, 2703);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 2448, 2714);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 2448, 2714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 2448, 2714);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override
                int
                GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 2927, 4158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 3135, 3150);

                UInt64
                i64 = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 3166, 3587) || true) && (X < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 3166, 3587);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 3209, 3490) || true) && (X == Int32.MinValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 3209, 3490);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 3341, 3370);

                        i64 = (UInt64)(-1 * (X + 1));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 3209, 3490);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 3209, 3490);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 3452, 3471);

                        i64 = (UInt64)(f_1471_3467_3469_M(-X));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 3209, 3490);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 3166, 3587);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 3166, 3587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 3556, 3572);

                    i64 = (UInt64)X;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 3166, 3587);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 3649, 3669);

                i64 *= 0x100000000U;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 3713, 4070) || true) && (Y < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 3713, 4070);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 3756, 3972) || true) && (Y == Int32.MinValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 3756, 3972);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 3821, 3851);

                        i64 += (UInt64)(-1 * (Y + 1));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 3756, 3972);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 3756, 3972);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 3933, 3953);

                        i64 += (UInt64)(f_1471_3949_3951_M(-Y));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 3756, 3972);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 3713, 4070);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 3713, 4070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 4038, 4055);

                    i64 += (UInt64)Y;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 3713, 4070);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 4086, 4117);

                int
                result = f_1471_4099_4116(i64)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 4133, 4147);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 2927, 4158);

                int
                f_1471_3467_3469_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 3467, 3469);
                    return return_v;
                }


                int
                f_1471_3949_3951_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 3949, 3951);
                    return return_v;
                }


                int
                f_1471_4099_4116(ulong
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 4099, 4116);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 2927, 4158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 2927, 4158);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static
                bool
                operator ==(Coordinates first, Coordinates second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1471, 4584, 4794);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 4696, 4753);

                bool
                result = first.X == second.X && (DynAbs.Tracing.TraceSender.Expression_True(1471, 4710, 4752) && first.Y == second.Y)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 4769, 4783);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1471, 4584, 4794);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 4584, 4794);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 4584, 4794);
            }
        }

        public static
                bool
                operator !=(Coordinates first, Coordinates second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1471, 5237, 5386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 5349, 5375);

                return !(first == second);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1471, 5237, 5386);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 5237, 5386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 5237, 5386);
            }
        }
        static Coordinates()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1471, 558, 5393);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1471, 558, 5393);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 558, 5393);
        }
    }

    public
        struct Size
    {

        private int width;

        private int height;

        public int Width
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 5853, 5874);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 5859, 5872);

                    return width;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 5853, 5874);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 5812, 5923);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 5812, 5923);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 5890, 5912);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 5896, 5910);

                    width = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 5890, 5912);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 5812, 5923);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 5812, 5923);
                }
            }
        }

        public int Height
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 6063, 6085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 6069, 6083);

                    return height;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 6063, 6085);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 6021, 6135);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 6021, 6135);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 6101, 6124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 6107, 6122);

                    height = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 6101, 6124);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 6021, 6135);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 6021, 6135);
                }
            }
        }

        public
                Size(int width, int height)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1471, 6452, 6585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 6520, 6539);

                this.width = width;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 6553, 6574);

                this.height = height;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1471, 6452, 6585);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 6452, 6585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 6452, 6585);
            }
        }

        public override
                string
                ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 6837, 7001);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 6913, 6990);

                return f_1471_6920_6989(f_1471_6934_6962(), "{0},{1}", Width, Height);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 6837, 7001);

                System.Globalization.CultureInfo
                f_1471_6934_6962()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 6934, 6962);
                    return return_v;
                }


                string
                f_1471_6920_6989(System.Globalization.CultureInfo
                provider, string
                format, int
                arg0, int
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 6920, 6989);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 6837, 7001);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 6837, 7001);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override
                bool
                Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 7429, 7681);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 7511, 7531);

                bool
                result = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 7547, 7640) || true) && (obj is Size)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 7547, 7640);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 7596, 7625);

                    result = this == ((Size)obj);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 7547, 7640);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 7656, 7670);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 7429, 7681);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 7429, 7681);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 7429, 7681);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override
                int
                GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 8058, 9348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 8275, 8290);

                UInt64
                i64 = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 8306, 8747) || true) && (Width < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 8306, 8747);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 8353, 8646) || true) && (Width == Int32.MinValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 8353, 8646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 8489, 8522);

                        i64 = (UInt64)(-1 * (Width + 1));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 8353, 8646);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 8353, 8646);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 8604, 8627);

                        i64 = (UInt64)(f_1471_8619_8625_M(-Width));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 8353, 8646);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 8306, 8747);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 8306, 8747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 8712, 8732);

                    i64 = (UInt64)Width;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 8306, 8747);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 8809, 8829);

                i64 *= 0x100000000U;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 8878, 9260) || true) && (Height < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 8878, 9260);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 8926, 9157) || true) && (Height == Int32.MinValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 8926, 9157);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 8996, 9031);

                        i64 += (UInt64)(-1 * (Height + 1));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 8926, 9157);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 8926, 9157);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 9113, 9138);

                        i64 += (UInt64)(f_1471_9129_9136_M(-Height));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 8926, 9157);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 8878, 9260);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 8878, 9260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 9223, 9245);

                    i64 += (UInt64)Height;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 8878, 9260);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 9276, 9307);

                int
                result = f_1471_9289_9306(i64)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 9323, 9337);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 8058, 9348);

                int
                f_1471_8619_8625_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 8619, 8625);
                    return return_v;
                }


                int
                f_1471_9129_9136_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 9129, 9136);
                    return return_v;
                }


                int
                f_1471_9289_9306(ulong
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 9289, 9306);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 8058, 9348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 8058, 9348);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static
                bool
                operator ==(Size first, Size second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1471, 9783, 9997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 9881, 9956);

                bool
                result = first.Width == second.Width && (DynAbs.Tracing.TraceSender.Expression_True(1471, 9895, 9955) && first.Height == second.Height)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 9972, 9986);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1471, 9783, 9997);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 9783, 9997);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 9783, 9997);
            }
        }

        public static
                bool
                operator !=(Size first, Size second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1471, 10445, 10580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 10543, 10569);

                return !(first == second);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1471, 10445, 10580);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 10445, 10580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 10445, 10580);
            }
        }
        static Size()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1471, 5487, 10587);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1471, 5487, 10587);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 5487, 10587);
        }
    }

    /// <summary>
    /// Governs the behavior of <see cref="System.Management.Automation.Host.PSHostRawUserInterface.ReadKey()"/>
    /// and <see cref="System.Management.Automation.Host.PSHostRawUserInterface.ReadKey(System.Management.Automation.Host.ReadKeyOptions)"/>
    /// </summary>

    [Flags]
    public
    enum
    ReadKeyOptions
    {
        /// <summary>
        /// Allow Ctrl-C to be processed as a keystroke, as opposed to causing a break event.
        /// </summary>

        AllowCtrlC = 0x0001,

        /// <summary>
        /// Do not display the character for the key in the window when pressed.
        /// </summary>

        NoEcho = 0x0002,

        /// <summary>
        /// Include key down events.  Either one of IncludeKeyDown and IncludeKeyUp or both must be specified.
        /// </summary>

        IncludeKeyDown = 0x0004,

        /// <summary>
        /// Include key up events.  Either one of IncludeKeyDown and IncludeKeyUp or both must be specified.
        /// </summary>

        IncludeKeyUp = 0x0008
    }

    /// <summary>
    /// Defines the states of Control Key.
    /// </summary>

    [Flags]
    public
    enum ControlKeyStates
    {
        /// <summary>
        /// The right alt key is pressed.
        /// </summary>

        RightAltPressed = 0x0001,

        /// <summary>
        /// The left alt key is pressed.
        /// </summary>

        LeftAltPressed = 0x0002,

        /// <summary>
        /// The right ctrl key is pressed.
        /// </summary>

        RightCtrlPressed = 0x0004,

        /// <summary>
        /// The left ctrl key is pressed.
        /// </summary>

        LeftCtrlPressed = 0x0008,

        /// <summary>
        /// The shift key is pressed.
        /// </summary>

        ShiftPressed = 0x0010,

        /// <summary>
        /// The numlock light is on.
        /// </summary>

        NumLockOn = 0x0020,

        /// <summary>
        /// The scrolllock light is on.
        /// </summary>

        ScrollLockOn = 0x0040,

        /// <summary>
        /// The capslock light is on.
        /// </summary>

        CapsLockOn = 0x0080,

        /// <summary>
        /// The key is enhanced.
        /// </summary>

        EnhancedKey = 0x0100
    }

    public
        struct KeyInfo
    {

        private int virtualKeyCode;

        private char character;

        private ControlKeyStates controlKeyState;

        private bool keyDown;

        public int VirtualKeyCode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 13527, 13557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 13533, 13555);

                    return virtualKeyCode;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 13527, 13557);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 13477, 13615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 13477, 13615);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 13573, 13604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 13579, 13602);

                    virtualKeyCode = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 13573, 13604);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 13477, 13615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 13477, 13615);
                }
            }
        }

        public char Character
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 13778, 13803);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 13784, 13801);

                    return character;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 13778, 13803);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 13732, 13856);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 13732, 13856);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 13819, 13845);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 13825, 13843);

                    character = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 13819, 13845);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 13732, 13856);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 13732, 13856);
                }
            }
        }

        public ControlKeyStates ControlKeyState
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 14021, 14052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 14027, 14050);

                    return controlKeyState;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 14021, 14052);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 13957, 14111);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 13957, 14111);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 14068, 14100);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 14074, 14098);

                    controlKeyState = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 14068, 14100);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 13957, 14111);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 13957, 14111);
                }
            }
        }

        public bool KeyDown
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 14321, 14344);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 14327, 14342);

                    return keyDown;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 14321, 14344);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 14277, 14395);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 14277, 14395);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 14360, 14384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 14366, 14382);

                    keyDown = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 14360, 14384);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 14277, 14395);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 14277, 14395);
                }
            }
        }

        public
                KeyInfo
                (
                    int virtualKeyCode,
                    char ch,
                    ControlKeyStates controlKeyState,
                    bool keyDown
                )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1471, 14998, 15368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 15196, 15233);

                this.virtualKeyCode = virtualKeyCode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 15247, 15267);

                this.character = ch;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 15281, 15320);

                this.controlKeyState = controlKeyState;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 15334, 15357);

                this.keyDown = keyDown;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1471, 14998, 15368);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 14998, 15368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 14998, 15368);
            }
        }

        public override
                string
                ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 15670, 15880);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 15746, 15869);

                return f_1471_15753_15868(f_1471_15767_15795(), "{0},{1},{2},{3}", VirtualKeyCode, Character, ControlKeyState, KeyDown);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 15670, 15880);

                System.Globalization.CultureInfo
                f_1471_15767_15795()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 15767, 15795);
                    return return_v;
                }


                string
                f_1471_15753_15868(System.Globalization.CultureInfo
                provider, string
                format, params object?[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 15753, 15868);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 15670, 15880);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 15670, 15880);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override
                bool
                Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 16348, 16606);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 16430, 16450);

                bool
                result = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 16466, 16565) || true) && (obj is KeyInfo)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 16466, 16565);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 16518, 16550);

                    result = this == ((KeyInfo)obj);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 16466, 16565);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 16581, 16595);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 16348, 16606);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 16348, 16606);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 16348, 16606);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override
                int
                GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 17129, 17801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 17528, 17567);

                UInt32
                i32 = (DynAbs.Tracing.TraceSender.Conditional_F1(1471, 17541, 17548) || ((KeyDown && DynAbs.Tracing.TraceSender.Conditional_F2(1471, 17551, 17562)) || DynAbs.Tracing.TraceSender.Conditional_F3(1471, 17565, 17566))) ? 0x10000000U : 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 17623, 17660);

                i32 |= ((uint)ControlKeyState) << 16;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 17719, 17749);

                i32 |= (UInt32)VirtualKeyCode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 17765, 17790);

                return f_1471_17772_17789(i32);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 17129, 17801);

                int
                f_1471_17772_17789(uint
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 17772, 17789);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 17129, 17801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 17129, 17801);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static
                bool
                operator ==(KeyInfo first, KeyInfo second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1471, 18316, 18673);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 18420, 18632);

                bool
                result = first.Character == second.Character && (DynAbs.Tracing.TraceSender.Expression_True(1471, 18434, 18520) && first.ControlKeyState == second.ControlKeyState) && (DynAbs.Tracing.TraceSender.Expression_True(1471, 18434, 18582) && first.KeyDown == second.KeyDown) && (DynAbs.Tracing.TraceSender.Expression_True(1471, 18434, 18631) && first.VirtualKeyCode == second.VirtualKeyCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 18648, 18662);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1471, 18316, 18673);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 18316, 18673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 18316, 18673);
            }
        }

        public static
                bool
                operator !=(KeyInfo first, KeyInfo second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1471, 19201, 19342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 19305, 19331);

                return !(first == second);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1471, 19201, 19342);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 19201, 19342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 19201, 19342);
            }
        }
        static KeyInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1471, 13040, 19349);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1471, 13040, 19349);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 13040, 19349);
        }
    }

    public
        struct Rectangle
    {

        private int left;

        private int top;

        private int right;

        private int bottom;

        public int Left
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 20050, 20070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 20056, 20068);

                    return left;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 20050, 20070);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 20010, 20118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 20010, 20118);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 20086, 20107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 20092, 20105);

                    left = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 20086, 20107);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 20010, 20118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 20010, 20118);
                }
            }
        }

        public int Top
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 20271, 20290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 20277, 20288);

                    return top;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 20271, 20290);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 20232, 20337);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 20232, 20337);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 20306, 20326);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 20312, 20324);

                    top = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 20306, 20326);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 20232, 20337);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 20232, 20337);
                }
            }
        }

        public int Right
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 20499, 20520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 20505, 20518);

                    return right;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 20499, 20520);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 20458, 20569);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 20458, 20569);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 20536, 20558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 20542, 20556);

                    right = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 20536, 20558);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 20458, 20569);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 20458, 20569);
                }
            }
        }

        public int Bottom
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 20728, 20750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 20734, 20748);

                    return bottom;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 20728, 20750);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 20686, 20800);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 20686, 20800);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 20766, 20789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 20772, 20787);

                    bottom = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 20766, 20789);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 20686, 20800);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 20686, 20800);
                }
            }
        }

        public
                Rectangle(int left, int top, int right, int bottom)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1471, 21593, 22333);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 21685, 21930) || true) && (right < left)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 21685, 21930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 21794, 21915);

                    throw f_1471_21800_21914("right", f_1471_21844_21896(), "right", "left");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 21685, 21930);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 21946, 22192) || true) && (bottom < top)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 21946, 22192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 22055, 22177);

                    throw f_1471_22061_22176("bottom", f_1471_22106_22158(), "bottom", "top");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 21946, 22192);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 22208, 22225);

                this.left = left;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 22239, 22254);

                this.top = top;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 22268, 22287);

                this.right = right;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 22301, 22322);

                this.bottom = bottom;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1471, 21593, 22333);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 21593, 22333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 21593, 22333);
            }
        }

        public
                Rectangle(Coordinates upperLeft, Coordinates lowerRight)
        : this(f_1471_23129_23140_C(upperLeft.X), upperLeft.Y, lowerRight.X, lowerRight.Y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1471, 23036, 23204);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1471, 23036, 23204);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 23036, 23204);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 23036, 23204);
            }
        }

        public override
                string
                ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 23477, 23662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 23553, 23651);

                return f_1471_23560_23650(f_1471_23574_23602(), "{0},{1} ; {2},{3}", Left, Top, Right, Bottom);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 23477, 23662);

                System.Globalization.CultureInfo
                f_1471_23574_23602()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 23574, 23602);
                    return return_v;
                }


                string
                f_1471_23560_23650(System.Globalization.CultureInfo
                provider, string
                format, params object?[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 23560, 23650);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 23477, 23662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 23477, 23662);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override
                bool
                Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 24107, 24369);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 24189, 24209);

                bool
                result = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 24225, 24328) || true) && (obj is Rectangle)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 24225, 24328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 24279, 24313);

                    result = this == ((Rectangle)obj);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 24225, 24328);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 24344, 24358);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 24107, 24369);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 24107, 24369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 24107, 24369);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override
                int
                GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 24792, 26203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 25058, 25073);

                UInt64
                i64 = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 25089, 25114);

                int
                upper = Top ^ Bottom
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 25128, 25569) || true) && (upper < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 25128, 25569);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 25175, 25468) || true) && (upper == Int32.MinValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 25175, 25468);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 25311, 25344);

                        i64 = (UInt64)(-1 * (upper + 1));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 25175, 25468);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 25175, 25468);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 25426, 25449);

                        i64 = (UInt64)(-upper);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 25175, 25468);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 25128, 25569);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 25128, 25569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 25534, 25554);

                    i64 = (UInt64)upper;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 25128, 25569);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 25631, 25651);

                i64 *= 0x100000000U;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 25699, 25724);

                int
                lower = Left ^ Right
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 25738, 26115) || true) && (lower < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 25738, 26115);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 25785, 26013) || true) && (lower == Int32.MinValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 25785, 26013);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 25854, 25888);

                        i64 += (UInt64)(-1 * (lower + 1));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 25785, 26013);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 25785, 26013);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 25970, 25994);

                        i64 += (UInt64)(-upper);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 25785, 26013);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 25738, 26115);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 25738, 26115);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 26079, 26100);

                    i64 += (UInt64)lower;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 25738, 26115);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 26131, 26162);

                int
                result = f_1471_26144_26161(i64)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 26178, 26192);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 24792, 26203);

                int
                f_1471_26144_26161(ulong
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 26144, 26161);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 24792, 26203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 24792, 26203);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static
                bool
                operator ==(Rectangle first, Rectangle second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1471, 26650, 26944);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 26758, 26903);

                bool
                result = first.Top == second.Top && (DynAbs.Tracing.TraceSender.Expression_True(1471, 26772, 26824) && first.Left == second.Left) && (DynAbs.Tracing.TraceSender.Expression_True(1471, 26772, 26871) && first.Bottom == second.Bottom) && (DynAbs.Tracing.TraceSender.Expression_True(1471, 26772, 26902) && first.Right == second.Right)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 26919, 26933);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1471, 26650, 26944);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 26650, 26944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 26650, 26944);
            }
        }

        public static
                bool
                operator !=(Rectangle first, Rectangle second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1471, 27430, 27575);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 27538, 27564);

                return !(first == second);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1471, 27430, 27575);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 27430, 27575);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 27430, 27575);
            }
        }
        static Rectangle()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1471, 19604, 27582);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1471, 19604, 27582);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 19604, 27582);
        }

        static string
        f_1471_21844_21896()
        {
            var return_v = MshHostRawUserInterfaceStrings.LessThanErrorTemplate;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 21844, 21896);
            return return_v;
        }


        static System.Management.Automation.PSArgumentException
        f_1471_21800_21914(string
        paramName, string
        resourceString, params object[]
        args)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 21800, 21914);
            return return_v;
        }


        static string
        f_1471_22106_22158()
        {
            var return_v = MshHostRawUserInterfaceStrings.LessThanErrorTemplate;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 22106, 22158);
            return return_v;
        }


        static System.Management.Automation.PSArgumentException
        f_1471_22061_22176(string
        paramName, string
        resourceString, params object[]
        args)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 22061, 22176);
            return return_v;
        }


        static int
        f_1471_23129_23140_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1471, 23036, 23204);
            return return_v;
        }

    }

    public
        struct BufferCell
    {

        private char character;

        private ConsoleColor foregroundColor;

        private ConsoleColor backgroundColor;

        private BufferCellType bufferCellType;

        public char Character
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 28218, 28243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 28224, 28241);

                    return character;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 28218, 28243);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 28172, 28296);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 28172, 28296);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 28259, 28285);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 28265, 28283);

                    character = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 28259, 28285);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 28172, 28296);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 28172, 28296);
                }
            }
        }

        public ConsoleColor ForegroundColor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 28629, 28660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 28635, 28658);

                    return foregroundColor;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 28629, 28660);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 28569, 28719);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 28569, 28719);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 28676, 28708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 28682, 28706);

                    foregroundColor = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 28676, 28708);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 28569, 28719);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 28569, 28719);
                }
            }
        }

        public ConsoleColor BackgroundColor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 28889, 28920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 28895, 28918);

                    return backgroundColor;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 28889, 28920);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 28829, 28979);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 28829, 28979);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 28936, 28968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 28942, 28966);

                    backgroundColor = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 28936, 28968);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 28829, 28979);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 28829, 28979);
                }
            }
        }

        public BufferCellType BufferCellType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 29144, 29174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 29150, 29172);

                    return bufferCellType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 29144, 29174);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 29083, 29232);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 29083, 29232);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 29190, 29221);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 29196, 29219);

                    bufferCellType = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 29190, 29221);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 29083, 29232);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 29083, 29232);
                }
            }
        }

        public
                BufferCell(char character, ConsoleColor foreground, ConsoleColor background, BufferCellType bufferCellType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1471, 29915, 30248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 30063, 30090);

                this.character = character;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 30104, 30138);

                this.foregroundColor = foreground;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 30152, 30186);

                this.backgroundColor = background;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 30200, 30237);

                this.bufferCellType = bufferCellType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1471, 29915, 30248);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 29915, 30248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 29915, 30248);
            }
        }

        public override
                string
                ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 30550, 30770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 30626, 30759);

                return f_1471_30633_30758(f_1471_30647_30675(), "'{0}' {1} {2} {3}", Character, ForegroundColor, BackgroundColor, BufferCellType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 30550, 30770);

                System.Globalization.CultureInfo
                f_1471_30647_30675()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 30647, 30675);
                    return return_v;
                }


                string
                f_1471_30633_30758(System.Globalization.CultureInfo
                provider, string
                format, params object?[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 30633, 30758);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 30550, 30770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 30550, 30770);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override
                bool
                Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 31251, 31515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 31333, 31353);

                bool
                result = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 31369, 31474) || true) && (obj is BufferCell)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 31369, 31474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 31424, 31459);

                    result = this == ((BufferCell)obj);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 31369, 31474);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 31490, 31504);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 31251, 31515);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 31251, 31515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 31251, 31515);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override
                int
                GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 31932, 32439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 32216, 32279);

                UInt32
                i32 = ((uint)(ForegroundColor ^ BackgroundColor)) << 16
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 32328, 32353);

                i32 |= (UInt16)Character;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 32367, 32398);

                int
                result = f_1471_32380_32397(i32)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 32414, 32428);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 31932, 32439);

                int
                f_1471_32380_32397(uint
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 32380, 32397);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 31932, 32439);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 31932, 32439);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static
                bool
                operator ==(BufferCell first, BufferCell second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1471, 32921, 33354);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 33031, 33313);

                bool
                result = first.Character == second.Character && (DynAbs.Tracing.TraceSender.Expression_True(1471, 33045, 33158) && first.BackgroundColor == second.BackgroundColor) && (DynAbs.Tracing.TraceSender.Expression_True(1471, 33045, 33236) && first.ForegroundColor == second.ForegroundColor) && (DynAbs.Tracing.TraceSender.Expression_True(1471, 33045, 33312) && first.BufferCellType == second.BufferCellType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 33329, 33343);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1471, 32921, 33354);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 32921, 33354);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 32921, 33354);
            }
        }

        public static
                bool
                operator !=(BufferCell first, BufferCell second)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1471, 33862, 34009);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 33972, 33998);

                return !(first == second);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1471, 33862, 34009);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 33862, 34009);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 33862, 34009);
            }
        }

        private const string
        StringsBaseName = "MshHostRawUserInterfaceStrings"
        ;
        static BufferCell()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1471, 27711, 34100);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 34042, 34092);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1471, 27711, 34100);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 27711, 34100);
        }
    }

    /// <summary>
    /// Defines three types of BufferCells to accommodate for hosts that use up to two cells
    /// to display a character in some languages such as Chinese and Japanese.
    /// </summary>

    public enum
    BufferCellType
    {
        /// <summary>
        /// Character occupies one BufferCell.
        /// </summary>

        Complete,

        /// <summary>
        /// Character occupies two BufferCells and this is the leading one.
        /// </summary>

        Leading,

        /// <summary>
        /// Preceded by a Leading BufferCell.
        /// </summary>

        Trailing
    }
    public abstract
        class PSHostRawUserInterface
    {
        protected
                PSHostRawUserInterface()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1471, 35943, 36035);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1471, 35943, 36035);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 35943, 36035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 35943, 36035);
            }
        }

        public abstract
                ConsoleColor
                ForegroundColor
        {
            get;
            set;
        }

        public abstract
                ConsoleColor
                BackgroundColor
        {
            get;
            set;
        }

        public abstract
                Coordinates
                CursorPosition
        {
            get;
            set;
        }

        public abstract
                Coordinates
                WindowPosition
        {
            get;
            set;
        }

        public abstract
                int
                CursorSize
        {
            get;
            set;
        }

        public abstract
                Size
                BufferSize
        {
            get;
            set;
        }

        public abstract
                Size
                WindowSize
        {
            get;
            set;
        }

        public abstract
                Size
                MaxWindowSize
        {
            get;
        }

        public abstract
                Size
                MaxPhysicalWindowSize
        {
            get;
        }

        public
                KeyInfo
                ReadKey()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 45037, 45161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 45104, 45150);

                return f_1471_45111_45149(this, ReadKeyOptions.IncludeKeyDown);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 45037, 45161);

                System.Management.Automation.Host.KeyInfo
                f_1471_45111_45149(System.Management.Automation.Host.PSHostRawUserInterface
                this_param, System.Management.Automation.Host.ReadKeyOptions
                options)
                {
                    var return_v = this_param.ReadKey(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 45111, 45149);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 45037, 45161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 45037, 45161);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract
                KeyInfo
                ReadKey(ReadKeyOptions options);

        public abstract
                void
                FlushInputBuffer();

        public abstract
                bool
                KeyAvailable
        {
            get;
        }

        public abstract
                string
                WindowTitle
        {
            get;
            set;
        }

        public abstract
                void
                SetBufferContents(Coordinates origin, BufferCell[,] contents);

        public abstract
                void
                SetBufferContents(Rectangle rectangle, BufferCell fill);

        public abstract
                BufferCell[,]
                GetBufferContents(Rectangle rectangle);

        public abstract
                void
                ScrollBufferContents
                (
                    Rectangle source,
                    Coordinates destination,
                    Rectangle clip,
                    BufferCell fill
                );

        public virtual
                int
                LengthInBufferCells
                (
                    string source,
                    int offset
                )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 59435, 60093);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 59590, 59712) || true) && (source == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 59590, 59712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 59642, 59697);

                    throw f_1471_59648_59696("source");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 59590, 59712);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 59958, 60025);

                string
                substring = (DynAbs.Tracing.TraceSender.Conditional_F1(1471, 59977, 59988) || ((offset == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1471, 59991, 59997)) || DynAbs.Tracing.TraceSender.Conditional_F3(1471, 60000, 60024))) ? source : f_1471_60000_60024(source, offset)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 60039, 60082);

                return f_1471_60046_60081(this, substring);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 59435, 60093);

                System.Management.Automation.PSArgumentNullException
                f_1471_59648_59696(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 59648, 59696);
                    return return_v;
                }


                string
                f_1471_60000_60024(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 60000, 60024);
                    return return_v;
                }


                int
                f_1471_60046_60081(System.Management.Automation.Host.PSHostRawUserInterface
                this_param, string
                source)
                {
                    var return_v = this_param.LengthInBufferCells(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 60046, 60081);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 59435, 60093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 59435, 60093);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual
                int
                LengthInBufferCells
                (
                    string source
                )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 61581, 61881);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 61711, 61833) || true) && (source == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 61711, 61833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 61763, 61818);

                    throw f_1471_61769_61817("source");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 61711, 61833);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 61849, 61870);

                return f_1471_61856_61869(source);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 61581, 61881);

                System.Management.Automation.PSArgumentNullException
                f_1471_61769_61817(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 61769, 61817);
                    return return_v;
                }


                int
                f_1471_61856_61869(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 61856, 61869);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 61581, 61881);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 61581, 61881);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual
                int
                LengthInBufferCells
                (
                    char source
                )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 63217, 63365);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 63345, 63354);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 63217, 63365);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 63217, 63365);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 63217, 63365);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public
                BufferCell[,]
                NewBufferCellArray(string[] contents, ConsoleColor foregroundColor, ConsoleColor backgroundColor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 66834, 69635);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 67028, 67154) || true) && (contents == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 67028, 67154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 67082, 67139);

                    throw f_1471_67088_67138("contents");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 67028, 67154);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 67170, 67221);

                byte[][]
                charLengths = new byte[f_1471_67202_67217(contents)][]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 67235, 67272);

                int
                maxStringLengthInBufferCells = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 67295, 67300);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 67286, 68027) || true) && (i < f_1471_67306_67321(contents))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 67323, 67326)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 67286, 68027))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 67286, 68027);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 67360, 67467) || true) && (f_1471_67364_67397(contents[i]))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 67360, 67467);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 67439, 67448);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 67360, 67467);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 67487, 67515);

                        int
                        lengthInBufferCells = 0
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 67533, 67579);

                        charLengths[i] = new byte[f_1471_67559_67577(contents[i])];
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 67606, 67611);
                            for (int
            j = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 67597, 67826) || true) && (j < f_1471_67617_67635(contents[i]))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 67637, 67640)
            , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 67597, 67826))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 67597, 67826);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 67682, 67744);

                                charLengths[i][j] = (byte)f_1471_67708_67743(this, f_1471_67728_67742(contents[i], j));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 67766, 67807);

                                lengthInBufferCells += charLengths[i][j];
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1471, 1, 230);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1471, 1, 230);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 67846, 68012) || true) && (maxStringLengthInBufferCells < lengthInBufferCells)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 67846, 68012);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 67942, 67993);

                            maxStringLengthInBufferCells = lengthInBufferCells;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 67846, 68012);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1471, 1, 742);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1471, 1, 742);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 68043, 68249) || true) && (maxStringLengthInBufferCells <= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 68043, 68249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 68114, 68234);

                    throw f_1471_68120_68233("contents", f_1471_68167_68232());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 68043, 68249);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 68265, 68351);

                BufferCell[,]
                results = new BufferCell[f_1471_68304_68319(contents), maxStringLengthInBufferCells]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 68374, 68379);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 68365, 69562) || true) && (i < f_1471_68385_68400(contents))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 68402, 68405)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 68365, 69562))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 68365, 69562);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 68439, 68455);

                        int
                        resultJ = 0
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 68482, 68487);
                            for (int
            j = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 68473, 69290) || true) && (j < f_1471_68493_68511(contents[i]))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 68513, 68516)
            , j++, DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 68518, 68527)
            , resultJ++, DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 68473, 69290))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 68473, 69290);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 68569, 69271) || true) && (charLengths[i][j] == 1)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 68569, 69271);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 68645, 68786);

                                    results[i, resultJ] =
                                    f_1471_68696_68785(f_1471_68711_68725(contents[i], j), foregroundColor, backgroundColor, BufferCellType.Complete);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 68569, 69271);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 68569, 69271);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 68836, 69271) || true) && (charLengths[i][j] == 2)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 68836, 69271);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 68912, 69052);

                                        results[i, resultJ] =
                                        f_1471_68963_69051(f_1471_68978_68992(contents[i], j), foregroundColor, backgroundColor, BufferCellType.Leading);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 69078, 69088);

                                        resultJ++;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 69114, 69248);

                                        results[i, resultJ] =
                                        f_1471_69165_69247((char)0, foregroundColor, backgroundColor, BufferCellType.Trailing);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 68836, 69271);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 68569, 69271);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1471, 1, 818);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1471, 1, 818);
                        }
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 69308, 69547) || true) && (resultJ < maxStringLengthInBufferCells)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 69308, 69547);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 69395, 69496);

                                results[i, resultJ] = f_1471_69417_69495(' ', foregroundColor, backgroundColor, BufferCellType.Complete);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 69518, 69528);

                                resultJ++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 69308, 69547);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1471, 69308, 69547);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1471, 69308, 69547);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1471, 1, 1198);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1471, 1, 1198);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 69578, 69593);

                return results;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 66834, 69635);

                System.Management.Automation.PSArgumentNullException
                f_1471_67088_67138(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 67088, 67138);
                    return return_v;
                }


                int
                f_1471_67202_67217(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 67202, 67217);
                    return return_v;
                }


                int
                f_1471_67306_67321(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 67306, 67321);
                    return return_v;
                }


                bool
                f_1471_67364_67397(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 67364, 67397);
                    return return_v;
                }


                int
                f_1471_67559_67577(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 67559, 67577);
                    return return_v;
                }


                int
                f_1471_67617_67635(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 67617, 67635);
                    return return_v;
                }


                char
                f_1471_67728_67742(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 67728, 67742);
                    return return_v;
                }


                int
                f_1471_67708_67743(System.Management.Automation.Host.PSHostRawUserInterface
                this_param, char
                source)
                {
                    var return_v = this_param.LengthInBufferCells(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 67708, 67743);
                    return return_v;
                }


                string
                f_1471_68167_68232()
                {
                    var return_v = MshHostRawUserInterfaceStrings.AllNullOrEmptyStringsErrorTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 68167, 68232);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1471_68120_68233(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 68120, 68233);
                    return return_v;
                }


                int
                f_1471_68304_68319(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 68304, 68319);
                    return return_v;
                }


                int
                f_1471_68385_68400(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 68385, 68400);
                    return return_v;
                }


                int
                f_1471_68493_68511(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 68493, 68511);
                    return return_v;
                }


                char
                f_1471_68711_68725(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 68711, 68725);
                    return return_v;
                }


                System.Management.Automation.Host.BufferCell
                f_1471_68696_68785(char
                character, System.ConsoleColor
                foreground, System.ConsoleColor
                background, System.Management.Automation.Host.BufferCellType
                bufferCellType)
                {
                    var return_v = new System.Management.Automation.Host.BufferCell(character, foreground, background, bufferCellType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 68696, 68785);
                    return return_v;
                }


                char
                f_1471_68978_68992(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 68978, 68992);
                    return return_v;
                }


                System.Management.Automation.Host.BufferCell
                f_1471_68963_69051(char
                character, System.ConsoleColor
                foreground, System.ConsoleColor
                background, System.Management.Automation.Host.BufferCellType
                bufferCellType)
                {
                    var return_v = new System.Management.Automation.Host.BufferCell(character, foreground, background, bufferCellType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 68963, 69051);
                    return return_v;
                }


                System.Management.Automation.Host.BufferCell
                f_1471_69165_69247(int
                character, System.ConsoleColor
                foreground, System.ConsoleColor
                background, System.Management.Automation.Host.BufferCellType
                bufferCellType)
                {
                    var return_v = new System.Management.Automation.Host.BufferCell((char)character, foreground, background, bufferCellType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 69165, 69247);
                    return return_v;
                }


                System.Management.Automation.Host.BufferCell
                f_1471_69417_69495(char
                character, System.ConsoleColor
                foreground, System.ConsoleColor
                background, System.Management.Automation.Host.BufferCellType
                bufferCellType)
                {
                    var return_v = new System.Management.Automation.Host.BufferCell(character, foreground, background, bufferCellType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 69417, 69495);
                    return return_v;
                }

#pragma warning restore 56506
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 66834, 69635);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 66834, 69635);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public
                BufferCell[,]
                NewBufferCellArray(int width, int height, BufferCell contents)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 72633, 74864);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 72759, 73029) || true) && (width <= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 72759, 73029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 72854, 73014);

                    throw f_1471_72860_73013("width", width, f_1471_72942_73003(), "width");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 72759, 73029);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 73045, 73320) || true) && (height <= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 73045, 73320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 73142, 73305);

                    throw f_1471_73148_73304("height", height, f_1471_73232_73293(), "height");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 73045, 73320);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 73336, 73389);

                BufferCell[,]
                buffer = new BufferCell[height, width]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 73403, 73460);

                int
                charLength = f_1471_73420_73459(this, contents.Character)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 73474, 74823) || true) && (charLength == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 73474, 74823);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 73536, 73541);
                        for (int
        r = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 73527, 73853) || true) && (r < f_1471_73547_73566(buffer, 0))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 73568, 73571)
        , ++r, DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 73527, 73853))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 73527, 73853);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 73622, 73627);
                                for (int
            c = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 73613, 73834) || true) && (c < f_1471_73633_73652(buffer, 1))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 73654, 73657)
            , ++c, DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 73613, 73834))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 73613, 73834);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 73707, 73731);

                                    buffer[r, c] = contents;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 73757, 73811);

                                    buffer[r, c].BufferCellType = BufferCellType.Complete;
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1471, 1, 222);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1471, 1, 222);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1471, 1, 327);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1471, 1, 327);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 73474, 74823);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 73474, 74823);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 73887, 74823) || true) && (charLength == 2)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 73887, 74823);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 73940, 73997);

                        int
                        normalizedWidth = (DynAbs.Tracing.TraceSender.Conditional_F1(1471, 73962, 73976) || ((width % 2 == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1471, 73979, 73984)) || DynAbs.Tracing.TraceSender.Conditional_F3(1471, 73987, 73996))) ? width : width - 1
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 74024, 74029);
                            for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 74015, 74808) || true) && (i < height)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 74043, 74046)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 74015, 74808))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 74015, 74808);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 74097, 74102);
                                    for (int
                j = 0
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 74088, 74534) || true) && (j < normalizedWidth)
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 74125, 74128)
                , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 74088, 74534))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 74088, 74534);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 74178, 74202);

                                        buffer[i, j] = contents;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 74228, 74281);

                                        buffer[i, j].BufferCellType = BufferCellType.Leading;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 74307, 74311);

                                        j++;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 74337, 74511);

                                        buffer[i, j] = f_1471_74352_74510((char)0, contents.ForegroundColor, contents.BackgroundColor, BufferCellType.Trailing);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1471, 1, 447);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1471, 1, 447);
                                }
                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 74558, 74789) || true) && (normalizedWidth < width)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1471, 74558, 74789);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 74635, 74673);

                                    buffer[i, normalizedWidth] = contents;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 74699, 74766);

                                    buffer[i, normalizedWidth].BufferCellType = BufferCellType.Leading;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 74558, 74789);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1471, 1, 794);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1471, 1, 794);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 73887, 74823);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1471, 73474, 74823);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 74839, 74853);

                return buffer;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 72633, 74864);

                string
                f_1471_72942_73003()
                {
                    var return_v = MshHostRawUserInterfaceStrings.NonPositiveNumberErrorTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 72942, 73003);
                    return return_v;
                }


                System.Management.Automation.PSArgumentOutOfRangeException
                f_1471_72860_73013(string
                paramName, int
                actualValue, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 72860, 73013);
                    return return_v;
                }


                string
                f_1471_73232_73293()
                {
                    var return_v = MshHostRawUserInterfaceStrings.NonPositiveNumberErrorTemplate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1471, 73232, 73293);
                    return return_v;
                }


                System.Management.Automation.PSArgumentOutOfRangeException
                f_1471_73148_73304(string
                paramName, int
                actualValue, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 73148, 73304);
                    return return_v;
                }


                int
                f_1471_73420_73459(System.Management.Automation.Host.PSHostRawUserInterface
                this_param, char
                source)
                {
                    var return_v = this_param.LengthInBufferCells(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 73420, 73459);
                    return return_v;
                }


                int
                f_1471_73547_73566(System.Management.Automation.Host.BufferCell[,]
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetLength(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 73547, 73566);
                    return return_v;
                }


                int
                f_1471_73633_73652(System.Management.Automation.Host.BufferCell[,]
                this_param, int
                dimension)
                {
                    var return_v = this_param.GetLength(dimension);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 73633, 73652);
                    return return_v;
                }


                System.Management.Automation.Host.BufferCell
                f_1471_74352_74510(int
                character, System.ConsoleColor
                foreground, System.ConsoleColor
                background, System.Management.Automation.Host.BufferCellType
                bufferCellType)
                {
                    var return_v = new System.Management.Automation.Host.BufferCell((char)character, foreground, background, bufferCellType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 74352, 74510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 72633, 74864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 72633, 74864);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public
                BufferCell[,]
                NewBufferCellArray(Size size, BufferCell contents)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1471, 76680, 76866);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1471, 76794, 76855);

                return f_1471_76801_76854(this, size.Width, size.Height, contents);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1471, 76680, 76866);

                System.Management.Automation.Host.BufferCell[,]
                f_1471_76801_76854(System.Management.Automation.Host.PSHostRawUserInterface
                this_param, int
                width, int
                height, System.Management.Automation.Host.BufferCell
                contents)
                {
                    var return_v = this_param.NewBufferCellArray(width, height, contents);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1471, 76801, 76854);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1471, 76680, 76866);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 76680, 76866);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSHostRawUserInterface()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1471, 35721, 76873);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1471, 35721, 76873);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1471, 35721, 76873);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1471, 35721, 76873);
    }
}
