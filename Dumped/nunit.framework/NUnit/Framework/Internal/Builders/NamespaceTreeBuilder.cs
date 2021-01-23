/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using NUnit.Framework.Internal;

// Image 51: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal.Builders
{
	public class NamespaceTreeBuilder
	{
		// Fields
		private Dictionary<string, TestSuite> namespaceSuites;
		private TestSuite rootSuite;
	
		// Properties
		public TestSuite RootSuite { get; }
	
		// Constructors
		public NamespaceTreeBuilder(TestSuite rootSuite);
	
		// Methods
		public void Add(IList<NUnit.Framework.Internal.Test> fixtures);
		public void Add(TestSuite fixture);
		private static string GetNamespaceForFixture(TestSuite fixture);
		private TestSuite BuildFromNameSpace(string ns);
		private void AddSetUpFixture(TestSuite newSetupFixture, TestSuite containingSuite, string ns);
	}
}
