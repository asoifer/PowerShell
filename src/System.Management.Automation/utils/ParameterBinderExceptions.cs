// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Management.Automation
{
    [Serializable]
    public class ParameterBindingException : RuntimeException
    {
        internal ParameterBindingException(
                    ErrorCategory errorCategory,
                    InvocationInfo invocationInfo,
                    IScriptExtent errorPosition,
                    string parameterName,
                    Type parameterType,
                    Type typeSpecified,
                    string resourceString,
                    string errorId,
                    params object[] args)
        : base(f_1029_2917_2930_C(errorCategory), invocationInfo, errorPosition, errorId, null, null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1029, 2532, 4171);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13114, 13122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13455, 13484);
                this._parameterName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13758, 13772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14061, 14075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14351, 14359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14632, 14654);
                this._line = Int64.MinValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14945, 14969);
                this._offset = Int64.MinValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15277, 15292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15378, 15393);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15421, 15450);
                this._args = f_1029_15429_15450();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15476, 15488);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 3008, 3156) || true) && (f_1029_3012_3048(resourceString))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1029, 3008, 3156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 3082, 3141);

                    throw f_1029_3088_3140("resourceString");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1029, 3008, 3156);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 3172, 3306) || true) && (f_1029_3176_3205(errorId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1029, 3172, 3306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 3239, 3291);

                    throw f_1029_3245_3290("errorId");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1029, 3172, 3306);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 3322, 3355);

                _invocationInfo = invocationInfo;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 3371, 3492) || true) && (_invocationInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1029, 3371, 3492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 3432, 3477);

                    _commandName = f_1029_3447_3476(f_1029_3447_3471(invocationInfo));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1029, 3371, 3492);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 3508, 3539);

                _parameterName = parameterName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 3553, 3584);

                _parameterType = parameterType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 3598, 3629);

                _typeSpecified = typeSpecified;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 3645, 3796) || true) && ((errorPosition == null) && (DynAbs.Tracing.TraceSender.Expression_True(1029, 3649, 3701) && (_invocationInfo != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1029, 3645, 3796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 3735, 3781);

                    errorPosition = f_1029_3751_3780(invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1029, 3645, 3796);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 3812, 3984) || true) && (errorPosition != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1029, 3812, 3984);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 3871, 3909);

                    _line = f_1029_3879_3908(errorPosition);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 3927, 3969);

                    _offset = f_1029_3937_3968(errorPosition);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1029, 3812, 3984);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 4000, 4033);

                _resourceString = resourceString;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 4047, 4066);

                _errorId = errorId;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 4082, 4160) || true) && (args != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1029, 4082, 4160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 4132, 4145);

                    _args = args;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1029, 4082, 4160);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1029, 2532, 4171);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 2532, 4171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 2532, 4171);
            }
        }

        internal ParameterBindingException(
                    Exception innerException,
                    ErrorCategory errorCategory,
                    InvocationInfo invocationInfo,
                    IScriptExtent errorPosition,
                    string parameterName,
                    Type parameterType,
                    Type typeSpecified,
                    string resourceString,
                    string errorId,
                    params object[] args)
        : base(f_1029_6630_6643_C(errorCategory), invocationInfo, errorPosition, errorId, null, innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1029, 6206, 7937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13114, 13122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13455, 13484);
                this._parameterName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13758, 13772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14061, 14075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14351, 14359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14632, 14654);
                this._line = Int64.MinValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14945, 14969);
                this._offset = Int64.MinValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15277, 15292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15378, 15393);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15421, 15450);
                this._args = f_1029_15429_15450();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15476, 15488);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 6731, 6869) || true) && (invocationInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1029, 6731, 6869);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 6791, 6854);

                    throw f_1029_6797_6853("invocationInfo");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1029, 6731, 6869);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 6885, 7033) || true) && (f_1029_6889_6925(resourceString))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1029, 6885, 7033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 6959, 7018);

                    throw f_1029_6965_7017("resourceString");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1029, 6885, 7033);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 7049, 7183) || true) && (f_1029_7053_7082(errorId))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1029, 7049, 7183);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 7116, 7168);

                    throw f_1029_7122_7167("errorId");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1029, 7049, 7183);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 7199, 7232);

                _invocationInfo = invocationInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 7246, 7291);

                _commandName = f_1029_7261_7290(f_1029_7261_7285(invocationInfo));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 7305, 7336);

                _parameterName = parameterName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 7350, 7381);

                _parameterType = parameterType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 7395, 7426);

                _typeSpecified = typeSpecified;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 7442, 7562) || true) && (errorPosition == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1029, 7442, 7562);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 7501, 7547);

                    errorPosition = f_1029_7517_7546(invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1029, 7442, 7562);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 7578, 7750) || true) && (errorPosition != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1029, 7578, 7750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 7637, 7675);

                    _line = f_1029_7645_7674(errorPosition);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 7693, 7735);

                    _offset = f_1029_7703_7734(errorPosition);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1029, 7578, 7750);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 7766, 7799);

                _resourceString = resourceString;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 7813, 7832);

                _errorId = errorId;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 7848, 7926) || true) && (args != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1029, 7848, 7926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 7898, 7911);

                    _args = args;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1029, 7848, 7926);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1029, 6206, 7937);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 6206, 7937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 6206, 7937);
            }
        }

        internal ParameterBindingException(
                    Exception innerException,
                    ParameterBindingException pbex,
                    string resourceString,
                    params object[] args)
        : base(f_1029_8391_8403_C(string.Empty), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1029, 8180, 9815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13114, 13122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13455, 13484);
                this._parameterName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13758, 13772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14061, 14075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14351, 14359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14632, 14654);
                this._line = Int64.MinValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14945, 14969);
                this._offset = Int64.MinValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15277, 15292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15378, 15393);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15421, 15450);
                this._args = f_1029_15429_15450();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15476, 15488);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 8445, 8563) || true) && (pbex == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1029, 8445, 8563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 8495, 8548);

                    throw f_1029_8501_8547("pbex");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1029, 8445, 8563);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 8579, 8727) || true) && (f_1029_8583_8619(resourceString))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1029, 8579, 8727);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 8653, 8712);

                    throw f_1029_8659_8711("resourceString");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1029, 8579, 8727);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 8743, 8784);

                _invocationInfo = f_1029_8761_8783(pbex);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 8798, 8920) || true) && (_invocationInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1029, 8798, 8920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 8859, 8905);

                    _commandName = f_1029_8874_8904(f_1029_8874_8899(_invocationInfo));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1029, 8798, 8920);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 8936, 8971);

                IScriptExtent
                errorPosition = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 8985, 9108) || true) && (_invocationInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1029, 8985, 9108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 9046, 9093);

                    errorPosition = f_1029_9062_9092(_invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1029, 8985, 9108);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 9124, 9142);

                _line = f_1029_9132_9141(pbex);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 9156, 9178);

                _offset = f_1029_9166_9177(pbex);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 9194, 9230);

                _parameterName = f_1029_9211_9229(pbex);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 9244, 9280);

                _parameterType = f_1029_9261_9279(pbex);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 9294, 9330);

                _typeSpecified = f_1029_9311_9329(pbex);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 9344, 9368);

                _errorId = f_1029_9355_9367(pbex);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 9384, 9417);

                _resourceString = resourceString;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 9433, 9511) || true) && (args != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1029, 9433, 9511);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 9483, 9496);

                    _args = args;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1029, 9433, 9511);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 9527, 9577);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorCategory(f_1029_9549_9565(pbex)._category), 1029, 9527, 9576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 9591, 9617);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetErrorId(_errorId), 1029, 9591, 9616);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 9631, 9804) || true) && (_invocationInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1029, 9631, 9804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 9692, 9789);

                    f_1029_9692_9788(DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.ErrorRecord, 1029, 9692, 9708), f_1029_9727_9787(f_1029_9746_9771(_invocationInfo), errorPosition));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1029, 9631, 9804);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1029, 8180, 9815);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 8180, 9815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 8180, 9815);
            }
        }

        protected ParameterBindingException(
                    SerializationInfo info,
                    StreamingContext context)
        : base(f_1029_10341_10345_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1029, 10208, 10609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13114, 13122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13455, 13484);
                this._parameterName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13758, 13772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14061, 14075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14351, 14359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14632, 14654);
                this._line = Int64.MinValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14945, 14969);
                this._offset = Int64.MinValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15277, 15292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15378, 15393);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15421, 15450);
                this._args = f_1029_15429_15450();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15476, 15488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 10380, 10443);

                _message = f_1029_10391_10442(info, "ParameterBindingException_Message");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 10457, 10506);

                _parameterName = f_1029_10474_10505(info, "ParameterName");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 10520, 10550);

                _line = f_1029_10528_10549(info, "Line");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 10564, 10598);

                _offset = f_1029_10574_10597(info, "Offset");
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1029, 10208, 10609);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 10208, 10609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 10208, 10609);
            }
        }

        [SecurityPermissionAttribute(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1029, 10890, 11490);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 11092, 11199) || true) && (info == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1029, 11092, 11199);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 11142, 11184);

                    throw f_1029_11148_11183("info");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1029, 11092, 11199);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 11215, 11249);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetObjectData(info, context), 1029, 11215, 11248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 11263, 11328);

                f_1029_11263_11327(info, "ParameterBindingException_Message", f_1029_11314_11326(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 11342, 11389);

                f_1029_11342_11388(info, "ParameterName", _parameterName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 11403, 11432);

                f_1029_11403_11431(info, "Line", _line);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 11446, 11479);

                f_1029_11446_11478(info, "Offset", _offset);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1029, 10890, 11490);

                System.Management.Automation.PSArgumentNullException
                f_1029_11148_11183(string
                paramName)
                {
                    var return_v = new System.Management.Automation.PSArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 11148, 11183);
                    return return_v;
                }


                string
                f_1029_11314_11326(System.Management.Automation.ParameterBindingException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 11314, 11326);
                    return return_v;
                }


                int
                f_1029_11263_11327(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 11263, 11327);
                    return 0;
                }


                int
                f_1029_11342_11388(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, string
                value)
                {
                    this_param.AddValue(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 11342, 11388);
                    return 0;
                }


                int
                f_1029_11403_11431(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, long
                value)
                {
                    this_param.AddValue(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 11403, 11431);
                    return 0;
                }


                int
                f_1029_11446_11478(System.Runtime.Serialization.SerializationInfo
                this_param, string
                name, long
                value)
                {
                    this_param.AddValue(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 11446, 11478);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 10890, 11490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 10890, 11490);
            }
        }

        public ParameterBindingException() : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1029, 11740, 11788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13114, 13122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13455, 13484);
                this._parameterName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13758, 13772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14061, 14075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14351, 14359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14632, 14654);
                this._line = Int64.MinValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14945, 14969);
                this._offset = Int64.MinValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15277, 15292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15378, 15393);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15421, 15450);
                this._args = f_1029_15429_15450();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15476, 15488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 11785, 11786);
                ;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1029, 11740, 11788);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 11740, 11788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 11740, 11788);
            }
        }

        public ParameterBindingException(string message) : base(f_1029_12140_12147_C(message))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1029, 12084, 12172);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13114, 13122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13455, 13484);
                this._parameterName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13758, 13772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14061, 14075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14351, 14359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14632, 14654);
                this._line = Int64.MinValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14945, 14969);
                this._offset = Int64.MinValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15277, 15292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15378, 15393);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15421, 15450);
                this._args = f_1029_15429_15450();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15476, 15488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 12151, 12170);

                _message = message;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1029, 12084, 12172);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 12084, 12172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 12084, 12172);
            }
        }

        public ParameterBindingException(
                    string message,
                    Exception innerException)
        : base(f_1029_12707_12714_C(message), innerException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1029, 12585, 12764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13114, 13122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13455, 13484);
                this._parameterName = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13758, 13772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14061, 14075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14351, 14359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14632, 14654);
                this._line = Int64.MinValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14945, 14969);
                this._offset = Int64.MinValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15277, 15292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15378, 15393);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15421, 15450);
                this._args = f_1029_15429_15450();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15476, 15488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 12743, 12762);

                _message = message;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1029, 12585, 12764);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 12585, 12764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 12585, 12764);
            }
        }

        public override string Message
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1029, 13021, 13076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13027, 13074);

                    return _message ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1029, 13034, 13073) ?? (_message = f_1029_13058_13072(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1029, 13021, 13076);

                    string
                    f_1029_13058_13072(System.Management.Automation.ParameterBindingException
                    this_param)
                    {
                        var return_v = this_param.BuildMessage();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 13058, 13072);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 12966, 13087);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 12966, 13087);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _message;

        public string ParameterName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1029, 13344, 13417);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13380, 13402);

                    return _parameterName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1029, 13344, 13417);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 13292, 13428);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 13292, 13428);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _parameterName;

        public Type ParameterType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1029, 13649, 13722);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13685, 13707);

                    return _parameterType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1029, 13649, 13722);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 13599, 13733);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 13599, 13733);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Type _parameterType;

        public Type TypeSpecified
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1029, 13952, 14025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 13988, 14010);

                    return _typeSpecified;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1029, 13952, 14025);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 13902, 14036);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 13902, 14036);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Type _typeSpecified;

        public string ErrorId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1029, 14246, 14313);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14282, 14298);

                    return _errorId;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1029, 14246, 14313);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 14200, 14324);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 14200, 14324);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private string _errorId;

        public Int64 Line
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1029, 14531, 14595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14567, 14580);

                    return _line;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1029, 14531, 14595);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 14489, 14606);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 14489, 14606);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Int64 _line;

        public Int64 Offset
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1029, 14842, 14908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 14878, 14893);

                    return _offset;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1029, 14842, 14908);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 14798, 14919);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 14798, 14919);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Int64 _offset;

        public InvocationInfo CommandInvocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1029, 15157, 15231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15193, 15216);

                    return _invocationInfo;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1029, 15157, 15231);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 15093, 15242);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 15093, 15242);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private InvocationInfo _invocationInfo;

        private string _resourceString;

        private object[] _args;

        private string _commandName;

        private string BuildMessage()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1029, 15501, 16304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15555, 15600);

                object[]
                messageArgs = f_1029_15578_15599()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15616, 16054) || true) && (_args != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1029, 15616, 16054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15667, 15710);

                    messageArgs = new object[f_1029_15692_15704(_args) + 6];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15728, 15758);

                    messageArgs[0] = _commandName;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15776, 15808);

                    messageArgs[1] = _parameterName;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15826, 15858);

                    messageArgs[2] = _parameterType;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15876, 15908);

                    messageArgs[3] = _typeSpecified;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15926, 15949);

                    messageArgs[4] = _line;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 15967, 15992);

                    messageArgs[5] = _offset;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 16010, 16039);

                    f_1029_16010_16038(_args, messageArgs, 6);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1029, 15616, 16054);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 16070, 16099);

                string
                result = string.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 16115, 16263) || true) && (!f_1029_16120_16157(_resourceString))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1029, 16115, 16263);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 16191, 16248);

                    result = f_1029_16200_16247(_resourceString, messageArgs);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1029, 16115, 16263);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 16279, 16293);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1029, 15501, 16304);

                object[]
                f_1029_15578_15599()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 15578, 15599);
                    return return_v;
                }


                int
                f_1029_15692_15704(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 15692, 15704);
                    return return_v;
                }


                int
                f_1029_16010_16038(object[]
                this_param, object[]
                array, int
                index)
                {
                    this_param.CopyTo((System.Array)array, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 16010, 16038);
                    return 0;
                }


                bool
                f_1029_16120_16157(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 16120, 16157);
                    return return_v;
                }


                string
                f_1029_16200_16247(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 16200, 16247);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 15501, 16304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 15501, 16304);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ParameterBindingException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1029, 447, 16341);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1029, 447, 16341);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 447, 16341);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1029, 447, 16341);

        bool
        f_1029_3012_3048(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 3012, 3048);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1029_3088_3140(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 3088, 3140);
            return return_v;
        }


        bool
        f_1029_3176_3205(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 3176, 3205);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1029_3245_3290(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 3245, 3290);
            return return_v;
        }


        System.Management.Automation.CommandInfo
        f_1029_3447_3471(System.Management.Automation.InvocationInfo
        this_param)
        {
            var return_v = this_param.MyCommand;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 3447, 3471);
            return return_v;
        }


        string
        f_1029_3447_3476(System.Management.Automation.CommandInfo
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 3447, 3476);
            return return_v;
        }


        System.Management.Automation.Language.IScriptExtent
        f_1029_3751_3780(System.Management.Automation.InvocationInfo
        this_param)
        {
            var return_v = this_param.ScriptPosition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 3751, 3780);
            return return_v;
        }


        int
        f_1029_3879_3908(System.Management.Automation.Language.IScriptExtent
        this_param)
        {
            var return_v = this_param.StartLineNumber;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 3879, 3908);
            return return_v;
        }


        int
        f_1029_3937_3968(System.Management.Automation.Language.IScriptExtent
        this_param)
        {
            var return_v = this_param.StartColumnNumber;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 3937, 3968);
            return return_v;
        }


        static System.Management.Automation.ErrorCategory
        f_1029_2917_2930_C(System.Management.Automation.ErrorCategory
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1029, 2532, 4171);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1029_6797_6853(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 6797, 6853);
            return return_v;
        }


        bool
        f_1029_6889_6925(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 6889, 6925);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1029_6965_7017(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 6965, 7017);
            return return_v;
        }


        bool
        f_1029_7053_7082(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 7053, 7082);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1029_7122_7167(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 7122, 7167);
            return return_v;
        }


        System.Management.Automation.CommandInfo
        f_1029_7261_7285(System.Management.Automation.InvocationInfo
        this_param)
        {
            var return_v = this_param.MyCommand;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 7261, 7285);
            return return_v;
        }


        string
        f_1029_7261_7290(System.Management.Automation.CommandInfo
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 7261, 7290);
            return return_v;
        }


        System.Management.Automation.Language.IScriptExtent
        f_1029_7517_7546(System.Management.Automation.InvocationInfo
        this_param)
        {
            var return_v = this_param.ScriptPosition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 7517, 7546);
            return return_v;
        }


        int
        f_1029_7645_7674(System.Management.Automation.Language.IScriptExtent
        this_param)
        {
            var return_v = this_param.StartLineNumber;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 7645, 7674);
            return return_v;
        }


        int
        f_1029_7703_7734(System.Management.Automation.Language.IScriptExtent
        this_param)
        {
            var return_v = this_param.StartColumnNumber;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 7703, 7734);
            return return_v;
        }


        static System.Management.Automation.ErrorCategory
        f_1029_6630_6643_C(System.Management.Automation.ErrorCategory
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1029, 6206, 7937);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1029_8501_8547(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 8501, 8547);
            return return_v;
        }


        bool
        f_1029_8583_8619(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 8583, 8619);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1029_8659_8711(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 8659, 8711);
            return return_v;
        }


        System.Management.Automation.InvocationInfo
        f_1029_8761_8783(System.Management.Automation.ParameterBindingException
        this_param)
        {
            var return_v = this_param.CommandInvocation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 8761, 8783);
            return return_v;
        }


        System.Management.Automation.CommandInfo
        f_1029_8874_8899(System.Management.Automation.InvocationInfo
        this_param)
        {
            var return_v = this_param.MyCommand;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 8874, 8899);
            return return_v;
        }


        string
        f_1029_8874_8904(System.Management.Automation.CommandInfo
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 8874, 8904);
            return return_v;
        }


        System.Management.Automation.Language.IScriptExtent
        f_1029_9062_9092(System.Management.Automation.InvocationInfo
        this_param)
        {
            var return_v = this_param.ScriptPosition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 9062, 9092);
            return return_v;
        }


        long
        f_1029_9132_9141(System.Management.Automation.ParameterBindingException
        this_param)
        {
            var return_v = this_param.Line;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 9132, 9141);
            return return_v;
        }


        long
        f_1029_9166_9177(System.Management.Automation.ParameterBindingException
        this_param)
        {
            var return_v = this_param.Offset;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 9166, 9177);
            return return_v;
        }


        string
        f_1029_9211_9229(System.Management.Automation.ParameterBindingException
        this_param)
        {
            var return_v = this_param.ParameterName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 9211, 9229);
            return return_v;
        }


        System.Type
        f_1029_9261_9279(System.Management.Automation.ParameterBindingException
        this_param)
        {
            var return_v = this_param.ParameterType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 9261, 9279);
            return return_v;
        }


        System.Type
        f_1029_9311_9329(System.Management.Automation.ParameterBindingException
        this_param)
        {
            var return_v = this_param.TypeSpecified;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 9311, 9329);
            return return_v;
        }


        string
        f_1029_9355_9367(System.Management.Automation.ParameterBindingException
        this_param)
        {
            var return_v = this_param.ErrorId;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 9355, 9367);
            return return_v;
        }


        System.Management.Automation.ErrorRecord
        f_1029_9549_9565(System.Management.Automation.ParameterBindingException
        this_param)
        {
            var return_v = this_param.ErrorRecord;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 9549, 9565);
            return return_v;
        }


        System.Management.Automation.CommandInfo
        f_1029_9746_9771(System.Management.Automation.InvocationInfo
        this_param)
        {
            var return_v = this_param.MyCommand;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 9746, 9771);
            return return_v;
        }


        System.Management.Automation.InvocationInfo
        f_1029_9727_9787(System.Management.Automation.CommandInfo
        commandInfo, System.Management.Automation.Language.IScriptExtent
        scriptPosition)
        {
            var return_v = new System.Management.Automation.InvocationInfo(commandInfo, scriptPosition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 9727, 9787);
            return return_v;
        }


        int
        f_1029_9692_9788(System.Management.Automation.ErrorRecord
        this_param, System.Management.Automation.InvocationInfo
        invocationInfo)
        {
            this_param.SetInvocationInfo(invocationInfo);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 9692, 9788);
            return 0;
        }


        static string
        f_1029_8391_8403_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1029, 8180, 9815);
            return return_v;
        }


        string?
        f_1029_10391_10442(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetString(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 10391, 10442);
            return return_v;
        }


        string?
        f_1029_10474_10505(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetString(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 10474, 10505);
            return return_v;
        }


        long
        f_1029_10528_10549(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetInt64(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 10528, 10549);
            return return_v;
        }


        long
        f_1029_10574_10597(System.Runtime.Serialization.SerializationInfo
        this_param, string
        name)
        {
            var return_v = this_param.GetInt64(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 10574, 10597);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1029_10341_10345_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1029, 10208, 10609);
            return return_v;
        }


        static string
        f_1029_12140_12147_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1029, 12084, 12172);
            return return_v;
        }


        static string
        f_1029_12707_12714_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1029, 12585, 12764);
            return return_v;
        }


        object[]
        f_1029_15429_15450()
        {
            var return_v = Array.Empty<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1029, 15429, 15450);
            return return_v;
        }

    }
    [Serializable]
    internal class ParameterBindingValidationException : ParameterBindingException
    {
        internal ParameterBindingValidationException(
                    ErrorCategory errorCategory,
                    InvocationInfo invocationInfo,
                    IScriptExtent errorPosition,
                    string parameterName,
                    Type parameterType,
                    Type typeSpecified,
                    string resourceString,
                    string errorId,
                    params object[] args)
        : base(
        f_1029_18639_18652_C(errorCategory), invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1029, 18226, 18918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 22998, 23023);
                this._swallowException = false;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1029, 18226, 18918);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 18226, 18918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 18226, 18918);
            }
        }

        internal ParameterBindingValidationException(
                    Exception innerException,
                    ErrorCategory errorCategory,
                    InvocationInfo invocationInfo,
                    IScriptExtent errorPosition,
                    string parameterName,
                    Type parameterType,
                    Type typeSpecified,
                    string resourceString,
                    string errorId,
                    params object[] args)
        : base(
        f_1029_21355_21369_C(innerException), errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1029, 20903, 21936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 22998, 23023);
                this._swallowException = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 21670, 21766);

                ValidationMetadataException
                validationException = innerException as ValidationMetadataException
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 21780, 21925) || true) && (validationException != null && (DynAbs.Tracing.TraceSender.Expression_True(1029, 21784, 21851) && f_1029_21815_21851(validationException)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1029, 21780, 21925);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 21885, 21910);

                    _swallowException = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1029, 21780, 21925);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1029, 20903, 21936);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 20903, 21936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 20903, 21936);
            }
        }

        protected ParameterBindingValidationException(
                    SerializationInfo info,
                    StreamingContext context)
        : base(f_1029_22479_22483_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1029, 22336, 22515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 22998, 23023);
                this._swallowException = false;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1029, 22336, 22515);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 22336, 22515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 22336, 22515);
            }
        }

        internal bool SwallowException
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1029, 22920, 22953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1029, 22926, 22951);

                    return _swallowException;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1029, 22920, 22953);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 22865, 22964);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 22865, 22964);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private readonly bool _swallowException;

        static ParameterBindingValidationException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1029, 16349, 23062);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1029, 16349, 23062);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 16349, 23062);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1029, 16349, 23062);

        static System.Management.Automation.ErrorCategory
        f_1029_18639_18652_C(System.Management.Automation.ErrorCategory
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1029, 18226, 18918);
            return return_v;
        }


        bool
        f_1029_21815_21851(System.Management.Automation.ValidationMetadataException
        this_param)
        {
            var return_v = this_param.SwallowException;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1029, 21815, 21851);
            return return_v;
        }


        static System.Exception
        f_1029_21355_21369_C(System.Exception
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1029, 20903, 21936);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1029_22479_22483_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1029, 22336, 22515);
            return return_v;
        }

    }
    [Serializable]
    internal class ParameterBindingArgumentTransformationException : ParameterBindingException
    {
        internal ParameterBindingArgumentTransformationException(
                    ErrorCategory errorCategory,
                    InvocationInfo invocationInfo,
                    IScriptExtent errorPosition,
                    string parameterName,
                    Type parameterType,
                    Type typeSpecified,
                    string resourceString,
                    string errorId,
                    params object[] args)
        : base(
        f_1029_25396_25409_C(errorCategory), invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1029, 24971, 25675);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1029, 24971, 25675);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 24971, 25675);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 24971, 25675);
            }
        }

        internal ParameterBindingArgumentTransformationException(
                    Exception innerException,
                    ErrorCategory errorCategory,
                    InvocationInfo invocationInfo,
                    IScriptExtent errorPosition,
                    string parameterName,
                    Type parameterType,
                    Type typeSpecified,
                    string resourceString,
                    string errorId,
                    params object[] args)
        : base(
        f_1029_28121_28135_C(innerException), errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1029, 27657, 28433);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1029, 27657, 28433);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 27657, 28433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 27657, 28433);
            }
        }

        protected ParameterBindingArgumentTransformationException(
                    SerializationInfo info,
                    StreamingContext context)
        : base(f_1029_28999_29003_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1029, 28844, 29035);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1029, 28844, 29035);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 28844, 29035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 28844, 29035);
            }
        }

        static ParameterBindingArgumentTransformationException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1029, 23070, 29078);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1029, 23070, 29078);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 23070, 29078);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1029, 23070, 29078);

        static System.Management.Automation.ErrorCategory
        f_1029_25396_25409_C(System.Management.Automation.ErrorCategory
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1029, 24971, 25675);
            return return_v;
        }


        static System.Exception
        f_1029_28121_28135_C(System.Exception
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1029, 27657, 28433);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1029_28999_29003_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1029, 28844, 29035);
            return return_v;
        }

    }
    [Serializable]
    internal class ParameterBindingParameterDefaultValueException : ParameterBindingException
    {
        internal ParameterBindingParameterDefaultValueException(
                    ErrorCategory errorCategory,
                    InvocationInfo invocationInfo,
                    IScriptExtent errorPosition,
                    string parameterName,
                    Type parameterType,
                    Type typeSpecified,
                    string resourceString,
                    string errorId,
                    params object[] args)
        : base(
        f_1029_31409_31422_C(errorCategory), invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1029, 30985, 31688);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1029, 30985, 31688);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 30985, 31688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 30985, 31688);
            }
        }

        internal ParameterBindingParameterDefaultValueException(
                    Exception innerException,
                    ErrorCategory errorCategory,
                    InvocationInfo invocationInfo,
                    IScriptExtent errorPosition,
                    string parameterName,
                    Type parameterType,
                    Type typeSpecified,
                    string resourceString,
                    string errorId,
                    params object[] args)
        : base(
        f_1029_34132_34146_C(innerException), errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1029, 33669, 34444);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1029, 33669, 34444);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 33669, 34444);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 33669, 34444);
            }
        }

        protected ParameterBindingParameterDefaultValueException(
                    SerializationInfo info,
                    StreamingContext context)
        : base(f_1029_35010_35014_C(info), context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1029, 34856, 35046);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1029, 34856, 35046);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1029, 34856, 35046);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 34856, 35046);
            }
        }

        static ParameterBindingParameterDefaultValueException()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1029, 29086, 35089);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1029, 29086, 35089);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1029, 29086, 35089);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1029, 29086, 35089);

        static System.Management.Automation.ErrorCategory
        f_1029_31409_31422_C(System.Management.Automation.ErrorCategory
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1029, 30985, 31688);
            return return_v;
        }


        static System.Exception
        f_1029_34132_34146_C(System.Exception
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1029, 33669, 34444);
            return return_v;
        }


        static System.Runtime.Serialization.SerializationInfo
        f_1029_35010_35014_C(System.Runtime.Serialization.SerializationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1029, 34856, 35046);
            return return_v;
        }

    }
}

