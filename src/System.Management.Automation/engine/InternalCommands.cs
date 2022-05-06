// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Management.Automation.PSTasks;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using CommonParamSet = System.Management.Automation.Internal.CommonParameters;
using Dbg = System.Management.Automation.Diagnostics;

namespace Microsoft.PowerShell.Commands
{

    internal struct DynamicPropertyGetter
    {

        private CallSite<Func<CallSite, object, object>> _getValueDynamicSite;

        private string _lastUsedPropertyName;

        public object GetValue(PSObject inputObject, string propertyName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 1115, 2115);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 1205, 1324);

                f_1283_1205_1323(!f_1283_1217_1273(propertyName), "propertyName should be pre-resolved by caller");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 1562, 2011) || true) && (!f_1283_1567_1645(propertyName, _lastUsedPropertyName, StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 1562, 2011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 1679, 1716);

                    _lastUsedPropertyName = propertyName;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 1734, 1996);

                    _getValueDynamicSite = f_1283_1757_1995(f_1283_1831_1994(propertyName, null, @static: false));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 1562, 2011);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 2027, 2104);

                // LAFHIS
                //return f_1283_2034_2103(_getValueDynamicSite.Target, _getValueDynamicSite, inputObject);
                var temp = _getValueDynamicSite.Target.Invoke(_getValueDynamicSite, inputObject);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 2034, 2103);
                return temp;

                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 1115, 2115);

                bool
                f_1283_1217_1273(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 1217, 1273);
                    return return_v;
                }


                int
                f_1283_1205_1323(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 1205, 1323);
                    return 0;
                }


                bool
                f_1283_1567_1645(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 1567, 1645);
                    return return_v;
                }


                System.Management.Automation.Language.PSGetMemberBinder
                f_1283_1831_1994(string
                memberName, System.Type
                classScope, bool
                @static)
                {
                    var return_v = PSGetMemberBinder.Get(memberName, classScope: classScope, @static: @static);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 1831, 1994);
                    return return_v;
                }


                System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>>
                f_1283_1757_1995(System.Management.Automation.Language.PSGetMemberBinder
                binder)
                {
                    var return_v = CallSite<Func<CallSite, object, object>>.Create((System.Runtime.CompilerServices.CallSiteBinder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 1757, 1995);
                    return return_v;
                }


                object
                f_1283_2034_2103(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object>>
                arg1, System.Management.Automation.PSObject
                arg2)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 2034, 2103);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 1115, 2115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 1115, 2115);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static DynamicPropertyGetter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1283, 852, 2122);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1283, 852, 2122);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 852, 2122);
        }
    }
    [Cmdlet("ForEach", "Object", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Low,
            DefaultParameterSetName = ForEachObjectCommand.ScriptBlockSet, HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096867",
            RemotingCapability = RemotingCapability.None)]
    public sealed class ForEachObjectCommand : PSCmdlet, IDisposable
    {
        private const string
        ParallelParameterSet = "ParallelParameterSet"
        ;

        private const string
        ScriptBlockSet = "ScriptBlockSet"
        ;

        private const string
        PropertyAndMethodSet = "PropertyAndMethodSet"
        ;

        [Parameter(ValueFromPipeline = true, ParameterSetName = ForEachObjectCommand.ScriptBlockSet)]
        [Parameter(ValueFromPipeline = true, ParameterSetName = ForEachObjectCommand.PropertyAndMethodSet)]
        [Parameter(ValueFromPipeline = true, ParameterSetName = ForEachObjectCommand.ParallelParameterSet)]
        public PSObject InputObject
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 3528, 3557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 3534, 3555);

                    _inputObject = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 3528, 3557);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 3155, 3612);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 3155, 3612);
                }
            }
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 3573, 3601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 3579, 3599);

                    return _inputObject;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 3573, 3601);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 3155, 3612);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 3155, 3612);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private PSObject _inputObject;

        private List<ScriptBlock> _scripts;

        [Parameter(ParameterSetName = ForEachObjectCommand.ScriptBlockSet)]
        public ScriptBlock Begin
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 4064, 4127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 4100, 4112);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 4064, 4127);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 3938, 4231);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 3938, 4231);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 4143, 4220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 4179, 4205);

                    f_1283_4179_4204(_scripts, 0, value);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 4143, 4220);

                    int
                    f_1283_4179_4204(System.Collections.Generic.List<System.Management.Automation.ScriptBlock>
                    this_param, int
                    index, System.Management.Automation.ScriptBlock
                    item)
                    {
                        this_param.Insert(index, item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 4179, 4204);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 3938, 4231);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 3938, 4231);
                }
            }
        }

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = ForEachObjectCommand.ScriptBlockSet)]
        [AllowNull]
        [AllowEmptyCollection]
        public ScriptBlock[] Process
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 4558, 4621);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 4594, 4606);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 4558, 4621);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 4343, 4903);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 4343, 4903);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 4637, 4892);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 4673, 4877) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 4673, 4877);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 4732, 4751);

                        f_1283_4732_4750(_scripts, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 4673, 4877);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 4673, 4877);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 4833, 4858);

                        f_1283_4833_4857(_scripts, value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 4673, 4877);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 4637, 4892);

                    int
                    f_1283_4732_4750(System.Collections.Generic.List<System.Management.Automation.ScriptBlock>
                    this_param, System.Management.Automation.ScriptBlock
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 4732, 4750);
                        return 0;
                    }


                    int
                    f_1283_4833_4857(System.Collections.Generic.List<System.Management.Automation.ScriptBlock>
                    this_param, System.Management.Automation.ScriptBlock[]
                    collection)
                    {
                        this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.ScriptBlock>)collection);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 4833, 4857);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 4343, 4903);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 4343, 4903);
                }
            }
        }

        private ScriptBlock _endScript;

        private bool _setEndScript;

        [Parameter(ParameterSetName = ForEachObjectCommand.ScriptBlockSet)]
        public ScriptBlock End
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 5242, 5311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 5278, 5296);

                    return _endScript;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 5242, 5311);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 5118, 5447);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 5118, 5447);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 5327, 5436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 5363, 5382);

                    _endScript = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 5400, 5421);

                    _setEndScript = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 5327, 5436);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 5118, 5447);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 5118, 5447);
                }
            }
        }

        [Parameter(ParameterSetName = ForEachObjectCommand.ScriptBlockSet, ValueFromRemainingArguments = true)]
        [AllowNull]
        [AllowEmptyCollection]
        public ScriptBlock[] RemainingScripts
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 5798, 5861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 5834, 5846);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 5798, 5861);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 5570, 6143);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 5570, 6143);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 5877, 6132);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 5913, 6117) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 5913, 6117);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 5972, 5991);

                        f_1283_5972_5990(_scripts, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 5913, 6117);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 5913, 6117);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 6073, 6098);

                        f_1283_6073_6097(_scripts, value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 5913, 6117);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 5877, 6132);

                    int
                    f_1283_5972_5990(System.Collections.Generic.List<System.Management.Automation.ScriptBlock>
                    this_param, System.Management.Automation.ScriptBlock
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 5972, 5990);
                        return 0;
                    }


                    int
                    f_1283_6073_6097(System.Collections.Generic.List<System.Management.Automation.ScriptBlock>
                    this_param, System.Management.Automation.ScriptBlock[]
                    collection)
                    {
                        this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.ScriptBlock>)collection);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 6073, 6097);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 5570, 6143);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 5570, 6143);
                }
            }
        }

        private int _start, _end;

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = ForEachObjectCommand.PropertyAndMethodSet)]
        [ValidateTrustedData]
        [ValidateNotNullOrEmpty]
        public string MemberName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 6600, 6680);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 6636, 6665);

                    return _propertyOrMethodName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 6600, 6680);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 6371, 6788);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 6371, 6788);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 6696, 6777);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 6732, 6762);

                    _propertyOrMethodName = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 6696, 6777);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 6371, 6788);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 6371, 6788);
                }
            }
        }

        private string _propertyOrMethodName;

        private string _targetString;

        private DynamicPropertyGetter _propGetter;

        [Parameter(ParameterSetName = ForEachObjectCommand.PropertyAndMethodSet, ValueFromRemainingArguments = true)]
        [ValidateTrustedData]
        [Alias("Args")]
        public object[] ArgumentList
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 7273, 7300);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 7279, 7298);

                    _arguments = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 7273, 7300);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 7045, 7353);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 7045, 7353);
                }
            }
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 7316, 7342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 7322, 7340);

                    return _arguments;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 7316, 7342);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 7045, 7353);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 7045, 7353);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private object[] _arguments;

        [Parameter(Mandatory = true, ParameterSetName = ForEachObjectCommand.ParallelParameterSet)]
        public ScriptBlock Parallel { get; set; }

        [Parameter(ParameterSetName = ForEachObjectCommand.ParallelParameterSet)]
        [ValidateRange(1, Int32.MaxValue)]
        public int ThrottleLimit { get; set; }

        [Parameter(ParameterSetName = ForEachObjectCommand.ParallelParameterSet)]
        [ValidateRange(0, (Int32.MaxValue / 1000))]
        public int TimeoutSeconds { get; set; }

        [Parameter(ParameterSetName = ForEachObjectCommand.ParallelParameterSet)]
        public SwitchParameter AsJob { get; set; }

        protected override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 9331, 9746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 9397, 9735);

                switch (f_1283_9405_9421())
                {

                    case ForEachObjectCommand.ScriptBlockSet:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 9397, 9735);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 9518, 9548);

                        f_1283_9518_9547(this);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 9570, 9576);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 9397, 9735);

                    case ForEachObjectCommand.ParallelParameterSet:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 9397, 9735);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 9665, 9692);

                        f_1283_9665_9691(this);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 9714, 9720);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 9397, 9735);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 9331, 9746);

                string
                f_1283_9405_9421()
                {
                    var return_v = ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 9405, 9421);
                    return return_v;
                }


                int
                f_1283_9518_9547(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param)
                {
                    this_param.InitScriptBlockParameterSet();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 9518, 9547);
                    return 0;
                }


                int
                f_1283_9665_9691(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param)
                {
                    this_param.InitParallelParameterSet();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 9665, 9691);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 9331, 9746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 9331, 9746);
            }
        }

        protected override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 10192, 10767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 10256, 10756);

                switch (f_1283_10264_10280())
                {

                    case ForEachObjectCommand.ScriptBlockSet:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 10256, 10756);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 10377, 10410);

                        f_1283_10377_10409(this);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 10432, 10438);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 10256, 10756);

                    case ForEachObjectCommand.PropertyAndMethodSet:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 10256, 10756);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 10527, 10566);

                        f_1283_10527_10565(this);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 10588, 10594);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 10256, 10756);

                    case ForEachObjectCommand.ParallelParameterSet:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 10256, 10756);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 10683, 10713);

                        f_1283_10683_10712(this);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 10735, 10741);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 10256, 10756);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 10192, 10767);

                string
                f_1283_10264_10280()
                {
                    var return_v = ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 10264, 10280);
                    return return_v;
                }


                int
                f_1283_10377_10409(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param)
                {
                    this_param.ProcessScriptBlockParameterSet();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 10377, 10409);
                    return 0;
                }


                int
                f_1283_10527_10565(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param)
                {
                    this_param.ProcessPropertyAndMethodParameterSet();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 10527, 10565);
                    return 0;
                }


                int
                f_1283_10683_10712(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param)
                {
                    this_param.ProcessParallelParameterSet();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 10683, 10712);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 10192, 10767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 10192, 10767);
            }
        }

        protected override void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 11151, 11556);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 11215, 11545);

                switch (f_1283_11223_11239())
                {

                    case ForEachObjectCommand.ScriptBlockSet:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 11215, 11545);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 11336, 11359);

                        f_1283_11336_11358(this);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 11381, 11387);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 11215, 11545);

                    case ForEachObjectCommand.ParallelParameterSet:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 11215, 11545);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 11476, 11502);

                        f_1283_11476_11501(this);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 11524, 11530);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 11215, 11545);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 11151, 11556);

                string
                f_1283_11223_11239()
                {
                    var return_v = ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 11223, 11239);
                    return return_v;
                }


                int
                f_1283_11336_11358(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param)
                {
                    this_param.EndBlockParameterSet();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 11336, 11358);
                    return 0;
                }


                int
                f_1283_11476_11501(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param)
                {
                    this_param.EndParallelParameterSet();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 11476, 11501);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 11151, 11556);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 11151, 11556);
            }
        }

        protected override void StopProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 11657, 11928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 11722, 11917);

                switch (f_1283_11730_11746())
                {

                    case ForEachObjectCommand.ParallelParameterSet:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 11722, 11917);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 11849, 11874);

                        f_1283_11849_11873(this);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 11896, 11902);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 11722, 11917);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 11657, 11928);

                string
                f_1283_11730_11746()
                {
                    var return_v = ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 11730, 11746);
                    return return_v;
                }


                int
                f_1283_11849_11873(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param)
                {
                    this_param.StopParallelProcessing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 11849, 11873);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 11657, 11928);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 11657, 11928);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 12078, 12342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 12186, 12208);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_taskTimer, 1283, 12186, 12207)?.Dispose(), 1283, 12197, 12207);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 12222, 12255);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_taskDataStreamWriter, 1283, 12222, 12254)?.Dispose(), 1283, 12244, 12254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 12269, 12290);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_taskPool, 1283, 12269, 12289)?.Dispose(), 1283, 12279, 12289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 12304, 12331);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_taskCollection, 1283, 12304, 12330)?.Dispose(), 1283, 12320, 12330);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 12078, 12342);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 12078, 12342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 12078, 12342);
            }
        }

        private PSTaskPool _taskPool;

        private PSTaskDataStreamWriter _taskDataStreamWriter;

        private Dictionary<string, object> _usingValuesMap;

        private Timer _taskTimer;

        private PSTaskJob _taskJob;

        private PSDataCollection<System.Management.Automation.PSTasks.PSTask> _taskCollection;

        private Exception _taskCollectionException;

        private string _currentLocationPath;

        private void InitParallelParameterSet()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 12870, 19411);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 13111, 13892) || true) && (f_1283_13115_13191(f_1283_13115_13143(f_1283_13115_13127()), nameof(CommonParamSet.ErrorAction)) || (DynAbs.Tracing.TraceSender.Expression_False(1283, 13115, 13290) || f_1283_13212_13290(f_1283_13212_13240(f_1283_13212_13224()), nameof(CommonParamSet.WarningAction))) || (DynAbs.Tracing.TraceSender.Expression_False(1283, 13115, 13393) || f_1283_13311_13393(f_1283_13311_13339(f_1283_13311_13323()), nameof(CommonParamSet.InformationAction))) || (DynAbs.Tracing.TraceSender.Expression_False(1283, 13115, 13495) || f_1283_13414_13495(f_1283_13414_13442(f_1283_13414_13426()), nameof(CommonParamSet.PipelineVariable))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 13111, 13892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 13529, 13877);

                    f_1283_13529_13876(this, f_1283_13577_13875(f_1283_13623_13711(f_1283_13651_13710()), "ParallelCommonParametersNotSupported", ErrorCategory.NotImplemented, this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 13111, 13892);
                }

                // Get the current working directory location, if available.
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 14018, 14084);

                    _currentLocationPath = f_1283_14041_14083(f_1283_14041_14078(f_1283_14041_14062(f_1283_14041_14053())));
                }
                catch (PSInvalidOperationException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1283, 14113, 14178);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1283, 14113, 14178);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 14194, 14290);

                bool
                allowUsingExpression = f_1283_14222_14260(f_1283_14222_14247(f_1283_14222_14234(this))) != PSLanguageMode.NoLanguage
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 14304, 14567);

                _usingValuesMap = f_1283_14322_14566(f_1283_14416_14424(), allowUsingExpression, f_1283_14514_14526(this), null);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 14844, 15372);
                    foreach (object item in f_1283_14868_14890_I(f_1283_14868_14890(_usingValuesMap)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 14844, 15372);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 14924, 15357) || true) && (item is ScriptBlock)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 14924, 15357);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 14989, 15338);

                            f_1283_14989_15337(this, f_1283_15037_15336(f_1283_15083_15171(f_1283_15107_15170()), "ParallelUsingVariableCannotBeScriptBlock", ErrorCategory.InvalidType, this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 14924, 15357);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 14844, 15372);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1283, 1, 529);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1283, 1, 529);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 15388, 16117) || true) && (f_1283_15392_15397())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 15388, 16117);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 15486, 15951) || true) && (f_1283_15490_15554(f_1283_15490_15518(f_1283_15490_15502()), nameof(TimeoutSeconds)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 15486, 15951);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 15596, 15932);

                        f_1283_15596_15931(this, f_1283_15644_15930(f_1283_15690_15769(f_1283_15714_15768()), "ParallelCannotUseTimeoutWithJob", ErrorCategory.InvalidOperation, this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 15486, 15951);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 15971, 16075);

                    _taskJob = f_1283_15982_16074(f_1283_16018_16037(f_1283_16018_16026()), f_1283_16060_16073());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 16095, 16102);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 15388, 16117);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 16203, 16289);

                _taskCollection = f_1283_16221_16288();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 16303, 16360);

                _taskDataStreamWriter = f_1283_16327_16359(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 16374, 16416);

                _taskPool = f_1283_16386_16415(f_1283_16401_16414());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 16430, 16552);

                _taskPool.PoolComplete += (sender, args) =>
                            {
                                _taskDataStreamWriter.Close();
                            };

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 16619, 16941) || true) && (f_1283_16623_16637() != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 16619, 16941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 16676, 16926);

                    _taskTimer = f_1283_16689_16925(callback: (_) => { _taskCollection.Complete(); _taskPool.StopAll(); }, state: null, dueTime: f_1283_16856_16870() * 1000, period: Timeout.Infinite);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 16619, 16941);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 16998, 19400);

                f_1283_16998_19399((_) =>
                                {
                    // As piped input are converted to PSTasks and added to the _taskCollection,
                    // transfer the task to the _taskPool on this dedicated thread.
                    // The _taskPool will block this thread when it is full, and allow more tasks to
                    // be added only when a currently running task completes and makes space in the pool.
                    // Continue adding any tasks appearing in _taskCollection until the collection is closed.
                    while (true)
                                    {
                        // This handle will unblock the thread when a new task is available or the _taskCollection
                        // is closed.
                        _taskCollection.WaitHandle.WaitOne();

                        // Task collection open state is volatile.
                        // Record current task collection open state here, to be checked after processing.
                        bool isOpen = _taskCollection.IsOpen;

                                        try
                                        {
                            // Read all tasks in the collection.
                            foreach (var task in _taskCollection.ReadAll())
                                            {
                                // This _taskPool method will block if the pool is full and will unblock
                                // only after a task completes making more space.
                                _taskPool.Add(task);
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            _taskCollection.Complete();
                                            _taskCollectionException = ex;
                                            _taskDataStreamWriter.Close();

                                            break;
                                        }

                        // Loop is exited only when task collection is closed and all task
                        // collection tasks are processed.
                        if (!isOpen)
                                        {
                                            break;
                                        }
                                    }

                    // We are done adding tasks and can close the task pool.
                    _taskPool.Close();
                                });
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 12870, 19411);

                System.Management.Automation.InvocationInfo
                f_1283_13115_13127()
                {
                    var return_v = MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 13115, 13127);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>
                f_1283_13115_13143(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 13115, 13143);
                    return return_v;
                }


                bool
                f_1283_13115_13191(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 13115, 13191);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1283_13212_13224()
                {
                    var return_v = MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 13212, 13224);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>
                f_1283_13212_13240(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 13212, 13240);
                    return return_v;
                }


                bool
                f_1283_13212_13290(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 13212, 13290);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1283_13311_13323()
                {
                    var return_v = MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 13311, 13323);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>
                f_1283_13311_13339(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 13311, 13339);
                    return return_v;
                }


                bool
                f_1283_13311_13393(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 13311, 13393);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1283_13414_13426()
                {
                    var return_v = MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 13414, 13426);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>
                f_1283_13414_13442(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 13414, 13442);
                    return return_v;
                }


                bool
                f_1283_13414_13495(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 13414, 13495);
                    return return_v;
                }


                string
                f_1283_13651_13710()
                {
                    var return_v = InternalCommandStrings.ParallelCommonParametersNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 13651, 13710);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1283_13623_13711(string
                message)
                {
                    var return_v = new System.Management.Automation.PSNotSupportedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 13623, 13711);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_13577_13875(System.Management.Automation.PSNotSupportedException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, Microsoft.PowerShell.Commands.ForEachObjectCommand
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 13577, 13875);
                    return return_v;
                }


                int
                f_1283_13529_13876(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 13529, 13876);
                    return 0;
                }


                System.Management.Automation.SessionState
                f_1283_14041_14053()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 14041, 14053);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1283_14041_14062(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 14041, 14062);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1283_14041_14078(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 14041, 14078);
                    return return_v;
                }


                string
                f_1283_14041_14083(System.Management.Automation.PathInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 14041, 14083);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1283_14222_14234(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 14222, 14234);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1283_14222_14247(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 14222, 14247);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1283_14222_14260(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 14222, 14260);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1283_14416_14424()
                {
                    var return_v = Parallel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 14416, 14424);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1283_14514_14526(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 14514, 14526);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>
                f_1283_14322_14566(System.Management.Automation.ScriptBlock
                scriptBlock, bool
                isTrustedInput, System.Management.Automation.ExecutionContext
                context, System.Collections.Generic.Dictionary<string, object>
                variables)
                {
                    var return_v = ScriptBlockToPowerShellConverter.GetUsingValuesAsDictionary(scriptBlock, isTrustedInput, context, variables);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 14322, 14566);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>.ValueCollection
                f_1283_14868_14890(System.Collections.Generic.Dictionary<string, object>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 14868, 14890);
                    return return_v;
                }


                string
                f_1283_15107_15170()
                {
                    var return_v = InternalCommandStrings.ParallelUsingVariableCannotBeScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 15107, 15170);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1283_15083_15171(string
                message)
                {
                    var return_v = new System.Management.Automation.PSArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 15083, 15171);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_15037_15336(System.Management.Automation.PSArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, Microsoft.PowerShell.Commands.ForEachObjectCommand
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 15037, 15336);
                    return return_v;
                }


                int
                f_1283_14989_15337(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 14989, 15337);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, object>.ValueCollection
                f_1283_14868_14890_I(System.Collections.Generic.Dictionary<string, object>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 14868, 14890);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1283_15392_15397()
                {
                    var return_v = AsJob;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 15392, 15397);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1283_15490_15502()
                {
                    var return_v = MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 15490, 15502);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>
                f_1283_15490_15518(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 15490, 15518);
                    return return_v;
                }


                bool
                f_1283_15490_15554(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 15490, 15554);
                    return return_v;
                }


                string
                f_1283_15714_15768()
                {
                    var return_v = InternalCommandStrings.ParallelCannotUseTimeoutWithJob;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 15714, 15768);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1283_15690_15769(string
                message)
                {
                    var return_v = new System.Management.Automation.PSArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 15690, 15769);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_15644_15930(System.Management.Automation.PSArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, Microsoft.PowerShell.Commands.ForEachObjectCommand
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 15644, 15930);
                    return return_v;
                }


                int
                f_1283_15596_15931(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 15596, 15931);
                    return 0;
                }


                System.Management.Automation.ScriptBlock
                f_1283_16018_16026()
                {
                    var return_v = Parallel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 16018, 16026);
                    return return_v;
                }


                string
                f_1283_16018_16037(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 16018, 16037);
                    return return_v;
                }


                int
                f_1283_16060_16073()
                {
                    var return_v = ThrottleLimit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 16060, 16073);
                    return return_v;
                }


                System.Management.Automation.PSTasks.PSTaskJob
                f_1283_15982_16074(string
                command, int
                throttleLimit)
                {
                    var return_v = new System.Management.Automation.PSTasks.PSTaskJob(command, throttleLimit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 15982, 16074);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSTasks.PSTask>
                f_1283_16221_16288()
                {
                    var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.PSTasks.PSTask>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 16221, 16288);
                    return return_v;
                }


                System.Management.Automation.PSTasks.PSTaskDataStreamWriter
                f_1283_16327_16359(Microsoft.PowerShell.Commands.ForEachObjectCommand
                psCmdlet)
                {
                    var return_v = new System.Management.Automation.PSTasks.PSTaskDataStreamWriter((System.Management.Automation.PSCmdlet)psCmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 16327, 16359);
                    return return_v;
                }


                int
                f_1283_16401_16414()
                {
                    var return_v = ThrottleLimit;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 16401, 16414);
                    return return_v;
                }


                System.Management.Automation.PSTasks.PSTaskPool
                f_1283_16386_16415(int
                size)
                {
                    var return_v = new System.Management.Automation.PSTasks.PSTaskPool(size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 16386, 16415);
                    return return_v;
                }


                int
                f_1283_16623_16637()
                {
                    var return_v = TimeoutSeconds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 16623, 16637);
                    return return_v;
                }


                int
                f_1283_16856_16870()
                {
                    var return_v = TimeoutSeconds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 16856, 16870);
                    return return_v;
                }


                System.Threading.Timer
                f_1283_16689_16925(System.Threading.TimerCallback
                callback, object?
                state, int
                dueTime, int
                period)
                {
                    var return_v = new System.Threading.Timer(callback: callback, state: state, dueTime: dueTime, period: period);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 16689, 16925);
                    return return_v;
                }


                bool
                f_1283_16998_19399(System.Threading.WaitCallback
                callBack)
                {
                    var return_v = System.Threading.ThreadPool.QueueUserWorkItem(callBack);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 16998, 19399);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 12870, 19411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 12870, 19411);
            }
        }

        private void ProcessParallelParameterSet()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 19423, 21534);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 19533, 20032) || true) && (_inputObject != null && (DynAbs.Tracing.TraceSender.Expression_True(1283, 19537, 19616) && f_1283_19578_19601(_inputObject) is ScriptBlock))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 19533, 20032);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 19650, 19990);

                    f_1283_19650_19989(this, f_1283_19683_19988(f_1283_19729_19820(f_1283_19753_19819()), "ParallelPipedInputObjectCannotBeScriptBlock", ErrorCategory.InvalidType, this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 20010, 20017);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 19533, 20032);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 20048, 20408) || true) && (f_1283_20052_20057())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 20048, 20408);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 20131, 20316);

                    var
                    taskChildJob = f_1283_20150_20315(f_1283_20191_20199(), _usingValuesMap, f_1283_20260_20271(), _currentLocationPath)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 20336, 20366);

                    f_1283_20336_20365(
                                    _taskJob, taskChildJob);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 20386, 20393);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 20048, 20408);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 20465, 20504);

                f_1283_20465_20503(
                            // Write any streaming data
                            _taskDataStreamWriter);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 20575, 21523) || true) && (f_1283_20579_20601(_taskCollection))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 20575, 21523);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 20878, 21204);

                        f_1283_20878_21203(                    // Create a PSTask based on this piped input and add it to the task collection.
                                                               // A dedicated thread will add it to the PSTask pool in a performant manner.
                                            _taskCollection, f_1283_20924_21202(f_1283_21002_21010(), _usingValuesMap, f_1283_21087_21098(), _currentLocationPath, _taskDataStreamWriter));
                    }
                    catch (InvalidOperationException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1283, 21241, 21508);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 21423, 21489);

                        f_1283_21423_21488(false, "Should not add to a closed PSTask collection");
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1283, 21241, 21508);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 20575, 21523);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 19423, 21534);

                object
                f_1283_19578_19601(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 19578, 19601);
                    return return_v;
                }


                string
                f_1283_19753_19819()
                {
                    var return_v = InternalCommandStrings.ParallelPipedInputObjectCannotBeScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 19753, 19819);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1283_19729_19820(string
                message)
                {
                    var return_v = new System.Management.Automation.PSArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 19729, 19820);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_19683_19988(System.Management.Automation.PSArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, Microsoft.PowerShell.Commands.ForEachObjectCommand
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 19683, 19988);
                    return return_v;
                }


                int
                f_1283_19650_19989(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 19650, 19989);
                    return 0;
                }


                System.Management.Automation.SwitchParameter
                f_1283_20052_20057()
                {
                    var return_v = AsJob;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 20052, 20057);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1283_20191_20199()
                {
                    var return_v = Parallel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 20191, 20199);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1283_20260_20271()
                {
                    var return_v = InputObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 20260, 20271);
                    return return_v;
                }


                System.Management.Automation.PSTasks.PSTaskChildJob
                f_1283_20150_20315(System.Management.Automation.ScriptBlock
                scriptBlock, System.Collections.Generic.Dictionary<string, object>
                usingValuesMap, System.Management.Automation.PSObject
                dollarUnderbar, string
                currentLocationPath)
                {
                    var return_v = new System.Management.Automation.PSTasks.PSTaskChildJob(scriptBlock, usingValuesMap, (object)dollarUnderbar, currentLocationPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 20150, 20315);
                    return return_v;
                }


                bool
                f_1283_20336_20365(System.Management.Automation.PSTasks.PSTaskJob
                this_param, System.Management.Automation.PSTasks.PSTaskChildJob
                childJob)
                {
                    var return_v = this_param.AddJob(childJob);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 20336, 20365);
                    return return_v;
                }


                int
                f_1283_20465_20503(System.Management.Automation.PSTasks.PSTaskDataStreamWriter
                this_param)
                {
                    this_param.WriteImmediate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 20465, 20503);
                    return 0;
                }


                bool
                f_1283_20579_20601(System.Management.Automation.PSDataCollection<System.Management.Automation.PSTasks.PSTask>
                this_param)
                {
                    var return_v = this_param.IsOpen;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 20579, 20601);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1283_21002_21010()
                {
                    var return_v = Parallel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 21002, 21010);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1283_21087_21098()
                {
                    var return_v = InputObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 21087, 21098);
                    return return_v;
                }


                System.Management.Automation.PSTasks.PSTask
                f_1283_20924_21202(System.Management.Automation.ScriptBlock
                scriptBlock, System.Collections.Generic.Dictionary<string, object>
                usingValuesMap, System.Management.Automation.PSObject
                dollarUnderbar, string
                currentLocationPath, System.Management.Automation.PSTasks.PSTaskDataStreamWriter
                dataStreamWriter)
                {
                    var return_v = new System.Management.Automation.PSTasks.PSTask(scriptBlock, usingValuesMap, (object)dollarUnderbar, currentLocationPath, dataStreamWriter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 20924, 21202);
                    return return_v;
                }


                int
                f_1283_20878_21203(System.Management.Automation.PSDataCollection<System.Management.Automation.PSTasks.PSTask>
                this_param, System.Management.Automation.PSTasks.PSTask
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 20878, 21203);
                    return 0;
                }


                int
                f_1283_21423_21488(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 21423, 21488);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 19423, 21534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 19423, 21534);
            }
        }

        private void EndParallelParameterSet()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 21546, 22782);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 21609, 21853) || true) && (f_1283_21613_21618())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 21609, 21853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 21708, 21725);

                    f_1283_21708_21724(                // Start and return parent job object.
                                    _taskJob);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 21743, 21771);

                    f_1283_21743_21770(f_1283_21743_21756(), _taskJob);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 21789, 21811);

                    f_1283_21789_21810(this, _taskJob);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 21831, 21838);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 21609, 21853);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 21965, 22004);

                f_1283_21965_22003(
                            // Close task collection and wait for processing to complete while streaming data.
                            _taskDataStreamWriter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 22018, 22045);

                f_1283_22018_22044(_taskCollection);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 22059, 22096);

                f_1283_22059_22095(_taskDataStreamWriter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 22215, 22249);

                var
                ex = _taskCollectionException
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 22263, 22771) || true) && (ex != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 22263, 22771);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 22311, 22427);

                    var
                    msg = f_1283_22321_22426(f_1283_22335_22363(), f_1283_22365_22421(), ex)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 22445, 22756);

                    f_1283_22445_22755(this, f_1283_22478_22754(exception: f_1283_22531_22565(msg), errorId: "ParallelPipedInputProcessingError", errorCategory: ErrorCategory.InvalidOperation, targetObject: this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 22263, 22771);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 21546, 22782);

                System.Management.Automation.SwitchParameter
                f_1283_21613_21618()
                {
                    var return_v = AsJob;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 21613, 21618);
                    return return_v;
                }


                int
                f_1283_21708_21724(System.Management.Automation.PSTasks.PSTaskJob
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 21708, 21724);
                    return 0;
                }


                System.Management.Automation.JobRepository
                f_1283_21743_21756()
                {
                    var return_v = JobRepository;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 21743, 21756);
                    return return_v;
                }


                int
                f_1283_21743_21770(System.Management.Automation.JobRepository
                this_param, System.Management.Automation.PSTasks.PSTaskJob
                item)
                {
                    this_param.Add((System.Management.Automation.Job)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 21743, 21770);
                    return 0;
                }


                int
                f_1283_21789_21810(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, System.Management.Automation.PSTasks.PSTaskJob
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 21789, 21810);
                    return 0;
                }


                int
                f_1283_21965_22003(System.Management.Automation.PSTasks.PSTaskDataStreamWriter
                this_param)
                {
                    this_param.WriteImmediate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 21965, 22003);
                    return 0;
                }


                int
                f_1283_22018_22044(System.Management.Automation.PSDataCollection<System.Management.Automation.PSTasks.PSTask>
                this_param)
                {
                    this_param.Complete();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 22018, 22044);
                    return 0;
                }


                int
                f_1283_22059_22095(System.Management.Automation.PSTasks.PSTaskDataStreamWriter
                this_param)
                {
                    this_param.WaitAndWrite();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 22059, 22095);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1283_22335_22363()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 22335, 22363);
                    return return_v;
                }


                string
                f_1283_22365_22421()
                {
                    var return_v = InternalCommandStrings.ParallelPipedInputProcessingError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 22365, 22421);
                    return return_v;
                }


                string
                f_1283_22321_22426(System.Globalization.CultureInfo
                provider, string
                format, System.Exception
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 22321, 22426);
                    return return_v;
                }


                System.InvalidOperationException
                f_1283_22531_22565(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 22531, 22565);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_22478_22754(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, Microsoft.PowerShell.Commands.ForEachObjectCommand
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception: (System.Exception)exception, errorId: errorId, errorCategory: errorCategory, targetObject: (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 22478, 22754);
                    return return_v;
                }


                int
                f_1283_22445_22755(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 22445, 22755);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 21546, 22782);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 21546, 22782);
            }
        }

        private void StopParallelProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 22794, 22930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 22856, 22884);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_taskCollection, 1283, 22856, 22883)?.Complete(), 1283, 22872, 22883);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 22898, 22919);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_taskPool, 1283, 22898, 22918)?.StopAll(), 1283, 22908, 22918);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 22794, 22930);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 22794, 22930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 22794, 22930);
            }
        }

        private void EndBlockParameterSet()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 22964, 23562);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 23024, 23102) || true) && (_endScript == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 23024, 23102);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 23080, 23087);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 23024, 23102);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 23118, 23157);

                var
                emptyArray = f_1283_23135_23156()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 23171, 23551);

                f_1283_23171_23550(_endScript, contextCmdlet: this, useLocalScope: false, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, dollarUnder: f_1283_23407_23427(), input: emptyArray, scriptThis: f_1283_23494_23514(), args: emptyArray);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 22964, 23562);

                object[]
                f_1283_23135_23156()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 23135, 23156);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1283_23407_23427()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 23407, 23427);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1283_23494_23514()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 23494, 23514);
                    return return_v;
                }


                int
                f_1283_23171_23550(System.Management.Automation.ScriptBlock
                this_param, Microsoft.PowerShell.Commands.ForEachObjectCommand
                contextCmdlet, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, object[]
                input, System.Management.Automation.PSObject
                scriptThis, object[]
                args)
                {
                    this_param.InvokeUsingCmdlet(contextCmdlet: (System.Management.Automation.Cmdlet)contextCmdlet, useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 23171, 23550);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 22964, 23562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 22964, 23562);
            }
        }

        private void ProcessPropertyAndMethodParameterSet()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 23574, 38271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 23650, 23792);

                _targetString = f_1283_23666_23791(f_1283_23680_23708(), f_1283_23710_23752(), f_1283_23754_23790(f_1283_23778_23789()));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 23808, 25634) || true) && (f_1283_23812_23850(f_1283_23838_23849()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 23808, 25634);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 23884, 25592) || true) && (_arguments != null && (DynAbs.Tracing.TraceSender.Expression_True(1283, 23888, 23931) && f_1283_23910_23927(_arguments) > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 23884, 25592);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 23973, 24156);

                        f_1283_23973_24155(this, f_1283_23984_24154("InputObject", f_1283_24026_24058(), "InvokeMethodOnNull", _inputObject));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 23884, 25592);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 23884, 25592);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 24277, 24445);

                        string
                        propertyAction = f_1283_24301_24444(f_1283_24315_24343(), f_1283_24370_24420(), _propertyOrMethodName)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 24469, 25573) || true) && (f_1283_24473_24517(this, _targetString, propertyAction))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 24469, 25573);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 24567, 25550) || true) && (f_1283_24571_24597(f_1283_24571_24578(), 2))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 24567, 25550);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 24655, 24853);

                                f_1283_24655_24852(this, f_1283_24666_24851("InputObject", f_1283_24708_24748(), "InputObjectIsNull", _inputObject));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 24567, 25550);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 24567, 25550);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 25505, 25523);

                                f_1283_25505_25522(this, null);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 24567, 25550);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 24469, 25573);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 23884, 25592);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 25612, 25619);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 23808, 25634);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 25650, 25681);

                ErrorRecord
                errorRecord = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 25767, 37126) || true) && (_arguments != null && (DynAbs.Tracing.TraceSender.Expression_True(1283, 25771, 25814) && f_1283_25793_25810(_arguments) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 25767, 37126);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 25848, 25874);

                    f_1283_25848_25873(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 25767, 37126);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 25767, 37126);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 26040, 26087) || true) && (f_1283_26044_26074(this))
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 26040, 26087);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 26078, 26085);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 26040, 26087);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 26107, 26134);

                    PSMemberInfo
                    member = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 26152, 27708) || true) && (f_1283_26156_26221(_propertyOrMethodName))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 26152, 27708);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 26313, 26462);

                        ReadOnlyPSMemberInfoCollection<PSMemberInfo>
                        members =
                        f_1283_26393_26461(f_1283_26393_26413(_inputObject), _propertyOrMethodName, PSMemberTypes.All)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 26484, 26570);

                        f_1283_26484_26569(members != null, "The return value of Members.Match should never be null");

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 26594, 27415) || true) && (f_1283_26598_26611(members) > 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 26594, 27415);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 26739, 26791);

                            StringBuilder
                            possibleMatches = f_1283_26771_26790()
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 26817, 27017);
                                foreach (PSMemberInfo item in f_1283_26847_26854_I(members))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 26817, 27017);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 26912, 26990);

                                    f_1283_26912_26989(possibleMatches, f_1283_26941_26969(), " {0}", f_1283_26979_26988(item));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 26817, 27017);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1283, 1, 201);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1283, 1, 201);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 27045, 27359);

                            f_1283_27045_27358(this, f_1283_27056_27357("Name", f_1283_27091_27143(), "AmbiguousPropertyOrMethodName", _inputObject, _propertyOrMethodName, possibleMatches));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 27385, 27392);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 26594, 27415);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 27439, 27554) || true) && (f_1283_27443_27456(members) == 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 27439, 27554);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 27511, 27531);

                            member = f_1283_27520_27530(members, 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 27439, 27554);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 26152, 27708);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 26152, 27708);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 27636, 27689);

                        member = f_1283_27645_27688(f_1283_27645_27665(_inputObject), _propertyOrMethodName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 26152, 27708);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 27767, 37111) || true) && (member is PSMethodInfo)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 27767, 37111);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 27915, 28003);

                        PSParameterizedProperty
                        targetParameterizedProperty = member as PSParameterizedProperty
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 28025, 28698) || true) && (targetParameterizedProperty != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 28025, 28698);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 28157, 28340);

                            string
                            propertyAction = f_1283_28181_28339(f_1283_28195_28223(), f_1283_28254_28304(), f_1283_28306_28338(targetParameterizedProperty))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 28481, 28640) || true) && (f_1283_28485_28529(this, _targetString, propertyAction))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 28481, 28640);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 28587, 28613);

                                f_1283_28587_28612(this, f_1283_28599_28611(member));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 28481, 28640);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 28668, 28675);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 28025, 28698);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 28722, 28773);

                        PSMethodInfo
                        targetMethod = member as PSMethodInfo
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 28795, 28869);

                        f_1283_28795_28868(targetMethod != null, "targetMethod should not be null here.");
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 28986, 29166);

                            string
                            methodAction = f_1283_29008_29165(f_1283_29022_29050(), f_1283_29081_29145(), f_1283_29147_29164(targetMethod))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 29194, 29595) || true) && (f_1283_29198_29240(this, _targetString, methodAction))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 29194, 29595);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 29298, 29568) || true) && (!f_1283_29303_29341(this, f_1283_29329_29340()))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 29298, 29568);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 29407, 29466);

                                    object
                                    result = f_1283_29423_29465(targetMethod, f_1283_29443_29464())
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 29500, 29537);

                                    f_1283_29500_29536(this, result);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 29298, 29568);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 29194, 29595);
                            }
                        }
                        catch (PipelineStoppedException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1283, 29640, 29834);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 29805, 29811);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1283, 29640, 29834);
                        }
                        catch (Exception ex)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1283, 29856, 30468);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 29925, 29969);

                            MethodException
                            mex = ex as MethodException
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 29995, 30445) || true) && (mex != null && (DynAbs.Tracing.TraceSender.Expression_True(1283, 29999, 30037) && f_1283_30014_30029(mex) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1283, 29999, 30111) && f_1283_30041_30078(f_1283_30041_30056(mex)) == "MethodCountCouldNotFindBest"))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 29995, 30445);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 30169, 30201);

                                f_1283_30169_30200(this, f_1283_30181_30199(targetMethod));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 29995, 30445);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 29995, 30445);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 30315, 30418);

                                f_1283_30315_30417(this, f_1283_30326_30416(ex, "MethodInvocationError", ErrorCategory.InvalidOperation, _inputObject));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 29995, 30445);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1283, 29856, 30468);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 27767, 37111);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 27767, 37111);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 30550, 30585);

                        string
                        resolvedPropertyName = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 30607, 30641);

                        bool
                        isBlindDynamicAccess = false
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 30663, 32491) || true) && (member == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 30663, 32491);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 30731, 32159) || true) && ((f_1283_30736_30759(_inputObject) is IDynamicMetaObjectProvider) && (DynAbs.Tracing.TraceSender.Expression_True(1283, 30735, 30889) && !f_1283_30824_30889(_propertyOrMethodName)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 30731, 32159);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 31612, 31657);

                                resolvedPropertyName = _propertyOrMethodName;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 31687, 31715);

                                isBlindDynamicAccess = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 30731, 32159);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 30731, 32159);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 31829, 32132);

                                errorRecord = f_1283_31843_32131("Name", f_1283_31878_31925(), "PropertyOrMethodNotFound", _inputObject, _propertyOrMethodName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 30731, 32159);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 30663, 32491);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 30663, 32491);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 32433, 32468);

                            resolvedPropertyName = f_1283_32456_32467(member);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 30663, 32491);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 32515, 37092) || true) && (!f_1283_32520_32562(resolvedPropertyName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 32515, 37092);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 32655, 32826);

                            string
                            propertyAction = f_1283_32679_32825(f_1283_32693_32721(), f_1283_32752_32802(), resolvedPropertyName)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 32854, 37069) || true) && (f_1283_32858_32902(this, _targetString, propertyAction))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 32854, 37069);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 33028, 33114);

                                    f_1283_33028_33113(this, _propGetter.GetValue(f_1283_33078_33089(), resolvedPropertyName));
                                }
                                catch (TerminateException) // The debugger is terminating the execution
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1283, 33175, 33348);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 33311, 33317);

                                    throw;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1283, 33175, 33348);
                                }
                                catch (MethodException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1283, 33378, 33503);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 33466, 33472);

                                    throw;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1283, 33378, 33503);
                                }
                                catch (PipelineStoppedException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1283, 33533, 33759);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 33722, 33728);

                                    throw;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1283, 33533, 33759);
                                }
                                catch (Exception ex)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1283, 33789, 37042);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 35990, 37011) || true) && (isBlindDynamicAccess)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 35990, 37011);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 36088, 36424);

                                        errorRecord = f_1283_36102_36423(ex, "DynamicPropertyAccessFailed_" + _propertyOrMethodName, ErrorCategory.InvalidOperation, f_1283_36411_36422());
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 35990, 37011);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 35990, 37011);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 36958, 36976);

                                        f_1283_36958_36975(this, null);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 35990, 37011);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1283, 33789, 37042);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 32854, 37069);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 32515, 37092);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 27767, 37111);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 25767, 37126);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 37142, 38260) || true) && (errorRecord != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 37142, 38260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 37199, 37363);

                    string
                    propertyAction = f_1283_37223_37362(f_1283_37237_37265(), f_1283_37288_37338(), _propertyOrMethodName)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 37383, 38245) || true) && (f_1283_37387_37431(this, _targetString, propertyAction))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 37383, 38245);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 37473, 38226) || true) && (f_1283_37477_37503(f_1283_37477_37484(), 2))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 37473, 38226);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 37553, 37577);

                            f_1283_37553_37576(this, errorRecord);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 37473, 38226);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 37473, 38226);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 38185, 38203);

                            f_1283_38185_38202(this, null);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 37473, 38226);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 37383, 38245);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 37142, 38260);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 23574, 38271);

                System.Globalization.CultureInfo
                f_1283_23680_23708()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 23680, 23708);
                    return return_v;
                }


                string
                f_1283_23710_23752()
                {
                    var return_v = InternalCommandStrings.ForEachObjectTarget;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 23710, 23752);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1283_23778_23789()
                {
                    var return_v = InputObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 23778, 23789);
                    return return_v;
                }


                string
                f_1283_23754_23790(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = GetStringRepresentation((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 23754, 23790);
                    return return_v;
                }


                string
                f_1283_23666_23791(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 23666, 23791);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1283_23838_23849()
                {
                    var return_v = InputObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 23838, 23849);
                    return return_v;
                }


                bool
                f_1283_23812_23850(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = LanguagePrimitives.IsNull((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 23812, 23850);
                    return return_v;
                }


                int
                f_1283_23910_23927(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 23910, 23927);
                    return return_v;
                }


                string
                f_1283_24026_24058()
                {
                    var return_v = ParserStrings.InvokeMethodOnNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 24026, 24058);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_23984_24154(string
                paraName, string
                resourceString, string
                errorId, System.Management.Automation.PSObject
                target, params object[]
                args)
                {
                    var return_v = GenerateNameParameterError(paraName, resourceString, errorId, (object)target, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 23984, 24154);
                    return return_v;
                }


                int
                f_1283_23973_24155(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 23973, 24155);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1283_24315_24343()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 24315, 24343);
                    return return_v;
                }


                string
                f_1283_24370_24420()
                {
                    var return_v = InternalCommandStrings.ForEachObjectPropertyAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 24370, 24420);
                    return return_v;
                }


                string
                f_1283_24301_24444(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 24301, 24444);
                    return return_v;
                }


                bool
                f_1283_24473_24517(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, string
                target, string
                action)
                {
                    var return_v = this_param.ShouldProcess(target, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 24473, 24517);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1283_24571_24578()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 24571, 24578);
                    return return_v;
                }


                bool
                f_1283_24571_24597(System.Management.Automation.ExecutionContext
                this_param, int
                majorVersion)
                {
                    var return_v = this_param.IsStrictVersion(majorVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 24571, 24597);
                    return return_v;
                }


                string
                f_1283_24708_24748()
                {
                    var return_v = InternalCommandStrings.InputObjectIsNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 24708, 24748);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_24666_24851(string
                paraName, string
                resourceString, string
                errorId, System.Management.Automation.PSObject
                target, params object[]
                args)
                {
                    var return_v = GenerateNameParameterError(paraName, resourceString, errorId, (object)target, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 24666, 24851);
                    return return_v;
                }


                int
                f_1283_24655_24852(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 24655, 24852);
                    return 0;
                }


                int
                f_1283_25505_25522(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, object
                sendToPipeline)
                {
                    this_param.WriteObject(sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 25505, 25522);
                    return 0;
                }


                int
                f_1283_25793_25810(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 25793, 25810);
                    return return_v;
                }


                int
                f_1283_25848_25873(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param)
                {
                    this_param.MethodCallWithArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 25848, 25873);
                    return 0;
                }


                bool
                f_1283_26044_26074(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param)
                {
                    var return_v = this_param.GetValueFromIDictionaryInput();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 26044, 26074);
                    return return_v;
                }


                bool
                f_1283_26156_26221(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 26156, 26221);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1283_26393_26413(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 26393, 26413);
                    return return_v;
                }


                System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1283_26393_26461(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, string
                name, System.Management.Automation.PSMemberTypes
                memberTypes)
                {
                    var return_v = this_param.Match(name, memberTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 26393, 26461);
                    return return_v;
                }


                int
                f_1283_26484_26569(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 26484, 26569);
                    return 0;
                }


                int
                f_1283_26598_26611(System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 26598, 26611);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1283_26771_26790()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 26771, 26790);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1283_26941_26969()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 26941, 26969);
                    return return_v;
                }


                string
                f_1283_26979_26988(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 26979, 26988);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1283_26912_26989(System.Text.StringBuilder
                this_param, System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 26912, 26989);
                    return return_v;
                }


                System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1283_26847_26854_I(System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 26847, 26854);
                    return return_v;
                }


                string
                f_1283_27091_27143()
                {
                    var return_v = InternalCommandStrings.AmbiguousPropertyOrMethodName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 27091, 27143);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_27056_27357(string
                paraName, string
                resourceString, string
                errorId, System.Management.Automation.PSObject
                target, params object[]
                args)
                {
                    var return_v = GenerateNameParameterError(paraName, resourceString, errorId, (object)target, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 27056, 27357);
                    return return_v;
                }


                int
                f_1283_27045_27358(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 27045, 27358);
                    return 0;
                }


                int
                f_1283_27443_27456(System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 27443, 27456);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1283_27520_27530(System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 27520, 27530);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1283_27645_27665(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 27645, 27665);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1283_27645_27688(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 27645, 27688);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1283_28195_28223()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 28195, 28223);
                    return return_v;
                }


                string
                f_1283_28254_28304()
                {
                    var return_v = InternalCommandStrings.ForEachObjectPropertyAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 28254, 28304);
                    return return_v;
                }


                string
                f_1283_28306_28338(System.Management.Automation.PSParameterizedProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 28306, 28338);
                    return return_v;
                }


                string
                f_1283_28181_28339(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 28181, 28339);
                    return return_v;
                }


                bool
                f_1283_28485_28529(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, string
                target, string
                action)
                {
                    var return_v = this_param.ShouldProcess(target, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 28485, 28529);
                    return return_v;
                }


                object
                f_1283_28599_28611(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 28599, 28611);
                    return return_v;
                }


                int
                f_1283_28587_28612(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, object
                sendToPipeline)
                {
                    this_param.WriteObject(sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 28587, 28612);
                    return 0;
                }


                int
                f_1283_28795_28868(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 28795, 28868);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1283_29022_29050()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 29022, 29050);
                    return return_v;
                }


                string
                f_1283_29081_29145()
                {
                    var return_v = InternalCommandStrings.ForEachObjectMethodActionWithoutArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 29081, 29145);
                    return return_v;
                }


                string
                f_1283_29147_29164(System.Management.Automation.PSMethodInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 29147, 29164);
                    return return_v;
                }


                string
                f_1283_29008_29165(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 29008, 29165);
                    return return_v;
                }


                bool
                f_1283_29198_29240(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, string
                target, string
                action)
                {
                    var return_v = this_param.ShouldProcess(target, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 29198, 29240);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1283_29329_29340()
                {
                    var return_v = InputObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 29329, 29340);
                    return return_v;
                }


                bool
                f_1283_29303_29341(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, System.Management.Automation.PSObject
                inputObject)
                {
                    var return_v = this_param.BlockMethodInLanguageMode((object)inputObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 29303, 29341);
                    return return_v;
                }


                object[]
                f_1283_29443_29464()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 29443, 29464);
                    return return_v;
                }


                object
                f_1283_29423_29465(System.Management.Automation.PSMethodInfo
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.Invoke(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 29423, 29465);
                    return return_v;
                }


                int
                f_1283_29500_29536(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, object
                obj)
                {
                    this_param.WriteToPipelineWithUnrolling(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 29500, 29536);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1283_30014_30029(System.Management.Automation.MethodException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 30014, 30029);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_30041_30056(System.Management.Automation.MethodException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 30041, 30056);
                    return return_v;
                }


                string
                f_1283_30041_30078(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.FullyQualifiedErrorId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 30041, 30078);
                    return return_v;
                }


                object
                f_1283_30181_30199(System.Management.Automation.PSMethodInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 30181, 30199);
                    return return_v;
                }


                int
                f_1283_30169_30200(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, object
                sendToPipeline)
                {
                    this_param.WriteObject(sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 30169, 30200);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1283_30326_30416(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.PSObject
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 30326, 30416);
                    return return_v;
                }


                int
                f_1283_30315_30417(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 30315, 30417);
                    return 0;
                }


                object
                f_1283_30736_30759(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 30736, 30759);
                    return return_v;
                }


                bool
                f_1283_30824_30889(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 30824, 30889);
                    return return_v;
                }


                string
                f_1283_31878_31925()
                {
                    var return_v = InternalCommandStrings.PropertyOrMethodNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 31878, 31925);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_31843_32131(string
                paraName, string
                resourceString, string
                errorId, System.Management.Automation.PSObject
                target, params object[]
                args)
                {
                    var return_v = GenerateNameParameterError(paraName, resourceString, errorId, (object)target, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 31843, 32131);
                    return return_v;
                }


                string
                f_1283_32456_32467(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 32456, 32467);
                    return return_v;
                }


                bool
                f_1283_32520_32562(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 32520, 32562);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1283_32693_32721()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 32693, 32721);
                    return return_v;
                }


                string
                f_1283_32752_32802()
                {
                    var return_v = InternalCommandStrings.ForEachObjectPropertyAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 32752, 32802);
                    return return_v;
                }


                string
                f_1283_32679_32825(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 32679, 32825);
                    return return_v;
                }


                bool
                f_1283_32858_32902(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, string
                target, string
                action)
                {
                    var return_v = this_param.ShouldProcess(target, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 32858, 32902);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1283_33078_33089()
                {
                    var return_v = InputObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 33078, 33089);
                    return return_v;
                }


                int
                f_1283_33028_33113(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, object
                obj)
                {
                    this_param.WriteToPipelineWithUnrolling(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 33028, 33113);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1283_36411_36422()
                {
                    var return_v = InputObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 36411, 36422);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_36102_36423(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.PSObject
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 36102, 36423);
                    return return_v;
                }


                int
                f_1283_36958_36975(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, object
                sendToPipeline)
                {
                    this_param.WriteObject(sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 36958, 36975);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1283_37237_37265()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 37237, 37265);
                    return return_v;
                }


                string
                f_1283_37288_37338()
                {
                    var return_v = InternalCommandStrings.ForEachObjectPropertyAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 37288, 37338);
                    return return_v;
                }


                string
                f_1283_37223_37362(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 37223, 37362);
                    return return_v;
                }


                bool
                f_1283_37387_37431(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, string
                target, string
                action)
                {
                    var return_v = this_param.ShouldProcess(target, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 37387, 37431);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1283_37477_37484()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 37477, 37484);
                    return return_v;
                }


                bool
                f_1283_37477_37503(System.Management.Automation.ExecutionContext
                this_param, int
                majorVersion)
                {
                    var return_v = this_param.IsStrictVersion(majorVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 37477, 37503);
                    return return_v;
                }


                int
                f_1283_37553_37576(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 37553, 37576);
                    return 0;
                }


                int
                f_1283_38185_38202(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, object
                sendToPipeline)
                {
                    this_param.WriteObject(sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 38185, 38202);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 23574, 38271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 23574, 38271);
            }
        }

        private void ProcessScriptBlockParameterSet()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 38283, 39349);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 38362, 38372);
                    for (int
        i = _start
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 38353, 39338) || true) && (i < _end)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 38384, 38387)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 38353, 39338))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 38353, 39338);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 38782, 39323) || true) && (f_1283_38786_38797(_scripts, i) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 38782, 39323);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 38847, 39304);

                            f_1283_38847_39303(f_1283_38847_38858(_scripts, i), contextCmdlet: this, useLocalScope: false, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, dollarUnder: f_1283_39116_39127(), input: new object[] { f_1283_39176_39187() }, scriptThis: f_1283_39228_39248(), args: f_1283_39281_39302());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 38782, 39323);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1283, 1, 986);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1283, 1, 986);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 38283, 39349);

                System.Management.Automation.ScriptBlock
                f_1283_38786_38797(System.Collections.Generic.List<System.Management.Automation.ScriptBlock>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 38786, 38797);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1283_38847_38858(System.Collections.Generic.List<System.Management.Automation.ScriptBlock>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 38847, 38858);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1283_39116_39127()
                {
                    var return_v = InputObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 39116, 39127);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1283_39176_39187()
                {
                    var return_v = InputObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 39176, 39187);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1283_39228_39248()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 39228, 39248);
                    return return_v;
                }


                object[]
                f_1283_39281_39302()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 39281, 39302);
                    return return_v;
                }


                int
                f_1283_38847_39303(System.Management.Automation.ScriptBlock
                this_param, Microsoft.PowerShell.Commands.ForEachObjectCommand
                contextCmdlet, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, object[]
                input, System.Management.Automation.PSObject
                scriptThis, object[]
                args)
                {
                    this_param.InvokeUsingCmdlet(contextCmdlet: (System.Management.Automation.Cmdlet)contextCmdlet, useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 38847, 39303);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 38283, 39349);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 38283, 39349);
            }
        }

        private void InitScriptBlockParameterSet()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 39361, 42294);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 39974, 40055);

                Dictionary<string, object>
                psBoundParameters = f_1283_40021_40054(f_1283_40021_40038(this))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 40069, 41123) || true) && (psBoundParameters != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 40069, 41123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 40132, 40163);

                    SwitchParameter
                    whatIf = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 40181, 40213);

                    SwitchParameter
                    confirm = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 40233, 40249);

                    object
                    argument
                    = default(object);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 40267, 40420) || true) && (f_1283_40271_40324(psBoundParameters, "whatif", out argument))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 40267, 40420);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 40366, 40401);

                        whatIf = (SwitchParameter)argument;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 40267, 40420);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 40440, 40595) || true) && (f_1283_40444_40498(psBoundParameters, "confirm", out argument))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 40440, 40595);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 40540, 40576);

                        confirm = (SwitchParameter)argument;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 40440, 40595);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 40615, 41108) || true) && (whatIf || (DynAbs.Tracing.TraceSender.Expression_False(1283, 40619, 40636) || confirm))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 40615, 41108);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 40678, 40751);

                        string
                        message = f_1283_40695_40750()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 40775, 41032);

                        ErrorRecord
                        errorRecord = f_1283_40801_41031(f_1283_40843_40881(message), "NoShouldProcessForScriptBlockSet", ErrorCategory.InvalidOperation, null)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 41054, 41089);

                        f_1283_41054_41088(this, errorRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 40615, 41108);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 40069, 41123);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 41227, 41249);

                _end = f_1283_41234_41248(_scripts);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 41263, 41299);

                _start = (DynAbs.Tracing.TraceSender.Conditional_F1(1283, 41272, 41290) || ((f_1283_41272_41286(_scripts) > 1 && DynAbs.Tracing.TraceSender.Conditional_F2(1283, 41293, 41294)) || DynAbs.Tracing.TraceSender.Conditional_F3(1283, 41297, 41298))) ? 1 : 0;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 41406, 41632) || true) && (!_setEndScript)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 41406, 41632);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 41458, 41617) || true) && (f_1283_41462_41476(_scripts) > 2)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 41458, 41617);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 41522, 41548);

                        _end = f_1283_41529_41543(_scripts) - 1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 41570, 41598);

                        _endScript = f_1283_41583_41597(_scripts, _end);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 41458, 41617);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 41406, 41632);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 41730, 41768) || true) && (_end < 2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 41730, 41768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 41761, 41768);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 41730, 41768);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 41784, 41833) || true) && (f_1283_41788_41799(_scripts, 0) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 41784, 41833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 41826, 41833);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 41784, 41833);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 41849, 41888);

                var
                emptyArray = f_1283_41866_41887()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 41902, 42283);

                f_1283_41902_42282(f_1283_41902_41913(_scripts, 0), contextCmdlet: this, useLocalScope: false, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, dollarUnder: f_1283_42139_42159(), input: emptyArray, scriptThis: f_1283_42226_42246(), args: emptyArray);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 39361, 42294);

                System.Management.Automation.InvocationInfo
                f_1283_40021_40038(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 40021, 40038);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>
                f_1283_40021_40054(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 40021, 40054);
                    return return_v;
                }


                bool
                f_1283_40271_40324(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key, out object
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 40271, 40324);
                    return return_v;
                }


                bool
                f_1283_40444_40498(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key, out object
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 40444, 40498);
                    return return_v;
                }


                string
                f_1283_40695_40750()
                {
                    var return_v = InternalCommandStrings.NoShouldProcessForScriptBlockSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 40695, 40750);
                    return return_v;
                }


                System.InvalidOperationException
                f_1283_40843_40881(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 40843, 40881);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_40801_41031(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 40801, 41031);
                    return return_v;
                }


                int
                f_1283_41054_41088(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 41054, 41088);
                    return 0;
                }


                int
                f_1283_41234_41248(System.Collections.Generic.List<System.Management.Automation.ScriptBlock>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 41234, 41248);
                    return return_v;
                }


                int
                f_1283_41272_41286(System.Collections.Generic.List<System.Management.Automation.ScriptBlock>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 41272, 41286);
                    return return_v;
                }


                int
                f_1283_41462_41476(System.Collections.Generic.List<System.Management.Automation.ScriptBlock>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 41462, 41476);
                    return return_v;
                }


                int
                f_1283_41529_41543(System.Collections.Generic.List<System.Management.Automation.ScriptBlock>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 41529, 41543);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1283_41583_41597(System.Collections.Generic.List<System.Management.Automation.ScriptBlock>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 41583, 41597);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1283_41788_41799(System.Collections.Generic.List<System.Management.Automation.ScriptBlock>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 41788, 41799);
                    return return_v;
                }


                object[]
                f_1283_41866_41887()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 41866, 41887);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1283_41902_41913(System.Collections.Generic.List<System.Management.Automation.ScriptBlock>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 41902, 41913);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1283_42139_42159()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 42139, 42159);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1283_42226_42246()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 42226, 42246);
                    return return_v;
                }


                int
                f_1283_41902_42282(System.Management.Automation.ScriptBlock
                this_param, Microsoft.PowerShell.Commands.ForEachObjectCommand
                contextCmdlet, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, object[]
                input, System.Management.Automation.PSObject
                scriptThis, object[]
                args)
                {
                    this_param.InvokeUsingCmdlet(contextCmdlet: (System.Management.Automation.Cmdlet)contextCmdlet, useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 41902, 42282);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 39361, 42294);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 39361, 42294);
            }
        }

        private void MethodCallWithArguments()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 42403, 45599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 42499, 42725);

                ReadOnlyPSMemberInfoCollection<PSMemberInfo>
                methods =
                f_1283_42571_42724(f_1283_42571_42591(_inputObject), _propertyOrMethodName, PSMemberTypes.Methods | PSMemberTypes.ParameterizedProperty)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 42741, 42828);

                f_1283_42741_42827(methods != null, "The return value of Members.Match should never be null.");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 42842, 45588) || true) && (f_1283_42846_42859(methods) > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 42842, 45588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 42954, 43006);

                    StringBuilder
                    possibleMatches = f_1283_42986_43005()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 43024, 43200);
                        foreach (PSMemberInfo item in f_1283_43054_43061_I(methods))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 43024, 43200);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 43103, 43181);

                            f_1283_43103_43180(possibleMatches, f_1283_43132_43160(), " {0}", f_1283_43170_43179(item));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 43024, 43200);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1283, 1, 177);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1283, 1, 177);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 43220, 43515);

                    f_1283_43220_43514(this, f_1283_43231_43513("Name", f_1283_43309_43351(), "AmbiguousMethodName", _inputObject, _propertyOrMethodName, possibleMatches));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 42842, 45588);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 42842, 45588);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 43549, 45588) || true) && (f_1283_43553_43566(methods) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(1283, 43553, 43604) || !(f_1283_43577_43587(methods, 0) is PSMethodInfo)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 43549, 45588);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 43694, 43941);

                        f_1283_43694_43940(this, f_1283_43705_43939("Name", f_1283_43783_43820(), "MethodNotFound", _inputObject, _propertyOrMethodName));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 43549, 45588);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 43549, 45588);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 44007, 44062);

                        PSMethodInfo
                        targetMethod = f_1283_44035_44045(methods, 0) as PSMethodInfo
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 44080, 44154);

                        f_1283_44080_44153(targetMethod != null, "targetMethod should not be null here.");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 44209, 44291);

                        StringBuilder
                        arglist = f_1283_44233_44290(f_1283_44251_44289(_arguments[0]))
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 44318, 44323);
                            for (int
            i = 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 44309, 44512) || true) && (i < f_1283_44329_44346(_arguments))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 44348, 44351)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 44309, 44512))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 44309, 44512);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 44393, 44493);

                                f_1283_44393_44492(arglist, f_1283_44414_44442(), ", {0}", f_1283_44453_44491(_arguments[i]));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1283, 1, 204);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1283, 1, 204);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 44532, 44731);

                        string
                        methodAction = f_1283_44554_44730(f_1283_44568_44596(), f_1283_44619_44680(), f_1283_44703_44720(targetMethod), arglist)
                        ;

                        try
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 44795, 45157) || true) && (f_1283_44799_44841(this, _targetString, methodAction))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 44795, 45157);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 44891, 45134) || true) && (!f_1283_44896_44934(this, f_1283_44922_44933()))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 44891, 45134);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 44992, 45040);

                                    object
                                    result = f_1283_45008_45039(targetMethod, _arguments)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 45070, 45107);

                                    f_1283_45070_45106(this, result);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 44891, 45134);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 44795, 45157);
                            }
                        }
                        catch (PipelineStoppedException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1283, 45194, 45372);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 45347, 45353);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1283, 45194, 45372);
                        }
                        catch (Exception ex)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1283, 45390, 45573);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 45451, 45554);

                            f_1283_45451_45553(this, f_1283_45462_45552(ex, "MethodInvocationError", ErrorCategory.InvalidOperation, _inputObject));
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1283, 45390, 45573);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 43549, 45588);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 42842, 45588);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 42403, 45599);

                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1283_42571_42591(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 42571, 42591);
                    return return_v;
                }


                System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1283_42571_42724(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, string
                name, System.Management.Automation.PSMemberTypes
                memberTypes)
                {
                    var return_v = this_param.Match(name, memberTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 42571, 42724);
                    return return_v;
                }


                int
                f_1283_42741_42827(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 42741, 42827);
                    return 0;
                }


                int
                f_1283_42846_42859(System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 42846, 42859);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1283_42986_43005()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 42986, 43005);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1283_43132_43160()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 43132, 43160);
                    return return_v;
                }


                string
                f_1283_43170_43179(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 43170, 43179);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1283_43103_43180(System.Text.StringBuilder
                this_param, System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 43103, 43180);
                    return return_v;
                }


                System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1283_43054_43061_I(System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 43054, 43061);
                    return return_v;
                }


                string
                f_1283_43309_43351()
                {
                    var return_v = InternalCommandStrings.AmbiguousMethodName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 43309, 43351);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_43231_43513(string
                paraName, string
                resourceString, string
                errorId, System.Management.Automation.PSObject
                target, params object[]
                args)
                {
                    var return_v = GenerateNameParameterError(paraName, resourceString, errorId, (object)target, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 43231, 43513);
                    return return_v;
                }


                int
                f_1283_43220_43514(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 43220, 43514);
                    return 0;
                }


                int
                f_1283_43553_43566(System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 43553, 43566);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1283_43577_43587(System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 43577, 43587);
                    return return_v;
                }


                string
                f_1283_43783_43820()
                {
                    var return_v = InternalCommandStrings.MethodNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 43783, 43820);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_43705_43939(string
                paraName, string
                resourceString, string
                errorId, System.Management.Automation.PSObject
                target, params object[]
                args)
                {
                    var return_v = GenerateNameParameterError(paraName, resourceString, errorId, (object)target, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 43705, 43939);
                    return return_v;
                }


                int
                f_1283_43694_43940(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 43694, 43940);
                    return 0;
                }


                System.Management.Automation.PSMemberInfo
                f_1283_44035_44045(System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 44035, 44045);
                    return return_v;
                }


                int
                f_1283_44080_44153(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 44080, 44153);
                    return 0;
                }


                string
                f_1283_44251_44289(object
                obj)
                {
                    var return_v = GetStringRepresentation(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 44251, 44289);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1283_44233_44290(string
                value)
                {
                    var return_v = new System.Text.StringBuilder(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 44233, 44290);
                    return return_v;
                }


                int
                f_1283_44329_44346(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 44329, 44346);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1283_44414_44442()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 44414, 44442);
                    return return_v;
                }


                string
                f_1283_44453_44491(object
                obj)
                {
                    var return_v = GetStringRepresentation(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 44453, 44491);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1283_44393_44492(System.Text.StringBuilder
                this_param, System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 44393, 44492);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1283_44568_44596()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 44568, 44596);
                    return return_v;
                }


                string
                f_1283_44619_44680()
                {
                    var return_v = InternalCommandStrings.ForEachObjectMethodActionWithArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 44619, 44680);
                    return return_v;
                }


                string
                f_1283_44703_44720(System.Management.Automation.PSMethodInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 44703, 44720);
                    return return_v;
                }


                string
                f_1283_44554_44730(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, System.Text.StringBuilder
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 44554, 44730);
                    return return_v;
                }


                bool
                f_1283_44799_44841(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, string
                target, string
                action)
                {
                    var return_v = this_param.ShouldProcess(target, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 44799, 44841);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1283_44922_44933()
                {
                    var return_v = InputObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 44922, 44933);
                    return return_v;
                }


                bool
                f_1283_44896_44934(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, System.Management.Automation.PSObject
                inputObject)
                {
                    var return_v = this_param.BlockMethodInLanguageMode((object)inputObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 44896, 44934);
                    return return_v;
                }


                object
                f_1283_45008_45039(System.Management.Automation.PSMethodInfo
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.Invoke(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 45008, 45039);
                    return return_v;
                }


                int
                f_1283_45070_45106(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, object
                obj)
                {
                    this_param.WriteToPipelineWithUnrolling(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 45070, 45106);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1283_45462_45552(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.PSObject
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 45462, 45552);
                    return return_v;
                }


                int
                f_1283_45451_45553(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 45451, 45553);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 42403, 45599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 42403, 45599);
            }
        }

        private static string GetStringRepresentation(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1283, 45856, 46545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 45938, 45957);

                string
                objInString
                = default(string);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 46076, 46147);

                    objInString = (DynAbs.Tracing.TraceSender.Conditional_F1(1283, 46090, 46120) || ((f_1283_46090_46120(obj) && DynAbs.Tracing.TraceSender.Conditional_F2(1283, 46123, 46129)) || DynAbs.Tracing.TraceSender.Conditional_F3(1283, 46132, 46146))) ? "null" : f_1283_46132_46146(obj);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1283, 46176, 46260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 46226, 46245);

                    objInString = null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1283, 46176, 46260);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 46276, 46499) || true) && (f_1283_46280_46313(objInString))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 46276, 46499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 46347, 46375);

                    var
                    psobj = obj as PSObject
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 46393, 46484);

                    objInString = (DynAbs.Tracing.TraceSender.Conditional_F1(1283, 46407, 46420) || ((psobj != null && DynAbs.Tracing.TraceSender.Conditional_F2(1283, 46423, 46458)) || DynAbs.Tracing.TraceSender.Conditional_F3(1283, 46461, 46483))) ? f_1283_46423_46458(f_1283_46423_46449(f_1283_46423_46439(psobj))) : f_1283_46461_46483(f_1283_46461_46474(obj));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 46276, 46499);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 46515, 46534);

                return objInString;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1283, 45856, 46545);

                bool
                f_1283_46090_46120(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsNull(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 46090, 46120);
                    return return_v;
                }


                string?
                f_1283_46132_46146(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 46132, 46146);
                    return return_v;
                }


                bool
                f_1283_46280_46313(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 46280, 46313);
                    return return_v;
                }


                object
                f_1283_46423_46439(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 46423, 46439);
                    return return_v;
                }


                System.Type
                f_1283_46423_46449(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 46423, 46449);
                    return return_v;
                }


                string
                f_1283_46423_46458(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 46423, 46458);
                    return return_v;
                }


                System.Type
                f_1283_46461_46474(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 46461, 46474);
                    return return_v;
                }


                string
                f_1283_46461_46483(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 46461, 46483);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 45856, 46545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 45856, 46545);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool GetValueFromIDictionaryInput()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 46775, 47886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 46843, 46887);

                object
                target = f_1283_46859_46886(_inputObject)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 46901, 46942);

                IDictionary
                hash = target as IDictionary
                ;

                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 46994, 47601) || true) && (hash != null && (DynAbs.Tracing.TraceSender.Expression_True(1283, 46998, 47050) && f_1283_47014_47050(hash, _propertyOrMethodName)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 46994, 47601);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 47092, 47301);

                        string
                        keyAction = f_1283_47111_47300(f_1283_47151_47179(), f_1283_47206_47251(), _propertyOrMethodName)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 47323, 47546) || true) && (f_1283_47327_47366(this, _targetString, keyAction))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 47323, 47546);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 47416, 47460);

                            object
                            result = f_1283_47432_47459(hash, _propertyOrMethodName)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 47486, 47523);

                            f_1283_47486_47522(this, result);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 47323, 47546);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 47570, 47582);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 46994, 47601);
                    }
                }
                catch (InvalidOperationException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1283, 47630, 47846);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1283, 47630, 47846);
                    // Ignore invalid operation exception, it can happen if the dictionary
                    // has keys that can't be compared to property.
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 47862, 47875);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 46775, 47886);

                object
                f_1283_46859_46886(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = PSObject.Base((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 46859, 46886);
                    return return_v;
                }


                bool
                f_1283_47014_47050(System.Collections.IDictionary
                this_param, string
                key)
                {
                    var return_v = this_param.Contains((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 47014, 47050);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1283_47151_47179()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 47151, 47179);
                    return return_v;
                }


                string
                f_1283_47206_47251()
                {
                    var return_v = InternalCommandStrings.ForEachObjectKeyAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 47206, 47251);
                    return return_v;
                }


                string
                f_1283_47111_47300(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 47111, 47300);
                    return return_v;
                }


                bool
                f_1283_47327_47366(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, string
                target, string
                action)
                {
                    var return_v = this_param.ShouldProcess(target, action);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 47327, 47366);
                    return return_v;
                }


                object
                f_1283_47432_47459(System.Collections.IDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 47432, 47459);
                    return return_v;
                }


                int
                f_1283_47486_47522(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, object
                obj)
                {
                    this_param.WriteToPipelineWithUnrolling(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 47486, 47522);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 46775, 47886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 46775, 47886);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void WriteToPipelineWithUnrolling(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 48207, 48580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 48285, 48353);

                IEnumerator
                objAsEnumerator = f_1283_48315_48352(obj)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 48367, 48569) || true) && (objAsEnumerator != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 48367, 48569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 48428, 48465);

                    f_1283_48428_48464(this, objAsEnumerator);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 48367, 48569);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 48367, 48569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 48531, 48554);

                    f_1283_48531_48553(this, obj, true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 48367, 48569);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 48207, 48580);

                System.Collections.IEnumerator
                f_1283_48315_48352(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerator(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 48315, 48352);
                    return return_v;
                }


                int
                f_1283_48428_48464(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, System.Collections.IEnumerator
                list)
                {
                    this_param.WriteOutIEnumerator(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 48428, 48464);
                    return 0;
                }


                int
                f_1283_48531_48553(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, object
                sendToPipeline, bool
                enumerateCollection)
                {
                    this_param.WriteObject(sendToPipeline, enumerateCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 48531, 48553);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 48207, 48580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 48207, 48580);
            }
        }

        private void WriteOutIEnumerator(IEnumerator list)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 48751, 49202);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 48826, 49191) || true) && (list != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 48826, 49191);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 48876, 49176) || true) && (f_1283_48883_48927(f_1283_48902_48914(this), null, list))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 48876, 49176);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 48969, 49012);

                            object
                            val = f_1283_48982_49011(null, list)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 49036, 49157) || true) && (val != f_1283_49047_49067())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 49036, 49157);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 49117, 49134);

                                f_1283_49117_49133(this, val);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 49036, 49157);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 48876, 49176);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1283, 48876, 49176);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1283, 48876, 49176);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 48826, 49191);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 48751, 49202);

                System.Management.Automation.ExecutionContext
                f_1283_48902_48914(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 48902, 48914);
                    return return_v;
                }


                bool
                f_1283_48883_48927(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Language.IScriptExtent
                errorPosition, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = ParserOps.MoveNext(context, errorPosition, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 48883, 48927);
                    return return_v;
                }


                object
                f_1283_48982_49011(System.Management.Automation.Language.IScriptExtent
                errorPosition, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = ParserOps.Current(errorPosition, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 48982, 49011);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1283_49047_49067()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 49047, 49067);
                    return return_v;
                }


                int
                f_1283_49117_49133(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, object
                sendToPipeline)
                {
                    this_param.WriteObject(sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 49117, 49133);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 48751, 49202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 48751, 49202);
            }
        }

        private bool BlockMethodInLanguageMode(object inputObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 49583, 50921);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 49732, 50175) || true) && (f_1283_49736_49756(f_1283_49736_49743()) == PSLanguageMode.RestrictedLanguage)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 49732, 50175);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 49827, 49987);

                    PSInvalidOperationException
                    exception =
                    f_1283_49888_49986(f_1283_49920_49985())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 50007, 50130);

                    f_1283_50007_50129(this, f_1283_50018_50128(exception, "NoMethodInvocationInRestrictedLanguageMode", ErrorCategory.InvalidOperation, null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 50148, 50160);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 49732, 50175);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 50265, 50881) || true) && (f_1283_50269_50289(f_1283_50269_50276()) == PSLanguageMode.ConstrainedLanguage)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 50265, 50881);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 50361, 50408);

                    object
                    baseObject = f_1283_50381_50407(inputObject)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 50428, 50866) || true) && (!f_1283_50433_50473(f_1283_50452_50472(baseObject)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 50428, 50866);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 50515, 50659);

                        PSInvalidOperationException
                        exception =
                        f_1283_50580_50658(f_1283_50612_50657())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 50683, 50813);

                        f_1283_50683_50812(this, f_1283_50694_50811(exception, "MethodInvocationNotSupportedInConstrainedLanguage", ErrorCategory.InvalidOperation, null));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 50835, 50847);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 50428, 50866);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 50265, 50881);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 50897, 50910);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 49583, 50921);

                System.Management.Automation.ExecutionContext
                f_1283_49736_49743()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 49736, 49743);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1283_49736_49756(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 49736, 49756);
                    return return_v;
                }


                string
                f_1283_49920_49985()
                {
                    var return_v = InternalCommandStrings.NoMethodInvocationInRestrictedLanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 49920, 49985);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1283_49888_49986(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 49888, 49986);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_50018_50128(System.Management.Automation.PSInvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 50018, 50128);
                    return return_v;
                }


                int
                f_1283_50007_50129(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 50007, 50129);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1283_50269_50276()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 50269, 50276);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1283_50269_50289(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 50269, 50289);
                    return return_v;
                }


                object
                f_1283_50381_50407(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 50381, 50407);
                    return return_v;
                }


                System.Type
                f_1283_50452_50472(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 50452, 50472);
                    return return_v;
                }


                bool
                f_1283_50433_50473(System.Type
                inputType)
                {
                    var return_v = CoreTypes.Contains(inputType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 50433, 50473);
                    return return_v;
                }


                string
                f_1283_50612_50657()
                {
                    var return_v = ParserStrings.InvokeMethodConstrainedLanguage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 50612, 50657);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1283_50580_50658(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 50580, 50658);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_50694_50811(System.Management.Automation.PSInvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 50694, 50811);
                    return return_v;
                }


                int
                f_1283_50683_50812(Microsoft.PowerShell.Commands.ForEachObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 50683, 50812);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 49583, 50921);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 49583, 50921);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ErrorRecord GenerateNameParameterError(string paraName, string resourceString, string errorId, object target, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1283, 51311, 52259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 51483, 51498);

                string
                message
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 51512, 51820) || true) && (args == null || (DynAbs.Tracing.TraceSender.Expression_False(1283, 51516, 51548) || 0 == f_1283_51537_51548(args)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 51512, 51820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 51664, 51689);

                    message = resourceString;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 51512, 51820);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 51512, 51820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 51755, 51805);

                    message = f_1283_51765_51804(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 51512, 51820);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 51836, 51994) || true) && (f_1283_51840_51869(message))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 51836, 51994);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 51903, 51979);

                    f_1283_51903_51978(false, "Could not load text for error record '" + errorId + "'");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 51836, 51994);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 52010, 52213);

                ErrorRecord
                errorRecord = f_1283_52036_52212(f_1283_52070_52112(message, paraName), errorId, ErrorCategory.InvalidArgument, target)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 52229, 52248);

                return errorRecord;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1283, 51311, 52259);

                int
                f_1283_51537_51548(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 51537, 51548);
                    return return_v;
                }


                string
                f_1283_51765_51804(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 51765, 51804);
                    return return_v;
                }


                bool
                f_1283_51840_51869(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 51840, 51869);
                    return return_v;
                }


                int
                f_1283_51903_51978(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 51903, 51978);
                    return 0;
                }


                System.Management.Automation.PSArgumentException
                f_1283_52070_52112(string
                message, string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 52070, 52112);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_52036_52212(System.Management.Automation.PSArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 52036, 52212);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 51311, 52259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 51311, 52259);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ForEachObjectCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1283, 2357, 52266);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 3641, 3676);
            this._inputObject = f_1283_3656_3676();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 3771, 3805);
            this._scripts = f_1283_3782_3805();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 4935, 4945);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 4969, 4982);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 6167, 6173);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 6175, 6179);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 6815, 6836);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 6862, 6875);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 7382, 7392);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 7621, 7763);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 7963, 8133);
            this.ThrottleLimit = 5;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 8362, 8537);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 12457, 12466);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 12508, 12529);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 12575, 12590);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 12615, 12625);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 12654, 12662);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 12743, 12758);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 12787, 12811);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 12837, 12857);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1283, 2357, 52266);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 2357, 52266);
        }


        static ForEachObjectCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1283, 2357, 52266);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 2782, 2827);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 2859, 2892);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 2924, 2969);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1283, 2357, 52266);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 2357, 52266);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1283, 2357, 52266);

        System.Management.Automation.PSObject
        f_1283_3656_3676()
        {
            var return_v = AutomationNull.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 3656, 3676);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.ScriptBlock>
        f_1283_3782_3805()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.ScriptBlock>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 3782, 3805);
            return return_v;
        }

    }
    [Cmdlet("Where", "Object", DefaultParameterSetName = "EqualSet",
            HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096806", RemotingCapability = RemotingCapability.None)]
    public sealed class WhereObjectCommand : PSCmdlet
    {
        [Parameter(ValueFromPipeline = true)]
        public PSObject InputObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 52998, 53069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 53034, 53054);

                    return _inputObject;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 52998, 53069);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 52899, 53168);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 52899, 53168);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 53085, 53157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 53121, 53142);

                    _inputObject = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 53085, 53157);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 52899, 53168);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 52899, 53168);
                }
            }
        }

        private PSObject _inputObject;

        private ScriptBlock _script;

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ScriptBlockSet")]
        public ScriptBlock FilterScript
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 53529, 53595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 53565, 53580);

                    return _script;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 53529, 53595);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 53383, 53689);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 53383, 53689);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 53611, 53678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 53647, 53663);

                    _script = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 53611, 53678);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 53383, 53689);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 53383, 53689);
                }
            }
        }

        private string _property;

        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "EqualSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "CaseSensitiveEqualSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "NotEqualSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "CaseSensitiveNotEqualSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "GreaterThanSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "CaseSensitiveGreaterThanSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "LessThanSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "CaseSensitiveLessThanSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "GreaterOrEqualSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "CaseSensitiveGreaterOrEqualSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "LessOrEqualSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "CaseSensitiveLessOrEqualSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "LikeSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "CaseSensitiveLikeSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "NotLikeSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "CaseSensitiveNotLikeSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "MatchSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "CaseSensitiveMatchSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "NotMatchSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "CaseSensitiveNotMatchSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "ContainsSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "CaseSensitiveContainsSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "NotContainsSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "CaseSensitiveNotContainsSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "InSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "CaseSensitiveInSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "NotInSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "CaseSensitiveNotInSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "IsSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "IsNotSet")]
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "Not")]
        [ValidateNotNullOrEmpty]
        public string Property
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 56776, 56844);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 56812, 56829);

                    return _property;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 56776, 56844);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 53843, 56940);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 53843, 56940);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 56860, 56929);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 56896, 56914);

                    _property = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 56860, 56929);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 53843, 56940);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 53843, 56940);
                }
            }
        }

        private object _convertedValue;

        private object _value;

        private bool _valueNotSpecified;

        [Parameter(Position = 1, ParameterSetName = "EqualSet")]
        [Parameter(Position = 1, ParameterSetName = "CaseSensitiveEqualSet")]
        [Parameter(Position = 1, ParameterSetName = "NotEqualSet")]
        [Parameter(Position = 1, ParameterSetName = "CaseSensitiveNotEqualSet")]
        [Parameter(Position = 1, ParameterSetName = "GreaterThanSet")]
        [Parameter(Position = 1, ParameterSetName = "CaseSensitiveGreaterThanSet")]
        [Parameter(Position = 1, ParameterSetName = "LessThanSet")]
        [Parameter(Position = 1, ParameterSetName = "CaseSensitiveLessThanSet")]
        [Parameter(Position = 1, ParameterSetName = "GreaterOrEqualSet")]
        [Parameter(Position = 1, ParameterSetName = "CaseSensitiveGreaterOrEqualSet")]
        [Parameter(Position = 1, ParameterSetName = "LessOrEqualSet")]
        [Parameter(Position = 1, ParameterSetName = "CaseSensitiveLessOrEqualSet")]
        [Parameter(Position = 1, ParameterSetName = "LikeSet")]
        [Parameter(Position = 1, ParameterSetName = "CaseSensitiveLikeSet")]
        [Parameter(Position = 1, ParameterSetName = "NotLikeSet")]
        [Parameter(Position = 1, ParameterSetName = "CaseSensitiveNotLikeSet")]
        [Parameter(Position = 1, ParameterSetName = "MatchSet")]
        [Parameter(Position = 1, ParameterSetName = "CaseSensitiveMatchSet")]
        [Parameter(Position = 1, ParameterSetName = "NotMatchSet")]
        [Parameter(Position = 1, ParameterSetName = "CaseSensitiveNotMatchSet")]
        [Parameter(Position = 1, ParameterSetName = "ContainsSet")]
        [Parameter(Position = 1, ParameterSetName = "CaseSensitiveContainsSet")]
        [Parameter(Position = 1, ParameterSetName = "NotContainsSet")]
        [Parameter(Position = 1, ParameterSetName = "CaseSensitiveNotContainsSet")]
        [Parameter(Position = 1, ParameterSetName = "InSet")]
        [Parameter(Position = 1, ParameterSetName = "CaseSensitiveInSet")]
        [Parameter(Position = 1, ParameterSetName = "NotInSet")]
        [Parameter(Position = 1, ParameterSetName = "CaseSensitiveNotInSet")]
        [Parameter(Position = 1, ParameterSetName = "IsSet")]
        [Parameter(Position = 1, ParameterSetName = "IsNotSet")]
        public object Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 59450, 59515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 59486, 59500);

                    return _value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 59450, 59515);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 57173, 59653);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 57173, 59653);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 59531, 59642);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 59567, 59582);

                    _value = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 59600, 59627);

                    _valueNotSpecified = false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 59531, 59642);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 57173, 59653);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 57173, 59653);
                }
            }
        }

        private TokenKind _binaryOperator;

        private bool _forceBooleanEvaluation;

        [Parameter(ParameterSetName = "EqualSet")]
        [Alias("IEQ")]
        public SwitchParameter EQ
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 60261, 60352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 60297, 60337);

                    return _binaryOperator == TokenKind.Ieq;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 60261, 60352);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 60135, 60512);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 60135, 60512);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 60368, 60501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 60404, 60436);

                    _binaryOperator = TokenKind.Ieq;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 60454, 60486);

                    _forceBooleanEvaluation = false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 60368, 60501);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 60135, 60512);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 60135, 60512);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "CaseSensitiveEqualSet")]
        public SwitchParameter CEQ
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 60768, 60859);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 60804, 60844);

                    return _binaryOperator == TokenKind.Ceq;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 60768, 60859);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 60634, 60969);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 60634, 60969);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 60875, 60958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 60911, 60943);

                    _binaryOperator = TokenKind.Ceq;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 60875, 60958);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 60634, 60969);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 60634, 60969);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "NotEqualSet")]
        [Alias("INE")]
        public SwitchParameter NE
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 61228, 61319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 61264, 61304);

                    return _binaryOperator == TokenKind.Ine;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 61228, 61319);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 61081, 61429);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 61081, 61429);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 61335, 61418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 61371, 61403);

                    _binaryOperator = TokenKind.Ine;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 61335, 61418);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 61081, 61429);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 61081, 61429);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "CaseSensitiveNotEqualSet")]
        public SwitchParameter CNE
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 61688, 61779);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 61724, 61764);

                    return _binaryOperator == TokenKind.Cne;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 61688, 61779);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 61551, 61889);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 61551, 61889);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 61795, 61878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 61831, 61863);

                    _binaryOperator = TokenKind.Cne;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 61795, 61878);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 61551, 61889);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 61551, 61889);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "GreaterThanSet")]
        [Alias("IGT")]
        public SwitchParameter GT
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 62154, 62245);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 62190, 62230);

                    return _binaryOperator == TokenKind.Igt;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 62154, 62245);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 62004, 62355);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 62004, 62355);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 62261, 62344);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 62297, 62329);

                    _binaryOperator = TokenKind.Igt;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 62261, 62344);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 62004, 62355);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 62004, 62355);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "CaseSensitiveGreaterThanSet")]
        public SwitchParameter CGT
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 62617, 62708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 62653, 62693);

                    return _binaryOperator == TokenKind.Cgt;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 62617, 62708);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 62477, 62818);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 62477, 62818);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 62724, 62807);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 62760, 62792);

                    _binaryOperator = TokenKind.Cgt;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 62724, 62807);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 62477, 62818);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 62477, 62818);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "LessThanSet")]
        [Alias("ILT")]
        public SwitchParameter LT
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 63077, 63168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 63113, 63153);

                    return _binaryOperator == TokenKind.Ilt;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 63077, 63168);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 62930, 63278);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 62930, 63278);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 63184, 63267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 63220, 63252);

                    _binaryOperator = TokenKind.Ilt;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 63184, 63267);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 62930, 63278);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 62930, 63278);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "CaseSensitiveLessThanSet")]
        public SwitchParameter CLT
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 63535, 63626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 63571, 63611);

                    return _binaryOperator == TokenKind.Clt;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 63535, 63626);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 63398, 63736);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 63398, 63736);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 63642, 63725);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 63678, 63710);

                    _binaryOperator = TokenKind.Clt;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 63642, 63725);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 63398, 63736);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 63398, 63736);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "GreaterOrEqualSet")]
        [Alias("IGE")]
        public SwitchParameter GE
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 64007, 64098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 64043, 64083);

                    return _binaryOperator == TokenKind.Ige;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 64007, 64098);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 63854, 64208);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 63854, 64208);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 64114, 64197);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 64150, 64182);

                    _binaryOperator = TokenKind.Ige;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 64114, 64197);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 63854, 64208);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 63854, 64208);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "CaseSensitiveGreaterOrEqualSet")]
        public SwitchParameter CGE
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 64473, 64564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 64509, 64549);

                    return _binaryOperator == TokenKind.Cge;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 64473, 64564);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 64330, 64674);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 64330, 64674);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 64580, 64663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 64616, 64648);

                    _binaryOperator = TokenKind.Cge;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 64580, 64663);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 64330, 64674);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 64330, 64674);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "LessOrEqualSet")]
        [Alias("ILE")]
        public SwitchParameter LE
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 64939, 65030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 64975, 65015);

                    return _binaryOperator == TokenKind.Ile;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 64939, 65030);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 64789, 65140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 64789, 65140);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 65046, 65129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 65082, 65114);

                    _binaryOperator = TokenKind.Ile;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 65046, 65129);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 64789, 65140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 64789, 65140);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "CaseSensitiveLessOrEqualSet")]
        public SwitchParameter CLE
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 65402, 65493);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 65438, 65478);

                    return _binaryOperator == TokenKind.Cle;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 65402, 65493);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 65262, 65603);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 65262, 65603);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 65509, 65592);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 65545, 65577);

                    _binaryOperator = TokenKind.Cle;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 65509, 65592);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 65262, 65603);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 65262, 65603);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "LikeSet")]
        [Alias("ILike")]
        public SwitchParameter Like
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 65857, 65950);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 65893, 65935);

                    return _binaryOperator == TokenKind.Ilike;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 65857, 65950);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 65710, 66062);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 65710, 66062);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 65966, 66051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 66002, 66036);

                    _binaryOperator = TokenKind.Ilike;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 65966, 66051);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 65710, 66062);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 65710, 66062);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "CaseSensitiveLikeSet")]
        public SwitchParameter CLike
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 66321, 66414);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 66357, 66399);

                    return _binaryOperator == TokenKind.Clike;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 66321, 66414);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 66186, 66526);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 66186, 66526);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 66430, 66515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 66466, 66500);

                    _binaryOperator = TokenKind.Clike;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 66430, 66515);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 66186, 66526);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 66186, 66526);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "NotLikeSet")]
        [Alias("INotLike")]
        public SwitchParameter NotLike
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 66793, 66857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 66829, 66842);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 66793, 66857);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 66637, 66972);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 66637, 66972);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 66873, 66961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 66909, 66946);

                    _binaryOperator = TokenKind.Inotlike;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 66873, 66961);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 66637, 66972);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 66637, 66972);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "CaseSensitiveNotLikeSet")]
        public SwitchParameter CNotLike
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 67240, 67336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 67276, 67321);

                    return _binaryOperator == TokenKind.Cnotlike;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 67240, 67336);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 67099, 67451);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 67099, 67451);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 67352, 67440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 67388, 67425);

                    _binaryOperator = TokenKind.Cnotlike;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 67352, 67440);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 67099, 67451);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 67099, 67451);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "MatchSet")]
        [Alias("IMatch")]
        public SwitchParameter Match
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 67709, 67803);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 67745, 67788);

                    return _binaryOperator == TokenKind.Imatch;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 67709, 67803);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 67559, 67916);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 67559, 67916);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 67819, 67905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 67855, 67890);

                    _binaryOperator = TokenKind.Imatch;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 67819, 67905);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 67559, 67916);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 67559, 67916);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "CaseSensitiveMatchSet")]
        public SwitchParameter CMatch
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 68178, 68272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 68214, 68257);

                    return _binaryOperator == TokenKind.Cmatch;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 68178, 68272);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 68041, 68385);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 68041, 68385);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 68288, 68374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 68324, 68359);

                    _binaryOperator = TokenKind.Cmatch;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 68288, 68374);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 68041, 68385);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 68041, 68385);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "NotMatchSet")]
        [Alias("INotMatch")]
        public SwitchParameter NotMatch
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 68656, 68753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 68692, 68738);

                    return _binaryOperator == TokenKind.Inotmatch;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 68656, 68753);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 68497, 68869);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 68497, 68869);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 68769, 68858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 68805, 68843);

                    _binaryOperator = TokenKind.Inotmatch;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 68769, 68858);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 68497, 68869);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 68497, 68869);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "CaseSensitiveNotMatchSet")]
        public SwitchParameter CNotMatch
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 69140, 69237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 69176, 69222);

                    return _binaryOperator == TokenKind.Cnotmatch;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 69140, 69237);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 68997, 69353);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 68997, 69353);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 69253, 69342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 69289, 69327);

                    _binaryOperator = TokenKind.Cnotmatch;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 69253, 69342);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 68997, 69353);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 68997, 69353);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "ContainsSet")]
        [Alias("IContains")]
        public SwitchParameter Contains
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 69624, 69721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 69660, 69706);

                    return _binaryOperator == TokenKind.Icontains;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 69624, 69721);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 69465, 69837);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 69465, 69837);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 69737, 69826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 69773, 69811);

                    _binaryOperator = TokenKind.Icontains;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 69737, 69826);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 69465, 69837);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 69465, 69837);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "CaseSensitiveContainsSet")]
        public SwitchParameter CContains
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 70108, 70205);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 70144, 70190);

                    return _binaryOperator == TokenKind.Ccontains;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 70108, 70205);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 69965, 70321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 69965, 70321);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 70221, 70310);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 70257, 70295);

                    _binaryOperator = TokenKind.Ccontains;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 70221, 70310);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 69965, 70321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 69965, 70321);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "NotContainsSet")]
        [Alias("INotContains")]
        public SwitchParameter NotContains
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 70604, 70704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 70640, 70689);

                    return _binaryOperator == TokenKind.Inotcontains;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 70604, 70704);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 70436, 70823);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 70436, 70823);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 70720, 70812);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 70756, 70797);

                    _binaryOperator = TokenKind.Inotcontains;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 70720, 70812);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 70436, 70823);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 70436, 70823);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "CaseSensitiveNotContainsSet")]
        public SwitchParameter CNotContains
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 71103, 71203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 71139, 71188);

                    return _binaryOperator == TokenKind.Cnotcontains;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 71103, 71203);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 70954, 71322);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 70954, 71322);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 71219, 71311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 71255, 71296);

                    _binaryOperator = TokenKind.Cnotcontains;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 71219, 71311);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 70954, 71322);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 70954, 71322);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "InSet")]
        [Alias("IIn")]
        public SwitchParameter In
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 71569, 71659);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 71605, 71644);

                    return _binaryOperator == TokenKind.In;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 71569, 71659);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 71428, 71768);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 71428, 71768);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 71675, 71757);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 71711, 71742);

                    _binaryOperator = TokenKind.In;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 71675, 71757);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 71428, 71768);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 71428, 71768);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "CaseSensitiveInSet")]
        public SwitchParameter CIn
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 72021, 72112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 72057, 72097);

                    return _binaryOperator == TokenKind.Cin;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 72021, 72112);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 71890, 72222);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 71890, 72222);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 72128, 72211);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 72164, 72196);

                    _binaryOperator = TokenKind.Cin;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 72128, 72211);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 71890, 72222);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 71890, 72222);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "NotInSet")]
        [Alias("INotIn")]
        public SwitchParameter NotIn
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 72481, 72575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 72517, 72560);

                    return _binaryOperator == TokenKind.Inotin;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 72481, 72575);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 72331, 72688);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 72331, 72688);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 72591, 72677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 72627, 72662);

                    _binaryOperator = TokenKind.Inotin;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 72591, 72677);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 72331, 72688);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 72331, 72688);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "CaseSensitiveNotInSet")]
        public SwitchParameter CNotIn
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 72950, 73044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 72986, 73029);

                    return _binaryOperator == TokenKind.Cnotin;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 72950, 73044);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 72813, 73157);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 72813, 73157);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 73060, 73146);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 73096, 73131);

                    _binaryOperator = TokenKind.Cnotin;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 73060, 73146);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 72813, 73157);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 72813, 73157);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "IsSet")]
        public SwitchParameter Is
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 73380, 73470);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 73416, 73455);

                    return _binaryOperator == TokenKind.Is;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 73380, 73470);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 73263, 73579);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 73263, 73579);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 73486, 73568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 73522, 73553);

                    _binaryOperator = TokenKind.Is;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 73486, 73568);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 73263, 73579);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 73263, 73579);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "IsNotSet")]
        public SwitchParameter IsNot
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 73811, 73904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 73847, 73889);

                    return _binaryOperator == TokenKind.IsNot;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 73811, 73904);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 73688, 74016);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 73688, 74016);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 73920, 74005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 73956, 73990);

                    _binaryOperator = TokenKind.IsNot;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 73920, 74005);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 73688, 74016);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 73688, 74016);
                }
            }
        }

        [Parameter(Mandatory = true, ParameterSetName = "Not")]
        public SwitchParameter Not
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 74239, 74330);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 74275, 74315);

                    return _binaryOperator == TokenKind.Not;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 74239, 74330);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 74123, 74440);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 74123, 74440);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 74346, 74429);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 74382, 74414);

                    _binaryOperator = TokenKind.Not;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 74346, 74429);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 74123, 74440);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 74123, 74440);
                }
            }
        }

        private readonly CallSite<Func<CallSite, object, bool>> _toBoolSite;

        private Func<object, object, object> _operationDelegate;

        private static Func<object, object, object> GetCallSiteDelegate(ExpressionType expressionType, bool ignoreCase)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1283, 74743, 75076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 74879, 75003);

                var
                site = f_1283_74890_75002(f_1283_74946_75001(expressionType, ignoreCase))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 75017, 75065);

                return (x, y) => site.Target.Invoke(site, x, y);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1283, 74743, 75076);

                System.Management.Automation.Language.PSBinaryOperationBinder
                f_1283_74946_75001(System.Linq.Expressions.ExpressionType
                operation, bool
                ignoreCase)
                {
                    var return_v = PSBinaryOperationBinder.Get(operation, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 74946, 75001);
                    return return_v;
                }


                System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object, object>>
                f_1283_74890_75002(System.Management.Automation.Language.PSBinaryOperationBinder
                binder)
                {
                    var return_v = CallSite<Func<CallSite, object, object, object>>.Create((System.Runtime.CompilerServices.CallSiteBinder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 74890, 75002);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 74743, 75076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 74743, 75076);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Func<object, object, object> GetCallSiteDelegateBoolean(ExpressionType expressionType, bool ignoreCase)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1283, 75088, 75814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 75609, 75741);

                var
                site = f_1283_75620_75740(binder: f_1283_75684_75739(expressionType, ignoreCase))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 75755, 75803);

                return (x, y) => site.Target.Invoke(site, y, x);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1283, 75088, 75814);

                System.Management.Automation.Language.PSBinaryOperationBinder
                f_1283_75684_75739(System.Linq.Expressions.ExpressionType
                operation, bool
                ignoreCase)
                {
                    var return_v = PSBinaryOperationBinder.Get(operation, ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 75684, 75739);
                    return return_v;
                }


                System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object, object>>
                f_1283_75620_75740(System.Management.Automation.Language.PSBinaryOperationBinder
                binder)
                {
                    var return_v = CallSite<Func<CallSite, object, object, object>>.Create(binder: (System.Runtime.CompilerServices.CallSiteBinder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 75620, 75740);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 75088, 75814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 75088, 75814);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Tuple<CallSite<Func<CallSite, object, IEnumerator>>, CallSite<Func<CallSite, object, object, object>>> GetContainsCallSites(bool ignoreCase)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1283, 75826, 76389);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 76006, 76106);

                var
                enumerableSite = f_1283_76027_76105(f_1283_76080_76104())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 76120, 76315);

                var
                equalSite =
                f_1283_76153_76314(f_1283_76209_76313(ExpressionType.Equal, ignoreCase, scalarCompare: true))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 76331, 76378);

                return f_1283_76338_76377(enumerableSite, equalSite);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1283, 75826, 76389);

                System.Management.Automation.Language.PSEnumerableBinder
                f_1283_76080_76104()
                {
                    var return_v = PSEnumerableBinder.Get();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 76080, 76104);
                    return return_v;
                }


                System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, System.Collections.IEnumerator>>
                f_1283_76027_76105(System.Management.Automation.Language.PSEnumerableBinder
                binder)
                {
                    var return_v = CallSite<Func<CallSite, object, IEnumerator>>.Create((System.Runtime.CompilerServices.CallSiteBinder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 76027, 76105);
                    return return_v;
                }


                System.Management.Automation.Language.PSBinaryOperationBinder
                f_1283_76209_76313(System.Linq.Expressions.ExpressionType
                operation, bool
                ignoreCase, bool
                scalarCompare)
                {
                    var return_v = PSBinaryOperationBinder.Get(operation, ignoreCase, scalarCompare: scalarCompare);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 76209, 76313);
                    return return_v;
                }


                System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object, object>>
                f_1283_76153_76314(System.Management.Automation.Language.PSBinaryOperationBinder
                binder)
                {
                    var return_v = CallSite<Func<CallSite, object, object, object>>.Create((System.Runtime.CompilerServices.CallSiteBinder)binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 76153, 76314);
                    return return_v;
                }


                System.Tuple<System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, System.Collections.IEnumerator>>, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object, object>>>
                f_1283_76338_76377(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, System.Collections.IEnumerator>>
                item1, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object, object>>
                item2)
                {
                    var return_v = Tuple.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 76338, 76377);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 75826, 76389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 75826, 76389);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckLanguageMode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 76401, 77067);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 76458, 77056) || true) && (f_1283_76462_76524(f_1283_76462_76482(f_1283_76462_76469()), PSLanguageMode.RestrictedLanguage))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 76458, 77056);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 76558, 76768);

                    string
                    message = f_1283_76575_76767(f_1283_76611_76639(), f_1283_76662_76728(), _binaryOperator)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 76786, 76888);

                    PSInvalidOperationException
                    exception =
                    f_1283_76847_76887(message)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 76906, 77041);

                    f_1283_76906_77040(this, f_1283_76928_77039(exception, "OperationNotAllowedInRestrictedLanguageMode", ErrorCategory.InvalidOperation, null));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 76458, 77056);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 76401, 77067);

                System.Management.Automation.ExecutionContext
                f_1283_76462_76469()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 76462, 76469);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1283_76462_76482(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 76462, 76482);
                    return return_v;
                }


                bool
                f_1283_76462_76524(System.Management.Automation.PSLanguageMode
                this_param, System.Management.Automation.PSLanguageMode
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 76462, 76524);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1283_76611_76639()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 76611, 76639);
                    return return_v;
                }


                string
                f_1283_76662_76728()
                {
                    var return_v = InternalCommandStrings.OperationNotAllowedInRestrictedLanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 76662, 76728);
                    return return_v;
                }


                string
                f_1283_76575_76767(System.Globalization.CultureInfo
                provider, string
                format, System.Management.Automation.Language.TokenKind
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 76575, 76767);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1283_76847_76887(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 76847, 76887);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_76928_77039(System.Management.Automation.PSInvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 76928, 77039);
                    return return_v;
                }


                int
                f_1283_76906_77040(Microsoft.PowerShell.Commands.WhereObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 76906, 77040);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 76401, 77067);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 76401, 77067);
            }
        }

        private object GetLikeRHSOperand(object operand)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 77079, 77547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 77152, 77180);

                var
                val = operand as string
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 77194, 77273) || true) && (val == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77194, 77273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 77243, 77258);

                    return operand;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77194, 77273);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 77289, 77473);

                var
                wildcardOptions = (DynAbs.Tracing.TraceSender.Conditional_F1(1283, 77311, 77386) || ((_binaryOperator == TokenKind.Ilike || (DynAbs.Tracing.TraceSender.Expression_False(1283, 77311, 77386) || _binaryOperator == TokenKind.Inotlike
                ) && DynAbs.Tracing.TraceSender.Conditional_F2(1283, 77406, 77432)) || DynAbs.Tracing.TraceSender.Conditional_F3(1283, 77452, 77472))) ? WildcardOptions.IgnoreCase
                : WildcardOptions.None
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 77487, 77536);

                return f_1283_77494_77535(val, wildcardOptions);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 77079, 77547);

                System.Management.Automation.WildcardPattern
                f_1283_77494_77535(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 77494, 77535);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 77079, 77547);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 77079, 77547);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 77583, 87562);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 77649, 77724) || true) && (_script != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77649, 77724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 77702, 77709);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77649, 77724);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 77740, 86271);

                switch (_binaryOperator)
                {

                    case TokenKind.Ieq:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 77838, 78206) || true) && (!_forceBooleanEvaluation)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77838, 78206);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 77916, 77997);

                            _operationDelegate = f_1283_77937_77996(ExpressionType.Equal, ignoreCase: true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77838, 78206);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77838, 78206);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 78095, 78183);

                            _operationDelegate = f_1283_78116_78182(ExpressionType.Equal, ignoreCase: true);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77838, 78206);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 78230, 78236);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);

                    case TokenKind.Ceq:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 78295, 78377);

                        _operationDelegate = f_1283_78316_78376(ExpressionType.Equal, ignoreCase: false);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 78399, 78405);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);

                    case TokenKind.Ine:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 78464, 78548);

                        _operationDelegate = f_1283_78485_78547(ExpressionType.NotEqual, ignoreCase: true);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 78570, 78576);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);

                    case TokenKind.Cne:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 78635, 78720);

                        _operationDelegate = f_1283_78656_78719(ExpressionType.NotEqual, ignoreCase: false);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 78742, 78748);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);

                    case TokenKind.Igt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 78807, 78894);

                        _operationDelegate = f_1283_78828_78893(ExpressionType.GreaterThan, ignoreCase: true);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 78916, 78922);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);

                    case TokenKind.Cgt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 78981, 79069);

                        _operationDelegate = f_1283_79002_79068(ExpressionType.GreaterThan, ignoreCase: false);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 79091, 79097);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);

                    case TokenKind.Ilt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 79156, 79240);

                        _operationDelegate = f_1283_79177_79239(ExpressionType.LessThan, ignoreCase: true);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 79262, 79268);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);

                    case TokenKind.Clt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 79327, 79412);

                        _operationDelegate = f_1283_79348_79411(ExpressionType.LessThan, ignoreCase: false);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 79434, 79440);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);

                    case TokenKind.Ige:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 79499, 79593);

                        _operationDelegate = f_1283_79520_79592(ExpressionType.GreaterThanOrEqual, ignoreCase: true);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 79615, 79621);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);

                    case TokenKind.Cge:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 79680, 79775);

                        _operationDelegate = f_1283_79701_79774(ExpressionType.GreaterThanOrEqual, ignoreCase: false);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 79797, 79803);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);

                    case TokenKind.Ile:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 79862, 79953);

                        _operationDelegate = f_1283_79883_79952(ExpressionType.LessThanOrEqual, ignoreCase: true);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 79975, 79981);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);

                    case TokenKind.Cle:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 80040, 80132);

                        _operationDelegate = f_1283_80061_80131(ExpressionType.LessThanOrEqual, ignoreCase: false);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 80154, 80160);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);

                    case TokenKind.Ilike:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 80221, 80375);

                        _operationDelegate =
                                                (lval, rval) => ParserOps.LikeOperator(Context, PositionUtilities.EmptyExtent, lval, rval, _binaryOperator);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 80397, 80403);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);

                    case TokenKind.Clike:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 80464, 80618);

                        _operationDelegate =
                                                (lval, rval) => ParserOps.LikeOperator(Context, PositionUtilities.EmptyExtent, lval, rval, _binaryOperator);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 80640, 80646);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);

                    case TokenKind.Inotlike:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 80710, 80864);

                        _operationDelegate =
                                                (lval, rval) => ParserOps.LikeOperator(Context, PositionUtilities.EmptyExtent, lval, rval, _binaryOperator);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 80886, 80892);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);

                    case TokenKind.Cnotlike:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 80956, 81110);

                        _operationDelegate =
                                                (lval, rval) => ParserOps.LikeOperator(Context, PositionUtilities.EmptyExtent, lval, rval, _binaryOperator);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 81132, 81138);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);

                    case TokenKind.Imatch:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 81200, 81220);

                        f_1283_81200_81219(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 81242, 81415);

                        _operationDelegate =
                                                (lval, rval) => ParserOps.MatchOperator(Context, PositionUtilities.EmptyExtent, lval, rval, notMatch: false, ignoreCase: true);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 81437, 81443);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);

                    case TokenKind.Cmatch:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 81505, 81525);

                        f_1283_81505_81524(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 81547, 81721);

                        _operationDelegate =
                                                (lval, rval) => ParserOps.MatchOperator(Context, PositionUtilities.EmptyExtent, lval, rval, notMatch: false, ignoreCase: false);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 81743, 81749);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);

                    case TokenKind.Inotmatch:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 81814, 81834);

                        f_1283_81814_81833(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 81856, 82028);

                        _operationDelegate =
                                                (lval, rval) => ParserOps.MatchOperator(Context, PositionUtilities.EmptyExtent, lval, rval, notMatch: true, ignoreCase: true);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 82050, 82056);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);

                    case TokenKind.Cnotmatch:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 82121, 82141);

                        f_1283_82121_82140(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 82163, 82336);

                        _operationDelegate =
                                                (lval, rval) => ParserOps.MatchOperator(Context, PositionUtilities.EmptyExtent, lval, rval, notMatch: true, ignoreCase: false);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 82358, 82364);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);

                    case TokenKind.Not:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 82423, 82514);

                        _operationDelegate = f_1283_82444_82513(ExpressionType.NotEqual, ignoreCase: true);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 82536, 82542);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);

                    case TokenKind.Icontains:
                    case TokenKind.Inotcontains:
                    case TokenKind.In:
                    case TokenKind.Inotin:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 82947, 82998);

                            var
                            sites = f_1283_82959_82997(ignoreCase: true)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 83024, 84237);

                            switch (_binaryOperator)
                            {

                                case TokenKind.Icontains:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 83024, 84237);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 83164, 83320);

                                    _operationDelegate =
                                                                        (lval, rval) => ParserOps.ContainsOperatorCompiled(Context, sites.Item1, sites.Item2, lval, rval);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1283, 83354, 83360);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 83024, 84237);

                                case TokenKind.Inotcontains:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 83024, 84237);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 83452, 83609);

                                    _operationDelegate =
                                                                        (lval, rval) => !ParserOps.ContainsOperatorCompiled(Context, sites.Item1, sites.Item2, lval, rval);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1283, 83643, 83649);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 83024, 84237);

                                case TokenKind.In:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 83024, 84237);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 83731, 83887);

                                    _operationDelegate =
                                                                        (lval, rval) => ParserOps.ContainsOperatorCompiled(Context, sites.Item1, sites.Item2, rval, lval);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1283, 83921, 83927);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 83024, 84237);

                                case TokenKind.Inotin:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 83024, 84237);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 84013, 84170);

                                    _operationDelegate =
                                                                        (lval, rval) => !ParserOps.ContainsOperatorCompiled(Context, sites.Item1, sites.Item2, rval, lval);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1283, 84204, 84210);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 83024, 84237);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1283, 84265, 84271);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);

                    case TokenKind.Ccontains:
                    case TokenKind.Cnotcontains:
                    case TokenKind.Cin:
                    case TokenKind.Cnotin:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 84509, 84561);

                            var
                            sites = f_1283_84521_84560(ignoreCase: false)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 84587, 85801);

                            switch (_binaryOperator)
                            {

                                case TokenKind.Ccontains:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 84587, 85801);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 84727, 84883);

                                    _operationDelegate =
                                                                        (lval, rval) => ParserOps.ContainsOperatorCompiled(Context, sites.Item1, sites.Item2, lval, rval);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1283, 84917, 84923);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 84587, 85801);

                                case TokenKind.Cnotcontains:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 84587, 85801);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 85015, 85172);

                                    _operationDelegate =
                                                                        (lval, rval) => !ParserOps.ContainsOperatorCompiled(Context, sites.Item1, sites.Item2, lval, rval);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1283, 85206, 85212);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 84587, 85801);

                                case TokenKind.Cin:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 84587, 85801);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 85295, 85451);

                                    _operationDelegate =
                                                                        (lval, rval) => ParserOps.ContainsOperatorCompiled(Context, sites.Item1, sites.Item2, rval, lval);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1283, 85485, 85491);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 84587, 85801);

                                case TokenKind.Cnotin:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 84587, 85801);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 85577, 85734);

                                    _operationDelegate =
                                                                        (lval, rval) => !ParserOps.ContainsOperatorCompiled(Context, sites.Item1, sites.Item2, rval, lval);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1283, 85768, 85774);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 84587, 85801);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1283, 85829, 85835);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);

                    case TokenKind.Is:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 85916, 86026);

                        _operationDelegate = (lval, rval) => ParserOps.IsOperator(Context, PositionUtilities.EmptyExtent, lval, rval);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 86048, 86054);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);

                    case TokenKind.IsNot:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 77740, 86271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 86115, 86228);

                        _operationDelegate = (lval, rval) => ParserOps.IsNotOperator(Context, PositionUtilities.EmptyExtent, lval, rval);
                        DynAbs.Tracing.TraceSender.TraceBreak(1283, 86250, 86256);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 77740, 86271);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 86287, 86312);

                _convertedValue = _value;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 86326, 87551) || true) && (!_valueNotSpecified)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 86326, 87551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 86383, 87536);

                    switch (_binaryOperator)
                    {

                        case TokenKind.Ilike:
                        case TokenKind.Clike:
                        case TokenKind.Inotlike:
                        case TokenKind.Cnotlike:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 86383, 87536);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 86630, 86683);

                            _convertedValue = f_1283_86648_86682(this, _convertedValue);
                            DynAbs.Tracing.TraceSender.TraceBreak(1283, 86709, 86715);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 86383, 87536);

                        case TokenKind.Is:
                        case TokenKind.IsNot:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 86383, 87536);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 86918, 86959);

                            var
                            strValue = _convertedValue as string
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 86985, 87483) || true) && (strValue != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 86985, 87483);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 87063, 87096);

                                var
                                typeLength = f_1283_87080_87095(strValue)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 87126, 87354) || true) && (typeLength > 2 && (DynAbs.Tracing.TraceSender.Expression_True(1283, 87130, 87166) && f_1283_87148_87159(strValue, 0) == '[') && (DynAbs.Tracing.TraceSender.Expression_True(1283, 87130, 87201) && f_1283_87170_87194(strValue, typeLength - 1) == ']'))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 87126, 87354);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 87267, 87323);

                                    _convertedValue = f_1283_87285_87322(strValue, 1, typeLength - 2);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 87126, 87354);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 87386, 87456);

                                _convertedValue = f_1283_87404_87455(_convertedValue);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 86985, 87483);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1283, 87511, 87517);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 86383, 87536);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 86326, 87551);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 77583, 87562);

                System.Func<object, object, object>
                f_1283_77937_77996(System.Linq.Expressions.ExpressionType
                expressionType, bool
                ignoreCase)
                {
                    var return_v = GetCallSiteDelegate(expressionType, ignoreCase: ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 77937, 77996);
                    return return_v;
                }


                System.Func<object, object, object>
                f_1283_78116_78182(System.Linq.Expressions.ExpressionType
                expressionType, bool
                ignoreCase)
                {
                    var return_v = GetCallSiteDelegateBoolean(expressionType, ignoreCase: ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 78116, 78182);
                    return return_v;
                }


                System.Func<object, object, object>
                f_1283_78316_78376(System.Linq.Expressions.ExpressionType
                expressionType, bool
                ignoreCase)
                {
                    var return_v = GetCallSiteDelegate(expressionType, ignoreCase: ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 78316, 78376);
                    return return_v;
                }


                System.Func<object, object, object>
                f_1283_78485_78547(System.Linq.Expressions.ExpressionType
                expressionType, bool
                ignoreCase)
                {
                    var return_v = GetCallSiteDelegate(expressionType, ignoreCase: ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 78485, 78547);
                    return return_v;
                }


                System.Func<object, object, object>
                f_1283_78656_78719(System.Linq.Expressions.ExpressionType
                expressionType, bool
                ignoreCase)
                {
                    var return_v = GetCallSiteDelegate(expressionType, ignoreCase: ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 78656, 78719);
                    return return_v;
                }


                System.Func<object, object, object>
                f_1283_78828_78893(System.Linq.Expressions.ExpressionType
                expressionType, bool
                ignoreCase)
                {
                    var return_v = GetCallSiteDelegate(expressionType, ignoreCase: ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 78828, 78893);
                    return return_v;
                }


                System.Func<object, object, object>
                f_1283_79002_79068(System.Linq.Expressions.ExpressionType
                expressionType, bool
                ignoreCase)
                {
                    var return_v = GetCallSiteDelegate(expressionType, ignoreCase: ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 79002, 79068);
                    return return_v;
                }


                System.Func<object, object, object>
                f_1283_79177_79239(System.Linq.Expressions.ExpressionType
                expressionType, bool
                ignoreCase)
                {
                    var return_v = GetCallSiteDelegate(expressionType, ignoreCase: ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 79177, 79239);
                    return return_v;
                }


                System.Func<object, object, object>
                f_1283_79348_79411(System.Linq.Expressions.ExpressionType
                expressionType, bool
                ignoreCase)
                {
                    var return_v = GetCallSiteDelegate(expressionType, ignoreCase: ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 79348, 79411);
                    return return_v;
                }


                System.Func<object, object, object>
                f_1283_79520_79592(System.Linq.Expressions.ExpressionType
                expressionType, bool
                ignoreCase)
                {
                    var return_v = GetCallSiteDelegate(expressionType, ignoreCase: ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 79520, 79592);
                    return return_v;
                }


                System.Func<object, object, object>
                f_1283_79701_79774(System.Linq.Expressions.ExpressionType
                expressionType, bool
                ignoreCase)
                {
                    var return_v = GetCallSiteDelegate(expressionType, ignoreCase: ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 79701, 79774);
                    return return_v;
                }


                System.Func<object, object, object>
                f_1283_79883_79952(System.Linq.Expressions.ExpressionType
                expressionType, bool
                ignoreCase)
                {
                    var return_v = GetCallSiteDelegate(expressionType, ignoreCase: ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 79883, 79952);
                    return return_v;
                }


                System.Func<object, object, object>
                f_1283_80061_80131(System.Linq.Expressions.ExpressionType
                expressionType, bool
                ignoreCase)
                {
                    var return_v = GetCallSiteDelegate(expressionType, ignoreCase: ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 80061, 80131);
                    return return_v;
                }


                int
                f_1283_81200_81219(Microsoft.PowerShell.Commands.WhereObjectCommand
                this_param)
                {
                    this_param.CheckLanguageMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 81200, 81219);
                    return 0;
                }


                int
                f_1283_81505_81524(Microsoft.PowerShell.Commands.WhereObjectCommand
                this_param)
                {
                    this_param.CheckLanguageMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 81505, 81524);
                    return 0;
                }


                int
                f_1283_81814_81833(Microsoft.PowerShell.Commands.WhereObjectCommand
                this_param)
                {
                    this_param.CheckLanguageMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 81814, 81833);
                    return 0;
                }


                int
                f_1283_82121_82140(Microsoft.PowerShell.Commands.WhereObjectCommand
                this_param)
                {
                    this_param.CheckLanguageMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 82121, 82140);
                    return 0;
                }


                System.Func<object, object, object>
                f_1283_82444_82513(System.Linq.Expressions.ExpressionType
                expressionType, bool
                ignoreCase)
                {
                    var return_v = GetCallSiteDelegateBoolean(expressionType, ignoreCase: ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 82444, 82513);
                    return return_v;
                }


                System.Tuple<System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, System.Collections.IEnumerator>>, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object, object>>>
                f_1283_82959_82997(bool
                ignoreCase)
                {
                    var return_v = GetContainsCallSites(ignoreCase: ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 82959, 82997);
                    return return_v;
                }


                System.Tuple<System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, System.Collections.IEnumerator>>, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, object, object>>>
                f_1283_84521_84560(bool
                ignoreCase)
                {
                    var return_v = GetContainsCallSites(ignoreCase: ignoreCase);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 84521, 84560);
                    return return_v;
                }


                object
                f_1283_86648_86682(Microsoft.PowerShell.Commands.WhereObjectCommand
                this_param, object
                operand)
                {
                    var return_v = this_param.GetLikeRHSOperand(operand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 86648, 86682);
                    return return_v;
                }


                int
                f_1283_87080_87095(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 87080, 87095);
                    return return_v;
                }


                char
                f_1283_87148_87159(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 87148, 87159);
                    return return_v;
                }


                char
                f_1283_87170_87194(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 87170, 87194);
                    return return_v;
                }


                string
                f_1283_87285_87322(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 87285, 87322);
                    return return_v;
                }


                System.Type
                f_1283_87404_87455(object
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<Type>(valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 87404, 87455);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 77583, 87562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 77583, 87562);
            }
        }

        private DynamicPropertyGetter _propGetter;

        protected override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 88042, 92084);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 88106, 88202) || true) && (_inputObject == f_1283_88126_88146())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 88106, 88202);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 88180, 88187);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 88106, 88202);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 88218, 92073) || true) && (_script != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 88218, 92073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 88271, 88672);

                    object
                    result = f_1283_88287_88671(_script, useLocalScope: false, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToCurrentErrorPipe, dollarUnder: f_1283_88495_88506(), input: new object[] { _inputObject }, scriptThis: f_1283_88600_88620(), args: f_1283_88649_88670())
                    ;

                    // LAFHIS
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 88692, 88828);
                    // f_1283_88696_88742(_toBoolSite.Target, _toBoolSite, result)
                    var temp = (bool)_toBoolSite.Target.Invoke(_toBoolSite, result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 88696, 88742);
                    if (temp)

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 88692, 88828);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 88784, 88809);

                        f_1283_88784_88808(this, f_1283_88796_88807());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 88692, 88828);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 88218, 92073);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 88218, 92073);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 89004, 89666) || true) && (_valueNotSpecified && (DynAbs.Tracing.TraceSender.Expression_True(1283, 89008, 89130) && ((_binaryOperator != TokenKind.Ieq && (DynAbs.Tracing.TraceSender.Expression_True(1283, 89032, 89100) && _binaryOperator != TokenKind.Not)) || (DynAbs.Tracing.TraceSender.Expression_False(1283, 89031, 89129) || !_forceBooleanEvaluation))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 89004, 89666);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 89319, 89647);

                        f_1283_89319_89646(this, f_1283_89367_89645("Value", f_1283_89483_89537(), "ValueNotSpecifiedForWhereObject", target: null));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 89004, 89666);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 89801, 90377) || true) && (!_valueNotSpecified && (DynAbs.Tracing.TraceSender.Expression_True(1283, 89805, 89889) && (_binaryOperator == TokenKind.Ieq && (DynAbs.Tracing.TraceSender.Expression_True(1283, 89829, 89888) && _forceBooleanEvaluation))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 89801, 90377);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 90049, 90358);

                        f_1283_90049_90357(this, f_1283_90097_90356("Operator", f_1283_90216_90259(), "OperatorNotSpecified", target: null));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 89801, 90377);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 90397, 90430);

                    bool
                    strictModeWithError = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 90448, 90498);

                    object
                    lvalue = f_1283_90464_90497(this, ref strictModeWithError)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 90516, 90607) || true) && (strictModeWithError)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 90516, 90607);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 90581, 90588);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 90516, 90607);
                    }

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 90671, 90738);

                        // LAFHIS
                        //object result = f_1283_90687_90737(_operationDelegate, lvalue, _convertedValue);
                        object result = _operationDelegate.Invoke(lvalue, _convertedValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 90687, 90737);

                        // LAFHIS
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 90760, 90908);
                        var temp = (bool)_toBoolSite.Target.Invoke(_toBoolSite, result);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 90764, 90810);
                        if (temp)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 90760, 90908);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 90860, 90885);

                            f_1283_90860_90884(this, f_1283_90872_90883());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 90760, 90908);
                        }
                    }
                    catch (PipelineStoppedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1283, 90945, 91123);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 91098, 91104);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1283, 90945, 91123);
                    }
                    catch (ArgumentException ae)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1283, 91141, 91604);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 91210, 91539);

                        ErrorRecord
                        errorRecord = f_1283_91236_91538(f_1283_91278_91394("BinaryOperator", f_1283_91331_91364(), _binaryOperator, f_1283_91383_91393(ae)), "BadOperatorArgument", ErrorCategory.InvalidArgument, _inputObject)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 91561, 91585);

                        f_1283_91561_91584(this, errorRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1283, 91141, 91604);
                    }
                    catch (Exception ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1283, 91622, 92058);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 91683, 91993);

                        ErrorRecord
                        errorRecord = f_1283_91709_91992(f_1283_91751_91852(f_1283_91794_91822(), _binaryOperator, f_1283_91841_91851(ex)), "OperatorFailed", ErrorCategory.InvalidOperation, _inputObject)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 92015, 92039);

                        f_1283_92015_92038(this, errorRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1283, 91622, 92058);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 88218, 92073);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 88042, 92084);

                System.Management.Automation.PSObject
                f_1283_88126_88146()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 88126, 88146);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1283_88495_88506()
                {
                    var return_v = InputObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 88495, 88506);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1283_88600_88620()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 88600, 88620);
                    return return_v;
                }


                object[]
                f_1283_88649_88670()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 88649, 88670);
                    return return_v;
                }


                object
                f_1283_88287_88671(System.Management.Automation.ScriptBlock
                this_param, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, object[]
                input, System.Management.Automation.PSObject
                scriptThis, object[]
                args)
                {
                    var return_v = this_param.DoInvokeReturnAsIs(useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 88287, 88671);
                    return return_v;
                }


                bool
                f_1283_88696_88742(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, bool>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, bool>>
                arg1, object
                arg2)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 88696, 88742);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1283_88796_88807()
                {
                    var return_v = InputObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 88796, 88807);
                    return return_v;
                }


                int
                f_1283_88784_88808(Microsoft.PowerShell.Commands.WhereObjectCommand
                this_param, System.Management.Automation.PSObject
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 88784, 88808);
                    return 0;
                }


                string
                f_1283_89483_89537()
                {
                    var return_v = InternalCommandStrings.ValueNotSpecifiedForWhereObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 89483, 89537);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_89367_89645(string
                paraName, string
                resourceString, string
                errorId, object
                target, params object[]
                args)
                {
                    var return_v = ForEachObjectCommand.GenerateNameParameterError(paraName, resourceString, errorId, target: target, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 89367, 89645);
                    return return_v;
                }


                int
                f_1283_89319_89646(Microsoft.PowerShell.Commands.WhereObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 89319, 89646);
                    return 0;
                }


                string
                f_1283_90216_90259()
                {
                    var return_v = InternalCommandStrings.OperatorNotSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 90216, 90259);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_90097_90356(string
                paraName, string
                resourceString, string
                errorId, object
                target, params object[]
                args)
                {
                    var return_v = ForEachObjectCommand.GenerateNameParameterError(paraName, resourceString, errorId, target: target, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 90097, 90356);
                    return return_v;
                }


                int
                f_1283_90049_90357(Microsoft.PowerShell.Commands.WhereObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 90049, 90357);
                    return 0;
                }


                object
                f_1283_90464_90497(Microsoft.PowerShell.Commands.WhereObjectCommand
                this_param, ref bool
                error)
                {
                    var return_v = this_param.GetValue(ref error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 90464, 90497);
                    return return_v;
                }


                object
                f_1283_90687_90737(Microsoft.PowerShell.Commands.WhereObjectCommand
                this_param, object
                arg1, object
                arg2)
                {
                    var return_v = this_param._operationDelegate(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 90687, 90737);
                    return return_v;
                }


                bool
                f_1283_90764_90810(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, bool>>
                this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, bool>>
                arg1, object
                arg2)
                {
                    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 90764, 90810);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1283_90872_90883()
                {
                    var return_v = InputObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 90872, 90883);
                    return return_v;
                }


                int
                f_1283_90860_90884(Microsoft.PowerShell.Commands.WhereObjectCommand
                this_param, System.Management.Automation.PSObject
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 90860, 90884);
                    return 0;
                }


                string
                f_1283_91331_91364()
                {
                    var return_v = ParserStrings.BadOperatorArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 91331, 91364);
                    return return_v;
                }


                string
                f_1283_91383_91393(System.ArgumentException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 91383, 91393);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1283_91278_91394(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 91278, 91394);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_91236_91538(System.Management.Automation.PSArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.PSObject
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 91236, 91538);
                    return return_v;
                }


                int
                f_1283_91561_91584(Microsoft.PowerShell.Commands.WhereObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 91561, 91584);
                    return 0;
                }


                string
                f_1283_91794_91822()
                {
                    var return_v = ParserStrings.OperatorFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 91794, 91822);
                    return return_v;
                }


                string
                f_1283_91841_91851(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 91841, 91851);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1283_91751_91852(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 91751, 91852);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_91709_91992(System.Management.Automation.PSInvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.PSObject
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 91709, 91992);
                    return return_v;
                }


                int
                f_1283_92015_92038(Microsoft.PowerShell.Commands.WhereObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 92015, 92038);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 88042, 92084);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 88042, 92084);
            }
        }

        private object GetValue(ref bool error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 92263, 99021);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 92327, 92911) || true) && (f_1283_92331_92369(f_1283_92357_92368()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 92327, 92911);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 92403, 92864) || true) && (f_1283_92407_92433(f_1283_92407_92414(), 2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 92403, 92864);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 92475, 92810);

                        f_1283_92475_92809(this, f_1283_92512_92808("InputObject", f_1283_92634_92674(), "InputObjectIsNull", _inputObject, _property));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 92832, 92845);

                        error = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 92403, 92864);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 92884, 92896);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 92327, 92911);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 93144, 93188);

                object
                target = f_1283_93160_93187(_inputObject)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 93202, 93243);

                IDictionary
                hash = target as IDictionary
                ;
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 93293, 93421) || true) && (hash != null && (DynAbs.Tracing.TraceSender.Expression_True(1283, 93297, 93337) && f_1283_93313_93337(hash, _property)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 93293, 93421);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 93379, 93402);

                        return f_1283_93386_93401(hash, _property);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 93293, 93421);
                    }
                }
                catch (InvalidOperationException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1283, 93450, 93666);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1283, 93450, 93666);
                    // Ignore invalid operation exception, it can happen if the dictionary
                    // has keys that can't be compared to property.
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 93682, 93717);

                string
                resolvedPropertyName = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 93731, 93765);

                bool
                isBlindDynamicAccess = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 93781, 93854);

                ReadOnlyPSMemberInfoCollection<PSMemberInfo>
                members = f_1283_93836_93853(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 93868, 96055) || true) && (f_1283_93872_93885(members) > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 93868, 96055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 93923, 93975);

                    StringBuilder
                    possibleMatches = f_1283_93955_93974()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 93993, 94169);
                        foreach (PSMemberInfo item in f_1283_94023_94030_I(members))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 93993, 94169);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 94072, 94150);

                            f_1283_94072_94149(possibleMatches, f_1283_94101_94129(), " {0}", f_1283_94139_94148(item));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 93993, 94169);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1283, 1, 177);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1283, 1, 177);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 94189, 94555);

                    f_1283_94189_94554(this, f_1283_94222_94553("Property", f_1283_94333_94385(), "AmbiguousPropertyName", _inputObject, _property, possibleMatches));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 94573, 94586);

                    error = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 93868, 96055);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 93868, 96055);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 94620, 96055) || true) && (f_1283_94624_94637(members) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 94620, 96055);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 94676, 95935) || true) && ((f_1283_94681_94703(f_1283_94681_94692()) is IDynamicMetaObjectProvider) && (DynAbs.Tracing.TraceSender.Expression_True(1283, 94680, 94813) && !f_1283_94760_94813(_property)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 94676, 95935);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 95400, 95433);

                            resolvedPropertyName = _property;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 95455, 95483);

                            isBlindDynamicAccess = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 94676, 95935);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 94676, 95935);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 95525, 95935) || true) && (f_1283_95529_95555(f_1283_95529_95536(), 2))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 95525, 95935);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 95597, 95881);

                                f_1283_95597_95880(this, f_1283_95608_95879("Property", f_1283_95719_95758(), "PropertyNotFound", _inputObject, _property));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 95903, 95916);

                                error = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 95525, 95935);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 94676, 95935);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 94620, 96055);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 94620, 96055);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 96001, 96040);

                        resolvedPropertyName = f_1283_96024_96039(f_1283_96024_96034(members, 0));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 94620, 96055);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 93868, 96055);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 96071, 98982) || true) && (!f_1283_96076_96118(resolvedPropertyName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 96071, 98982);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 96196, 96260);

                        return _propGetter.GetValue(_inputObject, resolvedPropertyName);
                    }
                    catch (TerminateException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1283, 96297, 96389);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 96364, 96370);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1283, 96297, 96389);
                    }
                    catch (MethodException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1283, 96407, 96496);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 96471, 96477);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1283, 96407, 96496);
                    }
                    catch (Exception ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1283, 96514, 98967);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 98304, 98948) || true) && (isBlindDynamicAccess && (DynAbs.Tracing.TraceSender.Expression_True(1283, 98308, 98358) && f_1283_98332_98358(f_1283_98332_98339(), 2)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 98304, 98948);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 98408, 98686);

                            f_1283_98408_98685(this, f_1283_98419_98684(ex, "DynamicPropertyAccessFailed_" + _property, ErrorCategory.InvalidOperation, _inputObject));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 98714, 98727);

                            error = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 98304, 98948);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 98304, 98948);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 98913, 98925);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 98304, 98948);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1283, 96514, 98967);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 96071, 98982);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 98998, 99010);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 92263, 99021);

                System.Management.Automation.PSObject
                f_1283_92357_92368()
                {
                    var return_v = InputObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 92357, 92368);
                    return return_v;
                }


                bool
                f_1283_92331_92369(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = LanguagePrimitives.IsNull((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 92331, 92369);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1283_92407_92414()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 92407, 92414);
                    return return_v;
                }


                bool
                f_1283_92407_92433(System.Management.Automation.ExecutionContext
                this_param, int
                majorVersion)
                {
                    var return_v = this_param.IsStrictVersion(majorVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 92407, 92433);
                    return return_v;
                }


                string
                f_1283_92634_92674()
                {
                    var return_v = InternalCommandStrings.InputObjectIsNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 92634, 92674);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_92512_92808(string
                paraName, string
                resourceString, string
                errorId, System.Management.Automation.PSObject
                target, params object[]
                args)
                {
                    var return_v = ForEachObjectCommand.GenerateNameParameterError(paraName, resourceString, errorId, (object)target, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 92512, 92808);
                    return return_v;
                }


                int
                f_1283_92475_92809(Microsoft.PowerShell.Commands.WhereObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 92475, 92809);
                    return 0;
                }


                object
                f_1283_93160_93187(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = PSObject.Base((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 93160, 93187);
                    return return_v;
                }


                bool
                f_1283_93313_93337(System.Collections.IDictionary
                this_param, string
                key)
                {
                    var return_v = this_param.Contains((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 93313, 93337);
                    return return_v;
                }


                object
                f_1283_93386_93401(System.Collections.IDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 93386, 93401);
                    return return_v;
                }


                System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1283_93836_93853(Microsoft.PowerShell.Commands.WhereObjectCommand
                this_param)
                {
                    var return_v = this_param.GetMatchMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 93836, 93853);
                    return return_v;
                }


                int
                f_1283_93872_93885(System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 93872, 93885);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1283_93955_93974()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 93955, 93974);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1283_94101_94129()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 94101, 94129);
                    return return_v;
                }


                string
                f_1283_94139_94148(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 94139, 94148);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1283_94072_94149(System.Text.StringBuilder
                this_param, System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 94072, 94149);
                    return return_v;
                }


                System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1283_94023_94030_I(System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 94023, 94030);
                    return return_v;
                }


                string
                f_1283_94333_94385()
                {
                    var return_v = InternalCommandStrings.AmbiguousPropertyOrMethodName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 94333, 94385);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_94222_94553(string
                paraName, string
                resourceString, string
                errorId, System.Management.Automation.PSObject
                target, params object[]
                args)
                {
                    var return_v = ForEachObjectCommand.GenerateNameParameterError(paraName, resourceString, errorId, (object)target, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 94222, 94553);
                    return return_v;
                }


                int
                f_1283_94189_94554(Microsoft.PowerShell.Commands.WhereObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 94189, 94554);
                    return 0;
                }


                int
                f_1283_94624_94637(System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 94624, 94637);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1283_94681_94692()
                {
                    var return_v = InputObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 94681, 94692);
                    return return_v;
                }


                object
                f_1283_94681_94703(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 94681, 94703);
                    return return_v;
                }


                bool
                f_1283_94760_94813(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 94760, 94813);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1283_95529_95536()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 95529, 95536);
                    return return_v;
                }


                bool
                f_1283_95529_95555(System.Management.Automation.ExecutionContext
                this_param, int
                majorVersion)
                {
                    var return_v = this_param.IsStrictVersion(majorVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 95529, 95555);
                    return return_v;
                }


                string
                f_1283_95719_95758()
                {
                    var return_v = InternalCommandStrings.PropertyNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 95719, 95758);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_95608_95879(string
                paraName, string
                resourceString, string
                errorId, System.Management.Automation.PSObject
                target, params object[]
                args)
                {
                    var return_v = ForEachObjectCommand.GenerateNameParameterError(paraName, resourceString, errorId, (object)target, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 95608, 95879);
                    return return_v;
                }


                int
                f_1283_95597_95880(Microsoft.PowerShell.Commands.WhereObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 95597, 95880);
                    return 0;
                }


                System.Management.Automation.PSMemberInfo
                f_1283_96024_96034(System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 96024, 96034);
                    return return_v;
                }


                string
                f_1283_96024_96039(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 96024, 96039);
                    return return_v;
                }


                bool
                f_1283_96076_96118(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 96076, 96118);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1283_98332_98339()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 98332, 98339);
                    return return_v;
                }


                bool
                f_1283_98332_98358(System.Management.Automation.ExecutionContext
                this_param, int
                majorVersion)
                {
                    var return_v = this_param.IsStrictVersion(majorVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 98332, 98358);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1283_98419_98684(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.PSObject
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 98419, 98684);
                    return return_v;
                }


                int
                f_1283_98408_98685(Microsoft.PowerShell.Commands.WhereObjectCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 98408, 98685);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 92263, 99021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 92263, 99021);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ReadOnlyPSMemberInfoCollection<PSMemberInfo> GetMatchMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 99171, 100022);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 99266, 99753) || true) && (!f_1283_99271_99324(_property))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 99266, 99753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 99358, 99464);

                    PSMemberInfoInternalCollection<PSMemberInfo>
                    results = f_1283_99413_99463()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 99482, 99536);

                    PSMemberInfo
                    member = f_1283_99504_99535(f_1283_99504_99524(_inputObject), _property)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 99554, 99653) || true) && (member != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 99554, 99653);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 99614, 99634);

                        f_1283_99614_99633(results, member);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 99554, 99653);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 99673, 99738);

                    return f_1283_99680_99737(results);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 99266, 99753);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 99769, 99881);

                ReadOnlyPSMemberInfoCollection<PSMemberInfo>
                members = f_1283_99824_99880(f_1283_99824_99844(_inputObject), _property, PSMemberTypes.All)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 99895, 99982);

                f_1283_99895_99981(members != null, "The return value of Members.Match should never be null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 99996, 100011);

                return members;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 99171, 100022);

                bool
                f_1283_99271_99324(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 99271, 99324);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1283_99413_99463()
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 99413, 99463);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1283_99504_99524(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 99504, 99524);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1283_99504_99535(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 99504, 99535);
                    return return_v;
                }


                int
                f_1283_99614_99633(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSMemberInfo
                member)
                {
                    this_param.Add(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 99614, 99633);
                    return 0;
                }


                System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1283_99680_99737(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                members)
                {
                    var return_v = new System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>(members);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 99680, 99737);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1283_99824_99844(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 99824, 99844);
                    return return_v;
                }


                System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1283_99824_99880(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, string
                name, System.Management.Automation.PSMemberTypes
                memberTypes)
                {
                    var return_v = this_param.Match(name, memberTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 99824, 99880);
                    return return_v;
                }


                int
                f_1283_99895_99981(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 99895, 99981);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 99171, 100022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 99171, 100022);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public WhereObjectCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1283, 52544, 100029);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 53197, 53232);
            this._inputObject = f_1283_53212_53232();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 53265, 53272);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 53716, 53725);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 56967, 56982);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 57008, 57021);
            this._value = true;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 57045, 57070);
            this._valueNotSpecified = true;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 59729, 59760);
            this._binaryOperator = TokenKind.Ieq;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 59926, 59956);
            this._forceBooleanEvaluation = true;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 74557, 74664);
            this._toBoolSite = f_1283_74584_74664(f_1283_74630_74663(typeof(bool)));
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 74712, 74730);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1283, 52544, 100029);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 52544, 100029);
        }


        static WhereObjectCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1283, 52544, 100029);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1283, 52544, 100029);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 52544, 100029);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1283, 52544, 100029);

        System.Management.Automation.PSObject
        f_1283_53212_53232()
        {
            var return_v = AutomationNull.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 53212, 53232);
            return return_v;
        }


        System.Management.Automation.Language.PSConvertBinder
        f_1283_74630_74663(System.Type
        type)
        {
            var return_v = PSConvertBinder.Get(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 74630, 74663);
            return return_v;
        }


        System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, bool>>
        f_1283_74584_74664(System.Management.Automation.Language.PSConvertBinder
        binder)
        {
            var return_v = CallSite<Func<CallSite, object, bool>>.Create((System.Runtime.CompilerServices.CallSiteBinder)binder);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 74584, 74664);
            return return_v;
        }

    }
    [Cmdlet(VerbsCommon.Set, "PSDebug", HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096959")]
    public sealed class SetPSDebugCommand : PSCmdlet
    {
        [Parameter(ParameterSetName = "on")]
        [ValidateRange(0, 2)]
        public int Trace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 100530, 100595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 100566, 100580);

                    return _trace;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 100530, 100595);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 100412, 100688);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 100412, 100688);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 100611, 100677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 100647, 100662);

                    _trace = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 100611, 100677);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 100412, 100688);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 100412, 100688);
                }
            }
        }

        private int _trace;

        [Parameter(ParameterSetName = "on")]
        public SwitchParameter Step
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 100928, 101009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 100964, 100994);

                    return (SwitchParameter)_step;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 100928, 101009);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 100830, 101101);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 100830, 101101);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 101025, 101090);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 101061, 101075);

                    _step = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 101025, 101090);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 100830, 101101);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 100830, 101101);
                }
            }
        }

        private bool? _step;

        [Parameter(ParameterSetName = "on")]
        public SwitchParameter Strict
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 101342, 101425);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 101378, 101410);

                    return (SwitchParameter)_strict;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 101342, 101425);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 101242, 101519);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 101242, 101519);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 101441, 101508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 101477, 101493);

                    _strict = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 101441, 101508);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 101242, 101519);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 101242, 101519);
                }
            }
        }

        private bool? _strict;

        [Parameter(ParameterSetName = "off")]
        public SwitchParameter Off
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 101771, 101834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 101807, 101819);

                    return _off;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 101771, 101834);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 101673, 101925);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 101673, 101925);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 101850, 101914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 101886, 101899);

                    _off = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 101850, 101914);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 101673, 101925);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 101673, 101925);
                }
            }
        }

        private bool _off;

        protected override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 102085, 102865);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 102230, 102854) || true) && (_off)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 102230, 102854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 102272, 102306);

                    f_1283_102272_102305(f_1283_102272_102288(f_1283_102272_102279()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 102324, 102388);

                    f_1283_102324_102362(f_1283_102324_102350(f_1283_102324_102331())).StrictModeVersion = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 102230, 102854);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 102230, 102854);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 102454, 102593) || true) && (_trace >= 0 || (DynAbs.Tracing.TraceSender.Expression_False(1283, 102458, 102486) || _step != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 102454, 102593);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 102528, 102574);

                        f_1283_102528_102573(f_1283_102528_102544(f_1283_102528_102535()), _trace, _step);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 102454, 102593);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 102662, 102839) || true) && (_strict != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 102662, 102839);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 102723, 102820);

                        f_1283_102723_102761(f_1283_102723_102749(f_1283_102723_102730())).StrictModeVersion = f_1283_102782_102819((DynAbs.Tracing.TraceSender.Conditional_F1(1283, 102794, 102807) || (((bool)_strict && DynAbs.Tracing.TraceSender.Conditional_F2(1283, 102810, 102811)) || DynAbs.Tracing.TraceSender.Conditional_F3(1283, 102814, 102815))) ? 1 : 0, 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 102662, 102839);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 102230, 102854);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 102085, 102865);

                System.Management.Automation.ExecutionContext
                f_1283_102272_102279()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 102272, 102279);
                    return return_v;
                }


                System.Management.Automation.ScriptDebugger
                f_1283_102272_102288(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 102272, 102288);
                    return return_v;
                }


                int
                f_1283_102272_102305(System.Management.Automation.ScriptDebugger
                this_param)
                {
                    this_param.DisableTracing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 102272, 102305);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1283_102324_102331()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 102324, 102331);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1283_102324_102350(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 102324, 102350);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1283_102324_102362(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.GlobalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 102324, 102362);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1283_102528_102535()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 102528, 102535);
                    return return_v;
                }


                System.Management.Automation.ScriptDebugger
                f_1283_102528_102544(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 102528, 102544);
                    return return_v;
                }


                int
                f_1283_102528_102573(System.Management.Automation.ScriptDebugger
                this_param, int
                traceLevel, bool?
                step)
                {
                    this_param.EnableTracing(traceLevel, step);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 102528, 102573);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1283_102723_102730()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 102723, 102730);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1283_102723_102749(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 102723, 102749);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1283_102723_102761(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.GlobalScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 102723, 102761);
                    return return_v;
                }


                System.Version
                f_1283_102782_102819(int
                major, int
                minor)
                {
                    var return_v = new System.Version(major, minor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 102782, 102819);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 102085, 102865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 102085, 102865);
            }
        }

        public SetPSDebugCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1283, 100145, 102872);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 100712, 100723);
            this._trace = -1;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 101127, 101132);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 101545, 101552);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 101950, 101954);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1283, 100145, 102872);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 100145, 102872);
        }


        static SetPSDebugCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1283, 100145, 102872);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1283, 100145, 102872);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 100145, 102872);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1283, 100145, 102872);
    }
    [Cmdlet(VerbsCommon.Set, "StrictMode", DefaultParameterSetName = "Version", HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096804")]
    public class SetStrictModeCommand : PSCmdlet
    {
        [Parameter(ParameterSetName = "Off", Mandatory = true)]
        public SwitchParameter Off
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 104058, 104121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 104094, 104106);

                    return _off;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 104058, 104121);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 103942, 104212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 103942, 104212);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 104137, 104201);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 104173, 104186);

                    _off = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 104137, 104201);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 103942, 104212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 103942, 104212);
                }
            }
        }

        private SwitchParameter _off;
        private sealed class ArgumentToVersionTransformationAttribute : ArgumentTransformationAttribute
        {
            public override object Transform(EngineIntrinsics engineIntrinsics, object inputData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 104731, 106046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 104849, 104891);

                    object
                    version = f_1283_104866_104890(inputData)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 104911, 104949);

                    string
                    versionStr = version as string
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 104967, 105472) || true) && (versionStr != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 104967, 105472);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 105031, 105202) || true) && (f_1283_105035_105098(versionStr, "latest", StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 105031, 105202);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 105148, 105179);

                            return f_1283_105155_105178();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 105031, 105202);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 105226, 105453) || true) && (f_1283_105230_105254(versionStr, "."))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 105226, 105453);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 105413, 105430);

                            return inputData;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 105226, 105453);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 104967, 105472);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 105492, 105775) || true) && (version is double)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 105492, 105775);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 105739, 105756);

                        return inputData;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 105492, 105775);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 105795, 105812);

                    int
                    majorVersion
                    = default(int);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 105830, 105994) || true) && (f_1283_105834_105897(version, out majorVersion))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 105830, 105994);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 105939, 105975);

                        return f_1283_105946_105974(majorVersion, 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 105830, 105994);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 106014, 106031);

                    return inputData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 104731, 106046);

                    object
                    f_1283_104866_104890(object
                    obj)
                    {
                        var return_v = PSObject.Base(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 104866, 104890);
                        return return_v;
                    }


                    bool
                    f_1283_105035_105098(string
                    this_param, string
                    value, System.StringComparison
                    comparisonType)
                    {
                        var return_v = this_param.Equals(value, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 105035, 105098);
                        return return_v;
                    }


                    System.Version
                    f_1283_105155_105178()
                    {
                        var return_v = PSVersionInfo.PSVersion;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 105155, 105178);
                        return return_v;
                    }


                    bool
                    f_1283_105230_105254(string
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Contains(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 105230, 105254);
                        return return_v;
                    }


                    bool
                    f_1283_105834_105897(object
                    valueToConvert, out int
                    result)
                    {
                        var return_v = LanguagePrimitives.TryConvertTo<int>(valueToConvert, out result);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 105834, 105897);
                        return return_v;
                    }


                    System.Version
                    f_1283_105946_105974(int
                    major, int
                    minor)
                    {
                        var return_v = new System.Version(major, minor);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 105946, 105974);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 104731, 106046);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 104731, 106046);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public ArgumentToVersionTransformationAttribute()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1283, 104611, 106057);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1283, 104611, 106057);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 104611, 106057);
            }


            static ArgumentToVersionTransformationAttribute()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1283, 104611, 106057);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1283, 104611, 106057);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 104611, 106057);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1283, 104611, 106057);
        }
        private sealed class ValidateVersionAttribute : ValidateArgumentsAttribute
        {
            protected override void Validate(object arguments, EngineIntrinsics engineIntrinsics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 106168, 106765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 106286, 106325);

                    Version
                    version = arguments as Version
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 106343, 106750) || true) && (version == null || (DynAbs.Tracing.TraceSender.Expression_False(1283, 106347, 106406) || !f_1283_106367_106406(version)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 106343, 106750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 106522, 106731);

                        throw f_1283_106528_106730("InvalidPSVersion", null, f_1283_106662_106693(), arguments);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 106343, 106750);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 106168, 106765);

                    bool
                    f_1283_106367_106406(System.Version
                    version)
                    {
                        var return_v = PSVersionInfo.IsValidPSVersion(version);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 106367, 106406);
                        return return_v;
                    }


                    string
                    f_1283_106662_106693()
                    {
                        var return_v = Metadata.ValidateVersionFailure;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 106662, 106693);
                        return return_v;
                    }


                    System.Management.Automation.ValidationMetadataException
                    f_1283_106528_106730(string
                    errorId, System.Exception
                    innerException, string
                    resourceStr, params object[]
                    arguments)
                    {
                        var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 106528, 106730);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 106168, 106765);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 106168, 106765);
                }
            }

            public ValidateVersionAttribute()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1283, 106069, 106776);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1283, 106069, 106776);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 106069, 106776);
            }


            static ValidateVersionAttribute()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1283, 106069, 106776);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1283, 106069, 106776);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 106069, 106776);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1283, 106069, 106776);
        }

        [Parameter(ParameterSetName = "Version", Mandatory = true)]
        [ArgumentToVersionTransformation]
        [ValidateVersion]
        [Alias("v")]
        public Version Version
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 107103, 107170);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 107139, 107155);

                    return _version;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 107103, 107170);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 106895, 107265);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 106895, 107265);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 107186, 107254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 107222, 107239);

                    _version = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 107186, 107254);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 106895, 107265);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 106895, 107265);
                }
            }
        }

        private Version _version;

        protected override void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1283, 107445, 107701);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 107509, 107605) || true) && (_off.IsPresent)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1283, 107509, 107605);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 107561, 107590);

                    _version = f_1283_107572_107589(0, 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1283, 107509, 107605);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 107621, 107690);

                f_1283_107621_107660(f_1283_107621_107647(f_1283_107621_107628())).StrictModeVersion = _version;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1283, 107445, 107701);

                System.Version
                f_1283_107572_107589(int
                major, int
                minor)
                {
                    var return_v = new System.Version(major, minor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1283, 107572, 107589);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1283_107621_107628()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 107621, 107628);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1283_107621_107647(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 107621, 107647);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1283_107621_107660(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1283, 107621, 107660);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1283, 107445, 107701);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 107445, 107701);
            }
        }

        public SetStrictModeCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1283, 103648, 107708);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1283, 107293, 107301);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1283, 103648, 107708);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 103648, 107708);
        }


        static SetStrictModeCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1283, 103648, 107708);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1283, 103648, 107708);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1283, 103648, 107708);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1283, 103648, 107708);
    }

}
