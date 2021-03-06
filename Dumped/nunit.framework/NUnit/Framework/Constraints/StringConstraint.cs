﻿/*
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
	public abstract class StringConstraint : Constraint
	{
		// Fields
		protected string expected;
		protected bool caseInsensitive;
		protected string descriptionText;
	
		// Properties
		public override string Description { get; }
	
		// Constructors
		protected StringConstraint(string expected);
	
		// Methods
		public override ConstraintResult ApplyTo(object actual);
		protected abstract bool Matches(string actual);
	}
}
