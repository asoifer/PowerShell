// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Management.Automation
{
    public class PSListModifier
    {
        public PSListModifier()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1467, 1071, 1284);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 6010, 6021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 6282, 6296);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 6562, 6579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 1119, 1158);

                _itemsToAdd = f_1467_1133_1157();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 1172, 1214);

                _itemsToRemove = f_1467_1189_1213();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 1228, 1273);

                _replacementItems = f_1467_1248_1272();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1467, 1071, 1284);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1467, 1071, 1284);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1467, 1071, 1284);
            }
        }

        public PSListModifier(Collection<object> removeItems, Collection<object> addItems)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1467, 1555, 1854);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 6010, 6021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 6282, 6296);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 6562, 6579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 1662, 1713);

                _itemsToAdd = addItems ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.ObjectModel.Collection<object>>(1467, 1676, 1712) ?? f_1467_1688_1712());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 1727, 1784);

                _itemsToRemove = removeItems ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.ObjectModel.Collection<object>>(1467, 1744, 1783) ?? f_1467_1759_1783());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 1798, 1843);

                _replacementItems = f_1467_1818_1842();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1467, 1555, 1854);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1467, 1555, 1854);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1467, 1555, 1854);
            }
        }

        public PSListModifier(object replacementItems)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1467, 2095, 3221);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 6010, 6021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 6282, 6296);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 6562, 6579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 2166, 2205);

                _itemsToAdd = f_1467_2180_2204();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 2219, 2261);

                _itemsToRemove = f_1467_2236_2260();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 2275, 3210) || true) && (replacementItems == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 2275, 3210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 2337, 2382);

                    _replacementItems = f_1467_2357_2381();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 2275, 3210);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 2275, 3210);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 2416, 3210) || true) && (replacementItems is Collection<object>)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 2416, 3210);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 2492, 2549);

                        _replacementItems = (Collection<object>)replacementItems;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 2416, 3210);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 2416, 3210);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 2583, 3210) || true) && (replacementItems is IList<object>)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 2583, 3210);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 2654, 2730);

                            _replacementItems = f_1467_2674_2729((IList<object>)replacementItems);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 2583, 3210);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 2583, 3210);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 2764, 3210) || true) && (replacementItems is IList)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 2764, 3210);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 2827, 2872);

                                _replacementItems = f_1467_2847_2871();
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 2890, 3026);
                                    foreach (object item in f_1467_2914_2937_I((IList)replacementItems))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 2890, 3026);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 2979, 3007);

                                        f_1467_2979_3006(_replacementItems, item);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 2890, 3026);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1467, 1, 137);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1467, 1, 137);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 2764, 3210);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 2764, 3210);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 3092, 3137);

                                _replacementItems = f_1467_3112_3136();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 3155, 3195);

                                f_1467_3155_3194(_replacementItems, replacementItems);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 2764, 3210);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 2583, 3210);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 2416, 3210);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 2275, 3210);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1467, 2095, 3221);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1467, 2095, 3221);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1467, 2095, 3221);
            }
        }

        public PSListModifier(Hashtable hash)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1467, 3537, 5758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 6010, 6021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 6282, 6296);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 6562, 6579);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 3599, 3717) || true) && (hash == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 3599, 3717);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 3649, 3702);

                    throw f_1467_3655_3701("hash");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 3599, 3717);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 3733, 3772);

                _itemsToAdd = f_1467_3747_3771();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 3786, 3828);

                _itemsToRemove = f_1467_3803_3827();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 3842, 3887);

                _replacementItems = f_1467_3862_3886();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 3903, 5747);
                    foreach (DictionaryEntry entry in f_1467_3937_3941_I(hash))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 3903, 5747);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 3975, 5732) || true) && (entry.Key is string)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 3975, 5732);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 4040, 4073);

                            string
                            key = entry.Key as string
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 4095, 4163);

                            bool
                            isAdd = f_1467_4108_4162(key, AddKey, StringComparison.OrdinalIgnoreCase)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 4185, 4259);

                            bool
                            isRemove = f_1467_4201_4258(key, RemoveKey, StringComparison.OrdinalIgnoreCase)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 4281, 4357);

                            bool
                            isReplace = f_1467_4298_4356(key, ReplaceKey, StringComparison.OrdinalIgnoreCase)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 4381, 4594) || true) && (!isAdd && (DynAbs.Tracing.TraceSender.Expression_True(1467, 4385, 4404) && !isRemove) && (DynAbs.Tracing.TraceSender.Expression_True(1467, 4385, 4418) && !isReplace))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 4381, 4594);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 4468, 4571);

                                throw f_1467_4474_4570("hash", f_1467_4517_4564(), key);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 4381, 4594);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 4618, 4648);

                            Collection<object>
                            collection
                            = default(Collection<object>);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 4670, 5046) || true) && (isRemove)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 4670, 5046);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 4732, 4760);

                                collection = _itemsToRemove;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 4670, 5046);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 4670, 5046);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 4810, 5046) || true) && (isAdd)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 4810, 5046);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 4869, 4894);

                                    collection = _itemsToAdd;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 4810, 5046);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 4810, 5046);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 4992, 5023);

                                    collection = _replacementItems;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 4810, 5046);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 4670, 5046);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 5070, 5141);

                            IEnumerable
                            enumerable = f_1467_5095_5140(entry.Value)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 5163, 5522) || true) && (enumerable != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 5163, 5522);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 5235, 5373);
                                    foreach (object obj in f_1467_5258_5268_I(enumerable))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 5235, 5373);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 5326, 5346);

                                        f_1467_5326_5345(collection, obj);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 5235, 5373);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1467, 1, 139);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1467, 1, 139);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 5163, 5522);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 5163, 5522);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 5471, 5499);

                                f_1467_5471_5498(collection, entry.Value);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 5163, 5522);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 3975, 5732);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 3975, 5732);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 5604, 5713);

                            throw f_1467_5610_5712("hash", f_1467_5653_5700(), entry.Key);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 3975, 5732);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 3903, 5747);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1467, 1, 1845);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1467, 1, 1845);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1467, 3537, 5758);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1467, 3537, 5758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1467, 3537, 5758);
            }
        }

        public Collection<object> Add
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1467, 5933, 5960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 5939, 5958);

                    return _itemsToAdd;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1467, 5933, 5960);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1467, 5879, 5971);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1467, 5879, 5971);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Collection<object> _itemsToAdd;

        public Collection<object> Remove
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1467, 6202, 6232);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 6208, 6230);

                    return _itemsToRemove;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1467, 6202, 6232);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1467, 6145, 6243);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1467, 6145, 6243);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Collection<object> _itemsToRemove;

        public Collection<object> Replace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1467, 6479, 6512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 6485, 6510);

                    return _replacementItems;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1467, 6479, 6512);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1467, 6421, 6523);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1467, 6421, 6523);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private Collection<object> _replacementItems;

        public void ApplyTo(IList collectionToUpdate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1467, 6794, 7674);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 6864, 7010) || true) && (collectionToUpdate == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 6864, 7010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 6928, 6995);

                    throw f_1467_6934_6994("collectionToUpdate");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 6864, 7010);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 7026, 7663) || true) && (f_1467_7030_7053(_replacementItems) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 7026, 7663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 7091, 7118);

                    f_1467_7091_7117(collectionToUpdate);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 7136, 7280);
                        foreach (object obj in f_1467_7159_7176_I(_replacementItems))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 7136, 7280);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 7218, 7261);

                            f_1467_7218_7260(collectionToUpdate, f_1467_7241_7259(obj));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 7136, 7280);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1467, 1, 145);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1467, 1, 145);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 7026, 7663);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 7026, 7663);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 7346, 7490);
                        foreach (object obj in f_1467_7369_7383_I(_itemsToRemove))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 7346, 7490);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 7425, 7471);

                            f_1467_7425_7470(collectionToUpdate, f_1467_7451_7469(obj));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 7346, 7490);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1467, 1, 145);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1467, 1, 145);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 7510, 7648);
                        foreach (object obj in f_1467_7533_7544_I(_itemsToAdd))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 7510, 7648);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 7586, 7629);

                            f_1467_7586_7628(collectionToUpdate, f_1467_7609_7627(obj));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 7510, 7648);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1467, 1, 139);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1467, 1, 139);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 7026, 7663);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1467, 6794, 7674);

                System.Management.Automation.PSArgumentNullException
                f_1467_6934_6994(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 6934, 6994);
                    return return_v;
                }


                int
                f_1467_7030_7053(System.Collections.ObjectModel.Collection<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1467, 7030, 7053);
                    return return_v;
                }


                int
                f_1467_7091_7117(System.Collections.IList
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 7091, 7117);
                    return 0;
                }


                object
                f_1467_7241_7259(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 7241, 7259);
                    return return_v;
                }


                int
                f_1467_7218_7260(System.Collections.IList
                this_param, object
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 7218, 7260);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<object>
                f_1467_7159_7176_I(System.Collections.ObjectModel.Collection<object>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 7159, 7176);
                    return return_v;
                }


                object
                f_1467_7451_7469(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 7451, 7469);
                    return return_v;
                }


                int
                f_1467_7425_7470(System.Collections.IList
                this_param, object
                value)
                {
                    this_param.Remove(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 7425, 7470);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<object>
                f_1467_7369_7383_I(System.Collections.ObjectModel.Collection<object>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 7369, 7383);
                    return return_v;
                }


                object
                f_1467_7609_7627(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 7609, 7627);
                    return return_v;
                }


                int
                f_1467_7586_7628(System.Collections.IList
                this_param, object
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 7586, 7628);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<object>
                f_1467_7533_7544_I(System.Collections.ObjectModel.Collection<object>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 7533, 7544);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1467, 6794, 7674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1467, 6794, 7674);
            }
        }

        public void ApplyTo(object collectionToUpdate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1467, 7888, 8425);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 7959, 8092) || true) && (collectionToUpdate == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 7959, 8092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 8023, 8077);

                    throw f_1467_8029_8076("collectionToUpdate");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 7959, 8092);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 8108, 8163);

                collectionToUpdate = f_1467_8129_8162(collectionToUpdate);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 8179, 8220);

                IList
                list = collectionToUpdate as IList
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 8234, 8384) || true) && (list == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 8234, 8384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 8284, 8369);

                    throw f_1467_8290_8368(f_1467_8333_8367());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 8234, 8384);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 8400, 8414);

                f_1467_8400_8413(this, list);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1467, 7888, 8425);

                System.ArgumentNullException
                f_1467_8029_8076(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 8029, 8076);
                    return return_v;
                }


                object
                f_1467_8129_8162(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 8129, 8162);
                    return return_v;
                }


                string
                f_1467_8333_8367()
                {
                    var return_v = PSListModifierStrings.UpdateFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1467, 8333, 8367);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1467_8290_8368(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 8290, 8368);
                    return return_v;
                }


                int
                f_1467_8400_8413(System.Management.Automation.PSListModifier
                this_param, System.Collections.IList
                collectionToUpdate)
                {
                    this_param.ApplyTo(collectionToUpdate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 8400, 8413);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1467, 7888, 8425);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1467, 7888, 8425);
            }
        }

        internal Hashtable ToHashtable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1467, 8437, 8962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 8494, 8530);

                Hashtable
                result = f_1467_8513_8529(2)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 8546, 8652) || true) && (f_1467_8550_8567(_itemsToAdd) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 8546, 8652);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 8605, 8637);

                    f_1467_8605_8636(result, AddKey, _itemsToAdd);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 8546, 8652);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 8668, 8783) || true) && (f_1467_8672_8692(_itemsToRemove) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 8668, 8783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 8730, 8768);

                    f_1467_8730_8767(result, RemoveKey, _itemsToRemove);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 8668, 8783);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 8799, 8921) || true) && (f_1467_8803_8826(_replacementItems) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1467, 8799, 8921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 8864, 8906);

                    f_1467_8864_8905(result, ReplaceKey, _replacementItems);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1467, 8799, 8921);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 8937, 8951);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1467, 8437, 8962);

                System.Collections.Hashtable
                f_1467_8513_8529(int
                capacity)
                {
                    var return_v = new System.Collections.Hashtable(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 8513, 8529);
                    return return_v;
                }


                int
                f_1467_8550_8567(System.Collections.ObjectModel.Collection<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1467, 8550, 8567);
                    return return_v;
                }


                int
                f_1467_8605_8636(System.Collections.Hashtable
                this_param, string
                key, System.Collections.ObjectModel.Collection<object>
                value)
                {
                    this_param.Add((object)key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 8605, 8636);
                    return 0;
                }


                int
                f_1467_8672_8692(System.Collections.ObjectModel.Collection<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1467, 8672, 8692);
                    return return_v;
                }


                int
                f_1467_8730_8767(System.Collections.Hashtable
                this_param, string
                key, System.Collections.ObjectModel.Collection<object>
                value)
                {
                    this_param.Add((object)key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 8730, 8767);
                    return 0;
                }


                int
                f_1467_8803_8826(System.Collections.ObjectModel.Collection<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1467, 8803, 8826);
                    return return_v;
                }


                int
                f_1467_8864_8905(System.Collections.Hashtable
                this_param, string
                key, System.Collections.ObjectModel.Collection<object>
                value)
                {
                    this_param.Add((object)key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 8864, 8905);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1467, 8437, 8962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1467, 8437, 8962);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal const string
        AddKey = "Add"
        ;

        internal const string
        RemoveKey = "Remove"
        ;

        internal const string
        ReplaceKey = "Replace"
        ;

        static PSListModifier()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1467, 906, 9126);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 8996, 9010);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 9043, 9063);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1467, 9096, 9118);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1467, 906, 9126);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1467, 906, 9126);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1467, 906, 9126);

        System.Collections.ObjectModel.Collection<object>
        f_1467_1133_1157()
        {
            var return_v = new System.Collections.ObjectModel.Collection<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 1133, 1157);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<object>
        f_1467_1189_1213()
        {
            var return_v = new System.Collections.ObjectModel.Collection<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 1189, 1213);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<object>
        f_1467_1248_1272()
        {
            var return_v = new System.Collections.ObjectModel.Collection<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 1248, 1272);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<object>
        f_1467_1688_1712()
        {
            var return_v = new System.Collections.ObjectModel.Collection<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 1688, 1712);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<object>
        f_1467_1759_1783()
        {
            var return_v = new System.Collections.ObjectModel.Collection<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 1759, 1783);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<object>
        f_1467_1818_1842()
        {
            var return_v = new System.Collections.ObjectModel.Collection<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 1818, 1842);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<object>
        f_1467_2180_2204()
        {
            var return_v = new System.Collections.ObjectModel.Collection<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 2180, 2204);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<object>
        f_1467_2236_2260()
        {
            var return_v = new System.Collections.ObjectModel.Collection<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 2236, 2260);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<object>
        f_1467_2357_2381()
        {
            var return_v = new System.Collections.ObjectModel.Collection<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 2357, 2381);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<object>
        f_1467_2674_2729(object
        list)
        {
            var return_v = new System.Collections.ObjectModel.Collection<object>((System.Collections.Generic.IList<object>)list);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 2674, 2729);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<object>
        f_1467_2847_2871()
        {
            var return_v = new System.Collections.ObjectModel.Collection<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 2847, 2871);
            return return_v;
        }


        int
        f_1467_2979_3006(System.Collections.ObjectModel.Collection<object>
        this_param, object
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 2979, 3006);
            return 0;
        }


        System.Collections.IList
        f_1467_2914_2937_I(System.Collections.IList
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 2914, 2937);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<object>
        f_1467_3112_3136()
        {
            var return_v = new System.Collections.ObjectModel.Collection<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 3112, 3136);
            return return_v;
        }


        int
        f_1467_3155_3194(System.Collections.ObjectModel.Collection<object>
        this_param, object
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 3155, 3194);
            return 0;
        }


        System.Management.Automation.PSArgumentNullException
        f_1467_3655_3701(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 3655, 3701);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<object>
        f_1467_3747_3771()
        {
            var return_v = new System.Collections.ObjectModel.Collection<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 3747, 3771);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<object>
        f_1467_3803_3827()
        {
            var return_v = new System.Collections.ObjectModel.Collection<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 3803, 3827);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<object>
        f_1467_3862_3886()
        {
            var return_v = new System.Collections.ObjectModel.Collection<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 3862, 3886);
            return return_v;
        }


        bool
        f_1467_4108_4162(string
        this_param, string
        value, System.StringComparison
        comparisonType)
        {
            var return_v = this_param.Equals(value, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 4108, 4162);
            return return_v;
        }


        bool
        f_1467_4201_4258(string
        this_param, string
        value, System.StringComparison
        comparisonType)
        {
            var return_v = this_param.Equals(value, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 4201, 4258);
            return return_v;
        }


        bool
        f_1467_4298_4356(string
        this_param, string
        value, System.StringComparison
        comparisonType)
        {
            var return_v = this_param.Equals(value, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 4298, 4356);
            return return_v;
        }


        string
        f_1467_4517_4564()
        {
            var return_v = PSListModifierStrings.ListModifierDisallowedKey;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1467, 4517, 4564);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1467_4474_4570(string
        paramName, string
        resourceString, params object[]
        args)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 4474, 4570);
            return return_v;
        }


        System.Collections.IEnumerable
        f_1467_5095_5140(object
        obj)
        {
            var return_v = LanguagePrimitives.GetEnumerable(obj);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 5095, 5140);
            return return_v;
        }


        int
        f_1467_5326_5345(System.Collections.ObjectModel.Collection<object>
        this_param, object
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 5326, 5345);
            return 0;
        }


        System.Collections.IEnumerable
        f_1467_5258_5268_I(System.Collections.IEnumerable
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 5258, 5268);
            return return_v;
        }


        int
        f_1467_5471_5498(System.Collections.ObjectModel.Collection<object>
        this_param, object
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 5471, 5498);
            return 0;
        }


        string
        f_1467_5653_5700()
        {
            var return_v = PSListModifierStrings.ListModifierDisallowedKey;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1467, 5653, 5700);
            return return_v;
        }


        System.Management.Automation.PSArgumentException
        f_1467_5610_5712(string
        paramName, string
        resourceString, params object[]
        args)
        {
            var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 5610, 5712);
            return return_v;
        }


        System.Collections.Hashtable
        f_1467_3937_3941_I(System.Collections.Hashtable
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1467, 3937, 3941);
            return return_v;
        }

    }
    public class PSListModifier<T> : PSListModifier
    {
        public PSListModifier()
                    : base()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1467, 9721, 9788);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1467, 9721, 9788);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1467, 9721, 9788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1467, 9721, 9788);
            }
        }

        public PSListModifier(Collection<object> removeItems, Collection<object> addItems)
        : base(f_1467_10162_10173_C(removeItems), addItems)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1467, 10059, 10206);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1467, 10059, 10206);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1467, 10059, 10206);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1467, 10059, 10206);
            }
        }

        public PSListModifier(object replacementItems)
        : base(f_1467_10512_10528_C(replacementItems))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1467, 10445, 10551);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1467, 10445, 10551);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1467, 10445, 10551);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1467, 10445, 10551);
            }
        }

        public PSListModifier(Hashtable hash)
        : base(f_1467_10925_10929_C(hash))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1467, 10867, 10952);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1467, 10867, 10952);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1467, 10867, 10952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1467, 10867, 10952);
            }
        }

        static System.Collections.ObjectModel.Collection<object>
        f_1467_10162_10173_C(System.Collections.ObjectModel.Collection<object>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1467, 10059, 10206);
            return return_v;
        }


        static object
        f_1467_10512_10528_C(object
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1467, 10445, 10551);
            return return_v;
        }


        static System.Collections.Hashtable
        f_1467_10925_10929_C(System.Collections.Hashtable
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1467, 10867, 10952);
            return return_v;
        }

    }
}
