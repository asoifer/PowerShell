// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.ComponentModel; // Win32Exception
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.IO.Pipes;
using System.Management.Automation.Internal;
using System.Management.Automation.Remoting;
using System.Management.Automation.Remoting.Client;
using System.Management.Automation.Tracing;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Threading;

using Microsoft.Win32.SafeHandles;

using Dbg = System.Management.Automation.Diagnostics;
using WSManAuthenticationMechanism = System.Management.Automation.Remoting.Client.WSManNativeApi.WSManAuthenticationMechanism;

// ReSharper disable CheckNamespace

namespace System.Management.Automation.Runspaces
// ReSharper restore CheckNamespace
{
    /// <summary>
    /// Different Authentication Mechanisms supported by New-Runspace command to connect
    /// to remote server.
    /// </summary>
    [SuppressMessage("Microsoft.Design", "CA1027:MarkEnumsWithFlags")]
    [SuppressMessage("Microsoft.Naming", "CA1724:TypeNamesShouldNotMatchNamespaces")]
    public enum AuthenticationMechanism
    {
        /// <summary>
        /// Use the default authentication (as defined by the underlying protocol)
        /// for establishing a remote connection.
        /// </summary>
        Default = 0x0,
        /// <summary>
        /// Use Basic authentication for establishing a remote connection.
        /// </summary>
        Basic = 0x1,
        /// <summary>
        /// Use Negotiate authentication for establishing a remote connection.
        /// </summary>
        Negotiate = 0x2,
        /// <summary>
        /// Use Negotiate authentication for establishing a remote connection.
        /// Allow implicit credentials for Negotiate.
        /// </summary>
        NegotiateWithImplicitCredential = 0x3,
        /// <summary>
        /// Use CredSSP authentication for establishing a remote connection.
        /// </summary>
        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Credssp")]
        Credssp = 0x4,
        /// <summary>
        /// Use Digest authentication mechanism. Digest authentication operates much
        /// like Basic authentication. However, unlike Basic authentication, Digest authentication
        /// transmits credentials across the network as a hash value, also known as a message digest.
        /// The user name and password cannot be deciphered from the hash value. Conversely, Basic
        /// authentication sends a Base 64 encoded password, essentially in clear text, across the
        /// network.
        /// </summary>
        Digest = 0x5,
        /// <summary>
        /// Use Kerberos authentication for establishing a remote connection.
        /// </summary>
        Kerberos = 0x6,
    }

    /// <summary>
    /// Specify the type of access mode that should be
    /// used when creating a session configuration.
    /// </summary>
    public enum PSSessionConfigurationAccessMode
    {
        /// <summary>
        /// Disable the configuration.
        /// </summary>
        Disabled = 0,

        /// <summary>
        /// Allow local access.
        /// </summary>
        Local = 1,

        /// <summary>
        /// Default allow remote access.
        /// </summary>
        Remote = 2,
    }

    /// <summary>
    /// WSManTransportManager supports disconnected PowerShell sessions.
    /// When a remote PS session server is in disconnected state, output
    /// from the running command pipeline is cached on the server.  This
    /// enum determines what the server does when the cache is full.
    /// </summary>
    public enum OutputBufferingMode
    {
        /// <summary>
        /// No output buffering mode specified.  Output buffering mode on server will
        /// default to Block if a new session is created, or will retain its current
        /// mode for non-creation scenarios (e.g., disconnect/connect operations).
        /// </summary>
        None = 0,

        /// <summary>
        /// Command pipeline execution continues, excess output is dropped in FIFO manner.
        /// </summary>
        Drop = 1,

        /// <summary>
        /// Command pipeline execution on server is blocked until session is reconnected.
        /// </summary>
        Block = 2
    }
    public abstract class RunspaceConnectionInfo
    {
        public abstract string ComputerName { get; set; }

        public abstract PSCredential Credential { get; set; }

        public abstract AuthenticationMechanism AuthenticationMechanism { get; set; }

        public abstract string CertificateThumbprint { get; set; }

        public CultureInfo Culture
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 6006, 6073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 6042, 6058);

                    return _culture;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 6006, 6073);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 5955, 6307);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 5955, 6307);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 6089, 6296);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 6125, 6244) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 6125, 6244);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 6184, 6225);

                        throw f_1629_6190_6224("value");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 6125, 6244);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 6264, 6281);

                    _culture = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 6089, 6296);

                    System.ArgumentNullException
                    f_1629_6190_6224(string
                    paramName)
                    {
                        var return_v = new System.ArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 6190, 6224);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 5955, 6307);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 5955, 6307);
                }
            }
        }

        private CultureInfo _culture;

        public CultureInfo UICulture
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 6549, 6618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 6585, 6603);

                    return _uiCulture;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 6549, 6618);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 6496, 6854);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 6496, 6854);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 6634, 6843);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 6670, 6789) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 6670, 6789);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 6729, 6770);

                        throw f_1629_6735_6769("value");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 6670, 6789);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 6809, 6828);

                    _uiCulture = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 6634, 6843);

                    System.ArgumentNullException
                    f_1629_6735_6769(string
                    paramName)
                    {
                        var return_v = new System.ArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 6735, 6769);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 6496, 6854);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 6496, 6854);
                }
            }
        }

        private CultureInfo _uiCulture;

        public int OpenTimeout
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 7401, 7429);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 7407, 7427);

                    return _openTimeout;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 7401, 7429);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 7354, 8269);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 7354, 8269);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 7445, 8258);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 7481, 7502);

                    _openTimeout = value;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 7522, 8243) || true) && (this is WSManConnectionInfo && (DynAbs.Tracing.TraceSender.Expression_True(1629, 7526, 7587) && _openTimeout == DefaultTimeout))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 7522, 8243);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 7629, 7663);

                        _openTimeout = DefaultOpenTimeout;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 7522, 8243);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 7522, 8243);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 7705, 8243) || true) && (this is WSManConnectionInfo && (DynAbs.Tracing.TraceSender.Expression_True(1629, 7709, 7771) && _openTimeout == InfiniteTimeout))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 7705, 8243);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 8194, 8224);

                            _openTimeout = Int32.MaxValue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 7705, 8243);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 7522, 8243);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 7445, 8258);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 7354, 8269);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 7354, 8269);
                }
            }
        }

        private int _openTimeout;

        internal const int
        DefaultOpenTimeout = 3 * 60 * 1000
        ;

        internal const int
        DefaultTimeout = -1
        ;

        internal const int
        InfiniteTimeout = 0
        ;

        public int CancelTimeout { get; set; }

        internal const int
        defaultCancelTimeout = BaseTransportManager.ClientCloseTimeoutMs
        ;

        public int OperationTimeout { get; set; }

        public int IdleTimeout { get; set; }

        internal const int
        DefaultIdleTimeout = BaseTransportManager.UseServerDefaultIdleTimeout
        ;

        public int MaxIdleTimeout { get; internal set; }

        public virtual void SetSessionOptions(PSSessionOption options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 10799, 12010);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 10886, 10997) || true) && (options == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 10886, 10997);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 10939, 10982);

                    throw f_1629_10945_10981("options");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 10886, 10997);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 11013, 11120) || true) && (f_1629_11017_11032(options) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 11013, 11120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 11074, 11105);

                    this.Culture = f_1629_11089_11104(options);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 11013, 11120);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 11136, 11249) || true) && (f_1629_11140_11157(options) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 11136, 11249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 11199, 11234);

                    this.UICulture = f_1629_11216_11233(options);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 11136, 11249);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 11265, 11321);

                _openTimeout = f_1629_11280_11320(this, f_1629_11300_11319(options));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 11335, 11394);

                CancelTimeout = f_1629_11351_11393(this, f_1629_11371_11392(options));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 11408, 11473);

                OperationTimeout = f_1629_11427_11472(this, f_1629_11447_11471(options));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 11709, 11999);

                IdleTimeout = (DynAbs.Tracing.TraceSender.Conditional_F1(1629, 11723, 11903) || (((options.IdleTimeout.TotalMilliseconds >= BaseTransportManager.UseServerDefaultIdleTimeout && (DynAbs.Tracing.TraceSender.Expression_True(1629, 11724, 11902) && options.IdleTimeout.TotalMilliseconds < int.MaxValue))
                && DynAbs.Tracing.TraceSender.Conditional_F2(1629, 11939, 11983)) || DynAbs.Tracing.TraceSender.Conditional_F3(1629, 11986, 11998))) ? (int)(options.IdleTimeout.TotalMilliseconds) : int.MaxValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 10799, 12010);

                System.ArgumentNullException
                f_1629_10945_10981(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 10945, 10981);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1629_11017_11032(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.Culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 11017, 11032);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1629_11089_11104(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.Culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 11089, 11104);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1629_11140_11157(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.UICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 11140, 11157);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1629_11216_11233(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.UICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 11216, 11233);
                    return return_v;
                }


                System.TimeSpan
                f_1629_11300_11319(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.OpenTimeout;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 11300, 11319);
                    return return_v;
                }


                int
                f_1629_11280_11320(System.Management.Automation.Runspaces.RunspaceConnectionInfo
                this_param, System.TimeSpan
                t)
                {
                    var return_v = this_param.TimeSpanToTimeOutMs(t);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 11280, 11320);
                    return return_v;
                }


                System.TimeSpan
                f_1629_11371_11392(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.CancelTimeout;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 11371, 11392);
                    return return_v;
                }


                int
                f_1629_11351_11393(System.Management.Automation.Runspaces.RunspaceConnectionInfo
                this_param, System.TimeSpan
                t)
                {
                    var return_v = this_param.TimeSpanToTimeOutMs(t);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 11351, 11393);
                    return return_v;
                }


                System.TimeSpan
                f_1629_11447_11471(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.OperationTimeout;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 11447, 11471);
                    return return_v;
                }


                int
                f_1629_11427_11472(System.Management.Automation.Runspaces.RunspaceConnectionInfo
                this_param, System.TimeSpan
                t)
                {
                    var return_v = this_param.TimeSpanToTimeOutMs(t);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 11427, 11472);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 10799, 12010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 10799, 12010);
            }
        }

        internal int TimeSpanToTimeOutMs(TimeSpan t)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 12098, 12444);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 12167, 12433) || true) && ((t.TotalMilliseconds > int.MaxValue) || (DynAbs.Tracing.TraceSender.Expression_False(1629, 12171, 12235) || (t == TimeSpan.MaxValue)) || (DynAbs.Tracing.TraceSender.Expression_False(1629, 12171, 12264) || (t.TotalMilliseconds < 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 12167, 12433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 12298, 12318);

                    return int.MaxValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 12167, 12433);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 12167, 12433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 12384, 12418);

                    return (int)(t.TotalMilliseconds);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 12167, 12433);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 12098, 12444);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 12098, 12444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 12098, 12444);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual BaseClientSessionTransportManager CreateClientSessionTransportManager(
                    Guid instanceId,
                    string sessionName,
                    PSRemotingCryptoHelper cryptoHelper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 12779, 13053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 13004, 13042);

                throw f_1629_13010_13041();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 12779, 13053);

                System.Management.Automation.PSNotImplementedException
                f_1629_13010_13041()
                {
                    var return_v = new System.Management.Automation.PSNotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 13010, 13041);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 12779, 13053);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 12779, 13053);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual RunspaceConnectionInfo InternalCopy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 13238, 13366);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 13317, 13355);

                throw f_1629_13323_13354();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 13238, 13366);

                System.Management.Automation.PSNotImplementedException
                f_1629_13323_13354()
                {
                    var return_v = new System.Management.Automation.PSNotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 13323, 13354);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 13238, 13366);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 13238, 13366);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual void ValidatePortInRange(int port)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 13538, 13967);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 13614, 13956) || true) && ((port < MinPort || (DynAbs.Tracing.TraceSender.Expression_False(1629, 13619, 13651) || port > MaxPort)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 13614, 13956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 13686, 13844);

                    string
                    message =
                    f_1629_13724_13843(f_1629_13797_13836(), port)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 13862, 13915);

                    ArgumentException
                    e = f_1629_13884_13914(message)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 13933, 13941);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 13614, 13956);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 13538, 13967);

                string
                f_1629_13797_13836()
                {
                    var return_v = RemotingErrorIdStrings.PortIsOutOfRange;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 13797, 13836);
                    return return_v;
                }


                string
                f_1629_13724_13843(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 13724, 13843);
                    return return_v;
                }


                System.ArgumentException
                f_1629_13884_13914(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 13884, 13914);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 13538, 13967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 13538, 13967);
            }
        }

        protected const int
        MaxPort = 0xFFFF
        ;

        protected const int
        MinPort = 0
        ;

        public RunspaceConnectionInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1629, 4922, 14308);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 6339, 6376);
            this._culture = f_1629_6350_6376();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 6886, 6927);
            this._uiCulture = f_1629_6899_6927();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 8293, 8326);
            this._openTimeout = DefaultOpenTimeout;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 9129, 9191);
            this.CancelTimeout = defaultCancelTimeout;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 9680, 9777);
            this.OperationTimeout = BaseTransportManager.ClientDefaultOperationTimeoutMs;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 10137, 10195);
            this.IdleTimeout = DefaultIdleTimeout;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 10558, 10624);
            this.MaxIdleTimeout = Int32.MaxValue;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1629, 4922, 14308);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 4922, 14308);
        }


        static RunspaceConnectionInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1629, 4922, 14308);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 8356, 8390);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 8433, 8452);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 8482, 8501);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 9222, 9286);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 10226, 10295);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 14134, 14150);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 14267, 14278);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1629, 4922, 14308);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 4922, 14308);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1629, 4922, 14308);

        System.Globalization.CultureInfo
        f_1629_6350_6376()
        {
            var return_v = CultureInfo.CurrentCulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 6350, 6376);
            return return_v;
        }


        System.Globalization.CultureInfo
        f_1629_6899_6927()
        {
            var return_v = CultureInfo.CurrentUICulture;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 6899, 6927);
            return return_v;
        }

    }
    public sealed class WSManConnectionInfo : RunspaceConnectionInfo
    {
        public Uri ConnectionUri
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 14713, 14786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 14749, 14771);

                    return _connectionUri;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 14713, 14786);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 14664, 15033);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 14664, 15033);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 14802, 15022);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 14838, 14970) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 14838, 14970);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 14897, 14951);

                        throw f_1629_14903_14950("value");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 14838, 14970);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 14990, 15007);

                    f_1629_14990_15006(this, value);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 14802, 15022);

                    System.Management.Automation.PSArgumentNullException
                    f_1629_14903_14950(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 14903, 14950);
                        return return_v;
                    }


                    int
                    f_1629_14990_15006(System.Management.Automation.Runspaces.WSManConnectionInfo
                    this_param, System.Uri
                    uri)
                    {
                        this_param.UpdateUri(uri);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 14990, 15006);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 14664, 15033);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 14664, 15033);
                }
            }
        }

        public override string ComputerName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 15187, 15259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 15223, 15244);

                    return _computerName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 15187, 15259);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 15127, 15430);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 15127, 15430);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 15275, 15419);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 15359, 15404);

                    f_1629_15359_15403(this, _scheme, value, null, _appName);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 15275, 15419);

                    int
                    f_1629_15359_15403(System.Management.Automation.Runspaces.WSManConnectionInfo
                    this_param, string
                    scheme, string
                    computerName, int?
                    port, string
                    appName)
                    {
                        this_param.ConstructUri(scheme, computerName, port, appName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 15359, 15403);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 15127, 15430);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 15127, 15430);
                }
            }
        }

        public string Scheme
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 15575, 15641);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 15611, 15626);

                    return _scheme;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 15575, 15641);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 15530, 15818);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 15530, 15818);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 15657, 15807);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 15741, 15792);

                    f_1629_15741_15791(this, value, _computerName, null, _appName);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 15657, 15807);

                    int
                    f_1629_15741_15791(System.Management.Automation.Runspaces.WSManConnectionInfo
                    this_param, string
                    scheme, string
                    computerName, int?
                    port, string
                    appName)
                    {
                        this_param.ConstructUri(scheme, computerName, port, appName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 15741, 15791);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 15530, 15818);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 15530, 15818);
                }
            }
        }

        public int Port
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 15956, 16033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 15992, 16018);

                    return f_1629_15999_16017(f_1629_15999_16012());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 15956, 16033);

                    System.Uri
                    f_1629_15999_16012()
                    {
                        var return_v = ConnectionUri;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 15999, 16012);
                        return return_v;
                    }


                    int
                    f_1629_15999_16017(System.Uri
                    this_param)
                    {
                        var return_v = this_param.Port;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 15999, 16017);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 15916, 16165);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 15916, 16165);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 16049, 16154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 16085, 16139);

                    f_1629_16085_16138(this, _scheme, _computerName, value, _appName);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 16049, 16154);

                    int
                    f_1629_16085_16138(System.Management.Automation.Runspaces.WSManConnectionInfo
                    this_param, string
                    scheme, string
                    computerName, int
                    port, string
                    appName)
                    {
                        this_param.ConstructUri(scheme, computerName, (int?)port, appName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 16085, 16138);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 15916, 16165);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 15916, 16165);
                }
            }
        }

        public string AppName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 16362, 16429);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 16398, 16414);

                    return _appName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 16362, 16429);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 16316, 16605);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 16316, 16605);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 16445, 16594);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 16529, 16579);

                    f_1629_16529_16578(this, _scheme, _computerName, null, value);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 16445, 16594);

                    int
                    f_1629_16529_16578(System.Management.Automation.Runspaces.WSManConnectionInfo
                    this_param, string
                    scheme, string
                    computerName, int?
                    port, string
                    appName)
                    {
                        this_param.ConstructUri(scheme, computerName, port, appName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 16529, 16578);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 16316, 16605);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 16316, 16605);
                }
            }
        }

        public override PSCredential Credential
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 16777, 16847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 16813, 16832);

                    return _credential;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 16777, 16847);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 16713, 16993);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 16713, 16993);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 16863, 16982);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 16947, 16967);

                    _credential = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 16863, 16982);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 16713, 16993);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 16713, 16993);
                }
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "System.Management.Automation.Runspaces.WSManConnectionInfo.#ShellUri")]
        public string ShellUri
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 17287, 17355);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 17323, 17340);

                    return _shellUri;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 17287, 17355);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 17052, 17468);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 17052, 17468);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 17371, 17457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 17407, 17442);

                    _shellUri = f_1629_17419_17441(this, value);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 17371, 17457);

                    string
                    f_1629_17419_17441(System.Management.Automation.Runspaces.WSManConnectionInfo
                    this_param, string
                    shell)
                    {
                        var return_v = this_param.ResolveShellUri(shell);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 17419, 17441);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 17052, 17468);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 17052, 17468);
                }
            }
        }

        public override AuthenticationMechanism AuthenticationMechanism
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 17692, 19098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 17728, 19083);

                    switch (f_1629_17736_17764())
                    {

                        case WSManAuthenticationMechanism.WSMAN_FLAG_DEFAULT_AUTHENTICATION:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 17728, 19083);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 17900, 17939);

                            return AuthenticationMechanism.Default;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 17728, 19083);

                        case WSManAuthenticationMechanism.WSMAN_FLAG_AUTH_BASIC:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 17728, 19083);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 18043, 18080);

                            return AuthenticationMechanism.Basic;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 17728, 19083);

                        case WSManAuthenticationMechanism.WSMAN_FLAG_AUTH_CREDSSP:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 17728, 19083);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 18186, 18225);

                            return AuthenticationMechanism.Credssp;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 17728, 19083);

                        case WSManAuthenticationMechanism.WSMAN_FLAG_AUTH_NEGOTIATE:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 17728, 19083);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 18333, 18520) || true) && (f_1629_18337_18372())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 18333, 18520);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 18430, 18493);

                                return AuthenticationMechanism.NegotiateWithImplicitCredential;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 18333, 18520);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 18548, 18589);

                            return AuthenticationMechanism.Negotiate;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 17728, 19083);

                        case WSManAuthenticationMechanism.WSMAN_FLAG_AUTH_DIGEST:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 17728, 19083);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 18694, 18732);

                            return AuthenticationMechanism.Digest;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 17728, 19083);

                        case WSManAuthenticationMechanism.WSMAN_FLAG_AUTH_KERBEROS:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 17728, 19083);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 18839, 18879);

                            return AuthenticationMechanism.Kerberos;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 17728, 19083);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 17728, 19083);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 18935, 18999);

                            f_1629_18935_18998(false, "Invalid authentication mechanism detected.");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 19025, 19064);

                            return AuthenticationMechanism.Default;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 17728, 19083);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 17692, 19098);

                    System.Management.Automation.Remoting.Client.WSManNativeApi.WSManAuthenticationMechanism
                    f_1629_17736_17764()
                    {
                        var return_v = WSManAuthenticationMechanism;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 17736, 17764);
                        return return_v;
                    }


                    bool
                    f_1629_18337_18372()
                    {
                        var return_v = AllowImplicitCredentialForNegotiate;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 18337, 18372);
                        return return_v;
                    }


                    int
                    f_1629_18935_18998(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Dbg.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 18935, 18998);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 17604, 20886);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 17604, 20886);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 19114, 20875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 19150, 20806);

                    switch (value)
                    {

                        case AuthenticationMechanism.Default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 19150, 20806);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 19268, 19362);

                            WSManAuthenticationMechanism = WSManAuthenticationMechanism.WSMAN_FLAG_DEFAULT_AUTHENTICATION;
                            DynAbs.Tracing.TraceSender.TraceBreak(1629, 19388, 19394);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 19150, 20806);

                        case AuthenticationMechanism.Basic:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 19150, 20806);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 19477, 19559);

                            WSManAuthenticationMechanism = WSManAuthenticationMechanism.WSMAN_FLAG_AUTH_BASIC;
                            DynAbs.Tracing.TraceSender.TraceBreak(1629, 19585, 19591);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 19150, 20806);

                        case AuthenticationMechanism.Negotiate:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 19150, 20806);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 19678, 19764);

                            WSManAuthenticationMechanism = WSManAuthenticationMechanism.WSMAN_FLAG_AUTH_NEGOTIATE;
                            DynAbs.Tracing.TraceSender.TraceBreak(1629, 19790, 19796);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 19150, 20806);

                        case AuthenticationMechanism.NegotiateWithImplicitCredential:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 19150, 20806);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 19905, 19991);

                            WSManAuthenticationMechanism = WSManAuthenticationMechanism.WSMAN_FLAG_AUTH_NEGOTIATE;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 20017, 20060);

                            AllowImplicitCredentialForNegotiate = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(1629, 20086, 20092);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 19150, 20806);

                        case AuthenticationMechanism.Credssp:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 19150, 20806);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 20177, 20261);

                            WSManAuthenticationMechanism = WSManAuthenticationMechanism.WSMAN_FLAG_AUTH_CREDSSP;
                            DynAbs.Tracing.TraceSender.TraceBreak(1629, 20287, 20293);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 19150, 20806);

                        case AuthenticationMechanism.Digest:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 19150, 20806);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 20377, 20460);

                            WSManAuthenticationMechanism = WSManAuthenticationMechanism.WSMAN_FLAG_AUTH_DIGEST;
                            DynAbs.Tracing.TraceSender.TraceBreak(1629, 20486, 20492);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 19150, 20806);

                        case AuthenticationMechanism.Kerberos:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 19150, 20806);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 20578, 20663);

                            WSManAuthenticationMechanism = WSManAuthenticationMechanism.WSMAN_FLAG_AUTH_KERBEROS;
                            DynAbs.Tracing.TraceSender.TraceBreak(1629, 20689, 20695);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 19150, 20806);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 19150, 20806);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 20751, 20787);

                            throw f_1629_20757_20786();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 19150, 20806);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 20826, 20860);

                    f_1629_20826_20859(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 19114, 20875);

                    System.Management.Automation.PSNotSupportedException
                    f_1629_20757_20786()
                    {
                        var return_v = new System.Management.Automation.PSNotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 20757, 20786);
                        return return_v;
                    }


                    int
                    f_1629_20826_20859(System.Management.Automation.Runspaces.WSManConnectionInfo
                    this_param)
                    {
                        this_param.ValidateSpecifiedAuthentication();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 20826, 20859);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 17604, 20886);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 17604, 20886);
                }
            }
        }

        internal WSManAuthenticationMechanism WSManAuthenticationMechanism { get; private set; }

        internal bool AllowImplicitCredentialForNegotiate { get; private set; }

        internal int PortSetting { get; private set; }

        public override string CertificateThumbprint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 21947, 21974);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 21953, 21972);

                    return _thumbPrint;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 21947, 21974);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 21878, 22224);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 21878, 22224);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 21990, 22213);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 22026, 22158) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 22026, 22158);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 22085, 22139);

                        throw f_1629_22091_22138("value");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 22026, 22158);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 22178, 22198);

                    _thumbPrint = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 21990, 22213);

                    System.Management.Automation.PSArgumentNullException
                    f_1629_22091_22138(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 22091, 22138);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 21878, 22224);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 21878, 22224);
                }
            }
        }

        public int MaximumConnectionRedirectionCount { get; set; }

        internal const int
        defaultMaximumConnectionRedirectionCount = 5
        ;

        public int? MaximumReceivedDataSizePerCommand { get; set; }

        public int? MaximumReceivedObjectSize { get; set; }

        public bool UseCompression { get; set; }

        public bool NoMachineProfile { get; set; }

        public ProxyAccessType ProxyAccessType { get; set; }

        public AuthenticationMechanism ProxyAuthentication
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 25672, 25708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 25678, 25706);

                    return _proxyAuthentication;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 25672, 25708);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 25597, 26591);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 25597, 26591);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 25724, 26580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 25760, 26565);

                    switch (value)
                    {

                        case AuthenticationMechanism.Basic:
                        case AuthenticationMechanism.Negotiate:
                        case AuthenticationMechanism.Digest:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 25760, 26565);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 25995, 26024);

                            _proxyAuthentication = value;
                            DynAbs.Tracing.TraceSender.TraceBreak(1629, 26050, 26056);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 25760, 26565);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 25760, 26565);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 26112, 26483);

                            string
                            message = f_1629_26129_26482(f_1629_26176_26227(), value, f_1629_26294_26334(AuthenticationMechanism.Basic), f_1629_26365_26409(AuthenticationMechanism.Negotiate), f_1629_26440_26481(AuthenticationMechanism.Digest))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 26509, 26546);

                            throw f_1629_26515_26545(message);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 25760, 26565);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 25724, 26580);

                    string
                    f_1629_26176_26227()
                    {
                        var return_v = RemotingErrorIdStrings.ProxyAmbiguousAuthentication;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 26176, 26227);
                        return return_v;
                    }


                    string
                    f_1629_26294_26334(System.Management.Automation.Runspaces.AuthenticationMechanism
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 26294, 26334);
                        return return_v;
                    }


                    string
                    f_1629_26365_26409(System.Management.Automation.Runspaces.AuthenticationMechanism
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 26365, 26409);
                        return return_v;
                    }


                    string
                    f_1629_26440_26481(System.Management.Automation.Runspaces.AuthenticationMechanism
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 26440, 26481);
                        return return_v;
                    }


                    string
                    f_1629_26129_26482(string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 26129, 26482);
                        return return_v;
                    }


                    System.ArgumentException
                    f_1629_26515_26545(string
                    message)
                    {
                        var return_v = new System.ArgumentException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 26515, 26545);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 25597, 26591);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 25597, 26591);
                }
            }
        }

        public PSCredential ProxyCredential
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 26797, 26829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 26803, 26827);

                    return _proxyCredential;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 26797, 26829);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 26737, 27287);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 26737, 27287);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 26845, 27276);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 26881, 27216) || true) && (f_1629_26885_26900() == ProxyAccessType.None)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 26881, 27216);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 26966, 27138);

                        string
                        message = f_1629_26983_27137(f_1629_27030_27081(), ProxyAccessType.None)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 27160, 27197);

                        throw f_1629_27166_27196(message);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 26881, 27216);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 27236, 27261);

                    _proxyCredential = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 26845, 27276);

                    System.Management.Automation.Remoting.ProxyAccessType
                    f_1629_26885_26900()
                    {
                        var return_v = ProxyAccessType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 26885, 26900);
                        return return_v;
                    }


                    string
                    f_1629_27030_27081()
                    {
                        var return_v = RemotingErrorIdStrings.ProxyCredentialWithoutAccess;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 27030, 27081);
                        return return_v;
                    }


                    string
                    f_1629_26983_27137(string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 26983, 27137);
                        return return_v;
                    }


                    System.ArgumentException
                    f_1629_27166_27196(string
                    message)
                    {
                        var return_v = new System.ArgumentException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 27166, 27196);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 26737, 27287);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 26737, 27287);
                }
            }
        }

        public bool SkipCACheck { get; set; }

        public bool SkipCNCheck { get; set; }

        public bool SkipRevocationCheck { get; set; }

        public bool NoEncryption { get; set; }

        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "UTF")]
        public bool UseUTF16 { get; set; }

        public OutputBufferingMode OutputBufferingMode { get; set; }

        [SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "SPN")]
        public bool IncludePortInSPN { get; set; }

        public bool EnableNetworkAccess { get; set; }

        public int MaxConnectionRetryCount { get; set; }

        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "System.Management.Automation.Runspaces.WSManConnectionInfo.#.ctor(System.String,System.String,System.Int32,System.String,System.String,System.Management.Automation.PSCredential,System.Int64,System.Int64)", MessageId = "4#")]
        public WSManConnectionInfo(string scheme, string computerName, int port, string appName, string shellUri, PSCredential credential, int openTimeout)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1629, 31439, 32191);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 21061, 21215);
                this.WSManAuthenticationMechanism = WSManAuthenticationMechanism.WSMAN_FLAG_DEFAULT_AUTHENTICATION;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 21328, 21399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 21570, 21622);
                this.PortSetting = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 22327, 22385);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 22716, 22775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 23012, 23063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 23592, 23640);
                this.UseCompression = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 24023, 24065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 24901, 24977);
                this.ProxyAccessType = ProxyAccessType.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 27779, 27816);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 28113, 28150);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 28447, 28492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 28766, 28804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 28984, 29128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 29353, 29443);
                this.OutputBufferingMode = DefaultOutputBufferingMode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 29599, 29751);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 30206, 30251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 30447, 30529);
                this.MaxConnectionRetryCount = DefaultMaxConnectionRetryCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54181, 54201);
                this._scheme = HttpScheme;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54227, 54262);
                this._computerName = DefaultComputerName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54288, 54315);
                this._appName = s_defaultAppName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54338, 54382);
                this._connectionUri = f_1629_54355_54382(LocalHostUriString);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54449, 54460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54535, 54562);
                this._shellUri = DefaultShellUri;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54636, 54647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54690, 54710);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54742, 54758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 56788, 56835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 59383, 59474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 59677, 59763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 31952, 31968);

                Scheme = scheme;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 31982, 32010);

                ComputerName = computerName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 32024, 32036);

                Port = port;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 32050, 32068);

                AppName = appName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 32082, 32102);

                ShellUri = shellUri;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 32116, 32140);

                Credential = credential;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 32154, 32180);

                OpenTimeout = openTimeout;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1629, 31439, 32191);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 31439, 32191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 31439, 32191);
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "System.Management.Automation.Runspaces.WSManConnectionInfo.#.ctor(System.String,System.String,System.Int32,System.String,System.String,System.Management.Automation.PSCredential)", MessageId = "4#")]
        public WSManConnectionInfo(string scheme, string computerName, int port, string appName, string shellUri, PSCredential credential) : this(f_1629_33486_33492_C(scheme), computerName, port, appName, shellUri, credential, DefaultOpenTimeout)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1629, 33020, 33586);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1629, 33020, 33586);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 33020, 33586);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 33020, 33586);
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "4#")]
        public WSManConnectionInfo(bool useSsl, string computerName, int port, string appName, string shellUri,
                    PSCredential credential) : this(f_1629_34246_34287_C((DynAbs.Tracing.TraceSender.Conditional_F1(1629, 34246, 34252) || ((useSsl && DynAbs.Tracing.TraceSender.Conditional_F2(1629, 34255, 34271)) || DynAbs.Tracing.TraceSender.Conditional_F3(1629, 34274, 34287))) ? DefaultSslScheme : DefaultScheme), computerName, port, appName, shellUri, credential)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1629, 33977, 34361);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1629, 33977, 34361);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 33977, 34361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 33977, 34361);
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "4#")]
        public WSManConnectionInfo(bool useSsl, string computerName, int port, string appName, string shellUri, PSCredential credential, int openTimeout) : this(f_1629_35010_35051_C((DynAbs.Tracing.TraceSender.Conditional_F1(1629, 35010, 35016) || ((useSsl && DynAbs.Tracing.TraceSender.Conditional_F2(1629, 35019, 35035)) || DynAbs.Tracing.TraceSender.Conditional_F3(1629, 35038, 35051))) ? DefaultSslScheme : DefaultScheme), computerName, port, appName, shellUri, credential, openTimeout)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1629, 34737, 35138);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1629, 34737, 35138);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 34737, 35138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 34737, 35138);
            }
        }

        public WSManConnectionInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1629, 35493, 35679);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 21061, 21215);
                this.WSManAuthenticationMechanism = WSManAuthenticationMechanism.WSMAN_FLAG_DEFAULT_AUTHENTICATION;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 21328, 21399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 21570, 21622);
                this.PortSetting = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 22327, 22385);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 22716, 22775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 23012, 23063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 23592, 23640);
                this.UseCompression = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 24023, 24065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 24901, 24977);
                this.ProxyAccessType = ProxyAccessType.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 27779, 27816);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 28113, 28150);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 28447, 28492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 28766, 28804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 28984, 29128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 29353, 29443);
                this.OutputBufferingMode = DefaultOutputBufferingMode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 29599, 29751);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 30206, 30251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 30447, 30529);
                this.MaxConnectionRetryCount = DefaultMaxConnectionRetryCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54181, 54201);
                this._scheme = HttpScheme;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54227, 54262);
                this._computerName = DefaultComputerName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54288, 54315);
                this._appName = s_defaultAppName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54338, 54382);
                this._connectionUri = f_1629_54355_54382(LocalHostUriString);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54449, 54460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54535, 54562);
                this._shellUri = DefaultShellUri;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54636, 54647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54690, 54710);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54742, 54758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 56788, 56835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 59383, 59474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 59677, 59763);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 35641, 35668);

                UseDefaultWSManPort = true;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1629, 35493, 35679);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 35493, 35679);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 35493, 35679);
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Scope = "member", Target = "System.Management.Automation.Runspaces.WSManConnectionInfo.#.ctor(System.Uri,System.String,System.Management.Automation.PSCredential)", MessageId = "1#")]
        public WSManConnectionInfo(Uri uri, string shellUri, PSCredential credential)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1629, 36264, 37994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 21061, 21215);
                this.WSManAuthenticationMechanism = WSManAuthenticationMechanism.WSMAN_FLAG_DEFAULT_AUTHENTICATION;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 21328, 21399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 21570, 21622);
                this.PortSetting = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 22327, 22385);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 22716, 22775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 23012, 23063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 23592, 23640);
                this.UseCompression = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 24023, 24065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 24901, 24977);
                this.ProxyAccessType = ProxyAccessType.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 27779, 27816);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 28113, 28150);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 28447, 28492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 28766, 28804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 28984, 29128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 29353, 29443);
                this.OutputBufferingMode = DefaultOutputBufferingMode;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 29599, 29751);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 30206, 30251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 30447, 30529);
                this.MaxConnectionRetryCount = DefaultMaxConnectionRetryCount;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54181, 54201);
                this._scheme = HttpScheme;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54227, 54262);
                this._computerName = DefaultComputerName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54288, 54315);
                this._appName = s_defaultAppName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54338, 54382);
                this._connectionUri = f_1629_54355_54382(LocalHostUriString);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54449, 54460);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54535, 54562);
                this._shellUri = DefaultShellUri;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54636, 54647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54690, 54710);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54742, 54758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 56788, 56835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 59383, 59474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 59677, 59763);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 36637, 36951) || true) && (uri == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 36637, 36951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 36804, 36824);

                    ShellUri = shellUri;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 36842, 36866);

                    Credential = credential;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 36884, 36911);

                    UseDefaultWSManPort = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 36929, 36936);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 36637, 36951);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 36967, 37235) || true) && (f_1629_36971_36989_M(!uri.IsAbsoluteUri))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 36967, 37235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 37023, 37220);

                    throw f_1629_37029_37219(f_1629_37055_37218(f_1629_37156_37217()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 36967, 37235);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 37463, 37909) || true) && (f_1629_37467_37531(f_1629_37467_37483(uri), "/", StringComparison.OrdinalIgnoreCase) && (DynAbs.Tracing.TraceSender.Expression_True(1629, 37467, 37583) && f_1629_37552_37583(f_1629_37573_37582(uri))) && (DynAbs.Tracing.TraceSender.Expression_True(1629, 37467, 37621) && f_1629_37587_37621(f_1629_37608_37620(uri))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 37463, 37909);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 37655, 37808);

                    f_1629_37655_37807(this, f_1629_37668_37678(uri), f_1629_37710_37718(uri), f_1629_37750_37758(uri), s_defaultAppName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 37463, 37909);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 37463, 37909);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 37874, 37894);

                    ConnectionUri = uri;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 37463, 37909);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 37925, 37945);

                ShellUri = shellUri;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 37959, 37983);

                Credential = credential;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1629, 36264, 37994);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 36264, 37994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 36264, 37994);
            }
        }

        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "1#")]
        public WSManConnectionInfo(Uri uri, string shellUri, string certificateThumbprint)
        : this(f_1629_38734_38737_C(uri), shellUri, (PSCredential)null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1629, 38524, 38840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 38793, 38829);

                _thumbPrint = certificateThumbprint;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1629, 38524, 38840);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 38524, 38840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 38524, 38840);
            }
        }

        public WSManConnectionInfo(Uri uri)
        : this(f_1629_39343_39346_C(uri), DefaultShellUri, DefaultCredential)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1629, 39287, 39405);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1629, 39287, 39405);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 39287, 39405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 39287, 39405);
            }
        }

        public override void SetSessionOptions(PSSessionOption options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 39914, 41689);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 40002, 40113) || true) && (options == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 40002, 40113);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 40055, 40098);

                    throw f_1629_40061_40097("options");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 40002, 40113);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 40129, 40491) || true) && ((f_1629_40134_40157(options) == ProxyAccessType.None) && (DynAbs.Tracing.TraceSender.Expression_True(1629, 40133, 40219) && (f_1629_40187_40210(options) != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 40129, 40491);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 40253, 40421);

                    string
                    message = f_1629_40270_40420(f_1629_40317_40368(), ProxyAccessType.None)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 40439, 40476);

                    throw f_1629_40445_40475(message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 40129, 40491);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 40507, 40539);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetSessionOptions(options), 1629, 40507, 40538);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 40555, 40744);

                this.MaximumConnectionRedirectionCount =
                (DynAbs.Tracing.TraceSender.Conditional_F1(1629, 40613, 40659) || ((f_1629_40613_40654(options) >= 0
                && DynAbs.Tracing.TraceSender.Conditional_F2(1629, 40687, 40728)) || DynAbs.Tracing.TraceSender.Conditional_F3(1629, 40731, 40743))) ? f_1629_40687_40728(options) : int.MaxValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 40760, 40843);

                this.MaximumReceivedDataSizePerCommand = f_1629_40801_40842(options);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 40857, 40924);

                this.MaximumReceivedObjectSize = f_1629_40890_40923(options);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 40940, 40987);

                this.UseCompression = f_1629_40962_40986_M(!(f_1629_40964_40985(options)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 41001, 41050);

                this.NoMachineProfile = f_1629_41025_41049(options);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 41066, 41108);

                ProxyAccessType = f_1629_41084_41107(options);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 41122, 41173);

                _proxyAuthentication = f_1629_41145_41172(options);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 41187, 41230);

                _proxyCredential = f_1629_41206_41229(options);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 41244, 41278);

                SkipCACheck = f_1629_41258_41277(options);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 41292, 41326);

                SkipCNCheck = f_1629_41306_41325(options);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 41340, 41390);

                SkipRevocationCheck = f_1629_41362_41389(options);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 41404, 41440);

                NoEncryption = f_1629_41419_41439(options);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 41454, 41482);

                UseUTF16 = f_1629_41465_41481(options);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 41496, 41540);

                IncludePortInSPN = f_1629_41515_41539(options);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 41556, 41606);

                OutputBufferingMode = f_1629_41578_41605(options);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 41620, 41678);

                MaxConnectionRetryCount = f_1629_41646_41677(options);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 39914, 41689);

                System.ArgumentNullException
                f_1629_40061_40097(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 40061, 40097);
                    return return_v;
                }


                System.Management.Automation.Remoting.ProxyAccessType
                f_1629_40134_40157(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.ProxyAccessType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 40134, 40157);
                    return return_v;
                }


                System.Management.Automation.PSCredential
                f_1629_40187_40210(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.ProxyCredential;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 40187, 40210);
                    return return_v;
                }


                string
                f_1629_40317_40368()
                {
                    var return_v = RemotingErrorIdStrings.ProxyCredentialWithoutAccess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 40317, 40368);
                    return return_v;
                }


                string
                f_1629_40270_40420(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 40270, 40420);
                    return return_v;
                }


                System.ArgumentException
                f_1629_40445_40475(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 40445, 40475);
                    return return_v;
                }


                int
                f_1629_40613_40654(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.MaximumConnectionRedirectionCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 40613, 40654);
                    return return_v;
                }


                int
                f_1629_40687_40728(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.MaximumConnectionRedirectionCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 40687, 40728);
                    return return_v;
                }


                int?
                f_1629_40801_40842(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.MaximumReceivedDataSizePerCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 40801, 40842);
                    return return_v;
                }


                int?
                f_1629_40890_40923(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.MaximumReceivedObjectSize;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 40890, 40923);
                    return return_v;
                }


                bool
                f_1629_40964_40985(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.NoCompression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 40964, 40985);
                    return return_v;
                }


                bool
                f_1629_40962_40986_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 40962, 40986);
                    return return_v;
                }


                bool
                f_1629_41025_41049(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.NoMachineProfile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 41025, 41049);
                    return return_v;
                }


                System.Management.Automation.Remoting.ProxyAccessType
                f_1629_41084_41107(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.ProxyAccessType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 41084, 41107);
                    return return_v;
                }


                System.Management.Automation.Runspaces.AuthenticationMechanism
                f_1629_41145_41172(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.ProxyAuthentication;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 41145, 41172);
                    return return_v;
                }


                System.Management.Automation.PSCredential
                f_1629_41206_41229(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.ProxyCredential;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 41206, 41229);
                    return return_v;
                }


                bool
                f_1629_41258_41277(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.SkipCACheck;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 41258, 41277);
                    return return_v;
                }


                bool
                f_1629_41306_41325(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.SkipCNCheck;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 41306, 41325);
                    return return_v;
                }


                bool
                f_1629_41362_41389(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.SkipRevocationCheck;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 41362, 41389);
                    return return_v;
                }


                bool
                f_1629_41419_41439(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.NoEncryption;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 41419, 41439);
                    return return_v;
                }


                bool
                f_1629_41465_41481(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.UseUTF16;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 41465, 41481);
                    return return_v;
                }


                bool
                f_1629_41515_41539(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.IncludePortInSPN;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 41515, 41539);
                    return return_v;
                }


                System.Management.Automation.Runspaces.OutputBufferingMode
                f_1629_41578_41605(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.OutputBufferingMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 41578, 41605);
                    return return_v;
                }


                int
                f_1629_41646_41677(System.Management.Automation.Remoting.PSSessionOption
                this_param)
                {
                    var return_v = this_param.MaxConnectionRetryCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 41646, 41677);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 39914, 41689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 39914, 41689);
            }
        }

        internal override RunspaceConnectionInfo InternalCopy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 41855, 41960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 41935, 41949);

                return f_1629_41942_41948(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 41855, 41960);

                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1629_41942_41948(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.Copy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 41942, 41948);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 41855, 41960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 41855, 41960);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public WSManConnectionInfo Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 42110, 44515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 42168, 42223);

                WSManConnectionInfo
                result = f_1629_42197_42222()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 42237, 42276);

                result._connectionUri = _connectionUri;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 42290, 42327);

                result._computerName = _computerName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 42341, 42366);

                result._scheme = _scheme;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 42380, 42413);

                result.PortSetting = f_1629_42401_42412();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 42427, 42454);

                result._appName = _appName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 42468, 42497);

                result._shellUri = _shellUri;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 42511, 42544);

                result._credential = _credential;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 42558, 42607);

                result.UseDefaultWSManPort = f_1629_42587_42606();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 42621, 42688);

                result.WSManAuthenticationMechanism = f_1629_42659_42687();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 42702, 42779);

                result.MaximumConnectionRedirectionCount = f_1629_42745_42778();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 42793, 42870);

                result.MaximumReceivedDataSizePerCommand = f_1629_42836_42869();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 42884, 42945);

                result.MaximumReceivedObjectSize = f_1629_42919_42944();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 42959, 42997);

                result.OpenTimeout = f_1629_42980_42996(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 43011, 43049);

                result.IdleTimeout = f_1629_43032_43048(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 43063, 43107);

                result.MaxIdleTimeout = f_1629_43087_43106(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 43121, 43163);

                result.CancelTimeout = f_1629_43144_43162(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 43177, 43225);

                result.OperationTimeout = DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.OperationTimeout, 1629, 43203, 43224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 43239, 43269);

                result.Culture = f_1629_43256_43268(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 43283, 43317);

                result.UICulture = f_1629_43302_43316(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 43331, 43364);

                result._thumbPrint = _thumbPrint;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 43378, 43459);

                result.AllowImplicitCredentialForNegotiate = f_1629_43423_43458();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 43473, 43512);

                result.UseCompression = f_1629_43497_43511();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 43526, 43569);

                result.NoMachineProfile = f_1629_43552_43568();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 43583, 43629);

                result.ProxyAccessType = f_1629_43608_43628(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 43643, 43698);

                result._proxyAuthentication = f_1629_43673_43697(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 43712, 43759);

                result._proxyCredential = f_1629_43738_43758(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 43773, 43811);

                result.SkipCACheck = f_1629_43794_43810(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 43825, 43863);

                result.SkipCNCheck = f_1629_43846_43862(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 43877, 43931);

                result.SkipRevocationCheck = f_1629_43906_43930(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 43945, 43985);

                result.NoEncryption = f_1629_43967_43984(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 43999, 44031);

                result.UseUTF16 = f_1629_44017_44030(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 44045, 44093);

                result.IncludePortInSPN = f_1629_44071_44092(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 44107, 44161);

                result.EnableNetworkAccess = f_1629_44136_44160(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 44175, 44229);

                result.UseDefaultWSManPort = f_1629_44204_44228(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 44243, 44292);

                result.OutputBufferingMode = f_1629_44272_44291();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 44306, 44350);

                result.DisconnectedOn = f_1629_44330_44349(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 44364, 44398);

                result.ExpiresOn = f_1629_44383_44397(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 44412, 44474);

                result.MaxConnectionRetryCount = f_1629_44445_44473(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 44490, 44504);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 42110, 44515);

                System.Management.Automation.Runspaces.WSManConnectionInfo
                f_1629_42197_42222()
                {
                    var return_v = new System.Management.Automation.Runspaces.WSManConnectionInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 42197, 42222);
                    return return_v;
                }


                int
                f_1629_42401_42412()
                {
                    var return_v = PortSetting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 42401, 42412);
                    return return_v;
                }


                bool
                f_1629_42587_42606()
                {
                    var return_v = UseDefaultWSManPort;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 42587, 42606);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManAuthenticationMechanism
                f_1629_42659_42687()
                {
                    var return_v = WSManAuthenticationMechanism;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 42659, 42687);
                    return return_v;
                }


                int
                f_1629_42745_42778()
                {
                    var return_v = MaximumConnectionRedirectionCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 42745, 42778);
                    return return_v;
                }


                int?
                f_1629_42836_42869()
                {
                    var return_v = MaximumReceivedDataSizePerCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 42836, 42869);
                    return return_v;
                }


                int?
                f_1629_42919_42944()
                {
                    var return_v = MaximumReceivedObjectSize;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 42919, 42944);
                    return return_v;
                }


                int
                f_1629_42980_42996(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.OpenTimeout;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 42980, 42996);
                    return return_v;
                }


                int
                f_1629_43032_43048(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.IdleTimeout;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 43032, 43048);
                    return return_v;
                }


                int
                f_1629_43087_43106(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.MaxIdleTimeout;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 43087, 43106);
                    return return_v;
                }


                int
                f_1629_43144_43162(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.CancelTimeout;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 43144, 43162);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1629_43256_43268(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.Culture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 43256, 43268);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1629_43302_43316(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.UICulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 43302, 43316);
                    return return_v;
                }


                bool
                f_1629_43423_43458()
                {
                    var return_v = AllowImplicitCredentialForNegotiate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 43423, 43458);
                    return return_v;
                }


                bool
                f_1629_43497_43511()
                {
                    var return_v = UseCompression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 43497, 43511);
                    return return_v;
                }


                bool
                f_1629_43552_43568()
                {
                    var return_v = NoMachineProfile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 43552, 43568);
                    return return_v;
                }


                System.Management.Automation.Remoting.ProxyAccessType
                f_1629_43608_43628(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ProxyAccessType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 43608, 43628);
                    return return_v;
                }


                System.Management.Automation.Runspaces.AuthenticationMechanism
                f_1629_43673_43697(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ProxyAuthentication;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 43673, 43697);
                    return return_v;
                }


                System.Management.Automation.PSCredential
                f_1629_43738_43758(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ProxyCredential;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 43738, 43758);
                    return return_v;
                }


                bool
                f_1629_43794_43810(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.SkipCACheck;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 43794, 43810);
                    return return_v;
                }


                bool
                f_1629_43846_43862(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.SkipCNCheck;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 43846, 43862);
                    return return_v;
                }


                bool
                f_1629_43906_43930(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.SkipRevocationCheck;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 43906, 43930);
                    return return_v;
                }


                bool
                f_1629_43967_43984(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.NoEncryption;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 43967, 43984);
                    return return_v;
                }


                bool
                f_1629_44017_44030(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.UseUTF16;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 44017, 44030);
                    return return_v;
                }


                bool
                f_1629_44071_44092(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.IncludePortInSPN;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 44071, 44092);
                    return return_v;
                }


                bool
                f_1629_44136_44160(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.EnableNetworkAccess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 44136, 44160);
                    return return_v;
                }


                bool
                f_1629_44204_44228(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.UseDefaultWSManPort;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 44204, 44228);
                    return return_v;
                }


                System.Management.Automation.Runspaces.OutputBufferingMode
                f_1629_44272_44291()
                {
                    var return_v = OutputBufferingMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 44272, 44291);
                    return return_v;
                }


                System.DateTime?
                f_1629_44330_44349(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.DisconnectedOn;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 44330, 44349);
                    return return_v;
                }


                System.DateTime?
                f_1629_44383_44397(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.ExpiresOn;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 44383, 44397);
                    return return_v;
                }


                int
                f_1629_44445_44473(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.MaxConnectionRetryCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 44445, 44473);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 42110, 44515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 42110, 44515);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public const string
        HttpScheme = "http"
        ;

        public const string
        HttpsScheme = "https"
        ;

        internal override BaseClientSessionTransportManager CreateClientSessionTransportManager(Guid instanceId, string sessionName, PSRemotingCryptoHelper cryptoHelper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 44860, 45217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 45046, 45206);

                return f_1629_45053_45205(instanceId, this, cryptoHelper, sessionName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 44860, 45217);

                System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager
                f_1629_45053_45205(System.Guid
                runspacePoolInstanceId, System.Management.Automation.Runspaces.WSManConnectionInfo
                connectionInfo, System.Management.Automation.Internal.PSRemotingCryptoHelper
                cryptoHelper, string
                sessionName)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.WSManClientSessionTransportManager(runspacePoolInstanceId, connectionInfo, cryptoHelper, sessionName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 45053, 45205);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 44860, 45217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 44860, 45217);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string ResolveShellUri(string shell)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 45286, 45926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 45355, 45387);

                string
                resolvedShellUri = shell
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 45401, 45527) || true) && (f_1629_45405_45443(resolvedShellUri))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 45401, 45527);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 45477, 45512);

                    resolvedShellUri = DefaultShellUri;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 45401, 45527);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 45543, 45875) || true) && (f_1629_45547_45704(resolvedShellUri, System.Management.Automation.Remoting.Client.WSManNativeApi.ResourceURIPrefix, StringComparison.OrdinalIgnoreCase) == -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 45543, 45875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 45744, 45860);

                    resolvedShellUri = System.Management.Automation.Remoting.Client.WSManNativeApi.ResourceURIPrefix + resolvedShellUri;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 45543, 45875);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 45891, 45915);

                return resolvedShellUri;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 45286, 45926);

                bool
                f_1629_45405_45443(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 45405, 45443);
                    return return_v;
                }


                int
                f_1629_45547_45704(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 45547, 45704);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 45286, 45926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 45286, 45926);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static T ExtractPropertyAsWsManConnectionInfo<T>(RunspaceConnectionInfo rsCI,
                    string property, T defaultValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1629, 46317, 46747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 46474, 46529);

                WSManConnectionInfo
                wsCI = rsCI as WSManConnectionInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 46543, 46628) || true) && (wsCI == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 46543, 46628);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 46593, 46613);

                    return defaultValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 46543, 46628);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 46644, 46736);

                return (T)f_1629_46654_46735(f_1629_46654_46714(typeof(WSManConnectionInfo), property, typeof(T)), wsCI, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1629, 46317, 46747);

                System.Reflection.PropertyInfo?
                f_1629_46654_46714(System.Type
                this_param, string
                name, System.Type
                returnType)
                {
                    var return_v = this_param.GetProperty(name, returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 46654, 46714);
                    return return_v;
                }


                object?
                f_1629_46654_46735(System.Reflection.PropertyInfo
                this_param, System.Management.Automation.Runspaces.WSManConnectionInfo
                obj, object?[]?
                index)
                {
                    var return_v = this_param.GetValue((object)obj, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 46654, 46735);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 46317, 46747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 46317, 46747);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void SetConnectionUri(Uri newUri)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 46759, 46928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 46826, 46879);

                f_1629_46826_46878(newUri != null, "newUri cannot be null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 46893, 46917);

                _connectionUri = newUri;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 46759, 46928);

                int
                f_1629_46826_46878(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 46826, 46878);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 46759, 46928);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 46759, 46928);
            }
        }

        internal void ConstructUri(string scheme, string computerName, int? port, string appName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 47486, 50561);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 47639, 47656);

                _scheme = scheme;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 47670, 47776) || true) && (f_1629_47674_47703(_scheme))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 47670, 47776);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 47737, 47761);

                    _scheme = DefaultScheme;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 47670, 47776);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 47855, 48403) || true) && (!(f_1629_47861_47923(_scheme, HttpScheme, StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1629, 47861, 48007) || f_1629_47944_48007(_scheme, HttpsScheme, StringComparison.OrdinalIgnoreCase)) || (DynAbs.Tracing.TraceSender.Expression_False(1629, 47861, 48093) || f_1629_48028_48093(_scheme, DefaultScheme, StringComparison.OrdinalIgnoreCase))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 47855, 48403);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 48128, 48291);

                    string
                    message =
                    f_1629_48166_48290(f_1629_48239_48280(), _scheme)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 48309, 48362);

                    ArgumentException
                    e = f_1629_48331_48361(message)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 48380, 48388);

                    throw e;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 47855, 48403);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 48461, 49311) || true) && (f_1629_48465_48499(computerName) || (DynAbs.Tracing.TraceSender.Expression_False(1629, 48465, 48571) || f_1629_48503_48571(computerName, ".", StringComparison.OrdinalIgnoreCase)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 48461, 49311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 48605, 48641);

                    _computerName = DefaultComputerName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 48461, 49311);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 48461, 49311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 48707, 48743);

                    _computerName = f_1629_48723_48742(computerName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 48851, 48878);

                    IPAddress
                    ipAddress = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 48898, 48966);

                    bool
                    isIPAddress = f_1629_48917_48965(_computerName, out ipAddress)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 48984, 49296) || true) && (isIPAddress && (DynAbs.Tracing.TraceSender.Expression_True(1629, 48988, 49058) && f_1629_49003_49026(ipAddress) == AddressFamily.InterNetworkV6))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 48984, 49296);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 49100, 49277) || true) && ((f_1629_49105_49125(_computerName) == 0) || (DynAbs.Tracing.TraceSender.Expression_False(1629, 49104, 49160) || (f_1629_49136_49152(_computerName, 0) != '[')))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 49100, 49277);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 49210, 49254);

                            _computerName = @"[" + _computerName + @"]";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 49100, 49277);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 48984, 49296);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 48461, 49311);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 49327, 49518);

                f_1629_49327_49517(PSEventId.ComputerName, PSOpcode.Method, PSTask.CreateRunspace, PSKeyword.Runspace | PSKeyword.UseAlwaysAnalytic, _computerName);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 49534, 50136) || true) && (f_1629_49538_49551(port))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 49534, 50136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 49585, 49617);

                    f_1629_49585_49616(this, f_1629_49605_49615(port));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 49692, 50121) || true) && (f_1629_49696_49706(port) == DefaultPort)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 49692, 50121);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 49879, 49896);

                        PortSetting = -1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 49918, 49945);

                        UseDefaultWSManPort = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 49692, 50121);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 49692, 50121);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 50027, 50052);

                        PortSetting = f_1629_50041_50051(port);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 50074, 50102);

                        UseDefaultWSManPort = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 49692, 50121);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 49534, 50136);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 50193, 50212);

                _appName = appName;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 50226, 50337) || true) && (f_1629_50230_50260(_appName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 50226, 50337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 50294, 50322);

                    _appName = s_defaultAppName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 50226, 50337);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 50383, 50502);

                UriBuilder
                uriBuilder = f_1629_50407_50501(_scheme, _computerName, f_1629_50479_50490(), _appName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 50518, 50550);

                _connectionUri = f_1629_50535_50549(uriBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 47486, 50561);

                bool
                f_1629_47674_47703(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 47674, 47703);
                    return return_v;
                }


                bool
                f_1629_47861_47923(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 47861, 47923);
                    return return_v;
                }


                bool
                f_1629_47944_48007(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 47944, 48007);
                    return return_v;
                }


                bool
                f_1629_48028_48093(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 48028, 48093);
                    return return_v;
                }


                string
                f_1629_48239_48280()
                {
                    var return_v = RemotingErrorIdStrings.InvalidSchemeValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 48239, 48280);
                    return return_v;
                }


                string
                f_1629_48166_48290(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 48166, 48290);
                    return return_v;
                }


                System.ArgumentException
                f_1629_48331_48361(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 48331, 48361);
                    return return_v;
                }


                bool
                f_1629_48465_48499(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 48465, 48499);
                    return return_v;
                }


                bool
                f_1629_48503_48571(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 48503, 48571);
                    return return_v;
                }


                string
                f_1629_48723_48742(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 48723, 48742);
                    return return_v;
                }


                bool
                f_1629_48917_48965(string
                ipString, out System.Net.IPAddress
                address)
                {
                    var return_v = IPAddress.TryParse(ipString, out address);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 48917, 48965);
                    return return_v;
                }


                System.Net.Sockets.AddressFamily
                f_1629_49003_49026(System.Net.IPAddress
                this_param)
                {
                    var return_v = this_param.AddressFamily;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 49003, 49026);
                    return return_v;
                }


                int
                f_1629_49105_49125(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 49105, 49125);
                    return return_v;
                }


                char
                f_1629_49136_49152(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 49136, 49152);
                    return return_v;
                }


                int
                f_1629_49327_49517(System.Management.Automation.Internal.PSEventId
                id, System.Management.Automation.Internal.PSOpcode
                opcode, System.Management.Automation.Internal.PSTask
                task, System.Management.Automation.Internal.PSKeyword
                keyword, params object[]
                args)
                {
                    PSEtwLog.LogAnalyticVerbose(id, opcode, task, keyword, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 49327, 49517);
                    return 0;
                }


                bool
                f_1629_49538_49551(int?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 49538, 49551);
                    return return_v;
                }


                int
                f_1629_49605_49615(int?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 49605, 49615);
                    return return_v;
                }


                int
                f_1629_49585_49616(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param, int
                port)
                {
                    this_param.ValidatePortInRange(port);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 49585, 49616);
                    return 0;
                }


                int
                f_1629_49696_49706(int?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 49696, 49706);
                    return return_v;
                }


                int
                f_1629_50041_50051(int?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 50041, 50051);
                    return return_v;
                }


                bool
                f_1629_50230_50260(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 50230, 50260);
                    return return_v;
                }


                int
                f_1629_50479_50490()
                {
                    var return_v = PortSetting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 50479, 50490);
                    return return_v;
                }


                System.UriBuilder
                f_1629_50407_50501(string
                scheme, string
                host, int
                port, string
                pathValue)
                {
                    var return_v = new System.UriBuilder(scheme, host, port, pathValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 50407, 50501);
                    return return_v;
                }


                System.Uri
                f_1629_50535_50549(System.UriBuilder
                this_param)
                {
                    var return_v = this_param.Uri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 50535, 50549);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 47486, 50561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 47486, 50561);
            }
        }

        internal static string GetConnectionString(Uri connectionUri,
                    out bool isSSLSpecified)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1629, 51046, 51629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 51170, 51265);

                isSSLSpecified =
                f_1629_51204_51264(f_1629_51204_51224(connectionUri), WSManConnectionInfo.HttpsScheme);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 51279, 51336);

                string
                result = f_1629_51295_51335(f_1629_51295_51323(connectionUri))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 51350, 51618) || true) && (isSSLSpecified)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 51350, 51618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 51402, 51470);

                    return f_1629_51409_51469(result, f_1629_51426_51464(WSManConnectionInfo.HttpsScheme) + 3);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 51350, 51618);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 51350, 51618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 51536, 51603);

                    return f_1629_51543_51602(result, f_1629_51560_51597(WSManConnectionInfo.HttpScheme) + 3);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 51350, 51618);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1629, 51046, 51629);

                string
                f_1629_51204_51224(System.Uri
                this_param)
                {
                    var return_v = this_param.Scheme;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 51204, 51224);
                    return return_v;
                }


                bool
                f_1629_51204_51264(string
                this_param, string
                value)
                {
                    var return_v = this_param.Equals(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 51204, 51264);
                    return return_v;
                }


                string
                f_1629_51295_51323(System.Uri
                this_param)
                {
                    var return_v = this_param.OriginalString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 51295, 51323);
                    return return_v;
                }


                string
                f_1629_51295_51335(string
                this_param)
                {
                    var return_v = this_param.TrimStart();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 51295, 51335);
                    return return_v;
                }


                int
                f_1629_51426_51464(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 51426, 51464);
                    return return_v;
                }


                string
                f_1629_51409_51469(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 51409, 51469);
                    return return_v;
                }


                int
                f_1629_51560_51597(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 51560, 51597);
                    return return_v;
                }


                string
                f_1629_51543_51602(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 51543, 51602);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 51046, 51629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 51046, 51629);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ValidateSpecifiedAuthentication()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 52101, 52571);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 52172, 52560) || true) && ((f_1629_52177_52205() != WSManAuthenticationMechanism.WSMAN_FLAG_DEFAULT_AUTHENTICATION)
                && (DynAbs.Tracing.TraceSender.Expression_True(1629, 52176, 52314) && (_thumbPrint != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 52172, 52560);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 52348, 52545);

                    throw f_1629_52354_52544(f_1629_52397_52454(), "CertificateThumbPrint", f_1629_52504_52543(f_1629_52504_52532(this)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 52172, 52560);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 52101, 52571);

                System.Management.Automation.Remoting.Client.WSManNativeApi.WSManAuthenticationMechanism
                f_1629_52177_52205()
                {
                    var return_v = WSManAuthenticationMechanism;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 52177, 52205);
                    return return_v;
                }


                string
                f_1629_52397_52454()
                {
                    var return_v = RemotingErrorIdStrings.NewRunspaceAmbiguousAuthentication;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 52397, 52454);
                    return return_v;
                }


                System.Management.Automation.Runspaces.AuthenticationMechanism
                f_1629_52504_52532(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.AuthenticationMechanism;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 52504, 52532);
                    return return_v;
                }


                string
                f_1629_52504_52543(System.Management.Automation.Runspaces.AuthenticationMechanism
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 52504, 52543);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1629_52354_52544(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 52354, 52544);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 52101, 52571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 52101, 52571);
            }
        }

        private void UpdateUri(Uri uri)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 52583, 54081);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 52639, 52907) || true) && (f_1629_52643_52661_M(!uri.IsAbsoluteUri))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 52639, 52907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 52695, 52892);

                    throw f_1629_52701_52891(f_1629_52727_52890(f_1629_52828_52889()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 52639, 52907);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 52923, 53114) || true) && (f_1629_52927_52962(f_1629_52927_52945(uri), ':') >
                f_1629_52982_53037(f_1629_52982_52997(uri), "//", StringComparison.Ordinal))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 52923, 53114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 53071, 53099);

                    UseDefaultWSManPort = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 52923, 53114);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 53342, 53357);

                string
                appname
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 53373, 54070) || true) && (f_1629_53377_53431(f_1629_53377_53393(uri), "/", StringComparison.Ordinal) && (DynAbs.Tracing.TraceSender.Expression_True(1629, 53377, 53483) && f_1629_53452_53483(f_1629_53473_53482(uri))) && (DynAbs.Tracing.TraceSender.Expression_True(1629, 53377, 53521) && f_1629_53487_53521(f_1629_53508_53520(uri))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 53373, 54070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 53555, 53582);

                    appname = s_defaultAppName;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 53600, 53753);

                    f_1629_53600_53752(this, f_1629_53613_53623(uri), f_1629_53658_53666(uri), f_1629_53701_53709(uri), appname);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 53373, 54070);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 53373, 54070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 53819, 53840);

                    _connectionUri = uri;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 53858, 53879);

                    _scheme = f_1629_53868_53878(uri);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 53897, 53925);

                    _appName = f_1629_53908_53924(uri);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 53943, 53966);

                    PortSetting = f_1629_53957_53965(uri);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 53984, 54009);

                    _computerName = f_1629_54000_54008(uri);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 54027, 54055);

                    UseDefaultWSManPort = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 53373, 54070);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 52583, 54081);

                bool
                f_1629_52643_52661_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 52643, 52661);
                    return return_v;
                }


                string
                f_1629_52828_52889()
                {
                    var return_v = RemotingErrorIdStrings.RelativeUriForRunspacePathNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 52828, 52889);
                    return return_v;
                }


                string
                f_1629_52727_52890(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 52727, 52890);
                    return return_v;
                }


                System.NotSupportedException
                f_1629_52701_52891(string
                message)
                {
                    var return_v = new System.NotSupportedException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 52701, 52891);
                    return return_v;
                }


                string
                f_1629_52927_52945(System.Uri
                this_param)
                {
                    var return_v = this_param.OriginalString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 52927, 52945);
                    return return_v;
                }


                int
                f_1629_52927_52962(string
                this_param, char
                value)
                {
                    var return_v = this_param.LastIndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 52927, 52962);
                    return return_v;
                }


                string
                f_1629_52982_52997(System.Uri
                this_param)
                {
                    var return_v = this_param.AbsoluteUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 52982, 52997);
                    return return_v;
                }


                int
                f_1629_52982_53037(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 52982, 53037);
                    return return_v;
                }


                string
                f_1629_53377_53393(System.Uri
                this_param)
                {
                    var return_v = this_param.AbsolutePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 53377, 53393);
                    return return_v;
                }


                bool
                f_1629_53377_53431(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 53377, 53431);
                    return return_v;
                }


                string
                f_1629_53473_53482(System.Uri
                this_param)
                {
                    var return_v = this_param.Query;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 53473, 53482);
                    return return_v;
                }


                bool
                f_1629_53452_53483(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 53452, 53483);
                    return return_v;
                }


                string
                f_1629_53508_53520(System.Uri
                this_param)
                {
                    var return_v = this_param.Fragment;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 53508, 53520);
                    return return_v;
                }


                bool
                f_1629_53487_53521(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 53487, 53521);
                    return return_v;
                }


                string
                f_1629_53613_53623(System.Uri
                this_param)
                {
                    var return_v = this_param.Scheme;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 53613, 53623);
                    return return_v;
                }


                string
                f_1629_53658_53666(System.Uri
                this_param)
                {
                    var return_v = this_param.Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 53658, 53666);
                    return return_v;
                }


                int
                f_1629_53701_53709(System.Uri
                this_param)
                {
                    var return_v = this_param.Port;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 53701, 53709);
                    return return_v;
                }


                int
                f_1629_53600_53752(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param, string
                scheme, string
                computerName, int
                port, string
                appName)
                {
                    this_param.ConstructUri(scheme, computerName, (int?)port, appName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 53600, 53752);
                    return 0;
                }


                string
                f_1629_53868_53878(System.Uri
                this_param)
                {
                    var return_v = this_param.Scheme;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 53868, 53878);
                    return return_v;
                }


                string
                f_1629_53908_53924(System.Uri
                this_param)
                {
                    var return_v = this_param.AbsolutePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 53908, 53924);
                    return return_v;
                }


                int
                f_1629_53957_53965(System.Uri
                this_param)
                {
                    var return_v = this_param.Port;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 53957, 53965);
                    return return_v;
                }


                string
                f_1629_54000_54008(System.Uri
                this_param)
                {
                    var return_v = this_param.Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 54000, 54008);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 52583, 54081);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 52583, 54081);
            }
        }

        private string _scheme;

        private string _computerName;

        private string _appName;

        private Uri _connectionUri;

        private PSCredential _credential;

        private string _shellUri;

        private string _thumbPrint;

        private AuthenticationMechanism _proxyAuthentication;

        private PSCredential _proxyCredential;

        internal const OutputBufferingMode
        DefaultOutputBufferingMode = OutputBufferingMode.None
        ;

        internal const int
        DefaultMaxConnectionRetryCount = 5
        ;

        private const string
        DefaultScheme = HttpScheme
        ;

        private const string
        DefaultSslScheme = HttpsScheme
        ;

        private static readonly string s_defaultAppName;

        internal bool UseDefaultWSManPort { get; set; }

        private const int
        DefaultPortHttp = 80
        ;

        private const int
        DefaultPortHttps = 443
        ;

        private const int
        DefaultPort = 0
        ;

        private const string
        DefaultComputerName = "localhost"
        ;

        private const string
        LocalHostUriString = "http://localhost/wsman"
        ;

        private const string
        DefaultShellUri =
                     System.Management.Automation.Remoting.Client.WSManNativeApi.ResourceURIPrefix + RemotingConstants.DefaultShellName
        ;

        private const PSCredential
        DefaultCredential = null
        ;

        internal bool IsLocalhostAndNetworkAccess
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 58585, 59164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 58621, 59077);

                    return (f_1629_58629_58648() && (DynAbs.Tracing.TraceSender.Expression_True(1629, 58629, 59075) && (f_1629_58770_58780() == null && (DynAbs.Tracing.TraceSender.Expression_True(1629, 58770, 59074) && (f_1629_58906_58982(f_1629_58906_58918(), DefaultComputerName, StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1629, 58906, 59073) || f_1629_59042_59067(f_1629_59042_59054(), '.') == -1))))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 58585, 59164);

                    bool
                    f_1629_58629_58648()
                    {
                        var return_v = EnableNetworkAccess;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 58629, 58648);
                        return return_v;
                    }


                    System.Management.Automation.PSCredential
                    f_1629_58770_58780()
                    {
                        var return_v = Credential;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 58770, 58780);
                        return return_v;
                    }


                    string
                    f_1629_58906_58918()
                    {
                        var return_v = ComputerName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 58906, 58918);
                        return return_v;
                    }


                    bool
                    f_1629_58906_58982(string
                    this_param, string
                    value, System.StringComparison
                    comparisonType)
                    {
                        var return_v = this_param.Equals(value, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 58906, 58982);
                        return return_v;
                    }


                    string
                    f_1629_59042_59054()
                    {
                        var return_v = ComputerName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 59042, 59054);
                        return return_v;
                    }


                    int
                    f_1629_59042_59067(string
                    this_param, char
                    value)
                    {
                        var return_v = this_param.IndexOf(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 59042, 59067);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 58519, 59175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 58519, 59175);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal DateTime? DisconnectedOn
        {
            get;
            set;
        }

        internal DateTime? ExpiresOn
        {
            get;
            set;
        }

        internal void NullDisconnectedExpiresOn()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 59903, 60043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 59969, 59996);

                this.DisconnectedOn = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 60010, 60032);

                this.ExpiresOn = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 59903, 60043);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 59903, 60043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 59903, 60043);
            }
        }

        internal void SetDisconnectedExpiresOnToNow()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 60247, 60539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 60317, 60390);

                TimeSpan
                idleTimeoutTime = TimeSpan.FromSeconds(f_1629_60365_60381(this) / 1000)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 60404, 60432);

                DateTime
                now = DateTime.Now
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 60446, 60472);

                this.DisconnectedOn = now;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 60486, 60528);

                this.ExpiresOn = now.Add(idleTimeoutTime);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 60247, 60539);

                int
                f_1629_60365_60381(System.Management.Automation.Runspaces.WSManConnectionInfo
                this_param)
                {
                    var return_v = this_param.IdleTimeout;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 60365, 60381);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 60247, 60539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 60247, 60539);
            }
        }

        static WSManConnectionInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1629, 14444, 60585);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 22416, 22460);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 44631, 44650);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 44768, 44789);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 55162, 55215);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 55347, 55381);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 55843, 55869);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 55901, 55931);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 56187, 56214);
            s_defaultAppName = "/wsman";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 56965, 56985);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 57107, 57129);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 57356, 57371);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 57491, 57524);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 57661, 57706);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 57825, 57971);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 58150, 58174);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1629, 14444, 60585);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 14444, 60585);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1629, 14444, 60585);

        static string
        f_1629_33486_33492_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1629, 33020, 33586);
            return return_v;
        }


        static string
        f_1629_34246_34287_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1629, 33977, 34361);
            return return_v;
        }


        static string
        f_1629_35010_35051_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1629, 34737, 35138);
            return return_v;
        }


        bool
        f_1629_36971_36989_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 36971, 36989);
            return return_v;
        }


        string
        f_1629_37156_37217()
        {
            var return_v = RemotingErrorIdStrings.RelativeUriForRunspacePathNotSupported;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 37156, 37217);
            return return_v;
        }


        string
        f_1629_37055_37218(string
        resourceString, params object[]
        args)
        {
            var return_v = PSRemotingErrorInvariants.FormatResourceString(resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 37055, 37218);
            return return_v;
        }


        System.NotSupportedException
        f_1629_37029_37219(string
        message)
        {
            var return_v = new System.NotSupportedException(message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 37029, 37219);
            return return_v;
        }


        string
        f_1629_37467_37483(System.Uri
        this_param)
        {
            var return_v = this_param.AbsolutePath;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 37467, 37483);
            return return_v;
        }


        bool
        f_1629_37467_37531(string
        this_param, string
        value, System.StringComparison
        comparisonType)
        {
            var return_v = this_param.Equals(value, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 37467, 37531);
            return return_v;
        }


        string
        f_1629_37573_37582(System.Uri
        this_param)
        {
            var return_v = this_param.Query;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 37573, 37582);
            return return_v;
        }


        bool
        f_1629_37552_37583(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 37552, 37583);
            return return_v;
        }


        string
        f_1629_37608_37620(System.Uri
        this_param)
        {
            var return_v = this_param.Fragment;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 37608, 37620);
            return return_v;
        }


        bool
        f_1629_37587_37621(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 37587, 37621);
            return return_v;
        }


        string
        f_1629_37668_37678(System.Uri
        this_param)
        {
            var return_v = this_param.Scheme;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 37668, 37678);
            return return_v;
        }


        string
        f_1629_37710_37718(System.Uri
        this_param)
        {
            var return_v = this_param.Host;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 37710, 37718);
            return return_v;
        }


        int
        f_1629_37750_37758(System.Uri
        this_param)
        {
            var return_v = this_param.Port;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 37750, 37758);
            return return_v;
        }


        int
        f_1629_37655_37807(System.Management.Automation.Runspaces.WSManConnectionInfo
        this_param, string
        scheme, string
        computerName, int
        port, string
        appName)
        {
            this_param.ConstructUri(scheme, computerName, (int?)port, appName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 37655, 37807);
            return 0;
        }


        static System.Uri
        f_1629_38734_38737_C(System.Uri
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1629, 38524, 38840);
            return return_v;
        }


        static System.Uri
        f_1629_39343_39346_C(System.Uri
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1629, 39287, 39405);
            return return_v;
        }


        System.Uri
        f_1629_54355_54382(string
        uriString)
        {
            var return_v = new System.Uri(uriString);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 54355, 54382);
            return return_v;
        }

    }
    internal sealed class NewProcessConnectionInfo : RunspaceConnectionInfo
    {
        private PSCredential _credential;

        private AuthenticationMechanism _authMechanism;

        public ScriptBlock InitializationScript { get; set; }

        public bool RunAs32 { get; set; }

        public string WorkingDirectory { get; set; }

        public Version PSVersion { get; set; }

        internal PowerShellProcessInstance Process { get; set; }

        public override string ComputerName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 62175, 62202);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 62181, 62200);

                    return "localhost";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 62175, 62202);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 62115, 62273);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 62115, 62273);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 62218, 62262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 62224, 62260);

                    throw f_1629_62230_62259();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 62218, 62262);

                    System.NotImplementedException
                    f_1629_62230_62259()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 62230, 62259);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 62115, 62273);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 62115, 62273);
                }
            }
        }

        public override PSCredential Credential
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 62445, 62472);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 62451, 62470);

                    return _credential;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 62445, 62472);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 62381, 62637);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 62381, 62637);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 62488, 62626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 62524, 62544);

                    _credential = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 62562, 62611);

                    _authMechanism = AuthenticationMechanism.Default;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 62488, 62626);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 62381, 62637);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 62381, 62637);
                }
            }
        }

        public override AuthenticationMechanism AuthenticationMechanism
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 62901, 62974);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 62937, 62959);

                    return _authMechanism;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 62901, 62974);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 62813, 63387);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 62813, 63387);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 62990, 63376);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 63026, 63318) || true) && (value != AuthenticationMechanism.Default)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 63026, 63318);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 63112, 63299);

                        throw f_1629_63118_63298(f_1629_63161_63210(), f_1629_63237_63253(value), f_1629_63255_63297(AuthenticationMechanism.Default));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 63026, 63318);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 63338, 63361);

                    _authMechanism = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 62990, 63376);

                    string
                    f_1629_63161_63210()
                    {
                        var return_v = RemotingErrorIdStrings.IPCSupportsOnlyDefaultAuth;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 63161, 63210);
                        return return_v;
                    }


                    string
                    f_1629_63237_63253(System.Management.Automation.Runspaces.AuthenticationMechanism
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 63237, 63253);
                        return return_v;
                    }


                    string
                    f_1629_63255_63297(System.Management.Automation.Runspaces.AuthenticationMechanism
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 63255, 63297);
                        return return_v;
                    }


                    System.Management.Automation.PSInvalidOperationException
                    f_1629_63118_63298(string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 63118, 63298);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 62813, 63387);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 62813, 63387);
                }
            }
        }

        public override string CertificateThumbprint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 63785, 63813);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 63791, 63811);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 63785, 63813);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 63716, 63884);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 63716, 63884);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 63829, 63873);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 63835, 63871);

                    throw f_1629_63841_63870();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 63829, 63873);

                    System.NotImplementedException
                    f_1629_63841_63870()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 63841, 63870);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 63716, 63884);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 63716, 63884);
                }
            }
        }

        public NewProcessConnectionInfo Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 63896, 64413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 63959, 64035);

                NewProcessConnectionInfo
                result = f_1629_63993_64034(_credential)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 64049, 64111);

                result.AuthenticationMechanism = f_1629_64082_64110(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 64125, 64181);

                result.InitializationScript = f_1629_64155_64180(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 64195, 64243);

                result.WorkingDirectory = f_1629_64221_64242(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 64257, 64287);

                result.RunAs32 = f_1629_64274_64286(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 64301, 64335);

                result.PSVersion = f_1629_64320_64334(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 64349, 64374);

                result.Process = f_1629_64366_64373();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 64388, 64402);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 63896, 64413);

                System.Management.Automation.Runspaces.NewProcessConnectionInfo
                f_1629_63993_64034(System.Management.Automation.PSCredential
                credential)
                {
                    var return_v = new System.Management.Automation.Runspaces.NewProcessConnectionInfo(credential);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 63993, 64034);
                    return return_v;
                }


                System.Management.Automation.Runspaces.AuthenticationMechanism
                f_1629_64082_64110(System.Management.Automation.Runspaces.NewProcessConnectionInfo
                this_param)
                {
                    var return_v = this_param.AuthenticationMechanism;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 64082, 64110);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1629_64155_64180(System.Management.Automation.Runspaces.NewProcessConnectionInfo
                this_param)
                {
                    var return_v = this_param.InitializationScript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 64155, 64180);
                    return return_v;
                }


                string
                f_1629_64221_64242(System.Management.Automation.Runspaces.NewProcessConnectionInfo
                this_param)
                {
                    var return_v = this_param.WorkingDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 64221, 64242);
                    return return_v;
                }


                bool
                f_1629_64274_64286(System.Management.Automation.Runspaces.NewProcessConnectionInfo
                this_param)
                {
                    var return_v = this_param.RunAs32;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 64274, 64286);
                    return return_v;
                }


                System.Version
                f_1629_64320_64334(System.Management.Automation.Runspaces.NewProcessConnectionInfo
                this_param)
                {
                    var return_v = this_param.PSVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 64320, 64334);
                    return return_v;
                }


                System.Management.Automation.Runspaces.PowerShellProcessInstance
                f_1629_64366_64373()
                {
                    var return_v = Process;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 64366, 64373);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 63896, 64413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 63896, 64413);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override RunspaceConnectionInfo InternalCopy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 64425, 64530);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 64505, 64519);

                return f_1629_64512_64518(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 64425, 64530);

                System.Management.Automation.Runspaces.NewProcessConnectionInfo
                f_1629_64512_64518(System.Management.Automation.Runspaces.NewProcessConnectionInfo
                this_param)
                {
                    var return_v = this_param.Copy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 64512, 64518);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 64425, 64530);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 64425, 64530);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override BaseClientSessionTransportManager CreateClientSessionTransportManager(Guid instanceId, string sessionName, PSRemotingCryptoHelper cryptoHelper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 64542, 64876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 64728, 64865);

                return f_1629_64735_64864(instanceId, this, cryptoHelper);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 64542, 64876);

                System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManager
                f_1629_64735_64864(System.Guid
                runspaceId, System.Management.Automation.Runspaces.NewProcessConnectionInfo
                connectionInfo, System.Management.Automation.Internal.PSRemotingCryptoHelper
                cryptoHelper)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.OutOfProcessClientSessionTransportManager(runspaceId, connectionInfo, cryptoHelper);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 64735, 64864);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 64542, 64876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 64542, 64876);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NewProcessConnectionInfo(PSCredential credential)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1629, 65121, 65303);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 60981, 60992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 61035, 61049);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 61227, 61280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 61467, 61500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 61653, 61697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 61811, 61849);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 61861, 61917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 65204, 65229);

                _credential = credential;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 65243, 65292);

                _authMechanism = AuthenticationMechanism.Default;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1629, 65121, 65303);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 65121, 65303);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 65121, 65303);
            }
        }

        static NewProcessConnectionInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1629, 60840, 65332);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1629, 60840, 65332);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 60840, 65332);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1629, 60840, 65332);
    }
    public sealed class NamedPipeConnectionInfo : RunspaceConnectionInfo
    {
        private PSCredential _credential;

        private AuthenticationMechanism _authMechanism;

        private string _appDomainName;

        private const int
        _defaultOpenTimeout = 60000
        ;

        public int ProcessId
        {
            get;
            set;
        }

        public string AppDomainName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 66459, 66489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 66465, 66487);

                    return _appDomainName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 66459, 66489);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 66407, 66606);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 66407, 66606);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 66505, 66595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 66541, 66580);

                    _appDomainName = value ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1629, 66558, 66579) ?? string.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 66505, 66595);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 66407, 66606);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 66407, 66606);
                }
            }
        }

        public string CustomPipeName
        {
            get;
            set;
        }

        public NamedPipeConnectionInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1629, 67087, 67189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 65784, 65795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 65838, 65852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 65878, 65907);
                this._appDomainName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 66147, 66225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 66796, 66882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 67144, 67178);

                OpenTimeout = _defaultOpenTimeout;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1629, 67087, 67189);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 67087, 67189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 67087, 67189);
            }
        }

        public NamedPipeConnectionInfo(
                    int processId) : this(f_1629_67491_67500_C(processId), string.Empty, _defaultOpenTimeout)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1629, 67411, 67549);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1629, 67411, 67549);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 67411, 67549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 67411, 67549);
            }
        }

        public NamedPipeConnectionInfo(
                    int processId,
                    string appDomainName) : this(f_1629_68005_68014_C(processId), appDomainName, _defaultOpenTimeout)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1629, 67890, 68064);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1629, 67890, 68064);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 67890, 68064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 67890, 68064);
            }
        }

        public NamedPipeConnectionInfo(
                    int processId,
                    string appDomainName,
                    int openTimeout)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1629, 68510, 68776);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 65784, 65795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 65838, 65852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 65878, 65907);
                this._appDomainName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 66147, 66225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 66796, 66882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 68659, 68681);

                ProcessId = processId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 68695, 68725);

                AppDomainName = appDomainName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 68739, 68765);

                OpenTimeout = openTimeout;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1629, 68510, 68776);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 68510, 68776);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 68510, 68776);
            }
        }

        public NamedPipeConnectionInfo(
                    string customPipeName) : this(f_1629_69090_69104_C(customPipeName), _defaultOpenTimeout)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1629, 69002, 69139);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1629, 69002, 69139);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 69002, 69139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 69002, 69139);
            }
        }

        public NamedPipeConnectionInfo(
                    string customPipeName,
                    int openTimeout)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1629, 69443, 69797);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 65784, 65795);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 65838, 65852);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 65878, 65907);
                this._appDomainName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 66147, 66225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 66796, 66882);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 69565, 69698) || true) && (customPipeName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 69565, 69698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 69625, 69683);

                    throw f_1629_69631_69682(nameof(customPipeName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 69565, 69698);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 69714, 69746);

                CustomPipeName = customPipeName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 69760, 69786);

                OpenTimeout = openTimeout;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1629, 69443, 69797);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 69443, 69797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 69443, 69797);
            }
        }

        public override string ComputerName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 70010, 70037);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 70016, 70035);

                    return "localhost";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 70010, 70037);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 69950, 70108);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 69950, 70108);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 70053, 70097);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 70059, 70095);

                    throw f_1629_70065_70094();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 70053, 70097);

                    System.NotImplementedException
                    f_1629_70065_70094()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 70065, 70094);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 69950, 70108);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 69950, 70108);
                }
            }
        }

        public override PSCredential Credential
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 70256, 70283);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 70262, 70281);

                    return _credential;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 70256, 70283);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 70192, 70458);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 70192, 70458);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 70299, 70447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 70335, 70355);

                    _credential = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 70373, 70432);

                    _authMechanism = Runspaces.AuthenticationMechanism.Default;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 70299, 70447);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 70192, 70458);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 70192, 70458);
                }
            }
        }

        public override AuthenticationMechanism AuthenticationMechanism
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 70634, 70707);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 70670, 70692);

                    return _authMechanism;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 70634, 70707);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 70546, 71130);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 70546, 71130);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 70723, 71119);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 70759, 71061) || true) && (value != Runspaces.AuthenticationMechanism.Default)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 70759, 71061);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 70855, 71042);

                        throw f_1629_70861_71041(f_1629_70904_70953(), f_1629_70980_70996(value), f_1629_70998_71040(AuthenticationMechanism.Default));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 70759, 71061);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 71081, 71104);

                    _authMechanism = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 70723, 71119);

                    string
                    f_1629_70904_70953()
                    {
                        var return_v = RemotingErrorIdStrings.IPCSupportsOnlyDefaultAuth;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 70904, 70953);
                        return return_v;
                    }


                    string
                    f_1629_70980_70996(System.Management.Automation.Runspaces.AuthenticationMechanism
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 70980, 70996);
                        return return_v;
                    }


                    string
                    f_1629_70998_71040(System.Management.Automation.Runspaces.AuthenticationMechanism
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 70998, 71040);
                        return return_v;
                    }


                    System.Management.Automation.PSInvalidOperationException
                    f_1629_70861_71041(string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 70861, 71041);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 70546, 71130);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 70546, 71130);
                }
            }
        }

        public override string CertificateThumbprint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 71294, 71322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 71300, 71320);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 71294, 71322);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 71225, 71393);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 71225, 71393);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 71338, 71382);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 71344, 71380);

                    throw f_1629_71350_71379();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 71338, 71382);

                    System.NotImplementedException
                    f_1629_71350_71379()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 71350, 71379);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 71225, 71393);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 71225, 71393);
                }
            }
        }

        internal override RunspaceConnectionInfo InternalCopy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 71556, 72077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 71636, 71700);

                NamedPipeConnectionInfo
                newCopy = f_1629_71670_71699()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 71714, 71768);

                newCopy._authMechanism = f_1629_71739_71767(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 71782, 71820);

                newCopy._credential = f_1629_71804_71819(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 71834, 71869);

                newCopy.ProcessId = f_1629_71854_71868(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 71883, 71923);

                newCopy._appDomainName = _appDomainName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 71937, 71976);

                newCopy.OpenTimeout = f_1629_71959_71975(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 71990, 72035);

                newCopy.CustomPipeName = f_1629_72015_72034(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 72051, 72066);

                return newCopy;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 71556, 72077);

                System.Management.Automation.Runspaces.NamedPipeConnectionInfo
                f_1629_71670_71699()
                {
                    var return_v = new System.Management.Automation.Runspaces.NamedPipeConnectionInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 71670, 71699);
                    return return_v;
                }


                System.Management.Automation.Runspaces.AuthenticationMechanism
                f_1629_71739_71767(System.Management.Automation.Runspaces.NamedPipeConnectionInfo
                this_param)
                {
                    var return_v = this_param.AuthenticationMechanism;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 71739, 71767);
                    return return_v;
                }


                System.Management.Automation.PSCredential
                f_1629_71804_71819(System.Management.Automation.Runspaces.NamedPipeConnectionInfo
                this_param)
                {
                    var return_v = this_param.Credential;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 71804, 71819);
                    return return_v;
                }


                int
                f_1629_71854_71868(System.Management.Automation.Runspaces.NamedPipeConnectionInfo
                this_param)
                {
                    var return_v = this_param.ProcessId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 71854, 71868);
                    return return_v;
                }


                int
                f_1629_71959_71975(System.Management.Automation.Runspaces.NamedPipeConnectionInfo
                this_param)
                {
                    var return_v = this_param.OpenTimeout;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 71959, 71975);
                    return return_v;
                }


                string
                f_1629_72015_72034(System.Management.Automation.Runspaces.NamedPipeConnectionInfo
                this_param)
                {
                    var return_v = this_param.CustomPipeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 72015, 72034);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 71556, 72077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 71556, 72077);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override BaseClientSessionTransportManager CreateClientSessionTransportManager(Guid instanceId, string sessionName, PSRemotingCryptoHelper cryptoHelper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 72089, 72420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 72275, 72409);

                return f_1629_72282_72408(this, instanceId, cryptoHelper);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 72089, 72420);

                System.Management.Automation.Remoting.Client.NamedPipeClientSessionTransportManager
                f_1629_72282_72408(System.Management.Automation.Runspaces.NamedPipeConnectionInfo
                connectionInfo, System.Guid
                runspaceId, System.Management.Automation.Internal.PSRemotingCryptoHelper
                cryptoHelper)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.NamedPipeClientSessionTransportManager(connectionInfo, runspaceId, cryptoHelper);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 72282, 72408);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 72089, 72420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 72089, 72420);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NamedPipeConnectionInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1629, 65646, 72449);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 65936, 65963);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1629, 65646, 72449);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 65646, 72449);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1629, 65646, 72449);

        static int
        f_1629_67491_67500_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1629, 67411, 67549);
            return return_v;
        }


        static int
        f_1629_68005_68014_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1629, 67890, 68064);
            return return_v;
        }


        static string
        f_1629_69090_69104_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1629, 69002, 69139);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1629_69631_69682(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 69631, 69682);
            return return_v;
        }

    }
    public sealed class SSHConnectionInfo : RunspaceConnectionInfo
    {
        public string UserName
        {
            get;
            private set;
        }

        private string KeyFilePath
        {
            get;
            set;
        }

        private int Port
        {
            get;
            set;
        }

        private string Subsystem
        {
            get;
            set;
        }

        private SSHConnectionInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1629, 73659, 73699);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 72922, 73010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 73097, 73181);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 73274, 73348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 73438, 73520);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 76037, 76130);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1629, 73659, 73699);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 73659, 73699);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 73659, 73699);
            }
        }

        public SSHConnectionInfo(
                    string userName,
                    string computerName,
                    string keyFilePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1629, 73964, 74411);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 72922, 73010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 73097, 73181);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 73274, 73348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 73438, 73520);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 76037, 76130);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 74111, 74191) || true) && (computerName == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 74111, 74191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 74139, 74189);

                    throw f_1629_74145_74188("computerName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 74111, 74191);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 74207, 74232);

                this.UserName = userName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 74246, 74279);

                this.ComputerName = computerName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 74293, 74324);

                this.KeyFilePath = keyFilePath;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 74338, 74352);

                this.Port = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 74366, 74400);

                this.Subsystem = DefaultSubsystem;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1629, 73964, 74411);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 73964, 74411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 73964, 74411);
            }
        }

        public SSHConnectionInfo(
                    string userName,
                    string computerName,
                    string keyFilePath,
                    int port) : this(f_1629_74910_74918_C(userName), computerName, keyFilePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1629, 74757, 75041);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 74971, 74997);

                f_1629_74971_74996(this, port);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 75013, 75030);

                this.Port = port;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1629, 74757, 75041);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 74757, 75041);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 74757, 75041);
            }
        }

        public SSHConnectionInfo(
                    string userName,
                    string computerName,
                    string keyFilePath,
                    int port,
                    string subsystem) : this(f_1629_75657_75665_C(userName), computerName, keyFilePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1629, 75473, 75884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 75718, 75744);

                f_1629_75718_75743(this, port);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 75760, 75777);

                this.Port = port;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 75791, 75873);

                this.Subsystem = (DynAbs.Tracing.TraceSender.Conditional_F1(1629, 75808, 75841) || (((f_1629_75809_75840(subsystem)) && DynAbs.Tracing.TraceSender.Conditional_F2(1629, 75844, 75860)) || DynAbs.Tracing.TraceSender.Conditional_F3(1629, 75863, 75872))) ? DefaultSubsystem : subsystem;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1629, 75473, 75884);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 75473, 75884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 75473, 75884);
            }
        }

        public override string ComputerName
        {
            get;
            set;
        }

        public override PSCredential Credential
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 76278, 76298);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 76284, 76296);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 76278, 76298);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 76214, 76369);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 76214, 76369);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 76314, 76358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 76320, 76356);

                    throw f_1629_76326_76355();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 76314, 76358);

                    System.NotImplementedException
                    f_1629_76326_76355()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 76326, 76355);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 76214, 76369);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 76214, 76369);
                }
            }
        }

        public override AuthenticationMechanism AuthenticationMechanism
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 76545, 76592);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 76551, 76590);

                    return AuthenticationMechanism.Default;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 76545, 76592);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 76457, 76663);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 76457, 76663);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 76608, 76652);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 76614, 76650);

                    throw f_1629_76620_76649();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 76608, 76652);

                    System.NotImplementedException
                    f_1629_76620_76649()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 76620, 76649);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 76457, 76663);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 76457, 76663);
                }
            }
        }

        public override string CertificateThumbprint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 76827, 76855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 76833, 76853);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 76827, 76855);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 76758, 76926);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 76758, 76926);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 76871, 76915);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 76877, 76913);

                    throw f_1629_76883_76912();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 76871, 76915);

                    System.NotImplementedException
                    f_1629_76883_76912()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 76883, 76912);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 76758, 76926);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 76758, 76926);
                }
            }
        }

        internal override RunspaceConnectionInfo InternalCopy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 77089, 77506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 77169, 77221);

                SSHConnectionInfo
                newCopy = f_1629_77197_77220()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 77235, 77276);

                newCopy.ComputerName = f_1629_77258_77275(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 77290, 77323);

                newCopy.UserName = f_1629_77309_77322(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 77337, 77376);

                newCopy.KeyFilePath = f_1629_77359_77375(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 77390, 77415);

                newCopy.Port = f_1629_77405_77414(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 77429, 77464);

                newCopy.Subsystem = f_1629_77449_77463(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 77480, 77495);

                return newCopy;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 77089, 77506);

                System.Management.Automation.Runspaces.SSHConnectionInfo
                f_1629_77197_77220()
                {
                    var return_v = new System.Management.Automation.Runspaces.SSHConnectionInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 77197, 77220);
                    return return_v;
                }


                string
                f_1629_77258_77275(System.Management.Automation.Runspaces.SSHConnectionInfo
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 77258, 77275);
                    return return_v;
                }


                string
                f_1629_77309_77322(System.Management.Automation.Runspaces.SSHConnectionInfo
                this_param)
                {
                    var return_v = this_param.UserName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 77309, 77322);
                    return return_v;
                }


                string
                f_1629_77359_77375(System.Management.Automation.Runspaces.SSHConnectionInfo
                this_param)
                {
                    var return_v = this_param.KeyFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 77359, 77375);
                    return return_v;
                }


                int
                f_1629_77405_77414(System.Management.Automation.Runspaces.SSHConnectionInfo
                this_param)
                {
                    var return_v = this_param.Port;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 77405, 77414);
                    return return_v;
                }


                string
                f_1629_77449_77463(System.Management.Automation.Runspaces.SSHConnectionInfo
                this_param)
                {
                    var return_v = this_param.Subsystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 77449, 77463);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 77089, 77506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 77089, 77506);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override BaseClientSessionTransportManager CreateClientSessionTransportManager(Guid instanceId, string sessionName, PSRemotingCryptoHelper cryptoHelper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 77792, 78117);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 77978, 78106);

                return f_1629_77985_78105(this, instanceId, cryptoHelper);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 77792, 78117);

                System.Management.Automation.Remoting.Client.SSHClientSessionTransportManager
                f_1629_77985_78105(System.Management.Automation.Runspaces.SSHConnectionInfo
                connectionInfo, System.Guid
                runspaceId, System.Management.Automation.Internal.PSRemotingCryptoHelper
                cryptoHelper)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.SSHClientSessionTransportManager(connectionInfo, runspaceId, cryptoHelper);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 77985, 78105);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 77792, 78117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 77792, 78117);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int StartSSHProcess(
                    out StreamWriter stdInWriterVar,
                    out StreamReader stdOutReaderVar,
                    out StreamReader stdErrReaderVar)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 78297, 83005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 78491, 78522);

                string
                filePath = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 78593, 78623);

                string
                sshCommand = "ssh.exe"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 78645, 78712);

                var
                context = f_1629_78659_78711()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 78726, 79028) || true) && (context != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 78726, 79028);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 78779, 78891);

                    var
                    cmdInfo = f_1629_78793_78871(f_1629_78793_78817(context), sshCommand, CommandOrigin.Internal) as ApplicationInfo
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 78909, 79013) || true) && (cmdInfo != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 78909, 79013);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 78970, 78994);

                        filePath = f_1629_78981_78993(cmdInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 78909, 79013);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 78726, 79028);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 80203, 80301);

                System.Diagnostics.ProcessStartInfo
                startInfo = f_1629_80251_80300(filePath)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 80546, 81003) || true) && (!f_1629_80551_80589(f_1629_80572_80588(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 80546, 81003);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 80623, 80863) || true) && (!f_1629_80628_80667(f_1629_80650_80666(this)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 80623, 80863);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 80709, 80844);

                        throw f_1629_80715_80843(f_1629_80767_80842(f_1629_80785_80823(), f_1629_80825_80841(this)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 80623, 80863);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 80883, 80988);

                    f_1629_80883_80987(f_1629_80883_80905(startInfo), f_1629_80910_80986(f_1629_80924_80952(), @"-i ""{0}""", f_1629_80969_80985(this)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 80546, 81003);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 81232, 81923) || true) && (!f_1629_81237_81272(f_1629_81258_81271(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 81232, 81923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 81306, 81366);

                    var
                    parts = f_1629_81318_81365(f_1629_81318_81331(this), Utils.Separators.Backslash)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 81384, 81908) || true) && (f_1629_81388_81400(parts) == 2)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 81384, 81908);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 81506, 81532);

                        var
                        domainName = parts[0]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 81554, 81578);

                        var
                        userName = parts[1]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 81600, 81709);

                        f_1629_81600_81708(f_1629_81600_81622(startInfo), f_1629_81627_81707(f_1629_81641_81669(), @"-l {0}@{1}", userName, domainName));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 81384, 81908);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 81384, 81908);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 81791, 81889);

                        f_1629_81791_81888(f_1629_81791_81813(startInfo), f_1629_81818_81887(f_1629_81832_81860(), @"-l {0}", f_1629_81873_81886(this)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 81384, 81908);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 81232, 81923);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 82119, 82280) || true) && (f_1629_82123_82132(this) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 82119, 82280);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 82171, 82265);

                    f_1629_82171_82264(f_1629_82171_82193(startInfo), f_1629_82198_82263(f_1629_82212_82240(), @"-p {0}", f_1629_82253_82262(this)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 82119, 82280);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 82547, 82697);

                f_1629_82547_82696(f_1629_82547_82569(startInfo), f_1629_82574_82695(f_1629_82588_82616(), @"-s {0} {1}", f_1629_82633_82678(f_1629_82633_82665(f_1629_82633_82650(this), '['), ']'), f_1629_82680_82694(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 82713, 82784);

                startInfo.WorkingDirectory = f_1629_82742_82783(filePath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 82798, 82830);

                startInfo.CreateNoWindow = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 82844, 82878);

                startInfo.UseShellExecute = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 82894, 82994);

                return f_1629_82901_82993(startInfo, out stdInWriterVar, out stdOutReaderVar, out stdErrReaderVar);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 78297, 83005);

                System.Management.Automation.ExecutionContext
                f_1629_78659_78711()
                {
                    var return_v = Runspaces.LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 78659, 78711);
                    return return_v;
                }


                System.Management.Automation.CommandDiscovery
                f_1629_78793_78817(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CommandDiscovery;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 78793, 78817);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1629_78793_78871(System.Management.Automation.CommandDiscovery
                this_param, string
                commandName, System.Management.Automation.CommandOrigin
                commandOrigin)
                {
                    var return_v = this_param.LookupCommandInfo(commandName, commandOrigin);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 78793, 78871);
                    return return_v;
                }


                string
                f_1629_78981_78993(System.Management.Automation.ApplicationInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 78981, 78993);
                    return return_v;
                }


                System.Diagnostics.ProcessStartInfo
                f_1629_80251_80300(string
                fileName)
                {
                    var return_v = new System.Diagnostics.ProcessStartInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 80251, 80300);
                    return return_v;
                }


                string
                f_1629_80572_80588(System.Management.Automation.Runspaces.SSHConnectionInfo
                this_param)
                {
                    var return_v = this_param.KeyFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 80572, 80588);
                    return return_v;
                }


                bool
                f_1629_80551_80589(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 80551, 80589);
                    return return_v;
                }


                string
                f_1629_80650_80666(System.Management.Automation.Runspaces.SSHConnectionInfo
                this_param)
                {
                    var return_v = this_param.KeyFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 80650, 80666);
                    return return_v;
                }


                bool
                f_1629_80628_80667(string
                path)
                {
                    var return_v = System.IO.File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 80628, 80667);
                    return return_v;
                }


                string
                f_1629_80785_80823()
                {
                    var return_v = RemotingErrorIdStrings.KeyFileNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 80785, 80823);
                    return return_v;
                }


                string
                f_1629_80825_80841(System.Management.Automation.Runspaces.SSHConnectionInfo
                this_param)
                {
                    var return_v = this_param.KeyFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 80825, 80841);
                    return return_v;
                }


                string
                f_1629_80767_80842(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 80767, 80842);
                    return return_v;
                }


                System.IO.FileNotFoundException
                f_1629_80715_80843(string
                message)
                {
                    var return_v = new System.IO.FileNotFoundException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 80715, 80843);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1629_80883_80905(System.Diagnostics.ProcessStartInfo
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 80883, 80905);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1629_80924_80952()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 80924, 80952);
                    return return_v;
                }


                string
                f_1629_80969_80985(System.Management.Automation.Runspaces.SSHConnectionInfo
                this_param)
                {
                    var return_v = this_param.KeyFilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 80969, 80985);
                    return return_v;
                }


                string
                f_1629_80910_80986(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 80910, 80986);
                    return return_v;
                }


                int
                f_1629_80883_80987(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 80883, 80987);
                    return 0;
                }


                string
                f_1629_81258_81271(System.Management.Automation.Runspaces.SSHConnectionInfo
                this_param)
                {
                    var return_v = this_param.UserName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 81258, 81271);
                    return return_v;
                }


                bool
                f_1629_81237_81272(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 81237, 81272);
                    return return_v;
                }


                string
                f_1629_81318_81331(System.Management.Automation.Runspaces.SSHConnectionInfo
                this_param)
                {
                    var return_v = this_param.UserName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 81318, 81331);
                    return return_v;
                }


                string[]
                f_1629_81318_81365(string
                this_param, params char[]
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 81318, 81365);
                    return return_v;
                }


                int
                f_1629_81388_81400(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 81388, 81400);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1629_81600_81622(System.Diagnostics.ProcessStartInfo
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 81600, 81622);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1629_81641_81669()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 81641, 81669);
                    return return_v;
                }


                string
                f_1629_81627_81707(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 81627, 81707);
                    return return_v;
                }


                int
                f_1629_81600_81708(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 81600, 81708);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1629_81791_81813(System.Diagnostics.ProcessStartInfo
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 81791, 81813);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1629_81832_81860()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 81832, 81860);
                    return return_v;
                }


                string
                f_1629_81873_81886(System.Management.Automation.Runspaces.SSHConnectionInfo
                this_param)
                {
                    var return_v = this_param.UserName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 81873, 81886);
                    return return_v;
                }


                string
                f_1629_81818_81887(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 81818, 81887);
                    return return_v;
                }


                int
                f_1629_81791_81888(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 81791, 81888);
                    return 0;
                }


                int
                f_1629_82123_82132(System.Management.Automation.Runspaces.SSHConnectionInfo
                this_param)
                {
                    var return_v = this_param.Port;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 82123, 82132);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1629_82171_82193(System.Diagnostics.ProcessStartInfo
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 82171, 82193);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1629_82212_82240()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 82212, 82240);
                    return return_v;
                }


                int
                f_1629_82253_82262(System.Management.Automation.Runspaces.SSHConnectionInfo
                this_param)
                {
                    var return_v = this_param.Port;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 82253, 82262);
                    return return_v;
                }


                string
                f_1629_82198_82263(System.Globalization.CultureInfo
                provider, string
                format, int
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 82198, 82263);
                    return return_v;
                }


                int
                f_1629_82171_82264(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 82171, 82264);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1629_82547_82569(System.Diagnostics.ProcessStartInfo
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 82547, 82569);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1629_82588_82616()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 82588, 82616);
                    return return_v;
                }


                string
                f_1629_82633_82650(System.Management.Automation.Runspaces.SSHConnectionInfo
                this_param)
                {
                    var return_v = this_param.ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 82633, 82650);
                    return return_v;
                }


                string
                f_1629_82633_82665(string
                this_param, char
                trimChar)
                {
                    var return_v = this_param.TrimStart(trimChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 82633, 82665);
                    return return_v;
                }


                string
                f_1629_82633_82678(string
                this_param, char
                trimChar)
                {
                    var return_v = this_param.TrimEnd(trimChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 82633, 82678);
                    return return_v;
                }


                string
                f_1629_82680_82694(System.Management.Automation.Runspaces.SSHConnectionInfo
                this_param)
                {
                    var return_v = this_param.Subsystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 82680, 82694);
                    return return_v;
                }


                string
                f_1629_82574_82695(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 82574, 82695);
                    return return_v;
                }


                int
                f_1629_82547_82696(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 82547, 82696);
                    return 0;
                }


                string?
                f_1629_82742_82783(string
                path)
                {
                    var return_v = System.IO.Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 82742, 82783);
                    return return_v;
                }


                int
                f_1629_82901_82993(System.Diagnostics.ProcessStartInfo
                startInfo, out System.IO.StreamWriter
                stdInWriterVar, out System.IO.StreamReader
                stdOutReaderVar, out System.IO.StreamReader
                stdErrReaderVar)
                {
                    var return_v = StartSSHProcessImpl(startInfo, out stdInWriterVar, out stdOutReaderVar, out stdErrReaderVar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 82901, 82993);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 78297, 83005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 78297, 83005);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const string
        DefaultSubsystem = "powershell"
        ;

        private static int StartSSHProcessImpl(
                    System.Diagnostics.ProcessStartInfo startInfo,
                    out StreamWriter stdInWriterVar,
                    out StreamReader stdOutReaderVar,
                    out StreamReader stdErrReaderVar)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1629, 95950, 98874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 96214, 96234);

                Exception
                ex = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 96248, 96293);

                System.Diagnostics.Process
                sshProcess = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 96749, 96787);

                SafePipeHandle
                stdInPipeServer = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 96801, 96840);

                SafePipeHandle
                stdOutPipeServer = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 96854, 96893);

                SafePipeHandle
                stdErrPipeServer = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 96943, 97148);

                    sshProcess = f_1629_96956_97147(startInfo, out stdInPipeServer, out stdOutPipeServer, out stdErrPipeServer);
                }
                catch (InvalidOperationException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1629, 97177, 97224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 97215, 97222);

                    ex = e;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1629, 97177, 97224);
                }
                catch (ArgumentException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1629, 97238, 97277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 97268, 97275);

                    ex = e;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1629, 97238, 97277);
                }
                catch (FileNotFoundException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1629, 97291, 97334);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 97325, 97332);

                    ex = e;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1629, 97291, 97334);
                }
                catch (System.ComponentModel.Win32Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1629, 97348, 97406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 97397, 97404);

                    ex = e;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1629, 97348, 97406);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 97422, 97768) || true) && ((ex != null) || (DynAbs.Tracing.TraceSender.Expression_False(1629, 97426, 97479) || (sshProcess == null)) || (DynAbs.Tracing.TraceSender.Expression_False(1629, 97426, 97530) || (f_1629_97501_97521(sshProcess) == true)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 97422, 97768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 97564, 97753);

                    throw f_1629_97570_97752(f_1629_97622_97726(f_1629_97640_97683(), (DynAbs.Tracing.TraceSender.Conditional_F1(1629, 97685, 97697) || (((ex != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1629, 97700, 97710)) || DynAbs.Tracing.TraceSender.Conditional_F3(1629, 97713, 97725))) ? f_1629_97700_97710(ex) : string.Empty), ex);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 97422, 97768);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 97872, 97894);

                stdInWriterVar = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 97908, 97931);

                stdOutReaderVar = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 97945, 97968);

                stdErrReaderVar = null;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 98018, 98127);

                    stdInWriterVar = f_1629_98035_98126(f_1629_98052_98125(PipeDirection.Out, true, true, stdInPipeServer));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 98145, 98255);

                    stdOutReaderVar = f_1629_98163_98254(f_1629_98180_98253(PipeDirection.In, true, true, stdOutPipeServer));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 98273, 98383);

                    stdErrReaderVar = f_1629_98291_98382(f_1629_98308_98381(PipeDirection.In, true, true, stdErrPipeServer));
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1629, 98412, 98826);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 98462, 98555) || true) && (stdInWriterVar != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 98462, 98555);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 98492, 98517);

                        f_1629_98492_98516(stdInWriterVar);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 98462, 98555);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 98462, 98555);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 98527, 98553);

                        f_1629_98527_98552(stdInPipeServer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 98462, 98555);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 98575, 98670) || true) && (stdOutReaderVar != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 98575, 98670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 98606, 98631);

                        f_1629_98606_98630(stdInWriterVar);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 98575, 98670);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 98575, 98670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 98641, 98668);

                        f_1629_98641_98667(stdOutPipeServer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 98575, 98670);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 98690, 98785) || true) && (stdErrReaderVar != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 98690, 98785);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 98721, 98746);

                        f_1629_98721_98745(stdInWriterVar);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 98690, 98785);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 98690, 98785);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 98756, 98783);

                        f_1629_98756_98782(stdErrPipeServer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 98690, 98785);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 98805, 98811);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1629, 98412, 98826);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 98842, 98863);

                return f_1629_98849_98862(sshProcess);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1629, 95950, 98874);

                System.Diagnostics.Process
                f_1629_96956_97147(System.Diagnostics.ProcessStartInfo
                startInfo, out Microsoft.Win32.SafeHandles.SafePipeHandle
                stdInPipeServer, out Microsoft.Win32.SafeHandles.SafePipeHandle
                stdOutPipeServer, out Microsoft.Win32.SafeHandles.SafePipeHandle
                stdErrPipeServer)
                {
                    var return_v = CreateProcessWithRedirectedStd(startInfo, out stdInPipeServer, out stdOutPipeServer, out stdErrPipeServer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 96956, 97147);
                    return return_v;
                }


                bool
                f_1629_97501_97521(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.HasExited;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 97501, 97521);
                    return return_v;
                }


                string
                f_1629_97640_97683()
                {
                    var return_v = RemotingErrorIdStrings.CannotStartSSHClient;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 97640, 97683);
                    return return_v;
                }


                string
                f_1629_97700_97710(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 97700, 97710);
                    return return_v;
                }


                string
                f_1629_97622_97726(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 97622, 97726);
                    return return_v;
                }


                System.InvalidOperationException
                f_1629_97570_97752(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.InvalidOperationException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 97570, 97752);
                    return return_v;
                }


                System.IO.Pipes.NamedPipeServerStream
                f_1629_98052_98125(System.IO.Pipes.PipeDirection
                direction, bool
                isAsync, bool
                isConnected, Microsoft.Win32.SafeHandles.SafePipeHandle
                safePipeHandle)
                {
                    var return_v = new System.IO.Pipes.NamedPipeServerStream(direction, isAsync, isConnected, safePipeHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 98052, 98125);
                    return return_v;
                }


                System.IO.StreamWriter
                f_1629_98035_98126(System.IO.Pipes.NamedPipeServerStream
                stream)
                {
                    var return_v = new System.IO.StreamWriter((System.IO.Stream)stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 98035, 98126);
                    return return_v;
                }


                System.IO.Pipes.NamedPipeServerStream
                f_1629_98180_98253(System.IO.Pipes.PipeDirection
                direction, bool
                isAsync, bool
                isConnected, Microsoft.Win32.SafeHandles.SafePipeHandle
                safePipeHandle)
                {
                    var return_v = new System.IO.Pipes.NamedPipeServerStream(direction, isAsync, isConnected, safePipeHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 98180, 98253);
                    return return_v;
                }


                System.IO.StreamReader
                f_1629_98163_98254(System.IO.Pipes.NamedPipeServerStream
                stream)
                {
                    var return_v = new System.IO.StreamReader((System.IO.Stream)stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 98163, 98254);
                    return return_v;
                }


                System.IO.Pipes.NamedPipeServerStream
                f_1629_98308_98381(System.IO.Pipes.PipeDirection
                direction, bool
                isAsync, bool
                isConnected, Microsoft.Win32.SafeHandles.SafePipeHandle
                safePipeHandle)
                {
                    var return_v = new System.IO.Pipes.NamedPipeServerStream(direction, isAsync, isConnected, safePipeHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 98308, 98381);
                    return return_v;
                }


                System.IO.StreamReader
                f_1629_98291_98382(System.IO.Pipes.NamedPipeServerStream
                stream)
                {
                    var return_v = new System.IO.StreamReader((System.IO.Stream)stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 98291, 98382);
                    return return_v;
                }


                int
                f_1629_98492_98516(System.IO.StreamWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 98492, 98516);
                    return 0;
                }


                int
                f_1629_98527_98552(Microsoft.Win32.SafeHandles.SafePipeHandle
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 98527, 98552);
                    return 0;
                }


                int
                f_1629_98606_98630(System.IO.StreamWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 98606, 98630);
                    return 0;
                }


                int
                f_1629_98641_98667(Microsoft.Win32.SafeHandles.SafePipeHandle
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 98641, 98667);
                    return 0;
                }


                int
                f_1629_98721_98745(System.IO.StreamWriter
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 98721, 98745);
                    return 0;
                }


                int
                f_1629_98756_98782(Microsoft.Win32.SafeHandles.SafePipeHandle
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 98756, 98782);
                    return 0;
                }


                int
                f_1629_98849_98862(System.Diagnostics.Process
                this_param)
                {
                    var return_v = this_param.Id;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 98849, 98862);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 95950, 98874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 95950, 98874);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const int
        CREATE_NEW_PROCESS_GROUP = 0x00000200
        ;

        private const int
        CREATE_SUSPENDED = 0x00000004
        ;

        private static Process CreateProcessWithRedirectedStd(
                    ProcessStartInfo startInfo,
                    out SafePipeHandle stdInPipeServer,
                    out SafePipeHandle stdOutPipeServer,
                    out SafePipeHandle stdErrPipeServer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1629, 99139, 105022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 99511, 99534);

                stdInPipeServer = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 99548, 99572);

                stdOutPipeServer = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 99586, 99610);

                stdErrPipeServer = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 99624, 99662);

                SafePipeHandle
                stdInPipeClient = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 99676, 99715);

                SafePipeHandle
                stdOutPipeClient = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 99729, 99768);

                SafePipeHandle
                stdErrPipeClient = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 99782, 99881);

                string
                randomName = f_1629_99802_99880(f_1629_99845_99879())
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 100011, 100083);

                    var
                    securityDesc = f_1629_100030_100082()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 100103, 100154);

                    var
                    stdInPipeName = @"\\.\pipe\StdIn" + randomName
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 100172, 100235);

                    stdInPipeServer = f_1629_100190_100234(stdInPipeName, securityDesc);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 100253, 100305);

                    stdInPipeClient = f_1629_100271_100304(stdInPipeName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 100325, 100378);

                    var
                    stdOutPipeName = @"\\.\pipe\StdOut" + randomName
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 100396, 100461);

                    stdOutPipeServer = f_1629_100415_100460(stdOutPipeName, securityDesc);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 100479, 100533);

                    stdOutPipeClient = f_1629_100498_100532(stdOutPipeName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 100553, 100606);

                    var
                    stdErrPipeName = @"\\.\pipe\StdErr" + randomName
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 100624, 100689);

                    stdErrPipeServer = f_1629_100643_100688(stdErrPipeName, securityDesc);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 100707, 100761);

                    stdErrPipeClient = f_1629_100726_100760(stdErrPipeName);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1629, 100790, 101343);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 100840, 100899) || true) && (stdInPipeServer != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 100840, 100899);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 100871, 100897);

                        f_1629_100871_100896(stdInPipeServer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 100840, 100899);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 100919, 100978) || true) && (stdInPipeClient != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 100919, 100978);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 100950, 100976);

                        f_1629_100950_100975(stdInPipeClient);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 100919, 100978);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 100998, 101059) || true) && (stdOutPipeServer != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 100998, 101059);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 101030, 101057);

                        f_1629_101030_101056(stdOutPipeServer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 100998, 101059);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 101079, 101140) || true) && (stdOutPipeClient != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 101079, 101140);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 101111, 101138);

                        f_1629_101111_101137(stdOutPipeClient);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 101079, 101140);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 101160, 101221) || true) && (stdErrPipeServer != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 101160, 101221);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 101192, 101219);

                        f_1629_101192_101218(stdErrPipeServer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 101160, 101221);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 101241, 101302) || true) && (stdErrPipeClient != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 101241, 101302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 101273, 101300);

                        f_1629_101273_101299(stdErrPipeClient);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 101241, 101302);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 101322, 101328);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1629, 100790, 101343);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 101390, 101468);

                PlatformInvokes.STARTUPINFO
                lpStartupInfo = f_1629_101434_101467()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 101482, 101583);

                PlatformInvokes.PROCESS_INFORMATION
                lpProcessInformation = f_1629_101541_101582()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 101597, 101619);

                int
                creationFlags = 0
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 101758, 101981);

                    var
                    cmdLine = f_1629_101772_101980(f_1629_101808_101836(), @"""{0}"" {1}", f_1629_101898_101916(startInfo), f_1629_101939_101979(' ', f_1629_101956_101978(startInfo)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 102001, 102091);

                    lpStartupInfo.hStdInput = f_1629_102027_102090(f_1629_102046_102082(stdInPipeClient), false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 102109, 102201);

                    lpStartupInfo.hStdOutput = f_1629_102136_102200(f_1629_102155_102192(stdOutPipeClient), false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 102219, 102310);

                    lpStartupInfo.hStdError = f_1629_102245_102309(f_1629_102264_102301(stdErrPipeClient), false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 102328, 102358);

                    lpStartupInfo.dwFlags = 0x100;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 102457, 102484);

                    creationFlags = 0x00000000;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 102731, 102773);

                    creationFlags |= CREATE_NEW_PROCESS_GROUP;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 102935, 102969);

                    creationFlags |= CREATE_SUSPENDED;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 102989, 103089);

                    PlatformInvokes.SECURITY_ATTRIBUTES
                    lpProcessAttributes = f_1629_103047_103088()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 103107, 103206);

                    PlatformInvokes.SECURITY_ATTRIBUTES
                    lpThreadAttributes = f_1629_103164_103205()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 103224, 103635);

                    bool
                    success = f_1629_103239_103634(null, cmdLine, lpProcessAttributes, lpThreadAttributes, true, creationFlags, IntPtr.Zero, f_1629_103528_103554(startInfo), lpStartupInfo, lpProcessInformation)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 103655, 103782) || true) && (!success)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 103655, 103782);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 103709, 103763);

                        throw f_1629_103715_103762(f_1629_103734_103761());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 103655, 103782);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 103935, 104009);

                    Process
                    result = f_1629_103952_104008(lpProcessInformation.dwProcessId)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 104027, 104105);

                    uint
                    returnValue = f_1629_104046_104104(lpProcessInformation.hThread)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 104125, 104295) || true) && (returnValue == PlatformInvokes.RESUME_THREAD_FAILED)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 104125, 104295);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 104222, 104276);

                        throw f_1629_104228_104275(f_1629_104247_104274());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 104125, 104295);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 104315, 104329);

                    return result;
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1629, 104358, 104911);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 104408, 104467) || true) && (stdInPipeServer != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 104408, 104467);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 104439, 104465);

                        f_1629_104439_104464(stdInPipeServer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 104408, 104467);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 104487, 104546) || true) && (stdInPipeClient != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 104487, 104546);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 104518, 104544);

                        f_1629_104518_104543(stdInPipeClient);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 104487, 104546);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 104566, 104627) || true) && (stdOutPipeServer != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 104566, 104627);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 104598, 104625);

                        f_1629_104598_104624(stdOutPipeServer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 104566, 104627);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 104647, 104708) || true) && (stdOutPipeClient != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 104647, 104708);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 104679, 104706);

                        f_1629_104679_104705(stdOutPipeClient);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 104647, 104708);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 104728, 104789) || true) && (stdErrPipeServer != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 104728, 104789);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 104760, 104787);

                        f_1629_104760_104786(stdErrPipeServer);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 104728, 104789);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 104809, 104870) || true) && (stdErrPipeClient != null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 104809, 104870);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 104841, 104868);

                        f_1629_104841_104867(stdErrPipeClient);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 104809, 104870);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 104890, 104896);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1629, 104358, 104911);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1629, 104925, 105011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 104965, 104996);

                    f_1629_104965_104995(lpProcessInformation);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1629, 104925, 105011);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1629, 99139, 105022);

                string
                f_1629_99845_99879()
                {
                    var return_v = System.IO.Path.GetRandomFileName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 99845, 99879);
                    return return_v;
                }


                string?
                f_1629_99802_99880(string
                path)
                {
                    var return_v = System.IO.Path.GetFileNameWithoutExtension(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 99802, 99880);
                    return return_v;
                }


                System.Security.AccessControl.CommonSecurityDescriptor
                f_1629_100030_100082()
                {
                    var return_v = RemoteSessionNamedPipeServer.GetServerPipeSecurity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 100030, 100082);
                    return return_v;
                }


                Microsoft.Win32.SafeHandles.SafePipeHandle
                f_1629_100190_100234(string
                pipeName, System.Security.AccessControl.CommonSecurityDescriptor
                securityDesc)
                {
                    var return_v = CreateNamedPipe(pipeName, securityDesc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 100190, 100234);
                    return return_v;
                }


                Microsoft.Win32.SafeHandles.SafePipeHandle
                f_1629_100271_100304(string
                pipeName)
                {
                    var return_v = GetNamedPipeHandle(pipeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 100271, 100304);
                    return return_v;
                }


                Microsoft.Win32.SafeHandles.SafePipeHandle
                f_1629_100415_100460(string
                pipeName, System.Security.AccessControl.CommonSecurityDescriptor
                securityDesc)
                {
                    var return_v = CreateNamedPipe(pipeName, securityDesc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 100415, 100460);
                    return return_v;
                }


                Microsoft.Win32.SafeHandles.SafePipeHandle
                f_1629_100498_100532(string
                pipeName)
                {
                    var return_v = GetNamedPipeHandle(pipeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 100498, 100532);
                    return return_v;
                }


                Microsoft.Win32.SafeHandles.SafePipeHandle
                f_1629_100643_100688(string
                pipeName, System.Security.AccessControl.CommonSecurityDescriptor
                securityDesc)
                {
                    var return_v = CreateNamedPipe(pipeName, securityDesc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 100643, 100688);
                    return return_v;
                }


                Microsoft.Win32.SafeHandles.SafePipeHandle
                f_1629_100726_100760(string
                pipeName)
                {
                    var return_v = GetNamedPipeHandle(pipeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 100726, 100760);
                    return return_v;
                }


                int
                f_1629_100871_100896(Microsoft.Win32.SafeHandles.SafePipeHandle
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 100871, 100896);
                    return 0;
                }


                int
                f_1629_100950_100975(Microsoft.Win32.SafeHandles.SafePipeHandle
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 100950, 100975);
                    return 0;
                }


                int
                f_1629_101030_101056(Microsoft.Win32.SafeHandles.SafePipeHandle
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 101030, 101056);
                    return 0;
                }


                int
                f_1629_101111_101137(Microsoft.Win32.SafeHandles.SafePipeHandle
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 101111, 101137);
                    return 0;
                }


                int
                f_1629_101192_101218(Microsoft.Win32.SafeHandles.SafePipeHandle
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 101192, 101218);
                    return 0;
                }


                int
                f_1629_101273_101299(Microsoft.Win32.SafeHandles.SafePipeHandle
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 101273, 101299);
                    return 0;
                }


                System.Management.Automation.PlatformInvokes.STARTUPINFO
                f_1629_101434_101467()
                {
                    var return_v = new System.Management.Automation.PlatformInvokes.STARTUPINFO();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 101434, 101467);
                    return return_v;
                }


                System.Management.Automation.PlatformInvokes.PROCESS_INFORMATION
                f_1629_101541_101582()
                {
                    var return_v = new System.Management.Automation.PlatformInvokes.PROCESS_INFORMATION();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 101541, 101582);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1629_101808_101836()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 101808, 101836);
                    return return_v;
                }


                string
                f_1629_101898_101916(System.Diagnostics.ProcessStartInfo
                this_param)
                {
                    var return_v = this_param.FileName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 101898, 101916);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1629_101956_101978(System.Diagnostics.ProcessStartInfo
                this_param)
                {
                    var return_v = this_param.ArgumentList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 101956, 101978);
                    return return_v;
                }


                string
                f_1629_101939_101979(char
                separator, System.Collections.ObjectModel.Collection<string>
                values)
                {
                    var return_v = string.Join(separator, (System.Collections.Generic.IEnumerable<string>)values);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 101939, 101979);
                    return return_v;
                }


                string
                f_1629_101772_101980(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 101772, 101980);
                    return return_v;
                }


                System.IntPtr
                f_1629_102046_102082(Microsoft.Win32.SafeHandles.SafePipeHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 102046, 102082);
                    return return_v;
                }


                Microsoft.Win32.SafeHandles.SafeFileHandle
                f_1629_102027_102090(System.IntPtr
                preexistingHandle, bool
                ownsHandle)
                {
                    var return_v = new Microsoft.Win32.SafeHandles.SafeFileHandle(preexistingHandle, ownsHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 102027, 102090);
                    return return_v;
                }


                System.IntPtr
                f_1629_102155_102192(Microsoft.Win32.SafeHandles.SafePipeHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 102155, 102192);
                    return return_v;
                }


                Microsoft.Win32.SafeHandles.SafeFileHandle
                f_1629_102136_102200(System.IntPtr
                preexistingHandle, bool
                ownsHandle)
                {
                    var return_v = new Microsoft.Win32.SafeHandles.SafeFileHandle(preexistingHandle, ownsHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 102136, 102200);
                    return return_v;
                }


                System.IntPtr
                f_1629_102264_102301(Microsoft.Win32.SafeHandles.SafePipeHandle
                this_param)
                {
                    var return_v = this_param.DangerousGetHandle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 102264, 102301);
                    return return_v;
                }


                Microsoft.Win32.SafeHandles.SafeFileHandle
                f_1629_102245_102309(System.IntPtr
                preexistingHandle, bool
                ownsHandle)
                {
                    var return_v = new Microsoft.Win32.SafeHandles.SafeFileHandle(preexistingHandle, ownsHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 102245, 102309);
                    return return_v;
                }


                System.Management.Automation.PlatformInvokes.SECURITY_ATTRIBUTES
                f_1629_103047_103088()
                {
                    var return_v = new System.Management.Automation.PlatformInvokes.SECURITY_ATTRIBUTES();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 103047, 103088);
                    return return_v;
                }


                System.Management.Automation.PlatformInvokes.SECURITY_ATTRIBUTES
                f_1629_103164_103205()
                {
                    var return_v = new System.Management.Automation.PlatformInvokes.SECURITY_ATTRIBUTES();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 103164, 103205);
                    return return_v;
                }


                string
                f_1629_103528_103554(System.Diagnostics.ProcessStartInfo
                this_param)
                {
                    var return_v = this_param.WorkingDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 103528, 103554);
                    return return_v;
                }


                bool
                f_1629_103239_103634(string
                lpApplicationName, string
                lpCommandLine, System.Management.Automation.PlatformInvokes.SECURITY_ATTRIBUTES
                lpProcessAttributes, System.Management.Automation.PlatformInvokes.SECURITY_ATTRIBUTES
                lpThreadAttributes, bool
                bInheritHandles, int
                dwCreationFlags, System.IntPtr
                lpEnvironment, string
                lpCurrentDirectory, System.Management.Automation.PlatformInvokes.STARTUPINFO
                lpStartupInfo, System.Management.Automation.PlatformInvokes.PROCESS_INFORMATION
                lpProcessInformation)
                {
                    var return_v = PlatformInvokes.CreateProcess(lpApplicationName, lpCommandLine, lpProcessAttributes, lpThreadAttributes, bInheritHandles, dwCreationFlags, lpEnvironment, lpCurrentDirectory, lpStartupInfo, lpProcessInformation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 103239, 103634);
                    return return_v;
                }


                int
                f_1629_103734_103761()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 103734, 103761);
                    return return_v;
                }


                System.ComponentModel.Win32Exception
                f_1629_103715_103762(int
                error)
                {
                    var return_v = new System.ComponentModel.Win32Exception(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 103715, 103762);
                    return return_v;
                }


                System.Diagnostics.Process
                f_1629_103952_104008(int
                processId)
                {
                    var return_v = Process.GetProcessById(processId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 103952, 104008);
                    return return_v;
                }


                uint
                f_1629_104046_104104(System.IntPtr
                threadHandle)
                {
                    var return_v = PlatformInvokes.ResumeThread(threadHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 104046, 104104);
                    return return_v;
                }


                int
                f_1629_104247_104274()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 104247, 104274);
                    return return_v;
                }


                System.ComponentModel.Win32Exception
                f_1629_104228_104275(int
                error)
                {
                    var return_v = new System.ComponentModel.Win32Exception(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 104228, 104275);
                    return return_v;
                }


                int
                f_1629_104439_104464(Microsoft.Win32.SafeHandles.SafePipeHandle
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 104439, 104464);
                    return 0;
                }


                int
                f_1629_104518_104543(Microsoft.Win32.SafeHandles.SafePipeHandle
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 104518, 104543);
                    return 0;
                }


                int
                f_1629_104598_104624(Microsoft.Win32.SafeHandles.SafePipeHandle
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 104598, 104624);
                    return 0;
                }


                int
                f_1629_104679_104705(Microsoft.Win32.SafeHandles.SafePipeHandle
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 104679, 104705);
                    return 0;
                }


                int
                f_1629_104760_104786(Microsoft.Win32.SafeHandles.SafePipeHandle
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 104760, 104786);
                    return 0;
                }


                int
                f_1629_104841_104867(Microsoft.Win32.SafeHandles.SafePipeHandle
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 104841, 104867);
                    return 0;
                }


                int
                f_1629_104965_104995(System.Management.Automation.PlatformInvokes.PROCESS_INFORMATION
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 104965, 104995);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 99139, 105022);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 99139, 105022);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SafePipeHandle GetNamedPipeHandle(string pipeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1629, 105034, 106071);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 105182, 105236);

                uint
                pipeFlags = NamedPipeNative.FILE_FLAG_OVERLAPPED
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 105299, 105398);

                PlatformInvokes.SECURITY_ATTRIBUTES
                securityAttributes = f_1629_105356_105397()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 105450, 105765);

                var
                fileHandle = f_1629_105467_105764(pipeName, NamedPipeNative.GENERIC_READ | NamedPipeNative.GENERIC_WRITE, 0, securityAttributes, NamedPipeNative.OPEN_EXISTING, pipeFlags, IntPtr.Zero)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 105781, 105825);

                int
                lastError = f_1629_105797_105824()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 105839, 106000) || true) && (fileHandle == PlatformInvokes.INVALID_HANDLE_VALUE)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 105839, 106000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 105927, 105985);

                    throw f_1629_105933_105984(lastError);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 105839, 106000);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 106016, 106060);

                return f_1629_106023_106059(fileHandle, true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1629, 105034, 106071);

                System.Management.Automation.PlatformInvokes.SECURITY_ATTRIBUTES
                f_1629_105356_105397()
                {
                    var return_v = new System.Management.Automation.PlatformInvokes.SECURITY_ATTRIBUTES();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 105356, 105397);
                    return return_v;
                }


                System.IntPtr
                f_1629_105467_105764(string
                lpFileName, uint
                dwDesiredAccess, int
                dwShareMode, System.Management.Automation.PlatformInvokes.SECURITY_ATTRIBUTES
                lpSecurityAttributes, uint
                dwCreationDisposition, uint
                dwFlagsAndAttributes, System.IntPtr
                hTemplateFile)
                {
                    var return_v = PlatformInvokes.CreateFileW(lpFileName, dwDesiredAccess, (uint)dwShareMode, lpSecurityAttributes, dwCreationDisposition, dwFlagsAndAttributes, hTemplateFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 105467, 105764);
                    return return_v;
                }


                int
                f_1629_105797_105824()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 105797, 105824);
                    return return_v;
                }


                System.ComponentModel.Win32Exception
                f_1629_105933_105984(int
                error)
                {
                    var return_v = new System.ComponentModel.Win32Exception(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 105933, 105984);
                    return return_v;
                }


                Microsoft.Win32.SafeHandles.SafePipeHandle
                f_1629_106023_106059(System.IntPtr
                preexistingHandle, bool
                ownsHandle)
                {
                    var return_v = new Microsoft.Win32.SafeHandles.SafePipeHandle(preexistingHandle, ownsHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 106023, 106059);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 105034, 106071);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 105034, 106071);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static SafePipeHandle CreateNamedPipe(
                    string pipeName,
                    CommonSecurityDescriptor securityDesc)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1629, 106083, 107714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 106320, 106382);

                NamedPipeNative.SECURITY_ATTRIBUTES
                securityAttributes = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 106396, 106432);

                GCHandle?
                securityDescHandle = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 106446, 106857) || true) && (securityDesc != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 106446, 106857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 106504, 106568);

                    byte[]
                    securityDescBuffer = new byte[f_1629_106541_106566(securityDesc)]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 106586, 106636);

                    f_1629_106586_106635(securityDesc, securityDescBuffer, 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 106654, 106731);

                    securityDescHandle = GCHandle.Alloc(securityDescBuffer, GCHandleType.Pinned);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 106749, 106840);

                    securityAttributes = f_1629_106770_106839(securityDescHandle.Value, true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 106841, 106842);
                    ;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 106446, 106857);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 106914, 107359);

                SafePipeHandle
                pipeHandle = f_1629_106942_107358(pipeName, NamedPipeNative.PIPE_ACCESS_DUPLEX | NamedPipeNative.FILE_FLAG_FIRST_PIPE_INSTANCE | NamedPipeNative.FILE_FLAG_OVERLAPPED, NamedPipeNative.PIPE_TYPE_MESSAGE | NamedPipeNative.PIPE_READMODE_MESSAGE, 1, 32768, 32768, 0, securityAttributes)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 107375, 107419);

                int
                lastError = f_1629_107391_107418()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 107433, 107544) || true) && (securityDescHandle != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 107433, 107544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 107497, 107529);

                    securityDescHandle.Value.Free();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 107433, 107544);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 107560, 107669) || true) && (f_1629_107564_107584(pipeHandle))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 107560, 107669);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 107618, 107654);

                    throw f_1629_107624_107653(lastError);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 107560, 107669);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 107685, 107703);

                return pipeHandle;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1629, 106083, 107714);

                int
                f_1629_106541_106566(System.Security.AccessControl.CommonSecurityDescriptor
                this_param)
                {
                    var return_v = this_param.BinaryLength;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 106541, 106566);
                    return return_v;
                }


                int
                f_1629_106586_106635(System.Security.AccessControl.CommonSecurityDescriptor
                this_param, byte[]
                binaryForm, int
                offset)
                {
                    this_param.GetBinaryForm(binaryForm, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 106586, 106635);
                    return 0;
                }


                System.Management.Automation.Remoting.NamedPipeNative.SECURITY_ATTRIBUTES
                f_1629_106770_106839(System.Runtime.InteropServices.GCHandle
                securityDescriptorPinnedHandle, bool
                inheritHandle)
                {
                    var return_v = NamedPipeNative.GetSecurityAttributes(securityDescriptorPinnedHandle, inheritHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 106770, 106839);
                    return return_v;
                }


                Microsoft.Win32.SafeHandles.SafePipeHandle
                f_1629_106942_107358(string
                lpName, uint
                dwOpenMode, uint
                dwPipeMode, int
                nMaxInstances, int
                nOutBufferSize, int
                nInBufferSize, int
                nDefaultTimeOut, System.Management.Automation.Remoting.NamedPipeNative.SECURITY_ATTRIBUTES
                securityAttributes)
                {
                    var return_v = NamedPipeNative.CreateNamedPipe(lpName, dwOpenMode, dwPipeMode, (uint)nMaxInstances, (uint)nOutBufferSize, (uint)nInBufferSize, (uint)nDefaultTimeOut, securityAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 106942, 107358);
                    return return_v;
                }


                int
                f_1629_107391_107418()
                {
                    var return_v = Marshal.GetLastWin32Error();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 107391, 107418);
                    return return_v;
                }


                bool
                f_1629_107564_107584(Microsoft.Win32.SafeHandles.SafePipeHandle
                this_param)
                {
                    var return_v = this_param.IsInvalid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 107564, 107584);
                    return return_v;
                }


                System.ComponentModel.Win32Exception
                f_1629_107624_107653(int
                error)
                {
                    var return_v = new System.ComponentModel.Win32Exception(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 107624, 107653);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 106083, 107714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 106083, 107714);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SSHConnectionInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1629, 72742, 107753);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 83178, 83209);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 98939, 98976);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 99005, 99034);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1629, 72742, 107753);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 72742, 107753);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1629, 72742, 107753);

        System.Management.Automation.PSArgumentNullException
        f_1629_74145_74188(string
        paramName)
        {
            var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 74145, 74188);
            return return_v;
        }


        int
        f_1629_74971_74996(System.Management.Automation.Runspaces.SSHConnectionInfo
        this_param, int
        port)
        {
            this_param.ValidatePortInRange(port);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 74971, 74996);
            return 0;
        }


        static string
        f_1629_74910_74918_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1629, 74757, 75041);
            return return_v;
        }


        int
        f_1629_75718_75743(System.Management.Automation.Runspaces.SSHConnectionInfo
        this_param, int
        port)
        {
            this_param.ValidatePortInRange(port);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 75718, 75743);
            return 0;
        }


        bool
        f_1629_75809_75840(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 75809, 75840);
            return return_v;
        }


        static string
        f_1629_75657_75665_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1629, 75473, 75884);
            return return_v;
        }

    }
    public sealed class VMConnectionInfo : RunspaceConnectionInfo
    {
        private AuthenticationMechanism _authMechanism;

        private PSCredential _credential;

        private const int
        _defaultOpenTimeout = 20000
        ;

        public Guid VMGuid { get; set; }

        public string ConfigurationName { get; set; }

        public override AuthenticationMechanism AuthenticationMechanism
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 108885, 108958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 108921, 108943);

                    return _authMechanism;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 108885, 108958);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 108797, 109371);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 108797, 109371);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 108974, 109360);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 109010, 109302) || true) && (value != AuthenticationMechanism.Default)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 109010, 109302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 109096, 109283);

                        throw f_1629_109102_109282(f_1629_109145_109194(), f_1629_109221_109237(value), f_1629_109239_109281(AuthenticationMechanism.Default));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 109010, 109302);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 109322, 109345);

                    _authMechanism = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 108974, 109360);

                    string
                    f_1629_109145_109194()
                    {
                        var return_v = RemotingErrorIdStrings.IPCSupportsOnlyDefaultAuth;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 109145, 109194);
                        return return_v;
                    }


                    string
                    f_1629_109221_109237(System.Management.Automation.Runspaces.AuthenticationMechanism
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 109221, 109237);
                        return return_v;
                    }


                    string
                    f_1629_109239_109281(System.Management.Automation.Runspaces.AuthenticationMechanism
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 109239, 109281);
                        return return_v;
                    }


                    System.Management.Automation.PSInvalidOperationException
                    f_1629_109102_109282(string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 109102, 109282);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 108797, 109371);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 108797, 109371);
                }
            }
        }

        public override string CertificateThumbprint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 109768, 109788);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 109774, 109786);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 109768, 109788);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 109699, 109859);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 109699, 109859);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 109804, 109848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 109810, 109846);

                    throw f_1629_109816_109845();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 109804, 109848);

                    System.NotImplementedException
                    f_1629_109816_109845()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 109816, 109845);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 109699, 109859);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 109699, 109859);
                }
            }
        }

        public override PSCredential Credential
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 110031, 110058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 110037, 110056);

                    return _credential;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 110031, 110058);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 109967, 110223);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 109967, 110223);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 110074, 110212);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 110110, 110130);

                    _credential = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 110148, 110197);

                    _authMechanism = AuthenticationMechanism.Default;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 110074, 110212);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 109967, 110223);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 109967, 110223);
                }
            }
        }

        public override string ComputerName { get; set; }

        internal override RunspaceConnectionInfo InternalCopy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 110379, 110598);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 110459, 110559);

                VMConnectionInfo
                result = f_1629_110485_110558(f_1629_110506_110516(), f_1629_110518_110524(), f_1629_110526_110538(), f_1629_110540_110557())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 110573, 110587);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 110379, 110598);

                System.Management.Automation.PSCredential
                f_1629_110506_110516()
                {
                    var return_v = Credential;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 110506, 110516);
                    return return_v;
                }


                System.Guid
                f_1629_110518_110524()
                {
                    var return_v = VMGuid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 110518, 110524);
                    return return_v;
                }


                string
                f_1629_110526_110538()
                {
                    var return_v = ComputerName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 110526, 110538);
                    return return_v;
                }


                string
                f_1629_110540_110557()
                {
                    var return_v = ConfigurationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 110540, 110557);
                    return return_v;
                }


                System.Management.Automation.Runspaces.VMConnectionInfo
                f_1629_110485_110558(System.Management.Automation.PSCredential
                credential, System.Guid
                vmGuid, string
                vmName, string
                configurationName)
                {
                    var return_v = new System.Management.Automation.Runspaces.VMConnectionInfo(credential, vmGuid, vmName, configurationName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 110485, 110558);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 110379, 110598);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 110379, 110598);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override BaseClientSessionTransportManager CreateClientSessionTransportManager(Guid instanceId, string sessionName, PSRemotingCryptoHelper cryptoHelper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 110610, 111007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 110796, 110996);

                return f_1629_110803_110995(this, instanceId, cryptoHelper, f_1629_110952_110958(), f_1629_110977_110994());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 110610, 111007);

                System.Guid
                f_1629_110952_110958()
                {
                    var return_v = VMGuid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 110952, 110958);
                    return return_v;
                }


                string
                f_1629_110977_110994()
                {
                    var return_v = ConfigurationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 110977, 110994);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.VMHyperVSocketClientSessionTransportManager
                f_1629_110803_110995(System.Management.Automation.Runspaces.VMConnectionInfo
                connectionInfo, System.Guid
                runspaceId, System.Management.Automation.Internal.PSRemotingCryptoHelper
                cryptoHelper, System.Guid
                vmGuid, string
                configurationName)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.VMHyperVSocketClientSessionTransportManager(connectionInfo, runspaceId, cryptoHelper, vmGuid, configurationName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 110803, 110995);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 110610, 111007);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 110610, 111007);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal VMConnectionInfo(
                    PSCredential credential,
                    Guid vmGuid,
                    string vmName,
                    string configurationName)
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1629, 111208, 111687);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 108104, 108118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 108150, 108161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 108525, 108570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 110318, 110367);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 111412, 111436);

                Credential = credential;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 111450, 111466);

                VMGuid = vmGuid;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 111480, 111502);

                ComputerName = vmName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 111516, 111554);

                ConfigurationName = configurationName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 111570, 111628);

                AuthenticationMechanism = AuthenticationMechanism.Default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 111642, 111676);

                OpenTimeout = _defaultOpenTimeout;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1629, 111208, 111687);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 111208, 111687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 111208, 111687);
            }
        }

        static VMConnectionInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1629, 107962, 111716);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 108190, 108217);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1629, 107962, 111716);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 107962, 111716);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1629, 107962, 111716);
    }
    public sealed class ContainerConnectionInfo : RunspaceConnectionInfo
    {
        private AuthenticationMechanism _authMechanism;

        private PSCredential _credential;

        private const int
        _defaultOpenTimeout = 20000
        ;

        internal ContainerProcess ContainerProc { get; set; }

        public override AuthenticationMechanism AuthenticationMechanism
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 112860, 112933);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 112896, 112918);

                    return _authMechanism;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 112860, 112933);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 112772, 113346);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 112772, 113346);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 112949, 113335);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 112985, 113277) || true) && (value != AuthenticationMechanism.Default)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 112985, 113277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 113071, 113258);

                        throw f_1629_113077_113257(f_1629_113120_113169(), f_1629_113196_113212(value), f_1629_113214_113256(AuthenticationMechanism.Default));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 112985, 113277);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 113297, 113320);

                    _authMechanism = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 112949, 113335);

                    string
                    f_1629_113120_113169()
                    {
                        var return_v = RemotingErrorIdStrings.IPCSupportsOnlyDefaultAuth;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 113120, 113169);
                        return return_v;
                    }


                    string
                    f_1629_113196_113212(System.Management.Automation.Runspaces.AuthenticationMechanism
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 113196, 113212);
                        return return_v;
                    }


                    string
                    f_1629_113214_113256(System.Management.Automation.Runspaces.AuthenticationMechanism
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 113214, 113256);
                        return return_v;
                    }


                    System.Management.Automation.PSInvalidOperationException
                    f_1629_113077_113257(string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 113077, 113257);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 112772, 113346);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 112772, 113346);
                }
            }
        }

        public override string CertificateThumbprint
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 113743, 113763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 113749, 113761);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 113743, 113763);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 113674, 113834);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 113674, 113834);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 113779, 113823);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 113785, 113821);

                    throw f_1629_113791_113820();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 113779, 113823);

                    System.NotImplementedException
                    f_1629_113791_113820()
                    {
                        var return_v = new System.NotImplementedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 113791, 113820);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 113674, 113834);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 113674, 113834);
                }
            }
        }

        public override PSCredential Credential
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 114006, 114033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 114012, 114031);

                    return _credential;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 114006, 114033);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 113942, 114208);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 113942, 114208);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 114049, 114197);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 114085, 114105);

                    _credential = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 114123, 114182);

                    _authMechanism = Runspaces.AuthenticationMechanism.Default;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 114049, 114197);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 113942, 114208);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 113942, 114208);
                }
            }
        }

        public override string ComputerName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 114370, 114411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 114376, 114409);

                    return f_1629_114383_114408(f_1629_114383_114396());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 114370, 114411);

                    System.Management.Automation.Runspaces.ContainerProcess
                    f_1629_114383_114396()
                    {
                        var return_v = ContainerProc;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 114383, 114396);
                        return return_v;
                    }


                    string
                    f_1629_114383_114408(System.Management.Automation.Runspaces.ContainerProcess
                    this_param)
                    {
                        var return_v = this_param.ContainerId;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 114383, 114408);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 114310, 114482);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 114310, 114482);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 114427, 114471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 114433, 114469);

                    throw f_1629_114439_114468();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 114427, 114471);

                    System.Management.Automation.PSNotSupportedException
                    f_1629_114439_114468()
                    {
                        var return_v = new System.Management.Automation.PSNotSupportedException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 114439, 114468);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 114310, 114482);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 114310, 114482);
                }
            }
        }

        internal override RunspaceConnectionInfo InternalCopy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 114494, 114691);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 114574, 114651);

                ContainerConnectionInfo
                newCopy = f_1629_114608_114650(f_1629_114636_114649())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 114665, 114680);

                return newCopy;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 114494, 114691);

                System.Management.Automation.Runspaces.ContainerProcess
                f_1629_114636_114649()
                {
                    var return_v = ContainerProc;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 114636, 114649);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ContainerConnectionInfo
                f_1629_114608_114650(System.Management.Automation.Runspaces.ContainerProcess
                containerProc)
                {
                    var return_v = new System.Management.Automation.Runspaces.ContainerConnectionInfo(containerProc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 114608, 114650);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 114494, 114691);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 114494, 114691);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override BaseClientSessionTransportManager CreateClientSessionTransportManager(Guid instanceId, string sessionName, PSRemotingCryptoHelper cryptoHelper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 114703, 115415);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 114889, 115404) || true) && (f_1629_114893_114916(f_1629_114893_114906()) != Guid.Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 114889, 115404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 114964, 115168);

                    return f_1629_114971_115167(this, instanceId, cryptoHelper, f_1629_115143_115166(f_1629_115143_115156()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 114889, 115404);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 114889, 115404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 115234, 115389);

                    return f_1629_115241_115388(this, instanceId, cryptoHelper);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 114889, 115404);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 114703, 115415);

                System.Management.Automation.Runspaces.ContainerProcess
                f_1629_114893_114906()
                {
                    var return_v = ContainerProc;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 114893, 114906);
                    return return_v;
                }


                System.Guid
                f_1629_114893_114916(System.Management.Automation.Runspaces.ContainerProcess
                this_param)
                {
                    var return_v = this_param.RuntimeId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 114893, 114916);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ContainerProcess
                f_1629_115143_115156()
                {
                    var return_v = ContainerProc;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 115143, 115156);
                    return return_v;
                }


                System.Guid
                f_1629_115143_115166(System.Management.Automation.Runspaces.ContainerProcess
                this_param)
                {
                    var return_v = this_param.RuntimeId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 115143, 115166);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.ContainerHyperVSocketClientSessionTransportManager
                f_1629_114971_115167(System.Management.Automation.Runspaces.ContainerConnectionInfo
                connectionInfo, System.Guid
                runspaceId, System.Management.Automation.Internal.PSRemotingCryptoHelper
                cryptoHelper, System.Guid
                targetGuid)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.ContainerHyperVSocketClientSessionTransportManager(connectionInfo, runspaceId, cryptoHelper, targetGuid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 114971, 115167);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.ContainerNamedPipeClientSessionTransportManager
                f_1629_115241_115388(System.Management.Automation.Runspaces.ContainerConnectionInfo
                connectionInfo, System.Guid
                runspaceId, System.Management.Automation.Internal.PSRemotingCryptoHelper
                cryptoHelper)
                {
                    var return_v = new System.Management.Automation.Remoting.Client.ContainerNamedPipeClientSessionTransportManager(connectionInfo, runspaceId, cryptoHelper);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 115241, 115388);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 114703, 115415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 114703, 115415);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ContainerConnectionInfo(
                    ContainerProcess containerProc)
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1629, 115623, 115943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 112203, 112217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 112249, 112260);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 112492, 112545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 115748, 115778);

                ContainerProc = containerProc;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 115794, 115852);

                AuthenticationMechanism = AuthenticationMechanism.Default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 115866, 115884);

                Credential = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 115898, 115932);

                OpenTimeout = _defaultOpenTimeout;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1629, 115623, 115943);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 115623, 115943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 115623, 115943);
            }
        }

        public static ContainerConnectionInfo CreateContainerConnectionInfo(
                    string containerId,
                    bool runAsAdmin,
                    string configurationName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1629, 116132, 116511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 116327, 116434);

                ContainerProcess
                containerProc = f_1629_116360_116433(containerId, null, 0, runAsAdmin, configurationName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 116450, 116500);

                return f_1629_116457_116499(containerProc);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1629, 116132, 116511);

                System.Management.Automation.Runspaces.ContainerProcess
                f_1629_116360_116433(string
                containerId, string
                containerObRoot, int
                processId, bool
                runAsAdmin, string
                configurationName)
                {
                    var return_v = new System.Management.Automation.Runspaces.ContainerProcess(containerId, containerObRoot, processId, runAsAdmin, configurationName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 116360, 116433);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ContainerConnectionInfo
                f_1629_116457_116499(System.Management.Automation.Runspaces.ContainerProcess
                containerProc)
                {
                    var return_v = new System.Management.Automation.Runspaces.ContainerConnectionInfo(containerProc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 116457, 116499);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 116132, 116511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 116132, 116511);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void CreateContainerProcess()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 116616, 116727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 116677, 116716);

                f_1629_116677_116715(f_1629_116677_116690());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 116616, 116727);

                System.Management.Automation.Runspaces.ContainerProcess
                f_1629_116677_116690()
                {
                    var return_v = ContainerProc;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 116677, 116690);
                    return return_v;
                }


                int
                f_1629_116677_116715(System.Management.Automation.Runspaces.ContainerProcess
                this_param)
                {
                    this_param.CreateContainerProcess();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 116677, 116715);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 116616, 116727);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 116616, 116727);
            }
        }

        public bool TerminateContainerProcess()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 116835, 116959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 116899, 116948);

                return f_1629_116906_116947(f_1629_116906_116919());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 116835, 116959);

                System.Management.Automation.Runspaces.ContainerProcess
                f_1629_116906_116919()
                {
                    var return_v = ContainerProc;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 116906, 116919);
                    return return_v;
                }


                bool
                f_1629_116906_116947(System.Management.Automation.Runspaces.ContainerProcess
                this_param)
                {
                    var return_v = this_param.TerminateContainerProcess();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 116906, 116947);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 116835, 116959);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 116835, 116959);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ContainerConnectionInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1629, 112054, 116988);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 112289, 112316);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1629, 112054, 116988);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 112054, 116988);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1629, 112054, 116988);
    }
    internal class ContainerProcess
    {
        private const uint
        NoError = 0
        ;

        private const uint
        InvalidContainerId = 1
        ;

        private const uint
        ContainersFeatureNotEnabled = 2
        ;

        private const uint
        OtherError = 9999
        ;

        private const uint
        FileNotFoundHResult = 0x80070002
        ;

        private static readonly string[] Executables;

        public Guid RuntimeId { get; set; }

        public string ContainerObRoot { get; set; }

        public string ContainerId { get; set; }

        internal int ProcessId { get; set; }

        internal bool RunAsAdmin { get; set; }

        internal string ConfigurationName { get; set; }

        internal bool ProcessTerminated { get; set; }

        internal uint ErrorCode { get; set; }

        internal string ErrorMessage { get; set; }

        internal string Executable { get; set; }

        [StructLayout(LayoutKind.Sequential)]
        internal struct HCS_PROCESS_INFORMATION
        {

            public uint ProcessId;

            public uint Reserved;

            public IntPtr StdInput;

            public IntPtr StdOutput;

            public IntPtr StdError;
            static HCS_PROCESS_INFORMATION()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1629, 119901, 120737);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1629, 119901, 120737);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 119901, 120737);
            }
        }

        [DllImport(PinvokeDllNames.CreateProcessInComputeSystemDllName, SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern uint HcsOpenComputeSystem(
                    string id,
                    ref IntPtr computeSystem,
                    ref string result);

        [DllImport(PinvokeDllNames.CreateProcessInComputeSystemDllName, SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern uint HcsGetComputeSystemProperties(
                    IntPtr computeSystem,
                    string propertyQuery,
                    ref string properties,
                    ref string result);

        [DllImport(PinvokeDllNames.CreateProcessInComputeSystemDllName, SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern uint HcsCreateProcess(
                    IntPtr computeSystem,
                    string processParameters,
                    ref HCS_PROCESS_INFORMATION processInformation,
                    ref IntPtr process,
                    ref string result);

        [DllImport(PinvokeDllNames.CreateProcessInComputeSystemDllName, SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern uint HcsOpenProcess(
                    IntPtr computeSystem,
                    int processId,
                    ref IntPtr process,
                    ref string result);

        [DllImport(PinvokeDllNames.CreateProcessInComputeSystemDllName, SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern uint HcsTerminateProcess(
                    IntPtr process,
                    ref string result);

        public ContainerProcess(string containerId, string containerObRoot, int processId, bool runAsAdmin, string configurationName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1629, 122465, 122993);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 118244, 118287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 118397, 118436);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 118573, 118609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 118862, 118909);
                this.RunAsAdmin = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 119043, 119090);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 119224, 119278);
                this.ProcessTerminated = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 119379, 119421);
                this.ErrorCode = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 119542, 119600);
                this.ErrorMessage = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 119744, 119800);
                this.Executable = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 122615, 122646);

                this.ContainerId = containerId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 122660, 122699);

                this.ContainerObRoot = containerObRoot;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 122713, 122740);

                this.ProcessId = processId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 122754, 122783);

                this.RunAsAdmin = runAsAdmin;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 122797, 122840);

                this.ConfigurationName = configurationName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 122856, 122941);

                f_1629_122856_122940(!f_1629_122868_122901(containerId), "containerId input cannot be empty.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 122957, 122982);

                f_1629_122957_122981(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1629, 122465, 122993);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 122465, 122993);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 122465, 122993);
            }
        }

        public void CreateContainerProcess()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 123154, 124569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 123215, 123262);

                f_1629_123215_123261(this, CreateContainerProcessInternal);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 123378, 124558);

                switch (f_1629_123386_123395())
                {

                    case NoError:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 123378, 124558);
                        DynAbs.Tracing.TraceSender.TraceBreak(1629, 123464, 123470);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 123378, 124558);

                    case InvalidContainerId:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 123378, 124558);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 123536, 123726);

                        throw f_1629_123542_123725(f_1629_123574_123724(f_1629_123592_123633(), f_1629_123712_123723()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 123378, 124558);

                    case ContainersFeatureNotEnabled:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 123378, 124558);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 123801, 123891);

                        throw f_1629_123807_123890(f_1629_123839_123889());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 123378, 124558);

                    case OtherError:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 123378, 124558);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 124004, 124056);

                        throw f_1629_124010_124055(f_1629_124042_124054());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 123378, 124558);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 123378, 124558);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 124164, 124543);

                        throw f_1629_124170_124542(f_1629_124202_124541(f_1629_124220_124273(), f_1629_124352_124363(), f_1629_124442_124452(), f_1629_124531_124540()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 123378, 124558);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 123154, 124569);

                int
                f_1629_123215_123261(System.Management.Automation.Runspaces.ContainerProcess
                this_param, System.Threading.ThreadStart
                threadProc)
                {
                    this_param.RunOnMTAThread(threadProc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 123215, 123261);
                    return 0;
                }


                uint
                f_1629_123386_123395()
                {
                    var return_v = ErrorCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 123386, 123395);
                    return return_v;
                }


                string
                f_1629_123592_123633()
                {
                    var return_v = RemotingErrorIdStrings.InvalidContainerId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 123592, 123633);
                    return return_v;
                }


                string
                f_1629_123712_123723()
                {
                    var return_v = ContainerId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 123712, 123723);
                    return return_v;
                }


                string
                f_1629_123574_123724(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 123574, 123724);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1629_123542_123725(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 123542, 123725);
                    return return_v;
                }


                string
                f_1629_123839_123889()
                {
                    var return_v = RemotingErrorIdStrings.ContainersFeatureNotEnabled;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 123839, 123889);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1629_123807_123890(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 123807, 123890);
                    return return_v;
                }


                string
                f_1629_124042_124054()
                {
                    var return_v = ErrorMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 124042, 124054);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1629_124010_124055(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 124010, 124055);
                    return return_v;
                }


                string
                f_1629_124220_124273()
                {
                    var return_v = RemotingErrorIdStrings.CannotCreateProcessInContainer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 124220, 124273);
                    return return_v;
                }


                string
                f_1629_124352_124363()
                {
                    var return_v = ContainerId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 124352, 124363);
                    return return_v;
                }


                string
                f_1629_124442_124452()
                {
                    var return_v = Executable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 124442, 124452);
                    return return_v;
                }


                uint
                f_1629_124531_124540()
                {
                    var return_v = ErrorCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 124531, 124540);
                    return return_v;
                }


                string
                f_1629_124202_124541(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 124202, 124541);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1629_124170_124542(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 124170, 124542);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 123154, 124569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 123154, 124569);
            }
        }

        public bool TerminateContainerProcess()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 124677, 124843);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 124741, 124791);

                f_1629_124741_124790(this, TerminateContainerProcessInternal);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 124807, 124832);

                return f_1629_124814_124831();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 124677, 124843);

                int
                f_1629_124741_124790(System.Management.Automation.Runspaces.ContainerProcess
                this_param, System.Threading.ThreadStart
                threadProc)
                {
                    this_param.RunOnMTAThread(threadProc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 124741, 124790);
                    return 0;
                }


                bool
                f_1629_124814_124831()
                {
                    var return_v = ProcessTerminated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 124814, 124831);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 124677, 124843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 124677, 124843);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void GetContainerProperties()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 124960, 125539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 125021, 125068);

                f_1629_125021_125067(this, GetContainerPropertiesInternal);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 125146, 125528);

                switch (f_1629_125154_125163())
                {

                    case NoError:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 125146, 125528);
                        DynAbs.Tracing.TraceSender.TraceBreak(1629, 125232, 125238);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 125146, 125528);

                    case ContainersFeatureNotEnabled:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 125146, 125528);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 125313, 125403);

                        throw f_1629_125319_125402(f_1629_125351_125401());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 125146, 125528);

                    case OtherError:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 125146, 125528);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 125461, 125513);

                        throw f_1629_125467_125512(f_1629_125499_125511());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 125146, 125528);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 124960, 125539);

                int
                f_1629_125021_125067(System.Management.Automation.Runspaces.ContainerProcess
                this_param, System.Threading.ThreadStart
                threadProc)
                {
                    this_param.RunOnMTAThread(threadProc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 125021, 125067);
                    return 0;
                }


                uint
                f_1629_125154_125163()
                {
                    var return_v = ErrorCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 125154, 125163);
                    return return_v;
                }


                string
                f_1629_125351_125401()
                {
                    var return_v = RemotingErrorIdStrings.ContainersFeatureNotEnabled;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 125351, 125401);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1629_125319_125402(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 125319, 125402);
                    return return_v;
                }


                string
                f_1629_125499_125511()
                {
                    var return_v = ErrorMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 125499, 125511);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1629_125467_125512(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 125467, 125512);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 124960, 125539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 124960, 125539);
            }
        }

        private static void GetHostComputeInteropTypes(out Type computeSystemPropertiesType, out Type hostComputeInteropType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1629, 125966, 127476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 126108, 126261);

                Assembly
                schemaAssembly = f_1629_126134_126260(f_1629_126148_126259("Microsoft.HyperV.Schema, Version=10.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 126467, 126553);

                computeSystemPropertiesType = f_1629_126497_126552(schemaAssembly, "HCS.Compute.System.Properties");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 126567, 126967) || true) && (computeSystemPropertiesType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 126567, 126967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 126640, 126746);

                    computeSystemPropertiesType = f_1629_126670_126745(schemaAssembly, "Microsoft.HyperV.Schema.Compute.System.Properties");

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 126764, 126952) || true) && (computeSystemPropertiesType == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 126764, 126952);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 126845, 126933);

                        throw f_1629_126851_126932(f_1629_126883_126931());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 126764, 126952);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 126567, 126967);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 126983, 127154);

                Assembly
                hostComputeInteropAssembly = f_1629_127021_127153(f_1629_127035_127152("Microsoft.HostCompute.Interop, Version=10.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 127168, 127280);

                hostComputeInteropType = f_1629_127193_127279(hostComputeInteropAssembly, "Microsoft.HostCompute.Interop.HostComputeInterop");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 127294, 127465) || true) && (hostComputeInteropType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 127294, 127465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 127362, 127450);

                    throw f_1629_127368_127449(f_1629_127400_127448());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 127294, 127465);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1629, 125966, 127476);

                System.Reflection.AssemblyName
                f_1629_126148_126259(string
                assemblyName)
                {
                    var return_v = new System.Reflection.AssemblyName(assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 126148, 126259);
                    return return_v;
                }


                System.Reflection.Assembly
                f_1629_126134_126260(System.Reflection.AssemblyName
                assemblyRef)
                {
                    var return_v = Assembly.Load(assemblyRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 126134, 126260);
                    return return_v;
                }


                System.Type?
                f_1629_126497_126552(System.Reflection.Assembly
                this_param, string
                name)
                {
                    var return_v = this_param.GetType(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 126497, 126552);
                    return return_v;
                }


                System.Type?
                f_1629_126670_126745(System.Reflection.Assembly
                this_param, string
                name)
                {
                    var return_v = this_param.GetType(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 126670, 126745);
                    return return_v;
                }


                string
                f_1629_126883_126931()
                {
                    var return_v = RemotingErrorIdStrings.CannotGetHostInteropTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 126883, 126931);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1629_126851_126932(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 126851, 126932);
                    return return_v;
                }


                System.Reflection.AssemblyName
                f_1629_127035_127152(string
                assemblyName)
                {
                    var return_v = new System.Reflection.AssemblyName(assemblyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 127035, 127152);
                    return return_v;
                }


                System.Reflection.Assembly
                f_1629_127021_127153(System.Reflection.AssemblyName
                assemblyRef)
                {
                    var return_v = Assembly.Load(assemblyRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 127021, 127153);
                    return return_v;
                }


                System.Type?
                f_1629_127193_127279(System.Reflection.Assembly
                this_param, string
                name)
                {
                    var return_v = this_param.GetType(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 127193, 127279);
                    return return_v;
                }


                string
                f_1629_127400_127448()
                {
                    var return_v = RemotingErrorIdStrings.CannotGetHostInteropTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 127400, 127448);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1629_127368_127449(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 127368, 127449);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 125966, 127476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 125966, 127476);
            }
        }

        private void CreateContainerProcessInternal()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 127581, 131781);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 127651, 127663);

                uint
                result
                = default(uint);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 127677, 127688);

                string
                cmd
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 127702, 127720);

                int
                processId = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 127734, 127749);

                uint
                error = 0
                ;

                //
                // Check whether the given container id exists.
                //
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 127894, 127929);

                    IntPtr
                    ComputeSystem = IntPtr.Zero
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 127947, 127982);

                    string
                    resultString = string.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 128002, 128082);

                    result = f_1629_128011_128081(f_1629_128032_128043(), ref ComputeSystem, ref resultString);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 128100, 130775) || true) && (result != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 128100, 130775);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 128157, 128171);

                        processId = 0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 128193, 128220);

                        error = InvalidContainerId;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 128100, 130775);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 128100, 130775);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 128866, 130756);
                            foreach (string executableToTry in f_1629_128901_128912_I(Executables))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 128866, 130756);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 128962, 129012);

                                cmd = f_1629_128968_129011(this, executableToTry);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 129040, 129115);

                                HCS_PROCESS_INFORMATION
                                ProcessInformation = f_1629_129085_129114()
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 129141, 129170);

                                IntPtr
                                Process = IntPtr.Zero
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 129330, 129431);

                                result = f_1629_129339_129430(ComputeSystem, cmd, ref ProcessInformation, ref Process, ref resultString);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 129457, 130733) || true) && (result == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 129457, 130733);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 129530, 129588);

                                    processId = f_1629_129542_129587(ProcessInformation.ProcessId);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 129722, 129732);

                                    error = 0;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1629, 129836, 129842);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 129457, 130733);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 129457, 130733);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 129900, 130733) || true) && (result == FileNotFoundHResult)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 129900, 130733);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 130255, 130269);

                                        processId = 0;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 130299, 130314);

                                        error = result;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 130344, 130353);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 129900, 130733);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 129900, 130733);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 130467, 130481);

                                        processId = 0;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 130511, 130526);

                                        error = result;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1629, 130700, 130706);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 129900, 130733);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 129457, 130733);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 128866, 130756);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1629, 1, 1891);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1629, 1, 1891);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 128100, 130775);
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1629, 130804, 131700);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 130856, 131685) || true) && (e is FileNotFoundException || (DynAbs.Tracing.TraceSender.Expression_False(1629, 130860, 130912) || e is FileLoadException))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 130856, 131685);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 131322, 131336);

                        ProcessId = 0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 131358, 131398);

                        ErrorCode = ContainersFeatureNotEnabled;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 131420, 131427);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 130856, 131685);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 130856, 131685);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 131509, 131523);

                        ProcessId = 0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 131545, 131568);

                        ErrorCode = OtherError;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 131590, 131637);

                        ErrorMessage = f_1629_131605_131636(this, e);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 131659, 131666);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 130856, 131685);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1629, 130804, 131700);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 131716, 131738);

                ProcessId = processId;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 131752, 131770);

                ErrorCode = error;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 127581, 131781);

                string
                f_1629_128032_128043()
                {
                    var return_v = ContainerId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 128032, 128043);
                    return return_v;
                }


                uint
                f_1629_128011_128081(string
                id, ref System.IntPtr
                computeSystem, ref string
                result)
                {
                    var return_v = HcsOpenComputeSystem(id, ref computeSystem, ref result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 128011, 128081);
                    return return_v;
                }


                string
                f_1629_128968_129011(System.Management.Automation.Runspaces.ContainerProcess
                this_param, string
                executable)
                {
                    var return_v = this_param.GetContainerProcessCommand(executable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 128968, 129011);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ContainerProcess.HCS_PROCESS_INFORMATION
                f_1629_129085_129114()
                {
                    var return_v = new System.Management.Automation.Runspaces.ContainerProcess.HCS_PROCESS_INFORMATION();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 129085, 129114);
                    return return_v;
                }


                uint
                f_1629_129339_129430(System.IntPtr
                computeSystem, string
                processParameters, ref System.Management.Automation.Runspaces.ContainerProcess.HCS_PROCESS_INFORMATION
                processInformation, ref System.IntPtr
                process, ref string
                result)
                {
                    var return_v = HcsCreateProcess(computeSystem, processParameters, ref processInformation, ref process, ref result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 129339, 129430);
                    return return_v;
                }


                int
                f_1629_129542_129587(uint
                value)
                {
                    var return_v = Convert.ToInt32(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 129542, 129587);
                    return return_v;
                }


                string[]
                f_1629_128901_128912_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 128901, 128912);
                    return return_v;
                }


                string
                f_1629_131605_131636(System.Management.Automation.Runspaces.ContainerProcess
                this_param, System.Exception
                e)
                {
                    var return_v = this_param.GetErrorMessageFromException(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 131605, 131636);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 127581, 131781);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 127581, 131781);
            }
        }

        private string GetContainerProcessCommand(string executable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 132096, 132758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 132181, 132205);

                Executable = executable;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 132219, 132747);

                return f_1629_132226_132746(f_1629_132266_132315(), @"{{""CommandLine"": ""{0} {1} -NoLogo {2}"",""RestrictedToken"": {3}}}", f_1629_132441_132451(), (DynAbs.Tracing.TraceSender.Conditional_F1(1629, 132478, 132503) || (((f_1629_132479_132488() != Guid.Empty) && DynAbs.Tracing.TraceSender.Conditional_F2(1629, 132506, 132536)) || DynAbs.Tracing.TraceSender.Conditional_F3(1629, 132539, 132561))) ? "-SocketServerMode -NoProfile" : "-NamedPipeServerMode", (DynAbs.Tracing.TraceSender.Conditional_F1(1629, 132588, 132627) || ((f_1629_132588_132627(f_1629_132609_132626()) && DynAbs.Tracing.TraceSender.Conditional_F2(1629, 132630, 132642)) || DynAbs.Tracing.TraceSender.Conditional_F3(1629, 132645, 132689))) ? string.Empty : f_1629_132645_132689("-Config ", f_1629_132671_132688()), (DynAbs.Tracing.TraceSender.Conditional_F1(1629, 132716, 132726) || ((f_1629_132716_132726() && DynAbs.Tracing.TraceSender.Conditional_F2(1629, 132729, 132736)) || DynAbs.Tracing.TraceSender.Conditional_F3(1629, 132739, 132745))) ? "false" : "true");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 132096, 132758);

                System.Globalization.CultureInfo
                f_1629_132266_132315()
                {
                    var return_v = System.Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 132266, 132315);
                    return return_v;
                }


                string
                f_1629_132441_132451()
                {
                    var return_v = Executable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 132441, 132451);
                    return return_v;
                }


                System.Guid
                f_1629_132479_132488()
                {
                    var return_v = RuntimeId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 132479, 132488);
                    return return_v;
                }


                string
                f_1629_132609_132626()
                {
                    var return_v = ConfigurationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 132609, 132626);
                    return return_v;
                }


                bool
                f_1629_132588_132627(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 132588, 132627);
                    return return_v;
                }


                string
                f_1629_132671_132688()
                {
                    var return_v = ConfigurationName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 132671, 132688);
                    return return_v;
                }


                string
                f_1629_132645_132689(string
                str0, string
                str1)
                {
                    var return_v = string.Concat(str0, str1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 132645, 132689);
                    return return_v;
                }


                bool
                f_1629_132716_132726()
                {
                    var return_v = RunAsAdmin;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 132716, 132726);
                    return return_v;
                }


                string
                f_1629_132226_132746(System.Globalization.CultureInfo
                provider, string
                format, params object?[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 132226, 132746);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 132096, 132758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 132096, 132758);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void TerminateContainerProcessInternal()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 132870, 133561);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 132943, 132978);

                IntPtr
                ComputeSystem = IntPtr.Zero
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 132992, 133027);

                string
                resultString = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 133041, 133070);

                IntPtr
                process = IntPtr.Zero
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 133086, 133112);

                ProcessTerminated = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 133128, 133550) || true) && (f_1629_133132_133202(f_1629_133153_133164(), ref ComputeSystem, ref resultString) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 133128, 133550);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 133241, 133535) || true) && (f_1629_133245_133316(ComputeSystem, f_1629_133275_133284(), ref process, ref resultString) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 133241, 133535);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 133363, 133516) || true) && (f_1629_133367_133413(process, ref resultString) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 133363, 133516);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 133468, 133493);

                            ProcessTerminated = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 133363, 133516);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 133241, 133535);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 133128, 133550);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 132870, 133561);

                string
                f_1629_133153_133164()
                {
                    var return_v = ContainerId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 133153, 133164);
                    return return_v;
                }


                uint
                f_1629_133132_133202(string
                id, ref System.IntPtr
                computeSystem, ref string
                result)
                {
                    var return_v = HcsOpenComputeSystem(id, ref computeSystem, ref result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 133132, 133202);
                    return return_v;
                }


                int
                f_1629_133275_133284()
                {
                    var return_v = ProcessId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 133275, 133284);
                    return return_v;
                }


                uint
                f_1629_133245_133316(System.IntPtr
                computeSystem, int
                processId, ref System.IntPtr
                process, ref string
                result)
                {
                    var return_v = HcsOpenProcess(computeSystem, processId, ref process, ref result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 133245, 133316);
                    return return_v;
                }


                uint
                f_1629_133367_133413(System.IntPtr
                process, ref string
                result)
                {
                    var return_v = HcsTerminateProcess(process, ref result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 133367, 133413);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 132870, 133561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 132870, 133561);
            }
        }

        private void GetContainerPropertiesInternal()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 133678, 136734);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 133784, 133819);

                    IntPtr
                    ComputeSystem = IntPtr.Zero
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 133837, 133872);

                    string
                    resultString = string.Empty
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 133892, 135876) || true) && (f_1629_133896_133966(f_1629_133917_133928(), ref ComputeSystem, ref resultString) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 133892, 135876);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 134013, 134046);

                        Type
                        computeSystemPropertiesType
                        = default(Type);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 134068, 134096);

                        Type
                        hostComputeInteropType
                        = default(Type);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 134120, 134208);

                        f_1629_134120_134207(out computeSystemPropertiesType, out hostComputeInteropType);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 134232, 134342);

                        MethodInfo
                        getComputeSystemPropertiesInfo = f_1629_134276_134341(hostComputeInteropType, "HcsGetComputeSystemProperties")
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 134366, 134478);

                        var
                        computeSystemPropertiesHandle = f_1629_134402_134477(getComputeSystemPropertiesInfo, null, new object[] { ComputeSystem })
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 134747, 134813);

                        var
                        fieldInfo = f_1629_134763_134812(computeSystemPropertiesType, "RuntimeId")
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 134835, 135489) || true) && (fieldInfo != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 134835, 135489);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 134906, 134974);

                            RuntimeId = (Guid)f_1629_134924_134973(fieldInfo, computeSystemPropertiesHandle);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 134835, 135489);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 134835, 135489);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 135072, 135144);

                            var
                            propertyInfo = f_1629_135091_135143(computeSystemPropertiesType, "RuntimeId")
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 135170, 135367) || true) && (propertyInfo == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 135170, 135367);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 135252, 135340);

                                throw f_1629_135258_135339(f_1629_135290_135338());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 135170, 135367);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 135395, 135466);

                            RuntimeId = (Guid)f_1629_135413_135465(propertyInfo, computeSystemPropertiesHandle);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 134835, 135489);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 135641, 135857) || true) && (f_1629_135645_135654() == Guid.Empty)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 135641, 135857);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 135718, 135834);

                            ContainerObRoot = (string)f_1629_135744_135833(f_1629_135744_135793(computeSystemPropertiesType, "ObRoot"), computeSystemPropertiesHandle);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 135641, 135857);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 133892, 135876);
                    }
                }
                catch (FileNotFoundException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1629, 135905, 136022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 135967, 136007);

                    ErrorCode = ContainersFeatureNotEnabled;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1629, 135905, 136022);
                }
                catch (FileLoadException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1629, 136036, 136149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 136094, 136134);

                    ErrorCode = ContainersFeatureNotEnabled;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1629, 136036, 136149);
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1629, 136163, 136723);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 136215, 136708) || true) && (f_1629_136219_136235(e) != null && (DynAbs.Tracing.TraceSender.Expression_True(1629, 136219, 136442) && f_1629_136268_136442(f_1629_136268_136290(), f_1629_136324_136359(f_1629_136324_136350(f_1629_136324_136340(e))), "Microsoft.HostCompute.Interop.ObjectNotFoundException")))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 136215, 136708);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 136484, 136515);

                        ErrorCode = InvalidContainerId;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 136215, 136708);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 136215, 136708);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 136597, 136620);

                        ErrorCode = OtherError;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 136642, 136689);

                        ErrorMessage = f_1629_136657_136688(this, e);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 136215, 136708);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1629, 136163, 136723);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 133678, 136734);

                string
                f_1629_133917_133928()
                {
                    var return_v = ContainerId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 133917, 133928);
                    return return_v;
                }


                uint
                f_1629_133896_133966(string
                id, ref System.IntPtr
                computeSystem, ref string
                result)
                {
                    var return_v = HcsOpenComputeSystem(id, ref computeSystem, ref result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 133896, 133966);
                    return return_v;
                }


                int
                f_1629_134120_134207(out System.Type
                computeSystemPropertiesType, out System.Type
                hostComputeInteropType)
                {
                    GetHostComputeInteropTypes(out computeSystemPropertiesType, out hostComputeInteropType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 134120, 134207);
                    return 0;
                }


                System.Reflection.MethodInfo?
                f_1629_134276_134341(System.Type
                this_param, string
                name)
                {
                    var return_v = this_param.GetMethod(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 134276, 134341);
                    return return_v;
                }


                object?
                f_1629_134402_134477(System.Reflection.MethodInfo
                this_param, object?
                obj, object[]
                parameters)
                {
                    var return_v = this_param.Invoke(obj, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 134402, 134477);
                    return return_v;
                }


                System.Reflection.FieldInfo?
                f_1629_134763_134812(System.Type
                this_param, string
                name)
                {
                    var return_v = this_param.GetField(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 134763, 134812);
                    return return_v;
                }


                object?
                f_1629_134924_134973(System.Reflection.FieldInfo
                this_param, object
                obj)
                {
                    var return_v = this_param.GetValue(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 134924, 134973);
                    return return_v;
                }


                System.Reflection.PropertyInfo?
                f_1629_135091_135143(System.Type
                this_param, string
                name)
                {
                    var return_v = this_param.GetProperty(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 135091, 135143);
                    return return_v;
                }


                string
                f_1629_135290_135338()
                {
                    var return_v = RemotingErrorIdStrings.CannotGetHostInteropTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 135290, 135338);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1629_135258_135339(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 135258, 135339);
                    return return_v;
                }


                object?
                f_1629_135413_135465(System.Reflection.PropertyInfo
                this_param, object
                obj)
                {
                    var return_v = this_param.GetValue(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 135413, 135465);
                    return return_v;
                }


                System.Guid
                f_1629_135645_135654()
                {
                    var return_v = RuntimeId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 135645, 135654);
                    return return_v;
                }


                System.Reflection.PropertyInfo?
                f_1629_135744_135793(System.Type
                this_param, string
                name)
                {
                    var return_v = this_param.GetProperty(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 135744, 135793);
                    return return_v;
                }


                object?
                f_1629_135744_135833(System.Reflection.PropertyInfo
                this_param, object
                obj)
                {
                    var return_v = this_param.GetValue(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 135744, 135833);
                    return return_v;
                }


                System.Exception
                f_1629_136219_136235(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 136219, 136235);
                    return return_v;
                }


                System.StringComparer
                f_1629_136268_136290()
                {
                    var return_v = StringComparer.Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 136268, 136290);
                    return return_v;
                }


                System.Exception
                f_1629_136324_136340(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 136324, 136340);
                    return return_v;
                }


                System.Type
                f_1629_136324_136350(System.Exception
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 136324, 136350);
                    return return_v;
                }


                string
                f_1629_136324_136359(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 136324, 136359);
                    return return_v;
                }


                bool
                f_1629_136268_136442(System.StringComparer
                this_param, string
                x, string
                y)
                {
                    var return_v = this_param.Equals(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 136268, 136442);
                    return return_v;
                }


                string
                f_1629_136657_136688(System.Management.Automation.Runspaces.ContainerProcess
                this_param, System.Exception
                e)
                {
                    var return_v = this_param.GetErrorMessageFromException(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 136657, 136688);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 133678, 136734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 133678, 136734);
            }
        }

        private void RunOnMTAThread(ThreadStart threadProc)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 136846, 137349);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 136922, 137338) || true) && (f_1629_136926_136966(f_1629_136926_136946()) == ApartmentState.MTA)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 136922, 137338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 137022, 137035);

                    f_1629_137022_137034(threadProc);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 136922, 137338);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 136922, 137338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 137101, 137166);

                    Thread
                    executionThread = f_1629_137126_137165(new ThreadStart(threadProc))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 137186, 137240);

                    f_1629_137186_137239(
                                    executionThread, ApartmentState.MTA);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 137258, 137282);

                    f_1629_137258_137281(executionThread);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 137300, 137323);

                    f_1629_137300_137322(executionThread);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 136922, 137338);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 136846, 137349);

                System.Threading.Thread
                f_1629_136926_136946()
                {
                    var return_v = Thread.CurrentThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 136926, 136946);
                    return return_v;
                }


                System.Threading.ApartmentState
                f_1629_136926_136966(System.Threading.Thread
                this_param)
                {
                    var return_v = this_param.GetApartmentState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 136926, 136966);
                    return return_v;
                }


                int
                f_1629_137022_137034(System.Threading.ThreadStart
                this_param)
                {
                    this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 137022, 137034);
                    return 0;
                }


                System.Threading.Thread
                f_1629_137126_137165(System.Threading.ThreadStart
                start)
                {
                    var return_v = new System.Threading.Thread(start);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 137126, 137165);
                    return return_v;
                }


                int
                f_1629_137186_137239(System.Threading.Thread
                this_param, System.Threading.ApartmentState
                state)
                {
                    this_param.SetApartmentState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 137186, 137239);
                    return 0;
                }


                int
                f_1629_137258_137281(System.Threading.Thread
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 137258, 137281);
                    return 0;
                }


                int
                f_1629_137300_137322(System.Threading.Thread
                this_param)
                {
                    this_param.Join();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 137300, 137322);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 136846, 137349);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 136846, 137349);
            }
        }

        private string GetErrorMessageFromException(Exception e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1629, 137466, 137766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 137547, 137579);

                string
                errorMessage = f_1629_137569_137578(e)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 137595, 137719) || true) && (f_1629_137599_137615(e) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1629, 137595, 137719);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 137657, 137704);

                    errorMessage += " " + f_1629_137679_137703(f_1629_137679_137695(e));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1629, 137595, 137719);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 137735, 137755);

                return errorMessage;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1629, 137466, 137766);

                string
                f_1629_137569_137578(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 137569, 137578);
                    return return_v;
                }


                System.Exception
                f_1629_137599_137615(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 137599, 137615);
                    return return_v;
                }


                System.Exception
                f_1629_137679_137695(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 137679, 137695);
                    return return_v;
                }


                string
                f_1629_137679_137703(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1629, 137679, 137703);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1629, 137466, 137766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 137466, 137766);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ContainerProcess()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1629, 117336, 137795);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 117435, 117446);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 117476, 117498);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 117528, 117559);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 117589, 117606);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 117638, 117670);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1629, 117767, 117826);
            Executables = new string[] { "pwsh.exe", "powershell.exe" };
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1629, 117336, 137795);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1629, 117336, 137795);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1629, 117336, 137795);

        bool
        f_1629_122868_122901(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 122868, 122901);
            return return_v;
        }


        int
        f_1629_122856_122940(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 122856, 122940);
            return 0;
        }


        int
        f_1629_122957_122981(System.Management.Automation.Runspaces.ContainerProcess
        this_param)
        {
            this_param.GetContainerProperties();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1629, 122957, 122981);
            return 0;
        }

    }
}
