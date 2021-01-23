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
	public class TestMethod : Test
	{
		// Fields
		public TestCaseParameters parms;
	
		// Properties
		internal bool HasExpectedResult { get; }
		internal object ExpectedResult { get; }
		internal object[] Arguments { get; }
		public override bool HasChildren { get; }
		public override IList<ITest> Tests { get; }
		public override string XmlElementName { get; }
		public override string MethodName { get; }
	
		// Constructors
		public TestMethod(IMethodInfo method, Test parentSuite);
	
		// Methods
		public override TestResult MakeTestResult();
		public override TNode AddToXml(TNode parentNode, bool recursive);
	}
}
