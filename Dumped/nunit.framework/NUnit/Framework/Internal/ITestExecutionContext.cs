/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using NUnit.Framework;
using NUnit.Framework.Constraints;

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal
{
	public interface ITestExecutionContext
	{
		// Properties
		TestResult CurrentResult { get; set; }
		TextWriter OutWriter { get; }
		object TestObject { get; set; }
		TestExecutionStatus ExecutionStatus { get; }
		List<ITestAction> UpstreamActions { get; }
		ValueFormatter CurrentValueFormatter { get; }
	
		// Methods
		void IncrementAssertCount();
	}
}
