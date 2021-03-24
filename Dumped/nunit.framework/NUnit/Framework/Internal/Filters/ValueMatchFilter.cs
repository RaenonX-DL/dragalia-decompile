/*
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
	public abstract class ValueMatchFilter : TestFilter
	{
		// Fields
		[CompilerGenerated]
		private string _ExpectedValue_k__BackingField;
		[CompilerGenerated]
		private bool _IsRegex_k__BackingField;
	
		// Properties
		public string ExpectedValue { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsRegex { [CompilerGenerated] get; [CompilerGenerated] set; }
		protected abstract string ElementName { get; }
	
		// Constructors
		public ValueMatchFilter(string expectedValue);
	
		// Methods
		protected bool Match(string input);
		public override TNode AddToXml(TNode parentNode, bool recursive);
	}
}
