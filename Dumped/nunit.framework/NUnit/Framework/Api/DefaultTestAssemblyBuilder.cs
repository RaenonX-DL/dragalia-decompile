/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Api
{
	public class DefaultTestAssemblyBuilder : ITestAssemblyBuilder
	{
		// Fields
		private static Logger log;
		private ISuiteBuilder _defaultSuiteBuilder;
	
		// Constructors
		public DefaultTestAssemblyBuilder();
		static DefaultTestAssemblyBuilder();
	
		// Methods
		public ITest Build(Assembly assembly, IDictionary<string, object> options);
		private TestSuite Build(Assembly assembly, string assemblyPath, IDictionary<string, object> options);
		private IList<NUnit.Framework.Internal.Test> GetFixtures(Assembly assembly, IList names);
		private IList<Type> GetCandidateFixtureTypes(Assembly assembly, IList names);
		private TestSuite BuildTestAssembly(Assembly assembly, string assemblyName, IList<NUnit.Framework.Internal.Test> fixtures);
	}
}
