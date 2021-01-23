/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Internal
{
	internal static class ArrayUtil
	{
		// Methods
		public static void EnsureCapacity<T>(ref T[] array, int index);
		private static void EnsureCore<T>(ref T[] array, int index);
		public static ValueTuple<T[], int> Materialize<T>(IEnumerable<T> source);
	}
}
