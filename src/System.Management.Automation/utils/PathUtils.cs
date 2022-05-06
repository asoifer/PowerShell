// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using System.Management.Automation.Internal;
using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    internal static class PathUtils
    {
        internal static void MasterStreamOpen(
                    PSCmdlet cmdlet,
                    string filePath,
                    string encoding,
                    bool defaultEncoding,
                    bool Append,
                    bool Force,
                    bool NoClobber,
                    out FileStream fileStream,
                    out StreamWriter streamWriter,
                    out FileInfo readOnlyFileInfo,
                    bool isLiteralPath
                    )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1031, 1884, 2594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 2327, 2400);

                Encoding
                resolvedEncoding = f_1031_2355_2399(cmdlet, encoding)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 2416, 2583);

                f_1031_2416_2582(cmdlet, filePath, resolvedEncoding, defaultEncoding, Append, Force, NoClobber, out fileStream, out streamWriter, out readOnlyFileInfo, isLiteralPath);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1031, 1884, 2594);

                System.Text.Encoding
                f_1031_2355_2399(System.Management.Automation.PSCmdlet
                cmdlet, string
                encoding)
                {
                    var return_v = EncodingConversion.Convert((System.Management.Automation.Cmdlet)cmdlet, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 2355, 2399);
                    return return_v;
                }


                int
                f_1031_2416_2582(System.Management.Automation.PSCmdlet
                cmdlet, string
                filePath, System.Text.Encoding
                resolvedEncoding, bool
                defaultEncoding, bool
                Append, bool
                Force, bool
                NoClobber, out System.IO.FileStream
                fileStream, out System.IO.StreamWriter
                streamWriter, out System.IO.FileInfo
                readOnlyFileInfo, bool
                isLiteralPath)
                {
                    MasterStreamOpen(cmdlet, filePath, resolvedEncoding, defaultEncoding, Append, Force, NoClobber, out fileStream, out streamWriter, out readOnlyFileInfo, isLiteralPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 2416, 2582);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1031, 1884, 2594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1031, 1884, 2594);
            }
        }

        internal static void MasterStreamOpen(
                    PSCmdlet cmdlet,
                    string filePath,
                    Encoding resolvedEncoding,
                    bool defaultEncoding,
                    bool Append,
                    bool Force,
                    bool NoClobber,
                    out FileStream fileStream,
                    out StreamWriter streamWriter,
                    out FileInfo readOnlyFileInfo,
                    bool isLiteralPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1031, 3987, 8534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 4426, 4444);

                fileStream = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 4458, 4478);

                streamWriter = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 4492, 4516);

                readOnlyFileInfo = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 4582, 4653);

                string
                resolvedPath = f_1031_4604_4652(filePath, cmdlet, isLiteralPath)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 4824, 4856);

                    FileMode
                    mode = FileMode.Create
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 4874, 5148) || true) && (Append)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1031, 4874, 5148);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 4926, 4949);

                        mode = FileMode.Append;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1031, 4874, 5148);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1031, 4874, 5148);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 4991, 5148) || true) && (NoClobber)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1031, 4991, 5148);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 5103, 5129);

                            mode = FileMode.CreateNew;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1031, 4991, 5148);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1031, 4874, 5148);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 5168, 5840) || true) && (Force && (DynAbs.Tracing.TraceSender.Expression_True(1031, 5172, 5203) && (Append || (DynAbs.Tracing.TraceSender.Expression_False(1031, 5182, 5202) || !NoClobber))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1031, 5168, 5840);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 5245, 5821) || true) && (f_1031_5249_5274(resolvedPath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1031, 5245, 5821);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 5324, 5368);

                            FileInfo
                            fInfo = f_1031_5341_5367(resolvedPath)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 5394, 5798) || true) && ((f_1031_5399_5415(fInfo) & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1031, 5394, 5798);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 5607, 5632);

                                readOnlyFileInfo = fInfo;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 5724, 5771);

                                fInfo.Attributes &= DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => ~(FileAttributes.ReadOnly), 1031, 5724, 5740);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1031, 5394, 5798);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1031, 5245, 5821);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1031, 5168, 5840);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 6037, 6104);

                    FileShare
                    fileShare = (DynAbs.Tracing.TraceSender.Conditional_F1(1031, 6059, 6064) || ((Force && DynAbs.Tracing.TraceSender.Conditional_F2(1031, 6067, 6086)) || DynAbs.Tracing.TraceSender.Conditional_F3(1031, 6089, 6103))) ? FileShare.ReadWrite : FileShare.Read
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 6193, 6270);

                    fileStream = f_1031_6206_6269(resolvedPath, mode, FileAccess.Write, fileShare);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 6551, 6743) || true) && (defaultEncoding)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1031, 6551, 6743);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 6593, 6637);

                        streamWriter = f_1031_6608_6636(fileStream);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1031, 6551, 6743);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1031, 6551, 6743);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 6681, 6743);

                        streamWriter = f_1031_6696_6742(fileStream, resolvedEncoding);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1031, 6551, 6743);
                    }
                }
                // These are the known exceptions for File.Load and StreamWriter.ctor
                catch (ArgumentException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1031, 6855, 7024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 6962, 7009);

                    f_1031_6962_7008(cmdlet, resolvedPath, e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1031, 6855, 7024);
                }
                catch (IOException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1031, 7038, 7944);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 7092, 7817) || true) && (NoClobber && (DynAbs.Tracing.TraceSender.Expression_True(1031, 7096, 7134) && f_1031_7109_7134(resolvedPath)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1031, 7092, 7817);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 7255, 7383);

                        ErrorRecord
                        errorRecord = f_1031_7281_7382(e, "NoClobber", ErrorCategory.ResourceExists, resolvedPath)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 7405, 7656);

                        errorRecord.ErrorDetails = f_1031_7432_7655(cmdlet, "PathUtilsStrings", "UtilityFileExistsNoClobber", filePath, "NoClobber");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 7756, 7798);

                        f_1031_7756_7797(
                                            // NOTE: this call will throw
                                            cmdlet, errorRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1031, 7092, 7817);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 7882, 7929);

                    f_1031_7882_7928(cmdlet, resolvedPath, e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1031, 7038, 7944);
                }
                catch (UnauthorizedAccessException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1031, 7958, 8137);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 8075, 8122);

                    f_1031_8075_8121(cmdlet, resolvedPath, e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1031, 7958, 8137);
                }
                catch (NotSupportedException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1031, 8151, 8324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 8262, 8309);

                    f_1031_8262_8308(cmdlet, resolvedPath, e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1031, 8151, 8324);
                }
                catch (System.Security.SecurityException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1031, 8338, 8523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 8461, 8508);

                    f_1031_8461_8507(cmdlet, resolvedPath, e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1031, 8338, 8523);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1031, 3987, 8534);

                string
                f_1031_4604_4652(string
                filePath, System.Management.Automation.PSCmdlet
                command, bool
                isLiteralPath)
                {
                    var return_v = ResolveFilePath(filePath, command, isLiteralPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 4604, 4652);
                    return return_v;
                }


                bool
                f_1031_5249_5274(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 5249, 5274);
                    return return_v;
                }


                System.IO.FileInfo
                f_1031_5341_5367(string
                fileName)
                {
                    var return_v = new System.IO.FileInfo(fileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 5341, 5367);
                    return return_v;
                }


                System.IO.FileAttributes
                f_1031_5399_5415(System.IO.FileInfo
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 5399, 5415);
                    return return_v;
                }


                System.IO.FileStream
                f_1031_6206_6269(string
                path, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share)
                {
                    var return_v = new System.IO.FileStream(path, mode, access, share);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 6206, 6269);
                    return return_v;
                }


                System.IO.StreamWriter
                f_1031_6608_6636(System.IO.FileStream
                stream)
                {
                    var return_v = new System.IO.StreamWriter((System.IO.Stream)stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 6608, 6636);
                    return return_v;
                }


                System.IO.StreamWriter
                f_1031_6696_6742(System.IO.FileStream
                stream, System.Text.Encoding
                encoding)
                {
                    var return_v = new System.IO.StreamWriter((System.IO.Stream)stream, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 6696, 6742);
                    return return_v;
                }


                int
                f_1031_6962_7008(System.Management.Automation.PSCmdlet
                cmdlet, string
                filePath, System.ArgumentException
                e)
                {
                    ReportFileOpenFailure((System.Management.Automation.Cmdlet)cmdlet, filePath, (System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 6962, 7008);
                    return 0;
                }


                bool
                f_1031_7109_7134(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 7109, 7134);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1031_7281_7382(System.IO.IOException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 7281, 7382);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1031_7432_7655(System.Management.Automation.PSCmdlet
                cmdlet, string
                baseName, string
                resourceId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ErrorDetails((System.Management.Automation.Cmdlet)cmdlet, baseName, resourceId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 7432, 7655);
                    return return_v;
                }


                int
                f_1031_7756_7797(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 7756, 7797);
                    return 0;
                }


                int
                f_1031_7882_7928(System.Management.Automation.PSCmdlet
                cmdlet, string
                filePath, System.IO.IOException
                e)
                {
                    ReportFileOpenFailure((System.Management.Automation.Cmdlet)cmdlet, filePath, (System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 7882, 7928);
                    return 0;
                }


                int
                f_1031_8075_8121(System.Management.Automation.PSCmdlet
                cmdlet, string
                filePath, System.UnauthorizedAccessException
                e)
                {
                    ReportFileOpenFailure((System.Management.Automation.Cmdlet)cmdlet, filePath, (System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 8075, 8121);
                    return 0;
                }


                int
                f_1031_8262_8308(System.Management.Automation.PSCmdlet
                cmdlet, string
                filePath, System.NotSupportedException
                e)
                {
                    ReportFileOpenFailure((System.Management.Automation.Cmdlet)cmdlet, filePath, (System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 8262, 8308);
                    return 0;
                }


                int
                f_1031_8461_8507(System.Management.Automation.PSCmdlet
                cmdlet, string
                filePath, System.Security.SecurityException
                e)
                {
                    ReportFileOpenFailure((System.Management.Automation.Cmdlet)cmdlet, filePath, (System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 8461, 8507);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1031, 3987, 8534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1031, 3987, 8534);
            }
        }

        internal static void ReportFileOpenFailure(Cmdlet cmdlet, string filePath, Exception e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1031, 8546, 8891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 8658, 8822);

                ErrorRecord
                errorRecord = f_1031_8684_8821(e, "FileOpenFailure", ErrorCategory.OpenError, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 8838, 8880);

                f_1031_8838_8879(
                            cmdlet, errorRecord);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1031, 8546, 8891);

                System.Management.Automation.ErrorRecord
                f_1031_8684_8821(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 8684, 8821);
                    return return_v;
                }


                int
                f_1031_8838_8879(System.Management.Automation.Cmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 8838, 8879);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1031, 8546, 8891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1031, 8546, 8891);
            }
        }

        internal static StreamReader OpenStreamReader(PSCmdlet command, string filePath, Encoding encoding, bool isLiteralPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1031, 8903, 9191);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 9047, 9120);

                FileStream
                fileStream = f_1031_9071_9119(filePath, command, isLiteralPath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 9134, 9180);

                return f_1031_9141_9179(fileStream, encoding);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1031, 8903, 9191);

                System.IO.FileStream
                f_1031_9071_9119(string
                filePath, System.Management.Automation.PSCmdlet
                command, bool
                isLiteralPath)
                {
                    var return_v = OpenFileStream(filePath, command, isLiteralPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 9071, 9119);
                    return return_v;
                }


                System.IO.StreamReader
                f_1031_9141_9179(System.IO.FileStream
                stream, System.Text.Encoding
                encoding)
                {
                    var return_v = new System.IO.StreamReader((System.IO.Stream)stream, encoding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 9141, 9179);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1031, 8903, 9191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1031, 8903, 9191);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static FileStream OpenFileStream(string filePath, PSCmdlet command, bool isLiteralPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1031, 9203, 10817);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 9324, 9406);

                string
                resolvedPath = f_1031_9346_9405(filePath, command, isLiteralPath)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 9458, 9547);

                    return f_1031_9465_9546(resolvedPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                }
                // These are the known exceptions for FileStream.ctor
                catch (ArgumentException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1031, 9643, 9856);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 9703, 9757);

                    f_1031_9703_9756(command, filePath, e);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 9775, 9787);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1031, 9643, 9856);
                }
                catch (IOException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1031, 9870, 10077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 9924, 9978);

                    f_1031_9924_9977(command, filePath, e);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 9996, 10008);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1031, 9870, 10077);
                }
                catch (UnauthorizedAccessException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1031, 10091, 10314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 10161, 10215);

                    f_1031_10161_10214(command, filePath, e);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 10233, 10245);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1031, 10091, 10314);
                }
                catch (NotSupportedException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1031, 10328, 10545);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 10392, 10446);

                    f_1031_10392_10445(command, filePath, e);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 10464, 10476);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1031, 10328, 10545);
                }
                catch (System.Management.Automation.DriveNotFoundException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1031, 10559, 10806);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 10653, 10707);

                    f_1031_10653_10706(command, filePath, e);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 10725, 10737);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1031, 10559, 10806);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1031, 9203, 10817);

                string
                f_1031_9346_9405(string
                filePath, System.Management.Automation.PSCmdlet
                command, bool
                isLiteralPath)
                {
                    var return_v = PathUtils.ResolveFilePath(filePath, command, isLiteralPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 9346, 9405);
                    return return_v;
                }


                System.IO.FileStream
                f_1031_9465_9546(string
                path, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share)
                {
                    var return_v = new System.IO.FileStream(path, mode, access, share);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 9465, 9546);
                    return return_v;
                }


                int
                f_1031_9703_9756(System.Management.Automation.PSCmdlet
                cmdlet, string
                filePath, System.ArgumentException
                e)
                {
                    PathUtils.ReportFileOpenFailure((System.Management.Automation.Cmdlet)cmdlet, filePath, (System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 9703, 9756);
                    return 0;
                }


                int
                f_1031_9924_9977(System.Management.Automation.PSCmdlet
                cmdlet, string
                filePath, System.IO.IOException
                e)
                {
                    PathUtils.ReportFileOpenFailure((System.Management.Automation.Cmdlet)cmdlet, filePath, (System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 9924, 9977);
                    return 0;
                }


                int
                f_1031_10161_10214(System.Management.Automation.PSCmdlet
                cmdlet, string
                filePath, System.UnauthorizedAccessException
                e)
                {
                    PathUtils.ReportFileOpenFailure((System.Management.Automation.Cmdlet)cmdlet, filePath, (System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 10161, 10214);
                    return 0;
                }


                int
                f_1031_10392_10445(System.Management.Automation.PSCmdlet
                cmdlet, string
                filePath, System.NotSupportedException
                e)
                {
                    PathUtils.ReportFileOpenFailure((System.Management.Automation.Cmdlet)cmdlet, filePath, (System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 10392, 10445);
                    return 0;
                }


                int
                f_1031_10653_10706(System.Management.Automation.PSCmdlet
                cmdlet, string
                filePath, System.Management.Automation.DriveNotFoundException
                e)
                {
                    PathUtils.ReportFileOpenFailure((System.Management.Automation.Cmdlet)cmdlet, filePath, (System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 10653, 10706);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1031, 9203, 10817);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1031, 9203, 10817);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string ResolveFilePath(string filePath, PSCmdlet command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1031, 11162, 11320);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 11260, 11309);

                return f_1031_11267_11308(filePath, command, false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1031, 11162, 11320);

                string
                f_1031_11267_11308(string
                filePath, System.Management.Automation.PSCmdlet
                command, bool
                isLiteralPath)
                {
                    var return_v = ResolveFilePath(filePath, command, isLiteralPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 11267, 11308);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1031, 11162, 11320);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1031, 11162, 11320);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string ResolveFilePath(string filePath, PSCmdlet command, bool isLiteralPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1031, 11715, 13848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 11833, 11852);

                string
                path = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 11904, 11933);

                    ProviderInfo
                    provider = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 11951, 11976);

                    PSDriveInfo
                    drive = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 11994, 12038);

                    List<string>
                    filePaths = f_1031_12019_12037()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 12058, 12434) || true) && (isLiteralPath)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1031, 12058, 12434);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 12117, 12229);

                        f_1031_12117_12228(filePaths, f_1031_12131_12227(f_1031_12131_12156(f_1031_12131_12151(command)), filePath, out provider, out drive));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1031, 12058, 12434);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1031, 12058, 12434);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 12311, 12415);

                        f_1031_12311_12414(filePaths, f_1031_12330_12413(f_1031_12330_12355(f_1031_12330_12350(command)), filePath, out provider));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1031, 12058, 12434);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 12454, 12633) || true) && (!f_1031_12459_12520(provider, f_1031_12479_12519(f_1031_12479_12508(f_1031_12479_12494(command)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1031, 12454, 12633);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 12562, 12614);

                        f_1031_12562_12613(command, f_1031_12595_12612(provider));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1031, 12454, 12633);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 12653, 12778) || true) && (f_1031_12657_12672(filePaths) > 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1031, 12653, 12778);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 12718, 12759);

                        f_1031_12718_12758(command);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1031, 12653, 12778);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 12798, 12927) || true) && (f_1031_12802_12817(filePaths) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1031, 12798, 12927);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 12864, 12908);

                        f_1031_12864_12907(command, filePath);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1031, 12798, 12927);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 12947, 12967);

                    path = f_1031_12954_12966(filePaths, 0);
                }
                catch (ItemNotFoundException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1031, 12996, 13085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 13058, 13070);

                    path = null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1031, 12996, 13085);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 13101, 13809) || true) && (f_1031_13105_13131(path))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1031, 13101, 13809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 13165, 13246);

                    CmdletProviderContext
                    cmdletProviderContext = f_1031_13211_13245(command)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 13264, 13293);

                    ProviderInfo
                    provider = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 13311, 13336);

                    PSDriveInfo
                    drive = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 13354, 13528);

                    path =
                    f_1031_13382_13527(f_1031_13382_13407(f_1031_13382_13402(command)), filePath, cmdletProviderContext, out provider, out drive);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 13546, 13597);

                    f_1031_13546_13596(cmdletProviderContext);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 13615, 13794) || true) && (!f_1031_13620_13681(provider, f_1031_13640_13680(f_1031_13640_13669(f_1031_13640_13655(command)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1031, 13615, 13794);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 13723, 13775);

                        f_1031_13723_13774(command, f_1031_13756_13773(provider));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1031, 13615, 13794);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1031, 13101, 13809);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 13825, 13837);

                return path;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1031, 11715, 13848);

                System.Collections.Generic.List<string>
                f_1031_12019_12037()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 12019, 12037);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1031_12131_12151(System.Management.Automation.PSCmdlet
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 12131, 12151);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1031_12131_12156(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 12131, 12156);
                    return return_v;
                }


                string
                f_1031_12131_12227(System.Management.Automation.PathIntrinsics
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.GetUnresolvedProviderPathFromPSPath(path, out provider, out drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 12131, 12227);
                    return return_v;
                }


                int
                f_1031_12117_12228(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 12117, 12228);
                    return 0;
                }


                System.Management.Automation.SessionState
                f_1031_12330_12350(System.Management.Automation.PSCmdlet
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 12330, 12350);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1031_12330_12355(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 12330, 12355);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1031_12330_12413(System.Management.Automation.PathIntrinsics
                this_param, string
                path, out System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetResolvedProviderPathFromPSPath(path, out provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 12330, 12413);
                    return return_v;
                }


                int
                f_1031_12311_12414(System.Collections.Generic.List<string>
                this_param, System.Collections.ObjectModel.Collection<string>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<string>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 12311, 12414);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1031_12479_12494(System.Management.Automation.PSCmdlet
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 12479, 12494);
                    return return_v;
                }


                System.Management.Automation.ProviderNames
                f_1031_12479_12508(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ProviderNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 12479, 12508);
                    return return_v;
                }


                string
                f_1031_12479_12519(System.Management.Automation.ProviderNames
                this_param)
                {
                    var return_v = this_param.FileSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 12479, 12519);
                    return return_v;
                }


                bool
                f_1031_12459_12520(System.Management.Automation.ProviderInfo
                this_param, string
                providerName)
                {
                    var return_v = this_param.NameEquals(providerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 12459, 12520);
                    return return_v;
                }


                string
                f_1031_12595_12612(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 12595, 12612);
                    return return_v;
                }


                int
                f_1031_12562_12613(System.Management.Automation.PSCmdlet
                cmdlet, string
                providerId)
                {
                    ReportWrongProviderType((System.Management.Automation.Cmdlet)cmdlet, providerId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 12562, 12613);
                    return 0;
                }


                int
                f_1031_12657_12672(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 12657, 12672);
                    return return_v;
                }


                int
                f_1031_12718_12758(System.Management.Automation.PSCmdlet
                cmdlet)
                {
                    ReportMultipleFilesNotSupported((System.Management.Automation.Cmdlet)cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 12718, 12758);
                    return 0;
                }


                int
                f_1031_12802_12817(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 12802, 12817);
                    return return_v;
                }


                int
                f_1031_12864_12907(System.Management.Automation.PSCmdlet
                cmdlet, string
                filePath)
                {
                    ReportWildcardingFailure((System.Management.Automation.Cmdlet)cmdlet, filePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 12864, 12907);
                    return 0;
                }


                string
                f_1031_12954_12966(System.Collections.Generic.List<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 12954, 12966);
                    return return_v;
                }


                bool
                f_1031_13105_13131(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 13105, 13131);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1031_13211_13245(System.Management.Automation.PSCmdlet
                command)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext((System.Management.Automation.Cmdlet)command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 13211, 13245);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1031_13382_13402(System.Management.Automation.PSCmdlet
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 13382, 13402);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1031_13382_13407(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 13382, 13407);
                    return return_v;
                }


                string
                f_1031_13382_13527(System.Management.Automation.PathIntrinsics
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.GetUnresolvedProviderPathFromPSPath(path, context, out provider, out drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 13382, 13527);
                    return return_v;
                }


                int
                f_1031_13546_13596(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    this_param.ThrowFirstErrorOrDoNothing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 13546, 13596);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1031_13640_13655(System.Management.Automation.PSCmdlet
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 13640, 13655);
                    return return_v;
                }


                System.Management.Automation.ProviderNames
                f_1031_13640_13669(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ProviderNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 13640, 13669);
                    return return_v;
                }


                string
                f_1031_13640_13680(System.Management.Automation.ProviderNames
                this_param)
                {
                    var return_v = this_param.FileSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 13640, 13680);
                    return return_v;
                }


                bool
                f_1031_13620_13681(System.Management.Automation.ProviderInfo
                this_param, string
                providerName)
                {
                    var return_v = this_param.NameEquals(providerName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 13620, 13681);
                    return return_v;
                }


                string
                f_1031_13756_13773(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 13756, 13773);
                    return return_v;
                }


                int
                f_1031_13723_13774(System.Management.Automation.PSCmdlet
                cmdlet, string
                providerId)
                {
                    ReportWrongProviderType((System.Management.Automation.Cmdlet)cmdlet, providerId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 13723, 13774);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1031, 11715, 13848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1031, 11715, 13848);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void ReportWrongProviderType(Cmdlet cmdlet, string providerId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1031, 13860, 14447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 13963, 14067);

                string
                msg = f_1031_13976_14066(f_1031_13994_14053(), providerId)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 14083, 14315);

                ErrorRecord
                errorRecord = f_1031_14109_14314(f_1031_14143_14187(), "ReadWriteFileNotFileSystemProvider", ErrorCategory.InvalidArgument, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 14331, 14380);

                errorRecord.ErrorDetails = f_1031_14358_14379(msg);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 14394, 14436);

                f_1031_14394_14435(cmdlet, errorRecord);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1031, 13860, 14447);

                string
                f_1031_13994_14053()
                {
                    var return_v = PathUtilsStrings.OutFile_ReadWriteFileNotFileSystemProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 13994, 14053);
                    return return_v;
                }


                string
                f_1031_13976_14066(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 13976, 14066);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1031_14143_14187()
                {
                    var return_v = PSTraceSource.NewInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 14143, 14187);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1031_14109_14314(System.Management.Automation.PSInvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 14109, 14314);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1031_14358_14379(string
                message)
                {
                    var return_v = new System.Management.Automation.ErrorDetails(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 14358, 14379);
                    return return_v;
                }


                int
                f_1031_14394_14435(System.Management.Automation.Cmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 14394, 14435);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1031, 13860, 14447);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1031, 13860, 14447);
            }
        }

        internal static void ReportMultipleFilesNotSupported(Cmdlet cmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1031, 14459, 15014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 14551, 14634);

                string
                msg = f_1031_14564_14633(f_1031_14582_14632())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 14650, 14882);

                ErrorRecord
                errorRecord = f_1031_14676_14881(f_1031_14710_14754(), "ReadWriteMultipleFilesNotSupported", ErrorCategory.InvalidArgument, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 14898, 14947);

                errorRecord.ErrorDetails = f_1031_14925_14946(msg);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 14961, 15003);

                f_1031_14961_15002(cmdlet, errorRecord);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1031, 14459, 15014);

                string
                f_1031_14582_14632()
                {
                    var return_v = PathUtilsStrings.OutFile_MultipleFilesNotSupported;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 14582, 14632);
                    return return_v;
                }


                string
                f_1031_14564_14633(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 14564, 14633);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1031_14710_14754()
                {
                    var return_v = PSTraceSource.NewInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 14710, 14754);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1031_14676_14881(System.Management.Automation.PSInvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 14676, 14881);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1031_14925_14946(string
                message)
                {
                    var return_v = new System.Management.Automation.ErrorDetails(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 14925, 14946);
                    return return_v;
                }


                int
                f_1031_14961_15002(System.Management.Automation.Cmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 14961, 15002);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1031, 14459, 15014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1031, 14459, 15014);
            }
        }

        internal static void ReportWildcardingFailure(Cmdlet cmdlet, string filePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1031, 15026, 15555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 15128, 15213);

                string
                msg = f_1031_15141_15212(f_1031_15159_15201(), filePath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 15229, 15423);

                ErrorRecord
                errorRecord = f_1031_15255_15422(f_1031_15289_15316(), "FileOpenFailure", ErrorCategory.OpenError, filePath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 15439, 15488);

                errorRecord.ErrorDetails = f_1031_15466_15487(msg);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 15502, 15544);

                f_1031_15502_15543(cmdlet, errorRecord);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1031, 15026, 15555);

                string
                f_1031_15159_15201()
                {
                    var return_v = PathUtilsStrings.OutFile_DidNotResolveFile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 15159, 15201);
                    return return_v;
                }


                string
                f_1031_15141_15212(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 15141, 15212);
                    return return_v;
                }


                System.IO.FileNotFoundException
                f_1031_15289_15316()
                {
                    var return_v = new System.IO.FileNotFoundException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 15289, 15316);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1031_15255_15422(System.IO.FileNotFoundException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 15255, 15422);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1031_15466_15487(string
                message)
                {
                    var return_v = new System.Management.Automation.ErrorDetails(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 15466, 15487);
                    return return_v;
                }


                int
                f_1031_15502_15543(System.Management.Automation.Cmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 15502, 15543);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1031, 15026, 15555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1031, 15026, 15555);
            }
        }

        internal static DirectoryInfo CreateModuleDirectory(PSCmdlet cmdlet, string moduleNameOrPath, bool force)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1031, 15567, 18697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 15697, 15763);

                f_1031_15697_15762(cmdlet != null, "Caller should verify cmdlet != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 15777, 15893);

                f_1031_15777_15892(!f_1031_15789_15827(moduleNameOrPath), "Caller should verify !string.IsNullOrEmpty(moduleNameOrPath)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 15909, 15944);

                DirectoryInfo
                directoryInfo = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 15994, 16117);

                    string
                    rootedPath = f_1031_16014_16116(moduleNameOrPath, f_1031_16101_16115(cmdlet))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 16135, 16455) || true) && (f_1031_16139_16171(rootedPath) && (DynAbs.Tracing.TraceSender.Expression_True(1031, 16139, 16207) && f_1031_16175_16207(moduleNameOrPath, '.')))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1031, 16135, 16455);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 16249, 16344);

                        PathInfo
                        currentPath = f_1031_16272_16343(cmdlet, f_1031_16303_16342(f_1031_16303_16331(f_1031_16303_16317(cmdlet))))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 16366, 16436);

                        rootedPath = f_1031_16379_16435(f_1031_16392_16416(currentPath), moduleNameOrPath);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1031, 16135, 16455);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 16475, 16727) || true) && (f_1031_16479_16511(rootedPath))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1031, 16475, 16727);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 16553, 16622);

                        string
                        personalModuleRoot = f_1031_16581_16621()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 16644, 16708);

                        rootedPath = f_1031_16657_16707(personalModuleRoot, moduleNameOrPath);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1031, 16475, 16727);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 16747, 16793);

                    directoryInfo = f_1031_16763_16792(rootedPath);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 16811, 17836) || true) && (f_1031_16815_16835(directoryInfo))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1031, 16811, 17836);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 16877, 17712) || true) && (!force)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1031, 16877, 17712);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 16937, 17227);

                            string
                            errorMessage = f_1031_16959_17226(f_1031_17003_17031(), f_1031_17119_17172(), f_1031_17203_17225(directoryInfo))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 17253, 17307);

                            ErrorDetails
                            details = f_1031_17276_17306(errorMessage)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 17333, 17621);

                            ErrorRecord
                            errorRecord = f_1031_17359_17620(f_1031_17405_17443(f_1031_17427_17442(details)), "ExportProxyCommand_OutputDirectoryExists", ErrorCategory.ResourceExists, directoryInfo)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 17647, 17689);

                            f_1031_17647_17688(cmdlet, errorRecord);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1031, 16877, 17712);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1031, 16811, 17836);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1031, 16811, 17836);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 17794, 17817);

                        f_1031_17794_17816(directoryInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1031, 16811, 17836);
                    }
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1031, 17865, 18649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 17917, 18216);

                    string
                    errorMessage = f_1031_17939_18215(f_1031_17975_18003(), f_1031_18083_18143(), moduleNameOrPath, f_1031_18205_18214(e))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 18234, 18288);

                    ErrorDetails
                    details = f_1031_18257_18287(errorMessage)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 18306, 18574);

                    ErrorRecord
                    errorRecord = f_1031_18332_18573(f_1031_18370_18411(f_1031_18392_18407(details), e), "ExportProxyCommand_CannotCreateOutputDirectory", ErrorCategory.ResourceExists, moduleNameOrPath)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 18592, 18634);

                    f_1031_18592_18633(cmdlet, errorRecord);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1031, 17865, 18649);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 18665, 18686);

                return directoryInfo;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1031, 15567, 18697);

                int
                f_1031_15697_15762(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 15697, 15762);
                    return 0;
                }


                bool
                f_1031_15789_15827(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 15789, 15827);
                    return return_v;
                }


                int
                f_1031_15777_15892(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 15777, 15892);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1031_16101_16115(System.Management.Automation.PSCmdlet
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 16101, 16115);
                    return return_v;
                }


                string
                f_1031_16014_16116(string
                filePath, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = Microsoft.PowerShell.Commands.ModuleCmdletBase.ResolveRootedFilePath(filePath, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 16014, 16116);
                    return return_v;
                }


                bool
                f_1031_16139_16171(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 16139, 16171);
                    return return_v;
                }


                bool
                f_1031_16175_16207(string
                this_param, char
                value)
                {
                    var return_v = this_param.StartsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 16175, 16207);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1031_16303_16317(System.Management.Automation.PSCmdlet
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 16303, 16317);
                    return return_v;
                }


                System.Management.Automation.ProviderNames
                f_1031_16303_16331(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.ProviderNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 16303, 16331);
                    return return_v;
                }


                string
                f_1031_16303_16342(System.Management.Automation.ProviderNames
                this_param)
                {
                    var return_v = this_param.FileSystem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 16303, 16342);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1031_16272_16343(System.Management.Automation.PSCmdlet
                this_param, string
                providerId)
                {
                    var return_v = this_param.CurrentProviderLocation(providerId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 16272, 16343);
                    return return_v;
                }


                string
                f_1031_16392_16416(System.Management.Automation.PathInfo
                this_param)
                {
                    var return_v = this_param.ProviderPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 16392, 16416);
                    return return_v;
                }


                string
                f_1031_16379_16435(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 16379, 16435);
                    return return_v;
                }


                bool
                f_1031_16479_16511(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 16479, 16511);
                    return return_v;
                }


                string
                f_1031_16581_16621()
                {
                    var return_v = ModuleIntrinsics.GetPersonalModulePath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 16581, 16621);
                    return return_v;
                }


                string
                f_1031_16657_16707(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 16657, 16707);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_1031_16763_16792(string
                path)
                {
                    var return_v = new System.IO.DirectoryInfo(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 16763, 16792);
                    return return_v;
                }


                bool
                f_1031_16815_16835(System.IO.DirectoryInfo
                this_param)
                {
                    var return_v = this_param.Exists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 16815, 16835);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1031_17003_17031()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 17003, 17031);
                    return return_v;
                }


                string
                f_1031_17119_17172()
                {
                    var return_v = PathUtilsStrings.ExportPSSession_ErrorDirectoryExists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 17119, 17172);
                    return return_v;
                }


                string
                f_1031_17203_17225(System.IO.DirectoryInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 17203, 17225);
                    return return_v;
                }


                string
                f_1031_16959_17226(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 16959, 17226);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1031_17276_17306(string
                message)
                {
                    var return_v = new System.Management.Automation.ErrorDetails(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 17276, 17306);
                    return return_v;
                }


                string
                f_1031_17427_17442(System.Management.Automation.ErrorDetails
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 17427, 17442);
                    return return_v;
                }


                System.ArgumentException
                f_1031_17405_17443(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 17405, 17443);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1031_17359_17620(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.IO.DirectoryInfo
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 17359, 17620);
                    return return_v;
                }


                int
                f_1031_17647_17688(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 17647, 17688);
                    return 0;
                }


                int
                f_1031_17794_17816(System.IO.DirectoryInfo
                this_param)
                {
                    this_param.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 17794, 17816);
                    return 0;
                }


                System.Globalization.CultureInfo
                f_1031_17975_18003()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 17975, 18003);
                    return return_v;
                }


                string
                f_1031_18083_18143()
                {
                    var return_v = PathUtilsStrings.ExportPSSession_CannotCreateOutputDirectory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 18083, 18143);
                    return return_v;
                }


                string
                f_1031_18205_18214(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 18205, 18214);
                    return return_v;
                }


                string
                f_1031_17939_18215(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 17939, 18215);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1031_18257_18287(string
                message)
                {
                    var return_v = new System.Management.Automation.ErrorDetails(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 18257, 18287);
                    return return_v;
                }


                string
                f_1031_18392_18407(System.Management.Automation.ErrorDetails
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 18392, 18407);
                    return return_v;
                }


                System.ArgumentException
                f_1031_18370_18411(string
                message, System.Exception
                innerException)
                {
                    var return_v = new System.ArgumentException(message, innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 18370, 18411);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1031_18332_18573(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 18332, 18573);
                    return return_v;
                }


                int
                f_1031_18592_18633(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 18592, 18633);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1031, 15567, 18697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1031, 15567, 18697);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static DirectoryInfo CreateTemporaryDirectory()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1031, 18709, 19445);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 18790, 18863);

                DirectoryInfo
                temporaryDirectory = f_1031_18825_18862(f_1031_18843_18861())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 18877, 18907);

                DirectoryInfo
                moduleDirectory
                = default(DirectoryInfo);
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1031, 18921, 19301);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 18956, 19254);

                            moduleDirectory = f_1031_18974_19253(f_1031_19014_19252(f_1031_19053_19080(temporaryDirectory), f_1031_19107_19251(null, "tmp_{0}", f_1031_19226_19250())));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1031, 18921, 19301);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 18921, 19301) || true) && (f_1031_19277_19299(moduleDirectory))
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1031, 18921, 19301);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1031, 18921, 19301);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 19317, 19369);

                f_1031_19317_19368(f_1031_19343_19367(moduleDirectory));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 19383, 19434);

                return f_1031_19390_19433(f_1031_19408_19432(moduleDirectory));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1031, 18709, 19445);

                string
                f_1031_18843_18861()
                {
                    var return_v = Path.GetTempPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 18843, 18861);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_1031_18825_18862(string
                path)
                {
                    var return_v = new System.IO.DirectoryInfo(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 18825, 18862);
                    return return_v;
                }


                string
                f_1031_19053_19080(System.IO.DirectoryInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 19053, 19080);
                    return return_v;
                }


                string
                f_1031_19226_19250()
                {
                    var return_v = Path.GetRandomFileName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 19226, 19250);
                    return return_v;
                }


                string
                f_1031_19107_19251(System.IFormatProvider?
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format(provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 19107, 19251);
                    return return_v;
                }


                string
                f_1031_19014_19252(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 19014, 19252);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_1031_18974_19253(string
                path)
                {
                    var return_v = new System.IO.DirectoryInfo(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 18974, 19253);
                    return return_v;
                }


                bool
                f_1031_19277_19299(System.IO.DirectoryInfo
                this_param)
                {
                    var return_v = this_param.Exists;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 19277, 19299);
                    return return_v;
                }


                string
                f_1031_19343_19367(System.IO.DirectoryInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 19343, 19367);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_1031_19317_19368(string
                path)
                {
                    var return_v = Directory.CreateDirectory(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 19317, 19368);
                    return return_v;
                }


                string
                f_1031_19408_19432(System.IO.DirectoryInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1031, 19408, 19432);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_1031_19390_19433(string
                path)
                {
                    var return_v = new System.IO.DirectoryInfo(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 19390, 19433);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1031, 18709, 19445);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1031, 18709, 19445);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool TryDeleteFile(string filepath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1031, 19457, 19897);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 19533, 19857) || true) && (f_1031_19537_19561(filepath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1031, 19533, 19857);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 19639, 19664);

                        f_1031_19639_19663(filepath);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 19686, 19698);

                        return true;
                    }
                    catch (IOException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1031, 19735, 19842);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1031, 19735, 19842);
                        // file is in use on Windows
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1031, 19533, 19857);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1031, 19873, 19886);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1031, 19457, 19897);

                bool
                f_1031_19537_19561(string
                path)
                {
                    var return_v = IO.File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 19537, 19561);
                    return return_v;
                }


                int
                f_1031_19639_19663(string
                path)
                {
                    IO.File.Delete(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1031, 19639, 19663);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1031, 19457, 19897);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1031, 19457, 19897);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PathUtils()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1031, 463, 19904);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1031, 463, 19904);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1031, 463, 19904);
        }

    }
}
