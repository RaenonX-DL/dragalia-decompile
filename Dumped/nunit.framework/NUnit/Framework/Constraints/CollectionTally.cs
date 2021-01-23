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

// Image 51: nunit.framework.dll - Assembly: nunit.framework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=2638cd05610744eb

namespace NUnit.Framework.Constraints
{
	public class CollectionTally
	{
		// Fields
		private readonly List<object> list;
		private readonly NUnitEqualityComparer comparer;
	
		// Properties
		public int Count { get; }
	
		// Constructors
		public CollectionTally(NUnitEqualityComparer comparer, IEnumerable c);
	
		// Methods
		private bool ItemsEqual(object expected, object actual);
		public bool TryRemove(object o);
		public bool TryRemove(IEnumerable c);
	}
}
