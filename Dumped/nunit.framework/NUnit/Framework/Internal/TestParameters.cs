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
	public abstract class TestParameters : ITestData, IApplyToTest
	{
		// Fields
		[CompilerGenerated]
		private RunState _RunState_k__BackingField;
		[CompilerGenerated]
		private object[] _Arguments_k__BackingField;
		[CompilerGenerated]
		private string _TestName_k__BackingField;
		[CompilerGenerated]
		private IPropertyBag _Properties_k__BackingField;
		[CompilerGenerated]
		private object[] _OriginalArguments_k__BackingField;
	
		// Properties
		public RunState RunState { [CompilerGenerated] get; [CompilerGenerated] set; }
		public object[] Arguments { [CompilerGenerated] get; [CompilerGenerated] internal set; }
		public string TestName { [CompilerGenerated] get; }
		public IPropertyBag Properties { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public object[] OriginalArguments { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public TestParameters();
		public TestParameters(object[] args);
	
		// Methods
		private void InitializeAguments(object[] args);
		public void ApplyToTest(Test test);
	}
}
