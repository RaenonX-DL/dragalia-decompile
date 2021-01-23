/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Builders;

// Image 51: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework
{
	[AttributeUsage]
	public class TestFixtureAttribute : NUnitAttribute, IFixtureBuilder, ITestFixtureData
	{
		// Fields
		private readonly NUnitTestFixtureBuilder _builder;
		[CompilerGenerated]
		private RunState _RunState_k__BackingField;
		[CompilerGenerated]
		private object[] _Arguments_k__BackingField;
		[CompilerGenerated]
		private IPropertyBag _Properties_k__BackingField;
		[CompilerGenerated]
		private Type[] _TypeArgs_k__BackingField;
	
		// Properties
		public RunState RunState { [CompilerGenerated] get; }
		public object[] Arguments { [CompilerGenerated] get; }
		public IPropertyBag Properties { [CompilerGenerated] get; }
		public Type[] TypeArgs { [CompilerGenerated] get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _BuildFrom_d__0 : IEnumerable<TestSuite>, IEnumerator<TestSuite>
		{
			// Fields
			private TestSuite __2__current;
			private int __1__state;
			private int __l__initialThreadId;
			public TestFixtureAttribute __4__this;
			public ITypeInfo typeInfo;
			public ITypeInfo __3__typeInfo;
	
			// Properties
			TestSuite IEnumerator<NUnit.Framework.Internal.TestSuite>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _BuildFrom_d__0(int __1__state);
	
			// Methods
			[DebuggerHidden]
			IEnumerator<TestSuite> IEnumerable<TestSuite>.GetEnumerator();
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
			void IDisposable.Dispose();
		}
	
		// Methods
		public IEnumerable<TestSuite> BuildFrom(ITypeInfo typeInfo);
	}
}
