/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;

// Image 51: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Constraints
{
	public class ConstraintResult
	{
		// Fields
		private IConstraint _constraint;
		[CompilerGenerated]
		private object _ActualValue_k__BackingField;
		[CompilerGenerated]
		private ConstraintStatus _Status_k__BackingField;
	
		// Properties
		public object ActualValue { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public ConstraintStatus Status { [CompilerGenerated] get; [CompilerGenerated] set; }
		public virtual bool IsSuccess { get; }
		public string Description { get; }
	
		// Constructors
		public ConstraintResult(IConstraint constraint, object actualValue);
		public ConstraintResult(IConstraint constraint, object actualValue, bool isSuccess);
	
		// Methods
		public virtual void WriteMessageTo(MessageWriter writer);
		public virtual void WriteActualValueTo(MessageWriter writer);
	}
}
