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

namespace NUnit.Framework
{
	[DefaultMember]
	public class TestParameters
	{
		// Fields
		private static readonly IFormatProvider MODIFIED_INVARIANT_CULTURE;
		private readonly Dictionary<string, string> _parameters;
	
		// Constructors
		public TestParameters();
		static TestParameters();
	
		// Methods
		internal void Add(string name, string value);
		private static IFormatProvider CreateModifiedInvariantCulture();
	}
}
