/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace XLua
{
	public class ObjectPool
	{
		// Fields
		private const int LIST_END = -1;
		private const int ALLOCED = -2;
		private Slot[] list;
		private int freelist;
		private int count;
	
		// Properties
		public object this[int i] { get => default; }
	
		// Nested types
		private struct Slot
		{
			// Fields
			public int next;
			public object obj;
	
			// Constructors
			public Slot(int next, object obj);
		}
	
		// Constructors
		public ObjectPool();
	
		// Methods
		public void Clear();
		private void extend_capacity();
		public int Add(object obj);
		public bool TryGetValue(int index, out object obj);
		public object Get(int index);
		public object Remove(int index);
		public object Replace(int index, object o);
		public int Check(int check_pos, int max_check, Func<object, bool> checker, Dictionary<object, int> reverse_map);
	}
}
