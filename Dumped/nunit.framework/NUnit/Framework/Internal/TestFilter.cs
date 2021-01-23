/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using NUnit.Framework.Interfaces;

// Image 51: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal
{
	[Serializable]
	public abstract class TestFilter : ITestFilter
	{
		// Fields
		public static readonly TestFilter Empty;
		[CompilerGenerated]
		private bool _TopLevel_k__BackingField;
	
		// Nested types
		[Serializable]
		private class EmptyFilter : TestFilter
		{
			// Constructors
			public EmptyFilter();
	
			// Methods
			public override bool Match(ITest test);
			public override bool Pass(ITest test);
			public override bool IsExplicitMatch(ITest test);
			public override TNode AddToXml(TNode parentNode, bool recursive);
		}
	
		// Constructors
		protected TestFilter();
		static TestFilter();
	
		// Methods
		public virtual bool Pass(ITest test);
		public virtual bool IsExplicitMatch(ITest test);
		public abstract bool Match(ITest test);
		public bool MatchParent(ITest test);
		protected virtual bool MatchDescendant(ITest test);
		public TNode ToXml(bool recursive);
		public abstract TNode AddToXml(TNode parentNode, bool recursive);
	}
}
