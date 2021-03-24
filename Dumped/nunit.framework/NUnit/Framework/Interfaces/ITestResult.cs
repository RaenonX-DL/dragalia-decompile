/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Interfaces
{
	public interface ITestResult : IXmlNodeBuilder
	{
		// Properties
		ResultState ResultState { get; }
		string Name { get; }
		string FullName { get; }
		double Duration { get; }
		DateTime StartTime { get; }
		DateTime EndTime { get; }
		string Message { get; }
		string StackTrace { get; }
		int AssertCount { get; }
		int FailCount { get; }
		int PassCount { get; }
		int SkipCount { get; }
		int InconclusiveCount { get; }
		bool HasChildren { get; }
		IEnumerable<ITestResult> Children { get; }
		ITest Test { get; }
		string Output { get; }
	}
}
