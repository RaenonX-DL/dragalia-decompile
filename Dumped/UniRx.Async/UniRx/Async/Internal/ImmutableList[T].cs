/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Internal
{
	internal class ImmutableList<T>
	{
		// Fields
		public static readonly ImmutableList<T> Empty;
		private T[] data;
	
		// Properties
		public T[] Data { get; }
	
		// Constructors
		private ImmutableList();
		public ImmutableList(T[] data);
		static ImmutableList();
	
		// Methods
		public ImmutableList<T> Add(T value);
		public ImmutableList<T> Remove(T value);
		public int IndexOf(T value);
	}
}
