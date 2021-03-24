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
using NUnit.Framework.Internal.Builders;

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework
{
	[AttributeUsage]
	public abstract class CombiningStrategyAttribute : NUnitAttribute, ITestBuilder, IApplyToTest
	{
		// Fields
		private NUnitTestCaseBuilder _builder;
		private ICombiningStrategy _strategy;
		private IParameterDataProvider _dataProvider;
	
		// Constructors
		protected CombiningStrategyAttribute(ICombiningStrategy strategy, IParameterDataProvider provider);
	
		// Methods
		public IEnumerable<TestMethod> BuildFrom(IMethodInfo method, NUnit.Framework.Internal.Test suite);
		public void ApplyToTest(NUnit.Framework.Internal.Test test);
	}
}
