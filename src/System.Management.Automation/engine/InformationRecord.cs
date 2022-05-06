// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace System.Management.Automation
{
    [DataContract()]
    public class InformationRecord
    {
        public InformationRecord(object messageData, string source)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1281, 1141, 1513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 2658, 2728);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 2875, 2931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 3590, 3595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 4244, 4249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 4617, 4630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 5169, 5179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 5312, 5352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 5485, 5548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 1225, 1256);

                this.MessageData = messageData;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 1270, 1291);

                this.Source = source;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 1307, 1341);

                this.TimeGenerated = DateTime.Now;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 1355, 1405);

                this.NativeThreadId = f_1281_1377_1404();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 1419, 1502);

                this.ManagedThreadId = (uint)f_1281_1448_1501(f_1281_1448_1485());
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1281, 1141, 1513);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1281, 1141, 1513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1281, 1141, 1513);
            }
        }

        private InformationRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1281, 1525, 1556);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 2658, 2728);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 2875, 2931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 3590, 3595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 4244, 4249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 4617, 4630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 5169, 5179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 5312, 5352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 5485, 5548);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1281, 1525, 1556);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1281, 1525, 1556);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1281, 1525, 1556);
            }
        }

        internal InformationRecord(InformationRecord baseRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1281, 1646, 2200);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 2658, 2728);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 2875, 2931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 3590, 3595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 4244, 4249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 4617, 4630);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 5169, 5179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 5312, 5352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 5485, 5548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 1727, 1769);

                this.MessageData = f_1281_1746_1768(baseRecord);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 1783, 1815);

                this.Source = f_1281_1797_1814(baseRecord);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 1831, 1877);

                this.TimeGenerated = f_1281_1852_1876(baseRecord);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 1891, 1919);

                this.Tags = f_1281_1903_1918(baseRecord);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 1933, 1961);

                this.User = f_1281_1945_1960(baseRecord);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 1975, 2011);

                this.Computer = f_1281_1991_2010(baseRecord);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 2025, 2063);

                this.ProcessId = f_1281_2042_2062(baseRecord);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 2077, 2125);

                this.NativeThreadId = f_1281_2099_2124(baseRecord);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 2139, 2189);

                this.ManagedThreadId = f_1281_2162_2188(baseRecord);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1281, 1646, 2200);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1281, 1646, 2200);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1281, 1646, 2200);
            }
        }

        [DataMember]
        public object MessageData { get; internal set; }

        [DataMember]
        public string Source { get; set; }

        [DataMember]
        public DateTime TimeGenerated { get; set; }

        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public List<string> Tags
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1281, 3446, 3499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 3452, 3497);

                    return _tags ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.List<string>>(1281, 3459, 3496) ?? (_tags = f_1281_3477_3495()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1281, 3446, 3499);

                    System.Collections.Generic.List<string>
                    f_1281_3477_3495()
                    {
                        var return_v = new System.Collections.Generic.List<string>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 3477, 3495);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1281, 3250, 3557);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1281, 3250, 3557);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            internal set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1281, 3515, 3546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 3530, 3544);

                    _tags = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1281, 3515, 3546);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1281, 3250, 3557);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1281, 3250, 3557);
                }
            }
        }

        private List<string> _tags;

        [DataMember]
        public string User
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1281, 3784, 4168);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 3820, 4120) || true) && (this._user == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1281, 3820, 4120);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 4023, 4093);

                        this._user = f_1281_4036_4062() + "\\" + f_1281_4072_4092();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1281, 3820, 4120);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 4140, 4153);

                    return _user;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1281, 3784, 4168);

                    string
                    f_1281_4036_4062()
                    {
                        var return_v = Environment.UserDomainName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 4036, 4062);
                        return return_v;
                    }


                    string
                    f_1281_4072_4092()
                    {
                        var return_v = Environment.UserName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 4072, 4092);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1281, 3719, 4217);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1281, 3719, 4217);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1281, 4184, 4206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 4190, 4204);

                    _user = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1281, 4184, 4206);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1281, 3719, 4217);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1281, 3719, 4217);
                }
            }
        }

        private string _user;

        [DataMember]
        public string Computer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1281, 4446, 4528);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 4452, 4526);

                    return this._computerName ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1281, 4459, 4525) ?? (this._computerName = f_1281_4503_4524()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1281, 4446, 4528);

                    string
                    f_1281_4503_4524()
                    {
                        var return_v = PsUtils.GetHostName();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 4503, 4524);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1281, 4377, 4590);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1281, 4377, 4590);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1281, 4544, 4579);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 4550, 4577);

                    this._computerName = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1281, 4544, 4579);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1281, 4377, 4590);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1281, 4377, 4590);
                }
            }
        }

        private string _computerName;

        [DataMember]
        public uint ProcessId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1281, 4825, 5089);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 4861, 5025) || true) && (f_1281_4865_4890_M(!this._processId.HasValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1281, 4861, 5025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 4932, 5006);

                        this._processId = (uint)f_1281_4956_5005(f_1281_4956_5002());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1281, 4861, 5025);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 5045, 5074);

                    return f_1281_5052_5073(this._processId);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1281, 4825, 5089);

                    bool
                    f_1281_4865_4890_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 4865, 4890);
                        return return_v;
                    }


                    System.Diagnostics.Process
                    f_1281_4956_5002()
                    {
                        var return_v = System.Diagnostics.Process.GetCurrentProcess();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 4956, 5002);
                        return return_v;
                    }


                    int
                    f_1281_4956_5005(System.Diagnostics.Process
                    this_param)
                    {
                        var return_v = this_param.Id;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 4956, 5005);
                        return return_v;
                    }


                    uint
                    f_1281_5052_5073(uint?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 5052, 5073);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1281, 4757, 5143);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1281, 4757, 5143);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1281, 5105, 5132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 5111, 5130);

                    _processId = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1281, 5105, 5132);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1281, 4757, 5143);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1281, 4757, 5143);
                }
            }
        }

        private uint? _processId;

        public uint NativeThreadId { get; set; }

        [DataMember]
        public uint ManagedThreadId { get; set; }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1281, 5717, 5977);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 5775, 5966) || true) && (f_1281_5779_5790() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1281, 5775, 5966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 5832, 5862);

                    return f_1281_5839_5861(f_1281_5839_5850());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1281, 5775, 5966);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1281, 5775, 5966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 5928, 5951);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ToString(), 1281, 5935, 5950);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1281, 5775, 5966);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1281, 5717, 5977);

                object
                f_1281_5779_5790()
                {
                    var return_v = MessageData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 5779, 5790);
                    return return_v;
                }


                object
                f_1281_5839_5850()
                {
                    var return_v = MessageData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 5839, 5850);
                    return return_v;
                }


                string?
                f_1281_5839_5861(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 5839, 5861);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1281, 5717, 5977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1281, 5717, 5977);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static InformationRecord FromPSObjectForRemoting(PSObject inputObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1281, 5989, 7445);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 6093, 6155);

                InformationRecord
                informationRecord = f_1281_6131_6154()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 6171, 6272);

                informationRecord.MessageData = f_1281_6203_6271(inputObject, "MessageData");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 6286, 6377);

                informationRecord.Source = f_1281_6313_6376(inputObject, "Source");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 6391, 6498);

                informationRecord.TimeGenerated = f_1281_6425_6497(inputObject, "TimeGenerated");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 6514, 6558);

                informationRecord.Tags = f_1281_6539_6557();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 6572, 6701);

                System.Collections.ArrayList
                tagsArrayList = f_1281_6617_6700(inputObject, "Tags")
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 6715, 6832);
                    foreach (string tag in f_1281_6738_6751_I(tagsArrayList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1281, 6715, 6832);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 6785, 6817);

                        f_1281_6785_6816(f_1281_6785_6807(informationRecord), tag);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1281, 6715, 6832);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1281, 1, 118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1281, 1, 118);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 6848, 6935);

                informationRecord.User = f_1281_6873_6934(inputObject, "User");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 6949, 7044);

                informationRecord.Computer = f_1281_6978_7043(inputObject, "Computer");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 7058, 7153);

                informationRecord.ProcessId = f_1281_7088_7152(inputObject, "ProcessId");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 7167, 7272);

                informationRecord.NativeThreadId = f_1281_7202_7271(inputObject, "NativeThreadId");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 7286, 7393);

                informationRecord.ManagedThreadId = f_1281_7322_7392(inputObject, "ManagedThreadId");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 7409, 7434);

                return informationRecord;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1281, 5989, 7445);

                System.Management.Automation.InformationRecord
                f_1281_6131_6154()
                {
                    var return_v = new System.Management.Automation.InformationRecord();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 6131, 6154);
                    return return_v;
                }


                object
                f_1281_6203_6271(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<object>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 6203, 6271);
                    return return_v;
                }


                string
                f_1281_6313_6376(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<string>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 6313, 6376);
                    return return_v;
                }


                System.DateTime
                f_1281_6425_6497(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<DateTime>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 6425, 6497);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1281_6539_6557()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 6539, 6557);
                    return return_v;
                }


                System.Collections.ArrayList
                f_1281_6617_6700(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<System.Collections.ArrayList>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 6617, 6700);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1281_6785_6807(System.Management.Automation.InformationRecord
                this_param)
                {
                    var return_v = this_param.Tags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 6785, 6807);
                    return return_v;
                }


                int
                f_1281_6785_6816(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 6785, 6816);
                    return 0;
                }


                System.Collections.ArrayList
                f_1281_6738_6751_I(System.Collections.ArrayList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 6738, 6751);
                    return return_v;
                }


                string
                f_1281_6873_6934(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<string>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 6873, 6934);
                    return return_v;
                }


                string
                f_1281_6978_7043(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<string>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 6978, 7043);
                    return return_v;
                }


                uint
                f_1281_7088_7152(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<uint>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 7088, 7152);
                    return return_v;
                }


                uint
                f_1281_7202_7271(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<uint>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 7202, 7271);
                    return return_v;
                }


                uint
                f_1281_7322_7392(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<uint>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 7322, 7392);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1281, 5989, 7445);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1281, 5989, 7445);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PSObject ToPSObjectForRemoting()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1281, 7702, 8803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 7768, 7839);

                PSObject
                informationAsPSObject = f_1281_7801_7838()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 7855, 7945);

                f_1281_7855_7944(f_1281_7855_7887(informationAsPSObject), f_1281_7892_7943("MessageData", f_1281_7926_7942(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 7959, 8039);

                f_1281_7959_8038(f_1281_7959_7991(informationAsPSObject), f_1281_7996_8037("Source", f_1281_8025_8036(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 8053, 8147);

                f_1281_8053_8146(f_1281_8053_8085(informationAsPSObject), f_1281_8090_8145("TimeGenerated", f_1281_8126_8144(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 8161, 8237);

                f_1281_8161_8236(f_1281_8161_8193(informationAsPSObject), f_1281_8198_8235("Tags", f_1281_8225_8234(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 8251, 8327);

                f_1281_8251_8326(f_1281_8251_8283(informationAsPSObject), f_1281_8288_8325("User", f_1281_8315_8324(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 8341, 8425);

                f_1281_8341_8424(f_1281_8341_8373(informationAsPSObject), f_1281_8378_8423("Computer", f_1281_8409_8422(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 8439, 8525);

                f_1281_8439_8524(f_1281_8439_8471(informationAsPSObject), f_1281_8476_8523("ProcessId", f_1281_8508_8522(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 8539, 8635);

                f_1281_8539_8634(f_1281_8539_8571(informationAsPSObject), f_1281_8576_8633("NativeThreadId", f_1281_8613_8632(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 8649, 8747);

                f_1281_8649_8746(f_1281_8649_8681(informationAsPSObject), f_1281_8686_8745("ManagedThreadId", f_1281_8724_8744(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 8763, 8792);

                return informationAsPSObject;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1281, 7702, 8803);

                System.Management.Automation.PSObject
                f_1281_7801_7838()
                {
                    var return_v = RemotingEncoder.CreateEmptyPSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 7801, 7838);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1281_7855_7887(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 7855, 7887);
                    return return_v;
                }


                object
                f_1281_7926_7942(System.Management.Automation.InformationRecord
                this_param)
                {
                    var return_v = this_param.MessageData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 7926, 7942);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1281_7892_7943(string
                name, object
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 7892, 7943);
                    return return_v;
                }


                int
                f_1281_7855_7944(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 7855, 7944);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1281_7959_7991(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 7959, 7991);
                    return return_v;
                }


                string
                f_1281_8025_8036(System.Management.Automation.InformationRecord
                this_param)
                {
                    var return_v = this_param.Source;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 8025, 8036);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1281_7996_8037(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 7996, 8037);
                    return return_v;
                }


                int
                f_1281_7959_8038(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 7959, 8038);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1281_8053_8085(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 8053, 8085);
                    return return_v;
                }


                System.DateTime
                f_1281_8126_8144(System.Management.Automation.InformationRecord
                this_param)
                {
                    var return_v = this_param.TimeGenerated;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 8126, 8144);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1281_8090_8145(string
                name, System.DateTime
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 8090, 8145);
                    return return_v;
                }


                int
                f_1281_8053_8146(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 8053, 8146);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1281_8161_8193(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 8161, 8193);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1281_8225_8234(System.Management.Automation.InformationRecord
                this_param)
                {
                    var return_v = this_param.Tags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 8225, 8234);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1281_8198_8235(string
                name, System.Collections.Generic.List<string>
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 8198, 8235);
                    return return_v;
                }


                int
                f_1281_8161_8236(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 8161, 8236);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1281_8251_8283(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 8251, 8283);
                    return return_v;
                }


                string
                f_1281_8315_8324(System.Management.Automation.InformationRecord
                this_param)
                {
                    var return_v = this_param.User;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 8315, 8324);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1281_8288_8325(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 8288, 8325);
                    return return_v;
                }


                int
                f_1281_8251_8326(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 8251, 8326);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1281_8341_8373(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 8341, 8373);
                    return return_v;
                }


                string
                f_1281_8409_8422(System.Management.Automation.InformationRecord
                this_param)
                {
                    var return_v = this_param.Computer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 8409, 8422);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1281_8378_8423(string
                name, string
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 8378, 8423);
                    return return_v;
                }


                int
                f_1281_8341_8424(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 8341, 8424);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1281_8439_8471(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 8439, 8471);
                    return return_v;
                }


                uint
                f_1281_8508_8522(System.Management.Automation.InformationRecord
                this_param)
                {
                    var return_v = this_param.ProcessId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 8508, 8522);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1281_8476_8523(string
                name, uint
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 8476, 8523);
                    return return_v;
                }


                int
                f_1281_8439_8524(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 8439, 8524);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1281_8539_8571(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 8539, 8571);
                    return return_v;
                }


                uint
                f_1281_8613_8632(System.Management.Automation.InformationRecord
                this_param)
                {
                    var return_v = this_param.NativeThreadId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 8613, 8632);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1281_8576_8633(string
                name, uint
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 8576, 8633);
                    return return_v;
                }


                int
                f_1281_8539_8634(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 8539, 8634);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1281_8649_8681(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 8649, 8681);
                    return return_v;
                }


                uint
                f_1281_8724_8744(System.Management.Automation.InformationRecord
                this_param)
                {
                    var return_v = this_param.ManagedThreadId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 8724, 8744);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1281_8686_8745(string
                name, uint
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 8686, 8745);
                    return return_v;
                }


                int
                f_1281_8649_8746(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 8649, 8746);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1281, 7702, 8803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1281, 7702, 8803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static InformationRecord()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1281, 754, 8810);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1281, 754, 8810);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1281, 754, 8810);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1281, 754, 8810);

        uint
        f_1281_1377_1404()
        {
            var return_v = PsUtils.GetNativeThreadId();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1281, 1377, 1404);
            return return_v;
        }


        System.Threading.Thread
        f_1281_1448_1485()
        {
            var return_v = System.Threading.Thread.CurrentThread;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 1448, 1485);
            return return_v;
        }


        int
        f_1281_1448_1501(System.Threading.Thread
        this_param)
        {
            var return_v = this_param.ManagedThreadId;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 1448, 1501);
            return return_v;
        }


        object
        f_1281_1746_1768(System.Management.Automation.InformationRecord
        this_param)
        {
            var return_v = this_param.MessageData;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 1746, 1768);
            return return_v;
        }


        string
        f_1281_1797_1814(System.Management.Automation.InformationRecord
        this_param)
        {
            var return_v = this_param.Source;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 1797, 1814);
            return return_v;
        }


        System.DateTime
        f_1281_1852_1876(System.Management.Automation.InformationRecord
        this_param)
        {
            var return_v = this_param.TimeGenerated;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 1852, 1876);
            return return_v;
        }


        System.Collections.Generic.List<string>
        f_1281_1903_1918(System.Management.Automation.InformationRecord
        this_param)
        {
            var return_v = this_param.Tags;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 1903, 1918);
            return return_v;
        }


        string
        f_1281_1945_1960(System.Management.Automation.InformationRecord
        this_param)
        {
            var return_v = this_param.User;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 1945, 1960);
            return return_v;
        }


        string
        f_1281_1991_2010(System.Management.Automation.InformationRecord
        this_param)
        {
            var return_v = this_param.Computer;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 1991, 2010);
            return return_v;
        }


        uint
        f_1281_2042_2062(System.Management.Automation.InformationRecord
        this_param)
        {
            var return_v = this_param.ProcessId;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 2042, 2062);
            return return_v;
        }


        uint
        f_1281_2099_2124(System.Management.Automation.InformationRecord
        this_param)
        {
            var return_v = this_param.NativeThreadId;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 2099, 2124);
            return return_v;
        }


        uint
        f_1281_2162_2188(System.Management.Automation.InformationRecord
        this_param)
        {
            var return_v = this_param.ManagedThreadId;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 2162, 2188);
            return return_v;
        }

    }
    public class HostInformationMessage
    {
        public string Message { get; set; }

        public bool? NoNewLine { get; set; }

        public ConsoleColor? ForegroundColor { get; set; }

        public ConsoleColor? BackgroundColor { get; set; }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1281, 9826, 9910);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 9884, 9899);

                return f_1281_9891_9898();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1281, 9826, 9910);

                string
                f_1281_9891_9898()
                {
                    var return_v = Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1281, 9891, 9898);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1281, 9826, 9910);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1281, 9826, 9910);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public HostInformationMessage()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1281, 8969, 9917);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 9119, 9154);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 9296, 9332);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 9441, 9491);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1281, 9600, 9650);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1281, 8969, 9917);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1281, 8969, 9917);
        }


        static HostInformationMessage()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1281, 8969, 9917);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1281, 8969, 9917);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1281, 8969, 9917);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1281, 8969, 9917);
    }
}
