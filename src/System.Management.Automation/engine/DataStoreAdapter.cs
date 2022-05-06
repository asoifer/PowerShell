// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#pragma warning disable 1634, 1691

using System.Threading;
using Dbg = System.Management.Automation;

namespace System.Management.Automation
{
    public class PSDriveInfo : IComparable
    {
        [Dbg.TraceSourceAttribute(
                     "PSDriveInfo",
                     "The namespace navigation tracer")]
        private static Dbg.PSTraceSource s_tracer;

        public string CurrentLocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1261, 1600, 1683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 1636, 1668);

                    return _currentWorkingDirectory;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1261, 1600, 1683);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 1546, 1794);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 1546, 1794);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1261, 1699, 1783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 1735, 1768);

                    _currentWorkingDirectory = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1261, 1699, 1783);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 1546, 1794);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 1546, 1794);
                }
            }
        }

        private string _currentWorkingDirectory;

        public string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1261, 2144, 2208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 2180, 2193);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1261, 2144, 2208);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 2101, 2219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 2101, 2219);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _name;

        public ProviderInfo Provider
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1261, 2551, 2619);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 2587, 2604);

                    return _provider;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1261, 2551, 2619);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 2498, 2630);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 2498, 2630);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ProviderInfo _provider;

        public string Root
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1261, 2985, 3049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 3021, 3034);

                    return _root;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1261, 2985, 3049);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 2942, 3150);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 2942, 3150);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            internal set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1261, 3065, 3139);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 3110, 3124);

                    _root = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1261, 3065, 3139);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 2942, 3150);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 2942, 3150);
                }
            }
        }

        internal void SetRoot(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1261, 3877, 4295);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 3936, 4054) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 3936, 4054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 3986, 4039);

                    throw f_1261_3992_4038("path");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 3936, 4054);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 4070, 4255) || true) && (f_1261_4074_4092_M(!DriveBeingCreated))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 4070, 4255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 4126, 4214);

                    NotSupportedException
                    e =
                    f_1261_4173_4213()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 4232, 4240);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 4070, 4255);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 4271, 4284);

                _root = path;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1261, 3877, 4295);

                System.Management.Automation.PSArgumentNullException
                f_1261_3992_4038(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 3992, 4038);
                    return return_v;
                }


                bool
                f_1261_4074_4092_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 4074, 4092);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1261_4173_4213()
                {
                    var return_v = PSTraceSource.NewNotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 4173, 4213);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 3877, 4295);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 3877, 4295);
            }
        }

        private string _root;

        public string Description { get; set; }

        public long? MaximumSize { get; internal set; }

        public PSCredential Credential { get; }

        internal bool DriveBeingCreated { get; set; }

        internal bool IsAutoMounted { get; set; }

        internal bool IsAutoMountedManuallyRemoved { get; set; }

        internal bool Persist { get; }

        internal bool IsNetworkDrive { get; set; }

        public string DisplayRoot { get; internal set; }

        public bool VolumeSeparatedByColon { get; internal set; }

        protected PSDriveInfo(PSDriveInfo driveInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1261, 10157, 10934);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 1976, 2000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 2337, 2342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 2827, 2836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 4413, 4418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 4535, 4574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 4710, 4757);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 4872, 4933);
                this.Credential = f_1261_4914_4932();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 5324, 5369);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 5549, 5590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 5763, 5819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 6064, 6103);
                this.Persist = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 6249, 6300);
                this.IsNetworkDrive = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 6565, 6621);
                this.DisplayRoot = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 9273, 9338);
                this.VolumeSeparatedByColon = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 17739, 17746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 28732, 28745);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 10226, 10354) || true) && (driveInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 10226, 10354);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 10281, 10339);

                    throw f_1261_10287_10338("driveInfo");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 10226, 10354);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 10370, 10393);

                _name = f_1261_10378_10392(driveInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 10407, 10438);

                _provider = f_1261_10419_10437(driveInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 10452, 10486);

                Credential = f_1261_10465_10485(driveInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 10500, 10553);

                _currentWorkingDirectory = f_1261_10527_10552(driveInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 10567, 10603);

                Description = f_1261_10581_10602(driveInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 10617, 10658);

                this.MaximumSize = f_1261_10636_10657(driveInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 10672, 10720);

                DriveBeingCreated = f_1261_10692_10719(driveInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 10734, 10762);

                _hidden = driveInfo._hidden;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 10776, 10816);

                IsAutoMounted = f_1261_10792_10815(driveInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 10830, 10854);

                _root = driveInfo._root;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 10868, 10896);

                Persist = f_1261_10878_10895(driveInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 10910, 10923);

                f_1261_10910_10922(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1261, 10157, 10934);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 10157, 10934);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 10157, 10934);
            }
        }

        public PSDriveInfo(
                    string name,
                    ProviderInfo provider,
                    string root,
                    string description,
                    PSCredential credential)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1261, 12061, 13410);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 1976, 2000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 2337, 2342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 2827, 2836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 4413, 4418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 4535, 4574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 4710, 4757);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 4872, 4933);
                this.Credential = f_1261_4914_4932();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 5324, 5369);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 5549, 5590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 5763, 5819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 6064, 6103);
                this.Persist = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 6249, 6300);
                this.IsNetworkDrive = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 6565, 6621);
                this.DisplayRoot = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 9273, 9338);
                this.VolumeSeparatedByColon = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 17739, 17746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 28732, 28745);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 12304, 12422) || true) && (name == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 12304, 12422);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 12354, 12407);

                    throw f_1261_12360_12406("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 12304, 12422);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 12438, 12564) || true) && (provider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 12438, 12564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 12492, 12549);

                    throw f_1261_12498_12548("provider");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 12438, 12564);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 12580, 12698) || true) && (root == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 12580, 12698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 12630, 12683);

                    throw f_1261_12636_12682("root");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 12580, 12698);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 12773, 12786);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 12800, 12821);

                _provider = provider;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 12835, 12848);

                _root = root;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 12862, 12888);

                Description = description;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 12904, 12999) || true) && (credential != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 12904, 12999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 12960, 12984);

                    Credential = credential;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 12904, 12999);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 13137, 13177);

                _currentWorkingDirectory = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 13193, 13331);

                f_1261_13193_13330(_currentWorkingDirectory != null, "The currentWorkingDirectory cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 13386, 13399);

                f_1261_13386_13398(
                            // Trace out the fields

                            this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1261, 12061, 13410);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 12061, 13410);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 12061, 13410);
            }
        }

        public PSDriveInfo(
                    string name,
                    ProviderInfo provider,
                    string root,
                    string description,
                    PSCredential credential, string displayRoot)
        : this(f_1261_15001_15005_C(name), provider, root, description, credential)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1261, 14782, 15109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 15072, 15098);

                DisplayRoot = displayRoot;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1261, 14782, 15109);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 14782, 15109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 14782, 15109);
            }
        }

        public PSDriveInfo(
                    string name,
                    ProviderInfo provider,
                    string root,
                    string description,
                    PSCredential credential,
                    bool persist)
        : this(f_1261_16633_16637_C(name), provider, root, description, credential)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1261, 16407, 16733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 16704, 16722);

                Persist = persist;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1261, 16407, 16733);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 16407, 16733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 16407, 16733);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1261, 16981, 17062);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 17039, 17051);

                return f_1261_17046_17050();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1261, 16981, 17062);

                string
                f_1261_17046_17050()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 17046, 17050);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 16981, 17062);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 16981, 17062);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool Hidden
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1261, 17438, 17504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 17474, 17489);

                    return _hidden;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1261, 17438, 17504);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 17393, 17598);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 17393, 17598);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1261, 17520, 17587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 17556, 17572);

                    _hidden = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1261, 17520, 17587);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 17393, 17598);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 17393, 17598);
                }
            }
        }

        private bool _hidden;

        internal void SetName(string newName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1261, 18409, 18648);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 18471, 18605) || true) && (f_1261_18475_18504(newName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 18471, 18605);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 18538, 18590);

                    throw f_1261_18544_18589("newName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 18471, 18605);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 18621, 18637);

                _name = newName;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1261, 18409, 18648);

                bool
                f_1261_18475_18504(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 18475, 18504);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1261_18544_18589(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 18544, 18589);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 18409, 18648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 18409, 18648);
            }
        }

        internal void SetProvider(ProviderInfo newProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1261, 19427, 19686);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 19503, 19635) || true) && (newProvider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 19503, 19635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 19560, 19620);

                    throw f_1261_19566_19619("newProvider");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 19503, 19635);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 19651, 19675);

                _provider = newProvider;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1261, 19427, 19686);

                System.Management.Automation.PSArgumentNullException
                f_1261_19566_19619(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 19566, 19619);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 19427, 19686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 19427, 19686);
            }
        }

        internal void Trace()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1261, 19784, 20774);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 19830, 19889);

                f_1261_19830_19888(s_tracer, "A drive was found:");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 19905, 20053) || true) && (f_1261_19909_19913() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 19905, 20053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 19955, 20038);

                    f_1261_19955_20037(s_tracer, "\tName: {0}", f_1261_20032_20036());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 19905, 20053);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 20069, 20229) || true) && (f_1261_20073_20081() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 20069, 20229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 20123, 20214);

                    f_1261_20123_20213(s_tracer, "\tProvider: {0}", f_1261_20204_20212());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 20069, 20229);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 20245, 20393) || true) && (f_1261_20249_20253() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 20245, 20393);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 20295, 20378);

                    f_1261_20295_20377(s_tracer, "\tRoot: {0}", f_1261_20372_20376());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 20245, 20393);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 20409, 20578) || true) && (f_1261_20413_20428() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 20409, 20578);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 20470, 20563);

                    f_1261_20470_20562(s_tracer, "\tCWD: {0}", f_1261_20546_20561());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 20409, 20578);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 20594, 20763) || true) && (f_1261_20598_20609() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 20594, 20763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 20651, 20748);

                    f_1261_20651_20747(s_tracer, "\tDescription: {0}", f_1261_20735_20746());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 20594, 20763);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1261, 19784, 20774);

                int
                f_1261_19830_19888(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 19830, 19888);
                    return 0;
                }


                string
                f_1261_19909_19913()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 19909, 19913);
                    return return_v;
                }


                string
                f_1261_20032_20036()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 20032, 20036);
                    return return_v;
                }


                int
                f_1261_19955_20037(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 19955, 20037);
                    return 0;
                }


                System.Management.Automation.ProviderInfo
                f_1261_20073_20081()
                {
                    var return_v = Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 20073, 20081);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1261_20204_20212()
                {
                    var return_v = Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 20204, 20212);
                    return return_v;
                }


                int
                f_1261_20123_20213(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Management.Automation.ProviderInfo
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 20123, 20213);
                    return 0;
                }


                string
                f_1261_20249_20253()
                {
                    var return_v = Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 20249, 20253);
                    return return_v;
                }


                string
                f_1261_20372_20376()
                {
                    var return_v = Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 20372, 20376);
                    return return_v;
                }


                int
                f_1261_20295_20377(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 20295, 20377);
                    return 0;
                }


                string
                f_1261_20413_20428()
                {
                    var return_v = CurrentLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 20413, 20428);
                    return return_v;
                }


                string
                f_1261_20546_20561()
                {
                    var return_v = CurrentLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 20546, 20561);
                    return return_v;
                }


                int
                f_1261_20470_20562(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 20470, 20562);
                    return 0;
                }


                string
                f_1261_20598_20609()
                {
                    var return_v = Description;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 20598, 20609);
                    return return_v;
                }


                string
                f_1261_20735_20746()
                {
                    var return_v = Description;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 20735, 20746);
                    return return_v;
                }


                int
                f_1261_20651_20747(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 20651, 20747);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 19784, 20774);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 19784, 20774);
            }
        }

        public int CompareTo(PSDriveInfo drive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1261, 21452, 21805);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 21549, 21669) || true) && (drive == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 21549, 21669);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 21600, 21654);

                    throw f_1261_21606_21653("drive");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 21549, 21669);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 21685, 21761);

                return f_1261_21692_21760(f_1261_21707_21711(), f_1261_21713_21723(drive), StringComparison.OrdinalIgnoreCase);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1261, 21452, 21805);

                System.Management.Automation.PSArgumentNullException
                f_1261_21606_21653(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 21606, 21653);
                    return return_v;
                }


                string
                f_1261_21707_21711()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 21707, 21711);
                    return return_v;
                }


                string
                f_1261_21713_21723(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 21713, 21723);
                    return return_v;
                }


                int
                f_1261_21692_21760(string
                strA, string
                strB, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Compare(strA, strB, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 21692, 21760);
                    return return_v;
                }


#pragma warning restore 56506
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 21452, 21805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 21452, 21805);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int CompareTo(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1261, 22353, 22796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 22410, 22449);

                PSDriveInfo
                drive = obj as PSDriveInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 22465, 22743) || true) && (drive == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 22465, 22743);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 22516, 22702);

                    ArgumentException
                    e =
                    f_1261_22559_22701("obj", f_1261_22652_22700())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 22720, 22728);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 22465, 22743);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 22759, 22785);

                return (f_1261_22767_22783(this, drive));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1261, 22353, 22796);

                string
                f_1261_22652_22700()
                {
                    var return_v = SessionStateStrings.OnlyAbleToComparePSDriveInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 22652, 22700);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1261_22559_22701(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 22559, 22701);
                    return return_v;
                }


                int
                f_1261_22767_22783(System.Management.Automation.PSDriveInfo
                this_param, System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.CompareTo(drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 22767, 22783);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 22353, 22796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 22353, 22796);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1261, 23117, 23369);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 23181, 23358) || true) && (obj is PSDriveInfo)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 23181, 23358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 23237, 23264);

                    return f_1261_23244_23258(this, obj) == 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 23181, 23358);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 23181, 23358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 23330, 23343);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 23181, 23358);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1261, 23117, 23369);

                int
                f_1261_23244_23258(System.Management.Automation.PSDriveInfo
                this_param, object
                obj)
                {
                    var return_v = this_param.CompareTo(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 23244, 23258);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 23117, 23369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 23117, 23369);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(PSDriveInfo drive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1261, 23692, 23794);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 23754, 23783);

                return f_1261_23761_23777(this, drive) == 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1261, 23692, 23794);

                int
                f_1261_23761_23777(System.Management.Automation.PSDriveInfo
                this_param, System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.CompareTo(drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 23761, 23777);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 23692, 23794);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 23692, 23794);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool operator ==(PSDriveInfo drive1, PSDriveInfo drive2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1261, 24355, 24875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 24450, 24479);

                object
                drive1Object = drive1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 24493, 24522);

                object
                drive2Object = drive2
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 24538, 24864) || true) && ((drive1Object == null) == (drive2Object == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 24538, 24864);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 24624, 24738) || true) && (drive1Object != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 24624, 24738);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 24690, 24719);

                        return f_1261_24697_24718(drive1, drive2);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 24624, 24738);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 24758, 24770);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 24538, 24864);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 24538, 24864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 24836, 24849);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 24538, 24864);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1261, 24355, 24875);

                bool
                f_1261_24697_24718(System.Management.Automation.PSDriveInfo
                this_param, System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.Equals(drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 24697, 24718);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 24355, 24875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 24355, 24875);
            }
        }

        public static bool operator !=(PSDriveInfo drive1, PSDriveInfo drive2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1261, 25433, 25566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 25528, 25555);

                return !(drive1 == drive2);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1261, 25433, 25566);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 25433, 25566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 25433, 25566);
            }
        }

        public static bool operator <(PSDriveInfo drive1, PSDriveInfo drive2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1261, 26097, 26850);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 26191, 26220);

                object
                drive1Object = drive1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 26234, 26263);

                object
                drive2Object = drive2
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 26279, 26839) || true) && (drive1Object == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 26279, 26839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 26337, 26367);

                    return (drive2Object != null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 26279, 26839);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 26279, 26839);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 26433, 26824) || true) && (drive2Object == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 26433, 26824);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 26593, 26606);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 26433, 26824);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 26433, 26824);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 26769, 26805);

                        return f_1261_26776_26800(drive1, drive2) < 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 26433, 26824);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 26279, 26839);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1261, 26097, 26850);

                int
                f_1261_26776_26800(System.Management.Automation.PSDriveInfo
                this_param, System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.CompareTo(drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 26776, 26800);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 26097, 26850);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 26097, 26850);
            }
        }

        public static bool operator >(PSDriveInfo drive1, PSDriveInfo drive2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1261, 27390, 28272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 27484, 27513);

                object
                drive1Object = drive1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 27527, 27556);

                object
                drive2Object = drive2
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 27572, 28261) || true) && ((drive1Object == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 27572, 28261);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 27777, 27790);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 27572, 28261);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 27572, 28261);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 27856, 28246) || true) && (drive2Object == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 27856, 28246);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 28016, 28028);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 27856, 28246);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 27856, 28246);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 28191, 28227);

                        return f_1261_28198_28222(drive1, drive2) > 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 27856, 28246);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 27572, 28261);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1261, 27390, 28272);

                int
                f_1261_28198_28222(System.Management.Automation.PSDriveInfo
                this_param, System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.CompareTo(drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 28198, 28222);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 27390, 28272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 27390, 28272);
            }
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1261, 28602, 28697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 28660, 28686);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetHashCode(), 1261, 28667, 28685);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1261, 28602, 28697);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 28602, 28697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 28602, 28697);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSNoteProperty _noteProperty;

        internal PSNoteProperty GetNotePropertyForProviderCmdlets(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1261, 28756, 29103);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 28851, 29055) || true) && (_noteProperty == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1261, 28851, 29055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 28910, 29040);

                    f_1261_28910_29039(ref _noteProperty, f_1261_29002_29032(name, this), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1261, 28851, 29055);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 29071, 29092);

                return _noteProperty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1261, 28756, 29103);

                System.Management.Automation.PSNoteProperty
                f_1261_29002_29032(string
                name, System.Management.Automation.PSDriveInfo
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 29002, 29032);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1261_28910_29039(ref System.Management.Automation.PSNoteProperty
                location1, System.Management.Automation.PSNoteProperty
                value, System.Management.Automation.PSNoteProperty
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 28910, 29039);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1261, 28756, 29103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 28756, 29103);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSDriveInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1261, 852, 29110);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1261, 1300, 1415);
            s_tracer = f_1261_1324_1415("PSDriveInfo", "The namespace navigation tracer");
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1261, 852, 29110);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1261, 852, 29110);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1261, 852, 29110);

        static System.Management.Automation.PSTraceSource
        f_1261_1324_1415(string
        name, string
        description)
        {
            var return_v = Dbg.PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 1324, 1415);
            return return_v;
        }


        System.Management.Automation.PSCredential
        f_1261_4914_4932()
        {
            var return_v = PSCredential.Empty;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 4914, 4932);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1261_10287_10338(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 10287, 10338);
            return return_v;
        }


        string
        f_1261_10378_10392(System.Management.Automation.PSDriveInfo
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 10378, 10392);
            return return_v;
        }


        System.Management.Automation.ProviderInfo
        f_1261_10419_10437(System.Management.Automation.PSDriveInfo
        this_param)
        {
            var return_v = this_param.Provider;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 10419, 10437);
            return return_v;
        }


        System.Management.Automation.PSCredential
        f_1261_10465_10485(System.Management.Automation.PSDriveInfo
        this_param)
        {
            var return_v = this_param.Credential;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 10465, 10485);
            return return_v;
        }


        string
        f_1261_10527_10552(System.Management.Automation.PSDriveInfo
        this_param)
        {
            var return_v = this_param.CurrentLocation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 10527, 10552);
            return return_v;
        }


        string
        f_1261_10581_10602(System.Management.Automation.PSDriveInfo
        this_param)
        {
            var return_v = this_param.Description;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 10581, 10602);
            return return_v;
        }


        long?
        f_1261_10636_10657(System.Management.Automation.PSDriveInfo
        this_param)
        {
            var return_v = this_param.MaximumSize;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 10636, 10657);
            return return_v;
        }


        bool
        f_1261_10692_10719(System.Management.Automation.PSDriveInfo
        this_param)
        {
            var return_v = this_param.DriveBeingCreated;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 10692, 10719);
            return return_v;
        }


        bool
        f_1261_10792_10815(System.Management.Automation.PSDriveInfo
        this_param)
        {
            var return_v = this_param.IsAutoMounted;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 10792, 10815);
            return return_v;
        }


        bool
        f_1261_10878_10895(System.Management.Automation.PSDriveInfo
        this_param)
        {
            var return_v = this_param.Persist;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1261, 10878, 10895);
            return return_v;
        }


        int
        f_1261_10910_10922(System.Management.Automation.PSDriveInfo
        this_param)
        {
            this_param.Trace();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 10910, 10922);
            return 0;
        }


        System.Management.Automation.PSArgumentNullException
        f_1261_12360_12406(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 12360, 12406);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1261_12498_12548(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 12498, 12548);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1261_12636_12682(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 12636, 12682);
            return return_v;
        }


        int
        f_1261_13193_13330(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 13193, 13330);
            return 0;
        }


        int
        f_1261_13386_13398(System.Management.Automation.PSDriveInfo
        this_param)
        {
            this_param.Trace();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1261, 13386, 13398);
            return 0;
        }


        static string
        f_1261_15001_15005_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1261, 14782, 15109);
            return return_v;
        }


        static string
        f_1261_16633_16637_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1261, 16407, 16733);
            return return_v;
        }

    }
}

