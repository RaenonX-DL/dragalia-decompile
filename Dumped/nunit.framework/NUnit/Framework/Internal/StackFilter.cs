/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text.RegularExpressions;

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal
{
	public static class StackFilter
	{
		// Fields
		private static readonly Regex assertOrAssumeRegex;
	
		// Constructors
		static StackFilter();
	
		// Methods
		public static string Filter(string rawTrace);
	}
}
