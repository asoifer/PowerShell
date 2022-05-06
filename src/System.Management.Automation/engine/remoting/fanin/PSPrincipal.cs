// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

/*
 * Contains definition for PSSenderInfo, PSPrincipal, PSIdentity which are
 * used to provide remote user information to different plugin snapins
 * like Exchange.
 */

using System;
using System.Security.Principal;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using Microsoft.PowerShell;

namespace System.Management.Automation.Remoting
{
    [Serializable]
    public sealed class PSSenderInfo : ISerializable
    {
        private PSPrimitiveDictionary _applicationArguments;

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1637, 1213, 1422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 1313, 1359);

                PSObject
                psObject = f_1637_1333_1358(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 1373, 1411);

                f_1637_1373_1410(psObject, info, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1637, 1213, 1422);

                System.Management.Automation.PSObject
                f_1637_1333_1358(System.Management.Automation.Remoting.PSSenderInfo
                obj)
                {
                    var return_v = PSObject.AsPSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1637, 1333, 1358);
                    return return_v;
                }


                int
                f_1637_1373_1410(System.Management.Automation.PSObject
                this_param, System.Runtime.Serialization.SerializationInfo
                info, System.Runtime.Serialization.StreamingContext
                context)
                {
                    this_param.GetObjectData(info, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1637, 1373, 1410);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1637, 1213, 1422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1637, 1213, 1422);
            }
        }

        private PSSenderInfo(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1637, 1608, 2862);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 964, 985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 3773, 4087);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 4218, 4319);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 4538, 4855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 5320, 5374);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 1703, 1775) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1637, 1703, 1775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 1753, 1760);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1637, 1703, 1775);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 1791, 1820);

                string
                serializedData = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 1872, 1939);

                    serializedData = f_1637_1889_1928(info, "CliXml", typeof(string)) as string;
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1637, 1968, 2120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 2098, 2105);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1637, 1968, 2120);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 2136, 2218) || true) && (serializedData == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1637, 2136, 2218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 2196, 2203);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1637, 2136, 2218);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 2270, 2350);

                    PSObject
                    result = f_1637_2288_2349(f_1637_2308_2348(serializedData))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 2368, 2451);

                    PSSenderInfo
                    senderInfo = f_1637_2394_2450(result)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 2471, 2502);

                    UserInfo = f_1637_2482_2501(senderInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 2520, 2567);

                    ConnectionString = f_1637_2539_2566(senderInfo);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 2585, 2642);

                    _applicationArguments = senderInfo._applicationArguments;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 2662, 2705);

                    ClientTimeZone = f_1637_2679_2704(senderInfo);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1637, 2734, 2851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 2829, 2836);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1637, 2734, 2851);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1637, 1608, 2862);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1637, 1608, 2862);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1637, 1608, 2862);
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#")]
        public PSSenderInfo(PSPrincipal userPrincipal, string httpUrl)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1637, 3311, 3582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 964, 985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 3773, 4087);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 4218, 4319);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 4538, 4855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 5320, 5374);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 3505, 3530);

                UserInfo = userPrincipal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 3544, 3571);

                ConnectionString = httpUrl;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1637, 3311, 3582);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1637, 3311, 3582);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1637, 3311, 3582);
            }
        }

        public PSPrincipal UserInfo
        {
            get;
        }

        public TimeZoneInfo ClientTimeZone
        {
            get;
            internal set;
        }

        public string ConnectionString
        {
            get;
        }

        public PSPrimitiveDictionary ApplicationArguments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1637, 5086, 5123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 5092, 5121);

                    return _applicationArguments;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1637, 5086, 5123);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1637, 5012, 5197);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1637, 5012, 5197);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            internal set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1637, 5139, 5186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 5154, 5184);

                    _applicationArguments = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1637, 5139, 5186);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1637, 5012, 5197);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1637, 5012, 5197);
                }
            }
        }

        public string ConfigurationName { get; internal set; }

        static PSSenderInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1637, 817, 5403);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1637, 817, 5403);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1637, 817, 5403);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1637, 817, 5403);

        object?
        f_1637_1889_1928(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name, System.Type
        type)
        {
            var return_v = this_param.GetValue(name, type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1637, 1889, 1928);
            return return_v;
        }


        object
        f_1637_2308_2348(string
        source)
        {
            var return_v = PSSerializer.Deserialize(source);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1637, 2308, 2348);
            return return_v;
        }


        System.Management.Automation.PSObject
        f_1637_2288_2349(object
        obj)
        {
            var return_v = PSObject.AsPSObject(obj);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1637, 2288, 2349);
            return return_v;
        }


        System.Management.Automation.Remoting.PSSenderInfo
        f_1637_2394_2450(System.Management.Automation.PSObject
        pso)
        {
            var return_v = DeserializingTypeConverter.RehydratePSSenderInfo(pso);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1637, 2394, 2450);
            return return_v;
        }


        System.Management.Automation.Remoting.PSPrincipal
        f_1637_2482_2501(System.Management.Automation.Remoting.PSSenderInfo
        this_param)
        {
            var return_v = this_param.UserInfo;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1637, 2482, 2501);
            return return_v;
        }


        string
        f_1637_2539_2566(System.Management.Automation.Remoting.PSSenderInfo
        this_param)
        {
            var return_v = this_param.ConnectionString;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1637, 2539, 2566);
            return return_v;
        }


        System.TimeZoneInfo
        f_1637_2679_2704(System.Management.Automation.Remoting.PSSenderInfo
        this_param)
        {
            var return_v = this_param.ClientTimeZone;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1637, 2679, 2704);
            return return_v;
        }

    }
    public sealed class PSPrincipal : IPrincipal
    {
        public PSIdentity Identity
        {
            get;
        }

        public WindowsIdentity WindowsIdentity
        {
            get;
        }

        IIdentity IPrincipal.Identity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1637, 6928, 6957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 6934, 6955);

                    return f_1637_6941_6954(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1637, 6928, 6957);

                    System.Management.Automation.Remoting.PSIdentity
                    f_1637_6941_6954(System.Management.Automation.Remoting.PSPrincipal
                    this_param)
                    {
                        var return_v = this_param.Identity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1637, 6941, 6954);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1637, 6874, 6968);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1637, 6874, 6968);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsInRole(string role)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1637, 7513, 7928);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 7571, 7917) || true) && (f_1637_7575_7590() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1637, 7571, 7917);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 7692, 7766);

                    WindowsPrincipal
                    windowsPrincipal = f_1637_7728_7765(f_1637_7749_7764())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 7784, 7823);

                    return f_1637_7791_7822(windowsPrincipal, role);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1637, 7571, 7917);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1637, 7571, 7917);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 7889, 7902);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1637, 7571, 7917);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1637, 7513, 7928);

                System.Security.Principal.WindowsIdentity
                f_1637_7575_7590()
                {
                    var return_v = WindowsIdentity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1637, 7575, 7590);
                    return return_v;
                }


                System.Security.Principal.WindowsIdentity
                f_1637_7749_7764()
                {
                    var return_v = WindowsIdentity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1637, 7749, 7764);
                    return return_v;
                }


                System.Security.Principal.WindowsPrincipal
                f_1637_7728_7765(System.Security.Principal.WindowsIdentity
                ntIdentity)
                {
                    var return_v = new System.Security.Principal.WindowsPrincipal(ntIdentity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1637, 7728, 7765);
                    return return_v;
                }


                bool
                f_1637_7791_7822(System.Security.Principal.WindowsPrincipal
                this_param, string
                role)
                {
                    var return_v = this_param.IsInRole(role);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1637, 7791, 7822);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1637, 7513, 7928);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1637, 7513, 7928);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsInRole(WindowsBuiltInRole role)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1637, 8072, 8501);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 8144, 8490) || true) && (f_1637_8148_8163() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1637, 8144, 8490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 8265, 8339);

                    WindowsPrincipal
                    windowsPrincipal = f_1637_8301_8338(f_1637_8322_8337())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 8357, 8396);

                    return f_1637_8364_8395(windowsPrincipal, role);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1637, 8144, 8490);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1637, 8144, 8490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 8462, 8475);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1637, 8144, 8490);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1637, 8072, 8501);

                System.Security.Principal.WindowsIdentity
                f_1637_8148_8163()
                {
                    var return_v = WindowsIdentity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1637, 8148, 8163);
                    return return_v;
                }


                System.Security.Principal.WindowsIdentity
                f_1637_8322_8337()
                {
                    var return_v = WindowsIdentity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1637, 8322, 8337);
                    return return_v;
                }


                System.Security.Principal.WindowsPrincipal
                f_1637_8301_8338(System.Security.Principal.WindowsIdentity
                ntIdentity)
                {
                    var return_v = new System.Security.Principal.WindowsPrincipal(ntIdentity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1637, 8301, 8338);
                    return return_v;
                }


                bool
                f_1637_8364_8395(System.Security.Principal.WindowsPrincipal
                this_param, System.Security.Principal.WindowsBuiltInRole
                role)
                {
                    var return_v = this_param.IsInRole(role);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1637, 8364, 8395);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1637, 8072, 8501);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1637, 8072, 8501);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSPrincipal(PSIdentity identity, WindowsIdentity windowsIdentity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1637, 8948, 9124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 5740, 6053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 6433, 6758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 9045, 9065);

                Identity = identity;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 9079, 9113);

                WindowsIdentity = windowsIdentity;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1637, 8948, 9124);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1637, 8948, 9124);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1637, 8948, 9124);
            }
        }

        static PSPrincipal()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1637, 5516, 9153);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1637, 5516, 9153);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1637, 5516, 9153);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1637, 5516, 9153);
    }
    public sealed class PSIdentity : IIdentity
    {
        public string AuthenticationType { get; }

        public bool IsAuthenticated { get; }

        public string Name { get; }

        public PSCertificateDetails CertificateDetails { get; }

        public PSIdentity(string authType, bool isAuthenticated, string userName, PSCertificateDetails cert)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1637, 11390, 11674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 9853, 9894);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 10035, 10071);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 10170, 10197);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 10340, 10395);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 11515, 11545);

                AuthenticationType = authType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 11559, 11593);

                IsAuthenticated = isAuthenticated;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 11607, 11623);

                Name = userName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 11637, 11663);

                CertificateDetails = cert;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1637, 11390, 11674);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1637, 11390, 11674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1637, 11390, 11674);
            }
        }

        static PSIdentity()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1637, 9265, 11703);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1637, 9265, 11703);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1637, 9265, 11703);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1637, 9265, 11703);
    }
    public sealed class PSCertificateDetails
    {
        public string Subject { get; }

        public string IssuerName { get; }

        public string IssuerThumbprint { get; }

        public PSCertificateDetails(string subject, string issuerName, string issuerThumbprint)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1637, 12805, 13034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 12001, 12031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 12144, 12177);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 12278, 12317);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 12917, 12935);

                Subject = subject;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 12949, 12973);

                IssuerName = issuerName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1637, 12987, 13023);

                IssuerThumbprint = issuerThumbprint;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1637, 12805, 13034);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1637, 12805, 13034);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1637, 12805, 13034);
            }
        }

        static PSCertificateDetails()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1637, 11797, 13063);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1637, 11797, 13063);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1637, 11797, 13063);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1637, 11797, 13063);
    }
}
