// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Text;

using Dbg = System.Management.Automation.Diagnostics;

//
// Now define the set of commands for manipulating modules.
//

namespace Microsoft.PowerShell.Commands
{
    public class ModuleSpecification
    {
        public ModuleSpecification()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1533, 1260, 1310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 11277, 11318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 11421, 11461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 11589, 11634);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 11765, 11816);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 11950, 12003);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1533, 1260, 1310);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1533, 1260, 1310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1533, 1260, 1310);
            }
        }

        public ModuleSpecification(string moduleName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1533, 1500, 1949);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 11277, 11318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 11421, 11461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 11589, 11634);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 11765, 11816);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 11950, 12003);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 1570, 1707) || true) && (f_1533_1574_1606(moduleName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 1570, 1707);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 1640, 1692);

                    throw f_1533_1646_1691(nameof(moduleName));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 1570, 1707);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 1723, 1746);

                this.Name = moduleName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 1804, 1824);

                this.Version = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 1838, 1866);

                this.RequiredVersion = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 1880, 1907);

                this.MaximumVersion = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 1921, 1938);

                this.Guid = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1533, 1500, 1949);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1533, 1500, 1949);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1533, 1500, 1949);
            }
        }

        public ModuleSpecification(Hashtable moduleSpecification)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1533, 2433, 2856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 11277, 11318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 11421, 11461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 11589, 11634);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 11765, 11816);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 11950, 12003);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 2515, 2656) || true) && (moduleSpecification == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 2515, 2656);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 2580, 2641);

                    throw f_1533_2586_2640(nameof(moduleSpecification));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 2515, 2656);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 2672, 2745);

                var
                exception = f_1533_2688_2744(this, moduleSpecification)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 2759, 2845) || true) && (exception != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 2759, 2845);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 2814, 2830);

                    throw exception;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 2759, 2845);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1533, 2433, 2856);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1533, 2433, 2856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1533, 2433, 2856);
            }
        }

        internal static Exception ModuleSpecificationInitHelper(ModuleSpecification moduleSpecification, Hashtable hashtable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1533, 3278, 7237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 3420, 3464);

                StringBuilder
                badKeys = f_1533_3444_3463()
                ;
                try
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 3514, 5377);
                        foreach (DictionaryEntry entry in f_1533_3548_3557_I(hashtable))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 3514, 5377);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 3599, 3635);

                            string
                            field = f_1533_3614_3634(entry.Key)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 3659, 5358) || true) && (f_1533_3663_3725(field, "ModuleName", StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 3659, 5358);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 3775, 3852);

                                moduleSpecification.Name = f_1533_3802_3851(entry.Value);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 3659, 5358);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 3659, 5358);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 3902, 5358) || true) && (f_1533_3906_3971(field, "ModuleVersion", StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 3902, 5358);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 4021, 4102);

                                    moduleSpecification.Version = f_1533_4051_4101(entry.Value);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 3902, 5358);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 3902, 5358);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 4152, 5358) || true) && (f_1533_4156_4223(field, "RequiredVersion", StringComparison.OrdinalIgnoreCase))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 4152, 5358);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 4273, 4362);

                                        moduleSpecification.RequiredVersion = f_1533_4311_4361(entry.Value);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 4152, 5358);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 4152, 5358);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 4412, 5358) || true) && (f_1533_4416_4482(field, "MaximumVersion", StringComparison.OrdinalIgnoreCase))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 4412, 5358);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 4532, 4619);

                                            moduleSpecification.MaximumVersion = f_1533_4569_4618(entry.Value);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 4645, 4716);

                                            f_1533_4645_4715(f_1533_4680_4714(moduleSpecification));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 4412, 5358);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 4412, 5358);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 4766, 5358) || true) && (f_1533_4770_4826(field, "GUID", StringComparison.OrdinalIgnoreCase))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 4766, 5358);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 4876, 4952);

                                                moduleSpecification.Guid = f_1533_4903_4951(entry.Value);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 4766, 5358);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 4766, 5358);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 5050, 5178) || true) && (f_1533_5054_5068(badKeys) > 0)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 5050, 5178);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 5130, 5151);

                                                    f_1533_5130_5150(badKeys, ", ");
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 5050, 5178);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 5206, 5226);

                                                f_1533_5206_5225(
                                                                        badKeys, "'");
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 5252, 5289);

                                                f_1533_5252_5288(badKeys, f_1533_5267_5287(entry.Key));
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 5315, 5335);

                                                f_1533_5315_5334(badKeys, "'");
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 4766, 5358);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 4412, 5358);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 4152, 5358);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 3902, 5358);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 3659, 5358);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 3514, 5377);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1533, 1, 1864);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1533, 1, 1864);
                    }
                }
                // catch all exceptions here, we are going to report them via return value.
                // Example of catched exception: one of conversions to Version failed.
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1533, 5579, 5655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 5631, 5640);

                    return e;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1533, 5579, 5655);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 5671, 5686);

                string
                message
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 5700, 5959) || true) && (f_1533_5704_5718(badKeys) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 5700, 5959);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 5757, 5888);

                    message = f_1533_5767_5887(f_1533_5785_5825(), "ModuleName, ModuleVersion, RequiredVersion, GUID", badKeys);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 5906, 5944);

                    return f_1533_5913_5943(message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 5700, 5959);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 5975, 6204) || true) && (f_1533_5979_6025(f_1533_6000_6024(moduleSpecification)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 5975, 6204);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 6059, 6128);

                    message = f_1533_6069_6127(f_1533_6087_6126());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 6146, 6189);

                    return f_1533_6153_6188(message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 5975, 6204);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 6220, 6534) || true) && (f_1533_6224_6259(moduleSpecification) == null && (DynAbs.Tracing.TraceSender.Expression_True(1533, 6224, 6306) && f_1533_6271_6298(moduleSpecification) == null) && (DynAbs.Tracing.TraceSender.Expression_True(1533, 6224, 6352) && f_1533_6310_6344(moduleSpecification) == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 6220, 6534);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 6386, 6458);

                    message = f_1533_6396_6457(f_1533_6414_6456());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 6476, 6519);

                    return f_1533_6483_6518(message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 6220, 6534);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 6550, 6862) || true) && (f_1533_6554_6589(moduleSpecification) != null && (DynAbs.Tracing.TraceSender.Expression_True(1533, 6554, 6636) && f_1533_6601_6628(moduleSpecification) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 6550, 6862);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 6670, 6791);

                    message = f_1533_6680_6790(f_1533_6698_6753(), "ModuleVersion", "RequiredVersion");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 6809, 6847);

                    return f_1533_6816_6846(message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 6550, 6862);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 6878, 7198) || true) && (f_1533_6882_6917(moduleSpecification) != null && (DynAbs.Tracing.TraceSender.Expression_True(1533, 6882, 6971) && f_1533_6929_6963(moduleSpecification) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 6878, 7198);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 7005, 7127);

                    message = f_1533_7015_7126(f_1533_7033_7088(), "MaximumVersion", "RequiredVersion");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 7145, 7183);

                    return f_1533_7152_7182(message);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 6878, 7198);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 7214, 7226);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1533, 3278, 7237);

                System.Text.StringBuilder
                f_1533_3444_3463()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 3444, 3463);
                    return return_v;
                }


                string?
                f_1533_3614_3634(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 3614, 3634);
                    return return_v;
                }


                bool
                f_1533_3663_3725(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 3663, 3725);
                    return return_v;
                }


                string
                f_1533_3802_3851(object
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<string>(valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 3802, 3851);
                    return return_v;
                }


                bool
                f_1533_3906_3971(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 3906, 3971);
                    return return_v;
                }


                System.Version
                f_1533_4051_4101(object
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<Version>(valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 4051, 4101);
                    return return_v;
                }


                bool
                f_1533_4156_4223(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 4156, 4223);
                    return return_v;
                }


                System.Version
                f_1533_4311_4361(object
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<Version>(valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 4311, 4361);
                    return return_v;
                }


                bool
                f_1533_4416_4482(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 4416, 4482);
                    return return_v;
                }


                string
                f_1533_4569_4618(object
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<string>(valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 4569, 4618);
                    return return_v;
                }


                string
                f_1533_4680_4714(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.MaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 4680, 4714);
                    return return_v;
                }


                System.Version
                f_1533_4645_4715(string
                stringVersion)
                {
                    var return_v = ModuleCmdletBase.GetMaximumVersion(stringVersion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 4645, 4715);
                    return return_v;
                }


                bool
                f_1533_4770_4826(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 4770, 4826);
                    return return_v;
                }


                System.Guid?
                f_1533_4903_4951(object
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<Guid?>(valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 4903, 4951);
                    return return_v;
                }


                int
                f_1533_5054_5068(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 5054, 5068);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1533_5130_5150(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 5130, 5150);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1533_5206_5225(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 5206, 5225);
                    return return_v;
                }


                string?
                f_1533_5267_5287(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 5267, 5287);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1533_5252_5288(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 5252, 5288);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1533_5315_5334(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 5315, 5334);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1533_3548_3557_I(System.Collections.Hashtable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 3548, 3557);
                    return return_v;
                }


                int
                f_1533_5704_5718(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 5704, 5718);
                    return return_v;
                }


                string
                f_1533_5785_5825()
                {
                    var return_v = Modules.InvalidModuleSpecificationMember;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 5785, 5825);
                    return return_v;
                }


                string
                f_1533_5767_5887(string
                formatSpec, string
                o1, System.Text.StringBuilder
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 5767, 5887);
                    return return_v;
                }


                System.ArgumentException
                f_1533_5913_5943(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 5913, 5943);
                    return return_v;
                }


                string
                f_1533_6000_6024(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 6000, 6024);
                    return return_v;
                }


                bool
                f_1533_5979_6025(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 5979, 6025);
                    return return_v;
                }


                string
                f_1533_6087_6126()
                {
                    var return_v = Modules.RequiredModuleMissingModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 6087, 6126);
                    return return_v;
                }


                string
                f_1533_6069_6127(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 6069, 6127);
                    return return_v;
                }


                System.MissingMemberException
                f_1533_6153_6188(string
                message)
                {
                    var return_v = new System.MissingMemberException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 6153, 6188);
                    return return_v;
                }


                System.Version
                f_1533_6224_6259(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.RequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 6224, 6259);
                    return return_v;
                }


                System.Version
                f_1533_6271_6298(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 6271, 6298);
                    return return_v;
                }


                string
                f_1533_6310_6344(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.MaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 6310, 6344);
                    return return_v;
                }


                string
                f_1533_6414_6456()
                {
                    var return_v = Modules.RequiredModuleMissingModuleVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 6414, 6456);
                    return return_v;
                }


                string
                f_1533_6396_6457(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 6396, 6457);
                    return return_v;
                }


                System.MissingMemberException
                f_1533_6483_6518(string
                message)
                {
                    var return_v = new System.MissingMemberException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 6483, 6518);
                    return return_v;
                }


                System.Version
                f_1533_6554_6589(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.RequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 6554, 6589);
                    return return_v;
                }


                System.Version
                f_1533_6601_6628(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 6601, 6628);
                    return return_v;
                }


                string
                f_1533_6698_6753()
                {
                    var return_v = SessionStateStrings.GetContent_TailAndHeadCannotCoexist;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 6698, 6753);
                    return return_v;
                }


                string
                f_1533_6680_6790(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 6680, 6790);
                    return return_v;
                }


                System.ArgumentException
                f_1533_6816_6846(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 6816, 6846);
                    return return_v;
                }


                System.Version
                f_1533_6882_6917(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.RequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 6882, 6917);
                    return return_v;
                }


                string
                f_1533_6929_6963(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.MaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 6929, 6963);
                    return return_v;
                }


                string
                f_1533_7033_7088()
                {
                    var return_v = SessionStateStrings.GetContent_TailAndHeadCannotCoexist;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 7033, 7088);
                    return return_v;
                }


                string
                f_1533_7015_7126(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 7015, 7126);
                    return return_v;
                }


                System.ArgumentException
                f_1533_7152_7182(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 7152, 7182);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1533, 3278, 7237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1533, 3278, 7237);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ModuleSpecification(PSModuleInfo moduleInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1533, 7249, 7595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 11277, 11318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 11421, 11461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 11589, 11634);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 11765, 11816);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 11950, 12003);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 7327, 7450) || true) && (moduleInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 7327, 7450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 7383, 7435);

                    throw f_1533_7389_7434(nameof(moduleInfo));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 7327, 7450);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 7466, 7494);

                this.Name = f_1533_7478_7493(moduleInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 7508, 7542);

                this.Version = f_1533_7523_7541(moduleInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 7556, 7584);

                this.Guid = f_1533_7568_7583(moduleInfo);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1533, 7249, 7595);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1533, 7249, 7595);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1533, 7249, 7595);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1533, 7910, 9113);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 7968, 8117) || true) && (f_1533_7972_7976() == null && (DynAbs.Tracing.TraceSender.Expression_True(1533, 7972, 8003) && f_1533_7988_7995() == null) && (DynAbs.Tracing.TraceSender.Expression_True(1533, 7972, 8030) && f_1533_8007_8022() == null) && (DynAbs.Tracing.TraceSender.Expression_True(1533, 7972, 8056) && f_1533_8034_8048() == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 7968, 8117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 8090, 8102);

                    return f_1533_8097_8101();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 7968, 8117);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 8133, 8177);

                var
                moduleSpecBuilder = f_1533_8157_8176()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 8193, 8264);

                f_1533_8193_8263(f_1533_8193_8251(f_1533_8193_8238(
                            moduleSpecBuilder, "@{ ModuleName = '"), f_1533_8246_8250()), "'");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 8280, 8412) || true) && (f_1533_8284_8288() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 8280, 8412);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 8330, 8397);

                    f_1533_8330_8396(f_1533_8330_8382(f_1533_8330_8369(moduleSpecBuilder, "; Guid = '{"), f_1533_8377_8381()), "}' ");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 8280, 8412);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 8428, 9003) || true) && (f_1533_8432_8447() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 8428, 9003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 8489, 8575);

                    f_1533_8489_8574(f_1533_8489_8562(f_1533_8489_8538(moduleSpecBuilder, "; RequiredVersion = '"), f_1533_8546_8561()), "'");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 8428, 9003);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 8428, 9003);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 8641, 8797) || true) && (f_1533_8645_8652() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 8641, 8797);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 8702, 8778);

                        f_1533_8702_8777(f_1533_8702_8765(f_1533_8702_8749(moduleSpecBuilder, "; ModuleVersion = '"), f_1533_8757_8764()), "'");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 8641, 8797);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 8817, 8988) || true) && (f_1533_8821_8835() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 8817, 8988);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 8885, 8969);

                        f_1533_8885_8968(f_1533_8885_8956(f_1533_8885_8933(moduleSpecBuilder, "; MaximumVersion = '"), f_1533_8941_8955()), "'");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 8817, 8988);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 8428, 9003);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 9019, 9050);

                f_1533_9019_9049(
                            moduleSpecBuilder, " }");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 9066, 9102);

                return f_1533_9073_9101(moduleSpecBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1533, 7910, 9113);

                System.Guid?
                f_1533_7972_7976()
                {
                    var return_v = Guid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 7972, 7976);
                    return return_v;
                }


                System.Version
                f_1533_7988_7995()
                {
                    var return_v = Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 7988, 7995);
                    return return_v;
                }


                System.Version
                f_1533_8007_8022()
                {
                    var return_v = RequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 8007, 8022);
                    return return_v;
                }


                string
                f_1533_8034_8048()
                {
                    var return_v = MaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 8034, 8048);
                    return return_v;
                }


                string
                f_1533_8097_8101()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 8097, 8101);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1533_8157_8176()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 8157, 8176);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1533_8193_8238(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 8193, 8238);
                    return return_v;
                }


                string
                f_1533_8246_8250()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 8246, 8250);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1533_8193_8251(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 8193, 8251);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1533_8193_8263(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 8193, 8263);
                    return return_v;
                }


                System.Guid?
                f_1533_8284_8288()
                {
                    var return_v = Guid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 8284, 8288);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1533_8330_8369(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 8330, 8369);
                    return return_v;
                }


                System.Guid?
                f_1533_8377_8381()
                {
                    var return_v = Guid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 8377, 8381);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1533_8330_8382(System.Text.StringBuilder
                this_param, System.Guid?
                value)
                {
                    var return_v = this_param.Append((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 8330, 8382);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1533_8330_8396(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 8330, 8396);
                    return return_v;
                }


                System.Version
                f_1533_8432_8447()
                {
                    var return_v = RequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 8432, 8447);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1533_8489_8538(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 8489, 8538);
                    return return_v;
                }


                System.Version
                f_1533_8546_8561()
                {
                    var return_v = RequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 8546, 8561);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1533_8489_8562(System.Text.StringBuilder
                this_param, System.Version
                value)
                {
                    var return_v = this_param.Append((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 8489, 8562);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1533_8489_8574(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 8489, 8574);
                    return return_v;
                }


                System.Version
                f_1533_8645_8652()
                {
                    var return_v = Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 8645, 8652);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1533_8702_8749(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 8702, 8749);
                    return return_v;
                }


                System.Version
                f_1533_8757_8764()
                {
                    var return_v = Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 8757, 8764);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1533_8702_8765(System.Text.StringBuilder
                this_param, System.Version
                value)
                {
                    var return_v = this_param.Append((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 8702, 8765);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1533_8702_8777(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 8702, 8777);
                    return return_v;
                }


                string
                f_1533_8821_8835()
                {
                    var return_v = MaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 8821, 8835);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1533_8885_8933(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 8885, 8933);
                    return return_v;
                }


                string
                f_1533_8941_8955()
                {
                    var return_v = MaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 8941, 8955);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1533_8885_8956(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 8885, 8956);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1533_8885_8968(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 8885, 8968);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1533_9019_9049(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 9019, 9049);
                    return return_v;
                }


                string
                f_1533_9073_9101(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 9073, 9101);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1533, 7910, 9113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1533, 7910, 9113);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool TryParse(string input, out ModuleSpecification result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1533, 9428, 9991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 9526, 9540);

                result = null;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 9590, 9610);

                    Hashtable
                    hashtable
                    = default(Hashtable);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 9628, 9827) || true) && (f_1533_9632_9688(input, out hashtable))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 9628, 9827);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 9730, 9774);

                        result = f_1533_9739_9773(hashtable);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 9796, 9808);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 9628, 9827);
                    }
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1533, 9856, 9951);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1533, 9856, 9951);
                    // Ignoring the exceptions to return false
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 9967, 9980);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1533, 9428, 9991);

                bool
                f_1533_9632_9688(string
                input, out System.Collections.Hashtable
                result)
                {
                    var return_v = Parser.TryParseAsConstantHashtable(input, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 9632, 9688);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification
                f_1533_9739_9773(System.Collections.Hashtable
                moduleSpecification)
                {
                    var return_v = new Microsoft.PowerShell.Commands.ModuleSpecification(moduleSpecification);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 9739, 9773);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1533, 9428, 9991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1533, 9428, 9991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ModuleSpecification WithNormalizedName(ExecutionContext context, string basePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1533, 10538, 11188);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 10739, 10844) || true) && (!f_1533_10744_10783(f_1533_10778_10782()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 10739, 10844);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 10817, 10829);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 10739, 10844);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 10860, 11177);

                return new ModuleSpecification()
                {
                    Guid = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1533_10932_10936(), 1533, 10867, 11176),
                    MaximumVersion = f_1533_10972_10986(),
                    Version = f_1533_11015_11022(),
                    RequiredVersion = f_1533_11059_11074(),
                    Name = f_1533_11100_11161(f_1533_11137_11141(), basePath, context)
                };
                DynAbs.Tracing.TraceSender.TraceExitMethod(1533, 10538, 11188);

                string
                f_1533_10778_10782()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 10778, 10782);
                    return return_v;
                }


                bool
                f_1533_10744_10783(string
                moduleName)
                {
                    var return_v = ModuleIntrinsics.IsModuleNamePath(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 10744, 10783);
                    return return_v;
                }


                System.Guid?
                f_1533_10932_10936()
                {
                    var return_v = Guid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 10932, 10936);
                    return return_v;
                }


                string
                f_1533_10972_10986()
                {
                    var return_v = MaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 10972, 10986);
                    return return_v;
                }


                System.Version
                f_1533_11015_11022()
                {
                    var return_v = Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 11015, 11022);
                    return return_v;
                }


                System.Version
                f_1533_11059_11074()
                {
                    var return_v = RequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 11059, 11074);
                    return return_v;
                }


                string
                f_1533_11137_11141()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 11137, 11141);
                    return return_v;
                }


                string
                f_1533_11100_11161(string
                moduleName, string
                basePath, System.Management.Automation.ExecutionContext
                executionContext)
                {
                    var return_v = ModuleIntrinsics.NormalizeModuleName(moduleName, basePath, executionContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 11100, 11161);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1533, 10538, 11188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1533, 10538, 11188);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string Name { get; internal set; }

        public Guid? Guid { get; internal set; }

        public Version Version { get; internal set; }

        public string MaximumVersion { get; internal set; }

        public Version RequiredVersion { get; internal set; }

        static ModuleSpecification()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1533, 1130, 12010);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1533, 1130, 12010);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1533, 1130, 12010);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1533, 1130, 12010);

        bool
        f_1533_1574_1606(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 1574, 1606);
            return return_v;
        }


        System.ArgumentNullException
        f_1533_1646_1691(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 1646, 1691);
            return return_v;
        }


        System.ArgumentNullException
        f_1533_2586_2640(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 2586, 2640);
            return return_v;
        }


        System.Exception
        f_1533_2688_2744(Microsoft.PowerShell.Commands.ModuleSpecification
        moduleSpecification, System.Collections.Hashtable
        hashtable)
        {
            var return_v = ModuleSpecificationInitHelper(moduleSpecification, hashtable);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 2688, 2744);
            return return_v;
        }


        System.ArgumentNullException
        f_1533_7389_7434(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 7389, 7434);
            return return_v;
        }


        string
        f_1533_7478_7493(System.Management.Automation.PSModuleInfo
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 7478, 7493);
            return return_v;
        }


        System.Version
        f_1533_7523_7541(System.Management.Automation.PSModuleInfo
        this_param)
        {
            var return_v = this_param.Version;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 7523, 7541);
            return return_v;
        }


        System.Guid
        f_1533_7568_7583(System.Management.Automation.PSModuleInfo
        this_param)
        {
            var return_v = this_param.Guid;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 7568, 7583);
            return return_v;
        }

    }
    internal class ModuleSpecificationComparer : IEqualityComparer<ModuleSpecification>
    {
        public bool Equals(ModuleSpecification x, ModuleSpecification y)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1533, 12504, 13055);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 12593, 12664) || true) && (x == y)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 12593, 12664);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 12637, 12649);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 12593, 12664);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 12680, 13044);

                return x != null && (DynAbs.Tracing.TraceSender.Expression_True(1533, 12687, 12709) && y != null
                ) && (DynAbs.Tracing.TraceSender.Expression_True(1533, 12687, 12795) && f_1533_12730_12795(f_1533_12744_12750(x), f_1533_12752_12758(y), StringComparison.OrdinalIgnoreCase)) && (DynAbs.Tracing.TraceSender.Expression_True(1533, 12687, 12843) && f_1533_12816_12843(f_1533_12828_12834(x), f_1533_12836_12842(y))) && (DynAbs.Tracing.TraceSender.Expression_True(1533, 12687, 12916) && f_1533_12864_12916(f_1533_12879_12896(x), f_1533_12898_12915(y))) && (DynAbs.Tracing.TraceSender.Expression_True(1533, 12687, 12973) && f_1533_12937_12973(f_1533_12952_12961(x), f_1533_12963_12972(y))) && (DynAbs.Tracing.TraceSender.Expression_True(1533, 12687, 13043) && f_1533_12994_13043(f_1533_13008_13024(x), f_1533_13026_13042(y)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1533, 12504, 13055);

                string
                f_1533_12744_12750(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 12744, 12750);
                    return return_v;
                }


                string
                f_1533_12752_12758(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 12752, 12758);
                    return return_v;
                }


                bool
                f_1533_12730_12795(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 12730, 12795);
                    return return_v;
                }


                System.Guid?
                f_1533_12828_12834(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Guid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 12828, 12834);
                    return return_v;
                }


                System.Guid?
                f_1533_12836_12842(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Guid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 12836, 12842);
                    return return_v;
                }


                bool
                f_1533_12816_12843(System.Guid?
                objA, System.Guid?
                objB)
                {
                    var return_v = Guid.Equals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 12816, 12843);
                    return return_v;
                }


                System.Version
                f_1533_12879_12896(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.RequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 12879, 12896);
                    return return_v;
                }


                System.Version
                f_1533_12898_12915(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.RequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 12898, 12915);
                    return return_v;
                }


                bool
                f_1533_12864_12916(System.Version
                objA, System.Version
                objB)
                {
                    var return_v = Version.Equals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 12864, 12916);
                    return return_v;
                }


                System.Version
                f_1533_12952_12961(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 12952, 12961);
                    return return_v;
                }


                System.Version
                f_1533_12963_12972(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 12963, 12972);
                    return return_v;
                }


                bool
                f_1533_12937_12973(System.Version
                objA, System.Version
                objB)
                {
                    var return_v = Version.Equals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 12937, 12973);
                    return return_v;
                }


                string
                f_1533_13008_13024(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.MaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 13008, 13024);
                    return return_v;
                }


                string
                f_1533_13026_13042(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.MaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 13026, 13042);
                    return return_v;
                }


                bool
                f_1533_12994_13043(string
                a, string
                b)
                {
                    var return_v = string.Equals(a, b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1533, 12994, 13043);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1533, 12504, 13055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1533, 12504, 13055);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int GetHashCode(ModuleSpecification obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1533, 13393, 13663);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 13465, 13538) || true) && (obj == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1533, 13465, 13538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 13514, 13523);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1533, 13465, 13538);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1533, 13554, 13652);

                return HashCode.Combine(f_1533_13578_13586(obj), f_1533_13588_13596(obj), f_1533_13598_13617(obj), f_1533_13619_13630(obj), f_1533_13632_13650(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1533, 13393, 13663);

                string
                f_1533_13578_13586(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 13578, 13586);
                    return return_v;
                }


                System.Guid?
                f_1533_13588_13596(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Guid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 13588, 13596);
                    return return_v;
                }


                System.Version
                f_1533_13598_13617(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.RequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 13598, 13617);
                    return return_v;
                }


                System.Version
                f_1533_13619_13630(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Version;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 13619, 13630);
                    return return_v;
                }


                string
                f_1533_13632_13650(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.MaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1533, 13632, 13650);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1533, 13393, 13663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1533, 13393, 13663);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ModuleSpecificationComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1533, 12121, 13670);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1533, 12121, 13670);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1533, 12121, 13670);
        }


        static ModuleSpecificationComparer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1533, 12121, 13670);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1533, 12121, 13670);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1533, 12121, 13670);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1533, 12121, 13670);
    }

}
