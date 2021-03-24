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

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal.Commands
{
	public class SetUpTearDownItem
	{
		// Fields
		private IList<MethodInfo> _setUpMethods;
		private IList<MethodInfo> _tearDownMethods;
		private bool _setUpWasRun;
	
		// Properties
		public bool HasMethods { get; }
	
		// Constructors
		public SetUpTearDownItem(IList<MethodInfo> setUpMethods, IList<MethodInfo> tearDownMethods);
	
		// Methods
		public void RunSetUp(ITestExecutionContext context);
		public void RunTearDown(ITestExecutionContext context);
		private void RunSetUpOrTearDownMethod(ITestExecutionContext context, MethodInfo method);
		private object RunNonAsyncMethod(MethodInfo method, ITestExecutionContext context);
	}
}
