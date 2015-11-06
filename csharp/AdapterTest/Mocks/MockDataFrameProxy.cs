﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Spark.CSharp.Proxy;

namespace AdapterTest.Mocks
{
    internal class MockDataFrameProxy : IDataFrameProxy
    {
        internal object[] mockDataFrameReference;
        private ISqlContextProxy mockSqlContextProxy;

        public ISqlContextProxy SqlContextProxy
        {
            get { return mockSqlContextProxy; }
        }

        //just saving the parameter collection to mock the proxy reference that will be used in Assert statements
        internal MockDataFrameProxy(object[] parameterCollection, ISqlContextProxy scProxy)
        {
            mockDataFrameReference = parameterCollection;
            mockSqlContextProxy = scProxy;
        }

        public void RegisterTempTable(string tableName)
        {
            throw new NotImplementedException();
        }

        public long Count()
        {
            throw new NotImplementedException();
        }

        public string GetQueryExecution()
        {
            throw new NotImplementedException();
        }

        public string GetExecutedPlan()
        {
            throw new NotImplementedException();
        }

        public string GetShowString(int numberOfRows, bool truncate)
        {
            throw new NotImplementedException();
        }

        public IStructTypeProxy GetSchema()
        {
            throw new NotImplementedException();
        }

        public IRDDProxy ToJSON()
        {
            throw new NotImplementedException();
        }

        public IRDDProxy ToRDD()
        {
            throw new NotImplementedException();
        }

        public IColumnProxy GetColumn(string columnName)
        {
            throw new NotImplementedException();
        }

        public IDataFrameProxy Select(string columnName, string[] columnNames)
        {
            throw new NotImplementedException();
        }

        public IDataFrameProxy SelectExpr(string[] columnExpressions)
        {
            throw new NotImplementedException();
        }

        public IDataFrameProxy Filter(string condition)
        {
            throw new NotImplementedException();
        }

        public IGroupedDataProxy GroupBy(string firstColumnName, string[] otherColumnNames)
        {
            throw new NotImplementedException();
        }

        public IGroupedDataProxy GroupBy()
        {
            throw new NotImplementedException();
        }

        public IDataFrameProxy Agg(IGroupedDataProxy scalaGroupedDataReference, System.Collections.Generic.Dictionary<string, string> columnNameAggFunctionDictionary)
        {
            throw new NotImplementedException();
        }

        public IDataFrameProxy Join(IDataFrameProxy otherScalaDataFrameReference, string joinColumnName)
        {
            return new MockDataFrameProxy(new object[] { otherScalaDataFrameReference, joinColumnName }, SqlContextProxy);
        }

        public IDataFrameProxy Join(IDataFrameProxy otherScalaDataFrameReference, string[] joinColumnNames)
        {
            throw new NotImplementedException();
        }

        public IDataFrameProxy Join(IDataFrameProxy otherScalaDataFrameReference, IColumnProxy scalaColumnReference, string joinType)
        {
            throw new NotImplementedException();
        }

        public bool IsLocal
        {
            get { throw new NotImplementedException(); }
        }

        public void Cache()
        {
            throw new NotImplementedException();
        }

        public void Persist(Microsoft.Spark.CSharp.Core.StorageLevelType storageLevelType)
        {
            throw new NotImplementedException();
        }

        public void Unpersist(bool blocking)
        {
            throw new NotImplementedException();
        }

        public IRDDProxy JavaToCSharp()
        {
            throw new NotImplementedException();
        }

        public IDataFrameProxy Limit(int num)
        {
            throw new NotImplementedException();
        }

        public IDataFrameProxy Coalesce(int numPartitions)
        {
            throw new NotImplementedException();
        }

        public IDataFrameProxy Repartition(int numPartitions)
        {
            throw new NotImplementedException();
        }

        public IDataFrameProxy Distinct()
        {
            throw new NotImplementedException();
        }

        public IDataFrameProxy Sample(bool withReplacement, double fraction, long? seed)
        {
            throw new NotImplementedException();
        }

        public IDataFrameProxy[] RandomSplit(double[] weights, long? seed)
        {
            throw new NotImplementedException();
        }

        public IDataFrameProxy Alias(string alias)
        {
            throw new NotImplementedException();
        }

        public IDataFrameProxy Describe(string[] columns)
        {
            throw new NotImplementedException();
        }

        public IGroupedDataProxy Rollup(IColumnProxy[] columns)
        {
            throw new NotImplementedException();
        }

        public IGroupedDataProxy Cube(IColumnProxy[] columns)
        {
            throw new NotImplementedException();
        }

        public IDataFrameProxy UnionAll(IDataFrameProxy other)
        {
            throw new NotImplementedException();
        }

        public IDataFrameProxy Intersect(IDataFrameProxy other)
        {
            throw new NotImplementedException();
        }

        public IDataFrameProxy Subtract(IDataFrameProxy other)
        {
            throw new NotImplementedException();
        }

        public IDataFrameProxy DropDuplicates(string[] subset)
        {
            throw new NotImplementedException();
        }

        public void Drop(IColumnProxy column)
        {
            throw new NotImplementedException();
        }

        public IDataFrameProxy Drop(string columnName)
        {
            throw new NotImplementedException();
        }

        public IDataFrameProxy DropNa(string how, int? thresh, string[] subset)
        {
            throw new NotImplementedException();
        }
    }
}