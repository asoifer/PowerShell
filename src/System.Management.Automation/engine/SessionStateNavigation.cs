// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.ObjectModel;
using System.Management.Automation.Provider;

using Dbg = System.Management.Automation;

#pragma warning disable 1634, 1691 // Stops compiler from warning about unknown warnings
#pragma warning disable 56500

namespace System.Management.Automation
{
    internal sealed partial class SessionStateInternal
    {
        internal string GetParentPath(string path, string root)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 1654, 2110);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 1734, 1852) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 1734, 1852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 1784, 1837);

                    throw f_1350_1790_1836("path");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 1734, 1852);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 1868, 1949);

                CmdletProviderContext
                context = f_1350_1900_1948(f_1350_1926_1947(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 1965, 2016);

                string
                result = f_1350_1981_2015(this, path, root, context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 2032, 2069);

                f_1350_2032_2068(
                            context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 2085, 2099);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 1654, 2110);

                System.Management.Automation.PSArgumentNullException
                f_1350_1790_1836(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 1790, 1836);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1350_1926_1947(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 1926, 1947);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1350_1900_1948(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 1900, 1948);
                    return return_v;
                }


                string
                f_1350_1981_2015(System.Management.Automation.SessionStateInternal
                this_param, string
                path, string
                root, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetParentPath(path, root, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 1981, 2015);
                    return return_v;
                }


                int
                f_1350_2032_2068(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    this_param.ThrowFirstErrorOrDoNothing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 2032, 2068);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 1654, 2110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 1654, 2110);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetParentPath(
                    string path,
                    string root,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 3345, 3556);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 3496, 3545);

                return f_1350_3503_3544(this, path, root, context, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 3345, 3556);

                string
                f_1350_3503_3544(System.Management.Automation.SessionStateInternal
                this_param, string
                path, string
                root, System.Management.Automation.CmdletProviderContext
                context, bool
                useDefaultProvider)
                {
                    var return_v = this_param.GetParentPath(path, root, context, useDefaultProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 3503, 3544);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 3345, 3556);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 3345, 3556);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetParentPath(
                    string path,
                    string root,
                    CmdletProviderContext context,
                    bool useDefaultProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 4479, 7102);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 4668, 4786) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 4668, 4786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 4718, 4771);

                    throw f_1350_4724_4770("path");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 4668, 4786);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 4802, 4901);

                CmdletProviderContext
                getProviderPathContext =
                f_1350_4866_4900(context)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 4953, 4978);

                    PSDriveInfo
                    drive = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 4996, 5025);

                    ProviderInfo
                    provider = null
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 5089, 5269);

                        f_1350_5089_5268(f_1350_5089_5096(), path, getProviderPathContext, out provider, out drive);
                    }
                    catch (DriveNotFoundException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 5306, 5991);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 5590, 5972) || true) && (useDefaultProvider)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 5590, 5972);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 5725, 5845);

                            provider = f_1350_5736_5844(f_1350_5736_5763(f_1350_5736_5754()), Microsoft.PowerShell.Commands.FileSystemProvider.ProviderName);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 5590, 5972);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 5590, 5972);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 5943, 5949);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 5590, 5972);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 5306, 5991);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 6011, 6197) || true) && (f_1350_6015_6049(getProviderPathContext))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 6011, 6197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 6091, 6144);

                        f_1350_6091_6143(getProviderPathContext, context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 6166, 6178);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 6011, 6197);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 6217, 6317) || true) && (drive != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 6217, 6317);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 6276, 6298);

                        context.Drive = drive;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 6217, 6317);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 6337, 6370);

                    bool
                    isProviderQualified = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 6388, 6418);

                    bool
                    isDriveQualified = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 6436, 6460);

                    string
                    qualifier = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 6478, 6597);

                    string
                    pathNoQualifier = f_1350_6503_6596(this, path, provider, out qualifier, out isProviderQualified, out isDriveQualified)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 6617, 6689);

                    string
                    result = f_1350_6633_6688(this, provider, pathNoQualifier, root, context)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 6709, 6929) || true) && (!f_1350_6714_6745(qualifier) && (DynAbs.Tracing.TraceSender.Expression_True(1350, 6713, 6778) && !f_1350_6750_6778(result)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 6709, 6929);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 6820, 6910);

                        result = f_1350_6829_6909(this, result, provider, qualifier, isProviderQualified, isDriveQualified);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 6709, 6929);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 6949, 6963);

                    return result;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1350, 6992, 7091);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 7032, 7076);

                    f_1350_7032_7075(getProviderPathContext);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1350, 6992, 7091);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 4479, 7102);

                System.Management.Automation.PSArgumentNullException
                f_1350_4724_4770(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 4724, 4770);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1350_4866_4900(System.Management.Automation.CmdletProviderContext
                contextToCopyFrom)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(contextToCopyFrom);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 4866, 4900);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1350_5089_5096()
                {
                    var return_v = Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 5089, 5096);
                    return return_v;
                }


                string
                f_1350_5089_5268(System.Management.Automation.LocationGlobber
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.GetProviderPath(path, context, out provider, out drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 5089, 5268);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1350_5736_5754()
                {
                    var return_v = PublicSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 5736, 5754);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1350_5736_5763(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 5736, 5763);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1350_5736_5844(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetSingleProvider(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 5736, 5844);
                    return return_v;
                }


                bool
                f_1350_6015_6049(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.HasErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 6015, 6049);
                    return return_v;
                }


                int
                f_1350_6091_6143(System.Management.Automation.CmdletProviderContext
                this_param, System.Management.Automation.CmdletProviderContext
                errorContext)
                {
                    this_param.WriteErrorsToContext(errorContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 6091, 6143);
                    return 0;
                }


                string
                f_1350_6503_6596(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.ProviderInfo
                provider, out string
                qualifier, out bool
                isProviderQualified, out bool
                isDriveQualified)
                {
                    var return_v = this_param.RemoveQualifier(path, provider, out qualifier, out isProviderQualified, out isDriveQualified);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 6503, 6596);
                    return return_v;
                }


                string
                f_1350_6633_6688(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider, string
                path, string
                root, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetParentPath(provider, path, root, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 6633, 6688);
                    return return_v;
                }


                bool
                f_1350_6714_6745(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 6714, 6745);
                    return return_v;
                }


                bool
                f_1350_6750_6778(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 6750, 6778);
                    return return_v;
                }


                string
                f_1350_6829_6909(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.ProviderInfo
                provider, string
                qualifier, bool
                isProviderQualified, bool
                isDriveQualified)
                {
                    var return_v = this_param.AddQualifier(path, provider, qualifier, isProviderQualified, isDriveQualified);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 6829, 6909);
                    return return_v;
                }


                int
                f_1350_7032_7075(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    this_param.RemoveStopReferral();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 7032, 7075);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 4479, 7102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 4479, 7102);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string AddQualifier(string path, ProviderInfo provider, string qualifier, bool isProviderQualified, bool isDriveQualified)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 7114, 8129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 7269, 7290);

                string
                result = path
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 7306, 7334);

                string
                formatString = "{1}"
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 7348, 7865) || true) && (isProviderQualified)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 7348, 7865);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 7405, 7431);

                    formatString = "{0}::{1}";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 7348, 7865);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 7348, 7865);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 7465, 7865) || true) && (isDriveQualified)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 7465, 7865);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 7623, 7850) || true) && (f_1350_7627_7658(provider))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 7623, 7850);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 7700, 7725);

                            formatString = "{0}:{1}";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 7623, 7850);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 7623, 7850);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 7807, 7831);

                            formatString = "{0}{1}";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 7623, 7850);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 7465, 7865);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 7348, 7865);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 7881, 8088);

                result =
                f_1350_7907_8087(f_1350_7943_7992(), formatString, qualifier, path);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 8104, 8118);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 7114, 8129);

                bool
                f_1350_7627_7658(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.VolumeSeparatedByColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 7627, 7658);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1350_7943_7992()
                {
                    var return_v = System.Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 7943, 7992);
                    return return_v;
                }


                string
                f_1350_7907_8087(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 7907, 8087);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 7114, 8129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 7114, 8129);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string RemoveQualifier(string path, ProviderInfo provider, out string qualifier, out bool isProviderQualified, out bool isDriveQualified)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 8986, 10557);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 9156, 9269);

                f_1350_9156_9268(path != null, "Path should be verified by the caller");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 9285, 9306);

                string
                result = path
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 9320, 9337);

                qualifier = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 9351, 9379);

                isProviderQualified = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 9393, 9418);

                isDriveQualified = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 9434, 10516) || true) && (f_1350_9438_9498(path, out qualifier))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 9434, 10516);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 9532, 9559);

                    isProviderQualified = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 9579, 9636);

                    int
                    index = f_1350_9591_9635(path, "::", StringComparison.Ordinal)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 9656, 9812) || true) && (index != -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 9656, 9812);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 9758, 9793);

                        result = f_1350_9767_9792(path, index + 2);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 9656, 9812);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 9434, 10516);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 9434, 10516);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 9878, 10501) || true) && (f_1350_9882_9925(f_1350_9882_9889(), path, out qualifier))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 9878, 10501);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 9967, 9991);

                        isDriveQualified = true;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 10188, 10482) || true) && (f_1350_10192_10223(provider))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 10188, 10482);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 10273, 10319);

                            result = f_1350_10282_10318(path, f_1350_10297_10313(qualifier) + 1);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 10188, 10482);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 10188, 10482);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 10417, 10459);

                            result = f_1350_10426_10458(path, f_1350_10441_10457(qualifier));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 10188, 10482);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 9878, 10501);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 9434, 10516);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 10532, 10546);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 8986, 10557);

                int
                f_1350_9156_9268(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 9156, 9268);
                    return 0;
                }


                bool
                f_1350_9438_9498(string
                path, out string
                providerId)
                {
                    var return_v = LocationGlobber.IsProviderQualifiedPath(path, out providerId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 9438, 9498);
                    return return_v;
                }


                int
                f_1350_9591_9635(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 9591, 9635);
                    return return_v;
                }


                string
                f_1350_9767_9792(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 9767, 9792);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1350_9882_9889()
                {
                    var return_v = Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 9882, 9889);
                    return return_v;
                }


                bool
                f_1350_9882_9925(System.Management.Automation.LocationGlobber
                this_param, string
                path, out string
                driveName)
                {
                    var return_v = this_param.IsAbsolutePath(path, out driveName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 9882, 9925);
                    return return_v;
                }


                bool
                f_1350_10192_10223(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.VolumeSeparatedByColon;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 10192, 10223);
                    return return_v;
                }


                int
                f_1350_10297_10313(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 10297, 10313);
                    return return_v;
                }


                string
                f_1350_10282_10318(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 10282, 10318);
                    return return_v;
                }


                int
                f_1350_10441_10457(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 10441, 10457);
                    return return_v;
                }


                string
                f_1350_10426_10458(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 10426, 10458);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 8986, 10557);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 8986, 10557);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetParentPath(
                    ProviderInfo provider,
                    string path,
                    string root,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 11919, 12921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 12174, 12312);

                f_1350_12174_12311(provider != null, "Caller should validate provider before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 12328, 12458);

                f_1350_12328_12457(path != null, "Caller should validate path before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 12474, 12604);

                f_1350_12474_12603(root != null, "Caller should validate root before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 12620, 12756);

                f_1350_12620_12755(context != null, "Caller should validate context before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 12772, 12836);

                CmdletProvider
                providerInstance = f_1350_12806_12835(this, provider)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 12850, 12910);

                return f_1350_12857_12909(this, providerInstance, path, root, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 11919, 12921);

                int
                f_1350_12174_12311(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 12174, 12311);
                    return 0;
                }


                int
                f_1350_12328_12457(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 12328, 12457);
                    return 0;
                }


                int
                f_1350_12474_12603(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 12474, 12603);
                    return 0;
                }


                int
                f_1350_12620_12755(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 12620, 12755);
                    return 0;
                }


                System.Management.Automation.Provider.CmdletProvider
                f_1350_12806_12835(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderInstance(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 12806, 12835);
                    return return_v;
                }


                string
                f_1350_12857_12909(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.Provider.CmdletProvider
                providerInstance, string
                path, string
                root, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetParentPath(providerInstance, path, root, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 12857, 12909);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 11919, 12921);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 11919, 12921);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetParentPath(
                    CmdletProvider providerInstance,
                    string path,
                    string root,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 14307, 16216);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 14572, 14726);

                f_1350_14572_14725(providerInstance != null, "Caller should validate providerInstance before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 14742, 14872);

                f_1350_14742_14871(path != null, "Caller should validate path before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 14888, 15018);

                f_1350_14888_15017(root != null, "Caller should validate root before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 15034, 15170);

                f_1350_15034_15169(context != null, "Caller should validate context before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 15186, 15310);

                NavigationCmdletProvider
                navigationCmdletProvider =
                f_1350_15255_15309(providerInstance, false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 15326, 15347);

                string
                result = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 15399, 15468);

                    result = f_1350_15408_15467(navigationCmdletProvider, path, root, context);
                }
                catch (LoopFlowException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 15497, 15576);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 15555, 15561);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 15497, 15576);
                }
                catch (PipelineStoppedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 15590, 15676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 15655, 15661);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 15590, 15676);
                }
                catch (ActionPreferenceStopException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 15690, 15781);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 15760, 15766);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 15690, 15781);
                }
                catch (Exception e) // Catch-all OK, 3rd party callout.
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 15795, 16175);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 15883, 16160);

                    throw f_1350_15889_16159(this, "GetParentPathProviderException", f_1350_15997_16047(), f_1350_16070_16107(navigationCmdletProvider), path, e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 15795, 16175);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 16191, 16205);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 14307, 16216);

                int
                f_1350_14572_14725(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 14572, 14725);
                    return 0;
                }


                int
                f_1350_14742_14871(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 14742, 14871);
                    return 0;
                }


                int
                f_1350_14888_15017(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 14888, 15017);
                    return 0;
                }


                int
                f_1350_15034_15169(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 15034, 15169);
                    return 0;
                }


                System.Management.Automation.Provider.NavigationCmdletProvider
                f_1350_15255_15309(System.Management.Automation.Provider.CmdletProvider
                providerInstance, bool
                acceptNonContainerProviders)
                {
                    var return_v = GetNavigationProviderInstance(providerInstance, acceptNonContainerProviders);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 15255, 15309);
                    return return_v;
                }


                string
                f_1350_15408_15467(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param, string
                path, string
                root, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetParentPath(path, root, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 15408, 15467);
                    return return_v;
                }


                string
                f_1350_15997_16047()
                {
                    var return_v = SessionStateStrings.GetParentPathProviderException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 15997, 16047);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1350_16070_16107(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param)
                {
                    var return_v = this_param.ProviderInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 16070, 16107);
                    return return_v;
                }


                System.Management.Automation.ProviderInvocationException
                f_1350_15889_16159(System.Management.Automation.SessionStateInternal
                this_param, string
                resourceId, string
                resourceStr, System.Management.Automation.ProviderInfo
                provider, string
                path, System.Exception
                e)
                {
                    var return_v = this_param.NewProviderInvocationException(resourceId, resourceStr, provider, path, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 15889, 16159);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 14307, 16216);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 14307, 16216);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string NormalizeRelativePath(string path, string basePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 17516, 17996);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 17608, 17726) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 17608, 17726);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 17658, 17711);

                    throw f_1350_17664_17710("path");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 17608, 17726);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 17742, 17823);

                CmdletProviderContext
                context = f_1350_17774_17822(f_1350_17800_17821(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 17839, 17902);

                string
                result = f_1350_17855_17901(this, path, basePath, context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 17918, 17955);

                f_1350_17918_17954(
                            context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 17971, 17985);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 17516, 17996);

                System.Management.Automation.PSArgumentNullException
                f_1350_17664_17710(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 17664, 17710);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1350_17800_17821(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 17800, 17821);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1350_17774_17822(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 17774, 17822);
                    return return_v;
                }


                string
                f_1350_17855_17901(System.Management.Automation.SessionStateInternal
                this_param, string
                path, string
                basePath, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.NormalizeRelativePath(path, basePath, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 17855, 17901);
                    return return_v;
                }


                int
                f_1350_17918_17954(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    this_param.ThrowFirstErrorOrDoNothing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 17918, 17954);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 17516, 17996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 17516, 17996);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string NormalizeRelativePath(
                    string path,
                    string basePath,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 19338, 25115);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 19501, 19619) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 19501, 19619);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 19551, 19604);

                    throw f_1350_19557_19603("path");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 19501, 19619);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 19635, 19734);

                CmdletProviderContext
                getProviderPathContext =
                f_1350_19699_19733(context)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 19786, 19811);

                    PSDriveInfo
                    drive = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 19829, 19858);

                    ProviderInfo
                    provider = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 19878, 20067);

                    string
                    workingPath = f_1350_19899_20066(f_1350_19899_19906(), path, getProviderPathContext, out provider, out drive)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 20087, 20273) || true) && (f_1350_20091_20125(getProviderPathContext))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 20087, 20273);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 20167, 20220);

                        f_1350_20167_20219(getProviderPathContext, context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 20242, 20254);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 20087, 20273);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 20293, 20803) || true) && (workingPath == null || (DynAbs.Tracing.TraceSender.Expression_False(1350, 20297, 20357) || provider == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 20293, 20803);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 20568, 20625);

                        Exception
                        e = f_1350_20582_20624("path")
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 20647, 20750);

                        f_1350_20647_20749(context, f_1350_20666_20748(e, "NormalizePathNullResult", ErrorCategory.InvalidArgument, path));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 20772, 20784);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 20293, 20803);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 20823, 22160) || true) && (basePath != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 20823, 22160);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 20885, 20914);

                        PSDriveInfo
                        baseDrive = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 20936, 20969);

                        ProviderInfo
                        baseProvider = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 20993, 21189);

                        f_1350_20993_21188(f_1350_20993_21000(), basePath, getProviderPathContext, out baseProvider, out baseDrive);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 21213, 22141) || true) && (drive != null && (DynAbs.Tracing.TraceSender.Expression_True(1350, 21217, 21251) && baseDrive != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 21213, 22141);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 21301, 22118) || true) && (!f_1350_21306_21375(f_1350_21306_21316(drive), f_1350_21324_21338(baseDrive), StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 21301, 22118);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 21710, 22091) || true) && (!(f_1350_21716_21789(f_1350_21716_21726(drive), f_1350_21738_21752(baseDrive), StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1350, 21716, 21901) || (f_1350_21827_21900(f_1350_21827_21841(baseDrive), f_1350_21853_21863(drive), StringComparison.OrdinalIgnoreCase)))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 21710, 22091);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 22048, 22060);

                                    return path;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 21710, 22091);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 21301, 22118);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 21213, 22141);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 20823, 22160);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 22180, 24885) || true) && (drive != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 22180, 24885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 22239, 22261);

                        context.Drive = drive;

                        if (
                        (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 22553, 24866) || true) && ((f_1350_22584_22613(this, provider) is NavigationCmdletProvider) && (DynAbs.Tracing.TraceSender.Expression_True(1350, 22583, 22706) && (!f_1350_22673_22705(f_1350_22694_22704(drive)))) && (DynAbs.Tracing.TraceSender.Expression_True(1350, 22583, 22800) && (f_1350_22736_22799(path, f_1350_22752_22762(drive), StringComparison.OrdinalIgnoreCase))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 22553, 24866);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 23893, 23982);

                            bool
                            driveRootEndsWithPathSeparator = f_1350_23931_23981(this, f_1350_23947_23980(f_1350_23947_23957(drive), f_1350_23958_23975(f_1350_23958_23968(drive)) - 1))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 24117, 24161);

                            int
                            indexAfterDriveRoot = f_1350_24143_24160(f_1350_24143_24153(drive))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 24187, 24314);

                            bool
                            pathStartsWithDriveRootAndPathSeparator = indexAfterDriveRoot < f_1350_24256_24267(path) && (DynAbs.Tracing.TraceSender.Expression_True(1350, 24234, 24313) && f_1350_24271_24313(this, f_1350_24287_24312(path, indexAfterDriveRoot)))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 24551, 24611);

                            bool
                            pathEqualsDriveRoot = f_1350_24578_24595(f_1350_24578_24588(drive)) == f_1350_24599_24610(path)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 24639, 24843) || true) && (driveRootEndsWithPathSeparator || (DynAbs.Tracing.TraceSender.Expression_False(1350, 24643, 24716) || pathStartsWithDriveRootAndPathSeparator) || (DynAbs.Tracing.TraceSender.Expression_False(1350, 24643, 24739) || pathEqualsDriveRoot))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 24639, 24843);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 24797, 24816);

                                workingPath = path;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 24639, 24843);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 22553, 24866);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 22180, 24885);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 24905, 24976);

                    return f_1350_24912_24975(this, provider, workingPath, basePath, context);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1350, 25005, 25104);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 25045, 25089);

                    f_1350_25045_25088(getProviderPathContext);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1350, 25005, 25104);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 19338, 25115);

                System.Management.Automation.PSArgumentNullException
                f_1350_19557_19603(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 19557, 19603);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1350_19699_19733(System.Management.Automation.CmdletProviderContext
                contextToCopyFrom)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(contextToCopyFrom);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 19699, 19733);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1350_19899_19906()
                {
                    var return_v = Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 19899, 19906);
                    return return_v;
                }


                string
                f_1350_19899_20066(System.Management.Automation.LocationGlobber
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.GetProviderPath(path, context, out provider, out drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 19899, 20066);
                    return return_v;
                }


                bool
                f_1350_20091_20125(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.HasErrors();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 20091, 20125);
                    return return_v;
                }


                int
                f_1350_20167_20219(System.Management.Automation.CmdletProviderContext
                this_param, System.Management.Automation.CmdletProviderContext
                errorContext)
                {
                    this_param.WriteErrorsToContext(errorContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 20167, 20219);
                    return 0;
                }


                System.Management.Automation.PSArgumentException
                f_1350_20582_20624(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 20582, 20624);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1350_20666_20748(System.Exception
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord(exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 20666, 20748);
                    return return_v;
                }


                int
                f_1350_20647_20749(System.Management.Automation.CmdletProviderContext
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 20647, 20749);
                    return 0;
                }


                System.Management.Automation.LocationGlobber
                f_1350_20993_21000()
                {
                    var return_v = Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 20993, 21000);
                    return return_v;
                }


                string
                f_1350_20993_21188(System.Management.Automation.LocationGlobber
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.GetProviderPath(path, context, out provider, out drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 20993, 21188);
                    return return_v;
                }


                string
                f_1350_21306_21316(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 21306, 21316);
                    return return_v;
                }


                string
                f_1350_21324_21338(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 21324, 21338);
                    return return_v;
                }


                bool
                f_1350_21306_21375(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 21306, 21375);
                    return return_v;
                }


                string
                f_1350_21716_21726(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 21716, 21726);
                    return return_v;
                }


                string
                f_1350_21738_21752(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 21738, 21752);
                    return return_v;
                }


                bool
                f_1350_21716_21789(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 21716, 21789);
                    return return_v;
                }


                string
                f_1350_21827_21841(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 21827, 21841);
                    return return_v;
                }


                string
                f_1350_21853_21863(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 21853, 21863);
                    return return_v;
                }


                bool
                f_1350_21827_21900(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 21827, 21900);
                    return return_v;
                }


                System.Management.Automation.Provider.CmdletProvider
                f_1350_22584_22613(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderInstance(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 22584, 22613);
                    return return_v;
                }


                string
                f_1350_22694_22704(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 22694, 22704);
                    return return_v;
                }


                bool
                f_1350_22673_22705(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 22673, 22705);
                    return return_v;
                }


                string
                f_1350_22752_22762(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 22752, 22762);
                    return return_v;
                }


                bool
                f_1350_22736_22799(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 22736, 22799);
                    return return_v;
                }


                string
                f_1350_23947_23957(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 23947, 23957);
                    return return_v;
                }


                string
                f_1350_23958_23968(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 23958, 23968);
                    return return_v;
                }


                int
                f_1350_23958_23975(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 23958, 23975);
                    return return_v;
                }


                char
                f_1350_23947_23980(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 23947, 23980);
                    return return_v;
                }


                bool
                f_1350_23931_23981(System.Management.Automation.SessionStateInternal
                this_param, char
                c)
                {
                    var return_v = this_param.IsPathSeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 23931, 23981);
                    return return_v;
                }


                string
                f_1350_24143_24153(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 24143, 24153);
                    return return_v;
                }


                int
                f_1350_24143_24160(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 24143, 24160);
                    return return_v;
                }


                int
                f_1350_24256_24267(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 24256, 24267);
                    return return_v;
                }


                char
                f_1350_24287_24312(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 24287, 24312);
                    return return_v;
                }


                bool
                f_1350_24271_24313(System.Management.Automation.SessionStateInternal
                this_param, char
                c)
                {
                    var return_v = this_param.IsPathSeparator(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 24271, 24313);
                    return return_v;
                }


                string
                f_1350_24578_24588(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Root;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 24578, 24588);
                    return return_v;
                }


                int
                f_1350_24578_24595(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 24578, 24595);
                    return return_v;
                }


                int
                f_1350_24599_24610(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 24599, 24610);
                    return return_v;
                }


                string
                f_1350_24912_24975(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider, string
                path, string
                basePath, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.NormalizeRelativePath(provider, path, basePath, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 24912, 24975);
                    return return_v;
                }


                int
                f_1350_25045_25088(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    this_param.RemoveStopReferral();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 25045, 25088);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 19338, 25115);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 19338, 25115);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsPathSeparator(char c)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 25453, 25619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 25514, 25608);

                return c == StringLiterals.DefaultPathSeparator || (DynAbs.Tracing.TraceSender.Expression_False(1350, 25521, 25607) || c == StringLiterals.AlternatePathSeparator);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 25453, 25619);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 25453, 25619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 25453, 25619);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string NormalizeRelativePath(
                    ProviderInfo provider,
                    string path,
                    string basePath,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 26885, 29175);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 27152, 27290);

                f_1350_27152_27289(provider != null, "Caller should validate provider before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 27306, 27436);

                f_1350_27306_27435(path != null, "Caller should validate path before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 27452, 27588);

                f_1350_27452_27587(context != null, "Caller should validate context before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 27654, 27727);

                Provider.CmdletProvider
                providerInstance = f_1350_27697_27726(this, provider)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 27743, 27840);

                NavigationCmdletProvider
                navigationCmdletProvider = providerInstance as NavigationCmdletProvider
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 27854, 29136) || true) && (navigationCmdletProvider != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 27854, 29136);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 27968, 28047);

                        path = f_1350_27975_28046(navigationCmdletProvider, path, basePath, context);
                    }
                    catch (LoopFlowException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 28084, 28175);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 28150, 28156);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 28084, 28175);
                    }
                    catch (PipelineStoppedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 28193, 28291);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 28266, 28272);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 28193, 28291);
                    }
                    catch (ActionPreferenceStopException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 28309, 28412);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 28387, 28393);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 28309, 28412);
                    }
                    catch (Exception e) // Catch-all OK, 3rd party callout.
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 28430, 28854);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 28526, 28835);

                        throw f_1350_28532_28834(this, "NormalizeRelativePathProviderException", f_1350_28652_28710(), f_1350_28737_28774(navigationCmdletProvider), path, e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 28430, 28854);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 27854, 29136);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 27854, 29136);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 28888, 29136) || true) && (providerInstance is ContainerCmdletProvider)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 28888, 29136);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 28888, 29136);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 28888, 29136);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 29074, 29121);

                        throw f_1350_29080_29120();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 28888, 29136);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 27854, 29136);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 29152, 29164);

                return path;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 26885, 29175);

                int
                f_1350_27152_27289(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 27152, 27289);
                    return 0;
                }


                int
                f_1350_27306_27435(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 27306, 27435);
                    return 0;
                }


                int
                f_1350_27452_27587(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 27452, 27587);
                    return 0;
                }


                System.Management.Automation.Provider.CmdletProvider
                f_1350_27697_27726(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = this_param.GetProviderInstance(provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 27697, 27726);
                    return return_v;
                }


                string
                f_1350_27975_28046(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param, string
                path, string
                basePath, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.NormalizeRelativePath(path, basePath, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 27975, 28046);
                    return return_v;
                }


                string
                f_1350_28652_28710()
                {
                    var return_v = SessionStateStrings.NormalizeRelativePathProviderException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 28652, 28710);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1350_28737_28774(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param)
                {
                    var return_v = this_param.ProviderInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 28737, 28774);
                    return return_v;
                }


                System.Management.Automation.ProviderInvocationException
                f_1350_28532_28834(System.Management.Automation.SessionStateInternal
                this_param, string
                resourceId, string
                resourceStr, System.Management.Automation.ProviderInfo
                provider, string
                path, System.Exception
                e)
                {
                    var return_v = this_param.NewProviderInvocationException(resourceId, resourceStr, provider, path, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 28532, 28834);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1350_29080_29120()
                {
                    var return_v = PSTraceSource.NewNotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 29080, 29120);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 26885, 29175);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 26885, 29175);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string MakePath(
                    string parent,
                    string child)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 30445, 30698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 30550, 30631);

                CmdletProviderContext
                context = f_1350_30582_30630(f_1350_30608_30629(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 30647, 30687);

                return f_1350_30654_30686(this, parent, child, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 30445, 30698);

                System.Management.Automation.ExecutionContext
                f_1350_30608_30629(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 30608, 30629);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1350_30582_30630(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 30582, 30630);
                    return return_v;
                }


                string
                f_1350_30654_30686(System.Management.Automation.SessionStateInternal
                this_param, string
                parent, string
                child, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.MakePath(parent, child, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 30654, 30686);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 30445, 30698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 30445, 30698);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string MakePath(
                    string parent,
                    string child,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 32014, 34218);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 32163, 32184);

                string
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 32200, 32324) || true) && (context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 32200, 32324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 32253, 32309);

                    throw f_1350_32259_32308("context");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 32200, 32324);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 32340, 32492) || true) && (parent == null && (DynAbs.Tracing.TraceSender.Expression_True(1350, 32344, 32392) && child == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 32340, 32492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 32426, 32477);

                    throw f_1350_32432_32476("parent");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 32340, 32492);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 32561, 32590);

                ProviderInfo
                provider = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 32604, 32710) || true) && (f_1350_32608_32620() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 32604, 32710);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 32662, 32695);

                    provider = f_1350_32673_32694(f_1350_32673_32685());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 32604, 32710);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 32726, 34177) || true) && (f_1350_32730_32743(context) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 32726, 34177);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 32785, 32860);

                    bool
                    isProviderQualified = f_1350_32812_32859(parent)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 32878, 32935);

                    bool
                    isAbsolute = f_1350_32896_32934(parent)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 32953, 33580) || true) && (isProviderQualified || (DynAbs.Tracing.TraceSender.Expression_False(1350, 32957, 32990) || isAbsolute))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 32953, 33580);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 33032, 33057);

                        PSDriveInfo
                        drive = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 33172, 33238);

                        f_1350_33172_33237(f_1350_33172_33179(), parent, context, out provider, out drive);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 33262, 33404) || true) && (drive == null && (DynAbs.Tracing.TraceSender.Expression_True(1350, 33266, 33302) && isProviderQualified))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 33262, 33404);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 33352, 33381);

                            drive = f_1350_33360_33380(provider);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 33262, 33404);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 33428, 33450);

                        context.Drive = drive;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 32953, 33580);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 32953, 33580);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 33532, 33561);

                        context.Drive = f_1350_33548_33560();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 32953, 33580);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 33600, 33652);

                    result = f_1350_33609_33651(this, provider, parent, child, context);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 33672, 33992) || true) && (isAbsolute)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 33672, 33992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 33728, 33798);

                        result = f_1350_33737_33797(result, f_1350_33783_33796(context));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 33672, 33992);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 33672, 33992);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 33840, 33992) || true) && (isProviderQualified)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 33840, 33992);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 33905, 33973);

                            result = f_1350_33914_33972(result, provider);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 33840, 33992);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 33672, 33992);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 32726, 34177);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 32726, 34177);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 34058, 34092);

                    provider = f_1350_34069_34091(f_1350_34069_34082(context));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 34110, 34162);

                    result = f_1350_34119_34161(this, provider, parent, child, context);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 32726, 34177);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 34193, 34207);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 32014, 34218);

                System.Management.Automation.PSArgumentNullException
                f_1350_32259_32308(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 32259, 32308);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1350_32432_32476(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 32432, 32476);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1350_32608_32620()
                {
                    var return_v = CurrentDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 32608, 32620);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1350_32673_32685()
                {
                    var return_v = CurrentDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 32673, 32685);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1350_32673_32694(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 32673, 32694);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1350_32730_32743(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Drive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 32730, 32743);
                    return return_v;
                }


                bool
                f_1350_32812_32859(string
                path)
                {
                    var return_v = LocationGlobber.IsProviderQualifiedPath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 32812, 32859);
                    return return_v;
                }


                bool
                f_1350_32896_32934(string
                path)
                {
                    var return_v = LocationGlobber.IsAbsolutePath(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 32896, 32934);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1350_33172_33179()
                {
                    var return_v = Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 33172, 33179);
                    return return_v;
                }


                string
                f_1350_33172_33237(System.Management.Automation.LocationGlobber
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.GetProviderPath(path, context, out provider, out drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 33172, 33237);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1350_33360_33380(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.HiddenDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 33360, 33380);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1350_33548_33560()
                {
                    var return_v = CurrentDrive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 33548, 33560);
                    return return_v;
                }


                string
                f_1350_33609_33651(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider, string
                parent, string
                child, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.MakePath(provider, parent, child, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 33609, 33651);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1350_33783_33796(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Drive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 33783, 33796);
                    return return_v;
                }


                string
                f_1350_33737_33797(string
                path, System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = LocationGlobber.GetDriveQualifiedPath(path, drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 33737, 33797);
                    return return_v;
                }


                string
                f_1350_33914_33972(string
                path, System.Management.Automation.ProviderInfo
                provider)
                {
                    var return_v = LocationGlobber.GetProviderQualifiedPath(path, provider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 33914, 33972);
                    return return_v;
                }


                System.Management.Automation.PSDriveInfo
                f_1350_34069_34082(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.Drive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 34069, 34082);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1350_34069_34091(System.Management.Automation.PSDriveInfo
                this_param)
                {
                    var return_v = this_param.Provider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 34069, 34091);
                    return return_v;
                }


                string
                f_1350_34119_34161(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider, string
                parent, string
                child, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.MakePath(provider, parent, child, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 34119, 34161);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 32014, 34218);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 32014, 34218);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string MakePath(
                    ProviderInfo provider,
                    string parent,
                    string child,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 35349, 36112);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 35602, 35740);

                f_1350_35602_35739(provider != null, "Caller should validate provider before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 35756, 35892);

                f_1350_35756_35891(context != null, "Caller should validate context before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 35958, 36027);

                Provider.CmdletProvider
                providerInstance = f_1350_36001_36026(provider)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 36043, 36101);

                return f_1350_36050_36100(this, providerInstance, parent, child, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 35349, 36112);

                int
                f_1350_35602_35739(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 35602, 35739);
                    return 0;
                }


                int
                f_1350_35756_35891(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 35756, 35891);
                    return 0;
                }


                System.Management.Automation.Provider.CmdletProvider
                f_1350_36001_36026(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.CreateInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 36001, 36026);
                    return return_v;
                }


                string
                f_1350_36050_36100(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.Provider.CmdletProvider
                providerInstance, string
                parent, string
                child, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.MakePath(providerInstance, parent, child, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 36050, 36100);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 35349, 36112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 35349, 36112);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string MakePath(
                    CmdletProvider providerInstance,
                    string parent,
                    string child,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 37260, 39312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 37523, 37677);

                f_1350_37523_37676(providerInstance != null, "Caller should validate providerInstance before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 37693, 37829);

                f_1350_37693_37828(context != null, "Caller should validate context before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 37895, 37916);

                string
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 37932, 38029);

                NavigationCmdletProvider
                navigationCmdletProvider = providerInstance as NavigationCmdletProvider
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 38045, 39271) || true) && (navigationCmdletProvider != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 38045, 39271);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 38159, 38226);

                        result = f_1350_38168_38225(navigationCmdletProvider, parent, child, context);
                    }
                    catch (LoopFlowException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 38263, 38354);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 38329, 38335);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 38263, 38354);
                    }
                    catch (PipelineStoppedException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 38372, 38470);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 38445, 38451);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 38372, 38470);
                    }
                    catch (ActionPreferenceStopException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 38488, 38591);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 38566, 38572);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 38488, 38591);
                    }
                    catch (Exception e) // Catch-all OK, 3rd party callout.
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 38609, 39013);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 38705, 38994);

                        throw f_1350_38711_38993(this, "MakePathProviderException", f_1350_38822_38867(), f_1350_38894_38931(navigationCmdletProvider), parent, e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 38609, 39013);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 38045, 39271);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 38045, 39271);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 39047, 39271) || true) && (providerInstance is ContainerCmdletProvider)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 39047, 39271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 39128, 39143);

                        result = child;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 39047, 39271);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 39047, 39271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 39209, 39256);

                        throw f_1350_39215_39255();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 39047, 39271);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 38045, 39271);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 39287, 39301);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 37260, 39312);

                int
                f_1350_37523_37676(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 37523, 37676);
                    return 0;
                }


                int
                f_1350_37693_37828(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 37693, 37828);
                    return 0;
                }


                string
                f_1350_38168_38225(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param, string
                parent, string
                child, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.MakePath(parent, child, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 38168, 38225);
                    return return_v;
                }


                string
                f_1350_38822_38867()
                {
                    var return_v = SessionStateStrings.MakePathProviderException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 38822, 38867);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1350_38894_38931(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param)
                {
                    var return_v = this_param.ProviderInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 38894, 38931);
                    return return_v;
                }


                System.Management.Automation.ProviderInvocationException
                f_1350_38711_38993(System.Management.Automation.SessionStateInternal
                this_param, string
                resourceId, string
                resourceStr, System.Management.Automation.ProviderInfo
                provider, string
                path, System.Exception
                e)
                {
                    var return_v = this_param.NewProviderInvocationException(resourceId, resourceStr, provider, path, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 38711, 38993);
                    return return_v;
                }


                System.Management.Automation.PSNotSupportedException
                f_1350_39215_39255()
                {
                    var return_v = PSTraceSource.NewNotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 39215, 39255);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 37260, 39312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 37260, 39312);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetChildName(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 40503, 40938);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 40569, 40687) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 40569, 40687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 40619, 40672);

                    throw f_1350_40625_40671("path");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 40569, 40687);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 40703, 40784);

                CmdletProviderContext
                context = f_1350_40735_40783(f_1350_40761_40782(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 40800, 40844);

                string
                result = f_1350_40816_40843(this, path, context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 40860, 40897);

                f_1350_40860_40896(
                            context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 40913, 40927);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 40503, 40938);

                System.Management.Automation.PSArgumentNullException
                f_1350_40625_40671(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 40625, 40671);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1350_40761_40782(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 40761, 40782);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1350_40735_40783(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 40735, 40783);
                    return return_v;
                }


                string
                f_1350_40816_40843(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetChildName(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 40816, 40843);
                    return return_v;
                }


                int
                f_1350_40860_40896(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    this_param.ThrowFirstErrorOrDoNothing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 40860, 40896);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 40503, 40938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 40503, 40938);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetChildName(
                    string path,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 42184, 42361);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 42308, 42350);

                return f_1350_42315_42349(this, path, context, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 42184, 42361);

                string
                f_1350_42315_42349(System.Management.Automation.SessionStateInternal
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, bool
                useDefaultProvider)
                {
                    var return_v = this_param.GetChildName(path, context, useDefaultProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 42315, 42349);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 42184, 42361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 42184, 42361);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string GetChildName(
                    string path,
                    CmdletProviderContext context,
                    bool useDefaultProvider)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 43066, 45087);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 43228, 43346) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 43228, 43346);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 43278, 43331);

                    throw f_1350_43284_43330("path");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 43228, 43346);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 43362, 43387);

                PSDriveInfo
                drive = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 43401, 43430);

                ProviderInfo
                provider = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 43444, 43470);

                string
                workingPath = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 43522, 43600);

                    workingPath = f_1350_43536_43599(f_1350_43536_43543(), path, context, out provider, out drive);
                }
                catch (DriveNotFoundException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 43629, 44486);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 43901, 44471) || true) && (useDefaultProvider)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 43901, 44471);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 44024, 44144);

                        provider = f_1350_44035_44143(f_1350_44035_44062(f_1350_44035_44053()), Microsoft.PowerShell.Commands.FileSystemProvider.ProviderName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 44168, 44271);

                        workingPath = f_1350_44182_44270(path, StringLiterals.AlternatePathSeparator, StringLiterals.DefaultPathSeparator);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 44293, 44364);

                        workingPath = f_1350_44307_44363(workingPath, StringLiterals.DefaultPathSeparator);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 43901, 44471);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 43901, 44471);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 44446, 44452);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 43901, 44471);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 43629, 44486);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 44502, 44688);

                f_1350_44502_44687(workingPath != null, "There should always be a way to generate a UniversalResourceName for a " +
                                "given path");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 44704, 44904);

                f_1350_44704_44903(provider != null, "There should always be a way to get the provider ID for a given path or else GetProviderPath should have thrown an exception");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 44920, 45008) || true) && (drive != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 44920, 45008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 44971, 44993);

                    context.Drive = drive;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 44920, 45008);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 45024, 45076);

                return f_1350_45031_45075(this, provider, workingPath, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 43066, 45087);

                System.Management.Automation.PSArgumentNullException
                f_1350_43284_43330(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 43284, 43330);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1350_43536_43543()
                {
                    var return_v = Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 43536, 43543);
                    return return_v;
                }


                string
                f_1350_43536_43599(System.Management.Automation.LocationGlobber
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.GetProviderPath(path, context, out provider, out drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 43536, 43599);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1350_44035_44053()
                {
                    var return_v = PublicSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 44035, 44053);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1350_44035_44062(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 44035, 44062);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1350_44035_44143(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetSingleProvider(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 44035, 44143);
                    return return_v;
                }


                string
                f_1350_44182_44270(string
                this_param, char
                oldChar, char
                newChar)
                {
                    var return_v = this_param.Replace(oldChar, newChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 44182, 44270);
                    return return_v;
                }


                string
                f_1350_44307_44363(string
                this_param, char
                trimChar)
                {
                    var return_v = this_param.TrimEnd(trimChar);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 44307, 44363);
                    return return_v;
                }


                int
                f_1350_44502_44687(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 44502, 44687);
                    return 0;
                }


                int
                f_1350_44704_44903(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 44704, 44903);
                    return 0;
                }


                string
                f_1350_45031_45075(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.ProviderInfo
                provider, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetChildName(provider, path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 45031, 45075);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 43066, 45087);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 43066, 45087);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetChildName(
                    ProviderInfo provider,
                    string path,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 46007, 46833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 46234, 46372);

                f_1350_46234_46371(provider != null, "Caller should validate provider before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 46388, 46519);

                f_1350_46388_46518(path != null, "Caller should validate path before callin g this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 46535, 46671);

                f_1350_46535_46670(context != null, "Caller should validate context before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 46687, 46747);

                CmdletProvider
                providerInstance = f_1350_46721_46746(provider)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 46763, 46822);

                return f_1350_46770_46821(this, providerInstance, path, context, true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 46007, 46833);

                int
                f_1350_46234_46371(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 46234, 46371);
                    return 0;
                }


                int
                f_1350_46388_46518(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 46388, 46518);
                    return 0;
                }


                int
                f_1350_46535_46670(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 46535, 46670);
                    return 0;
                }


                System.Management.Automation.Provider.CmdletProvider
                f_1350_46721_46746(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.CreateInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 46721, 46746);
                    return return_v;
                }


                string
                f_1350_46770_46821(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.Provider.CmdletProvider
                providerInstance, string
                path, System.Management.Automation.CmdletProviderContext
                context, bool
                acceptNonContainerProviders)
                {
                    var return_v = this_param.GetChildName(providerInstance, path, context, acceptNonContainerProviders);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 46770, 46821);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 46007, 46833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 46007, 46833);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetChildName(
                    CmdletProvider providerInstance,
                    string path,
                    CmdletProviderContext context,
                    bool acceptNonContainerProviders
                    )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 47982, 49874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 48280, 48434);

                f_1350_48280_48433(providerInstance != null, "Caller should validate providerInstance before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 48450, 48580);

                f_1350_48450_48579(path != null, "Caller should validate path before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 48596, 48732);

                f_1350_48596_48731(context != null, "Caller should validate context before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 48748, 48769);

                string
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 48785, 48931);

                NavigationCmdletProvider
                navigationCmdletProvider =
                f_1350_48854_48930(providerInstance, acceptNonContainerProviders)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 48947, 49014) || true) && (navigationCmdletProvider == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 48947, 49014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 49002, 49014);

                    return path;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 48947, 49014);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 49066, 49128);

                    result = f_1350_49075_49127(navigationCmdletProvider, path, context);
                }
                catch (LoopFlowException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 49157, 49236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 49215, 49221);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 49157, 49236);
                }
                catch (PipelineStoppedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 49250, 49336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 49315, 49321);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 49250, 49336);
                }
                catch (ActionPreferenceStopException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 49350, 49441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 49420, 49426);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 49350, 49441);
                }
                catch (Exception e) // Catch-all OK, 3rd party callout.
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 49455, 49833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 49543, 49818);

                    throw f_1350_49549_49817(this, "GetChildNameProviderException", f_1350_49656_49705(), f_1350_49728_49765(navigationCmdletProvider), path, e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 49455, 49833);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 49849, 49863);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 47982, 49874);

                int
                f_1350_48280_48433(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 48280, 48433);
                    return 0;
                }


                int
                f_1350_48450_48579(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 48450, 48579);
                    return 0;
                }


                int
                f_1350_48596_48731(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 48596, 48731);
                    return 0;
                }


                System.Management.Automation.Provider.NavigationCmdletProvider
                f_1350_48854_48930(System.Management.Automation.Provider.CmdletProvider
                providerInstance, bool
                acceptNonContainerProviders)
                {
                    var return_v = GetNavigationProviderInstance(providerInstance, acceptNonContainerProviders);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 48854, 48930);
                    return return_v;
                }


                string
                f_1350_49075_49127(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.GetChildName(path, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 49075, 49127);
                    return return_v;
                }


                string
                f_1350_49656_49705()
                {
                    var return_v = SessionStateStrings.GetChildNameProviderException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 49656, 49705);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1350_49728_49765(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param)
                {
                    var return_v = this_param.ProviderInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 49728, 49765);
                    return return_v;
                }


                System.Management.Automation.ProviderInvocationException
                f_1350_49549_49817(System.Management.Automation.SessionStateInternal
                this_param, string
                resourceId, string
                resourceStr, System.Management.Automation.ProviderInfo
                provider, string
                path, System.Exception
                e)
                {
                    var return_v = this_param.NewProviderInvocationException(resourceId, resourceStr, provider, path, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 49549, 49817);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 47982, 49874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 47982, 49874);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<PSObject> MoveItem(string[] paths, string destination, bool force, bool literalPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 51858, 52550);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 51987, 52107) || true) && (paths == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 51987, 52107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 52038, 52092);

                    throw f_1350_52044_52091("paths");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 51987, 52107);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 52123, 52204);

                CmdletProviderContext
                context = f_1350_52155_52203(f_1350_52181_52202(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 52218, 52240);

                context.Force = force;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 52254, 52302);

                context.SuppressWildcardExpansion = literalPath;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 52318, 52356);

                f_1350_52318_52355(this, paths, destination, context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 52372, 52409);

                f_1350_52372_52408(
                            context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 52500, 52539);

                return f_1350_52507_52538(context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 51858, 52550);

                System.Management.Automation.PSArgumentNullException
                f_1350_52044_52091(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 52044, 52091);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1350_52181_52202(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 52181, 52202);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1350_52155_52203(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 52155, 52203);
                    return return_v;
                }


                int
                f_1350_52318_52355(System.Management.Automation.SessionStateInternal
                this_param, string[]
                paths, string
                destination, System.Management.Automation.CmdletProviderContext
                context)
                {
                    this_param.MoveItem(paths, destination, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 52318, 52355);
                    return 0;
                }


                int
                f_1350_52372_52408(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    this_param.ThrowFirstErrorOrDoNothing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 52372, 52408);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1350_52507_52538(System.Management.Automation.CmdletProviderContext
                this_param)
                {
                    var return_v = this_param.GetAccumulatedObjects();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 52507, 52538);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 51858, 52550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 51858, 52550);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void MoveItem(
                    string[] paths,
                    string destination,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 54151, 59457);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 54305, 54425) || true) && (paths == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 54305, 54425);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 54356, 54410);

                    throw f_1350_54362_54409("paths");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 54305, 54425);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 54441, 54573) || true) && (destination == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 54441, 54573);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 54498, 54558);

                    throw f_1350_54504_54557("destination");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 54441, 54573);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 54589, 54618);

                ProviderInfo
                provider = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 54632, 54671);

                CmdletProvider
                providerInstance = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 54687, 54929);

                Collection<PathInfo>
                providerDestinationPaths =
                f_1350_54752_54928(f_1350_54752_54759(), destination, true, context, out providerInstance)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 54945, 59446) || true) && (f_1350_54949_54979(providerDestinationPaths) > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 54945, 59446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 55017, 55216);

                    ArgumentException
                    argException =
                    f_1350_55071_55215("destination", f_1350_55172_55214())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 55236, 55363);

                    f_1350_55236_55362(
                                    context, f_1350_55255_55361(argException, f_1350_55285_55316(f_1350_55285_55307(argException)), ErrorCategory.InvalidArgument, destination));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 54945, 59446);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 54945, 59446);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 55429, 59431);
                        foreach (string path in f_1350_55453_55458_I(paths))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 55429, 59431);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 55500, 55643) || true) && (path == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 55500, 55643);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 55566, 55620);

                                throw f_1350_55572_55619("paths");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 55500, 55643);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 55667, 55976);

                            Collection<string>
                            providerPaths =
                            f_1350_55727_55975(f_1350_55727_55734(), path, false, context, out provider, out providerInstance)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 56146, 59412) || true) && (f_1350_56150_56169(providerPaths) > 1 && (DynAbs.Tracing.TraceSender.Expression_True(1350, 56150, 56236) && f_1350_56202_56232(providerDestinationPaths) > 0) && (DynAbs.Tracing.TraceSender.Expression_True(1350, 56150, 56315) && !f_1350_56266_56315(this, f_1350_56282_56314(f_1350_56282_56309(providerDestinationPaths, 0)))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 56146, 59412);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 56365, 56602);

                                ArgumentException
                                argException =
                                f_1350_56427_56601("path", f_1350_56537_56600())
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 56630, 56773);

                                f_1350_56630_56772(
                                                        context, f_1350_56649_56771(argException, f_1350_56679_56710(f_1350_56679_56701(argException)), ErrorCategory.InvalidArgument, f_1350_56743_56770(providerDestinationPaths, 0)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 56146, 59412);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 56146, 59412);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 56871, 56908);

                                PSDriveInfo
                                unusedPSDriveInfo = null
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 56934, 56974);

                                ProviderInfo
                                destinationProvider = null
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 57002, 57094);

                                CmdletProviderContext
                                destinationContext = f_1350_57045_57093(f_1350_57071_57092(this))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 57122, 57168);

                                string
                                destinationProviderInternalPath = null
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 57196, 58241) || true) && (f_1350_57200_57230(providerDestinationPaths) > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 57196, 58241);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 57292, 57634);

                                    destinationProviderInternalPath =
                                    f_1350_57359_57633(f_1350_57359_57366(), f_1350_57421_57453(f_1350_57421_57448(providerDestinationPaths, 0)), destinationContext, out destinationProvider, out unusedPSDriveInfo);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 57196, 58241);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 57196, 58241);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 57893, 58214);

                                    destinationProviderInternalPath =
                                    f_1350_57960_58213(f_1350_57960_57967(), destination, destinationContext, out destinationProvider, out unusedPSDriveInfo);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 57196, 58241);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 58338, 59389) || true) && (!f_1350_58343_58541(f_1350_58391_58408(provider), f_1350_58443_58471(destinationProvider), StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 58338, 59389);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 58599, 58855);

                                    ArgumentException
                                    argException =
                                    f_1350_58665_58854("destination", f_1350_58790_58853())
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 58887, 59016);

                                    f_1350_58887_59015(
                                                                context, f_1350_58906_59014(argException, f_1350_58936_58967(f_1350_58936_58958(argException)), ErrorCategory.InvalidArgument, providerPaths));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 58338, 59389);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 58338, 59389);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 59130, 59362);
                                        foreach (string providerPath in f_1350_59162_59175_I(providerPaths))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 59130, 59362);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 59241, 59331);

                                            f_1350_59241_59330(this, providerInstance, providerPath, destinationProviderInternalPath, context);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 59130, 59362);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1350, 1, 233);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1350, 1, 233);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 58338, 59389);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 56146, 59412);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 55429, 59431);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1350, 1, 4003);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1350, 1, 4003);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 54945, 59446);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 54151, 59457);

                System.Management.Automation.PSArgumentNullException
                f_1350_54362_54409(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 54362, 54409);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1350_54504_54557(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 54504, 54557);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1350_54752_54759()
                {
                    var return_v = Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 54752, 54759);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                f_1350_54752_54928(System.Management.Automation.LocationGlobber
                this_param, string
                path, bool
                allowNonexistingPaths, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.Provider.CmdletProvider
                providerInstance)
                {
                    var return_v = this_param.GetGlobbedMonadPathsFromMonadPath(path, allowNonexistingPaths, context, out providerInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 54752, 54928);
                    return return_v;
                }


                int
                f_1350_54949_54979(System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 54949, 54979);
                    return return_v;
                }


                string
                f_1350_55172_55214()
                {
                    var return_v = SessionStateStrings.MoveItemOneDestination;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 55172, 55214);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1350_55071_55215(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 55071, 55215);
                    return return_v;
                }


                System.Type
                f_1350_55285_55307(System.ArgumentException
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 55285, 55307);
                    return return_v;
                }


                string
                f_1350_55285_55316(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 55285, 55316);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1350_55255_55361(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 55255, 55361);
                    return return_v;
                }


                int
                f_1350_55236_55362(System.Management.Automation.CmdletProviderContext
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 55236, 55362);
                    return 0;
                }


                System.Management.Automation.PSArgumentNullException
                f_1350_55572_55619(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 55572, 55619);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1350_55727_55734()
                {
                    var return_v = Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 55727, 55734);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1350_55727_55975(System.Management.Automation.LocationGlobber
                this_param, string
                path, bool
                allowNonexistingPaths, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.Provider.CmdletProvider
                providerInstance)
                {
                    var return_v = this_param.GetGlobbedProviderPathsFromMonadPath(path, allowNonexistingPaths, context, out provider, out providerInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 55727, 55975);
                    return return_v;
                }


                int
                f_1350_56150_56169(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 56150, 56169);
                    return return_v;
                }


                int
                f_1350_56202_56232(System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 56202, 56232);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1350_56282_56309(System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 56282, 56309);
                    return return_v;
                }


                string
                f_1350_56282_56314(System.Management.Automation.PathInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 56282, 56314);
                    return return_v;
                }


                bool
                f_1350_56266_56315(System.Management.Automation.SessionStateInternal
                this_param, string
                path)
                {
                    var return_v = this_param.IsItemContainer(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 56266, 56315);
                    return return_v;
                }


                string
                f_1350_56537_56600()
                {
                    var return_v = SessionStateStrings.MoveItemPathMultipleDestinationNotContainer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 56537, 56600);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1350_56427_56601(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 56427, 56601);
                    return return_v;
                }


                System.Type
                f_1350_56679_56701(System.ArgumentException
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 56679, 56701);
                    return return_v;
                }


                string
                f_1350_56679_56710(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 56679, 56710);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1350_56743_56770(System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 56743, 56770);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1350_56649_56771(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.PathInfo
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 56649, 56771);
                    return return_v;
                }


                int
                f_1350_56630_56772(System.Management.Automation.CmdletProviderContext
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 56630, 56772);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1350_57071_57092(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 57071, 57092);
                    return return_v;
                }


                System.Management.Automation.CmdletProviderContext
                f_1350_57045_57093(System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 57045, 57093);
                    return return_v;
                }


                int
                f_1350_57200_57230(System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 57200, 57230);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1350_57359_57366()
                {
                    var return_v = Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 57359, 57366);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1350_57421_57448(System.Collections.ObjectModel.Collection<System.Management.Automation.PathInfo>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 57421, 57448);
                    return return_v;
                }


                string
                f_1350_57421_57453(System.Management.Automation.PathInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 57421, 57453);
                    return return_v;
                }


                string
                f_1350_57359_57633(System.Management.Automation.LocationGlobber
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.GetProviderPath(path, context, out provider, out drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 57359, 57633);
                    return return_v;
                }


                System.Management.Automation.LocationGlobber
                f_1350_57960_57967()
                {
                    var return_v = Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 57960, 57967);
                    return return_v;
                }


                string
                f_1350_57960_58213(System.Management.Automation.LocationGlobber
                this_param, string
                path, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.PSDriveInfo
                drive)
                {
                    var return_v = this_param.GetProviderPath(path, context, out provider, out drive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 57960, 58213);
                    return return_v;
                }


                string
                f_1350_58391_58408(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 58391, 58408);
                    return return_v;
                }


                string
                f_1350_58443_58471(System.Management.Automation.ProviderInfo
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 58443, 58471);
                    return return_v;
                }


                bool
                f_1350_58343_58541(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 58343, 58541);
                    return return_v;
                }


                string
                f_1350_58790_58853()
                {
                    var return_v = SessionStateStrings.MoveItemSourceAndDestinationNotSameProvider;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 58790, 58853);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1350_58665_58854(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 58665, 58854);
                    return return_v;
                }


                System.Type
                f_1350_58936_58958(System.ArgumentException
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 58936, 58958);
                    return return_v;
                }


                string
                f_1350_58936_58967(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 58936, 58967);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1350_58906_59014(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, System.Collections.ObjectModel.Collection<string>
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 58906, 59014);
                    return return_v;
                }


                int
                f_1350_58887_59015(System.Management.Automation.CmdletProviderContext
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 58887, 59015);
                    return 0;
                }


                int
                f_1350_59241_59330(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.Provider.CmdletProvider
                providerInstance, string
                path, string
                destination, System.Management.Automation.CmdletProviderContext
                context)
                {
                    this_param.MoveItemPrivate(providerInstance, path, destination, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 59241, 59330);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1350_59162_59175_I(System.Collections.ObjectModel.Collection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 59162, 59175);
                    return return_v;
                }


                string[]
                f_1350_55453_55458_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 55453, 55458);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 54151, 59457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 54151, 59457);
            }
        }

        private void MoveItemPrivate(
                    CmdletProvider providerInstance,
                    string path,
                    string destination,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 60530, 62215);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 60801, 60955);

                f_1350_60801_60954(providerInstance != null, "Caller should validate providerInstance before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 60971, 61101);

                f_1350_60971_61100(path != null, "Caller should validate path before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 61117, 61253);

                f_1350_61117_61252(context != null, "Caller should validate context before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 61269, 61393);

                NavigationCmdletProvider
                navigationCmdletProvider =
                f_1350_61338_61392(providerInstance, false)
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 61445, 61507);

                    f_1350_61445_61506(navigationCmdletProvider, path, destination, context);
                }
                catch (LoopFlowException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 61536, 61615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 61594, 61600);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 61536, 61615);
                }
                catch (PipelineStoppedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 61629, 61715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 61694, 61700);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 61629, 61715);
                }
                catch (ActionPreferenceStopException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 61729, 61820);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 61799, 61805);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 61729, 61820);
                }
                catch (Exception e) // Catch-all OK, 3rd party callout.
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 61834, 62204);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 61922, 62189);

                    throw f_1350_61928_62188(this, "MoveItemProviderException", f_1350_62031_62076(), f_1350_62099_62136(navigationCmdletProvider), path, e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 61834, 62204);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 60530, 62215);

                int
                f_1350_60801_60954(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 60801, 60954);
                    return 0;
                }


                int
                f_1350_60971_61100(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 60971, 61100);
                    return 0;
                }


                int
                f_1350_61117_61252(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 61117, 61252);
                    return 0;
                }


                System.Management.Automation.Provider.NavigationCmdletProvider
                f_1350_61338_61392(System.Management.Automation.Provider.CmdletProvider
                providerInstance, bool
                acceptNonContainerProviders)
                {
                    var return_v = GetNavigationProviderInstance(providerInstance, acceptNonContainerProviders);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 61338, 61392);
                    return return_v;
                }


                int
                f_1350_61445_61506(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param, string
                path, string
                destination, System.Management.Automation.CmdletProviderContext
                context)
                {
                    this_param.MoveItem(path, destination, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 61445, 61506);
                    return 0;
                }


                string
                f_1350_62031_62076()
                {
                    var return_v = SessionStateStrings.MoveItemProviderException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 62031, 62076);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1350_62099_62136(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param)
                {
                    var return_v = this_param.ProviderInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 62099, 62136);
                    return return_v;
                }


                System.Management.Automation.ProviderInvocationException
                f_1350_61928_62188(System.Management.Automation.SessionStateInternal
                this_param, string
                resourceId, string
                resourceStr, System.Management.Automation.ProviderInfo
                provider, string
                path, System.Exception
                e)
                {
                    var return_v = this_param.NewProviderInvocationException(resourceId, resourceStr, provider, path, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 61928, 62188);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 60530, 62215);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 60530, 62215);
            }
        }

        internal object MoveItemDynamicParameters(
                    string path,
                    string destination,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 63734, 64909);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 63904, 63981) || true) && (path == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 63904, 63981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 63954, 63966);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 63904, 63981);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 63997, 64026);

                ProviderInfo
                provider = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 64040, 64079);

                CmdletProvider
                providerInstance = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 64095, 64182);

                CmdletProviderContext
                newContext =
                f_1350_64147_64181(context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 64196, 64328);

                f_1350_64196_64327(newContext, f_1350_64236_64260(), f_1350_64279_64303(), null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 64344, 64607);

                Collection<string>
                providerPaths =
                f_1350_64396_64606(f_1350_64396_64403(), path, true, newContext, out provider, out providerInstance)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 64623, 64870) || true) && (f_1350_64627_64646(providerPaths) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1350, 64623, 64870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 64761, 64855);

                    return f_1350_64768_64854(this, providerInstance, f_1350_64812_64828(providerPaths, 0), destination, newContext);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1350, 64623, 64870);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 64886, 64898);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 63734, 64909);

                System.Management.Automation.CmdletProviderContext
                f_1350_64147_64181(System.Management.Automation.CmdletProviderContext
                contextToCopyFrom)
                {
                    var return_v = new System.Management.Automation.CmdletProviderContext(contextToCopyFrom);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 64147, 64181);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1350_64236_64260()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 64236, 64260);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1350_64279_64303()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 64279, 64303);
                    return return_v;
                }


                int
                f_1350_64196_64327(System.Management.Automation.CmdletProviderContext
                this_param, System.Collections.ObjectModel.Collection<string>
                include, System.Collections.ObjectModel.Collection<string>
                exclude, string
                filter)
                {
                    this_param.SetFilters(include, exclude, filter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 64196, 64327);
                    return 0;
                }


                System.Management.Automation.LocationGlobber
                f_1350_64396_64403()
                {
                    var return_v = Globber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 64396, 64403);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1350_64396_64606(System.Management.Automation.LocationGlobber
                this_param, string
                path, bool
                allowNonexistingPaths, System.Management.Automation.CmdletProviderContext
                context, out System.Management.Automation.ProviderInfo
                provider, out System.Management.Automation.Provider.CmdletProvider
                providerInstance)
                {
                    var return_v = this_param.GetGlobbedProviderPathsFromMonadPath(path, allowNonexistingPaths, context, out provider, out providerInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 64396, 64606);
                    return return_v;
                }


                int
                f_1350_64627_64646(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 64627, 64646);
                    return return_v;
                }


                string
                f_1350_64812_64828(System.Collections.ObjectModel.Collection<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 64812, 64828);
                    return return_v;
                }


                object
                f_1350_64768_64854(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.Provider.CmdletProvider
                providerInstance, string
                path, string
                destination, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.MoveItemDynamicParameters(providerInstance, path, destination, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 64768, 64854);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 63734, 64909);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 63734, 64909);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private object MoveItemDynamicParameters(
                    CmdletProvider providerInstance,
                    string path,
                    string destination,
                    CmdletProviderContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1350, 66156, 68077);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 66439, 66593);

                f_1350_66439_66592(providerInstance != null, "Caller should validate providerInstance before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 66609, 66739);

                f_1350_66609_66738(path != null, "Caller should validate path before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 66755, 66891);

                f_1350_66755_66890(context != null, "Caller should validate context before calling this method");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 66907, 67031);

                NavigationCmdletProvider
                navigationCmdletProvider =
                f_1350_66976_67030(providerInstance, false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 67047, 67068);

                object
                result = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 67120, 67208);

                    result = f_1350_67129_67207(navigationCmdletProvider, path, destination, context);
                }
                catch (NotSupportedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 67237, 67320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 67299, 67305);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 67237, 67320);
                }
                catch (LoopFlowException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 67334, 67413);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 67392, 67398);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 67334, 67413);
                }
                catch (PipelineStoppedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 67427, 67513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 67492, 67498);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 67427, 67513);
                }
                catch (ActionPreferenceStopException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 67527, 67618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 67597, 67603);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 67527, 67618);
                }
                catch (Exception e) // Catch-all OK, 3rd party callout.
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1350, 67632, 68036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 67720, 68021);

                    throw f_1350_67726_68020(this, "MoveItemDynamicParametersProviderException", f_1350_67846_67908(), f_1350_67931_67968(navigationCmdletProvider), path, e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1350, 67632, 68036);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1350, 68052, 68066);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1350, 66156, 68077);

                int
                f_1350_66439_66592(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 66439, 66592);
                    return 0;
                }


                int
                f_1350_66609_66738(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 66609, 66738);
                    return 0;
                }


                int
                f_1350_66755_66890(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 66755, 66890);
                    return 0;
                }


                System.Management.Automation.Provider.NavigationCmdletProvider
                f_1350_66976_67030(System.Management.Automation.Provider.CmdletProvider
                providerInstance, bool
                acceptNonContainerProviders)
                {
                    var return_v = GetNavigationProviderInstance(providerInstance, acceptNonContainerProviders);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 66976, 67030);
                    return return_v;
                }


                object
                f_1350_67129_67207(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param, string
                path, string
                destination, System.Management.Automation.CmdletProviderContext
                context)
                {
                    var return_v = this_param.MoveItemDynamicParameters(path, destination, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 67129, 67207);
                    return return_v;
                }


                string
                f_1350_67846_67908()
                {
                    var return_v = SessionStateStrings.MoveItemDynamicParametersProviderException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 67846, 67908);
                    return return_v;
                }


                System.Management.Automation.ProviderInfo
                f_1350_67931_67968(System.Management.Automation.Provider.NavigationCmdletProvider
                this_param)
                {
                    var return_v = this_param.ProviderInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1350, 67931, 67968);
                    return return_v;
                }


                System.Management.Automation.ProviderInvocationException
                f_1350_67726_68020(System.Management.Automation.SessionStateInternal
                this_param, string
                resourceId, string
                resourceStr, System.Management.Automation.ProviderInfo
                provider, string
                path, System.Exception
                e)
                {
                    var return_v = this_param.NewProviderInvocationException(resourceId, resourceStr, provider, path, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1350, 67726, 68020);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1350, 66156, 68077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1350, 66156, 68077);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}

#pragma warning restore 56500

