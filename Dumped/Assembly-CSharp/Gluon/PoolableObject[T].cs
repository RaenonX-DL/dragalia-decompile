/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PoolableObject<T>
		where T : IPoolableObject, new()
	{
		// Fields
		private List<T> pool;
	
		// Properties
		public int Count { get; }
	
		// Constructors
		public PoolableObject(int initialCapacity);
	
		// Methods
		public T Fetch();
		public void ReleaseAll();
	}
}
