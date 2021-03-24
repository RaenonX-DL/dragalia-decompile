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
	public class ConstraintBuilder : IResolveConstraint
	{
		// Fields
		private readonly OperatorStack ops;
		private readonly ConstraintStack constraints;
		private object lastPushed;
	
		// Properties
		private bool IsResolvable { get; }
	
		// Nested types
		public class OperatorStack
		{
			// Fields
			private readonly Stack<ConstraintOperator> stack;
	
			// Properties
			public bool Empty { get; }
	
			// Methods
			public ConstraintOperator Pop();
		}
	
		public class ConstraintStack
		{
			// Fields
			private readonly Stack<IConstraint> stack;
	
			// Methods
			public IConstraint Pop();
		}
	
		// Methods
		public IConstraint Resolve();
	}
}
