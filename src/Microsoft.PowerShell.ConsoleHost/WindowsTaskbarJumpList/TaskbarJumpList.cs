// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Diagnostics;
using System.Management.Automation;
using System.Reflection;
using System.Threading;

using static Microsoft.PowerShell.ComInterfaces;

namespace Microsoft.PowerShell
{
    internal static class TaskbarJumpList
    {
        internal static void CreateRunAsAdministratorJumpList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(134, 1003, 2186);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 1261, 1347) || true) && (f_134_1265_1291_M(!Platform.IsWindowsDesktop))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(134, 1261, 1347);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 1325, 1332);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(134, 1261, 1347);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 1466, 2087);

                var
                thread = f_134_1479_2086(() =>
                            {
                                try
                                {
                                    TaskbarJumpList.CreateElevatedEntry(ConsoleHostStrings.RunAsAdministrator);
                                }
                                catch (Exception exception)
                                {
                    // Due to COM threading complexity there might still be sporadic failures but they can be
                    // ignored as creating the JumpList is not critical and persists after its first creation.
                    Debug.Fail($"Creating 'Run as Administrator' JumpList failed. {exception}");
                                }
                            })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 2101, 2146);

                f_134_2101_2145(thread, ApartmentState.STA);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 2160, 2175);

                f_134_2160_2174(thread);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(134, 1003, 2186);

                bool
                f_134_1265_1291_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(134, 1265, 1291);
                    return return_v;
                }


                System.Threading.Thread
                f_134_1479_2086(System.Threading.ThreadStart
                start)
                {
                    var return_v = new System.Threading.Thread(start);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 1479, 2086);
                    return return_v;
                }


                int
                f_134_2101_2145(System.Threading.Thread
                this_param, System.Threading.ApartmentState
                state)
                {
                    this_param.SetApartmentState(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 2101, 2145);
                    return 0;
                }


                int
                f_134_2160_2174(System.Threading.Thread
                this_param)
                {
                    this_param.Start();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 2160, 2174);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(134, 1003, 2186);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(134, 1003, 2186);
            }
        }

        private static void CreateElevatedEntry(string title)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(134, 2198, 7063);
                Microsoft.PowerShell.ComInterfaces.StartUpInfo startupInfo = default(Microsoft.PowerShell.ComInterfaces.StartUpInfo);
                object pCustDestListobj = default(object);
                uint uMaxSlots = default(uint);
                object pRemovedItems = default(object);
                uint flags = default(uint);
                object instance = default(object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 2473, 2517);

                f_134_2473_2516(out startupInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 2531, 2569);

                var
                STARTF_USESHOWWINDOW = 0x00000001
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 2583, 2599);

                var
                SW_HIDE = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 2613, 7052) || true) && (((startupInfo.dwFlags & STARTF_USESHOWWINDOW) == 1) && (DynAbs.Tracing.TraceSender.Expression_True(134, 2617, 2708) && (startupInfo.wShowWindow != SW_HIDE)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(134, 2613, 7052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 2742, 2820);

                    string
                    cmdPath = f_134_2759_2819(f_134_2759_2795(f_134_2759_2786()), ".dll", ".exe")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 2953, 3031);

                    var
                    CLSID_DestinationList = f_134_2981_3030(@"77f10cf0-3db5-4966-b520-b7c54fd35ed6")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 3049, 3085);

                    const uint
                    CLSCTX_INPROC_SERVER = 1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 3103, 3171);

                    var
                    IID_IUnknown = f_134_3122_3170("00000000-0000-0000-C000-000000000046")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 3189, 3322);

                    var
                    hResult = f_134_3203_3321(ref CLSID_DestinationList, null, CLSCTX_INPROC_SERVER, ref IID_IUnknown, out pCustDestListobj)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 3340, 3525) || true) && (hResult < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(134, 3340, 3525);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 3397, 3477);

                        f_134_3397_3476($"Creating ICustomDestinationList failed with HResult '{hResult}'.");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 3499, 3506);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(134, 3340, 3525);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 3545, 3606);

                    var
                    pCustDestList = (ICustomDestinationList)pCustDestListobj
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 3624, 3755);

                    var temp = f_134_3678_3727(@"92CA9DCD-5622-4BBA-A805-5E9F541BD8C9"); // LAFHIS
                    hResult = f_134_3634_3754(pCustDestList, out uMaxSlots, ref temp, out pRemovedItems);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 3773, 3962) || true) && (hResult < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(134, 3773, 3962);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 3830, 3914);

                        f_134_3830_3913($"BeginList on ICustomDestinationList failed with HResult '{hResult}'.");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 3936, 3943);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(134, 3773, 3962);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 3982, 7037) || true) && (uMaxSlots >= 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(134, 3982, 7037);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 4086, 4138);

                        var
                        nativeShellLink = (IShellLinkW)f_134_4121_4137()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 4160, 4218);

                        var
                        nativePropertyStore = (IPropertyStore)nativeShellLink
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 4240, 4273);

                        f_134_4240_4272(nativeShellLink, cmdPath);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 4295, 4325);

                        f_134_4295_4324(nativeShellLink, 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 4347, 4408);

                        var
                        shellLinkDataList = (IShellLinkDataListW)nativeShellLink
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 4430, 4473);

                        f_134_4430_4472(shellLinkDataList, out flags);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 4495, 4515);

                        flags |= 0x00800000;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 4564, 4584);

                        flags |= 0x00002000;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 4625, 4659);

                        f_134_4625_4658(shellLinkDataList, flags);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 4681, 4769);

                        var
                        PKEY_TITLE = f_134_4698_4768(f_134_4714_4764("{F29F85E0-4FF9-1068-AB91-08002B27B3D9}"), 2)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 4791, 4870);

                        hResult = f_134_4801_4869(nativePropertyStore, ref PKEY_TITLE, f_134_4846_4868(title));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 4892, 5161) || true) && (hResult < 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(134, 4892, 5161);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 4957, 4983);

                            f_134_4957_4982(pCustDestList);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 5009, 5105);

                            f_134_5009_5104($"SetValue on IPropertyStore with title '{title}' failed with HResult '{hResult}'.");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 5131, 5138);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(134, 4892, 5161);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 5185, 5224);

                        hResult = f_134_5195_5223(nativePropertyStore);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 5246, 5492) || true) && (hResult < 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(134, 5246, 5492);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 5311, 5337);

                            f_134_5311_5336(pCustDestList);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 5363, 5436);

                            f_134_5363_5435($"Commit on IPropertyStore failed with HResult '{hResult}'.");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 5462, 5469);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(134, 5246, 5492);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 5579, 5668);

                        var
                        CLSID_EnumerableObjectCollection = f_134_5618_5667(@"2d3468c1-36a7-43b6-ac24-d3f02fd9607a")
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 5690, 5727);

                        const uint
                        CLSCTX_INPROC_HANDLER = 2
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 5749, 5821);

                        const uint
                        CLSCTX_INPROC = CLSCTX_INPROC_SERVER | CLSCTX_INPROC_HANDLER
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 5843, 5920);

                        var
                        ComSvrInterface_GUID = f_134_5870_5919(@"555E2D2B-EE00-47AA-AB2B-39F953F6B339")
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 5942, 6067);

                        hResult = f_134_5952_6066(ref CLSID_EnumerableObjectCollection, null, CLSCTX_INPROC, ref IID_IUnknown, out instance);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 6089, 6337) || true) && (hResult < 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(134, 6089, 6337);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 6154, 6180);

                            f_134_6154_6179(pCustDestList);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 6206, 6281);

                            f_134_6206_6280($"Creating IObjectCollection failed with HResult '{hResult}'.");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 6307, 6314);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(134, 6089, 6337);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 6361, 6415);

                        var
                        pShortCutCollection = (IObjectCollection)instance
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 6437, 6501);

                        f_134_6437_6500(pShortCutCollection, nativePropertyStore);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 6613, 6685);

                        hResult = f_134_6623_6684(pCustDestList, pShortCutCollection);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 6707, 6967) || true) && (hResult < 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(134, 6707, 6967);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 6772, 6798);

                            f_134_6772_6797(pCustDestList);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 6824, 6911);

                            f_134_6824_6910($"AddUserTasks on ICustomDestinationList failed with HResult '{hResult}'.");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 6937, 6944);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(134, 6707, 6967);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(134, 6991, 7018);

                        f_134_6991_7017(
                                            pCustDestList);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(134, 3982, 7037);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(134, 2613, 7052);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(134, 2198, 7063);

                int
                f_134_2473_2516(out Microsoft.PowerShell.ComInterfaces.StartUpInfo
                lpStartupInfo)
                {
                    GetStartupInfo(out lpStartupInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 2473, 2516);
                    return 0;
                }


                System.Reflection.Assembly?
                f_134_2759_2786()
                {
                    var return_v = Assembly.GetEntryAssembly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 2759, 2786);
                    return return_v;
                }


                string
                f_134_2759_2795(System.Reflection.Assembly
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(134, 2759, 2795);
                    return return_v;
                }


                string
                f_134_2759_2819(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 2759, 2819);
                    return return_v;
                }


                System.Guid
                f_134_2981_3030(string
                g)
                {
                    var return_v = new System.Guid(g);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 2981, 3030);
                    return return_v;
                }


                System.Guid
                f_134_3122_3170(string
                g)
                {
                    var return_v = new System.Guid(g);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 3122, 3170);
                    return return_v;
                }


                Microsoft.PowerShell.HResult
                f_134_3203_3321(ref System.Guid
                clsid, object
                inner, uint
                context, ref System.Guid
                uuid, out object
                rReturnedComObject)
                {
                    var return_v = CoCreateInstance(ref clsid, inner, context, ref uuid, out rReturnedComObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 3203, 3321);
                    return return_v;
                }


                int
                f_134_3397_3476(string
                message)
                {
                    Debug.Fail(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 3397, 3476);
                    return 0;
                }


                System.Guid
                f_134_3678_3727(string
                g)
                {
                    var return_v = new System.Guid(g);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 3678, 3727);
                    return return_v;
                }


                Microsoft.PowerShell.HResult
                f_134_3634_3754(Microsoft.PowerShell.ComInterfaces.ICustomDestinationList
                this_param, out uint
                cMaxSlots, ref System.Guid
                riid, out object
                ppvObject)
                {
                    var return_v = this_param.BeginList(out cMaxSlots, ref riid, out ppvObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 3634, 3754);
                    return return_v;
                }


                int
                f_134_3830_3913(string
                message)
                {
                    Debug.Fail(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 3830, 3913);
                    return 0;
                }


                Microsoft.PowerShell.ComInterfaces.CShellLink
                f_134_4121_4137()
                {
                    var return_v = new Microsoft.PowerShell.ComInterfaces.CShellLink();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 4121, 4137);
                    return return_v;
                }


                int
                f_134_4240_4272(Microsoft.PowerShell.ComInterfaces.IShellLinkW
                this_param, string
                pszFile)
                {
                    this_param.SetPath(pszFile);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 4240, 4272);
                    return 0;
                }


                int
                f_134_4295_4324(Microsoft.PowerShell.ComInterfaces.IShellLinkW
                this_param, int
                iShowCmd)
                {
                    this_param.SetShowCmd((uint)iShowCmd);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 4295, 4324);
                    return 0;
                }


                int
                f_134_4430_4472(Microsoft.PowerShell.ComInterfaces.IShellLinkDataListW
                this_param, out uint
                pdwFlags)
                {
                    this_param.GetFlags(out pdwFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 4430, 4472);
                    return 0;
                }


                int
                f_134_4625_4658(Microsoft.PowerShell.ComInterfaces.IShellLinkDataListW
                this_param, uint
                dwFlags)
                {
                    this_param.SetFlags(dwFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 4625, 4658);
                    return 0;
                }


                System.Guid
                f_134_4714_4764(string
                g)
                {
                    var return_v = new System.Guid(g);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 4714, 4764);
                    return return_v;
                }


                Microsoft.PowerShell.PropertyKey
                f_134_4698_4768(System.Guid
                formatId, int
                propertyId)
                {
                    var return_v = new Microsoft.PowerShell.PropertyKey(formatId, propertyId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 4698, 4768);
                    return return_v;
                }


                Microsoft.PowerShell.PropVariant
                f_134_4846_4868(string
                value)
                {
                    var return_v = new Microsoft.PowerShell.PropVariant(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 4846, 4868);
                    return return_v;
                }


                Microsoft.PowerShell.HResult
                f_134_4801_4869(Microsoft.PowerShell.ComInterfaces.IPropertyStore
                this_param, ref Microsoft.PowerShell.PropertyKey
                key, Microsoft.PowerShell.PropVariant
                pv)
                {
                    var return_v = this_param.SetValue(ref key, pv);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 4801, 4869);
                    return return_v;
                }


                int
                f_134_4957_4982(Microsoft.PowerShell.ComInterfaces.ICustomDestinationList
                this_param)
                {
                    this_param.AbortList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 4957, 4982);
                    return 0;
                }


                int
                f_134_5009_5104(string
                message)
                {
                    Debug.Fail(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 5009, 5104);
                    return 0;
                }


                Microsoft.PowerShell.HResult
                f_134_5195_5223(Microsoft.PowerShell.ComInterfaces.IPropertyStore
                this_param)
                {
                    var return_v = this_param.Commit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 5195, 5223);
                    return return_v;
                }


                int
                f_134_5311_5336(Microsoft.PowerShell.ComInterfaces.ICustomDestinationList
                this_param)
                {
                    this_param.AbortList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 5311, 5336);
                    return 0;
                }


                int
                f_134_5363_5435(string
                message)
                {
                    Debug.Fail(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 5363, 5435);
                    return 0;
                }


                System.Guid
                f_134_5618_5667(string
                g)
                {
                    var return_v = new System.Guid(g);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 5618, 5667);
                    return return_v;
                }


                System.Guid
                f_134_5870_5919(string
                g)
                {
                    var return_v = new System.Guid(g);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 5870, 5919);
                    return return_v;
                }


                Microsoft.PowerShell.HResult
                f_134_5952_6066(ref System.Guid
                clsid, object
                inner, uint
                context, ref System.Guid
                uuid, out object
                rReturnedComObject)
                {
                    var return_v = CoCreateInstance(ref clsid, inner, context, ref uuid, out rReturnedComObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 5952, 6066);
                    return return_v;
                }


                int
                f_134_6154_6179(Microsoft.PowerShell.ComInterfaces.ICustomDestinationList
                this_param)
                {
                    this_param.AbortList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 6154, 6179);
                    return 0;
                }


                int
                f_134_6206_6280(string
                message)
                {
                    Debug.Fail(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 6206, 6280);
                    return 0;
                }


                int
                f_134_6437_6500(Microsoft.PowerShell.ComInterfaces.IObjectCollection
                this_param, Microsoft.PowerShell.ComInterfaces.IPropertyStore
                pvObject)
                {
                    this_param.AddObject((object)pvObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 6437, 6500);
                    return 0;
                }


                Microsoft.PowerShell.HResult
                f_134_6623_6684(Microsoft.PowerShell.ComInterfaces.ICustomDestinationList
                this_param, Microsoft.PowerShell.ComInterfaces.IObjectCollection
                poa)
                {
                    var return_v = this_param.AddUserTasks((Microsoft.PowerShell.ComInterfaces.IObjectArray)poa);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 6623, 6684);
                    return return_v;
                }


                int
                f_134_6772_6797(Microsoft.PowerShell.ComInterfaces.ICustomDestinationList
                this_param)
                {
                    this_param.AbortList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 6772, 6797);
                    return 0;
                }


                int
                f_134_6824_6910(string
                message)
                {
                    Debug.Fail(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 6824, 6910);
                    return 0;
                }


                int
                f_134_6991_7017(Microsoft.PowerShell.ComInterfaces.ICustomDestinationList
                this_param)
                {
                    this_param.CommitList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(134, 6991, 7017);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(134, 2198, 7063);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(134, 2198, 7063);
            }
        }

        static TaskbarJumpList()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(134, 323, 7070);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(134, 323, 7070);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(134, 323, 7070);
        }

    }
}
