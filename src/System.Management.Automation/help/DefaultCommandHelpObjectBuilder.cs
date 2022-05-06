// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Management.Automation.Internal;
using System.Management.Automation.Runspaces;
using System.Reflection;
using System.Text;

namespace System.Management.Automation.Help
{
internal class PositionalParameterComparer : IComparer
{
public int Compare(object x, object y)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1146,756,1048);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,819,870);

CommandParameterInfo 
a = x as CommandParameterInfo
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,884,935);

CommandParameterInfo 
b = y as CommandParameterInfo
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,951,988);

f_1146_951_987(a != null &&(DynAbs.Tracing.TraceSender.Expression_True(1146, 964, 986)&&b != null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,1004,1037);

return (f_1146_1012_1022(a)- f_1146_1025_1035(b));
DynAbs.Tracing.TraceSender.TraceExitMethod(1146,756,1048);

int
f_1146_951_987(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 951, 987);
return 0;
}


int
f_1146_1012_1022(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.Position ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 1012, 1022);
return return_v;
}


int
f_1146_1025_1035(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.Position;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 1025, 1035);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1146,756,1048);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,756,1048);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public PositionalParameterComparer()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1146,529,1055);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1146,529,1055);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,529,1055);
}


static PositionalParameterComparer()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1146,529,1055);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1146,529,1055);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,529,1055);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1146,529,1055);
}
internal class DefaultCommandHelpObjectBuilder
{
internal static string TypeNameForDefaultHelp ;

internal static PSObject GetPSObjectFromCmdletInfo(CommandInfo input)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1146,1810,6896);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,2077,2136);

CommandInfo 
commandInfo = f_1146_2103_2135(input, null)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,2152,2182);

PSObject 
obj = f_1146_2167_2181()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,2198,2220);

f_1146_2198_2219(f_1146_2198_2211(obj));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,2234,2396);

f_1146_2234_2395(f_1146_2234_2247(obj), f_1146_2252_2394(f_1146_2266_2294(), "{0}#{1}#command", DefaultCommandHelpObjectBuilder.TypeNameForDefaultHelp, f_1146_2371_2393(commandInfo)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,2410,2564);

f_1146_2410_2563(f_1146_2410_2423(obj), f_1146_2428_2562(f_1146_2442_2470(), "{0}#{1}", DefaultCommandHelpObjectBuilder.TypeNameForDefaultHelp, f_1146_2539_2561(commandInfo)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,2578,2652);

f_1146_2578_2651(f_1146_2578_2591(obj), DefaultCommandHelpObjectBuilder.TypeNameForDefaultHelp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,2666,2702);

f_1146_2666_2701(f_1146_2666_2679(obj), "CmdletHelpInfo");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,2716,2746);

f_1146_2716_2745(f_1146_2716_2729(obj), "HelpInfo");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,2762,6019) || true) && (commandInfo is CmdletInfo cmdletInfo)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,2762,6019);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,2836,2856);

bool 
common = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,2874,3020) || true) && (f_1146_2878_2899(cmdletInfo)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,2874,3020);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,2949,3001);

common = f_1146_2958_3000(f_1146_2978_2999(cmdletInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,2874,3020);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,3040,3107);

f_1146_3040_3106(f_1146_3040_3054(obj), f_1146_3059_3105("CommonParameters", common));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,3125,3226);

f_1146_3125_3225(obj, f_1146_3151_3166(cmdletInfo), f_1146_3168_3183(cmdletInfo), f_1146_3185_3200(cmdletInfo), TypeNameForDefaultHelp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,3244,3344);

f_1146_3244_3343(obj, f_1146_3269_3284(cmdletInfo), f_1146_3286_3310(cmdletInfo), common, TypeNameForDefaultHelp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,3362,3446);

f_1146_3362_3445(obj, f_1146_3391_3412(cmdletInfo), common, TypeNameForDefaultHelp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,3464,3516);

f_1146_3464_3515(obj, f_1146_3493_3514(cmdletInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,3534,3602);

f_1146_3534_3601(obj, f_1146_3565_3600(f_1146_3565_3592(commandInfo)));

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,3666,3719);

f_1146_3666_3718(obj, f_1146_3696_3717(cmdletInfo));
                }
                catch (PSInvalidOperationException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1146,3756,3941);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,3832,3922);

f_1146_3832_3921(obj, f_1146_3862_3920(f_1146_3897_3919()));
DynAbs.Tracing.TraceSender.TraceExitCatch(1146,3756,3941);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,3961,4024);

f_1146_3961_4023(obj, f_1146_3987_4002(cmdletInfo), f_1146_4004_4022(cmdletInfo));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,4044,4401) || true) && (f_1146_4048_4104(f_1146_4063_4080(cmdletInfo), f_1146_4082_4103(cmdletInfo)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,4044,4401);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,4146,4225);

f_1146_4146_4224(obj, f_1146_4172_4187(cmdletInfo), f_1146_4189_4223(f_1146_4189_4215(cmdletInfo)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,4044,4401);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,4044,4401);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,4307,4382);

f_1146_4307_4381(f_1146_4307_4321(obj), f_1146_4326_4380("remarks", f_1146_4356_4379()));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,4044,4401);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,4421,4493);

f_1146_4421_4492(f_1146_4421_4435(obj), f_1146_4440_4491("PSSnapIn", f_1146_4471_4490(cmdletInfo)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,2762,6019);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,2762,6019);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,4527,6019) || true) && (commandInfo is FunctionInfo funcInfo)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,4527,6019);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,4601,4656);

bool 
common = f_1146_4615_4655(f_1146_4635_4654(funcInfo))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,4676,4743);

f_1146_4676_4742(f_1146_4676_4690(obj), f_1146_4695_4741("CommonParameters", common));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,4761,4854);

f_1146_4761_4853(obj, f_1146_4787_4800(funcInfo), string.Empty, string.Empty, TypeNameForDefaultHelp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,4872,4968);

f_1146_4872_4967(obj, f_1146_4897_4910(funcInfo), f_1146_4912_4934(funcInfo), common, TypeNameForDefaultHelp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,4986,5068);

f_1146_4986_5067(obj, f_1146_5015_5034(funcInfo), common, TypeNameForDefaultHelp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,5086,5136);

f_1146_5086_5135(obj, f_1146_5115_5134(funcInfo));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,5154,5219);

f_1146_5154_5218(obj, f_1146_5185_5217(f_1146_5185_5209(funcInfo)));

                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,5283,5334);

f_1146_5283_5333(obj, f_1146_5313_5332(funcInfo));
                }
                catch (PSInvalidOperationException)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1146,5371,5556);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,5447,5537);

f_1146_5447_5536(obj, f_1146_5477_5535(f_1146_5512_5534()));
DynAbs.Tracing.TraceSender.TraceExitCatch(1146,5371,5556);
                }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,5576,5635);

f_1146_5576_5634(obj, f_1146_5602_5615(funcInfo), f_1146_5617_5633(funcInfo));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,5655,6004) || true) && (f_1146_5659_5711(f_1146_5674_5689(funcInfo), f_1146_5691_5710(funcInfo)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,5655,6004);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,5753,5828);

f_1146_5753_5827(obj, f_1146_5779_5792(funcInfo), f_1146_5794_5826(f_1146_5794_5818(funcInfo)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,5655,6004);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,5655,6004);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,5910,5985);

f_1146_5910_5984(f_1146_5910_5924(obj), f_1146_5929_5983("remarks", f_1146_5959_5982()));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,5655,6004);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,4527,6019);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,2762,6019);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,6035,6092);

f_1146_6035_6091(f_1146_6035_6049(obj), f_1146_6054_6090("alertSet", null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,6106,6166);

f_1146_6106_6165(f_1146_6106_6120(obj), f_1146_6125_6164("description", null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,6180,6237);

f_1146_6180_6236(f_1146_6180_6194(obj), f_1146_6199_6235("examples", null));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,6251,6322);

f_1146_6251_6321(f_1146_6251_6265(obj), f_1146_6270_6320("Synopsis", f_1146_6301_6319(commandInfo)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,6336,6413);

f_1146_6336_6412(f_1146_6336_6350(obj), f_1146_6355_6411("ModuleName", f_1146_6388_6410(commandInfo)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,6427,6504);

f_1146_6427_6503(f_1146_6427_6441(obj), f_1146_6446_6502("nonTerminatingErrors", string.Empty));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,6518,6631);

f_1146_6518_6630(f_1146_6518_6532(obj), f_1146_6537_6629("xmlns:command", "http://schemas.microsoft.com/maml/dev/command/2004/10"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,6645,6746);

f_1146_6645_6745(f_1146_6645_6659(obj), f_1146_6664_6744("xmlns:dev", "http://schemas.microsoft.com/maml/dev/2004/10"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,6760,6858);

f_1146_6760_6857(f_1146_6760_6774(obj), f_1146_6779_6856("xmlns:maml", "http://schemas.microsoft.com/maml/2004/10"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,6874,6885);

return obj;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1146,1810,6896);

System.Management.Automation.CommandInfo
f_1146_2103_2135(System.Management.Automation.CommandInfo
this_param,object[]
argumentList)
{
var return_v = this_param.CreateGetCommandCopy( argumentList);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 2103, 2135);
return return_v;
}


System.Management.Automation.PSObject
f_1146_2167_2181()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 2167, 2181);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1146_2198_2211(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 2198, 2211);
return return_v;
}


int
f_1146_2198_2219(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 2198, 2219);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1146_2234_2247(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 2234, 2247);
return return_v;
}


System.Globalization.CultureInfo
f_1146_2266_2294()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 2266, 2294);
return return_v;
}


string
f_1146_2371_2393(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 2371, 2393);
return return_v;
}


string
f_1146_2252_2394(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 2252, 2394);
return return_v;
}


int
f_1146_2234_2395(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 2234, 2395);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1146_2410_2423(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 2410, 2423);
return return_v;
}


System.Globalization.CultureInfo
f_1146_2442_2470()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 2442, 2470);
return return_v;
}


string
f_1146_2539_2561(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 2539, 2561);
return return_v;
}


string
f_1146_2428_2562(System.Globalization.CultureInfo
provider,string
format,string
arg0,string
arg1)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 2428, 2562);
return return_v;
}


int
f_1146_2410_2563(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 2410, 2563);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1146_2578_2591(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 2578, 2591);
return return_v;
}


int
f_1146_2578_2651(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 2578, 2651);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1146_2666_2679(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 2666, 2679);
return return_v;
}


int
f_1146_2666_2701(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 2666, 2701);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1146_2716_2729(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 2716, 2729);
return return_v;
}


int
f_1146_2716_2745(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 2716, 2745);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
f_1146_2878_2899(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.Parameters ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 2878, 2899);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
f_1146_2978_2999(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 2978, 2999);
return return_v;
}


bool
f_1146_2958_3000(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
parameters)
{
var return_v = HasCommonParameters( parameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 2958, 3000);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_3040_3054(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 3040, 3054);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_3059_3105(string
name,bool
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 3059, 3105);
return return_v;
}


int
f_1146_3040_3106(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 3040, 3106);
return 0;
}


string
f_1146_3151_3166(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 3151, 3166);
return return_v;
}


string
f_1146_3168_3183(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.Noun;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 3168, 3183);
return return_v;
}


string
f_1146_3185_3200(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.Verb;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 3185, 3200);
return return_v;
}


int
f_1146_3125_3225(System.Management.Automation.PSObject
obj,string
name,string
noun,string
verb,string
typeNameForHelp)
{
AddDetailsProperties( obj, name, noun, verb, typeNameForHelp);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 3125, 3225);
return 0;
}


string
f_1146_3269_3284(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 3269, 3284);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>
f_1146_3286_3310(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.ParameterSets;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 3286, 3310);
return return_v;
}


int
f_1146_3244_3343(System.Management.Automation.PSObject
obj,string
cmdletName,System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>
parameterSets,bool
common,string
typeNameForHelp)
{
AddSyntaxProperties( obj, cmdletName, parameterSets, common, typeNameForHelp);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 3244, 3343);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
f_1146_3391_3412(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 3391, 3412);
return return_v;
}


int
f_1146_3362_3445(System.Management.Automation.PSObject
obj,System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
parameters,bool
common,string
typeNameForHelp)
{
AddParametersProperties( obj, parameters, common, typeNameForHelp);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 3362, 3445);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
f_1146_3493_3514(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 3493, 3514);
return return_v;
}


int
f_1146_3464_3515(System.Management.Automation.PSObject
obj,System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
parameters)
{
AddInputTypesProperties( obj, parameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 3464, 3515);
return 0;
}


System.Management.Automation.CommandMetadata
f_1146_3565_3592(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.CommandMetadata;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 3565, 3592);
return return_v;
}


string
f_1146_3565_3600(System.Management.Automation.CommandMetadata
this_param)
{
var return_v = this_param.HelpUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 3565, 3600);
return return_v;
}


int
f_1146_3534_3601(System.Management.Automation.PSObject
obj,string
relatedLink)
{
AddRelatedLinksProperties( obj, relatedLink);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 3534, 3601);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
f_1146_3696_3717(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.OutputType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 3696, 3717);
return return_v;
}


int
f_1146_3666_3718(System.Management.Automation.PSObject
obj,System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
outputTypes)
{
AddOutputTypesProperties( obj, outputTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 3666, 3718);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.PSTypeName>
f_1146_3897_3919()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.PSTypeName>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 3897, 3919);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
f_1146_3862_3920(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
list)
{
var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>( (System.Collections.Generic.IList<System.Management.Automation.PSTypeName>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 3862, 3920);
return return_v;
}


int
f_1146_3832_3921(System.Management.Automation.PSObject
obj,System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
outputTypes)
{
AddOutputTypesProperties( obj, outputTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 3832, 3921);
return 0;
}


string
f_1146_3987_4002(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 3987, 4002);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1146_4004_4022(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 4004, 4022);
return return_v;
}


int
f_1146_3961_4023(System.Management.Automation.PSObject
obj,string
name,System.Management.Automation.ExecutionContext
context)
{
AddAliasesProperties( obj, name, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 3961, 4023);
return 0;
}


System.Management.Automation.PSModuleInfo
f_1146_4063_4080(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.Module;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 4063, 4080);
return return_v;
}


string
f_1146_4082_4103(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 4082, 4103);
return return_v;
}


bool
f_1146_4048_4104(System.Management.Automation.PSModuleInfo
module,string
moduleName)
{
var return_v = HasHelpInfoUri( module, moduleName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 4048, 4104);
return return_v;
}


string
f_1146_4172_4187(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 4172, 4187);
return return_v;
}


System.Management.Automation.CommandMetadata
f_1146_4189_4215(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.CommandMetadata;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 4189, 4215);
return return_v;
}


string
f_1146_4189_4223(System.Management.Automation.CommandMetadata
this_param)
{
var return_v = this_param.HelpUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 4189, 4223);
return return_v;
}


int
f_1146_4146_4224(System.Management.Automation.PSObject
obj,string
cmdletName,string
helpUri)
{
AddRemarksProperties( obj, cmdletName, helpUri);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 4146, 4224);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_4307_4321(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 4307, 4321);
return return_v;
}


string
f_1146_4356_4379()
{
var return_v = HelpDisplayStrings.None;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 4356, 4379);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_4326_4380(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 4326, 4380);
return return_v;
}


int
f_1146_4307_4381(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 4307, 4381);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_4421_4435(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 4421, 4435);
return return_v;
}


System.Management.Automation.PSSnapInInfo
f_1146_4471_4490(System.Management.Automation.CmdletInfo
this_param)
{
var return_v = this_param.PSSnapIn;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 4471, 4490);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_4440_4491(string
name,System.Management.Automation.PSSnapInInfo
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 4440, 4491);
return return_v;
}


int
f_1146_4421_4492(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 4421, 4492);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
f_1146_4635_4654(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 4635, 4654);
return return_v;
}


bool
f_1146_4615_4655(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
parameters)
{
var return_v = HasCommonParameters( parameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 4615, 4655);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_4676_4690(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 4676, 4690);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_4695_4741(string
name,bool
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 4695, 4741);
return return_v;
}


int
f_1146_4676_4742(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 4676, 4742);
return 0;
}


string
f_1146_4787_4800(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 4787, 4800);
return return_v;
}


int
f_1146_4761_4853(System.Management.Automation.PSObject
obj,string
name,string
noun,string
verb,string
typeNameForHelp)
{
AddDetailsProperties( obj, name, noun, verb, typeNameForHelp);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 4761, 4853);
return 0;
}


string
f_1146_4897_4910(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 4897, 4910);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>
f_1146_4912_4934(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.ParameterSets;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 4912, 4934);
return return_v;
}


int
f_1146_4872_4967(System.Management.Automation.PSObject
obj,string
cmdletName,System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>
parameterSets,bool
common,string
typeNameForHelp)
{
AddSyntaxProperties( obj, cmdletName, parameterSets, common, typeNameForHelp);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 4872, 4967);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
f_1146_5015_5034(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 5015, 5034);
return return_v;
}


int
f_1146_4986_5067(System.Management.Automation.PSObject
obj,System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
parameters,bool
common,string
typeNameForHelp)
{
AddParametersProperties( obj, parameters, common, typeNameForHelp);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 4986, 5067);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
f_1146_5115_5134(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 5115, 5134);
return return_v;
}


int
f_1146_5086_5135(System.Management.Automation.PSObject
obj,System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
parameters)
{
AddInputTypesProperties( obj, parameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 5086, 5135);
return 0;
}


System.Management.Automation.CommandMetadata
f_1146_5185_5209(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.CommandMetadata;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 5185, 5209);
return return_v;
}


string
f_1146_5185_5217(System.Management.Automation.CommandMetadata
this_param)
{
var return_v = this_param.HelpUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 5185, 5217);
return return_v;
}


int
f_1146_5154_5218(System.Management.Automation.PSObject
obj,string
relatedLink)
{
AddRelatedLinksProperties( obj, relatedLink);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 5154, 5218);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
f_1146_5313_5332(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.OutputType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 5313, 5332);
return return_v;
}


int
f_1146_5283_5333(System.Management.Automation.PSObject
obj,System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
outputTypes)
{
AddOutputTypesProperties( obj, outputTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 5283, 5333);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.PSTypeName>
f_1146_5512_5534()
{
var return_v = new System.Collections.Generic.List<System.Management.Automation.PSTypeName>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 5512, 5534);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
f_1146_5477_5535(System.Collections.Generic.List<System.Management.Automation.PSTypeName>
list)
{
var return_v = new System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>( (System.Collections.Generic.IList<System.Management.Automation.PSTypeName>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 5477, 5535);
return return_v;
}


int
f_1146_5447_5536(System.Management.Automation.PSObject
obj,System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
outputTypes)
{
AddOutputTypesProperties( obj, outputTypes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 5447, 5536);
return 0;
}


string
f_1146_5602_5615(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 5602, 5615);
return return_v;
}


System.Management.Automation.ExecutionContext
f_1146_5617_5633(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.Context;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 5617, 5633);
return return_v;
}


int
f_1146_5576_5634(System.Management.Automation.PSObject
obj,string
name,System.Management.Automation.ExecutionContext
context)
{
AddAliasesProperties( obj, name, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 5576, 5634);
return 0;
}


System.Management.Automation.PSModuleInfo
f_1146_5674_5689(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.Module;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 5674, 5689);
return return_v;
}


string
f_1146_5691_5710(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 5691, 5710);
return return_v;
}


bool
f_1146_5659_5711(System.Management.Automation.PSModuleInfo
module,string
moduleName)
{
var return_v = HasHelpInfoUri( module, moduleName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 5659, 5711);
return return_v;
}


string
f_1146_5779_5792(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 5779, 5792);
return return_v;
}


System.Management.Automation.CommandMetadata
f_1146_5794_5818(System.Management.Automation.FunctionInfo
this_param)
{
var return_v = this_param.CommandMetadata;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 5794, 5818);
return return_v;
}


string
f_1146_5794_5826(System.Management.Automation.CommandMetadata
this_param)
{
var return_v = this_param.HelpUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 5794, 5826);
return return_v;
}


int
f_1146_5753_5827(System.Management.Automation.PSObject
obj,string
cmdletName,string
helpUri)
{
AddRemarksProperties( obj, cmdletName, helpUri);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 5753, 5827);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_5910_5924(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 5910, 5924);
return return_v;
}


string
f_1146_5959_5982()
{
var return_v = HelpDisplayStrings.None;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 5959, 5982);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_5929_5983(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 5929, 5983);
return return_v;
}


int
f_1146_5910_5984(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 5910, 5984);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_6035_6049(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 6035, 6049);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_6054_6090(string
name,object
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 6054, 6090);
return return_v;
}


int
f_1146_6035_6091(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 6035, 6091);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_6106_6120(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 6106, 6120);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_6125_6164(string
name,object
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 6125, 6164);
return return_v;
}


int
f_1146_6106_6165(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 6106, 6165);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_6180_6194(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 6180, 6194);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_6199_6235(string
name,object
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 6199, 6235);
return return_v;
}


int
f_1146_6180_6236(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 6180, 6236);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_6251_6265(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 6251, 6265);
return return_v;
}


string
f_1146_6301_6319(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.Syntax;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 6301, 6319);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_6270_6320(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 6270, 6320);
return return_v;
}


int
f_1146_6251_6321(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 6251, 6321);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_6336_6350(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 6336, 6350);
return return_v;
}


string
f_1146_6388_6410(System.Management.Automation.CommandInfo
this_param)
{
var return_v = this_param.ModuleName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 6388, 6410);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_6355_6411(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 6355, 6411);
return return_v;
}


int
f_1146_6336_6412(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 6336, 6412);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_6427_6441(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 6427, 6441);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_6446_6502(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 6446, 6502);
return return_v;
}


int
f_1146_6427_6503(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 6427, 6503);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_6518_6532(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 6518, 6532);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_6537_6629(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 6537, 6629);
return return_v;
}


int
f_1146_6518_6630(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 6518, 6630);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_6645_6659(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 6645, 6659);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_6664_6744(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 6664, 6744);
return return_v;
}


int
f_1146_6645_6745(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 6645, 6745);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_6760_6774(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 6760, 6774);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_6779_6856(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 6779, 6856);
return return_v;
}


int
f_1146_6760_6857(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 6760, 6857);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1146,1810,6896);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,1810,6896);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static void AddDetailsProperties(PSObject obj, string name, string noun, string verb, string typeNameForHelp,
            string synopsis = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1146,7340,8507);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,7520,7556);

PSObject 
mshObject = f_1146_7541_7555()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,7572,7600);

f_1146_7572_7599(f_1146_7572_7591(mshObject));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,7614,7715);

f_1146_7614_7714(f_1146_7614_7633(mshObject), f_1146_7638_7713(f_1146_7652_7680(), "{0}#details", typeNameForHelp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,7731,7790);

f_1146_7731_7789(f_1146_7731_7751(mshObject), f_1146_7756_7788("name", name));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,7804,7863);

f_1146_7804_7862(f_1146_7804_7824(mshObject), f_1146_7829_7861("noun", noun));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,7877,7936);

f_1146_7877_7935(f_1146_7877_7897(mshObject), f_1146_7902_7934("verb", verb));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,7981,8419) || true) && (!f_1146_7986_8016(synopsis))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,7981,8419);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,8050,8094);

PSObject 
descriptionObject = f_1146_8079_8093()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,8112,8148);

f_1146_8112_8147(f_1146_8112_8139(descriptionObject));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,8166,8218);

f_1146_8166_8217(f_1146_8166_8193(descriptionObject), "MamlParaTextItem");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,8236,8307);

f_1146_8236_8306(f_1146_8236_8264(descriptionObject), f_1146_8269_8305("Text", synopsis));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,8325,8404);

f_1146_8325_8403(f_1146_8325_8345(mshObject), f_1146_8350_8402("Description", descriptionObject));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,7981,8419);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,8435,8496);

f_1146_8435_8495(f_1146_8435_8449(obj), f_1146_8454_8494("details", mshObject));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1146,7340,8507);

System.Management.Automation.PSObject
f_1146_7541_7555()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 7541, 7555);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1146_7572_7591(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 7572, 7591);
return return_v;
}


int
f_1146_7572_7599(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 7572, 7599);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1146_7614_7633(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 7614, 7633);
return return_v;
}


System.Globalization.CultureInfo
f_1146_7652_7680()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 7652, 7680);
return return_v;
}


string
f_1146_7638_7713(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 7638, 7713);
return return_v;
}


int
f_1146_7614_7714(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 7614, 7714);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_7731_7751(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 7731, 7751);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_7756_7788(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 7756, 7788);
return return_v;
}


int
f_1146_7731_7789(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 7731, 7789);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_7804_7824(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 7804, 7824);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_7829_7861(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 7829, 7861);
return return_v;
}


int
f_1146_7804_7862(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 7804, 7862);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_7877_7897(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 7877, 7897);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_7902_7934(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 7902, 7934);
return return_v;
}


int
f_1146_7877_7935(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 7877, 7935);
return 0;
}


bool
f_1146_7986_8016(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 7986, 8016);
return return_v;
}


System.Management.Automation.PSObject
f_1146_8079_8093()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 8079, 8093);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1146_8112_8139(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 8112, 8139);
return return_v;
}


int
f_1146_8112_8147(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 8112, 8147);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1146_8166_8193(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 8166, 8193);
return return_v;
}


int
f_1146_8166_8217(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 8166, 8217);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_8236_8264(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 8236, 8264);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_8269_8305(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 8269, 8305);
return return_v;
}


int
f_1146_8236_8306(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 8236, 8306);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_8325_8345(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 8325, 8345);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_8350_8402(string
name,System.Management.Automation.PSObject
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 8350, 8402);
return return_v;
}


int
f_1146_8325_8403(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 8325, 8403);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_8435_8449(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 8435, 8449);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_8454_8494(string
name,System.Management.Automation.PSObject
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 8454, 8494);
return return_v;
}


int
f_1146_8435_8495(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 8435, 8495);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1146,7340,8507);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,7340,8507);
}
		}

internal static void AddSyntaxProperties(PSObject obj, string cmdletName, ReadOnlyCollection<CommandParameterSetInfo> parameterSets, bool common, string typeNameForHelp)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1146,8920,9498);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,9114,9150);

PSObject 
mshObject = f_1146_9135_9149()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,9166,9194);

f_1146_9166_9193(f_1146_9166_9185(mshObject));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,9208,9308);

f_1146_9208_9307(f_1146_9208_9227(mshObject), f_1146_9232_9306(f_1146_9246_9274(), "{0}#syntax", typeNameForHelp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,9324,9411);

f_1146_9324_9410(mshObject, cmdletName, parameterSets, common, typeNameForHelp);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,9427,9487);

f_1146_9427_9486(f_1146_9427_9441(obj), f_1146_9446_9485("Syntax", mshObject));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1146,8920,9498);

System.Management.Automation.PSObject
f_1146_9135_9149()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 9135, 9149);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1146_9166_9185(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 9166, 9185);
return return_v;
}


int
f_1146_9166_9193(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 9166, 9193);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1146_9208_9227(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 9208, 9227);
return return_v;
}


System.Globalization.CultureInfo
f_1146_9246_9274()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 9246, 9274);
return return_v;
}


string
f_1146_9232_9306(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 9232, 9306);
return return_v;
}


int
f_1146_9208_9307(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 9208, 9307);
return 0;
}


int
f_1146_9324_9410(System.Management.Automation.PSObject
obj,string
cmdletName,System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>
parameterSets,bool
common,string
typeNameForHelp)
{
AddSyntaxItemProperties( obj, cmdletName, parameterSets, common, typeNameForHelp);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 9324, 9410);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_9427_9441(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 9427, 9441);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_9446_9485(string
name,System.Management.Automation.PSObject
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 9446, 9485);
return return_v;
}


int
f_1146_9427_9486(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 9427, 9486);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1146,8920,9498);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,8920,9498);
}
		}

private static void AddSyntaxItemProperties(PSObject obj, string cmdletName, ReadOnlyCollection<CommandParameterSetInfo> parameterSets, bool common, string typeNameForHelp)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1146,9969,11398);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,10166,10205);

ArrayList 
mshObjects = f_1146_10189_10204()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,10221,11296);
foreach(CommandParameterSetInfo parameterSet in f_1146_10270_10283_I(parameterSets) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,10221,11296);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,10317,10353);

PSObject 
mshObject = f_1146_10338_10352()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,10373,10401);

f_1146_10373_10400(f_1146_10373_10392(mshObject));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,10419,10523);

f_1146_10419_10522(f_1146_10419_10438(mshObject), f_1146_10443_10521(f_1146_10457_10485(), "{0}#syntaxItem", typeNameForHelp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,10543,10608);

f_1146_10543_10607(f_1146_10543_10563(mshObject), f_1146_10568_10606("name", cmdletName));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,10626,10699);

f_1146_10626_10698(f_1146_10626_10646(mshObject), f_1146_10651_10697("CommonParameters", common));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,10719,10804);

Collection<CommandParameterInfo> 
parameters = f_1146_10765_10803()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,11059,11135);

f_1146_11059_11134(                // GenerateParameters parameters in display order
                // ie., Positional followed by
                //      Named Mandatory (in alpha numeric) followed by
                //      Named (in alpha numeric)
                parameterSet, parameters.Add, delegate { });
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,11155,11235);

f_1146_11155_11234(mshObject, parameters, common, f_1146_11216_11233(parameterSet));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,11255,11281);

f_1146_11255_11280(
                mshObjects, mshObject);
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,10221,11296);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1146,1,1076);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1146,1,1076);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,11312,11387);

f_1146_11312_11386(f_1146_11312_11326(obj), f_1146_11331_11385("syntaxItem", f_1146_11364_11384(mshObjects)));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1146,9969,11398);

System.Collections.ArrayList
f_1146_10189_10204()
{
var return_v = new System.Collections.ArrayList();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 10189, 10204);
return return_v;
}


System.Management.Automation.PSObject
f_1146_10338_10352()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 10338, 10352);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1146_10373_10392(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 10373, 10392);
return return_v;
}


int
f_1146_10373_10400(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 10373, 10400);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1146_10419_10438(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 10419, 10438);
return return_v;
}


System.Globalization.CultureInfo
f_1146_10457_10485()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 10457, 10485);
return return_v;
}


string
f_1146_10443_10521(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 10443, 10521);
return return_v;
}


int
f_1146_10419_10522(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 10419, 10522);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_10543_10563(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 10543, 10563);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_10568_10606(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 10568, 10606);
return return_v;
}


int
f_1146_10543_10607(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 10543, 10607);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_10626_10646(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 10626, 10646);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_10651_10697(string
name,bool
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 10651, 10697);
return return_v;
}


int
f_1146_10626_10698(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 10626, 10698);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInfo>
f_1146_10765_10803()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInfo>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 10765, 10803);
return return_v;
}


int
f_1146_11059_11134(System.Management.Automation.CommandParameterSetInfo
this_param,System.Action<System.Management.Automation.CommandParameterInfo>
parameterAction,System.Action<string>
commonParameterAction)
{
this_param.GenerateParametersInDisplayOrder( parameterAction, commonParameterAction);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 11059, 11134);
return 0;
}


string
f_1146_11216_11233(System.Management.Automation.CommandParameterSetInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 11216, 11233);
return return_v;
}


int
f_1146_11155_11234(System.Management.Automation.PSObject
obj,System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInfo>
parameters,bool
common,string
parameterSetName)
{
AddSyntaxParametersProperties( obj, (System.Collections.Generic.IEnumerable<System.Management.Automation.CommandParameterInfo>)parameters, common, parameterSetName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 11155, 11234);
return 0;
}


int
f_1146_11255_11280(System.Collections.ArrayList
this_param,System.Management.Automation.PSObject
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 11255, 11280);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>
f_1146_10270_10283_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.CommandParameterSetInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 10270, 10283);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_11312_11326(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 11312, 11326);
return return_v;
}


object?[]
f_1146_11364_11384(System.Collections.ArrayList
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 11364, 11384);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_11331_11385(string
name,object?[]
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 11331, 11385);
return return_v;
}


int
f_1146_11312_11386(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 11312, 11386);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1146,9969,11398);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,9969,11398);
}
		}

private static void AddSyntaxParametersProperties(PSObject obj, IEnumerable<CommandParameterInfo> parameters,
            bool common, string parameterSetName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1146,12061,15689);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,12246,12285);

ArrayList 
mshObjects = f_1146_12269_12284()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,12301,15588);
foreach(CommandParameterInfo parameter in f_1146_12344_12354_I(parameters) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,12301,15588);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,12388,12520) || true) && (common &&(DynAbs.Tracing.TraceSender.Expression_True(1146, 12392, 12450)&&f_1146_12402_12450(f_1146_12402_12425(), f_1146_12435_12449(parameter))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,12388,12520);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,12492,12501);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,12388,12520);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,12540,12576);

PSObject 
mshObject = f_1146_12561_12575()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,12596,12624);

f_1146_12596_12623(f_1146_12596_12615(mshObject));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,12642,12784);

f_1146_12642_12783(f_1146_12642_12661(mshObject), f_1146_12666_12782(f_1146_12680_12708(), "{0}#parameter", DefaultCommandHelpObjectBuilder.TypeNameForDefaultHelp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,12804,12887);

Collection<Attribute> 
attributes = f_1146_12839_12886(f_1146_12865_12885(parameter))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,12907,13097);

f_1146_12907_13096(mshObject, f_1146_12941_12955(parameter), f_1146_12957_12998(f_1146_12980_12997(parameter)), f_1146_13021_13040(parameter), f_1146_13042_13065(parameter), attributes, parameterSetName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,13117,13200);

Collection<ValidateSetAttribute> 
validateSet = f_1146_13164_13199(attributes)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,13218,13258);

List<string> 
names = f_1146_13239_13257()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,13278,13517);
foreach(ValidateSetAttribute set in f_1146_13315_13326_I(validateSet) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,13278,13517);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,13368,13498);
foreach(string value in f_1146_13393_13408_I(f_1146_13393_13408(set)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,13368,13498);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,13458,13475);

f_1146_13458_13474(                        names, value);
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,13368,13498);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1146,1,131);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1146,1,131);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1146,13278,13517);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1146,1,240);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1146,1,240);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,13537,15527) || true) && (f_1146_13541_13552(names)!= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,13537,15527);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,13599,13660);

f_1146_13599_13659(mshObject, f_1146_13643_13658(names));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,13537,15527);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,13537,15527);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,13742,15508) || true) && (f_1146_13746_13776(f_1146_13746_13769(parameter))&&(DynAbs.Tracing.TraceSender.Expression_True(1146, 13746, 13828)&&(f_1146_13781_13819(f_1146_13795_13818(parameter))!= null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,13742,15508);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,13878,13962);

f_1146_13878_13961(mshObject, f_1146_13922_13960(f_1146_13936_13959(parameter)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,13742,15508);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,13742,15508);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,14012,15508) || true) && (f_1146_14016_14047(f_1146_14016_14039(parameter)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,14012,15508);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,14097,14430) || true) && (f_1146_14101_14148(f_1146_14101_14141(f_1146_14101_14124(parameter)))&&(DynAbs.Tracing.TraceSender.Expression_True(1146, 14101, 14244)&&f_1146_14181_14236(f_1146_14195_14235(f_1146_14195_14218(parameter)))!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,14097,14430);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,14302,14403);

f_1146_14302_14402(mshObject, f_1146_14346_14401(f_1146_14360_14400(f_1146_14360_14383(parameter))));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,14097,14430);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,14012,15508);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,14012,15508);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,14480,15508) || true) && (f_1146_14484_14521(f_1146_14484_14507(parameter)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,14480,15508);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,14571,14632);

Type[] 
types = f_1146_14586_14631(f_1146_14586_14609(parameter))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,14660,15485) || true) && (f_1146_14664_14676(types)!= 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,14660,15485);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,14739,14760);

Type 
type = types[0]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,14792,15458) || true) && (f_1146_14796_14807(type)&&(DynAbs.Tracing.TraceSender.Expression_True(1146, 14796, 14840)&&(f_1146_14812_14831(type)!= null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,14792,15458);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,14906,14971);

f_1146_14906_14970(mshObject, f_1146_14950_14969(type));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,14792,15458);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,14792,15458);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,15037,15458) || true) && (f_1146_15041_15053(type))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,15037,15458);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,15119,15427) || true) && (f_1146_15123_15151(f_1146_15123_15144(type))&&(DynAbs.Tracing.TraceSender.Expression_True(1146, 15123, 15236)&&f_1146_15192_15228(f_1146_15206_15227(type))!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,15119,15427);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,15310,15392);

f_1146_15310_15391(mshObject, f_1146_15354_15390(f_1146_15368_15389(type)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,15119,15427);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,15037,15458);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,14792,15458);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,14660,15485);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,14480,15508);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,14012,15508);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,13742,15508);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,13537,15527);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,15547,15573);

f_1146_15547_15572(
                mshObjects, mshObject);
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,12301,15588);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1146,1,3288);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1146,1,3288);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,15604,15678);

f_1146_15604_15677(f_1146_15604_15618(obj), f_1146_15623_15676("parameter", f_1146_15655_15675(mshObjects)));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1146,12061,15689);

System.Collections.ArrayList
f_1146_12269_12284()
{
var return_v = new System.Collections.ArrayList();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 12269, 12284);
return return_v;
}


System.Collections.Generic.HashSet<string>
f_1146_12402_12425()
{
var return_v = Cmdlet.CommonParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 12402, 12425);
return return_v;
}


string
f_1146_12435_12449(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 12435, 12449);
return return_v;
}


bool
f_1146_12402_12450(System.Collections.Generic.HashSet<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 12402, 12450);
return return_v;
}


System.Management.Automation.PSObject
f_1146_12561_12575()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 12561, 12575);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1146_12596_12615(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 12596, 12615);
return return_v;
}


int
f_1146_12596_12623(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 12596, 12623);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1146_12642_12661(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 12642, 12661);
return return_v;
}


System.Globalization.CultureInfo
f_1146_12680_12708()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 12680, 12708);
return return_v;
}


string
f_1146_12666_12782(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 12666, 12782);
return return_v;
}


int
f_1146_12642_12783(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 12642, 12783);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Attribute>
f_1146_12865_12885(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 12865, 12885);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1146_12839_12886(System.Collections.ObjectModel.ReadOnlyCollection<System.Attribute>
list)
{
var return_v = new System.Collections.ObjectModel.Collection<System.Attribute>( (System.Collections.Generic.IList<System.Attribute>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 12839, 12886);
return return_v;
}


string
f_1146_12941_12955(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 12941, 12955);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<string>
f_1146_12980_12997(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.Aliases;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 12980, 12997);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1146_12957_12998(System.Collections.ObjectModel.ReadOnlyCollection<string>
list)
{
var return_v = new System.Collections.ObjectModel.Collection<string>( (System.Collections.Generic.IList<string>)list);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 12957, 12998);
return return_v;
}


bool
f_1146_13021_13040(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.IsDynamic;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 13021, 13040);
return return_v;
}


System.Type
f_1146_13042_13065(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.ParameterType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 13042, 13065);
return return_v;
}


int
f_1146_12907_13096(System.Management.Automation.PSObject
obj,string
name,System.Collections.ObjectModel.Collection<string>
aliases,bool
dynamic,System.Type
type,System.Collections.ObjectModel.Collection<System.Attribute>
attributes,string
parameterSetName)
{
AddParameterProperties( obj, name, aliases, dynamic, type, attributes, parameterSetName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 12907, 13096);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ValidateSetAttribute>
f_1146_13164_13199(System.Collections.ObjectModel.Collection<System.Attribute>
attributes)
{
var return_v = GetValidateSetAttribute( attributes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 13164, 13199);
return return_v;
}


System.Collections.Generic.List<string>
f_1146_13239_13257()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 13239, 13257);
return return_v;
}


System.Collections.Generic.IList<string>
f_1146_13393_13408(System.Management.Automation.ValidateSetAttribute
this_param)
{
var return_v = this_param.ValidValues;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 13393, 13408);
return return_v;
}


int
f_1146_13458_13474(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 13458, 13474);
return 0;
}


System.Collections.Generic.IList<string>
f_1146_13393_13408_I(System.Collections.Generic.IList<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 13393, 13408);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ValidateSetAttribute>
f_1146_13315_13326_I(System.Collections.ObjectModel.Collection<System.Management.Automation.ValidateSetAttribute>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 13315, 13326);
return return_v;
}


int
f_1146_13541_13552(System.Collections.Generic.List<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 13541, 13552);
return return_v;
}


string[]
f_1146_13643_13658(System.Collections.Generic.List<string>
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 13643, 13658);
return return_v;
}


int
f_1146_13599_13659(System.Management.Automation.PSObject
obj,string[]
values)
{
AddParameterValueGroupProperties( obj, values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 13599, 13659);
return 0;
}


System.Type
f_1146_13746_13769(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.ParameterType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 13746, 13769);
return return_v;
}


bool
f_1146_13746_13776(System.Type
this_param)
{
var return_v = this_param.IsEnum ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 13746, 13776);
return return_v;
}


System.Type
f_1146_13795_13818(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.ParameterType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 13795, 13818);
return return_v;
}


string[]
f_1146_13781_13819(System.Type
enumType)
{
var return_v = Enum.GetNames( enumType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 13781, 13819);
return return_v;
}


System.Type
f_1146_13936_13959(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.ParameterType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 13936, 13959);
return return_v;
}


string[]
f_1146_13922_13960(System.Type
enumType)
{
var return_v = Enum.GetNames( enumType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 13922, 13960);
return return_v;
}


int
f_1146_13878_13961(System.Management.Automation.PSObject
obj,string[]
values)
{
AddParameterValueGroupProperties( obj, values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 13878, 13961);
return 0;
}


System.Type
f_1146_14016_14039(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.ParameterType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 14016, 14039);
return return_v;
}


bool
f_1146_14016_14047(System.Type
this_param)
{
var return_v = this_param.IsArray;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 14016, 14047);
return return_v;
}


System.Type
f_1146_14101_14124(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.ParameterType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 14101, 14124);
return return_v;
}


System.Type?
f_1146_14101_14141(System.Type
this_param)
{
var return_v = this_param.GetElementType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 14101, 14141);
return return_v;
}


bool
f_1146_14101_14148(System.Type
this_param)
{
var return_v = this_param.IsEnum ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 14101, 14148);
return return_v;
}


System.Type
f_1146_14195_14218(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.ParameterType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 14195, 14218);
return return_v;
}


System.Type?
f_1146_14195_14235(System.Type
this_param)
{
var return_v = this_param.GetElementType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 14195, 14235);
return return_v;
}


string[]
f_1146_14181_14236(System.Type
enumType)
{
var return_v = Enum.GetNames( enumType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 14181, 14236);
return return_v;
}


System.Type
f_1146_14360_14383(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.ParameterType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 14360, 14383);
return return_v;
}


System.Type?
f_1146_14360_14400(System.Type
this_param)
{
var return_v = this_param.GetElementType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 14360, 14400);
return return_v;
}


string[]
f_1146_14346_14401(System.Type
enumType)
{
var return_v = Enum.GetNames( enumType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 14346, 14401);
return return_v;
}


int
f_1146_14302_14402(System.Management.Automation.PSObject
obj,string[]
values)
{
AddParameterValueGroupProperties( obj, values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 14302, 14402);
return 0;
}


System.Type
f_1146_14484_14507(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.ParameterType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 14484, 14507);
return return_v;
}


bool
f_1146_14484_14521(System.Type
this_param)
{
var return_v = this_param.IsGenericType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 14484, 14521);
return return_v;
}


System.Type
f_1146_14586_14609(System.Management.Automation.CommandParameterInfo
this_param)
{
var return_v = this_param.ParameterType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 14586, 14609);
return return_v;
}


System.Type[]
f_1146_14586_14631(System.Type
this_param)
{
var return_v = this_param.GetGenericArguments();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 14586, 14631);
return return_v;
}


int
f_1146_14664_14676(System.Type[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 14664, 14676);
return return_v;
}


bool
f_1146_14796_14807(System.Type
this_param)
{
var return_v = this_param.IsEnum ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 14796, 14807);
return return_v;
}


string[]
f_1146_14812_14831(System.Type
enumType)
{
var return_v = Enum.GetNames( enumType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 14812, 14831);
return return_v;
}


string[]
f_1146_14950_14969(System.Type
enumType)
{
var return_v = Enum.GetNames( enumType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 14950, 14969);
return return_v;
}


int
f_1146_14906_14970(System.Management.Automation.PSObject
obj,string[]
values)
{
AddParameterValueGroupProperties( obj, values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 14906, 14970);
return 0;
}


bool
f_1146_15041_15053(System.Type
this_param)
{
var return_v = this_param.IsArray;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 15041, 15053);
return return_v;
}


System.Type?
f_1146_15123_15144(System.Type
this_param)
{
var return_v = this_param.GetElementType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 15123, 15144);
return return_v;
}


bool
f_1146_15123_15151(System.Type
this_param)
{
var return_v = this_param.IsEnum ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 15123, 15151);
return return_v;
}


System.Type?
f_1146_15206_15227(System.Type
this_param)
{
var return_v = this_param.GetElementType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 15206, 15227);
return return_v;
}


string[]
f_1146_15192_15228(System.Type
enumType)
{
var return_v = Enum.GetNames( enumType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 15192, 15228);
return return_v;
}


System.Type?
f_1146_15368_15389(System.Type
this_param)
{
var return_v = this_param.GetElementType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 15368, 15389);
return return_v;
}


string[]
f_1146_15354_15390(System.Type
enumType)
{
var return_v = Enum.GetNames( enumType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 15354, 15390);
return return_v;
}


int
f_1146_15310_15391(System.Management.Automation.PSObject
obj,string[]
values)
{
AddParameterValueGroupProperties( obj, values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 15310, 15391);
return 0;
}


int
f_1146_15547_15572(System.Collections.ArrayList
this_param,System.Management.Automation.PSObject
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 15547, 15572);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.CommandParameterInfo>
f_1146_12344_12354_I(System.Collections.Generic.IEnumerable<System.Management.Automation.CommandParameterInfo>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 12344, 12354);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_15604_15618(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 15604, 15618);
return return_v;
}


object?[]
f_1146_15655_15675(System.Collections.ArrayList
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 15655, 15675);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_15623_15676(string
name,object?[]
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 15623, 15676);
return return_v;
}


int
f_1146_15604_15677(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 15604, 15677);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1146,12061,15689);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,12061,15689);
}
		}

private static void AddParameterValueGroupProperties(PSObject obj, string[] values)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1146,15915,16559);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,16023,16065);

PSObject 
paramValueGroup = f_1146_16050_16064()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,16081,16115);

f_1146_16081_16114(f_1146_16081_16106(paramValueGroup));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,16129,16287);

f_1146_16129_16286(f_1146_16129_16154(paramValueGroup), f_1146_16159_16285(f_1146_16173_16201(), "{0}#parameterValueGroup", DefaultCommandHelpObjectBuilder.TypeNameForDefaultHelp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,16303,16348);

ArrayList 
paramValue = f_1146_16326_16347(values)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,16364,16455);

f_1146_16364_16454(f_1146_16364_16390(paramValueGroup), f_1146_16395_16453("parameterValue", f_1146_16432_16452(paramValue)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,16469,16548);

f_1146_16469_16547(f_1146_16469_16483(obj), f_1146_16488_16546("parameterValueGroup", paramValueGroup));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1146,15915,16559);

System.Management.Automation.PSObject
f_1146_16050_16064()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 16050, 16064);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1146_16081_16106(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 16081, 16106);
return return_v;
}


int
f_1146_16081_16114(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 16081, 16114);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1146_16129_16154(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 16129, 16154);
return return_v;
}


System.Globalization.CultureInfo
f_1146_16173_16201()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 16173, 16201);
return return_v;
}


string
f_1146_16159_16285(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 16159, 16285);
return return_v;
}


int
f_1146_16129_16286(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 16129, 16286);
return 0;
}


System.Collections.ArrayList
f_1146_16326_16347(string[]
c)
{
var return_v = new System.Collections.ArrayList( (System.Collections.ICollection)c);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 16326, 16347);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_16364_16390(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 16364, 16390);
return return_v;
}


object?[]
f_1146_16432_16452(System.Collections.ArrayList
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 16432, 16452);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_16395_16453(string
name,object?[]
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 16395, 16453);
return return_v;
}


int
f_1146_16364_16454(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 16364, 16454);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_16469_16483(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 16469, 16483);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_16488_16546(string
name,System.Management.Automation.PSObject
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 16488, 16546);
return return_v;
}


int
f_1146_16469_16547(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 16469, 16547);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1146,15915,16559);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,15915,16559);
}
		}

internal static void AddParametersProperties(PSObject obj, Dictionary<string, ParameterMetadata> parameters, bool common, string typeNameForHelp)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1146,16968,18754);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,17138,17177);

PSObject 
paramsObject = f_1146_17162_17176()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,17193,17224);

f_1146_17193_17223(f_1146_17193_17215(paramsObject));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,17238,17345);

f_1146_17238_17344(f_1146_17238_17260(paramsObject), f_1146_17265_17343(f_1146_17279_17307(), "{0}#parameters", typeNameForHelp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,17361,17402);

ArrayList 
paramObjects = f_1146_17386_17401()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,17418,17463);

ArrayList 
sortedParameters = f_1146_17447_17462()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,17479,17719) || true) && (parameters != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,17479,17719);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,17535,17704);
foreach(KeyValuePair<string, ParameterMetadata> parameter in f_1146_17597_17607_I(parameters) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,17535,17704);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,17649,17685);

f_1146_17649_17684(                    sortedParameters, parameter.Key);
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,17535,17704);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1146,1,170);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1146,1,170);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1146,17479,17719);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,17735,17781);

f_1146_17735_17780(
            sortedParameters, f_1146_17757_17779());
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,17797,18561);
foreach(string parameter in f_1146_17826_17842_I(sortedParameters) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,17797,18561);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,17876,18003) || true) && (common &&(DynAbs.Tracing.TraceSender.Expression_True(1146, 17880, 17933)&&f_1146_17890_17933(f_1146_17890_17913(), parameter)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,17876,18003);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,17975,17984);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,17876,18003);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,18023,18061);

PSObject 
paramObject = f_1146_18046_18060()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,18081,18111);

f_1146_18081_18110(f_1146_18081_18102(paramObject));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,18129,18273);

f_1146_18129_18272(f_1146_18129_18150(paramObject), f_1146_18155_18271(f_1146_18169_18197(), "{0}#parameter", DefaultCommandHelpObjectBuilder.TypeNameForDefaultHelp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,18293,18496);

f_1146_18293_18495(paramObject, parameter, f_1146_18340_18369(f_1146_18340_18361(parameters, parameter)), f_1146_18392_18423(f_1146_18392_18413(parameters, parameter)), f_1146_18425_18460(f_1146_18425_18446(parameters, parameter)), f_1146_18462_18494(f_1146_18462_18483(parameters, parameter)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,18516,18546);

f_1146_18516_18545(
                paramObjects, paramObject);
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,17797,18561);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1146,1,765);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1146,1,765);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,18577,18662);

f_1146_18577_18661(f_1146_18577_18600(paramsObject), f_1146_18605_18660("parameter", f_1146_18637_18659(paramObjects)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,18676,18743);

f_1146_18676_18742(f_1146_18676_18690(obj), f_1146_18695_18741("parameters", paramsObject));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1146,16968,18754);

System.Management.Automation.PSObject
f_1146_17162_17176()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 17162, 17176);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1146_17193_17215(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 17193, 17215);
return return_v;
}


int
f_1146_17193_17223(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 17193, 17223);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1146_17238_17260(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 17238, 17260);
return return_v;
}


System.Globalization.CultureInfo
f_1146_17279_17307()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 17279, 17307);
return return_v;
}


string
f_1146_17265_17343(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 17265, 17343);
return return_v;
}


int
f_1146_17238_17344(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 17238, 17344);
return 0;
}


System.Collections.ArrayList
f_1146_17386_17401()
{
var return_v = new System.Collections.ArrayList();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 17386, 17401);
return return_v;
}


System.Collections.ArrayList
f_1146_17447_17462()
{
var return_v = new System.Collections.ArrayList();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 17447, 17462);
return return_v;
}


int
f_1146_17649_17684(System.Collections.ArrayList
this_param,string
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 17649, 17684);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
f_1146_17597_17607_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 17597, 17607);
return return_v;
}


System.StringComparer
f_1146_17757_17779()
{
var return_v = StringComparer.Ordinal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 17757, 17779);
return return_v;
}


int
f_1146_17735_17780(System.Collections.ArrayList
this_param,System.StringComparer
comparer)
{
this_param.Sort( (System.Collections.IComparer)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 17735, 17780);
return 0;
}


System.Collections.Generic.HashSet<string>
f_1146_17890_17913()
{
var return_v = Cmdlet.CommonParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 17890, 17913);
return return_v;
}


bool
f_1146_17890_17933(System.Collections.Generic.HashSet<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 17890, 17933);
return return_v;
}


System.Management.Automation.PSObject
f_1146_18046_18060()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 18046, 18060);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1146_18081_18102(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 18081, 18102);
return return_v;
}


int
f_1146_18081_18110(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 18081, 18110);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1146_18129_18150(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 18129, 18150);
return return_v;
}


System.Globalization.CultureInfo
f_1146_18169_18197()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 18169, 18197);
return return_v;
}


string
f_1146_18155_18271(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 18155, 18271);
return return_v;
}


int
f_1146_18129_18272(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 18129, 18272);
return 0;
}


System.Management.Automation.ParameterMetadata
f_1146_18340_18361(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 18340, 18361);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1146_18340_18369(System.Management.Automation.ParameterMetadata
this_param)
{
var return_v = this_param.Aliases;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 18340, 18369);
return return_v;
}


System.Management.Automation.ParameterMetadata
f_1146_18392_18413(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 18392, 18413);
return return_v;
}


bool
f_1146_18392_18423(System.Management.Automation.ParameterMetadata
this_param)
{
var return_v = this_param.IsDynamic;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 18392, 18423);
return return_v;
}


System.Management.Automation.ParameterMetadata
f_1146_18425_18446(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 18425, 18446);
return return_v;
}


System.Type
f_1146_18425_18460(System.Management.Automation.ParameterMetadata
this_param)
{
var return_v = this_param.ParameterType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 18425, 18460);
return return_v;
}


System.Management.Automation.ParameterMetadata
f_1146_18462_18483(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 18462, 18483);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1146_18462_18494(System.Management.Automation.ParameterMetadata
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 18462, 18494);
return return_v;
}


int
f_1146_18293_18495(System.Management.Automation.PSObject
obj,string
name,System.Collections.ObjectModel.Collection<string>
aliases,bool
dynamic,System.Type
type,System.Collections.ObjectModel.Collection<System.Attribute>
attributes)
{
AddParameterProperties( obj, name, aliases, dynamic, type, attributes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 18293, 18495);
return 0;
}


int
f_1146_18516_18545(System.Collections.ArrayList
this_param,System.Management.Automation.PSObject
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 18516, 18545);
return return_v;
}


System.Collections.ArrayList
f_1146_17826_17842_I(System.Collections.ArrayList
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 17826, 17842);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_18577_18600(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 18577, 18600);
return return_v;
}


object?[]
f_1146_18637_18659(System.Collections.ArrayList
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 18637, 18659);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_18605_18660(string
name,object?[]
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 18605, 18660);
return return_v;
}


int
f_1146_18577_18661(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 18577, 18661);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_18676_18690(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 18676, 18690);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_18695_18741(string
name,System.Management.Automation.PSObject
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 18695, 18741);
return return_v;
}


int
f_1146_18676_18742(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 18676, 18742);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1146,16968,18754);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,16968,18754);
}
		}

private static void AddParameterProperties(PSObject obj, string name, Collection<string> aliases, bool dynamic,
            Type type, Collection<Attribute> attributes, string parameterSetName = null)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1146,19333,24146);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,19559,19634);

Collection<ParameterAttribute> 
attribs = f_1146_19600_19633(attributes)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,19650,19703);

f_1146_19650_19702(f_1146_19650_19664(obj), f_1146_19669_19701("name", name));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,19719,24135) || true) && (f_1146_19723_19736(attribs)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,19719,24135);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,19775,19840);

f_1146_19775_19839(f_1146_19775_19789(obj), f_1146_19794_19838("required", string.Empty));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,19858,19928);

f_1146_19858_19927(f_1146_19858_19872(obj), f_1146_19877_19926("pipelineInput", string.Empty));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,19946,20012);

f_1146_19946_20011(f_1146_19946_19960(obj), f_1146_19965_20010("isDynamic", string.Empty));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,20030,20103);

f_1146_20030_20102(f_1146_20030_20044(obj), f_1146_20049_20101("parameterSetName", string.Empty));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,20121,20189);

f_1146_20121_20188(f_1146_20121_20135(obj), f_1146_20140_20187("description", string.Empty));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,20207,20272);

f_1146_20207_20271(f_1146_20207_20221(obj), f_1146_20226_20270("position", string.Empty));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,20290,20354);

f_1146_20290_20353(f_1146_20290_20304(obj), f_1146_20309_20352("aliases", string.Empty));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,19719,24135);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,19719,24135);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,20420,20467);

ParameterAttribute 
paramAttribute = f_1146_20456_20466(attribs, 0)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,20485,20933) || true) && (!f_1146_20490_20528(parameterSetName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,20485,20933);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,20570,20914);
foreach(var attrib in f_1146_20593_20600_I(attribs) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,20570,20914);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,20650,20891) || true) && (f_1146_20654_20746(f_1146_20668_20691(attrib), parameterSetName, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,20650,20891);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,20804,20828);

paramAttribute = attrib;
DynAbs.Tracing.TraceSender.TraceBreak(1146,20858,20864);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,20650,20891);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,20570,20914);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1146,1,345);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1146,1,345);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1146,20485,20933);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,20953,21086);

f_1146_20953_21085(f_1146_20953_20967(obj), f_1146_20972_21084("required", f_1146_21003_21083(f_1146_21003_21038(f_1146_21003_21029()), f_1146_21047_21082(f_1146_21047_21071(paramAttribute)))));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,21104,21200);

f_1146_21104_21199(f_1146_21104_21118(obj), f_1146_21123_21198("pipelineInput", f_1146_21159_21197(paramAttribute)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,21218,21335);

f_1146_21218_21334(f_1146_21218_21232(obj), f_1146_21237_21333("isDynamic", f_1146_21269_21332(f_1146_21269_21304(f_1146_21269_21295()), f_1146_21313_21331(dynamic))));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,21355,22200) || true) && (f_1146_21359_21470(f_1146_21359_21390(paramAttribute), ParameterAttribute.AllParameterSets, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,21355,22200);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,21512,21631);

f_1146_21512_21630(f_1146_21512_21526(obj), f_1146_21531_21629("parameterSetName", f_1146_21570_21628(f_1146_21588_21627())));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,21355,22200);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,21355,22200);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,21713,21752);

StringBuilder 
sb = f_1146_21732_21751()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,21785,21790);

                    for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,21776,22083) || true) && (i < f_1146_21796_21809(attribs))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,21811,21814)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1146,21776,22083))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,21776,22083);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,21864,21903);

f_1146_21864_21902(                        sb, f_1146_21874_21901(f_1146_21874_21884(attribs, i)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,21931,22060) || true) && (i != (f_1146_21941_21954(attribs)- 1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,21931,22060);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,22017,22033);

f_1146_22017_22032(                            sb, ", ");
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,21931,22060);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1146,1,308);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1146,1,308);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,22107,22181);

f_1146_22107_22180(f_1146_22107_22121(obj), f_1146_22126_22179("parameterSetName", f_1146_22165_22178(sb)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,21355,22200);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,22220,22517) || true) && (f_1146_22224_22250(paramAttribute)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,22220,22517);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,22300,22339);

StringBuilder 
sb = f_1146_22319_22338()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,22363,22405);

f_1146_22363_22404(
                    sb, f_1146_22377_22403(paramAttribute));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,22429,22498);

f_1146_22429_22497(f_1146_22429_22443(obj), f_1146_22448_22496("description", f_1146_22482_22495(sb)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,22220,22517);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,22680,22827) || true) && (type != typeof(SwitchParameter))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,22680,22827);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,22757,22808);

f_1146_22757_22807(obj, type, attributes);
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,22680,22827);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,22847,22897);

f_1146_22847_22896(obj, type, attributes);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,22917,23373) || true) && (f_1146_22921_22944(paramAttribute)== int.MinValue)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,22917,23373);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,23002,23132);

f_1146_23002_23131(f_1146_23002_23016(obj), f_1146_23021_23130("position", f_1146_23077_23129(f_1146_23095_23128())));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,22917,23373);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,22917,23373);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,23214,23354);

f_1146_23214_23353(f_1146_23214_23228(obj), f_1146_23233_23352("position", f_1146_23289_23351(f_1146_23289_23312(paramAttribute), f_1146_23322_23350())));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,22917,23373);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,23393,24120) || true) && (f_1146_23397_23410(aliases)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,23393,24120);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,23457,23577);

f_1146_23457_23576(f_1146_23457_23471(obj), f_1146_23476_23575("aliases", f_1146_23506_23574(f_1146_23550_23573())));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,23393,24120);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,23393,24120);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,23659,23698);

StringBuilder 
sb = f_1146_23678_23697()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,23731,23736);

                    for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,23722,24012) || true) && (i < f_1146_23742_23755(aliases))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,23757,23760)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1146,23722,24012))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,23722,24012);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,23810,23832);

f_1146_23810_23831(                        sb, f_1146_23820_23830(aliases, i));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,23860,23989) || true) && (i != (f_1146_23870_23883(aliases)- 1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,23860,23989);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,23946,23962);

f_1146_23946_23961(                            sb, ", ");
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,23860,23989);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1146,1,291);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1146,1,291);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,24036,24101);

f_1146_24036_24100(f_1146_24036_24050(obj), f_1146_24055_24099("aliases", f_1146_24085_24098(sb)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,23393,24120);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,19719,24135);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1146,19333,24146);

System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterAttribute>
f_1146_19600_19633(System.Collections.ObjectModel.Collection<System.Attribute>
attributes)
{
var return_v = GetParameterAttribute( attributes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 19600, 19633);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_19650_19664(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 19650, 19664);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_19669_19701(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 19669, 19701);
return return_v;
}


int
f_1146_19650_19702(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 19650, 19702);
return 0;
}


int
f_1146_19723_19736(System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterAttribute>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 19723, 19736);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_19775_19789(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 19775, 19789);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_19794_19838(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 19794, 19838);
return return_v;
}


int
f_1146_19775_19839(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 19775, 19839);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_19858_19872(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 19858, 19872);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_19877_19926(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 19877, 19926);
return return_v;
}


int
f_1146_19858_19927(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 19858, 19927);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_19946_19960(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 19946, 19960);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_19965_20010(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 19965, 20010);
return return_v;
}


int
f_1146_19946_20011(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 19946, 20011);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_20030_20044(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 20030, 20044);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_20049_20101(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 20049, 20101);
return return_v;
}


int
f_1146_20030_20102(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 20030, 20102);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_20121_20135(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 20121, 20135);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_20140_20187(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 20140, 20187);
return return_v;
}


int
f_1146_20121_20188(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 20121, 20188);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_20207_20221(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 20207, 20221);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_20226_20270(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 20226, 20270);
return return_v;
}


int
f_1146_20207_20271(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 20207, 20271);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_20290_20304(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 20290, 20304);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_20309_20352(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 20309, 20352);
return return_v;
}


int
f_1146_20290_20353(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 20290, 20353);
return 0;
}


System.Management.Automation.ParameterAttribute
f_1146_20456_20466(System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterAttribute>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 20456, 20466);
return return_v;
}


bool
f_1146_20490_20528(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 20490, 20528);
return return_v;
}


string
f_1146_20668_20691(System.Management.Automation.ParameterAttribute
this_param)
{
var return_v = this_param.ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 20668, 20691);
return return_v;
}


bool
f_1146_20654_20746(string
a,string
b,System.StringComparison
comparisonType)
{
var return_v = string.Equals( a, b, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 20654, 20746);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterAttribute>
f_1146_20593_20600_I(System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterAttribute>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 20593, 20600);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_20953_20967(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 20953, 20967);
return return_v;
}


System.Globalization.CultureInfo
f_1146_21003_21029()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 21003, 21029);
return return_v;
}


System.Globalization.TextInfo
f_1146_21003_21038(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.TextInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 21003, 21038);
return return_v;
}


bool
f_1146_21047_21071(System.Management.Automation.ParameterAttribute
this_param)
{
var return_v = this_param.Mandatory;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 21047, 21071);
return return_v;
}


string
f_1146_21047_21082(bool
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 21047, 21082);
return return_v;
}


string
f_1146_21003_21083(System.Globalization.TextInfo
this_param,string
str)
{
var return_v = this_param.ToLower( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 21003, 21083);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_20972_21084(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 20972, 21084);
return return_v;
}


int
f_1146_20953_21085(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 20953, 21085);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_21104_21118(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 21104, 21118);
return return_v;
}


string
f_1146_21159_21197(System.Management.Automation.ParameterAttribute
paramAttrib)
{
var return_v = GetPipelineInputString( paramAttrib);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 21159, 21197);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_21123_21198(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 21123, 21198);
return return_v;
}


int
f_1146_21104_21199(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 21104, 21199);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_21218_21232(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 21218, 21232);
return return_v;
}


System.Globalization.CultureInfo
f_1146_21269_21295()
{
var return_v = CultureInfo.CurrentCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 21269, 21295);
return return_v;
}


System.Globalization.TextInfo
f_1146_21269_21304(System.Globalization.CultureInfo
this_param)
{
var return_v = this_param.TextInfo;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 21269, 21304);
return return_v;
}


string
f_1146_21313_21331(bool
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 21313, 21331);
return return_v;
}


string
f_1146_21269_21332(System.Globalization.TextInfo
this_param,string
str)
{
var return_v = this_param.ToLower( str);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 21269, 21332);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_21237_21333(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 21237, 21333);
return return_v;
}


int
f_1146_21218_21334(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 21218, 21334);
return 0;
}


string
f_1146_21359_21390(System.Management.Automation.ParameterAttribute
this_param)
{
var return_v = this_param.ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 21359, 21390);
return return_v;
}


bool
f_1146_21359_21470(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 21359, 21470);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_21512_21526(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 21512, 21526);
return return_v;
}


string
f_1146_21588_21627()
{
var return_v = HelpDisplayStrings.AllParameterSetsName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 21588, 21627);
return return_v;
}


string
f_1146_21570_21628(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 21570, 21628);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_21531_21629(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 21531, 21629);
return return_v;
}


int
f_1146_21512_21630(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 21512, 21630);
return 0;
}


System.Text.StringBuilder
f_1146_21732_21751()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 21732, 21751);
return return_v;
}


int
f_1146_21796_21809(System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterAttribute>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 21796, 21809);
return return_v;
}


System.Management.Automation.ParameterAttribute
f_1146_21874_21884(System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterAttribute>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 21874, 21884);
return return_v;
}


string
f_1146_21874_21901(System.Management.Automation.ParameterAttribute
this_param)
{
var return_v = this_param.ParameterSetName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 21874, 21901);
return return_v;
}


System.Text.StringBuilder
f_1146_21864_21902(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 21864, 21902);
return return_v;
}


int
f_1146_21941_21954(System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterAttribute>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 21941, 21954);
return return_v;
}


System.Text.StringBuilder
f_1146_22017_22032(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 22017, 22032);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_22107_22121(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 22107, 22121);
return return_v;
}


string
f_1146_22165_22178(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 22165, 22178);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_22126_22179(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 22126, 22179);
return return_v;
}


int
f_1146_22107_22180(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 22107, 22180);
return 0;
}


string
f_1146_22224_22250(System.Management.Automation.ParameterAttribute
this_param)
{
var return_v = this_param.HelpMessage ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 22224, 22250);
return return_v;
}


System.Text.StringBuilder
f_1146_22319_22338()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 22319, 22338);
return return_v;
}


string
f_1146_22377_22403(System.Management.Automation.ParameterAttribute
this_param)
{
var return_v = this_param.HelpMessage;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 22377, 22403);
return return_v;
}


System.Text.StringBuilder
f_1146_22363_22404(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 22363, 22404);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_22429_22443(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 22429, 22443);
return return_v;
}


string
f_1146_22482_22495(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 22482, 22495);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_22448_22496(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 22448, 22496);
return return_v;
}


int
f_1146_22429_22497(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 22429, 22497);
return 0;
}


int
f_1146_22757_22807(System.Management.Automation.PSObject
obj,System.Type
parameterType,System.Collections.ObjectModel.Collection<System.Attribute>
attributes)
{
AddParameterValueProperties( obj, parameterType, (System.Collections.Generic.IEnumerable<System.Attribute>)attributes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 22757, 22807);
return 0;
}


int
f_1146_22847_22896(System.Management.Automation.PSObject
obj,System.Type
parameterType,System.Collections.ObjectModel.Collection<System.Attribute>
attributes)
{
AddParameterTypeProperties( obj, parameterType, (System.Collections.Generic.IEnumerable<System.Attribute>)attributes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 22847, 22896);
return 0;
}


int
f_1146_22921_22944(System.Management.Automation.ParameterAttribute
this_param)
{
var return_v = this_param.Position ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 22921, 22944);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_23002_23016(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 23002, 23016);
return return_v;
}


string
f_1146_23095_23128()
{
var return_v = HelpDisplayStrings.NamedParameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 23095, 23128);
return return_v;
}


string
f_1146_23077_23129(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 23077, 23129);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_23021_23130(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 23021, 23130);
return return_v;
}


int
f_1146_23002_23131(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 23002, 23131);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_23214_23228(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 23214, 23228);
return return_v;
}


int
f_1146_23289_23312(System.Management.Automation.ParameterAttribute
this_param)
{
var return_v = this_param.Position;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 23289, 23312);
return return_v;
}


System.Globalization.CultureInfo
f_1146_23322_23350()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 23322, 23350);
return return_v;
}


string
f_1146_23289_23351(int
this_param,System.Globalization.CultureInfo
provider)
{
var return_v = this_param.ToString( (System.IFormatProvider)provider);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 23289, 23351);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_23233_23352(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 23233, 23352);
return return_v;
}


int
f_1146_23214_23353(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 23214, 23353);
return 0;
}


int
f_1146_23397_23410(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 23397, 23410);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_23457_23471(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 23457, 23471);
return return_v;
}


string
f_1146_23550_23573()
{
var return_v =                         HelpDisplayStrings.None;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 23550, 23573);
return return_v;
}


string
f_1146_23506_23574(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 23506, 23574);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_23476_23575(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 23476, 23575);
return return_v;
}


int
f_1146_23457_23576(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 23457, 23576);
return 0;
}


System.Text.StringBuilder
f_1146_23678_23697()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 23678, 23697);
return return_v;
}


int
f_1146_23742_23755(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 23742, 23755);
return return_v;
}


string
f_1146_23820_23830(System.Collections.ObjectModel.Collection<string>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 23820, 23830);
return return_v;
}


System.Text.StringBuilder
f_1146_23810_23831(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 23810, 23831);
return return_v;
}


int
f_1146_23870_23883(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 23870, 23883);
return return_v;
}


System.Text.StringBuilder
f_1146_23946_23961(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 23946, 23961);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_24036_24050(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 24036, 24050);
return return_v;
}


string
f_1146_24085_24098(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 24085, 24098);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_24055_24099(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 24055, 24099);
return return_v;
}


int
f_1146_24036_24100(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 24036, 24100);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1146,19333,24146);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,19333,24146);
}
		}

private static void AddParameterTypeProperties(PSObject obj, Type parameterType, IEnumerable<Attribute> attributes)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1146,24494,25154);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,24634,24670);

PSObject 
mshObject = f_1146_24655_24669()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,24686,24714);

f_1146_24686_24713(f_1146_24686_24705(mshObject));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,24728,24865);

f_1146_24728_24864(f_1146_24728_24747(mshObject), f_1146_24752_24863(f_1146_24766_24794(), "{0}#type", DefaultCommandHelpObjectBuilder.TypeNameForDefaultHelp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,24881,24981);

var 
parameterTypeString = f_1146_24907_24980(parameterType, attributes)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,24995,25069);

f_1146_24995_25068(f_1146_24995_25015(mshObject), f_1146_25020_25067("name", parameterTypeString));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,25085,25143);

f_1146_25085_25142(f_1146_25085_25099(obj), f_1146_25104_25141("type", mshObject));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1146,24494,25154);

System.Management.Automation.PSObject
f_1146_24655_24669()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 24655, 24669);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1146_24686_24705(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 24686, 24705);
return return_v;
}


int
f_1146_24686_24713(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 24686, 24713);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1146_24728_24747(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 24728, 24747);
return return_v;
}


System.Globalization.CultureInfo
f_1146_24766_24794()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 24766, 24794);
return return_v;
}


string
f_1146_24752_24863(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 24752, 24863);
return return_v;
}


int
f_1146_24728_24864(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 24728, 24864);
return 0;
}


string
f_1146_24907_24980(System.Type
type,System.Collections.Generic.IEnumerable<System.Attribute>
attributes)
{
var return_v = CommandParameterSetInfo.GetParameterTypeString( type, attributes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 24907, 24980);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_24995_25015(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 24995, 25015);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_25020_25067(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 25020, 25067);
return return_v;
}


int
f_1146_24995_25068(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 24995, 25068);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_25085_25099(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 25085, 25099);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_25104_25141(string
name,System.Management.Automation.PSObject
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 25104, 25141);
return return_v;
}


int
f_1146_25085_25142(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 25085, 25142);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1146,24494,25154);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,24494,25154);
}
		}

private static void AddParameterValueProperties(PSObject obj, Type parameterType, IEnumerable<Attribute> attributes)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1146,25503,26546);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,25644,25663);

PSObject 
mshObject
=default(PSObject);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,25679,26370) || true) && (parameterType != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,25679,26370);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,25738,25809);

Type 
type = f_1146_25750_25791(parameterType)??(DynAbs.Tracing.TraceSender.Expression_Null<System.Type>(1146, 25750, 25808)??parameterType)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,25827,25927);

var 
parameterTypeString = f_1146_25853_25926(parameterType, attributes)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,25945,25991);

mshObject = f_1146_25957_25990(parameterTypeString);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,26009,26095);

f_1146_26009_26094(f_1146_26009_26029(mshObject), f_1146_26034_26093("variableLength", f_1146_26071_26092(parameterType)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,25679,26370);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,25679,26370);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,26161,26203);

mshObject = f_1146_26173_26202("System.Object");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,26221,26355);

f_1146_26221_26354(f_1146_26221_26241(mshObject), f_1146_26246_26353("variableLength", f_1146_26304_26352(f_1146_26322_26351())));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,25679,26370);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,26386,26451);

f_1146_26386_26450(f_1146_26386_26406(mshObject), f_1146_26411_26449("required", "true"));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,26467,26535);

f_1146_26467_26534(f_1146_26467_26481(obj), f_1146_26486_26533("parameterValue", mshObject));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1146,25503,26546);

System.Type?
f_1146_25750_25791(System.Type
nullableType)
{
var return_v = Nullable.GetUnderlyingType( nullableType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 25750, 25791);
return return_v;
}


string
f_1146_25853_25926(System.Type
type,System.Collections.Generic.IEnumerable<System.Attribute>
attributes)
{
var return_v = CommandParameterSetInfo.GetParameterTypeString( type, attributes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 25853, 25926);
return return_v;
}


System.Management.Automation.PSObject
f_1146_25957_25990(string
obj)
{
var return_v = new System.Management.Automation.PSObject( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 25957, 25990);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_26009_26029(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 26009, 26029);
return return_v;
}


bool
f_1146_26071_26092(System.Type
this_param)
{
var return_v = this_param.IsArray;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 26071, 26092);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_26034_26093(string
name,bool
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 26034, 26093);
return return_v;
}


int
f_1146_26009_26094(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 26009, 26094);
return 0;
}


System.Management.Automation.PSObject
f_1146_26173_26202(string
obj)
{
var return_v = new System.Management.Automation.PSObject( (object)obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 26173, 26202);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_26221_26241(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 26221, 26241);
return return_v;
}


string
f_1146_26322_26351()
{
var return_v = HelpDisplayStrings.FalseShort;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 26322, 26351);
return return_v;
}


string
f_1146_26304_26352(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 26304, 26352);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_26246_26353(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 26246, 26353);
return return_v;
}


int
f_1146_26221_26354(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 26221, 26354);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_26386_26406(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 26386, 26406);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_26411_26449(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 26411, 26449);
return return_v;
}


int
f_1146_26386_26450(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 26386, 26450);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_26467_26481(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 26467, 26481);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_26486_26533(string
name,System.Management.Automation.PSObject
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 26486, 26533);
return return_v;
}


int
f_1146_26467_26534(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 26467, 26534);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1146,25503,26546);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,25503,26546);
}
		}

internal static void AddInputTypesProperties(PSObject obj, Dictionary<string, ParameterMetadata> parameters)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1146,26772,29294);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,26905,26958);

Collection<string> 
inputs = f_1146_26933_26957()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,26974,27870) || true) && (parameters != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,26974,27870);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,27030,27855);
foreach(KeyValuePair<string, ParameterMetadata> parameter in f_1146_27092_27102_I(parameters) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,27030,27855);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,27144,27235);

Collection<ParameterAttribute> 
attribs = f_1146_27185_27234(f_1146_27207_27233(parameter.Value))
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,27259,27836);
foreach(ParameterAttribute attrib in f_1146_27297_27304_I(attribs) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,27259,27836);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,27354,27813) || true) && (f_1146_27358_27382(attrib)||(DynAbs.Tracing.TraceSender.Expression_False(1146, 27358, 27453)||f_1146_27415_27453(attrib))||(DynAbs.Tracing.TraceSender.Expression_False(1146, 27358, 27520)||f_1146_27486_27520(attrib)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,27354,27813);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,27578,27786) || true) && (!f_1146_27583_27638(inputs, f_1146_27599_27637(f_1146_27599_27628(parameter.Value))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,27578,27786);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,27704,27755);

f_1146_27704_27754(                                inputs, f_1146_27715_27753(f_1146_27715_27744(parameter.Value)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,27578,27786);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,27354,27813);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,27259,27836);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1146,1,578);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1146,1,578);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1146,27030,27855);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1146,1,826);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1146,1,826);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1146,26974,27870);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,27886,28011) || true) && (f_1146_27890_27902(inputs)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,27886,28011);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,27941,27996);

f_1146_27941_27995(                inputs, f_1146_27952_27994(f_1146_27970_27993()));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,27886,28011);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,28027,28066);

StringBuilder 
sb = f_1146_28046_28065()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,28082,28183);
foreach(string input in f_1146_28107_28113_I(inputs) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,28082,28183);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,28147,28168);

f_1146_28147_28167(                sb, input);
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,28082,28183);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1146,1,102);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1146,1,102);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,28199,28239);

PSObject 
inputTypesObj = f_1146_28224_28238()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,28255,28287);

f_1146_28255_28286(f_1146_28255_28278(inputTypesObj));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,28301,28448);

f_1146_28301_28447(f_1146_28301_28324(inputTypesObj), f_1146_28329_28446(f_1146_28343_28371(), "{0}#inputTypes", DefaultCommandHelpObjectBuilder.TypeNameForDefaultHelp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,28464,28503);

PSObject 
inputTypeObj = f_1146_28488_28502()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,28519,28550);

f_1146_28519_28549(f_1146_28519_28541(inputTypeObj));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,28564,28709);

f_1146_28564_28708(f_1146_28564_28586(inputTypeObj), f_1146_28591_28707(f_1146_28605_28633(), "{0}#inputType", DefaultCommandHelpObjectBuilder.TypeNameForDefaultHelp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,28725,28759);

PSObject 
typeObj = f_1146_28744_28758()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,28775,28801);

f_1146_28775_28800(f_1146_28775_28792(typeObj));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,28815,28950);

f_1146_28815_28949(f_1146_28815_28832(typeObj), f_1146_28837_28948(f_1146_28851_28879(), "{0}#type", DefaultCommandHelpObjectBuilder.TypeNameForDefaultHelp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,28966,29032);

f_1146_28966_29031(f_1146_28966_28984(typeObj), f_1146_28989_29030("name", f_1146_29016_29029(sb)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,29046,29111);

f_1146_29046_29110(f_1146_29046_29069(inputTypeObj), f_1146_29074_29109("type", typeObj));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,29125,29201);

f_1146_29125_29200(f_1146_29125_29149(inputTypesObj), f_1146_29154_29199("inputType", inputTypeObj));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,29215,29283);

f_1146_29215_29282(f_1146_29215_29229(obj), f_1146_29234_29281("inputTypes", inputTypesObj));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1146,26772,29294);

System.Collections.ObjectModel.Collection<string>
f_1146_26933_26957()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 26933, 26957);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1146_27207_27233(System.Management.Automation.ParameterMetadata
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 27207, 27233);
return return_v;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterAttribute>
f_1146_27185_27234(System.Collections.ObjectModel.Collection<System.Attribute>
attributes)
{
var return_v = GetParameterAttribute( attributes);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 27185, 27234);
return return_v;
}


bool
f_1146_27358_27382(System.Management.Automation.ParameterAttribute
this_param)
{
var return_v = this_param.ValueFromPipeline ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 27358, 27382);
return return_v;
}


bool
f_1146_27415_27453(System.Management.Automation.ParameterAttribute
this_param)
{
var return_v = this_param.ValueFromPipelineByPropertyName ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 27415, 27453);
return return_v;
}


bool
f_1146_27486_27520(System.Management.Automation.ParameterAttribute
this_param)
{
var return_v = this_param.ValueFromRemainingArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 27486, 27520);
return return_v;
}


System.Type
f_1146_27599_27628(System.Management.Automation.ParameterMetadata
this_param)
{
var return_v = this_param.ParameterType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 27599, 27628);
return return_v;
}


string
f_1146_27599_27637(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 27599, 27637);
return return_v;
}


bool
f_1146_27583_27638(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 27583, 27638);
return return_v;
}


System.Type
f_1146_27715_27744(System.Management.Automation.ParameterMetadata
this_param)
{
var return_v = this_param.ParameterType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 27715, 27744);
return return_v;
}


string
f_1146_27715_27753(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 27715, 27753);
return return_v;
}


int
f_1146_27704_27754(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 27704, 27754);
return 0;
}


System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterAttribute>
f_1146_27297_27304_I(System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterAttribute>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 27297, 27304);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
f_1146_27092_27102_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 27092, 27102);
return return_v;
}


int
f_1146_27890_27902(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 27890, 27902);
return return_v;
}


string
f_1146_27970_27993()
{
var return_v = HelpDisplayStrings.None;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 27970, 27993);
return return_v;
}


string
f_1146_27952_27994(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 27952, 27994);
return return_v;
}


int
f_1146_27941_27995(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 27941, 27995);
return 0;
}


System.Text.StringBuilder
f_1146_28046_28065()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 28046, 28065);
return return_v;
}


System.Text.StringBuilder
f_1146_28147_28167(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 28147, 28167);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1146_28107_28113_I(System.Collections.ObjectModel.Collection<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 28107, 28113);
return return_v;
}


System.Management.Automation.PSObject
f_1146_28224_28238()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 28224, 28238);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1146_28255_28278(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 28255, 28278);
return return_v;
}


int
f_1146_28255_28286(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 28255, 28286);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1146_28301_28324(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 28301, 28324);
return return_v;
}


System.Globalization.CultureInfo
f_1146_28343_28371()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 28343, 28371);
return return_v;
}


string
f_1146_28329_28446(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 28329, 28446);
return return_v;
}


int
f_1146_28301_28447(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 28301, 28447);
return 0;
}


System.Management.Automation.PSObject
f_1146_28488_28502()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 28488, 28502);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1146_28519_28541(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 28519, 28541);
return return_v;
}


int
f_1146_28519_28549(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 28519, 28549);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1146_28564_28586(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 28564, 28586);
return return_v;
}


System.Globalization.CultureInfo
f_1146_28605_28633()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 28605, 28633);
return return_v;
}


string
f_1146_28591_28707(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 28591, 28707);
return return_v;
}


int
f_1146_28564_28708(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 28564, 28708);
return 0;
}


System.Management.Automation.PSObject
f_1146_28744_28758()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 28744, 28758);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1146_28775_28792(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 28775, 28792);
return return_v;
}


int
f_1146_28775_28800(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 28775, 28800);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1146_28815_28832(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 28815, 28832);
return return_v;
}


System.Globalization.CultureInfo
f_1146_28851_28879()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 28851, 28879);
return return_v;
}


string
f_1146_28837_28948(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 28837, 28948);
return return_v;
}


int
f_1146_28815_28949(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 28815, 28949);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_28966_28984(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 28966, 28984);
return return_v;
}


string
f_1146_29016_29029(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 29016, 29029);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_28989_29030(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 28989, 29030);
return return_v;
}


int
f_1146_28966_29031(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 28966, 29031);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_29046_29069(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 29046, 29069);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_29074_29109(string
name,System.Management.Automation.PSObject
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 29074, 29109);
return return_v;
}


int
f_1146_29046_29110(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 29046, 29110);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_29125_29149(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 29125, 29149);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_29154_29199(string
name,System.Management.Automation.PSObject
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 29154, 29199);
return return_v;
}


int
f_1146_29125_29200(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 29125, 29200);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_29215_29229(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 29215, 29229);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_29234_29281(string
name,System.Management.Automation.PSObject
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 29234, 29281);
return return_v;
}


int
f_1146_29215_29282(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 29215, 29282);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1146,26772,29294);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,26772,29294);
}
		}

private static void AddOutputTypesProperties(PSObject obj, ReadOnlyCollection<PSTypeName> outputTypes)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1146,29516,31193);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,29643,29685);

PSObject 
returnValuesObj = f_1146_29670_29684()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,29701,29735);

f_1146_29701_29734(f_1146_29701_29726(returnValuesObj));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,29749,29900);

f_1146_29749_29899(f_1146_29749_29774(returnValuesObj), f_1146_29779_29898(f_1146_29793_29821(), "{0}#returnValues", DefaultCommandHelpObjectBuilder.TypeNameForDefaultHelp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,29916,29957);

PSObject 
returnValueObj = f_1146_29942_29956()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,29973,30006);

f_1146_29973_30005(f_1146_29973_29997(returnValueObj));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,30020,30169);

f_1146_30020_30168(f_1146_30020_30044(returnValueObj), f_1146_30049_30167(f_1146_30063_30091(), "{0}#returnValue", DefaultCommandHelpObjectBuilder.TypeNameForDefaultHelp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,30185,30219);

PSObject 
typeObj = f_1146_30204_30218()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,30235,30261);

f_1146_30235_30260(f_1146_30235_30252(typeObj));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,30275,30410);

f_1146_30275_30409(f_1146_30275_30292(typeObj), f_1146_30297_30408(f_1146_30311_30339(), "{0}#type", DefaultCommandHelpObjectBuilder.TypeNameForDefaultHelp));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,30426,30917) || true) && (f_1146_30430_30447(outputTypes)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,30426,30917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,30486,30554);

f_1146_30486_30553(f_1146_30486_30504(typeObj), f_1146_30509_30552("name", "System.Object"));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,30426,30917);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,30426,30917);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,30620,30659);

StringBuilder 
sb = f_1146_30639_30658()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,30679,30816);
foreach(PSTypeName outputType in f_1146_30713_30724_I(outputTypes) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,30679,30816);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,30766,30797);

f_1146_30766_30796(                    sb, f_1146_30780_30795(outputType));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,30679,30816);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1146,1,138);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1146,1,138);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,30836,30902);

f_1146_30836_30901(f_1146_30836_30854(typeObj), f_1146_30859_30900("name", f_1146_30886_30899(sb)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,30426,30917);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,30933,31000);

f_1146_30933_30999(f_1146_30933_30958(returnValueObj), f_1146_30963_30998("type", typeObj));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,31014,31096);

f_1146_31014_31095(f_1146_31014_31040(returnValuesObj), f_1146_31045_31094("returnValue", returnValueObj));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,31110,31182);

f_1146_31110_31181(f_1146_31110_31124(obj), f_1146_31129_31180("returnValues", returnValuesObj));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1146,29516,31193);

System.Management.Automation.PSObject
f_1146_29670_29684()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 29670, 29684);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1146_29701_29726(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 29701, 29726);
return return_v;
}


int
f_1146_29701_29734(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 29701, 29734);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1146_29749_29774(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 29749, 29774);
return return_v;
}


System.Globalization.CultureInfo
f_1146_29793_29821()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 29793, 29821);
return return_v;
}


string
f_1146_29779_29898(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 29779, 29898);
return return_v;
}


int
f_1146_29749_29899(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 29749, 29899);
return 0;
}


System.Management.Automation.PSObject
f_1146_29942_29956()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 29942, 29956);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1146_29973_29997(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 29973, 29997);
return return_v;
}


int
f_1146_29973_30005(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 29973, 30005);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1146_30020_30044(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 30020, 30044);
return return_v;
}


System.Globalization.CultureInfo
f_1146_30063_30091()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 30063, 30091);
return return_v;
}


string
f_1146_30049_30167(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 30049, 30167);
return return_v;
}


int
f_1146_30020_30168(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 30020, 30168);
return 0;
}


System.Management.Automation.PSObject
f_1146_30204_30218()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 30204, 30218);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1146_30235_30252(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 30235, 30252);
return return_v;
}


int
f_1146_30235_30260(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 30235, 30260);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1146_30275_30292(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 30275, 30292);
return return_v;
}


System.Globalization.CultureInfo
f_1146_30311_30339()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 30311, 30339);
return return_v;
}


string
f_1146_30297_30408(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 30297, 30408);
return return_v;
}


int
f_1146_30275_30409(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 30275, 30409);
return 0;
}


int
f_1146_30430_30447(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 30430, 30447);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_30486_30504(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 30486, 30504);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_30509_30552(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 30509, 30552);
return return_v;
}


int
f_1146_30486_30553(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 30486, 30553);
return 0;
}


System.Text.StringBuilder
f_1146_30639_30658()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 30639, 30658);
return return_v;
}


string
f_1146_30780_30795(System.Management.Automation.PSTypeName
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 30780, 30795);
return return_v;
}


System.Text.StringBuilder
f_1146_30766_30796(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 30766, 30796);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
f_1146_30713_30724_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 30713, 30724);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_30836_30854(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 30836, 30854);
return return_v;
}


string
f_1146_30886_30899(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 30886, 30899);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_30859_30900(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 30859, 30900);
return return_v;
}


int
f_1146_30836_30901(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 30836, 30901);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_30933_30958(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 30933, 30958);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_30963_30998(string
name,System.Management.Automation.PSObject
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 30963, 30998);
return return_v;
}


int
f_1146_30933_30999(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 30933, 30999);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_31014_31040(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 31014, 31040);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_31045_31094(string
name,System.Management.Automation.PSObject
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 31045, 31094);
return return_v;
}


int
f_1146_31014_31095(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 31014, 31095);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_31110_31124(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 31110, 31124);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_31129_31180(string
name,System.Management.Automation.PSObject
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 31129, 31180);
return return_v;
}


int
f_1146_31110_31181(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 31110, 31181);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1146,29516,31193);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,29516,31193);
}
		}

private static void AddAliasesProperties(PSObject obj, string name, ExecutionContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1146,31466,32168);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,31584,31623);

StringBuilder 
sb = f_1146_31603_31622()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,31639,31658);

bool 
found = false
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,31674,31943) || true) && (context != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,31674,31943);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,31727,31928);
foreach(string alias in f_1146_31752_31811_I(f_1146_31752_31811(f_1146_31752_31781(f_1146_31752_31772(context)), name)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,31727,31928);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,31853,31866);

found = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,31888,31909);

f_1146_31888_31908(                    sb, alias);
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,31727,31928);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1146,1,202);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1146,1,202);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1146,31674,31943);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,31959,32076) || true) && (!found)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,31959,32076);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,32003,32061);

f_1146_32003_32060(                sb, f_1146_32017_32059(f_1146_32035_32058()));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,31959,32076);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,32092,32157);

f_1146_32092_32156(f_1146_32092_32106(obj), f_1146_32111_32155("aliases", f_1146_32141_32154(sb)));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1146,31466,32168);

System.Text.StringBuilder
f_1146_31603_31622()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 31603, 31622);
return return_v;
}


System.Management.Automation.SessionState
f_1146_31752_31772(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.SessionState;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 31752, 31772);
return return_v;
}


System.Management.Automation.SessionStateInternal
f_1146_31752_31781(System.Management.Automation.SessionState
this_param)
{
var return_v = this_param.Internal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 31752, 31781);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_1146_31752_31811(System.Management.Automation.SessionStateInternal
this_param,string
command)
{
var return_v = this_param.GetAliasesByCommandName( command);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 31752, 31811);
return return_v;
}


System.Text.StringBuilder
f_1146_31888_31908(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 31888, 31908);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_1146_31752_31811_I(System.Collections.Generic.IEnumerable<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 31752, 31811);
return return_v;
}


string
f_1146_32035_32058()
{
var return_v = HelpDisplayStrings.None;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 32035, 32058);
return return_v;
}


string
f_1146_32017_32059(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 32017, 32059);
return return_v;
}


System.Text.StringBuilder
f_1146_32003_32060(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.AppendLine( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 32003, 32060);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_32092_32106(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 32092, 32106);
return return_v;
}


string
f_1146_32141_32154(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 32141, 32154);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_32111_32155(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 32111, 32155);
return return_v;
}


int
f_1146_32092_32156(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 32092, 32156);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1146,31466,32168);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,31466,32168);
}
		}

private static void AddRemarksProperties(PSObject obj, string cmdletName, string helpUri)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1146,32416,32956);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,32530,32945) || true) && (f_1146_32534_32563(helpUri))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,32530,32945);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,32597,32733);

f_1146_32597_32732(f_1146_32597_32611(obj), f_1146_32616_32731("remarks", f_1146_32646_32730(f_1146_32664_32717(), cmdletName)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,32530,32945);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,32530,32945);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,32799,32930);

f_1146_32799_32929(f_1146_32799_32813(obj), f_1146_32818_32928("remarks", f_1146_32848_32927(f_1146_32866_32905(), cmdletName, helpUri)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,32530,32945);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1146,32416,32956);

bool
f_1146_32534_32563(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 32534, 32563);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_32597_32611(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 32597, 32611);
return return_v;
}


string
f_1146_32664_32717()
{
var return_v = HelpDisplayStrings.GetLatestHelpContentWithoutHelpUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 32664, 32717);
return return_v;
}


string
f_1146_32646_32730(string
formatSpec,string
o)
{
var return_v = StringUtil.Format( formatSpec, (object)o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 32646, 32730);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_32616_32731(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 32616, 32731);
return return_v;
}


int
f_1146_32597_32732(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 32597, 32732);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_32799_32813(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 32799, 32813);
return return_v;
}


string
f_1146_32866_32905()
{
var return_v = HelpDisplayStrings.GetLatestHelpContent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 32866, 32905);
return return_v;
}


string
f_1146_32848_32927(string
formatSpec,string
o1,string
o2)
{
var return_v = StringUtil.Format( formatSpec, (object)o1, (object)o2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 32848, 32927);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_32818_32928(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 32818, 32928);
return return_v;
}


int
f_1146_32799_32929(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 32799, 32929);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1146,32416,32956);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,32416,32956);
}
		}

internal static void AddRelatedLinksProperties(PSObject obj, string relatedLink)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1146,33151,35777);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,33256,35766) || true) && (!f_1146_33261_33294(relatedLink))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,33256,35766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,33328,33372);

PSObject 
navigationLinkObj = f_1146_33357_33371()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,33392,33428);

f_1146_33392_33427(f_1146_33392_33419(navigationLinkObj));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,33446,33602);

f_1146_33446_33601(f_1146_33446_33473(navigationLinkObj), f_1146_33478_33600(f_1146_33492_33520(), "{0}#navigationLinks", DefaultCommandHelpObjectBuilder.TypeNameForDefaultHelp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,33622,33695);

f_1146_33622_33694(f_1146_33622_33650(navigationLinkObj), f_1146_33655_33693("uri", relatedLink));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,33715,33794);

List<PSObject> 
navigationLinkValues = new List<PSObject> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => navigationLinkObj,1146,33753,33793) }
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,33881,33962);

PSNoteProperty 
relatedLinksPO = f_1146_33913_33943(f_1146_33913_33927(obj), "relatedLinks")as PSNoteProperty
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,33980,35255) || true) && ((relatedLinksPO != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1146, 33984, 34042)&&(f_1146_34013_34033(relatedLinksPO)!= null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,33980,35255);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,34084,34155);

PSObject 
relatedLinksValue = f_1146_34113_34154(f_1146_34133_34153(relatedLinksPO))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,34177,34276);

PSNoteProperty 
navigationLinkPO = f_1146_34211_34257(f_1146_34211_34239(relatedLinksValue), "navigationLink")as PSNoteProperty
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,34298,35236) || true) && ((navigationLinkPO != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1146, 34302, 34364)&&(f_1146_34333_34355(navigationLinkPO)!= null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,34298,35236);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,34414,34480);

PSObject 
navigationLinkValue = f_1146_34445_34467(navigationLinkPO)as PSObject
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,34506,35213) || true) && (navigationLinkValue != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,34506,35213);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,34595,34641);

f_1146_34595_34640(                            navigationLinkValues, navigationLinkValue);
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,34506,35213);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,34506,35213);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,34755,34830);

PSObject[] 
navigationLinkValueArray = f_1146_34793_34815(navigationLinkPO)as PSObject[]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,34860,35186) || true) && (navigationLinkValueArray != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,34860,35186);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,34962,35155);
foreach(var psObject in f_1146_34987_35011_I(navigationLinkValueArray) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,34962,35155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,35085,35120);

f_1146_35085_35119(                                    navigationLinkValues, psObject);
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,34962,35155);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1146,1,194);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1146,1,194);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1146,34860,35186);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,34506,35213);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,34298,35236);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,33980,35255);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,35275,35317);

PSObject 
relatedLinksObj = f_1146_35302_35316()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,35337,35371);

f_1146_35337_35370(f_1146_35337_35362(relatedLinksObj));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,35389,35540);

f_1146_35389_35539(f_1146_35389_35414(relatedLinksObj), f_1146_35419_35538(f_1146_35433_35461(), "{0}#relatedLinks", DefaultCommandHelpObjectBuilder.TypeNameForDefaultHelp));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,35558,35659);

f_1146_35558_35658(f_1146_35558_35584(relatedLinksObj), f_1146_35589_35657("navigationLink", f_1146_35626_35656(navigationLinkValues)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,35679,35751);

f_1146_35679_35750(f_1146_35679_35693(obj), f_1146_35698_35749("relatedLinks", relatedLinksObj));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,33256,35766);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1146,33151,35777);

bool
f_1146_33261_33294(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 33261, 33294);
return return_v;
}


System.Management.Automation.PSObject
f_1146_33357_33371()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 33357, 33371);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1146_33392_33419(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 33392, 33419);
return return_v;
}


int
f_1146_33392_33427(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 33392, 33427);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1146_33446_33473(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 33446, 33473);
return return_v;
}


System.Globalization.CultureInfo
f_1146_33492_33520()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 33492, 33520);
return return_v;
}


string
f_1146_33478_33600(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 33478, 33600);
return return_v;
}


int
f_1146_33446_33601(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 33446, 33601);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_33622_33650(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 33622, 33650);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_33655_33693(string
name,string
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 33655, 33693);
return return_v;
}


int
f_1146_33622_33694(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 33622, 33694);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_33913_33927(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 33913, 33927);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1146_33913_33943(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 33913, 33943);
return return_v;
}


object
f_1146_34013_34033(System.Management.Automation.PSNoteProperty
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 34013, 34033);
return return_v;
}


object
f_1146_34133_34153(System.Management.Automation.PSNoteProperty
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 34133, 34153);
return return_v;
}


System.Management.Automation.PSObject
f_1146_34113_34154(object
obj)
{
var return_v = PSObject.AsPSObject( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 34113, 34154);
return return_v;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_34211_34239(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 34211, 34239);
return return_v;
}


System.Management.Automation.PSPropertyInfo
f_1146_34211_34257(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,string
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 34211, 34257);
return return_v;
}


object
f_1146_34333_34355(System.Management.Automation.PSNoteProperty
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 34333, 34355);
return return_v;
}


object
f_1146_34445_34467(System.Management.Automation.PSNoteProperty
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 34445, 34467);
return return_v;
}


int
f_1146_34595_34640(System.Collections.Generic.List<System.Management.Automation.PSObject>
this_param,System.Management.Automation.PSObject
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 34595, 34640);
return 0;
}


object
f_1146_34793_34815(System.Management.Automation.PSNoteProperty
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 34793, 34815);
return return_v;
}


int
f_1146_35085_35119(System.Collections.Generic.List<System.Management.Automation.PSObject>
this_param,System.Management.Automation.PSObject
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 35085, 35119);
return 0;
}


System.Management.Automation.PSObject[]
f_1146_34987_35011_I(System.Management.Automation.PSObject[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 34987, 35011);
return return_v;
}


System.Management.Automation.PSObject
f_1146_35302_35316()
{
var return_v = new System.Management.Automation.PSObject();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 35302, 35316);
return return_v;
}


System.Collections.ObjectModel.Collection<string>
f_1146_35337_35362(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 35337, 35362);
return return_v;
}


int
f_1146_35337_35370(System.Collections.ObjectModel.Collection<string>
this_param)
{
this_param.Clear();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 35337, 35370);
return 0;
}


System.Collections.ObjectModel.Collection<string>
f_1146_35389_35414(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.TypeNames;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 35389, 35414);
return return_v;
}


System.Globalization.CultureInfo
f_1146_35433_35461()
{
var return_v = CultureInfo.InvariantCulture;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 35433, 35461);
return return_v;
}


string
f_1146_35419_35538(System.Globalization.CultureInfo
provider,string
format,string
arg0)
{
var return_v = string.Format( (System.IFormatProvider)provider, format, (object)arg0);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 35419, 35538);
return return_v;
}


int
f_1146_35389_35539(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 35389, 35539);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_35558_35584(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 35558, 35584);
return return_v;
}


System.Management.Automation.PSObject[]
f_1146_35626_35656(System.Collections.Generic.List<System.Management.Automation.PSObject>
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 35626, 35656);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_35589_35657(string
name,System.Management.Automation.PSObject[]
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 35589, 35657);
return return_v;
}


int
f_1146_35558_35658(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 35558, 35658);
return 0;
}


System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
f_1146_35679_35693(System.Management.Automation.PSObject
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 35679, 35693);
return return_v;
}


System.Management.Automation.PSNoteProperty
f_1146_35698_35749(string
name,System.Management.Automation.PSObject
value)
{
var return_v = new System.Management.Automation.PSNoteProperty( name, (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 35698, 35749);
return return_v;
}


int
f_1146_35679_35750(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
this_param,System.Management.Automation.PSNoteProperty
member)
{
this_param.Add( (System.Management.Automation.PSPropertyInfo)member);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 35679, 35750);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1146,33151,35777);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,33151,35777);
}
		}

private static Collection<ParameterAttribute> GetParameterAttribute(Collection<Attribute> attributes)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1146,36039,36627);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,36165,36251);

Collection<ParameterAttribute> 
paramAttributes = f_1146_36214_36250()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,36267,36577);
foreach(Attribute attribute in f_1146_36299_36309_I(attributes) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,36267,36577);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,36343,36419);

ParameterAttribute 
paramAttribute = (object)attribute as ParameterAttribute
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,36439,36562) || true) && (paramAttribute != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,36439,36562);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,36507,36543);

f_1146_36507_36542(                    paramAttributes, paramAttribute);
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,36439,36562);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,36267,36577);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1146,1,311);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1146,1,311);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,36593,36616);

return paramAttributes;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1146,36039,36627);

System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterAttribute>
f_1146_36214_36250()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterAttribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 36214, 36250);
return return_v;
}


int
f_1146_36507_36542(System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterAttribute>
this_param,System.Management.Automation.ParameterAttribute
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 36507, 36542);
return 0;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1146_36299_36309_I(System.Collections.ObjectModel.Collection<System.Attribute>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 36299, 36309);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1146,36039,36627);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,36039,36627);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static Collection<ValidateSetAttribute> GetValidateSetAttribute(Collection<Attribute> attributes)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1146,36892,37528);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,37022,37118);

Collection<ValidateSetAttribute> 
validateSetAttributes = f_1146_37079_37117()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,37134,37472);
foreach(Attribute attribute in f_1146_37166_37176_I(attributes) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,37134,37472);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,37210,37296);

ValidateSetAttribute 
validateSetAttribute = (object)attribute as ValidateSetAttribute
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,37316,37457) || true) && (validateSetAttribute != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,37316,37457);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,37390,37438);

f_1146_37390_37437(                    validateSetAttributes, validateSetAttribute);
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,37316,37457);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,37134,37472);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1146,1,339);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1146,1,339);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,37488,37517);

return validateSetAttributes;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1146,36892,37528);

System.Collections.ObjectModel.Collection<System.Management.Automation.ValidateSetAttribute>
f_1146_37079_37117()
{
var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.ValidateSetAttribute>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 37079, 37117);
return return_v;
}


int
f_1146_37390_37437(System.Collections.ObjectModel.Collection<System.Management.Automation.ValidateSetAttribute>
this_param,System.Management.Automation.ValidateSetAttribute
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 37390, 37437);
return 0;
}


System.Collections.ObjectModel.Collection<System.Attribute>
f_1146_37166_37176_I(System.Collections.ObjectModel.Collection<System.Attribute>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 37166, 37176);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1146,36892,37528);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,36892,37528);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static string GetPipelineInputString(ParameterAttribute paramAttrib)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1146,37751,39111);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,37852,37886);

f_1146_37852_37885(paramAttrib != null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,37902,37937);

ArrayList 
values = f_1146_37921_37936()
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,37953,38101) || true) && (f_1146_37957_37986(paramAttrib))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,37953,38101);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,38020,38086);

f_1146_38020_38085(                values, f_1146_38031_38084(f_1146_38049_38083()));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,37953,38101);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,38117,38286) || true) && (f_1146_38121_38164(paramAttrib))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,38117,38286);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,38198,38271);

f_1146_38198_38270(                values, f_1146_38209_38269(f_1146_38227_38268()));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,38117,38286);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,38302,38475) || true) && (f_1146_38306_38345(paramAttrib))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,38302,38475);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,38379,38460);

f_1146_38379_38459(                values, f_1146_38390_38458(f_1146_38408_38457()));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,38302,38475);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,38491,38617) || true) && (f_1146_38495_38507(values)== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,38491,38617);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,38546,38602);

return f_1146_38553_38601(f_1146_38571_38600());
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,38491,38617);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,38633,38672);

StringBuilder 
sb = f_1146_38652_38671()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,38688,38747);

f_1146_38688_38746(
            sb, f_1146_38698_38745(f_1146_38716_38744()));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,38761,38777);

f_1146_38761_38776(            sb, " (");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,38802,38807);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,38793,39032) || true) && (i < f_1146_38813_38825(values))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,38827,38830)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1146,38793,39032))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,38793,39032);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,38864,38893);

f_1146_38864_38892(                sb, f_1146_38882_38891(values, i));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,38913,39017) || true) && (i != (f_1146_38923_38935(values)- 1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,38913,39017);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,38982,38998);

f_1146_38982_38997(                    sb, ", ");
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,38913,39017);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1146,1,240);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1146,1,240);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,39048,39063);

f_1146_39048_39062(
            sb, ")");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,39079,39100);

return f_1146_39086_39099(sb);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1146,37751,39111);

int
f_1146_37852_37885(bool
condition)
{
Debug.Assert( condition);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 37852, 37885);
return 0;
}


System.Collections.ArrayList
f_1146_37921_37936()
{
var return_v = new System.Collections.ArrayList();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 37921, 37936);
return return_v;
}


bool
f_1146_37957_37986(System.Management.Automation.ParameterAttribute
this_param)
{
var return_v = this_param.ValueFromPipeline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 37957, 37986);
return return_v;
}


string
f_1146_38049_38083()
{
var return_v = HelpDisplayStrings.PipelineByValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 38049, 38083);
return return_v;
}


string
f_1146_38031_38084(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 38031, 38084);
return return_v;
}


int
f_1146_38020_38085(System.Collections.ArrayList
this_param,string
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 38020, 38085);
return return_v;
}


bool
f_1146_38121_38164(System.Management.Automation.ParameterAttribute
this_param)
{
var return_v = this_param.ValueFromPipelineByPropertyName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 38121, 38164);
return return_v;
}


string
f_1146_38227_38268()
{
var return_v = HelpDisplayStrings.PipelineByPropertyName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 38227, 38268);
return return_v;
}


string
f_1146_38209_38269(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 38209, 38269);
return return_v;
}


int
f_1146_38198_38270(System.Collections.ArrayList
this_param,string
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 38198, 38270);
return return_v;
}


bool
f_1146_38306_38345(System.Management.Automation.ParameterAttribute
this_param)
{
var return_v = this_param.ValueFromRemainingArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 38306, 38345);
return return_v;
}


string
f_1146_38408_38457()
{
var return_v = HelpDisplayStrings.PipelineFromRemainingArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 38408, 38457);
return return_v;
}


string
f_1146_38390_38458(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 38390, 38458);
return return_v;
}


int
f_1146_38379_38459(System.Collections.ArrayList
this_param,string
value)
{
var return_v = this_param.Add( (object)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 38379, 38459);
return return_v;
}


int
f_1146_38495_38507(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 38495, 38507);
return return_v;
}


string
f_1146_38571_38600()
{
var return_v = HelpDisplayStrings.FalseShort;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 38571, 38600);
return return_v;
}


string
f_1146_38553_38601(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 38553, 38601);
return return_v;
}


System.Text.StringBuilder
f_1146_38652_38671()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 38652, 38671);
return return_v;
}


string
f_1146_38716_38744()
{
var return_v = HelpDisplayStrings.TrueShort;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 38716, 38744);
return return_v;
}


string
f_1146_38698_38745(string
formatSpec,params object[]
o)
{
var return_v = StringUtil.Format( formatSpec, o);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 38698, 38745);
return return_v;
}


System.Text.StringBuilder
f_1146_38688_38746(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 38688, 38746);
return return_v;
}


System.Text.StringBuilder
f_1146_38761_38776(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 38761, 38776);
return return_v;
}


int
f_1146_38813_38825(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 38813, 38825);
return return_v;
}


object
f_1146_38882_38891(System.Collections.ArrayList
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 38882, 38891);
return return_v;
}


System.Text.StringBuilder
f_1146_38864_38892(System.Text.StringBuilder
this_param,object
value)
{
var return_v = this_param.Append( (string)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 38864, 38892);
return return_v;
}


int
f_1146_38923_38935(System.Collections.ArrayList
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 38923, 38935);
return return_v;
}


System.Text.StringBuilder
f_1146_38982_38997(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 38982, 38997);
return return_v;
}


System.Text.StringBuilder
f_1146_39048_39062(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 39048, 39062);
return return_v;
}


string
f_1146_39086_39099(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 39086, 39099);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1146,37751,39111);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,37751,39111);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static bool HasCommonParameters(Dictionary<string, ParameterMetadata> parameters)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1146,39407,39964);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,39522,39581);

Collection<string> 
commonParams = f_1146_39556_39580()
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,39597,39876);
foreach(KeyValuePair<string, ParameterMetadata> parameter in f_1146_39659_39669_I(parameters) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,39597,39876);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,39703,39861) || true) && (f_1146_39707_39761(f_1146_39707_39730(), f_1146_39740_39760(parameter.Value)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,39703,39861);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,39803,39842);

f_1146_39803_39841(                    commonParams, f_1146_39820_39840(parameter.Value));
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,39703,39861);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,39597,39876);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1146,1,280);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1146,1,280);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,39892,39953);

return (f_1146_39900_39918(commonParams)== f_1146_39922_39951(f_1146_39922_39945()));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1146,39407,39964);

System.Collections.ObjectModel.Collection<string>
f_1146_39556_39580()
{
var return_v = new System.Collections.ObjectModel.Collection<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 39556, 39580);
return return_v;
}


System.Collections.Generic.HashSet<string>
f_1146_39707_39730()
{
var return_v = Cmdlet.CommonParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 39707, 39730);
return return_v;
}


string
f_1146_39740_39760(System.Management.Automation.ParameterMetadata
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 39740, 39760);
return return_v;
}


bool
f_1146_39707_39761(System.Collections.Generic.HashSet<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 39707, 39761);
return return_v;
}


string
f_1146_39820_39840(System.Management.Automation.ParameterMetadata
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 39820, 39840);
return return_v;
}


int
f_1146_39803_39841(System.Collections.ObjectModel.Collection<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 39803, 39841);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
f_1146_39659_39669_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ParameterMetadata>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 39659, 39669);
return return_v;
}


int
f_1146_39900_39918(System.Collections.ObjectModel.Collection<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 39900, 39918);
return return_v;
}


System.Collections.Generic.HashSet<string>
f_1146_39922_39945()
{
var return_v = Cmdlet.CommonParameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 39922, 39945);
return return_v;
}


int
f_1146_39922_39951(System.Collections.Generic.HashSet<string>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 39922, 39951);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1146,39407,39964);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,39407,39964);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static bool HasHelpInfoUri(PSModuleInfo module, string moduleName)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1146,40202,40735);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,40376,40563) || true) && (!f_1146_40381_40413(moduleName)&&(DynAbs.Tracing.TraceSender.Expression_True(1146, 40380, 40502)&&f_1146_40417_40502(moduleName, InitialSessionState.CoreModule, StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,40376,40563);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,40536,40548);

return true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,40376,40563);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,40579,40659) || true) && (module == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1146,40579,40659);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,40631,40644);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1146,40579,40659);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,40675,40724);

return !f_1146_40683_40723(f_1146_40704_40722(module));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1146,40202,40735);

bool
f_1146_40381_40413(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 40381, 40413);
return return_v;
}


bool
f_1146_40417_40502(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 40417, 40502);
return return_v;
}


string
f_1146_40704_40722(System.Management.Automation.PSModuleInfo
this_param)
{
var return_v = this_param.HelpInfoUri;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1146, 40704, 40722);
return return_v;
}


bool
f_1146_40683_40723(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1146, 40683, 40723);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1146,40202,40735);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,40202,40735);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public DefaultCommandHelpObjectBuilder()
{
DynAbs.Tracing.TraceSender.TraceEnterConstructor(1146,1442,40742);
DynAbs.Tracing.TraceSender.TraceExitConstructor(1146,1442,40742);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,1442,40742);
}


static DefaultCommandHelpObjectBuilder()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1146,1442,40742);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1146,1528,1577);
TypeNameForDefaultHelp = "ExtendedCmdletHelpInfo";DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1146,1442,40742);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1146,1442,40742);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1146,1442,40742);
}
}
