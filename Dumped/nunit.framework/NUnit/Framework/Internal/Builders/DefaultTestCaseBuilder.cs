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
using NUnit.Framework.Internal;

// Image 51: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal.Builders
{
	public class DefaultTestCaseBuilder : ITestCaseBuilder
	{
		// Fields
		private NUnitTestCaseBuilder _nunitTestCaseBuilder;
	
		// Constructors
		public DefaultTestCaseBuilder();
	
		// Methods
		public bool CanBuildFrom(IMethodInfo method);
		public bool CanBuildFrom(IMethodInfo method, NUnit.Framework.Internal.Test parentSuite);
		public NUnit.Framework.Internal.Test BuildFrom(IMethodInfo method, NUnit.Framework.Internal.Test parentSuite);
		private NUnit.Framework.Internal.Test BuildParameterizedMethodSuite(IMethodInfo method, IEnumerable<TestMethod> tests);
		private NUnit.Framework.Internal.Test BuildSingleTestMethod(IMethodInfo method, NUnit.Framework.Internal.Test suite);
	}
}
