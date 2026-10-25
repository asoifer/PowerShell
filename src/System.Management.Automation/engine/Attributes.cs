// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace System.Management.Automation.Internal
{
    [AttributeUsage(AttributeTargets.All)]
    public abstract class CmdletMetadataAttribute : Attribute
    {
        internal CmdletMetadataAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 1349, 1405);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 1349, 1405);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 1349, 1405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 1349, 1405);
            }
        }

        static CmdletMetadataAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 1150, 1412);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 1150, 1412);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 1150, 1412);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 1150, 1412);
    }
    [AttributeUsage(AttributeTargets.All)]
    public abstract class ParsingBaseAttribute : CmdletMetadataAttribute
    {
        internal ParsingBaseAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 2242, 2295);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 2242, 2295);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 2242, 2295);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 2242, 2295);
            }
        }

        static ParsingBaseAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 2021, 2302);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 2021, 2302);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 2021, 2302);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 2021, 2302);
    }
}

namespace System.Management.Automation
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public abstract class ValidateArgumentsAttribute : CmdletMetadataAttribute
    {
        protected abstract void Validate(object arguments, EngineIntrinsics engineIntrinsics);

        internal void InternalValidate(object o, EngineIntrinsics engineIntrinsics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 6330, 6362);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 6333, 6362);
                f_1236_6333_6362(this, o, engineIntrinsics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 6330, 6362);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 6330, 6362);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 6330, 6362);
            }

            int
            f_1236_6333_6362(System.Management.Automation.ValidateArgumentsAttribute
            this_param, object
            arguments, System.Management.Automation.EngineIntrinsics
            engineIntrinsics)
            {
                this_param.Validate(arguments, engineIntrinsics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 6333, 6362);
                return 0;
            }

        }

        protected ValidateArgumentsAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 6528, 6588);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 6528, 6588);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 6528, 6588);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 6528, 6588);
            }
        }

        static ValidateArgumentsAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 4769, 6595);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 4769, 6595);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 4769, 6595);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 4769, 6595);
    }
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public abstract class ValidateEnumeratedArgumentsAttribute : ValidateArgumentsAttribute
    {
        protected ValidateEnumeratedArgumentsAttribute() : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 8743, 8822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 10974, 11086);
                this._getEnumeratorSite = f_1236_11008_11086(f_1236_11061_11085());
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 8743, 8822);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 8743, 8822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 8743, 8822);
            }
        }

        protected abstract void ValidateElement(object element);

        protected sealed override void Validate(object arguments, EngineIntrinsics engineIntrinsics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 10064, 10899);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 10181, 10447) || true) && (f_1236_10185_10221(arguments))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 10181, 10447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 10255, 10432);

                    throw f_1236_10261_10431("ArgumentIsEmpty", null, f_1236_10382_10430());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 10181, 10447);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 10463, 10544);

                // LAFHIS
                //var enumerator = f_1236_10480_10543(_getEnumeratorSite.Target, _getEnumeratorSite, arguments);
                var enumerator = _getEnumeratorSite.Target.Invoke(_getEnumeratorSite, arguments);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 10480, 10543);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 10560, 10683) || true) && (enumerator == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 10560, 10683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 10616, 10643);

                    f_1236_10616_10642(this, arguments);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 10661, 10668);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 10560, 10683);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 10740, 10853) || true) && (f_1236_10747_10768(enumerator))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 10740, 10853);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 10802, 10838);

                        f_1236_10802_10837(this, f_1236_10818_10836(enumerator));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 10740, 10853);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1236, 10740, 10853);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1236, 10740, 10853);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 10869, 10888);

                f_1236_10869_10887(
                            enumerator);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 10064, 10899);

                bool
                f_1236_10185_10221(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsNull(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 10185, 10221);
                    return return_v;
                }


                string
                f_1236_10382_10430()
                {
                    var return_v = Metadata.ValidateNotNullOrEmptyCollectionFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 10382, 10430);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_10261_10431(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 10261, 10431);
                    return return_v;
                }


                //System.Collections.IEnumerator
                //f_1236_10480_10543(System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, System.Collections.IEnumerator>>
                //this_param, System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, System.Collections.IEnumerator>>
                //arg1, object
                //arg2)
                //{
                //    var return_v = this_param.Target((System.Runtime.CompilerServices.CallSite)arg1, arg2);
                //    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 10480, 10543);
                //    return return_v;
                //}


                int
                f_1236_10616_10642(System.Management.Automation.ValidateEnumeratedArgumentsAttribute
                this_param, object
                element)
                {
                    this_param.ValidateElement(element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 10616, 10642);
                    return 0;
                }


                bool
                f_1236_10747_10768(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 10747, 10768);
                    return return_v;
                }


                object
                f_1236_10818_10836(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 10818, 10836);
                    return return_v;
                }


                int
                f_1236_10802_10837(System.Management.Automation.ValidateEnumeratedArgumentsAttribute
                this_param, object
                element)
                {
                    this_param.ValidateElement(element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 10802, 10837);
                    return 0;
                }


                int
                f_1236_10869_10887(System.Collections.IEnumerator
                this_param)
                {
                    this_param.Reset();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 10869, 10887);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 10064, 10899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 10064, 10899);
            }
        }

        private readonly CallSite<Func<CallSite, object, IEnumerator>> _getEnumeratorSite;

        static ValidateEnumeratedArgumentsAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 8402, 11094);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 8402, 11094);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 8402, 11094);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 8402, 11094);

        System.Management.Automation.Language.PSEnumerableBinder
        f_1236_11061_11085()
        {
            var return_v = PSEnumerableBinder.Get();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 11061, 11085);
            return return_v;
        }


        System.Runtime.CompilerServices.CallSite<System.Func<System.Runtime.CompilerServices.CallSite, object, System.Collections.IEnumerator>>
        f_1236_11008_11086(System.Management.Automation.Language.PSEnumerableBinder
        binder)
        {
            var return_v = CallSite<Func<CallSite, object, IEnumerator>>.Create((System.Runtime.CompilerServices.CallSiteBinder)binder);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 11008, 11086);
            return return_v;
        }

    }



    /// <summary>
    /// To specify RunAs behavior for the class
    /// /// </summary>
    public enum DSCResourceRunAsCredential
    {
        /// <summary>Default is same as optional.</summary>
        Default,
        /// <summary>
        /// PsDscRunAsCredential can not be used for this DSC Resource.
        /// </summary>
        NotSupported,
        /// <summary>
        /// PsDscRunAsCredential is mandatory for resource.
        /// </summary>
        Mandatory,
        /// <summary>
        /// PsDscRunAsCredential can or can not be specified.
        /// </summary>
        Optional = Default,
    }
    [AttributeUsage(AttributeTargets.Class)]
    public class DscResourceAttribute : CmdletMetadataAttribute
    {
        public DSCResourceRunAsCredential RunAsCredential { get; set; }

        public DscResourceAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 11906, 12202);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 12132, 12195);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 11906, 12202);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 11906, 12202);
        }


        static DscResourceAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 11906, 12202);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 11906, 12202);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 11906, 12202);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 11906, 12202);
    }
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class DscPropertyAttribute : CmdletMetadataAttribute
    {
        public bool Key { get; set; }

        public bool Mandatory { get; set; }

        public bool NotConfigurable { get; set; }

        public DscPropertyAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 12538, 13304);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 12818, 12847);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 12985, 13020);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 13256, 13297);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 12538, 13304);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 12538, 13304);
        }


        static DscPropertyAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 12538, 13304);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 12538, 13304);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 12538, 13304);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 12538, 13304);
    }
    [AttributeUsage(AttributeTargets.Class)]
    public class DscLocalConfigurationManagerAttribute : CmdletMetadataAttribute
    {
        public DscLocalConfigurationManagerAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 13459, 13595);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 13459, 13595);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 13459, 13595);
        }


        static DscLocalConfigurationManagerAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 13459, 13595);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 13459, 13595);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 13459, 13595);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 13459, 13595);
    }
    [AttributeUsage(AttributeTargets.Class)]
    public abstract class CmdletCommonMetadataAttribute : CmdletMetadataAttribute
    {
        public string DefaultParameterSetName { get; set; }

        public bool SupportsShouldProcess { get; set; }

        public bool SupportsPaging { get; set; }

        public bool SupportsTransactions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 14878, 14915);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 14884, 14913);

                    return _supportsTransactions;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 14878, 14915);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 14821, 15263);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 14821, 15263);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 14931, 15252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 15199, 15229);

                    _supportsTransactions = false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 14931, 15252);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 14821, 15263);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 14821, 15263);
                }
            }
        }

        private bool _supportsTransactions;

        private ConfirmImpact _confirmImpact;

        public ConfirmImpact ConfirmImpact
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 15739, 15801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 15742, 15801);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1236, 15742, 15763) || ((f_1236_15742_15763() && DynAbs.Tracing.TraceSender.Conditional_F2(1236, 15766, 15780)) || DynAbs.Tracing.TraceSender.Conditional_F3(1236, 15783, 15801))) ? _confirmImpact : ConfirmImpact.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 15739, 15801);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 15676, 15857);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 15676, 15857);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 15820, 15845);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 15823, 15845);
                    _confirmImpact = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 15820, 15845);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 15676, 15857);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 15676, 15857);
                }
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings")]
        public string HelpUri { get; set; }

        public RemotingCapability RemotingCapability { get; set; }

        public CmdletCommonMetadataAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 13699, 16524);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 13946, 13997);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 14242, 14298);
            this.SupportsShouldProcess = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 14529, 14578);
            this.SupportsPaging = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 15288, 15317);
            this._supportsTransactions = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 15352, 15389);
            this._confirmImpact = ConfirmImpact.Medium;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 16092, 16232);
            this.HelpUri = string.Empty;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 16426, 16517);
            this.RemotingCapability = RemotingCapability.PowerShell;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 13699, 16524);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 13699, 16524);
        }


        static CmdletCommonMetadataAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 13699, 16524);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 13699, 16524);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 13699, 16524);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 13699, 16524);

        bool
        f_1236_15742_15763()
        {
            var return_v = SupportsShouldProcess;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 15742, 15763);
            return return_v;
        }

    }
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class CmdletAttribute : CmdletCommonMetadataAttribute
    {
        public string NounName { get; }

        public string VerbName { get; }

        public CmdletAttribute(string verbName, string nounName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 17381, 17905);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 16880, 16911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 17005, 17036);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 17524, 17666) || true) && (f_1236_17528_17558(nounName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 17524, 17666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 17592, 17651);

                    throw f_1236_17598_17650(nameof(nounName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 17524, 17666);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 17682, 17824) || true) && (f_1236_17686_17716(verbName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 17682, 17824);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 17750, 17809);

                    throw f_1236_17756_17808(nameof(verbName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 17682, 17824);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 17840, 17860);

                NounName = nounName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 17874, 17894);

                VerbName = verbName;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 17381, 17905);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 17381, 17905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 17381, 17905);
            }
        }

        static CmdletAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 16668, 17912);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 16668, 17912);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 16668, 17912);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 16668, 17912);

        bool
        f_1236_17528_17558(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 17528, 17558);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1236_17598_17650(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 17598, 17650);
            return return_v;
        }


        bool
        f_1236_17686_17716(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 17686, 17716);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1236_17756_17808(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 17756, 17808);
            return return_v;
        }

    }
    [AttributeUsage(AttributeTargets.Class)]
    public class CmdletBindingAttribute : CmdletCommonMetadataAttribute
    {
        public bool PositionalBinding { get; set; }

        public CmdletBindingAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 18114, 18632);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 18574, 18625);
            this.PositionalBinding = true;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 18114, 18632);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 18114, 18632);
        }


        static CmdletBindingAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 18114, 18632);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 18114, 18632);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 18114, 18632);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 18114, 18632);
    }
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    [SuppressMessage("Microsoft.Design", "CA1019:DefineAccessorsForAttributeArguments")]
    public sealed class OutputTypeAttribute : CmdletMetadataAttribute
    {
        internal OutputTypeAttribute(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 19131, 19244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 20870, 21105);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 21374, 21416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 21878, 21895);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 19195, 19233);

                Type = new[] { f_1236_19210_19230(type) };
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 19131, 19244);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 19131, 19244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 19131, 19244);
            }
        }

        internal OutputTypeAttribute(string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 19358, 19481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 20870, 21105);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 21374, 21416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 21878, 21895);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 19428, 19470);

                Type = new[] { f_1236_19443_19467(typeName) };
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 19358, 19481);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 19358, 19481);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 19358, 19481);
            }
        }

        public OutputTypeAttribute(params Type[] type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 19689, 20123);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 20870, 21105);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 21374, 21416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 21878, 21895);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 19760, 20112) || true) && (f_1236_19764_19776_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(type, 1236, 19764, 19776)?.Length) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 19760, 20112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 19814, 19849);

                    Type = new PSTypeName[f_1236_19836_19847(type)];
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 19876, 19881);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 19867, 19998) || true) && (i < f_1236_19887_19898(type))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 19900, 19903)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 19867, 19998))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 19867, 19998);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 19945, 19979);

                            f_1236_19945_19949()[i] = f_1236_19955_19978(type[i]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1236, 1, 132);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1236, 1, 132);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 19760, 20112);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 19760, 20112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 20064, 20097);

                    Type = f_1236_20071_20096();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 19760, 20112);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 19689, 20123);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 19689, 20123);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 19689, 20123);
            }
        }

        public OutputTypeAttribute(params string[] type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 20324, 20760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 20870, 21105);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 21374, 21416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 21878, 21895);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 20397, 20749) || true) && (f_1236_20401_20413_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(type, 1236, 20401, 20413)?.Length) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 20397, 20749);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 20451, 20486);

                    Type = new PSTypeName[f_1236_20473_20484(type)];
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 20513, 20518);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 20504, 20635) || true) && (i < f_1236_20524_20535(type))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 20537, 20540)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 20504, 20635))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 20504, 20635);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 20582, 20616);

                            f_1236_20582_20586()[i] = f_1236_20592_20615(type[i]);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1236, 1, 132);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1236, 1, 132);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 20397, 20749);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 20397, 20749);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 20701, 20734);

                    Type = f_1236_20708_20733();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 20397, 20749);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 20324, 20760);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 20324, 20760);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 20324, 20760);
            }
        }

        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        [SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
        public PSTypeName[] Type { get; private set; }

        public string ProviderCmdlet { get; set; }

        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays")]
        public string[] ParameterSetName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 21697, 21788);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 21700, 21788);
                    return _parameterSetName ?? (DynAbs.Tracing.TraceSender.Expression_Null<string[]>(1236, 21700, 21788) ?? (_parameterSetName = new[] { ParameterAttribute.AllParameterSets }));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 21697, 21788);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 21542, 21849);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 21542, 21849);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 21809, 21837);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 21812, 21837);
                    _parameterSetName = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 21809, 21837);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 21542, 21849);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 21542, 21849);
                }
            }
        }

        private string[] _parameterSetName;

        static OutputTypeAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 18777, 21903);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 18777, 21903);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 18777, 21903);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 18777, 21903);

        System.Management.Automation.PSTypeName
        f_1236_19210_19230(System.Type
        type)
        {
            var return_v = new System.Management.Automation.PSTypeName(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 19210, 19230);
            return return_v;
        }


        System.Management.Automation.PSTypeName
        f_1236_19443_19467(string
        name)
        {
            var return_v = new System.Management.Automation.PSTypeName(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 19443, 19467);
            return return_v;
        }


        int?
        f_1236_19764_19776_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 19764, 19776);
            return return_v;
        }


        int
        f_1236_19836_19847(System.Type[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 19836, 19847);
            return return_v;
        }


        int
        f_1236_19887_19898(System.Type[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 19887, 19898);
            return return_v;
        }


        System.Management.Automation.PSTypeName[]
        f_1236_19945_19949()
        {
            var return_v = Type;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 19945, 19949);
            return return_v;
        }


        System.Management.Automation.PSTypeName
        f_1236_19955_19978(System.Type
        type)
        {
            var return_v = new System.Management.Automation.PSTypeName(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 19955, 19978);
            return return_v;
        }


        System.Management.Automation.PSTypeName[]
        f_1236_20071_20096()
        {
            var return_v = Array.Empty<PSTypeName>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 20071, 20096);
            return return_v;
        }


        int?
        f_1236_20401_20413_M(int?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 20401, 20413);
            return return_v;
        }


        int
        f_1236_20473_20484(string[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 20473, 20484);
            return return_v;
        }


        int
        f_1236_20524_20535(string[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 20524, 20535);
            return return_v;
        }


        System.Management.Automation.PSTypeName[]
        f_1236_20582_20586()
        {
            var return_v = Type;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 20582, 20586);
            return return_v;
        }


        System.Management.Automation.PSTypeName
        f_1236_20592_20615(string
        name)
        {
            var return_v = new System.Management.Automation.PSTypeName(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 20592, 20615);
            return return_v;
        }


        System.Management.Automation.PSTypeName[]
        f_1236_20708_20733()
        {
            var return_v = Array.Empty<PSTypeName>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 20708, 20733);
            return return_v;
        }

    }
    [AttributeUsage(AttributeTargets.Assembly)]
    public class DynamicClassImplementationAssemblyAttribute : Attribute
    {
        public string ScriptFile { get; set; }

        public DynamicClassImplementationAssemblyAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 22106, 22403);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 22358, 22396);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 22106, 22403);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 22106, 22403);
        }


        static DynamicClassImplementationAssemblyAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 22106, 22403);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 22106, 22403);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 22106, 22403);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 22106, 22403);
    }
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    public sealed class AliasAttribute : ParsingBaseAttribute
    {
        internal string[] aliasNames;

        public IList<string> AliasNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 22986, 23004);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 22989, 23004);
                    return this.aliasNames;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 22986, 23004);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 22986, 23004);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 22986, 23004);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public AliasAttribute(params string[] aliasNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 23290, 23556);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 22817, 22827);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 23364, 23500) || true) && (aliasNames == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 23364, 23500);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 23420, 23485);

                    throw f_1236_23426_23484(nameof(aliasNames));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 23364, 23500);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 23516, 23545);

                this.aliasNames = aliasNames;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 23290, 23556);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 23290, 23556);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 23290, 23556);
            }
        }

        static AliasAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 22603, 23563);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 22603, 23563);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 22603, 23563);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 22603, 23563);

        System.Management.Automation.PSArgumentNullException
        f_1236_23426_23484(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 23426, 23484);
            return return_v;
        }

    }
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)]
    public sealed class ParameterAttribute : ParsingBaseAttribute
    {
        public const string
        AllParameterSets = "__AllParameterSets"
        ;

        public ParameterAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 24128, 24177);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 24641, 24696);
                this._parameterSetName = ParameterAttribute.AllParameterSets;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 24724, 24736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 24762, 24782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 24808, 24830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 25039, 25076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 25229, 25278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 25952, 25996);
                this._effectiveAction = default(ExperimentAction);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 26177, 26226);
                this.Position = int.MinValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 26910, 26954);
                this.Mandatory = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 27202, 27245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 27572, 27629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 27915, 27977);
                this.ValueFromRemainingArguments = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 30255, 30289);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 24128, 24177);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 24128, 24177);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 24128, 24177);
            }
        }

        public ParameterAttribute(string experimentName, ExperimentAction experimentAction)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 24325, 24614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 24641, 24696);
                this._parameterSetName = ParameterAttribute.AllParameterSets;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 24724, 24736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 24762, 24782);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 24808, 24830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 25039, 25076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 25229, 25278);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 25952, 25996);
                this._effectiveAction = default(ExperimentAction);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 26177, 26226);
                this.Position = int.MinValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 26910, 26954);
                this.Mandatory = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 27202, 27245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 27572, 27629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 27915, 27977);
                this.ValueFromRemainingArguments = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 30255, 30289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 24433, 24507);

                f_1236_24433_24506(experimentName, experimentAction);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 24521, 24553);

                ExperimentName = experimentName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 24567, 24603);

                ExperimentAction = experimentAction;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 24325, 24614);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 24325, 24614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 24325, 24614);
            }
        }

        private string _parameterSetName;

        private string _helpMessage;

        private string _helpMessageBaseName;

        private string _helpMessageResourceId;

        public string ExperimentName { get; }

        public ExperimentAction ExperimentAction { get; }

        internal bool ToHide
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 25311, 25354);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 25314, 25354);
                    return f_1236_25314_25329() == ExperimentAction.Hide;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 25311, 25354);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 25311, 25354);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 25311, 25354);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool ToShow
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 25386, 25429);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 25389, 25429);
                    return f_1236_25389_25404() == ExperimentAction.Show;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 25386, 25429);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 25386, 25429);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 25386, 25429);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ExperimentAction EffectiveAction
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 25614, 25904);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 25650, 25845) || true) && (_effectiveAction == ExperimentAction.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 25650, 25845);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 25737, 25826);

                        _effectiveAction = f_1236_25756_25825(f_1236_25792_25806(), f_1236_25808_25824());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 25650, 25845);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 25865, 25889);

                    return _effectiveAction;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 25614, 25904);

                    string
                    f_1236_25792_25806()
                    {
                        var return_v = ExperimentName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 25792, 25806);
                        return return_v;
                    }


                    System.Management.Automation.ExperimentAction
                    f_1236_25808_25824()
                    {
                        var return_v = ExperimentAction;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 25808, 25824);
                        return return_v;
                    }


                    System.Management.Automation.ExperimentAction
                    f_1236_25756_25825(string
                    experimentName, System.Management.Automation.ExperimentAction
                    experimentAction)
                    {
                        var return_v = ExperimentalFeature.GetActionToTake(experimentName, experimentAction);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 25756, 25825);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 25549, 25915);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 25549, 25915);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ExperimentAction _effectiveAction;

        public int Position { get; set; }

        public string ParameterSetName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 26528, 26548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 26531, 26548);
                    return _parameterSetName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 26528, 26548);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 26469, 26677);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 26469, 26677);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 26569, 26665);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 26572, 26665);
                    _parameterSetName = (DynAbs.Tracing.TraceSender.Conditional_F1(1236, 26592, 26619) || ((f_1236_26592_26619(value) && DynAbs.Tracing.TraceSender.Conditional_F2(1236, 26622, 26657)) || DynAbs.Tracing.TraceSender.Conditional_F3(1236, 26660, 26665))) ? ParameterAttribute.AllParameterSets : value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 26569, 26665);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 26469, 26677);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 26469, 26677);
                }
            }
        }

        public bool Mandatory { get; set; }

        public bool ValueFromPipeline { get; set; }

        public bool ValueFromPipelineByPropertyName { get; set; }

        public bool ValueFromRemainingArguments { get; set; }

        public string HelpMessage
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 28298, 28313);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 28301, 28313);
                    return _helpMessage;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 28298, 28313);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 28244, 28587);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 28244, 28587);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 28330, 28576);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 28366, 28520) || true) && (f_1236_28370_28397(value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 28366, 28520);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 28439, 28501);

                        throw f_1236_28445_28500(nameof(HelpMessage));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 28366, 28520);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 28540, 28561);

                    _helpMessage = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 28330, 28576);

                    bool
                    f_1236_28370_28397(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 28370, 28397);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentException
                    f_1236_28445_28500(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 28445, 28500);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 28244, 28587);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 28244, 28587);
                }
            }
        }

        public string HelpMessageBaseName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 28974, 28997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 28977, 28997);
                    return _helpMessageBaseName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 28974, 28997);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 28912, 29287);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 28912, 29287);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 29014, 29276);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 29050, 29212) || true) && (f_1236_29054_29081(value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 29050, 29212);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 29123, 29193);

                        throw f_1236_29129_29192(nameof(HelpMessageBaseName));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 29050, 29212);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 29232, 29261);

                    _helpMessageBaseName = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 29014, 29276);

                    bool
                    f_1236_29054_29081(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 29054, 29081);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentException
                    f_1236_29129_29192(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 29129, 29192);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 28912, 29287);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 28912, 29287);
                }
            }
        }

        public string HelpMessageResourceId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 29667, 29692);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 29670, 29692);
                    return _helpMessageResourceId;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 29667, 29692);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 29603, 29986);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 29603, 29986);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 29709, 29975);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 29745, 29909) || true) && (f_1236_29749_29776(value))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 29745, 29909);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 29818, 29890);

                        throw f_1236_29824_29889(nameof(HelpMessageResourceId));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 29745, 29909);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 29929, 29960);

                    _helpMessageResourceId = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 29709, 29975);

                    bool
                    f_1236_29749_29776(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 29749, 29776);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentException
                    f_1236_29824_29889(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 29824, 29889);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 29603, 29986);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 29603, 29986);
                }
            }
        }

        public bool DontShow { get; set; }

        static ParameterAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 23653, 30296);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 23956, 23995);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 23653, 30296);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 23653, 30296);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 23653, 30296);

        int
        f_1236_24433_24506(string
        experimentName, System.Management.Automation.ExperimentAction
        experimentAction)
        {
            ExperimentalAttribute.ValidateArguments(experimentName, experimentAction);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 24433, 24506);
            return 0;
        }


        System.Management.Automation.ExperimentAction
        f_1236_25314_25329()
        {
            var return_v = EffectiveAction;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 25314, 25329);
            return return_v;
        }


        System.Management.Automation.ExperimentAction
        f_1236_25389_25404()
        {
            var return_v = EffectiveAction;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 25389, 25404);
            return return_v;
        }


        bool
        f_1236_26592_26619(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 26592, 26619);
            return return_v;
        }

    }
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class PSTypeNameAttribute : Attribute
    {
        public string PSTypeName { get; private set; }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly")]
        public PSTypeNameAttribute(string psTypeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 31163, 31528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 30963, 31009);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 31326, 31472) || true) && (f_1236_31330_31362(psTypeName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 31326, 31472);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 31396, 31457);

                    throw f_1236_31402_31456(nameof(psTypeName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 31326, 31472);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 31488, 31517);

                this.PSTypeName = psTypeName;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 31163, 31528);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 31163, 31528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 31163, 31528);
            }
        }

        static PSTypeNameAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 30758, 31535);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 30758, 31535);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 30758, 31535);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 30758, 31535);

        bool
        f_1236_31330_31362(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 31330, 31362);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1236_31402_31456(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 31402, 31456);
            return return_v;
        }

    }
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class SupportsWildcardsAttribute : ParsingBaseAttribute
    {
        public SupportsWildcardsAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 31638, 31795);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 31638, 31795);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 31638, 31795);
        }


        static SupportsWildcardsAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 31638, 31795);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 31638, 31795);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 31638, 31795);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 31638, 31795);
    }
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class PSDefaultValueAttribute : ParsingBaseAttribute
    {
        public object Value { get; set; }

        public string Help { get; set; }

        public PSDefaultValueAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 32212, 32823);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 32609, 32642);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 32784, 32816);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 32212, 32823);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 32212, 32823);
        }


        static PSDefaultValueAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 32212, 32823);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 32212, 32823);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 32212, 32823);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 32212, 32823);
    }
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Constructor | AttributeTargets.Event)]
    public sealed class HiddenAttribute : ParsingBaseAttribute
    {
        public HiddenAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 33035, 33263);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 33035, 33263);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 33035, 33263);
        }


        static HiddenAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 33035, 33263);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 33035, 33263);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 33035, 33263);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 33035, 33263);
    }
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class ValidateLengthAttribute : ValidateEnumeratedArgumentsAttribute
    {
        public int MinLength { get; }

        public int MaxLength { get; }

        protected override void ValidateElement(object element)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 34553, 35594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 34633, 34673);

                string
                objectString = element as string
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 34687, 34929) || true) && (objectString == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 34687, 34929);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 34745, 34914);

                    throw f_1236_34751_34913("ValidateLengthNotString", null, f_1236_34880_34912());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 34687, 34929);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 34945, 34975);

                int
                len = f_1236_34955_34974(objectString)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 34991, 35279) || true) && (len < f_1236_35001_35010())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 34991, 35279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 35044, 35264);

                    throw f_1236_35050_35263("ValidateLengthMinLengthFailure", null, f_1236_35186_35225(), f_1236_35248_35257(), len);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 34991, 35279);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 35295, 35583) || true) && (len > f_1236_35305_35314())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 35295, 35583);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 35348, 35568);

                    throw f_1236_35354_35567("ValidateLengthMaxLengthFailure", null, f_1236_35490_35529(), f_1236_35552_35561(), len);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 35295, 35583);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 34553, 35594);

                string
                f_1236_34880_34912()
                {
                    var return_v = Metadata.ValidateLengthNotString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 34880, 34912);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_34751_34913(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 34751, 34913);
                    return return_v;
                }


                int
                f_1236_34955_34974(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 34955, 34974);
                    return return_v;
                }


                int
                f_1236_35001_35010()
                {
                    var return_v = MinLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 35001, 35010);
                    return return_v;
                }


                string
                f_1236_35186_35225()
                {
                    var return_v = Metadata.ValidateLengthMinLengthFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 35186, 35225);
                    return return_v;
                }


                int
                f_1236_35248_35257()
                {
                    var return_v = MinLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 35248, 35257);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_35050_35263(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 35050, 35263);
                    return return_v;
                }


                int
                f_1236_35305_35314()
                {
                    var return_v = MaxLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 35305, 35314);
                    return return_v;
                }


                string
                f_1236_35490_35529()
                {
                    var return_v = Metadata.ValidateLengthMaxLengthFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 35490, 35529);
                    return return_v;
                }


                int
                f_1236_35552_35561()
                {
                    var return_v = MaxLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 35552, 35561);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_35354_35567(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 35354, 35567);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 34553, 35594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 34553, 35594);
            }
        }

        public ValidateLengthAttribute(int minLength, int maxLength) : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 36087, 36876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 33833, 33862);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 33971, 34000);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 36181, 36328) || true) && (minLength < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 36181, 36328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 36232, 36313);

                    throw f_1236_36238_36312(nameof(minLength), minLength);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 36181, 36328);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 36344, 36492) || true) && (maxLength <= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 36344, 36492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 36396, 36477);

                    throw f_1236_36402_36476(nameof(maxLength), maxLength);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 36344, 36492);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 36508, 36791) || true) && (maxLength < minLength)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 36508, 36791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 36567, 36776);

                    throw f_1236_36573_36775("ValidateLengthMaxLengthSmallerThanMinLength", null, f_1236_36722_36774());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 36508, 36791);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 36807, 36829);

                MinLength = minLength;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 36843, 36865);

                MaxLength = maxLength;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 36087, 36876);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 36087, 36876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 36087, 36876);
            }
        }

        static ValidateLengthAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 33563, 36883);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 33563, 36883);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 33563, 36883);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 33563, 36883);

        System.Management.Automation.PSArgumentOutOfRangeException
        f_1236_36238_36312(string
        paramName, int
        actualValue)
        {
            var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 36238, 36312);
            return return_v;
        }


        System.Management.Automation.PSArgumentOutOfRangeException
        f_1236_36402_36476(string
        paramName, int
        actualValue)
        {
            var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 36402, 36476);
            return return_v;
        }


        string
        f_1236_36722_36774()
        {
            var return_v = Metadata.ValidateLengthMaxLengthSmallerThanMinLength;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 36722, 36774);
            return return_v;
        }


        System.Management.Automation.ValidationMetadataException
        f_1236_36573_36775(string
        errorId, System.Exception
        innerException, string
        resourceStr, params object[]
        arguments)
        {
            var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 36573, 36775);
            return return_v;
        }

    }

    /// <summary>
    /// Predefined range kind to use with ValidateRangeAttribute.
    /// </summary>
    public enum ValidateRangeKind
    {
        /// <summary>
        /// Range is greater than 0.
        /// </summary>
        Positive,

        /// <summary>
        /// Range is greater than or equal to 0.
        /// </summary>
        NonNegative,

        /// <summary>
        /// Range is less than 0.
        /// </summary>
        Negative,

        /// <summary>
        /// Range is less than or equal to 0.
        /// </summary>
        NonPositive
    }
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class ValidateRangeAttribute : ValidateEnumeratedArgumentsAttribute
    {
        public object MinRange { get; }

        private IComparable _minComparable;

        public object MaxRange { get; }

        private IComparable _maxComparable;

        private Type _promotedType;

        internal ValidateRangeKind? RangeKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 38600, 38613);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 38603, 38613);
                    return _rangeKind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 38600, 38613);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 38556, 38616);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 38556, 38616);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ValidateRangeKind? _rangeKind;

        protected override void ValidateElement(object element)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 39258, 39963);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 39338, 39578) || true) && (element == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 39338, 39578);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 39391, 39563);

                    throw f_1236_39397_39562("ArgumentIsEmpty", null, f_1236_39530_39561());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 39338, 39578);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 39594, 39622);

                var
                o = element as PSObject
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 39636, 39721) || true) && (o != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 39636, 39721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 39683, 39706);

                    element = f_1236_39693_39705(o);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 39636, 39721);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 39737, 39952) || true) && (f_1236_39741_39760(_rangeKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 39737, 39952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 39794, 39848);

                    f_1236_39794_39847(this, element, _rangeKind);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 39737, 39952);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 39737, 39952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 39914, 39937);

                    f_1236_39914_39936(this, element);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 39737, 39952);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 39258, 39963);

                string
                f_1236_39530_39561()
                {
                    var return_v = Metadata.ValidateNotNullFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 39530, 39561);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_39397_39562(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 39397, 39562);
                    return return_v;
                }


                object
                f_1236_39693_39705(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 39693, 39705);
                    return return_v;
                }


                bool
                f_1236_39741_39760(System.Management.Automation.ValidateRangeKind?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 39741, 39760);
                    return return_v;
                }


                int
                f_1236_39794_39847(System.Management.Automation.ValidateRangeAttribute
                this_param, object
                element, System.Management.Automation.ValidateRangeKind?
                rangeKind)
                {
                    this_param.ValidateRange(element, (System.Management.Automation.ValidateRangeKind)rangeKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 39794, 39847);
                    return 0;
                }


                int
                f_1236_39914_39936(System.Management.Automation.ValidateRangeAttribute
                this_param, object
                element)
                {
                    this_param.ValidateRange(element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 39914, 39936);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 39258, 39963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 39258, 39963);
            }
        }

        public ValidateRangeAttribute(object minRange, object maxRange) : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 40740, 43377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 37938, 37969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 38001, 38015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 38124, 38155);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 38187, 38201);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 38431, 38444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 38655, 38665);
                object minResultValue = default(object);
                object maxResultValue = default(object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 40837, 40969) || true) && (minRange == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 40837, 40969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 40891, 40954);

                    throw f_1236_40897_40953(nameof(minRange));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 40837, 40969);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 40985, 41117) || true) && (maxRange == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 40985, 41117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 41039, 41102);

                    throw f_1236_41045_41101(nameof(maxRange));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 40985, 41117);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 41133, 42298) || true) && (f_1236_41137_41155(maxRange) != f_1236_41159_41177(minRange))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 41133, 42298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 41211, 41231);

                    bool
                    failure = true
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 41249, 41319);

                    _promotedType = f_1236_41265_41318(f_1236_41279_41297(minRange), f_1236_41299_41317(maxRange));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 41337, 41815) || true) && (_promotedType != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 41337, 41815);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 41404, 41796) || true) && (f_1236_41408_41491(minRange, _promotedType, out minResultValue) && (DynAbs.Tracing.TraceSender.Expression_True(1236, 41408, 41603) && f_1236_41520_41603(maxRange, _promotedType, out maxResultValue)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 41404, 41796);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 41653, 41679);

                            minRange = minResultValue;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 41705, 41731);

                            maxRange = maxResultValue;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 41757, 41773);

                            failure = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 41404, 41796);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 41337, 41815);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 41835, 42182) || true) && (failure)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 41835, 42182);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 41888, 42163);

                        throw f_1236_41894_42162("MinRangeNotTheSameTypeOfMaxRange", null, f_1236_42044_42086(), f_1236_42113_42136(f_1236_42113_42131(minRange)), f_1236_42138_42161(f_1236_42138_42156(maxRange)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 41835, 42182);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 41133, 42298);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 41133, 42298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 42248, 42283);

                    _promotedType = f_1236_42264_42282(minRange);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 41133, 42298);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 42409, 42450);

                _minComparable = minRange as IComparable;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 42464, 42711) || true) && (_minComparable == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 42464, 42711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 42524, 42696);

                    throw f_1236_42530_42695("MinRangeNotIComparable", null, f_1236_42658_42694());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 42464, 42711);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 42727, 42768);

                _maxComparable = maxRange as IComparable;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 42782, 42880);

                f_1236_42782_42879(_maxComparable != null, "maxComparable comes from a type that is IComparable");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 43015, 43296) || true) && (f_1236_43019_43053(_minComparable, maxRange) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 43015, 43296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 43091, 43281);

                    throw f_1236_43097_43280("MaxRangeSmallerThanMinRange", null, f_1236_43230_43279());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 43015, 43296);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 43312, 43332);

                MinRange = minRange;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 43346, 43366);

                MaxRange = maxRange;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 40740, 43377);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 40740, 43377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 40740, 43377);
            }
        }

        public ValidateRangeAttribute(ValidateRangeKind kind) : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 43608, 43724);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 37938, 37969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 38001, 38015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 38124, 38155);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 38187, 38201);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 38431, 38444);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 38655, 38665);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 43695, 43713);

                _rangeKind = kind;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 43608, 43724);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 43608, 43724);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 43608, 43724);
            }
        }

        private void ValidateRange(object element, ValidateRangeKind rangeKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 43736, 46955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 43832, 43896);

                Type
                commonType = f_1236_43850_43895(typeof(int), f_1236_43877_43894(element))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 43910, 44254) || true) && (commonType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 43910, 44254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 43966, 44239);

                    throw f_1236_43972_44238("ValidationRangeElementType", innerException: null, f_1236_44120_44153(), f_1236_44176_44198(f_1236_44176_44193(element)), f_1236_44221_44237(typeof(int)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 43910, 44254);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 44270, 44289);

                object
                resultValue
                = default(object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 44303, 44331);

                IComparable
                dynamicZero = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 44347, 45000) || true) && (f_1236_44351_44420(element, commonType, out resultValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 44347, 45000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 44454, 44476);

                    element = resultValue;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 44496, 44663) || true) && (f_1236_44500_44563(0, commonType, out resultValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 44496, 44663);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 44605, 44644);

                        dynamicZero = (IComparable)resultValue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 44496, 44663);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 44347, 45000);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 44347, 45000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 44729, 44985);

                    throw f_1236_44735_44984("ValidationRangeElementType", null, f_1236_44867_44900(), f_1236_44923_44945(f_1236_44923_44940(element)), f_1236_44968_44983(commonType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 44347, 45000);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 45016, 46944);

                switch (rangeKind)
                {

                    case ValidateRangeKind.Positive:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 45016, 46944);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 45121, 45485) || true) && (f_1236_45125_45155(dynamicZero, element) >= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 45121, 45485);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 45210, 45462);

                            throw f_1236_45216_45461("ValidateRangePositiveFailure", null, f_1236_45374_45411(), f_1236_45442_45460(element));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 45121, 45485);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1236, 45509, 45515);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 45016, 46944);

                    case ValidateRangeKind.NonNegative:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 45016, 46944);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 45590, 45959) || true) && (f_1236_45594_45624(dynamicZero, element) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 45590, 45959);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 45678, 45936);

                            throw f_1236_45684_45935("ValidateRangeNonNegativeFailure", null, f_1236_45845_45885(), f_1236_45916_45934(element));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 45590, 45959);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1236, 45983, 45989);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 45016, 46944);

                    case ValidateRangeKind.Negative:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 45016, 46944);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 46061, 46425) || true) && (f_1236_46065_46095(dynamicZero, element) <= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 46061, 46425);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 46150, 46402);

                            throw f_1236_46156_46401("ValidateRangeNegativeFailure", null, f_1236_46314_46351(), f_1236_46382_46400(element));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 46061, 46425);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1236, 46449, 46455);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 45016, 46944);

                    case ValidateRangeKind.NonPositive:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 45016, 46944);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 46530, 46899) || true) && (f_1236_46534_46564(dynamicZero, element) < 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 46530, 46899);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 46618, 46876);

                            throw f_1236_46624_46875("ValidateRangeNonPositiveFailure", null, f_1236_46785_46825(), f_1236_46856_46874(element));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 46530, 46899);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1236, 46923, 46929);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 45016, 46944);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 43736, 46955);

                System.Type
                f_1236_43877_43894(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 43877, 43894);
                    return return_v;
                }


                System.Type
                f_1236_43850_43895(System.Type
                minType, System.Type
                maxType)
                {
                    var return_v = GetCommonType(minType, maxType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 43850, 43895);
                    return return_v;
                }


                string
                f_1236_44120_44153()
                {
                    var return_v = Metadata.ValidateRangeElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 44120, 44153);
                    return return_v;
                }


                System.Type
                f_1236_44176_44193(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 44176, 44193);
                    return return_v;
                }


                string
                f_1236_44176_44198(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 44176, 44198);
                    return return_v;
                }


                string
                f_1236_44221_44237(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 44221, 44237);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_43972_44238(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException: innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 43972, 44238);
                    return return_v;
                }


                bool
                f_1236_44351_44420(object
                valueToConvert, System.Type
                resultType, out object
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo(valueToConvert, resultType, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 44351, 44420);
                    return return_v;
                }


                bool
                f_1236_44500_44563(int
                valueToConvert, System.Type
                resultType, out object
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo((object)valueToConvert, resultType, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 44500, 44563);
                    return return_v;
                }


                string
                f_1236_44867_44900()
                {
                    var return_v = Metadata.ValidateRangeElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 44867, 44900);
                    return return_v;
                }


                System.Type
                f_1236_44923_44940(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 44923, 44940);
                    return return_v;
                }


                string
                f_1236_44923_44945(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 44923, 44945);
                    return return_v;
                }


                string
                f_1236_44968_44983(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 44968, 44983);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_44735_44984(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 44735, 44984);
                    return return_v;
                }


                int
                f_1236_45125_45155(System.IComparable
                this_param, object
                obj)
                {
                    var return_v = this_param.CompareTo(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 45125, 45155);
                    return return_v;
                }


                string
                f_1236_45374_45411()
                {
                    var return_v = Metadata.ValidateRangePositiveFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 45374, 45411);
                    return return_v;
                }


                string?
                f_1236_45442_45460(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 45442, 45460);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_45216_45461(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 45216, 45461);
                    return return_v;
                }


                int
                f_1236_45594_45624(System.IComparable
                this_param, object
                obj)
                {
                    var return_v = this_param.CompareTo(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 45594, 45624);
                    return return_v;
                }


                string
                f_1236_45845_45885()
                {
                    var return_v = Metadata.ValidateRangeNonNegativeFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 45845, 45885);
                    return return_v;
                }


                string?
                f_1236_45916_45934(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 45916, 45934);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_45684_45935(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 45684, 45935);
                    return return_v;
                }


                int
                f_1236_46065_46095(System.IComparable
                this_param, object
                obj)
                {
                    var return_v = this_param.CompareTo(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 46065, 46095);
                    return return_v;
                }


                string
                f_1236_46314_46351()
                {
                    var return_v = Metadata.ValidateRangeNegativeFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 46314, 46351);
                    return return_v;
                }


                string?
                f_1236_46382_46400(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 46382, 46400);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_46156_46401(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 46156, 46401);
                    return return_v;
                }


                int
                f_1236_46534_46564(System.IComparable
                this_param, object
                obj)
                {
                    var return_v = this_param.CompareTo(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 46534, 46564);
                    return return_v;
                }


                string
                f_1236_46785_46825()
                {
                    var return_v = Metadata.ValidateRangeNonPositiveFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 46785, 46825);
                    return return_v;
                }


                string?
                f_1236_46856_46874(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 46856, 46874);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_46624_46875(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 46624, 46875);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 43736, 46955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 43736, 46955);
            }
        }

        private void ValidateRange(object element)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 46967, 48596);
                object resultValue = default(object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 47135, 47754) || true) && (f_1236_47139_47156(element) != _promotedType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 47135, 47754);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 47207, 47739) || true) && (f_1236_47211_47290(element, _promotedType, out resultValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 47207, 47739);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 47332, 47354);

                        element = resultValue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 47207, 47739);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 47207, 47739);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 47436, 47720);

                        throw f_1236_47442_47719("ValidationRangeElementType", null, f_1236_47586_47619(), f_1236_47646_47668(f_1236_47646_47663(element)), f_1236_47695_47718(f_1236_47695_47713(f_1236_47695_47703())));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 47207, 47739);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 47135, 47754);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 47859, 48215) || true) && (f_1236_47863_47896(_minComparable, element) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 47859, 48215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 47934, 48200);

                    throw f_1236_47940_48199("ValidateRangeTooSmall", null, f_1236_48067_48115(), f_1236_48138_48156(element), f_1236_48179_48198(f_1236_48179_48187()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 47859, 48215);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 48231, 48585) || true) && (f_1236_48235_48268(_maxComparable, element) < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 48231, 48585);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 48306, 48570);

                    throw f_1236_48312_48569("ValidateRangeTooBig", null, f_1236_48437_48485(), f_1236_48508_48526(element), f_1236_48549_48568(f_1236_48549_48557()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 48231, 48585);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 46967, 48596);

                System.Type
                f_1236_47139_47156(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 47139, 47156);
                    return return_v;
                }


                bool
                f_1236_47211_47290(object
                valueToConvert, System.Type
                resultType, out object
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo(valueToConvert, resultType, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 47211, 47290);
                    return return_v;
                }


                string
                f_1236_47586_47619()
                {
                    var return_v = Metadata.ValidateRangeElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 47586, 47619);
                    return return_v;
                }


                System.Type
                f_1236_47646_47663(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 47646, 47663);
                    return return_v;
                }


                string
                f_1236_47646_47668(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 47646, 47668);
                    return return_v;
                }


                object
                f_1236_47695_47703()
                {
                    var return_v = MinRange;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 47695, 47703);
                    return return_v;
                }


                System.Type
                f_1236_47695_47713(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 47695, 47713);
                    return return_v;
                }


                string
                f_1236_47695_47718(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 47695, 47718);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_47442_47719(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 47442, 47719);
                    return return_v;
                }


                int
                f_1236_47863_47896(System.IComparable
                this_param, object
                obj)
                {
                    var return_v = this_param.CompareTo(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 47863, 47896);
                    return return_v;
                }


                string
                f_1236_48067_48115()
                {
                    var return_v = Metadata.ValidateRangeSmallerThanMinRangeFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 48067, 48115);
                    return return_v;
                }


                string?
                f_1236_48138_48156(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 48138, 48156);
                    return return_v;
                }


                object
                f_1236_48179_48187()
                {
                    var return_v = MinRange;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 48179, 48187);
                    return return_v;
                }


                string?
                f_1236_48179_48198(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 48179, 48198);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_47940_48199(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 47940, 48199);
                    return return_v;
                }


                int
                f_1236_48235_48268(System.IComparable
                this_param, object
                obj)
                {
                    var return_v = this_param.CompareTo(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 48235, 48268);
                    return return_v;
                }


                string
                f_1236_48437_48485()
                {
                    var return_v = Metadata.ValidateRangeGreaterThanMaxRangeFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 48437, 48485);
                    return return_v;
                }


                string?
                f_1236_48508_48526(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 48508, 48526);
                    return return_v;
                }


                object
                f_1236_48549_48557()
                {
                    var return_v = MaxRange;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 48549, 48557);
                    return return_v;
                }


                string?
                f_1236_48549_48568(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 48549, 48568);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_48312_48569(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 48312, 48569);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 46967, 48596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 46967, 48596);
            }
        }

        private static Type GetCommonType(Type minType, Type maxType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1236, 48608, 50531);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 48694, 48717);

                Type
                resultType = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 48733, 48796);

                TypeCode
                minTypeCode = f_1236_48756_48795(minType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 48810, 48873);

                TypeCode
                maxTypeCode = f_1236_48833_48872(maxType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 48887, 48974);

                TypeCode
                opTypeCode = (DynAbs.Tracing.TraceSender.Conditional_F1(1236, 48909, 48945) || (((int)minTypeCode >= (int)maxTypeCode && DynAbs.Tracing.TraceSender.Conditional_F2(1236, 48948, 48959)) || DynAbs.Tracing.TraceSender.Conditional_F3(1236, 48962, 48973))) ? minTypeCode : maxTypeCode
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 48988, 50486) || true) && ((int)opTypeCode <= (int)TypeCode.Int32)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 48988, 50486);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 49064, 49089);

                    resultType = typeof(int);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 48988, 50486);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 48988, 50486);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 49123, 50486) || true) && ((int)opTypeCode <= (int)TypeCode.UInt32)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 49123, 50486);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 49400, 49565);

                        resultType = (DynAbs.Tracing.TraceSender.Conditional_F1(1236, 49413, 49511) || ((f_1236_49413_49460(minTypeCode) || (DynAbs.Tracing.TraceSender.Expression_False(1236, 49413, 49511) || f_1236_49464_49511(maxTypeCode)) && DynAbs.Tracing.TraceSender.Conditional_F2(1236, 49535, 49549)) || DynAbs.Tracing.TraceSender.Conditional_F3(1236, 49552, 49564))) ? typeof(double) : typeof(uint);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 49123, 50486);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 49123, 50486);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 49599, 50486) || true) && ((int)opTypeCode <= (int)TypeCode.Int64)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 49599, 50486);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 49675, 49701);

                            resultType = typeof(long);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 49599, 50486);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 49599, 50486);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 49735, 50486) || true) && ((int)opTypeCode <= (int)TypeCode.UInt64)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 49735, 50486);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 50012, 50178);

                                resultType = (DynAbs.Tracing.TraceSender.Conditional_F1(1236, 50025, 50123) || ((f_1236_50025_50072(minTypeCode) || (DynAbs.Tracing.TraceSender.Expression_False(1236, 50025, 50123) || f_1236_50076_50123(maxTypeCode)) && DynAbs.Tracing.TraceSender.Conditional_F2(1236, 50147, 50161)) || DynAbs.Tracing.TraceSender.Conditional_F3(1236, 50164, 50177))) ? typeof(double) : typeof(ulong);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 49735, 50486);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 49735, 50486);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 50212, 50486) || true) && (opTypeCode == TypeCode.Decimal)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 50212, 50486);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 50280, 50309);

                                    resultType = typeof(decimal);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 50212, 50486);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 50212, 50486);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 50343, 50486) || true) && (opTypeCode == TypeCode.Single || (DynAbs.Tracing.TraceSender.Expression_False(1236, 50347, 50409) || opTypeCode == TypeCode.Double))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 50343, 50486);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 50443, 50471);

                                        resultType = typeof(double);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 50343, 50486);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 50212, 50486);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 49735, 50486);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 49599, 50486);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 49123, 50486);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 48988, 50486);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 50502, 50520);

                return resultType;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1236, 48608, 50531);

                System.TypeCode
                f_1236_48756_48795(System.Type
                type)
                {
                    var return_v = LanguagePrimitives.GetTypeCode(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 48756, 48795);
                    return return_v;
                }


                System.TypeCode
                f_1236_48833_48872(System.Type
                type)
                {
                    var return_v = LanguagePrimitives.GetTypeCode(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 48833, 48872);
                    return return_v;
                }


                bool
                f_1236_49413_49460(System.TypeCode
                typeCode)
                {
                    var return_v = LanguagePrimitives.IsSignedInteger(typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 49413, 49460);
                    return return_v;
                }


                bool
                f_1236_49464_49511(System.TypeCode
                typeCode)
                {
                    var return_v = LanguagePrimitives.IsSignedInteger(typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 49464, 49511);
                    return return_v;
                }


                bool
                f_1236_50025_50072(System.TypeCode
                typeCode)
                {
                    var return_v = LanguagePrimitives.IsSignedInteger(typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 50025, 50072);
                    return return_v;
                }


                bool
                f_1236_50076_50123(System.TypeCode
                typeCode)
                {
                    var return_v = LanguagePrimitives.IsSignedInteger(typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 50076, 50123);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 48608, 50531);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 48608, 50531);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ValidateRangeAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 37670, 50538);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 37670, 50538);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 37670, 50538);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 37670, 50538);

        System.Management.Automation.PSArgumentNullException
        f_1236_40897_40953(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 40897, 40953);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1236_41045_41101(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 41045, 41101);
            return return_v;
        }


        System.Type
        f_1236_41137_41155(object
        this_param)
        {
            var return_v = this_param.GetType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 41137, 41155);
            return return_v;
        }


        System.Type
        f_1236_41159_41177(object
        this_param)
        {
            var return_v = this_param.GetType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 41159, 41177);
            return return_v;
        }


        System.Type
        f_1236_41279_41297(object
        this_param)
        {
            var return_v = this_param.GetType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 41279, 41297);
            return return_v;
        }


        System.Type
        f_1236_41299_41317(object
        this_param)
        {
            var return_v = this_param.GetType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 41299, 41317);
            return return_v;
        }


        System.Type
        f_1236_41265_41318(System.Type
        minType, System.Type
        maxType)
        {
            var return_v = GetCommonType(minType, maxType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 41265, 41318);
            return return_v;
        }


        bool
        f_1236_41408_41491(object
        valueToConvert, System.Type
        resultType, out object
        result)
        {
            var return_v = LanguagePrimitives.TryConvertTo(valueToConvert, resultType, out result);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 41408, 41491);
            return return_v;
        }


        bool
        f_1236_41520_41603(object
        valueToConvert, System.Type
        resultType, out object
        result)
        {
            var return_v = LanguagePrimitives.TryConvertTo(valueToConvert, resultType, out result);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 41520, 41603);
            return return_v;
        }


        string
        f_1236_42044_42086()
        {
            var return_v = Metadata.ValidateRangeMinRangeMaxRangeType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 42044, 42086);
            return return_v;
        }


        System.Type
        f_1236_42113_42131(object
        this_param)
        {
            var return_v = this_param.GetType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 42113, 42131);
            return return_v;
        }


        string
        f_1236_42113_42136(System.Type
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 42113, 42136);
            return return_v;
        }


        System.Type
        f_1236_42138_42156(object
        this_param)
        {
            var return_v = this_param.GetType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 42138, 42156);
            return return_v;
        }


        string
        f_1236_42138_42161(System.Type
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 42138, 42161);
            return return_v;
        }


        System.Management.Automation.ValidationMetadataException
        f_1236_41894_42162(string
        errorId, System.Exception
        innerException, string
        resourceStr, params object[]
        arguments)
        {
            var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 41894, 42162);
            return return_v;
        }


        System.Type
        f_1236_42264_42282(object
        this_param)
        {
            var return_v = this_param.GetType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 42264, 42282);
            return return_v;
        }


        string
        f_1236_42658_42694()
        {
            var return_v = Metadata.ValidateRangeNotIComparable;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 42658, 42694);
            return return_v;
        }


        System.Management.Automation.ValidationMetadataException
        f_1236_42530_42695(string
        errorId, System.Exception
        innerException, string
        resourceStr, params object[]
        arguments)
        {
            var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 42530, 42695);
            return return_v;
        }


        int
        f_1236_42782_42879(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 42782, 42879);
            return 0;
        }


        int
        f_1236_43019_43053(System.IComparable
        this_param, object
        obj)
        {
            var return_v = this_param.CompareTo(obj);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 43019, 43053);
            return return_v;
        }


        string
        f_1236_43230_43279()
        {
            var return_v = Metadata.ValidateRangeMaxRangeSmallerThanMinRange;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 43230, 43279);
            return return_v;
        }


        System.Management.Automation.ValidationMetadataException
        f_1236_43097_43280(string
        errorId, System.Exception
        innerException, string
        resourceStr, params object[]
        arguments)
        {
            var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 43097, 43280);
            return return_v;
        }

    }
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class ValidatePatternAttribute : ValidateEnumeratedArgumentsAttribute
    {
        public string RegexPattern { get; }

        public RegexOptions Options { set; get; }

        public string ErrorMessage { get; set; }

        protected override void ValidateElement(object element)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 52180, 53134);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 52260, 52500) || true) && (element == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 52260, 52500);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 52313, 52485);

                    throw f_1236_52319_52484("ArgumentIsEmpty", null, f_1236_52452_52483());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 52260, 52500);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 52516, 52557);

                string
                objectString = f_1236_52538_52556(element)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 52571, 52616);

                var
                regex = f_1236_52583_52615(f_1236_52593_52605(), f_1236_52607_52614())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 52630, 52670);

                Match
                match = f_1236_52644_52669(regex, objectString)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 52684, 53123) || true) && (f_1236_52688_52702_M(!match.Success))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 52684, 53123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 52736, 52887);

                    var
                    errorMessageFormat = (DynAbs.Tracing.TraceSender.Conditional_F1(1236, 52761, 52795) || ((f_1236_52761_52795(f_1236_52782_52794()) && DynAbs.Tracing.TraceSender.Conditional_F2(1236, 52819, 52850)) || DynAbs.Tracing.TraceSender.Conditional_F3(1236, 52874, 52886))) ? f_1236_52819_52850() : f_1236_52874_52886()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 52905, 53108);

                    throw f_1236_52911_53107("ValidatePatternFailure", null, errorMessageFormat, objectString, f_1236_53094_53106());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 52684, 53123);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 52180, 53134);

                string
                f_1236_52452_52483()
                {
                    var return_v = Metadata.ValidateNotNullFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 52452, 52483);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_52319_52484(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 52319, 52484);
                    return return_v;
                }


                string?
                f_1236_52538_52556(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 52538, 52556);
                    return return_v;
                }


                string
                f_1236_52593_52605()
                {
                    var return_v = RegexPattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 52593, 52605);
                    return return_v;
                }


                System.Text.RegularExpressions.RegexOptions
                f_1236_52607_52614()
                {
                    var return_v = Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 52607, 52614);
                    return return_v;
                }


                System.Text.RegularExpressions.Regex
                f_1236_52583_52615(string
                pattern, System.Text.RegularExpressions.RegexOptions
                options)
                {
                    var return_v = new System.Text.RegularExpressions.Regex(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 52583, 52615);
                    return return_v;
                }


                System.Text.RegularExpressions.Match
                f_1236_52644_52669(System.Text.RegularExpressions.Regex
                this_param, string
                input)
                {
                    var return_v = this_param.Match(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 52644, 52669);
                    return return_v;
                }


                bool
                f_1236_52688_52702_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 52688, 52702);
                    return return_v;
                }


                string
                f_1236_52782_52794()
                {
                    var return_v = ErrorMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 52782, 52794);
                    return return_v;
                }


                bool
                f_1236_52761_52795(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 52761, 52795);
                    return return_v;
                }


                string
                f_1236_52819_52850()
                {
                    var return_v = Metadata.ValidatePatternFailure
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 52819, 52850);
                    return return_v;
                }


                string
                f_1236_52874_52886()
                {
                    var return_v = ErrorMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 52874, 52886);
                    return return_v;
                }


                string
                f_1236_53094_53106()
                {
                    var return_v = RegexPattern;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 53094, 53106);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_52911_53107(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 52911, 53107);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 52180, 53134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 52180, 53134);
            }
        }

        public ValidatePatternAttribute(string regexPattern)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 53443, 53725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 50960, 50995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 51128, 51196);
                this.Options = RegexOptions.IgnoreCase;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 51742, 51782);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 53520, 53670) || true) && (f_1236_53524_53558(regexPattern))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 53520, 53670);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 53592, 53655);

                    throw f_1236_53598_53654(nameof(regexPattern));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 53520, 53670);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 53686, 53714);

                RegexPattern = regexPattern;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 53443, 53725);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 53443, 53725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 53443, 53725);
            }
        }

        static ValidatePatternAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 50673, 53732);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 50673, 53732);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 50673, 53732);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 50673, 53732);

        bool
        f_1236_53524_53558(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 53524, 53558);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1236_53598_53654(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 53598, 53654);
            return return_v;
        }

    }
    public sealed class ValidateScriptAttribute : ValidateEnumeratedArgumentsAttribute
    {
        public string ErrorMessage { get; set; }

        public ScriptBlock ScriptBlock { get; }

        protected override void ValidateElement(object element)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 54913, 56132);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 54993, 55233) || true) && (element == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 54993, 55233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 55046, 55218);

                    throw f_1236_55052_55217("ArgumentIsEmpty", null, f_1236_55185_55216());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 54993, 55233);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 55249, 55654);

                object
                result = f_1236_55265_55653(f_1236_55265_55276(), useLocalScope: true, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToExternalErrorPipe, dollarUnder: f_1236_55465_55509(element), input: f_1236_55535_55555(), scriptThis: f_1236_55586_55606(), args: f_1236_55631_55652())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 55670, 56121) || true) && (!f_1236_55675_55708(result))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 55670, 56121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 55742, 55892);

                    var
                    errorMessageFormat = (DynAbs.Tracing.TraceSender.Conditional_F1(1236, 55767, 55801) || ((f_1236_55767_55801(f_1236_55788_55800()) && DynAbs.Tracing.TraceSender.Conditional_F2(1236, 55825, 55855)) || DynAbs.Tracing.TraceSender.Conditional_F3(1236, 55879, 55891))) ? f_1236_55825_55855() : f_1236_55879_55891()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 55910, 56106);

                    throw f_1236_55916_56105("ValidateScriptFailure", null, errorMessageFormat, element, f_1236_56093_56104());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 55670, 56121);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 54913, 56132);

                string
                f_1236_55185_55216()
                {
                    var return_v = Metadata.ValidateNotNullFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 55185, 55216);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_55052_55217(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 55052, 55217);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1236_55265_55276()
                {
                    var return_v = ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 55265, 55276);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1236_55465_55509(object
                obj)
                {
                    var return_v = LanguagePrimitives.AsPSObjectOrNull(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 55465, 55509);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1236_55535_55555()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 55535, 55555);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1236_55586_55606()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 55586, 55606);
                    return return_v;
                }


                object[]
                f_1236_55631_55652()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 55631, 55652);
                    return return_v;
                }


                object
                f_1236_55265_55653(System.Management.Automation.ScriptBlock
                this_param, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, System.Management.Automation.PSObject
                input, System.Management.Automation.PSObject
                scriptThis, object[]
                args)
                {
                    var return_v = this_param.DoInvokeReturnAsIs(useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: (object)scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 55265, 55653);
                    return return_v;
                }


                bool
                f_1236_55675_55708(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsTrue(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 55675, 55708);
                    return return_v;
                }


                string
                f_1236_55788_55800()
                {
                    var return_v = ErrorMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 55788, 55800);
                    return return_v;
                }


                bool
                f_1236_55767_55801(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 55767, 55801);
                    return return_v;
                }


                string
                f_1236_55825_55855()
                {
                    var return_v = Metadata.ValidateScriptFailure
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 55825, 55855);
                    return return_v;
                }


                string
                f_1236_55879_55891()
                {
                    var return_v = ErrorMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 55879, 55891);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1236_56093_56104()
                {
                    var return_v = ScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 56093, 56104);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_55916_56105(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 55916, 56105);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 54913, 56132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 54913, 56132);
            }
        }

        public ValidateScriptAttribute(ScriptBlock scriptBlock)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 56436, 56703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 54399, 54439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 54562, 54601);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 56516, 56650) || true) && (scriptBlock == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 56516, 56650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 56573, 56635);

                    throw f_1236_56579_56634(nameof(scriptBlock));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 56516, 56650);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 56666, 56692);

                ScriptBlock = scriptBlock;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 56436, 56703);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 56436, 56703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 56436, 56703);
            }
        }

        static ValidateScriptAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 53833, 56710);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 53833, 56710);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 53833, 56710);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 53833, 56710);

        System.Management.Automation.PSArgumentException
        f_1236_56579_56634(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 56579, 56634);
            return return_v;
        }

    }
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class ValidateCountAttribute : ValidateArgumentsAttribute
    {
        public int MinLength { get; }

        public int MaxLength { get; }

        protected override void Validate(object arguments, EngineIntrinsics engineIntrinsics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 57985, 59980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 58095, 58110);

                UInt32
                len = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 58124, 59322) || true) && (arguments == null || (DynAbs.Tracing.TraceSender.Expression_False(1236, 58128, 58182) || arguments == f_1236_58162_58182()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 58124, 59322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 58321, 58329);

                    len = 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 58124, 59322);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 58124, 59322);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 58363, 59322) || true) && (arguments is IList il)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 58363, 59322);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 58422, 58445);

                        len = (UInt32)f_1236_58436_58444(il);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 58363, 59322);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 58363, 59322);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 58479, 59322) || true) && (arguments is ICollection ic)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 58479, 59322);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 58544, 58567);

                            len = (UInt32)f_1236_58558_58566(ic);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 58479, 59322);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 58479, 59322);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 58601, 59322) || true) && (arguments is IEnumerable ie)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 58601, 59322);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 58666, 58701);

                                IEnumerator
                                e = f_1236_58682_58700(ie)
                                ;
                                try
                                {
                                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 58719, 58805) || true) && (f_1236_58726_58738(e))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 58719, 58805);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 58780, 58786);

                                        len++;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 58719, 58805);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1236, 58719, 58805);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1236, 58719, 58805);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 58601, 59322);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 58601, 59322);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 58839, 59322) || true) && (arguments is IEnumerator enumerator)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 58839, 59322);
                                    try
                                    {
                                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 58912, 59007) || true) && (f_1236_58919_58940(enumerator))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 58912, 59007);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 58982, 58988);

                                            len++;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 58912, 59007);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1236, 58912, 59007);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1236, 58912, 59007);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 58839, 59322);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 58839, 59322);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 59142, 59307);

                                    throw f_1236_59148_59306("NotAnArrayParameter", null, f_1236_59273_59305());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 58839, 59322);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 58601, 59322);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 58479, 59322);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 58363, 59322);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 58124, 59322);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 59338, 59643) || true) && (f_1236_59342_59351() == f_1236_59355_59364() && (DynAbs.Tracing.TraceSender.Expression_True(1236, 59342, 59384) && len != f_1236_59375_59384()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 59338, 59643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 59418, 59628);

                    throw f_1236_59424_59627("ValidateCountExactFailure", null, f_1236_59555_59589(), f_1236_59612_59621(), len);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 59338, 59643);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 59659, 59969) || true) && (len < f_1236_59669_59678() || (DynAbs.Tracing.TraceSender.Expression_False(1236, 59663, 59697) || len > f_1236_59688_59697()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 59659, 59969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 59731, 59954);

                    throw f_1236_59737_59953("ValidateCountMinMaxFailure", null, f_1236_59869_59904(), f_1236_59927_59936(), f_1236_59938_59947(), len);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 59659, 59969);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 57985, 59980);

                System.Management.Automation.PSObject
                f_1236_58162_58182()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 58162, 58182);
                    return return_v;
                }


                int
                f_1236_58436_58444(System.Collections.IList
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 58436, 58444);
                    return return_v;
                }


                int
                f_1236_58558_58566(System.Collections.ICollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 58558, 58566);
                    return return_v;
                }


                System.Collections.IEnumerator
                f_1236_58682_58700(System.Collections.IEnumerable
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 58682, 58700);
                    return return_v;
                }


                bool
                f_1236_58726_58738(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 58726, 58738);
                    return return_v;
                }


                bool
                f_1236_58919_58940(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 58919, 58940);
                    return return_v;
                }


                string
                f_1236_59273_59305()
                {
                    var return_v = Metadata.ValidateCountNotInArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 59273, 59305);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_59148_59306(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 59148, 59306);
                    return return_v;
                }


                int
                f_1236_59342_59351()
                {
                    var return_v = MinLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 59342, 59351);
                    return return_v;
                }


                int
                f_1236_59355_59364()
                {
                    var return_v = MaxLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 59355, 59364);
                    return return_v;
                }


                int
                f_1236_59375_59384()
                {
                    var return_v = MaxLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 59375, 59384);
                    return return_v;
                }


                string
                f_1236_59555_59589()
                {
                    var return_v = Metadata.ValidateCountExactFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 59555, 59589);
                    return return_v;
                }


                int
                f_1236_59612_59621()
                {
                    var return_v = MaxLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 59612, 59621);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_59424_59627(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 59424, 59627);
                    return return_v;
                }


                int
                f_1236_59669_59678()
                {
                    var return_v = MinLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 59669, 59678);
                    return return_v;
                }


                int
                f_1236_59688_59697()
                {
                    var return_v = MaxLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 59688, 59697);
                    return return_v;
                }


                string
                f_1236_59869_59904()
                {
                    var return_v = Metadata.ValidateCountMinMaxFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 59869, 59904);
                    return return_v;
                }


                int
                f_1236_59927_59936()
                {
                    var return_v = MinLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 59927, 59936);
                    return return_v;
                }


                int
                f_1236_59938_59947()
                {
                    var return_v = MaxLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 59938, 59947);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_59737_59953(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 59737, 59953);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 57985, 59980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 57985, 59980);
            }
        }

        public ValidateCountAttribute(int minLength, int maxLength)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 60560, 61337);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 57102, 57131);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 57246, 57275);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 60644, 60791) || true) && (minLength < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 60644, 60791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 60695, 60776);

                    throw f_1236_60701_60775(nameof(minLength), minLength);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 60644, 60791);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 60807, 60955) || true) && (maxLength <= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 60807, 60955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 60859, 60940);

                    throw f_1236_60865_60939(nameof(maxLength), maxLength);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 60807, 60955);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 60971, 61252) || true) && (maxLength < minLength)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 60971, 61252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 61030, 61237);

                    throw f_1236_61036_61236("ValidateRangeMaxLengthSmallerThanMinLength", null, f_1236_61184_61235());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 60971, 61252);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 61268, 61290);

                MinLength = minLength;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 61304, 61326);

                MaxLength = maxLength;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 60560, 61337);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 60560, 61337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 60560, 61337);
            }
        }

        static ValidateCountAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 56837, 61344);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 56837, 61344);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 56837, 61344);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 56837, 61344);

        System.Management.Automation.PSArgumentOutOfRangeException
        f_1236_60701_60775(string
        paramName, int
        actualValue)
        {
            var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 60701, 60775);
            return return_v;
        }


        System.Management.Automation.PSArgumentOutOfRangeException
        f_1236_60865_60939(string
        paramName, int
        actualValue)
        {
            var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 60865, 60939);
            return return_v;
        }


        string
        f_1236_61184_61235()
        {
            var return_v = Metadata.ValidateCountMaxLengthSmallerThanMinLength;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 61184, 61235);
            return return_v;
        }


        System.Management.Automation.ValidationMetadataException
        f_1236_61036_61236(string
        errorId, System.Exception
        innerException, string
        resourceStr, params object[]
        arguments)
        {
            var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 61036, 61236);
            return return_v;
        }

    }
    public abstract class CachedValidValuesGeneratorBase : IValidateSetValuesGenerator
    {
        private string[] _validValues;

        private int _validValuesCacheExpiration;

        protected CachedValidValuesGeneratorBase(int cacheExpirationInSeconds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 62107, 62268);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 61698, 61710);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 61733, 61760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 62202, 62257);

                _validValuesCacheExpiration = cacheExpirationInSeconds;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 62107, 62268);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 62107, 62268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 62107, 62268);
            }
        }

        public abstract string[] GenerateValidValues();

        public string[] GetValidValues()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 62523, 63555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 62745, 62781);

                var
                validValuesLocal = _validValues
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 62795, 62896) || true) && (validValuesLocal != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 62795, 62896);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 62857, 62881);

                    return validValuesLocal;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 62795, 62896);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 62912, 62959);

                var
                validValuesNoCache = f_1236_62937_62958(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 62975, 63259) || true) && (validValuesNoCache == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 62975, 63259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 63039, 63244);

                    throw f_1236_63045_63243("ValidateSetGeneratedValidValuesListIsNull", null, f_1236_63192_63242());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 62975, 63259);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 63275, 63502) || true) && (_validValuesCacheExpiration > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 63275, 63502);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 63344, 63378);

                    _validValues = validValuesNoCache;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 63396, 63487);

                    f_1236_63396_63486(f_1236_63396_63442(_validValuesCacheExpiration * 1000), (task) => _validValues = null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 63275, 63502);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 63518, 63544);

                return validValuesNoCache;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 62523, 63555);

                string[]
                f_1236_62937_62958(System.Management.Automation.CachedValidValuesGeneratorBase
                this_param)
                {
                    var return_v = this_param.GenerateValidValues();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 62937, 62958);
                    return return_v;
                }


                string
                f_1236_63192_63242()
                {
                    var return_v = Metadata.ValidateSetGeneratedValidValuesListIsNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 63192, 63242);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_63045_63243(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 63045, 63243);
                    return return_v;
                }


                System.Threading.Tasks.Task
                f_1236_63396_63442(int
                millisecondsDelay)
                {
                    var return_v = Task.Delay(millisecondsDelay);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 63396, 63442);
                    return return_v;
                }


                System.Threading.Tasks.Task<string[]>
                f_1236_63396_63486(System.Threading.Tasks.Task
                this_param, System.Func<System.Threading.Tasks.Task, string[]>
                continuationFunction)
                {
                    var return_v = this_param.ContinueWith<string[]>(continuationFunction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 63396, 63486);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 62523, 63555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 62523, 63555);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CachedValidValuesGeneratorBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 61549, 63562);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 61549, 63562);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 61549, 63562);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 61549, 63562);
    }
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class ValidateSetAttribute : ValidateEnumeratedArgumentsAttribute
    {
        private string[] _validValues;

        private IValidateSetValuesGenerator validValuesGenerator;

        private static ConcurrentDictionary<Type, IValidateSetValuesGenerator> s_ValidValuesGeneratorCache;

        public string ErrorMessage { get; set; }

        public bool IgnoreCase { get; set; }

        public IList<string> ValidValues
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 65360, 65975);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 65396, 65509) || true) && (validValuesGenerator == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 65396, 65509);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 65470, 65490);

                        return _validValues;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 65396, 65509);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 65529, 65590);

                    var
                    validValuesLocal = f_1236_65552_65589(validValuesGenerator)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 65610, 65916) || true) && (validValuesLocal == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 65610, 65916);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 65680, 65897);

                        throw f_1236_65686_65896("ValidateSetGeneratedValidValuesListIsNull", null, f_1236_65845_65895());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 65610, 65916);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 65936, 65960);

                    return validValuesLocal;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 65360, 65975);

                    string[]
                    f_1236_65552_65589(System.Management.Automation.IValidateSetValuesGenerator
                    this_param)
                    {
                        var return_v = this_param.GetValidValues();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 65552, 65589);
                        return return_v;
                    }


                    string
                    f_1236_65845_65895()
                    {
                        var return_v = Metadata.ValidateSetGeneratedValidValuesListIsNull;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 65845, 65895);
                        return return_v;
                    }


                    System.Management.Automation.ValidationMetadataException
                    f_1236_65686_65896(string
                    errorId, System.Exception
                    innerException, string
                    resourceStr, params object[]
                    arguments)
                    {
                        var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 65686, 65896);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 65303, 65986);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 65303, 65986);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void ValidateElement(object element)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 66355, 67429);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 66435, 66663) || true) && (element == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 66435, 66663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 66488, 66648);

                    throw f_1236_66494_66647("ArgumentIsEmpty", null, f_1236_66615_66646());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 66435, 66663);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 66679, 66717);

                string
                objString = f_1236_66698_66716(element)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 66731, 67093);
                    foreach (string setString in f_1236_66760_66771_I(f_1236_66760_66771()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 66731, 67093);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 66805, 67078) || true) && (f_1236_66809_67005(f_1236_66809_66849(f_1236_66809_66837()), setString, objString, (DynAbs.Tracing.TraceSender.Conditional_F1(1236, 66944, 66954) || ((f_1236_66944_66954() && DynAbs.Tracing.TraceSender.Conditional_F2(1236, 66957, 66982)) || DynAbs.Tracing.TraceSender.Conditional_F3(1236, 66985, 67004))) ? CompareOptions.IgnoreCase : CompareOptions.None) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 66805, 67078);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 67052, 67059);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 66805, 67078);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 66731, 67093);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1236, 1, 363);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1236, 1, 363);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 67109, 67214);

                var
                errorMessageFormat = (DynAbs.Tracing.TraceSender.Conditional_F1(1236, 67134, 67168) || ((f_1236_67134_67168(f_1236_67155_67167()) && DynAbs.Tracing.TraceSender.Conditional_F2(1236, 67171, 67198)) || DynAbs.Tracing.TraceSender.Conditional_F3(1236, 67201, 67213))) ? f_1236_67171_67198() : f_1236_67201_67213()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 67228, 67418);

                throw f_1236_67234_67417("ValidateSetFailure", null, errorMessageFormat, f_1236_67383_67401(element), f_1236_67403_67416(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 66355, 67429);

                string
                f_1236_66615_66646()
                {
                    var return_v = Metadata.ValidateNotNullFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 66615, 66646);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_66494_66647(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 66494, 66647);
                    return return_v;
                }


                string?
                f_1236_66698_66716(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 66698, 66716);
                    return return_v;
                }


                System.Collections.Generic.IList<string>
                f_1236_66760_66771()
                {
                    var return_v = ValidValues;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 66760, 66771);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1236_66809_66837()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 66809, 66837);
                    return return_v;
                }


                System.Globalization.CompareInfo
                f_1236_66809_66849(System.Globalization.CultureInfo
                this_param)
                {
                    var return_v = this_param.CompareInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 66809, 66849);
                    return return_v;
                }


                bool
                f_1236_66944_66954()
                {
                    var return_v = IgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 66944, 66954);
                    return return_v;
                }


                int
                f_1236_66809_67005(System.Globalization.CompareInfo
                this_param, string
                string1, string
                string2, System.Globalization.CompareOptions
                options)
                {
                    var return_v = this_param.Compare(string1, string2, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 66809, 67005);
                    return return_v;
                }


                System.Collections.Generic.IList<string>
                f_1236_66760_66771_I(System.Collections.Generic.IList<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 66760, 66771);
                    return return_v;
                }


                string
                f_1236_67155_67167()
                {
                    var return_v = ErrorMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 67155, 67167);
                    return return_v;
                }


                bool
                f_1236_67134_67168(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 67134, 67168);
                    return return_v;
                }


                string
                f_1236_67171_67198()
                {
                    var return_v = Metadata.ValidateSetFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 67171, 67198);
                    return return_v;
                }


                string
                f_1236_67201_67213()
                {
                    var return_v = ErrorMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 67201, 67213);
                    return return_v;
                }


                string?
                f_1236_67383_67401(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 67383, 67401);
                    return return_v;
                }


                string
                f_1236_67403_67416(System.Management.Automation.ValidateSetAttribute
                this_param)
                {
                    var return_v = this_param.SetAsString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 67403, 67416);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_67234_67417(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 67234, 67417);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 66355, 67429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 66355, 67429);
            }
        }

        private string SetAsString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 67470, 67550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 67473, 67550);
                return f_1236_67473_67550(f_1236_67485_67536(f_1236_67485_67522(f_1236_67485_67513())), f_1236_67538_67549());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 67470, 67550);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 67470, 67550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 67470, 67550);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Globalization.CultureInfo
            f_1236_67485_67513()
            {
                var return_v = CultureInfo.CurrentUICulture;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 67485, 67513);
                return return_v;
            }


            System.Globalization.TextInfo
            f_1236_67485_67522(System.Globalization.CultureInfo
            this_param)
            {
                var return_v = this_param.TextInfo;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 67485, 67522);
                return return_v;
            }


            string
            f_1236_67485_67536(System.Globalization.TextInfo
            this_param)
            {
                var return_v = this_param.ListSeparator;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 67485, 67536);
                return return_v;
            }


            System.Collections.Generic.IList<string>
            f_1236_67538_67549()
            {
                var return_v = ValidValues;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 67538, 67549);
                return return_v;
            }


            string
            f_1236_67473_67550(string
            separator, System.Collections.Generic.IList<string>
            values)
            {
                var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<string?>)values);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 67473, 67550);
                return return_v;
            }

        }

        public ValidateSetAttribute(params string[] validValues)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 67947, 68397);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 64017, 64029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 64076, 64103);
                this.validValuesGenerator = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 64920, 64960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 65153, 65197);
                this.IgnoreCase = true;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 68028, 68166) || true) && (validValues == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 68028, 68166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 68085, 68151);

                    throw f_1236_68091_68150(nameof(validValues));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 68028, 68166);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 68182, 68343) || true) && (f_1236_68186_68204(validValues) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 68182, 68343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 68243, 68328);

                    throw f_1236_68249_68327(nameof(validValues), validValues);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 68182, 68343);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 68359, 68386);

                _validValues = validValues;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 67947, 68397);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 67947, 68397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 67947, 68397);
            }
        }

        public ValidateSetAttribute(Type valuesGeneratorType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 68927, 69764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 64017, 64029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 64076, 64103);
                this.validValuesGenerator = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 64920, 64960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 65153, 65197);
                this.IgnoreCase = true;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 69154, 69404) || true) && (!f_1236_69159_69250(typeof(IValidateSetValuesGenerator), valuesGeneratorType) || (DynAbs.Tracing.TraceSender.Expression_False(1236, 69158, 69285) || f_1236_69254_69285(valuesGeneratorType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 69154, 69404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 69319, 69389);

                    throw f_1236_69325_69388(nameof(valuesGeneratorType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 69154, 69404);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 69585, 69753);

                validValuesGenerator = f_1236_69608_69752(s_ValidValuesGeneratorCache, valuesGeneratorType, (key) => (IValidateSetValuesGenerator)Activator.CreateInstance(key));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 68927, 69764);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 68927, 69764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 68927, 69764);
            }
        }

        static ValidateSetAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 63688, 69771);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 64279, 64383);
            s_ValidValuesGeneratorCache = f_1236_64322_64383();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 63688, 69771);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 63688, 69771);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 63688, 69771);

        static System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Management.Automation.IValidateSetValuesGenerator>
        f_1236_64322_64383()
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Management.Automation.IValidateSetValuesGenerator>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 64322, 64383);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1236_68091_68150(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 68091, 68150);
            return return_v;
        }


        int
        f_1236_68186_68204(string[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 68186, 68204);
            return return_v;
        }


        System.Management.Automation.PSArgumentOutOfRangeException
        f_1236_68249_68327(string
        paramName, string[]
        actualValue)
        {
            var return_v = PSTraceSource.NewArgumentOutOfRangeException(paramName, (object)actualValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 68249, 68327);
            return return_v;
        }


        bool
        f_1236_69159_69250(System.Type
        this_param, System.Type
        c)
        {
            var return_v = this_param.IsAssignableFrom(c);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 69159, 69250);
            return return_v;
        }


        bool
        f_1236_69254_69285(System.Type
        this_param)
        {
            var return_v = this_param.IsNotPublic;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 69254, 69285);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1236_69325_69388(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 69325, 69388);
            return return_v;
        }


        System.Management.Automation.IValidateSetValuesGenerator
        f_1236_69608_69752(System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Management.Automation.IValidateSetValuesGenerator>
        this_param, System.Type
        key, System.Func<System.Type, System.Management.Automation.IValidateSetValuesGenerator>
        valueFactory)
        {
            var return_v = this_param.GetOrAdd(key, valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 69608, 69752);
            return return_v;
        }

    }

    /// <summary>
    /// Allows dynamically generate set of values for <see cref="ValidateSetAttribute"/>
    /// </summary>
    public interface IValidateSetValuesGenerator
    {

        string[] GetValidValues();
    }
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class ValidateTrustedDataAttribute : ValidateArgumentsAttribute
    {
        protected override void Validate(object arguments, EngineIntrinsics engineIntrinsics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 70830, 71506);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 70940, 71495) || true) && (f_1236_70944_70991() && (DynAbs.Tracing.TraceSender.Expression_True(1236, 70944, 71111) && f_1236_71012_71080(f_1236_71012_71067(f_1236_71012_71050(f_1236_71012_71041(engineIntrinsics)))) == PSLanguageMode.FullLanguage))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 70940, 71495);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 71145, 71480) || true) && (f_1236_71149_71196(arguments))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 71145, 71480);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 71238, 71461);

                        throw f_1236_71244_71460("ValidateTrustedDataFailure", null, f_1236_71388_71423(), arguments);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 71145, 71480);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 70940, 71495);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 70830, 71506);

                bool
                f_1236_70944_70991()
                {
                    var return_v = ExecutionContext.HasEverUsedConstrainedLanguage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 70944, 70991);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1236_71012_71041(System.Management.Automation.EngineIntrinsics
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 71012, 71041);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1236_71012_71050(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 71012, 71050);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1236_71012_71067(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 71012, 71067);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1236_71012_71080(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 71012, 71080);
                    return return_v;
                }


                bool
                f_1236_71149_71196(object
                value)
                {
                    var return_v = ExecutionContext.IsMarkedAsUntrusted(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 71149, 71196);
                    return return_v;
                }


                string
                f_1236_71388_71423()
                {
                    var return_v = Metadata.ValidateTrustedDataFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 71388, 71423);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_71244_71460(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 71244, 71460);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 70830, 71506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 70830, 71506);
            }
        }

        public ValidateTrustedDataAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 70193, 71513);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 70193, 71513);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 70193, 71513);
        }


        static ValidateTrustedDataAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 70193, 71513);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 70193, 71513);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 70193, 71513);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 70193, 71513);
    }
    [AttributeUsageAttribute(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class AllowNullAttribute : CmdletMetadataAttribute
    {
        public AllowNullAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 71944, 71975);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 71944, 71975);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 71944, 71975);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 71944, 71975);
            }
        }

        static AllowNullAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 71646, 71982);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 71646, 71982);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 71646, 71982);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 71646, 71982);
    }
    [AttributeUsageAttribute(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class AllowEmptyStringAttribute : CmdletMetadataAttribute
    {
        public AllowEmptyStringAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 72422, 72460);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 72422, 72460);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 72422, 72460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 72422, 72460);
            }
        }

        static AllowEmptyStringAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 72110, 72467);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 72110, 72467);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 72110, 72467);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 72110, 72467);
    }
    [AttributeUsageAttribute(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class AllowEmptyCollectionAttribute : CmdletMetadataAttribute
    {
        public AllowEmptyCollectionAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 72923, 72965);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 72923, 72965);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 72923, 72965);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 72923, 72965);
            }
        }

        static AllowEmptyCollectionAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 72603, 72972);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 72603, 72972);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 72603, 72972);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 72603, 72972);
    }
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class ValidateDriveAttribute : ValidateArgumentsAttribute
    {
        private string[] _validRootDrives;

        public IList<string> ValidRootDrives
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 73478, 73497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 73481, 73497);
                    return _validRootDrives;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 73478, 73497);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 73435, 73500);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 73435, 73500);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ValidateDriveAttribute(params string[] validRootDrives)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 73740, 74031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 73318, 73334);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 73827, 73969) || true) && (validRootDrives == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 73827, 73969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 73888, 73954);

                    throw f_1236_73894_73953(nameof(validRootDrives));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 73827, 73969);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 73985, 74020);

                _validRootDrives = validRootDrives;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 73740, 74031);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 73740, 74031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 73740, 74031);
            }
        }

        protected override void Validate(object arguments, EngineIntrinsics engineIntrinsics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 74264, 76230);
                System.Management.Automation.ProviderInfo providerInfo = default(System.Management.Automation.ProviderInfo);
                System.Management.Automation.PSDriveInfo driveInfo = default(System.Management.Automation.PSDriveInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 74374, 74608) || true) && (arguments == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 74374, 74608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 74429, 74593);

                    throw f_1236_74435_74592("PathArgumentIsEmpty", null, f_1236_74560_74591());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 74374, 74608);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 74624, 74655);

                var
                path = arguments as string
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 74669, 74908) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 74669, 74908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 74719, 74893);

                    throw f_1236_74725_74892("PathArgumentIsNotValid", null, f_1236_74853_74891());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 74669, 74908);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 74924, 75289);

                var
                resolvedPath = f_1236_74943_75288(f_1236_74943_74989(f_1236_74943_74981(f_1236_74943_74972(engineIntrinsics))), path: path, context: f_1236_75062_75144(f_1236_75088_75143(f_1236_75088_75126(f_1236_75088_75117(engineIntrinsics)))), isTrusted: true, provider: out providerInfo, drive: out driveInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 75305, 75339);

                string
                rootDrive = f_1236_75324_75338(driveInfo)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 75353, 75601) || true) && (f_1236_75357_75388(rootDrive))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 75353, 75601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 75422, 75586);

                    throw f_1236_75428_75585("PathArgumentNoRoot", null, f_1236_75552_75584());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 75353, 75601);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 75617, 75640);

                bool
                rootFound = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 75654, 75920);
                    foreach (var validDrive in f_1236_75681_75697_I(_validRootDrives))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 75654, 75920);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 75731, 75905) || true) && (f_1236_75735_75799(rootDrive, validDrive, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 75731, 75905);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 75841, 75858);

                            rootFound = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(1236, 75880, 75886);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 75731, 75905);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 75654, 75920);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1236, 1, 267);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1236, 1, 267);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 75936, 76219) || true) && (!rootFound)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 75936, 76219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 75984, 76204);

                    throw f_1236_75990_76203("PathRootInvalid", null, f_1236_76111_76144(), rootDrive, f_1236_76178_76202(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 75936, 76219);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 74264, 76230);

                string
                f_1236_74560_74591()
                {
                    var return_v = Metadata.ValidateNotNullFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 74560, 74591);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_74435_74592(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 74435, 74592);
                    return return_v;
                }


                string
                f_1236_74853_74891()
                {
                    var return_v = Metadata.ValidateDrivePathArgNotString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 74853, 74891);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_74725_74892(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 74725, 74892);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1236_74943_74972(System.Management.Automation.EngineIntrinsics
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 74943, 74972);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1236_74943_74981(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 74943, 74981);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1236_74943_74989(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 74943, 74989);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1236_75088_75117(System.Management.Automation.EngineIntrinsics
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 75088, 75117);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1236_75088_75126(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 75088, 75126);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1236_75088_75143(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 75088, 75143);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1236_75062_75144(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 75062, 75144);
                    return return_v;
                }


                string
                f_1236_74943_75288(System.Management.Automation.LocationGlobber
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, bool
                isTrusted, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.GetProviderPath(path: path, context: context, isTrusted: isTrusted, out provider, out drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 74943, 75288);
                    return return_v;
                }


                string
                f_1236_75324_75338(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 75324, 75338);
                    return return_v;
                }


                bool
                f_1236_75357_75388(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 75357, 75388);
                    return return_v;
                }


                string
                f_1236_75552_75584()
                {
                    var return_v = Metadata.ValidateDrivePathNoRoot;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 75552, 75584);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_75428_75585(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 75428, 75585);
                    return return_v;
                }


                bool
                f_1236_75735_75799(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 75735, 75799);
                    return return_v;
                }


                string[]
                f_1236_75681_75697_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 75681, 75697);
                    return return_v;
                }


                string
                f_1236_76111_76144()
                {
                    var return_v = Metadata.ValidateDrivePathFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 76111, 76144);
                    return return_v;
                }


                string
                f_1236_76178_76202(System.Management.Automation.ValidateDriveAttribute
                this_param)
                {
                    var return_v = this_param.ValidDriveListAsString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 76178, 76202);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_75990_76203(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 75990, 76203);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 74264, 76230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 74264, 76230);
            }
        }

        private string ValidDriveListAsString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 76242, 76407);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 76306, 76396);

                return f_1236_76313_76395(f_1236_76325_76376(f_1236_76325_76362(f_1236_76325_76353())), _validRootDrives);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 76242, 76407);

                System.Globalization.CultureInfo
                f_1236_76325_76353()
                {
                    var return_v = CultureInfo.CurrentUICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 76325, 76353);
                    return return_v;
                }


                System.Globalization.TextInfo
                f_1236_76325_76362(System.Globalization.CultureInfo
                this_param)
                {
                    var return_v = this_param.TextInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 76325, 76362);
                    return return_v;
                }


                string
                f_1236_76325_76376(System.Globalization.TextInfo
                this_param)
                {
                    var return_v = this_param.ListSeparator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 76325, 76376);
                    return return_v;
                }


                string
                f_1236_76313_76395(string
                separator, params string[]
                value)
                {
                    var return_v = string.Join(separator, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 76313, 76395);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 76242, 76407);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 76242, 76407);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ValidateDriveAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 73146, 76414);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 73146, 76414);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 73146, 76414);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 73146, 76414);

        System.Management.Automation.PSArgumentException
        f_1236_73894_73953(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 73894, 73953);
            return return_v;
        }

    }
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class ValidateUserDriveAttribute : ValidateDriveAttribute
    {
        public ValidateUserDriveAttribute()
        : base(f_1236_76881_76904_C(new string[] { "User" }))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 76825, 76927);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 76825, 76927);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 76825, 76927);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 76825, 76927);
            }
        }

        static ValidateUserDriveAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 76521, 76934);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 76521, 76934);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 76521, 76934);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 76521, 76934);

        static string[]
        f_1236_76881_76904_C(string[]
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1236, 76825, 76927);
            return return_v;
        }

    }
    public abstract class NullValidationAttributeBase : ValidateArgumentsAttribute
    {
        protected bool IsArgumentCollection(Type argumentType, out bool isElementValueType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 77290, 78208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 77398, 77425);

                isElementValueType = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 77439, 77510);

                var
                information = f_1236_77457_77509(argumentType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 77524, 78197);

                switch (f_1236_77532_77567(information))
                {

                    case ParameterCollectionType.Array:
                    case ParameterCollectionType.IList:
                    case ParameterCollectionType.ICollectionGeneric:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 77524, 78197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 77954, 77997);

                        Type
                        elementType = f_1236_77973_77996(information)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 78019, 78087);

                        isElementValueType = elementType != null && (DynAbs.Tracing.TraceSender.Expression_True(1236, 78040, 78086) && f_1236_78063_78086(elementType));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 78109, 78121);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 77524, 78197);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 77524, 78197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 78169, 78182);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 77524, 78197);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 77290, 78208);

                System.Management.Automation.ParameterCollectionTypeInformation
                f_1236_77457_77509(System.Type
                type)
                {
                    var return_v = new System.Management.Automation.ParameterCollectionTypeInformation(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 77457, 77509);
                    return return_v;
                }


                System.Management.Automation.ParameterCollectionType
                f_1236_77532_77567(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ParameterCollectionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 77532, 77567);
                    return return_v;
                }


                System.Type
                f_1236_77973_77996(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 77973, 77996);
                    return return_v;
                }


                bool
                f_1236_78063_78086(System.Type
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 78063, 78086);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 77290, 78208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 77290, 78208);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public NullValidationAttributeBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 77091, 78215);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 77091, 78215);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 77091, 78215);
        }


        static NullValidationAttributeBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 77091, 78215);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 77091, 78215);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 77091, 78215);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 77091, 78215);
    }
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class ValidateNotNullAttribute : NullValidationAttributeBase
    {
        protected override void Validate(object arguments, EngineIntrinsics engineIntrinsics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 79163, 80432);
                bool isElementValueType = default(bool);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 79273, 80421) || true) && (f_1236_79277_79313(arguments))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 79273, 80421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 79347, 79506);

                    throw f_1236_79353_79505("ArgumentIsNull", null, f_1236_79473_79504());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 79273, 80421);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 79273, 80421);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 79540, 80421) || true) && (f_1236_79544_79614(this, f_1236_79565_79584(arguments), out isElementValueType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 79540, 80421);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 79813, 79848) || true) && (isElementValueType)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 79813, 79848);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 79839, 79846);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 79813, 79848);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 79868, 79937);

                        IEnumerator
                        enumerator = f_1236_79893_79936(arguments)
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 79955, 80406) || true) && (f_1236_79962_79983(enumerator))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 79955, 80406);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 80025, 80061);

                                object
                                element = f_1236_80042_80060(enumerator)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 80083, 80387) || true) && (f_1236_80087_80121(element))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 80083, 80387);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 80171, 80364);

                                    throw f_1236_80177_80363("ArgumentIsNull", null, f_1236_80321_80362());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 80083, 80387);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 79955, 80406);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1236, 79955, 80406);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1236, 79955, 80406);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 79540, 80421);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 79273, 80421);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 79163, 80432);

                bool
                f_1236_79277_79313(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsNull(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 79277, 79313);
                    return return_v;
                }


                string
                f_1236_79473_79504()
                {
                    var return_v = Metadata.ValidateNotNullFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 79473, 79504);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_79353_79505(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 79353, 79505);
                    return return_v;
                }


                System.Type
                f_1236_79565_79584(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 79565, 79584);
                    return return_v;
                }


                bool
                f_1236_79544_79614(System.Management.Automation.ValidateNotNullAttribute
                this_param, System.Type
                argumentType, out bool
                isElementValueType)
                {
                    var return_v = this_param.IsArgumentCollection(argumentType, out isElementValueType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 79544, 79614);
                    return return_v;
                }


                System.Collections.IEnumerator
                f_1236_79893_79936(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerator(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 79893, 79936);
                    return return_v;
                }


                bool
                f_1236_79962_79983(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 79962, 79983);
                    return return_v;
                }


                object
                f_1236_80042_80060(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 80042, 80060);
                    return return_v;
                }


                bool
                f_1236_80087_80121(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsNull(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 80087, 80121);
                    return return_v;
                }


                string
                f_1236_80321_80362()
                {
                    var return_v = Metadata.ValidateNotNullCollectionFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 80321, 80362);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_80177_80363(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 80177, 80363);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 79163, 80432);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 79163, 80432);
            }
        }

        public ValidateNotNullAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 78325, 80439);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 78325, 80439);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 78325, 80439);
        }


        static ValidateNotNullAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 78325, 80439);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 78325, 80439);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 78325, 80439);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 78325, 80439);
    }
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public sealed class ValidateNotNullOrEmptyAttribute : NullValidationAttributeBase
    {
        protected override void Validate(object arguments, EngineIntrinsics engineIntrinsics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 81385, 84402);
                bool isElementValueType = default(bool);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 81495, 84391) || true) && (f_1236_81499_81535(arguments))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 81495, 84391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 81569, 81735);

                    throw f_1236_81575_81734("ArgumentIsNull", null, f_1236_81695_81733());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 81495, 84391);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 81495, 84391);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 81769, 84391) || true) && (arguments is string str)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 81769, 84391);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 81830, 82099) || true) && (f_1236_81834_81859(str))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 81830, 82099);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 81901, 82080);

                            throw f_1236_81907_82079("ArgumentIsEmpty", null, f_1236_82040_82078());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 81830, 82099);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 81769, 84391);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 81769, 84391);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 82133, 84391) || true) && (f_1236_82137_82207(this, f_1236_82158_82177(arguments), out isElementValueType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 82133, 84391);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 82241, 82261);

                            bool
                            isEmpty = true
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 82279, 82348);

                            IEnumerator
                            enumerator = f_1236_82304_82347(arguments)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 82366, 82413) || true) && (f_1236_82370_82391(enumerator))
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 82366, 82413);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 82395, 82411);

                                isEmpty = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 82366, 82413);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 82598, 83725) || true) && (!isEmpty && (DynAbs.Tracing.TraceSender.Expression_True(1236, 82602, 82633) && !isElementValueType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 82598, 83725);
                                {
                                    try
                                    {
                                        do

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 82675, 83706);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 82726, 82762);

                                            object
                                            element = f_1236_82743_82761(enumerator)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 82788, 83123) || true) && (f_1236_82792_82826(element))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 82788, 83123);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 82884, 83096);

                                                throw f_1236_82890_83095("ArgumentIsNull", null, f_1236_83046_83094());
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 82788, 83123);
                                            }

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 83151, 83652) || true) && (element is string elementAsString)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 83151, 83652);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 83246, 83625) || true) && (f_1236_83250_83287(elementAsString))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 83246, 83625);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 83353, 83594);

                                                    throw f_1236_83359_83593("ArgumentCollectionContainsEmpty", null, f_1236_83544_83592());
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 83246, 83625);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 83151, 83652);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 82675, 83706);
                                        }
                                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 82675, 83706) || true) && (f_1236_83683_83704(enumerator))
                                        );
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1236, 82675, 83706);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1236, 82675, 83706);
                                    }
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 82598, 83725);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 83745, 84006) || true) && (isEmpty)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 83745, 84006);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 83798, 83987);

                                throw f_1236_83804_83986("ArgumentIsEmpty", null, f_1236_83937_83985());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 83745, 84006);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 82133, 84391);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 82133, 84391);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 84040, 84391) || true) && (arguments is IDictionary dict)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 84040, 84391);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 84107, 84376) || true) && (f_1236_84111_84121(dict) == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 84107, 84376);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 84168, 84357);

                                    throw f_1236_84174_84356("ArgumentIsEmpty", null, f_1236_84307_84355());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 84107, 84376);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 84040, 84391);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 82133, 84391);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 81769, 84391);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 81495, 84391);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 81385, 84402);

                bool
                f_1236_81499_81535(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsNull(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 81499, 81535);
                    return return_v;
                }


                string
                f_1236_81695_81733()
                {
                    var return_v = Metadata.ValidateNotNullOrEmptyFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 81695, 81733);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_81575_81734(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 81575, 81734);
                    return return_v;
                }


                bool
                f_1236_81834_81859(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 81834, 81859);
                    return return_v;
                }


                string
                f_1236_82040_82078()
                {
                    var return_v = Metadata.ValidateNotNullOrEmptyFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 82040, 82078);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_81907_82079(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 81907, 82079);
                    return return_v;
                }


                System.Type
                f_1236_82158_82177(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 82158, 82177);
                    return return_v;
                }


                bool
                f_1236_82137_82207(System.Management.Automation.ValidateNotNullOrEmptyAttribute
                this_param, System.Type
                argumentType, out bool
                isElementValueType)
                {
                    var return_v = this_param.IsArgumentCollection(argumentType, out isElementValueType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 82137, 82207);
                    return return_v;
                }


                System.Collections.IEnumerator
                f_1236_82304_82347(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerator(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 82304, 82347);
                    return return_v;
                }


                bool
                f_1236_82370_82391(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 82370, 82391);
                    return return_v;
                }


                object
                f_1236_82743_82761(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 82743, 82761);
                    return return_v;
                }


                bool
                f_1236_82792_82826(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsNull(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 82792, 82826);
                    return return_v;
                }


                string
                f_1236_83046_83094()
                {
                    var return_v = Metadata.ValidateNotNullOrEmptyCollectionFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 83046, 83094);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_82890_83095(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 82890, 83095);
                    return return_v;
                }


                bool
                f_1236_83250_83287(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 83250, 83287);
                    return return_v;
                }


                string
                f_1236_83544_83592()
                {
                    var return_v = Metadata.ValidateNotNullOrEmptyCollectionFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 83544, 83592);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_83359_83593(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 83359, 83593);
                    return return_v;
                }


                bool
                f_1236_83683_83704(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 83683, 83704);
                    return return_v;
                }


                string
                f_1236_83937_83985()
                {
                    var return_v = Metadata.ValidateNotNullOrEmptyCollectionFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 83937, 83985);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_83804_83986(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 83804, 83986);
                    return return_v;
                }


                int
                f_1236_84111_84121(System.Collections.IDictionary
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 84111, 84121);
                    return return_v;
                }


                string
                f_1236_84307_84355()
                {
                    var return_v = Metadata.ValidateNotNullOrEmptyCollectionFailure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 84307, 84355);
                    return return_v;
                }


                System.Management.Automation.ValidationMetadataException
                f_1236_84174_84356(string
                errorId, System.Exception
                innerException, string
                resourceStr, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ValidationMetadataException(errorId, innerException, resourceStr, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 84174, 84356);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 81385, 84402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 81385, 84402);
            }
        }

        public ValidateNotNullOrEmptyAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 80614, 84409);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 80614, 84409);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 80614, 84409);
        }


        static ValidateNotNullOrEmptyAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 80614, 84409);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 80614, 84409);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 80614, 84409);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 80614, 84409);
    }
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public abstract class ArgumentTransformationAttribute : CmdletMetadataAttribute
    {
        protected ArgumentTransformationAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1236, 86194, 86259);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1236, 86194, 86259);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 86194, 86259);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 86194, 86259);
            }
        }

        public abstract object Transform(EngineIntrinsics engineIntrinsics, object inputData);

        internal object TransformInternal(
                    EngineIntrinsics engineIntrinsics,
                    object inputData,
                    bool trackDataInputSource = true)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 88084, 88654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 88269, 88324);

                object
                result = f_1236_88285_88323(this, engineIntrinsics, inputData)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 88338, 88613) || true) && (trackDataInputSource && (DynAbs.Tracing.TraceSender.Expression_True(1236, 88342, 88390) && engineIntrinsics != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1236, 88338, 88613);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 88424, 88598);

                    f_1236_88424_88597(inputData, result, f_1236_88545_88596(f_1236_88545_88583(f_1236_88545_88574(engineIntrinsics))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1236, 88338, 88613);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 88629, 88643);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 88084, 88654);

                object
                f_1236_88285_88323(System.Management.Automation.ArgumentTransformationAttribute
                this_param, System.Management.Automation.EngineIntrinsics
                engineIntrinsics, object
                inputData)
                {
                    var return_v = this_param.Transform(engineIntrinsics, inputData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 88285, 88323);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1236_88545_88574(System.Management.Automation.EngineIntrinsics
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 88545, 88574);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1236_88545_88583(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 88545, 88583);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1236_88545_88596(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1236, 88545, 88596);
                    return return_v;
                }


                int
                f_1236_88424_88597(object
                originalObject, object
                resultObject, System.Management.Automation.PSLanguageMode
                currentLanguageMode)
                {
                    ExecutionContext.PropagateInputSource(originalObject, resultObject, currentLanguageMode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1236, 88424, 88597);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 88084, 88654);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 88084, 88654);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual bool TransformNullOptionalParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1236, 88908, 88915);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1236, 88911, 88915);
                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1236, 88908, 88915);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1236, 88850, 88918);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 88850, 88918);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ArgumentTransformationAttribute()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1236, 85877, 88925);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1236, 85877, 88925);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1236, 85877, 88925);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1236, 85877, 88925);
    }

}
