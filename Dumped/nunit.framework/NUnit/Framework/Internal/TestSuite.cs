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
	public class TestSuite : Test
	{
		// Fields
		private List<ITest> tests;
		[CompilerGenerated]
		private object[] _Arguments_k__BackingField;
		[CompilerGenerated]
		private bool _MaintainTestOrder_k__BackingField;
	
		// Properties
		public override IList<ITest> Tests { get; }
		public override int TestCaseCount { get; }
		public object[] Arguments { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		protected bool MaintainTestOrder { [CompilerGenerated] get; [CompilerGenerated] set; }
		public override bool HasChildren { get; }
		public override string XmlElementName { get; }
	
		// Constructors
		public TestSuite(string name);
		public TestSuite(string parentSuiteName, string name);
		public TestSuite(ITypeInfo fixtureType);
	
		// Methods
		public void Sort();
		public void Add(Test test);
		public override TestResult MakeTestResult();
		public override TNode AddToXml(TNode parentNode, bool recursive);
		protected void CheckSetUpTearDownMethods(Type attrType);
	}
}
