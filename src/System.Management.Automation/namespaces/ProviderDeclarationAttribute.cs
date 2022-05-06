// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace System.Management.Automation.Provider
{
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed class CmdletProviderAttribute : Attribute
{
public CmdletProviderAttribute(
            string providerName,
            ProviderCapabilities providerCapabilities)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1208,1302,2040);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1208,2067,2132);
this._illegalCharacters = new char[] { ':', '\\', '[', ']', '?', '*' };DynAbs.Tracing.TraceSender.TraceSimpleStatement(1208,2236,2287);
this.ProviderName = string.Empty;DynAbs.Tracing.TraceSender.TraceSimpleStatement(1208,2423,2509);
this.ProviderCapabilities = ProviderCapabilities.None;
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1208,1484,1632) || true) && (f_1208_1488_1522(providerName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1208,1484,1632);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1208,1556,1617);

throw f_1208_1562_1616("providerName");
DynAbs.Tracing.TraceSender.TraceExitCondition(1208,1484,1632);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1208,1648,1927) || true) && (f_1208_1652_1695(providerName, _illegalCharacters)!= -1)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1208,1648,1927);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1208,1735,1912);

throw f_1208_1741_1911("providerName", f_1208_1835_1875(), providerName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1208,1648,1927);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1208,1943,1971);

ProviderName = providerName;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1208,1985,2029);

ProviderCapabilities = providerCapabilities;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1208,1302,2040);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1208,1302,2040);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1208,1302,2040);
}
		}

private char[] _illegalCharacters ;

public string ProviderName {get; }

public ProviderCapabilities ProviderCapabilities {get; }

static CmdletProviderAttribute()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1208,418,2583);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1208,418,2583);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1208,418,2583);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1208,418,2583);

bool
f_1208_1488_1522(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1208, 1488, 1522);
return return_v;
}


System.Management.Automation.PSArgumentNullException
f_1208_1562_1616(string
paramName)
{
var return_v = PSTraceSource.NewArgumentNullException( paramName);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1208, 1562, 1616);
return return_v;
}


int
f_1208_1652_1695(string
this_param,char[]
anyOf)
{
var return_v = this_param.IndexOfAny( anyOf);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1208, 1652, 1695);
return return_v;
}


string
f_1208_1835_1875()
{
var return_v =                     SessionStateStrings.ProviderNameNotValid;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1208, 1835, 1875);
return return_v;
}


System.Management.Automation.PSArgumentException
f_1208_1741_1911(string
paramName,string
resourceString,params object[]
args)
{
var return_v = PSTraceSource.NewArgumentException( paramName, resourceString, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1208, 1741, 1911);
return return_v;
}

}

    /// <summary>
    /// This enumeration defines the capabilities that the provider implements.
    /// </summary>
    [Flags]
    public enum ProviderCapabilities
    {
        /// <summary>
        /// The provider does not add any additional capabilities beyond what the
        /// Monad engine provides.
        /// </summary>
        None = 0x0,

        /// <summary>
        /// The provider does the inclusion filtering for those commands that take an Include
        /// parameter. The Monad engine should not try to do the filtering on behalf of this
        /// provider.
        /// </summary>
        /// <remarks>
        /// Note, the provider should make every effort to filter in a way that is consistent
        /// with the Monad engine. This option is allowed because in many cases the provider
        /// can be much more efficient at filtering.
        /// </remarks>
        Include = 0x1,

        /// <summary>
        /// The provider does the exclusion filtering for those commands that take an Exclude
        /// parameter. The Monad engine should not try to do the filtering on behalf of this
        /// provider.
        /// </summary>
        /// <remarks>
        /// Note, the provider should make every effort to filter in a way that is consistent
        /// with the Monad engine. This option is allowed because in many cases the provider
        /// can be much more efficient at filtering.
        /// </remarks>
        Exclude = 0x2,

        /// <summary>
        /// The provider can take a provider specific filter string.
        /// </summary>
        /// <remarks>
        /// When this attribute is specified a provider specific filter can be passed from
        /// the Core Commands to the provider. This filter string is not interpreted in any
        /// way by the Monad engine.
        /// </remarks>
        Filter = 0x4,

        /// <summary>
        /// The provider does the wildcard matching for those commands that allow for it. The Monad
        /// engine should not try to do the wildcard matching on behalf of the provider when this
        /// flag is set.
        /// </summary>
        /// <remarks>
        /// Note, the provider should make every effort to do the wildcard matching in a way that is consistent
        /// with the Monad engine. This option is allowed because in many cases wildcard matching
        /// cannot occur via the path name or because the provider can do the matching in a much more
        /// efficient manner.
        /// </remarks>
        ExpandWildcards = 0x8,

        /// <summary>
        /// The provider supports ShouldProcess. When this capability is specified, the
        /// -Whatif and -Confirm parameters become available to the user when using
        /// this provider.
        /// </summary>
        ShouldProcess = 0x10,

        /// <summary>
        /// The provider supports credentials. When this capability is specified and
        /// the user passes credentials to the core cmdlets, those credentials will
        /// be passed to the provider. If the provider doesn't specify this capability
        /// and the user passes credentials, an exception is thrown.
        /// </summary>
        Credentials = 0x20,

        /// <summary>
        /// The provider supports transactions. When this capability is specified, PowerShell
        /// lets the provider participate in the current PowerShell transaction.
        /// The provider does not support this capability and the user attempts to apply a
        /// transaction to it, an exception is thrown.
        /// </summary>
        Transactions = 0x40,
    }
}
