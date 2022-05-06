// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

using Microsoft.PowerShell.Commands;

namespace System.Management.Automation
{
    internal static class SessionStateConstants
    {
        internal const int
        DefaultVariableCapacity = 4096
        ;

        internal const int
        MaxVariablesCapacity = 32768
        ;

        internal const int
        MinVariablesCapacity = 1024
        ;

        internal const int
        DefaultAliasCapacity = 4096
        ;

        internal const int
        MaxAliasCapacity = 32768
        ;

        internal const int
        MinAliasCapacity = 1024
        ;

        internal const int
        DefaultFunctionCapacity = 4096
        ;

        internal const int
        MaxFunctionCapacity = 32768
        ;

        internal const int
        MinFunctionCapacity = 1024
        ;

        internal const int
        DefaultDriveCapacity = 4096
        ;

        internal const int
        MaxDriveCapacity = 32768
        ;

        internal const int
        MinDriveCapacity = 1024
        ;

        internal const int
        DefaultErrorCapacity = 256
        ;

        internal const int
        MaxErrorCapacity = 32768
        ;

        internal const int
        MinErrorCapacity = 256
        ;

        internal const int
        DefaultDictionaryCapacity = 100
        ;

        internal const float
        DefaultHashTableLoadFactor = 0.25F
        ;

        static SessionStateConstants()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1359, 418, 3354);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 606, 636);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 784, 812);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 959, 986);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 1125, 1152);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 1298, 1322);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 1468, 1491);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 1632, 1662);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 1810, 1837);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 1985, 2011);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 2149, 2176);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 2321, 2345);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 2490, 2513);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 2651, 2677);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 2822, 2846);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 2991, 3013);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 3150, 3181);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 3312, 3346);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1359, 418, 3354);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1359, 418, 3354);
        }

    }
    internal static class SessionStateUtilities
    {
        internal static Collection<T> ConvertArrayToCollection<T>(T[] array)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1359, 3871, 4236);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 3964, 4007);

                Collection<T>
                result = f_1359_3987_4006()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 4021, 4195) || true) && (array != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1359, 4021, 4195);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 4072, 4180);
                        foreach (T element in f_1359_4094_4099_I(array))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1359, 4072, 4180);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 4141, 4161);

                            f_1359_4141_4160(result, element);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1359, 4072, 4180);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1359, 1, 109);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1359, 1, 109);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1359, 4021, 4195);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 4211, 4225);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1359, 3871, 4236);

                System.Collections.ObjectModel.Collection<T>
                f_1359_3987_4006()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1359, 3987, 4006);
                    return return_v;
                }


                int
                f_1359_4141_4160(System.Collections.ObjectModel.Collection<T>
                this_param, T
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1359, 4141, 4160);
                    return 0;
                }


                T[]
                f_1359_4094_4099_I(T[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1359, 4094, 4099);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1359, 3871, 4236);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1359, 3871, 4236);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CollectionContainsValue(IEnumerable collection, object value, IComparer comparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1359, 5107, 5988);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 5234, 5351) || true) && (collection == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1359, 5234, 5351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 5290, 5336);

                    throw f_1359_5296_5335("collection");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1359, 5234, 5351);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 5367, 5387);

                bool
                result = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 5403, 5947);
                    foreach (object item in f_1359_5427_5437_I(collection))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1359, 5403, 5947);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 5471, 5932) || true) && (comparer != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1359, 5471, 5932);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 5533, 5690) || true) && (f_1359_5537_5566(comparer, item, value) == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1359, 5533, 5690);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 5621, 5635);

                                result = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1359, 5661, 5667);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1359, 5533, 5690);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1359, 5471, 5932);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1359, 5471, 5932);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 5772, 5913) || true) && (f_1359_5776_5794(item, value))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1359, 5772, 5913);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 5844, 5858);

                                result = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1359, 5884, 5890);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1359, 5772, 5913);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1359, 5471, 5932);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1359, 5403, 5947);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1359, 1, 545);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1359, 1, 545);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 5963, 5977);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1359, 5107, 5988);

                System.ArgumentNullException
                f_1359_5296_5335(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1359, 5296, 5335);
                    return return_v;
                }


                int
                f_1359_5537_5566(System.Collections.IComparer
                this_param, object
                x, object
                y)
                {
                    var return_v = this_param.Compare(x, y);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1359, 5537, 5566);
                    return return_v;
                }


                bool
                f_1359_5776_5794(object
                this_param, object
                obj)
                {
                    var return_v = this_param.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1359, 5776, 5794);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1359_5427_5437_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1359, 5427, 5437);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1359, 5107, 5988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1359, 5107, 5988);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Collection<WildcardPattern> CreateWildcardsFromStrings(
                    IEnumerable<string> globPatterns,
                    WildcardOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1359, 6568, 7398);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 6749, 6820);

                Collection<WildcardPattern>
                result = f_1359_6786_6819()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 6836, 7357) || true) && (globPatterns != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1359, 6836, 7357);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 6988, 7342);
                        foreach (string pattern in f_1359_7015_7027_I(globPatterns))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1359, 6988, 7342);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 7069, 7323) || true) && (!f_1359_7074_7103(pattern))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1359, 7069, 7323);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 7153, 7300);

                                f_1359_7153_7299(result, f_1359_7194_7298(pattern, options));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1359, 7069, 7323);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1359, 6988, 7342);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1359, 1, 355);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1359, 1, 355);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1359, 6836, 7357);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 7373, 7387);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1359, 6568, 7398);

                System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                f_1359_6786_6819()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1359, 6786, 6819);
                    return return_v;
                }


                bool
                f_1359_7074_7103(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1359, 7074, 7103);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1359_7194_7298(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1359, 7194, 7298);
                    return return_v;
                }


                int
                f_1359_7153_7299(System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                this_param, System.Management.Automation.WildcardPattern
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1359, 7153, 7299);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1359_7015_7027_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1359, 7015, 7027);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1359, 6568, 7398);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1359, 6568, 7398);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool MatchesAnyWildcardPattern(
                    string text,
                    IEnumerable<WildcardPattern> patterns,
                    bool defaultValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1359, 8171, 9099);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 8353, 8373);

                bool
                result = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 8387, 8417);

                bool
                patternsNonEmpty = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 8433, 8874) || true) && (patterns != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1359, 8433, 8874);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 8564, 8859);
                        foreach (WildcardPattern pattern in f_1359_8600_8608_I(patterns))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1359, 8564, 8859);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 8650, 8674);

                            patternsNonEmpty = true;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 8696, 8840) || true) && (f_1359_8700_8721(pattern, text))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1359, 8696, 8840);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 8771, 8785);

                                result = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1359, 8811, 8817);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1359, 8696, 8840);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1359, 8564, 8859);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1359, 1, 296);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1359, 1, 296);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1359, 8433, 8874);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 8890, 9058) || true) && (!patternsNonEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1359, 8890, 9058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 9021, 9043);

                    result = defaultValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1359, 8890, 9058);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 9074, 9088);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1359, 8171, 9099);

                bool
                f_1359_8700_8721(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1359, 8700, 8721);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>
                f_1359_8600_8608_I(System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1359, 8600, 8608);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1359, 8171, 9099);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1359, 8171, 9099);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static FileMode GetFileModeFromOpenMode(OpenMode openMode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1359, 9431, 10007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 9523, 9557);

                FileMode
                result = FileMode.Create
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 9573, 9966);

                switch (openMode)
                {

                    case OpenMode.Add:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1359, 9573, 9966);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 9663, 9688);

                        result = FileMode.Append;
                        DynAbs.Tracing.TraceSender.TraceBreak(1359, 9710, 9716);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1359, 9573, 9966);

                    case OpenMode.New:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1359, 9573, 9966);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 9776, 9804);

                        result = FileMode.CreateNew;
                        DynAbs.Tracing.TraceSender.TraceBreak(1359, 9826, 9832);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1359, 9573, 9966);

                    case OpenMode.Overwrite:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1359, 9573, 9966);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 9898, 9923);

                        result = FileMode.Create;
                        DynAbs.Tracing.TraceSender.TraceBreak(1359, 9945, 9951);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1359, 9573, 9966);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1359, 9982, 9996);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1359, 9431, 10007);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1359, 9431, 10007);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1359, 9431, 10007);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SessionStateUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1359, 3472, 10014);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1359, 3472, 10014);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1359, 3472, 10014);
        }

    }
}

namespace Microsoft.PowerShell.Commands
{
    /// <summary>
    /// The enum used by commands to allow the user to specify how
    /// a file (or other item) should be opened.
    /// </summary>
    public enum OpenMode
    {
        /// <summary>
        /// This opens the file for appending (similar to FileMode.Append)
        /// </summary>
        Add,

        /// <summary>
        /// The file must be created new. If the file exists it is an error (similar to FileMode.CreateNew)
        /// </summary>
        New,

        /// <summary>
        /// Creates a new file, if the file already exists it is overwritten (similar to FileMode.Create)
        /// </summary>
        Overwrite
    }
}

