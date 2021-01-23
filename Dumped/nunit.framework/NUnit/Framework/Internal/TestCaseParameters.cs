/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using NUnit.Framework.Interfaces;

// Image 51: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal
{
	public class TestCaseParameters : TestParameters, ITestCaseData, IApplyToTest
	{
		// Fields
		private object _expectedResult;
		[CompilerGenerated]
		private bool _HasExpectedResult_k__BackingField;
	
		// Properties
		public object ExpectedResult { get; }
		public bool HasExpectedResult { [CompilerGenerated] get; }
	
		// Constructors
		public TestCaseParameters();
		public TestCaseParameters(object[] args);
	}
}
