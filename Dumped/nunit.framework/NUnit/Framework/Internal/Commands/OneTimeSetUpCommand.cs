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

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal.Commands
{
	public class OneTimeSetUpCommand : TestCommand
	{
		// Fields
		private readonly TestSuite _suite;
		private readonly ITypeInfo _typeInfo;
		private readonly object[] _arguments;
		private readonly List<SetUpTearDownItem> _setUpTearDown;
		private readonly List<TestActionItem> _actions;
	
		// Constructors
		public OneTimeSetUpCommand(TestSuite suite, List<SetUpTearDownItem> setUpTearDown, List<TestActionItem> actions);
	
		// Methods
		public override TestResult Execute(ITestExecutionContext context);
	}
}
