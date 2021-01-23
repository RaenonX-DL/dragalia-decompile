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
	public class DefaultSuiteBuilder : ISuiteBuilder
	{
		// Fields
		private NUnitTestFixtureBuilder _defaultBuilder;
	
		// Constructors
		public DefaultSuiteBuilder();
	
		// Methods
		public bool CanBuildFrom(ITypeInfo typeInfo);
		public TestSuite BuildFrom(ITypeInfo typeInfo);
		private TestSuite BuildMultipleFixtures(ITypeInfo typeInfo, IEnumerable<TestSuite> fixtures);
		private IFixtureBuilder[] GetFixtureBuilderAttributes(ITypeInfo typeInfo);
		private bool HasArguments(IFixtureBuilder attr);
	}
}
