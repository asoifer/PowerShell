// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Dbg = System.Management.Automation;
using System;
using System.Text;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Management.Automation.Internal;
using System.Management.Automation.Provider;
using System.Management.Automation.Security;
using System.Runtime.InteropServices;
using DWORD = System.UInt32;

namespace System.Management.Automation
{
    /// <summary>
    /// Defines the possible status when validating integrity of catalog.
    /// </summary>
    public enum CatalogValidationStatus
    {
        /// <summary>
        /// Status when catalog is not tampered.
        /// </summary>
        Valid,

        /// <summary>
        /// Status when catalog is tampered.
        /// </summary>
        ValidationFailed
    }
    public class CatalogInformation
    {
        public CatalogValidationStatus Status { get; set; }

        public string HashAlgorithm { get; set; }

        public Dictionary<string, string> CatalogItems { get; set; }

        public Dictionary<string, string> PathItems { get; set; }

        public Signature Signature { get; set; }

        public CatalogInformation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1222, 1140, 2046);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 1267, 1318);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 1455, 1496);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 1649, 1709);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 1843, 1900);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 1999, 2039);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1222, 1140, 2046);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1222, 1140, 2046);
        }


        static CatalogInformation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1222, 1140, 2046);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1222, 1140, 2046);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1222, 1140, 2046);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1222, 1140, 2046);
    }
    internal static class CatalogHelper
    {
        private static int catalogVersion1;

        private static int catalogVersion2;

        private static string HashAlgorithmSHA1;

        private static string HashAlgorithmSHA256;

        private static PSCmdlet _cmdlet;

        private static int GetCatalogVersion(IntPtr catalogHandle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1222, 2979, 4515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 3062, 3086);

                int
                catalogVersion = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 3102, 3176);

                IntPtr
                catalogData = f_1222_3123_3175(catalogHandle)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 3190, 3297);

                NativeMethods.CRYPTCATSTORE
                catalogInfo = f_1222_3232_3296(catalogData)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 3313, 4466) || true) && (catalogInfo.dwPublicVersion == catalogVersion2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 3313, 4466);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 3397, 3416);

                    catalogVersion = 2;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 3313, 4466);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 3313, 4466);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 3740, 4466) || true) && ((catalogInfo.dwPublicVersion == catalogVersion1) || (DynAbs.Tracing.TraceSender.Expression_False(1222, 3744, 3830) || (catalogInfo.dwPublicVersion == 1)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 3740, 4466);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 3864, 3883);

                        catalogVersion = 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 3740, 4466);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 3740, 4466);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 4005, 4254);

                        Exception
                        exception = f_1222_4027_4253(f_1222_4057_4252(f_1222_4075_4111(), f_1222_4152_4181(catalogVersion1, "X"), f_1222_4222_4251(catalogVersion2, "X")))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 4274, 4390);

                        ErrorRecord
                        errorRecord = f_1222_4300_4389(exception, "UnKnownCatalogVersion", ErrorCategory.InvalidOperation, null)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 4408, 4451);

                        f_1222_4408_4450(_cmdlet, errorRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 3740, 4466);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 3313, 4466);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 4482, 4504);

                return catalogVersion;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1222, 2979, 4515);

                System.IntPtr
                f_1222_3123_3175(System.IntPtr
                hCatalog)
                {
                    var return_v = NativeMethods.CryptCATStoreFromHandle(hCatalog);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 3123, 3175);
                    return return_v;
                }


                System.Management.Automation.Security.NativeMethods.CRYPTCATSTORE
                f_1222_3232_3296(System.IntPtr
                ptr)
                {
                    var return_v = Marshal.PtrToStructure<NativeMethods.CRYPTCATSTORE>(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 3232, 3296);
                    return return_v;
                }


                string
                f_1222_4075_4111()
                {
                    var return_v = CatalogStrings.UnKnownCatalogVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 4075, 4111);
                    return return_v;
                }


                string
                f_1222_4152_4181(int
                this_param, string
                format)
                {
                    var return_v = this_param.ToString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 4152, 4181);
                    return return_v;
                }


                string
                f_1222_4222_4251(int
                this_param, string
                format)
                {
                    var return_v = this_param.ToString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 4222, 4251);
                    return return_v;
                }


                string
                f_1222_4057_4252(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 4057, 4252);
                    return return_v;
                }


                System.InvalidOperationException
                f_1222_4027_4253(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 4027, 4253);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1222_4300_4389(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 4300, 4389);
                    return return_v;
                }


                int
                f_1222_4408_4450(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 4408, 4450);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1222, 2979, 4515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1222, 2979, 4515);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetCatalogHashAlgorithm(int catalogVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1222, 4800, 5735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 4890, 4926);

                string
                hashAlgorithm = string.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 4942, 5687) || true) && (catalogVersion == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 4942, 5687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 4999, 5033);

                    hashAlgorithm = HashAlgorithmSHA1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 4942, 5687);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 4942, 5687);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 5067, 5687) || true) && (catalogVersion == 2)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 5067, 5687);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 5124, 5160);

                        hashAlgorithm = HashAlgorithmSHA256;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 5067, 5687);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 5067, 5687);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 5274, 5475);

                        Exception
                        exception = f_1222_5296_5474(f_1222_5326_5473(f_1222_5344_5380(), "1.0", "2.0"))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 5495, 5611);

                        ErrorRecord
                        errorRecord = f_1222_5521_5610(exception, "UnKnownCatalogVersion", ErrorCategory.InvalidOperation, null)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 5629, 5672);

                        f_1222_5629_5671(_cmdlet, errorRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 5067, 5687);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 4942, 5687);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 5703, 5724);

                return hashAlgorithm;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1222, 4800, 5735);

                string
                f_1222_5344_5380()
                {
                    var return_v = CatalogStrings.UnKnownCatalogVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 5344, 5380);
                    return return_v;
                }


                string
                f_1222_5326_5473(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 5326, 5473);
                    return return_v;
                }


                System.InvalidOperationException
                f_1222_5296_5474(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 5296, 5474);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1222_5521_5610(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 5521, 5610);
                    return return_v;
                }


                int
                f_1222_5629_5671(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 5629, 5671);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1222, 4800, 5735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1222, 4800, 5735);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GenerateCDFFile(Collection<string> Path, string catalogFilePath, string cdfFilePath, int catalogVersion, string hashAlgorithm)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1222, 6375, 8518);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 6549, 6603);

                HashSet<string>
                relativePaths = f_1222_6581_6602()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 6619, 6658);

                string
                cdfHeaderContent = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 6672, 6710);

                string
                cdfFilesContent = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 6724, 6750);

                int
                catAttributeCount = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 6855, 6915);

                cdfHeaderContent += "[CatalogHeader]" + f_1222_6895_6914();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 6929, 6998);

                cdfHeaderContent += @"Name=" + catalogFilePath + f_1222_6978_6997();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 7012, 7089);

                cdfHeaderContent += "CatalogVersion=" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (catalogVersion).ToString(), 1222, 7052, 7066) + f_1222_7069_7088();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 7103, 7179);

                cdfHeaderContent += "HashAlgorithms=" + hashAlgorithm + f_1222_7159_7178();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 7193, 7251);

                cdfFilesContent += "[CatalogFiles]" + f_1222_7231_7250();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 7267, 8156);
                    foreach (string catalogFile in f_1222_7298_7302_I(Path))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 7267, 8156);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 7336, 8141) || true) && (f_1222_7340_7379(catalogFile))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 7336, 8141);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 7421, 7516);

                            var
                            directoryItems = f_1222_7442_7515(catalogFile, "*.*", SearchOption.AllDirectories)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 7538, 7838);
                                foreach (string fileItem in f_1222_7566_7580_I(directoryItems))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 7538, 7838);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 7630, 7815);

                                    f_1222_7630_7814(f_1222_7674_7696(fileItem), f_1222_7698_7728(catalogFile), ref relativePaths, ref cdfHeaderContent, ref cdfFilesContent, ref catAttributeCount);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 7538, 7838);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1222, 1, 301);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1222, 1, 301);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 7336, 8141);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 7336, 8141);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 7880, 8141) || true) && (f_1222_7884_7918(catalogFile))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 7880, 8141);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 7960, 8122);

                                f_1222_7960_8121(f_1222_8004_8029(catalogFile), null, ref relativePaths, ref cdfHeaderContent, ref cdfFilesContent, ref catAttributeCount);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 7880, 8141);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 7336, 8141);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 7267, 8156);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1222, 1, 890);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1222, 1, 890);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 8172, 8472);
                using (System.IO.StreamWriter
                fileWriter = f_1222_8215_8287(f_1222_8242_8286(cdfFilePath, FileMode.Create))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 8321, 8360);

                    f_1222_8321_8359(fileWriter, cdfHeaderContent);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 8378, 8401);

                    f_1222_8378_8400(fileWriter);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 8419, 8457);

                    f_1222_8419_8456(fileWriter, cdfFilesContent);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1222, 8172, 8472);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 8488, 8507);

                return cdfFilePath;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1222, 6375, 8518);

                System.Collections.Generic.HashSet<string>
                f_1222_6581_6602()
                {
                    var return_v = new System.Collections.Generic.HashSet<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 6581, 6602);
                    return return_v;
                }


                string
                f_1222_6895_6914()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 6895, 6914);
                    return return_v;
                }


                string
                f_1222_6978_6997()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 6978, 6997);
                    return return_v;
                }


                string
                f_1222_7069_7088()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 7069, 7088);
                    return return_v;
                }


                string
                f_1222_7159_7178()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 7159, 7178);
                    return return_v;
                }


                string
                f_1222_7231_7250()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 7231, 7250);
                    return return_v;
                }


                bool
                f_1222_7340_7379(string
                path)
                {
                    var return_v = System.IO.Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 7340, 7379);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1222_7442_7515(string
                path, string
                searchPattern, System.IO.SearchOption
                searchOption)
                {
                    var return_v = Directory.EnumerateFiles(path, searchPattern, searchOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 7442, 7515);
                    return return_v;
                }


                System.IO.FileInfo
                f_1222_7674_7696(string
                fileName)
                {
                    var return_v = new System.IO.FileInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 7674, 7696);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_1222_7698_7728(string
                path)
                {
                    var return_v = new System.IO.DirectoryInfo(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 7698, 7728);
                    return return_v;
                }


                int
                f_1222_7630_7814(System.IO.FileInfo
                fileToHash, System.IO.DirectoryInfo
                dirInfo, ref System.Collections.Generic.HashSet<string>
                relativePaths, ref string
                cdfHeaderContent, ref string
                cdfFilesContent, ref int
                catAttributeCount)
                {
                    ProcessFileToBeAddedInCatalogDefinitionFile(fileToHash, dirInfo, ref relativePaths, ref cdfHeaderContent, ref cdfFilesContent, ref catAttributeCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 7630, 7814);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1222_7566_7580_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 7566, 7580);
                    return return_v;
                }


                bool
                f_1222_7884_7918(string
                path)
                {
                    var return_v = System.IO.File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 7884, 7918);
                    return return_v;
                }


                System.IO.FileInfo
                f_1222_8004_8029(string
                fileName)
                {
                    var return_v = new System.IO.FileInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 8004, 8029);
                    return return_v;
                }


                int
                f_1222_7960_8121(System.IO.FileInfo
                fileToHash, System.IO.DirectoryInfo
                dirInfo, ref System.Collections.Generic.HashSet<string>
                relativePaths, ref string
                cdfHeaderContent, ref string
                cdfFilesContent, ref int
                catAttributeCount)
                {
                    ProcessFileToBeAddedInCatalogDefinitionFile(fileToHash, dirInfo, ref relativePaths, ref cdfHeaderContent, ref cdfFilesContent, ref catAttributeCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 7960, 8121);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1222_7298_7302_I(System.Collections.ObjectModel.Collection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 7298, 7302);
                    return return_v;
                }


                System.IO.FileStream
                f_1222_8242_8286(string
                path, System.IO.FileMode
                mode)
                {
                    var return_v = new System.IO.FileStream(path, mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 8242, 8286);
                    return return_v;
                }


                System.IO.StreamWriter
                f_1222_8215_8287(System.IO.FileStream
                stream)
                {
                    var return_v = new System.IO.StreamWriter((System.IO.Stream)stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 8215, 8287);
                    return return_v;
                }


                int
                f_1222_8321_8359(System.IO.StreamWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 8321, 8359);
                    return 0;
                }


                int
                f_1222_8378_8400(System.IO.StreamWriter
                this_param)
                {
                    this_param.WriteLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 8378, 8400);
                    return 0;
                }


                int
                f_1222_8419_8456(System.IO.StreamWriter
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 8419, 8456);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1222, 6375, 8518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1222, 6375, 8518);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void ProcessFileToBeAddedInCatalogDefinitionFile(FileInfo fileToHash, DirectoryInfo dirInfo, ref HashSet<string> relativePaths, ref string cdfHeaderContent, ref string cdfFilesContent, ref int catAttributeCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1222, 9291, 11242);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 9543, 9578);

                string
                relativePath = string.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 9594, 9954) || true) && (dirInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 9594, 9954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 9756, 9842);

                    relativePath = f_1222_9771_9841(f_1222_9771_9825(f_1222_9771_9790(fileToHash), f_1222_9801_9824(f_1222_9801_9817(dirInfo))), '\\');
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 9594, 9954);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 9594, 9954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 9908, 9939);

                    relativePath = f_1222_9923_9938(fileToHash);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 9594, 9954);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 9970, 11231) || true) && (!f_1222_9975_10011(relativePaths, relativePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 9970, 11231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 10045, 10077);

                    f_1222_10045_10076(relativePaths, relativePath);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 10095, 10732) || true) && (f_1222_10099_10116(fileToHash) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 10095, 10732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 10163, 10263);

                        cdfFilesContent += "<HASH>" + f_1222_10193_10212(fileToHash) + "=" + f_1222_10221_10240(fileToHash) + f_1222_10243_10262();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 10285, 10403);

                        cdfFilesContent += "<HASH>" + f_1222_10315_10334(fileToHash) + "ATTR1=0x10010001:FilePath:" + relativePath + f_1222_10383_10402();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 10095, 10732);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 10095, 10732);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 10596, 10713);

                        // LAFHIS
                        var temp = ((++catAttributeCount)).ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 10628, 10649);
                        cdfHeaderContent += "CATATTR" + temp + "=0x10010001:FilePath:" + relativePath + f_1222_10693_10712();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 10095, 10732);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 9970, 11231);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 9970, 11231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 10928, 11155);

                    ErrorRecord
                    errorRecord = f_1222_10954_11154(f_1222_10970_11080(f_1222_11000_11079(f_1222_11018_11064(), relativePath)), "FoundDuplicateFilesRelativePath", ErrorCategory.InvalidOperation, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 11173, 11216);

                    f_1222_11173_11215(_cmdlet, errorRecord);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 9970, 11231);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1222, 9291, 11242);

                string
                f_1222_9771_9790(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 9771, 9790);
                    return return_v;
                }


                string
                f_1222_9801_9817(System.IO.DirectoryInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 9801, 9817);
                    return return_v;
                }


                int
                f_1222_9801_9824(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 9801, 9824);
                    return return_v;
                }


                string
                f_1222_9771_9825(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 9771, 9825);
                    return return_v;
                }


                string
                f_1222_9771_9841(string
                this_param, char
                trimChar)
                {
                    var return_v = this_param.TrimStart(trimChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 9771, 9841);
                    return return_v;
                }


                string
                f_1222_9923_9938(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 9923, 9938);
                    return return_v;
                }


                bool
                f_1222_9975_10011(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 9975, 10011);
                    return return_v;
                }


                bool
                f_1222_10045_10076(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 10045, 10076);
                    return return_v;
                }


                long
                f_1222_10099_10116(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 10099, 10116);
                    return return_v;
                }


                string
                f_1222_10193_10212(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 10193, 10212);
                    return return_v;
                }


                string
                f_1222_10221_10240(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 10221, 10240);
                    return return_v;
                }


                string
                f_1222_10243_10262()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 10243, 10262);
                    return return_v;
                }


                string
                f_1222_10315_10334(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 10315, 10334);
                    return return_v;
                }


                string
                f_1222_10383_10402()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 10383, 10402);
                    return return_v;
                }


                string
                f_1222_10693_10712()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 10693, 10712);
                    return return_v;
                }


                string
                f_1222_11018_11064()
                {
                    var return_v = CatalogStrings.FoundDuplicateFilesRelativePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 11018, 11064);
                    return return_v;
                }


                string
                f_1222_11000_11079(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 11000, 11079);
                    return return_v;
                }


                System.InvalidOperationException
                f_1222_10970_11080(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 10970, 11080);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1222_10954_11154(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 10954, 11154);
                    return return_v;
                }


                int
                f_1222_11173_11215(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 11173, 11215);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1222, 9291, 11242);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1222, 9291, 11242);
            }
        }

        internal static void GenerateCatalogFile(string cdfFilePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1222, 11449, 15528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 11534, 11568);

                string
                pwszFilePath = cdfFilePath
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 11582, 11700);

                NativeMethods.CryptCATCDFOpenCallBack
                catOpenCallBack = new NativeMethods.CryptCATCDFOpenCallBack(ParseErrorCallback)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 11746, 11826);

                IntPtr
                resultCDF = f_1222_11765_11825(pwszFilePath, catOpenCallBack)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 11897, 15517) || true) && (resultCDF != IntPtr.Zero)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 11897, 15517);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 12069, 12102);

                    IntPtr
                    catalogAttr = IntPtr.Zero
                    ;
                    {
                        try
                        {
                            do

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 12120, 12627);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 12163, 12261);

                                catalogAttr = f_1222_12177_12260(resultCDF, catalogAttr, catOpenCallBack);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 12285, 12572) || true) && (catalogAttr != IntPtr.Zero)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 12285, 12572);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 12365, 12430);

                                    string
                                    filePath = f_1222_12383_12429(catalogAttr)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 12456, 12549);

                                    f_1222_12456_12548(_cmdlet, f_1222_12477_12547(f_1222_12495_12526(), filePath, filePath));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 12285, 12572);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 12120, 12627);
                            }
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 12120, 12627) || true) && (catalogAttr != IntPtr.Zero)
                            );
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1222, 12120, 12627);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1222, 12120, 12627);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 12720, 12752);

                    IntPtr
                    memberInfo = IntPtr.Zero
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 12814, 12846);

                        IntPtr
                        memberFile = IntPtr.Zero
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 12868, 13029);

                        NativeMethods.CryptCATCDFEnumMembersByCDFTagExErrorCallBack
                        memberCallBack = new NativeMethods.CryptCATCDFEnumMembersByCDFTagExErrorCallBack(ParseErrorCallback)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 13051, 13082);

                        string
                        fileName = string.Empty
                        ;
                        {
                            try
                            {
                                do

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 13104, 14936);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 13155, 13289);

                                    memberFile = f_1222_13168_13288(resultCDF, memberFile, memberCallBack, ref memberInfo, true, IntPtr.Zero);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 13315, 13361);

                                    fileName = f_1222_13326_13360(memberFile);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 13389, 14887) || true) && (!f_1222_13394_13424(fileName))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 13389, 14887);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 13482, 13514);

                                        IntPtr
                                        memberAttr = IntPtr.Zero
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 13544, 13583);

                                        string
                                        fileRelativePath = string.Empty
                                        ;
                                        {
                                            try
                                            {
                                                do

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 13613, 14860);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 13680, 13806);

                                                    memberAttr = f_1222_13693_13805(resultCDF, memberFile, memberInfo, memberAttr, memberCallBack);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 13842, 14794) || true) && (memberAttr != IntPtr.Zero)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 13842, 14794);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 13945, 14010);

                                                        fileRelativePath = f_1222_13964_14009(memberAttr);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 14048, 14759) || true) && (!f_1222_14053_14091(fileRelativePath))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 14048, 14759);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 14489, 14529);

                                                            string
                                                            itemName = f_1222_14507_14528(fileName, 6)
                                                            ;
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 14571, 14672);

                                                            f_1222_14571_14671(_cmdlet, f_1222_14592_14670(f_1222_14610_14641(), itemName, fileRelativePath));
                                                            DynAbs.Tracing.TraceSender.TraceBreak(1222, 14714, 14720);

                                                            break;
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 14048, 14759);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 13842, 14794);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 13613, 14860);
                                                }
                                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 13613, 14860) || true) && (memberAttr != IntPtr.Zero)
                                                );
                                            }
                                            catch (System.Exception)
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1222, 13613, 14860);
                                                throw;
                                            }
                                            finally
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoop(1222, 13613, 14860);
                                            }
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 13389, 14887);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 13104, 14936);
                                }
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 13104, 14936) || true) && (fileName != null)
                                );
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1222, 13104, 14936);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1222, 13104, 14936);
                            }
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1222, 14973, 15082);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 15021, 15063);

                        f_1222_15021_15062(resultCDF);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1222, 14973, 15082);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 11897, 15517);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 11897, 15517);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 15243, 15441);

                    ErrorRecord
                    errorRecord = f_1222_15269_15440(f_1222_15285_15364(f_1222_15315_15363()), "UnableToOpenCatalogDefinitionFile", ErrorCategory.InvalidOperation, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 15459, 15502);

                    f_1222_15459_15501(_cmdlet, errorRecord);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 11897, 15517);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1222, 11449, 15528);

                System.IntPtr
                f_1222_11765_11825(string
                pwszFilePath, System.Management.Automation.Security.NativeMethods.CryptCATCDFOpenCallBack
                pfnParseError)
                {
                    var return_v = NativeMethods.CryptCATCDFOpen(pwszFilePath, pfnParseError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 11765, 11825);
                    return return_v;
                }


                System.IntPtr
                f_1222_12177_12260(System.IntPtr
                pCDF, System.IntPtr
                pPrevAttr, System.Management.Automation.Security.NativeMethods.CryptCATCDFOpenCallBack
                pfnParseError)
                {
                    var return_v = NativeMethods.CryptCATCDFEnumCatAttributes(pCDF, pPrevAttr, pfnParseError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 12177, 12260);
                    return return_v;
                }


                string
                f_1222_12383_12429(System.IntPtr
                memberAttrInfo)
                {
                    var return_v = ProcessFilePathAttributeInCatalog(memberAttrInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 12383, 12429);
                    return return_v;
                }


                string
                f_1222_12495_12526()
                {
                    var return_v = CatalogStrings.AddFileToCatalog;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 12495, 12526);
                    return return_v;
                }


                string
                f_1222_12477_12547(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 12477, 12547);
                    return return_v;
                }


                int
                f_1222_12456_12548(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 12456, 12548);
                    return 0;
                }


                System.IntPtr
                f_1222_13168_13288(System.IntPtr
                pCDF, System.IntPtr
                pwszPrevCDFTag, System.Management.Automation.Security.NativeMethods.CryptCATCDFEnumMembersByCDFTagExErrorCallBack
                fn, ref System.IntPtr
                ppMember, bool
                fContinueOnError, System.IntPtr
                pvReserved)
                {
                    var return_v = NativeMethods.CryptCATCDFEnumMembersByCDFTagEx(pCDF, pwszPrevCDFTag, fn, ref ppMember, fContinueOnError, pvReserved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 13168, 13288);
                    return return_v;
                }


                string?
                f_1222_13326_13360(System.IntPtr
                ptr)
                {
                    var return_v = Marshal.PtrToStringUni(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 13326, 13360);
                    return return_v;
                }


                bool
                f_1222_13394_13424(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 13394, 13424);
                    return return_v;
                }


                System.IntPtr
                f_1222_13693_13805(System.IntPtr
                pCDF, System.IntPtr
                pwszMemberTag, System.IntPtr
                pMember, System.IntPtr
                pPrevAttr, System.Management.Automation.Security.NativeMethods.CryptCATCDFEnumMembersByCDFTagExErrorCallBack
                fn)
                {
                    var return_v = NativeMethods.CryptCATCDFEnumAttributesWithCDFTag(pCDF, pwszMemberTag, pMember, pPrevAttr, fn);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 13693, 13805);
                    return return_v;
                }


                string
                f_1222_13964_14009(System.IntPtr
                memberAttrInfo)
                {
                    var return_v = ProcessFilePathAttributeInCatalog(memberAttrInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 13964, 14009);
                    return return_v;
                }


                bool
                f_1222_14053_14091(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 14053, 14091);
                    return return_v;
                }


                string
                f_1222_14507_14528(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 14507, 14528);
                    return return_v;
                }


                string
                f_1222_14610_14641()
                {
                    var return_v = CatalogStrings.AddFileToCatalog;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 14610, 14641);
                    return return_v;
                }


                string
                f_1222_14592_14670(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 14592, 14670);
                    return return_v;
                }


                int
                f_1222_14571_14671(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 14571, 14671);
                    return 0;
                }


                bool
                f_1222_15021_15062(System.IntPtr
                pCDF)
                {
                    var return_v = NativeMethods.CryptCATCDFClose(pCDF);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 15021, 15062);
                    return return_v;
                }


                string
                f_1222_15315_15363()
                {
                    var return_v = CatalogStrings.UnableToOpenCatalogDefinitionFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 15315, 15363);
                    return return_v;
                }


                System.InvalidOperationException
                f_1222_15285_15364(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 15285, 15364);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1222_15269_15440(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 15269, 15440);
                    return return_v;
                }


                int
                f_1222_15459_15501(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 15459, 15501);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1222, 11449, 15528);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1222, 11449, 15528);
            }
        }

        internal static FileInfo GenerateCatalog(PSCmdlet cmdlet, Collection<string> Path, string catalogFilePath, int catalogVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1222, 15998, 17775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 16149, 16166);

                _cmdlet = cmdlet;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 16180, 16243);

                string
                hashAlgorithm = f_1222_16203_16242(catalogVersion)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 16259, 17736) || true) && (!f_1222_16264_16299(hashAlgorithm))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 16259, 17736);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 16395, 16505);

                    string
                    cdfFilePath = f_1222_16416_16504(f_1222_16439_16467(), f_1222_16469_16503())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 16523, 16558);

                    cdfFilePath = cdfFilePath + ".cdf";
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 16620, 16717);

                        cdfFilePath = f_1222_16634_16716(Path, catalogFilePath, cdfFilePath, catalogVersion, hashAlgorithm);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 16741, 17371) || true) && (!f_1222_16746_16770(cdfFilePath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 16741, 17371);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 17081, 17279);

                            ErrorRecord
                            errorRecord = f_1222_17107_17278(f_1222_17123_17202(f_1222_17153_17201()), "CatalogDefinitionFileNotGenerated", ErrorCategory.InvalidOperation, null)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 17305, 17348);

                            f_1222_17305_17347(_cmdlet, errorRecord);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 16741, 17371);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 17395, 17428);

                        f_1222_17395_17427(cdfFilePath);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 17450, 17592) || true) && (f_1222_17454_17482(catalogFilePath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 17450, 17592);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 17532, 17569);

                            return f_1222_17539_17568(catalogFilePath);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 17450, 17592);
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1222, 17629, 17721);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 17677, 17702);

                        f_1222_17677_17701(cdfFilePath);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1222, 17629, 17721);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 16259, 17736);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 17752, 17764);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1222, 15998, 17775);

                string
                f_1222_16203_16242(int
                catalogVersion)
                {
                    var return_v = GetCatalogHashAlgorithm(catalogVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 16203, 16242);
                    return return_v;
                }


                bool
                f_1222_16264_16299(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 16264, 16299);
                    return return_v;
                }


                string
                f_1222_16439_16467()
                {
                    var return_v = System.IO.Path.GetTempPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 16439, 16467);
                    return return_v;
                }


                string
                f_1222_16469_16503()
                {
                    var return_v = System.IO.Path.GetRandomFileName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 16469, 16503);
                    return return_v;
                }


                string
                f_1222_16416_16504(string
                path1, string
                path2)
                {
                    var return_v = System.IO.Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 16416, 16504);
                    return return_v;
                }


                string
                f_1222_16634_16716(System.Collections.ObjectModel.Collection<string>
                Path, string
                catalogFilePath, string
                cdfFilePath, int
                catalogVersion, string
                hashAlgorithm)
                {
                    var return_v = GenerateCDFFile(Path, catalogFilePath, cdfFilePath, catalogVersion, hashAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 16634, 16716);
                    return return_v;
                }


                bool
                f_1222_16746_16770(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 16746, 16770);
                    return return_v;
                }


                string
                f_1222_17153_17201()
                {
                    var return_v = CatalogStrings.CatalogDefinitionFileNotGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 17153, 17201);
                    return return_v;
                }


                System.InvalidOperationException
                f_1222_17123_17202(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 17123, 17202);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1222_17107_17278(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 17107, 17278);
                    return return_v;
                }


                int
                f_1222_17305_17347(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 17305, 17347);
                    return 0;
                }


                int
                f_1222_17395_17427(string
                cdfFilePath)
                {
                    GenerateCatalogFile(cdfFilePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 17395, 17427);
                    return 0;
                }


                bool
                f_1222_17454_17482(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 17454, 17482);
                    return return_v;
                }


                System.IO.FileInfo
                f_1222_17539_17568(string
                fileName)
                {
                    var return_v = new System.IO.FileInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 17539, 17568);
                    return return_v;
                }


                int
                f_1222_17677_17701(string
                path)
                {
                    File.Delete(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 17677, 17701);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1222, 15998, 17775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1222, 15998, 17775);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string ProcessFilePathAttributeInCatalog(IntPtr memberAttrInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1222, 18062, 19180);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 18166, 18201);

                string
                relativePath = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 18217, 18341);

                NativeMethods.CRYPTCATATTRIBUTE
                currentMemberAttr = f_1222_18269_18340(memberAttrInfo)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 18533, 19133) || true) && (f_1222_18537_18626(currentMemberAttr.pwszReferenceTag, "FilePath", StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 18533, 19133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 18776, 18827);

                    int
                    attrValueSize = (int)currentMemberAttr.cbValue
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 18845, 18888);

                    byte[]
                    attrValue = new byte[attrValueSize]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 18906, 18975);

                    f_1222_18906_18974(currentMemberAttr.pbValue, attrValue, 0, attrValueSize);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 18993, 19058);

                    relativePath = f_1222_19008_19057(f_1222_19008_19036(), attrValue);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 19076, 19118);

                    relativePath = f_1222_19091_19117(relativePath, '\0');
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 18533, 19133);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 19149, 19169);

                return relativePath;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1222, 18062, 19180);

                System.Management.Automation.Security.NativeMethods.CRYPTCATATTRIBUTE
                f_1222_18269_18340(System.IntPtr
                ptr)
                {
                    var return_v = Marshal.PtrToStructure<NativeMethods.CRYPTCATATTRIBUTE>(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 18269, 18340);
                    return return_v;
                }


                bool
                f_1222_18537_18626(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 18537, 18626);
                    return return_v;
                }


                int
                f_1222_18906_18974(System.IntPtr
                source, byte[]
                destination, int
                startIndex, int
                length)
                {
                    Marshal.Copy(source, destination, startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 18906, 18974);
                    return 0;
                }


                System.Text.Encoding
                f_1222_19008_19036()
                {
                    var return_v = System.Text.Encoding.Unicode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 19008, 19036);
                    return return_v;
                }


                string
                f_1222_19008_19057(System.Text.Encoding
                this_param, byte[]
                bytes)
                {
                    var return_v = this_param.GetString(bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 19008, 19057);
                    return return_v;
                }


                string
                f_1222_19091_19117(string
                this_param, char
                trimChar)
                {
                    var return_v = this_param.TrimEnd(trimChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 19091, 19117);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1222, 18062, 19180);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1222, 18062, 19180);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string CalculateFileHash(string filePath, string hashAlgorithm)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1222, 19469, 23308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 19573, 19605);

                string
                hashValue = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 19619, 19649);

                IntPtr
                catAdmin = IntPtr.Zero
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 19748, 20199) || true) && (!f_1222_19753_19853(ref catAdmin, IntPtr.Zero, hashAlgorithm, IntPtr.Zero, 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 19748, 20199);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 19887, 20123);

                    ErrorRecord
                    errorRecord = f_1222_19913_20122(f_1222_19929_20044(f_1222_19959_20043(f_1222_19977_20027(), hashAlgorithm)), "UnableToAcquireHashAlgorithmContext", ErrorCategory.InvalidOperation, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 20141, 20184);

                    f_1222_20141_20183(_cmdlet, errorRecord);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 19748, 20199);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 20215, 20247);

                DWORD
                GENERIC_READ = 0x80000000
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 20261, 20285);

                DWORD
                OPEN_EXISTING = 3
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 20299, 20344);

                IntPtr
                INVALID_HANDLE_VALUE = f_1222_20329_20343(-1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 20442, 20548);

                IntPtr
                fileHandle = f_1222_20462_20547(filePath, GENERIC_READ, 0, 0, OPEN_EXISTING, 0, IntPtr.Zero)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 20562, 23264) || true) && (fileHandle != INVALID_HANDLE_VALUE)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 20562, 23264);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 20678, 20703);

                        DWORD
                        hashBufferSize = 0
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 20725, 20757);

                        IntPtr
                        hashBuffer = IntPtr.Zero
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 20879, 21338) || true) && (!f_1222_20884_20991(catAdmin, fileHandle, ref hashBufferSize, hashBuffer, 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 20879, 21338);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 21041, 21246);

                            ErrorRecord
                            errorRecord = f_1222_21067_21245(f_1222_21083_21180(f_1222_21113_21179(f_1222_21131_21168(), filePath)), "UnableToCreateFileHash", ErrorCategory.InvalidOperation, null)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 21272, 21315);

                            f_1222_21272_21314(_cmdlet, errorRecord);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 20879, 21338);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 21362, 21393);

                        int
                        size = (int)hashBufferSize
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 21415, 21455);

                        hashBuffer = f_1222_21428_21454(size);
                        try
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 21605, 22080) || true) && (!f_1222_21610_21717(catAdmin, fileHandle, ref hashBufferSize, hashBuffer, 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 21605, 22080);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 21775, 21980);

                                ErrorRecord
                                errorRecord = f_1222_21801_21979(f_1222_21817_21914(f_1222_21847_21913(f_1222_21865_21902(), filePath)), "UnableToCreateFileHash", ErrorCategory.InvalidOperation, null)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 22010, 22053);

                                f_1222_22010_22052(_cmdlet, errorRecord);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 21605, 22080);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 22108, 22142);

                            byte[]
                            hashBytes = new byte[size]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 22168, 22213);

                            f_1222_22168_22212(hashBuffer, hashBytes, 0, size);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 22239, 22311);

                            hashValue = f_1222_22251_22310(f_1222_22251_22283(hashBytes), "-", string.Empty);
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinally(1222, 22356, 22581);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 22412, 22558) || true) && (hashBuffer != IntPtr.Zero)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 22412, 22558);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 22499, 22531);

                                f_1222_22499_22530(hashBuffer);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 22412, 22558);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitFinally(1222, 22356, 22581);
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1222, 22618, 22800);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 22666, 22721);

                        f_1222_22666_22720(catAdmin, 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 22743, 22781);

                        f_1222_22743_22780(fileHandle);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1222, 22618, 22800);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 20562, 23264);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 20562, 23264);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 22983, 23188);

                    ErrorRecord
                    errorRecord = f_1222_23009_23187(f_1222_23025_23122(f_1222_23055_23121(f_1222_23073_23110(), filePath)), "UnableToReadFileToHash", ErrorCategory.InvalidOperation, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 23206, 23249);

                    f_1222_23206_23248(_cmdlet, errorRecord);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 20562, 23264);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 23280, 23297);

                return hashValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1222, 19469, 23308);

                bool
                f_1222_19753_19853(ref System.IntPtr
                phCatAdmin, System.IntPtr
                pgSubsystem, string
                pwszHashAlgorithm, System.IntPtr
                pStrongHashPolicy, int
                dwFlags)
                {
                    var return_v = NativeMethods.CryptCATAdminAcquireContext2(ref phCatAdmin, pgSubsystem, pwszHashAlgorithm, pStrongHashPolicy, (uint)dwFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 19753, 19853);
                    return return_v;
                }


                string
                f_1222_19977_20027()
                {
                    var return_v = CatalogStrings.UnableToAcquireHashAlgorithmContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 19977, 20027);
                    return return_v;
                }


                string
                f_1222_19959_20043(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 19959, 20043);
                    return return_v;
                }


                System.InvalidOperationException
                f_1222_19929_20044(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 19929, 20044);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1222_19913_20122(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 19913, 20122);
                    return return_v;
                }


                int
                f_1222_20141_20183(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 20141, 20183);
                    return 0;
                }


                System.IntPtr
                f_1222_20329_20343(int
                value)
                {
                    var return_v = new System.IntPtr(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 20329, 20343);
                    return return_v;
                }


                System.IntPtr
                f_1222_20462_20547(string
                lpFileName, uint
                dwDesiredAccess, int
                dwShareMode, int
                lpSecurityAttributes, uint
                dwCreationDisposition, int
                dwFlagsAndAttributes, System.IntPtr
                hTemplateFile)
                {
                    var return_v = NativeMethods.CreateFile(lpFileName, dwDesiredAccess, (uint)dwShareMode, (uint)lpSecurityAttributes, dwCreationDisposition, (uint)dwFlagsAndAttributes, hTemplateFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 20462, 20547);
                    return return_v;
                }


                bool
                f_1222_20884_20991(System.IntPtr
                hCatAdmin, System.IntPtr
                hFile, ref uint
                pcbHash, System.IntPtr
                pbHash, int
                dwFlags)
                {
                    var return_v = NativeMethods.CryptCATAdminCalcHashFromFileHandle2(hCatAdmin, hFile, ref pcbHash, pbHash, (uint)dwFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 20884, 20991);
                    return return_v;
                }


                string
                f_1222_21131_21168()
                {
                    var return_v = CatalogStrings.UnableToCreateFileHash;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 21131, 21168);
                    return return_v;
                }


                string
                f_1222_21113_21179(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 21113, 21179);
                    return return_v;
                }


                System.InvalidOperationException
                f_1222_21083_21180(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 21083, 21180);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1222_21067_21245(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 21067, 21245);
                    return return_v;
                }


                int
                f_1222_21272_21314(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 21272, 21314);
                    return 0;
                }


                System.IntPtr
                f_1222_21428_21454(int
                cb)
                {
                    var return_v = Marshal.AllocHGlobal(cb);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 21428, 21454);
                    return return_v;
                }


                bool
                f_1222_21610_21717(System.IntPtr
                hCatAdmin, System.IntPtr
                hFile, ref uint
                pcbHash, System.IntPtr
                pbHash, int
                dwFlags)
                {
                    var return_v = NativeMethods.CryptCATAdminCalcHashFromFileHandle2(hCatAdmin, hFile, ref pcbHash, pbHash, (uint)dwFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 21610, 21717);
                    return return_v;
                }


                string
                f_1222_21865_21902()
                {
                    var return_v = CatalogStrings.UnableToCreateFileHash;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 21865, 21902);
                    return return_v;
                }


                string
                f_1222_21847_21913(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 21847, 21913);
                    return return_v;
                }


                System.InvalidOperationException
                f_1222_21817_21914(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 21817, 21914);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1222_21801_21979(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 21801, 21979);
                    return return_v;
                }


                int
                f_1222_22010_22052(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 22010, 22052);
                    return 0;
                }


                int
                f_1222_22168_22212(System.IntPtr
                source, byte[]
                destination, int
                startIndex, int
                length)
                {
                    Marshal.Copy(source, destination, startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 22168, 22212);
                    return 0;
                }


                string
                f_1222_22251_22283(byte[]
                value)
                {
                    var return_v = BitConverter.ToString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 22251, 22283);
                    return return_v;
                }


                string
                f_1222_22251_22310(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 22251, 22310);
                    return return_v;
                }


                int
                f_1222_22499_22530(System.IntPtr
                hglobal)
                {
                    Marshal.FreeHGlobal(hglobal);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 22499, 22530);
                    return 0;
                }


                bool
                f_1222_22666_22720(System.IntPtr
                phCatAdmin, int
                dwFlags)
                {
                    var return_v = NativeMethods.CryptCATAdminReleaseContext(phCatAdmin, (uint)dwFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 22666, 22720);
                    return return_v;
                }


                bool
                f_1222_22743_22780(System.IntPtr
                hObject)
                {
                    var return_v = NativeMethods.CloseHandle(hObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 22743, 22780);
                    return return_v;
                }


                string
                f_1222_23073_23110()
                {
                    var return_v = CatalogStrings.UnableToReadFileToHash;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 23073, 23110);
                    return return_v;
                }


                string
                f_1222_23055_23121(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 23055, 23121);
                    return return_v;
                }


                System.InvalidOperationException
                f_1222_23025_23122(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 23025, 23122);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1222_23009_23187(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 23009, 23187);
                    return return_v;
                }


                int
                f_1222_23206_23248(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 23206, 23248);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1222, 19469, 23308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1222, 19469, 23308);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Dictionary<string, string> GetHashesFromCatalog(string catalogFilePath, WildcardPattern[] excludedPatterns, out int catalogVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1222, 23783, 29172);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 23955, 24044);

                IntPtr
                resultCatalog = f_1222_23978_24043(catalogFilePath, 0, IntPtr.Zero, 1, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 24058, 24103);

                IntPtr
                INVALID_HANDLE_VALUE = f_1222_24088_24102(-1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 24117, 24232);

                Dictionary<string, string>
                catalogHashes = f_1222_24160_24231(f_1222_24191_24230())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 24246, 24265);

                catalogVersion = 0;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 24281, 29124) || true) && (resultCatalog != INVALID_HANDLE_VALUE)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 24281, 29124);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 24400, 24433);

                        IntPtr
                        catAttrInfo = IntPtr.Zero
                        ;
                        {
                            try
                            {
                                do

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 24566, 25425);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 24617, 24698);

                                    catAttrInfo = f_1222_24631_24697(resultCatalog, catAttrInfo);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 24932, 25366) || true) && (catAttrInfo != IntPtr.Zero)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 24932, 25366);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 25020, 25089);

                                        string
                                        relativePath = f_1222_25042_25088(catAttrInfo)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 25119, 25339) || true) && (!f_1222_25124_25158(relativePath))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 25119, 25339);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 25224, 25308);

                                            f_1222_25224_25307(relativePath, string.Empty, excludedPatterns, ref catalogHashes);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 25119, 25339);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 24932, 25366);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 24566, 25425);
                                }
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 24566, 25425) || true) && (catAttrInfo != IntPtr.Zero)
                                );
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1222, 24566, 25425);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1222, 24566, 25425);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 25449, 25499);

                        catalogVersion = f_1222_25466_25498(resultCatalog);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 25523, 25555);

                        IntPtr
                        memberInfo = IntPtr.Zero
                        ;
                        {
                            try
                            {
                                do

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 25684, 28621);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 25735, 25813);

                                    memberInfo = f_1222_25748_25812(resultCatalog, memberInfo);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 25839, 28563) || true) && (memberInfo != IntPtr.Zero)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 25839, 28563);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 25926, 26036);

                                        NativeMethods.CRYPTCATMEMBER
                                        currentMember = f_1222_25971_26035(memberInfo)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 26066, 26199);

                                        NativeMethods.SIP_INDIRECT_DATA
                                        pIndirectData = f_1222_26114_26198(currentMember.pIndirectData)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 26482, 28536) || true) && (!((catalogVersion == 2) && (DynAbs.Tracing.TraceSender.Expression_True(1222, 26488, 26619) && (f_1222_26514_26618(pIndirectData.DigestAlgorithm.pszObjId, f_1222_26560_26581(f_1222_26560_26575("SHA1")), StringComparison.OrdinalIgnoreCase)))))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 26482, 28536);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 26686, 26721);

                                            string
                                            relativePath = string.Empty
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 26755, 26791);

                                            IntPtr
                                            memberAttrInfo = IntPtr.Zero
                                            ;
                                            {
                                                try
                                                {
                                                    do

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 26825, 27582);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 26900, 26996);

                                                        memberAttrInfo = f_1222_26917_26995(resultCatalog, memberInfo, memberAttrInfo);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 27036, 27475) || true) && (memberAttrInfo != IntPtr.Zero)
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 27036, 27475);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 27151, 27216);

                                                            relativePath = f_1222_27166_27215(memberAttrInfo);

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 27258, 27436) || true) && (!f_1222_27263_27297(relativePath))
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 27258, 27436);
                                                                DynAbs.Tracing.TraceSender.TraceBreak(1222, 27387, 27393);

                                                                break;
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 27258, 27436);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 27036, 27475);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 26825, 27582);
                                                    }
                                                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 26825, 27582) || true) && (memberAttrInfo != IntPtr.Zero)
                                                    );
                                                }
                                                catch (System.Exception)
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1222, 26825, 27582);
                                                    throw;
                                                }
                                                finally
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1222, 26825, 27582);
                                                }
                                            }
                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 27925, 28367) || true) && (f_1222_27929_27963(relativePath))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 27925, 28367);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 28037, 28251);

                                                ErrorRecord
                                                errorRecord = f_1222_28063_28250(f_1222_28079_28184(f_1222_28109_28183(f_1222_28127_28165(), catalogFilePath)), "UnableToOpenCatalogFile", ErrorCategory.InvalidOperation, null)
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 28289, 28332);

                                                f_1222_28289_28331(_cmdlet, errorRecord);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 27925, 28367);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 28403, 28505);

                                            f_1222_28403_28504(relativePath, currentMember.pwszReferenceTag, excludedPatterns, ref catalogHashes);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 26482, 28536);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 25839, 28563);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 25684, 28621);
                                }
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 25684, 28621) || true) && (memberInfo != IntPtr.Zero)
                                );
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1222, 25684, 28621);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1222, 25684, 28621);
                            }
                        }
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1222, 28658, 28768);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 28706, 28749);

                        f_1222_28706_28748(resultCatalog);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1222, 28658, 28768);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 24281, 29124);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 24281, 29124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 28834, 29048);

                    ErrorRecord
                    errorRecord = f_1222_28860_29047(f_1222_28876_28981(f_1222_28906_28980(f_1222_28924_28962(), catalogFilePath)), "UnableToOpenCatalogFile", ErrorCategory.InvalidOperation, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 29066, 29109);

                    f_1222_29066_29108(_cmdlet, errorRecord);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 24281, 29124);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 29140, 29161);

                return catalogHashes;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1222, 23783, 29172);

                System.IntPtr
                f_1222_23978_24043(string
                pwszFilePath, int
                fdwOpenFlags, System.IntPtr
                hProv, int
                dwPublicVersion, int
                dwEncodingType)
                {
                    var return_v = NativeMethods.CryptCATOpen(pwszFilePath, (uint)fdwOpenFlags, hProv, (uint)dwPublicVersion, (uint)dwEncodingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 23978, 24043);
                    return return_v;
                }


                System.IntPtr
                f_1222_24088_24102(int
                value)
                {
                    var return_v = new System.IntPtr(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 24088, 24102);
                    return return_v;
                }


                System.StringComparer
                f_1222_24191_24230()
                {
                    var return_v = StringComparer.CurrentCultureIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 24191, 24230);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1222_24160_24231(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 24160, 24231);
                    return return_v;
                }


                System.IntPtr
                f_1222_24631_24697(System.IntPtr
                hCatalog, System.IntPtr
                pPrevAttr)
                {
                    var return_v = NativeMethods.CryptCATEnumerateCatAttr(hCatalog, pPrevAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 24631, 24697);
                    return return_v;
                }


                string
                f_1222_25042_25088(System.IntPtr
                memberAttrInfo)
                {
                    var return_v = ProcessFilePathAttributeInCatalog(memberAttrInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 25042, 25088);
                    return return_v;
                }


                bool
                f_1222_25124_25158(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 25124, 25158);
                    return return_v;
                }


                int
                f_1222_25224_25307(string
                relativePath, string
                fileHash, System.Management.Automation.WildcardPattern[]
                excludedPatterns, ref System.Collections.Generic.Dictionary<string, string>
                catalogHashes)
                {
                    ProcessCatalogFile(relativePath, fileHash, excludedPatterns, ref catalogHashes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 25224, 25307);
                    return 0;
                }


                int
                f_1222_25466_25498(System.IntPtr
                catalogHandle)
                {
                    var return_v = GetCatalogVersion(catalogHandle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 25466, 25498);
                    return return_v;
                }


                System.IntPtr
                f_1222_25748_25812(System.IntPtr
                hCatalog, System.IntPtr
                pPrevMember)
                {
                    var return_v = NativeMethods.CryptCATEnumerateMember(hCatalog, pPrevMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 25748, 25812);
                    return return_v;
                }


                System.Management.Automation.Security.NativeMethods.CRYPTCATMEMBER
                f_1222_25971_26035(System.IntPtr
                ptr)
                {
                    var return_v = Marshal.PtrToStructure<NativeMethods.CRYPTCATMEMBER>(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 25971, 26035);
                    return return_v;
                }


                System.Management.Automation.Security.NativeMethods.SIP_INDIRECT_DATA
                f_1222_26114_26198(System.IntPtr
                ptr)
                {
                    var return_v = Marshal.PtrToStructure<NativeMethods.SIP_INDIRECT_DATA>(ptr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 26114, 26198);
                    return return_v;
                }


                System.Security.Cryptography.Oid
                f_1222_26560_26575(string
                oid)
                {
                    var return_v = new System.Security.Cryptography.Oid(oid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 26560, 26575);
                    return return_v;
                }


                string
                f_1222_26560_26581(System.Security.Cryptography.Oid
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 26560, 26581);
                    return return_v;
                }


                bool
                f_1222_26514_26618(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 26514, 26618);
                    return return_v;
                }


                System.IntPtr
                f_1222_26917_26995(System.IntPtr
                hCatalog, System.IntPtr
                pCatMember, System.IntPtr
                pPrevAttr)
                {
                    var return_v = NativeMethods.CryptCATEnumerateAttr(hCatalog, pCatMember, pPrevAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 26917, 26995);
                    return return_v;
                }


                string
                f_1222_27166_27215(System.IntPtr
                memberAttrInfo)
                {
                    var return_v = ProcessFilePathAttributeInCatalog(memberAttrInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 27166, 27215);
                    return return_v;
                }


                bool
                f_1222_27263_27297(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 27263, 27297);
                    return return_v;
                }


                bool
                f_1222_27929_27963(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 27929, 27963);
                    return return_v;
                }


                string
                f_1222_28127_28165()
                {
                    var return_v = CatalogStrings.UnableToOpenCatalogFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 28127, 28165);
                    return return_v;
                }


                string
                f_1222_28109_28183(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 28109, 28183);
                    return return_v;
                }


                System.InvalidOperationException
                f_1222_28079_28184(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 28079, 28184);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1222_28063_28250(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 28063, 28250);
                    return return_v;
                }


                int
                f_1222_28289_28331(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 28289, 28331);
                    return 0;
                }


                int
                f_1222_28403_28504(string
                relativePath, string
                fileHash, System.Management.Automation.WildcardPattern[]
                excludedPatterns, ref System.Collections.Generic.Dictionary<string, string>
                catalogHashes)
                {
                    ProcessCatalogFile(relativePath, fileHash, excludedPatterns, ref catalogHashes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 28403, 28504);
                    return 0;
                }


                bool
                f_1222_28706_28748(System.IntPtr
                hCatalog)
                {
                    var return_v = NativeMethods.CryptCATClose(hCatalog);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 28706, 28748);
                    return return_v;
                }


                string
                f_1222_28924_28962()
                {
                    var return_v = CatalogStrings.UnableToOpenCatalogFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 28924, 28962);
                    return return_v;
                }


                string
                f_1222_28906_28980(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 28906, 28980);
                    return return_v;
                }


                System.InvalidOperationException
                f_1222_28876_28981(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 28876, 28981);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1222_28860_29047(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 28860, 29047);
                    return return_v;
                }


                int
                f_1222_29066_29108(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 29066, 29108);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1222, 23783, 29172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1222, 23783, 29172);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void ProcessCatalogFile(string relativePath, string fileHash, WildcardPattern[] excludedPatterns, ref Dictionary<string, string> catalogHashes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1222, 29680, 30608);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 29919, 30026);

                f_1222_29919_30025(            // Found the attribute we are looking for
                            _cmdlet, f_1222_29940_30024(f_1222_29958_29999(), relativePath, fileHash));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 30130, 30597) || true) && (!f_1222_30135_30209(f_1222_30157_30190((f_1222_30158_30184(relativePath))), excludedPatterns))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 30130, 30597);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 30315, 30357);

                    f_1222_30315_30356(                // Add relativePath mapping to hashvalue for each file
                                    catalogHashes, relativePath, fileHash);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 30130, 30597);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 30130, 30597);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 30484, 30582);

                    f_1222_30484_30581(                // Verbose about skipping file from catalog
                                    _cmdlet, f_1222_30505_30580(f_1222_30523_30565(), relativePath));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 30130, 30597);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1222, 29680, 30608);

                string
                f_1222_29958_29999()
                {
                    var return_v = CatalogStrings.FoundFileHashInCatalogItem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 29958, 29999);
                    return return_v;
                }


                string
                f_1222_29940_30024(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 29940, 30024);
                    return return_v;
                }


                int
                f_1222_29919_30025(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 29919, 30025);
                    return 0;
                }


                System.IO.FileInfo
                f_1222_30158_30184(string
                fileName)
                {
                    var return_v = new System.IO.FileInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 30158, 30184);
                    return return_v;
                }


                string
                f_1222_30157_30190(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 30157, 30190);
                    return return_v;
                }


                bool
                f_1222_30135_30209(string
                filename, System.Management.Automation.WildcardPattern[]
                excludedPatterns)
                {
                    var return_v = CheckExcludedCriteria(filename, excludedPatterns);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 30135, 30209);
                    return return_v;
                }


                int
                f_1222_30315_30356(System.Collections.Generic.Dictionary<string, string>
                this_param, string
                key, string
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 30315, 30356);
                    return 0;
                }


                string
                f_1222_30523_30565()
                {
                    var return_v = CatalogStrings.SkipValidationOfCatalogFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 30523, 30565);
                    return return_v;
                }


                string
                f_1222_30505_30580(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 30505, 30580);
                    return return_v;
                }


                int
                f_1222_30484_30581(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 30484, 30581);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1222, 29680, 30608);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1222, 29680, 30608);
            }
        }

        internal static void ProcessPathFile(FileInfo fileToHash, DirectoryInfo dirInfo, string hashAlgorithm, WildcardPattern[] excludedPatterns, ref Dictionary<string, string> fileHashes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1222, 31179, 33129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 31385, 31420);

                string
                relativePath = string.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 31434, 31464);

                string
                exclude = string.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 31480, 31925) || true) && (dirInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 31480, 31925);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 31642, 31728);

                    relativePath = f_1222_31657_31727(f_1222_31657_31711(f_1222_31657_31676(fileToHash), f_1222_31687_31710(f_1222_31687_31703(dirInfo))), '\\');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 31746, 31772);

                    exclude = f_1222_31756_31771(fileToHash);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 31480, 31925);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 31480, 31925);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 31838, 31869);

                    relativePath = f_1222_31853_31868(fileToHash);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 31887, 31910);

                    exclude = relativePath;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 31480, 31925);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 31941, 33118) || true) && (!f_1222_31946_31994(exclude, excludedPatterns))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 31941, 33118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 32028, 32059);

                    string
                    fileHash = string.Empty
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 32079, 32231) || true) && (f_1222_32083_32100(fileToHash) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 32079, 32231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 32147, 32212);

                        fileHash = f_1222_32158_32211(f_1222_32176_32195(fileToHash), hashAlgorithm);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 32079, 32231);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 32251, 32884) || true) && (!f_1222_32256_32292(fileHashes, relativePath))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 32251, 32884);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 32334, 32373);

                        f_1222_32334_32372(fileHashes, relativePath, fileHash);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 32395, 32491);

                        f_1222_32395_32490(_cmdlet, f_1222_32416_32489(f_1222_32434_32464(), relativePath, fileHash));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 32251, 32884);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 32251, 32884);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 32573, 32800);

                        ErrorRecord
                        errorRecord = f_1222_32599_32799(f_1222_32615_32725(f_1222_32645_32724(f_1222_32663_32709(), relativePath)), "FoundDuplicateFilesRelativePath", ErrorCategory.InvalidOperation, null)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 32822, 32865);

                        f_1222_32822_32864(_cmdlet, errorRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 32251, 32884);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 31941, 33118);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 31941, 33118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 33008, 33103);

                    f_1222_33008_33102(                // Verbose about skipping file from path
                                    _cmdlet, f_1222_33029_33101(f_1222_33047_33086(), relativePath));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 31941, 33118);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1222, 31179, 33129);

                string
                f_1222_31657_31676(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 31657, 31676);
                    return return_v;
                }


                string
                f_1222_31687_31703(System.IO.DirectoryInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 31687, 31703);
                    return return_v;
                }


                int
                f_1222_31687_31710(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 31687, 31710);
                    return return_v;
                }


                string
                f_1222_31657_31711(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 31657, 31711);
                    return return_v;
                }


                string
                f_1222_31657_31727(string
                this_param, char
                trimChar)
                {
                    var return_v = this_param.TrimStart(trimChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 31657, 31727);
                    return return_v;
                }


                string
                f_1222_31756_31771(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 31756, 31771);
                    return return_v;
                }


                string
                f_1222_31853_31868(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 31853, 31868);
                    return return_v;
                }


                bool
                f_1222_31946_31994(string
                filename, System.Management.Automation.WildcardPattern[]
                excludedPatterns)
                {
                    var return_v = CheckExcludedCriteria(filename, excludedPatterns);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 31946, 31994);
                    return return_v;
                }


                long
                f_1222_32083_32100(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 32083, 32100);
                    return return_v;
                }


                string
                f_1222_32176_32195(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 32176, 32195);
                    return return_v;
                }


                string
                f_1222_32158_32211(string
                filePath, string
                hashAlgorithm)
                {
                    var return_v = CalculateFileHash(filePath, hashAlgorithm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 32158, 32211);
                    return return_v;
                }


                bool
                f_1222_32256_32292(System.Collections.Generic.Dictionary<string, string>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 32256, 32292);
                    return return_v;
                }


                int
                f_1222_32334_32372(System.Collections.Generic.Dictionary<string, string>
                this_param, string
                key, string
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 32334, 32372);
                    return 0;
                }


                string
                f_1222_32434_32464()
                {
                    var return_v = CatalogStrings.FoundFileInPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 32434, 32464);
                    return return_v;
                }


                string
                f_1222_32416_32489(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 32416, 32489);
                    return return_v;
                }


                int
                f_1222_32395_32490(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 32395, 32490);
                    return 0;
                }


                string
                f_1222_32663_32709()
                {
                    var return_v = CatalogStrings.FoundDuplicateFilesRelativePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 32663, 32709);
                    return return_v;
                }


                string
                f_1222_32645_32724(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 32645, 32724);
                    return return_v;
                }


                System.InvalidOperationException
                f_1222_32615_32725(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 32615, 32725);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1222_32599_32799(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 32599, 32799);
                    return return_v;
                }


                int
                f_1222_32822_32864(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 32822, 32864);
                    return 0;
                }


                string
                f_1222_33047_33086()
                {
                    var return_v = CatalogStrings.SkipValidationOfPathFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 33047, 33086);
                    return return_v;
                }


                string
                f_1222_33029_33101(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 33029, 33101);
                    return return_v;
                }


                int
                f_1222_33008_33102(System.Management.Automation.PSCmdlet
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 33008, 33102);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1222, 31179, 33129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1222, 31179, 33129);
            }
        }

        internal static Dictionary<string, string> CalculateHashesFromPath(Collection<string> folderPaths, string catalogFilePath, string hashAlgorithm, WildcardPattern[] excludedPatterns)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1222, 33654, 35078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 33909, 34021);

                Dictionary<string, string>
                fileHashes = f_1222_33949_34020(f_1222_33980_34019())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 34037, 35033);
                    foreach (string folderPath in f_1222_34067_34078_I(folderPaths))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 34037, 35033);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 34112, 35018) || true) && (f_1222_34116_34154(folderPath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 34112, 35018);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 34196, 34290);

                            var
                            directoryItems = f_1222_34217_34289(folderPath, "*.*", SearchOption.AllDirectories)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 34312, 34781);
                                foreach (string fileItem in f_1222_34340_34354_I(directoryItems))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 34312, 34781);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 34490, 34610) || true) && (f_1222_34494_34570(fileItem, catalogFilePath, StringComparison.OrdinalIgnoreCase))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 34490, 34610);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 34601, 34610);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 34490, 34610);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 34638, 34758);

                                    f_1222_34638_34757(f_1222_34654_34676(fileItem), f_1222_34678_34707(folderPath), hashAlgorithm, excludedPatterns, ref fileHashes);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 34312, 34781);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1222, 1, 470);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1222, 1, 470);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 34112, 35018);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 34112, 35018);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 34823, 35018) || true) && (f_1222_34827_34860(folderPath))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 34823, 35018);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 34902, 34999);

                                f_1222_34902_34998(f_1222_34918_34942(folderPath), null, hashAlgorithm, excludedPatterns, ref fileHashes);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 34823, 35018);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 34112, 35018);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 34037, 35033);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1222, 1, 997);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1222, 1, 997);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 35049, 35067);

                return fileHashes;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1222, 33654, 35078);

                System.StringComparer
                f_1222_33980_34019()
                {
                    var return_v = StringComparer.CurrentCultureIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 33980, 34019);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1222_33949_34020(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 33949, 34020);
                    return return_v;
                }


                bool
                f_1222_34116_34154(string
                path)
                {
                    var return_v = System.IO.Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 34116, 34154);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1222_34217_34289(string
                path, string
                searchPattern, System.IO.SearchOption
                searchOption)
                {
                    var return_v = Directory.EnumerateFiles(path, searchPattern, searchOption);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 34217, 34289);
                    return return_v;
                }


                bool
                f_1222_34494_34570(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 34494, 34570);
                    return return_v;
                }


                System.IO.FileInfo
                f_1222_34654_34676(string
                fileName)
                {
                    var return_v = new System.IO.FileInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 34654, 34676);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_1222_34678_34707(string
                path)
                {
                    var return_v = new System.IO.DirectoryInfo(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 34678, 34707);
                    return return_v;
                }


                int
                f_1222_34638_34757(System.IO.FileInfo
                fileToHash, System.IO.DirectoryInfo
                dirInfo, string
                hashAlgorithm, System.Management.Automation.WildcardPattern[]
                excludedPatterns, ref System.Collections.Generic.Dictionary<string, string>
                fileHashes)
                {
                    ProcessPathFile(fileToHash, dirInfo, hashAlgorithm, excludedPatterns, ref fileHashes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 34638, 34757);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1222_34340_34354_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 34340, 34354);
                    return return_v;
                }


                bool
                f_1222_34827_34860(string
                path)
                {
                    var return_v = System.IO.File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 34827, 34860);
                    return return_v;
                }


                System.IO.FileInfo
                f_1222_34918_34942(string
                fileName)
                {
                    var return_v = new System.IO.FileInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 34918, 34942);
                    return return_v;
                }


                int
                f_1222_34902_34998(System.IO.FileInfo
                fileToHash, System.IO.DirectoryInfo
                dirInfo, string
                hashAlgorithm, System.Management.Automation.WildcardPattern[]
                excludedPatterns, ref System.Collections.Generic.Dictionary<string, string>
                fileHashes)
                {
                    ProcessPathFile(fileToHash, dirInfo, hashAlgorithm, excludedPatterns, ref fileHashes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 34902, 34998);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1222_34067_34078_I(System.Collections.ObjectModel.Collection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 34067, 34078);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1222, 33654, 35078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1222, 33654, 35078);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CompareDictionaries(Dictionary<string, string> catalogItems, Dictionary<string, string> pathItems)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1222, 35403, 37093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 35547, 35566);

                bool
                Status = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 35582, 35645);

                List<string>
                relativePathsFromFolder = f_1222_35621_35644(f_1222_35621_35635(pathItems))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 35659, 35726);

                List<string>
                relativePathsFromCatalog = f_1222_35699_35725(f_1222_35699_35716(catalogItems))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 35927, 36074);

                List<string>
                relativePathsNotInFolder = f_1222_35967_36073(f_1222_35967_36064(relativePathsFromFolder, relativePathsFromCatalog, f_1222_36024_36063()))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 36088, 36236);

                List<string>
                relativePathsNotInCatalog = f_1222_36129_36235(f_1222_36129_36226(relativePathsFromCatalog, relativePathsFromFolder, f_1222_36186_36225()))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 36297, 36444) || true) && ((f_1222_36302_36332(relativePathsNotInFolder) != 0) || (DynAbs.Tracing.TraceSender.Expression_False(1222, 36301, 36380) || (f_1222_36343_36374(relativePathsNotInCatalog) != 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 36297, 36444);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 36414, 36429);

                    Status = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 36297, 36444);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 36460, 37052);
                    foreach (KeyValuePair<string, string> item in f_1222_36506_36518_I(catalogItems))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 36460, 37052);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 36552, 36609);

                        string
                        catalogHashValue = (string)f_1222_36586_36608(catalogItems, item.Key)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 36627, 37037) || true) && (f_1222_36631_36662(pathItems, item.Key))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 36627, 37037);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 36704, 36757);

                            string
                            folderHashValue = (string)f_1222_36737_36756(pathItems, item.Key)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 36779, 37018) || true) && (f_1222_36783_36823(folderHashValue, catalogHashValue))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 36779, 37018);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 36873, 36882);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 36779, 37018);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 36779, 37018);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 36980, 36995);

                                Status = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 36779, 37018);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 36627, 37037);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 36460, 37052);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1222, 1, 593);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1222, 1, 593);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 37068, 37082);

                return Status;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1222, 35403, 37093);

                System.Collections.Generic.Dictionary<string, string>.KeyCollection
                f_1222_35621_35635(System.Collections.Generic.Dictionary<string, string>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 35621, 35635);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1222_35621_35644(System.Collections.Generic.Dictionary<string, string>.KeyCollection
                source)
                {
                    var return_v = source.ToList<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 35621, 35644);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>.KeyCollection
                f_1222_35699_35716(System.Collections.Generic.Dictionary<string, string>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 35699, 35716);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1222_35699_35725(System.Collections.Generic.Dictionary<string, string>.KeyCollection
                source)
                {
                    var return_v = source.ToList<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 35699, 35725);
                    return return_v;
                }


                System.StringComparer
                f_1222_36024_36063()
                {
                    var return_v = StringComparer.CurrentCultureIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 36024, 36063);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1222_35967_36064(System.Collections.Generic.List<string>
                first, System.Collections.Generic.List<string>
                second, System.StringComparer
                comparer)
                {
                    var return_v = first.Except<string>((System.Collections.Generic.IEnumerable<string>)second, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 35967, 36064);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1222_35967_36073(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.ToList<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 35967, 36073);
                    return return_v;
                }


                System.StringComparer
                f_1222_36186_36225()
                {
                    var return_v = StringComparer.CurrentCultureIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 36186, 36225);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1222_36129_36226(System.Collections.Generic.List<string>
                first, System.Collections.Generic.List<string>
                second, System.StringComparer
                comparer)
                {
                    var return_v = first.Except<string>((System.Collections.Generic.IEnumerable<string>)second, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 36129, 36226);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1222_36129_36235(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.ToList<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 36129, 36235);
                    return return_v;
                }


                int
                f_1222_36302_36332(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 36302, 36332);
                    return return_v;
                }


                int
                f_1222_36343_36374(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 36343, 36374);
                    return return_v;
                }


                string
                f_1222_36586_36608(System.Collections.Generic.Dictionary<string, string>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 36586, 36608);
                    return return_v;
                }


                bool
                f_1222_36631_36662(System.Collections.Generic.Dictionary<string, string>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 36631, 36662);
                    return return_v;
                }


                string
                f_1222_36737_36756(System.Collections.Generic.Dictionary<string, string>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 36737, 36756);
                    return return_v;
                }


                bool
                f_1222_36783_36823(string
                this_param, string
                value)
                {
                    var return_v = this_param.Equals(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 36783, 36823);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1222_36506_36518_I(System.Collections.Generic.Dictionary<string, string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 36506, 36518);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1222, 35403, 37093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1222, 35403, 37093);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CatalogInformation ValidateCatalog(PSCmdlet cmdlet, Collection<string> catalogFolders, string catalogFilePath, WildcardPattern[] excludedPatterns)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1222, 37559, 39004);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 37746, 37763);

                _cmdlet = cmdlet;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 37777, 37800);

                int
                catalogVersion = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 37814, 37933);

                Dictionary<string, string>
                catalogHashes = f_1222_37857_37932(catalogFilePath, excludedPatterns, out catalogVersion)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 37947, 38010);

                string
                hashAlgorithm = f_1222_37970_38009(catalogVersion)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 38026, 38965) || true) && (!f_1222_38031_38066(hashAlgorithm))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 38026, 38965);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 38100, 38230);

                    Dictionary<string, string>
                    fileHashes = f_1222_38140_38229(catalogFolders, catalogFilePath, hashAlgorithm, excludedPatterns)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 38248, 38302);

                    CatalogInformation
                    catalog = f_1222_38277_38301()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 38320, 38357);

                    catalog.CatalogItems = catalogHashes;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 38375, 38406);

                    catalog.PathItems = fileHashes;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 38424, 38485);

                    bool
                    status = f_1222_38438_38484(catalogHashes, fileHashes)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 38503, 38769) || true) && (status == true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 38503, 38769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 38563, 38610);

                        catalog.Status = CatalogValidationStatus.Valid;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 38503, 38769);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 38503, 38769);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 38692, 38750);

                        catalog.Status = CatalogValidationStatus.ValidationFailed;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 38503, 38769);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 38789, 38827);

                    catalog.HashAlgorithm = hashAlgorithm;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 38845, 38917);

                    catalog.Signature = f_1222_38865_38916(catalogFilePath, null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 38935, 38950);

                    return catalog;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 38026, 38965);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 38981, 38993);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1222, 37559, 39004);

                System.Collections.Generic.Dictionary<string, string>
                f_1222_37857_37932(string
                catalogFilePath, System.Management.Automation.WildcardPattern[]
                excludedPatterns, out int
                catalogVersion)
                {
                    var return_v = GetHashesFromCatalog(catalogFilePath, excludedPatterns, out catalogVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 37857, 37932);
                    return return_v;
                }


                string
                f_1222_37970_38009(int
                catalogVersion)
                {
                    var return_v = GetCatalogHashAlgorithm(catalogVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 37970, 38009);
                    return return_v;
                }


                bool
                f_1222_38031_38066(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 38031, 38066);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1222_38140_38229(System.Collections.ObjectModel.Collection<string>
                folderPaths, string
                catalogFilePath, string
                hashAlgorithm, System.Management.Automation.WildcardPattern[]
                excludedPatterns)
                {
                    var return_v = CalculateHashesFromPath(folderPaths, catalogFilePath, hashAlgorithm, excludedPatterns);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 38140, 38229);
                    return return_v;
                }


                System.Management.Automation.CatalogInformation
                f_1222_38277_38301()
                {
                    var return_v = new System.Management.Automation.CatalogInformation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 38277, 38301);
                    return return_v;
                }


                bool
                f_1222_38438_38484(System.Collections.Generic.Dictionary<string, string>
                catalogItems, System.Collections.Generic.Dictionary<string, string>
                pathItems)
                {
                    var return_v = CompareDictionaries(catalogItems, pathItems);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 38438, 38484);
                    return return_v;
                }


                System.Management.Automation.Signature
                f_1222_38865_38916(string
                fileName, string
                fileContent)
                {
                    var return_v = SignatureHelper.GetSignature(fileName, fileContent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 38865, 38916);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1222, 37559, 39004);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1222, 37559, 39004);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CheckExcludedCriteria(string filename, WildcardPattern[] excludedPatterns)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1222, 39291, 39763);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 39411, 39723) || true) && (excludedPatterns != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 39411, 39723);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 39473, 39708);
                        foreach (WildcardPattern patternItem in f_1222_39513_39529_I(excludedPatterns))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 39473, 39708);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 39571, 39689) || true) && (f_1222_39575_39604(patternItem, filename))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 39571, 39689);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 39654, 39666);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 39571, 39689);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 39473, 39708);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1222, 1, 236);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1222, 1, 236);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 39411, 39723);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 39739, 39752);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1222, 39291, 39763);

                bool
                f_1222_39575_39604(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 39575, 39604);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern[]
                f_1222_39513_39529_I(System.Management.Automation.WildcardPattern[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 39513, 39529);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1222, 39291, 39763);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1222, 39291, 39763);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ParseErrorCallback(DWORD dwErrorArea, DWORD dwLocalError, string pwszLine)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1222, 39882, 42638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 40001, 40294);

                switch (dwErrorArea)
                {

                    case NativeConstants.CRYPTCAT_E_AREA_HEADER:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 40001, 40294);
                        DynAbs.Tracing.TraceSender.TraceBreak(1222, 40099, 40105);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 40001, 40294);

                    case NativeConstants.CRYPTCAT_E_AREA_MEMBER:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 40001, 40294);
                        DynAbs.Tracing.TraceSender.TraceBreak(1222, 40168, 40174);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 40001, 40294);

                    case NativeConstants.CRYPTCAT_E_AREA_ATTRIBUTE:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 40001, 40294);
                        DynAbs.Tracing.TraceSender.TraceBreak(1222, 40240, 40246);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 40001, 40294);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 40001, 40294);
                        DynAbs.Tracing.TraceSender.TraceBreak(1222, 40273, 40279);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 40001, 40294);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 40310, 42627);

                switch (dwLocalError)
                {

                    case NativeConstants.CRYPTCAT_E_CDF_MEMBER_FILE_PATH:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 40310, 42627);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 40466, 40711);

                            ErrorRecord
                            errorRecord = f_1222_40492_40710(f_1222_40508_40625(f_1222_40538_40624(f_1222_40556_40613(), pwszLine)), "UnableToFindFileNameOrPathForCatalogMember", ErrorCategory.InvalidOperation, null)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 40737, 40780);

                            f_1222_40737_40779(_cmdlet, errorRecord);
                            DynAbs.Tracing.TraceSender.TraceBreak(1222, 40806, 40812);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 40310, 42627);

                    case NativeConstants.CRYPTCAT_E_CDF_MEMBER_INDIRECTDATA:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 40310, 42627);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 40958, 41163);

                            ErrorRecord
                            errorRecord = f_1222_40984_41162(f_1222_41000_41097(f_1222_41030_41096(f_1222_41048_41085(), pwszLine)), "UnableToCreateFileHash", ErrorCategory.InvalidOperation, null)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 41189, 41232);

                            f_1222_41189_41231(_cmdlet, errorRecord);
                            DynAbs.Tracing.TraceSender.TraceBreak(1222, 41258, 41264);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 40310, 42627);

                    case NativeConstants.CRYPTCAT_E_CDF_MEMBER_FILENOTFOUND:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 40310, 42627);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 41410, 41615);

                            ErrorRecord
                            errorRecord = f_1222_41436_41614(f_1222_41452_41549(f_1222_41482_41548(f_1222_41500_41537(), pwszLine)), "UnableToFindFileToHash", ErrorCategory.InvalidOperation, null)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 41641, 41684);

                            f_1222_41641_41683(_cmdlet, errorRecord);
                            DynAbs.Tracing.TraceSender.TraceBreak(1222, 41710, 41716);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 40310, 42627);

                    case NativeConstants.CRYPTCAT_E_CDF_BAD_GUID_CONV:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 40310, 42627);
                        DynAbs.Tracing.TraceSender.TraceBreak(1222, 41808, 41814);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 40310, 42627);

                    case NativeConstants.CRYPTCAT_E_CDF_ATTR_TYPECOMBO:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 40310, 42627);
                        DynAbs.Tracing.TraceSender.TraceBreak(1222, 41884, 41890);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 40310, 42627);

                    case NativeConstants.CRYPTCAT_E_CDF_ATTR_TOOFEWVALUES:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 40310, 42627);
                        DynAbs.Tracing.TraceSender.TraceBreak(1222, 41963, 41969);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 40310, 42627);

                    case NativeConstants.CRYPTCAT_E_CDF_UNSUPPORTED:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 40310, 42627);
                        DynAbs.Tracing.TraceSender.TraceBreak(1222, 42036, 42042);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 40310, 42627);

                    case NativeConstants.CRYPTCAT_E_CDF_DUPLICATE:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 40310, 42627);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 42155, 42382);

                            ErrorRecord
                            errorRecord = f_1222_42181_42381(f_1222_42197_42305(f_1222_42227_42304(f_1222_42245_42293(), pwszLine)), "FoundDuplicateFileMemberInCatalog", ErrorCategory.InvalidOperation, null)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 42408, 42451);

                            f_1222_42408_42450(_cmdlet, errorRecord);
                            DynAbs.Tracing.TraceSender.TraceBreak(1222, 42477, 42483);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 40310, 42627);

                    case NativeConstants.CRYPTCAT_E_CDF_TAGNOTFOUND:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 40310, 42627);
                        DynAbs.Tracing.TraceSender.TraceBreak(1222, 42573, 42579);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 40310, 42627);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1222, 40310, 42627);
                        DynAbs.Tracing.TraceSender.TraceBreak(1222, 42606, 42612);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1222, 40310, 42627);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1222, 39882, 42638);

                string
                f_1222_40556_40613()
                {
                    var return_v = CatalogStrings.UnableToFindFileNameOrPathForCatalogMember;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 40556, 40613);
                    return return_v;
                }


                string
                f_1222_40538_40624(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 40538, 40624);
                    return return_v;
                }


                System.InvalidOperationException
                f_1222_40508_40625(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 40508, 40625);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1222_40492_40710(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 40492, 40710);
                    return return_v;
                }


                int
                f_1222_40737_40779(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 40737, 40779);
                    return 0;
                }


                string
                f_1222_41048_41085()
                {
                    var return_v = CatalogStrings.UnableToCreateFileHash;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 41048, 41085);
                    return return_v;
                }


                string
                f_1222_41030_41096(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 41030, 41096);
                    return return_v;
                }


                System.InvalidOperationException
                f_1222_41000_41097(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 41000, 41097);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1222_40984_41162(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 40984, 41162);
                    return return_v;
                }


                int
                f_1222_41189_41231(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 41189, 41231);
                    return 0;
                }


                string
                f_1222_41500_41537()
                {
                    var return_v = CatalogStrings.UnableToFindFileToHash;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 41500, 41537);
                    return return_v;
                }


                string
                f_1222_41482_41548(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 41482, 41548);
                    return return_v;
                }


                System.InvalidOperationException
                f_1222_41452_41549(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 41452, 41549);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1222_41436_41614(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 41436, 41614);
                    return return_v;
                }


                int
                f_1222_41641_41683(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 41641, 41683);
                    return 0;
                }


                string
                f_1222_42245_42293()
                {
                    var return_v = CatalogStrings.FoundDuplicateFileMemberInCatalog;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1222, 42245, 42293);
                    return return_v;
                }


                string
                f_1222_42227_42304(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 42227, 42304);
                    return return_v;
                }


                System.InvalidOperationException
                f_1222_42197_42305(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 42197, 42305);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1222_42181_42381(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 42181, 42381);
                    return return_v;
                }


                int
                f_1222_42408_42450(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1222, 42408, 42450);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1222, 39882, 42638);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1222, 39882, 42638);
            }
        }

        static CatalogHelper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1222, 2154, 42645);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 2292, 2313);
            catalogVersion1 = 256;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 2412, 2433);
            catalogVersion2 = 512;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 2525, 2551);
            HashAlgorithmSHA1 = "SHA1";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 2584, 2614);
            HashAlgorithmSHA256 = "SHA256";
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1222, 2649, 2663);
            _cmdlet = null;
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1222, 2154, 42645);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1222, 2154, 42645);
        }

    }
}

