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

namespace NUnit.Framework.Internal.Commands
{
	public class OneTimeTearDownCommand : TestCommand
	{
		// Fields
		private List<SetUpTearDownItem> _setUpTearDownItems;
		private List<TestActionItem> _actions;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass2
		{
			// Fields
			public IDisposable disposable;
	
			// Constructors
			public __c__DisplayClass2();
	
			// Methods
			public object _Execute_b__0();
		}
	
		// Constructors
		public OneTimeTearDownCommand(TestSuite suite, List<SetUpTearDownItem> setUpTearDownItems, List<TestActionItem> actions);
	
		// Methods
		public override TestResult Execute(ITestExecutionContext context);
	}
}
