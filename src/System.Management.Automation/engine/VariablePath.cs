// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace System.Management.Automation
{
    [Flags]
    internal enum VariablePathFlags
    {
        None = 0x00,
        Local = 0x01,
        Script = 0x02,
        Global = 0x04,
        Private = 0x08,
        Variable = 0x10,
        Function = 0x20,
        DriveQualified = 0x40,
        Unqualified = 0x80,

        // If any of these bits are set, the path does not represent an unscoped variable.
        UnscopedVariableMask = Local | Script | Global | Private | Function | DriveQualified,
    }
    public class VariablePath
    {
        private string _userPath;

        private string _unqualifiedPath;

        private VariablePathFlags _flags;

        private VariablePath()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1375, 1574, 1618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 1033, 1042);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 1183, 1199);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 1360, 1391);
                this._flags = VariablePathFlags.None;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1375, 1574, 1618);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1375, 1574, 1618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1375, 1574, 1618);
            }
        }

        public VariablePath(string path)
        : this(f_1375_1959_1963_C(path), VariablePathFlags.None)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1375, 1906, 2010);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1375, 1906, 2010);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1375, 1906, 2010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1375, 1906, 2010);
            }
        }

        static string
        f_1375_1959_1963_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1375, 1959, 1963);
            return return_v;
        }

        /// <summary>
        /// Constructs a scoped item lookup path.
        /// </summary>
        /// <param name="path">The path to parse.</param>
        /// <param name="knownFlags">
        /// These flags for anything known about the path (such as, is it a function) before
        /// being scanned.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// If <paramref name="path"/> is null.
        /// </exception>
        internal VariablePath(string path, VariablePathFlags knownFlags)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw PSTraceSource.NewArgumentException("path");
            }

            _userPath = path;
            _flags = knownFlags;

            string candidateScope = null;
            string candidateScopeUpper = null;
            VariablePathFlags candidateFlags = VariablePathFlags.Unqualified;

            int currentCharIndex = 0;
            int lastScannedColon = -1;

        scanScope:
            switch (path[0])
            {
                case 'g':
                case 'G':
                    candidateScope = "lobal";
                    candidateScopeUpper = "LOBAL";
                    candidateFlags = VariablePathFlags.Global;
                    break;
                case 'l':
                case 'L':
                    candidateScope = "ocal";
                    candidateScopeUpper = "OCAL";
                    candidateFlags = VariablePathFlags.Local;
                    break;
                case 'p':
                case 'P':
                    candidateScope = "rivate";
                    candidateScopeUpper = "RIVATE";
                    candidateFlags = VariablePathFlags.Private;
                    break;
                case 's':
                case 'S':
                    candidateScope = "cript";
                    candidateScopeUpper = "CRIPT";
                    candidateFlags = VariablePathFlags.Script;
                    break;
                case 'v':
                case 'V':
                    if (knownFlags == VariablePathFlags.None)
                    {
                        // If we see 'variable:', our namespaceId will be empty, and
                        // we'll also need to scan for the scope again.
                        candidateScope = "ariable";
                        candidateScopeUpper = "ARIABLE";
                        candidateFlags = VariablePathFlags.Variable;
                    }

                    break;
            }

            if (candidateScope != null)
            {
                currentCharIndex += 1; // First character already matched.
                int j;
                for (j = 0; currentCharIndex < path.Length && j < candidateScope.Length; ++j, ++currentCharIndex)
                {
                    if (path[currentCharIndex] != candidateScope[j] && path[currentCharIndex] != candidateScopeUpper[j])
                    {
                        break;
                    }
                }

                if (j == candidateScope.Length &&
                    currentCharIndex < path.Length &&
                    path[currentCharIndex] == ':')
                {
                    if (_flags == VariablePathFlags.None)
                    {
                        _flags = VariablePathFlags.Variable;
                    }

                    _flags |= candidateFlags;
                    lastScannedColon = currentCharIndex;
                    currentCharIndex += 1;

                    // If saw 'variable:', we need to look for a scope after 'variable:'.
                    if (candidateFlags == VariablePathFlags.Variable)
                    {
                        knownFlags = VariablePathFlags.Variable;
                        candidateScope = candidateScopeUpper = null;
                        candidateFlags = VariablePathFlags.None;
                        goto scanScope;
                    }
                }
            }

            if (_flags == VariablePathFlags.None)
            {
                lastScannedColon = path.IndexOf(':', currentCharIndex);
                // No colon, or a colon as the first character means we have
                // a simple variable, otherwise it's a drive.
                if (lastScannedColon > 0)
                {
                    _flags = VariablePathFlags.DriveQualified;
                }
            }

            if (lastScannedColon == -1)
            {
                _unqualifiedPath = _userPath;
            }
            else
            {
                _unqualifiedPath = _userPath.Substring(lastScannedColon + 1);
            }

            if (_flags == VariablePathFlags.None)
            {
                _flags = VariablePathFlags.Unqualified | VariablePathFlags.Variable;
            }
        }

        internal VariablePath CloneAndSetLocal()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1375, 6999, 7430);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 7064, 7151);

                f_1375_7064_7150(f_1375_7077_7095(), "Special method to clone, input must be unqualified");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 7167, 7208);

                VariablePath
                result = f_1375_7189_7207()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 7222, 7251);

                result._userPath = _userPath;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 7265, 7308);

                result._unqualifiedPath = _unqualifiedPath;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 7322, 7391);

                result._flags = VariablePathFlags.Local | VariablePathFlags.Variable;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 7405, 7419);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1375, 6999, 7430);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1375, 6999, 7430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1375, 6999, 7430);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string UserPath
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1375, 7672, 7697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 7678, 7695);

                    return _userPath;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1375, 7672, 7697);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1375, 7647, 7699);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1375, 7647, 7699);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsGlobal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1375, 7851, 7907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 7857, 7905);

                    return 0 != (_flags & VariablePathFlags.Global);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1375, 7851, 7907);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1375, 7828, 7909);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1375, 7828, 7909);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsLocal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1375, 8059, 8114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 8065, 8112);

                    return 0 != (_flags & VariablePathFlags.Local);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1375, 8059, 8114);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1375, 8037, 8116);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1375, 8037, 8116);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsPrivate
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1375, 8270, 8327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 8276, 8325);

                    return 0 != (_flags & VariablePathFlags.Private);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1375, 8270, 8327);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1375, 8246, 8329);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1375, 8246, 8329);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsScript
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1375, 8481, 8537);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 8487, 8535);

                    return 0 != (_flags & VariablePathFlags.Script);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1375, 8481, 8537);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1375, 8458, 8539);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1375, 8458, 8539);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsUnqualified
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1375, 8704, 8765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 8710, 8763);

                    return 0 != (_flags & VariablePathFlags.Unqualified);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1375, 8704, 8765);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1375, 8676, 8767);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1375, 8676, 8767);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Unscoped")]
        public bool IsUnscopedVariable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1375, 9066, 9138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 9072, 9136);

                    return (0 == (_flags & VariablePathFlags.UnscopedVariableMask));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1375, 9066, 9138);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1375, 8916, 9140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1375, 8916, 9140);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsVariable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1375, 9282, 9340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 9288, 9338);

                    return 0 != (_flags & VariablePathFlags.Variable);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1375, 9282, 9340);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1375, 9257, 9342);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1375, 9257, 9342);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsFunction
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1375, 9486, 9544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 9492, 9542);

                    return 0 != (_flags & VariablePathFlags.Function);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1375, 9486, 9544);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1375, 9459, 9546);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1375, 9459, 9546);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsDriveQualified
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1375, 9723, 9787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 9729, 9785);

                    return 0 != (_flags & VariablePathFlags.DriveQualified);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1375, 9723, 9787);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1375, 9692, 9789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1375, 9692, 9789);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string DriveName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1375, 10074, 10543);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 10110, 10204) || true) && (f_1375_10114_10131_M(!IsDriveQualified))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1375, 10110, 10204);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 10173, 10185);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1375, 10110, 10204);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 10474, 10528);

                    return f_1375_10481_10527(_userPath, 0, f_1375_10504_10526(_userPath, ':'));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1375, 10074, 10543);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1375, 10026, 10554);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1375, 10026, 10554);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal string UnqualifiedPath
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1375, 10718, 10750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 10724, 10748);

                    return _unqualifiedPath;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1375, 10718, 10750);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1375, 10662, 10761);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1375, 10662, 10761);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal string QualifiedName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1375, 10980, 11043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 10986, 11041);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1375, 10993, 11009) || ((f_1375_10993_11009() && DynAbs.Tracing.TraceSender.Conditional_F2(1375, 11012, 11021)) || DynAbs.Tracing.TraceSender.Conditional_F3(1375, 11024, 11040))) ? _userPath : _unqualifiedPath;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1375, 10980, 11043);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1375, 10926, 11054);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1375, 10926, 11054);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1375, 11186, 11272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1375, 11244, 11261);

                return _userPath;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1375, 11186, 11272);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1375, 11186, 11272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1375, 11186, 11272);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static VariablePath()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1375, 832, 11279);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1375, 832, 11279);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1375, 832, 11279);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1375, 832, 11279);

        bool
        f_1375_7077_7095()
        {
            var return_v = IsUnscopedVariable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1375, 7077, 7095);
            return return_v;
        }


        int
        f_1375_7064_7150(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1375, 7064, 7150);
            return 0;
        }


        System.Management.Automation.VariablePath
        f_1375_7189_7207()
        {
            var return_v = new System.Management.Automation.VariablePath();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1375, 7189, 7207);
            return return_v;
        }


        bool
        f_1375_10114_10131_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1375, 10114, 10131);
            return return_v;
        }


        int
        f_1375_10504_10526(string
        this_param, char
        value)
        {
            var return_v = this_param.IndexOf(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1375, 10504, 10526);
            return return_v;
        }


        string
        f_1375_10481_10527(string
        this_param, int
        startIndex, int
        length)
        {
            var return_v = this_param.Substring(startIndex, length);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1375, 10481, 10527);
            return return_v;
        }


        bool
        f_1375_10993_11009()
        {
            var return_v = IsDriveQualified;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1375, 10993, 11009);
            return return_v;
        }

    }
    internal class FunctionLookupPath : VariablePath
    {
        internal FunctionLookupPath(string path)
        : base(f_1375_11413_11417_C(path), VariablePathFlags.Function | VariablePathFlags.Unqualified)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1375, 11352, 11500);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1375, 11352, 11500);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1375, 11352, 11500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1375, 11352, 11500);
            }
        }

        static FunctionLookupPath()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1375, 11287, 11507);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1375, 11287, 11507);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1375, 11287, 11507);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1375, 11287, 11507);

        static string
        f_1375_11413_11417_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1375, 11352, 11500);
            return return_v;
        }

    }
}
