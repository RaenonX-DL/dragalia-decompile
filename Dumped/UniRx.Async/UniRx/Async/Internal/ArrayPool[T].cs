/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Internal
{
	internal sealed class ArrayPool<T>
	{
		// Fields
		private const int DefaultMaxNumberOfArraysPerBucket = 50;
		private static readonly T[] EmptyArray;
		public static readonly ArrayPool<T> Shared;
		private readonly MinimumQueue<T[]>[] buckets;
		private readonly SpinLock[] locks;
	
		// Constructors
		private ArrayPool();
		static ArrayPool();
	
		// Methods
		public T[] Rent(int minimumLength);
		public void Return(T[] array, bool clearArray = false);
		private static int CalculateSize(int size);
		private static int GetQueueIndex(int size);
	}
}
