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
	public static class Progress
	{
		// Nested types
		private sealed class NullProgress<T> : IProgress<T>
		{
			// Fields
			public static readonly IProgress<T> Instance;
	
			// Constructors
			private NullProgress();
			static NullProgress();
	
			// Methods
			public void Report(T value);
		}
	
		private sealed class AnonymousProgress<T> : IProgress<T>
		{
			// Fields
			private readonly Action<T> action;
	
			// Constructors
			public AnonymousProgress(Action<T> action);
	
			// Methods
			public void Report(T value);
		}
	
		private sealed class OnlyValueChangedProgress<T> : IProgress<T>
		{
			// Fields
			private readonly Action<T> action;
			private readonly IEqualityComparer<T> comparer;
			private bool isFirstCall;
			private T latestValue;
	
			// Constructors
			public OnlyValueChangedProgress(Action<T> action, IEqualityComparer<T> comparer);
	
			// Methods
			public void Report(T value);
		}
	
		// Methods
		public static IProgress<T> Create<T>(Action<T> handler);
		public static IProgress<T> CreateOnlyValueChanged<T>(Action<T> handler, IEqualityComparer<T> comparer = null);
	}
}
