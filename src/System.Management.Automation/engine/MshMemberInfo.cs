// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Management.Automation.Internal;
using System.Management.Automation.Interpreter;
using System.Management.Automation.Language;
using System.Reflection;
using System.Text;

using Microsoft.PowerShell;
using TypeTable = System.Management.Automation.Runspaces.TypeTable;

#pragma warning disable 1634, 1691 // Stops compiler from warning about unknown warnings
#pragma warning disable 56503

namespace System.Management.Automation
{

    /// <summary>
    /// Enumerates all possible types of members.
    /// </summary>
    [TypeConverterAttribute(typeof(LanguagePrimitives.EnumMultipleTypeConverter))]
    [FlagsAttribute()]
    public enum PSMemberTypes
    {
        /// <summary>
        /// An alias to another member.
        /// </summary>
        AliasProperty = 1,

        /// <summary>
        /// A property defined as a reference to a method.
        /// </summary>
        CodeProperty = 2,

        /// <summary>
        /// A property from the BaseObject.
        /// </summary>
        Property = 4,

        /// <summary>
        /// A property defined by a Name-Value pair.
        /// </summary>
        NoteProperty = 8,

        /// <summary>
        /// A property defined by script language.
        /// </summary>
        ScriptProperty = 16,

        /// <summary>
        /// A set of properties.
        /// </summary>
        PropertySet = 32,

        /// <summary>
        /// A method from the BaseObject.
        /// </summary>
        Method = 64,

        /// <summary>
        /// A method defined as a reference to another method.
        /// </summary>
        CodeMethod = 128,

        /// <summary>
        /// A method defined as a script.
        /// </summary>
        ScriptMethod = 256,

        /// <summary>
        /// A member that acts like a Property that takes parameters. This is not consider to be a property or a method.
        /// </summary>
        ParameterizedProperty = 512,

        /// <summary>
        /// A set of members.
        /// </summary>
        MemberSet = 1024,

        /// <summary>
        /// All events.
        /// </summary>
        Event = 2048,

        /// <summary>
        /// All dynamic members (where PowerShell cannot know the type of the member)
        /// </summary>
        Dynamic = 4096,

        /// <summary>
        /// Members that are inferred by type inference for PSObject and hashtable.
        /// </summary>
        InferredProperty = 8192,
        /// <summary>
        /// All property member types.
        /// </summary>
        Properties = AliasProperty | CodeProperty | Property | NoteProperty | ScriptProperty | InferredProperty,

        /// <summary>
        /// All method member types.
        /// </summary>
        Methods = CodeMethod | Method | ScriptMethod,

        /// <summary>
        /// All member types.
        /// </summary>
        All = Properties | Methods | Event | PropertySet | MemberSet | ParameterizedProperty | Dynamic
    }

    /// <summary>
    /// Enumerator for all possible views available on a PSObject.
    /// </summary>
    [TypeConverterAttribute(typeof(LanguagePrimitives.EnumMultipleTypeConverter))]
    [FlagsAttribute()]
    public enum PSMemberViewTypes
    {
        /// <summary>
        /// Extended methods / properties.
        /// </summary>
        Extended = 1,

        /// <summary>
        /// Adapted methods / properties.
        /// </summary>
        Adapted = 2,

        /// <summary>
        /// Base methods / properties.
        /// </summary>
        Base = 4,

        /// <summary>
        /// All methods / properties.
        /// </summary>
        All = Extended | Adapted | Base
    }

    /// <summary>
    /// Match options.
    /// </summary>
    [FlagsAttribute]
    internal enum MshMemberMatchOptions
    {
        /// <summary>
        /// No options.
        /// </summary>
        None = 0,

        /// <summary>
        /// Hidden members should be displayed.
        /// </summary>
        IncludeHidden = 1,

        /// <summary>
        /// Only include members with <see cref="PSMemberInfo.ShouldSerialize"/> property set to <c>true</c>
        /// </summary>
        OnlySerializable = 2
    }
    public abstract class PSMemberInfo
    {
        internal object instance;

        internal string name;

        internal bool ShouldSerialize { get; set; }

        internal virtual void ReplicateInstance(object particularInstance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 4991, 5128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 5082, 5117);

                this.instance = particularInstance;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 4991, 5128);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 4991, 5128);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 4991, 5128);
            }
        }

        internal void SetValueNoConversion(object setValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 5140, 5427);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 5216, 5352) || true) && (!(this is PSProperty thisAsProperty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 5216, 5352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 5290, 5312);

                    this.Value = setValue;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 5330, 5337);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 5216, 5352);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 5368, 5416);

                f_1292_5368_5415(
                            thisAsProperty, setValue, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 5140, 5427);

                int
                f_1292_5368_5415(System.Management.Automation.PSProperty
                this_param, object
                setValue, bool
                shouldConvert)
                {
                    this_param.SetAdaptedValue(setValue, shouldConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 5368, 5415);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 5140, 5427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 5140, 5427);
            }
        }

        protected PSMemberInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 5560, 5675);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 4886, 4894);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 4921, 4925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 4936, 4979);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 6828, 6872);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 7460, 7496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 7689, 7734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 5609, 5632);

                ShouldSerialize = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 5646, 5664);

                IsInstance = true;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 5560, 5675);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 5560, 5675);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 5560, 5675);
            }
        }

        internal void CloneBaseProperties(PSMemberInfo destiny)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 5687, 6042);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 5767, 5787);

                destiny.name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 5801, 5829);

                destiny.IsHidden = f_1292_5820_5828();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 5843, 5887);

                destiny.IsReservedMember = f_1292_5870_5886();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 5901, 5933);

                destiny.IsInstance = f_1292_5922_5932();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 5947, 5975);

                destiny.instance = instance;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 5989, 6031);

                destiny.ShouldSerialize = f_1292_6015_6030();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 5687, 6042);

                bool
                f_1292_5820_5828()
                {
                    var return_v = IsHidden;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 5820, 5828);
                    return return_v;
                }


                bool
                f_1292_5870_5886()
                {
                    var return_v = IsReservedMember;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 5870, 5886);
                    return return_v;
                }


                bool
                f_1292_5922_5932()
                {
                    var return_v = IsInstance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 5922, 5932);
                    return return_v;
                }


                bool
                f_1292_6015_6030()
                {
                    var return_v = ShouldSerialize;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 6015, 6030);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 5687, 6042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 5687, 6042);
            }
        }

        public abstract PSMemberTypes MemberType { get; }

        public string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 6298, 6310);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 6301, 6310);
                    return this.name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 6298, 6310);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 6298, 6310);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 6298, 6310);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected void SetMemberName(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 6473, 6711);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 6539, 6667) || true) && (f_1292_6543_6569(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 6539, 6667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 6603, 6652);

                    throw f_1292_6609_6651("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 6539, 6667);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 6683, 6700);

                this.name = name;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 6473, 6711);

                bool
                f_1292_6543_6569(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 6543, 6569);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1292_6609_6651(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 6609, 6651);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 6473, 6711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 6473, 6711);
            }
        }

        internal bool IsReservedMember { get; set; }

        internal bool IsHidden { get; set; }

        public bool IsInstance { get; internal set; }

        public abstract object Value { get; set; }

        public abstract string TypeNameOfValue { get; }

        public abstract PSMemberInfo Copy();

        internal bool MatchesOptions(MshMemberMatchOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 9121, 9545);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 9205, 9342) || true) && (f_1292_9209_9222(this) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 9209, 9280) && (0 == (options & MshMemberMatchOptions.IncludeHidden))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 9205, 9342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 9314, 9327);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 9205, 9342);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 9358, 9506) || true) && (f_1292_9362_9383_M(!this.ShouldSerialize) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 9362, 9444) && (0 != (options & MshMemberMatchOptions.OnlySerializable))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 9358, 9506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 9478, 9491);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 9358, 9506);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 9522, 9534);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 9121, 9545);

                bool
                f_1292_9209_9222(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.IsHidden;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 9209, 9222);
                    return return_v;
                }


                bool
                f_1292_9362_9383_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 9362, 9383);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 9121, 9545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 9121, 9545);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSMemberInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 4819, 9552);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 4819, 9552);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 4819, 9552);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 4819, 9552);
    }
    public abstract class PSPropertyInfo : PSMemberInfo
    {
        protected PSPropertyInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 9867, 9915);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 9867, 9915);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 9867, 9915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 9867, 9915);
            }
        }

        public abstract bool IsSettable { get; }

        public abstract bool IsGettable { get; }

        internal Exception NewSetValueException(Exception e, string errorId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 10230, 10499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 10323, 10488);

                return f_1292_10330_10487(errorId, e, f_1292_10408_10447(), f_1292_10466_10475(this), f_1292_10477_10486(e));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 10230, 10499);

                string
                f_1292_10408_10447()
                {
                    var return_v = ExtendedTypeSystem.ExceptionWhenSetting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 10408, 10447);
                    return return_v;
                }


                string
                f_1292_10466_10475(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 10466, 10475);
                    return return_v;
                }


                string
                f_1292_10477_10486(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 10477, 10486);
                    return return_v;
                }


                System.Management.Automation.SetValueInvocationException
                f_1292_10330_10487(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.SetValueInvocationException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 10330, 10487);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 10230, 10499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 10230, 10499);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Exception NewGetValueException(Exception e, string errorId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 10511, 10780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 10604, 10769);

                return f_1292_10611_10768(errorId, e, f_1292_10689_10728(), f_1292_10747_10756(this), f_1292_10758_10767(e));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 10511, 10780);

                string
                f_1292_10689_10728()
                {
                    var return_v = ExtendedTypeSystem.ExceptionWhenGetting;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 10689, 10728);
                    return return_v;
                }


                string
                f_1292_10747_10756(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 10747, 10756);
                    return return_v;
                }


                string
                f_1292_10758_10767(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 10758, 10767);
                    return return_v;
                }


                System.Management.Automation.GetValueInvocationException
                f_1292_10611_10768(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.GetValueInvocationException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 10611, 10768);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 10511, 10780);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 10511, 10780);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSPropertyInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 9676, 10787);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 9676, 10787);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 9676, 10787);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 9676, 10787);
    }
    public class PSAliasProperty : PSPropertyInfo
    {
        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 11306, 11816);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 11364, 11412);

                StringBuilder
                returnValue = f_1292_11392_11411()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 11426, 11456);

                f_1292_11426_11455(returnValue, f_1292_11445_11454(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 11470, 11496);

                f_1292_11470_11495(returnValue, " = ");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 11510, 11704) || true) && (f_1292_11514_11528() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 11510, 11704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 11570, 11594);

                    f_1292_11570_11593(returnValue, "(");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 11612, 11647);

                    f_1292_11612_11646(returnValue, f_1292_11631_11645());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 11665, 11689);

                    f_1292_11665_11688(returnValue, ")");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 11510, 11704);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 11720, 11761);

                f_1292_11720_11760(
                            returnValue, f_1292_11739_11759());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 11775, 11805);

                return f_1292_11782_11804(returnValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 11306, 11816);

                System.Text.StringBuilder
                f_1292_11392_11411()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 11392, 11411);
                    return return_v;
                }


                string
                f_1292_11445_11454(System.Management.Automation.PSAliasProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 11445, 11454);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_11426_11455(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 11426, 11455);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_11470_11495(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 11470, 11495);
                    return return_v;
                }


                System.Type
                f_1292_11514_11528()
                {
                    var return_v = ConversionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 11514, 11528);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_11570_11593(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 11570, 11593);
                    return return_v;
                }


                System.Type
                f_1292_11631_11645()
                {
                    var return_v = ConversionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 11631, 11645);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_11612_11646(System.Text.StringBuilder
                this_param, System.Type
                value)
                {
                    var return_v = this_param.Append((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 11612, 11646);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_11665_11688(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 11665, 11688);
                    return return_v;
                }


                string
                f_1292_11739_11759()
                {
                    var return_v = ReferencedMemberName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 11739, 11759);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_11720_11760(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 11720, 11760);
                    return return_v;
                }


                string
                f_1292_11782_11804(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 11782, 11804);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 11306, 11816);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 11306, 11816);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSAliasProperty(string name, string referencedMemberName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 12266, 12761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 14119, 14162);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 14544, 14592);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 12355, 12483) || true) && (f_1292_12359_12385(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 12355, 12483);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 12419, 12468);

                    throw f_1292_12425_12467("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 12355, 12483);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 12499, 12516);

                this.name = name;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 12530, 12690) || true) && (f_1292_12534_12576(referencedMemberName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 12530, 12690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 12610, 12675);

                    throw f_1292_12616_12674("referencedMemberName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 12530, 12690);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 12706, 12750);

                ReferencedMemberName = referencedMemberName;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 12266, 12761);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 12266, 12761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 12266, 12761);
            }
        }

        public PSAliasProperty(string name, string referencedMemberName, Type conversionType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 13376, 13997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 14119, 14162);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 14544, 14592);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 13486, 13614) || true) && (f_1292_13490_13516(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 13486, 13614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 13550, 13599);

                    throw f_1292_13556_13598("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 13486, 13614);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 13630, 13647);

                this.name = name;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 13661, 13821) || true) && (f_1292_13665_13707(referencedMemberName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 13661, 13821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 13741, 13806);

                    throw f_1292_13747_13805("referencedMemberName");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 13661, 13821);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 13837, 13881);

                ReferencedMemberName = referencedMemberName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 13954, 13986);

                ConversionType = conversionType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 13376, 13997);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 13376, 13997);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 13376, 13997);
            }
        }

        public string ReferencedMemberName { get; }

        internal PSMemberInfo ReferencedMember
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 14311, 14353);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 14314, 14353);
                    return f_1292_14314_14353(this, f_1292_14332_14352());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 14311, 14353);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 14311, 14353);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 14311, 14353);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Type ConversionType { get; private set; }

        public override PSMemberInfo Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 14858, 15105);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 14918, 15026);

                PSAliasProperty
                alias = new PSAliasProperty(name, f_1292_14968_14988()) { ConversionType = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1292_15009_15023(), 1292, 14942, 15025) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 15040, 15067);

                f_1292_15040_15066(this, alias);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 15081, 15094);

                return alias;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 14858, 15105);

                string
                f_1292_14968_14988()
                {
                    var return_v = ReferencedMemberName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 14968, 14988);
                    return return_v;
                }


                System.Type
                f_1292_15009_15023()
                {
                    var return_v = ConversionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 15009, 15023);
                    return return_v;
                }


                int
                f_1292_15040_15066(System.Management.Automation.PSAliasProperty
                this_param, System.Management.Automation.PSAliasProperty
                destiny)
                {
                    this_param.CloneBaseProperties((System.Management.Automation.PSMemberInfo)destiny);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 15040, 15066);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 14858, 15105);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 14858, 15105);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override PSMemberTypes MemberType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 15240, 15270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 15243, 15270);
                    return PSMemberTypes.AliasProperty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 15240, 15270);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 15240, 15270);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 15240, 15270);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string TypeNameOfValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 15710, 15944);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 15746, 15864) || true) && (f_1292_15750_15764() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 15746, 15864);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 15814, 15845);

                        return f_1292_15821_15844(f_1292_15821_15835());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 15746, 15864);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 15884, 15929);

                    return f_1292_15891_15928(f_1292_15891_15912(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 15710, 15944);

                    System.Type
                    f_1292_15750_15764()
                    {
                        var return_v = ConversionType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 15750, 15764);
                        return return_v;
                    }


                    System.Type
                    f_1292_15821_15835()
                    {
                        var return_v = ConversionType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 15821, 15835);
                        return return_v;
                    }


                    string
                    f_1292_15821_15844(System.Type
                    this_param)
                    {
                        var return_v = this_param.FullName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 15821, 15844);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfo
                    f_1292_15891_15912(System.Management.Automation.PSAliasProperty
                    this_param)
                    {
                        var return_v = this_param.ReferencedMember;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 15891, 15912);
                        return return_v;
                    }


                    string
                    f_1292_15891_15928(System.Management.Automation.PSMemberInfo
                    this_param)
                    {
                        var return_v = this_param.TypeNameOfValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 15891, 15928);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 15647, 15955);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 15647, 15955);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSettable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 16382, 16618);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 16418, 16570) || true) && (f_1292_16422_16443(this) is PSPropertyInfo memberProperty)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 16418, 16570);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 16518, 16551);

                        return f_1292_16525_16550(memberProperty);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 16418, 16570);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 16590, 16603);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 16382, 16618);

                    System.Management.Automation.PSMemberInfo
                    f_1292_16422_16443(System.Management.Automation.PSAliasProperty
                    this_param)
                    {
                        var return_v = this_param.ReferencedMember;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 16422, 16443);
                        return return_v;
                    }


                    bool
                    f_1292_16525_16550(System.Management.Automation.PSPropertyInfo
                    this_param)
                    {
                        var return_v = this_param.IsSettable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 16525, 16550);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 16326, 16629);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 16326, 16629);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsGettable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 17073, 17309);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 17109, 17261) || true) && (f_1292_17113_17134(this) is PSPropertyInfo memberProperty)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 17109, 17261);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 17209, 17242);

                        return f_1292_17216_17241(memberProperty);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 17109, 17261);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 17281, 17294);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 17073, 17309);

                    System.Management.Automation.PSMemberInfo
                    f_1292_17113_17134(System.Management.Automation.PSAliasProperty
                    this_param)
                    {
                        var return_v = this_param.ReferencedMember;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 17113, 17134);
                        return return_v;
                    }


                    bool
                    f_1292_17216_17241(System.Management.Automation.PSPropertyInfo
                    this_param)
                    {
                        var return_v = this_param.IsGettable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 17216, 17241);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 17017, 17320);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 17017, 17320);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private PSMemberInfo LookupMember(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 17332, 17879);
                System.Management.Automation.PSMemberInfo returnValue = default(System.Management.Automation.PSMemberInfo);
                bool hasCycle = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 17403, 17526);

                f_1292_17403_17525(this, name, f_1292_17422_17475(f_1292_17442_17474()), out returnValue, out hasCycle);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 17540, 17833) || true) && (hasCycle)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 17540, 17833);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 17586, 17818);

                    throw f_1292_17592_17817("CycleInAliasLookup", null, f_1292_17749_17780(), f_1292_17807_17816(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 17540, 17833);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 17849, 17868);

                return returnValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 17332, 17879);

                System.StringComparer
                f_1292_17442_17474()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 17442, 17474);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1292_17422_17475(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 17422, 17475);
                    return return_v;
                }


                int
                f_1292_17403_17525(System.Management.Automation.PSAliasProperty
                this_param, string
                name, System.Collections.Generic.HashSet<string>
                visitedAliases, out System.Management.Automation.PSMemberInfo
                returnedMember, out bool
                hasCycle)
                {
                    this_param.LookupMember(name, visitedAliases, out returnedMember, out hasCycle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 17403, 17525);
                    return 0;
                }


                string
                f_1292_17749_17780()
                {
                    var return_v = ExtendedTypeSystem.CycleInAlias;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 17749, 17780);
                    return return_v;
                }


                string
                f_1292_17807_17816(System.Management.Automation.PSAliasProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 17807, 17816);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1292_17592_17817(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 17592, 17817);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 17332, 17879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 17332, 17879);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LookupMember(string name, HashSet<string> visitedAliases, out PSMemberInfo returnedMember, out bool hasCycle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 17891, 19214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 18038, 18060);

                returnedMember = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 18074, 18345) || true) && (this.instance == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 18074, 18345);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 18133, 18330);

                    throw f_1292_18139_18329("AliasLookupMemberOutsidePSObject", null, f_1292_18255_18301(), name);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 18074, 18345);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 18361, 18435);

                PSMemberInfo
                member = f_1292_18383_18434(f_1292_18383_18428(f_1292_18383_18417(this.instance)), name)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 18449, 18719) || true) && (member == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 18449, 18719);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 18501, 18704);

                    throw f_1292_18507_18703("AliasLookupMemberNotPresent", null, f_1292_18640_18675(), name);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 18449, 18719);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 18735, 18912) || true) && (!(member is PSAliasProperty aliasMember))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 18735, 18912);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 18813, 18830);

                    hasCycle = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 18848, 18872);

                    returnedMember = member;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 18890, 18897);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 18735, 18912);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 18928, 19051) || true) && (f_1292_18932_18961(visitedAliases, name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 18928, 19051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 18995, 19011);

                    hasCycle = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 19029, 19036);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 18928, 19051);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 19067, 19092);

                f_1292_19067_19091(
                            visitedAliases, name);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 19106, 19203);

                f_1292_19106_19202(this, f_1292_19119_19151(aliasMember), visitedAliases, out returnedMember, out hasCycle);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 17891, 19214);

                string
                f_1292_18255_18301()
                {
                    var return_v = ExtendedTypeSystem.AccessMemberOutsidePSObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 18255, 18301);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1292_18139_18329(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 18139, 18329);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1292_18383_18417(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 18383, 18417);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1292_18383_18428(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 18383, 18428);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1292_18383_18434(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 18383, 18434);
                    return return_v;
                }


                string
                f_1292_18640_18675()
                {
                    var return_v = ExtendedTypeSystem.MemberNotPresent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 18640, 18675);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1292_18507_18703(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 18507, 18703);
                    return return_v;
                }


                bool
                f_1292_18932_18961(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 18932, 18961);
                    return return_v;
                }


                bool
                f_1292_19067_19091(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 19067, 19091);
                    return return_v;
                }


                string
                f_1292_19119_19151(System.Management.Automation.PSAliasProperty
                this_param)
                {
                    var return_v = this_param.ReferencedMemberName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 19119, 19151);
                    return return_v;
                }


                int
                f_1292_19106_19202(System.Management.Automation.PSAliasProperty
                this_param, string
                name, System.Collections.Generic.HashSet<string>
                visitedAliases, out System.Management.Automation.PSMemberInfo
                returnedMember, out bool
                hasCycle)
                {
                    this_param.LookupMember(name, visitedAliases, out returnedMember, out hasCycle);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 19106, 19202);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 17891, 19214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 17891, 19214);
            }
        }

        public override object Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 19877, 20223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 19913, 19962);

                    object
                    returnValue = f_1292_19934_19961(f_1292_19934_19955(this))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 19980, 20169) || true) && (f_1292_19984_19998() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 19980, 20169);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 20048, 20150);

                        returnValue = f_1292_20062_20149(returnValue, f_1292_20104_20118(), f_1292_20120_20148());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 19980, 20169);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 20189, 20208);

                    return returnValue;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 19877, 20223);

                    System.Management.Automation.PSMemberInfo
                    f_1292_19934_19955(System.Management.Automation.PSAliasProperty
                    this_param)
                    {
                        var return_v = this_param.ReferencedMember;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 19934, 19955);
                        return return_v;
                    }


                    object
                    f_1292_19934_19961(System.Management.Automation.PSMemberInfo
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 19934, 19961);
                        return return_v;
                    }


                    System.Type
                    f_1292_19984_19998()
                    {
                        var return_v = ConversionType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 19984, 19998);
                        return return_v;
                    }


                    System.Type
                    f_1292_20104_20118()
                    {
                        var return_v = ConversionType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 20104, 20118);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1292_20120_20148()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 20120, 20148);
                        return return_v;
                    }


                    object
                    f_1292_20062_20149(object
                    valueToConvert, System.Type
                    resultType, System.Globalization.CultureInfo
                    formatProvider)
                    {
                        var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 20062, 20149);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 19824, 20293);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 19824, 20293);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 20243, 20281);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 20246, 20281);
                    f_1292_20246_20267(this).Value = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 20243, 20281);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 19824, 20293);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 19824, 20293);
                }
            }
        }

        static PSAliasProperty()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 11073, 20345);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 11073, 20345);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 11073, 20345);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 11073, 20345);

        bool
        f_1292_12359_12385(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 12359, 12385);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_12425_12467(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 12425, 12467);
            return return_v;
        }


        bool
        f_1292_12534_12576(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 12534, 12576);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_12616_12674(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 12616, 12674);
            return return_v;
        }


        bool
        f_1292_13490_13516(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 13490, 13516);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_13556_13598(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 13556, 13598);
            return return_v;
        }


        bool
        f_1292_13665_13707(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 13665, 13707);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_13747_13805(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 13747, 13805);
            return return_v;
        }


        string
        f_1292_14332_14352()
        {
            var return_v = ReferencedMemberName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 14332, 14352);
            return return_v;
        }


        System.Management.Automation.PSMemberInfo
        f_1292_14314_14353(System.Management.Automation.PSAliasProperty
        this_param, string
        name)
        {
            var return_v = this_param.LookupMember(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 14314, 14353);
            return return_v;
        }


        System.Management.Automation.PSMemberInfo
        f_1292_20246_20267(System.Management.Automation.PSAliasProperty
        this_param)
        {
            var return_v = this_param.ReferencedMember;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 20246, 20267);
            return return_v;
        }

    }
    public class PSCodeProperty : PSPropertyInfo
    {
        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 20907, 21713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 20965, 21013);

                StringBuilder
                returnValue = f_1292_20993_21012()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 21027, 21068);

                f_1292_21027_21067(returnValue, f_1292_21046_21066(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 21082, 21106);

                f_1292_21082_21105(returnValue, " ");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 21120, 21150);

                f_1292_21120_21149(returnValue, f_1292_21139_21148(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 21164, 21188);

                f_1292_21164_21187(returnValue, "{");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 21202, 21402) || true) && (f_1292_21206_21221(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 21202, 21402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 21255, 21282);

                    f_1292_21255_21281(returnValue, "get=");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 21300, 21345);

                    f_1292_21300_21344(returnValue, f_1292_21319_21343(f_1292_21319_21338()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 21363, 21387);

                    f_1292_21363_21386(returnValue, ";");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 21202, 21402);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 21418, 21618) || true) && (f_1292_21422_21437(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 21418, 21618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 21471, 21498);

                    f_1292_21471_21497(returnValue, "set=");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 21516, 21561);

                    f_1292_21516_21560(returnValue, f_1292_21535_21559(f_1292_21535_21554()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 21579, 21603);

                    f_1292_21579_21602(returnValue, ";");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 21418, 21618);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 21634, 21658);

                f_1292_21634_21657(
                            returnValue, "}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 21672, 21702);

                return f_1292_21679_21701(returnValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 20907, 21713);

                System.Text.StringBuilder
                f_1292_20993_21012()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 20993, 21012);
                    return return_v;
                }


                string
                f_1292_21046_21066(System.Management.Automation.PSCodeProperty
                this_param)
                {
                    var return_v = this_param.TypeNameOfValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 21046, 21066);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_21027_21067(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 21027, 21067);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_21082_21105(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 21082, 21105);
                    return return_v;
                }


                string
                f_1292_21139_21148(System.Management.Automation.PSCodeProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 21139, 21148);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_21120_21149(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 21120, 21149);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_21164_21187(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 21164, 21187);
                    return return_v;
                }


                bool
                f_1292_21206_21221(System.Management.Automation.PSCodeProperty
                this_param)
                {
                    var return_v = this_param.IsGettable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 21206, 21221);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_21255_21281(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 21255, 21281);
                    return return_v;
                }


                System.Reflection.MethodInfo
                f_1292_21319_21338()
                {
                    var return_v = GetterCodeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 21319, 21338);
                    return return_v;
                }


                string
                f_1292_21319_21343(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 21319, 21343);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_21300_21344(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 21300, 21344);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_21363_21386(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 21363, 21386);
                    return return_v;
                }


                bool
                f_1292_21422_21437(System.Management.Automation.PSCodeProperty
                this_param)
                {
                    var return_v = this_param.IsSettable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 21422, 21437);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_21471_21497(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 21471, 21497);
                    return return_v;
                }


                System.Reflection.MethodInfo
                f_1292_21535_21554()
                {
                    var return_v = SetterCodeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 21535, 21554);
                    return return_v;
                }


                string
                f_1292_21535_21559(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 21535, 21559);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_21516_21560(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 21516, 21560);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_21579_21602(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 21579, 21602);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_21634_21657(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 21634, 21657);
                    return return_v;
                }


                string
                f_1292_21679_21701(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 21679, 21701);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 20907, 21713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 20907, 21713);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void SetGetterFromTypeTable(Type type, string methodName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 21854, 22708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 21945, 21978);

                MethodInfo
                methodAsMember = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 22030, 22143);

                    methodAsMember = f_1292_22047_22142(type, methodName, BindingFlags.Static | BindingFlags.Public | BindingFlags.IgnoreCase);
                }
                catch (AmbiguousMatchException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1292, 22172, 22382);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1292, 22172, 22382);
                    // Ignore the AmbiguousMatchException.
                    // We will generate error below if we cannot find exactly one match method.
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 22398, 22655) || true) && (methodAsMember == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 22398, 22655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 22458, 22640);

                    throw f_1292_22464_22639("GetterFormatFromTypeTable", null, f_1292_22595_22638());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 22398, 22655);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 22671, 22697);

                f_1292_22671_22696(this, methodAsMember);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 21854, 22708);

                System.Reflection.MethodInfo?
                f_1292_22047_22142(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetMethod(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 22047, 22142);
                    return return_v;
                }


                string
                f_1292_22595_22638()
                {
                    var return_v = ExtendedTypeSystem.CodePropertyGetterFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 22595, 22638);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1292_22464_22639(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 22464, 22639);
                    return return_v;
                }


                int
                f_1292_22671_22696(System.Management.Automation.PSCodeProperty
                this_param, System.Reflection.MethodInfo
                methodForGet)
                {
                    this_param.SetGetter(methodForGet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 22671, 22696);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 21854, 22708);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 21854, 22708);
            }
        }

        internal void SetSetterFromTypeTable(Type type, string methodName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 22848, 23723);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 22939, 22972);

                MethodInfo
                methodAsMember = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 23024, 23137);

                    methodAsMember = f_1292_23041_23136(type, methodName, BindingFlags.Static | BindingFlags.Public | BindingFlags.IgnoreCase);
                }
                catch (AmbiguousMatchException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1292, 23166, 23376);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1292, 23166, 23376);
                    // Ignore the AmbiguousMatchException.
                    // We will generate error below if we cannot find exactly one match method.
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 23392, 23649) || true) && (methodAsMember == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 23392, 23649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 23452, 23634);

                    throw f_1292_23458_23633("SetterFormatFromTypeTable", null, f_1292_23589_23632());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 23392, 23649);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 23665, 23712);

                f_1292_23665_23711(this, methodAsMember, f_1292_23691_23710());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 22848, 23723);

                System.Reflection.MethodInfo?
                f_1292_23041_23136(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetMethod(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 23041, 23136);
                    return return_v;
                }


                string
                f_1292_23589_23632()
                {
                    var return_v = ExtendedTypeSystem.CodePropertySetterFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 23589, 23632);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1292_23458_23633(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 23458, 23633);
                    return return_v;
                }


                System.Reflection.MethodInfo
                f_1292_23691_23710()
                {
                    var return_v = GetterCodeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 23691, 23710);
                    return return_v;
                }


                int
                f_1292_23665_23711(System.Management.Automation.PSCodeProperty
                this_param, System.Reflection.MethodInfo
                methodForSet, System.Reflection.MethodInfo
                methodForGet)
                {
                    this_param.SetSetter(methodForSet, methodForGet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 23665, 23711);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 22848, 23723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 22848, 23723);
            }
        }

        internal void SetGetter(MethodInfo methodForGet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 23846, 24380);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 23919, 24044) || true) && (methodForGet == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 23919, 24044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 23977, 24004);

                    GetterCodeReference = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 24022, 24029);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 23919, 24044);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 24060, 24318) || true) && (!f_1292_24065_24100(methodForGet))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 24060, 24318);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 24134, 24303);

                    throw f_1292_24140_24302("GetterFormat", null, f_1292_24258_24301());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 24060, 24318);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 24334, 24369);

                GetterCodeReference = methodForGet;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 23846, 24380);

                bool
                f_1292_24065_24100(System.Reflection.MethodInfo
                methodForGet)
                {
                    var return_v = CheckGetterMethodInfo(methodForGet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 24065, 24100);
                    return return_v;
                }


                string
                f_1292_24258_24301()
                {
                    var return_v = ExtendedTypeSystem.CodePropertyGetterFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 24258, 24301);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1292_24140_24302(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 24140, 24302);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 23846, 24380);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 23846, 24380);
            }
        }

        internal static bool CheckGetterMethodInfo(MethodInfo methodForGet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 24392, 24821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 24484, 24542);

                ParameterInfo[]
                parameters = f_1292_24513_24541(methodForGet)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 24556, 24810);

                return f_1292_24563_24584(methodForGet) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 24563, 24629) && f_1292_24608_24629(methodForGet)) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 24563, 24692) && f_1292_24653_24676(methodForGet) != typeof(void)
                ) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 24563, 24738) && f_1292_24716_24733(parameters) == 1
                ) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 24563, 24809) && f_1292_24762_24789(parameters[0]) == typeof(PSObject));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 24392, 24821);

                System.Reflection.ParameterInfo[]
                f_1292_24513_24541(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 24513, 24541);
                    return return_v;
                }


                bool
                f_1292_24563_24584(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.IsPublic
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 24563, 24584);
                    return return_v;
                }


                bool
                f_1292_24608_24629(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.IsStatic
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 24608, 24629);
                    return return_v;
                }


                System.Type
                f_1292_24653_24676(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 24653, 24676);
                    return return_v;
                }


                int
                f_1292_24716_24733(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 24716, 24733);
                    return return_v;
                }


                System.Type
                f_1292_24762_24789(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 24762, 24789);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 24392, 24821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 24392, 24821);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void SetSetter(MethodInfo methodForSet, MethodInfo methodForGet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 24944, 25822);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 25041, 25472) || true) && (methodForSet == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 25041, 25472);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 25099, 25385) || true) && (methodForGet == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 25099, 25385);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 25165, 25366);

                        throw f_1292_25171_25365("SetterAndGetterNullFormat", null, f_1292_25314_25364());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 25099, 25385);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 25405, 25432);

                    SetterCodeReference = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 25450, 25457);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 25041, 25472);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 25488, 25760) || true) && (!f_1292_25493_25542(methodForSet, methodForGet))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 25488, 25760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 25576, 25745);

                    throw f_1292_25582_25744("SetterFormat", null, f_1292_25700_25743());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 25488, 25760);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 25776, 25811);

                SetterCodeReference = methodForSet;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 24944, 25822);

                string
                f_1292_25314_25364()
                {
                    var return_v = ExtendedTypeSystem.CodePropertyGetterAndSetterNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 25314, 25364);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1292_25171_25365(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 25171, 25365);
                    return return_v;
                }


                bool
                f_1292_25493_25542(System.Reflection.MethodInfo
                methodForSet, System.Reflection.MethodInfo
                methodForGet)
                {
                    var return_v = CheckSetterMethodInfo(methodForSet, methodForGet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 25493, 25542);
                    return return_v;
                }


                string
                f_1292_25700_25743()
                {
                    var return_v = ExtendedTypeSystem.CodePropertySetterFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 25700, 25743);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1292_25582_25744(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 25582, 25744);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 24944, 25822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 24944, 25822);
            }
        }

        internal static bool CheckSetterMethodInfo(MethodInfo methodForSet, MethodInfo methodForGet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 25834, 26392);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 25951, 26009);

                ParameterInfo[]
                parameters = f_1292_25980_26008(methodForSet)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 26023, 26381);

                return f_1292_26030_26051(methodForSet) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 26030, 26096) && f_1292_26075_26096(methodForSet)) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 26030, 26159) && f_1292_26120_26143(methodForSet) == typeof(void)
                ) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 26030, 26205) && f_1292_26183_26200(parameters) == 2
                ) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 26030, 26276) && f_1292_26229_26256(parameters[0]) == typeof(PSObject)
                ) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 26030, 26380) && (methodForGet == null || (DynAbs.Tracing.TraceSender.Expression_False(1292, 26301, 26379) || f_1292_26325_26348(methodForGet) == f_1292_26352_26379(parameters[1]))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 25834, 26392);

                System.Reflection.ParameterInfo[]
                f_1292_25980_26008(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 25980, 26008);
                    return return_v;
                }


                bool
                f_1292_26030_26051(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.IsPublic
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 26030, 26051);
                    return return_v;
                }


                bool
                f_1292_26075_26096(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.IsStatic
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 26075, 26096);
                    return return_v;
                }


                System.Type
                f_1292_26120_26143(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 26120, 26143);
                    return return_v;
                }


                int
                f_1292_26183_26200(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 26183, 26200);
                    return return_v;
                }


                System.Type
                f_1292_26229_26256(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 26229, 26256);
                    return return_v;
                }


                System.Type
                f_1292_26325_26348(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 26325, 26348);
                    return return_v;
                }


                System.Type
                f_1292_26352_26379(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 26352, 26379);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 25834, 26392);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 25834, 26392);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PSCodeProperty(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 26520, 26753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 29531, 29590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 29729, 29788);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 26581, 26709) || true) && (f_1292_26585_26611(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 26581, 26709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 26645, 26694);

                    throw f_1292_26651_26693("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 26581, 26709);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 26725, 26742);

                this.name = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 26520, 26753);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 26520, 26753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 26520, 26753);
            }
        }

        public PSCodeProperty(string name, MethodInfo getterCodeReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 27343, 27815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 29531, 29590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 29729, 29788);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 27434, 27562) || true) && (f_1292_27438_27464(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 27434, 27562);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 27498, 27547);

                    throw f_1292_27504_27546("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 27434, 27562);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 27578, 27595);

                this.name = name;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 27609, 27757) || true) && (getterCodeReference == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 27609, 27757);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 27674, 27742);

                    throw f_1292_27680_27741("getterCodeReference");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 27609, 27757);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 27773, 27804);

                f_1292_27773_27803(this, getterCodeReference);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 27343, 27815);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 27343, 27815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 27343, 27815);
            }
        }

        public PSCodeProperty(string name, MethodInfo getterCodeReference, MethodInfo setterCodeReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 28771, 29392);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 29531, 29590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 29729, 29788);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 28894, 29022) || true) && (f_1292_28898_28924(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 28894, 29022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 28958, 29007);

                    throw f_1292_28964_29006("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 28894, 29022);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 29038, 29055);

                this.name = name;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 29069, 29268) || true) && (getterCodeReference == null && (DynAbs.Tracing.TraceSender.Expression_True(1292, 29073, 29131) && setterCodeReference == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 29069, 29268);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 29165, 29253);

                    throw f_1292_29171_29252("getterCodeReference setterCodeReference");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 29069, 29268);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 29284, 29315);

                f_1292_29284_29314(this, getterCodeReference);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 29329, 29381);

                f_1292_29329_29380(this, setterCodeReference, getterCodeReference);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 28771, 29392);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 28771, 29392);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 28771, 29392);
            }
        }

        public MethodInfo GetterCodeReference { get; private set; }

        public MethodInfo SetterCodeReference { get; private set; }

        public override PSMemberInfo Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 30054, 30292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 30114, 30207);

                PSCodeProperty
                property = f_1292_30140_30206(name, f_1292_30165_30184(), f_1292_30186_30205())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 30221, 30251);

                f_1292_30221_30250(this, property);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 30265, 30281);

                return property;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 30054, 30292);

                System.Reflection.MethodInfo
                f_1292_30165_30184()
                {
                    var return_v = GetterCodeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 30165, 30184);
                    return return_v;
                }


                System.Reflection.MethodInfo
                f_1292_30186_30205()
                {
                    var return_v = SetterCodeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 30186, 30205);
                    return return_v;
                }


                System.Management.Automation.PSCodeProperty
                f_1292_30140_30206(string
                name, System.Reflection.MethodInfo
                getterCodeReference, System.Reflection.MethodInfo
                setterCodeReference)
                {
                    var return_v = new System.Management.Automation.PSCodeProperty(name, getterCodeReference, setterCodeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 30140, 30206);
                    return return_v;
                }


                int
                f_1292_30221_30250(System.Management.Automation.PSCodeProperty
                this_param, System.Management.Automation.PSCodeProperty
                destiny)
                {
                    this_param.CloneBaseProperties((System.Management.Automation.PSMemberInfo)destiny);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 30221, 30250);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 30054, 30292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 30054, 30292);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override PSMemberTypes MemberType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 30427, 30456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 30430, 30456);
                    return PSMemberTypes.CodeProperty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 30427, 30456);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 30427, 30456);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 30427, 30456);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSettable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 30600, 30635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 30603, 30635);
                    return f_1292_30603_30627(this) != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 30600, 30635);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 30600, 30635);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 30600, 30635);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsGettable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 30780, 30810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 30783, 30810);
                    return f_1292_30783_30802() != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 30780, 30810);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 30780, 30810);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 30780, 30810);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override object Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 31250, 32711);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 31286, 31611) || true) && (f_1292_31290_31309() == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 31286, 31611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 31359, 31592);

                        throw f_1292_31365_31591("GetWithoutGetterFromCodePropertyValue", null, f_1292_31510_31554(), f_1292_31581_31590(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 31286, 31611);
                    }

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 31675, 31747);

                        return f_1292_31682_31746(f_1292_31682_31701(), null, new object[] { this.instance });
                    }
                    catch (TargetInvocationException ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1292, 31784, 32212);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 31861, 31903);

                        Exception
                        inner = f_1292_31879_31896(ex) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Exception>(1292, 31879, 31902) ?? ex)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 31925, 32193);

                        throw f_1292_31931_32192("CatchFromCodePropertyGetTI", inner, f_1292_32076_32115(), this.name, f_1292_32178_32191(inner));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1292, 31784, 32212);
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1292, 32230, 32696);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 32290, 32395) || true) && (e is GetValueException)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 32290, 32395);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 32366, 32372);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 32290, 32395);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 32419, 32677);

                        throw f_1292_32425_32676("CatchFromCodePropertyGet", e, f_1292_32564_32603(), this.name, f_1292_32666_32675(e));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1292, 32230, 32696);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 31250, 32711);

                    System.Reflection.MethodInfo
                    f_1292_31290_31309()
                    {
                        var return_v = GetterCodeReference;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 31290, 31309);
                        return return_v;
                    }


                    string
                    f_1292_31510_31554()
                    {
                        var return_v = ExtendedTypeSystem.GetWithoutGetterException;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 31510, 31554);
                        return return_v;
                    }


                    string
                    f_1292_31581_31590(System.Management.Automation.PSCodeProperty
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 31581, 31590);
                        return return_v;
                    }


                    System.Management.Automation.GetValueException
                    f_1292_31365_31591(string
                    errorId, System.Exception
                    innerException, string
                    resourceString, params object[]
                    arguments)
                    {
                        var return_v = new System.Management.Automation.GetValueException(errorId, innerException, resourceString, arguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 31365, 31591);
                        return return_v;
                    }


                    System.Reflection.MethodInfo
                    f_1292_31682_31701()
                    {
                        var return_v = GetterCodeReference;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 31682, 31701);
                        return return_v;
                    }


                    object?
                    f_1292_31682_31746(System.Reflection.MethodInfo
                    this_param, object?
                    obj, object[]
                    parameters)
                    {
                        var return_v = this_param.Invoke(obj, parameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 31682, 31746);
                        return return_v;
                    }


                    System.Exception
                    f_1292_31879_31896(System.Reflection.TargetInvocationException
                    this_param)
                    {
                        var return_v = this_param.InnerException;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 31879, 31896);
                        return return_v;
                    }


                    string
                    f_1292_32076_32115()
                    {
                        var return_v = ExtendedTypeSystem.ExceptionWhenGetting;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 32076, 32115);
                        return return_v;
                    }


                    string
                    f_1292_32178_32191(System.Exception
                    this_param)
                    {
                        var return_v = this_param.Message;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 32178, 32191);
                        return return_v;
                    }


                    System.Management.Automation.GetValueInvocationException
                    f_1292_31931_32192(string
                    errorId, System.Exception
                    innerException, string
                    resourceString, params object[]
                    arguments)
                    {
                        var return_v = new System.Management.Automation.GetValueInvocationException(errorId, innerException, resourceString, arguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 31931, 32192);
                        return return_v;
                    }


                    string
                    f_1292_32564_32603()
                    {
                        var return_v = ExtendedTypeSystem.ExceptionWhenGetting;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 32564, 32603);
                        return return_v;
                    }


                    string
                    f_1292_32666_32675(System.Exception
                    this_param)
                    {
                        var return_v = this_param.Message;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 32666, 32675);
                        return return_v;
                    }


                    System.Management.Automation.GetValueInvocationException
                    f_1292_32425_32676(string
                    errorId, System.Exception
                    innerException, string
                    resourceString, params object[]
                    arguments)
                    {
                        var return_v = new System.Management.Automation.GetValueInvocationException(errorId, innerException, resourceString, arguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 32425, 32676);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 31197, 34194);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 31197, 34194);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 32727, 34183);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 32763, 33083) || true) && (f_1292_32767_32786() == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 32763, 33083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 32836, 33064);

                        throw f_1292_32842_33063("SetWithoutSetterFromCodeProperty", null, f_1292_32982_33026(), f_1292_33053_33062(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 32763, 33083);
                    }

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 33147, 33219);

                        f_1292_33147_33218(f_1292_33147_33166(), null, new object[] { this.instance, value });
                    }
                    catch (TargetInvocationException ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1292, 33256, 33684);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 33333, 33375);

                        Exception
                        inner = f_1292_33351_33368(ex) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Exception>(1292, 33351, 33374) ?? ex)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 33397, 33665);

                        throw f_1292_33403_33664("CatchFromCodePropertySetTI", inner, f_1292_33548_33587(), this.name, f_1292_33650_33663(inner));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1292, 33256, 33684);
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1292, 33702, 34168);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 33762, 33867) || true) && (e is SetValueException)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 33762, 33867);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 33838, 33844);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 33762, 33867);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 33891, 34149);

                        throw f_1292_33897_34148("CatchFromCodePropertySet", e, f_1292_34036_34075(), this.name, f_1292_34138_34147(e));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1292, 33702, 34168);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 32727, 34183);

                    System.Reflection.MethodInfo
                    f_1292_32767_32786()
                    {
                        var return_v = SetterCodeReference;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 32767, 32786);
                        return return_v;
                    }


                    string
                    f_1292_32982_33026()
                    {
                        var return_v = ExtendedTypeSystem.SetWithoutSetterException;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 32982, 33026);
                        return return_v;
                    }


                    string
                    f_1292_33053_33062(System.Management.Automation.PSCodeProperty
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 33053, 33062);
                        return return_v;
                    }


                    System.Management.Automation.SetValueException
                    f_1292_32842_33063(string
                    errorId, System.Exception
                    innerException, string
                    resourceString, params object[]
                    arguments)
                    {
                        var return_v = new System.Management.Automation.SetValueException(errorId, innerException, resourceString, arguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 32842, 33063);
                        return return_v;
                    }


                    System.Reflection.MethodInfo
                    f_1292_33147_33166()
                    {
                        var return_v = SetterCodeReference;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 33147, 33166);
                        return return_v;
                    }


                    object?
                    f_1292_33147_33218(System.Reflection.MethodInfo
                    this_param, object?
                    obj, object[]
                    parameters)
                    {
                        var return_v = this_param.Invoke(obj, parameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 33147, 33218);
                        return return_v;
                    }


                    System.Exception
                    f_1292_33351_33368(System.Reflection.TargetInvocationException
                    this_param)
                    {
                        var return_v = this_param.InnerException;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 33351, 33368);
                        return return_v;
                    }


                    string
                    f_1292_33548_33587()
                    {
                        var return_v = ExtendedTypeSystem.ExceptionWhenSetting;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 33548, 33587);
                        return return_v;
                    }


                    string
                    f_1292_33650_33663(System.Exception
                    this_param)
                    {
                        var return_v = this_param.Message;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 33650, 33663);
                        return return_v;
                    }


                    System.Management.Automation.SetValueInvocationException
                    f_1292_33403_33664(string
                    errorId, System.Exception
                    innerException, string
                    resourceString, params object[]
                    arguments)
                    {
                        var return_v = new System.Management.Automation.SetValueInvocationException(errorId, innerException, resourceString, arguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 33403, 33664);
                        return return_v;
                    }


                    string
                    f_1292_34036_34075()
                    {
                        var return_v = ExtendedTypeSystem.ExceptionWhenSetting;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 34036, 34075);
                        return return_v;
                    }


                    string
                    f_1292_34138_34147(System.Exception
                    this_param)
                    {
                        var return_v = this_param.Message;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 34138, 34147);
                        return return_v;
                    }


                    System.Management.Automation.SetValueInvocationException
                    f_1292_33897_34148(string
                    errorId, System.Exception
                    innerException, string
                    resourceString, params object[]
                    arguments)
                    {
                        var return_v = new System.Management.Automation.SetValueInvocationException(errorId, innerException, resourceString, arguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 33897, 34148);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 31197, 34194);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 31197, 34194);
                }
            }
        }

        public override string TypeNameOfValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 34466, 34915);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 34502, 34833) || true) && (f_1292_34506_34525() == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 34502, 34833);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 34575, 34814);

                        throw f_1292_34581_34813("GetWithoutGetterFromCodePropertyTypeOfValue", null, f_1292_34732_34776(), f_1292_34803_34812(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 34502, 34833);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 34853, 34900);

                    return f_1292_34860_34899(f_1292_34860_34890(f_1292_34860_34879()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 34466, 34915);

                    System.Reflection.MethodInfo
                    f_1292_34506_34525()
                    {
                        var return_v = GetterCodeReference;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 34506, 34525);
                        return return_v;
                    }


                    string
                    f_1292_34732_34776()
                    {
                        var return_v = ExtendedTypeSystem.GetWithoutGetterException;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 34732, 34776);
                        return return_v;
                    }


                    string
                    f_1292_34803_34812(System.Management.Automation.PSCodeProperty
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 34803, 34812);
                        return return_v;
                    }


                    System.Management.Automation.GetValueException
                    f_1292_34581_34813(string
                    errorId, System.Exception
                    innerException, string
                    resourceString, params object[]
                    arguments)
                    {
                        var return_v = new System.Management.Automation.GetValueException(errorId, innerException, resourceString, arguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 34581, 34813);
                        return return_v;
                    }


                    System.Reflection.MethodInfo
                    f_1292_34860_34879()
                    {
                        var return_v = GetterCodeReference;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 34860, 34879);
                        return return_v;
                    }


                    System.Type
                    f_1292_34860_34890(System.Reflection.MethodInfo
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 34860, 34890);
                        return return_v;
                    }


                    string
                    f_1292_34860_34899(System.Type
                    this_param)
                    {
                        var return_v = this_param.FullName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 34860, 34899);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 34403, 34926);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 34403, 34926);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PSCodeProperty()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 20675, 34978);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 20675, 34978);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 20675, 34978);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 20675, 34978);

        bool
        f_1292_26585_26611(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 26585, 26611);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_26651_26693(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 26651, 26693);
            return return_v;
        }


        bool
        f_1292_27438_27464(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 27438, 27464);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_27504_27546(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 27504, 27546);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1292_27680_27741(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 27680, 27741);
            return return_v;
        }


        int
        f_1292_27773_27803(System.Management.Automation.PSCodeProperty
        this_param, System.Reflection.MethodInfo
        methodForGet)
        {
            this_param.SetGetter(methodForGet);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 27773, 27803);
            return 0;
        }


        bool
        f_1292_28898_28924(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 28898, 28924);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_28964_29006(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 28964, 29006);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1292_29171_29252(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 29171, 29252);
            return return_v;
        }


        int
        f_1292_29284_29314(System.Management.Automation.PSCodeProperty
        this_param, System.Reflection.MethodInfo
        methodForGet)
        {
            this_param.SetGetter(methodForGet);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 29284, 29314);
            return 0;
        }


        int
        f_1292_29329_29380(System.Management.Automation.PSCodeProperty
        this_param, System.Reflection.MethodInfo
        methodForSet, System.Reflection.MethodInfo
        methodForGet)
        {
            this_param.SetSetter(methodForSet, methodForGet);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 29329, 29380);
            return 0;
        }


        System.Reflection.MethodInfo
        f_1292_30603_30627(System.Management.Automation.PSCodeProperty
        this_param)
        {
            var return_v = this_param.SetterCodeReference;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 30603, 30627);
            return return_v;
        }


        System.Reflection.MethodInfo
        f_1292_30783_30802()
        {
            var return_v = GetterCodeReference;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 30783, 30802);
            return return_v;
        }

    }
    internal class PSInferredProperty : PSPropertyInfo
    {
        public PSInferredProperty(string name, PSTypeName typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 35175, 35321);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 35333, 35370);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 35469, 35511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 35259, 35276);

                this.name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 35290, 35310);

                TypeName = typeName;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 35175, 35321);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 35175, 35321);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 35175, 35321);
            }
        }

        internal PSTypeName TypeName { get; }

        public override PSMemberTypes MemberType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 35423, 35456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 35426, 35456);
                    return PSMemberTypes.InferredProperty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 35423, 35456);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 35423, 35456);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 35423, 35456);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override object Value { get; set; }

        public override string TypeNameOfValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 35562, 35578);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 35565, 35578);
                    return f_1292_35565_35578(f_1292_35565_35573());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 35562, 35578);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 35562, 35578);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 35562, 35578);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override PSMemberInfo Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 35627, 35668);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 35630, 35668);
                return f_1292_35630_35668(f_1292_35653_35657(), f_1292_35659_35667());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 35627, 35668);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 35627, 35668);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 35627, 35668);
            }
            throw new System.Exception("Slicer error: unreachable code");

            string
            f_1292_35653_35657()
            {
                var return_v = Name;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 35653, 35657);
                return return_v;
            }


            System.Management.Automation.PSTypeName
            f_1292_35659_35667()
            {
                var return_v = TypeName;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 35659, 35667);
                return return_v;
            }


            System.Management.Automation.PSInferredProperty
            f_1292_35630_35668(string
            name, System.Management.Automation.PSTypeName
            typeName)
            {
                var return_v = new System.Management.Automation.PSInferredProperty(name, typeName);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 35630, 35668);
                return return_v;
            }

        }

        public override bool IsSettable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 35713, 35721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 35716, 35721);
                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 35713, 35721);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 35713, 35721);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 35713, 35721);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsGettable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 35766, 35774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 35769, 35774);
                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 35766, 35774);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 35766, 35774);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 35766, 35774);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 35821, 35875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 35824, 35875);
                return $"{f_1292_35827_35866(f_1292_35852_35865(f_1292_35852_35860()))} {f_1292_35869_35873()}";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 35821, 35875);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 35821, 35875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 35821, 35875);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Management.Automation.PSTypeName
            f_1292_35852_35860()
            {
                var return_v = TypeName;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 35852, 35860);
                return return_v;
            }


            System.Type
            f_1292_35852_35865(System.Management.Automation.PSTypeName
            this_param)
            {
                var return_v = this_param.Type;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 35852, 35865);
                return return_v;
            }


            string
            f_1292_35827_35866(System.Type
            type)
            {
                var return_v = ToStringCodeMethods.Type(type);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 35827, 35866);
                return return_v;
            }


            string
            f_1292_35869_35873()
            {
                var return_v = Name;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 35869, 35873);
                return return_v;
            }

        }

        static PSInferredProperty()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 35108, 35883);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 35108, 35883);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 35108, 35883);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 35108, 35883);

        System.Management.Automation.PSTypeName
        f_1292_35565_35573()
        {
            var return_v = TypeName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 35565, 35573);
            return return_v;
        }


        string
        f_1292_35565_35578(System.Management.Automation.PSTypeName
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 35565, 35578);
            return return_v;
        }

    }
    public class PSProperty : PSPropertyInfo
    {
        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 36234, 36792);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 36292, 36571) || true) && (this.isDeserialized)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 36292, 36571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 36349, 36397);

                    StringBuilder
                    returnValue = f_1292_36377_36396()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 36415, 36456);

                    f_1292_36415_36455(returnValue, f_1292_36434_36454(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 36474, 36508);

                    f_1292_36474_36507(returnValue, " {get;set;}");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 36526, 36556);

                    return f_1292_36533_36555(returnValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 36292, 36571);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 36587, 36725);

                f_1292_36587_36724((this.baseObject != null) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 36606, 36657) && (this.adapter != null)), "if it is deserialized, it should have all these properties set");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 36739, 36781);

                return f_1292_36746_36780(adapter, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 36234, 36792);

                System.Text.StringBuilder
                f_1292_36377_36396()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 36377, 36396);
                    return return_v;
                }


                string
                f_1292_36434_36454(System.Management.Automation.PSProperty
                this_param)
                {
                    var return_v = this_param.TypeNameOfValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 36434, 36454);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_36415_36455(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 36415, 36455);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_36474_36507(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 36474, 36507);
                    return return_v;
                }


                string
                f_1292_36533_36555(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 36533, 36555);
                    return return_v;
                }


                int
                f_1292_36587_36724(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 36587, 36724);
                    return 0;
                }


                string
                f_1292_36746_36780(System.Management.Automation.Adapter
                this_param, System.Management.Automation.PSProperty
                property)
                {
                    var return_v = this_param.BasePropertyToString(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 36746, 36780);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 36234, 36792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 36234, 36792);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string typeOfValue;

        internal object serializedValue;

        internal bool isDeserialized;

        internal Adapter adapter;

        internal object adapterData;

        internal object baseObject;

        internal PSProperty(string name, object serializedValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 37582, 37785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 36997, 37008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 37037, 37052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 37077, 37091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 37242, 37249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 37278, 37289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 37316, 37326);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 37663, 37690);

                this.isDeserialized = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 37704, 37743);

                this.serializedValue = serializedValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 37757, 37774);

                this.name = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 37582, 37785);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 37582, 37785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 37582, 37785);
            }
        }

        internal PSProperty(string name, Adapter adapter, object baseObject, object adapterData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 38251, 38661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 36997, 37008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 37037, 37052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 37077, 37091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 37242, 37249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 37278, 37289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 37316, 37326);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 38364, 38492) || true) && (f_1292_38368_38394(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 38364, 38492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 38428, 38477);

                    throw f_1292_38434_38476("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 38364, 38492);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 38508, 38525);

                this.name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 38539, 38562);

                this.adapter = adapter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 38576, 38607);

                this.adapterData = adapterData;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 38621, 38650);

                this.baseObject = baseObject;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 38251, 38661);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 38251, 38661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 38251, 38661);
            }
        }

        public override PSMemberInfo Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 38927, 39345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 38987, 39084);

                PSProperty
                property = f_1292_39009_39083(this.name, this.adapter, this.baseObject, this.adapterData)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 39098, 39128);

                f_1292_39098_39127(this, property);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 39142, 39182);

                property.typeOfValue = this.typeOfValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 39196, 39244);

                property.serializedValue = this.serializedValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 39258, 39304);

                property.isDeserialized = this.isDeserialized;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 39318, 39334);

                return property;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 38927, 39345);

                System.Management.Automation.PSProperty
                f_1292_39009_39083(string
                name, System.Management.Automation.Adapter
                adapter, object
                baseObject, object
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSProperty(name, adapter, baseObject, adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 39009, 39083);
                    return return_v;
                }


                int
                f_1292_39098_39127(System.Management.Automation.PSProperty
                this_param, System.Management.Automation.PSProperty
                destiny)
                {
                    this_param.CloneBaseProperties((System.Management.Automation.PSMemberInfo)destiny);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 39098, 39127);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 38927, 39345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 38927, 39345);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override PSMemberTypes MemberType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 39480, 39505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 39483, 39505);
                    return PSMemberTypes.Property;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 39480, 39505);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 39480, 39505);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 39480, 39505);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private object GetAdaptedValue()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 39518, 39915);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 39575, 39670) || true) && (this.isDeserialized)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 39575, 39670);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 39632, 39655);

                    return serializedValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 39575, 39670);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 39686, 39824);

                f_1292_39686_39823((this.baseObject != null) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 39705, 39756) && (this.adapter != null)), "if it is deserialized, it should have all these properties set");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 39840, 39881);

                object
                o = f_1292_39851_39880(adapter, this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 39895, 39904);

                return o;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 39518, 39915);

                int
                f_1292_39686_39823(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 39686, 39823);
                    return 0;
                }


                object
                f_1292_39851_39880(System.Management.Automation.Adapter
                this_param, System.Management.Automation.PSProperty
                property)
                {
                    var return_v = this_param.BasePropertyGet(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 39851, 39880);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 39518, 39915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 39518, 39915);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void SetAdaptedValue(object setValue, bool shouldConvert)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 39927, 40376);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 40018, 40142) || true) && (this.isDeserialized)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 40018, 40142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 40075, 40102);

                    serializedValue = setValue;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 40120, 40127);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 40018, 40142);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 40158, 40296);

                f_1292_40158_40295((this.baseObject != null) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 40177, 40228) && (this.adapter != null)), "if it is deserialized, it should have all these properties set");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 40310, 40365);

                f_1292_40310_40364(adapter, this, setValue, shouldConvert);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 39927, 40376);

                int
                f_1292_40158_40295(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 40158, 40295);
                    return 0;
                }


                int
                f_1292_40310_40364(System.Management.Automation.Adapter
                this_param, System.Management.Automation.PSProperty
                property, object
                setValue, bool
                convert)
                {
                    this_param.BasePropertySet(property, setValue, convert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 40310, 40364);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 39927, 40376);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 39927, 40376);
            }
        }

        public override object Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 40784, 40804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 40787, 40804);
                    return f_1292_40787_40804(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 40784, 40804);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 40727, 40866);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 40727, 40866);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 40823, 40854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 40826, 40854);
                    f_1292_40826_40854(this, value, true);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 40823, 40854);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 40727, 40866);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 40727, 40866);
                }
            }
        }

        public override bool IsSettable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 41033, 41400);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 41069, 41165) || true) && (this.isDeserialized)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 41069, 41165);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 41134, 41146);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 41069, 41165);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 41185, 41323);

                    f_1292_41185_41322((this.baseObject != null) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 41204, 41255) && (this.adapter != null)), "if it is deserialized, it should have all these properties set");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 41341, 41385);

                    return f_1292_41348_41384(adapter, this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 41033, 41400);

                    int
                    f_1292_41185_41322(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 41185, 41322);
                        return 0;
                    }


                    bool
                    f_1292_41348_41384(System.Management.Automation.Adapter
                    this_param, System.Management.Automation.PSProperty
                    property)
                    {
                        var return_v = this_param.BasePropertyIsSettable(property);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 41348, 41384);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 40977, 41411);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 40977, 41411);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsGettable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 41579, 41946);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 41615, 41711) || true) && (this.isDeserialized)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 41615, 41711);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 41680, 41692);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 41615, 41711);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 41731, 41869);

                    f_1292_41731_41868((this.baseObject != null) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 41750, 41801) && (this.adapter != null)), "if it is deserialized, it should have all these properties set");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 41887, 41931);

                    return f_1292_41894_41930(adapter, this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 41579, 41946);

                    int
                    f_1292_41731_41868(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 41731, 41868);
                        return 0;
                    }


                    bool
                    f_1292_41894_41930(System.Management.Automation.Adapter
                    this_param, System.Management.Automation.PSProperty
                    property)
                    {
                        var return_v = this_param.BasePropertyIsGettable(property);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 41894, 41930);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 41523, 41957);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 41523, 41957);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string TypeNameOfValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 42136, 43303);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 42172, 43074) || true) && (this.isDeserialized)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 42172, 43074);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 42237, 42357) || true) && (serializedValue == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 42237, 42357);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 42314, 42334);

                            return string.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 42237, 42357);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 42381, 42989) || true) && (serializedValue is PSObject serializedValueAsPSObject)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 42381, 42989);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 42488, 42548);

                            var
                            typeNames = f_1292_42504_42547(serializedValueAsPSObject)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 42574, 42966) || true) && ((typeNames != null) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 42578, 42623) && (f_1292_42602_42617(typeNames) >= 1)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 42574, 42966);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 42919, 42939);

                                return f_1292_42926_42938(typeNames, 0);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 42574, 42966);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 42381, 42989);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 43013, 43055);

                        return f_1292_43020_43054(f_1292_43020_43045(serializedValue));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 42172, 43074);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 43094, 43232);

                    f_1292_43094_43231((this.baseObject != null) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 43113, 43164) && (this.adapter != null)), "if it is deserialized, it should have all these properties set");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 43250, 43288);

                    return f_1292_43257_43287(adapter, this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 42136, 43303);

                    System.Management.Automation.Runspaces.ConsolidatedString
                    f_1292_42504_42547(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.InternalTypeNames;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 42504, 42547);
                        return return_v;
                    }


                    int
                    f_1292_42602_42617(System.Management.Automation.Runspaces.ConsolidatedString
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 42602, 42617);
                        return return_v;
                    }


                    string
                    f_1292_42926_42938(System.Management.Automation.Runspaces.ConsolidatedString
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 42926, 42938);
                        return return_v;
                    }


                    System.Type
                    f_1292_43020_43045(object
                    this_param)
                    {
                        var return_v = this_param.GetType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 43020, 43045);
                        return return_v;
                    }


                    string
                    f_1292_43020_43054(System.Type
                    this_param)
                    {
                        var return_v = this_param.FullName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 43020, 43054);
                        return return_v;
                    }


                    int
                    f_1292_43094_43231(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 43094, 43231);
                        return 0;
                    }


                    string
                    f_1292_43257_43287(System.Management.Automation.Adapter
                    this_param, System.Management.Automation.PSProperty
                    property)
                    {
                        var return_v = this_param.BasePropertyType(property);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 43257, 43287);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 42073, 43314);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 42073, 43314);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PSProperty()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 36006, 43366);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 36006, 43366);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 36006, 43366);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 36006, 43366);

        bool
        f_1292_38368_38394(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 38368, 38394);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_38434_38476(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 38434, 38476);
            return return_v;
        }


        object
        f_1292_40787_40804(System.Management.Automation.PSProperty
        this_param)
        {
            var return_v = this_param.GetAdaptedValue();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 40787, 40804);
            return return_v;
        }


        int
        f_1292_40826_40854(System.Management.Automation.PSProperty
        this_param, object
        setValue, bool
        shouldConvert)
        {
            this_param.SetAdaptedValue(setValue, shouldConvert);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 40826, 40854);
            return 0;
        }

    }
    public class PSAdaptedProperty : PSProperty
    {
        public PSAdaptedProperty(string name, object tag)
        : base(f_1292_43967_43971_C(name), null, null, tag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 43897, 44194);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 43897, 44194);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 43897, 44194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 43897, 44194);
            }
        }

        internal PSAdaptedProperty(string name, Adapter adapter, object baseObject, object adapterData)
        : base(f_1292_44322_44326_C(name), adapter, baseObject, adapterData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 44206, 44383);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 44206, 44383);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 44206, 44383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 44206, 44383);
            }
        }

        public override PSMemberInfo Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 44481, 44913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 44541, 44652);

                PSAdaptedProperty
                property = f_1292_44570_44651(this.name, this.adapter, this.baseObject, this.adapterData)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 44666, 44696);

                f_1292_44666_44695(this, property);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 44710, 44750);

                property.typeOfValue = this.typeOfValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 44764, 44812);

                property.serializedValue = this.serializedValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 44826, 44872);

                property.isDeserialized = this.isDeserialized;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 44886, 44902);

                return property;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 44481, 44913);

                System.Management.Automation.PSAdaptedProperty
                f_1292_44570_44651(string
                name, System.Management.Automation.Adapter
                adapter, object
                baseObject, object
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSAdaptedProperty(name, adapter, baseObject, adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 44570, 44651);
                    return return_v;
                }


                int
                f_1292_44666_44695(System.Management.Automation.PSAdaptedProperty
                this_param, System.Management.Automation.PSAdaptedProperty
                destiny)
                {
                    this_param.CloneBaseProperties((System.Management.Automation.PSMemberInfo)destiny);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 44666, 44695);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 44481, 44913);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 44481, 44913);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object BaseObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 45051, 45069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 45054, 45069);
                    return this.baseObject;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 45051, 45069);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 45051, 45069);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 45051, 45069);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public object Tag
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 45201, 45220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 45204, 45220);
                    return this.adapterData;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 45201, 45220);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 45201, 45220);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 45201, 45220);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PSAdaptedProperty()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 43478, 45228);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 43478, 45228);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 43478, 45228);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 43478, 45228);

        static string
        f_1292_43967_43971_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1292, 43897, 44194);
            return return_v;
        }


        static string
        f_1292_44322_44326_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1292, 44206, 44383);
            return return_v;
        }

    }
    public class PSNoteProperty : PSPropertyInfo
    {
        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 45571, 46020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 45629, 45677);

                StringBuilder
                returnValue = f_1292_45657_45676()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 45693, 45751);

                f_1292_45693_45750(
                            returnValue, f_1292_45712_45749(f_1292_45738_45748(this)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 45765, 45789);

                f_1292_45765_45788(returnValue, " ");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 45803, 45833);

                f_1292_45803_45832(returnValue, f_1292_45822_45831(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 45847, 45871);

                f_1292_45847_45870(returnValue, "=");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 45885, 45965);

                f_1292_45885_45964(returnValue, (DynAbs.Tracing.TraceSender.Conditional_F1(1292, 45904, 45926) || ((this.noteValue == null && DynAbs.Tracing.TraceSender.Conditional_F2(1292, 45929, 45935)) || DynAbs.Tracing.TraceSender.Conditional_F3(1292, 45938, 45963))) ? "null" : f_1292_45938_45963(this.noteValue));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 45979, 46009);

                return f_1292_45986_46008(returnValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 45571, 46020);

                System.Text.StringBuilder
                f_1292_45657_45676()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 45657, 45676);
                    return return_v;
                }


                object
                f_1292_45738_45748(System.Management.Automation.PSNoteProperty
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 45738, 45748);
                    return return_v;
                }


                string
                f_1292_45712_45749(object
                val)
                {
                    var return_v = GetDisplayTypeNameOfValue(val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 45712, 45749);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_45693_45750(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 45693, 45750);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_45765_45788(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 45765, 45788);
                    return return_v;
                }


                string
                f_1292_45822_45831(System.Management.Automation.PSNoteProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 45822, 45831);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_45803_45832(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 45803, 45832);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_45847_45870(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 45847, 45870);
                    return return_v;
                }


                string?
                f_1292_45938_45963(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 45938, 45963);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_45885_45964(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 45885, 45964);
                    return return_v;
                }


                string
                f_1292_45986_46008(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 45986, 46008);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 45571, 46020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 45571, 46020);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object noteValue;

        public PSNoteProperty(string name, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 46400, 46716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 46048, 46057);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 46473, 46601) || true) && (f_1292_46477_46503(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 46473, 46601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 46537, 46586);

                    throw f_1292_46543_46585("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 46473, 46601);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 46617, 46634);

                this.name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 46682, 46705);

                this.noteValue = value;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 46400, 46716);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 46400, 46716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 46400, 46716);
            }
        }

        public override PSMemberInfo Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 46982, 47199);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 47042, 47114);

                PSNoteProperty
                property = f_1292_47068_47113(this.name, this.noteValue)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 47128, 47158);

                f_1292_47128_47157(this, property);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 47172, 47188);

                return property;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 46982, 47199);

                System.Management.Automation.PSNoteProperty
                f_1292_47068_47113(string
                name, object
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 47068, 47113);
                    return return_v;
                }


                int
                f_1292_47128_47157(System.Management.Automation.PSNoteProperty
                this_param, System.Management.Automation.PSNoteProperty
                destiny)
                {
                    this_param.CloneBaseProperties((System.Management.Automation.PSMemberInfo)destiny);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 47128, 47157);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 46982, 47199);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 46982, 47199);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override PSMemberTypes MemberType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 47345, 47374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 47348, 47374);
                    return PSMemberTypes.NoteProperty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 47345, 47374);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 47345, 47374);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 47345, 47374);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSettable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 47545, 47563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 47548, 47563);
                    return f_1292_47548_47563(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 47545, 47563);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 47545, 47563);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 47545, 47563);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsGettable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 47739, 47746);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 47742, 47746);
                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 47739, 47746);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 47739, 47746);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 47739, 47746);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override object Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 47917, 47934);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 47920, 47934);
                    return this.noteValue;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 47917, 47934);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 47860, 48321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 47860, 48321);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 47949, 48310);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 47985, 48252) || true) && (f_1292_47989_48005_M(!this.IsInstance))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 47985, 48252);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 48047, 48233);

                        throw f_1292_48053_48232("ChangeValueOfStaticNote", null, f_1292_48158_48195(), f_1292_48222_48231(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 47985, 48252);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 48272, 48295);

                    this.noteValue = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 47949, 48310);

                    bool
                    f_1292_47989_48005_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 47989, 48005);
                        return return_v;
                    }


                    string
                    f_1292_48158_48195()
                    {
                        var return_v = ExtendedTypeSystem.ChangeStaticMember;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 48158, 48195);
                        return return_v;
                    }


                    string
                    f_1292_48222_48231(System.Management.Automation.PSNoteProperty
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 48222, 48231);
                        return return_v;
                    }


                    System.Management.Automation.SetValueException
                    f_1292_48053_48232(string
                    errorId, System.Exception
                    innerException, string
                    resourceString, params object[]
                    arguments)
                    {
                        var return_v = new System.Management.Automation.SetValueException(errorId, innerException, resourceString, arguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 48053, 48232);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 47860, 48321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 47860, 48321);
                }
            }
        }

        public override string TypeNameOfValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 48500, 49272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 48536, 48560);

                    object
                    val = f_1292_48549_48559(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 48580, 48687) || true) && (val == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 48580, 48687);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 48637, 48668);

                        return f_1292_48644_48667(typeof(object));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 48580, 48687);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 48707, 49207) || true) && (val is PSObject valAsPSObject)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 48707, 49207);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 48782, 48830);

                        var
                        typeNames = f_1292_48798_48829(valAsPSObject)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 48852, 49188) || true) && ((typeNames != null) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 48856, 48901) && (f_1292_48880_48895(typeNames) >= 1)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 48852, 49188);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 49145, 49165);

                            return f_1292_49152_49164(typeNames, 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 48852, 49188);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 48707, 49207);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 49227, 49257);

                    return f_1292_49234_49256(f_1292_49234_49247(val));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 48500, 49272);

                    object
                    f_1292_48549_48559(System.Management.Automation.PSNoteProperty
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 48549, 48559);
                        return return_v;
                    }


                    string
                    f_1292_48644_48667(System.Type
                    this_param)
                    {
                        var return_v = this_param.FullName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 48644, 48667);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.ConsolidatedString
                    f_1292_48798_48829(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.InternalTypeNames;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 48798, 48829);
                        return return_v;
                    }


                    int
                    f_1292_48880_48895(System.Management.Automation.Runspaces.ConsolidatedString
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 48880, 48895);
                        return return_v;
                    }


                    string
                    f_1292_49152_49164(System.Management.Automation.Runspaces.ConsolidatedString
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 49152, 49164);
                        return return_v;
                    }


                    System.Type
                    f_1292_49234_49247(object
                    this_param)
                    {
                        var return_v = this_param.GetType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 49234, 49247);
                        return return_v;
                    }


                    string
                    f_1292_49234_49256(System.Type
                    this_param)
                    {
                        var return_v = this_param.FullName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 49234, 49256);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 48437, 49283);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 48437, 49283);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static string GetDisplayTypeNameOfValue(object val)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 49340, 50063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 49425, 49455);

                string
                displayTypeName = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 49471, 49760) || true) && (val is PSObject valAsPSObject)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 49471, 49760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 49538, 49586);

                    var
                    typeNames = f_1292_49554_49585(valAsPSObject)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 49604, 49745) || true) && ((typeNames != null) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 49608, 49653) && (f_1292_49632_49647(typeNames) >= 1)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 49604, 49745);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 49695, 49726);

                        displayTypeName = f_1292_49713_49725(typeNames, 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 49604, 49745);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 49471, 49760);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 49776, 50013) || true) && (f_1292_49780_49817(displayTypeName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 49776, 50013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 49851, 49998);

                    displayTypeName = (DynAbs.Tracing.TraceSender.Conditional_F1(1292, 49869, 49880) || ((val == null
                    && DynAbs.Tracing.TraceSender.Conditional_F2(1292, 49904, 49912)) || DynAbs.Tracing.TraceSender.Conditional_F3(1292, 49936, 49997))) ? "object"
                    : f_1292_49936_49997(f_1292_49961_49974(val), dropNamespaces: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 49776, 50013);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 50029, 50052);

                return displayTypeName;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 49340, 50063);

                System.Management.Automation.Runspaces.ConsolidatedString
                f_1292_49554_49585(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 49554, 49585);
                    return return_v;
                }


                int
                f_1292_49632_49647(System.Management.Automation.Runspaces.ConsolidatedString
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 49632, 49647);
                    return return_v;
                }


                string
                f_1292_49713_49725(System.Management.Automation.Runspaces.ConsolidatedString
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 49713, 49725);
                    return return_v;
                }


                bool
                f_1292_49780_49817(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 49780, 49817);
                    return return_v;
                }


                System.Type
                f_1292_49961_49974(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 49961, 49974);
                    return return_v;
                }


                string
                f_1292_49936_49997(System.Type
                type, bool
                dropNamespaces)
                {
                    var return_v = ToStringCodeMethods.Type(type, dropNamespaces: dropNamespaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 49936, 49997);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 49340, 50063);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 49340, 50063);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSNoteProperty()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 45339, 50070);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 45339, 50070);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 45339, 50070);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 45339, 50070);

        bool
        f_1292_46477_46503(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 46477, 46503);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_46543_46585(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 46543, 46585);
            return return_v;
        }


        bool
        f_1292_47548_47563(System.Management.Automation.PSNoteProperty
        this_param)
        {
            var return_v = this_param.IsInstance;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 47548, 47563);
            return return_v;
        }

    }
    public class PSVariableProperty : PSNoteProperty
    {
        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 50608, 51031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 50666, 50714);

                StringBuilder
                returnValue = f_1292_50694_50713()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 50728, 50791);

                f_1292_50728_50790(returnValue, f_1292_50747_50789(f_1292_50773_50788(_variable)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 50805, 50829);

                f_1292_50805_50828(returnValue, " ");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 50843, 50878);

                f_1292_50843_50877(returnValue, f_1292_50862_50876(_variable));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 50892, 50916);

                f_1292_50892_50915(returnValue, "=");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 50930, 50976);

                f_1292_50930_50975(returnValue, f_1292_50949_50964(_variable) ?? (DynAbs.Tracing.TraceSender.Expression_Null<object>(1292, 50949, 50974) ?? "null"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 50990, 51020);

                return f_1292_50997_51019(returnValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 50608, 51031);

                System.Text.StringBuilder
                f_1292_50694_50713()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 50694, 50713);
                    return return_v;
                }


                object
                f_1292_50773_50788(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 50773, 50788);
                    return return_v;
                }


                string
                f_1292_50747_50789(object
                val)
                {
                    var return_v = GetDisplayTypeNameOfValue(val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 50747, 50789);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_50728_50790(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 50728, 50790);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_50805_50828(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 50805, 50828);
                    return return_v;
                }


                string
                f_1292_50862_50876(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 50862, 50876);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_50843_50877(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 50843, 50877);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_50892_50915(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 50892, 50915);
                    return return_v;
                }


                object
                f_1292_50949_50964(System.Management.Automation.PSVariable
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 50949, 50964);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_50930_50975(System.Text.StringBuilder
                this_param, object
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 50930, 50975);
                    return return_v;
                }


                string
                f_1292_50997_51019(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 50997, 51019);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 50608, 51031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 50608, 51031);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PSVariable _variable;

        public PSVariableProperty(PSVariable variable)
        : base(f_1292_51527_51541_C(f_1292_51527_51541_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(variable, 1292, 51527, 51541)?.Name)), null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 51460, 51661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 51063, 51072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 51573, 51650);

                _variable = variable ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.PSVariable>(1292, 51585, 51649) ?? throw f_1292_51603_51649("variable"));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 51460, 51661);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 51460, 51661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 51460, 51661);
            }
        }

        public override PSMemberInfo Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 52046, 52251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 52106, 52166);

                PSNoteProperty
                property = f_1292_52132_52165(_variable)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 52180, 52210);

                f_1292_52180_52209(this, property);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 52224, 52240);

                return property;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 52046, 52251);

                System.Management.Automation.PSVariableProperty
                f_1292_52132_52165(System.Management.Automation.PSVariable
                variable)
                {
                    var return_v = new System.Management.Automation.PSVariableProperty(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 52132, 52165);
                    return return_v;
                }


                int
                f_1292_52180_52209(System.Management.Automation.PSVariableProperty
                this_param, System.Management.Automation.PSNoteProperty
                destiny)
                {
                    this_param.CloneBaseProperties((System.Management.Automation.PSMemberInfo)destiny);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 52180, 52209);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 52046, 52251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 52046, 52251);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override PSMemberTypes MemberType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 52397, 52426);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 52400, 52426);
                    return PSMemberTypes.NoteProperty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 52397, 52426);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 52397, 52426);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 52397, 52426);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSettable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 52578, 52686);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 52581, 52686);
                    return (f_1292_52582_52599(_variable) & (ScopedItemOptions.Constant | ScopedItemOptions.ReadOnly)) == ScopedItemOptions.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 52578, 52686);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 52578, 52686);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 52578, 52686);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsGettable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 52862, 52869);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 52865, 52869);
                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 52862, 52869);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 52862, 52869);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 52862, 52869);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override object Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 53040, 53058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 53043, 53058);
                    return f_1292_53043_53058(_variable);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 53040, 53058);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 52983, 53446);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 52983, 53446);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 53073, 53435);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 53109, 53376) || true) && (f_1292_53113_53129_M(!this.IsInstance))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 53109, 53376);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 53171, 53357);

                        throw f_1292_53177_53356("ChangeValueOfStaticNote", null, f_1292_53282_53319(), f_1292_53346_53355(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 53109, 53376);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 53396, 53420);

                    _variable.Value = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 53073, 53435);

                    bool
                    f_1292_53113_53129_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 53113, 53129);
                        return return_v;
                    }


                    string
                    f_1292_53282_53319()
                    {
                        var return_v = ExtendedTypeSystem.ChangeStaticMember;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 53282, 53319);
                        return return_v;
                    }


                    string
                    f_1292_53346_53355(System.Management.Automation.PSVariableProperty
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 53346, 53355);
                        return return_v;
                    }


                    System.Management.Automation.SetValueException
                    f_1292_53177_53356(string
                    errorId, System.Exception
                    innerException, string
                    resourceString, params object[]
                    arguments)
                    {
                        var return_v = new System.Management.Automation.SetValueException(errorId, innerException, resourceString, arguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 53177, 53356);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 52983, 53446);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 52983, 53446);
                }
            }
        }

        public override string TypeNameOfValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 53625, 54402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 53661, 53690);

                    object
                    val = f_1292_53674_53689(_variable)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 53710, 53817) || true) && (val == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 53710, 53817);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 53767, 53798);

                        return f_1292_53774_53797(typeof(object));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 53710, 53817);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 53837, 54337) || true) && (val is PSObject valAsPSObject)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 53837, 54337);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 53912, 53960);

                        var
                        typeNames = f_1292_53928_53959(valAsPSObject)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 53982, 54318) || true) && ((typeNames != null) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 53986, 54031) && (f_1292_54010_54025(typeNames) >= 1)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 53982, 54318);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 54275, 54295);

                            return f_1292_54282_54294(typeNames, 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 53982, 54318);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 53837, 54337);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 54357, 54387);

                    return f_1292_54364_54386(f_1292_54364_54377(val));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 53625, 54402);

                    object
                    f_1292_53674_53689(System.Management.Automation.PSVariable
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 53674, 53689);
                        return return_v;
                    }


                    string
                    f_1292_53774_53797(System.Type
                    this_param)
                    {
                        var return_v = this_param.FullName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 53774, 53797);
                        return return_v;
                    }


                    System.Management.Automation.Runspaces.ConsolidatedString
                    f_1292_53928_53959(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.InternalTypeNames;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 53928, 53959);
                        return return_v;
                    }


                    int
                    f_1292_54010_54025(System.Management.Automation.Runspaces.ConsolidatedString
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 54010, 54025);
                        return return_v;
                    }


                    string
                    f_1292_54282_54294(System.Management.Automation.Runspaces.ConsolidatedString
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 54282, 54294);
                        return return_v;
                    }


                    System.Type
                    f_1292_54364_54377(object
                    this_param)
                    {
                        var return_v = this_param.GetType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 54364, 54377);
                        return return_v;
                    }


                    string
                    f_1292_54364_54386(System.Type
                    this_param)
                    {
                        var return_v = this_param.FullName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 54364, 54386);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 53562, 54413);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 53562, 54413);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PSVariableProperty()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 50372, 54465);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 50372, 54465);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 50372, 54465);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 50372, 54465);

        static string
        f_1292_51527_51541_M(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 51527, 51541);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_51603_51649(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 51603, 51649);
            return return_v;
        }


        static string
        f_1292_51527_51541_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1292, 51460, 51661);
            return return_v;
        }


        System.Management.Automation.ScopedItemOptions
        f_1292_52582_52599(System.Management.Automation.PSVariable
        this_param)
        {
            var return_v = this_param.Options;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 52582, 52599);
            return return_v;
        }


        object
        f_1292_53043_53058(System.Management.Automation.PSVariable
        this_param)
        {
            var return_v = this_param.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 53043, 53058);
            return return_v;
        }

    }
    public class PSScriptProperty : PSPropertyInfo
    {
        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 55013, 55828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 55071, 55119);

                StringBuilder
                returnValue = f_1292_55099_55118()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 55133, 55174);

                f_1292_55133_55173(returnValue, f_1292_55152_55172(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 55188, 55212);

                f_1292_55188_55211(returnValue, " ");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 55226, 55256);

                f_1292_55226_55255(returnValue, f_1292_55245_55254(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 55270, 55295);

                f_1292_55270_55294(returnValue, " {");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 55309, 55513) || true) && (f_1292_55313_55328(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 55309, 55513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 55362, 55389);

                    f_1292_55362_55388(returnValue, "get=");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 55407, 55456);

                    f_1292_55407_55455(returnValue, f_1292_55426_55454(f_1292_55426_55443(this)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 55474, 55498);

                    f_1292_55474_55497(returnValue, ";");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 55309, 55513);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 55529, 55733) || true) && (f_1292_55533_55548(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 55529, 55733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 55582, 55609);

                    f_1292_55582_55608(returnValue, "set=");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 55627, 55676);

                    f_1292_55627_55675(returnValue, f_1292_55646_55674(f_1292_55646_55663(this)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 55694, 55718);

                    f_1292_55694_55717(returnValue, ";");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 55529, 55733);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 55749, 55773);

                f_1292_55749_55772(
                            returnValue, "}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 55787, 55817);

                return f_1292_55794_55816(returnValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 55013, 55828);

                System.Text.StringBuilder
                f_1292_55099_55118()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 55099, 55118);
                    return return_v;
                }


                string
                f_1292_55152_55172(System.Management.Automation.PSScriptProperty
                this_param)
                {
                    var return_v = this_param.TypeNameOfValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 55152, 55172);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_55133_55173(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 55133, 55173);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_55188_55211(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 55188, 55211);
                    return return_v;
                }


                string
                f_1292_55245_55254(System.Management.Automation.PSScriptProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 55245, 55254);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_55226_55255(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 55226, 55255);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_55270_55294(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 55270, 55294);
                    return return_v;
                }


                bool
                f_1292_55313_55328(System.Management.Automation.PSScriptProperty
                this_param)
                {
                    var return_v = this_param.IsGettable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 55313, 55328);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_55362_55388(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 55362, 55388);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1292_55426_55443(System.Management.Automation.PSScriptProperty
                this_param)
                {
                    var return_v = this_param.GetterScript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 55426, 55443);
                    return return_v;
                }


                string
                f_1292_55426_55454(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 55426, 55454);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_55407_55455(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 55407, 55455);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_55474_55497(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 55474, 55497);
                    return return_v;
                }


                bool
                f_1292_55533_55548(System.Management.Automation.PSScriptProperty
                this_param)
                {
                    var return_v = this_param.IsSettable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 55533, 55548);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_55582_55608(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 55582, 55608);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1292_55646_55663(System.Management.Automation.PSScriptProperty
                this_param)
                {
                    var return_v = this_param.SetterScript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 55646, 55663);
                    return return_v;
                }


                string
                f_1292_55646_55674(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 55646, 55674);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_55627_55675(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 55627, 55675);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_55694_55717(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 55694, 55717);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_55749_55772(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 55749, 55772);
                    return return_v;
                }


                string
                f_1292_55794_55816(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 55794, 55816);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 55013, 55828);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 55013, 55828);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private readonly PSLanguageMode? _languageMode;

        private readonly string _getterScriptText;

        private ScriptBlock _getterScript;

        private readonly string _setterScriptText;

        private ScriptBlock _setterScript;

        private bool _shouldCloneOnAccess;

        public ScriptBlock GetterScript
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 56317, 57761);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 56513, 56917) || true) && ((_getterScript == null) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 56517, 56571) && (_getterScriptText != null)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 56513, 56917);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 56613, 56667);

                        _getterScript = f_1292_56629_56666(_getterScriptText);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 56691, 56833) || true) && (f_1292_56695_56717(_languageMode))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 56691, 56833);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 56767, 56810);

                            _getterScript.LanguageMode = _languageMode;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 56691, 56833);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 56857, 56898);

                        _getterScript.DebuggerStepThrough = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 56513, 56917);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 56937, 57035) || true) && (_getterScript == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 56937, 57035);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 57004, 57016);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 56937, 57035);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 57055, 57746) || true) && (_shouldCloneOnAccess)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 57055, 57746);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 57447, 57499);

                        ScriptBlock
                        newGetterScript = f_1292_57477_57498(_getterScript)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 57521, 57579);

                        newGetterScript.LanguageMode = f_1292_57552_57578(_getterScript);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 57601, 57624);

                        return newGetterScript;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 57055, 57746);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 57055, 57746);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 57706, 57727);

                        return _getterScript;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 57055, 57746);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 56317, 57761);

                    System.Management.Automation.ScriptBlock
                    f_1292_56629_56666(string
                    script)
                    {
                        var return_v = ScriptBlock.Create(script);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 56629, 56666);
                        return return_v;
                    }


                    bool
                    f_1292_56695_56717(System.Management.Automation.PSLanguageMode?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 56695, 56717);
                        return return_v;
                    }


                    System.Management.Automation.ScriptBlock
                    f_1292_57477_57498(System.Management.Automation.ScriptBlock
                    this_param)
                    {
                        var return_v = this_param.Clone();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 57477, 57498);
                        return return_v;
                    }


                    System.Management.Automation.PSLanguageMode?
                    f_1292_57552_57578(System.Management.Automation.ScriptBlock
                    this_param)
                    {
                        var return_v = this_param.LanguageMode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 57552, 57578);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 56261, 57772);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 56261, 57772);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ScriptBlock SetterScript
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 57964, 59408);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 58160, 58564) || true) && ((_setterScript == null) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 58164, 58218) && (_setterScriptText != null)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 58160, 58564);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 58260, 58314);

                        _setterScript = f_1292_58276_58313(_setterScriptText);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 58338, 58480) || true) && (f_1292_58342_58364(_languageMode))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 58338, 58480);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 58414, 58457);

                            _setterScript.LanguageMode = _languageMode;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 58338, 58480);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 58504, 58545);

                        _setterScript.DebuggerStepThrough = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 58160, 58564);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 58584, 58682) || true) && (_setterScript == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 58584, 58682);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 58651, 58663);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 58584, 58682);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 58702, 59393) || true) && (_shouldCloneOnAccess)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 58702, 59393);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 59094, 59146);

                        ScriptBlock
                        newSetterScript = f_1292_59124_59145(_setterScript)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 59168, 59226);

                        newSetterScript.LanguageMode = f_1292_59199_59225(_setterScript);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 59248, 59271);

                        return newSetterScript;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 58702, 59393);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 58702, 59393);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 59353, 59374);

                        return _setterScript;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 58702, 59393);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 57964, 59408);

                    System.Management.Automation.ScriptBlock
                    f_1292_58276_58313(string
                    script)
                    {
                        var return_v = ScriptBlock.Create(script);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 58276, 58313);
                        return return_v;
                    }


                    bool
                    f_1292_58342_58364(System.Management.Automation.PSLanguageMode?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 58342, 58364);
                        return return_v;
                    }


                    System.Management.Automation.ScriptBlock
                    f_1292_59124_59145(System.Management.Automation.ScriptBlock
                    this_param)
                    {
                        var return_v = this_param.Clone();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 59124, 59145);
                        return return_v;
                    }


                    System.Management.Automation.PSLanguageMode?
                    f_1292_59199_59225(System.Management.Automation.ScriptBlock
                    this_param)
                    {
                        var return_v = this_param.LanguageMode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 59199, 59225);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 57908, 59419);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 57908, 59419);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PSScriptProperty(string name, ScriptBlock getterScript)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 59836, 60204);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 55873, 55886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 55921, 55938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 55969, 55982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 56019, 56036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 56067, 56080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 56104, 56124);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 59923, 60051) || true) && (f_1292_59927_59953(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 59923, 60051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 59987, 60036);

                    throw f_1292_59993_60035("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 59923, 60051);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 60067, 60084);

                this.name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 60100, 60193);

                _getterScript = getterScript ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.ScriptBlock>(1292, 60116, 60192) ?? throw f_1292_60138_60192("getterScript"));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 59836, 60204);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 59836, 60204);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 59836, 60204);
            }
        }

        public PSScriptProperty(string name, ScriptBlock getterScript, ScriptBlock setterScript)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 60849, 61748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 55873, 55886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 55921, 55938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 55969, 55982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 56019, 56036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 56067, 56080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 56104, 56124);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 60962, 61090) || true) && (f_1292_60966_60992(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 60962, 61090);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 61026, 61075);

                    throw f_1292_61032_61074("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 60962, 61090);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 61106, 61123);

                this.name = name;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 61137, 61391) || true) && (getterScript == null && (DynAbs.Tracing.TraceSender.Expression_True(1292, 61141, 61185) && setterScript == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 61137, 61391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 61306, 61376);

                    throw f_1292_61312_61375("getterScript setterScript");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 61137, 61391);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 61407, 61520) || true) && (getterScript != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 61407, 61520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 61465, 61505);

                    getterScript.DebuggerStepThrough = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 61407, 61520);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 61536, 61649) || true) && (setterScript != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 61536, 61649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 61594, 61634);

                    setterScript.DebuggerStepThrough = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 61536, 61649);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 61665, 61694);

                _getterScript = getterScript;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 61708, 61737);

                _setterScript = setterScript;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 60849, 61748);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 60849, 61748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 60849, 61748);
            }
        }

        internal PSScriptProperty(string name, string getterScript, string setterScript, PSLanguageMode? languageMode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 62507, 63221);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 55873, 55886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 55921, 55938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 55969, 55982);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 56019, 56036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 56067, 56080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 56104, 56124);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 62642, 62770) || true) && (f_1292_62646_62672(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 62642, 62770);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 62706, 62755);

                    throw f_1292_62712_62754("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 62642, 62770);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 62786, 62803);

                this.name = name;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 62817, 63071) || true) && (getterScript == null && (DynAbs.Tracing.TraceSender.Expression_True(1292, 62821, 62865) && setterScript == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 62817, 63071);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 62986, 63056);

                    throw f_1292_62992_63055("getterScript setterScript");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 62817, 63071);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 63087, 63120);

                _getterScriptText = getterScript;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 63134, 63167);

                _setterScriptText = setterScript;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 63181, 63210);

                _languageMode = languageMode;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 62507, 63221);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 62507, 63221);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 62507, 63221);
            }
        }

        internal PSScriptProperty(string name, ScriptBlock getterScript, ScriptBlock setterScript, bool shouldCloneOnAccess)
        : this(f_1292_63370_63374_C(name), getterScript, setterScript)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 63233, 63482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 63428, 63471);

                _shouldCloneOnAccess = shouldCloneOnAccess;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 63233, 63482);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 63233, 63482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 63233, 63482);
            }
        }

        internal PSScriptProperty(string name, string getterScript, string setterScript, PSLanguageMode? languageMode, bool shouldCloneOnAccess)
        : this(f_1292_63651_63655_C(name), getterScript, setterScript, languageMode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 63494, 63777);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 63723, 63766);

                _shouldCloneOnAccess = shouldCloneOnAccess;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 63494, 63777);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 63494, 63777);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 63494, 63777);
            }
        }

        public override PSMemberInfo Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 64043, 64316);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 64103, 64231);

                var
                property = new PSScriptProperty(name, f_1292_64145_64162(this), f_1292_64164_64181(this)) { _shouldCloneOnAccess = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => _shouldCloneOnAccess, 1292, 64118, 64230) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 64245, 64275);

                f_1292_64245_64274(this, property);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 64289, 64305);

                return property;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 64043, 64316);

                System.Management.Automation.ScriptBlock
                f_1292_64145_64162(System.Management.Automation.PSScriptProperty
                this_param)
                {
                    var return_v = this_param.GetterScript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 64145, 64162);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1292_64164_64181(System.Management.Automation.PSScriptProperty
                this_param)
                {
                    var return_v = this_param.SetterScript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 64164, 64181);
                    return return_v;
                }


                int
                f_1292_64245_64274(System.Management.Automation.PSScriptProperty
                this_param, System.Management.Automation.PSScriptProperty
                destiny)
                {
                    this_param.CloneBaseProperties((System.Management.Automation.PSMemberInfo)destiny);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 64245, 64274);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 64043, 64316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 64043, 64316);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override PSMemberTypes MemberType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 64451, 64482);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 64454, 64482);
                    return PSMemberTypes.ScriptProperty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 64451, 64482);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 64451, 64482);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 64451, 64482);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSettable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 64626, 64689);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 64629, 64689);
                    return this._setterScript != null || (DynAbs.Tracing.TraceSender.Expression_False(1292, 64629, 64689) || this._setterScriptText != null);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 64626, 64689);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 64626, 64689);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 64626, 64689);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsGettable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 64834, 64897);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 64837, 64897);
                    return this._getterScript != null || (DynAbs.Tracing.TraceSender.Expression_False(1292, 64837, 64897) || this._getterScriptText != null);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 64834, 64897);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 64834, 64897);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 64834, 64897);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override object Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 65469, 65874);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 65505, 65804) || true) && (f_1292_65509_65526(this) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 65505, 65804);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 65576, 65785);

                        throw f_1292_65582_65784("GetWithoutGetterFromScriptPropertyValue", null, f_1292_65703_65747(), f_1292_65774_65783(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 65505, 65804);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 65824, 65859);

                    return f_1292_65831_65858(this, this.instance);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 65469, 65874);

                    System.Management.Automation.ScriptBlock
                    f_1292_65509_65526(System.Management.Automation.PSScriptProperty
                    this_param)
                    {
                        var return_v = this_param.GetterScript;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 65509, 65526);
                        return return_v;
                    }


                    string
                    f_1292_65703_65747()
                    {
                        var return_v = ExtendedTypeSystem.GetWithoutGetterException;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 65703, 65747);
                        return return_v;
                    }


                    string
                    f_1292_65774_65783(System.Management.Automation.PSScriptProperty
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 65774, 65783);
                        return return_v;
                    }


                    System.Management.Automation.GetValueException
                    f_1292_65582_65784(string
                    errorId, System.Exception
                    innerException, string
                    resourceString, params object[]
                    arguments)
                    {
                        var return_v = new System.Management.Automation.GetValueException(errorId, innerException, resourceString, arguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 65582, 65784);
                        return return_v;
                    }


                    object
                    f_1292_65831_65858(System.Management.Automation.PSScriptProperty
                    this_param, object
                    scriptThis)
                    {
                        var return_v = this_param.InvokeGetter(scriptThis);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 65831, 65858);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 65416, 66301);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 65416, 66301);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 65890, 66290);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 65926, 66220) || true) && (f_1292_65930_65947(this) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 65926, 66220);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 65997, 66201);

                        throw f_1292_66003_66200("SetWithoutSetterFromScriptProperty", null, f_1292_66119_66163(), f_1292_66190_66199(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 65926, 66220);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 66240, 66275);

                    f_1292_66240_66274(this, this.instance, value);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 65890, 66290);

                    System.Management.Automation.ScriptBlock
                    f_1292_65930_65947(System.Management.Automation.PSScriptProperty
                    this_param)
                    {
                        var return_v = this_param.SetterScript;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 65930, 65947);
                        return return_v;
                    }


                    string
                    f_1292_66119_66163()
                    {
                        var return_v = ExtendedTypeSystem.SetWithoutSetterException;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 66119, 66163);
                        return return_v;
                    }


                    string
                    f_1292_66190_66199(System.Management.Automation.PSScriptProperty
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 66190, 66199);
                        return return_v;
                    }


                    System.Management.Automation.SetValueException
                    f_1292_66003_66200(string
                    errorId, System.Exception
                    innerException, string
                    resourceString, params object[]
                    arguments)
                    {
                        var return_v = new System.Management.Automation.SetValueException(errorId, innerException, resourceString, arguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 66003, 66200);
                        return return_v;
                    }


                    object
                    f_1292_66240_66274(System.Management.Automation.PSScriptProperty
                    this_param, object
                    scriptThis, object
                    value)
                    {
                        var return_v = this_param.InvokeSetter(scriptThis, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 66240, 66274);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 65416, 66301);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 65416, 66301);
                }
            }
        }

        internal object InvokeSetter(object scriptThis, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 66313, 67535);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 66435, 66809);

                    f_1292_66435_66808(f_1292_66435_66447(), useLocalScope: true, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToExternalErrorPipe, dollarUnder: f_1292_66648_66668(), input: f_1292_66698_66718(), scriptThis: scriptThis, args: new[] { value });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 66827, 66840);

                    return value;
                }
                catch (RuntimeException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1292, 66869, 67007);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 66928, 66992);

                    throw f_1292_66934_66991(this, e, "ScriptSetValueRuntimeException");
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1292, 66869, 67007);
                }
                catch (TerminateException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1292, 67021, 67192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 67171, 67177);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1292, 67021, 67192);
                }
                catch (FlowControlException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1292, 67206, 67352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 67269, 67337);

                    throw f_1292_67275_67336(this, e, "ScriptSetValueFlowControlException");
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1292, 67206, 67352);
                }
                catch (PSInvalidOperationException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1292, 67366, 67524);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 67436, 67509);

                    throw f_1292_67442_67508(this, e, "ScriptSetValueInvalidOperationException");
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1292, 67366, 67524);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 66313, 67535);

                System.Management.Automation.ScriptBlock
                f_1292_66435_66447()
                {
                    var return_v = SetterScript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 66435, 66447);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1292_66648_66668()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 66648, 66668);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1292_66698_66718()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 66698, 66718);
                    return return_v;
                }


                object
                f_1292_66435_66808(System.Management.Automation.ScriptBlock
                this_param, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, System.Management.Automation.PSObject
                input, object
                scriptThis, object[]
                args)
                {
                    var return_v = this_param.DoInvokeReturnAsIs(useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 66435, 66808);
                    return return_v;
                }


                System.Exception
                f_1292_66934_66991(System.Management.Automation.PSScriptProperty
                this_param, System.Management.Automation.RuntimeException
                e, string
                errorId)
                {
                    var return_v = this_param.NewSetValueException((System.Exception)e, errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 66934, 66991);
                    return return_v;
                }


                System.Exception
                f_1292_67275_67336(System.Management.Automation.PSScriptProperty
                this_param, System.Management.Automation.FlowControlException
                e, string
                errorId)
                {
                    var return_v = this_param.NewSetValueException((System.Exception)e, errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 67275, 67336);
                    return return_v;
                }


                System.Exception
                f_1292_67442_67508(System.Management.Automation.PSScriptProperty
                this_param, System.Management.Automation.PSInvalidOperationException
                e, string
                errorId)
                {
                    var return_v = this_param.NewSetValueException((System.Exception)e, errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 67442, 67508);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 66313, 67535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 66313, 67535);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object InvokeGetter(object scriptThis)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 67547, 68726);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 67655, 68031);

                    return f_1292_67662_68030(f_1292_67662_67674(), useLocalScope: true, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.SwallowErrors, dollarUnder: f_1292_67864_67884(), input: f_1292_67914_67934(), scriptThis: scriptThis, args: f_1292_68008_68029());
                }
                catch (RuntimeException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1292, 68060, 68198);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 68119, 68183);

                    throw f_1292_68125_68182(this, e, "ScriptGetValueRuntimeException");
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1292, 68060, 68198);
                }
                catch (TerminateException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1292, 68212, 68383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 68362, 68368);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1292, 68212, 68383);
                }
                catch (FlowControlException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1292, 68397, 68543);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 68460, 68528);

                    throw f_1292_68466_68527(this, e, "ScriptGetValueFlowControlException");
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1292, 68397, 68543);
                }
                catch (PSInvalidOperationException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1292, 68557, 68715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 68627, 68700);

                    throw f_1292_68633_68699(this, e, "ScriptgetValueInvalidOperationException");
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1292, 68557, 68715);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 67547, 68726);

                System.Management.Automation.ScriptBlock
                f_1292_67662_67674()
                {
                    var return_v = GetterScript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 67662, 67674);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1292_67864_67884()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 67864, 67884);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1292_67914_67934()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 67914, 67934);
                    return return_v;
                }


                object[]
                f_1292_68008_68029()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 68008, 68029);
                    return return_v;
                }


                object
                f_1292_67662_68030(System.Management.Automation.ScriptBlock
                this_param, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, System.Management.Automation.PSObject
                input, object
                scriptThis, object[]
                args)
                {
                    var return_v = this_param.DoInvokeReturnAsIs(useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 67662, 68030);
                    return return_v;
                }


                System.Exception
                f_1292_68125_68182(System.Management.Automation.PSScriptProperty
                this_param, System.Management.Automation.RuntimeException
                e, string
                errorId)
                {
                    var return_v = this_param.NewGetValueException((System.Exception)e, errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 68125, 68182);
                    return return_v;
                }


                System.Exception
                f_1292_68466_68527(System.Management.Automation.PSScriptProperty
                this_param, System.Management.Automation.FlowControlException
                e, string
                errorId)
                {
                    var return_v = this_param.NewGetValueException((System.Exception)e, errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 68466, 68527);
                    return return_v;
                }


                System.Exception
                f_1292_68633_68699(System.Management.Automation.PSScriptProperty
                this_param, System.Management.Automation.PSInvalidOperationException
                e, string
                errorId)
                {
                    var return_v = this_param.NewGetValueException((System.Exception)e, errorId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 68633, 68699);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 67547, 68726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 67547, 68726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string TypeNameOfValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 68960, 69325);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 68996, 69310) || true) && ((f_1292_69001_69018(this) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 69000, 69092) && (f_1292_69053_69087(f_1292_69053_69081(f_1292_69053_69070(this))) > 0)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 68996, 69310);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 69134, 69178);

                        return f_1292_69141_69177(f_1292_69141_69172(f_1292_69141_69169(f_1292_69141_69158(this)), 0));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 68996, 69310);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 68996, 69310);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 69260, 69291);

                        return f_1292_69267_69290(typeof(object));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 68996, 69310);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 68960, 69325);

                    System.Management.Automation.ScriptBlock
                    f_1292_69001_69018(System.Management.Automation.PSScriptProperty
                    this_param)
                    {
                        var return_v = this_param.GetterScript;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 69001, 69018);
                        return return_v;
                    }


                    System.Management.Automation.ScriptBlock
                    f_1292_69053_69070(System.Management.Automation.PSScriptProperty
                    this_param)
                    {
                        var return_v = this_param.GetterScript;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 69053, 69070);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
                    f_1292_69053_69081(System.Management.Automation.ScriptBlock
                    this_param)
                    {
                        var return_v = this_param.OutputType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 69053, 69081);
                        return return_v;
                    }


                    int
                    f_1292_69053_69087(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 69053, 69087);
                        return return_v;
                    }


                    System.Management.Automation.ScriptBlock
                    f_1292_69141_69158(System.Management.Automation.PSScriptProperty
                    this_param)
                    {
                        var return_v = this_param.GetterScript;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 69141, 69158);
                        return return_v;
                    }


                    System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
                    f_1292_69141_69169(System.Management.Automation.ScriptBlock
                    this_param)
                    {
                        var return_v = this_param.OutputType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 69141, 69169);
                        return return_v;
                    }


                    System.Management.Automation.PSTypeName
                    f_1292_69141_69172(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.PSTypeName>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 69141, 69172);
                        return return_v;
                    }


                    string
                    f_1292_69141_69177(System.Management.Automation.PSTypeName
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 69141, 69177);
                        return return_v;
                    }


                    string
                    f_1292_69267_69290(System.Type
                    this_param)
                    {
                        var return_v = this_param.FullName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 69267, 69290);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 68897, 69336);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 68897, 69336);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PSScriptProperty()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 54779, 69388);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 54779, 69388);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 54779, 69388);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 54779, 69388);

        bool
        f_1292_59927_59953(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 59927, 59953);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_59993_60035(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 59993, 60035);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1292_60138_60192(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 60138, 60192);
            return return_v;
        }


        bool
        f_1292_60966_60992(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 60966, 60992);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_61032_61074(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 61032, 61074);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_61312_61375(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 61312, 61375);
            return return_v;
        }


        bool
        f_1292_62646_62672(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 62646, 62672);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_62712_62754(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 62712, 62754);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_62992_63055(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 62992, 63055);
            return return_v;
        }


        static string
        f_1292_63370_63374_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1292, 63233, 63482);
            return return_v;
        }


        static string
        f_1292_63651_63655_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1292, 63494, 63777);
            return return_v;
        }

    }
    internal class PSMethodInvocationConstraints
    {
        internal PSMethodInvocationConstraints(
                    Type methodTargetType,
                    Type[] parameterTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 69457, 69692);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 69809, 69846);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 70058, 70073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 69593, 69634);

                this.MethodTargetType = methodTargetType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 69648, 69681);

                _parameterTypes = parameterTypes;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 69457, 69692);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 69457, 69692);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 69457, 69692);
            }
        }

        public Type MethodTargetType { get; }

        public IEnumerable<Type> ParameterTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 70003, 70021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 70006, 70021);
                    return _parameterTypes;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 70003, 70021);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 70003, 70021);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 70003, 70021);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private readonly Type[] _parameterTypes;

        internal static bool EqualsForCollection<T>(ICollection<T> xs, ICollection<T> ys)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 70086, 70522);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 70192, 70273) || true) && (xs == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 70192, 70273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 70240, 70258);

                    return ys == null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 70192, 70273);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 70289, 70365) || true) && (ys == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 70289, 70365);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 70337, 70350);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 70289, 70365);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 70381, 70467) || true) && (f_1292_70385_70393(xs) != f_1292_70397_70405(ys))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 70381, 70467);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 70439, 70452);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 70381, 70467);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 70483, 70511);

                return f_1292_70490_70510(xs, ys);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 70086, 70522);

                int
                f_1292_70385_70393(System.Collections.Generic.ICollection<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 70385, 70393);
                    return return_v;
                }


                int
                f_1292_70397_70405(System.Collections.Generic.ICollection<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 70397, 70405);
                    return return_v;
                }


                bool
                f_1292_70490_70510(System.Collections.Generic.ICollection<T>
                first, System.Collections.Generic.ICollection<T>
                second)
                {
                    var return_v = first.SequenceEqual<T>((System.Collections.Generic.IEnumerable<T>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 70490, 70510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 70086, 70522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 70086, 70522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(PSMethodInvocationConstraints other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 70616, 71209);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 70696, 70790) || true) && (f_1292_70700_70728(null, other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 70696, 70790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 70762, 70775);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 70696, 70790);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 70806, 70899) || true) && (f_1292_70810_70838(this, other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 70806, 70899);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 70872, 70884);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 70806, 70899);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 70915, 71028) || true) && (f_1292_70919_70941(other) != f_1292_70945_70966(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 70915, 71028);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 71000, 71013);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 70915, 71028);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 71044, 71170) || true) && (!f_1292_71049_71108(_parameterTypes, other._parameterTypes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 71044, 71170);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 71142, 71155);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 71044, 71170);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 71186, 71198);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 70616, 71209);

                bool
                f_1292_70700_70728(object?
                objA, System.Management.Automation.PSMethodInvocationConstraints
                objB)
                {
                    var return_v = ReferenceEquals(objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 70700, 70728);
                    return return_v;
                }


                bool
                f_1292_70810_70838(System.Management.Automation.PSMethodInvocationConstraints
                objA, System.Management.Automation.PSMethodInvocationConstraints
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 70810, 70838);
                    return return_v;
                }


                System.Type
                f_1292_70919_70941(System.Management.Automation.PSMethodInvocationConstraints
                this_param)
                {
                    var return_v = this_param.MethodTargetType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 70919, 70941);
                    return return_v;
                }


                System.Type
                f_1292_70945_70966(System.Management.Automation.PSMethodInvocationConstraints
                this_param)
                {
                    var return_v = this_param.MethodTargetType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 70945, 70966);
                    return return_v;
                }


                bool
                f_1292_71049_71108(System.Type[]
                xs, System.Type[]
                ys)
                {
                    var return_v = EqualsForCollection((System.Collections.Generic.ICollection<System.Type>)xs, (System.Collections.Generic.ICollection<System.Type>)ys);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 71049, 71108);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 70616, 71209);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 70616, 71209);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 71221, 71697);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 71285, 71377) || true) && (f_1292_71289_71315(null, obj))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 71285, 71377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 71349, 71362);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 71285, 71377);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 71393, 71484) || true) && (f_1292_71397_71423(this, obj))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 71393, 71484);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 71457, 71469);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 71393, 71484);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 71500, 71620) || true) && (f_1292_71504_71517(obj) != typeof(PSMethodInvocationConstraints))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 71500, 71620);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 71592, 71605);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 71500, 71620);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 71636, 71686);

                return f_1292_71643_71685(this, obj);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 71221, 71697);

                bool
                f_1292_71289_71315(object?
                objA, object
                objB)
                {
                    var return_v = ReferenceEquals(objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 71289, 71315);
                    return return_v;
                }


                bool
                f_1292_71397_71423(System.Management.Automation.PSMethodInvocationConstraints
                objA, object
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 71397, 71423);
                    return return_v;
                }


                System.Type
                f_1292_71504_71517(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 71504, 71517);
                    return return_v;
                }


                bool
                f_1292_71643_71685(System.Management.Automation.PSMethodInvocationConstraints
                this_param, object
                other)
                {
                    var return_v = this_param.Equals((System.Management.Automation.PSMethodInvocationConstraints)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 71643, 71685);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 71221, 71697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 71221, 71697);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 71709, 72221);
                // algorithm based on https://stackoverflow.com/questions/263400/what-is-the-best-algorithm-for-an-overridden-system-object-gethashcode
                unchecked
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 71958, 71974);

                    int
                    result = 61
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 71994, 72082);

                    result = result * 397 + ((DynAbs.Tracing.TraceSender.Conditional_F1(1292, 72019, 72043) || ((f_1292_72019_72035() != null && DynAbs.Tracing.TraceSender.Conditional_F2(1292, 72046, 72076)) || DynAbs.Tracing.TraceSender.Conditional_F3(1292, 72079, 72080))) ? f_1292_72046_72076(f_1292_72046_72062()) : 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 72100, 72161);

                    result = result * 397 + f_1292_72124_72160(f_1292_72124_72138());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 72181, 72195);

                    return result;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 71709, 72221);

                System.Type
                f_1292_72019_72035()
                {
                    var return_v = MethodTargetType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 72019, 72035);
                    return return_v;
                }


                System.Type
                f_1292_72046_72062()
                {
                    var return_v = MethodTargetType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 72046, 72062);
                    return return_v;
                }


                int
                f_1292_72046_72076(System.Type
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 72046, 72076);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Type>
                f_1292_72124_72138()
                {
                    var return_v = ParameterTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 72124, 72138);
                    return return_v;
                }


                int
                f_1292_72124_72160(System.Collections.Generic.IEnumerable<System.Type>
                xs)
                {
                    var return_v = xs.SequenceGetHashCode<System.Type>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 72124, 72160);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 71709, 72221);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 71709, 72221);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 72233, 73216);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 72291, 72330);

                StringBuilder
                sb = f_1292_72310_72329()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 72344, 72376);

                string
                separator = string.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 72390, 72615) || true) && (f_1292_72394_72410() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 72390, 72615);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 72452, 72472);

                    f_1292_72452_72471(sb, "this: ");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 72490, 72566);

                    f_1292_72490_72565(sb, f_1292_72500_72564(f_1292_72525_72541(), dropNamespaces: true));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 72584, 72600);

                    separator = " ";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 72390, 72615);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 72631, 73064) || true) && (_parameterTypes != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 72631, 73064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 72692, 72713);

                    f_1292_72692_72712(sb, separator);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 72731, 72751);

                    f_1292_72731_72750(sb, "args: ");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 72769, 72794);

                    separator = string.Empty;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 72812, 73049);
                        foreach (var p in f_1292_72830_72845_I(_parameterTypes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 72812, 73049);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 72887, 72908);

                            f_1292_72887_72907(sb, separator);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 72930, 72991);

                            f_1292_72930_72990(sb, f_1292_72940_72989(p, dropNamespaces: true));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 73013, 73030);

                            separator = ", ";
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 72812, 73049);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 238);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 238);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 72631, 73064);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 73080, 73168) || true) && (f_1292_73084_73093(sb) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 73080, 73168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 73132, 73153);

                    f_1292_73132_73152(sb, "<empty>");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 73080, 73168);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 73184, 73205);

                return f_1292_73191_73204(sb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 72233, 73216);

                System.Text.StringBuilder
                f_1292_72310_72329()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 72310, 72329);
                    return return_v;
                }


                System.Type
                f_1292_72394_72410()
                {
                    var return_v = MethodTargetType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 72394, 72410);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_72452_72471(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 72452, 72471);
                    return return_v;
                }


                System.Type
                f_1292_72525_72541()
                {
                    var return_v = MethodTargetType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 72525, 72541);
                    return return_v;
                }


                string
                f_1292_72500_72564(System.Type
                type, bool
                dropNamespaces)
                {
                    var return_v = ToStringCodeMethods.Type(type, dropNamespaces: dropNamespaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 72500, 72564);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_72490_72565(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 72490, 72565);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_72692_72712(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 72692, 72712);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_72731_72750(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 72731, 72750);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_72887_72907(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 72887, 72907);
                    return return_v;
                }


                string
                f_1292_72940_72989(System.Type
                type, bool
                dropNamespaces)
                {
                    var return_v = ToStringCodeMethods.Type(type, dropNamespaces: dropNamespaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 72940, 72989);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_72930_72990(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 72930, 72990);
                    return return_v;
                }


                System.Type[]
                f_1292_72830_72845_I(System.Type[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 72830, 72845);
                    return return_v;
                }


                int
                f_1292_73084_73093(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 73084, 73093);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_73132_73152(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 73132, 73152);
                    return return_v;
                }


                string
                f_1292_73191_73204(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 73191, 73204);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 72233, 73216);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 72233, 73216);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSMethodInvocationConstraints()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 69396, 73223);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 69396, 73223);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 69396, 73223);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 69396, 73223);
    }
    public abstract class PSMethodInfo : PSMemberInfo
    {
        protected PSMethodInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 73535, 73581);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 73535, 73581);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 73535, 73581);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 73535, 73581);
            }
        }

        public abstract object Invoke(params object[] arguments);

        public abstract Collection<string> OverloadDefinitions { get; }

        public sealed override object Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 75131, 75138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 75134, 75138);
                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 75131, 75138);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 75067, 75372);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 75067, 75372);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 75157, 75360);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 75160, 75360);
                    throw f_1292_75166_75360("CannotChangePSMethodInfoValue", null, f_1292_75271_75317(), f_1292_75336_75359(f_1292_75336_75350(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 75157, 75360);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 75067, 75372);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 75067, 75372);
                }
            }
        }

        static PSMethodInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 73344, 75424);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 73344, 75424);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 73344, 75424);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 73344, 75424);

        string
        f_1292_75271_75317()
        {
            var return_v = ExtendedTypeSystem.CannotSetValueForMemberType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 75271, 75317);
            return return_v;
        }


        System.Type
        f_1292_75336_75350(System.Management.Automation.PSMethodInfo
        this_param)
        {
            var return_v = this_param.GetType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 75336, 75350);
            return return_v;
        }


        string
        f_1292_75336_75359(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 75336, 75359);
            return return_v;
        }


        System.Management.Automation.ExtendedTypeSystemException
        f_1292_75166_75360(string
        errorId, System.Exception
        innerException, string
        resourceString, params object[]
        arguments)
        {
            var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 75166, 75360);
            return return_v;
        }

    }
    public class PSCodeMethod : PSMethodInfo
    {
        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 75962, 76367);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 76020, 76068);

                StringBuilder
                returnValue = f_1292_76048_76067()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 76082, 76250);
                    foreach (string overload in f_1292_76110_76129_I(f_1292_76110_76129()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 76082, 76250);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 76163, 76192);

                        f_1292_76163_76191(returnValue, overload);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 76210, 76235);

                        f_1292_76210_76234(returnValue, ", ");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 76082, 76250);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 169);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 76266, 76312);

                f_1292_76266_76311(
                            returnValue, f_1292_76285_76303(returnValue) - 2, 2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 76326, 76356);

                return f_1292_76333_76355(returnValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 75962, 76367);

                System.Text.StringBuilder
                f_1292_76048_76067()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 76048, 76067);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1292_76110_76129()
                {
                    var return_v = OverloadDefinitions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 76110, 76129);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_76163_76191(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 76163, 76191);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_76210_76234(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 76210, 76234);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1292_76110_76129_I(System.Collections.ObjectModel.Collection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 76110, 76129);
                    return return_v;
                }


                int
                f_1292_76285_76303(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 76285, 76303);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_76266_76311(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Remove(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 76266, 76311);
                    return return_v;
                }


                string
                f_1292_76333_76355(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 76333, 76355);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 75962, 76367);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 75962, 76367);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MethodInformation[] _codeReferenceMethodInformation;

        internal static bool CheckMethodInfo(MethodInfo method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 76451, 76787);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 76531, 76583);

                ParameterInfo[]
                parameters = f_1292_76560_76582(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 76597, 76776);

                return f_1292_76604_76619(method) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 76604, 76658) && f_1292_76643_76658(method)) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 76604, 76704) && f_1292_76682_76699(parameters) != 0
                ) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 76604, 76775) && f_1292_76728_76755(parameters[0]) == typeof(PSObject));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 76451, 76787);

                System.Reflection.ParameterInfo[]
                f_1292_76560_76582(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 76560, 76582);
                    return return_v;
                }


                bool
                f_1292_76604_76619(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.IsStatic
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 76604, 76619);
                    return return_v;
                }


                bool
                f_1292_76643_76658(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.IsPublic
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 76643, 76658);
                    return return_v;
                }


                int
                f_1292_76682_76699(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 76682, 76699);
                    return return_v;
                }


                System.Type
                f_1292_76728_76755(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 76728, 76755);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 76451, 76787);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 76451, 76787);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void SetCodeReference(Type type, string methodName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 76799, 77818);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 76884, 76917);

                MethodInfo
                methodAsMember = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 76969, 77082);

                    methodAsMember = f_1292_76986_77081(type, methodName, BindingFlags.Static | BindingFlags.Public | BindingFlags.IgnoreCase);
                }
                catch (AmbiguousMatchException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1292, 77111, 77321);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1292, 77111, 77321);
                    // Ignore the AmbiguousMatchException.
                    // We will generate error below if we cannot find exactly one match method.
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 77337, 77554) || true) && (methodAsMember == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 77337, 77554);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 77397, 77539);

                    throw f_1292_77403_77538("WrongMethodFormatFromTypeTable", null, f_1292_77496_77537());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 77337, 77554);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 77570, 77601);

                CodeReference = methodAsMember;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 77615, 77807) || true) && (!f_1292_77620_77650(f_1292_77636_77649()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 77615, 77807);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 77684, 77792);

                    throw f_1292_77690_77791("WrongMethodFormat", null, f_1292_77749_77790());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 77615, 77807);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 76799, 77818);

                System.Reflection.MethodInfo?
                f_1292_76986_77081(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetMethod(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 76986, 77081);
                    return return_v;
                }


                string
                f_1292_77496_77537()
                {
                    var return_v = ExtendedTypeSystem.CodeMethodMethodFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 77496, 77537);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1292_77403_77538(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 77403, 77538);
                    return return_v;
                }


                System.Reflection.MethodInfo
                f_1292_77636_77649()
                {
                    var return_v = CodeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 77636, 77649);
                    return return_v;
                }


                bool
                f_1292_77620_77650(System.Reflection.MethodInfo
                method)
                {
                    var return_v = CheckMethodInfo(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 77620, 77650);
                    return return_v;
                }


                string
                f_1292_77749_77790()
                {
                    var return_v = ExtendedTypeSystem.CodeMethodMethodFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 77749, 77790);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1292_77690_77791(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 77690, 77791);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 76799, 77818);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 76799, 77818);
            }
        }

        internal PSCodeMethod(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 77911, 78142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 76407, 76438);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 79447, 79500);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 77970, 78098) || true) && (f_1292_77974_78000(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 77970, 78098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 78034, 78083);

                    throw f_1292_78040_78082("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 77970, 78098);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 78114, 78131);

                this.name = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 77911, 78142);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 77911, 78142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 77911, 78142);
            }
        }

        public PSCodeMethod(string name, MethodInfo codeReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 78667, 79326);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 76407, 76438);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 79447, 79500);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 78750, 78878) || true) && (f_1292_78754_78780(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 78750, 78878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 78814, 78863);

                    throw f_1292_78820_78862("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 78750, 78878);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 78894, 79030) || true) && (codeReference == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 78894, 79030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 78953, 79015);

                    throw f_1292_78959_79014("codeReference");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 78894, 79030);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 79046, 79238) || true) && (!f_1292_79051_79081(codeReference))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 79046, 79238);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 79115, 79223);

                    throw f_1292_79121_79222("WrongMethodFormat", null, f_1292_79180_79221());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 79046, 79238);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 79254, 79271);

                this.name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 79285, 79315);

                CodeReference = codeReference;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 78667, 79326);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 78667, 79326);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 78667, 79326);
            }
        }

        public MethodInfo CodeReference { get; private set; }

        public override PSMemberInfo Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 79766, 79967);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 79826, 79886);

                PSCodeMethod
                member = f_1292_79848_79885(name, f_1292_79871_79884())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 79900, 79928);

                f_1292_79900_79927(this, member);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 79942, 79956);

                return member;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 79766, 79967);

                System.Reflection.MethodInfo
                f_1292_79871_79884()
                {
                    var return_v = CodeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 79871, 79884);
                    return return_v;
                }


                System.Management.Automation.PSCodeMethod
                f_1292_79848_79885(string
                name, System.Reflection.MethodInfo
                codeReference)
                {
                    var return_v = new System.Management.Automation.PSCodeMethod(name, codeReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 79848, 79885);
                    return return_v;
                }


                int
                f_1292_79900_79927(System.Management.Automation.PSCodeMethod
                this_param, System.Management.Automation.PSCodeMethod
                destiny)
                {
                    this_param.CloneBaseProperties((System.Management.Automation.PSMemberInfo)destiny);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 79900, 79927);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 79766, 79967);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 79766, 79967);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override PSMemberTypes MemberType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 80102, 80129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 80105, 80129);
                    return PSMemberTypes.CodeMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 80102, 80129);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 80102, 80129);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 80102, 80129);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override object Invoke(params object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 80833, 81803);
                object[] convertedArguments = default(object[]);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 80914, 81042) || true) && (arguments == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 80914, 81042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 80969, 81027);

                    throw f_1292_80975_81026("arguments");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 80914, 81042);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 81058, 81115);

                object[]
                newArguments = new object[f_1292_81093_81109(arguments) + 1]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 81129, 81161);

                newArguments[0] = this.instance;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 81184, 81189);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 81175, 81300) || true) && (i < f_1292_81195_81211(arguments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 81213, 81216)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 81175, 81300))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 81175, 81300);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 81250, 81285);

                        newArguments[i + 1] = arguments[i];
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 126);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 126);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 81316, 81507) || true) && (_codeReferenceMethodInformation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 81316, 81507);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 81393, 81492);

                    _codeReferenceMethodInformation = f_1292_81427_81491(new[] { f_1292_81475_81488() });
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 81316, 81507);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 81523, 81657);

                f_1292_81523_81656(f_1292_81557_81575(f_1292_81557_81570()), _codeReferenceMethodInformation, newArguments, out convertedArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 81673, 81792);

                return f_1292_81680_81791(null, convertedArguments, _codeReferenceMethodInformation[0], newArguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 80833, 81803);

                System.Management.Automation.PSArgumentNullException
                f_1292_80975_81026(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 80975, 81026);
                    return return_v;
                }


                int
                f_1292_81093_81109(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 81093, 81109);
                    return return_v;
                }


                int
                f_1292_81195_81211(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 81195, 81211);
                    return return_v;
                }


                System.Reflection.MethodInfo
                f_1292_81475_81488()
                {
                    var return_v = CodeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 81475, 81488);
                    return return_v;
                }


                System.Management.Automation.MethodInformation[]
                f_1292_81427_81491(System.Reflection.MethodInfo[]
                methods)
                {
                    var return_v = DotNetAdapter.GetMethodInformationArray((System.Reflection.MethodBase[])methods);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 81427, 81491);
                    return return_v;
                }


                System.Reflection.MethodInfo
                f_1292_81557_81570()
                {
                    var return_v = CodeReference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 81557, 81570);
                    return return_v;
                }


                string
                f_1292_81557_81575(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 81557, 81575);
                    return return_v;
                }


                System.Management.Automation.MethodInformation
                f_1292_81523_81656(string
                methodName, System.Management.Automation.MethodInformation[]
                methods, object[]
                arguments, out object[]
                newArguments)
                {
                    var return_v = Adapter.GetBestMethodAndArguments(methodName, methods, arguments, out newArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 81523, 81656);
                    return return_v;
                }


                object
                f_1292_81680_81791(object
                target, object[]
                arguments, System.Management.Automation.MethodInformation
                methodInformation, object[]
                originalArguments)
                {
                    var return_v = DotNetAdapter.AuxiliaryMethodInvoke(target, arguments, methodInformation, originalArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 81680, 81791);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 80833, 81803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 80833, 81803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Collection<string> OverloadDefinitions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 81969, 82099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 81972, 82099);
                    return new Collection<string>
        {
DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1292_82019_82088(null, f_1292_82071_82084(), 0),1292,81972,82099)        };
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 81969, 82099);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 81969, 82099);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 81969, 82099);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string TypeNameOfValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 82316, 82348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 82319, 82348);
                    return f_1292_82319_82348(typeof(PSCodeMethod));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 82316, 82348);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 82316, 82348);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 82316, 82348);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PSCodeMethod()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 75736, 82401);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 75736, 82401);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 75736, 82401);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 75736, 82401);

        bool
        f_1292_77974_78000(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 77974, 78000);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_78040_78082(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 78040, 78082);
            return return_v;
        }


        bool
        f_1292_78754_78780(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 78754, 78780);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_78820_78862(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 78820, 78862);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1292_78959_79014(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 78959, 79014);
            return return_v;
        }


        bool
        f_1292_79051_79081(System.Reflection.MethodInfo
        method)
        {
            var return_v = CheckMethodInfo(method);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 79051, 79081);
            return return_v;
        }


        string
        f_1292_79180_79221()
        {
            var return_v = ExtendedTypeSystem.CodeMethodMethodFormat;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 79180, 79221);
            return return_v;
        }


        System.Management.Automation.ExtendedTypeSystemException
        f_1292_79121_79222(string
        errorId, System.Exception
        innerException, string
        resourceString, params object[]
        arguments)
        {
            var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 79121, 79222);
            return return_v;
        }


        System.Reflection.MethodInfo
        f_1292_82071_82084()
        {
            var return_v = CodeReference;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 82071, 82084);
            return return_v;
        }


        string
        f_1292_82019_82088(string
        memberName, System.Reflection.MethodInfo
        methodEntry, int
        parametersToIgnore)
        {
            var return_v = DotNetAdapter.GetMethodInfoOverloadDefinition(memberName, (System.Reflection.MethodBase)methodEntry, parametersToIgnore);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 82019, 82088);
            return return_v;
        }


        string
        f_1292_82319_82348(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 82319, 82348);
            return return_v;
        }

    }
    public class PSScriptMethod : PSMethodInfo
    {
        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 82922, 83260);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 82980, 83028);

                StringBuilder
                returnValue = f_1292_83008_83027()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 83042, 83083);

                f_1292_83042_83082(returnValue, f_1292_83061_83081(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 83097, 83121);

                f_1292_83097_83120(returnValue, " ");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 83135, 83165);

                f_1292_83135_83164(returnValue, f_1292_83154_83163(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 83179, 83205);

                f_1292_83179_83204(returnValue, "();");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 83219, 83249);

                return f_1292_83226_83248(returnValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 82922, 83260);

                System.Text.StringBuilder
                f_1292_83008_83027()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 83008, 83027);
                    return return_v;
                }


                string
                f_1292_83061_83081(System.Management.Automation.PSScriptMethod
                this_param)
                {
                    var return_v = this_param.TypeNameOfValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 83061, 83081);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_83042_83082(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 83042, 83082);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_83097_83120(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 83097, 83120);
                    return return_v;
                }


                string
                f_1292_83154_83163(System.Management.Automation.PSScriptMethod
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 83154, 83163);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_83135_83164(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 83135, 83164);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_83179_83204(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 83179, 83204);
                    return return_v;
                }


                string
                f_1292_83226_83248(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 83226, 83248);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 82922, 83260);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 82922, 83260);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private readonly ScriptBlock _script;

        private bool _shouldCloneOnAccess;

        public ScriptBlock Script
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 83525, 84233);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 83561, 84218) || true) && (_shouldCloneOnAccess)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 83561, 84218);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 83953, 83993);

                        ScriptBlock
                        newScript = f_1292_83977_83992(_script)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 84015, 84061);

                        newScript.LanguageMode = f_1292_84040_84060(_script);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 84085, 84102);

                        return newScript;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 83561, 84218);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 83561, 84218);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 84184, 84199);

                        return _script;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 83561, 84218);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 83525, 84233);

                    System.Management.Automation.ScriptBlock
                    f_1292_83977_83992(System.Management.Automation.ScriptBlock
                    this_param)
                    {
                        var return_v = this_param.Clone();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 83977, 83992);
                        return return_v;
                    }


                    System.Management.Automation.PSLanguageMode?
                    f_1292_84040_84060(System.Management.Automation.ScriptBlock
                    this_param)
                    {
                        var return_v = this_param.LanguageMode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 84040, 84060);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 83475, 84244);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 83475, 84244);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PSScriptMethod(string name, ScriptBlock script)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 84591, 84933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 83301, 83308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 83332, 83352);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 84670, 84798) || true) && (f_1292_84674_84700(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 84670, 84798);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 84734, 84783);

                    throw f_1292_84740_84782("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 84670, 84798);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 84814, 84831);

                this.name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 84847, 84922);

                _script = script ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.ScriptBlock>(1292, 84857, 84921) ?? throw f_1292_84873_84921("script"));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 84591, 84933);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 84591, 84933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 84591, 84933);
            }
        }

        internal PSScriptMethod(string name, ScriptBlock script, bool shouldCloneOnAccess)
        : this(f_1292_85542_85546_C(name), script)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 85439, 85634);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 85580, 85623);

                _shouldCloneOnAccess = shouldCloneOnAccess;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 85439, 85634);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 85439, 85634);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 85439, 85634);
            }
        }

        public override object Invoke(params object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 86160, 86457);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 86241, 86369) || true) && (arguments == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 86241, 86369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 86296, 86354);

                    throw f_1292_86302_86353("arguments");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 86241, 86369);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 86385, 86446);

                return f_1292_86392_86445(f_1292_86405_86409(), _script, this.instance, arguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 86160, 86457);

                System.Management.Automation.PSArgumentNullException
                f_1292_86302_86353(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 86302, 86353);
                    return return_v;
                }


                string
                f_1292_86405_86409()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 86405, 86409);
                    return return_v;
                }


                object
                f_1292_86392_86445(string
                methodName, System.Management.Automation.ScriptBlock
                script, object
                @this, object[]
                arguments)
                {
                    var return_v = InvokeScript(methodName, script, @this, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 86392, 86445);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 86160, 86457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 86160, 86457);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object InvokeScript(string methodName, ScriptBlock script, object @this, object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 86469, 88234);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 86638, 87002);

                    return f_1292_86645_87001(script, useLocalScope: true, errorHandlingBehavior: ScriptBlock.ErrorHandlingBehavior.WriteToExternalErrorPipe, dollarUnder: f_1292_86852_86872(), input: f_1292_86902_86922(), scriptThis: @this, args: arguments);
                }
                catch (RuntimeException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1292, 87031, 87348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 87090, 87333);

                    throw f_1292_87096_87332("ScriptMethodRuntimeException", e, f_1292_87225_87269(), methodName, f_1292_87304_87320(arguments), f_1292_87322_87331(e));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1292, 87031, 87348);
                }
                catch (TerminateException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1292, 87362, 87533);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 87512, 87518);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1292, 87362, 87533);
                }
                catch (FlowControlException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1292, 87547, 87872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 87610, 87857);

                    throw f_1292_87616_87856("ScriptMethodFlowControlException", e, f_1292_87749_87793(), methodName, f_1292_87828_87844(arguments), f_1292_87846_87855(e));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1292, 87547, 87872);
                }
                catch (PSInvalidOperationException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1292, 87886, 88223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 87956, 88208);

                    throw f_1292_87962_88207("ScriptMethodInvalidOperationException", e, f_1292_88100_88144(), methodName, f_1292_88179_88195(arguments), f_1292_88197_88206(e));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1292, 87886, 88223);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 86469, 88234);

                System.Management.Automation.PSObject
                f_1292_86852_86872()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 86852, 86872);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1292_86902_86922()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 86902, 86922);
                    return return_v;
                }


                object
                f_1292_86645_87001(System.Management.Automation.ScriptBlock
                this_param, bool
                useLocalScope, System.Management.Automation.ScriptBlock.ErrorHandlingBehavior
                errorHandlingBehavior, System.Management.Automation.PSObject
                dollarUnder, System.Management.Automation.PSObject
                input, object
                scriptThis, object[]
                args)
                {
                    var return_v = this_param.DoInvokeReturnAsIs(useLocalScope: useLocalScope, errorHandlingBehavior: errorHandlingBehavior, dollarUnder: (object)dollarUnder, input: (object)input, scriptThis: scriptThis, args: args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 86645, 87001);
                    return return_v;
                }


                string
                f_1292_87225_87269()
                {
                    var return_v = ExtendedTypeSystem.MethodInvocationException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 87225, 87269);
                    return return_v;
                }


                int
                f_1292_87304_87320(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 87304, 87320);
                    return return_v;
                }


                string
                f_1292_87322_87331(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 87322, 87331);
                    return return_v;
                }


                System.Management.Automation.MethodInvocationException
                f_1292_87096_87332(string
                errorId, System.Management.Automation.RuntimeException
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.MethodInvocationException(errorId, (System.Exception)innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 87096, 87332);
                    return return_v;
                }


                string
                f_1292_87749_87793()
                {
                    var return_v = ExtendedTypeSystem.MethodInvocationException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 87749, 87793);
                    return return_v;
                }


                int
                f_1292_87828_87844(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 87828, 87844);
                    return return_v;
                }


                string
                f_1292_87846_87855(System.Management.Automation.FlowControlException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 87846, 87855);
                    return return_v;
                }


                System.Management.Automation.MethodInvocationException
                f_1292_87616_87856(string
                errorId, System.Management.Automation.FlowControlException
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.MethodInvocationException(errorId, (System.Exception)innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 87616, 87856);
                    return return_v;
                }


                string
                f_1292_88100_88144()
                {
                    var return_v = ExtendedTypeSystem.MethodInvocationException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 88100, 88144);
                    return return_v;
                }


                int
                f_1292_88179_88195(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 88179, 88195);
                    return return_v;
                }


                string
                f_1292_88197_88206(System.Management.Automation.PSInvalidOperationException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 88197, 88206);
                    return return_v;
                }


                System.Management.Automation.MethodInvocationException
                f_1292_87962_88207(string
                errorId, System.Management.Automation.PSInvalidOperationException
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.MethodInvocationException(errorId, (System.Exception)innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 87962, 88207);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 86469, 88234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 86469, 88234);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Collection<string> OverloadDefinitions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 88435, 88593);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 88471, 88544);

                    Collection<string>
                    retValue = new Collection<string> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1292_88526_88541(this), 1292, 88501, 88543) }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 88562, 88578);

                    return retValue;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 88435, 88593);

                    string
                    f_1292_88526_88541(System.Management.Automation.PSScriptMethod
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 88526, 88541);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 88356, 88604);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 88356, 88604);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override PSMemberInfo Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 88828, 89069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 88888, 88988);

                var
                method = new PSScriptMethod(this.name, _script) { _shouldCloneOnAccess = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => _shouldCloneOnAccess, 1292, 88901, 88987) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 89002, 89030);

                f_1292_89002_89029(this, method);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 89044, 89058);

                return method;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 88828, 89069);

                int
                f_1292_89002_89029(System.Management.Automation.PSScriptMethod
                this_param, System.Management.Automation.PSScriptMethod
                destiny)
                {
                    this_param.CloneBaseProperties((System.Management.Automation.PSMemberInfo)destiny);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 89002, 89029);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 88828, 89069);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 88828, 89069);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override PSMemberTypes MemberType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 89204, 89233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 89207, 89233);
                    return PSMemberTypes.ScriptMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 89204, 89233);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 89204, 89233);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 89204, 89233);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string TypeNameOfValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 89444, 89470);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 89447, 89470);
                    return f_1292_89447_89470(typeof(object));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 89444, 89470);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 89444, 89470);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 89444, 89470);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PSScriptMethod()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 82694, 89523);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 82694, 89523);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 82694, 89523);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 82694, 89523);

        bool
        f_1292_84674_84700(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 84674, 84700);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_84740_84782(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 84740, 84782);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1292_84873_84921(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 84873, 84921);
            return return_v;
        }


        static string
        f_1292_85542_85546_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1292, 85439, 85634);
            return return_v;
        }


        string
        f_1292_89447_89470(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 89447, 89470);
            return return_v;
        }

    }
    public class PSMethod : PSMethodInfo
    {
        internal override void ReplicateInstance(object particularInstance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 89881, 90073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 89973, 90016);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ReplicateInstance(particularInstance), 1292, 89973, 90015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 90030, 90062);

                baseObject = particularInstance;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 89881, 90073);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 89881, 90073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 89881, 90073);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 90254, 90364);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 90312, 90353);

                return f_1292_90319_90352(_adapter, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 90254, 90364);

                string
                f_1292_90319_90352(System.Management.Automation.Adapter
                this_param, System.Management.Automation.PSMethod
                method)
                {
                    var return_v = this_param.BaseMethodToString(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 90319, 90352);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 90254, 90364);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 90254, 90364);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object adapterData;

        internal Adapter _adapter;

        internal object baseObject;

        internal PSMethod(string name, Adapter adapter, object baseObject, object adapterData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 90936, 91345);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 90392, 90403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 90431, 90439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 90466, 90476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 95360, 95392);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 91047, 91175) || true) && (f_1292_91051_91077(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 91047, 91175);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 91111, 91160);

                    throw f_1292_91117_91159("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 91047, 91175);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 91191, 91208);

                this.name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 91222, 91253);

                this.adapterData = adapterData;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 91267, 91291);

                this._adapter = adapter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 91305, 91334);

                this.baseObject = baseObject;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 90936, 91345);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 90936, 91345);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 90936, 91345);
            }
        }

        internal PSMethod(string name, Adapter adapter, object baseObject, object adapterData, bool isSpecial, bool isHidden)
        : this(f_1292_92136_92140_C(name), adapter, baseObject, adapterData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 91998, 92277);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 92200, 92227);

                this.IsSpecial = isSpecial;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 92241, 92266);

                this.IsHidden = isHidden;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 91998, 92277);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 91998, 92277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 91998, 92277);
            }
        }

        public override PSMemberInfo Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 92543, 92802);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 92603, 92721);

                PSMethod
                member = f_1292_92621_92720(this.name, _adapter, this.baseObject, this.adapterData, f_1292_92690_92704(this), f_1292_92706_92719(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 92735, 92763);

                f_1292_92735_92762(this, member);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 92777, 92791);

                return member;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 92543, 92802);

                bool
                f_1292_92690_92704(System.Management.Automation.PSMethod
                this_param)
                {
                    var return_v = this_param.IsSpecial;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 92690, 92704);
                    return return_v;
                }


                bool
                f_1292_92706_92719(System.Management.Automation.PSMethod
                this_param)
                {
                    var return_v = this_param.IsHidden;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 92706, 92719);
                    return return_v;
                }


                System.Management.Automation.PSMethod
                f_1292_92621_92720(string
                name, System.Management.Automation.Adapter
                adapter, object
                baseObject, object
                adapterData, bool
                isSpecial, bool
                isHidden)
                {
                    var return_v = new System.Management.Automation.PSMethod(name, adapter, baseObject, adapterData, isSpecial, isHidden);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 92621, 92720);
                    return return_v;
                }


                int
                f_1292_92735_92762(System.Management.Automation.PSMethod
                this_param, System.Management.Automation.PSMethod
                destiny)
                {
                    this_param.CloneBaseProperties((System.Management.Automation.PSMemberInfo)destiny);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 92735, 92762);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 92543, 92802);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 92543, 92802);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override PSMemberTypes MemberType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 92937, 92960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 92940, 92960);
                    return PSMemberTypes.Method;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 92937, 92960);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 92937, 92960);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 92937, 92960);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override object Invoke(params object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 93562, 93690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 93643, 93679);

                return f_1292_93650_93678(this, null, arguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 93562, 93690);

                object
                f_1292_93650_93678(System.Management.Automation.PSMethod
                this_param, System.Management.Automation.PSMethodInvocationConstraints
                invocationConstraints, params object[]
                arguments)
                {
                    var return_v = this_param.Invoke(invocationConstraints, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 93650, 93678);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 93562, 93690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 93562, 93690);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object Invoke(PSMethodInvocationConstraints invocationConstraints, params object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 94361, 94716);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 94488, 94616) || true) && (arguments == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 94488, 94616);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 94543, 94601);

                    throw f_1292_94549_94600("arguments");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 94488, 94616);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 94632, 94705);

                return f_1292_94639_94704(_adapter, this, invocationConstraints, arguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 94361, 94716);

                System.Management.Automation.PSArgumentNullException
                f_1292_94549_94600(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 94549, 94600);
                    return return_v;
                }


                object
                f_1292_94639_94704(System.Management.Automation.Adapter
                this_param, System.Management.Automation.PSMethod
                method, System.Management.Automation.PSMethodInvocationConstraints
                invocationConstraints, params object[]
                arguments)
                {
                    var return_v = this_param.BaseMethodInvoke(method, invocationConstraints, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 94639, 94704);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 94361, 94716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 94361, 94716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Collection<string> OverloadDefinitions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 94893, 94932);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 94896, 94932);
                    return f_1292_94896_94932(_adapter, this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 94893, 94932);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 94893, 94932);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 94893, 94932);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string TypeNameOfValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 95135, 95163);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 95138, 95163);
                    return f_1292_95138_95163(typeof(PSMethod));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 95135, 95163);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 95135, 95163);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 95135, 95163);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsSpecial { get; }

        internal static PSMethod Create(string name, DotNetAdapter dotNetInstanceAdapter, object baseObject, DotNetAdapter.MethodCacheEntry method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 95404, 95656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 95568, 95645);

                return f_1292_95575_95644(name, dotNetInstanceAdapter, baseObject, method, false, false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 95404, 95656);

                System.Management.Automation.PSMethod
                f_1292_95575_95644(string
                name, System.Management.Automation.DotNetAdapter
                dotNetInstanceAdapter, object
                baseObject, System.Management.Automation.DotNetAdapter.MethodCacheEntry
                method, bool
                isSpecial, bool
                isHidden)
                {
                    var return_v = Create(name, dotNetInstanceAdapter, baseObject, method, isSpecial, isHidden);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 95575, 95644);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 95404, 95656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 95404, 95656);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSMethod Create(string name, DotNetAdapter dotNetInstanceAdapter, object baseObject, DotNetAdapter.MethodCacheEntry method, bool isSpecial, bool isHidden)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 95668, 96461);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 95863, 96150) || true) && (f_1292_95867_95876(method, 0).method is ConstructorInfo)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 95863, 96150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 96045, 96135);

                    return f_1292_96052_96134(name, dotNetInstanceAdapter, baseObject, method, isSpecial, isHidden);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 95863, 96150);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 96166, 96330) || true) && (method.PSMethodCtor == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 96166, 96330);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 96231, 96315);

                    method.PSMethodCtor = f_1292_96253_96314(method.methodInformationStructures);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 96166, 96330);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 96346, 96450);

                // LAFHIS
                var temp = method.PSMethodCtor.Invoke(name, dotNetInstanceAdapter, baseObject, method, isSpecial, isHidden);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 96353, 96449);
                return temp;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 95668, 96461);

                System.Management.Automation.MethodInformation
                f_1292_95867_95876(System.Management.Automation.DotNetAdapter.MethodCacheEntry
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 95867, 95876);
                    return return_v;
                }


                System.Management.Automation.PSMethod
                f_1292_96052_96134(string
                name, System.Management.Automation.DotNetAdapter
                adapter, object
                baseObject, System.Management.Automation.DotNetAdapter.MethodCacheEntry
                adapterData, bool
                isSpecial, bool
                isHidden)
                {
                    var return_v = new System.Management.Automation.PSMethod(name, (System.Management.Automation.Adapter)adapter, baseObject, (object)adapterData, isSpecial, isHidden);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 96052, 96134);
                    return return_v;
                }


                System.Func<string, System.Management.Automation.DotNetAdapter, object, object, bool, bool, System.Management.Automation.PSMethod>
                f_1292_96253_96314(System.Management.Automation.MethodInformation[]
                methods)
                {
                    var return_v = CreatePSMethodConstructor(methods);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 96253, 96314);
                    return return_v;
                }


                System.Management.Automation.PSMethod
                f_1292_96353_96449(System.Management.Automation.DotNetAdapter.MethodCacheEntry
                this_param, string
                arg1, System.Management.Automation.DotNetAdapter
                arg2, object
                arg3, System.Management.Automation.DotNetAdapter.MethodCacheEntry
                arg4, bool
                arg5, bool
                arg6)
                {
                    var return_v = this_param.PSMethodCtor(arg1, arg2, arg3, arg4, arg5, arg6);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 96353, 96449);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 95668, 96461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 95668, 96461);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Type GetMethodGroupType(MethodInfo methodInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 96473, 99620);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 96559, 96797) || true) && (f_1292_96563_96611(f_1292_96563_96587(methodInfo)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 96559, 96797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 96743, 96782);

                    return typeof(Func<PSNonBindableType>);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 96559, 96797);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 96813, 98595) || true) && (f_1292_96817_96853(methodInfo))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 96813, 98595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 98541, 98580);

                    return typeof(Func<PSNonBindableType>);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 96813, 98595);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 98611, 98659);

                var
                parameterInfos = f_1292_98632_98658(methodInfo)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 98673, 98854) || true) && (f_1292_98677_98698(parameterInfos) > 16)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 98673, 98854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 98800, 98839);

                    return typeof(Func<PSNonBindableType>);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 98673, 98854);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 98906, 98960);

                    var
                    methodTypes = new Type[f_1292_98933_98954(parameterInfos) + 1]
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 98987, 98992);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 98978, 99294) || true) && (i < f_1292_98998_99019(parameterInfos))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 99021, 99024)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 98978, 99294))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 98978, 99294);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 99066, 99104);

                            var
                            parameterInfo = parameterInfos[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 99126, 99175);

                            Type
                            parameterType = f_1292_99147_99174(parameterInfo)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 99197, 99275);

                            methodTypes[i] = f_1292_99214_99274(parameterType, f_1292_99254_99273(parameterInfo));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 317);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 317);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 99314, 99399);

                    methodTypes[f_1292_99326_99347(parameterInfos)] = f_1292_99351_99398(f_1292_99376_99397(methodInfo));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 99419, 99468);

                    return f_1292_99426_99467(methodTypes);
                }
                catch (TypeLoadException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1292, 99497, 99609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 99555, 99594);

                    return typeof(Func<PSNonBindableType>);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1292, 99497, 99609);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 96473, 99620);

                System.Type
                f_1292_96563_96587(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.DeclaringType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 96563, 96587);
                    return return_v;
                }


                bool
                f_1292_96563_96611(System.Type
                this_param)
                {
                    var return_v = this_param.IsGenericTypeDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 96563, 96611);
                    return return_v;
                }


                bool
                f_1292_96817_96853(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.IsGenericMethodDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 96817, 96853);
                    return return_v;
                }


                System.Reflection.ParameterInfo[]
                f_1292_98632_98658(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 98632, 98658);
                    return return_v;
                }


                int
                f_1292_98677_98698(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 98677, 98698);
                    return return_v;
                }


                int
                f_1292_98933_98954(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 98933, 98954);
                    return return_v;
                }


                int
                f_1292_98998_99019(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 98998, 99019);
                    return return_v;
                }


                System.Type
                f_1292_99147_99174(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 99147, 99174);
                    return return_v;
                }


                bool
                f_1292_99254_99273(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.IsOut;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 99254, 99273);
                    return return_v;
                }


                System.Type
                f_1292_99214_99274(System.Type
                type, bool
                isOut)
                {
                    var return_v = GetPSMethodProjectedType(type, isOut);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 99214, 99274);
                    return return_v;
                }


                int
                f_1292_99326_99347(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 99326, 99347);
                    return return_v;
                }


                System.Type
                f_1292_99376_99397(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 99376, 99397);
                    return return_v;
                }


                System.Type
                f_1292_99351_99398(System.Type
                type)
                {
                    var return_v = GetPSMethodProjectedType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 99351, 99398);
                    return return_v;
                }


                System.Type
                f_1292_99426_99467(System.Type[]
                types)
                {
                    var return_v = DelegateHelpers.MakeDelegate(types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 99426, 99467);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 96473, 99620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 96473, 99620);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Type GetPSMethodProjectedType(Type type, bool isOut = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 99632, 100538);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 99732, 99825) || true) && (type == typeof(void))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 99732, 99825);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 99790, 99810);

                    return typeof(VOID);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 99732, 99825);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 99841, 99956) || true) && (type == typeof(TypedReference))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 99841, 99956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 99909, 99941);

                    return typeof(PSTypedReference);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 99841, 99956);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 99972, 100499) || true) && (f_1292_99976_99988(type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 99972, 100499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 100022, 100088);

                    var
                    elementType = f_1292_100040_100087(f_1292_100065_100086(type))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 100106, 100258);

                    type = (DynAbs.Tracing.TraceSender.Conditional_F1(1292, 100113, 100118) || ((isOut && DynAbs.Tracing.TraceSender.Conditional_F2(1292, 100121, 100174)) || DynAbs.Tracing.TraceSender.Conditional_F3(1292, 100207, 100257))) ? f_1292_100121_100174(typeof(PSOutParameter<>), elementType) : f_1292_100207_100257(typeof(PSReference<>), elementType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 99972, 100499);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 99972, 100499);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 100292, 100499) || true) && (f_1292_100296_100310(type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 100292, 100499);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 100344, 100410);

                        var
                        elementType = f_1292_100362_100409(f_1292_100387_100408(type))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 100428, 100484);

                        type = f_1292_100435_100483(typeof(PSPointer<>), elementType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 100292, 100499);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 99972, 100499);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 100515, 100527);

                return type;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 99632, 100538);

                bool
                f_1292_99976_99988(System.Type
                this_param)
                {
                    var return_v = this_param.IsByRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 99976, 99988);
                    return return_v;
                }


                System.Type?
                f_1292_100065_100086(System.Type
                this_param)
                {
                    var return_v = this_param.GetElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 100065, 100086);
                    return return_v;
                }


                System.Type
                f_1292_100040_100087(System.Type
                type)
                {
                    var return_v = GetPSMethodProjectedType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 100040, 100087);
                    return return_v;
                }


                System.Type
                f_1292_100121_100174(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 100121, 100174);
                    return return_v;
                }


                System.Type
                f_1292_100207_100257(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 100207, 100257);
                    return return_v;
                }


                bool
                f_1292_100296_100310(System.Type
                this_param)
                {
                    var return_v = this_param.IsPointer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 100296, 100310);
                    return return_v;
                }


                System.Type?
                f_1292_100387_100408(System.Type
                this_param)
                {
                    var return_v = this_param.GetElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 100387, 100408);
                    return return_v;
                }


                System.Type
                f_1292_100362_100409(System.Type
                type)
                {
                    var return_v = GetPSMethodProjectedType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 100362, 100409);
                    return return_v;
                }


                System.Type
                f_1292_100435_100483(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 100435, 100483);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 99632, 100538);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 99632, 100538);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Func<string, DotNetAdapter, object, object, bool, bool, PSMethod> CreatePSMethodConstructor(MethodInformation[] methods)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 100550, 101485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 100778, 100815);

                var
                types = new Type[f_1292_100799_100813(methods)]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 100838, 100843);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 100829, 100978) || true) && (i < f_1292_100849_100863(methods))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 100865, 100868)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 100829, 100978))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 100829, 100978);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 100902, 100963);

                        types[i] = f_1292_100913_100962(methods[i].method);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 150);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 150);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 100994, 101058);

                var
                methodGroupType = f_1292_101016_101057(types, 0, f_1292_101044_101056(types))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 101072, 101144);

                Type
                psMethodType = f_1292_101092_101143(typeof(PSMethod<>), methodGroupType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 101158, 101251);

                var
                delegateType = typeof(Func<string, DotNetAdapter, object, object, bool, bool, PSMethod>)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 101265, 101474);

                return (Func<string, DotNetAdapter, object, object, bool, bool, PSMethod>)f_1292_101339_101473(delegateType, f_1292_101394_101472(psMethodType, "Create", BindingFlags.NonPublic | BindingFlags.Static));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 100550, 101485);

                int
                f_1292_100799_100813(System.Management.Automation.MethodInformation[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 100799, 100813);
                    return return_v;
                }


                int
                f_1292_100849_100863(System.Management.Automation.MethodInformation[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 100849, 100863);
                    return return_v;
                }


                System.Type
                f_1292_100913_100962(System.Reflection.MethodBase
                methodInfo)
                {
                    var return_v = GetMethodGroupType((System.Reflection.MethodInfo)methodInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 100913, 100962);
                    return return_v;
                }


                int
                f_1292_101044_101056(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 101044, 101056);
                    return return_v;
                }


                System.Type
                f_1292_101016_101057(System.Type[]
                sourceTypes, int
                start, int
                count)
                {
                    var return_v = CreateMethodGroup(sourceTypes, start, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 101016, 101057);
                    return return_v;
                }


                System.Type
                f_1292_101092_101143(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 101092, 101143);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_1292_101394_101472(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetMethod(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 101394, 101472);
                    return return_v;
                }


                System.Delegate
                f_1292_101339_101473(System.Type
                type, System.Reflection.MethodInfo
                method)
                {
                    var return_v = Delegate.CreateDelegate(type, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 101339, 101473);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 100550, 101485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 100550, 101485);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Type CreateMethodGroup(Type[] sourceTypes, int start, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 101497, 103799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 101601, 101625);

                var
                types = sourceTypes
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 101639, 101809) || true) && (count != f_1292_101652_101670(sourceTypes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 101639, 101809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 101704, 101728);

                    types = new Type[count];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 101746, 101794);

                    f_1292_101746_101793(sourceTypes, start, types, 0, count);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 101639, 101809);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 101825, 103788);

                switch (count)
                {

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 101825, 103788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 101880, 101932);

                        return f_1292_101887_101931(typeof(MethodGroup<>), types);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 101825, 103788);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 101825, 103788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 101958, 102011);

                        return f_1292_101965_102010(typeof(MethodGroup<,>), types);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 101825, 103788);

                    case 3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 101825, 103788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 102037, 102125);

                        return f_1292_102044_102124(typeof(MethodGroup<,>), types[0], f_1292_102093_102123(types, 1, 2));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 101825, 103788);

                    case 4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 101825, 103788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 102151, 102206);

                        return f_1292_102158_102205(typeof(MethodGroup<,,,>), types);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 101825, 103788);

                    case int i when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 102235, 102245) || true) && (i < 8) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 102235, 102245) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 101825, 103788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 102247, 102361);

                        return f_1292_102254_102360(typeof(MethodGroup<,,,>), types[0], types[1], types[2], f_1292_102325_102359(types, 3, i - 3));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 101825, 103788);

                    case 8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 101825, 103788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 102387, 102446);

                        return f_1292_102394_102445(typeof(MethodGroup<,,,,,,,>), types);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 101825, 103788);

                    case int i when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 102475, 102486) || true) && (i < 16) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 102475, 102486) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 101825, 103788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 102509, 102667);

                        return f_1292_102516_102666(typeof(MethodGroup<,,,,,,,>), types[0], types[1], types[2], types[3], types[4], types[5], types[6], f_1292_102631_102665(types, 7, i - 7));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 101825, 103788);

                    case 16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 101825, 103788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 102694, 102761);

                        return f_1292_102701_102760(typeof(MethodGroup<,,,,,,,,,,,,,,,>), types);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 101825, 103788);

                    case int i when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 102790, 102801) || true) && (i < 32) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 102790, 102801) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 101825, 103788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 102824, 103102);

                        return f_1292_102831_103101(typeof(MethodGroup<,,,,,,,,,,,,,,,>), types[0], types[1], types[2], types[3], types[4], types[5], types[6], types[7], types[8], types[9], types[10], types[11], types[12], types[13], types[14], f_1292_103064_103100(types, 15, i - 15));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 101825, 103788);

                    case 32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 101825, 103788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 103129, 103212);

                        return f_1292_103136_103211(typeof(MethodGroup<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>), types);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 101825, 103788);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 101825, 103788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 103260, 103773);

                        return f_1292_103267_103772(typeof(MethodGroup<,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,>), types[0], types[1], types[2], types[3], types[4], types[5], types[6], types[7], types[8], types[9], types[10], types[11], types[12], types[13], types[14], types[15], types[16], types[17], types[18], types[19], types[20], types[21], types[22], types[23], types[24], types[25], types[26], types[27], types[28], types[29], types[30], f_1292_103717_103771(sourceTypes, start + 31, count - 31));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 101825, 103788);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 101497, 103799);

                int
                f_1292_101652_101670(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 101652, 101670);
                    return return_v;
                }


                int
                f_1292_101746_101793(System.Type[]
                sourceArray, int
                sourceIndex, System.Type[]
                destinationArray, int
                destinationIndex, int
                length)
                {
                    Array.Copy((System.Array)sourceArray, sourceIndex, (System.Array)destinationArray, destinationIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 101746, 101793);
                    return 0;
                }


                System.Type
                f_1292_101887_101931(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 101887, 101931);
                    return return_v;
                }


                System.Type
                f_1292_101965_102010(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 101965, 102010);
                    return return_v;
                }


                System.Type
                f_1292_102093_102123(System.Type[]
                sourceTypes, int
                start, int
                count)
                {
                    var return_v = CreateMethodGroup(sourceTypes, start, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 102093, 102123);
                    return return_v;
                }


                System.Type
                f_1292_102044_102124(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 102044, 102124);
                    return return_v;
                }


                System.Type
                f_1292_102158_102205(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 102158, 102205);
                    return return_v;
                }


                System.Type
                f_1292_102325_102359(System.Type[]
                sourceTypes, int
                start, int
                count)
                {
                    var return_v = CreateMethodGroup(sourceTypes, start, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 102325, 102359);
                    return return_v;
                }


                System.Type
                f_1292_102254_102360(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 102254, 102360);
                    return return_v;
                }


                System.Type
                f_1292_102394_102445(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 102394, 102445);
                    return return_v;
                }


                System.Type
                f_1292_102631_102665(System.Type[]
                sourceTypes, int
                start, int
                count)
                {
                    var return_v = CreateMethodGroup(sourceTypes, start, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 102631, 102665);
                    return return_v;
                }


                System.Type
                f_1292_102516_102666(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 102516, 102666);
                    return return_v;
                }


                System.Type
                f_1292_102701_102760(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 102701, 102760);
                    return return_v;
                }


                System.Type
                f_1292_103064_103100(System.Type[]
                sourceTypes, int
                start, int
                count)
                {
                    var return_v = CreateMethodGroup(sourceTypes, start, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 103064, 103100);
                    return return_v;
                }


                System.Type
                f_1292_102831_103101(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 102831, 103101);
                    return return_v;
                }


                System.Type
                f_1292_103136_103211(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 103136, 103211);
                    return return_v;
                }


                System.Type
                f_1292_103717_103771(System.Type[]
                sourceTypes, int
                start, int
                count)
                {
                    var return_v = CreateMethodGroup(sourceTypes, start, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 103717, 103771);
                    return return_v;
                }


                System.Type
                f_1292_103267_103772(System.Type
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericType(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 103267, 103772);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 101497, 103799);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 101497, 103799);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSMethod()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 89828, 103806);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 89828, 103806);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 89828, 103806);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 89828, 103806);

        bool
        f_1292_91051_91077(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 91051, 91077);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_91117_91159(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 91117, 91159);
            return return_v;
        }


        static string
        f_1292_92136_92140_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1292, 91998, 92277);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<string>
        f_1292_94896_94932(System.Management.Automation.Adapter
        this_param, System.Management.Automation.PSMethod
        method)
        {
            var return_v = this_param.BaseMethodDefinitions(method);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 94896, 94932);
            return return_v;
        }


        string
        f_1292_95138_95163(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 95138, 95163);
            return return_v;
        }

    }
    internal abstract class PSNonBindableType
    {
        public PSNonBindableType()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 103814, 103869);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 103814, 103869);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 103814, 103869);
        }


        static PSNonBindableType()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 103814, 103869);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 103814, 103869);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 103814, 103869);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 103814, 103869);
    }
    internal class VOID
    {
        public VOID()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 103877, 103910);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 103877, 103910);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 103877, 103910);
        }


        static VOID()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 103877, 103910);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 103877, 103910);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 103877, 103910);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 103877, 103910);
    }
    internal class PSOutParameter<T>
    {
        public PSOutParameter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 103918, 103964);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 103918, 103964);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 103918, 103964);
        }


        static PSOutParameter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 103918, 103964);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 103918, 103964);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 103918, 103964);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 103918, 103964);
    }

    internal struct PSPointer<T>
    {
        static PSPointer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 103972, 104014);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 103972, 104014);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 103972, 104014);
        }
    }

    internal struct PSTypedReference
    {
        static PSTypedReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 104022, 104068);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 104022, 104068);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 104022, 104068);
        }
    }
    internal abstract class MethodGroup
    {
        public MethodGroup()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 104076, 104125);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 104076, 104125);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 104076, 104125);
        }


        static MethodGroup()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 104076, 104125);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 104076, 104125);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 104076, 104125);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 104076, 104125);
    }
    internal class MethodGroup<T1> : MethodGroup
    { }
    internal class MethodGroup<T1, T2> : MethodGroup
    { }
    internal class MethodGroup<T1, T2, T3, T4> : MethodGroup
    { }
    internal class MethodGroup<T1, T2, T3, T4, T5, T6, T7, T8> : MethodGroup
    { }
    internal class MethodGroup<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : MethodGroup
    { }
    internal class MethodGroup<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31,
            T32> : MethodGroup
    { }

    internal struct PSMethodSignatureEnumerator : IEnumerator<Type>
    {

        private int _currentIndex;

        private readonly Type _t;

        internal PSMethodSignatureEnumerator(Type t)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 104949, 105226);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 105018, 105108);

                f_1292_105018_105107(f_1292_105037_105069(t, typeof(PSMethod)), "Must be a PSMethod<MethodGroup<>>");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 105122, 105153);

                _t = f_1292_105127_105149(t)[0];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 105167, 105182);

                Current = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 105196, 105215);

                _currentIndex = -1;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 104949, 105226);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 104949, 105226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 104949, 105226);
            }
        }

        public bool MoveNext()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 105238, 105361);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 105285, 105301);

                _currentIndex++;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 105315, 105350);

                return MoveNext(_t, _currentIndex);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 105238, 105361);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 105238, 105361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 105238, 105361);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool MoveNext(Type type, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 105373, 106133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 105433, 105486);

                var
                genericTypeArguments = f_1292_105460_105485(type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 105500, 105541);

                var
                length = f_1292_105513_105540(genericTypeArguments)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 105555, 105694) || true) && (index < length - 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 105555, 105694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 105611, 105649);

                    Current = genericTypeArguments[index];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 105667, 105679);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 105555, 105694);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 105710, 105751);

                var
                t = genericTypeArguments[length - 1]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 105765, 105938) || true) && (f_1292_105769_105804(t, typeof(MethodGroup)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 105765, 105938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 105838, 105875);

                    var
                    remaining = index - (length - 1)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 105893, 105923);

                    return MoveNext(t, remaining);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 105765, 105938);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 105954, 106068) || true) && (index >= length)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 105954, 106068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 106007, 106022);

                    Current = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 106040, 106053);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 105954, 106068);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 106084, 106096);

                Current = t;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 106110, 106122);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 105373, 106133);

                System.Type[]
                f_1292_105460_105485(System.Type
                this_param)
                {
                    var return_v = this_param.GenericTypeArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 105460, 105485);
                    return return_v;
                }


                int
                f_1292_105513_105540(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 105513, 105540);
                    return return_v;
                }


                bool
                f_1292_105769_105804(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsSubclassOf(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 105769, 105804);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 105373, 106133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 105373, 106133);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Reset()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 106145, 106248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 106189, 106208);

                _currentIndex = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 106222, 106237);

                Current = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 106145, 106248);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 106145, 106248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 106145, 106248);
            }
        }

        public Type Current { get; private set; }

        object IEnumerator.Current
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 106340, 106350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 106343, 106350);
                    return Current;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 106340, 106350);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 106340, 106350);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 106340, 106350);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 106363, 106406);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 106363, 106406);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 106363, 106406);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 106363, 106406);
            }
        }
        static PSMethodSignatureEnumerator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 104796, 106413);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 104796, 106413);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 104796, 106413);
        }

        static bool
        f_1292_105037_105069(System.Type
        this_param, System.Type
        c)
        {
            var return_v = this_param.IsSubclassOf(c);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 105037, 105069);
            return return_v;
        }


        static int
        f_1292_105018_105107(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 105018, 105107);
            return 0;
        }


        static System.Type[]
        f_1292_105127_105149(System.Type
        this_param)
        {
            var return_v = this_param.GenericTypeArguments;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 105127, 105149);
            return return_v;
        }

    }
    internal sealed class PSMethod<T> : PSMethod
    {
        public override PSMemberInfo Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 106482, 106749);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 106542, 106668);

                PSMethod
                member = f_1292_106560_106667(this.name, this._adapter, this.baseObject, this.adapterData, f_1292_106637_106651(this), f_1292_106653_106666(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 106682, 106710);

                f_1292_106682_106709(this, member);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 106724, 106738);

                return member;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 106482, 106749);

                bool
                f_1292_106637_106651(System.Management.Automation.PSMethod<T>
                this_param)
                {
                    var return_v = this_param.IsSpecial;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 106637, 106651);
                    return return_v;
                }


                bool
                f_1292_106653_106666(System.Management.Automation.PSMethod<T>
                this_param)
                {
                    var return_v = this_param.IsHidden;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 106653, 106666);
                    return return_v;
                }


                System.Management.Automation.PSMethod<T>
                f_1292_106560_106667(string
                name, System.Management.Automation.Adapter
                adapter, object
                baseObject, object
                adapterData, bool
                isSpecial, bool
                isHidden)
                {
                    var return_v = new System.Management.Automation.PSMethod<T>(name, adapter, baseObject, adapterData, isSpecial, isHidden);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 106560, 106667);
                    return return_v;
                }


                int
                f_1292_106682_106709(System.Management.Automation.PSMethod<T>
                this_param, System.Management.Automation.PSMethod
                destiny)
                {
                    this_param.CloneBaseProperties((System.Management.Automation.PSMemberInfo)destiny);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 106682, 106709);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 106482, 106749);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 106482, 106749);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PSMethod(string name, Adapter adapter, object baseObject, object adapterData)
        : base(f_1292_106868_106872_C(name), adapter, baseObject, adapterData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 106761, 106929);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 106761, 106929);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 106761, 106929);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 106761, 106929);
            }
        }

        internal PSMethod(string name, Adapter adapter, object baseObject, object adapterData, bool isSpecial, bool isHidden)
        : base(f_1292_107079_107083_C(name), adapter, baseObject, adapterData, isSpecial, isHidden)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 106941, 107161);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 106941, 107161);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 106941, 107161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 106941, 107161);
            }
        }

        internal static PSMethod<T> Create(string name, Adapter adapter, object baseObject, object adapterData, bool isSpecial, bool isHidden)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 107311, 107565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 107470, 107554);

                return f_1292_107477_107553(name, adapter, baseObject, adapterData, isSpecial, isHidden);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 107311, 107565);

                System.Management.Automation.PSMethod<T>
                f_1292_107477_107553(string
                name, System.Management.Automation.Adapter
                adapter, object
                baseObject, object
                adapterData, bool
                isSpecial, bool
                isHidden)
                {
                    var return_v = new System.Management.Automation.PSMethod<T>(name, adapter, baseObject, adapterData, isSpecial, isHidden);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 107477, 107553);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 107311, 107565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 107311, 107565);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static string
        f_1292_106868_106872_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1292, 106761, 106929);
            return return_v;
        }


        static string
        f_1292_107079_107083_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1292, 106941, 107161);
            return return_v;
        }

    }
    public class PSParameterizedProperty : PSMethodInfo
    {
        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 108126, 108414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 108184, 108329);

                f_1292_108184_108328((this.baseObject != null) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 108203, 108254) && (this.adapter != null)) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 108203, 108284) && (this.adapterData != null)), "it should have all these properties set");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 108343, 108403);

                return f_1292_108350_108402(this.adapter, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 108126, 108414);

                int
                f_1292_108184_108328(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 108184, 108328);
                    return 0;
                }


                string
                f_1292_108350_108402(System.Management.Automation.Adapter
                this_param, System.Management.Automation.PSParameterizedProperty
                property)
                {
                    var return_v = this_param.BaseParameterizedPropertyToString(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 108350, 108402);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 108126, 108414);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 108126, 108414);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Adapter adapter;

        internal object adapterData;

        internal object baseObject;

        internal PSParameterizedProperty(string name, Adapter adapter, object baseObject, object adapterData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 109002, 109425);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 108443, 108450);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 108477, 108488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 108515, 108525);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 109128, 109256) || true) && (f_1292_109132_109158(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 109128, 109256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 109192, 109241);

                    throw f_1292_109198_109240("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 109128, 109256);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 109272, 109289);

                this.name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 109303, 109326);

                this.adapter = adapter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 109340, 109371);

                this.adapterData = adapterData;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 109385, 109414);

                this.baseObject = baseObject;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 109002, 109425);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 109002, 109425);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 109002, 109425);
            }
        }

        internal PSParameterizedProperty(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 109437, 109679);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 108443, 108450);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 108477, 108488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 108515, 108525);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 109507, 109635) || true) && (f_1292_109511_109537(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 109507, 109635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 109571, 109620);

                    throw f_1292_109577_109619("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 109507, 109635);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 109651, 109668);

                this.name = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 109437, 109679);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 109437, 109679);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 109437, 109679);
            }
        }

        public bool IsSettable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 109813, 109865);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 109816, 109865);
                    return f_1292_109816_109865(adapter, this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 109813, 109865);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 109813, 109865);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 109813, 109865);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsGettable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 110001, 110053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 110004, 110053);
                    return f_1292_110004_110053(adapter, this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 110001, 110053);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 110001, 110053);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 110001, 110053);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override object Invoke(params object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 110552, 110854);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 110633, 110761) || true) && (arguments == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 110633, 110761);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 110688, 110746);

                    throw f_1292_110694_110745("arguments");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 110633, 110761);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 110777, 110843);

                return f_1292_110784_110842(this.adapter, this, arguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 110552, 110854);

                System.Management.Automation.PSArgumentNullException
                f_1292_110694_110745(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 110694, 110745);
                    return return_v;
                }


                object
                f_1292_110784_110842(System.Management.Automation.Adapter
                this_param, System.Management.Automation.PSParameterizedProperty
                property, params object[]
                arguments)
                {
                    var return_v = this_param.BaseParameterizedPropertyGet(property, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 110784, 110842);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 110552, 110854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 110552, 110854);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void InvokeSet(object valueToSet, params object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 111304, 111622);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 111396, 111524) || true) && (arguments == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 111396, 111524);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 111451, 111509);

                    throw f_1292_111457_111508("arguments");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 111396, 111524);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 111540, 111611);

                f_1292_111540_111610(
                            this.adapter, this, valueToSet, arguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 111304, 111622);

                System.Management.Automation.PSArgumentNullException
                f_1292_111457_111508(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 111457, 111508);
                    return return_v;
                }


                int
                f_1292_111540_111610(System.Management.Automation.Adapter
                this_param, System.Management.Automation.PSParameterizedProperty
                property, object
                setValue, params object[]
                arguments)
                {
                    this_param.BaseParameterizedPropertySet(property, setValue, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 111540, 111610);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 111304, 111622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 111304, 111622);
            }
        }

        public override Collection<string> OverloadDefinitions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 111808, 111861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 111811, 111861);
                    return f_1292_111811_111861(adapter, this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 111808, 111861);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 111808, 111861);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 111808, 111861);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string TypeNameOfValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 112017, 112063);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 112020, 112063);
                    return f_1292_112020_112063(adapter, this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 112017, 112063);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 112017, 112063);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 112017, 112063);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override PSMemberInfo Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 112288, 112556);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 112348, 112471);

                PSParameterizedProperty
                property = f_1292_112383_112470(this.name, this.adapter, this.baseObject, this.adapterData)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 112485, 112515);

                f_1292_112485_112514(this, property);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 112529, 112545);

                return property;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 112288, 112556);

                System.Management.Automation.PSParameterizedProperty
                f_1292_112383_112470(string
                name, System.Management.Automation.Adapter
                adapter, object
                baseObject, object
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSParameterizedProperty(name, adapter, baseObject, adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 112383, 112470);
                    return return_v;
                }


                int
                f_1292_112485_112514(System.Management.Automation.PSParameterizedProperty
                this_param, System.Management.Automation.PSParameterizedProperty
                destiny)
                {
                    this_param.CloneBaseProperties((System.Management.Automation.PSMemberInfo)destiny);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 112485, 112514);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 112288, 112556);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 112288, 112556);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override PSMemberTypes MemberType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 112691, 112729);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 112694, 112729);
                    return PSMemberTypes.ParameterizedProperty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 112691, 112729);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 112691, 112729);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 112691, 112729);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PSParameterizedProperty()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 107889, 112782);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 107889, 112782);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 107889, 112782);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 107889, 112782);

        bool
        f_1292_109132_109158(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 109132, 109158);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_109198_109240(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 109198, 109240);
            return return_v;
        }


        bool
        f_1292_109511_109537(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 109511, 109537);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_109577_109619(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 109577, 109619);
            return return_v;
        }


        bool
        f_1292_109816_109865(System.Management.Automation.Adapter
        this_param, System.Management.Automation.PSParameterizedProperty
        property)
        {
            var return_v = this_param.BaseParameterizedPropertyIsSettable(property);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 109816, 109865);
            return return_v;
        }


        bool
        f_1292_110004_110053(System.Management.Automation.Adapter
        this_param, System.Management.Automation.PSParameterizedProperty
        property)
        {
            var return_v = this_param.BaseParameterizedPropertyIsGettable(property);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 110004, 110053);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<string>
        f_1292_111811_111861(System.Management.Automation.Adapter
        this_param, System.Management.Automation.PSParameterizedProperty
        property)
        {
            var return_v = this_param.BaseParameterizedPropertyDefinitions(property);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 111811, 111861);
            return return_v;
        }


        string
        f_1292_112020_112063(System.Management.Automation.Adapter
        this_param, System.Management.Automation.PSParameterizedProperty
        property)
        {
            var return_v = this_param.BaseParameterizedPropertyType(property);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 112020, 112063);
            return return_v;
        }

    }
    public class PSMemberSet : PSMemberInfo
    {
        internal override void ReplicateInstance(object particularInstance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 112922, 113206);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 113014, 113057);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ReplicateInstance(particularInstance), 1292, 113014, 113056);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 113071, 113195);
                    foreach (var member in f_1292_113094_113101_I(f_1292_113094_113101()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 113071, 113195);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 113135, 113180);

                        f_1292_113135_113179(member, particularInstance);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 113071, 113195);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 125);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 125);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 112922, 113206);

                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1292_113094_113101()
                {
                    var return_v = Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 113094, 113101);
                    return return_v;
                }


                int
                f_1292_113135_113179(System.Management.Automation.PSMemberInfo
                this_param, object
                particularInstance)
                {
                    this_param.ReplicateInstance(particularInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 113135, 113179);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1292_113094_113101_I(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 113094, 113101);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 112922, 113206);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 112922, 113206);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 113387, 113995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 113445, 113493);

                StringBuilder
                returnValue = f_1292_113473_113492()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 113507, 113532);

                f_1292_113507_113531(returnValue, " {");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 113548, 113716);
                    foreach (PSMemberInfo member in f_1292_113580_113592_I(f_1292_113580_113592(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 113548, 113716);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 113626, 113658);

                        f_1292_113626_113657(returnValue, f_1292_113645_113656(member));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 113676, 113701);

                        f_1292_113676_113700(returnValue, ", ");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 113548, 113716);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 169);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 113732, 113853) || true) && (f_1292_113736_113754(returnValue) > 2)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 113732, 113853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 113792, 113838);

                    f_1292_113792_113837(returnValue, f_1292_113811_113829(returnValue) - 2, 2);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 113732, 113853);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 113869, 113902);

                f_1292_113869_113901(
                            returnValue, 0, f_1292_113891_113900(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 113916, 113940);

                f_1292_113916_113939(returnValue, "}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 113954, 113984);

                return f_1292_113961_113983(returnValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 113387, 113995);

                System.Text.StringBuilder
                f_1292_113473_113492()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 113473, 113492);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_113507_113531(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 113507, 113531);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1292_113580_113592(System.Management.Automation.PSMemberSet
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 113580, 113592);
                    return return_v;
                }


                string
                f_1292_113645_113656(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 113645, 113656);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_113626_113657(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 113626, 113657);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_113676_113700(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 113676, 113700);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1292_113580_113592_I(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 113580, 113592);
                    return return_v;
                }


                int
                f_1292_113736_113754(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 113736, 113754);
                    return return_v;
                }


                int
                f_1292_113811_113829(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 113811, 113829);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_113792_113837(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Remove(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 113792, 113837);
                    return return_v;
                }


                string
                f_1292_113891_113900(System.Management.Automation.PSMemberSet
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 113891, 113900);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_113869_113901(System.Text.StringBuilder
                this_param, int
                index, string
                value)
                {
                    var return_v = this_param.Insert(index, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 113869, 113901);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_113916_113939(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 113916, 113939);
                    return return_v;
                }


                string
                f_1292_113961_113983(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 113961, 113983);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 113387, 113995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 113387, 113995);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private readonly PSMemberInfoIntegratingCollection<PSMemberInfo> _members;

        private readonly PSMemberInfoIntegratingCollection<PSPropertyInfo> _properties;

        private readonly PSMemberInfoIntegratingCollection<PSMethodInfo> _methods;

        internal PSMemberInfoInternalCollection<PSMemberInfo> internalMembers;

        private readonly PSObject _constructorPSObject;

        private static readonly Collection<CollectionEntry<PSMemberInfo>> s_emptyMemberCollection;

        private static readonly Collection<CollectionEntry<PSMethodInfo>> s_emptyMethodCollection;

        private static readonly Collection<CollectionEntry<PSPropertyInfo>> s_emptyPropertyCollection;

        public PSMemberSet(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 115137, 115790);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 114072, 114080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 114158, 114169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 114245, 114253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 114318, 114333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 114370, 114390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 121975, 121996);
                this.inheritMembers = true;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 115193, 115327) || true) && (f_1292_115197_115223(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 115193, 115327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 115257, 115312);

                    throw f_1292_115263_115311(nameof(name));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 115193, 115327);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 115343, 115360);

                this.name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 115374, 115448);

                this.internalMembers = f_1292_115397_115447();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 115462, 115556);

                _members = f_1292_115473_115555(this, s_emptyMemberCollection);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 115570, 115671);

                _properties = f_1292_115584_115670(this, s_emptyPropertyCollection);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 115685, 115779);

                _methods = f_1292_115696_115778(this, s_emptyMethodCollection);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 115137, 115790);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 115137, 115790);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 115137, 115790);
            }
        }

        public PSMemberSet(string name, IEnumerable<PSMemberInfo> members)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 116182, 117321);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 114072, 114080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 114158, 114169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 114245, 114253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 114318, 114333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 114370, 114390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 121975, 121996);
                this.inheritMembers = true;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 116273, 116407) || true) && (f_1292_116277_116303(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 116273, 116407);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 116337, 116392);

                    throw f_1292_116343_116391(nameof(name));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 116273, 116407);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 116423, 116440);

                this.name = name;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 116454, 116584) || true) && (members == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 116454, 116584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 116507, 116569);

                    throw f_1292_116513_116568(nameof(members));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 116454, 116584);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 116600, 116674);

                this.internalMembers = f_1292_116623_116673();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 116688, 116977);
                    foreach (PSMemberInfo member in f_1292_116720_116727_I(members))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 116688, 116977);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 116761, 116902) || true) && (member == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 116761, 116902);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 116821, 116883);

                            throw f_1292_116827_116882(nameof(members));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 116761, 116902);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 116922, 116962);

                        f_1292_116922_116961(
                                        this.internalMembers, f_1292_116947_116960(member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 116688, 116977);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 290);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 290);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 116993, 117087);

                _members = f_1292_117004_117086(this, s_emptyMemberCollection);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 117101, 117202);

                _properties = f_1292_117115_117201(this, s_emptyPropertyCollection);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 117216, 117310);

                _methods = f_1292_117227_117309(this, s_emptyMethodCollection);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 116182, 117321);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 116182, 117321);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 116182, 117321);
            }
        }

        internal PSMemberSet(string name, PSMemberInfoInternalCollection<PSMemberInfo> members)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 117842, 118561);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 114072, 114080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 114158, 114169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 114245, 114253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 114318, 114333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 114370, 114390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 121975, 121996);
                this.inheritMembers = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 117954, 118050);

                f_1292_117954_118049(!f_1292_117974_118000(name), "Caller needs to guarantee not null or empty.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 118064, 118139);

                f_1292_118064_118138(members != null, "Caller needs to guarantee not null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 118155, 118172);

                this.name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 118186, 118217);

                this.internalMembers = members;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 118233, 118327);

                _members = f_1292_118244_118326(this, s_emptyMemberCollection);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 118341, 118442);

                _properties = f_1292_118355_118441(this, s_emptyPropertyCollection);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 118456, 118550);

                _methods = f_1292_118467_118549(this, s_emptyMethodCollection);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 117842, 118561);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 117842, 118561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 117842, 118561);
            }
        }

        private static readonly Collection<CollectionEntry<PSMemberInfo>> s_typeMemberCollection;

        private static readonly Collection<CollectionEntry<PSMethodInfo>> s_typeMethodCollection;

        private static readonly Collection<CollectionEntry<PSPropertyInfo>> s_typePropertyCollection;

        private static Collection<CollectionEntry<PSMemberInfo>> GetTypeMemberCollection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 118962, 119553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 119069, 119173);

                Collection<CollectionEntry<PSMemberInfo>>
                returnValue = f_1292_119125_119172()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 119187, 119509);

                f_1292_119187_119508(returnValue, f_1292_119203_119507(PSObject.TypeTableGetMembersDelegate<PSMemberInfo>, PSObject.TypeTableGetMemberDelegate<PSMemberInfo>, PSObject.TypeTableGetFirstMemberOrDefaultDelegate<PSMemberInfo>, true, true, "type table members"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 119523, 119542);

                return returnValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 118962, 119553);

                System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>>
                f_1292_119125_119172()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 119125, 119172);
                    return return_v;
                }


                System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>
                f_1292_119203_119507(System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>.GetMembersDelegate
                getMembers, System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>.GetMemberDelegate
                getMember, System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>.GetFirstOrDefaultDelegate
                getFirstOrDefault, bool
                shouldReplicateWhenReturning, bool
                shouldCloneWhenReturning, string
                collectionNameForTracing)
                {
                    var return_v = new System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>(getMembers, getMember, getFirstOrDefault, shouldReplicateWhenReturning, shouldCloneWhenReturning, collectionNameForTracing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 119203, 119507);
                    return return_v;
                }


                int
                f_1292_119187_119508(System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>>
                this_param, System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 119187, 119508);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 118962, 119553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 118962, 119553);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Collection<CollectionEntry<PSMethodInfo>> GetTypeMethodCollection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 119565, 120156);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 119672, 119776);

                Collection<CollectionEntry<PSMethodInfo>>
                returnValue = f_1292_119728_119775()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 119790, 120112);

                f_1292_119790_120111(returnValue, f_1292_119806_120110(PSObject.TypeTableGetMembersDelegate<PSMethodInfo>, PSObject.TypeTableGetMemberDelegate<PSMethodInfo>, PSObject.TypeTableGetFirstMemberOrDefaultDelegate<PSMethodInfo>, true, true, "type table members"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 120126, 120145);

                return returnValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 119565, 120156);

                System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>>
                f_1292_119728_119775()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 119728, 119775);
                    return return_v;
                }


                System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>
                f_1292_119806_120110(System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>.GetMembersDelegate
                getMembers, System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>.GetMemberDelegate
                getMember, System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>.GetFirstOrDefaultDelegate
                getFirstOrDefault, bool
                shouldReplicateWhenReturning, bool
                shouldCloneWhenReturning, string
                collectionNameForTracing)
                {
                    var return_v = new System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>(getMembers, getMember, getFirstOrDefault, shouldReplicateWhenReturning, shouldCloneWhenReturning, collectionNameForTracing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 119806, 120110);
                    return return_v;
                }


                int
                f_1292_119790_120111(System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>>
                this_param, System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 119790, 120111);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 119565, 120156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 119565, 120156);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Collection<CollectionEntry<PSPropertyInfo>> GetTypePropertyCollection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 120168, 120775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 120279, 120387);

                Collection<CollectionEntry<PSPropertyInfo>>
                returnValue = f_1292_120337_120386()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 120401, 120731);

                f_1292_120401_120730(returnValue, f_1292_120417_120729(PSObject.TypeTableGetMembersDelegate<PSPropertyInfo>, PSObject.TypeTableGetMemberDelegate<PSPropertyInfo>, PSObject.TypeTableGetFirstMemberOrDefaultDelegate<PSPropertyInfo>, true, true, "type table members"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 120745, 120764);

                return returnValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 120168, 120775);

                System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>>
                f_1292_120337_120386()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 120337, 120386);
                    return return_v;
                }


                System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>
                f_1292_120417_120729(System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>.GetMembersDelegate
                getMembers, System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>.GetMemberDelegate
                getMember, System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>.GetFirstOrDefaultDelegate
                getFirstOrDefault, bool
                shouldReplicateWhenReturning, bool
                shouldCloneWhenReturning, string
                collectionNameForTracing)
                {
                    var return_v = new System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>(getMembers, getMember, getFirstOrDefault, shouldReplicateWhenReturning, shouldCloneWhenReturning, collectionNameForTracing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 120417, 120729);
                    return return_v;
                }


                int
                f_1292_120401_120730(System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>>
                this_param, System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 120401, 120730);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 120168, 120775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 120168, 120775);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PSMemberSet(string name, PSObject mshObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 121117, 121949);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 114072, 114080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 114158, 114169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 114245, 114253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 114318, 114333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 114370, 114390);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 121975, 121996);
                this.inheritMembers = true;
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 121195, 121323) || true) && (f_1292_121199_121225(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 121195, 121323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 121259, 121308);

                    throw f_1292_121265_121307("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 121195, 121323);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 121339, 121356);

                this.name = name;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 121370, 121498) || true) && (mshObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 121370, 121498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 121425, 121483);

                    throw f_1292_121431_121482("mshObject");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 121370, 121498);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 121514, 121547);

                _constructorPSObject = mshObject;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 121561, 121610);

                this.internalMembers = f_1292_121584_121609(mshObject);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 121624, 121717);

                _members = f_1292_121635_121716(this, s_typeMemberCollection);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 121731, 121831);

                _properties = f_1292_121745_121830(this, s_typePropertyCollection);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 121845, 121938);

                _methods = f_1292_121856_121937(this, s_typeMethodCollection);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 121117, 121949);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 121117, 121949);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 121117, 121949);
            }
        }

        internal bool inheritMembers;

        public bool InheritMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 122232, 122254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 122235, 122254);
                    return this.inheritMembers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 122232, 122254);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 122232, 122254);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 122232, 122254);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual PSMemberInfoInternalCollection<PSMemberInfo> InternalMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 122442, 122465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 122445, 122465);
                    return this.internalMembers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 122442, 122465);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 122442, 122465);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 122442, 122465);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PSMemberInfoCollection<PSMemberInfo> Members
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 122618, 122629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 122621, 122629);
                    return _members;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 122618, 122629);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 122618, 122629);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 122618, 122629);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PSMemberInfoCollection<PSPropertyInfo> Properties
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 122834, 122848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 122837, 122848);
                    return _properties;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 122834, 122848);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 122834, 122848);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 122834, 122848);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PSMemberInfoCollection<PSMethodInfo> Methods
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 123043, 123054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 123046, 123054);
                    return _methods;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 123043, 123054);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 123043, 123054);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 123043, 123054);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override PSMemberInfo Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 123321, 123875);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 123381, 123864) || true) && (_constructorPSObject == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 123381, 123864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 123447, 123493);

                    PSMemberSet
                    memberSet = f_1292_123471_123492(name)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 123511, 123646);
                        foreach (PSMemberInfo member in f_1292_123543_123555_I(f_1292_123543_123555(this)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 123511, 123646);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 123597, 123627);

                            f_1292_123597_123626(f_1292_123597_123614(memberSet), member);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 123511, 123646);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 136);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 136);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 123666, 123697);

                    f_1292_123666_123696(this, memberSet);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 123715, 123732);

                    return memberSet;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 123381, 123864);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 123381, 123864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 123798, 123849);

                    return f_1292_123805_123848(name, _constructorPSObject);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 123381, 123864);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 123321, 123875);

                System.Management.Automation.PSMemberSet
                f_1292_123471_123492(string
                name)
                {
                    var return_v = new System.Management.Automation.PSMemberSet(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 123471, 123492);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1292_123543_123555(System.Management.Automation.PSMemberSet
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 123543, 123555);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1292_123597_123614(System.Management.Automation.PSMemberSet
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 123597, 123614);
                    return return_v;
                }


                int
                f_1292_123597_123626(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSMemberInfo
                member)
                {
                    this_param.Add(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 123597, 123626);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1292_123543_123555_I(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 123543, 123555);
                    return return_v;
                }


                int
                f_1292_123666_123696(System.Management.Automation.PSMemberSet
                this_param, System.Management.Automation.PSMemberSet
                destiny)
                {
                    this_param.CloneBaseProperties((System.Management.Automation.PSMemberInfo)destiny);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 123666, 123696);
                    return 0;
                }


                System.Management.Automation.PSMemberSet
                f_1292_123805_123848(string
                name, System.Management.Automation.PSObject
                mshObject)
                {
                    var return_v = new System.Management.Automation.PSMemberSet(name, mshObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 123805, 123848);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 123321, 123875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 123321, 123875);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override PSMemberTypes MemberType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 124070, 124096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 124073, 124096);
                    return PSMemberTypes.MemberSet;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 124070, 124096);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 124070, 124096);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 124070, 124096);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override object Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 124404, 124411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 124407, 124411);
                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 124404, 124411);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 124347, 124610);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 124347, 124610);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 124430, 124598);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 124433, 124598);
                    throw f_1292_124439_124598("CannotChangePSMemberSetValue", null, f_1292_124526_124572(), f_1292_124574_124597(f_1292_124574_124588(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 124430, 124598);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 124347, 124610);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 124347, 124610);
                }
            }
        }

        public override string TypeNameOfValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 124808, 124839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 124811, 124839);
                    return f_1292_124811_124839(typeof(PSMemberSet));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 124808, 124839);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 124808, 124839);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 124808, 124839);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PSMemberSet()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 112866, 124892);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 114469, 114542);
            s_emptyMemberCollection = f_1292_114495_114542();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 114619, 114692);
            s_emptyMethodCollection = f_1292_114645_114692();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 114771, 114848);
            s_emptyPropertyCollection = f_1292_114799_114848();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 118639, 118689);
            s_typeMemberCollection = f_1292_118664_118689();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 118766, 118816);
            s_typeMethodCollection = f_1292_118791_118816();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 118895, 118949);
            s_typePropertyCollection = f_1292_118922_118949();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 112866, 124892);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 112866, 124892);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 112866, 124892);

        static System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>>
        f_1292_114495_114542()
        {
            var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 114495, 114542);
            return return_v;
        }


        static System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>>
        f_1292_114645_114692()
        {
            var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 114645, 114692);
            return return_v;
        }


        static System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>>
        f_1292_114799_114848()
        {
            var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 114799, 114848);
            return return_v;
        }


        bool
        f_1292_115197_115223(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 115197, 115223);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_115263_115311(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 115263, 115311);
            return return_v;
        }


        System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
        f_1292_115397_115447()
        {
            var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 115397, 115447);
            return return_v;
        }


        System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMemberInfo>
        f_1292_115473_115555(System.Management.Automation.PSMemberSet
        owner, System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>>
        collections)
        {
            var return_v = new System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMemberInfo>((object)owner, collections);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 115473, 115555);
            return return_v;
        }


        System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSPropertyInfo>
        f_1292_115584_115670(System.Management.Automation.PSMemberSet
        owner, System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>>
        collections)
        {
            var return_v = new System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSPropertyInfo>((object)owner, collections);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 115584, 115670);
            return return_v;
        }


        System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMethodInfo>
        f_1292_115696_115778(System.Management.Automation.PSMemberSet
        owner, System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>>
        collections)
        {
            var return_v = new System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMethodInfo>((object)owner, collections);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 115696, 115778);
            return return_v;
        }


        bool
        f_1292_116277_116303(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 116277, 116303);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_116343_116391(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 116343, 116391);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1292_116513_116568(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 116513, 116568);
            return return_v;
        }


        System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
        f_1292_116623_116673()
        {
            var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 116623, 116673);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1292_116827_116882(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 116827, 116882);
            return return_v;
        }


        System.Management.Automation.PSMemberInfo
        f_1292_116947_116960(System.Management.Automation.PSMemberInfo
        this_param)
        {
            var return_v = this_param.Copy();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 116947, 116960);
            return return_v;
        }


        int
        f_1292_116922_116961(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
        this_param, System.Management.Automation.PSMemberInfo
        member)
        {
            this_param.Add(member);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 116922, 116961);
            return 0;
        }


        System.Collections.Generic.IEnumerable<System.Management.Automation.PSMemberInfo>
        f_1292_116720_116727_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSMemberInfo>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 116720, 116727);
            return return_v;
        }


        System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMemberInfo>
        f_1292_117004_117086(System.Management.Automation.PSMemberSet
        owner, System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>>
        collections)
        {
            var return_v = new System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMemberInfo>((object)owner, collections);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 117004, 117086);
            return return_v;
        }


        System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSPropertyInfo>
        f_1292_117115_117201(System.Management.Automation.PSMemberSet
        owner, System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>>
        collections)
        {
            var return_v = new System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSPropertyInfo>((object)owner, collections);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 117115, 117201);
            return return_v;
        }


        System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMethodInfo>
        f_1292_117227_117309(System.Management.Automation.PSMemberSet
        owner, System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>>
        collections)
        {
            var return_v = new System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMethodInfo>((object)owner, collections);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 117227, 117309);
            return return_v;
        }


        bool
        f_1292_117974_118000(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 117974, 118000);
            return return_v;
        }


        int
        f_1292_117954_118049(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 117954, 118049);
            return 0;
        }


        int
        f_1292_118064_118138(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 118064, 118138);
            return 0;
        }


        System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMemberInfo>
        f_1292_118244_118326(System.Management.Automation.PSMemberSet
        owner, System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>>
        collections)
        {
            var return_v = new System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMemberInfo>((object)owner, collections);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 118244, 118326);
            return return_v;
        }


        System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSPropertyInfo>
        f_1292_118355_118441(System.Management.Automation.PSMemberSet
        owner, System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>>
        collections)
        {
            var return_v = new System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSPropertyInfo>((object)owner, collections);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 118355, 118441);
            return return_v;
        }


        System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMethodInfo>
        f_1292_118467_118549(System.Management.Automation.PSMemberSet
        owner, System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>>
        collections)
        {
            var return_v = new System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMethodInfo>((object)owner, collections);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 118467, 118549);
            return return_v;
        }


        static System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>>
        f_1292_118664_118689()
        {
            var return_v = GetTypeMemberCollection();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 118664, 118689);
            return return_v;
        }


        static System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>>
        f_1292_118791_118816()
        {
            var return_v = GetTypeMethodCollection();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 118791, 118816);
            return return_v;
        }


        static System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>>
        f_1292_118922_118949()
        {
            var return_v = GetTypePropertyCollection();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 118922, 118949);
            return return_v;
        }


        bool
        f_1292_121199_121225(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 121199, 121225);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_121265_121307(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 121265, 121307);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1292_121431_121482(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 121431, 121482);
            return return_v;
        }


        System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
        f_1292_121584_121609(System.Management.Automation.PSObject
        this_param)
        {
            var return_v = this_param.InstanceMembers;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 121584, 121609);
            return return_v;
        }


        System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMemberInfo>
        f_1292_121635_121716(System.Management.Automation.PSMemberSet
        owner, System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>>
        collections)
        {
            var return_v = new System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMemberInfo>((object)owner, collections);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 121635, 121716);
            return return_v;
        }


        System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSPropertyInfo>
        f_1292_121745_121830(System.Management.Automation.PSMemberSet
        owner, System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSPropertyInfo>>
        collections)
        {
            var return_v = new System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSPropertyInfo>((object)owner, collections);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 121745, 121830);
            return return_v;
        }


        System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMethodInfo>
        f_1292_121856_121937(System.Management.Automation.PSMemberSet
        owner, System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMethodInfo>>
        collections)
        {
            var return_v = new System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMethodInfo>((object)owner, collections);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 121856, 121937);
            return return_v;
        }


        string
        f_1292_124526_124572()
        {
            var return_v = ExtendedTypeSystem.CannotSetValueForMemberType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 124526, 124572);
            return return_v;
        }


        System.Type
        f_1292_124574_124588(System.Management.Automation.PSMemberSet
        this_param)
        {
            var return_v = this_param.GetType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 124574, 124588);
            return return_v;
        }


        string
        f_1292_124574_124597(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 124574, 124597);
            return return_v;
        }


        System.Management.Automation.ExtendedTypeSystemException
        f_1292_124439_124598(string
        errorId, System.Exception
        innerException, string
        resourceString, params object[]
        arguments)
        {
            var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 124439, 124598);
            return return_v;
        }


        string
        f_1292_124811_124839(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 124811, 124839);
            return return_v;
        }

    }
    internal class PSInternalMemberSet : PSMemberSet
    {
        private readonly object _syncObject;

        private readonly PSObject _psObject;

        internal PSInternalMemberSet(string propertyName, PSObject psObject)
        : base(f_1292_126011_126023_C(propertyName))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 125922, 126123);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 125469, 125495);
                this._syncObject = f_1292_125483_125495();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 125532, 125541);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 126049, 126077);

                this.internalMembers = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 126091, 126112);

                _psObject = psObject;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 125922, 126123);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 125922, 126123);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 125922, 126123);
            }
        }

        internal override PSMemberInfoInternalCollection<PSMemberInfo> InternalMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 126392, 127975);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 126473, 126655) || true) && (f_1292_126477_126555(name, PSObject.AdaptedMemberSetName, StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 126473, 126655);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 126597, 126636);

                        return f_1292_126604_126635(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 126473, 126655);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 126725, 127917) || true) && (internalMembers == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 126725, 127917);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 126800, 126811);
                        lock (_syncObject)
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 126861, 127875) || true) && (internalMembers == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 126861, 127875);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 126946, 127015);

                                internalMembers = f_1292_126964_127014();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 127047, 127848);

                                switch (f_1292_127055_127078(name))
                                {

                                    case PSObject.BaseObjectMemberSetName:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 127047, 127848);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 127220, 127254);

                                        f_1292_127220_127253(this);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1292, 127292, 127298);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 127047, 127848);

                                    case PSObject.PSObjectMemberSetName:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 127047, 127848);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 127406, 127444);

                                        f_1292_127406_127443(this);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1292, 127482, 127488);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 127047, 127848);

                                    default:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 127047, 127848);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 127568, 127773);

                                        f_1292_127568_127772(false, f_1292_127635_127771(f_1292_127649_127677(), "PSInternalMemberSet cannot process {0}", name));
                                        DynAbs.Tracing.TraceSender.TraceBreak(1292, 127811, 127817);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 127047, 127848);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 126861, 127875);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 126725, 127917);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 127937, 127960);

                    return internalMembers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 126392, 127975);

                    bool
                    f_1292_126477_126555(string
                    this_param, string
                    value, System.StringComparison
                    comparisonType)
                    {
                        var return_v = this_param.Equals(value, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 126477, 126555);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                    f_1292_126604_126635(System.Management.Automation.PSInternalMemberSet
                    this_param)
                    {
                        var return_v = this_param.GetInternalMembersFromAdapted();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 126604, 126635);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                    f_1292_126964_127014()
                    {
                        var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 126964, 127014);
                        return return_v;
                    }


                    string
                    f_1292_127055_127078(string
                    this_param)
                    {
                        var return_v = this_param.ToLowerInvariant();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 127055, 127078);
                        return return_v;
                    }


                    int
                    f_1292_127220_127253(System.Management.Automation.PSInternalMemberSet
                    this_param)
                    {
                        this_param.GenerateInternalMembersFromBase();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 127220, 127253);
                        return 0;
                    }


                    int
                    f_1292_127406_127443(System.Management.Automation.PSInternalMemberSet
                    this_param)
                    {
                        this_param.GenerateInternalMembersFromPSObject();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 127406, 127443);
                        return 0;
                    }


                    System.Globalization.CultureInfo
                    f_1292_127649_127677()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 127649, 127677);
                        return return_v;
                    }


                    string
                    f_1292_127635_127771(System.Globalization.CultureInfo
                    provider, string
                    format, string
                    arg0)
                    {
                        var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 127635, 127771);
                        return return_v;
                    }


                    int
                    f_1292_127568_127772(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 127568, 127772);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 126289, 127986);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 126289, 127986);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void GenerateInternalMembersFromBase()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 128055, 128772);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 128126, 128761) || true) && (f_1292_128130_128154(_psObject))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 128126, 128761);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 128188, 128441) || true) && (f_1292_128192_128212(_psObject) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 128188, 128441);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 128262, 128422);
                            foreach (PSMemberInfo member in f_1292_128294_128314_I(f_1292_128294_128314(_psObject)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 128262, 128422);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 128364, 128399);

                                f_1292_128364_128398(internalMembers, f_1292_128384_128397(member));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 128262, 128422);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 161);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 161);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 128188, 128441);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 128126, 128761);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 128126, 128761);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 128507, 128746);
                        foreach (PSMemberInfo member in f_1292_128560_128650_I(f_1292_128560_128650(f_1292_128560_128590(), f_1292_128620_128649(_psObject))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 128507, 128746);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 128692, 128727);

                            f_1292_128692_128726(internalMembers, f_1292_128712_128725(member));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 128507, 128746);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 240);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 240);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 128126, 128761);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 128055, 128772);

                bool
                f_1292_128130_128154(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.IsDeserialized;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 128130, 128154);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                f_1292_128192_128212(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ClrMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 128192, 128212);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                f_1292_128294_128314(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ClrMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 128294, 128314);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1292_128384_128397(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Copy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 128384, 128397);
                    return return_v;
                }


                int
                f_1292_128364_128398(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSMemberInfo
                member)
                {
                    this_param.Add(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 128364, 128398);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                f_1292_128294_128314_I(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 128294, 128314);
                    return return_v;
                }


                System.Management.Automation.DotNetAdapter
                f_1292_128560_128590()
                {
                    var return_v = PSObject.DotNetInstanceAdapter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 128560, 128590);
                    return return_v;
                }


                object
                f_1292_128620_128649(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ImmediateBaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 128620, 128649);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_128560_128650(System.Management.Automation.DotNetAdapter
                this_param, object
                obj)
                {
                    var return_v = this_param.BaseGetMembers<System.Management.Automation.PSMemberInfo>(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 128560, 128650);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1292_128712_128725(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Copy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 128712, 128725);
                    return return_v;
                }


                int
                f_1292_128692_128726(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSMemberInfo
                member)
                {
                    this_param.Add(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 128692, 128726);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_128560_128650_I(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 128560, 128650);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 128055, 128772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 128055, 128772);
            }
        }

        private PSMemberInfoInternalCollection<PSMemberInfo> GetInternalMembersFromAdapted()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 128784, 129676);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 128893, 128998);

                PSMemberInfoInternalCollection<PSMemberInfo>
                retVal = f_1292_128947_128997()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 129014, 129635) || true) && (f_1292_129018_129042(_psObject))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 129014, 129635);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 129076, 129328) || true) && (f_1292_129080_129104(_psObject) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 129076, 129328);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 129154, 129309);
                            foreach (PSMemberInfo member in f_1292_129186_129210_I(f_1292_129186_129210(_psObject)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 129154, 129309);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 129260, 129286);

                                f_1292_129260_129285(retVal, f_1292_129271_129284(member));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 129154, 129309);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 156);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 156);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 129076, 129328);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 129014, 129635);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 129014, 129635);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 129394, 129620);
                        foreach (PSMemberInfo member in f_1292_129426_129533_I(f_1292_129426_129533(f_1292_129426_129451(_psObject), f_1292_129503_129532(_psObject))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 129394, 129620);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 129575, 129601);

                            f_1292_129575_129600(retVal, f_1292_129586_129599(member));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 129394, 129620);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 227);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 227);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 129014, 129635);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 129651, 129665);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 128784, 129676);

                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_128947_128997()
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 128947, 128997);
                    return return_v;
                }


                bool
                f_1292_129018_129042(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.IsDeserialized;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 129018, 129042);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                f_1292_129080_129104(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.AdaptedMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 129080, 129104);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                f_1292_129186_129210(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.AdaptedMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 129186, 129210);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1292_129271_129284(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Copy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 129271, 129284);
                    return return_v;
                }


                int
                f_1292_129260_129285(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSMemberInfo
                member)
                {
                    this_param.Add(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 129260, 129285);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                f_1292_129186_129210_I(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSPropertyInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 129186, 129210);
                    return return_v;
                }


                System.Management.Automation.Adapter
                f_1292_129426_129451(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalAdapter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 129426, 129451);
                    return return_v;
                }


                object
                f_1292_129503_129532(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ImmediateBaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 129503, 129532);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_129426_129533(System.Management.Automation.Adapter
                this_param, object
                obj)
                {
                    var return_v = this_param.BaseGetMembers<System.Management.Automation.PSMemberInfo>(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 129426, 129533);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1292_129586_129599(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Copy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 129586, 129599);
                    return return_v;
                }


                int
                f_1292_129575_129600(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSMemberInfo
                member)
                {
                    this_param.Add(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 129575, 129600);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_129426_129533_I(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 129426, 129533);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 128784, 129676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 128784, 129676);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GenerateInternalMembersFromPSObject()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 129688, 130047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 129763, 129899);

                PSMemberInfoCollection<PSMemberInfo>
                members = f_1292_129810_129898(f_1292_129810_129840(), _psObject)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 129913, 130036);
                    foreach (PSMemberInfo member in f_1292_129945_129952_I(members))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 129913, 130036);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 129986, 130021);

                        f_1292_129986_130020(internalMembers, f_1292_130006_130019(member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 129913, 130036);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 124);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 124);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 129688, 130047);

                System.Management.Automation.DotNetAdapter
                f_1292_129810_129840()
                {
                    var return_v = PSObject.DotNetInstanceAdapter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 129810, 129840);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_129810_129898(System.Management.Automation.DotNetAdapter
                this_param, System.Management.Automation.PSObject
                obj)
                {
                    var return_v = this_param.BaseGetMembers<System.Management.Automation.PSMemberInfo>((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 129810, 129898);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1292_130006_130019(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Copy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 130006, 130019);
                    return return_v;
                }


                int
                f_1292_129986_130020(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSMemberInfo
                member)
                {
                    this_param.Add(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 129986, 130020);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1292_129945_129952_I(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 129945, 129952);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 129688, 130047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 129688, 130047);
            }
        }

        static PSInternalMemberSet()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 125380, 130076);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 125380, 130076);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 125380, 130076);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 125380, 130076);

        object
        f_1292_125483_125495()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 125483, 125495);
            return return_v;
        }


        static string
        f_1292_126011_126023_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1292, 125922, 126123);
            return return_v;
        }

    }
    public class PSPropertySet : PSMemberInfo
    {
        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 130585, 131224);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 130643, 130691);

                StringBuilder
                returnValue = f_1292_130671_130690()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 130705, 130735);

                f_1292_130705_130734(returnValue, f_1292_130724_130733(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 130749, 130774);

                f_1292_130749_130773(returnValue, " {");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 130788, 131129) || true) && (f_1292_130792_130821(f_1292_130792_130815()) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 130788, 131129);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 130860, 131048);
                        foreach (string property in f_1292_130888_130911_I(f_1292_130888_130911()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 130860, 131048);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 130953, 130982);

                            f_1292_130953_130981(returnValue, property);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 131004, 131029);

                            f_1292_131004_131028(returnValue, ", ");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 130860, 131048);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 189);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 189);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 131068, 131114);

                    f_1292_131068_131113(
                                    returnValue, f_1292_131087_131105(returnValue) - 2, 2);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 130788, 131129);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 131145, 131169);

                f_1292_131145_131168(
                            returnValue, "}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 131183, 131213);

                return f_1292_131190_131212(returnValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 130585, 131224);

                System.Text.StringBuilder
                f_1292_130671_130690()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 130671, 130690);
                    return return_v;
                }


                string
                f_1292_130724_130733(System.Management.Automation.PSPropertySet
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 130724, 130733);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_130705_130734(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 130705, 130734);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_130749_130773(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 130749, 130773);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1292_130792_130815()
                {
                    var return_v = ReferencedPropertyNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 130792, 130815);
                    return return_v;
                }


                int
                f_1292_130792_130821(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 130792, 130821);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1292_130888_130911()
                {
                    var return_v = ReferencedPropertyNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 130888, 130911);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_130953_130981(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 130953, 130981);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_131004_131028(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 131004, 131028);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1292_130888_130911_I(System.Collections.ObjectModel.Collection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 130888, 130911);
                    return return_v;
                }


                int
                f_1292_131087_131105(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 131087, 131105);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_131068_131113(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Remove(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 131068, 131113);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_131145_131168(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 131145, 131168);
                    return return_v;
                }


                string
                f_1292_131190_131212(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 131190, 131212);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 130585, 131224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 130585, 131224);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSPropertySet(string name, IEnumerable<string> referencedPropertyNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 131615, 132522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 133803, 133861);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 131718, 131852) || true) && (f_1292_131722_131748(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 131718, 131852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 131782, 131837);

                    throw f_1292_131788_131836(nameof(name));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 131718, 131852);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 131868, 131885);

                this.name = name;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 131899, 132061) || true) && (referencedPropertyNames == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 131899, 132061);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 131968, 132046);

                    throw f_1292_131974_132045(nameof(referencedPropertyNames));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 131899, 132061);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 132077, 132128);

                ReferencedPropertyNames = f_1292_132103_132127();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 132142, 132511);
                    foreach (string referencedPropertyName in f_1292_132184_132207_I(referencedPropertyNames))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 132142, 132511);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 132241, 132424) || true) && (f_1292_132245_132289(referencedPropertyName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 132241, 132424);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 132331, 132405);

                            throw f_1292_132337_132404(nameof(referencedPropertyNames));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 132241, 132424);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 132444, 132496);

                        f_1292_132444_132495(f_1292_132444_132467(), referencedPropertyName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 132142, 132511);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 370);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 370);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 131615, 132522);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 131615, 132522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 131615, 132522);
            }
        }

        internal PSPropertySet(string name, List<string> referencedPropertyNameList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 133045, 133685);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 133803, 133861);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 133146, 133242);

                f_1292_133146_133241(!f_1292_133166_133192(name), "Caller needs to guarantee not null or empty.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 133256, 133350);

                f_1292_133256_133349(referencedPropertyNameList != null, "Caller needs to guarantee not null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 133566, 133583);

                this.name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 133597, 133674);

                ReferencedPropertyNames = f_1292_133623_133673(referencedPropertyNameList);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 133045, 133685);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 133045, 133685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 133045, 133685);
            }
        }

        public Collection<string> ReferencedPropertyNames { get; }

        public override PSMemberInfo Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 134127, 134340);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 134187, 134259);

                PSPropertySet
                member = f_1292_134210_134258(name, f_1292_134234_134257())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 134273, 134301);

                f_1292_134273_134300(this, member);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 134315, 134329);

                return member;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 134127, 134340);

                System.Collections.ObjectModel.Collection<string>
                f_1292_134234_134257()
                {
                    var return_v = ReferencedPropertyNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 134234, 134257);
                    return return_v;
                }


                System.Management.Automation.PSPropertySet
                f_1292_134210_134258(string
                name, System.Collections.ObjectModel.Collection<string>
                referencedPropertyNames)
                {
                    var return_v = new System.Management.Automation.PSPropertySet(name, (System.Collections.Generic.IEnumerable<string>)referencedPropertyNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 134210, 134258);
                    return return_v;
                }


                int
                f_1292_134273_134300(System.Management.Automation.PSPropertySet
                this_param, System.Management.Automation.PSPropertySet
                destiny)
                {
                    this_param.CloneBaseProperties((System.Management.Automation.PSMemberInfo)destiny);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 134273, 134300);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 134127, 134340);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 134127, 134340);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override PSMemberTypes MemberType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 134475, 134503);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 134478, 134503);
                    return PSMemberTypes.PropertySet;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 134475, 134503);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 134475, 134503);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 134475, 134503);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override object Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 134760, 134767);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 134763, 134767);
                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 134760, 134767);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 134703, 134968);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 134703, 134968);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 134786, 134956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 134789, 134956);
                    throw f_1292_134795_134956("CannotChangePSPropertySetValue", null, f_1292_134884_134930(), f_1292_134932_134955(f_1292_134932_134946(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 134786, 134956);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 134703, 134968);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 134703, 134968);
                }
            }
        }

        public override string TypeNameOfValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 135168, 135201);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 135171, 135201);
                    return f_1292_135171_135201(typeof(PSPropertySet));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 135168, 135201);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 135168, 135201);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 135168, 135201);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PSPropertySet()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 130358, 135254);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 130358, 135254);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 130358, 135254);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 130358, 135254);

        bool
        f_1292_131722_131748(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 131722, 131748);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_131788_131836(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 131788, 131836);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1292_131974_132045(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 131974, 132045);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<string>
        f_1292_132103_132127()
        {
            var return_v = new System.Collections.ObjectModel.Collection<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 132103, 132127);
            return return_v;
        }


        bool
        f_1292_132245_132289(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 132245, 132289);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_132337_132404(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 132337, 132404);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<string>
        f_1292_132444_132467()
        {
            var return_v = ReferencedPropertyNames;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 132444, 132467);
            return return_v;
        }


        int
        f_1292_132444_132495(System.Collections.ObjectModel.Collection<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 132444, 132495);
            return 0;
        }


        System.Collections.Generic.IEnumerable<string>
        f_1292_132184_132207_I(System.Collections.Generic.IEnumerable<string>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 132184, 132207);
            return return_v;
        }


        bool
        f_1292_133166_133192(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 133166, 133192);
            return return_v;
        }


        int
        f_1292_133146_133241(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 133146, 133241);
            return 0;
        }


        int
        f_1292_133256_133349(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 133256, 133349);
            return 0;
        }


        System.Collections.ObjectModel.Collection<string>
        f_1292_133623_133673(System.Collections.Generic.List<string>
        list)
        {
            var return_v = new System.Collections.ObjectModel.Collection<string>((System.Collections.Generic.IList<string>)list);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 133623, 133673);
            return return_v;
        }


        string
        f_1292_134884_134930()
        {
            var return_v = ExtendedTypeSystem.CannotSetValueForMemberType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 134884, 134930);
            return return_v;
        }


        System.Type
        f_1292_134932_134946(System.Management.Automation.PSPropertySet
        this_param)
        {
            var return_v = this_param.GetType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 134932, 134946);
            return return_v;
        }


        string
        f_1292_134932_134955(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 134932, 134955);
            return return_v;
        }


        System.Management.Automation.ExtendedTypeSystemException
        f_1292_134795_134956(string
        errorId, System.Exception
        innerException, string
        resourceString, params object[]
        arguments)
        {
            var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 134795, 134956);
            return return_v;
        }


        string
        f_1292_135171_135201(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 135171, 135201);
            return return_v;
        }

    }
    public class PSEvent : PSMemberInfo
    {
        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 135779, 136483);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 135837, 135889);

                StringBuilder
                eventDefinition = f_1292_135869_135888()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 135903, 135953);

                f_1292_135903_135952(eventDefinition, f_1292_135926_135951(this.baseEvent));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 135969, 135997);

                f_1292_135969_135996(
                            eventDefinition, "(");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 136013, 136033);

                int
                loopCounter = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 136047, 136378);
                    foreach (ParameterInfo parameter in f_1292_136083_136145_I(f_1292_136083_136145(f_1292_136083_136129(f_1292_136083_136109(baseEvent), "Invoke"))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 136047, 136378);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 136179, 136250) || true) && (loopCounter > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 136179, 136250);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 136221, 136250);

                            f_1292_136221_136249(eventDefinition, ", ");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 136179, 136250);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 136270, 136329);

                        f_1292_136270_136328(
                                        eventDefinition, f_1292_136293_136327(f_1292_136293_136316(parameter)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 136349, 136363);

                        loopCounter++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 136047, 136378);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 332);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 332);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 136394, 136422);

                f_1292_136394_136421(
                            eventDefinition, ")");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 136438, 136472);

                return f_1292_136445_136471(eventDefinition);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 135779, 136483);

                System.Text.StringBuilder
                f_1292_135869_135888()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 135869, 135888);
                    return return_v;
                }


                string?
                f_1292_135926_135951(System.Reflection.EventInfo
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 135926, 135951);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_135903_135952(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 135903, 135952);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_135969_135996(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 135969, 135996);
                    return return_v;
                }


                System.Type
                f_1292_136083_136109(System.Reflection.EventInfo
                this_param)
                {
                    var return_v = this_param.EventHandlerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 136083, 136109);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_1292_136083_136129(System.Type
                this_param, string
                name)
                {
                    var return_v = this_param.GetMethod(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 136083, 136129);
                    return return_v;
                }


                System.Reflection.ParameterInfo[]
                f_1292_136083_136145(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 136083, 136145);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_136221_136249(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 136221, 136249);
                    return return_v;
                }


                System.Type
                f_1292_136293_136316(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 136293, 136316);
                    return return_v;
                }


                string
                f_1292_136293_136327(System.Type
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 136293, 136327);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_136270_136328(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 136270, 136328);
                    return return_v;
                }


                System.Reflection.ParameterInfo[]
                f_1292_136083_136145_I(System.Reflection.ParameterInfo[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 136083, 136145);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1292_136394_136421(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 136394, 136421);
                    return return_v;
                }


                string
                f_1292_136445_136471(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 136445, 136471);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 135779, 136483);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 135779, 136483);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal EventInfo baseEvent;

        internal PSEvent(EventInfo baseEvent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 136766, 136907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 136514, 136523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 136828, 136855);

                this.baseEvent = baseEvent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 136869, 136896);

                this.name = f_1292_136881_136895(baseEvent);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 136766, 136907);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 136766, 136907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 136766, 136907);
            }
        }

        public override PSMemberInfo Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 137173, 137359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 137233, 137278);

                PSEvent
                member = f_1292_137250_137277(this.baseEvent)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 137292, 137320);

                f_1292_137292_137319(this, member);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 137334, 137348);

                return member;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 137173, 137359);

                System.Management.Automation.PSEvent
                f_1292_137250_137277(System.Reflection.EventInfo
                baseEvent)
                {
                    var return_v = new System.Management.Automation.PSEvent(baseEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 137250, 137277);
                    return return_v;
                }


                int
                f_1292_137292_137319(System.Management.Automation.PSEvent
                this_param, System.Management.Automation.PSEvent
                destiny)
                {
                    this_param.CloneBaseProperties((System.Management.Automation.PSMemberInfo)destiny);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 137292, 137319);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 137173, 137359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 137173, 137359);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override PSMemberTypes MemberType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 137494, 137516);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 137497, 137516);
                    return PSMemberTypes.Event;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 137494, 137516);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 137494, 137516);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 137494, 137516);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override object Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 137856, 137868);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 137859, 137868);
                    return baseEvent;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 137856, 137868);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 137792, 138067);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 137792, 138067);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 137887, 138055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 137890, 138055);
                    throw f_1292_137896_138055("CannotChangePSEventInfoValue", null, f_1292_137983_138029(), f_1292_138031_138054(f_1292_138031_138045(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 137887, 138055);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 137792, 138067);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 137792, 138067);
                }
            }
        }

        public override string TypeNameOfValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 138269, 138296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 138272, 138296);
                    return f_1292_138272_138296(typeof(PSEvent));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 138269, 138296);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 138269, 138296);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 138269, 138296);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PSEvent()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 135558, 138349);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 135558, 138349);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 135558, 138349);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 135558, 138349);

        string
        f_1292_136881_136895(System.Reflection.EventInfo
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 136881, 136895);
            return return_v;
        }


        string
        f_1292_137983_138029()
        {
            var return_v = ExtendedTypeSystem.CannotSetValueForMemberType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 137983, 138029);
            return return_v;
        }


        System.Type
        f_1292_138031_138045(System.Management.Automation.PSEvent
        this_param)
        {
            var return_v = this_param.GetType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 138031, 138045);
            return return_v;
        }


        string
        f_1292_138031_138054(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 138031, 138054);
            return return_v;
        }


        System.Management.Automation.ExtendedTypeSystemException
        f_1292_137896_138055(string
        errorId, System.Exception
        innerException, string
        resourceString, params object[]
        arguments)
        {
            var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 137896, 138055);
            return return_v;
        }


        string
        f_1292_138272_138296(System.Type
        this_param)
        {
            var return_v = this_param.FullName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 138272, 138296);
            return return_v;
        }

    }
    public class PSDynamicMember : PSMemberInfo
    {
        internal PSDynamicMember(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 138483, 138573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 138545, 138562);

                this.name = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 138483, 138573);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 138483, 138573);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 138483, 138573);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 138609, 138703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 138667, 138692);

                return "dynamic " + f_1292_138687_138691();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 138609, 138703);

                string
                f_1292_138687_138691()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 138687, 138691);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 138609, 138703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 138609, 138703);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override PSMemberTypes MemberType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 138780, 138804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 138783, 138804);
                    return PSMemberTypes.Dynamic;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 138780, 138804);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 138780, 138804);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 138780, 138804);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override object Value
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 138898, 138951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 138901, 138951);
                    throw f_1292_138907_138951();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 138898, 138951);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 138841, 139035);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 138841, 139035);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 138970, 139023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 138973, 139023);
                    throw f_1292_138979_139023();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 138970, 139023);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 138841, 139035);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 138841, 139035);
                }
            }
        }

        public override string TypeNameOfValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 139110, 139122);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 139113, 139122);
                    return "dynamic";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 139110, 139122);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 139110, 139122);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 139110, 139122);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override PSMemberInfo Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 139159, 139263);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 139219, 139252);

                return f_1292_139226_139251(f_1292_139246_139250());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 139159, 139263);

                string
                f_1292_139246_139250()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 139246, 139250);
                    return return_v;
                }


                System.Management.Automation.PSDynamicMember
                f_1292_139226_139251(string
                name)
                {
                    var return_v = new System.Management.Automation.PSDynamicMember(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 139226, 139251);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 139159, 139263);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 139159, 139263);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSDynamicMember()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 138423, 139270);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 138423, 139270);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 138423, 139270);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 138423, 139270);

        System.Management.Automation.PSInvalidOperationException
        f_1292_138907_138951()
        {
            var return_v = PSTraceSource.NewInvalidOperationException();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 138907, 138951);
            return return_v;
        }


        System.Management.Automation.PSInvalidOperationException
        f_1292_138979_139023()
        {
            var return_v = PSTraceSource.NewInvalidOperationException();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 138979, 139023);
            return return_v;
        }

    }
    internal class MemberMatch
    {
        internal static WildcardPattern GetNamePattern(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 139560, 139861);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 139644, 139822) || true) && (name != null && (DynAbs.Tracing.TraceSender.Expression_True(1292, 139648, 139712) && f_1292_139664_139712(name)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 139644, 139822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 139746, 139807);

                    return f_1292_139753_139806(name, WildcardOptions.IgnoreCase);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 139644, 139822);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 139838, 139850);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 139560, 139861);

                bool
                f_1292_139664_139712(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 139664, 139712);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1292_139753_139806(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 139753, 139806);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 139560, 139861);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 139560, 139861);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSMemberInfoInternalCollection<T> Match<T>(PSMemberInfoInternalCollection<T> memberList, string name, WildcardPattern nameMatch, PSMemberTypes memberTypes)
                    where T : PSMemberInfo
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 140574, 141803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 140806, 140894);

                PSMemberInfoInternalCollection<T>
                returnValue = f_1292_140854_140893()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 140908, 141038) || true) && (memberList == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 140908, 141038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 140964, 141023);

                    throw f_1292_140970_141022("memberList");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 140908, 141038);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 141054, 141182) || true) && (f_1292_141058_141084(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 141054, 141182);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 141118, 141167);

                    throw f_1292_141124_141166("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 141054, 141182);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 141198, 141498) || true) && (nameMatch == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 141198, 141498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 141253, 141281);

                    T
                    member = f_1292_141264_141280(memberList, name)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 141299, 141444) || true) && (member != null && (DynAbs.Tracing.TraceSender.Expression_True(1292, 141303, 141359) && (f_1292_141322_141339(member) & memberTypes) != 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 141299, 141444);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 141401, 141425);

                        f_1292_141401_141424(returnValue, member);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 141299, 141444);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 141464, 141483);

                    return returnValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 141198, 141498);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 141514, 141757);
                    foreach (T member in f_1292_141535_141545_I(memberList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 141514, 141757);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 141579, 141742) || true) && (f_1292_141583_141613(nameMatch, f_1292_141601_141612(member)) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 141583, 141657) && ((f_1292_141619_141636(member) & memberTypes) != 0)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 141579, 141742);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 141699, 141723);

                            f_1292_141699_141722(returnValue, member);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 141579, 141742);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 141514, 141757);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 244);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 244);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 141773, 141792);

                return returnValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 140574, 141803);

                System.Management.Automation.PSMemberInfoInternalCollection<T>
                f_1292_140854_140893()
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 140854, 140893);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1292_140970_141022(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 140970, 141022);
                    return return_v;
                }


                bool
                f_1292_141058_141084(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 141058, 141084);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1292_141124_141166(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 141124, 141166);
                    return return_v;
                }


                T
                f_1292_141264_141280(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 141264, 141280);
                    return return_v;
                }


                System.Management.Automation.PSMemberTypes
                f_1292_141322_141339(T
                this_param)
                {
                    var return_v = this_param.MemberType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 141322, 141339);
                    return return_v;
                }


                int
                f_1292_141401_141424(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, T
                member)
                {
                    this_param.Add(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 141401, 141424);
                    return 0;
                }


                string
                f_1292_141601_141612(T
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 141601, 141612);
                    return return_v;
                }


                bool
                f_1292_141583_141613(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 141583, 141613);
                    return return_v;
                }


                System.Management.Automation.PSMemberTypes
                f_1292_141619_141636(T
                this_param)
                {
                    var return_v = this_param.MemberType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 141619, 141636);
                    return return_v;
                }


                int
                f_1292_141699_141722(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, T
                member)
                {
                    this_param.Add(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 141699, 141722);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<T>
                f_1292_141535_141545_I(System.Management.Automation.PSMemberInfoInternalCollection<T>
                i)

                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 141535, 141545);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 140574, 141803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 140574, 141803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MemberMatch()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 139517, 141810);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 139517, 141810);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 139517, 141810);
        }


        static MemberMatch()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 139517, 141810);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 139517, 141810);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 139517, 141810);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 139517, 141810);
    }

    /// <summary>
    /// A Predicate that determine if a member name matches a criterion.
    /// </summary>
    /// <param name="memberName"></param>
    /// <returns><c>true</c> if the <paramref name="memberName"/> matches the predicate, otherwise <c>false</c>.</returns>
    public delegate bool MemberNamePredicate(string memberName);
    public abstract class PSMemberInfoCollection<T> : IEnumerable<T> where T : PSMemberInfo
    {
        protected PSMemberInfoCollection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 142538, 142594);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 142538, 142594);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 142538, 142594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 142538, 142594);
            }
        }

        public abstract void Add(T member);

        public abstract void Add(T member, bool preValidated);

        public abstract void Remove(string name);

        /// <summary>
        /// Gets the member in this collection matching name. If the member does not exist, null is returned.
        /// </summary>
        /// <param name="name">Name of the member to look for.</param>
        /// <returns>The member matching name.</returns>
        /// <exception cref="ArgumentException">For invalid arguments.</exception>
        public abstract T this[string name] { get; }

        public abstract ReadOnlyPSMemberInfoCollection<T> Match(string name);

        public abstract ReadOnlyPSMemberInfoCollection<T> Match(string name, PSMemberTypes memberTypes);

        internal abstract ReadOnlyPSMemberInfoCollection<T> Match(string name, PSMemberTypes memberTypes, MshMemberMatchOptions matchOptions);

        internal static bool IsReservedName(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 147309, 147929);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 147382, 147918);

                return (f_1292_147390_147479(name, PSObject.BaseObjectMemberSetName, StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1292, 147390, 147590) || f_1292_147504_147590(name, PSObject.AdaptedMemberSetName, StringComparison.OrdinalIgnoreCase)) || (DynAbs.Tracing.TraceSender.Expression_False(1292, 147390, 147702) || f_1292_147615_147702(name, PSObject.ExtendedMemberSetName, StringComparison.OrdinalIgnoreCase)) || (DynAbs.Tracing.TraceSender.Expression_False(1292, 147390, 147814) || f_1292_147727_147814(name, PSObject.PSObjectMemberSetName, StringComparison.OrdinalIgnoreCase)) || (DynAbs.Tracing.TraceSender.Expression_False(1292, 147390, 147916) || f_1292_147839_147916(name, PSObject.PSTypeNames, StringComparison.OrdinalIgnoreCase)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 147309, 147929);

                bool
                f_1292_147390_147479(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 147390, 147479);
                    return return_v;
                }


                bool
                f_1292_147504_147590(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 147504, 147590);
                    return return_v;
                }


                bool
                f_1292_147615_147702(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 147615, 147702);
                    return return_v;
                }


                bool
                f_1292_147727_147814(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 147727, 147814);
                    return return_v;
                }


                bool
                f_1292_147839_147916(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 147839, 147916);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 147309, 147929);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 147309, 147929);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 148149, 148247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 148213, 148236);

                return f_1292_148220_148235(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 148149, 148247);

                System.Collections.Generic.IEnumerator<T>
                f_1292_148220_148235(System.Management.Automation.PSMemberInfoCollection<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 148220, 148235);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 148149, 148247);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 148149, 148247);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract IEnumerator<T> GetEnumerator();

        internal abstract T FirstOrDefault(MemberNamePredicate predicate);

        static PSMemberInfoCollection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 142279, 148603);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 142279, 148603);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 142279, 148603);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 142279, 148603);
    }
    public class ReadOnlyPSMemberInfoCollection<T> : IEnumerable<T> where T : PSMemberInfo
    {
        private readonly PSMemberInfoInternalCollection<T> _members;

        internal ReadOnlyPSMemberInfoCollection(PSMemberInfoInternalCollection<T> members)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 149368, 149645);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 149074, 149082);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 149475, 149599) || true) && (members == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 149475, 149599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 149528, 149584);

                    throw f_1292_149534_149583("members");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 149475, 149599);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 149615, 149634);

                _members = members;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 149368, 149645);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 149368, 149645);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 149368, 149645);
            }
        }

        /// <summary>
        /// Return the member in this collection matching name. If the member does not exist, null is returned.
        /// </summary>
        /// <param name="name">Name of the member to look for.</param>
        /// <returns>The member matching name.</returns>
        /// <exception cref="ArgumentException">For invalid arguments.</exception>
        public T this[string name]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 150082, 150315);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 150118, 150258) || true) && (f_1292_150122_150148(name))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 150118, 150258);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 150190, 150239);

                        throw f_1292_150196_150238("name");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 150118, 150258);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 150278, 150300);

                    return f_1292_150285_150299(_members, name);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 150082, 150315);

                    bool
                    f_1292_150122_150148(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 150122, 150148);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentException
                    f_1292_150196_150238(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 150196, 150238);
                        return return_v;
                    }


                    T
                    f_1292_150285_150299(System.Management.Automation.PSMemberInfoInternalCollection<T>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 150285, 150299);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 150082, 150315);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 150082, 150315);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ReadOnlyPSMemberInfoCollection<T> Match(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 150719, 150986);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 150803, 150931) || true) && (f_1292_150807_150833(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 150803, 150931);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 150867, 150916);

                    throw f_1292_150873_150915("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 150803, 150931);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 150947, 150975);

                return f_1292_150954_150974(_members, name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 150719, 150986);

                bool
                f_1292_150807_150833(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 150807, 150833);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1292_150873_150915(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 150873, 150915);
                    return return_v;
                }


                System.Management.Automation.ReadOnlyPSMemberInfoCollection<T>
                f_1292_150954_150974(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, string
                name)
                {
                    var return_v = this_param.Match(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 150954, 150974);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 150719, 150986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 150719, 150986);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ReadOnlyPSMemberInfoCollection<T> Match(string name, PSMemberTypes memberTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 151482, 151789);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 151593, 151721) || true) && (f_1292_151597_151623(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 151593, 151721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 151657, 151706);

                    throw f_1292_151663_151705("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 151593, 151721);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 151737, 151778);

                return f_1292_151744_151777(_members, name, memberTypes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 151482, 151789);

                bool
                f_1292_151597_151623(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 151597, 151623);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1292_151663_151705(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 151663, 151705);
                    return return_v;
                }


                System.Management.Automation.ReadOnlyPSMemberInfoCollection<T>
                f_1292_151744_151777(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, string
                name, System.Management.Automation.PSMemberTypes
                memberTypes)
                {
                    var return_v = this_param.Match(name, memberTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 151744, 151777);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 151482, 151789);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 151482, 151789);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 151978, 152076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 152042, 152065);

                return f_1292_152049_152064(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 151978, 152076);

                System.Collections.Generic.IEnumerator<T>
                f_1292_152049_152064(System.Management.Automation.ReadOnlyPSMemberInfoCollection<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 152049, 152064);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 151978, 152076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 151978, 152076);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual IEnumerator<T> GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 152266, 152379);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 152336, 152368);

                return f_1292_152343_152367(_members);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 152266, 152379);

                System.Collections.Generic.IEnumerator<T>
                f_1292_152343_152367(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 152343, 152367);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 152266, 152379);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 152266, 152379);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 152516, 152533);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 152519, 152533);
                    return f_1292_152519_152533(_members);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 152516, 152533);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 152516, 152533);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 152516, 152533);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        /// <summary>
        /// Returns the 0 based member identified by index.
        /// </summary>
        /// <param name="index">Index of the member to retrieve.</param>
        /// <exception cref="ArgumentException">For invalid arguments.</exception>
        public T this[int index] => f_1292_152840_152855(_members, index);

        static ReadOnlyPSMemberInfoCollection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 148920, 152863);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 148920, 152863);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 148920, 152863);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 148920, 152863);

        System.Management.Automation.PSArgumentNullException
        f_1292_149534_149583(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 149534, 149583);
            return return_v;
        }


        int
        f_1292_152519_152533(System.Management.Automation.PSMemberInfoInternalCollection<T>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 152519, 152533);
            return return_v;
        }


        T
        f_1292_152840_152855(System.Management.Automation.PSMemberInfoInternalCollection<T>
        this_param, int
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 152840, 152855);
            return return_v;
        }

    }
    internal class PSMemberInfoInternalCollection<T> : PSMemberInfoCollection<T>, IEnumerable<T> where T : PSMemberInfo
    {
        private OrderedDictionary _members;

        private int _countHidden;

        private OrderedDictionary Members
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 153420, 153710);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 153456, 153659) || true) && (_members == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 153456, 153659);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 153518, 153640);

                        f_1292_153518_153639(ref _members, f_1292_153577_153632(f_1292_153599_153631()), null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 153456, 153659);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 153679, 153695);

                    return _members;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 153420, 153710);

                    System.StringComparer
                    f_1292_153599_153631()
                    {
                        var return_v = StringComparer.OrdinalIgnoreCase;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 153599, 153631);
                        return return_v;
                    }


                    System.Collections.Specialized.OrderedDictionary
                    f_1292_153577_153632(System.StringComparer
                    comparer)
                    {
                        var return_v = new System.Collections.Specialized.OrderedDictionary((System.Collections.IEqualityComparer)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 153577, 153632);
                        return return_v;
                    }


                    System.Collections.Specialized.OrderedDictionary
                    f_1292_153518_153639(ref System.Collections.Specialized.OrderedDictionary
                    location1, System.Collections.Specialized.OrderedDictionary
                    value, System.Collections.Specialized.OrderedDictionary
                    comparand)
                    {
                        var return_v = System.Threading.Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 153518, 153639);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 153362, 153721);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 153362, 153721);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PSMemberInfoInternalCollection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 153821, 153884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 153100, 153108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 153131, 153143);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 153821, 153884);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 153821, 153884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 153821, 153884);
            }
        }

        internal PSMemberInfoInternalCollection(int capacity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 154009, 154175);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 153100, 153108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 153131, 153143);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 154087, 154164);

                _members = f_1292_154098_154163(capacity, f_1292_154130_154162());
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 154009, 154175);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 154009, 154175);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 154009, 154175);
            }
        }

        private void Replace(T oldMember, T newMember)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 154187, 154507);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 154258, 154294);

                f_1292_154258_154265()[f_1292_154266_154280(newMember)] = newMember;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 154308, 154394) || true) && (f_1292_154312_154330(oldMember))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 154308, 154394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 154364, 154379);

                    _countHidden--;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 154308, 154394);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 154410, 154496) || true) && (f_1292_154414_154432(newMember))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 154410, 154496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 154466, 154481);

                    _countHidden++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 154410, 154496);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 154187, 154507);

                System.Collections.Specialized.OrderedDictionary
                f_1292_154258_154265()
                {
                    var return_v = Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 154258, 154265);
                    return return_v;
                }


                string
                f_1292_154266_154280(T
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 154266, 154280);
                    return return_v;
                }


                bool
                f_1292_154312_154330(T
                this_param)
                {
                    var return_v = this_param.IsHidden;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 154312, 154330);
                    return return_v;
                }


                bool
                f_1292_154414_154432(T
                this_param)
                {
                    var return_v = this_param.IsHidden;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 154414, 154432);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 154187, 154507);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 154187, 154507);
            }
        }

        internal void Replace(T newMember)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 154698, 155248);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 154757, 154860);

                f_1292_154757_154859(newMember != null, "called from internal code that checks for new member not null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 154944, 154966);

                var
                members = f_1292_154958_154965()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 154986, 154993);
                lock (members)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 155027, 155072);

                    var
                    oldMember = f_1292_155043_155066(members, f_1292_155051_155065(newMember)) as T
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 155090, 155174);

                    f_1292_155090_155173(oldMember != null, "internal code checks member already exists");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 155192, 155222);

                    f_1292_155192_155221(this, oldMember, newMember);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 154698, 155248);

                int
                f_1292_154757_154859(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 154757, 154859);
                    return 0;
                }


                System.Collections.Specialized.OrderedDictionary
                f_1292_154958_154965()
                {
                    var return_v = Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 154958, 154965);
                    return return_v;
                }


                string
                f_1292_155051_155065(T
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 155051, 155065);
                    return return_v;
                }


                object
                f_1292_155043_155066(System.Collections.Specialized.OrderedDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 155043, 155066);
                    return return_v;
                }


                int
                f_1292_155090_155173(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 155090, 155173);
                    return 0;
                }


                int
                f_1292_155192_155221(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, T
                oldMember, T
                newMember)
                {
                    this_param.Replace(oldMember, newMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 155192, 155221);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 154698, 155248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 154698, 155248);
            }
        }

        public override void Add(T member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 155618, 155707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 155677, 155696);

                f_1292_155677_155695(this, member, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 155618, 155707);

                int
                f_1292_155677_155695(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, T
                member, bool
                preValidated)
                {
                    this_param.Add(member, preValidated);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 155677, 155695);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 155618, 155707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 155618, 155707);
            }
        }

        public override void Add(T member, bool preValidated)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 156347, 157118);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 156425, 156547) || true) && (member == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 156425, 156547);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 156477, 156532);

                    throw f_1292_156483_156531("member");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 156425, 156547);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 156631, 156653);

                var
                members = f_1292_156645_156652()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 156673, 156680);
                lock (members)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 156714, 157092) || true) && (f_1292_156718_156738(members, f_1292_156726_156737(member)) is T existingMember)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 156714, 157092);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 156800, 156832);

                        f_1292_156800_156831(this, existingMember, member);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 156714, 157092);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 156714, 157092);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 156914, 156944);

                        members[f_1292_156922_156933(member)] = member;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 156966, 157073) || true) && (f_1292_156970_156985(member))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 156966, 157073);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 157035, 157050);

                            _countHidden++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 156966, 157073);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 156714, 157092);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 156347, 157118);

                System.Management.Automation.PSArgumentNullException
                f_1292_156483_156531(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 156483, 156531);
                    return return_v;
                }


                System.Collections.Specialized.OrderedDictionary
                f_1292_156645_156652()
                {
                    var return_v = Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 156645, 156652);
                    return return_v;
                }


                string
                f_1292_156726_156737(T
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 156726, 156737);
                    return return_v;
                }


                object
                f_1292_156718_156738(System.Collections.Specialized.OrderedDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 156718, 156738);
                    return return_v;
                }


                int
                f_1292_156800_156831(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, T
                oldMember, T
                newMember)
                {
                    this_param.Replace(oldMember, newMember);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 156800, 156831);
                    return 0;
                }


                string
                f_1292_156922_156933(T
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 156922, 156933);
                    return return_v;
                }


                bool
                f_1292_156970_156985(T
                this_param)
                {
                    var return_v = this_param.IsHidden;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 156970, 156985);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 156347, 157118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 156347, 157118);
            }
        }

        public override void Remove(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 157510, 158433);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 157575, 157703) || true) && (f_1292_157579_157605(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 157575, 157703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 157639, 157688);

                    throw f_1292_157645_157687("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 157575, 157703);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 157719, 157996) || true) && (f_1292_157723_157743(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 157719, 157996);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 157777, 157981);

                    throw f_1292_157783_157980("PSMemberInfoInternalCollectionRemoveReservedName", null, f_1292_157915_157952(), name);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 157719, 157996);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 158012, 158088) || true) && (_members == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 158012, 158088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 158066, 158073);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 158012, 158088);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 158110, 158118);

                lock (_members)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 158152, 158407) || true) && (f_1292_158156_158170(_members, name) is PSMemberInfo member)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 158152, 158407);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 158235, 158342) || true) && (f_1292_158239_158254(member))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 158235, 158342);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 158304, 158319);

                            _countHidden--;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 158235, 158342);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 158366, 158388);

                        f_1292_158366_158387(
                                            _members, name);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 158152, 158407);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 157510, 158433);

                bool
                f_1292_157579_157605(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 157579, 157605);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1292_157645_157687(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 157645, 157687);
                    return return_v;
                }


                bool
                f_1292_157723_157743(string
                name)
                {
                    var return_v = IsReservedName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 157723, 157743);
                    return return_v;
                }


                string
                f_1292_157915_157952()
                {
                    var return_v = ExtendedTypeSystem.ReservedMemberName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 157915, 157952);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1292_157783_157980(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 157783, 157980);
                    return return_v;
                }


                object
                f_1292_158156_158170(System.Collections.Specialized.OrderedDictionary
                this_param, object
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 158156, 158170);
                    return return_v;
                }


                bool
                f_1292_158239_158254(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.IsHidden;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 158239, 158254);
                    return return_v;
                }


                int
                f_1292_158366_158387(System.Collections.Specialized.OrderedDictionary
                this_param, string
                key)
                {
                    this_param.Remove((object)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 158366, 158387);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 157510, 158433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 157510, 158433);
            }
        }

        /// <summary>
        /// Returns the member in this collection matching name.
        /// </summary>
        /// <param name="name">Name of the member to look for.</param>
        /// <returns>The member matching name.</returns>
        /// <exception cref="ArgumentException">For invalid arguments.</exception>
        public override T this[string name]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 158832, 159258);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 158868, 159008) || true) && (f_1292_158872_158898(name))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 158868, 159008);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 158940, 158989);

                        throw f_1292_158946_158988("name");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 158868, 159008);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 159028, 159121) || true) && (_members == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 159028, 159121);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 159090, 159102);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 159028, 159121);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 159147, 159155);

                    lock (_members)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 159197, 159224);

                        return f_1292_159204_159218(_members, name) as T;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 158832, 159258);

                    bool
                    f_1292_158872_158898(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 158872, 158898);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentException
                    f_1292_158946_158988(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 158946, 158988);
                        return return_v;
                    }


                    object
                    f_1292_159204_159218(System.Collections.Specialized.OrderedDictionary
                    this_param, object
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 159204, 159218);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 158832, 159258);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 158832, 159258);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ReadOnlyPSMemberInfoCollection<T> Match(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 159662, 159976);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 159755, 159883) || true) && (f_1292_159759_159785(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 159755, 159883);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 159819, 159868);

                    throw f_1292_159825_159867("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 159755, 159883);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 159899, 159965);

                return f_1292_159906_159964(this, name, PSMemberTypes.All, MshMemberMatchOptions.None);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 159662, 159976);

                bool
                f_1292_159759_159785(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 159759, 159785);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1292_159825_159867(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 159825, 159867);
                    return return_v;
                }


                System.Management.Automation.ReadOnlyPSMemberInfoCollection<T>
                f_1292_159906_159964(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, string
                name, System.Management.Automation.PSMemberTypes
                memberTypes, System.Management.Automation.MshMemberMatchOptions
                matchOptions)
                {
                    var return_v = this_param.Match(name, memberTypes, matchOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 159906, 159964);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 159662, 159976);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 159662, 159976);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ReadOnlyPSMemberInfoCollection<T> Match(string name, PSMemberTypes memberTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 160472, 160807);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 160592, 160720) || true) && (f_1292_160596_160622(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 160592, 160720);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 160656, 160705);

                    throw f_1292_160662_160704("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 160592, 160720);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 160736, 160796);

                return f_1292_160743_160795(this, name, memberTypes, MshMemberMatchOptions.None);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 160472, 160807);

                bool
                f_1292_160596_160622(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 160596, 160622);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1292_160662_160704(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 160662, 160704);
                    return return_v;
                }


                System.Management.Automation.ReadOnlyPSMemberInfoCollection<T>
                f_1292_160743_160795(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, string
                name, System.Management.Automation.PSMemberTypes
                memberTypes, System.Management.Automation.MshMemberMatchOptions
                matchOptions)
                {
                    var return_v = this_param.Match(name, memberTypes, matchOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 160743, 160795);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 160472, 160807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 160472, 160807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ReadOnlyPSMemberInfoCollection<T> Match(string name, PSMemberTypes memberTypes, MshMemberMatchOptions matchOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 161366, 161912);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 161524, 161652) || true) && (f_1292_161528_161554(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 161524, 161652);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 161588, 161637);

                    throw f_1292_161594_161636("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 161524, 161652);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 161668, 161753);

                PSMemberInfoInternalCollection<T>
                internalMembers = f_1292_161720_161752(this, matchOptions)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 161767, 161901);

                return f_1292_161774_161900(f_1292_161812_161899(internalMembers, name, f_1292_161853_161885(name), memberTypes));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 161366, 161912);

                bool
                f_1292_161528_161554(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 161528, 161554);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1292_161594_161636(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 161594, 161636);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<T>
                f_1292_161720_161752(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, System.Management.Automation.MshMemberMatchOptions
                matchOptions)
                {
                    var return_v = this_param.GetInternalMembers(matchOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 161720, 161752);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1292_161853_161885(string
                name)
                {
                    var return_v = MemberMatch.GetNamePattern(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 161853, 161885);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<T>
                f_1292_161812_161899(System.Management.Automation.PSMemberInfoInternalCollection<T>
                memberList, string
                name, System.Management.Automation.WildcardPattern
                nameMatch, System.Management.Automation.PSMemberTypes
                memberTypes)
                {
                    var return_v = MemberMatch.Match(memberList, name, nameMatch, memberTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 161812, 161899);
                    return return_v;
                }


                System.Management.Automation.ReadOnlyPSMemberInfoCollection<T>
                f_1292_161774_161900(System.Management.Automation.PSMemberInfoInternalCollection<T>
                members)
                {
                    var return_v = new System.Management.Automation.ReadOnlyPSMemberInfoCollection<T>(members);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 161774, 161900);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 161366, 161912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 161366, 161912);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSMemberInfoInternalCollection<T> GetInternalMembers(MshMemberMatchOptions matchOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 161924, 162607);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 162045, 162133);

                PSMemberInfoInternalCollection<T>
                returnValue = f_1292_162093_162132()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 162149, 162237) || true) && (_members == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 162149, 162237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 162203, 162222);

                    return returnValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 162149, 162237);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 162259, 162267);

                lock (_members)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 162301, 162546);
                        foreach (T member in f_1292_162322_162349_I(f_1292_162322_162349(f_1292_162322_162337(_members))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 162301, 162546);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 162391, 162527) || true) && (f_1292_162395_162430(member, matchOptions))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 162391, 162527);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 162480, 162504);

                                f_1292_162480_162503(returnValue, member);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 162391, 162527);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 162301, 162546);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 246);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 246);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 162577, 162596);

                return returnValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 161924, 162607);

                System.Management.Automation.PSMemberInfoInternalCollection<T>
                f_1292_162093_162132()
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 162093, 162132);
                    return return_v;
                }


                System.Collections.ICollection
                f_1292_162322_162337(System.Collections.Specialized.OrderedDictionary
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 162322, 162337);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<T>
                f_1292_162322_162349(System.Collections.ICollection
                source)
                {
                    var return_v = source.OfType<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 162322, 162349);
                    return return_v;
                }


                bool
                f_1292_162395_162430(T
                this_param, System.Management.Automation.MshMemberMatchOptions
                options)
                {
                    var return_v = this_param.MatchesOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 162395, 162430);
                    return return_v;
                }


                int
                f_1292_162480_162503(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, T
                member)
                {
                    this_param.Add(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 162480, 162503);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<T>
                f_1292_162322_162349_I(System.Collections.Generic.IEnumerable<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 162322, 162349);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 161924, 162607);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 161924, 162607);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int Count
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 162765, 163023);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 162801, 162891) || true) && (_members == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 162801, 162891);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 162863, 162872);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 162801, 162891);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 162917, 162925);

                    lock (_members)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 162967, 162989);

                        return f_1292_162974_162988(_members);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 162765, 163023);

                    int
                    f_1292_162974_162988(System.Collections.Specialized.OrderedDictionary
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 162974, 162988);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 162722, 163034);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 162722, 163034);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int VisibleCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 163220, 163493);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 163256, 163346) || true) && (_members == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 163256, 163346);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 163318, 163327);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 163256, 163346);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 163372, 163380);

                    lock (_members)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 163422, 163459);

                        return f_1292_163429_163443(_members) - _countHidden;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 163220, 163493);

                    int
                    f_1292_163429_163443(System.Collections.Specialized.OrderedDictionary
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 163429, 163443);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 163170, 163504);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 163170, 163504);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        /// <summary>
        /// Returns the 0 based member identified by index.
        /// </summary>
        /// <param name="index">Index of the member to retrieve.</param>
        /// <exception cref="ArgumentException">For invalid arguments.</exception>
        internal T this[int index]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 163833, 164100);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 163869, 163962) || true) && (_members == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 163869, 163962);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 163931, 163943);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 163869, 163962);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 163988, 163996);

                    lock (_members)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 164038, 164066);

                        return f_1292_164045_164060(_members, index) as T;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 163833, 164100);

                    object
                    f_1292_164045_164060(System.Collections.Specialized.OrderedDictionary
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 164045, 164060);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 163833, 164100);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 163833, 164100);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override IEnumerator<T> GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 164406, 164847);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 164477, 164591) || true) && (_members == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 164477, 164591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 164531, 164576);

                    return f_1292_164538_164575(f_1292_164538_164559());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 164477, 164591);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 164613, 164621);

                lock (_members)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 164761, 164821);

                    return f_1292_164768_164820(f_1292_164768_164804(f_1292_164768_164795(f_1292_164768_164783(_members))));
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 164406, 164847);

                System.Collections.Generic.IEnumerable<T>
                f_1292_164538_164559()
                {
                    var return_v = Enumerable.Empty<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 164538, 164559);
                    return return_v;
                }


                System.Collections.Generic.IEnumerator<T>
                f_1292_164538_164575(System.Collections.Generic.IEnumerable<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 164538, 164575);
                    return return_v;
                }


                System.Collections.ICollection
                f_1292_164768_164783(System.Collections.Specialized.OrderedDictionary
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 164768, 164783);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<T>
                f_1292_164768_164795(System.Collections.ICollection
                source)
                {
                    var return_v = source.OfType<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 164768, 164795);
                    return return_v;
                }


                System.Collections.Generic.List<T>
                f_1292_164768_164804(System.Collections.Generic.IEnumerable<T>
                source)
                {
                    var return_v = source.ToList<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 164768, 164804);
                    return return_v;
                }


                System.Collections.Generic.List<T>.Enumerator
                f_1292_164768_164820(System.Collections.Generic.List<T>
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 164768, 164820);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 164406, 164847);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 164406, 164847);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override T FirstOrDefault(MemberNamePredicate predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 165006, 165430);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 165102, 165110);
                lock (_members)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 165144, 165376);
                        foreach (DictionaryEntry entry in f_1292_165178_165186_I(_members))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 165144, 165376);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 165228, 165357) || true) && (f_1292_165232_165260(predicate, entry.Key))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 165228, 165357);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 165310, 165334);

                                return entry.Value as T;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 165228, 165357);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 165144, 165376);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 233);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 233);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 165407, 165419);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 165006, 165430);

                bool
                f_1292_165232_165260(System.Management.Automation.MemberNamePredicate
                this_param, object
                memberName)
                {
                    var return_v = this_param.Invoke((string)memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 165232, 165260);
                    return return_v;
                }


                System.Collections.Specialized.OrderedDictionary
                f_1292_165178_165186_I(System.Collections.Specialized.OrderedDictionary
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 165178, 165186);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 165006, 165430);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 165006, 165430);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSMemberInfoInternalCollection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 152942, 165437);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 152942, 165437);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 152942, 165437);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 152942, 165437);

        System.StringComparer
        f_1292_154130_154162()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 154130, 154162);
            return return_v;
        }


        System.Collections.Specialized.OrderedDictionary
        f_1292_154098_154163(int
        capacity, System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Specialized.OrderedDictionary(capacity, (System.Collections.IEqualityComparer)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 154098, 154163);
            return return_v;
        }

    }
    internal class CollectionEntry<T> where T : PSMemberInfo
    {
        internal delegate PSMemberInfoInternalCollection<T> GetMembersDelegate(PSObject obj);

        internal delegate T GetMemberDelegate(PSObject obj, string name);

        internal delegate T GetFirstOrDefaultDelegate(PSObject obj, MemberNamePredicate predicate);

        internal CollectionEntry(
                    GetMembersDelegate getMembers,
                    GetMemberDelegate getMember,
                    GetFirstOrDefaultDelegate getFirstOrDefault,
                    bool shouldReplicateWhenReturning,
                    bool shouldCloneWhenReturning,
                    string collectionNameForTracing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 165826, 166489);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 166501, 166548);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 166560, 166605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 166617, 166678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 166690, 166739);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 166773, 166802);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 166837, 166862);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 166158, 166182);

                GetMembers = getMembers;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 166196, 166218);

                GetMember = getMember;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 166232, 166270);

                GetFirstOrDefault = getFirstOrDefault;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 166284, 166345);

                _shouldReplicateWhenReturning = shouldReplicateWhenReturning;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 166359, 166412);

                _shouldCloneWhenReturning = shouldCloneWhenReturning;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 166426, 166478);

                CollectionNameForTracing = collectionNameForTracing;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 165826, 166489);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 165826, 166489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 165826, 166489);
            }
        }

        internal GetMembersDelegate GetMembers { get; }

        internal GetMemberDelegate GetMember { get; }

        internal GetFirstOrDefaultDelegate GetFirstOrDefault { get; }

        internal string CollectionNameForTracing { get; }

        private readonly bool _shouldReplicateWhenReturning;

        private readonly bool _shouldCloneWhenReturning;

        internal T CloneOrReplicateObject(object owner, T member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 166875, 167232);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 166957, 167061) || true) && (_shouldCloneWhenReturning)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 166957, 167061);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 167020, 167046);

                    member = (T)f_1292_167032_167045(member);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 166957, 167061);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 167077, 167191) || true) && (_shouldReplicateWhenReturning)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 167077, 167191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 167144, 167176);

                    f_1292_167144_167175(member, owner);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 167077, 167191);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 167207, 167221);

                return member;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 166875, 167232);

                System.Management.Automation.PSMemberInfo
                f_1292_167032_167045(T
                this_param)
                {
                    var return_v = this_param.Copy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 167032, 167045);
                    return return_v;
                }


                int
                f_1292_167144_167175(T
                this_param, object
                particularInstance)
                {
                    this_param.ReplicateInstance(particularInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 167144, 167175);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 166875, 167232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 166875, 167232);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CollectionEntry()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 165476, 167239);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 165476, 167239);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 165476, 167239);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 165476, 167239);
    }
    internal static class ReservedNameMembers
    {
        private static object GenerateMemberSet(string name, object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 167339, 167987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 167428, 167473);

                PSObject
                mshOwner = f_1292_167448_167472(obj)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 167487, 167534);

                var
                memberSet = f_1292_167503_167533(f_1292_167503_167527(mshOwner), name)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 167548, 167943) || true) && (memberSet == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 167548, 167943);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 167603, 167822);

                    memberSet = new PSInternalMemberSet(name, mshOwner)
                    {
                        ShouldSerialize = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => false, 1292, 167615, 167821),
                        IsHidden = true,
                        IsReservedMember = true
                    };
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 167840, 167880);

                    f_1292_167840_167879(f_1292_167840_167864(mshOwner), memberSet);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 167898, 167928);

                    memberSet.instance = mshOwner;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 167548, 167943);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 167959, 167976);

                return memberSet;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 167339, 167987);

                System.Management.Automation.PSObject
                f_1292_167448_167472(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 167448, 167472);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_167503_167527(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InstanceMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 167503, 167527);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1292_167503_167533(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 167503, 167533);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_167840_167864(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InstanceMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 167840, 167864);
                    return return_v;
                }


                int
                f_1292_167840_167879(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSMemberInfo
                member)
                {
                    this_param.Add(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 167840, 167879);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 167339, 167987);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 167339, 167987);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object GeneratePSBaseMemberSet(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 167999, 168157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 168082, 168146);

                return f_1292_168089_168145(PSObject.BaseObjectMemberSetName, obj);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 167999, 168157);

                object
                f_1292_168089_168145(string
                name, object
                obj)
                {
                    var return_v = GenerateMemberSet(name, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 168089, 168145);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 167999, 168157);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 167999, 168157);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object GeneratePSAdaptedMemberSet(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 168169, 168327);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 168255, 168316);

                return f_1292_168262_168315(PSObject.AdaptedMemberSetName, obj);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 168169, 168327);

                object
                f_1292_168262_168315(string
                name, object
                obj)
                {
                    var return_v = GenerateMemberSet(name, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 168262, 168315);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 168169, 168327);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 168169, 168327);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object GeneratePSObjectMemberSet(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 168339, 168497);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 168424, 168486);

                return f_1292_168431_168485(PSObject.PSObjectMemberSetName, obj);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 168339, 168497);

                object
                f_1292_168431_168485(string
                name, object
                obj)
                {
                    var return_v = GenerateMemberSet(name, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 168431, 168485);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 168339, 168497);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 168339, 168497);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object GeneratePSExtendedMemberSet(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 168509, 169255);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 168596, 168641);

                PSObject
                mshOwner = f_1292_168616_168640(obj)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 168655, 168728);

                var
                memberSet = f_1292_168671_168727(f_1292_168671_168695(mshOwner), PSObject.ExtendedMemberSetName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 168742, 169211) || true) && (memberSet == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 168742, 169211);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 168797, 169034);

                    memberSet = new PSMemberSet(PSObject.ExtendedMemberSetName, mshOwner)
                    {
                        ShouldSerialize = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => false, 1292, 168809, 169033),
                        IsHidden = true,
                        IsReservedMember = true
                    };
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 169052, 169090);

                    f_1292_169052_169089(memberSet, mshOwner);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 169108, 169138);

                    memberSet.instance = mshOwner;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 169156, 169196);

                    f_1292_169156_169195(f_1292_169156_169180(mshOwner), memberSet);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 168742, 169211);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 169227, 169244);

                return memberSet;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 168509, 169255);

                System.Management.Automation.PSObject
                f_1292_168616_168640(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 168616, 168640);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_168671_168695(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InstanceMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 168671, 168695);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1292_168671_168727(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 168671, 168727);
                    return return_v;
                }


                int
                f_1292_169052_169089(System.Management.Automation.PSMemberInfo
                this_param, System.Management.Automation.PSObject
                particularInstance)
                {
                    this_param.ReplicateInstance((object)particularInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 169052, 169089);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_169156_169180(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InstanceMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 169156, 169180);
                    return return_v;
                }


                int
                f_1292_169156_169195(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSMemberInfo
                member)
                {
                    this_param.Add(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 169156, 169195);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 168509, 169255);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 168509, 169255);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Collection<string> PSTypeNames(PSObject o)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 169339, 169450);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 169420, 169439);

                return f_1292_169427_169438(o);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 169339, 169450);

                System.Collections.ObjectModel.Collection<string>
                f_1292_169427_169438(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 169427, 169438);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 169339, 169450);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 169339, 169450);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void GeneratePSTypeNames(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1292, 169462, 170184);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 169539, 169584);

                PSObject
                mshOwner = f_1292_169559_169583(obj)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 169598, 169790) || true) && (f_1292_169602_169648(f_1292_169602_169626(mshOwner), PSObject.PSTypeNames) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 169598, 169790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 169768, 169775);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 169598, 169790);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 169806, 170116);

                PSCodeProperty
                codeProperty = new PSCodeProperty(PSObject.PSTypeNames, CachedReflectionInfo.ReservedNameMembers_PSTypeNames)
                {
                    ShouldSerialize = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => false, 1292, 169836, 170115),
                    instance = mshOwner,
                    IsHidden = true,
                    IsReservedMember = true
                }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 170130, 170173);

                f_1292_170130_170172(f_1292_170130_170154(mshOwner), codeProperty);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1292, 169462, 170184);

                System.Management.Automation.PSObject
                f_1292_169559_169583(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 169559, 169583);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_169602_169626(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InstanceMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 169602, 169626);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1292_169602_169648(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 169602, 169648);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_170130_170154(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InstanceMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 170130, 170154);
                    return return_v;
                }


                int
                f_1292_170130_170172(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSCodeProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSMemberInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 170130, 170172);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 169462, 170184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 169462, 170184);
            }
        }

        static ReservedNameMembers()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 167281, 170191);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 167281, 170191);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 167281, 170191);
        }

    }
    internal class PSMemberInfoIntegratingCollection<T> : PSMemberInfoCollection<T>, IEnumerable<T> where T : PSMemberInfo
    {
        private void GenerateAllReservedMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 170368, 170951);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 170434, 170940) || true) && (f_1292_170438_170476_M(!_mshOwner.HasGeneratedReservedMembers))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 170434, 170940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 170510, 170555);

                    _mshOwner.HasGeneratedReservedMembers = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 170573, 170632);

                    f_1292_170573_170631(_mshOwner);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 170650, 170705);

                    f_1292_170650_170704(_mshOwner);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 170723, 170780);

                    f_1292_170723_170779(_mshOwner);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 170798, 170856);

                    f_1292_170798_170855(_mshOwner);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 170874, 170925);

                    f_1292_170874_170924(_mshOwner);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 170434, 170940);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 170368, 170951);

                bool
                f_1292_170438_170476_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 170438, 170476);
                    return return_v;
                }


                object
                f_1292_170573_170631(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = ReservedNameMembers.GeneratePSExtendedMemberSet((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 170573, 170631);
                    return return_v;
                }


                object
                f_1292_170650_170704(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = ReservedNameMembers.GeneratePSBaseMemberSet((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 170650, 170704);
                    return return_v;
                }


                object
                f_1292_170723_170779(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = ReservedNameMembers.GeneratePSObjectMemberSet((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 170723, 170779);
                    return return_v;
                }


                object
                f_1292_170798_170855(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = ReservedNameMembers.GeneratePSAdaptedMemberSet((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 170798, 170855);
                    return return_v;
                }


                int
                f_1292_170874_170924(System.Management.Automation.PSObject
                obj)
                {
                    ReservedNameMembers.GeneratePSTypeNames((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 170874, 170924);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 170368, 170951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 170368, 170951);
            }
        }

        internal Collection<CollectionEntry<T>> Collections { get; }

        private readonly PSObject _mshOwner;

        private readonly PSMemberSet _memberSetOwner;

        internal PSMemberInfoIntegratingCollection(object owner, Collection<CollectionEntry<T>> collections)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 171229, 171935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 171054, 171114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 171152, 171161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 171201, 171216);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 171354, 171474) || true) && (owner == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 171354, 171474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 171405, 171459);

                    throw f_1292_171411_171458("owner");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 171354, 171474);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 171490, 171520);

                _mshOwner = owner as PSObject;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 171534, 171573);

                _memberSetOwner = owner as PSMemberSet;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 171587, 171734) || true) && (_mshOwner == null && (DynAbs.Tracing.TraceSender.Expression_True(1292, 171591, 171635) && _memberSetOwner == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 171587, 171734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 171669, 171719);

                    throw f_1292_171675_171718("owner");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 171587, 171734);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 171750, 171882) || true) && (collections == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 171750, 171882);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 171807, 171867);

                    throw f_1292_171813_171866("collections");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 171750, 171882);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 171898, 171924);

                Collections = collections;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 171229, 171935);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 171229, 171935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 171229, 171935);
            }
        }

        public override void Add(T member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 172787, 172876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 172846, 172865);

                f_1292_172846_172864(this, member, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 172787, 172876);

                int
                f_1292_172846_172864(System.Management.Automation.PSMemberInfoIntegratingCollection<T>
                this_param, T
                member, bool
                preValidated)
                {
                    this_param.Add(member, preValidated);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 172846, 172864);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 172787, 172876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 172787, 172876);
            }
        }

        public override void Add(T member, bool preValidated)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 173912, 174982);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 173990, 174112) || true) && (member == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 173990, 174112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 174042, 174097);

                    throw f_1292_174048_174096("member");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 173990, 174112);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 174128, 174910) || true) && (!preValidated)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 174128, 174910);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 174179, 174527) || true) && (f_1292_174183_174200(member) == PSMemberTypes.Property || (DynAbs.Tracing.TraceSender.Expression_False(1292, 174183, 174271) || f_1292_174230_174247(member) == PSMemberTypes.Method))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 174179, 174527);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 174313, 174508);

                        throw f_1292_174319_174507("CannotAddMethodOrProperty", null, f_1292_174462_174506());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 174179, 174527);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 174547, 174895) || true) && (_memberSetOwner != null && (DynAbs.Tracing.TraceSender.Expression_True(1292, 174551, 174610) && f_1292_174578_174610(_memberSetOwner)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 174547, 174895);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 174652, 174876);

                        throw f_1292_174658_174875("CannotAddToReservedNameMemberset", null, f_1292_174782_174827(), f_1292_174854_174874(_memberSetOwner));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 174547, 174895);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 174128, 174910);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 174926, 174971);

                f_1292_174926_174970(this, member, preValidated);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 173912, 174982);

                System.Management.Automation.PSArgumentNullException
                f_1292_174048_174096(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 174048, 174096);
                    return return_v;
                }


                System.Management.Automation.PSMemberTypes
                f_1292_174183_174200(T
                this_param)
                {
                    var return_v = this_param.MemberType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 174183, 174200);
                    return return_v;
                }


                System.Management.Automation.PSMemberTypes
                f_1292_174230_174247(T
                this_param)
                {
                    var return_v = this_param.MemberType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 174230, 174247);
                    return return_v;
                }


                string
                f_1292_174462_174506()
                {
                    var return_v = ExtendedTypeSystem.CannotAddPropertyOrMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 174462, 174506);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1292_174319_174507(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 174319, 174507);
                    return return_v;
                }


                bool
                f_1292_174578_174610(System.Management.Automation.PSMemberSet
                this_param)
                {
                    var return_v = this_param.IsReservedMember;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 174578, 174610);
                    return return_v;
                }


                string
                f_1292_174782_174827()
                {
                    var return_v = ExtendedTypeSystem.CannotChangeReservedMember;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 174782, 174827);
                    return return_v;
                }


                string
                f_1292_174854_174874(System.Management.Automation.PSMemberSet
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 174854, 174874);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1292_174658_174875(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 174658, 174875);
                    return return_v;
                }


                int
                f_1292_174926_174970(System.Management.Automation.PSMemberInfoIntegratingCollection<T>
                this_param, T
                member, bool
                preValidated)
                {
                    this_param.AddToReservedMemberSet(member, preValidated);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 174926, 174970);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 173912, 174982);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 173912, 174982);
            }
        }

        internal void AddToReservedMemberSet(T member, bool preValidated)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 175187, 175736);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 175277, 175668) || true) && (!preValidated)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 175277, 175668);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 175328, 175653) || true) && (_memberSetOwner != null && (DynAbs.Tracing.TraceSender.Expression_True(1292, 175332, 175386) && f_1292_175359_175386_M(!_memberSetOwner.IsInstance)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 175328, 175653);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 175428, 175634);

                        throw f_1292_175434_175633("RemoveMemberFromStaticMemberSet", null, f_1292_175557_175594(), f_1292_175621_175632(member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 175328, 175653);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 175277, 175668);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 175684, 175725);

                f_1292_175684_175724(this, member, preValidated);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 175187, 175736);

                bool
                f_1292_175359_175386_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 175359, 175386);
                    return return_v;
                }


                string
                f_1292_175557_175594()
                {
                    var return_v = ExtendedTypeSystem.ChangeStaticMember;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 175557, 175594);
                    return return_v;
                }


                string
                f_1292_175621_175632(T
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 175621, 175632);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1292_175434_175633(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 175434, 175633);
                    return return_v;
                }


                int
                f_1292_175684_175724(System.Management.Automation.PSMemberInfoIntegratingCollection<T>
                this_param, T
                member, bool
                preValidated)
                {
                    this_param.AddToTypesXmlCache(member, preValidated);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 175684, 175724);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 175187, 175736);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 175187, 175736);
            }
        }

        internal void AddToTypesXmlCache(T member, bool preValidated)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 176640, 178912);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 176726, 176848) || true) && (member == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 176726, 176848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 176778, 176833);

                    throw f_1292_176784_176832("member");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 176726, 176848);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 176864, 177234) || true) && (!preValidated)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 176864, 177234);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 176915, 177219) || true) && (f_1292_176919_176946(f_1292_176934_176945(member)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 176915, 177219);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 176988, 177200);

                        throw f_1292_176994_177199("PSObjectMembersMembersAddReservedName", null, f_1292_177123_177160(), f_1292_177187_177198(member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 176915, 177219);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 176864, 177234);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 177250, 177295);

                PSMemberInfo
                memberToBeAdded = f_1292_177281_177294(member)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 177311, 178818) || true) && (_mshOwner != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 177311, 178818);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 177366, 178160) || true) && (!preValidated)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 177366, 178160);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 177425, 177472);

                        TypeTable
                        typeTable = f_1292_177447_177471(_mshOwner)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 177494, 178141) || true) && (typeTable != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 177494, 178141);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 177565, 177637);

                            var
                            typesXmlMembers = f_1292_177587_177636(typeTable, f_1292_177608_177635(_mshOwner))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 177663, 177713);

                            var
                            typesXmlMember = f_1292_177684_177712(typesXmlMembers, f_1292_177700_177711(member))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 177739, 178118) || true) && (typesXmlMember is T)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 177739, 178118);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 177820, 178091);

                                throw f_1292_177826_178090("AlreadyPresentInTypesXml", null, f_1292_177992_178043(), f_1292_178078_178089(member));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 177739, 178118);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 177494, 178141);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 177366, 178160);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 178180, 178225);

                    f_1292_178180_178224(
                                    memberToBeAdded, _mshOwner);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 178243, 178304);

                    f_1292_178243_178303(f_1292_178243_178268(_mshOwner), memberToBeAdded, preValidated);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 178598, 178659);

                    f_1292_178598_178658(f_1292_178637_178657(memberToBeAdded));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 178677, 178776);

                    f_1292_178677_178775(f_1292_178740_178774(f_1292_178740_178764(_mshOwner)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 178796, 178803);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 177311, 178818);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 178834, 178901);

                f_1292_178834_178900(f_1292_178834_178865(_memberSetOwner), memberToBeAdded, preValidated);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 176640, 178912);

                System.Management.Automation.PSArgumentNullException
                f_1292_176784_176832(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 176784, 176832);
                    return return_v;
                }


                string
                f_1292_176934_176945(T
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 176934, 176945);
                    return return_v;
                }


                bool
                f_1292_176919_176946(string
                name)
                {
                    var return_v = IsReservedName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 176919, 176946);
                    return return_v;
                }


                string
                f_1292_177123_177160()
                {
                    var return_v = ExtendedTypeSystem.ReservedMemberName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 177123, 177160);
                    return return_v;
                }


                string
                f_1292_177187_177198(T
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 177187, 177198);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1292_176994_177199(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 176994, 177199);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1292_177281_177294(T
                this_param)
                {
                    var return_v = this_param.Copy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 177281, 177294);
                    return return_v;
                }


                System.Management.Automation.Runspaces.TypeTable
                f_1292_177447_177471(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.GetTypeTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 177447, 177471);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1292_177608_177635(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 177608, 177635);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_177587_177636(System.Management.Automation.Runspaces.TypeTable
                this_param, System.Management.Automation.Runspaces.ConsolidatedString
                types)
                {
                    var return_v = this_param.GetMembers(types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 177587, 177636);
                    return return_v;
                }


                string
                f_1292_177700_177711(T
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 177700, 177711);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1292_177684_177712(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 177684, 177712);
                    return return_v;
                }


                string
                f_1292_177992_178043()
                {
                    var return_v = ExtendedTypeSystem.MemberAlreadyPresentFromTypesXml;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 177992, 178043);
                    return return_v;
                }


                string
                f_1292_178078_178089(T
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 178078, 178089);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1292_177826_178090(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 177826, 178090);
                    return return_v;
                }


                int
                f_1292_178180_178224(System.Management.Automation.PSMemberInfo
                this_param, System.Management.Automation.PSObject
                particularInstance)
                {
                    this_param.ReplicateInstance((object)particularInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 178180, 178224);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_178243_178268(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InstanceMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 178243, 178268);
                    return return_v;
                }


                int
                f_1292_178243_178303(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSMemberInfo
                member, bool
                preValidated)
                {
                    this_param.Add(member, preValidated);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 178243, 178303);
                    return 0;
                }


                string
                f_1292_178637_178657(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 178637, 178657);
                    return return_v;
                }


                int
                f_1292_178598_178658(string
                memberName)
                {
                    PSGetMemberBinder.SetHasInstanceMember(memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 178598, 178658);
                    return 0;
                }


                object
                f_1292_178740_178764(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = PSObject.Base((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 178740, 178764);
                    return return_v;
                }


                System.Type
                f_1292_178740_178774(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 178740, 178774);
                    return return_v;
                }


                int
                f_1292_178677_178775(System.Type
                type)
                {
                    PSVariableAssignmentBinder.NoteTypeHasInstanceMemberOrTypeName(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 178677, 178775);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_178834_178865(System.Management.Automation.PSMemberSet
                this_param)
                {
                    var return_v = this_param.InternalMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 178834, 178865);
                    return return_v;
                }


                int
                f_1292_178834_178900(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                this_param, System.Management.Automation.PSMemberInfo
                member, bool
                preValidated)
                {
                    this_param.Add(member, preValidated);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 178834, 178900);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 176640, 178912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 176640, 178912);
            }
        }

        public override void Remove(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 179521, 180536);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 179586, 179714) || true) && (f_1292_179590_179616(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 179586, 179714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 179650, 179699);

                    throw f_1292_179656_179698("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 179586, 179714);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 179730, 179864) || true) && (_mshOwner != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 179730, 179864);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 179785, 179824);

                    f_1292_179785_179823(f_1292_179785_179810(_mshOwner), name);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 179842, 179849);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 179730, 179864);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 179880, 180142) || true) && (f_1292_179884_179911_M(!_memberSetOwner.IsInstance))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 179880, 180142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 179945, 180127);

                    throw f_1292_179951_180126("AddMemberToStaticMemberSet", null, f_1292_180061_180098(), name);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 179880, 180142);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 180158, 180464) || true) && (f_1292_180162_180198(f_1292_180177_180197(_memberSetOwner)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 180158, 180464);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 180232, 180449);

                    throw f_1292_180238_180448("CannotRemoveFromReservedNameMemberset", null, f_1292_180359_180404(), f_1292_180427_180447(_memberSetOwner));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 180158, 180464);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 180480, 180525);

                f_1292_180480_180524(f_1292_180480_180511(_memberSetOwner), name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 179521, 180536);

                bool
                f_1292_179590_179616(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 179590, 179616);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1292_179656_179698(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 179656, 179698);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_179785_179810(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InstanceMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 179785, 179810);
                    return return_v;
                }


                int
                f_1292_179785_179823(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                this_param, string
                name)
                {
                    this_param.Remove(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 179785, 179823);
                    return 0;
                }


                bool
                f_1292_179884_179911_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 179884, 179911);
                    return return_v;
                }


                string
                f_1292_180061_180098()
                {
                    var return_v = ExtendedTypeSystem.ChangeStaticMember;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 180061, 180098);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1292_179951_180126(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 179951, 180126);
                    return return_v;
                }


                string
                f_1292_180177_180197(System.Management.Automation.PSMemberSet
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 180177, 180197);
                    return return_v;
                }


                bool
                f_1292_180162_180198(string
                name)
                {
                    var return_v = IsReservedName(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 180162, 180198);
                    return return_v;
                }


                string
                f_1292_180359_180404()
                {
                    var return_v = ExtendedTypeSystem.CannotChangeReservedMember;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 180359, 180404);
                    return return_v;
                }


                string
                f_1292_180427_180447(System.Management.Automation.PSMemberSet
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 180427, 180447);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeSystemException
                f_1292_180238_180448(string
                errorId, System.Exception
                innerException, string
                resourceString, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeSystemException(errorId, innerException, resourceString, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 180238, 180448);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_180480_180511(System.Management.Automation.PSMemberSet
                this_param)
                {
                    var return_v = this_param.InternalMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 180480, 180511);
                    return return_v;
                }


                int
                f_1292_180480_180524(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                this_param, string
                name)
                {
                    this_param.Remove(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 180480, 180524);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 179521, 180536);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 179521, 180536);
            }
        }

        private void EnsureReservedMemberIsLoaded(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 181001, 182391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 181080, 181177);

                f_1292_181080_181176(!f_1292_181100_181126(name), "Name cannot be null or empty");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 181252, 182380) || true) && (f_1292_181256_181267(name) >= 6 && (DynAbs.Tracing.TraceSender.Expression_True(1292, 181256, 181310) && (f_1292_181277_181284(name, 0) == 'p' || (DynAbs.Tracing.TraceSender.Expression_False(1292, 181277, 181309) || f_1292_181295_181302(name, 0) == 'P'))) && (DynAbs.Tracing.TraceSender.Expression_True(1292, 181256, 181348) && (f_1292_181315_181322(name, 1) == 's' || (DynAbs.Tracing.TraceSender.Expression_False(1292, 181315, 181347) || f_1292_181333_181340(name, 1) == 'S'))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 181252, 182380);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 181382, 182365);

                    switch (f_1292_181390_181413(name))
                    {

                        case PSObject.BaseObjectMemberSetName:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 181382, 182365);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 181519, 181574);

                            f_1292_181519_181573(_mshOwner);
                            DynAbs.Tracing.TraceSender.TraceBreak(1292, 181600, 181606);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 181382, 182365);

                        case PSObject.AdaptedMemberSetName:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 181382, 182365);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 181689, 181747);

                            f_1292_181689_181746(_mshOwner);
                            DynAbs.Tracing.TraceSender.TraceBreak(1292, 181773, 181779);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 181382, 182365);

                        case PSObject.ExtendedMemberSetName:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 181382, 182365);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 181863, 181922);

                            f_1292_181863_181921(_mshOwner);
                            DynAbs.Tracing.TraceSender.TraceBreak(1292, 181948, 181954);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 181382, 182365);

                        case PSObject.PSObjectMemberSetName:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 181382, 182365);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 182038, 182095);

                            f_1292_182038_182094(_mshOwner);
                            DynAbs.Tracing.TraceSender.TraceBreak(1292, 182121, 182127);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 181382, 182365);

                        case PSObject.PSTypeNames:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 181382, 182365);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 182201, 182252);

                            f_1292_182201_182251(_mshOwner);
                            DynAbs.Tracing.TraceSender.TraceBreak(1292, 182278, 182284);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 181382, 182365);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 181382, 182365);
                            DynAbs.Tracing.TraceSender.TraceBreak(1292, 182340, 182346);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 181382, 182365);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 181252, 182380);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 181001, 182391);

                bool
                f_1292_181100_181126(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 181100, 181126);
                    return return_v;
                }


                int
                f_1292_181080_181176(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 181080, 181176);
                    return 0;
                }


                int
                f_1292_181256_181267(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 181256, 181267);
                    return return_v;
                }


                char
                f_1292_181277_181284(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 181277, 181284);
                    return return_v;
                }


                char
                f_1292_181295_181302(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 181295, 181302);
                    return return_v;
                }


                char
                f_1292_181315_181322(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 181315, 181322);
                    return return_v;
                }


                char
                f_1292_181333_181340(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 181333, 181340);
                    return return_v;
                }


                string
                f_1292_181390_181413(string
                this_param)
                {
                    var return_v = this_param.ToLowerInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 181390, 181413);
                    return return_v;
                }


                object
                f_1292_181519_181573(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = ReservedNameMembers.GeneratePSBaseMemberSet((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 181519, 181573);
                    return return_v;
                }


                object
                f_1292_181689_181746(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = ReservedNameMembers.GeneratePSAdaptedMemberSet((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 181689, 181746);
                    return return_v;
                }


                object
                f_1292_181863_181921(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = ReservedNameMembers.GeneratePSExtendedMemberSet((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 181863, 181921);
                    return return_v;
                }


                object
                f_1292_182038_182094(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = ReservedNameMembers.GeneratePSObjectMemberSet((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 182038, 182094);
                    return return_v;
                }


                int
                f_1292_182201_182251(System.Management.Automation.PSObject
                obj)
                {
                    ReservedNameMembers.GeneratePSTypeNames((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 182201, 182251);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 181001, 182391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 181001, 182391);
            }
        }

        /// <summary>
        /// Returns the name corresponding to name or null if it is not present.
        /// </summary>
        /// <param name="name">Name of the member to return.</param>
        /// <exception cref="ArgumentException">For invalid arguments.</exception>
        public override T this[string name]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 182746, 185705);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 182782, 185690);
                    using (f_1292_182789_182835(f_1292_182789_182814(), "Lookup"))
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 182877, 183029) || true) && (f_1292_182881_182907(name))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 182877, 183029);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 182957, 183006);

                            throw f_1292_182963_183005("name");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 182877, 183029);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 183053, 183073);

                        PSMemberInfo
                        member
                        = default(PSMemberInfo);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 183095, 183116);

                        object
                        delegateOwner
                        = default(object);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 183138, 184905) || true) && (_mshOwner != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 183138, 184905);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 183388, 183423);

                            f_1292_183388_183422(this, name);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 183449, 183475);

                            delegateOwner = _mshOwner;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 183501, 183562);

                            PSMemberInfoInternalCollection<PSMemberInfo>
                            instanceMembers
                            = default(PSMemberInfoInternalCollection<PSMemberInfo>);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 183588, 184052) || true) && (f_1292_183592_183651(_mshOwner, out instanceMembers))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 183588, 184052);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 183709, 183740);

                                member = f_1292_183718_183739(instanceMembers, name);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 183770, 184025) || true) && (member is T memberAsT)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 183770, 184025);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 183861, 183943);

                                    f_1292_183861_183942(f_1292_183861_183886(), "Found PSObject instance member: {0}.", name);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 183977, 183994);

                                    return memberAsT;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 183770, 184025);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 183588, 184052);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 183138, 184905);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 183138, 184905);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 184150, 184197);

                            member = f_1292_184159_184196(f_1292_184159_184190(_memberSetOwner), name);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 184223, 184264);

                            delegateOwner = _memberSetOwner.instance;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 184290, 184882) || true) && (member is T memberAsT)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 184290, 184882);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 184662, 184738);

                                f_1292_184662_184737(f_1292_184662_184687(), "Found PSMemberSet member: {0}.", name);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 184768, 184808);

                                f_1292_184768_184807(member, delegateOwner);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 184838, 184855);

                                return memberAsT;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 184290, 184882);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 183138, 184905);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 184929, 184993) || true) && (delegateOwner == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 184929, 184993);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 184981, 184993);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 184929, 184993);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 185017, 185068);

                        delegateOwner = f_1292_185033_185067(delegateOwner);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 185090, 185635);
                            foreach (CollectionEntry<T> collection in f_1292_185132_185143_I(f_1292_185132_185143()))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 185090, 185635);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 185193, 185321);

                                f_1292_185193_185320(delegateOwner != null, "all integrating collections with non empty collections have an associated PSObject");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 185347, 185413);

                                T
                                memberAsT = f_1292_185361_185412(collection, delegateOwner, name)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 185439, 185612) || true) && (memberAsT != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 185439, 185612);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 185518, 185585);

                                    return f_1292_185525_185584(collection, delegateOwner, memberAsT);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 185439, 185612);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 185090, 185635);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 546);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 546);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 185659, 185671);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1292, 182782, 185690);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 182746, 185705);

                    System.Management.Automation.PSTraceSource
                    f_1292_182789_182814()
                    {
                        var return_v = PSObject.MemberResolution;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 182789, 182814);
                        return return_v;
                    }


                    System.IDisposable
                    f_1292_182789_182835(System.Management.Automation.PSTraceSource
                    this_param, string
                    msg)
                    {
                        var return_v = this_param.TraceScope(msg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 182789, 182835);
                        return return_v;
                    }


                    bool
                    f_1292_182881_182907(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 182881, 182907);
                        return return_v;
                    }


                    System.Management.Automation.PSArgumentException
                    f_1292_182963_183005(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 182963, 183005);
                        return return_v;
                    }


                    int
                    f_1292_183388_183422(System.Management.Automation.PSMemberInfoIntegratingCollection<T>
                    this_param, string
                    name)
                    {
                        this_param.EnsureReservedMemberIsLoaded(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 183388, 183422);
                        return 0;
                    }


                    bool
                    f_1292_183592_183651(System.Management.Automation.PSObject
                    obj, out System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                    instanceMembers)
                    {
                        var return_v = PSObject.HasInstanceMembers((object)obj, out instanceMembers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 183592, 183651);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfo
                    f_1292_183718_183739(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 183718, 183739);
                        return return_v;
                    }


                    System.Management.Automation.PSTraceSource
                    f_1292_183861_183886()
                    {
                        var return_v = PSObject.MemberResolution;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 183861, 183886);
                        return return_v;
                    }


                    int
                    f_1292_183861_183942(System.Management.Automation.PSTraceSource
                    this_param, string
                    format, string
                    arg1)
                    {
                        this_param.WriteLine(format, (object)arg1);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 183861, 183942);
                        return 0;
                    }


                    System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                    f_1292_184159_184190(System.Management.Automation.PSMemberSet
                    this_param)
                    {
                        var return_v = this_param.InternalMembers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 184159, 184190);
                        return return_v;
                    }


                    System.Management.Automation.PSMemberInfo
                    f_1292_184159_184196(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 184159, 184196);
                        return return_v;
                    }


                    System.Management.Automation.PSTraceSource
                    f_1292_184662_184687()
                    {
                        var return_v =                             // In membersets we cannot replicate the instance when adding
                                                                   // since the memberset might not yet have an associated PSObject.
                                                                   // We replicate the instance when returning the members of the memberset.
                                                    PSObject.MemberResolution;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 184662, 184687);
                        return return_v;
                    }


                    int
                    f_1292_184662_184737(System.Management.Automation.PSTraceSource
                    this_param, string
                    format, string
                    arg1)
                    {
                        this_param.WriteLine(format, (object)arg1);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 184662, 184737);
                        return 0;
                    }


                    int
                    f_1292_184768_184807(System.Management.Automation.PSMemberInfo
                    this_param, object
                    particularInstance)
                    {
                        this_param.ReplicateInstance(particularInstance);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 184768, 184807);
                        return 0;
                    }


                    System.Management.Automation.PSObject
                    f_1292_185033_185067(object
                    obj)
                    {
                        var return_v = PSObject.AsPSObject(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 185033, 185067);
                        return return_v;
                    }


                    System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<T>>
                    f_1292_185132_185143()
                    {
                        var return_v = Collections;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 185132, 185143);
                        return return_v;
                    }


                    int
                    f_1292_185193_185320(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 185193, 185320);
                        return 0;
                    }


                    T
                    f_1292_185361_185412(System.Management.Automation.CollectionEntry<T>
                    this_param, object
                    obj, string
                    name)
                    {
                        var return_v = this_param.GetMember((System.Management.Automation.PSObject)obj, name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 185361, 185412);
                        return return_v;
                    }


                    T
                    f_1292_185525_185584(System.Management.Automation.CollectionEntry<T>
                    this_param, object
                    owner, T
                    member)
                    {
                        var return_v = this_param.CloneOrReplicateObject(owner, member);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 185525, 185584);
                        return return_v;
                    }


                    System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<T>>
                    f_1292_185132_185143_I(System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<T>>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 185132, 185143);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 182746, 185705);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 182746, 185705);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private PSMemberInfoInternalCollection<T> GetIntegratedMembers(MshMemberMatchOptions matchOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 185728, 188758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 185851, 188747);
                using (f_1292_185858_185934(f_1292_185858_185883(), "Generating the total list of members"))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 185968, 186056);

                    PSMemberInfoInternalCollection<T>
                    returnValue = f_1292_186016_186055()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 186074, 186095);

                    object
                    delegateOwner
                    = default(object);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 186113, 187274) || true) && (_mshOwner != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 186113, 187274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 186176, 186202);

                        delegateOwner = _mshOwner;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 186224, 186627);
                            foreach (PSMemberInfo member in f_1292_186256_186281_I(f_1292_186256_186281(_mshOwner)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 186224, 186627);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 186331, 186604) || true) && (f_1292_186335_186370(member, matchOptions))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 186331, 186604);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 186428, 186577) || true) && (member is T memberAsT)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 186428, 186577);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 186519, 186546);

                                        f_1292_186519_186545(returnValue, memberAsT);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 186428, 186577);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 186331, 186604);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 186224, 186627);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 404);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 404);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 186113, 187274);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 186113, 187274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 186709, 186750);

                        delegateOwner = _memberSetOwner.instance;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 186772, 187255);
                            foreach (PSMemberInfo member in f_1292_186804_186835_I(f_1292_186804_186835(_memberSetOwner)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 186772, 187255);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 186885, 187232) || true) && (f_1292_186889_186924(member, matchOptions))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 186885, 187232);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 186982, 187205) || true) && (member is T memberAsT)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 186982, 187205);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 187073, 187113);

                                        f_1292_187073_187112(member, delegateOwner);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 187147, 187174);

                                        f_1292_187147_187173(returnValue, memberAsT);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 186982, 187205);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 186885, 187232);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 186772, 187255);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 484);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 484);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 186113, 187274);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 187294, 187361) || true) && (delegateOwner == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 187294, 187361);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 187342, 187361);

                        return returnValue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 187294, 187361);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 187381, 187432);

                    delegateOwner = f_1292_187397_187431(delegateOwner);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 187450, 188693);
                        foreach (CollectionEntry<T> collection in f_1292_187492_187503_I(f_1292_187492_187503()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 187450, 188693);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 187545, 187636);

                            PSMemberInfoInternalCollection<T>
                            members = f_1292_187589_187635(collection, delegateOwner)
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 187658, 188674);
                                foreach (T member in f_1292_187679_187686_I(members))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 187658, 188674);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 187736, 187791);

                                    PSMemberInfo
                                    previousMember = f_1292_187766_187790(returnValue, f_1292_187778_187789(member))
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 187817, 188219) || true) && (previousMember != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 187817, 188219);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 187901, 188153);

                                        f_1292_187901_188152(f_1292_187901_187926(), "Member \"{0}\" of type \"{1}\" has been ignored because a member with the same name and type \"{2}\" is already present.", f_1292_188094_188105(member), f_1292_188107_188124(member), f_1292_188126_188151(previousMember));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 188183, 188192);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 187817, 188219);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 188247, 188495) || true) && (!f_1292_188252_188287(member, matchOptions))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 188247, 188495);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 188345, 188429);

                                        f_1292_188345_188428(f_1292_188345_188370(), "Skipping hidden member \"{0}\".", f_1292_188416_188427(member));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 188459, 188468);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 188247, 188495);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 188523, 188596);

                                    T
                                    memberToAdd = f_1292_188539_188595(collection, delegateOwner, member)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 188622, 188651);

                                    f_1292_188622_188650(returnValue, memberToAdd);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 187658, 188674);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 1017);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 1017);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 187450, 188693);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 1244);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 1244);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 188713, 188732);

                    return returnValue;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1292, 185851, 188747);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 185728, 188758);

                System.Management.Automation.PSTraceSource
                f_1292_185858_185883()
                {
                    var return_v = PSObject.MemberResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 185858, 185883);
                    return return_v;
                }


                System.IDisposable
                f_1292_185858_185934(System.Management.Automation.PSTraceSource
                this_param, string
                msg)
                {
                    var return_v = this_param.TraceScope(msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 185858, 185934);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<T>
                f_1292_186016_186055()
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 186016, 186055);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_186256_186281(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InstanceMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 186256, 186281);
                    return return_v;
                }


                bool
                f_1292_186335_186370(System.Management.Automation.PSMemberInfo
                this_param, System.Management.Automation.MshMemberMatchOptions
                options)
                {
                    var return_v = this_param.MatchesOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 186335, 186370);
                    return return_v;
                }


                int
                f_1292_186519_186545(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, T
                member)
                {
                    this_param.Add(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 186519, 186545);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_186256_186281_I(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 186256, 186281);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_186804_186835(System.Management.Automation.PSMemberSet
                this_param)
                {
                    var return_v = this_param.InternalMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 186804, 186835);
                    return return_v;
                }


                bool
                f_1292_186889_186924(System.Management.Automation.PSMemberInfo
                this_param, System.Management.Automation.MshMemberMatchOptions
                options)
                {
                    var return_v = this_param.MatchesOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 186889, 186924);
                    return return_v;
                }


                int
                f_1292_187073_187112(System.Management.Automation.PSMemberInfo
                this_param, object
                particularInstance)
                {
                    this_param.ReplicateInstance(particularInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 187073, 187112);
                    return 0;
                }


                int
                f_1292_187147_187173(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, T
                member)
                {
                    this_param.Add(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 187147, 187173);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_186804_186835_I(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 186804, 186835);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1292_187397_187431(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 187397, 187431);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<T>>
                f_1292_187492_187503()
                {
                    var return_v = Collections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 187492, 187503);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<T>
                f_1292_187589_187635(System.Management.Automation.CollectionEntry<T>
                this_param, object
                obj)
                {
                    var return_v = this_param.GetMembers((System.Management.Automation.PSObject)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 187589, 187635);
                    return return_v;
                }


                string
                f_1292_187778_187789(T
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 187778, 187789);
                    return return_v;
                }


                T
                f_1292_187766_187790(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 187766, 187790);
                    return return_v;
                }


                System.Management.Automation.PSTraceSource
                f_1292_187901_187926()
                {
                    var return_v = PSObject.MemberResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 187901, 187926);
                    return return_v;
                }


                string
                f_1292_188094_188105(T
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 188094, 188105);
                    return return_v;
                }


                System.Management.Automation.PSMemberTypes
                f_1292_188107_188124(T
                this_param)
                {
                    var return_v = this_param.MemberType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 188107, 188124);
                    return return_v;
                }


                System.Management.Automation.PSMemberTypes
                f_1292_188126_188151(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.MemberType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 188126, 188151);
                    return return_v;
                }


                int
                f_1292_187901_188152(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, System.Management.Automation.PSMemberTypes
                arg2, System.Management.Automation.PSMemberTypes
                arg3)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2, (object)arg3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 187901, 188152);
                    return 0;
                }


                bool
                f_1292_188252_188287(T
                this_param, System.Management.Automation.MshMemberMatchOptions
                options)
                {
                    var return_v = this_param.MatchesOptions(options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 188252, 188287);
                    return return_v;
                }


                System.Management.Automation.PSTraceSource
                f_1292_188345_188370()
                {
                    var return_v = PSObject.MemberResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 188345, 188370);
                    return return_v;
                }


                string
                f_1292_188416_188427(T
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 188416, 188427);
                    return return_v;
                }


                int
                f_1292_188345_188428(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 188345, 188428);
                    return 0;
                }


                T
                f_1292_188539_188595(System.Management.Automation.CollectionEntry<T>
                this_param, object
                owner, T
                member)
                {
                    var return_v = this_param.CloneOrReplicateObject(owner, member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 188539, 188595);
                    return return_v;
                }


                int
                f_1292_188622_188650(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, T
                member)
                {
                    this_param.Add(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 188622, 188650);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<T>
                f_1292_187679_187686_I(System.Management.Automation.PSMemberInfoInternalCollection<T>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 187679, 187686);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<T>>
                f_1292_187492_187503_I(System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<T>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 187492, 187503);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 185728, 188758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 185728, 188758);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ReadOnlyPSMemberInfoCollection<T> Match(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 189151, 189465);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 189244, 189372) || true) && (f_1292_189248_189274(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 189244, 189372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 189308, 189357);

                    throw f_1292_189314_189356("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 189244, 189372);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 189388, 189454);

                return f_1292_189395_189453(this, name, PSMemberTypes.All, MshMemberMatchOptions.None);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 189151, 189465);

                bool
                f_1292_189248_189274(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 189248, 189274);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1292_189314_189356(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 189314, 189356);
                    return return_v;
                }


                System.Management.Automation.ReadOnlyPSMemberInfoCollection<T>
                f_1292_189395_189453(System.Management.Automation.PSMemberInfoIntegratingCollection<T>
                this_param, string
                name, System.Management.Automation.PSMemberTypes
                memberTypes, System.Management.Automation.MshMemberMatchOptions
                matchOptions)
                {
                    var return_v = this_param.Match(name, memberTypes, matchOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 189395, 189453);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 189151, 189465);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 189151, 189465);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ReadOnlyPSMemberInfoCollection<T> Match(string name, PSMemberTypes memberTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 189961, 190296);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 190081, 190209) || true) && (f_1292_190085_190111(name))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 190081, 190209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 190145, 190194);

                    throw f_1292_190151_190193("name");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 190081, 190209);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 190225, 190285);

                return f_1292_190232_190284(this, name, memberTypes, MshMemberMatchOptions.None);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 189961, 190296);

                bool
                f_1292_190085_190111(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 190085, 190111);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1292_190151_190193(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 190151, 190193);
                    return return_v;
                }


                System.Management.Automation.ReadOnlyPSMemberInfoCollection<T>
                f_1292_190232_190284(System.Management.Automation.PSMemberInfoIntegratingCollection<T>
                this_param, string
                name, System.Management.Automation.PSMemberTypes
                memberTypes, System.Management.Automation.MshMemberMatchOptions
                matchOptions)
                {
                    var return_v = this_param.Match(name, memberTypes, matchOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 190232, 190284);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 189961, 190296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 189961, 190296);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ReadOnlyPSMemberInfoCollection<T> Match(string name, PSMemberTypes memberTypes, MshMemberMatchOptions matchOptions)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 190856, 191892);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 191014, 191881);
                using (f_1292_191021_191083(f_1292_191021_191046(), "Matching \"{0}\"", name))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 191117, 191257) || true) && (f_1292_191121_191147(name))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 191117, 191257);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 191189, 191238);

                        throw f_1292_191195_191237("name");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 191117, 191257);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 191277, 191388) || true) && (_mshOwner != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 191277, 191388);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 191340, 191369);

                        f_1292_191340_191368(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 191277, 191388);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 191408, 191469);

                    WildcardPattern
                    nameMatch = f_1292_191436_191468(name)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 191487, 191569);

                    PSMemberInfoInternalCollection<T>
                    allMembers = f_1292_191534_191568(this, matchOptions)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 191587, 191734);

                    ReadOnlyPSMemberInfoCollection<T>
                    returnValue = f_1292_191635_191733(f_1292_191673_191732(allMembers, name, nameMatch, memberTypes))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 191752, 191829);

                    f_1292_191752_191828(f_1292_191752_191777(), "{0} total matches.", f_1292_191810_191827(returnValue));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 191847, 191866);

                    return returnValue;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1292, 191014, 191881);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 190856, 191892);

                System.Management.Automation.PSTraceSource
                f_1292_191021_191046()
                {
                    var return_v = PSObject.MemberResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 191021, 191046);
                    return return_v;
                }


                System.IDisposable
                f_1292_191021_191083(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    var return_v = this_param.TraceScope(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 191021, 191083);
                    return return_v;
                }


                bool
                f_1292_191121_191147(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 191121, 191147);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1292_191195_191237(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 191195, 191237);
                    return return_v;
                }


                int
                f_1292_191340_191368(System.Management.Automation.PSMemberInfoIntegratingCollection<T>
                this_param)
                {
                    this_param.GenerateAllReservedMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 191340, 191368);
                    return 0;
                }


                System.Management.Automation.WildcardPattern
                f_1292_191436_191468(string
                name)
                {
                    var return_v = MemberMatch.GetNamePattern(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 191436, 191468);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<T>
                f_1292_191534_191568(System.Management.Automation.PSMemberInfoIntegratingCollection<T>
                this_param, System.Management.Automation.MshMemberMatchOptions
                matchOptions)
                {
                    var return_v = this_param.GetIntegratedMembers(matchOptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 191534, 191568);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<T>
                f_1292_191673_191732(System.Management.Automation.PSMemberInfoInternalCollection<T>
                memberList, string
                name, System.Management.Automation.WildcardPattern
                nameMatch, System.Management.Automation.PSMemberTypes
                memberTypes)
                {
                    var return_v = MemberMatch.Match(memberList, name, nameMatch, memberTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 191673, 191732);
                    return return_v;
                }


                System.Management.Automation.ReadOnlyPSMemberInfoCollection<T>
                f_1292_191635_191733(System.Management.Automation.PSMemberInfoInternalCollection<T>
                members)
                {
                    var return_v = new System.Management.Automation.ReadOnlyPSMemberInfoCollection<T>(members);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 191635, 191733);
                    return return_v;
                }


                System.Management.Automation.PSTraceSource
                f_1292_191752_191777()
                {
                    var return_v = PSObject.MemberResolution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 191752, 191777);
                    return return_v;
                }


                int
                f_1292_191810_191827(System.Management.Automation.ReadOnlyPSMemberInfoCollection<T>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 191810, 191827);
                    return return_v;
                }


                int
                f_1292_191752_191828(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 191752, 191828);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 190856, 191892);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 190856, 191892);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IEnumerator<T> GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 192187, 192300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 192258, 192289);

                return f_1292_192265_192288(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 192187, 192300);

                System.Management.Automation.PSMemberInfoIntegratingCollection<T>.Enumerator<T>
                f_1292_192265_192288(System.Management.Automation.PSMemberInfoIntegratingCollection<T>
                integratingCollection)
                {
                    var return_v = new System.Management.Automation.PSMemberInfoIntegratingCollection<T>.Enumerator<T>(integratingCollection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 192265, 192288);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 192187, 192300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 192187, 192300);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override T FirstOrDefault(MemberNamePredicate predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 192312, 193883);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 192402, 192423);

                object
                delegateOwner
                = default(object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 192437, 193275) || true) && (_mshOwner != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 192437, 193275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 192492, 192518);

                    delegateOwner = _mshOwner;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 192536, 192798);
                        foreach (PSMemberInfo member in f_1292_192568_192593_I(f_1292_192568_192593(_mshOwner)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 192536, 192798);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 192635, 192779) || true) && (member is T memberAsT && (DynAbs.Tracing.TraceSender.Expression_True(1292, 192639, 192689) && f_1292_192664_192689(predicate, f_1292_192674_192688(memberAsT))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 192635, 192779);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 192739, 192756);

                                return memberAsT;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 192635, 192779);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 192536, 192798);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 263);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 263);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 192437, 193275);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 192437, 193275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 192864, 192905);

                    delegateOwner = _memberSetOwner.instance;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 192923, 193260);
                        foreach (PSMemberInfo member in f_1292_192955_192986_I(f_1292_192955_192986(_memberSetOwner)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 192923, 193260);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 193028, 193241) || true) && (member is T memberAsT && (DynAbs.Tracing.TraceSender.Expression_True(1292, 193032, 193082) && f_1292_193057_193082(predicate, f_1292_193067_193081(memberAsT))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 193028, 193241);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 193132, 193175);

                                f_1292_193132_193174(memberAsT, delegateOwner);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 193201, 193218);

                                return memberAsT;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 193028, 193241);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 192923, 193260);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 338);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 338);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 192437, 193275);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 193291, 193377) || true) && (delegateOwner == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 193291, 193377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 193350, 193362);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 193291, 193377);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 193393, 193447);

                var
                ownerAsPSObj = f_1292_193412_193446(delegateOwner)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 193470, 193475);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 193461, 193844) || true) && (i < f_1292_193481_193498(f_1292_193481_193492()))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 193500, 193503)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 193461, 193844))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 193461, 193844);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 193537, 193574);

                        var
                        collectionEntry = f_1292_193559_193573(f_1292_193559_193570(), i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 193592, 193664);

                        var
                        member = f_1292_193605_193663(collectionEntry, ownerAsPSObj, predicate)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 193682, 193829) || true) && (member != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 193682, 193829);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 193742, 193810);

                            return f_1292_193749_193809(collectionEntry, ownerAsPSObj, member);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 193682, 193829);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 1, 384);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 1, 384);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 193860, 193872);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 192312, 193883);

                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_192568_192593(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InstanceMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 192568, 192593);
                    return return_v;
                }


                string
                f_1292_192674_192688(T
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 192674, 192688);
                    return return_v;
                }


                bool
                f_1292_192664_192689(System.Management.Automation.MemberNamePredicate
                this_param, string
                memberName)
                {
                    var return_v = this_param.Invoke(memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 192664, 192689);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_192568_192593_I(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 192568, 192593);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_192955_192986(System.Management.Automation.PSMemberSet
                this_param)
                {
                    var return_v = this_param.InternalMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 192955, 192986);
                    return return_v;
                }


                string
                f_1292_193067_193081(T
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 193067, 193081);
                    return return_v;
                }


                bool
                f_1292_193057_193082(System.Management.Automation.MemberNamePredicate
                this_param, string
                memberName)
                {
                    var return_v = this_param.Invoke(memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 193057, 193082);
                    return return_v;
                }


                int
                f_1292_193132_193174(T
                this_param, object
                particularInstance)
                {
                    this_param.ReplicateInstance(particularInstance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 193132, 193174);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1292_192955_192986_I(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 192955, 192986);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1292_193412_193446(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 193412, 193446);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<T>>
                f_1292_193481_193492()
                {
                    var return_v = Collections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 193481, 193492);
                    return return_v;
                }


                int
                f_1292_193481_193498(System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<T>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 193481, 193498);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<T>>
                f_1292_193559_193570()
                {
                    var return_v = Collections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 193559, 193570);
                    return return_v;
                }


                System.Management.Automation.CollectionEntry<T>
                f_1292_193559_193573(System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<T>>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 193559, 193573);
                    return return_v;
                }


                T
                f_1292_193605_193663(System.Management.Automation.CollectionEntry<T>
                this_param, System.Management.Automation.PSObject
                obj, System.Management.Automation.MemberNamePredicate
                predicate)
                {
                    var return_v = this_param.GetFirstOrDefault(obj, predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 193605, 193663);
                    return return_v;
                }


                T
                f_1292_193749_193809(System.Management.Automation.CollectionEntry<T>
                this_param, System.Management.Automation.PSObject
                owner, T
                member)
                {
                    var return_v = this_param.CloneOrReplicateObject((object)owner, member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 193749, 193809);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 192312, 193883);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 192312, 193883);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal struct Enumerator<S> : IEnumerator<S> where S : PSMemberInfo
        {

            private S _current;

            private int _currentIndex;

            private readonly PSMemberInfoInternalCollection<S> _allMembers;

            internal Enumerator(PSMemberInfoIntegratingCollection<S> integratingCollection)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1292, 194473, 195714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 194585, 195699);
                    using (f_1292_194592_194649(f_1292_194592_194617(), "Enumeration Start"))
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 194691, 194710);

                        _currentIndex = -1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 194732, 194748);

                        _current = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 194770, 194855);

                        _allMembers = f_1292_194784_194854(integratingCollection, MshMemberMatchOptions.None);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 194877, 195680) || true) && (integratingCollection._mshOwner != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 194877, 195680);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 194970, 195021);

                            f_1292_194970_195020(integratingCollection);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 195047, 195198);

                            f_1292_195047_195197(f_1292_195047_195072(), "Enumerating PSObject with type \"{0}\".", f_1292_195126_195196(f_1292_195126_195187(f_1292_195126_195177(integratingCollection._mshOwner))));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 195224, 195320);

                            f_1292_195224_195319(f_1292_195224_195249(), "PSObject instance members: {0}", f_1292_195294_195318(_allMembers));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 194877, 195680);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 194877, 195680);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 195418, 195534);

                            f_1292_195418_195533(f_1292_195418_195443(), "Enumerating PSMemberSet \"{0}\".", f_1292_195490_195532(integratingCollection._memberSetOwner));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 195560, 195657);

                            f_1292_195560_195656(f_1292_195560_195585(), "MemberSet instance members: {0}", f_1292_195631_195655(_allMembers));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 194877, 195680);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1292, 194585, 195699);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1292, 194473, 195714);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 194473, 195714);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 194473, 195714);
                }
            }

            public bool MoveNext()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 196001, 196676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 196056, 196072);

                    _currentIndex++;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 196092, 196108);

                    S
                    member = null
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 196126, 196424) || true) && (_currentIndex < f_1292_196149_196166(_allMembers))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 196126, 196424);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 196208, 196244);

                            member = f_1292_196217_196243(_allMembers, _currentIndex);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 196266, 196365) || true) && (f_1292_196270_196286_M(!member.IsHidden))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 196266, 196365);
                                DynAbs.Tracing.TraceSender.TraceBreak(1292, 196336, 196342);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 196266, 196365);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 196389, 196405);

                            _currentIndex++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 196126, 196424);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1292, 196126, 196424);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1292, 196126, 196424);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 196444, 196594) || true) && (_currentIndex < f_1292_196464_196481(_allMembers))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 196444, 196594);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 196523, 196541);

                        _current = member;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 196563, 196575);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 196444, 196594);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 196614, 196630);

                    _current = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 196648, 196661);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 196001, 196676);

                    int
                    f_1292_196149_196166(System.Management.Automation.PSMemberInfoInternalCollection<S>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 196149, 196166);
                        return return_v;
                    }


                    S
                    f_1292_196217_196243(System.Management.Automation.PSMemberInfoInternalCollection<S>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 196217, 196243);
                        return return_v;
                    }


                    bool
                    f_1292_196270_196286_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 196270, 196286);
                        return return_v;
                    }


                    int
                    f_1292_196464_196481(System.Management.Automation.PSMemberInfoInternalCollection<S>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 196464, 196481);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 196001, 196676);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 196001, 196676);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            S IEnumerator<S>.Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 196950, 197200);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 196994, 197141) || true) && (_currentIndex == -1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1292, 196994, 197141);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 197067, 197118);

                            throw f_1292_197073_197117();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1292, 196994, 197141);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 197165, 197181);

                        return _current;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 196950, 197200);

                        System.Management.Automation.PSInvalidOperationException
                        f_1292_197073_197117()
                        {
                            var return_v = PSTraceSource.NewInvalidOperationException();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 197073, 197117);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 196893, 197215);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 196893, 197215);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 197258, 197291);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 197261, 197291);
                        return f_1292_197261_197291(((IEnumerator<S>)this));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 197258, 197291);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 197258, 197291);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 197258, 197291);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            void IEnumerator.Reset()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 197308, 197433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 197365, 197384);

                    _currentIndex = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1292, 197402, 197418);

                    _current = null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 197308, 197433);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 197308, 197433);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 197308, 197433);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1292, 197536, 197587);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1292, 197536, 197587);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1292, 197536, 197587);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 197536, 197587);
                }
            }
            static Enumerator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 194014, 197598);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 194014, 197598);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 194014, 197598);
            }

            static System.Management.Automation.PSTraceSource
            f_1292_194592_194617()
            {
                var return_v = PSObject.MemberResolution;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 194592, 194617);
                return return_v;
            }


            static System.IDisposable
            f_1292_194592_194649(System.Management.Automation.PSTraceSource
            this_param, string
            msg)
            {
                var return_v = this_param.TraceScope(msg);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 194592, 194649);
                return return_v;
            }


            static System.Management.Automation.PSMemberInfoInternalCollection<S>
            f_1292_194784_194854(System.Management.Automation.PSMemberInfoIntegratingCollection<S>
            this_param, System.Management.Automation.MshMemberMatchOptions
            matchOptions)
            {
                var return_v = this_param.GetIntegratedMembers(matchOptions);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 194784, 194854);
                return return_v;
            }


            static int
            f_1292_194970_195020(System.Management.Automation.PSMemberInfoIntegratingCollection<S>
            this_param)
            {
                this_param.GenerateAllReservedMembers();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 194970, 195020);
                return 0;
            }


            static System.Management.Automation.PSTraceSource
            f_1292_195047_195072()
            {
                var return_v = PSObject.MemberResolution;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 195047, 195072);
                return return_v;
            }


            static object
            f_1292_195126_195177(System.Management.Automation.PSObject
            this_param)
            {
                var return_v = this_param.ImmediateBaseObject;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 195126, 195177);
                return return_v;
            }


            static System.Type
            f_1292_195126_195187(object
            this_param)
            {
                var return_v = this_param.GetType();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 195126, 195187);
                return return_v;
            }


            static string
            f_1292_195126_195196(System.Type
            this_param)
            {
                var return_v = this_param.FullName;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 195126, 195196);
                return return_v;
            }


            static int
            f_1292_195047_195197(System.Management.Automation.PSTraceSource
            this_param, string
            format, string
            arg1)
            {
                this_param.WriteLine(format, (object)arg1);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 195047, 195197);
                return 0;
            }


            static System.Management.Automation.PSTraceSource
            f_1292_195224_195249()
            {
                var return_v = PSObject.MemberResolution;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 195224, 195249);
                return return_v;
            }


            static int
            f_1292_195294_195318(System.Management.Automation.PSMemberInfoInternalCollection<S>
            this_param)
            {
                var return_v = this_param.VisibleCount;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 195294, 195318);
                return return_v;
            }


            static int
            f_1292_195224_195319(System.Management.Automation.PSTraceSource
            this_param, string
            format, int
            arg1)
            {
                this_param.WriteLine(format, arg1);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 195224, 195319);
                return 0;
            }


            static System.Management.Automation.PSTraceSource
            f_1292_195418_195443()
            {
                var return_v = PSObject.MemberResolution;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 195418, 195443);
                return return_v;
            }


            static string
            f_1292_195490_195532(System.Management.Automation.PSMemberSet
            this_param)
            {
                var return_v = this_param.Name;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 195490, 195532);
                return return_v;
            }


            static int
            f_1292_195418_195533(System.Management.Automation.PSTraceSource
            this_param, string
            format, string
            arg1)
            {
                this_param.WriteLine(format, (object)arg1);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 195418, 195533);
                return 0;
            }


            static System.Management.Automation.PSTraceSource
            f_1292_195560_195585()
            {
                var return_v = PSObject.MemberResolution;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 195560, 195585);
                return return_v;
            }


            static int
            f_1292_195631_195655(System.Management.Automation.PSMemberInfoInternalCollection<S>
            this_param)
            {
                var return_v = this_param.VisibleCount;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 195631, 195655);
                return return_v;
            }


            static int
            f_1292_195560_195656(System.Management.Automation.PSTraceSource
            this_param, string
            format, int
            arg1)
            {
                this_param.WriteLine(format, arg1);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 195560, 195656);
                return 0;
            }


            static S
            f_1292_197261_197291(System.Collections.Generic.IEnumerator<S>
            this_param)
            {
                var return_v = this_param.Current;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1292, 197261, 197291);
                return return_v;
            }

        }

        static PSMemberInfoIntegratingCollection()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1292, 170199, 197605);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1292, 170199, 197605);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1292, 170199, 197605);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1292, 170199, 197605);

        System.Management.Automation.PSArgumentNullException
        f_1292_171411_171458(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 171411, 171458);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1292_171675_171718(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 171675, 171718);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1292_171813_171866(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1292, 171813, 171866);
            return return_v;
        }

    }

}

#pragma warning restore 56503
