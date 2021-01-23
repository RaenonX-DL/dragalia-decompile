/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using NUnit.Framework.Interfaces;

// Image 51: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal
{
	public class TestSuiteResult : TestResult
	{
		// Fields
		private int _passCount;
		private int _failCount;
		private int _skipCount;
		private int _inconclusiveCount;
		private List<ITestResult> _children;
	
		// Properties
		public override int FailCount { get; }
		public override int PassCount { get; }
		public override int SkipCount { get; }
		public override int InconclusiveCount { get; }
		public override bool HasChildren { get; }
		public override IEnumerable<ITestResult> Children { get; }
	
		// Constructors
		public TestSuiteResult(TestSuite suite);
	
		// Methods
		public virtual void AddResult(ITestResult result);
	}
}
