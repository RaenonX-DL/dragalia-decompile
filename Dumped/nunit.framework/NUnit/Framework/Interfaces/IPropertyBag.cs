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

// Image 54: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Interfaces
{
	public interface IPropertyBag : IXmlNodeBuilder
	{
		// Properties
		IList this[string key] { get => default; }
		ICollection<string> Keys { get; }
	
		// Methods
		void Add(string key, object value);
		void Set(string key, object value);
		object Get(string key);
		bool ContainsKey(string key);
	}
}
