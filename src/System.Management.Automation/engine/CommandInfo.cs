// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Text;

using Microsoft.PowerShell.Commands;

namespace System.Management.Automation
{
    /// <summary>
    /// Defines the types of commands that MSH can execute.
    /// </summary>
    [Flags]
    public enum CommandTypes
    {
        /// <summary>
        /// Aliases create a name that refers to other command types.
        /// </summary>
        /// <remarks>
        /// Aliases are only persisted within the execution of a single engine.
        /// </remarks>
        Alias = 0x0001,

        /// <summary>
        /// Script functions that are defined by a script block.
        /// </summary>
        /// <remarks>
        /// Functions are only persisted within the execution of a single engine.
        /// </remarks>
        Function = 0x0002,

        /// <summary>
        /// Script filters that are defined by a script block.
        /// </summary>
        /// <remarks>
        /// Filters are only persisted within the execution of a single engine.
        /// </remarks>
        Filter = 0x0004,

        /// <summary>
        /// A cmdlet.
        /// </summary>
        Cmdlet = 0x0008,

        /// <summary>
        /// An MSH script (*.ps1 file)
        /// </summary>
        ExternalScript = 0x0010,

        /// <summary>
        /// Any existing application (can be console or GUI).
        /// </summary>
        /// <remarks>
        /// An application can have any extension that can be executed either directly through CreateProcess
        /// or indirectly through ShellExecute.
        /// </remarks>
        Application = 0x0020,

        /// <summary>
        /// A script that is built into the runspace configuration.
        /// </summary>
        Script = 0x0040,

        /// <summary>
        /// A Configuration.
        /// </summary>
        Configuration = 0x0100,

        /// <summary>
        /// All possible command types.
        /// </summary>
        /// <remarks>
        /// Note, a CommandInfo instance will never specify
        /// All as its CommandType but All can be used when filtering the CommandTypes.
        /// </remarks>
        All = Alias | Function | Filter | Cmdlet | Script | ExternalScript | Application | Configuration,
    }
    public abstract class CommandInfo : IHasSessionStateEntryVisibility
    {
        internal CommandInfo(string name, CommandTypes type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1247, 3460, 3817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 5734, 5790);
                this.Name = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 5911, 5992);
                this.CommandType = CommandTypes.Application;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 7738, 7746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 8265, 8273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 8412, 8471);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 8606, 8654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 11045, 11093);
                this._visibility = SessionStateEntryVisibility.Public;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 12712, 12761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 22323, 22347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 23813, 23827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 24394, 24441);
                this.IsImported = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 24567, 24619);
                this.Prefix = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 26904, 26948);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 27239, 27280);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 3640, 3745) || true) && (name == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 3640, 3745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 3690, 3730);

                    throw f_1247_3696_3729("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 3640, 3745);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 3761, 3773);

                Name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 3787, 3806);

                CommandType = type;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1247, 3460, 3817);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 3460, 3817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 3460, 3817);
            }
        }

        internal CommandInfo(string name, CommandTypes type, ExecutionContext context)
        : this(f_1247_4492_4496_C(name), type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1247, 4393, 4562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 4528, 4551);

                this.Context = context;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1247, 4393, 4562);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 4393, 4562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 4393, 4562);
            }
        }

        internal CommandInfo(CommandInfo other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1247, 4694, 5346);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 5734, 5790);
                this.Name = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 5911, 5992);
                this.CommandType = CommandTypes.Application;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 7738, 7746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 8265, 8273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 8412, 8471);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 8606, 8654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 11045, 11093);
                this._visibility = SessionStateEntryVisibility.Public;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 12712, 12761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 22323, 22347);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 23813, 23827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 24394, 24441);
                this.IsImported = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 24567, 24619);
                this.Prefix = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 26904, 26948);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 27239, 27280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 4994, 5021);

                this.Module = f_1247_5008_5020(other);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 5035, 5067);

                _visibility = other._visibility;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 5081, 5109);

                Arguments = f_1247_5093_5108(other);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 5123, 5152);

                this.Context = f_1247_5138_5151(other);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 5166, 5184);

                Name = f_1247_5173_5183(other);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 5198, 5230);

                CommandType = f_1247_5212_5229(other);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 5244, 5266);

                CopiedCommand = other;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 5280, 5335);

                this.DefiningLanguageMode = f_1247_5308_5334(other);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1247, 4694, 5346);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 4694, 5346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 4694, 5346);
            }
        }

        internal CommandInfo(string name, CommandInfo other)
        : this(f_1247_5551_5556_C(other))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1247, 5478, 5605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 5582, 5594);

                Name = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1247, 5478, 5605);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 5478, 5605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 5478, 5605);
            }
        }

        public string Name { get; private set; }

        public CommandTypes CommandType { get; private set; }

        public virtual string Source
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 6186, 6217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 6192, 6215);

                    return f_1247_6199_6214(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 6186, 6217);

                    string
                    f_1247_6199_6214(System.Management.Automation.CommandInfo
                    this_param)
                    {
                        var return_v = this_param.ModuleName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 6199, 6214);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 6155, 6219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 6155, 6219);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual Version Version
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 6404, 7699);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 6440, 7648) || true) && (_version == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 6440, 7648);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 6502, 7629) || true) && (f_1247_6506_6512() != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 6502, 7629);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 6570, 7552) || true) && (f_1247_6574_6614(f_1247_6574_6588(f_1247_6574_6580()), f_1247_6596_6613(0, 0)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 6570, 7552);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 6672, 7525) || true) && (f_1247_6676_6776(f_1247_6676_6687(f_1247_6676_6682()), StringLiterals.PowerShellDataFileExtension, StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 6672, 7525);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 6902, 6976);

                                    f_1247_6902_6975(f_1247_6902_6908(), f_1247_6920_6974(f_1247_6962_6973(f_1247_6962_6968())));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 6672, 7525);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 6672, 7525);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 7042, 7525) || true) && (f_1247_7046_7148(f_1247_7046_7057(f_1247_7046_7052()), StringLiterals.PowerShellILAssemblyExtension, StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1247, 7046, 7294) || f_1247_7190_7294(f_1247_7190_7201(f_1247_7190_7196()), StringLiterals.PowerShellILExecutableExtension, StringComparison.OrdinalIgnoreCase)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 7042, 7525);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 7425, 7494);

                                        f_1247_7425_7493(f_1247_7425_7431(), f_1247_7443_7492(f_1247_7443_7484(f_1247_7472_7483(f_1247_7472_7478()))));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 7042, 7525);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 6672, 7525);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 6570, 7552);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 7580, 7606);

                            _version = f_1247_7591_7605(f_1247_7591_7597());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 6502, 7629);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 6440, 7648);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 7668, 7684);

                    return _version;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 6404, 7699);

                    System.Management.Automation.PSModuleInfo
                    f_1247_6506_6512()
                    {
                        var return_v = Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 6506, 6512);
                        return return_v;
                    }


                    System.Management.Automation.PSModuleInfo
                    f_1247_6574_6580()
                    {
                        var return_v = Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 6574, 6580);
                        return return_v;
                    }


                    System.Version
                    f_1247_6574_6588(System.Management.Automation.PSModuleInfo
                    this_param)
                    {
                        var return_v = this_param.Version;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 6574, 6588);
                        return return_v;
                    }


                    System.Version
                    f_1247_6596_6613(int
                    major, int
                    minor)
                    {
                        var return_v = new System.Version(major, minor);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 6596, 6613);
                        return return_v;
                    }


                    bool
                    f_1247_6574_6614(System.Version
                    this_param, System.Version
                    obj)
                    {
                        var return_v = this_param.Equals(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 6574, 6614);
                        return return_v;
                    }


                    System.Management.Automation.PSModuleInfo
                    f_1247_6676_6682()
                    {
                        var return_v = Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 6676, 6682);
                        return return_v;
                    }


                    string
                    f_1247_6676_6687(System.Management.Automation.PSModuleInfo
                    this_param)
                    {
                        var return_v = this_param.Path;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 6676, 6687);
                        return return_v;
                    }


                    bool
                    f_1247_6676_6776(string
                    this_param, string
                    value, System.StringComparison
                    comparisonType)
                    {
                        var return_v = this_param.EndsWith(value, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 6676, 6776);
                        return return_v;
                    }


                    System.Management.Automation.PSModuleInfo
                    f_1247_6902_6908()
                    {
                        var return_v = Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 6902, 6908);
                        return return_v;
                    }


                    System.Management.Automation.PSModuleInfo
                    f_1247_6962_6968()
                    {
                        var return_v = Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 6962, 6968);
                        return return_v;
                    }


                    string
                    f_1247_6962_6973(System.Management.Automation.PSModuleInfo
                    this_param)
                    {
                        var return_v = this_param.Path;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 6962, 6973);
                        return return_v;
                    }


                    System.Version
                    f_1247_6920_6974(string
                    manifestPath)
                    {
                        var return_v = ModuleIntrinsics.GetManifestModuleVersion(manifestPath);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 6920, 6974);
                        return return_v;
                    }


                    int
                    f_1247_6902_6975(System.Management.Automation.PSModuleInfo
                    this_param, System.Version
                    version)
                    {
                        this_param.SetVersion(version);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 6902, 6975);
                        return 0;
                    }


                    System.Management.Automation.PSModuleInfo
                    f_1247_7046_7052()
                    {
                        var return_v = Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 7046, 7052);
                        return return_v;
                    }


                    string
                    f_1247_7046_7057(System.Management.Automation.PSModuleInfo
                    this_param)
                    {
                        var return_v = this_param.Path;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 7046, 7057);
                        return return_v;
                    }


                    bool
                    f_1247_7046_7148(string
                    this_param, string
                    value, System.StringComparison
                    comparisonType)
                    {
                        var return_v = this_param.EndsWith(value, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 7046, 7148);
                        return return_v;
                    }


                    System.Management.Automation.PSModuleInfo
                    f_1247_7190_7196()
                    {
                        var return_v = Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 7190, 7196);
                        return return_v;
                    }


                    string
                    f_1247_7190_7201(System.Management.Automation.PSModuleInfo
                    this_param)
                    {
                        var return_v = this_param.Path;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 7190, 7201);
                        return return_v;
                    }


                    bool
                    f_1247_7190_7294(string
                    this_param, string
                    value, System.StringComparison
                    comparisonType)
                    {
                        var return_v = this_param.EndsWith(value, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 7190, 7294);
                        return return_v;
                    }


                    System.Management.Automation.PSModuleInfo
                    f_1247_7425_7431()
                    {
                        var return_v = Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 7425, 7431);
                        return return_v;
                    }


                    System.Management.Automation.PSModuleInfo
                    f_1247_7472_7478()
                    {
                        var return_v = Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 7472, 7478);
                        return return_v;
                    }


                    string
                    f_1247_7472_7483(System.Management.Automation.PSModuleInfo
                    this_param)
                    {
                        var return_v = this_param.Path;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 7472, 7483);
                        return return_v;
                    }


                    System.Reflection.AssemblyName
                    f_1247_7443_7484(string
                    assemblyFile)
                    {
                        var return_v = AssemblyName.GetAssemblyName(assemblyFile);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 7443, 7484);
                        return return_v;
                    }


                    System.Version
                    f_1247_7443_7492(System.Reflection.AssemblyName
                    this_param)
                    {
                        var return_v = this_param.Version;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 7443, 7492);
                        return return_v;
                    }


                    int
                    f_1247_7425_7493(System.Management.Automation.PSModuleInfo
                    this_param, System.Version
                    version)
                    {
                        this_param.SetVersion(version);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 7425, 7493);
                        return 0;
                    }


                    System.Management.Automation.PSModuleInfo
                    f_1247_7591_7597()
                    {
                        var return_v = Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 7591, 7597);
                        return return_v;
                    }


                    System.Version
                    f_1247_7591_7605(System.Management.Automation.PSModuleInfo
                    this_param)
                    {
                        var return_v = this_param.Version;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 7591, 7605);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 6349, 7710);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 6349, 7710);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Version _version;

        internal ExecutionContext Context
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 7925, 7949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 7931, 7947);

                    return _context;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 7925, 7949);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 7867, 8228);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 7867, 8228);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 7965, 8217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 8001, 8018);

                    _context = value;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 8036, 8202) || true) && ((value != null) && (DynAbs.Tracing.TraceSender.Expression_True(1247, 8040, 8094) && f_1247_8059_8094_M(!f_1247_8060_8085(this).HasValue)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 8036, 8202);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 8136, 8183);

                        this.DefiningLanguageMode = f_1247_8164_8182(value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 8036, 8202);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 7965, 8217);

                    System.Management.Automation.PSLanguageMode?
                    f_1247_8060_8085(System.Management.Automation.CommandInfo
                    this_param)
                    {
                        var return_v = this_param.DefiningLanguageMode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 8060, 8085);
                        return return_v;
                    }


                    bool
                    f_1247_8059_8094_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 8059, 8094);
                        return return_v;
                    }


                    System.Management.Automation.PSLanguageMode
                    f_1247_8164_8182(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.LanguageMode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 8164, 8182);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 7867, 8228);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 7867, 8228);
                }
            }
        }

        private ExecutionContext _context;

        internal PSLanguageMode? DefiningLanguageMode { get; set; }

        internal virtual HelpCategory HelpCategory
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 8550, 8583);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 8556, 8581);

                    return HelpCategory.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 8550, 8583);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 8483, 8594);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 8483, 8594);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal CommandInfo CopiedCommand { get; set; }

        internal void SetCommandType(CommandTypes newType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 8833, 8941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 8908, 8930);

                CommandType = newType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 8833, 8941);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 8833, 8941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 8833, 8941);
            }
        }

        public abstract string Definition { get; }

        internal void Rename(string newName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 9645, 9873);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 9706, 9831) || true) && (f_1247_9710_9739(newName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 9706, 9831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 9773, 9816);

                    throw f_1247_9779_9815("newName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 9706, 9831);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 9847, 9862);

                Name = newName;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 9645, 9873);

                bool
                f_1247_9710_9739(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 9710, 9739);
                    return return_v;
                }


                System.ArgumentNullException
                f_1247_9779_9815(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 9779, 9815);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 9645, 9873);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 9645, 9873);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 10003, 10133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 10061, 10122);

                return f_1247_10068_10121(f_1247_10108_10112(), f_1247_10114_10120());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 10003, 10133);

                string
                f_1247_10108_10112()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 10108, 10112);
                    return return_v;
                }


                string
                f_1247_10114_10120()
                {
                    var return_v = Prefix;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 10114, 10120);
                    return return_v;
                }


                string
                f_1247_10068_10121(string
                commandName, string
                prefix)
                {
                    var return_v = ModuleCmdletBase.AddPrefixToCommandName(commandName, prefix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 10068, 10121);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 10003, 10133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 10003, 10133);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual SessionStateEntryVisibility Visibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 10392, 10513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 10428, 10498);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1247, 10435, 10456) || ((f_1247_10435_10448() == null && DynAbs.Tracing.TraceSender.Conditional_F2(1247, 10459, 10470)) || DynAbs.Tracing.TraceSender.Conditional_F3(1247, 10473, 10497))) ? _visibility : f_1247_10473_10497(f_1247_10473_10486());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 10392, 10513);

                    System.Management.Automation.CommandInfo
                    f_1247_10435_10448()
                    {
                        var return_v = CopiedCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 10435, 10448);
                        return return_v;
                    }


                    System.Management.Automation.CommandInfo
                    f_1247_10473_10486()
                    {
                        var return_v = CopiedCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 10473, 10486);
                        return return_v;
                    }


                    System.Management.Automation.SessionStateEntryVisibility
                    f_1247_10473_10497(System.Management.Automation.CommandInfo
                    this_param)
                    {
                        var return_v = this_param.Visibility;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 10473, 10497);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 10314, 10997);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 10314, 10997);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 10529, 10986);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 10565, 10786) || true) && (f_1247_10569_10582() == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 10565, 10786);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 10632, 10652);

                        _visibility = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 10565, 10786);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 10565, 10786);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 10734, 10767);

                        f_1247_10734_10747().Visibility = value;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 10565, 10786);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 10806, 10971) || true) && (value == SessionStateEntryVisibility.Private && (DynAbs.Tracing.TraceSender.Expression_True(1247, 10810, 10872) && f_1247_10858_10864() != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 10806, 10971);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 10914, 10952);

                        f_1247_10914_10920().ModuleHasPrivateMembers = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 10806, 10971);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 10529, 10986);

                    System.Management.Automation.CommandInfo
                    f_1247_10569_10582()
                    {
                        var return_v = CopiedCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 10569, 10582);
                        return return_v;
                    }


                    System.Management.Automation.CommandInfo
                    f_1247_10734_10747()
                    {
                        var return_v = CopiedCommand;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 10734, 10747);
                        return return_v;
                    }


                    System.Management.Automation.PSModuleInfo
                    f_1247_10858_10864()
                    {
                        var return_v = Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 10858, 10864);
                        return return_v;
                    }


                    System.Management.Automation.PSModuleInfo
                    f_1247_10914_10920()
                    {
                        var return_v = Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 10914, 10920);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 10314, 10997);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 10314, 10997);
                }
            }
        }

        private SessionStateEntryVisibility _visibility;

        internal virtual CommandMetadata CommandMetadata
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 11305, 11394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 11341, 11379);

                    throw f_1247_11347_11378();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 11305, 11394);

                    System.InvalidOperationException
                    f_1247_11347_11378()
                    {
                        var return_v = new System.InvalidOperationException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 11347, 11378);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 11232, 11405);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 11232, 11405);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual string Syntax
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 11565, 11591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 11571, 11589);

                    return f_1247_11578_11588();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 11565, 11591);

                    string
                    f_1247_11578_11588()
                    {
                        var return_v = Definition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 11578, 11588);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 11510, 11602);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 11510, 11602);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string ModuleName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 11844, 12499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 11880, 11905);

                    string
                    moduleName = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 11925, 12361) || true) && (f_1247_11929_11935() != null && (DynAbs.Tracing.TraceSender.Expression_True(1247, 11929, 11981) && !f_1247_11948_11981(f_1247_11969_11980(f_1247_11969_11975()))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 11925, 12361);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 12023, 12048);

                        moduleName = f_1247_12036_12047(f_1247_12036_12042());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 11925, 12361);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 11925, 12361);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 12130, 12169);

                        CmdletInfo
                        cmdlet = this as CmdletInfo
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 12191, 12342) || true) && (cmdlet != null && (DynAbs.Tracing.TraceSender.Expression_True(1247, 12195, 12236) && f_1247_12213_12228(cmdlet) != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 12191, 12342);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 12286, 12319);

                            moduleName = f_1247_12299_12318(cmdlet);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 12191, 12342);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 11925, 12361);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 12381, 12446) || true) && (moduleName == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 12381, 12446);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 12426, 12446);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 12381, 12446);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 12466, 12484);

                    return moduleName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 11844, 12499);

                    System.Management.Automation.PSModuleInfo
                    f_1247_11929_11935()
                    {
                        var return_v = Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 11929, 11935);
                        return return_v;
                    }


                    System.Management.Automation.PSModuleInfo
                    f_1247_11969_11975()
                    {
                        var return_v = Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 11969, 11975);
                        return return_v;
                    }


                    string
                    f_1247_11969_11980(System.Management.Automation.PSModuleInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 11969, 11980);
                        return return_v;
                    }


                    bool
                    f_1247_11948_11981(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 11948, 11981);
                        return return_v;
                    }


                    System.Management.Automation.PSModuleInfo
                    f_1247_12036_12042()
                    {
                        var return_v = Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 12036, 12042);
                        return return_v;
                    }


                    string
                    f_1247_12036_12047(System.Management.Automation.PSModuleInfo
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 12036, 12047);
                        return return_v;
                    }


                    System.Management.Automation.PSSnapInInfo
                    f_1247_12213_12228(System.Management.Automation.CmdletInfo
                    this_param)
                    {
                        var return_v = this_param.PSSnapIn;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 12213, 12228);
                        return return_v;
                    }


                    string
                    f_1247_12299_12318(System.Management.Automation.CmdletInfo
                    this_param)
                    {
                        var return_v = this_param.PSSnapInName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 12299, 12318);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 11795, 12510);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 11795, 12510);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PSModuleInfo Module { get; internal set; }

        public RemotingCapability RemotingCapability
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 13006, 13478);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 13086, 13136);

                        return f_1247_13093_13135(f_1247_13093_13116());
                    }
                    catch (PSNotSupportedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1247, 13173, 13463);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 13407, 13444);

                        return RemotingCapability.PowerShell;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1247, 13173, 13463);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 13006, 13478);

                    System.Management.Automation.CommandMetadata
                    f_1247_13093_13116()
                    {
                        var return_v = ExternalCommandMetadata;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 13093, 13116);
                        return return_v;
                    }


                    System.Management.Automation.RemotingCapability
                    f_1247_13093_13135(System.Management.Automation.CommandMetadata
                    this_param)
                    {
                        var return_v = this_param.RemotingCapability;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 13093, 13135);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 12937, 13489);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 12937, 13489);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool ImplementsDynamicParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 13696, 13717);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 13702, 13715);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 13696, 13717);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 13622, 13728);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 13622, 13728);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private MergedCommandParameterMetadata GetMergedCommandParameterMetadataSafely()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 13996, 16679);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 14101, 14152) || true) && (_context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 14101, 14152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 14140, 14152);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 14101, 14152);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 14168, 14206);

                MergedCommandParameterMetadata
                result
                = default(MergedCommandParameterMetadata);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 14220, 16578) || true) && (_context != f_1247_14236_14278())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 14220, 16578);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 14795, 14849);

                    var
                    runspace = (RunspaceBase)f_1247_14824_14848(_context)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 14867, 16563) || true) && (f_1247_14871_14911(runspace))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 14867, 16563);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 14953, 14999);

                        f_1247_14953_14998(this, out result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 14867, 16563);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 14867, 16563);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 15081, 15735);

                        f_1247_15081_15734(f_1247_15081_15096(_context), source: null, eventName: PSEngineEvent.GetCommandInfoParameterMetadata, sourceIdentifier: PSEngineEvent.GetCommandInfoParameterMetadata, data: null, handlerDelegate: new PSEventReceivedEventHandler(OnGetMergedCommandParameterMetadataSafelyEventHandler), supportEvent: true, forwardEvent: false, shouldQueueAndProcessInExecutionThread: true, maxTriggerCount: 1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 15759, 15830);

                        var
                        eventArgs = f_1247_15775_15829()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 15854, 16228);

                        f_1247_15854_16227(f_1247_15854_15869(_context), sourceIdentifier: PSEngineEvent.GetCommandInfoParameterMetadata, sender: null, args: new[] { eventArgs }, extraData: null, processInCurrentThread: true, waitForCompletionInCurrentThread: true);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 16252, 16496) || true) && (eventArgs.Exception != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 16252, 16496);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 16445, 16473);

                            f_1247_16445_16472(                        // An exception happened on a different thread, rethrow it here on the correct thread.
                                                    eventArgs.Exception);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 16252, 16496);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 16520, 16544);

                        return eventArgs.Result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 14867, 16563);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 14220, 16578);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 16594, 16640);

                f_1247_16594_16639(this, out result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 16654, 16668);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 13996, 16679);

                System.Management.Automation.ExecutionContext
                f_1247_14236_14278()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 14236, 14278);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1247_14824_14848(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 14824, 14848);
                    return return_v;
                }


                bool
                f_1247_14871_14911(System.Management.Automation.Runspaces.RunspaceBase
                this_param)
                {
                    var return_v = this_param.CanRunActionInCurrentPipeline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 14871, 14911);
                    return return_v;
                }


                int
                f_1247_14953_14998(System.Management.Automation.CommandInfo
                this_param, out System.Management.Automation.MergedCommandParameterMetadata
                result)
                {
                    this_param.GetMergedCommandParameterMetadata(out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 14953, 14998);
                    return 0;
                }


                System.Management.Automation.PSLocalEventManager
                f_1247_15081_15096(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 15081, 15096);
                    return return_v;
                }


                System.Management.Automation.PSEventSubscriber
                f_1247_15081_15734(System.Management.Automation.PSLocalEventManager
                this_param, object
                source, string
                eventName, string
                sourceIdentifier, System.Management.Automation.PSObject
                data, System.Management.Automation.PSEventReceivedEventHandler
                handlerDelegate, bool
                supportEvent, bool
                forwardEvent, bool
                shouldQueueAndProcessInExecutionThread, int
                maxTriggerCount)
                {
                    var return_v = this_param.SubscribeEvent(source: source, eventName: eventName, sourceIdentifier: sourceIdentifier, data: data, handlerDelegate: handlerDelegate, supportEvent: supportEvent, forwardEvent: forwardEvent, shouldQueueAndProcessInExecutionThread: shouldQueueAndProcessInExecutionThread, maxTriggerCount: maxTriggerCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 15081, 15734);
                    return return_v;
                }


                System.Management.Automation.CommandInfo.GetMergedCommandParameterMetadataSafelyEventArgs
                f_1247_15775_15829()
                {
                    var return_v = new System.Management.Automation.CommandInfo.GetMergedCommandParameterMetadataSafelyEventArgs();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 15775, 15829);
                    return return_v;
                }


                System.Management.Automation.PSLocalEventManager
                f_1247_15854_15869(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Events;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 15854, 15869);
                    return return_v;
                }


                System.Management.Automation.PSEventArgs
                f_1247_15854_16227(System.Management.Automation.PSLocalEventManager
                this_param, string
                sourceIdentifier, object
                sender, System.Management.Automation.CommandInfo.GetMergedCommandParameterMetadataSafelyEventArgs[]
                args, System.Management.Automation.PSObject
                extraData, bool
                processInCurrentThread, bool
                waitForCompletionInCurrentThread)
                {
                    var return_v = this_param.GenerateEvent(sourceIdentifier: sourceIdentifier, sender: sender, args: (object[])args, extraData: extraData, processInCurrentThread: processInCurrentThread, waitForCompletionInCurrentThread: waitForCompletionInCurrentThread);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 15854, 16227);
                    return return_v;
                }


                int
                f_1247_16445_16472(System.Runtime.ExceptionServices.ExceptionDispatchInfo
                this_param)
                {
                    this_param.Throw();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 16445, 16472);
                    return 0;
                }


                int
                f_1247_16594_16639(System.Management.Automation.CommandInfo
                this_param, out System.Management.Automation.MergedCommandParameterMetadata
                result)
                {
                    this_param.GetMergedCommandParameterMetadata(out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 16594, 16639);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 13996, 16679);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 13996, 16679);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private class GetMergedCommandParameterMetadataSafelyEventArgs : EventArgs
        {
            public MergedCommandParameterMetadata Result;

            public ExceptionDispatchInfo Exception;

            public GetMergedCommandParameterMetadataSafelyEventArgs()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1247, 16691, 16899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 16828, 16834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 16878, 16887);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1247, 16691, 16899);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 16691, 16899);
            }


            static GetMergedCommandParameterMetadataSafelyEventArgs()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1247, 16691, 16899);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1247, 16691, 16899);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 16691, 16899);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1247, 16691, 16899);
        }

        private void OnGetMergedCommandParameterMetadataSafelyEventHandler(object sender, PSEventArgs args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 16911, 17654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 17035, 17124);

                var
                eventArgs = f_1247_17051_17071(args) as GetMergedCommandParameterMetadataSafelyEventArgs
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 17138, 17643) || true) && (eventArgs != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 17138, 17643);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 17316, 17372);

                        f_1247_17316_17371(this, out eventArgs.Result);
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1247, 17409, 17628);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 17554, 17609);

                        eventArgs.Exception = f_1247_17576_17608(e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1247, 17409, 17628);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 17138, 17643);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 16911, 17654);

                System.EventArgs
                f_1247_17051_17071(System.Management.Automation.PSEventArgs
                this_param)
                {
                    var return_v = this_param.SourceEventArgs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 17051, 17071);
                    return return_v;
                }


                int
                f_1247_17316_17371(System.Management.Automation.CommandInfo
                this_param, out System.Management.Automation.MergedCommandParameterMetadata
                result)
                {
                    this_param.GetMergedCommandParameterMetadata(out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 17316, 17371);
                    return 0;
                }


                System.Runtime.ExceptionServices.ExceptionDispatchInfo
                f_1247_17576_17608(System.Exception
                source)
                {
                    var return_v = ExceptionDispatchInfo.Capture(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 17576, 17608);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 16911, 17654);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 16911, 17654);
            }
        }

        private void GetMergedCommandParameterMetadata(out MergedCommandParameterMetadata result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 17666, 21025);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 19046, 19073);

                CommandProcessor
                processor
                = default(CommandProcessor);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 19087, 20928) || true) && (f_1247_19091_19122(f_1247_19091_19098()) != null && (DynAbs.Tracing.TraceSender.Expression_True(1247, 19091, 19185) && f_1247_19134_19177(f_1247_19134_19165(f_1247_19134_19141())) == this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 19087, 20928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 19324, 19386);

                    processor = (CommandProcessor)f_1247_19354_19385(f_1247_19354_19361());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 19087, 20928);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 19087, 20928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 19452, 19514);

                    IScriptCommandInfo
                    scriptCommand = this as IScriptCommandInfo
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 19532, 19893);

                    processor = (DynAbs.Tracing.TraceSender.Conditional_F1(1247, 19544, 19565) || ((scriptCommand != null
                    && DynAbs.Tracing.TraceSender.Conditional_F2(1247, 19589, 19795)) || DynAbs.Tracing.TraceSender.Conditional_F3(1247, 19819, 19892))) ? f_1247_19589_19795(scriptCommand, _context, useLocalScope: true, fromScriptFile: false, sessionState: f_1247_19718_19764(f_1247_19718_19743(scriptCommand)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.SessionStateInternal>(1247, 19718, 19794) ?? f_1247_19768_19794(f_1247_19768_19775()))) : new CommandProcessor((CmdletInfo)this, _context) { UseLocalScope = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 1247, 19819, 19892) };
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 19913, 19992);

                    f_1247_19913_19991(processor, f_1247_19981_19990());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 20010, 20092);

                    CommandProcessorBase
                    oldCurrentCommandProcessor = f_1247_20060_20091(f_1247_20060_20067())
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 20154, 20198);

                        f_1247_20154_20161().CurrentCommandProcessor = processor;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 20222, 20266);

                        f_1247_20222_20265(
                                            processor);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 20288, 20389);

                        f_1247_20288_20388(f_1247_20288_20329(processor), processor.arguments);
                    }
                    catch (ParameterBindingException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1247, 20426, 20712);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 20581, 20693) || true) && (f_1247_20585_20610(processor.arguments) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 20581, 20693);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 20664, 20670);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 20581, 20693);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1247, 20426, 20712);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1247, 20730, 20913);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 20778, 20839);

                        f_1247_20778_20785().CurrentCommandProcessor = oldCurrentCommandProcessor;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 20861, 20894);

                        f_1247_20861_20893(processor);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1247, 20730, 20913);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 19087, 20928);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 20944, 21014);

                result = f_1247_20953_21013(f_1247_20953_20994(processor));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 17666, 21025);

                System.Management.Automation.ExecutionContext
                f_1247_19091_19098()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 19091, 19098);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1247_19091_19122(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 19091, 19122);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1247_19134_19141()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 19134, 19141);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1247_19134_19165(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 19134, 19165);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1247_19134_19177(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 19134, 19177);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1247_19354_19361()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 19354, 19361);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1247_19354_19385(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 19354, 19385);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1247_19718_19743(System.Management.Automation.IScriptCommandInfo
                this_param)
                {
                    var return_v = this_param.ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 19718, 19743);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1247_19718_19764(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.SessionStateInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 19718, 19764);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1247_19768_19775()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 19768, 19775);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1247_19768_19794(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 19768, 19794);
                    return return_v;
                }


                System.Management.Automation.CommandProcessor
                f_1247_19589_19795(System.Management.Automation.IScriptCommandInfo
                scriptCommandInfo, System.Management.Automation.ExecutionContext
                context, bool
                useLocalScope, bool
                fromScriptFile, System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = new System.Management.Automation.CommandProcessor(scriptCommandInfo, context, useLocalScope: useLocalScope, fromScriptFile: fromScriptFile, sessionState: sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 19589, 19795);
                    return return_v;
                }


                object[]
                f_1247_19981_19990()
                {
                    var return_v = Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 19981, 19990);
                    return return_v;
                }


                int
                f_1247_19913_19991(System.Management.Automation.CommandProcessor
                commandProcessor, object[]
                arguments)
                {
                    ParameterBinderController.AddArgumentsToCommandProcessor((System.Management.Automation.CommandProcessorBase)commandProcessor, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 19913, 19991);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1247_20060_20067()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 20060, 20067);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1247_20060_20091(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 20060, 20091);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1247_20154_20161()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 20154, 20161);
                    return return_v;
                }


                int
                f_1247_20222_20265(System.Management.Automation.CommandProcessor
                this_param)
                {
                    this_param.SetCurrentScopeToExecutionScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 20222, 20265);
                    return 0;
                }


                System.Management.Automation.CmdletParameterBinderController
                f_1247_20288_20329(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CmdletParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 20288, 20329);
                    return return_v;
                }


                int
                f_1247_20288_20388(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                arguments)
                {
                    this_param.BindCommandLineParametersNoValidation(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 20288, 20388);
                    return 0;
                }


                int
                f_1247_20585_20610(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 20585, 20610);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1247_20778_20785()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 20778, 20785);
                    return return_v;
                }


                int
                f_1247_20861_20893(System.Management.Automation.CommandProcessor
                this_param)
                {
                    this_param.RestorePreviousScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 20861, 20893);
                    return 0;
                }


                System.Management.Automation.CmdletParameterBinderController
                f_1247_20953_20994(System.Management.Automation.CommandProcessor
                this_param)
                {
                    var return_v = this_param.CmdletParameterBinderController;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 20953, 20994);
                    return return_v;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1247_20953_21013(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 20953, 21013);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 17666, 21025);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 17666, 21025);
            }
        }

        public virtual Dictionary<string, ParameterMetadata> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 21225, 22019);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 21261, 21384);

                    Dictionary<string, ParameterMetadata>
                    result = f_1247_21308_21383(f_1247_21350_21382())
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 21404, 21942) || true) && (f_1247_21408_21435() && (DynAbs.Tracing.TraceSender.Expression_True(1247, 21408, 21454) && f_1247_21439_21446() != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 21404, 21942);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 21496, 21578);

                        MergedCommandParameterMetadata
                        merged = f_1247_21536_21577(this)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 21602, 21836);
                            foreach (KeyValuePair<string, MergedCompiledCommandParameter> pair in f_1247_21672_21697_I(f_1247_21672_21697(merged)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 21602, 21836);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 21747, 21813);

                                f_1247_21747_21812(result, pair.Key, f_1247_21768_21811(f_1247_21790_21810(pair.Value)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 21602, 21836);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1247, 1, 235);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1247, 1, 235);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 21909, 21923);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 21404, 21942);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 21962, 22004);

                    return f_1247_21969_22003(f_1247_21969_21992());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 21225, 22019);

                    System.StringComparer
                    f_1247_21350_21382()
                    {
                        var return_v = StringComparer.OrdinalIgnoreCase;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 21350, 21382);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                    f_1247_21308_21383(System.StringComparer
                    comparer)
                    {
                        var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 21308, 21383);
                        return return_v;
                    }


                    bool
                    f_1247_21408_21435()
                    {
                        var return_v = ImplementsDynamicParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 21408, 21435);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1247_21439_21446()
                    {
                        var return_v = Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 21439, 21446);
                        return return_v;
                    }


                    System.Management.Automation.MergedCommandParameterMetadata
                    f_1247_21536_21577(System.Management.Automation.CommandInfo
                    this_param)
                    {
                        var return_v = this_param.GetMergedCommandParameterMetadataSafely();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 21536, 21577);
                        return return_v;
                    }


                    System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                    f_1247_21672_21697(System.Management.Automation.MergedCommandParameterMetadata
                    this_param)
                    {
                        var return_v = this_param.BindableParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 21672, 21697);
                        return return_v;
                    }


                    System.Management.Automation.CompiledCommandParameter
                    f_1247_21790_21810(System.Management.Automation.MergedCompiledCommandParameter
                    this_param)
                    {
                        var return_v = this_param.Parameter;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 21790, 21810);
                        return return_v;
                    }


                    System.Management.Automation.ParameterMetadata
                    f_1247_21768_21811(System.Management.Automation.CompiledCommandParameter
                    cmdParameterMD)
                    {
                        var return_v = new System.Management.Automation.ParameterMetadata(cmdParameterMD);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 21768, 21811);
                        return return_v;
                    }


                    int
                    f_1247_21747_21812(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                    this_param, string
                    key, System.Management.Automation.ParameterMetadata
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 21747, 21812);
                        return 0;
                    }


                    System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                    f_1247_21672_21697_I(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 21672, 21697);
                        return return_v;
                    }


                    System.Management.Automation.CommandMetadata
                    f_1247_21969_21992()
                    {
                        var return_v = ExternalCommandMetadata;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 21969, 21992);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                    f_1247_21969_22003(System.Management.Automation.CommandMetadata
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 21969, 22003);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 21137, 22030);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 21137, 22030);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal CommandMetadata ExternalCommandMetadata
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 22115, 22219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 22121, 22217);

                    return _externalCommandMetadata ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.CommandMetadata>(1247, 22128, 22216) ?? (_externalCommandMetadata = f_1247_22184_22215(this, true)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 22115, 22219);

                    System.Management.Automation.CommandMetadata
                    f_1247_22184_22215(System.Management.Automation.CommandInfo
                    commandInfo, bool
                    shouldGenerateCommonParameters)
                    {
                        var return_v = new System.Management.Automation.CommandMetadata(commandInfo, shouldGenerateCommonParameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 22184, 22215);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 22042, 22287);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 22042, 22287);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 22235, 22276);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 22241, 22274);

                    _externalCommandMetadata = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 22235, 22276);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 22042, 22287);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 22042, 22287);
                }
            }
        }

        private CommandMetadata _externalCommandMetadata;

        public ParameterMetadata ResolveParameter(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 22745, 23083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 22824, 22906);

                MergedCommandParameterMetadata
                merged = f_1247_22864_22905(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 22920, 23012);

                MergedCompiledCommandParameter
                result = f_1247_22960_23011(merged, name, true, true, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 23026, 23072);

                return f_1247_23033_23071(f_1247_23033_23048(this), f_1247_23049_23070(f_1247_23049_23065(result)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 22745, 23083);

                System.Management.Automation.MergedCommandParameterMetadata
                f_1247_22864_22905(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.GetMergedCommandParameterMetadataSafely();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 22864, 22905);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1247_22960_23011(System.Management.Automation.MergedCommandParameterMetadata
                this_param, string
                name, bool
                throwOnParameterNotFound, bool
                tryExactMatching, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    var return_v = this_param.GetMatchingParameter(name, throwOnParameterNotFound, tryExactMatching, invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 22960, 23011);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                f_1247_23033_23048(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 23033, 23048);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1247_23049_23065(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 23049, 23065);
                    return return_v;
                }


                string
                f_1247_23049_23070(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 23049, 23070);
                    return return_v;
                }


                System.Management.Automation.ParameterMetadata
                f_1247_23033_23071(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 23033, 23071);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 22745, 23083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 22745, 23083);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ReadOnlyCollection<CommandParameterSetInfo> ParameterSets
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 23336, 23737);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 23372, 23680) || true) && (_parameterSets == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 23372, 23680);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 23440, 23554);

                        Collection<CommandParameterSetInfo>
                        parameterSetInfo =
                        f_1247_23520_23553(this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 23578, 23661);

                        _parameterSets = f_1247_23595_23660(parameterSetInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 23372, 23680);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 23700, 23722);

                    return _parameterSets;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 23336, 23737);

                    System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterSetInfo>
                    f_1247_23520_23553(System.Management.Automation.CommandInfo
                    this_param)
                    {
                        var return_v = this_param.GenerateCommandParameterSetInfo();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 23520, 23553);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>
                    f_1247_23595_23660(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterSetInfo>
                    list)
                    {
                        var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>((System.Collections.Generic.IList<System.Management.Automation.CommandParameterSetInfo>)list);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 23595, 23660);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 23247, 23748);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 23247, 23748);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ReadOnlyCollection<CommandParameterSetInfo> _parameterSets;

        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public abstract ReadOnlyCollection<PSTypeName> OutputType { get; }

        internal bool IsImported { get; set; }

        internal string Prefix { get; set; }

        internal virtual CommandInfo CreateGetCommandCopy(object[] argumentList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 24860, 25006);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 24957, 24995);

                throw f_1247_24963_24994();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 24860, 25006);

                System.InvalidOperationException
                f_1247_24963_24994()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 24963, 24994);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 24860, 25006);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 24860, 25006);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<CommandParameterSetInfo> GenerateCommandParameterSetInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 26073, 26579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 26176, 26219);

                Collection<CommandParameterSetInfo>
                result
                = default(Collection<CommandParameterSetInfo>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 26235, 26538) || true) && (f_1247_26239_26255() && (DynAbs.Tracing.TraceSender.Expression_True(1247, 26239, 26286) && f_1247_26259_26286()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 26235, 26538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 26320, 26410);

                    result = f_1247_26329_26409(f_1247_26350_26365(), f_1247_26367_26408(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 26235, 26538);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 26235, 26538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 26476, 26523);

                    result = f_1247_26485_26522(f_1247_26506_26521());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 26235, 26538);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 26554, 26568);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 26073, 26579);

                bool
                f_1247_26239_26255()
                {
                    var return_v = IsGetCommandCopy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 26239, 26255);
                    return return_v;
                }


                bool
                f_1247_26259_26286()
                {
                    var return_v = ImplementsDynamicParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 26259, 26286);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1247_26350_26365()
                {
                    var return_v = CommandMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 26350, 26365);
                    return return_v;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1247_26367_26408(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.GetMergedCommandParameterMetadataSafely();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 26367, 26408);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterSetInfo>
                f_1247_26329_26409(System.Management.Automation.CommandMetadata
                metadata, System.Management.Automation.MergedCommandParameterMetadata
                parameterMetadata)
                {
                    var return_v = GetParameterMetadata(metadata, parameterMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 26329, 26409);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1247_26506_26521()
                {
                    var return_v = CommandMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 26506, 26521);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterSetInfo>
                f_1247_26485_26522(System.Management.Automation.CommandMetadata
                metadata)
                {
                    var return_v = GetCacheableMetadata(metadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 26485, 26522);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 26073, 26579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 26073, 26579);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsGetCommandCopy { get; set; }

        internal object[] Arguments { get; set; }

        internal static Collection<CommandParameterSetInfo> GetCacheableMetadata(CommandMetadata metadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1247, 27292, 27505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 27415, 27494);

                return f_1247_27422_27493(metadata, f_1247_27453_27492(metadata));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1247, 27292, 27505);

                System.Management.Automation.MergedCommandParameterMetadata
                f_1247_27453_27492(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.StaticCommandParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 27453, 27492);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterSetInfo>
                f_1247_27422_27493(System.Management.Automation.CommandMetadata
                metadata, System.Management.Automation.MergedCommandParameterMetadata
                parameterMetadata)
                {
                    var return_v = GetParameterMetadata(metadata, parameterMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 27422, 27493);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 27292, 27505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 27292, 27505);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Collection<CommandParameterSetInfo> GetParameterMetadata(CommandMetadata metadata, MergedCommandParameterMetadata parameterMetadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1247, 27517, 29349);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 27690, 27777);

                Collection<CommandParameterSetInfo>
                result = f_1247_27735_27776()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 27793, 29308) || true) && (parameterMetadata != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 27793, 29308);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 27856, 29293) || true) && (f_1247_27860_27895(parameterMetadata) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 27856, 29293);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 27942, 28010);

                        const string
                        parameterSetName = ParameterAttribute.AllParameterSets
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 28034, 28276);

                        f_1247_28034_28275(
                                            result, f_1247_28071_28274(parameterSetName, false, uint.MaxValue, parameterMetadata));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 27856, 29293);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 27856, 29293);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 28358, 28418);

                        int
                        parameterSetCount = f_1247_28382_28417(parameterMetadata)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 28449, 28458);
                            for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 28440, 29274) || true) && (index < parameterSetCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 28487, 28494)
        , ++index, DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 28440, 29274))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 28440, 29274);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 28544, 28590);

                                uint
                                currentFlagPosition = (uint)0x1 << index
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 28673, 28758);

                                string
                                parameterSetName = f_1247_28699_28757(parameterMetadata, currentFlagPosition)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 28848, 28939);

                                bool
                                isDefaultParameterSet = (currentFlagPosition & f_1247_28900_28932(metadata)) != 0
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 28967, 29251);

                                f_1247_28967_29250(
                                                        result, f_1247_29008_29249(parameterSetName, isDefaultParameterSet, currentFlagPosition, parameterMetadata));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1247, 1, 835);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1247, 1, 835);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 27856, 29293);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 27793, 29308);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 29324, 29338);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1247, 27517, 29349);

                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterSetInfo>
                f_1247_27735_27776()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterSetInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 27735, 27776);
                    return return_v;
                }


                int
                f_1247_27860_27895(System.Management.Automation.MergedCommandParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSetCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 27860, 27895);
                    return return_v;
                }


                System.Management.Automation.CommandParameterSetInfo
                f_1247_28071_28274(string
                name, bool
                isDefaultParameterSet, uint
                parameterSetFlag, System.Management.Automation.MergedCommandParameterMetadata
                parameterMetadata)
                {
                    var return_v = new System.Management.Automation.CommandParameterSetInfo(name, isDefaultParameterSet, parameterSetFlag, parameterMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 28071, 28274);
                    return return_v;
                }


                int
                f_1247_28034_28275(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterSetInfo>
                this_param, System.Management.Automation.CommandParameterSetInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 28034, 28275);
                    return 0;
                }


                int
                f_1247_28382_28417(System.Management.Automation.MergedCommandParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSetCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 28382, 28417);
                    return return_v;
                }


                string
                f_1247_28699_28757(System.Management.Automation.MergedCommandParameterMetadata
                this_param, uint
                parameterSet)
                {
                    var return_v = this_param.GetParameterSetName(parameterSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 28699, 28757);
                    return return_v;
                }


                uint
                f_1247_28900_28932(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.DefaultParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 28900, 28932);
                    return return_v;
                }


                System.Management.Automation.CommandParameterSetInfo
                f_1247_29008_29249(string
                name, bool
                isDefaultParameterSet, uint
                parameterSetFlag, System.Management.Automation.MergedCommandParameterMetadata
                parameterMetadata)
                {
                    var return_v = new System.Management.Automation.CommandParameterSetInfo(name, isDefaultParameterSet, parameterSetFlag, parameterMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 29008, 29249);
                    return return_v;
                }


                int
                f_1247_28967_29250(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterSetInfo>
                this_param, System.Management.Automation.CommandParameterSetInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 28967, 29250);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 27517, 29349);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 27517, 29349);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CommandInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1247, 2898, 29356);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1247, 2898, 29356);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 2898, 29356);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1247, 2898, 29356);

        System.ArgumentNullException
        f_1247_3696_3729(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 3696, 3729);
            return return_v;
        }


        static string
        f_1247_4492_4496_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1247, 4393, 4562);
            return return_v;
        }


        System.Management.Automation.PSModuleInfo
        f_1247_5008_5020(System.Management.Automation.CommandInfo
        this_param)
        {
            var return_v = this_param.Module;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 5008, 5020);
            return return_v;
        }


        object[]
        f_1247_5093_5108(System.Management.Automation.CommandInfo
        this_param)
        {
            var return_v = this_param.Arguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 5093, 5108);
            return return_v;
        }


        System.Management.Automation.ExecutionContext
        f_1247_5138_5151(System.Management.Automation.CommandInfo
        this_param)
        {
            var return_v = this_param.Context;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 5138, 5151);
            return return_v;
        }


        string
        f_1247_5173_5183(System.Management.Automation.CommandInfo
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 5173, 5183);
            return return_v;
        }


        System.Management.Automation.CommandTypes
        f_1247_5212_5229(System.Management.Automation.CommandInfo
        this_param)
        {
            var return_v = this_param.CommandType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 5212, 5229);
            return return_v;
        }


        System.Management.Automation.PSLanguageMode?
        f_1247_5308_5334(System.Management.Automation.CommandInfo
        this_param)
        {
            var return_v = this_param.DefiningLanguageMode;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 5308, 5334);
            return return_v;
        }


        static System.Management.Automation.CommandInfo
        f_1247_5551_5556_C(System.Management.Automation.CommandInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1247, 5478, 5605);
            return return_v;
        }

    }
    public class PSTypeName
    {
        public PSTypeName(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1247, 29786, 29965);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 32246, 32273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 33689, 33694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 33828, 33892);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 33917, 33935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 29839, 29852);

                _type = type;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 29866, 29954) || true) && (_type != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 29866, 29954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 29917, 29939);

                    Name = f_1247_29924_29938(_type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 29866, 29954);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1247, 29786, 29965);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 29786, 29965);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 29786, 29965);
            }
        }

        public PSTypeName(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1247, 30171, 30276);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 32246, 32273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 33689, 33694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 33828, 33892);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 33917, 33935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 30226, 30238);

                Name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 30252, 30265);

                _type = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1247, 30171, 30276);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 30171, 30276);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 30171, 30276);
            }
        }

        public PSTypeName(string name, Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1247, 30543, 30659);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 32246, 32273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 33689, 33694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 33828, 33892);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 33917, 33935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 30609, 30621);

                Name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 30635, 30648);

                _type = type;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1247, 30543, 30659);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 30543, 30659);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 30543, 30659);
            }
        }

        public PSTypeName(TypeDefinitionAst typeDefinitionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1247, 30883, 31215);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 32246, 32273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 33689, 33694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 33828, 33892);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 33917, 33935);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 30962, 31106) || true) && (typeDefinitionAst == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 30962, 31106);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 31025, 31091);

                    throw f_1247_31031_31090("typeDefinitionAst");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 30962, 31106);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 31122, 31160);

                TypeDefinitionAst = typeDefinitionAst;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 31174, 31204);

                Name = f_1247_31181_31203(typeDefinitionAst);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1247, 30883, 31215);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 30883, 31215);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 30883, 31215);
            }
        }

        public PSTypeName(ITypeName typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1247, 31337, 32145);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 32246, 32273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 33689, 33694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 33828, 33892);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 33917, 33935);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 31399, 31525) || true) && (typeName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 31399, 31525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 31453, 31510);

                    throw f_1247_31459_31509("typeName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 31399, 31525);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 31541, 31578);

                _type = f_1247_31549_31577(typeName);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 31592, 32134) || true) && (_type != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 31592, 32134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 31643, 31665);

                    Name = f_1247_31650_31664(_type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 31592, 32134);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 31592, 32134);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 31731, 31760);

                    var
                    t = typeName as TypeName
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 31778, 32119) || true) && (t != null && (DynAbs.Tracing.TraceSender.Expression_True(1247, 31782, 31823) && t._typeDefinitionAst != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 31778, 32119);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 31865, 31906);

                        TypeDefinitionAst = t._typeDefinitionAst;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 31928, 31958);

                        Name = f_1247_31935_31957(f_1247_31935_31952());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 31778, 32119);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 31778, 32119);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 32040, 32053);

                        _type = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 32075, 32100);

                        Name = f_1247_32082_32099(typeName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 31778, 32119);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 31592, 32134);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1247, 31337, 32145);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 31337, 32145);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 31337, 32145);
            }
        }

        public string Name { get; }

        [SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
        public Type Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 32547, 33653);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 32583, 33605) || true) && (!_typeWasCalculated)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 32583, 33605);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 32648, 33042) || true) && (_type == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 32648, 33042);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 32715, 33019) || true) && (f_1247_32719_32736() != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 32715, 33019);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 32802, 32833);

                                _type = f_1247_32810_32832(f_1247_32810_32827());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 32715, 33019);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 32715, 33019);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 32947, 32992);

                                f_1247_32947_32991(f_1247_32975_32979(), out _type);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 32715, 33019);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 32648, 33042);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 33066, 33536) || true) && (_type == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 33066, 33536);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 33186, 33513) || true) && (f_1247_33190_33194() != null && (DynAbs.Tracing.TraceSender.Expression_True(1247, 33190, 33255) && f_1247_33235_33255(f_1247_33235_33239(), '[')) && (DynAbs.Tracing.TraceSender.Expression_True(1247, 33190, 33306) && f_1247_33288_33306(f_1247_33288_33292(), ']')))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 33186, 33513);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 33364, 33412);

                                string
                                tmp = f_1247_33377_33411(f_1247_33377_33381(), 1, f_1247_33395_33406(f_1247_33395_33399()) - 2)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 33442, 33486);

                                f_1247_33442_33485(tmp, out _type);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 33186, 33513);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 33066, 33536);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 33560, 33586);

                        _typeWasCalculated = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 32583, 33605);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 33625, 33638);

                    return _type;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 32547, 33653);

                    System.Management.Automation.Language.TypeDefinitionAst
                    f_1247_32719_32736()
                    {
                        var return_v = TypeDefinitionAst;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 32719, 32736);
                        return return_v;
                    }


                    System.Management.Automation.Language.TypeDefinitionAst
                    f_1247_32810_32827()
                    {
                        var return_v = TypeDefinitionAst;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 32810, 32827);
                        return return_v;
                    }


                    System.Type
                    f_1247_32810_32832(System.Management.Automation.Language.TypeDefinitionAst
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 32810, 32832);
                        return return_v;
                    }


                    string
                    f_1247_32975_32979()
                    {
                        var return_v = Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 32975, 32979);
                        return return_v;
                    }


                    bool
                    f_1247_32947_32991(string
                    typeName, out System.Type
                    type)
                    {
                        var return_v = TypeResolver.TryResolveType(typeName, out type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 32947, 32991);
                        return return_v;
                    }


                    string
                    f_1247_33190_33194()
                    {
                        var return_v = Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 33190, 33194);
                        return return_v;
                    }


                    string
                    f_1247_33235_33239()
                    {
                        var return_v = Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 33235, 33239);
                        return return_v;
                    }


                    bool
                    f_1247_33235_33255(string
                    this_param, char
                    value)
                    {
                        var return_v = this_param.StartsWith(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 33235, 33255);
                        return return_v;
                    }


                    string
                    f_1247_33288_33292()
                    {
                        var return_v = Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 33288, 33292);
                        return return_v;
                    }


                    bool
                    f_1247_33288_33306(string
                    this_param, char
                    value)
                    {
                        var return_v = this_param.EndsWith(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 33288, 33306);
                        return return_v;
                    }


                    string
                    f_1247_33377_33381()
                    {
                        var return_v = Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 33377, 33381);
                        return return_v;
                    }


                    string
                    f_1247_33395_33399()
                    {
                        var return_v = Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 33395, 33399);
                        return return_v;
                    }


                    int
                    f_1247_33395_33406(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 33395, 33406);
                        return return_v;
                    }


                    string
                    f_1247_33377_33411(string
                    this_param, int
                    startIndex, int
                    length)
                    {
                        var return_v = this_param.Substring(startIndex, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 33377, 33411);
                        return return_v;
                    }


                    bool
                    f_1247_33442_33485(string
                    typeName, out System.Type
                    type)
                    {
                        var return_v = TypeResolver.TryResolveType(typeName, out type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 33442, 33485);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 32411, 33664);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 32411, 33664);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Type _type;

        public TypeDefinitionAst TypeDefinitionAst { get; private set; }

        private bool _typeWasCalculated;

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 34144, 34241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 34202, 34230);

                return f_1247_34209_34213() ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1247, 34209, 34229) ?? string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 34144, 34241);

                string
                f_1247_34209_34213()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 34209, 34213);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 34144, 34241);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 34144, 34241);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSTypeName()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1247, 29565, 34248);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1247, 29565, 34248);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 29565, 34248);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1247, 29565, 34248);

        string
        f_1247_29924_29938(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 29924, 29938);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1247_31031_31090(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 31031, 31090);
            return return_v;
        }


        string
        f_1247_31181_31203(System.Management.Automation.Language.TypeDefinitionAst
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 31181, 31203);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1247_31459_31509(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 31459, 31509);
            return return_v;
        }


        System.Type
        f_1247_31549_31577(System.Management.Automation.Language.ITypeName
        this_param)
        {
            var return_v = this_param.GetReflectionType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 31549, 31577);
            return return_v;
        }


        string
        f_1247_31650_31664(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 31650, 31664);
            return return_v;
        }


        System.Management.Automation.Language.TypeDefinitionAst
        f_1247_31935_31952()
        {
            var return_v = TypeDefinitionAst;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 31935, 31952);
            return return_v;
        }


        string
        f_1247_31935_31957(System.Management.Automation.Language.TypeDefinitionAst
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 31935, 31957);
            return return_v;
        }


        string
        f_1247_32082_32099(System.Management.Automation.Language.ITypeName
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 32082, 32099);
            return return_v;
        }

    }

    [DebuggerDisplay("{PSTypeName} {Name}")]
    internal struct PSMemberNameAndType
    {

        public readonly string Name;

        public readonly PSTypeName PSTypeName;

        public readonly object Value;

        public PSMemberNameAndType(string name, PSTypeName typeName, object value = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1247, 34485, 34678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 34591, 34603);

                Name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 34617, 34639);

                PSTypeName = typeName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 34653, 34667);

                Value = value;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1247, 34485, 34678);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 34485, 34678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 34485, 34678);
            }
        }
        static PSMemberNameAndType()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1247, 34256, 34685);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1247, 34256, 34685);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 34256, 34685);
        }
    }
    internal class PSSyntheticTypeName : PSTypeName
    {
        internal static PSSyntheticTypeName Create(string typename, IList<PSMemberNameAndType> membersTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 35182, 35231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 35185, 35231);
                return f_1247_35185_35231(f_1247_35192_35216(typename), membersTypes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 35182, 35231);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 35182, 35231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 35182, 35231);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.PSTypeName
            f_1247_35192_35216(string
            name)
            {
                var return_v = new System.Management.Automation.PSTypeName(name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 35192, 35216);
                return return_v;
            }


            System.Management.Automation.PSSyntheticTypeName
            f_1247_35185_35231(System.Management.Automation.PSTypeName
            typename, System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>
            membersTypes)
            {
                var return_v = Create(typename, membersTypes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 35185, 35231);
                return return_v;
            }

        }

        internal static PSSyntheticTypeName Create(Type type, IList<PSMemberNameAndType> membersTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 35339, 35384);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 35342, 35384);
                return f_1247_35342_35384(f_1247_35349_35369(type), membersTypes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 35339, 35384);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 35339, 35384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 35339, 35384);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.PSTypeName
            f_1247_35349_35369(System.Type
            type)
            {
                var return_v = new System.Management.Automation.PSTypeName(type);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 35349, 35369);
                return return_v;
            }


            System.Management.Automation.PSSyntheticTypeName
            f_1247_35342_35384(System.Management.Automation.PSTypeName
            typename, System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>
            membersTypes)
            {
                var return_v = Create(typename, membersTypes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 35342, 35384);
                return return_v;
            }

        }

        internal static PSSyntheticTypeName Create(PSTypeName typename, IList<PSMemberNameAndType> membersTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1247, 35397, 35898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 35526, 35594);

                var
                typeName = f_1247_35541_35593(f_1247_35565_35578(typename), membersTypes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 35608, 35654);

                var
                members = f_1247_35622_35653()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 35668, 35699);

                f_1247_35668_35698(members, membersTypes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 35713, 35808);

                f_1247_35713_35807(members, (c1, c2) => string.Compare(c1.Name, c2.Name, StringComparison.OrdinalIgnoreCase));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 35822, 35887);

                return f_1247_35829_35886(typeName, f_1247_35863_35876(typename), members);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1247, 35397, 35898);

                string
                f_1247_35565_35578(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 35565, 35578);
                    return return_v;
                }


                string
                f_1247_35541_35593(string
                typename, System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>
                members)
                {
                    var return_v = GetMemberTypeProjection(typename, members);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 35541, 35593);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                f_1247_35622_35653()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 35622, 35653);
                    return return_v;
                }


                int
                f_1247_35668_35698(System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                this_param, System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.PSMemberNameAndType>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 35668, 35698);
                    return 0;
                }


                int
                f_1247_35713_35807(System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                this_param, System.Comparison<System.Management.Automation.PSMemberNameAndType>
                comparison)
                {
                    this_param.Sort(comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 35713, 35807);
                    return 0;
                }


                System.Type
                f_1247_35863_35876(System.Management.Automation.PSTypeName
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 35863, 35876);
                    return return_v;
                }


                System.Management.Automation.PSSyntheticTypeName
                f_1247_35829_35886(string
                typeName, System.Type
                type, System.Collections.Generic.List<System.Management.Automation.PSMemberNameAndType>
                membersTypes)
                {
                    var return_v = new System.Management.Automation.PSSyntheticTypeName(typeName, type, (System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>)membersTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 35829, 35886);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 35397, 35898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 35397, 35898);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSSyntheticTypeName(string typeName, Type type, IList<PSMemberNameAndType> membersTypes)
        : base(f_1247_36023_36031_C(typeName), type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1247, 35910, 36499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 37521, 37571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 36063, 36086);

                Members = membersTypes;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 36100, 36184) || true) && (type != typeof(PSObject))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 36100, 36184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 36162, 36169);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 36100, 36184);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 36209, 36214);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 36200, 36488) || true) && (i < f_1247_36220_36233(f_1247_36220_36227()))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 36235, 36238)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 36200, 36488))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 36200, 36488);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 36272, 36309);

                        var
                        psMemberNameAndType = f_1247_36298_36308(f_1247_36298_36305(), i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 36327, 36473) || true) && (f_1247_36331_36364(psMemberNameAndType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 36327, 36473);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 36406, 36426);

                            f_1247_36406_36425(f_1247_36406_36413(), i);
                            DynAbs.Tracing.TraceSender.TraceBreak(1247, 36448, 36454);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 36327, 36473);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1247, 1, 289);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1247, 1, 289);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1247, 35910, 36499);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 35910, 36499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 35910, 36499);
            }
        }

        private static bool IsPSTypeName(PSMemberNameAndType member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1247, 36572, 36649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 36575, 36649);
                return f_1247_36575_36649(member.Name, nameof(PSTypeName), StringComparison.OrdinalIgnoreCase);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1247, 36572, 36649);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 36572, 36649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 36572, 36649);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_1247_36575_36649(string
            this_param, string
            value, System.StringComparison
            comparisonType)
            {
                var return_v = this_param.Equals(value, comparisonType);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 36575, 36649);
                return return_v;
            }

        }

        private static string GetMemberTypeProjection(string typename, IList<PSMemberNameAndType> members)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1247, 36662, 37509);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 36785, 37089) || true) && (typename == f_1247_36801_36826(typeof(PSObject)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 36785, 37089);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 36860, 37074);
                        foreach (var mem in f_1247_36880_36887_I(members))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 36860, 37074);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 36929, 37055) || true) && (f_1247_36933_36950(mem))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 36929, 37055);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 37000, 37032);

                                typename = f_1247_37011_37031(mem.Value);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 36929, 37055);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 36860, 37074);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1247, 1, 215);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1247, 1, 215);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 36785, 37089);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 37105, 37166);

                var
                builder = f_1247_37119_37165(typename, f_1247_37147_37160(members) * 7)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 37180, 37200);

                f_1247_37180_37199(builder, '#');
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 37214, 37425);
                    foreach (var m in f_1247_37232_37260_I(f_1247_37232_37260(members, m => m.Name)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 37214, 37425);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 37294, 37410) || true) && (!f_1247_37299_37314(m))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1247, 37294, 37410);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 37356, 37391);

                            f_1247_37356_37390(f_1247_37356_37378(builder, m.Name), ":");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 37294, 37410);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1247, 37214, 37425);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1247, 1, 212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1247, 1, 212);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 37441, 37458);

                f_1247_37441_37457_M(builder.Length--);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1247, 37472, 37498);

                return f_1247_37479_37497(builder);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1247, 36662, 37509);

                string
                f_1247_36801_36826(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 36801, 36826);
                    return return_v;
                }


                bool
                f_1247_36933_36950(System.Management.Automation.PSMemberNameAndType
                member)
                {
                    var return_v = IsPSTypeName(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 36933, 36950);
                    return return_v;
                }


                string?
                f_1247_37011_37031(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 37011, 37031);
                    return return_v;
                }


                System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>
                f_1247_36880_36887_I(System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 36880, 36887);
                    return return_v;
                }


                int
                f_1247_37147_37160(System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 37147, 37160);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1247_37119_37165(string
                value, int
                capacity)
                {
                    var return_v = new System.Text.StringBuilder(value, capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 37119, 37165);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1247_37180_37199(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 37180, 37199);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<System.Management.Automation.PSMemberNameAndType>
                f_1247_37232_37260(System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>
                source, System.Func<System.Management.Automation.PSMemberNameAndType, string>
                keySelector)
                {
                    var return_v = source.OrderBy<System.Management.Automation.PSMemberNameAndType, string>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 37232, 37260);
                    return return_v;
                }


                bool
                f_1247_37299_37314(System.Management.Automation.PSMemberNameAndType
                member)
                {
                    var return_v = IsPSTypeName(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 37299, 37314);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1247_37356_37378(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 37356, 37378);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1247_37356_37390(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 37356, 37390);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<System.Management.Automation.PSMemberNameAndType>
                f_1247_37232_37260_I(System.Linq.IOrderedEnumerable<System.Management.Automation.PSMemberNameAndType>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 37232, 37260);
                    return return_v;
                }


                int
                f_1247_37441_37457_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 37441, 37457);
                    return return_v;
                }


                string
                f_1247_37479_37497(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 37479, 37497);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1247, 36662, 37509);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 36662, 37509);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IList<PSMemberNameAndType> Members { get; }

        static PSSyntheticTypeName()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1247, 35017, 37578);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1247, 35017, 37578);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1247, 35017, 37578);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1247, 35017, 37578);

        System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>
        f_1247_36220_36227()
        {
            var return_v = Members;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 36220, 36227);
            return return_v;
        }


        int
        f_1247_36220_36233(System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 36220, 36233);
            return return_v;
        }


        System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>
        f_1247_36298_36305()
        {
            var return_v = Members;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 36298, 36305);
            return return_v;
        }


        System.Management.Automation.PSMemberNameAndType
        f_1247_36298_36308(System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>
        this_param, int
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 36298, 36308);
            return return_v;
        }


        bool
        f_1247_36331_36364(System.Management.Automation.PSMemberNameAndType
        member)
        {
            var return_v = IsPSTypeName(member);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 36331, 36364);
            return return_v;
        }


        System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>
        f_1247_36406_36413()
        {
            var return_v = Members;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1247, 36406, 36413);
            return return_v;
        }


        int
        f_1247_36406_36425(System.Collections.Generic.IList<System.Management.Automation.PSMemberNameAndType>
        this_param, int
        index)
        {
            this_param.RemoveAt(index);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1247, 36406, 36425);
            return 0;
        }


        static string
        f_1247_36023_36031_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1247, 35910, 36499);
            return return_v;
        }

    }

    internal interface IScriptCommandInfo
    {

        ScriptBlock ScriptBlock { get; }
    }
}
