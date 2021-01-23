/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using DG.Tweening;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public static class TweenExtensions
{
	// Nested types
	public struct TweenAwaiter : ICriticalNotifyCompletion
	{
		// Fields
		private static readonly Action<object> cancellationCallback;
		private readonly Tween tween;
		private readonly CancellationToken cancellationToken;

		// Properties
		public bool IsCompleted { get; }

		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass10_0
		{
			// Fields
			public CancellationTokenRegistration registration;
			public Action continuation;

			// Constructors
			public __c__DisplayClass10_0();

			// Methods
			internal void _RegisterCompleteEvent_b__0();
		}

		// Constructors
		public TweenAwaiter(Tween tween, CancellationToken cancellationToken);
		static TweenAwaiter();

		// Methods
		public TweenAwaiter GetAwaiter();
		public void GetResult();
		public void OnCompleted(Action continuation);
		public void UnsafeOnCompleted(Action continuation);
		private static void RegisterCompleteEvent(Tween tween, CancellationTokenRegistration registration, Action continuation);
		private static void CancellationCallbackCore(object state);
	}

	// Extension methods
	public static TweenAwaiter GetAwaiter(this Tween tween);
	public static TweenAwaiter ConfigureAwait(this Tween tween, CancellationToken cancellationToken);
}

