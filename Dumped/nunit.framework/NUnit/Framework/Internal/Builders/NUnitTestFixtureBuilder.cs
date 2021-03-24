/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal.Builders
{
	public class NUnitTestFixtureBuilder
	{
		// Fields
		private static readonly string NO_TYPE_ARGS_MSG;
		private ITestCaseBuilder _testBuilder;
	
		// Constructors
		public NUnitTestFixtureBuilder();
		static NUnitTestFixtureBuilder();
	
		// Methods
		public TestSuite BuildFrom(ITypeInfo typeInfo);
		public TestSuite BuildFrom(ITypeInfo typeInfo, ITestFixtureData testFixtureData);
		private void AddTestCasesToFixture(TestFixture fixture);
		private NUnit.Framework.Internal.Test BuildTestCase(IMethodInfo method, TestSuite suite);
		private static void CheckTestFixtureIsValid(TestFixture fixture);
	}
}
