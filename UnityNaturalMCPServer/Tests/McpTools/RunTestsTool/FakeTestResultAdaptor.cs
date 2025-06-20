using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using NUnit.Framework.Interfaces;
using UnityEditor.TestTools.TestRunner.Api;
using TestStatus = UnityEditor.TestTools.TestRunner.Api.TestStatus;

namespace UnityNaturalMCP.Tests.McpTools.RunTestsTool
{
    [SuppressMessage("ReSharper", "UnassignedGetOnlyAutoProperty")]
    public class FakeTestResultAdaptor : ITestResultAdaptor
    {
        public TNode ToXml()
        {
            throw new NotImplementedException();
        }

        public ITestAdaptor Test { get; }
        public string Name { get; }
        public string FullName { get; set; }
        public string ResultState { get; }
        public TestStatus TestStatus { get; set; }
        public double Duration { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public int AssertCount { get; }
        public int FailCount { get; }
        public int PassCount { get; }
        public int SkipCount { get; }
        public int InconclusiveCount { get; }
        public bool HasChildren { get; set; }
        public IEnumerable<ITestResultAdaptor> Children { get; }
        public string Output { get; }
    }
}