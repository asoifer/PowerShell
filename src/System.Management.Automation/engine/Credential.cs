// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#pragma warning disable 1634, 1691

using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Security;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using Microsoft.PowerShell;

// FxCop suppressions for resource strings:
[module: SuppressMessage("Microsoft.Naming", "CA1703:ResourceStringsShouldBeSpelledCorrectly", Scope = "resource", Target = "Credential.resources", MessageId = "Cred")]

namespace System.Management.Automation
{
    /// <summary>
    /// Defines the valid types of MSH credentials.  Used by PromptForCredential calls.
    /// </summary>
    [Flags]
    public enum PSCredentialTypes
    {
        /// <summary>
        /// Generic credentials.
        /// </summary>
        Generic = 1,

        /// <summary>
        /// Credentials valid for a domain.
        /// </summary>
        Domain = 2,

        /// <summary>
        /// Default credentials.
        /// </summary>
        Default = Generic | Domain
    }

    /// <summary>
    /// Defines the options available when prompting for credentials.  Used
    /// by PromptForCredential calls.
    /// </summary>
    [Flags]
    public enum PSCredentialUIOptions
    {
        /// <summary>
        /// Validates the username, but not its existence
        /// or correctness.
        /// </summary>
        Default = ValidateUserNameSyntax,

        /// <summary>
        /// Performs no validation.
        /// </summary>
        None = 0,

        /// <summary>
        /// Validates the username, but not its existence.
        /// or correctness.
        /// </summary>
        ValidateUserNameSyntax,

        /// <summary>
        /// Always prompt, even if a persisted credential was available.
        /// </summary>
        AlwaysPrompt,

        /// <summary>
        /// Username is read-only, and the user may not modify it.
        /// </summary>
        ReadOnlyUserName
    }

    /// <summary>
    /// Declare a delegate which returns the encryption key and initialization vector for symmetric encryption algorithm.
    /// </summary>
    /// <param name="context">The streaming context, which contains the serialization context.</param>
    /// <param name="key">Symmetric encryption key.</param>
    /// <param name="iv">Symmetric encryption initialization vector.</param>
    /// <returns></returns>
    public delegate bool GetSymmetricEncryptionKey(StreamingContext context, out byte[] key, out byte[] iv);
    [Serializable()]
    public sealed class PSCredential : ISerializable
    {
        public static GetSymmetricEncryptionKey GetSymmetricEncryptionKeyDelegate
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1259, 3126, 3195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 3162, 3180);

                    return s_delegate;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1259, 3126, 3195);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1259, 3028, 3292);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1259, 3028, 3292);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1259, 3211, 3281);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 3247, 3266);

                    s_delegate = value;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1259, 3211, 3281);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1259, 3028, 3292);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1259, 3028, 3292);
                }
            }
        }

        private static GetSymmetricEncryptionKey s_delegate;

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1259, 3535, 4719);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 3635, 3677) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1259, 3635, 3677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 3670, 3677);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1259, 3635, 3677);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 3737, 3772);

                string
                safePassword = string.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 3788, 4601) || true) && (_password != null && (DynAbs.Tracing.TraceSender.Expression_True(1259, 3792, 3833) && f_1259_3813_3829(_password) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1259, 3788, 4601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 3867, 3878);

                    byte[]
                    key
                    = default(byte[]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 3896, 3906);

                    byte[]
                    iv
                    = default(byte[]);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 3924, 4586) || true) && (s_delegate != null && (DynAbs.Tracing.TraceSender.Expression_True(1259, 3928, 3986) && f_1259_3950_3986(context, out key, out iv)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1259, 3924, 4586);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 4028, 4104);

                        safePassword = f_1259_4043_4103(f_1259_4043_4089(_password, key, iv));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1259, 3924, 4586);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1259, 3924, 4586);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 4238, 4291);

                            safePassword = f_1259_4253_4290(_password);
                        }
                        catch (CryptographicException cryptographicException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1259, 4336, 4567);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 4438, 4544);

                            throw f_1259_4444_4543(cryptographicException, f_1259_4511_4542());
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1259, 4336, 4567);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1259, 3924, 4586);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1259, 3788, 4601);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 4617, 4654);

                f_1259_4617_4653(
                            info, "UserName", _userName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 4668, 4708);

                f_1259_4668_4707(info, "Password", safePassword);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1259, 3535, 4719);

                int
                f_1259_3813_3829(System.Security.SecureString
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1259, 3813, 3829);
                    return return_v;
                }


                bool
                f_1259_3950_3986(System.Runtime.Serialization.StreamingContext
                context, out byte[]
                key, out byte[]
                iv)
                {
                    var return_v = s_delegate(context, out key, out iv);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 3950, 3986);
                    return return_v;
                }


                Microsoft.PowerShell.EncryptionResult
                f_1259_4043_4089(System.Security.SecureString
                input, byte[]
                key, byte[]
                iv)
                {
                    var return_v = SecureStringHelper.Encrypt(input, key, iv);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 4043, 4089);
                    return return_v;
                }


                string
                f_1259_4043_4103(Microsoft.PowerShell.EncryptionResult
                this_param)
                {
                    var return_v = this_param.EncryptedData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1259, 4043, 4103);
                    return return_v;
                }


                string
                f_1259_4253_4290(System.Security.SecureString
                input)
                {
                    var return_v = SecureStringHelper.Protect(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 4253, 4290);
                    return return_v;
                }


                string
                f_1259_4511_4542()
                {
                    var return_v = Credential.CredentialDisallowed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1259, 4511, 4542);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1259_4444_4543(System.Security.Cryptography.CryptographicException
                innerException, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException((System.Exception)innerException, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 4444, 4543);
                    return return_v;
                }


                int
                f_1259_4617_4653(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 4617, 4653);
                    return 0;
                }


                int
                f_1259_4668_4707(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 4668, 4707);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1259, 3535, 4719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1259, 3535, 4719);
            }
        }

        private PSCredential(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1259, 4890, 5820);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 5847, 5856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 5888, 5897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 7687, 7695);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 4985, 5027) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1259, 4985, 5027);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 5020, 5027);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1259, 4985, 5027);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 5043, 5105);

                _userName = (string)f_1259_5063_5104(info, "UserName", typeof(string));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 5166, 5238);

                string
                safePassword = (string)f_1259_5196_5237(info, "Password", typeof(string))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 5252, 5809) || true) && (safePassword == string.Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1259, 5252, 5809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 5318, 5349);

                    _password = f_1259_5330_5348();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1259, 5252, 5809);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1259, 5252, 5809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 5415, 5426);

                    byte[]
                    key
                    = default(byte[]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 5444, 5454);

                    byte[]
                    iv
                    = default(byte[]);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 5472, 5794) || true) && (s_delegate != null && (DynAbs.Tracing.TraceSender.Expression_True(1259, 5476, 5534) && f_1259_5498_5534(context, out key, out iv)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1259, 5472, 5794);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 5576, 5638);

                        _password = f_1259_5588_5637(safePassword, key, iv);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1259, 5472, 5794);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1259, 5472, 5794);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 5720, 5775);

                        _password = f_1259_5732_5774(safePassword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1259, 5472, 5794);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1259, 5252, 5809);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1259, 4890, 5820);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1259, 4890, 5820);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1259, 4890, 5820);
            }
        }

        private string _userName;

        private SecureString _password;

        public string UserName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1259, 6030, 6055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 6036, 6053);

                    return _userName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1259, 6030, 6055);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1259, 5983, 6066);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1259, 5983, 6066);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SecureString Password
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1259, 6208, 6233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 6214, 6231);

                    return _password;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1259, 6208, 6233);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1259, 6155, 6244);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1259, 6155, 6244);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PSCredential(string userName, SecureString password)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1259, 6530, 6806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 5847, 5856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 5888, 5897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 7687, 7695);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 6614, 6665);

                f_1259_6614_6664(userName, "userName");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 6679, 6723);

                f_1259_6679_6722(password, "password");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 6739, 6760);

                _userName = userName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 6774, 6795);

                _password = password;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1259, 6530, 6806);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1259, 6530, 6806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1259, 6530, 6806);
            }
        }

        public PSCredential(PSObject pso)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1259, 7028, 7479);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 5847, 5856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 5888, 5897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 7687, 7695);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 7086, 7172) || true) && (pso == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1259, 7086, 7172);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 7120, 7172);

                    throw f_1259_7126_7171("pso");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1259, 7086, 7172);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 7188, 7468) || true) && (f_1259_7192_7218(f_1259_7192_7206(pso), "UserName") != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1259, 7188, 7468);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 7260, 7313);

                    _userName = (string)f_1259_7280_7312(f_1259_7280_7306(f_1259_7280_7294(pso), "UserName"));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 7333, 7453) || true) && (f_1259_7337_7363(f_1259_7337_7351(pso), "Password") != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1259, 7333, 7453);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 7394, 7453);

                        _password = (SecureString)f_1259_7420_7452(f_1259_7420_7446(f_1259_7420_7434(pso), "Password"));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1259, 7333, 7453);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1259, 7188, 7468);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1259, 7028, 7479);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1259, 7028, 7479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1259, 7028, 7479);
            }
        }

        private PSCredential()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1259, 7605, 7649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 5847, 5856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 5888, 5897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 7687, 7695);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1259, 7605, 7649);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1259, 7605, 7649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1259, 7605, 7649);
            }
        }

        private NetworkCredential _netCred;

        public NetworkCredential GetNetworkCredential()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1259, 8431, 8864);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 8503, 8821) || true) && (_netCred == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1259, 8503, 8821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 8557, 8576);

                    string
                    user = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 8594, 8615);

                    string
                    domain = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 8635, 8806) || true) && (f_1259_8639_8687(_userName, out user, out domain))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1259, 8635, 8806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 8729, 8787);

                        _netCred = f_1259_8740_8786(user, _password, domain);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1259, 8635, 8806);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1259, 8503, 8821);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 8837, 8853);

                return _netCred;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1259, 8431, 8864);

                bool
                f_1259_8639_8687(string
                input, out string
                user, out string
                domain)
                {
                    var return_v = IsValidUserName(input, out user, out domain);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 8639, 8687);
                    return return_v;
                }


                System.Net.NetworkCredential
                f_1259_8740_8786(string
                userName, System.Security.SecureString
                password, string
                domain)
                {
                    var return_v = new System.Net.NetworkCredential(userName, password, domain);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 8740, 8786);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1259, 8431, 8864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1259, 8431, 8864);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Provides an explicit cast to get a NetworkCredential
        /// from this PSCredential.
        /// </summary>
        /// <param name="credential">PSCredential to convert.</param>
        /// <returns>
        ///     null if the current object has not been initialized.
        ///     null if the current credentials are incompatible with
        ///       a NetworkCredential -- such as smart card credentials.
        ///     the appropriate network credential for this PSCredential otherwise.
        /// </returns>
        public static explicit operator NetworkCredential(PSCredential credential)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1259, 9444, 9807);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 9576, 9706) || true) && (credential == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1259, 9576, 9706);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 9632, 9691);

                    throw f_1259_9638_9690("credential");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1259, 9576, 9706);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 9722, 9763);

                return f_1259_9729_9762(credential);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1259, 9444, 9807);

                System.Management.Automation.PSArgumentNullException
                f_1259_9638_9690(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 9638, 9690);
                    return return_v;
                }


                System.Net.NetworkCredential
                f_1259_9729_9762(System.Management.Automation.PSCredential
                this_param)
                {
                    var return_v = this_param.GetNetworkCredential();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 9729, 9762);
                    return return_v;
                }


#pragma warning restore 56506
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1259, 9444, 9807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1259, 9444, 9807);
            }
        }
        public static PSCredential Empty
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1259, 10055, 10121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 10091, 10106);

                    return s_empty;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1259, 10055, 10121);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1259, 9998, 10132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1259, 9998, 10132);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static readonly PSCredential s_empty;

        private static bool IsValidUserName(string input,
                                                    out string user,
                                                    out string domain)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1259, 10628, 11514);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 10828, 10960) || true) && (f_1259_10832_10859(input))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1259, 10828, 10960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 10893, 10914);

                    user = domain = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 10932, 10945);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1259, 10828, 10960);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 10976, 11021);

                f_1259_10976_11020(input, out user, out domain);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 11037, 11475) || true) && ((user == null) || (DynAbs.Tracing.TraceSender.Expression_False(1259, 11041, 11092) || (domain == null)) || (DynAbs.Tracing.TraceSender.Expression_False(1259, 11041, 11131) || (f_1259_11114_11125(user) == 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1259, 11037, 11475);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 11373, 11460);

                    throw f_1259_11379_11459("UserName", f_1259_11426_11458());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1259, 11037, 11475);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 11491, 11503);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1259, 10628, 11514);

                bool
                f_1259_10832_10859(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 10832, 10859);
                    return return_v;
                }


                int
                f_1259_10976_11020(string
                input, out string
                user, out string
                domain)
                {
                    SplitUserDomain(input, out user, out domain);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 10976, 11020);
                    return 0;
                }


                int
                f_1259_11114_11125(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1259, 11114, 11125);
                    return return_v;
                }


                string
                f_1259_11426_11458()
                {
                    var return_v = Credential.InvalidUserNameFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1259, 11426, 11458);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1259_11379_11459(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 11379, 11459);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1259, 10628, 11514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1259, 10628, 11514);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void SplitUserDomain(string input,
                                                    out string user,
                                                    out string domain)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1259, 12006, 13646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 12206, 12216);

                int
                i = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 12230, 12242);

                user = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 12256, 12270);

                domain = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 12286, 12473) || true) && ((i = f_1259_12295_12314(input, '\\')) >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1259, 12286, 12473);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 12354, 12384);

                    user = f_1259_12361_12383(input, i + 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 12402, 12433);

                    domain = f_1259_12411_12432(input, 0, i);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 12451, 12458);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1259, 12286, 12473);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 13160, 13187);

                i = f_1259_13164_13186(input, '@');

                if (
                (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 13203, 13635) || true) && ((i >= 0) && (DynAbs.Tracing.TraceSender.Expression_True(1259, 13225, 13374) && (
                                    (f_1259_13278_13300(input, '.') < i) || (DynAbs.Tracing.TraceSender.Expression_False(1259, 13277, 13355) || (f_1259_13331_13349(input, '@') != i)
                ))
                ))
                            )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1259, 13203, 13635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 13422, 13454);

                    domain = f_1259_13431_13453(input, i + 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 13472, 13501);

                    user = f_1259_13479_13500(input, 0, i);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1259, 13203, 13635);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1259, 13203, 13635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 13567, 13580);

                    user = input;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 13598, 13620);

                    domain = string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1259, 13203, 13635);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1259, 12006, 13646);

                int
                f_1259_12295_12314(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 12295, 12314);
                    return return_v;
                }


                string
                f_1259_12361_12383(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 12361, 12383);
                    return return_v;
                }


                string
                f_1259_12411_12432(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 12411, 12432);
                    return return_v;
                }


                int
                f_1259_13164_13186(string
                this_param, char
                value)
                {
                    var return_v = this_param.LastIndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 13164, 13186);
                    return return_v;
                }


                int
                f_1259_13278_13300(string
                this_param, char
                value)
                {
                    var return_v = this_param.LastIndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 13278, 13300);
                    return return_v;
                }


                int
                f_1259_13331_13349(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 13331, 13349);
                    return return_v;
                }


                string
                f_1259_13431_13453(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 13431, 13453);
                    return return_v;
                }


                string
                f_1259_13479_13500(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 13479, 13500);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1259, 12006, 13646);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1259, 12006, 13646);
            }
        }

        static PSCredential()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1259, 2762, 13653);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 3345, 3362);
            s_delegate = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1259, 10181, 10209);
            s_empty = f_1259_10191_10209();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1259, 2762, 13653);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1259, 2762, 13653);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1259, 2762, 13653);

        object?
        f_1259_5063_5104(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name, System.Type
        type)
        {
            var return_v = this_param.GetValue(name, type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 5063, 5104);
            return return_v;
        }


        object?
        f_1259_5196_5237(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name, System.Type
        type)
        {
            var return_v = this_param.GetValue(name, type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 5196, 5237);
            return return_v;
        }


        System.Security.SecureString
        f_1259_5330_5348()
        {
            var return_v = new System.Security.SecureString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 5330, 5348);
            return return_v;
        }


        bool
        f_1259_5498_5534(System.Runtime.Serialization.StreamingContext
        context, out byte[]
        key, out byte[]
        iv)
        {
            var return_v = s_delegate(context, out key, out iv);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 5498, 5534);
            return return_v;
        }


        System.Security.SecureString
        f_1259_5588_5637(string
        input, byte[]
        key, byte[]
        IV)
        {
            var return_v = SecureStringHelper.Decrypt(input, key, IV);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 5588, 5637);
            return return_v;
        }


        System.Security.SecureString
        f_1259_5732_5774(string
        input)
        {
            var return_v = SecureStringHelper.Unprotect(input);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 5732, 5774);
            return return_v;
        }


        int
        f_1259_6614_6664(string
        arg, string
        argName)
        {
            Utils.CheckArgForNullOrEmpty(arg, argName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 6614, 6664);
            return 0;
        }


        int
        f_1259_6679_6722(System.Security.SecureString
        arg, string
        argName)
        {
            Utils.CheckArgForNull((object)arg, argName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 6679, 6722);
            return 0;
        }


        System.Management.Automation.PSArgumentNullException
        f_1259_7126_7171(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 7126, 7171);
            return return_v;
        }


        System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
        f_1259_7192_7206(System.Management.Automation.PSObject
        this_param)
        {
            var return_v = this_param.Properties;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1259, 7192, 7206);
            return return_v;
        }


        System.Management.Automation.PSPropertyInfo
        f_1259_7192_7218(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
        this_param, string
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1259, 7192, 7218);
            return return_v;
        }


        System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
        f_1259_7280_7294(System.Management.Automation.PSObject
        this_param)
        {
            var return_v = this_param.Properties;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1259, 7280, 7294);
            return return_v;
        }


        System.Management.Automation.PSPropertyInfo
        f_1259_7280_7306(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
        this_param, string
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1259, 7280, 7306);
            return return_v;
        }


        object
        f_1259_7280_7312(System.Management.Automation.PSPropertyInfo
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1259, 7280, 7312);
            return return_v;
        }


        System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
        f_1259_7337_7351(System.Management.Automation.PSObject
        this_param)
        {
            var return_v = this_param.Properties;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1259, 7337, 7351);
            return return_v;
        }


        System.Management.Automation.PSPropertyInfo
        f_1259_7337_7363(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
        this_param, string
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1259, 7337, 7363);
            return return_v;
        }


        System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
        f_1259_7420_7434(System.Management.Automation.PSObject
        this_param)
        {
            var return_v = this_param.Properties;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1259, 7420, 7434);
            return return_v;
        }


        System.Management.Automation.PSPropertyInfo
        f_1259_7420_7446(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
        this_param, string
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1259, 7420, 7446);
            return return_v;
        }


        object
        f_1259_7420_7452(System.Management.Automation.PSPropertyInfo
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1259, 7420, 7452);
            return return_v;
        }


        static System.Management.Automation.PSCredential
        f_1259_10191_10209()
        {
            var return_v = new System.Management.Automation.PSCredential();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1259, 10191, 10209);
            return return_v;
        }

    }
}

