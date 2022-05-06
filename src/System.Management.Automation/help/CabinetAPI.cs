// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics.CodeAnalysis;

namespace System.Management.Automation.Internal
{
    internal abstract class ICabinetExtractor : IDisposable
    {
        internal abstract bool Extract(string cabinetName, string srcPath, string destPath);

        private bool _disposed;

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1143, 1431, 1542);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1143, 1477, 1491);

                f_1143_1477_1490(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1143, 1505, 1531);

                f_1143_1505_1530(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1143, 1431, 1542);

                int
                f_1143_1477_1490(System.Management.Automation.Internal.ICabinetExtractor
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1143, 1477, 1490);
                    return 0;
                }


                int
                f_1143_1505_1530(System.Management.Automation.Internal.ICabinetExtractor
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1143, 1505, 1530);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1143, 1431, 1542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1143, 1431, 1542);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1143, 1554, 1981);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1143, 1625, 1774) || true) && (_disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1143, 1625, 1774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1143, 1752, 1759);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1143, 1625, 1774);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1143, 1953, 1970);

                _disposed = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1143, 1554, 1981);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1143, 1554, 1981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1143, 1554, 1981);
            }
        }

        ~ICabinetExtractor()
        {
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1143, 2038, 2053);

            f_1143_2038_2052(this, false);
        }

        public ICabinetExtractor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1143, 373, 2093);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1143, 1295, 1312);
            this._disposed = false;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1143, 373, 2093);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1143, 373, 2093);
        }


        static ICabinetExtractor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1143, 373, 2093);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1143, 373, 2093);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1143, 373, 2093);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1143, 373, 2093);

        int
        f_1143_2038_2052(System.Management.Automation.Internal.ICabinetExtractor
        this_param, bool
        disposing)
        {
            this_param.Dispose(disposing);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1143, 2038, 2052);
            return 0;
        }

    }
    internal abstract class ICabinetExtractorLoader
    {
        internal virtual ICabinetExtractor GetCabinetExtractor()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1143, 2489, 2562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1143, 2548, 2560);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1143, 2489, 2562);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1143, 2489, 2562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1143, 2489, 2562);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ICabinetExtractorLoader()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1143, 2425, 2569);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1143, 2425, 2569);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1143, 2425, 2569);
        }


        static ICabinetExtractorLoader()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1143, 2425, 2569);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1143, 2425, 2569);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1143, 2425, 2569);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1143, 2425, 2569);
    }
    internal class CabinetExtractorFactory
    {
        private static ICabinetExtractorLoader s_cabinetLoader;

        internal static ICabinetExtractor EmptyExtractor;

        [SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", MessageId = "System.Reflection.Assembly.LoadFrom")]
        static CabinetExtractorFactory()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1143, 2957, 3224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1143, 2760, 2775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1143, 2820, 2864);
                EmptyExtractor = f_1143_2837_2864();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1143, 3158, 3213);

                s_cabinetLoader = f_1143_3176_3212();
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1143, 2957, 3224);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1143, 2957, 3224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1143, 2957, 3224);
            }
        }

        internal static ICabinetExtractor GetCabinetExtractor()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1143, 3383, 3683);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1143, 3463, 3672) || true) && (s_cabinetLoader != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1143, 3463, 3672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1143, 3524, 3569);

                    return f_1143_3531_3568(s_cabinetLoader);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1143, 3463, 3672);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1143, 3463, 3672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1143, 3635, 3657);

                    return EmptyExtractor;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1143, 3463, 3672);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1143, 3383, 3683);

                System.Management.Automation.Internal.ICabinetExtractor
                f_1143_3531_3568(System.Management.Automation.Internal.ICabinetExtractorLoader
                this_param)
                {
                    var return_v = this_param.GetCabinetExtractor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1143, 3531, 3568);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1143, 3383, 3683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1143, 3383, 3683);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CabinetExtractorFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1143, 2666, 3690);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1143, 2666, 3690);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1143, 2666, 3690);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1143, 2666, 3690);

        static System.Management.Automation.Internal.EmptyCabinetExtractor
        f_1143_2837_2864()
        {
            var return_v = new System.Management.Automation.Internal.EmptyCabinetExtractor();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1143, 2837, 2864);
            return return_v;
        }


        static System.Management.Automation.Internal.CabinetExtractorLoader
        f_1143_3176_3212()
        {
            var return_v = CabinetExtractorLoader.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1143, 3176, 3212);
            return return_v;
        }

    }
    internal sealed class EmptyCabinetExtractor : ICabinetExtractor
    {
        internal override bool Extract(string cabinetName, string srcPath, string destPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1143, 4218, 4417);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1143, 4393, 4406);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1143, 4218, 4417);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1143, 4218, 4417);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1143, 4218, 4417);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1143, 4558, 4837);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1143, 4558, 4837);
                // it's intentional that this method has no definition since there is nothing to dispose.
                // If a resource is added to this class, it should implement IDisposable for derived classes.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1143, 4558, 4837);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1143, 4558, 4837);
            }
        }

        public EmptyCabinetExtractor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1143, 3786, 4844);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1143, 3786, 4844);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1143, 3786, 4844);
        }


        static EmptyCabinetExtractor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1143, 3786, 4844);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1143, 3786, 4844);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1143, 3786, 4844);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1143, 3786, 4844);
    }
}

