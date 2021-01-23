/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class Pool<T>
		where T : class, new()
	{
		// Fields
		public readonly int max;
		private readonly Stack<T> freeObjects;
		[CompilerGenerated]
		private int _Peak_k__BackingField;
	
		// Properties
		public int Count { get; }
		public int Peak { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public interface IPoolable
		{
			// Methods
			void Reset();
		}
	
		// Constructors
		public Pool(int initialCapacity = 16, int max = 2147483647);
	
		// Methods
		public T Obtain();
		public void Free(T obj);
		public void Clear();
		protected void Reset(T obj);
	}
}
