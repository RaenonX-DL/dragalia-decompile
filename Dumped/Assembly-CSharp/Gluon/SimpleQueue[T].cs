/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SimpleQueue<T>
		where T : IReplicable<T>, ICleanable, new()
	{
		// Fields
		private int qmax;
		private int n;
		private int ptr;
		private T[] data;
	
		// Constructors
		public SimpleQueue(int max);
	
		// Methods
		public void Flush();
		public bool EnQueue(T d);
		public void DeQueue();
		public T Get();
		public T Get(int offset);
		public int Count();
		public bool IsEmpty();
		public bool IsFull();
	}
}
