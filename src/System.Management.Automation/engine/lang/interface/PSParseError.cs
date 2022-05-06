// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
/********************************************************************++

    Project:     PowerShell

    Contents:    PowerShell error interface for syntax editors

    Classes:     System.Management.Automation.PSParseError

--********************************************************************/

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    public sealed class PSParseError
    {
        internal PSParseError(RuntimeException rte)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1566, 669, 992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1566, 1482, 1511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1566, 1598, 1628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1566, 737, 802);

                f_1566_737_801(rte != null, "exception argument should not be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1566, 816, 893);

                f_1566_816_892(f_1566_827_841(rte) != null, "token for exception should not be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1566, 909, 931);

                Message = f_1566_919_930(rte);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1566, 945, 981);

                Token = f_1566_953_980(f_1566_965_979(rte));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1566, 669, 992);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1566, 669, 992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1566, 669, 992);
            }
        }

        internal PSParseError(Language.ParseError error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1566, 1004, 1160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1566, 1482, 1511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1566, 1598, 1628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1566, 1077, 1101);

                Message = f_1566_1087_1100(error);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1566, 1115, 1149);

                Token = f_1566_1123_1148(f_1566_1135_1147(error));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1566, 1004, 1160);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1566, 1004, 1160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1566, 1004, 1160);
            }
        }

        public PSToken Token { get; }

        public string Message { get; }

        static PSParseError()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1566, 620, 1635);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1566, 620, 1635);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1566, 620, 1635);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1566, 620, 1635);

        int
        f_1566_737_801(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1566, 737, 801);
            return 0;
        }


        System.Management.Automation.Language.Token
        f_1566_827_841(System.Management.Automation.RuntimeException
        this_param)
        {
            var return_v = this_param.ErrorToken;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1566, 827, 841);
            return return_v;
        }


        int
        f_1566_816_892(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Dbg.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1566, 816, 892);
            return 0;
        }


        string
        f_1566_919_930(System.Management.Automation.RuntimeException
        this_param)
        {
            var return_v = this_param.Message;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1566, 919, 930);
            return return_v;
        }


        System.Management.Automation.Language.Token
        f_1566_965_979(System.Management.Automation.RuntimeException
        this_param)
        {
            var return_v = this_param.ErrorToken;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1566, 965, 979);
            return return_v;
        }


        System.Management.Automation.PSToken
        f_1566_953_980(System.Management.Automation.Language.Token
        token)
        {
            var return_v = new System.Management.Automation.PSToken(token);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1566, 953, 980);
            return return_v;
        }


        string
        f_1566_1087_1100(System.Management.Automation.Language.ParseError
        this_param)
        {
            var return_v = this_param.Message;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1566, 1087, 1100);
            return return_v;
        }


        System.Management.Automation.Language.IScriptExtent
        f_1566_1135_1147(System.Management.Automation.Language.ParseError
        this_param)
        {
            var return_v = this_param.Extent;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1566, 1135, 1147);
            return return_v;
        }


        System.Management.Automation.PSToken
        f_1566_1123_1148(System.Management.Automation.Language.IScriptExtent
        extent)
        {
            var return_v = new System.Management.Automation.PSToken(extent);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1566, 1123, 1148);
            return return_v;
        }

    }
}
