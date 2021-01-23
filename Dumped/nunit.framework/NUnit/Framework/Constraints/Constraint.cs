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
	public abstract class Constraint : IConstraint
	{
		// Fields
		private Lazy<string> _displayName;
		[CompilerGenerated]
		private string _Description_k__BackingField;
		[CompilerGenerated]
		private object[] _Arguments_k__BackingField;
		[CompilerGenerated]
		private ConstraintBuilder _Builder_k__BackingField;
	
		// Properties
		public virtual string DisplayName { get; }
		public virtual string Description { [CompilerGenerated] get; }
		public object[] Arguments { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public ConstraintBuilder Builder { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		protected Constraint(params object[] args);
	
		// Methods
		public abstract ConstraintResult ApplyTo(object actual);
		public override string ToString();
		protected virtual string GetStringRepresentation();
		private static string _displayable(object o);
		IConstraint IResolveConstraint.Resolve();
		[CompilerGenerated]
		private string _.ctor_b__0();
	}
}
