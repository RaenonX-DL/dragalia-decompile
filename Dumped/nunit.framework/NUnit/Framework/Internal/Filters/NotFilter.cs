﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal.Filters
{
	[Serializable]
	public class NotFilter : TestFilter
	{
		// Fields
		[CompilerGenerated]
		private TestFilter _BaseFilter_k__BackingField;
	
		// Properties
		public TestFilter BaseFilter { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public NotFilter(TestFilter baseFilter);
	
		// Methods
		public override bool Pass(ITest test);
		public override bool Match(ITest test);
		public override bool IsExplicitMatch(ITest test);
		public override TNode AddToXml(TNode parentNode, bool recursive);
	}
}
