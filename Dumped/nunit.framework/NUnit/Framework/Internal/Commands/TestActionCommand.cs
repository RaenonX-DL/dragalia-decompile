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
	public class TestActionCommand : DelegatingTestCommand
	{
		// Fields
		private IList<TestActionItem> _actions;
	
		// Constructors
		public TestActionCommand(TestCommand innerCommand);
	
		// Methods
		public override TestResult Execute(ITestExecutionContext context);
	}
}
