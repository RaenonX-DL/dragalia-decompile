﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using NUnit.Framework.Interfaces;

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal
{
	public class TestListener : ITestListener
	{
		// Properties
		public static ITestListener NULL { get; }
	
		// Constructors
		private TestListener();
	
		// Methods
		public void TestStarted(ITest test);
		public void TestFinished(ITestResult result);
		public void TestOutput(TestOutput output);
	}
}
