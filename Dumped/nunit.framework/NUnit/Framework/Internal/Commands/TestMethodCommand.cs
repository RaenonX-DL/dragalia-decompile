/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using NUnit.Framework.Internal;

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal.Commands
{
	public class TestMethodCommand : TestCommand
	{
		// Fields
		private readonly TestMethod testMethod;
		private readonly object[] arguments;
	
		// Constructors
		public TestMethodCommand(TestMethod testMethod);
	
		// Methods
		public override TestResult Execute(ITestExecutionContext context);
		private object RunTestMethod(ITestExecutionContext context);
		private object RunNonAsyncTestMethod(ITestExecutionContext context);
	}
}
