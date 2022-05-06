// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

using Microsoft.PowerShell;

#pragma warning disable 1634, 1691 // Stops compiler from warning about unknown warnings

namespace System.Management.Automation
{
    internal class DirectoryEntryAdapter : DotNetAdapter
    {
        private static readonly DotNetAdapter s_dotNetAdapter;

        internal override bool CanSiteBinderOptimize(MemberTypes typeToOperateOn)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1276, 1178, 1300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 1276, 1289);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1276, 1178, 1300);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1276, 1178, 1300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1276, 1178, 1300);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override T GetMember<T>(object obj, string memberName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1276, 1728, 5614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 1817, 1837);

                PSProperty
                property
                = default(PSProperty);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 1851, 1894);

                DirectoryEntry
                entry = (DirectoryEntry)obj
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 1983, 2049);

                PropertyValueCollection
                collection = f_1276_2020_2048(f_1276_2020_2036(entry), memberName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 2063, 2095);

                object
                valueToTake = collection
                ;

#pragma warning disable 56500
                // Even for the cases where propertyName does not exist
                // entry.Properties[propertyName] still returns a PropertyValueCollection.
                // The non schema way to check for a non existing property is to call entry.InvokeGet
                // and catch an eventual exception.
                // Specifically for "LDAP://RootDse" there are some cases where calling
                // InvokeGet will throw COMException for existing properties like defaultNamingContext.
                // Having a call to entry.Properties[propertyName] fixes the RootDse problem.
                // Calling entry.RefreshCache() also fixes the RootDse problem.
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 2837, 2889);

                    object
                    invokeGetValue = f_1276_2861_2888(entry, memberName)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 3092, 3266) || true) && ((collection == null) || (DynAbs.Tracing.TraceSender.Expression_False(1276, 3096, 3176) || ((f_1276_3122_3138(collection) == null) && (DynAbs.Tracing.TraceSender.Expression_True(1276, 3121, 3175) && (invokeGetValue != null)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1276, 3092, 3266);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 3218, 3247);

                        valueToTake = invokeGetValue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1276, 3092, 3266);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 3286, 3361);

                    property = f_1276_3297_3360(f_1276_3312_3335(collection), this, obj, valueToTake);
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1276, 3390, 3471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 3440, 3456);

                    property = null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1276, 3390, 3471);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 3518, 3606) || true) && (valueToTake == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1276, 3518, 3606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 3575, 3591);

                    property = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1276, 3518, 3606);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 3622, 3762) || true) && (f_1276_3626_3672(typeof(T), typeof(PSProperty)) && (DynAbs.Tracing.TraceSender.Expression_True(1276, 3626, 3692) && property != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1276, 3622, 3762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 3726, 3747);

                    return property as T;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1276, 3622, 3762);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 3778, 5575) || true) && (f_1276_3782_3826(typeof(T), typeof(PSMethod)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1276, 3778, 5575);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 3860, 5560) || true) && (property == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1276, 3860, 5560);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 5360, 5541) || true) && (DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetDotNetProperty<T>(obj, memberName), 1276, 5364, 5406) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1276, 5360, 5541);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 5464, 5518);

                            return f_1276_5471_5512(memberName, this, obj, null) as T;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1276, 5360, 5541);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1276, 3860, 5560);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1276, 3778, 5575);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 5591, 5603);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1276, 1728, 5614);

                System.DirectoryServices.PropertyCollection
                f_1276_2020_2036(System.DirectoryServices.DirectoryEntry
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1276, 2020, 2036);
                    return return_v;
                }


                System.DirectoryServices.PropertyValueCollection
                f_1276_2020_2048(System.DirectoryServices.PropertyCollection
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1276, 2020, 2048);
                    return return_v;
                }


                object
                f_1276_2861_2888(System.DirectoryServices.DirectoryEntry
                this_param, string
                propertyName)
                {
                    var return_v = this_param.InvokeGet(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 2861, 2888);
                    return return_v;
                }


                object
                f_1276_3122_3138(System.DirectoryServices.PropertyValueCollection
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1276, 3122, 3138);
                    return return_v;
                }


                string
                f_1276_3312_3335(System.DirectoryServices.PropertyValueCollection
                this_param)
                {
                    var return_v = this_param.PropertyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1276, 3312, 3335);
                    return return_v;
                }


                System.Management.Automation.PSProperty
                f_1276_3297_3360(string
                name, System.Management.Automation.DirectoryEntryAdapter
                adapter, object
                baseObject, object
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSProperty(name, (System.Management.Automation.Adapter)adapter, baseObject, adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 3297, 3360);
                    return return_v;
                }


                bool
                f_1276_3626_3672(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 3626, 3672);
                    return return_v;
                }


                bool
                f_1276_3782_3826(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 3782, 3826);
                    return return_v;
                }


                System.Management.Automation.PSMethod
                f_1276_5471_5512(string
                name, System.Management.Automation.DirectoryEntryAdapter
                adapter, object
                baseObject, object
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSMethod(name, (System.Management.Automation.Adapter)adapter, baseObject, adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 5471, 5512);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1276, 1728, 5614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1276, 1728, 5614);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override PSMemberInfoInternalCollection<T> GetMembers<T>(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1276, 6391, 7441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 6494, 6537);

                DirectoryEntry
                entry = (DirectoryEntry)obj
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 6553, 6637);

                PSMemberInfoInternalCollection<T>
                members = f_1276_6597_6636()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 6653, 6784) || true) && (f_1276_6657_6673(entry) == null || (DynAbs.Tracing.TraceSender.Expression_False(1276, 6657, 6723) || f_1276_6685_6715(f_1276_6685_6701(entry)) == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1276, 6653, 6784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 6757, 6769);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1276, 6653, 6784);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 6800, 6826);

                int
                countOfProperties = 0
                ;

#pragma warning disable 56500
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 6909, 6966);

                    countOfProperties = f_1276_6929_6965(f_1276_6929_6959(f_1276_6929_6945(entry)));
                }
                catch (Exception) // swallow all non-severe exceptions
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1276, 6995, 7079);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1276, 6995, 7079);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 7126, 7399) || true) && (countOfProperties > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1276, 7126, 7399);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 7185, 7384);
                        foreach (PropertyValueCollection property in f_1276_7230_7246_I(f_1276_7230_7246(entry)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1276, 7185, 7384);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 7288, 7365);

                            f_1276_7288_7364(members, f_1276_7300_7358(f_1276_7315_7336(property), this, obj, property));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1276, 7185, 7384);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1276, 1, 200);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1276, 1, 200);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1276, 7126, 7399);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 7415, 7430);

                return members;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1276, 6391, 7441);

                System.Management.Automation.PSMemberInfoInternalCollection<T>
                f_1276_6597_6636()
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 6597, 6636);
                    return return_v;
                }


                System.DirectoryServices.PropertyCollection
                f_1276_6657_6673(System.DirectoryServices.DirectoryEntry
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1276, 6657, 6673);
                    return return_v;
                }


                System.DirectoryServices.PropertyCollection
                f_1276_6685_6701(System.DirectoryServices.DirectoryEntry
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1276, 6685, 6701);
                    return return_v;
                }


                System.Collections.ICollection
                f_1276_6685_6715(System.DirectoryServices.PropertyCollection
                this_param)
                {
                    var return_v = this_param.PropertyNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1276, 6685, 6715);
                    return return_v;
                }


                System.DirectoryServices.PropertyCollection
                f_1276_6929_6945(System.DirectoryServices.DirectoryEntry
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1276, 6929, 6945);
                    return return_v;
                }


                System.Collections.ICollection
                f_1276_6929_6959(System.DirectoryServices.PropertyCollection
                this_param)
                {
                    var return_v = this_param.PropertyNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1276, 6929, 6959);
                    return return_v;
                }


                int
                f_1276_6929_6965(System.Collections.ICollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1276, 6929, 6965);
                    return return_v;
                }


                System.DirectoryServices.PropertyCollection
                f_1276_7230_7246(System.DirectoryServices.DirectoryEntry
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1276, 7230, 7246);
                    return return_v;
                }


                string
                f_1276_7315_7336(System.DirectoryServices.PropertyValueCollection
                this_param)
                {
                    var return_v = this_param.PropertyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1276, 7315, 7336);
                    return return_v;
                }


                System.Management.Automation.PSProperty
                f_1276_7300_7358(string
                name, System.Management.Automation.DirectoryEntryAdapter
                adapter, object
                baseObject, System.DirectoryServices.PropertyValueCollection
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSProperty(name, (System.Management.Automation.Adapter)adapter, baseObject, (object)adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 7300, 7358);
                    return return_v;
                }


                int
                f_1276_7288_7364(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, System.Management.Automation.PSProperty
                member)
                {
                    this_param.Add(member as T);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 7288, 7364);
                    return 0;
                }


                System.DirectoryServices.PropertyCollection
                f_1276_7230_7246_I(System.DirectoryServices.PropertyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 7230, 7246);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1276, 6391, 7441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1276, 6391, 7441);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override object PropertyGet(PSProperty property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1276, 7802, 7924);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 7885, 7913);

                return property.adapterData;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1276, 7802, 7924);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1276, 7802, 7924);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1276, 7802, 7924);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void PropertySet(PSProperty property, object setValue, bool convertIfPossible)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1276, 8378, 10885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 8500, 8581);

                PropertyValueCollection
                values = property.adapterData as PropertyValueCollection
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 8597, 10851) || true) && (values != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1276, 8597, 10851);
                    // This means GetMember returned PropertyValueCollection
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 8767, 8782);

                        f_1276_8767_8781(values);
                    }
                    catch (System.Runtime.InteropServices.COMException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1276, 8819, 9487);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 8913, 9468) || true) && (f_1276_8917_8928(e) != unchecked((int)0x80004005) || (DynAbs.Tracing.TraceSender.Expression_False(1276, 8917, 8980) || (setValue == null)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1276, 8913, 9468);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 9462, 9468);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1276, 8913, 9468);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1276, 8819, 9487);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 9507, 9575);

                    IEnumerable
                    enumValues = f_1276_9532_9574(setValue)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 9595, 9913) || true) && (enumValues == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1276, 9595, 9913);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 9659, 9680);

                        f_1276_9659_9679(values, setValue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1276, 9595, 9913);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1276, 9595, 9913);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 9762, 9894);
                            foreach (object objValue in f_1276_9790_9800_I(enumValues))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1276, 9762, 9894);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 9850, 9871);

                                f_1276_9850_9870(values, objValue);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1276, 9762, 9894);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1276, 1, 133);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1276, 1, 133);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1276, 9595, 9913);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1276, 8597, 10851);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1276, 8597, 10851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 10089, 10148);

                    DirectoryEntry
                    entry = (DirectoryEntry)property.baseObject
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 10166, 10270);

                    f_1276_10166_10269(entry != null, "Object should be of type DirectoryEntry in DirectoryEntry adapter.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 10290, 10334);

                    List<object>
                    setValues = f_1276_10315_10333()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 10352, 10420);

                    IEnumerable
                    enumValues = f_1276_10377_10419(setValue)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 10440, 10764) || true) && (enumValues == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1276, 10440, 10764);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 10504, 10528);

                        f_1276_10504_10527(setValues, setValue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1276, 10440, 10764);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1276, 10440, 10764);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 10610, 10745);
                            foreach (object objValue in f_1276_10638_10648_I(enumValues))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1276, 10610, 10745);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 10698, 10722);

                                f_1276_10698_10721(setValues, objValue);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1276, 10610, 10745);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1276, 1, 136);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1276, 1, 136);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1276, 10440, 10764);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 10784, 10836);

                    f_1276_10784_10835(
                                    entry, property.name, f_1276_10815_10834(setValues));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1276, 8597, 10851);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 10867, 10874);

                return;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1276, 8378, 10885);

                int
                f_1276_8767_8781(System.DirectoryServices.PropertyValueCollection
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 8767, 8781);
                    return 0;
                }


                int
                f_1276_8917_8928(System.Runtime.InteropServices.COMException
                this_param)
                {
                    var return_v = this_param.ErrorCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1276, 8917, 8928);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1276_9532_9574(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerable(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 9532, 9574);
                    return return_v;
                }


                int
                f_1276_9659_9679(System.DirectoryServices.PropertyValueCollection
                this_param, object
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 9659, 9679);
                    return return_v;
                }


                int
                f_1276_9850_9870(System.DirectoryServices.PropertyValueCollection
                this_param, object
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 9850, 9870);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1276_9790_9800_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 9790, 9800);
                    return return_v;
                }


                int
                f_1276_10166_10269(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 10166, 10269);
                    return 0;
                }


                System.Collections.Generic.List<object>
                f_1276_10315_10333()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 10315, 10333);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1276_10377_10419(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerable(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 10377, 10419);
                    return return_v;
                }


                int
                f_1276_10504_10527(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 10504, 10527);
                    return 0;
                }


                int
                f_1276_10698_10721(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 10698, 10721);
                    return 0;
                }


                System.Collections.IEnumerable
                f_1276_10638_10648_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 10638, 10648);
                    return return_v;
                }


                object[]
                f_1276_10815_10834(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 10815, 10834);
                    return return_v;
                }


                int
                f_1276_10784_10835(System.DirectoryServices.DirectoryEntry
                this_param, string
                propertyName, params object[]
                args)
                {
                    this_param.InvokeSet(propertyName, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 10784, 10835);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1276, 8378, 10885);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1276, 8378, 10885);
            }
        }

        protected override bool PropertyIsSettable(PSProperty property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1276, 11128, 11239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 11216, 11228);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1276, 11128, 11239);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1276, 11128, 11239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1276, 11128, 11239);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool PropertyIsGettable(PSProperty property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1276, 11482, 11593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 11570, 11582);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1276, 11482, 11593);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1276, 11482, 11593);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1276, 11482, 11593);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override string PropertyType(PSProperty property, bool forDisplay)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1276, 11999, 12456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 12100, 12120);

                object
                value = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 12170, 12204);

                    value = f_1276_12178_12203(this, property);
                }
                catch (GetValueException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1276, 12233, 12288);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1276, 12233, 12288);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 12304, 12364);

                var
                type = (DynAbs.Tracing.TraceSender.Conditional_F1(1276, 12315, 12328) || ((value == null && DynAbs.Tracing.TraceSender.Conditional_F2(1276, 12331, 12345)) || DynAbs.Tracing.TraceSender.Conditional_F3(1276, 12348, 12363))) ? typeof(object) : f_1276_12348_12363(value)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 12378, 12445);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1276, 12385, 12395) || ((forDisplay && DynAbs.Tracing.TraceSender.Conditional_F2(1276, 12398, 12428)) || DynAbs.Tracing.TraceSender.Conditional_F3(1276, 12431, 12444))) ? f_1276_12398_12428(type) : f_1276_12431_12444(type);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1276, 11999, 12456);

                object
                f_1276_12178_12203(System.Management.Automation.DirectoryEntryAdapter
                this_param, System.Management.Automation.PSProperty
                property)
                {
                    var return_v = this_param.BasePropertyGet(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 12178, 12203);
                    return return_v;
                }


                System.Type
                f_1276_12348_12363(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 12348, 12363);
                    return return_v;
                }


                string
                f_1276_12398_12428(System.Type
                type)
                {
                    var return_v = ToStringCodeMethods.Type(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 12398, 12428);
                    return return_v;
                }


                string
                f_1276_12431_12444(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1276, 12431, 12444);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1276, 11999, 12456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1276, 11999, 12456);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override object MethodInvoke(PSMethod method, PSMethodInvocationConstraints invocationConstraints, object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1276, 12525, 12733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 12678, 12722);

                return f_1276_12685_12721(this, method, arguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1276, 12525, 12733);

                object
                f_1276_12685_12721(System.Management.Automation.DirectoryEntryAdapter
                this_param, System.Management.Automation.PSMethod
                method, object[]
                arguments)
                {
                    var return_v = this_param.MethodInvoke(method, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 12685, 12721);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1276, 12525, 12733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1276, 12525, 12733);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override object MethodInvoke(PSMethod method, object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1276, 13122, 15504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 13222, 13301);

                ParameterInformation[]
                parameters = new ParameterInformation[f_1276_13283_13299(arguments)]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 13326, 13331);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 13317, 13484) || true) && (i < f_1276_13337_13353(arguments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 13355, 13358)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1276, 13317, 13484))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1276, 13317, 13484);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 13392, 13469);

                        parameters[i] = f_1276_13408_13468(typeof(object), false, null, false);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1276, 1, 168);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1276, 1, 168);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 13500, 13565);

                MethodInformation[]
                methodInformation = new MethodInformation[1]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 13579, 13650);

                methodInformation[0] = f_1276_13602_13649(false, false, parameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 13666, 13688);

                object[]
                newArguments
                = default(object[]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 13702, 13789);

                f_1276_13702_13788(f_1276_13728_13739(method), methodInformation, arguments, out newArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 13805, 13862);

                DirectoryEntry
                entry = (DirectoryEntry)method.baseObject
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 14593, 14613);

                Exception
                exception
                = default(Exception);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 14663, 14710);

                    return f_1276_14670_14709(entry, f_1276_14683_14694(method), newArguments);
                }
                catch (DirectoryServicesCOMException dse)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1276, 14739, 14844);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 14813, 14829);

                    exception = dse;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1276, 14739, 14844);
                }
                catch (TargetInvocationException tie)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1276, 14858, 14959);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 14928, 14944);

                    exception = tie;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1276, 14858, 14959);
                }
                catch (COMException ce)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1276, 14973, 15059);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 15029, 15044);

                    exception = ce;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1276, 14973, 15059);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 15219, 15317);

                PSMethod
                dotNetmethod = f_1276_15243_15316(s_dotNetAdapter, method.baseObject, method.name)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 15331, 15442) || true) && (dotNetmethod != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1276, 15331, 15442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 15389, 15427);

                    return f_1276_15396_15426(dotNetmethod, arguments);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1276, 15331, 15442);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 15477, 15493);

                throw exception;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1276, 13122, 15504);

                int
                f_1276_13283_13299(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1276, 13283, 13299);
                    return return_v;
                }


                int
                f_1276_13337_13353(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1276, 13337, 13353);
                    return return_v;
                }


                System.Management.Automation.ParameterInformation
                f_1276_13408_13468(System.Type
                parameterType, bool
                isOptional, object
                defaultValue, bool
                isByRef)
                {
                    var return_v = new System.Management.Automation.ParameterInformation(parameterType, isOptional, defaultValue, isByRef);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 13408, 13468);
                    return return_v;
                }


                System.Management.Automation.MethodInformation
                f_1276_13602_13649(bool
                hasvarargs, bool
                hasoptional, System.Management.Automation.ParameterInformation[]
                arguments)
                {
                    var return_v = new System.Management.Automation.MethodInformation(hasvarargs, hasoptional, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 13602, 13649);
                    return return_v;
                }


                string
                f_1276_13728_13739(System.Management.Automation.PSMethod
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1276, 13728, 13739);
                    return return_v;
                }


                System.Management.Automation.MethodInformation
                f_1276_13702_13788(string
                methodName, System.Management.Automation.MethodInformation[]
                methods, object[]
                arguments, out object[]
                newArguments)
                {
                    var return_v = GetBestMethodAndArguments(methodName, methods, arguments, out newArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 13702, 13788);
                    return return_v;
                }


                string
                f_1276_14683_14694(System.Management.Automation.PSMethod
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1276, 14683, 14694);
                    return return_v;
                }


                object
                f_1276_14670_14709(System.DirectoryServices.DirectoryEntry
                this_param, string
                methodName, params object[]
                args)
                {
                    var return_v = this_param.Invoke(methodName, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 14670, 14709);
                    return return_v;
                }


                System.Management.Automation.PSMethod
                f_1276_15243_15316(System.Management.Automation.DotNetAdapter
                this_param, object
                obj, string
                methodName)
                {
                    var return_v = this_param.GetDotNetMethod<System.Management.Automation.PSMethod>(obj, methodName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 15243, 15316);
                    return return_v;
                }


                object
                f_1276_15396_15426(System.Management.Automation.PSMethod
                this_param, params object[]
                arguments)
                {
                    var return_v = this_param.Invoke(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 15396, 15426);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1276, 13122, 15504);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1276, 13122, 15504);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override string MethodToString(PSMethod method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1276, 15726, 16161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 15808, 15856);

                StringBuilder
                returnValue = f_1276_15836_15855()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 15870, 16044);
                    foreach (string overload in f_1276_15898_15923_I(f_1276_15898_15923(this, method)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1276, 15870, 16044);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 15957, 15986);

                        f_1276_15957_15985(returnValue, overload);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 16004, 16029);

                        f_1276_16004_16028(returnValue, ", ");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1276, 15870, 16044);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1276, 1, 175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1276, 1, 175);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 16060, 16106);

                f_1276_16060_16105(
                            returnValue, f_1276_16079_16097(returnValue) - 2, 2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 16120, 16150);

                return f_1276_16127_16149(returnValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1276, 15726, 16161);

                System.Text.StringBuilder
                f_1276_15836_15855()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 15836, 15855);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1276_15898_15923(System.Management.Automation.DirectoryEntryAdapter
                this_param, System.Management.Automation.PSMethod
                method)
                {
                    var return_v = this_param.MethodDefinitions(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 15898, 15923);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1276_15957_15985(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 15957, 15985);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1276_16004_16028(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 16004, 16028);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1276_15898_15923_I(System.Collections.ObjectModel.Collection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 15898, 15923);
                    return return_v;
                }


                int
                f_1276_16079_16097(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1276, 16079, 16097);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1276_16060_16105(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Remove(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 16060, 16105);
                    return return_v;
                }


                string
                f_1276_16127_16149(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 16127, 16149);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1276, 15726, 16161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1276, 15726, 16161);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public DirectoryEntryAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1276, 535, 16197);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1276, 535, 16197);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1276, 535, 16197);
        }


        static DirectoryEntryAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1276, 535, 16197);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1276, 1082, 1119);
            s_dotNetAdapter = f_1276_1100_1119();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1276, 535, 16197);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1276, 535, 16197);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1276, 535, 16197);

        static System.Management.Automation.DotNetAdapter
        f_1276_1100_1119()
        {
            var return_v = new System.Management.Automation.DotNetAdapter();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1276, 1100, 1119);
            return return_v;
        }

    }
}
