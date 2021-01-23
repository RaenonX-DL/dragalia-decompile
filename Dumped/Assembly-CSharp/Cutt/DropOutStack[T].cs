/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public class DropOutStack<T>
		where T : class
	{
		// Fields
		private T[] Items;
		private int Top;
		public int Count;
		private int Capacity;
	
		// Constructors
		public DropOutStack(int capacity);
	
		// Methods
		public void Push(T item);
		public T Pop();
		public T At(int index);
		public void Clear();
	}
}
