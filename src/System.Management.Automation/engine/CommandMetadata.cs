// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Reflection;
using System.Text;

using Microsoft.PowerShell.Commands;

using Dbg = System.Diagnostics.Debug;
using System.Diagnostics.CodeAnalysis;

namespace System.Management.Automation
{
    /// <summary>
    /// Defines session capabilities provided by a PowerShell session.
    /// </summary>
    /// <seealso cref="System.Management.Automation.Runspaces.InitialSessionState.CreateRestricted"/>
    /// <seealso cref="System.Management.Automation.CommandMetadata.GetRestrictedCommands"/>
    [Flags]
    public enum SessionCapabilities
    {
        /// <summary>
        /// Session with <see cref="RemoteServer"/> capabilities can be made available on a server
        /// that wants to provide a full user experience to PowerShell clients.
        /// Clients connecting to the server will be able to use implicit remoting
        /// (Import-PSSession, Export-PSSession) as well as interactive remoting (Enter-PSSession, Exit-PSSession).
        /// </summary>
        RemoteServer = 0x1,

        /// <summary>
        /// Include language capabilities.
        /// </summary>
        Language = 0x4
    }
    [DebuggerDisplay("CommandName = {Name}; Type = {CommandType}")]
    public sealed class CommandMetadata
    {
        public CommandMetadata(Type commandType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1248, 2430, 2543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 18920, 18968);
                this.Name = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19088, 19133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19232, 19244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19755, 19817);
                this._defaultParameterSetName = ParameterAttribute.AllParameterSets;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19996, 20043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20214, 20254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20597, 20648);
                this.PositionalBinding = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20825, 20871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20982, 21122);
                this.HelpUri = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 21958, 22009);
                this._remotingCapability = RemotingCapability.PowerShell;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 22367, 22439);
                this.ConfirmImpact = ConfirmImpact.Medium;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 24561, 24572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 24596, 24627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 24781, 24830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 25416, 25447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 25765, 25793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26130, 26154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26384, 26430);
                this._otherAttributes = f_1248_26403_26430();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26528, 26543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26657, 26676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26872, 26889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 2495, 2532);

                f_1248_2495_2531(this, null, null, commandType, false);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1248, 2430, 2543);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 2430, 2543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 2430, 2543);
            }
        }

        public CommandMetadata(CommandInfo commandInfo)
        : this(f_1248_3206_3217_C(commandInfo), false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1248, 3138, 3247);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1248, 3138, 3247);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 3138, 3247);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 3138, 3247);
            }
        }

        public CommandMetadata(CommandInfo commandInfo, bool shouldGenerateCommonParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1248, 3990, 5612);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 18920, 18968);
                this.Name = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19088, 19133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19232, 19244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19755, 19817);
                this._defaultParameterSetName = ParameterAttribute.AllParameterSets;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19996, 20043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20214, 20254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20597, 20648);
                this.PositionalBinding = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20825, 20871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20982, 21122);
                this.HelpUri = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 21958, 22009);
                this._remotingCapability = RemotingCapability.PowerShell;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 22367, 22439);
                this.ConfirmImpact = ConfirmImpact.Medium;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 24561, 24572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 24596, 24627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 24781, 24830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 25416, 25447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 25765, 25793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26130, 26154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26384, 26430);
                this._otherAttributes = f_1248_26403_26430();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26528, 26543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26657, 26676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26872, 26889);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 4099, 4231) || true) && (commandInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 4099, 4231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 4156, 4216);

                    throw f_1248_4162_4215("commandInfo");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 4099, 4231);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 4245, 4529) || true) && (commandInfo is AliasInfo)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 4245, 4529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 4310, 4365);

                        commandInfo = f_1248_4324_4364(((AliasInfo)commandInfo));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 4383, 4514) || true) && (commandInfo == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 4383, 4514);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 4448, 4495);

                            throw f_1248_4454_4494();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 4383, 4514);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 4245, 4529);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1248, 4245, 4529);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1248, 4245, 4529);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 4545, 4567);

                CmdletInfo
                cmdletInfo
                = default(CmdletInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 4581, 4611);

                ExternalScriptInfo
                scriptInfo
                = default(ExternalScriptInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 4625, 4647);

                FunctionInfo
                funcInfo
                = default(FunctionInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 4661, 5601) || true) && ((cmdletInfo = commandInfo as CmdletInfo) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 4661, 5601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 4747, 4852);

                    f_1248_4747_4851(this, f_1248_4752_4768(commandInfo), f_1248_4770_4789(cmdletInfo), f_1248_4791_4818(cmdletInfo), shouldGenerateCommonParameters);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 4661, 5601);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 4661, 5601);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 4886, 5601) || true) && ((scriptInfo = commandInfo as ExternalScriptInfo) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 4886, 5601);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 5069, 5147);

                        f_1248_5069_5146(this, f_1248_5074_5096(scriptInfo), f_1248_5098_5113(scriptInfo), shouldGenerateCommonParameters);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 5165, 5215);

                        _wrappedCommandType = CommandTypes.ExternalScript;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 4886, 5601);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 4886, 5601);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 5249, 5601) || true) && ((funcInfo = commandInfo as FunctionInfo) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 5249, 5601);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 5335, 5409);

                            f_1248_5335_5408(this, f_1248_5340_5360(funcInfo), f_1248_5362_5375(funcInfo), shouldGenerateCommonParameters);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 5427, 5473);

                            _wrappedCommandType = f_1248_5449_5472(commandInfo);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 5249, 5601);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 5249, 5601);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 5539, 5586);

                            throw f_1248_5545_5585();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 5249, 5601);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 4886, 5601);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 4661, 5601);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1248, 3990, 5612);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 3990, 5612);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 3990, 5612);
            }
        }

        public CommandMetadata(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1248, 5807, 6133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 18920, 18968);
                this.Name = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19088, 19133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19232, 19244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19755, 19817);
                this._defaultParameterSetName = ParameterAttribute.AllParameterSets;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19996, 20043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20214, 20254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20597, 20648);
                this.PositionalBinding = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20825, 20871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20982, 21122);
                this.HelpUri = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 21958, 22009);
                this._remotingCapability = RemotingCapability.PowerShell;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 22367, 22439);
                this.ConfirmImpact = ConfirmImpact.Medium;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 24561, 24572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 24596, 24627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 24781, 24830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 25416, 25447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 25765, 25793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26130, 26154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26384, 26430);
                this._otherAttributes = f_1248_26403_26430();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26528, 26543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26657, 26676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26872, 26889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 5867, 5913);

                string
                scriptName = f_1248_5887_5912(path)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 5927, 6000);

                ExternalScriptInfo
                scriptInfo = f_1248_5959_5999(scriptName, path)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 6016, 6058);

                f_1248_6016_6057(this, f_1248_6021_6043(scriptInfo), path, false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 6072, 6122);

                _wrappedCommandType = CommandTypes.ExternalScript;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1248, 5807, 6133);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 5807, 6133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 5807, 6133);
            }
        }

        public CommandMetadata(CommandMetadata other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1248, 6440, 8554);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 18920, 18968);
                this.Name = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19088, 19133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19232, 19244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19755, 19817);
                this._defaultParameterSetName = ParameterAttribute.AllParameterSets;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19996, 20043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20214, 20254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20597, 20648);
                this.PositionalBinding = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20825, 20871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20982, 21122);
                this.HelpUri = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 21958, 22009);
                this._remotingCapability = RemotingCapability.PowerShell;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 22367, 22439);
                this.ConfirmImpact = ConfirmImpact.Medium;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 24561, 24572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 24596, 24627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 24781, 24830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 25416, 25447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 25765, 25793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26130, 26154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26384, 26430);
                this._otherAttributes = f_1248_26403_26430();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26528, 26543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26657, 26676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26872, 26889);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 6510, 6630) || true) && (other == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 6510, 6630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 6561, 6615);

                    throw f_1248_6567_6614("other");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 6510, 6630);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 6646, 6664);

                Name = f_1248_6653_6663(other);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 6678, 6714);

                ConfirmImpact = f_1248_6694_6713(other);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 6728, 6786);

                _defaultParameterSetFlag = other._defaultParameterSetFlag;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 6800, 6858);

                _defaultParameterSetName = other._defaultParameterSetName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 6872, 6938);

                _implementsDynamicParameters = other._implementsDynamicParameters;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 6952, 7004);

                SupportsShouldProcess = f_1248_6976_7003(other);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 7018, 7056);

                SupportsPaging = f_1248_7035_7055(other);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 7070, 7120);

                SupportsTransactions = f_1248_7093_7119(other);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 7134, 7171);

                this.CommandType = f_1248_7153_7170(other);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 7185, 7229);

                _wrappedAnyCmdlet = other._wrappedAnyCmdlet;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 7243, 7283);

                _wrappedCommand = other._wrappedCommand;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 7297, 7345);

                _wrappedCommandType = other._wrappedCommandType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 7361, 7475);

                _parameters = f_1248_7375_7474(f_1248_7417_7439(f_1248_7417_7433(other)), f_1248_7441_7473());
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 7517, 7703);
                    foreach (KeyValuePair<string, ParameterMetadata> entry in f_1248_7575_7591_I(f_1248_7575_7591(other)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 7517, 7703);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 7625, 7688);

                        f_1248_7625_7687(_parameters, entry.Key, f_1248_7652_7686(entry.Value));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 7517, 7703);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1248, 1, 187);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1248, 1, 187);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 7814, 8248) || true) && (other._otherAttributes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 7814, 8248);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 7882, 7906);

                    _otherAttributes = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 7814, 8248);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 7814, 8248);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 7972, 8068);

                    _otherAttributes = f_1248_7991_8067(f_1248_8017_8066(f_1248_8037_8065(other._otherAttributes)));
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 8086, 8233);
                        foreach (Attribute attribute in f_1248_8118_8140_I(other._otherAttributes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 8086, 8233);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 8182, 8214);

                            f_1248_8182_8213(_otherAttributes, attribute);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 8086, 8233);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1248, 1, 148);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1248, 1, 148);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 7814, 8248);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 8504, 8543);

                _staticCommandParameterMetadata = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1248, 6440, 8554);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 6440, 8554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 6440, 8554);
            }
        }

        internal CommandMetadata(
                    string name,
                    CommandTypes commandType,
                    bool isProxyForCmdlet,
                    string defaultParameterSetName,
                    bool supportsShouldProcess,
                    ConfirmImpact confirmImpact,
                    bool supportsPaging,
                    bool supportsTransactions,
                    bool positionalBinding,
                    Dictionary<string, ParameterMetadata> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1248, 8665, 9626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 18920, 18968);
                this.Name = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19088, 19133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19232, 19244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19755, 19817);
                this._defaultParameterSetName = ParameterAttribute.AllParameterSets;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19996, 20043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20214, 20254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20597, 20648);
                this.PositionalBinding = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20825, 20871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20982, 21122);
                this.HelpUri = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 21958, 22009);
                this._remotingCapability = RemotingCapability.PowerShell;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 22367, 22439);
                this.ConfirmImpact = ConfirmImpact.Medium;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 24561, 24572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 24596, 24627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 24781, 24830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 25416, 25447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 25765, 25793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26130, 26154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26384, 26430);
                this._otherAttributes = f_1248_26403_26430();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26528, 26543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26657, 26676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26872, 26889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 9118, 9148);

                Name = _wrappedCommand = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 9162, 9196);

                _wrappedCommandType = commandType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 9210, 9247);

                _wrappedAnyCmdlet = isProxyForCmdlet;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 9261, 9312);

                _defaultParameterSetName = defaultParameterSetName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 9326, 9372);

                SupportsShouldProcess = supportsShouldProcess;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 9386, 9418);

                SupportsPaging = supportsPaging;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 9432, 9462);

                ConfirmImpact = confirmImpact;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 9476, 9520);

                SupportsTransactions = supportsTransactions;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 9534, 9572);

                PositionalBinding = positionalBinding;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 9586, 9615);

                this.Parameters = parameters;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1248, 8665, 9626);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 8665, 9626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 8665, 9626);
            }
        }

        private void Init(string name, string fullyQualifiedName, Type commandType, bool shouldGenerateCommonParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1248, 9638, 10309);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 9775, 9787);

                Name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 9801, 9832);

                this.CommandType = commandType;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 9848, 10044) || true) && (commandType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 9848, 10044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 9905, 9946);

                    f_1248_9905_9945(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 9964, 10029);

                    _shouldGenerateCommonParameters = shouldGenerateCommonParameters;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 9848, 10044);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 10115, 10203);

                _wrappedCommand = (DynAbs.Tracing.TraceSender.Conditional_F1(1248, 10133, 10174) || ((!f_1248_10134_10174(fullyQualifiedName) && DynAbs.Tracing.TraceSender.Conditional_F2(1248, 10177, 10195)) || DynAbs.Tracing.TraceSender.Conditional_F3(1248, 10198, 10202))) ? fullyQualifiedName : f_1248_10198_10202();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 10217, 10259);

                _wrappedCommandType = CommandTypes.Cmdlet;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 10273, 10298);

                _wrappedAnyCmdlet = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1248, 9638, 10309);

                int
                f_1248_9905_9945(System.Management.Automation.CommandMetadata
                this_param)
                {
                    this_param.ConstructCmdletMetadataUsingReflection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 9905, 9945);
                    return 0;
                }


                bool
                f_1248_10134_10174(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 10134, 10174);
                    return return_v;
                }


                string
                f_1248_10198_10202()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 10198, 10202);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 9638, 10309);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 9638, 10309);
            }
        }

        private void Init(ScriptBlock scriptBlock, string name, bool shouldGenerateCommonParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1248, 10321, 11367);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 10438, 10759) || true) && (f_1248_10442_10471(scriptBlock))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 10438, 10759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 10505, 10530);

                    _wrappedAnyCmdlet = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 10438, 10759);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 10438, 10759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 10705, 10744);

                    shouldGenerateCommonParameters = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 10438, 10759);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 10775, 10858);

                CmdletBindingAttribute
                cmdletBindingAttribute = f_1248_10823_10857(scriptBlock)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 10872, 11135) || true) && (cmdletBindingAttribute != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 10872, 11135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 10940, 10987);

                    f_1248_10940_10986(this, cmdletBindingAttribute);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 10872, 11135);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 10872, 11135);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 11021, 11135) || true) && (f_1248_11025_11054(scriptBlock))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 11021, 11135);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 11088, 11120);

                        _defaultParameterSetName = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 11021, 11135);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 10872, 11135);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 11151, 11192);

                Obsolete = f_1248_11162_11191(scriptBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 11206, 11233);

                _scriptBlock = scriptBlock;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 11247, 11277);

                _wrappedCommand = Name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 11291, 11356);

                _shouldGenerateCommonParameters = shouldGenerateCommonParameters;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1248, 10321, 11367);

                bool
                f_1248_10442_10471(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.UsesCmdletBinding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 10442, 10471);
                    return return_v;
                }


                System.Management.Automation.CmdletBindingAttribute
                f_1248_10823_10857(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.CmdletBindingAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 10823, 10857);
                    return return_v;
                }


                int
                f_1248_10940_10986(System.Management.Automation.CommandMetadata
                this_param, System.Management.Automation.CmdletBindingAttribute
                attribute)
                {
                    this_param.ProcessCmdletAttribute((System.Management.Automation.CmdletCommonMetadataAttribute)attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 10940, 10986);
                    return 0;
                }


                bool
                f_1248_11025_11054(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.UsesCmdletBinding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 11025, 11054);
                    return return_v;
                }


                System.ObsoleteAttribute
                f_1248_11162_11191(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.ObsoleteAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 11162, 11191);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 10321, 11367);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 10321, 11367);
            }
        }

        internal static CommandMetadata Get(string commandName, Type cmdletType, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1248, 12725, 13730);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 12848, 12990) || true) && (f_1248_12852_12885(commandName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 12848, 12990);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 12919, 12975);

                    throw f_1248_12925_12974("commandName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 12848, 12990);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 13006, 13036);

                CommandMetadata
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 13052, 13284) || true) && ((context != null) && (DynAbs.Tracing.TraceSender.Expression_True(1248, 13056, 13097) && (cmdletType != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 13052, 13284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 13131, 13188);

                    string
                    cmdletTypeName = f_1248_13155_13187(cmdletType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 13206, 13269);

                    f_1248_13206_13268(s_commandMetadataCache, cmdletTypeName, out result);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 13052, 13284);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 13300, 13689) || true) && (result == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 13300, 13689);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 13352, 13415);

                    result = f_1248_13361_13414(commandName, cmdletType, context);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 13435, 13674) || true) && ((context != null) && (DynAbs.Tracing.TraceSender.Expression_True(1248, 13439, 13480) && (cmdletType != null)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 13435, 13674);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 13522, 13579);

                        string
                        cmdletTypeName = f_1248_13546_13578(cmdletType)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 13601, 13655);

                        f_1248_13601_13654(s_commandMetadataCache, cmdletTypeName, result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 13435, 13674);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 13300, 13689);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 13705, 13719);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1248, 12725, 13730);

                bool
                f_1248_12852_12885(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 12852, 12885);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1248_12925_12974(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 12925, 12974);
                    return return_v;
                }


                string
                f_1248_13155_13187(System.Type
                this_param)
                {
                    var return_v = this_param.AssemblyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 13155, 13187);
                    return return_v;
                }


                bool
                f_1248_13206_13268(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandMetadata>
                this_param, string
                key, out System.Management.Automation.CommandMetadata
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 13206, 13268);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1248_13361_13414(string
                commandName, System.Type
                cmdletType, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CommandMetadata(commandName, cmdletType, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 13361, 13414);
                    return return_v;
                }


                string
                f_1248_13546_13578(System.Type
                this_param)
                {
                    var return_v = this_param.AssemblyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 13546, 13578);
                    return return_v;
                }


                bool
                f_1248_13601_13654(System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandMetadata>
                this_param, string
                key, System.Management.Automation.CommandMetadata
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 13601, 13654);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 12725, 13730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 12725, 13730);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal CommandMetadata(string commandName, Type cmdletType, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1248, 15036, 15947);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 18920, 18968);
                this.Name = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19088, 19133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19232, 19244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19755, 19817);
                this._defaultParameterSetName = ParameterAttribute.AllParameterSets;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19996, 20043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20214, 20254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20597, 20648);
                this.PositionalBinding = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20825, 20871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20982, 21122);
                this.HelpUri = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 21958, 22009);
                this._remotingCapability = RemotingCapability.PowerShell;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 22367, 22439);
                this.ConfirmImpact = ConfirmImpact.Medium;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 24561, 24572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 24596, 24627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 24781, 24830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 25416, 25447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 25765, 25793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26130, 26154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26384, 26430);
                this._otherAttributes = f_1248_26403_26430();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26528, 26543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26657, 26676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26872, 26889);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 15148, 15290) || true) && (f_1248_15152_15185(commandName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 15148, 15290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 15219, 15275);

                    throw f_1248_15225_15274("commandName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 15148, 15290);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 15306, 15325);

                Name = commandName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 15339, 15369);

                this.CommandType = cmdletType;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 15385, 15936) || true) && (cmdletType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 15385, 15936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 15441, 15545);

                    InternalParameterMetadata
                    parameterMetadata = f_1248_15487_15544(cmdletType, context, false)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 15563, 15604);

                    f_1248_15563_15603(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 15622, 15713);

                    _staticCommandParameterMetadata = f_1248_15656_15712(this, context, parameterMetadata, true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 15731, 15856);

                    _defaultParameterSetFlag = f_1248_15758_15855(_staticCommandParameterMetadata, _defaultParameterSetName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 15874, 15921);

                    f_1248_15874_15920(_staticCommandParameterMetadata);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 15385, 15936);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1248, 15036, 15947);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 15036, 15947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 15036, 15947);
            }
        }

        internal CommandMetadata(ScriptBlock scriptblock, string commandName, ExecutionContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1248, 17257, 18729);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 18920, 18968);
                this.Name = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19088, 19133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19232, 19244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19755, 19817);
                this._defaultParameterSetName = ParameterAttribute.AllParameterSets;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19996, 20043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20214, 20254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20597, 20648);
                this.PositionalBinding = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20825, 20871);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 20982, 21122);
                this.HelpUri = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 21958, 22009);
                this._remotingCapability = RemotingCapability.PowerShell;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 22367, 22439);
                this.ConfirmImpact = ConfirmImpact.Medium;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 24561, 24572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 24596, 24627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 24781, 24830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 25416, 25447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 25765, 25793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26130, 26154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26384, 26430);
                this._otherAttributes = f_1248_26403_26430();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26528, 26543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26657, 26676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26872, 26889);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 17377, 17505) || true) && (scriptblock == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 17377, 17505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 17434, 17490);

                    throw f_1248_17440_17489("scriptblock");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 17377, 17505);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 17521, 17604);

                CmdletBindingAttribute
                cmdletBindingAttribute = f_1248_17569_17603(scriptblock)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 17620, 17848) || true) && (cmdletBindingAttribute != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 17620, 17848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 17688, 17735);

                    f_1248_17688_17734(this, cmdletBindingAttribute);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 17620, 17848);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 17620, 17848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 17801, 17833);

                    _defaultParameterSetName = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 17620, 17848);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 17864, 17905);

                Obsolete = f_1248_17875_17904(scriptblock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 17919, 17938);

                Name = commandName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 17952, 17994);

                this.CommandType = typeof(PSScriptCmdlet);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 18010, 18131) || true) && (f_1248_18014_18046(scriptblock))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 18010, 18131);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 18080, 18116);

                    _implementsDynamicParameters = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 18010, 18131);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 18147, 18388);

                InternalParameterMetadata
                parameterMetadata = f_1248_18193_18387(f_1248_18223_18259(scriptblock), false, f_1248_18357_18386(scriptblock))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 18402, 18518);

                _staticCommandParameterMetadata = f_1248_18436_18517(this, context, parameterMetadata, f_1248_18487_18516(scriptblock));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 18532, 18657);

                _defaultParameterSetFlag = f_1248_18559_18656(_staticCommandParameterMetadata, _defaultParameterSetName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 18671, 18718);

                f_1248_18671_18717(_staticCommandParameterMetadata);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1248, 17257, 18729);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 17257, 18729);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 17257, 18729);
            }
        }

        public string Name { get; set; }

        public Type CommandType { get; private set; }

        private ScriptBlock _scriptBlock;

        public string DefaultParameterSetName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1248, 19421, 19461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19427, 19459);

                    return _defaultParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1248, 19421, 19461);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 19359, 19728);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 19359, 19728);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1248, 19477, 19717);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19513, 19649) || true) && (f_1248_19517_19544(value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 19513, 19649);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19586, 19630);

                        value = ParameterAttribute.AllParameterSets;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 19513, 19649);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 19669, 19702);

                    _defaultParameterSetName = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1248, 19477, 19717);

                    bool
                    f_1248_19517_19544(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 19517, 19544);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 19359, 19728);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 19359, 19728);
                }
            }
        }

        private string _defaultParameterSetName;

        public bool SupportsShouldProcess { get; set; }

        public bool SupportsPaging { get; set; }

        public bool PositionalBinding { get; set; }

        public bool SupportsTransactions { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings")]
        public string HelpUri { get; set; }

        public RemotingCapability RemotingCapability
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1248, 21367, 21856);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 21403, 21470);

                    RemotingCapability
                    currentRemotingCapability = _remotingCapability
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 21488, 21794) || true) && ((currentRemotingCapability == Automation.RemotingCapability.PowerShell) && (DynAbs.Tracing.TraceSender.Expression_True(1248, 21492, 21662) && ((f_1248_21590_21605(this) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1248, 21589, 21661) && f_1248_21618_21661(f_1248_21618_21633(this), "ComputerName")))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 21488, 21794);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 21704, 21775);

                        _remotingCapability = Automation.RemotingCapability.SupportedByCommand;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 21488, 21794);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 21814, 21841);

                    return _remotingCapability;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1248, 21367, 21856);

                    System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                    f_1248_21590_21605(System.Management.Automation.CommandMetadata
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 21590, 21605);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                    f_1248_21618_21633(System.Management.Automation.CommandMetadata
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 21618, 21633);
                        return return_v;
                    }


                    bool
                    f_1248_21618_21661(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                    this_param, string
                    key)
                    {
                        var return_v = this_param.ContainsKey(key);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 21618, 21661);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 21298, 21919);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 21298, 21919);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1248, 21872, 21908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 21878, 21906);

                    _remotingCapability = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1248, 21872, 21908);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 21298, 21919);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 21298, 21919);
                }
            }
        }

        private RemotingCapability _remotingCapability;

        public ConfirmImpact ConfirmImpact { get; set; }

        public Dictionary<string, ParameterMetadata> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1248, 22633, 24397);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 22669, 24343) || true) && (_parameters == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 22669, 24343);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 22795, 24324) || true) && (_scriptBlock != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 22795, 24324);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 22869, 23100);

                            InternalParameterMetadata
                            parameterMetadata = f_1248_22915_23099(f_1248_22945_22982(_scriptBlock), false, f_1248_23068_23098(_scriptBlock))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 23126, 23300);

                            MergedCommandParameterMetadata
                            mergedCommandParameterMetadata =
                            f_1248_23219_23299(this, null, parameterMetadata, _shouldGenerateCommonParameters)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 23326, 23411);

                            _parameters = f_1248_23340_23410(mergedCommandParameterMetadata);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 22795, 24324);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 22795, 24324);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 23461, 24324) || true) && (f_1248_23465_23481(this) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 23461, 24324);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 23615, 23722);

                                InternalParameterMetadata
                                parameterMetadata = f_1248_23661_23721(f_1248_23691_23707(this), null, false)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 23748, 23922);

                                MergedCommandParameterMetadata
                                mergedCommandParameterMetadata =
                                f_1248_23841_23921(this, null, parameterMetadata, _shouldGenerateCommonParameters)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 24216, 24301);

                                _parameters = f_1248_24230_24300(mergedCommandParameterMetadata);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 23461, 24324);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 22795, 24324);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 22669, 24343);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 24363, 24382);

                    return _parameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1248, 22633, 24397);

                    System.Management.Automation.RuntimeDefinedParameterDictionary
                    f_1248_22945_22982(System.Management.Automation.ScriptBlock
                    this_param)
                    {
                        var return_v = this_param.RuntimeDefinedParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 22945, 22982);
                        return return_v;
                    }


                    bool
                    f_1248_23068_23098(System.Management.Automation.ScriptBlock
                    this_param)
                    {
                        var return_v = this_param.UsesCmdletBinding;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 23068, 23098);
                        return return_v;
                    }


                    System.Management.Automation.InternalParameterMetadata
                    f_1248_22915_23099(System.Management.Automation.RuntimeDefinedParameterDictionary
                    runtimeDefinedParameters, bool
                    processingDynamicParameters, bool
                    checkNames)
                    {
                        var return_v = InternalParameterMetadata.Get(runtimeDefinedParameters, processingDynamicParameters, checkNames);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 22915, 23099);
                        return return_v;
                    }


                    System.Management.Automation.MergedCommandParameterMetadata
                    f_1248_23219_23299(System.Management.Automation.CommandMetadata
                    this_param, System.Management.Automation.ExecutionContext
                    context, System.Management.Automation.InternalParameterMetadata
                    parameterMetadata, bool
                    shouldGenerateCommonParameters)
                    {
                        var return_v = this_param.MergeParameterMetadata(context, parameterMetadata, shouldGenerateCommonParameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 23219, 23299);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                    f_1248_23340_23410(System.Management.Automation.MergedCommandParameterMetadata
                    cmdParameterMetadata)
                    {
                        var return_v = ParameterMetadata.GetParameterMetadata(cmdParameterMetadata);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 23340, 23410);
                        return return_v;
                    }


                    System.Type
                    f_1248_23465_23481(System.Management.Automation.CommandMetadata
                    this_param)
                    {
                        var return_v = this_param.CommandType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 23465, 23481);
                        return return_v;
                    }


                    System.Type
                    f_1248_23691_23707(System.Management.Automation.CommandMetadata
                    this_param)
                    {
                        var return_v = this_param.CommandType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 23691, 23707);
                        return return_v;
                    }


                    System.Management.Automation.InternalParameterMetadata
                    f_1248_23661_23721(System.Type
                    type, System.Management.Automation.ExecutionContext
                    context, bool
                    processingDynamicParameters)
                    {
                        var return_v = InternalParameterMetadata.Get(type, context, processingDynamicParameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 23661, 23721);
                        return return_v;
                    }


                    System.Management.Automation.MergedCommandParameterMetadata
                    f_1248_23841_23921(System.Management.Automation.CommandMetadata
                    this_param, System.Management.Automation.ExecutionContext
                    context, System.Management.Automation.InternalParameterMetadata
                    parameterMetadata, bool
                    shouldGenerateCommonParameters)
                    {
                        var return_v = this_param.MergeParameterMetadata(context, parameterMetadata, shouldGenerateCommonParameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 23841, 23921);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                    f_1248_24230_24300(System.Management.Automation.MergedCommandParameterMetadata
                    cmdParameterMetadata)
                    {
                        var return_v = ParameterMetadata.GetParameterMetadata(cmdParameterMetadata);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 24230, 24300);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 22553, 24503);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 22553, 24503);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            private set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1248, 24413, 24492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 24457, 24477);

                    _parameters = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1248, 24413, 24492);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 22553, 24503);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 22553, 24503);
                }
            }
        }

        private Dictionary<string, ParameterMetadata> _parameters;

        private bool _shouldGenerateCommonParameters;

        internal ObsoleteAttribute Obsolete { get; set; }

        internal MergedCommandParameterMetadata StaticCommandParameterMetadata
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1248, 25255, 25345);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 25291, 25330);

                    return _staticCommandParameterMetadata;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1248, 25255, 25345);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 25160, 25356);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 25160, 25356);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private readonly MergedCommandParameterMetadata _staticCommandParameterMetadata;

        internal bool ImplementsDynamicParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1248, 25685, 25729);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 25691, 25727);

                    return _implementsDynamicParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1248, 25685, 25729);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 25619, 25740);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 25619, 25740);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool _implementsDynamicParameters;

        internal uint DefaultParameterSetFlag
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1248, 25997, 26037);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26003, 26035);

                    return _defaultParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1248, 25997, 26037);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 25935, 26105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 25935, 26105);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1248, 26053, 26094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26059, 26092);

                    _defaultParameterSetFlag = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1248, 26053, 26094);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 25935, 26105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 25935, 26105);
                }
            }
        }

        private uint _defaultParameterSetFlag;

        private readonly Collection<Attribute> _otherAttributes;

        private string _wrappedCommand;

        private CommandTypes _wrappedCommandType;

        private bool _wrappedAnyCmdlet;

        internal bool WrappedAnyCmdlet
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1248, 26955, 26988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 26961, 26986);

                    return _wrappedAnyCmdlet;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1248, 26955, 26988);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 26900, 26999);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 26900, 26999);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal CommandTypes WrappedCommandType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1248, 27076, 27154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 27112, 27139);

                    return _wrappedCommandType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1248, 27076, 27154);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 27011, 27165);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 27011, 27165);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void ConstructCmdletMetadataUsingReflection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1248, 27563, 28958);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 27641, 27784);

                f_1248_27641_27783(f_1248_27678_27689() != null, "This method should only be called when constructed with the Type");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 27901, 27994);

                Type
                dynamicParametersType = f_1248_27930_27993(f_1248_27930_27941(), f_1248_27955_27986(typeof(IDynamicParameters)), true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 28010, 28128) || true) && (dynamicParametersType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 28010, 28128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 28077, 28113);

                    _implementsDynamicParameters = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 28010, 28128);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 28199, 28261);

                var
                customAttributes = f_1248_28222_28260(f_1248_28222_28233(), false)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 28277, 28947);
                    foreach (Attribute attribute in f_1248_28309_28325_I(customAttributes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 28277, 28947);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 28359, 28422);

                        CmdletAttribute
                        cmdletAttribute = attribute as CmdletAttribute
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 28440, 28932) || true) && (cmdletAttribute != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 28440, 28932);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 28509, 28549);

                            f_1248_28509_28548(this, cmdletAttribute);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 28571, 28641);

                            this.Name = f_1248_28583_28607(cmdletAttribute) + "-" + f_1248_28616_28640(cmdletAttribute);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 28440, 28932);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 28440, 28932);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 28683, 28932) || true) && (attribute is ObsoleteAttribute)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 28683, 28932);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 28759, 28799);

                                Obsolete = (ObsoleteAttribute)attribute;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 28683, 28932);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 28683, 28932);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 28881, 28913);

                                f_1248_28881_28912(_otherAttributes, attribute);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 28683, 28932);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 28440, 28932);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 28277, 28947);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1248, 1, 671);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1248, 1, 671);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1248, 27563, 28958);

                System.Type
                f_1248_27678_27689()
                {
                    var return_v = CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 27678, 27689);
                    return return_v;
                }


                int
                f_1248_27641_27783(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 27641, 27783);
                    return 0;
                }


                System.Type
                f_1248_27930_27941()
                {
                    var return_v = CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 27930, 27941);
                    return return_v;
                }


                string
                f_1248_27955_27986(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 27955, 27986);
                    return return_v;
                }


                System.Type?
                f_1248_27930_27993(System.Type
                this_param, string
                name, bool
                ignoreCase)
                {
                    var return_v = this_param.GetInterface(name, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 27930, 27993);
                    return return_v;
                }


                System.Type
                f_1248_28222_28233()
                {
                    var return_v = CommandType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 28222, 28233);
                    return return_v;
                }


                object[]
                f_1248_28222_28260(System.Type
                this_param, bool
                inherit)
                {
                    var return_v = this_param.GetCustomAttributes(inherit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 28222, 28260);
                    return return_v;
                }


                int
                f_1248_28509_28548(System.Management.Automation.CommandMetadata
                this_param, System.Management.Automation.CmdletAttribute
                attribute)
                {
                    this_param.ProcessCmdletAttribute((System.Management.Automation.CmdletCommonMetadataAttribute)attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 28509, 28548);
                    return 0;
                }


                string
                f_1248_28583_28607(System.Management.Automation.CmdletAttribute
                this_param)
                {
                    var return_v = this_param.VerbName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 28583, 28607);
                    return return_v;
                }


                string
                f_1248_28616_28640(System.Management.Automation.CmdletAttribute
                this_param)
                {
                    var return_v = this_param.NounName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 28616, 28640);
                    return return_v;
                }


                int
                f_1248_28881_28912(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Attribute
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 28881, 28912);
                    return 0;
                }


                object[]
                f_1248_28309_28325_I(object[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 28309, 28325);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 27563, 28958);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 27563, 28958);
            }
        }

        private void ProcessCmdletAttribute(CmdletCommonMetadataAttribute attribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1248, 29485, 30846);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 29586, 29714) || true) && (attribute == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 29586, 29714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 29641, 29699);

                    throw f_1248_29647_29698("attribute");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 29586, 29714);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 29785, 29846);

                _defaultParameterSetName = f_1248_29812_29845(attribute);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 29928, 29984);

                SupportsShouldProcess = f_1248_29952_29983(attribute);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 30059, 30099);

                ConfirmImpact = f_1248_30075_30098(attribute);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 30174, 30216);

                SupportsPaging = f_1248_30191_30215(attribute);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 30297, 30351);

                SupportsTransactions = f_1248_30320_30350(attribute);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 30401, 30429);

                HelpUri = f_1248_30411_30428(attribute);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 30478, 30529);

                _remotingCapability = f_1248_30500_30528(attribute);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 30612, 30677);

                var
                cmdletBindingAttribute = attribute as CmdletBindingAttribute
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 30691, 30835) || true) && (cmdletBindingAttribute != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 30691, 30835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 30759, 30820);

                    PositionalBinding = f_1248_30779_30819(cmdletBindingAttribute);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 30691, 30835);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1248, 29485, 30846);

                System.Management.Automation.PSArgumentNullException
                f_1248_29647_29698(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 29647, 29698);
                    return return_v;
                }


                string
                f_1248_29812_29845(System.Management.Automation.CmdletCommonMetadataAttribute
                this_param)
                {
                    var return_v = this_param.DefaultParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 29812, 29845);
                    return return_v;
                }


                bool
                f_1248_29952_29983(System.Management.Automation.CmdletCommonMetadataAttribute
                this_param)
                {
                    var return_v = this_param.SupportsShouldProcess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 29952, 29983);
                    return return_v;
                }


                System.Management.Automation.ConfirmImpact
                f_1248_30075_30098(System.Management.Automation.CmdletCommonMetadataAttribute
                this_param)
                {
                    var return_v = this_param.ConfirmImpact;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 30075, 30098);
                    return return_v;
                }


                bool
                f_1248_30191_30215(System.Management.Automation.CmdletCommonMetadataAttribute
                this_param)
                {
                    var return_v = this_param.SupportsPaging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 30191, 30215);
                    return return_v;
                }


                bool
                f_1248_30320_30350(System.Management.Automation.CmdletCommonMetadataAttribute
                this_param)
                {
                    var return_v = this_param.SupportsTransactions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 30320, 30350);
                    return return_v;
                }


                string
                f_1248_30411_30428(System.Management.Automation.CmdletCommonMetadataAttribute
                this_param)
                {
                    var return_v = this_param.HelpUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 30411, 30428);
                    return return_v;
                }


                System.Management.Automation.RemotingCapability
                f_1248_30500_30528(System.Management.Automation.CmdletCommonMetadataAttribute
                this_param)
                {
                    var return_v = this_param.RemotingCapability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 30500, 30528);
                    return return_v;
                }


                bool
                f_1248_30779_30819(System.Management.Automation.CmdletBindingAttribute
                this_param)
                {
                    var return_v = this_param.PositionalBinding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 30779, 30819);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 29485, 30846);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 29485, 30846);
            }
        }

        private MergedCommandParameterMetadata MergeParameterMetadata(ExecutionContext context, InternalParameterMetadata parameterMetadata, bool shouldGenerateCommonParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1248, 31343, 34277);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 31601, 31719);

                MergedCommandParameterMetadata
                staticCommandParameterMetadata =
                f_1248_31682_31718()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 31807, 31966);

                f_1248_31807_31965(
                            // First add the metadata for the formal cmdlet parameters
                            staticCommandParameterMetadata, parameterMetadata, ParameterBinderAssociation.DeclaredFormalParameters);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 32037, 34212) || true) && (shouldGenerateCommonParameters)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 32037, 34212);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 32105, 32251);

                    InternalParameterMetadata
                    commonParametersMetadata =
                    f_1248_32179_32250(typeof(CommonParameters), context, false)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 32271, 32437);

                    f_1248_32271_32436(
                                    staticCommandParameterMetadata, commonParametersMetadata, ParameterBinderAssociation.CommonParameters);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 32574, 33041) || true) && (f_1248_32578_32604(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 32574, 33041);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 32646, 32810);

                        InternalParameterMetadata
                        shouldProcessParametersMetadata =
                        f_1248_32731_32809(typeof(ShouldProcessParameters), context, false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 32834, 33022);

                        f_1248_32834_33021(
                                            staticCommandParameterMetadata, shouldProcessParametersMetadata, ParameterBinderAssociation.ShouldProcessParameters);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 32574, 33041);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 33171, 33603) || true) && (f_1248_33175_33194(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 33171, 33603);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 33236, 33386);

                        InternalParameterMetadata
                        pagingParametersMetadata =
                        f_1248_33314_33385(typeof(PagingParameters), context, false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 33410, 33584);

                        f_1248_33410_33583(
                                            staticCommandParameterMetadata, pagingParametersMetadata, ParameterBinderAssociation.PagingParameters);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 33171, 33603);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 33739, 34197) || true) && (f_1248_33743_33768(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 33739, 34197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 33810, 33970);

                        InternalParameterMetadata
                        transactionParametersMetadata =
                        f_1248_33893_33969(typeof(TransactionParameters), context, false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 33994, 34178);

                        f_1248_33994_34177(
                                            staticCommandParameterMetadata, transactionParametersMetadata, ParameterBinderAssociation.TransactionParameters);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 33739, 34197);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 32037, 34212);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 34228, 34266);

                return staticCommandParameterMetadata;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1248, 31343, 34277);

                System.Management.Automation.MergedCommandParameterMetadata
                f_1248_31682_31718()
                {
                    var return_v = new System.Management.Automation.MergedCommandParameterMetadata();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 31682, 31718);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1248_31807_31965(System.Management.Automation.MergedCommandParameterMetadata
                this_param, System.Management.Automation.InternalParameterMetadata
                parameterMetadata, System.Management.Automation.ParameterBinderAssociation
                binderAssociation)
                {
                    var return_v = this_param.AddMetadataForBinder(parameterMetadata, binderAssociation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 31807, 31965);
                    return return_v;
                }


                System.Management.Automation.InternalParameterMetadata
                f_1248_32179_32250(System.Type
                type, System.Management.Automation.ExecutionContext
                context, bool
                processingDynamicParameters)
                {
                    var return_v = InternalParameterMetadata.Get(type, context, processingDynamicParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 32179, 32250);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1248_32271_32436(System.Management.Automation.MergedCommandParameterMetadata
                this_param, System.Management.Automation.InternalParameterMetadata
                parameterMetadata, System.Management.Automation.ParameterBinderAssociation
                binderAssociation)
                {
                    var return_v = this_param.AddMetadataForBinder(parameterMetadata, binderAssociation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 32271, 32436);
                    return return_v;
                }


                bool
                f_1248_32578_32604(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.SupportsShouldProcess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 32578, 32604);
                    return return_v;
                }


                System.Management.Automation.InternalParameterMetadata
                f_1248_32731_32809(System.Type
                type, System.Management.Automation.ExecutionContext
                context, bool
                processingDynamicParameters)
                {
                    var return_v = InternalParameterMetadata.Get(type, context, processingDynamicParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 32731, 32809);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1248_32834_33021(System.Management.Automation.MergedCommandParameterMetadata
                this_param, System.Management.Automation.InternalParameterMetadata
                parameterMetadata, System.Management.Automation.ParameterBinderAssociation
                binderAssociation)
                {
                    var return_v = this_param.AddMetadataForBinder(parameterMetadata, binderAssociation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 32834, 33021);
                    return return_v;
                }


                bool
                f_1248_33175_33194(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.SupportsPaging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 33175, 33194);
                    return return_v;
                }


                System.Management.Automation.InternalParameterMetadata
                f_1248_33314_33385(System.Type
                type, System.Management.Automation.ExecutionContext
                context, bool
                processingDynamicParameters)
                {
                    var return_v = InternalParameterMetadata.Get(type, context, processingDynamicParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 33314, 33385);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1248_33410_33583(System.Management.Automation.MergedCommandParameterMetadata
                this_param, System.Management.Automation.InternalParameterMetadata
                parameterMetadata, System.Management.Automation.ParameterBinderAssociation
                binderAssociation)
                {
                    var return_v = this_param.AddMetadataForBinder(parameterMetadata, binderAssociation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 33410, 33583);
                    return return_v;
                }


                bool
                f_1248_33743_33768(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.SupportsTransactions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 33743, 33768);
                    return return_v;
                }


                System.Management.Automation.InternalParameterMetadata
                f_1248_33893_33969(System.Type
                type, System.Management.Automation.ExecutionContext
                context, bool
                processingDynamicParameters)
                {
                    var return_v = InternalParameterMetadata.Get(type, context, processingDynamicParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 33893, 33969);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1248_33994_34177(System.Management.Automation.MergedCommandParameterMetadata
                this_param, System.Management.Automation.InternalParameterMetadata
                parameterMetadata, System.Management.Automation.ParameterBinderAssociation
                binderAssociation)
                {
                    var return_v = this_param.AddMetadataForBinder(parameterMetadata, binderAssociation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 33994, 34177);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 31343, 34277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 31343, 34277);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetProxyCommand(string helpComment, bool generateDynamicParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1248, 34503, 35660);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 34611, 34875) || true) && (f_1248_34615_34648(helpComment))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 34611, 34875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 34682, 34860);

                    helpComment = f_1248_34696_34859(f_1248_34710_34738(), @"
.ForwardHelpTargetName {0}
.ForwardHelpCategory {1}
", _wrappedCommand, _wrappedCommandType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 34611, 34875);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 34891, 34931);

                string
                dynamicParamblock = string.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 34945, 35179) || true) && (generateDynamicParameters && (DynAbs.Tracing.TraceSender.Expression_True(1248, 34949, 35010) && f_1248_34978_35010(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 34945, 35179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 35044, 35164);

                    dynamicParamblock = f_1248_35064_35163(f_1248_35078_35106(), @"
dynamicparam
{{{0}}}

", f_1248_35140_35162(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 34945, 35179);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 35195, 35619);

                string
                result = f_1248_35211_35618(f_1248_35225_35253(), @"{0}
param({1})

{2}begin
{{{3}}}

process
{{{4}}}

end
{{{5}}}
<#
{6}
#>
", f_1248_35364_35373(this), f_1248_35392_35407(this), dynamicParamblock, f_1248_35462_35477(this), f_1248_35496_35513(this), f_1248_35532_35545(this), f_1248_35564_35617(helpComment))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 35635, 35649);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1248, 34503, 35660);

                bool
                f_1248_34615_34648(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 34615, 34648);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1248_34710_34738()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 34710, 34738);
                    return return_v;
                }


                string
                f_1248_34696_34859(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, System.Management.Automation.CommandTypes
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 34696, 34859);
                    return return_v;
                }


                bool
                f_1248_34978_35010(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.ImplementsDynamicParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 34978, 35010);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1248_35078_35106()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 35078, 35106);
                    return return_v;
                }


                string
                f_1248_35140_35162(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.GetDynamicParamBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 35140, 35162);
                    return return_v;
                }


                string
                f_1248_35064_35163(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 35064, 35163);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1248_35225_35253()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 35225, 35253);
                    return return_v;
                }


                string
                f_1248_35364_35373(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.GetDecl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 35364, 35373);
                    return return_v;
                }


                string
                f_1248_35392_35407(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.GetParamBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 35392, 35407);
                    return return_v;
                }


                string
                f_1248_35462_35477(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.GetBeginBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 35462, 35477);
                    return return_v;
                }


                string
                f_1248_35496_35513(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.GetProcessBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 35496, 35513);
                    return return_v;
                }


                string
                f_1248_35532_35545(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.GetEndBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 35532, 35545);
                    return return_v;
                }


                string
                f_1248_35564_35617(string
                value)
                {
                    var return_v = CodeGeneration.EscapeBlockCommentContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 35564, 35617);
                    return return_v;
                }


                string
                f_1248_35211_35618(System.Globalization.CultureInfo
                provider, string
                format, params object?[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 35211, 35618);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 34503, 35660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 34503, 35660);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetDecl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1248, 35672, 38276);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 35722, 35751);

                string
                result = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 35765, 35797);

                string
                separator = string.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 35811, 38235) || true) && (_wrappedAnyCmdlet)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 35811, 38235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 35866, 35924);

                    StringBuilder
                    decl = f_1248_35887_35923("[CmdletBinding(")
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 35944, 36328) || true) && (!f_1248_35949_35995(_defaultParameterSetName))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 35944, 36328);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 36037, 36060);

                        f_1248_36037_36059(decl, separator);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 36082, 36123);

                        f_1248_36082_36122(decl, "DefaultParameterSetName='");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 36145, 36231);

                        f_1248_36145_36230(decl, f_1248_36157_36229(_defaultParameterSetName));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 36253, 36270);

                        f_1248_36253_36269(decl, "'");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 36292, 36309);

                        separator = ", ";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 35944, 36328);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 36348, 36747) || true) && (f_1248_36352_36373())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 36348, 36747);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 36415, 36438);

                        f_1248_36415_36437(decl, separator);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 36460, 36503);

                        f_1248_36460_36502(decl, "SupportsShouldProcess=$true");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 36525, 36542);

                        separator = ", ";
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 36564, 36587);

                        f_1248_36564_36586(decl, separator);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 36609, 36640);

                        f_1248_36609_36639(decl, "ConfirmImpact='");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 36662, 36689);

                        f_1248_36662_36688(decl, f_1248_36674_36687());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 36711, 36728);

                        f_1248_36711_36727(decl, "'");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 36348, 36747);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 36767, 36966) || true) && (f_1248_36771_36785())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 36767, 36966);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 36827, 36850);

                        f_1248_36827_36849(decl, separator);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 36872, 36908);

                        f_1248_36872_36907(decl, "SupportsPaging=$true");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 36930, 36947);

                        separator = ", ";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 36767, 36966);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 36986, 37197) || true) && (f_1248_36990_37010())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 36986, 37197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 37052, 37075);

                        f_1248_37052_37074(decl, separator);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 37097, 37139);

                        f_1248_37097_37138(decl, "SupportsTransactions=$true");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 37161, 37178);

                        separator = ", ";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 36986, 37197);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 37217, 37432) || true) && (f_1248_37221_37238() == false)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 37217, 37432);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 37289, 37312);

                        f_1248_37289_37311(decl, separator);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 37334, 37374);

                        f_1248_37334_37373(decl, "PositionalBinding=$false");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 37396, 37413);

                        separator = ", ";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 37217, 37432);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 37452, 37786) || true) && (!f_1248_37457_37486(f_1248_37478_37485()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 37452, 37786);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 37528, 37551);

                        f_1248_37528_37550(decl, separator);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 37573, 37598);

                        f_1248_37573_37597(decl, "HelpUri='");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 37620, 37689);

                        f_1248_37620_37688(decl, f_1248_37632_37687(f_1248_37679_37686()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 37711, 37728);

                        f_1248_37711_37727(decl, "'");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 37750, 37767);

                        separator = ", ";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 37452, 37786);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 37806, 38137) || true) && (_remotingCapability != RemotingCapability.PowerShell)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 37806, 38137);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 37904, 37927);

                        f_1248_37904_37926(decl, separator);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 37949, 37985);

                        f_1248_37949_37984(decl, "RemotingCapability='");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 38007, 38040);

                        f_1248_38007_38039(decl, _remotingCapability);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 38062, 38079);

                        f_1248_38062_38078(decl, "'");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 38101, 38118);

                        separator = ", ";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 37806, 38137);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 38157, 38175);

                    f_1248_38157_38174(
                                    decl, ")]");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 38195, 38220);

                    result = f_1248_38204_38219(decl);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 35811, 38235);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 38251, 38265);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1248, 35672, 38276);

                System.Text.StringBuilder
                f_1248_35887_35923(string
                value)
                {
                    var return_v = new System.Text.StringBuilder(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 35887, 35923);
                    return return_v;
                }


                bool
                f_1248_35949_35995(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 35949, 35995);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_36037_36059(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 36037, 36059);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_36082_36122(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 36082, 36122);
                    return return_v;
                }


                string
                f_1248_36157_36229(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 36157, 36229);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_36145_36230(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 36145, 36230);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_36253_36269(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 36253, 36269);
                    return return_v;
                }


                bool
                f_1248_36352_36373()
                {
                    var return_v = SupportsShouldProcess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 36352, 36373);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_36415_36437(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 36415, 36437);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_36460_36502(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 36460, 36502);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_36564_36586(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 36564, 36586);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_36609_36639(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 36609, 36639);
                    return return_v;
                }


                System.Management.Automation.ConfirmImpact
                f_1248_36674_36687()
                {
                    var return_v = ConfirmImpact;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 36674, 36687);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_36662_36688(System.Text.StringBuilder
                this_param, System.Management.Automation.ConfirmImpact
                value)
                {
                    var return_v = this_param.Append((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 36662, 36688);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_36711_36727(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 36711, 36727);
                    return return_v;
                }


                bool
                f_1248_36771_36785()
                {
                    var return_v = SupportsPaging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 36771, 36785);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_36827_36849(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 36827, 36849);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_36872_36907(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 36872, 36907);
                    return return_v;
                }


                bool
                f_1248_36990_37010()
                {
                    var return_v = SupportsTransactions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 36990, 37010);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_37052_37074(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 37052, 37074);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_37097_37138(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 37097, 37138);
                    return return_v;
                }


                bool
                f_1248_37221_37238()
                {
                    var return_v = PositionalBinding;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 37221, 37238);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_37289_37311(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 37289, 37311);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_37334_37373(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 37334, 37373);
                    return return_v;
                }


                string
                f_1248_37478_37485()
                {
                    var return_v = HelpUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 37478, 37485);
                    return return_v;
                }


                bool
                f_1248_37457_37486(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 37457, 37486);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_37528_37550(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 37528, 37550);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_37573_37597(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 37573, 37597);
                    return return_v;
                }


                string
                f_1248_37679_37686()
                {
                    var return_v = HelpUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 37679, 37686);
                    return return_v;
                }


                string
                f_1248_37632_37687(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 37632, 37687);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_37620_37688(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 37620, 37688);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_37711_37727(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 37711, 37727);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_37904_37926(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 37904, 37926);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_37949_37984(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 37949, 37984);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_38007_38039(System.Text.StringBuilder
                this_param, System.Management.Automation.RemotingCapability
                value)
                {
                    var return_v = this_param.Append((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 38007, 38039);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_38062_38078(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 38062, 38078);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_38157_38174(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 38157, 38174);
                    return return_v;
                }


                string
                f_1248_38204_38219(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 38204, 38219);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 35672, 38276);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 35672, 38276);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetParamBlock()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1248, 38288, 39421);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 38344, 39374) || true) && (f_1248_38348_38369(f_1248_38348_38363(f_1248_38348_38358())) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 38344, 39374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 38407, 38454);

                    StringBuilder
                    parameters = f_1248_38434_38453()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 38472, 38531);

                    string
                    prefix = f_1248_38488_38530(f_1248_38502_38521(), "    ")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 38549, 38579);

                    string
                    paramDataPrefix = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 38599, 39310);
                        foreach (var pair in f_1248_38620_38630_I(f_1248_38620_38630()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 38599, 39310);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 38672, 39053) || true) && (paramDataPrefix != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 38672, 39053);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 38749, 38784);

                                f_1248_38749_38783(parameters, paramDataPrefix);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 38672, 39053);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 38672, 39053);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 38972, 39030);

                                paramDataPrefix = f_1248_38990_39029(",", f_1248_39009_39028());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 38672, 39053);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 39151, 39240);

                            string
                            paramData = f_1248_39170_39239(pair.Value, prefix, pair.Key, _wrappedAnyCmdlet)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 39262, 39291);

                            f_1248_39262_39290(parameters, paramData);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 38599, 39310);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1248, 1, 712);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1248, 1, 712);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 39330, 39359);

                    return f_1248_39337_39358(parameters);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 38344, 39374);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 39390, 39410);

                return string.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1248, 38288, 39421);

                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                f_1248_38348_38358()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 38348, 38358);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>.KeyCollection
                f_1248_38348_38363(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 38348, 38363);
                    return return_v;
                }


                int
                f_1248_38348_38369(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>.KeyCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 38348, 38369);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_38434_38453()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 38434, 38453);
                    return return_v;
                }


                string
                f_1248_38502_38521()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 38502, 38521);
                    return return_v;
                }


                string
                f_1248_38488_38530(string
                str0, string
                str1)
                {
                    var return_v = string.Concat(str0, str1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 38488, 38530);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                f_1248_38620_38630()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 38620, 38630);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_38749_38783(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 38749, 38783);
                    return return_v;
                }


                string
                f_1248_39009_39028()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 39009, 39028);
                    return return_v;
                }


                string
                f_1248_38990_39029(string
                str0, string
                str1)
                {
                    var return_v = string.Concat(str0, str1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 38990, 39029);
                    return return_v;
                }


                string
                f_1248_39170_39239(System.Management.Automation.ParameterMetadata
                this_param, string
                prefix, string
                paramNameOverride, bool
                isProxyForCmdlet)
                {
                    var return_v = this_param.GetProxyParameterData(prefix, paramNameOverride, isProxyForCmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 39170, 39239);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1248_39262_39290(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 39262, 39290);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                f_1248_38620_38630_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 38620, 38630);
                    return return_v;
                }


                string
                f_1248_39337_39358(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 39337, 39358);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 38288, 39421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 38288, 39421);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetBeginBlock()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1248, 39433, 41720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 39489, 39503);

                string
                result
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 39519, 39739) || true) && (f_1248_39523_39560(_wrappedCommand))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 39519, 39739);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 39594, 39663);

                    string
                    error = f_1248_39609_39662()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 39681, 39724);

                    throw f_1248_39687_39723(error);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 39519, 39739);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 39755, 39808);

                string
                commandOrigin = "$myInvocation.CommandOrigin"
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 39963, 40089) || true) && (_wrappedCommandType == CommandTypes.Function)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 39963, 40089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 40045, 40074);

                    commandOrigin = string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 39963, 40089);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 40105, 41679) || true) && (_wrappedAnyCmdlet)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 40105, 41679);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 40160, 40933);

                    result = f_1248_40169_40932(f_1248_40183_40211(), @"
    try {{
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {{
            $PSBoundParameters['OutBuffer'] = 1
        }}

        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('{0}', [System.Management.Automation.CommandTypes]::{1})
        $scriptCmd = {{& $wrappedCmd @PSBoundParameters }}

        $steppablePipeline = $scriptCmd.GetSteppablePipeline({2})
        $steppablePipeline.Begin($PSCmdlet)
    }} catch {{
        throw
    }}
", f_1248_40768_40831(_wrappedCommand), _wrappedCommandType, commandOrigin);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 40105, 41679);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 40105, 41679);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 40999, 41664);

                    result = f_1248_41008_41663(f_1248_41022_41050(), @"
    try {{
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('{0}', [System.Management.Automation.CommandTypes]::{1})
        $PSBoundParameters.Add('$args', $args)
        $scriptCmd = {{& $wrappedCmd @PSBoundParameters }}

        $steppablePipeline = $scriptCmd.GetSteppablePipeline({2})
        $steppablePipeline.Begin($myInvocation.ExpectingInput, $ExecutionContext)
    }} catch {{
        throw
    }}
", f_1248_41511_41574(_wrappedCommand), _wrappedCommandType, commandOrigin);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 40105, 41679);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 41695, 41709);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1248, 39433, 41720);

                bool
                f_1248_39523_39560(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 39523, 39560);
                    return return_v;
                }


                string
                f_1248_39609_39662()
                {
                    var return_v = ProxyCommandStrings.CommandMetadataMissingCommandName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 39609, 39662);
                    return return_v;
                }


                System.InvalidOperationException
                f_1248_39687_39723(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 39687, 39723);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1248_40183_40211()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 40183, 40211);
                    return return_v;
                }


                string
                f_1248_40768_40831(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 40768, 40831);
                    return return_v;
                }


                string
                f_1248_40169_40932(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, System.Management.Automation.CommandTypes
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 40169, 40932);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1248_41022_41050()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 41022, 41050);
                    return return_v;
                }


                string
                f_1248_41511_41574(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 41511, 41574);
                    return return_v;
                }


                string
                f_1248_41008_41663(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, System.Management.Automation.CommandTypes
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 41008, 41663);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 39433, 41720);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 39433, 41720);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetProcessBlock()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1248, 41732, 41902);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 41790, 41891);

                return @"
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1248, 41732, 41902);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 41732, 41902);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 41732, 41902);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetDynamicParamBlock()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1248, 41914, 43140);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 41977, 43129);

                return f_1248_41984_43128(f_1248_41998_42026(), @"
    try {{
        $targetCmd = $ExecutionContext.InvokeCommand.GetCommand('{0}', [System.Management.Automation.CommandTypes]::{1}, $PSBoundParameters)
        $dynamicParams = @($targetCmd.Parameters.GetEnumerator() | Microsoft.PowerShell.Core\Where-Object {{ $_.Value.IsDynamic }})
        if ($dynamicParams.Length -gt 0)
        {{
            $paramDictionary = [Management.Automation.RuntimeDefinedParameterDictionary]::new()
            foreach ($param in $dynamicParams)
            {{
                $param = $param.Value

                if(-not $MyInvocation.MyCommand.Parameters.ContainsKey($param.Name))
                {{
                    $dynParam = [Management.Automation.RuntimeDefinedParameter]::new($param.Name, $param.ParameterType, $param.Attributes)
                    $paramDictionary.Add($param.Name, $dynParam)
                }}
            }}

            return $paramDictionary
        }}
    }} catch {{
        throw
    }}
", f_1248_43030_43093(_wrappedCommand), _wrappedCommandType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1248, 41914, 43140);

                System.Globalization.CultureInfo
                f_1248_41998_42026()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 41998, 42026);
                    return return_v;
                }


                string
                f_1248_43030_43093(string
                value)
                {
                    var return_v = CodeGeneration.EscapeSingleQuotedStringContent(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 43030, 43093);
                    return return_v;
                }


                string
                f_1248_41984_43128(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, System.Management.Automation.CommandTypes
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 41984, 43128);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 41914, 43140);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 41914, 43140);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetEndBlock()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1248, 43152, 43312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 43206, 43301);

                return @"
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1248, 43152, 43312);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 43152, 43312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 43152, 43312);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal const string
        isSafeNameOrIdentifierRegex = @"^[-._:\\\p{Ll}\p{Lu}\p{Lt}\p{Lo}\p{Nd}\p{Lm}]{1,100}$"
        ;

        private static CommandMetadata GetRestrictedCmdlet(string cmdletName, string defaultParameterSet, string helpUri, params ParameterMetadata[] parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1248, 43570, 45415);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 43747, 43884);

                Dictionary<string, ParameterMetadata>
                parametersDictionary = f_1248_43808_43883(f_1248_43850_43882())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 43898, 44049);
                    foreach (ParameterMetadata parameter in f_1248_43938_43948_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 43898, 44049);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 43982, 44034);

                        f_1248_43982_44033(parametersDictionary, f_1248_44007_44021(parameter), parameter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 43898, 44049);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1248, 1, 152);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1248, 1, 152);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 44732, 45329);

                CommandMetadata
                metadata = f_1248_44759_45328(name: cmdletName, commandType: CommandTypes.Cmdlet, isProxyForCmdlet: true, defaultParameterSetName: defaultParameterSet, supportsShouldProcess: false, confirmImpact: ConfirmImpact.None, supportsPaging: false, supportsTransactions: false, positionalBinding: true, parameters: parametersDictionary)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 45345, 45372);

                metadata.HelpUri = helpUri;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 45388, 45404);

                return metadata;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1248, 43570, 45415);

                System.StringComparer
                f_1248_43850_43882()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 43850, 43882);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                f_1248_43808_43883(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 43808, 43883);
                    return return_v;
                }


                string
                f_1248_44007_44021(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 44007, 44021);
                    return return_v;
                }


                int
                f_1248_43982_44033(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                this_param, string
                key, System.Management.Automation.ParameterMetadata
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 43982, 44033);
                    return 0;
                }


                System.Management.Automation.ParameterMetadata[]
                f_1248_43938_43948_I(System.Management.Automation.ParameterMetadata[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 43938, 43948);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1248_44759_45328(string
                name, System.Management.Automation.CommandTypes
                commandType, bool
                isProxyForCmdlet, string
                defaultParameterSetName, bool
                supportsShouldProcess, System.Management.Automation.ConfirmImpact
                confirmImpact, bool
                supportsPaging, bool
                supportsTransactions, bool
                positionalBinding, System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
                parameters)
                {
                    var return_v = new System.Management.Automation.CommandMetadata(name: name, commandType: commandType, isProxyForCmdlet: isProxyForCmdlet, defaultParameterSetName: defaultParameterSetName, supportsShouldProcess: supportsShouldProcess, confirmImpact: confirmImpact, supportsPaging: supportsPaging, supportsTransactions: supportsTransactions, positionalBinding: positionalBinding, parameters: parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 44759, 45328);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 43570, 45415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 43570, 45415);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CommandMetadata GetRestrictedGetCommand()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1248, 45427, 48089);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 46003, 46085);

                ParameterMetadata
                nameParameter = f_1248_46037_46084("Name", typeof(string[]))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 46099, 46166);

                f_1248_46099_46165(f_1248_46099_46123(nameParameter), f_1248_46128_46164(0, 1000));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 46180, 46246);

                f_1248_46180_46245(f_1248_46180_46204(nameParameter), f_1248_46209_46244(0, 1000));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 46407, 46493);

                ParameterMetadata
                moduleParameter = f_1248_46443_46492("Module", typeof(string[]))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 46507, 46576);

                f_1248_46507_46575(f_1248_46507_46533(moduleParameter), f_1248_46538_46574(0, 1000));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 46590, 46657);

                f_1248_46590_46656(f_1248_46590_46616(moduleParameter), f_1248_46621_46655(0, 100));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 46828, 46926);

                ParameterMetadata
                argumentListParameter = f_1248_46870_46925("ArgumentList", typeof(object[]))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 46940, 47013);

                f_1248_46940_47012(f_1248_46940_46972(argumentListParameter), f_1248_46977_47011(0, 100));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 47182, 47282);

                ParameterMetadata
                commandTypeParameter = f_1248_47223_47281("CommandType", typeof(CommandTypes))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 47347, 47452);

                ParameterMetadata
                listImportedParameter = f_1248_47389_47451("ListImported", typeof(SwitchParameter))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 47557, 47659);

                ParameterMetadata
                showCommandInfo = f_1248_47593_47658("ShowCommandInfo", typeof(SwitchParameter))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 47675, 48078);

                return f_1248_47682_48077("Get-Command", null, "https://go.microsoft.com/fwlink/?LinkID=113309", nameParameter, moduleParameter, argumentListParameter, commandTypeParameter, listImportedParameter, showCommandInfo);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1248, 45427, 48089);

                System.Management.Automation.ParameterMetadata
                f_1248_46037_46084(string
                name, System.Type
                parameterType)
                {
                    var return_v = new System.Management.Automation.ParameterMetadata(name, parameterType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 46037, 46084);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1248_46099_46123(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 46099, 46123);
                    return return_v;
                }


                System.Management.Automation.ValidateLengthAttribute
                f_1248_46128_46164(int
                minLength, int
                maxLength)
                {
                    var return_v = new System.Management.Automation.ValidateLengthAttribute(minLength, maxLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 46128, 46164);
                    return return_v;
                }


                int
                f_1248_46099_46165(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ValidateLengthAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 46099, 46165);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1248_46180_46204(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 46180, 46204);
                    return return_v;
                }


                System.Management.Automation.ValidateCountAttribute
                f_1248_46209_46244(int
                minLength, int
                maxLength)
                {
                    var return_v = new System.Management.Automation.ValidateCountAttribute(minLength, maxLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 46209, 46244);
                    return return_v;
                }


                int
                f_1248_46180_46245(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ValidateCountAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 46180, 46245);
                    return 0;
                }


                System.Management.Automation.ParameterMetadata
                f_1248_46443_46492(string
                name, System.Type
                parameterType)
                {
                    var return_v = new System.Management.Automation.ParameterMetadata(name, parameterType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 46443, 46492);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1248_46507_46533(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 46507, 46533);
                    return return_v;
                }


                System.Management.Automation.ValidateLengthAttribute
                f_1248_46538_46574(int
                minLength, int
                maxLength)
                {
                    var return_v = new System.Management.Automation.ValidateLengthAttribute(minLength, maxLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 46538, 46574);
                    return return_v;
                }


                int
                f_1248_46507_46575(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ValidateLengthAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 46507, 46575);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1248_46590_46616(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 46590, 46616);
                    return return_v;
                }


                System.Management.Automation.ValidateCountAttribute
                f_1248_46621_46655(int
                minLength, int
                maxLength)
                {
                    var return_v = new System.Management.Automation.ValidateCountAttribute(minLength, maxLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 46621, 46655);
                    return return_v;
                }


                int
                f_1248_46590_46656(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ValidateCountAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 46590, 46656);
                    return 0;
                }


                System.Management.Automation.ParameterMetadata
                f_1248_46870_46925(string
                name, System.Type
                parameterType)
                {
                    var return_v = new System.Management.Automation.ParameterMetadata(name, parameterType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 46870, 46925);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1248_46940_46972(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 46940, 46972);
                    return return_v;
                }


                System.Management.Automation.ValidateCountAttribute
                f_1248_46977_47011(int
                minLength, int
                maxLength)
                {
                    var return_v = new System.Management.Automation.ValidateCountAttribute(minLength, maxLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 46977, 47011);
                    return return_v;
                }


                int
                f_1248_46940_47012(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ValidateCountAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 46940, 47012);
                    return 0;
                }


                System.Management.Automation.ParameterMetadata
                f_1248_47223_47281(string
                name, System.Type
                parameterType)
                {
                    var return_v = new System.Management.Automation.ParameterMetadata(name, parameterType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 47223, 47281);
                    return return_v;
                }


                System.Management.Automation.ParameterMetadata
                f_1248_47389_47451(string
                name, System.Type
                parameterType)
                {
                    var return_v = new System.Management.Automation.ParameterMetadata(name, parameterType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 47389, 47451);
                    return return_v;
                }


                System.Management.Automation.ParameterMetadata
                f_1248_47593_47658(string
                name, System.Type
                parameterType)
                {
                    var return_v = new System.Management.Automation.ParameterMetadata(name, parameterType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 47593, 47658);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1248_47682_48077(string
                cmdletName, string
                defaultParameterSet, string
                helpUri, params System.Management.Automation.ParameterMetadata[]
                parameters)
                {
                    var return_v = GetRestrictedCmdlet(cmdletName, defaultParameterSet, helpUri, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 47682, 48077);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 45427, 48089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 45427, 48089);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CommandMetadata GetRestrictedGetFormatData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1248, 48101, 49089);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 48455, 48545);

                ParameterMetadata
                typeNameParameter = f_1248_48493_48544("TypeName", typeof(string[]))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 48559, 48630);

                f_1248_48559_48629(f_1248_48559_48587(typeNameParameter), f_1248_48592_48628(0, 1000));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 48644, 48714);

                f_1248_48644_48713(f_1248_48644_48672(typeNameParameter), f_1248_48677_48712(0, 1000));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 48807, 48914);

                ParameterMetadata
                powershellVersionParameter = f_1248_48854_48913("PowerShellVersion", typeof(Version))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 48930, 49078);

                return f_1248_48937_49077("Get-FormatData", null, "https://go.microsoft.com/fwlink/?LinkID=144303", typeNameParameter, powershellVersionParameter);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1248, 48101, 49089);

                System.Management.Automation.ParameterMetadata
                f_1248_48493_48544(string
                name, System.Type
                parameterType)
                {
                    var return_v = new System.Management.Automation.ParameterMetadata(name, parameterType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 48493, 48544);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1248_48559_48587(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 48559, 48587);
                    return return_v;
                }


                System.Management.Automation.ValidateLengthAttribute
                f_1248_48592_48628(int
                minLength, int
                maxLength)
                {
                    var return_v = new System.Management.Automation.ValidateLengthAttribute(minLength, maxLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 48592, 48628);
                    return return_v;
                }


                int
                f_1248_48559_48629(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ValidateLengthAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 48559, 48629);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1248_48644_48672(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 48644, 48672);
                    return return_v;
                }


                System.Management.Automation.ValidateCountAttribute
                f_1248_48677_48712(int
                minLength, int
                maxLength)
                {
                    var return_v = new System.Management.Automation.ValidateCountAttribute(minLength, maxLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 48677, 48712);
                    return return_v;
                }


                int
                f_1248_48644_48713(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ValidateCountAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 48644, 48713);
                    return 0;
                }


                System.Management.Automation.ParameterMetadata
                f_1248_48854_48913(string
                name, System.Type
                parameterType)
                {
                    var return_v = new System.Management.Automation.ParameterMetadata(name, parameterType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 48854, 48913);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1248_48937_49077(string
                cmdletName, string
                defaultParameterSet, string
                helpUri, params System.Management.Automation.ParameterMetadata[]
                parameters)
                {
                    var return_v = GetRestrictedCmdlet(cmdletName, defaultParameterSet, helpUri, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 48937, 49077);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 48101, 49089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 48101, 49089);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CommandMetadata GetRestrictedGetHelp()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1248, 49101, 50429);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 49648, 49728);

                ParameterMetadata
                nameParameter = f_1248_49682_49727("Name", typeof(string))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 49742, 49830);

                f_1248_49742_49829(f_1248_49742_49766(nameParameter), f_1248_49771_49828(isSafeNameOrIdentifierRegex));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 49844, 49911);

                f_1248_49844_49910(f_1248_49844_49868(nameParameter), f_1248_49873_49909(0, 1000));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 49992, 50082);

                ParameterMetadata
                categoryParameter = f_1248_50030_50081("Category", typeof(string[]))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 50096, 50192);

                f_1248_50096_50191(f_1248_50096_50124(categoryParameter), f_1248_50129_50190(f_1248_50154_50189(typeof(HelpCategory))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 50206, 50273);

                f_1248_50206_50272(f_1248_50206_50234(categoryParameter), f_1248_50239_50271(0, 1));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 50289, 50418);

                return f_1248_50296_50417("Get-Help", null, "https://go.microsoft.com/fwlink/?LinkID=113316", nameParameter, categoryParameter);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1248, 49101, 50429);

                System.Management.Automation.ParameterMetadata
                f_1248_49682_49727(string
                name, System.Type
                parameterType)
                {
                    var return_v = new System.Management.Automation.ParameterMetadata(name, parameterType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 49682, 49727);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1248_49742_49766(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 49742, 49766);
                    return return_v;
                }


                System.Management.Automation.ValidatePatternAttribute
                f_1248_49771_49828(string
                regexPattern)
                {
                    var return_v = new System.Management.Automation.ValidatePatternAttribute(regexPattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 49771, 49828);
                    return return_v;
                }


                int
                f_1248_49742_49829(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ValidatePatternAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 49742, 49829);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1248_49844_49868(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 49844, 49868);
                    return return_v;
                }


                System.Management.Automation.ValidateLengthAttribute
                f_1248_49873_49909(int
                minLength, int
                maxLength)
                {
                    var return_v = new System.Management.Automation.ValidateLengthAttribute(minLength, maxLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 49873, 49909);
                    return return_v;
                }


                int
                f_1248_49844_49910(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ValidateLengthAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 49844, 49910);
                    return 0;
                }


                System.Management.Automation.ParameterMetadata
                f_1248_50030_50081(string
                name, System.Type
                parameterType)
                {
                    var return_v = new System.Management.Automation.ParameterMetadata(name, parameterType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 50030, 50081);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1248_50096_50124(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 50096, 50124);
                    return return_v;
                }


                string[]
                f_1248_50154_50189(System.Type
                enumType)
                {
                    var return_v = Enum.GetNames(enumType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 50154, 50189);
                    return return_v;
                }


                System.Management.Automation.ValidateSetAttribute
                f_1248_50129_50190(params string[]
                validValues)
                {
                    var return_v = new System.Management.Automation.ValidateSetAttribute(validValues);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 50129, 50190);
                    return return_v;
                }


                int
                f_1248_50096_50191(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ValidateSetAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 50096, 50191);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1248_50206_50234(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 50206, 50234);
                    return return_v;
                }


                System.Management.Automation.ValidateCountAttribute
                f_1248_50239_50271(int
                minLength, int
                maxLength)
                {
                    var return_v = new System.Management.Automation.ValidateCountAttribute(minLength, maxLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 50239, 50271);
                    return return_v;
                }


                int
                f_1248_50206_50272(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ValidateCountAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 50206, 50272);
                    return 0;
                }


                System.Management.Automation.CommandMetadata
                f_1248_50296_50417(string
                cmdletName, string
                defaultParameterSet, string
                helpUri, params System.Management.Automation.ParameterMetadata[]
                parameters)
                {
                    var return_v = GetRestrictedCmdlet(cmdletName, defaultParameterSet, helpUri, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 50296, 50417);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 49101, 50429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 49101, 50429);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CommandMetadata GetRestrictedSelectObject()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1248, 50441, 52135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 50836, 51078);

                string[]
                validPropertyValues = new string[] {
                "ModuleName", "Namespace", "OutputType", "Count", "HelpUri",
                "Name", "CommandType", "ResolvedCommandName", "DefaultParameterSet", "CmdletBinding", "Parameters" }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 51092, 51182);

                ParameterMetadata
                propertyParameter = f_1248_51130_51181("Property", typeof(string[]))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 51196, 51276);

                f_1248_51196_51275(f_1248_51196_51224(propertyParameter), f_1248_51229_51274(validPropertyValues));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 51290, 51382);

                f_1248_51290_51381(f_1248_51290_51318(propertyParameter), f_1248_51323_51380(1, f_1248_51353_51379(validPropertyValues)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 51515, 51603);

                ParameterMetadata
                inputParameter = f_1248_51550_51602("InputObject", typeof(object))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 51617, 51953);

                f_1248_51617_51952(f_1248_51617_51645(inputParameter), ParameterAttribute.AllParameterSets, f_1248_51722_51951(int.MinValue, ParameterSetMetadata.ParameterFlags.ValueFromPipeline | ParameterSetMetadata.ParameterFlags.Mandatory, null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 51988, 52124);

                return f_1248_51995_52123("Select-Object", null, "https://go.microsoft.com/fwlink/?LinkID=2096716", propertyParameter, inputParameter);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1248, 50441, 52135);

                System.Management.Automation.ParameterMetadata
                f_1248_51130_51181(string
                name, System.Type
                parameterType)
                {
                    var return_v = new System.Management.Automation.ParameterMetadata(name, parameterType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 51130, 51181);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1248_51196_51224(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 51196, 51224);
                    return return_v;
                }


                System.Management.Automation.ValidateSetAttribute
                f_1248_51229_51274(params string[]
                validValues)
                {
                    var return_v = new System.Management.Automation.ValidateSetAttribute(validValues);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 51229, 51274);
                    return return_v;
                }


                int
                f_1248_51196_51275(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ValidateSetAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 51196, 51275);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1248_51290_51318(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 51290, 51318);
                    return return_v;
                }


                int
                f_1248_51353_51379(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 51353, 51379);
                    return return_v;
                }


                System.Management.Automation.ValidateCountAttribute
                f_1248_51323_51380(int
                minLength, int
                maxLength)
                {
                    var return_v = new System.Management.Automation.ValidateCountAttribute(minLength, maxLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 51323, 51380);
                    return return_v;
                }


                int
                f_1248_51290_51381(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ValidateCountAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 51290, 51381);
                    return 0;
                }


                System.Management.Automation.ParameterMetadata
                f_1248_51550_51602(string
                name, System.Type
                parameterType)
                {
                    var return_v = new System.Management.Automation.ParameterMetadata(name, parameterType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 51550, 51602);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1248_51617_51645(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 51617, 51645);
                    return return_v;
                }


                System.Management.Automation.ParameterSetMetadata
                f_1248_51722_51951(int
                position, System.Management.Automation.ParameterSetMetadata.ParameterFlags
                flags, string
                helpMessage)
                {
                    var return_v = new System.Management.Automation.ParameterSetMetadata(position, flags, helpMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 51722, 51951);
                    return return_v;
                }


                int
                f_1248_51617_51952(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param, string
                key, System.Management.Automation.ParameterSetMetadata
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 51617, 51952);
                    return 0;
                }


                System.Management.Automation.CommandMetadata
                f_1248_51995_52123(string
                cmdletName, string
                defaultParameterSet, string
                helpUri, params System.Management.Automation.ParameterMetadata[]
                parameters)
                {
                    var return_v = GetRestrictedCmdlet(cmdletName, defaultParameterSet, helpUri, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 51995, 52123);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 50441, 52135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 50441, 52135);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CommandMetadata GetRestrictedMeasureObject()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1248, 52147, 53128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 52527, 52615);

                ParameterMetadata
                inputParameter = f_1248_52562_52614("InputObject", typeof(object))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 52629, 52965);

                f_1248_52629_52964(f_1248_52629_52657(inputParameter), ParameterAttribute.AllParameterSets, f_1248_52734_52963(int.MinValue, ParameterSetMetadata.ParameterFlags.ValueFromPipeline | ParameterSetMetadata.ParameterFlags.Mandatory, null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 53000, 53117);

                return f_1248_53007_53116("Measure-Object", null, "https://go.microsoft.com/fwlink/?LinkID=113349", inputParameter);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1248, 52147, 53128);

                System.Management.Automation.ParameterMetadata
                f_1248_52562_52614(string
                name, System.Type
                parameterType)
                {
                    var return_v = new System.Management.Automation.ParameterMetadata(name, parameterType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 52562, 52614);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1248_52629_52657(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 52629, 52657);
                    return return_v;
                }


                System.Management.Automation.ParameterSetMetadata
                f_1248_52734_52963(int
                position, System.Management.Automation.ParameterSetMetadata.ParameterFlags
                flags, string
                helpMessage)
                {
                    var return_v = new System.Management.Automation.ParameterSetMetadata(position, flags, helpMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 52734, 52963);
                    return return_v;
                }


                int
                f_1248_52629_52964(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param, string
                key, System.Management.Automation.ParameterSetMetadata
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 52629, 52964);
                    return 0;
                }


                System.Management.Automation.CommandMetadata
                f_1248_53007_53116(string
                cmdletName, string
                defaultParameterSet, string
                helpUri, params System.Management.Automation.ParameterMetadata[]
                parameters)
                {
                    var return_v = GetRestrictedCmdlet(cmdletName, defaultParameterSet, helpUri, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 53007, 53116);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 52147, 53128);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 52147, 53128);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CommandMetadata GetRestrictedOutDefault()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1248, 53140, 54067);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 53469, 53557);

                ParameterMetadata
                inputParameter = f_1248_53504_53556("InputObject", typeof(object))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 53571, 53907);

                f_1248_53571_53906(f_1248_53571_53599(inputParameter), ParameterAttribute.AllParameterSets, f_1248_53676_53905(int.MinValue, ParameterSetMetadata.ParameterFlags.ValueFromPipeline | ParameterSetMetadata.ParameterFlags.Mandatory, null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 53942, 54056);

                return f_1248_53949_54055("Out-Default", null, "https://go.microsoft.com/fwlink/?LinkID=113362", inputParameter);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1248, 53140, 54067);

                System.Management.Automation.ParameterMetadata
                f_1248_53504_53556(string
                name, System.Type
                parameterType)
                {
                    var return_v = new System.Management.Automation.ParameterMetadata(name, parameterType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 53504, 53556);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                f_1248_53571_53599(System.Management.Automation.ParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 53571, 53599);
                    return return_v;
                }


                System.Management.Automation.ParameterSetMetadata
                f_1248_53676_53905(int
                position, System.Management.Automation.ParameterSetMetadata.ParameterFlags
                flags, string
                helpMessage)
                {
                    var return_v = new System.Management.Automation.ParameterSetMetadata(position, flags, helpMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 53676, 53905);
                    return return_v;
                }


                int
                f_1248_53571_53906(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterSetMetadata>
                this_param, string
                key, System.Management.Automation.ParameterSetMetadata
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 53571, 53906);
                    return 0;
                }


                System.Management.Automation.CommandMetadata
                f_1248_53949_54055(string
                cmdletName, string
                defaultParameterSet, string
                helpUri, params System.Management.Automation.ParameterMetadata[]
                parameters)
                {
                    var return_v = GetRestrictedCmdlet(cmdletName, defaultParameterSet, helpUri, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 53949, 54055);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 53140, 54067);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 53140, 54067);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CommandMetadata GetRestrictedExitPSSession()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1248, 54079, 54456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 54317, 54419);

                return f_1248_54324_54418("Exit-PSSession", null, "https://go.microsoft.com/fwlink/?LinkID=2096787");
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1248, 54079, 54456);

                System.Management.Automation.CommandMetadata
                f_1248_54324_54418(string
                cmdletName, string
                defaultParameterSet, string
                helpUri, params System.Management.Automation.ParameterMetadata[]
                parameters)
                {
                    var return_v = GetRestrictedCmdlet(cmdletName, defaultParameterSet, helpUri, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 54324, 54418);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 54079, 54456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 54079, 54456);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Dictionary<string, CommandMetadata> GetRestrictedCommands(SessionCapabilities sessionCapabilities)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1248, 55708, 56582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 55845, 55916);

                List<CommandMetadata>
                restrictedCommands = f_1248_55888_55915()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 56019, 56225) || true) && (SessionCapabilities.RemoteServer == (sessionCapabilities & SessionCapabilities.RemoteServer))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 56019, 56225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 56149, 56210);

                    f_1248_56149_56209(restrictedCommands, f_1248_56177_56208());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 56019, 56225);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 56241, 56360);

                Dictionary<string, CommandMetadata>
                result = f_1248_56286_56359(f_1248_56326_56358())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 56374, 56541);
                    foreach (CommandMetadata restrictedCommand in f_1248_56420_56438_I(restrictedCommands))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1248, 56374, 56541);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 56472, 56526);

                        f_1248_56472_56525(result, f_1248_56483_56505(restrictedCommand), restrictedCommand);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1248, 56374, 56541);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1248, 1, 168);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1248, 1, 168);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 56557, 56571);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1248, 55708, 56582);

                System.Collections.Generic.List<System.Management.Automation.CommandMetadata>
                f_1248_55888_55915()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.CommandMetadata>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 55888, 55915);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandMetadata>
                f_1248_56177_56208()
                {
                    var return_v = GetRestrictedRemotingCommands();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 56177, 56208);
                    return return_v;
                }


                int
                f_1248_56149_56209(System.Collections.Generic.List<System.Management.Automation.CommandMetadata>
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.CommandMetadata>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.CommandMetadata>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 56149, 56209);
                    return 0;
                }


                System.StringComparer
                f_1248_56326_56358()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 56326, 56358);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandMetadata>
                f_1248_56286_56359(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandMetadata>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 56286, 56359);
                    return return_v;
                }


                string
                f_1248_56483_56505(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 56483, 56505);
                    return return_v;
                }


                int
                f_1248_56472_56525(System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandMetadata>
                this_param, string
                key, System.Management.Automation.CommandMetadata
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 56472, 56525);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.CommandMetadata>
                f_1248_56420_56438_I(System.Collections.Generic.List<System.Management.Automation.CommandMetadata>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 56420, 56438);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 55708, 56582);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 55708, 56582);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Collection<CommandMetadata> GetRestrictedRemotingCommands()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1248, 56594, 57591);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 56693, 57540);

                Collection<CommandMetadata>
                remotingCommands = new Collection<CommandMetadata>
                                                                           {
DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1248_56898_56923(),1248,56740,57539),f_1248_56989_57017(),f_1248_57083_57110(),f_1248_57176_57198(),f_1248_57264_57292(),f_1248_57358_57386(),f_1248_57452_57477()                                                           }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 57556, 57580);

                return remotingCommands;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1248, 56594, 57591);

                System.Management.Automation.CommandMetadata
                f_1248_56898_56923()
                {
                    var return_v = GetRestrictedGetCommand();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 56898, 56923);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1248_56989_57017()
                {
                    var return_v = GetRestrictedGetFormatData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 56989, 57017);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1248_57083_57110()
                {
                    var return_v = GetRestrictedSelectObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 57083, 57110);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1248_57176_57198()
                {
                    var return_v = GetRestrictedGetHelp();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 57176, 57198);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1248_57264_57292()
                {
                    var return_v = GetRestrictedMeasureObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 57264, 57292);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1248_57358_57386()
                {
                    var return_v = GetRestrictedExitPSSession();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 57358, 57386);
                    return return_v;
                }


                System.Management.Automation.CommandMetadata
                f_1248_57452_57477()
                {
                    var return_v = GetRestrictedOutDefault();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 57452, 57477);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1248, 56594, 57591);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 56594, 57591);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static System.Collections.Concurrent.ConcurrentDictionary<string, CommandMetadata> s_commandMetadataCache;

        static CommandMetadata()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1248, 1626, 72676);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 43471, 43557);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1248, 72495, 72646);
            s_commandMetadataCache = f_1248_72533_72646(f_1248_72613_72645());
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1248, 1626, 72676);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1248, 1626, 72676);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1248, 1626, 72676);

        int
        f_1248_2495_2531(System.Management.Automation.CommandMetadata
        this_param, string
        name, string
        fullyQualifiedName, System.Type
        commandType, bool
        shouldGenerateCommonParameters)
        {
            this_param.Init(name, fullyQualifiedName, commandType, shouldGenerateCommonParameters);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 2495, 2531);
            return 0;
        }


        static System.Management.Automation.CommandInfo
        f_1248_3206_3217_C(System.Management.Automation.CommandInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1248, 3138, 3247);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1248_4162_4215(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 4162, 4215);
            return return_v;
        }


        System.Management.Automation.CommandInfo
        f_1248_4324_4364(System.Management.Automation.AliasInfo
        this_param)
        {
            var return_v = this_param.ResolvedCommand;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 4324, 4364);
            return return_v;
        }


        System.Management.Automation.PSNotSupportedException
        f_1248_4454_4494()
        {
            var return_v = PSTraceSource.NewNotSupportedException();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 4454, 4494);
            return return_v;
        }


        string
        f_1248_4752_4768(System.Management.Automation.CommandInfo
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 4752, 4768);
            return return_v;
        }


        string
        f_1248_4770_4789(System.Management.Automation.CmdletInfo
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 4770, 4789);
            return return_v;
        }


        System.Type
        f_1248_4791_4818(System.Management.Automation.CmdletInfo
        this_param)
        {
            var return_v = this_param.ImplementingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 4791, 4818);
            return return_v;
        }


        int
        f_1248_4747_4851(System.Management.Automation.CommandMetadata
        this_param, string
        name, string
        fullyQualifiedName, System.Type
        commandType, bool
        shouldGenerateCommonParameters)
        {
            this_param.Init(name, fullyQualifiedName, commandType, shouldGenerateCommonParameters);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 4747, 4851);
            return 0;
        }


        System.Management.Automation.ScriptBlock
        f_1248_5074_5096(System.Management.Automation.ExternalScriptInfo
        this_param)
        {
            var return_v = this_param.ScriptBlock;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 5074, 5096);
            return return_v;
        }


        string
        f_1248_5098_5113(System.Management.Automation.ExternalScriptInfo
        this_param)
        {
            var return_v = this_param.Path;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 5098, 5113);
            return return_v;
        }


        int
        f_1248_5069_5146(System.Management.Automation.CommandMetadata
        this_param, System.Management.Automation.ScriptBlock
        scriptBlock, string
        name, bool
        shouldGenerateCommonParameters)
        {
            this_param.Init(scriptBlock, name, shouldGenerateCommonParameters);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 5069, 5146);
            return 0;
        }


        System.Management.Automation.ScriptBlock
        f_1248_5340_5360(System.Management.Automation.FunctionInfo
        this_param)
        {
            var return_v = this_param.ScriptBlock;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 5340, 5360);
            return return_v;
        }


        string
        f_1248_5362_5375(System.Management.Automation.FunctionInfo
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 5362, 5375);
            return return_v;
        }


        int
        f_1248_5335_5408(System.Management.Automation.CommandMetadata
        this_param, System.Management.Automation.ScriptBlock
        scriptBlock, string
        name, bool
        shouldGenerateCommonParameters)
        {
            this_param.Init(scriptBlock, name, shouldGenerateCommonParameters);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 5335, 5408);
            return 0;
        }


        System.Management.Automation.CommandTypes
        f_1248_5449_5472(System.Management.Automation.CommandInfo
        this_param)
        {
            var return_v = this_param.CommandType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 5449, 5472);
            return return_v;
        }


        System.Management.Automation.PSNotSupportedException
        f_1248_5545_5585()
        {
            var return_v = PSTraceSource.NewNotSupportedException();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 5545, 5585);
            return return_v;
        }


        string?
        f_1248_5887_5912(string
        path)
        {
            var return_v = IO.Path.GetFileName(path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 5887, 5912);
            return return_v;
        }


        System.Management.Automation.ExternalScriptInfo
        f_1248_5959_5999(string
        name, string
        path)
        {
            var return_v = new System.Management.Automation.ExternalScriptInfo(name, path);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 5959, 5999);
            return return_v;
        }


        System.Management.Automation.ScriptBlock
        f_1248_6021_6043(System.Management.Automation.ExternalScriptInfo
        this_param)
        {
            var return_v = this_param.ScriptBlock;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 6021, 6043);
            return return_v;
        }


        int
        f_1248_6016_6057(System.Management.Automation.CommandMetadata
        this_param, System.Management.Automation.ScriptBlock
        scriptBlock, string
        name, bool
        shouldGenerateCommonParameters)
        {
            this_param.Init(scriptBlock, name, shouldGenerateCommonParameters);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 6016, 6057);
            return 0;
        }


        System.Management.Automation.PSArgumentNullException
        f_1248_6567_6614(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 6567, 6614);
            return return_v;
        }


        string
        f_1248_6653_6663(System.Management.Automation.CommandMetadata
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 6653, 6663);
            return return_v;
        }


        System.Management.Automation.ConfirmImpact
        f_1248_6694_6713(System.Management.Automation.CommandMetadata
        this_param)
        {
            var return_v = this_param.ConfirmImpact;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 6694, 6713);
            return return_v;
        }


        bool
        f_1248_6976_7003(System.Management.Automation.CommandMetadata
        this_param)
        {
            var return_v = this_param.SupportsShouldProcess;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 6976, 7003);
            return return_v;
        }


        bool
        f_1248_7035_7055(System.Management.Automation.CommandMetadata
        this_param)
        {
            var return_v = this_param.SupportsPaging;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 7035, 7055);
            return return_v;
        }


        bool
        f_1248_7093_7119(System.Management.Automation.CommandMetadata
        this_param)
        {
            var return_v = this_param.SupportsTransactions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 7093, 7119);
            return return_v;
        }


        System.Type
        f_1248_7153_7170(System.Management.Automation.CommandMetadata
        this_param)
        {
            var return_v = this_param.CommandType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 7153, 7170);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
        f_1248_7417_7433(System.Management.Automation.CommandMetadata
        this_param)
        {
            var return_v = this_param.Parameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 7417, 7433);
            return return_v;
        }


        int
        f_1248_7417_7439(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 7417, 7439);
            return return_v;
        }


        System.StringComparer
        f_1248_7441_7473()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 7441, 7473);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
        f_1248_7375_7474(int
        capacity, System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>(capacity, (System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 7375, 7474);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
        f_1248_7575_7591(System.Management.Automation.CommandMetadata
        this_param)
        {
            var return_v = this_param.Parameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 7575, 7591);
            return return_v;
        }


        System.Management.Automation.ParameterMetadata
        f_1248_7652_7686(System.Management.Automation.ParameterMetadata
        other)
        {
            var return_v = new System.Management.Automation.ParameterMetadata(other);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 7652, 7686);
            return return_v;
        }


        int
        f_1248_7625_7687(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
        this_param, string
        key, System.Management.Automation.ParameterMetadata
        value)
        {
            this_param.Add(key, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 7625, 7687);
            return 0;
        }


        System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
        f_1248_7575_7591_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 7575, 7591);
            return return_v;
        }


        int
        f_1248_8037_8065(System.Collections.ObjectModel.Collection<System.Attribute>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 8037, 8065);
            return return_v;
        }


        System.Collections.Generic.List<System.Attribute>
        f_1248_8017_8066(int
        capacity)
        {
            var return_v = new System.Collections.Generic.List<System.Attribute>(capacity);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 8017, 8066);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<System.Attribute>
        f_1248_7991_8067(System.Collections.Generic.List<System.Attribute>
        list)
        {
            var return_v = new System.Collections.ObjectModel.Collection<System.Attribute>((System.Collections.Generic.IList<System.Attribute>)list);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 7991, 8067);
            return return_v;
        }


        int
        f_1248_8182_8213(System.Collections.ObjectModel.Collection<System.Attribute>
        this_param, System.Attribute
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 8182, 8213);
            return 0;
        }


        System.Collections.ObjectModel.Collection<System.Attribute>
        f_1248_8118_8140_I(System.Collections.ObjectModel.Collection<System.Attribute>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 8118, 8140);
            return return_v;
        }


        bool
        f_1248_15152_15185(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 15152, 15185);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1248_15225_15274(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 15225, 15274);
            return return_v;
        }


        System.Management.Automation.InternalParameterMetadata
        f_1248_15487_15544(System.Type
        type, System.Management.Automation.ExecutionContext
        context, bool
        processingDynamicParameters)
        {
            var return_v = InternalParameterMetadata.Get(type, context, processingDynamicParameters);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 15487, 15544);
            return return_v;
        }


        int
        f_1248_15563_15603(System.Management.Automation.CommandMetadata
        this_param)
        {
            this_param.ConstructCmdletMetadataUsingReflection();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 15563, 15603);
            return 0;
        }


        System.Management.Automation.MergedCommandParameterMetadata
        f_1248_15656_15712(System.Management.Automation.CommandMetadata
        this_param, System.Management.Automation.ExecutionContext
        context, System.Management.Automation.InternalParameterMetadata
        parameterMetadata, bool
        shouldGenerateCommonParameters)
        {
            var return_v = this_param.MergeParameterMetadata(context, parameterMetadata, shouldGenerateCommonParameters);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 15656, 15712);
            return return_v;
        }


        uint
        f_1248_15758_15855(System.Management.Automation.MergedCommandParameterMetadata
        this_param, string
        defaultParameterSetName)
        {
            var return_v = this_param.GenerateParameterSetMappingFromMetadata(defaultParameterSetName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 15758, 15855);
            return return_v;
        }


        int
        f_1248_15874_15920(System.Management.Automation.MergedCommandParameterMetadata
        this_param)
        {
            this_param.MakeReadOnly();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 15874, 15920);
            return 0;
        }


        System.Management.Automation.PSArgumentException
        f_1248_17440_17489(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 17440, 17489);
            return return_v;
        }


        System.Management.Automation.CmdletBindingAttribute
        f_1248_17569_17603(System.Management.Automation.ScriptBlock
        this_param)
        {
            var return_v = this_param.CmdletBindingAttribute;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 17569, 17603);
            return return_v;
        }


        int
        f_1248_17688_17734(System.Management.Automation.CommandMetadata
        this_param, System.Management.Automation.CmdletBindingAttribute
        attribute)
        {
            this_param.ProcessCmdletAttribute((System.Management.Automation.CmdletCommonMetadataAttribute)attribute);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 17688, 17734);
            return 0;
        }


        System.ObsoleteAttribute
        f_1248_17875_17904(System.Management.Automation.ScriptBlock
        this_param)
        {
            var return_v = this_param.ObsoleteAttribute;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 17875, 17904);
            return return_v;
        }


        bool
        f_1248_18014_18046(System.Management.Automation.ScriptBlock
        this_param)
        {
            var return_v = this_param.HasDynamicParameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 18014, 18046);
            return return_v;
        }


        System.Management.Automation.RuntimeDefinedParameterDictionary
        f_1248_18223_18259(System.Management.Automation.ScriptBlock
        this_param)
        {
            var return_v = this_param.RuntimeDefinedParameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 18223, 18259);
            return return_v;
        }


        bool
        f_1248_18357_18386(System.Management.Automation.ScriptBlock
        this_param)
        {
            var return_v = this_param.UsesCmdletBinding;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 18357, 18386);
            return return_v;
        }


        System.Management.Automation.InternalParameterMetadata
        f_1248_18193_18387(System.Management.Automation.RuntimeDefinedParameterDictionary
        runtimeDefinedParameters, bool
        processingDynamicParameters, bool
        checkNames)
        {
            var return_v = InternalParameterMetadata.Get(runtimeDefinedParameters, processingDynamicParameters, checkNames);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 18193, 18387);
            return return_v;
        }


        bool
        f_1248_18487_18516(System.Management.Automation.ScriptBlock
        this_param)
        {
            var return_v = this_param.UsesCmdletBinding;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 18487, 18516);
            return return_v;
        }


        System.Management.Automation.MergedCommandParameterMetadata
        f_1248_18436_18517(System.Management.Automation.CommandMetadata
        this_param, System.Management.Automation.ExecutionContext
        context, System.Management.Automation.InternalParameterMetadata
        parameterMetadata, bool
        shouldGenerateCommonParameters)
        {
            var return_v = this_param.MergeParameterMetadata(context, parameterMetadata, shouldGenerateCommonParameters);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 18436, 18517);
            return return_v;
        }


        uint
        f_1248_18559_18656(System.Management.Automation.MergedCommandParameterMetadata
        this_param, string
        defaultParameterSetName)
        {
            var return_v = this_param.GenerateParameterSetMappingFromMetadata(defaultParameterSetName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 18559, 18656);
            return return_v;
        }


        int
        f_1248_18671_18717(System.Management.Automation.MergedCommandParameterMetadata
        this_param)
        {
            this_param.MakeReadOnly();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 18671, 18717);
            return 0;
        }


        System.Collections.ObjectModel.Collection<System.Attribute>
        f_1248_26403_26430()
        {
            var return_v = new System.Collections.ObjectModel.Collection<System.Attribute>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 26403, 26430);
            return return_v;
        }


        static System.StringComparer
        f_1248_72613_72645()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1248, 72613, 72645);
            return return_v;
        }


        static System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandMetadata>
        f_1248_72533_72646(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<string, System.Management.Automation.CommandMetadata>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1248, 72533, 72646);
            return return_v;
        }

    }
}
