/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Constraints
{
	public class SamePathConstraint : PathConstraint
	{
		// Properties
		public override string Description { get; }
	
		// Constructors
		public SamePathConstraint(string expected);
	
		// Methods
		protected override bool Matches(string actual);
	}
}
