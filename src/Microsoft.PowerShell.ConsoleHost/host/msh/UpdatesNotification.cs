// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Globalization;
using System.IO;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Microsoft.PowerShell
{
    internal static class UpdatesNotification
    {
        private const string
        UpdateCheckEnvVar = "POWERSHELL_UPDATECHECK"
        ;

        private const string
        LTSBuildInfoURL = "https://aka.ms/pwsh-buildinfo-lts"
        ;

        private const string
        StableBuildInfoURL = "https://aka.ms/pwsh-buildinfo-stable"
        ;

        private const string
        PreviewBuildInfoURL = "https://aka.ms/pwsh-buildinfo-preview"
        ;

        private static readonly string s_updateFileNameTemplate, s_updateFileNamePattern;

        private static readonly string s_sentinelFileName, s_doneFileNameTemplate, s_doneFileNamePattern;

        private static readonly string s_cacheDirectory;

        private static readonly EnumerationOptions s_enumOptions;

        private static readonly NotificationType s_notificationType;

        internal static readonly bool CanNotifyUpdates;

        static UpdatesNotification()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(129, 2756, 3710);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 796, 840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 872, 925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 957, 1016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 1048, 1109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 1541, 1565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 1567, 1590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 2294, 2312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 2314, 2336);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 2338, 2359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 2403, 2419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 2473, 2486);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 2538, 2556);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 2727, 2743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 2809, 2852);

                s_notificationType = f_129_2830_2851();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 2866, 2928);

                CanNotifyUpdates = s_notificationType != NotificationType.Off;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 2944, 3699) || true) && (CanNotifyUpdates)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 2944, 3699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 2998, 3039);

                    s_enumOptions = f_129_3014_3038();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 3057, 3141);

                    s_cacheDirectory = f_129_3076_3140(Platform.CacheDirectory, f_129_3114_3139());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 3254, 3308);

                    string
                    typeNum = f_129_3271_3307(((int)s_notificationType))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 3326, 3370);

                    s_sentinelFileName = $"_sentinel{typeNum}_";
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 3388, 3457);

                    s_doneFileNameTemplate = $"sentinel{typeNum}-{{0}}-{{1}}-{{2}}.done";
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 3475, 3527);

                    s_doneFileNamePattern = $"sentinel{typeNum}-*.done";
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 3545, 3603);

                    s_updateFileNameTemplate = $"update{typeNum}_{{0}}_{{1}}";
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 3621, 3684);

                    s_updateFileNamePattern = $"update{typeNum}_v*.*.*_????-??-??";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(129, 2944, 3699);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(129, 2756, 3710);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(129, 2756, 3710);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(129, 2756, 3710);
            }
        }

        internal static void ShowUpdateNotification(PSHostUserInterface hostUI)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(129, 4123, 6587);
                System.Management.Automation.SemanticVersion lastUpdateVersion = default(System.Management.Automation.SemanticVersion);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 4219, 4314) || true) && (!f_129_4224_4258(s_cacheDirectory))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 4219, 4314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 4292, 4299);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(129, 4219, 4314);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 4330, 6576) || true) && (f_129_4334_4501(updateFilePath: out _, out lastUpdateVersion, lastUpdateDate: out _) && (DynAbs.Tracing.TraceSender.Expression_True(129, 4334, 4546) && lastUpdateVersion != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 4330, 6576);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 4580, 4629);

                    string
                    releaseTag = f_129_4600_4628(lastUpdateVersion)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 4647, 5042);

                    string
                    notificationMsgTemplate = (DynAbs.Tracing.TraceSender.Conditional_F1(129, 4680, 4722) || ((s_notificationType == NotificationType.LTS
                    && DynAbs.Tracing.TraceSender.Conditional_F2(129, 4746, 4797)) || DynAbs.Tracing.TraceSender.Conditional_F3(129, 4821, 5041))) ? f_129_4746_4797() : (DynAbs.Tracing.TraceSender.Conditional_F1(129, 4821, 4876) || ((f_129_4821_4876(f_129_4842_4875(lastUpdateVersion)) && DynAbs.Tracing.TraceSender.Conditional_F2(129, 4904, 4958)) || DynAbs.Tracing.TraceSender.Conditional_F3(129, 4986, 5041))) ? f_129_4904_4958() : f_129_4986_5041()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 5062, 5102);

                    string
                    notificationColor = string.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 5120, 5153);

                    string
                    resetColor = string.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 5173, 5208);

                    string
                    line2Padding = string.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 5226, 5261);

                    string
                    line3Padding = string.Empty
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 5363, 6324) || true) && (f_129_5367_5397(hostUI))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 5363, 6324);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 5481, 5511);

                        notificationColor = "\x1B[7m";
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 5533, 5556);

                        resetColor = "\x1B[0m";
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 5680, 5736);

                        int
                        line1Length = f_129_5698_5735(notificationMsgTemplate, '\n')
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 5758, 5831);

                        int
                        line2Length = f_129_5776_5830(notificationMsgTemplate, '\n', line1Length + 1)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 5853, 5926);

                        int
                        line3Length = f_129_5871_5925(notificationMsgTemplate, '\n', line2Length + 1)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 5948, 5979);

                        line3Length -= line2Length + 1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 6001, 6032);

                        line2Length -= line1Length + 1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 6056, 6140);

                        line2Padding = f_129_6071_6139(line2Padding, line1Length - line2Length + f_129_6121_6138(releaseTag));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 6237, 6305);

                        line3Padding = f_129_6252_6304(line3Padding, line1Length - line3Length + 3);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(129, 5363, 6324);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 6344, 6507);

                    string
                    notificationMsg = f_129_6369_6506(f_129_6383_6409(), notificationMsgTemplate, releaseTag, notificationColor, resetColor, line2Padding, line3Padding)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 6527, 6561);

                    f_129_6527_6560(
                                    hostUI, notificationMsg);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(129, 4330, 6576);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(129, 4123, 6587);

                bool
                f_129_4224_4258(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 4224, 4258);
                    return return_v;
                }


                bool
                f_129_4334_4501(out string
                updateFilePath, out System.Management.Automation.SemanticVersion
                lastUpdateVersion, out System.DateTime
                lastUpdateDate)
                {
                    var return_v = TryParseUpdateFile(out updateFilePath, out lastUpdateVersion, out lastUpdateDate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 4334, 4501);
                    return return_v;
                }


                string
                f_129_4600_4628(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 4600, 4628);
                    return return_v;
                }


                string
                f_129_4746_4797()
                {
                    var return_v = ManagedEntranceStrings.LTSUpdateNotificationMessage
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 4746, 4797);
                    return return_v;
                }


                string
                f_129_4842_4875(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.PreReleaseLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 4842, 4875);
                    return return_v;
                }


                bool
                f_129_4821_4876(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 4821, 4876);
                    return return_v;
                }


                string
                f_129_4904_4958()
                {
                    var return_v = ManagedEntranceStrings.StableUpdateNotificationMessage
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 4904, 4958);
                    return return_v;
                }


                string
                f_129_4986_5041()
                {
                    var return_v = ManagedEntranceStrings.PreviewUpdateNotificationMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 4986, 5041);
                    return return_v;
                }


                bool
                f_129_5367_5397(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    var return_v = this_param.SupportsVirtualTerminal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 5367, 5397);
                    return return_v;
                }


                int
                f_129_5698_5735(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 5698, 5735);
                    return return_v;
                }


                int
                f_129_5776_5830(string
                this_param, char
                value, int
                startIndex)
                {
                    var return_v = this_param.IndexOf(value, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 5776, 5830);
                    return return_v;
                }


                int
                f_129_5871_5925(string
                this_param, char
                value, int
                startIndex)
                {
                    var return_v = this_param.IndexOf(value, startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 5871, 5925);
                    return return_v;
                }


                int
                f_129_6121_6138(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 6121, 6138);
                    return return_v;
                }


                string
                f_129_6071_6139(string
                this_param, int
                totalWidth)
                {
                    var return_v = this_param.PadRight(totalWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 6071, 6139);
                    return return_v;
                }


                string
                f_129_6252_6304(string
                this_param, int
                totalWidth)
                {
                    var return_v = this_param.PadRight(totalWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 6252, 6304);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_129_6383_6409()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 6383, 6409);
                    return return_v;
                }


                string
                f_129_6369_6506(System.Globalization.CultureInfo
                provider, string
                format, params object?[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 6369, 6506);
                    return return_v;
                }


                int
                f_129_6527_6560(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 6527, 6560);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(129, 4123, 6587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(129, 4123, 6587);
            }
        }

        internal static void CheckForUpdates()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(129, 6599, 13753);
                string updateFilePath = default(string);
                System.Management.Automation.SemanticVersion lastUpdateVersion = default(System.Management.Automation.SemanticVersion);
                System.DateTime lastUpdateDate = default(System.DateTime);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 7122, 7219) || true) && (f_129_7126_7158(f_129_7126_7151()) > 40)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 7122, 7219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 7197, 7204);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(129, 7122, 7219);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 7300, 7372);

                string
                preReleaseLabel = f_129_7325_7371(f_129_7325_7355())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 7386, 7544) || true) && (preReleaseLabel != null && (DynAbs.Tracing.TraceSender.Expression_True(129, 7390, 7488) && f_129_7417_7488(preReleaseLabel, "daily", StringComparison.OrdinalIgnoreCase)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 7386, 7544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 7522, 7529);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(129, 7386, 7544);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 7645, 7746) || true) && (!f_129_7650_7690())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 7645, 7746);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 7724, 7731);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(129, 7645, 7746);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 7833, 7965) || true) && (!f_129_7838_7872(s_cacheDirectory))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 7833, 7965);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 7906, 7950);

                    f_129_7906_7949(s_cacheDirectory);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(129, 7833, 7965);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 7981, 8167);

                bool
                parseSuccess = f_129_8001_8166(out updateFilePath, out lastUpdateVersion, out lastUpdateDate)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 8183, 8216);

                DateTime
                today = DateTime.UtcNow
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 8230, 8572) || true) && (parseSuccess && (DynAbs.Tracing.TraceSender.Expression_True(129, 8234, 8272) && updateFilePath != null) && (DynAbs.Tracing.TraceSender.Expression_True(129, 8234, 8314) && (today - lastUpdateDate).TotalDays < 7))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 8230, 8572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 8550, 8557);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(129, 8230, 8572);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 8657, 8907);

                string
                todayDoneFileName = f_129_8684_8906(f_129_8716_8744(), s_doneFileNameTemplate, f_129_8804_8825(today.Year), f_129_8844_8866(today.Month), f_129_8885_8905(today.Day))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 8923, 9000);

                string
                todayDoneFilePath = f_129_8950_8999(s_cacheDirectory, todayDoneFileName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 9014, 9222) || true) && (f_129_9018_9048(todayDoneFilePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 9014, 9222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 9200, 9207);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(129, 9014, 9222);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 9467, 9544);

                    string
                    sentinelFilePath = f_129_9493_9543(s_cacheDirectory, s_sentinelFileName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 9562, 13211);
                    using (f_129_9569_9700(sentinelFilePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None, bufferSize: 1, FileOptions.DeleteOnClose))
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 9742, 10043) || true) && (f_129_9746_9776(todayDoneFilePath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 9742, 10043);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 10013, 10020);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(129, 9742, 10043);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 10247, 10448);
                            foreach (string oldFile in f_129_10274_10354_I(f_129_10274_10354(s_cacheDirectory, s_doneFileNamePattern, s_enumOptions)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 10247, 10448);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 10404, 10425);

                                f_129_10404_10424(oldFile);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(129, 10247, 10448);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(129, 1, 202);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(129, 1, 202);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 10472, 11254) || true) && (!parseSuccess)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 10472, 11254);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 11022, 11231);
                                foreach (string file in f_129_11046_11128_I(f_129_11046_11128(s_cacheDirectory, s_updateFileNamePattern, s_enumOptions)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 11022, 11231);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 11186, 11204);

                                    f_129_11186_11203(file);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(129, 11022, 11231);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(129, 1, 210);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(129, 1, 210);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(129, 10472, 11254);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 11751, 11837);

                        SemanticVersion
                        baselineVersion = lastUpdateVersion ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.SemanticVersion>(129, 11785, 11836) ?? f_129_11806_11836())
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 11859, 11921);

                        Release
                        release = f_129_11883_11920(baselineVersion)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 11945, 12936) || true) && (release != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 11945, 12936);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 12087, 12113);

                            const int
                            dateLength = 10
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 12139, 12414);

                            string
                            newUpdateFileName = f_129_12166_12413(f_129_12210_12238(), s_updateFileNameTemplate, f_129_12324_12339(release), f_129_12370_12412(f_129_12370_12387(release), 0, dateLength))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 12442, 12519);

                            string
                            newUpdateFilePath = f_129_12469_12518(s_cacheDirectory, newUpdateFileName)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 12547, 12913) || true) && (updateFilePath == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 12547, 12913);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 12631, 12727);

                                f_129_12631_12726(f_129_12631_12718(newUpdateFilePath, FileMode.CreateNew, FileAccess.Write, FileShare.None));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(129, 12547, 12913);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 12547, 12913);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 12841, 12886);

                                f_129_12841_12885(updateFilePath, newUpdateFilePath);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(129, 12547, 12913);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(129, 11945, 12936);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 13096, 13192);

                        f_129_13096_13191(f_129_13096_13183(todayDoneFilePath, FileMode.CreateNew, FileAccess.Write, FileShare.None));
                        DynAbs.Tracing.TraceSender.TraceExitUsing(129, 9562, 13211);
                    }
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(129, 13240, 13742);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(129, 13240, 13742);
                    // There are 2 possible reason for the exception:
                    // 1. An update check initiated from another `pwsh` process is in progress.
                    //    It's OK to just return and let that update check to finish the work.
                    // 2. The update check failed (ex. internet connectivity issue, GitHub service failure).
                    //    It's OK to just return and let another `pwsh` do the check at later time.
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(129, 6599, 13753);

                string
                f_129_7126_7151()
                {
                    var return_v = PSVersionInfo.GitCommitId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 7126, 7151);
                    return return_v;
                }


                int
                f_129_7126_7158(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 7126, 7158);
                    return return_v;
                }


                System.Management.Automation.SemanticVersion
                f_129_7325_7355()
                {
                    var return_v = PSVersionInfo.PSCurrentVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 7325, 7355);
                    return return_v;
                }


                string
                f_129_7325_7371(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.PreReleaseLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 7325, 7371);
                    return return_v;
                }


                bool
                f_129_7417_7488(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 7417, 7488);
                    return return_v;
                }


                bool
                f_129_7650_7690()
                {
                    var return_v = NetworkInterface.GetIsNetworkAvailable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 7650, 7690);
                    return return_v;
                }


                bool
                f_129_7838_7872(string
                path)
                {
                    var return_v = Directory.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 7838, 7872);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_129_7906_7949(string
                path)
                {
                    var return_v = Directory.CreateDirectory(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 7906, 7949);
                    return return_v;
                }


                bool
                f_129_8001_8166(out string
                updateFilePath, out System.Management.Automation.SemanticVersion
                lastUpdateVersion, out System.DateTime
                lastUpdateDate)
                {
                    var return_v = TryParseUpdateFile(out updateFilePath, out lastUpdateVersion, out lastUpdateDate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 8001, 8166);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_129_8716_8744()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 8716, 8744);
                    return return_v;
                }


                string
                f_129_8804_8825(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 8804, 8825);
                    return return_v;
                }


                string
                f_129_8844_8866(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 8844, 8866);
                    return return_v;
                }


                string
                f_129_8885_8905(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 8885, 8905);
                    return return_v;
                }


                string
                f_129_8684_8906(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 8684, 8906);
                    return return_v;
                }


                string
                f_129_8950_8999(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 8950, 8999);
                    return return_v;
                }


                bool
                f_129_9018_9048(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 9018, 9048);
                    return return_v;
                }


                string
                f_129_9493_9543(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 9493, 9543);
                    return return_v;
                }


                System.IO.FileStream
                f_129_9569_9700(string
                path, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share, int
                bufferSize, System.IO.FileOptions
                options)
                {
                    var return_v = new System.IO.FileStream(path, mode, access, share, bufferSize: bufferSize, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 9569, 9700);
                    return return_v;
                }


                bool
                f_129_9746_9776(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 9746, 9776);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_129_10274_10354(string
                path, string
                searchPattern, System.IO.EnumerationOptions
                enumerationOptions)
                {
                    var return_v = Directory.EnumerateFiles(path, searchPattern, enumerationOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 10274, 10354);
                    return return_v;
                }


                int
                f_129_10404_10424(string
                path)
                {
                    File.Delete(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 10404, 10424);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_129_10274_10354_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 10274, 10354);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_129_11046_11128(string
                path, string
                searchPattern, System.IO.EnumerationOptions
                enumerationOptions)
                {
                    var return_v = Directory.EnumerateFiles(path, searchPattern, enumerationOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 11046, 11128);
                    return return_v;
                }


                int
                f_129_11186_11203(string
                path)
                {
                    File.Delete(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 11186, 11203);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_129_11046_11128_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 11046, 11128);
                    return return_v;
                }


                System.Management.Automation.SemanticVersion
                f_129_11806_11836()
                {
                    var return_v = PSVersionInfo.PSCurrentVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 11806, 11836);
                    return return_v;
                }


                Microsoft.PowerShell.UpdatesNotification.Release
                f_129_11883_11920(System.Management.Automation.SemanticVersion
                baselineVersion)
                {
                    var return_v = QueryNewReleaseAsync(baselineVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 11883, 11920);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_129_12210_12238()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 12210, 12238);
                    return return_v;
                }


                string
                f_129_12324_12339(Microsoft.PowerShell.UpdatesNotification.Release
                this_param)
                {
                    var return_v = this_param.TagName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 12324, 12339);
                    return return_v;
                }


                string
                f_129_12370_12387(Microsoft.PowerShell.UpdatesNotification.Release
                this_param)
                {
                    var return_v = this_param.PublishAt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 12370, 12387);
                    return return_v;
                }


                string
                f_129_12370_12412(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 12370, 12412);
                    return return_v;
                }


                string
                f_129_12166_12413(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 12166, 12413);
                    return return_v;
                }


                string
                f_129_12469_12518(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 12469, 12518);
                    return return_v;
                }


                System.IO.FileStream
                f_129_12631_12718(string
                path, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share)
                {
                    var return_v = new System.IO.FileStream(path, mode, access, share);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 12631, 12718);
                    return return_v;
                }


                int
                f_129_12631_12726(System.IO.FileStream
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 12631, 12726);
                    return 0;
                }


                int
                f_129_12841_12885(string
                sourceFileName, string
                destFileName)
                {
                    File.Move(sourceFileName, destFileName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 12841, 12885);
                    return 0;
                }


                System.IO.FileStream
                f_129_13096_13183(string
                path, System.IO.FileMode
                mode, System.IO.FileAccess
                access, System.IO.FileShare
                share)
                {
                    var return_v = new System.IO.FileStream(path, mode, access, share);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 13096, 13183);
                    return return_v;
                }


                int
                f_129_13096_13191(System.IO.FileStream
                this_param)
                {
                    this_param.Close();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 13096, 13191);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(129, 6599, 13753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(129, 6599, 13753);
            }
        }

        private static bool TryParseUpdateFile(
                    out string updateFilePath,
                    out SemanticVersion lastUpdateVersion,
                    out DateTime lastUpdateDate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(129, 14628, 16839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 14826, 14848);

                updateFilePath = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 14862, 14887);

                lastUpdateVersion = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 14901, 14926);

                lastUpdateDate = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 14942, 15037);

                var
                files = f_129_14954_15036(s_cacheDirectory, s_updateFileNamePattern, s_enumOptions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 15051, 15090);

                var
                enumerator = f_129_15068_15089(files)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 15106, 15308) || true) && (!f_129_15111_15132(enumerator))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 15106, 15308);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 15281, 15293);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(129, 15106, 15308);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 15324, 15360);

                updateFilePath = f_129_15341_15359(enumerator);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 15374, 15695) || true) && (f_129_15378_15399(enumerator))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 15374, 15695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 15627, 15649);

                    updateFilePath = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 15667, 15680);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(129, 15374, 15695);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 15862, 15919);

                string
                updateFileName = f_129_15886_15918(updateFilePath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 15933, 15990);

                int
                dateStartIndex = f_129_15954_15985(updateFileName, '_') + 1
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 16006, 16340) || true) && (!DateTime.TryParse(f_129_16051_16074(updateFileName).Slice(dateStartIndex), f_129_16119_16147(), DateTimeStyles.AssumeLocal, out lastUpdateDate))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 16006, 16340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 16272, 16294);

                    updateFilePath = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 16312, 16325);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(129, 16006, 16340);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 16356, 16412);

                int
                versionStartIndex = f_129_16380_16407(updateFileName, '_') + 2
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 16426, 16485);

                int
                versionLength = dateStartIndex - versionStartIndex - 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 16499, 16581);

                string
                versionString = f_129_16522_16580(updateFileName, versionStartIndex, versionLength)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 16597, 16724) || true) && (f_129_16601_16663(versionString, out lastUpdateVersion))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 16597, 16724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 16697, 16709);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(129, 16597, 16724);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 16740, 16762);

                updateFilePath = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 16776, 16801);

                lastUpdateDate = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 16815, 16828);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(129, 14628, 16839);

                System.Collections.Generic.IEnumerable<string>
                f_129_14954_15036(string
                path, string
                searchPattern, System.IO.EnumerationOptions
                enumerationOptions)
                {
                    var return_v = Directory.EnumerateFiles(path, searchPattern, enumerationOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 14954, 15036);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<string>
                f_129_15068_15089(System.Collections.Generic.IEnumerable<string>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 15068, 15089);
                    return return_v;
                }


                bool
                f_129_15111_15132(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 15111, 15132);
                    return return_v;
                }


                string
                f_129_15341_15359(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 15341, 15359);
                    return return_v;
                }


                bool
                f_129_15378_15399(System.Collections.Generic.IEnumerator<string>
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 15378, 15399);
                    return return_v;
                }


                string?
                f_129_15886_15918(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 15886, 15918);
                    return return_v;
                }


                int
                f_129_15954_15985(string
                this_param, char
                value)
                {
                    var return_v = this_param.LastIndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 15954, 15985);
                    return return_v;
                }


                System.ReadOnlySpan<char>
                f_129_16051_16074(string
                text)
                {
                    var return_v = text.AsSpan();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 16051, 16074);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_129_16119_16147()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 16119, 16147);
                    return return_v;
                }


                int
                f_129_16380_16407(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 16380, 16407);
                    return return_v;
                }


                string
                f_129_16522_16580(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 16522, 16580);
                    return return_v;
                }


                bool
                f_129_16601_16663(string
                version, out System.Management.Automation.SemanticVersion
                result)
                {
                    var return_v = SemanticVersion.TryParse(version, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 16601, 16663);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(129, 14628, 16839);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(129, 14628, 16839);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Release QueryNewReleaseAsync(SemanticVersion baselineVersion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(129, 16851, 19140);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 16964, 17056);

                bool
                isStableRelease = f_129_16987_17055(f_129_17008_17054(f_129_17008_17038()))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 17070, 17446);

                string[]
                queryUris = s_notificationType switch
                {
                    NotificationType.LTS => new[] { LTSBuildInfoURL },
                    NotificationType.Default => (DynAbs.Tracing.TraceSender.Conditional_F1(129, 17245, 17260) || ((isStableRelease
&& DynAbs.Tracing.TraceSender.Conditional_F2(129, 17284, 17312)) || DynAbs.Tracing.TraceSender.Conditional_F3(129, 17336, 17385))) ? new[] { StableBuildInfoURL }
: new[] { StableBuildInfoURL, PreviewBuildInfoURL },
                    _ => f_129_17409_17430()
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 17462, 17498);

                using var
                client = f_129_17481_17497()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 17514, 17622);

                string
                userAgent = f_129_17533_17621(f_129_17547_17575(), "PowerShell {0}", f_129_17595_17620())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 17636, 17694);

                f_129_17636_17693(f_129_17636_17664(client), "User-Agent", userAgent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 17708, 17805);

                f_129_17708_17804(f_129_17708_17743(f_129_17708_17736(client)), f_129_17748_17803("application/json"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 17821, 17852);

                Release
                releaseToReturn = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 17866, 17915);

                SemanticVersion
                highestVersion = baselineVersion
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 17929, 18020);

                var
                settings = new JsonSerializerSettings() { DateParseHandling = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => DateParseHandling.None, 129, 17944, 18019) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 18034, 18083);

                var
                serializer = f_129_18051_18082(settings)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 18099, 19090);
                    foreach (string queryUri in f_129_18127_18136_I(queryUris))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 18099, 19090);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 18246, 18309);

                        HttpResponseMessage
                        response = f_129_18283_18308(client, queryUri)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 18327, 18362);

                        f_129_18327_18361(response);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 18382, 18444);

                        using var
                        stream = f_129_18407_18443(f_129_18407_18423(response))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 18462, 18506);

                        using var
                        reader = f_129_18481_18505(stream)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 18524, 18574);

                        using var
                        jsonReader = f_129_18547_18573(reader)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 18594, 18656);

                        JObject
                        release = f_129_18612_18655(serializer, jsonReader)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 18674, 18721);

                        var
                        tagName = f_129_18688_18720(f_129_18688_18709(release, "ReleaseTag"))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 18739, 18797);

                        var
                        version = f_129_18753_18796(f_129_18775_18795(tagName, 1))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 18817, 19075) || true) && (version > highestVersion)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 18817, 19075);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 18887, 18912);

                            highestVersion = version;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 18934, 18984);

                            var
                            publishAt = f_129_18950_18983(f_129_18950_18972(release, "ReleaseDate"))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 19006, 19056);

                            releaseToReturn = f_129_19024_19055(publishAt, tagName);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(129, 18817, 19075);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(129, 18099, 19090);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(129, 1, 992);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(129, 1, 992);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 19106, 19129);

                return releaseToReturn;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(129, 16851, 19140);

                System.Management.Automation.SemanticVersion
                f_129_17008_17038()
                {
                    var return_v = PSVersionInfo.PSCurrentVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 17008, 17038);
                    return return_v;
                }


                string
                f_129_17008_17054(System.Management.Automation.SemanticVersion
                this_param)
                {
                    var return_v = this_param.PreReleaseLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 17008, 17054);
                    return return_v;
                }


                bool
                f_129_16987_17055(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 16987, 17055);
                    return return_v;
                }


                string[]
                f_129_17409_17430()
                {
                    var return_v = Array.Empty<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 17409, 17430);
                    return return_v;
                }


                System.Net.Http.HttpClient
                f_129_17481_17497()
                {
                    var return_v = new System.Net.Http.HttpClient();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 17481, 17497);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_129_17547_17575()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 17547, 17575);
                    return return_v;
                }


                string
                f_129_17595_17620()
                {
                    var return_v = PSVersionInfo.GitCommitId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 17595, 17620);
                    return return_v;
                }


                string
                f_129_17533_17621(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 17533, 17621);
                    return return_v;
                }


                System.Net.Http.Headers.HttpRequestHeaders
                f_129_17636_17664(System.Net.Http.HttpClient
                this_param)
                {
                    var return_v = this_param.DefaultRequestHeaders;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 17636, 17664);
                    return return_v;
                }


                int
                f_129_17636_17693(System.Net.Http.Headers.HttpRequestHeaders
                this_param, string
                name, string
                value)
                {
                    this_param.Add(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 17636, 17693);
                    return 0;
                }


                System.Net.Http.Headers.HttpRequestHeaders
                f_129_17708_17736(System.Net.Http.HttpClient
                this_param)
                {
                    var return_v = this_param.DefaultRequestHeaders;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 17708, 17736);
                    return return_v;
                }


                System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.MediaTypeWithQualityHeaderValue>
                f_129_17708_17743(System.Net.Http.Headers.HttpRequestHeaders
                this_param)
                {
                    var return_v = this_param.Accept;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 17708, 17743);
                    return return_v;
                }


                System.Net.Http.Headers.MediaTypeWithQualityHeaderValue
                f_129_17748_17803(string
                mediaType)
                {
                    var return_v = new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(mediaType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 17748, 17803);
                    return return_v;
                }


                int
                f_129_17708_17804(System.Net.Http.Headers.HttpHeaderValueCollection<System.Net.Http.Headers.MediaTypeWithQualityHeaderValue>
                this_param, System.Net.Http.Headers.MediaTypeWithQualityHeaderValue
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 17708, 17804);
                    return 0;
                }


                Newtonsoft.Json.JsonSerializer
                f_129_18051_18082(Newtonsoft.Json.JsonSerializerSettings
                settings)
                {
                    var return_v = JsonSerializer.Create(settings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 18051, 18082);
                    return return_v;
                }


                System.Net.Http.HttpResponseMessage
                f_129_18283_18308(System.Net.Http.HttpClient
                this_param, string
                requestUri)
                {
                    var return_v = this_param.GetAsync(requestUri).Result;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 18283, 18308);
                    return return_v;
                }


                System.Net.Http.HttpResponseMessage
                f_129_18327_18361(System.Net.Http.HttpResponseMessage
                this_param)
                {
                    var return_v = this_param.EnsureSuccessStatusCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 18327, 18361);
                    return return_v;
                }


                System.Net.Http.HttpContent
                f_129_18407_18423(System.Net.Http.HttpResponseMessage
                this_param)
                {
                    var return_v = this_param.Content;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 18407, 18423);
                    return return_v;
                }


                System.IO.Stream
                f_129_18407_18443(System.Net.Http.HttpContent
                this_param)
                {
                    var return_v = this_param.ReadAsStreamAsync().Result;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 18407, 18443);
                    return return_v;
                }


                System.IO.StreamReader
                f_129_18481_18505(System.IO.Stream
                stream)
                {
                    var return_v = new System.IO.StreamReader(stream);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 18481, 18505);
                    return return_v;
                }


                Newtonsoft.Json.JsonTextReader
                f_129_18547_18573(System.IO.StreamReader
                reader)
                {
                    var return_v = new Newtonsoft.Json.JsonTextReader((System.IO.TextReader)reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 18547, 18573);
                    return return_v;
                }


                Newtonsoft.Json.Linq.JObject
                f_129_18612_18655(Newtonsoft.Json.JsonSerializer
                this_param, Newtonsoft.Json.JsonTextReader
                reader)
                {
                    var return_v = this_param.Deserialize<Newtonsoft.Json.Linq.JObject>((Newtonsoft.Json.JsonReader)reader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 18612, 18655);
                    return return_v;
                }


                Newtonsoft.Json.Linq.JToken
                f_129_18688_18709(Newtonsoft.Json.Linq.JObject
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 18688, 18709);
                    return return_v;
                }


                string
                f_129_18688_18720(Newtonsoft.Json.Linq.JToken
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 18688, 18720);
                    return return_v;
                }


                string
                f_129_18775_18795(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 18775, 18795);
                    return return_v;
                }


                System.Management.Automation.SemanticVersion
                f_129_18753_18796(string
                version)
                {
                    var return_v = SemanticVersion.Parse(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 18753, 18796);
                    return return_v;
                }


                Newtonsoft.Json.Linq.JToken
                f_129_18950_18972(Newtonsoft.Json.Linq.JObject
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 18950, 18972);
                    return return_v;
                }


                string
                f_129_18950_18983(Newtonsoft.Json.Linq.JToken
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 18950, 18983);
                    return return_v;
                }


                Microsoft.PowerShell.UpdatesNotification.Release
                f_129_19024_19055(string
                publishAt, string
                tagName)
                {
                    var return_v = new Microsoft.PowerShell.UpdatesNotification.Release(publishAt, tagName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 19024, 19055);
                    return return_v;
                }


                string[]
                f_129_18127_18136_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 18127, 18136);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(129, 16851, 19140);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(129, 16851, 19140);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static NotificationType GetNotificationType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(129, 19247, 19719);
                Microsoft.PowerShell.UpdatesNotification.NotificationType type = default(Microsoft.PowerShell.UpdatesNotification.NotificationType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 19325, 19392);

                string
                str = f_129_19338_19391(UpdateCheckEnvVar)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 19406, 19516) || true) && (f_129_19410_19435(str))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 19406, 19516);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 19469, 19501);

                    return NotificationType.Default;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(129, 19406, 19516);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 19532, 19660) || true) && (f_129_19536_19599(str, ignoreCase: true, out type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(129, 19532, 19660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 19633, 19645);

                    return type;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(129, 19532, 19660);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 19676, 19708);

                return NotificationType.Default;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(129, 19247, 19719);

                string?
                f_129_19338_19391(string
                variable)
                {
                    var return_v = Environment.GetEnvironmentVariable(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 19338, 19391);
                    return return_v;
                }


                bool
                f_129_19410_19435(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 19410, 19435);
                    return return_v;
                }


                bool
                f_129_19536_19599(string
                value, bool
                ignoreCase, out Microsoft.PowerShell.UpdatesNotification.NotificationType
                result)
                {
                    var return_v = Enum.TryParse(value, ignoreCase: ignoreCase, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 19536, 19599);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(129, 19247, 19719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(129, 19247, 19719);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Notification type that can be configured.
        /// </summary>
        private enum NotificationType
        {
            /// <summary>
            /// Turn off the udpate notification.
            /// </summary>
            Off = 0,

            /// <summary>
            /// Give you the default behaviors:
            ///  - the preview version 'pwsh' checks for the new preview version and the new GA version.
            ///  - the GA version 'pwsh' checks for the new GA version only.
            /// </summary>
            Default = 1,

            /// <summary>
            /// Both preview and GA version 'pwsh' checks for the new LTS version only.
            /// </summary>
            LTS = 2
        }
        private class Release
        {
            internal Release(string publishAt, string tagName)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(129, 20553, 20709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 20862, 20896);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 21006, 21038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 20636, 20658);

                    PublishAt = publishAt;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(129, 20676, 20694);

                    TagName = tagName;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(129, 20553, 20709);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(129, 20553, 20709);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(129, 20553, 20709);
                }
            }

            internal string PublishAt { get; }

            internal string TagName { get; }

            static Release()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(129, 20507, 21049);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(129, 20507, 21049);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(129, 20507, 21049);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(129, 20507, 21049);
        }

        static Microsoft.PowerShell.UpdatesNotification.NotificationType
        f_129_2830_2851()
        {
            var return_v = GetNotificationType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 2830, 2851);
            return return_v;
        }


        static System.IO.EnumerationOptions
        f_129_3014_3038()
        {
            var return_v = new System.IO.EnumerationOptions();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 3014, 3038);
            return return_v;
        }


        static string
        f_129_3114_3139()
        {
            var return_v = PSVersionInfo.GitCommitId;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(129, 3114, 3139);
            return return_v;
        }


        static string
        f_129_3076_3140(string
        path1, string
        path2)
        {
            var return_v = Path.Combine(path1, path2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 3076, 3140);
            return return_v;
        }


        static string
        f_129_3271_3307(int
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(129, 3271, 3307);
            return return_v;
        }

    }
}
