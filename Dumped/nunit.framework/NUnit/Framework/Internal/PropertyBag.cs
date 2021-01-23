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

// Image 51: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Internal
{
	public class PropertyBag : IPropertyBag
	{
		// Fields
		private Dictionary<string, IList> inner;
	
		// Properties
		public ICollection<string> Keys { get; }
		public IList this[string key] { get => default; }
	
		// Constructors
		public PropertyBag();
	
		// Methods
		public void Add(string key, object value);
		public void Set(string key, object value);
		public object Get(string key);
		public bool ContainsKey(string key);
		public TNode ToXml(bool recursive);
		public TNode AddToXml(TNode parentNode, bool recursive);
	}
}
