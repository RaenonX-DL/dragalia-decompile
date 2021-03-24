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

namespace NUnit.Framework.Constraints
{
	public class EqualConstraint : Constraint
	{
		// Fields
		private readonly object _expected;
		private Tolerance _tolerance;
		private NUnitEqualityComparer _comparer;
		[CompilerGenerated]
		private bool _ClipStrings_k__BackingField;
	
		// Properties
		public Tolerance Tolerance { get; }
		public bool CaseInsensitive { get; }
		public bool ClipStrings { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public IList<NUnitEqualityComparer.FailurePoint> FailurePoints { get; }
		public override string Description { get; }
	
		// Constructors
		public EqualConstraint(object expected);
	
		// Methods
		public override ConstraintResult ApplyTo(object actual);
		private void AdjustArgumentIfNeeded<T>(ref T arg);
	}
}
