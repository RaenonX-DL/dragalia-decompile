/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async
{
	public static class EnumerableAsyncExtensions
	{
		// Extension methods
		public static IEnumerable<UniTask> Select<T>(this IEnumerable<T> source, Func<T, UniTask> selector);
		public static IEnumerable<UniTask<TR>> Select<T, TR>(this IEnumerable<T> source, Func<T, UniTask<TR>> selector);
		public static IEnumerable<UniTask> Select<T>(this IEnumerable<T> source, Func<T, int, UniTask> selector);
		public static IEnumerable<UniTask<TR>> Select<T, TR>(this IEnumerable<T> source, Func<T, int, UniTask<TR>> selector);
	}
}
