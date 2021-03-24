/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal.Filters
{
	public abstract class CompositeFilter : TestFilter
	{
		// Fields
		[CompilerGenerated]
		private IList<ITestFilter> _Filters_k__BackingField;
	
		// Properties
		public IList<ITestFilter> Filters { [CompilerGenerated] get; [CompilerGenerated] private set; }
		protected abstract string ElementName { get; }
	
		// Constructors
		public CompositeFilter();
		public CompositeFilter(params ITestFilter[] filters);
	
		// Methods
		public abstract bool Pass(ITest test);
		public abstract bool Match(ITest test);
		public abstract bool IsExplicitMatch(ITest test);
		public override TNode AddToXml(TNode parentNode, bool recursive);
	}
}
