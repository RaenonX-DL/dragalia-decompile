using System;
using System.Runtime.CompilerServices;
using System.Threading;
using DG.Tweening;

public static class TweenExtensions
{
	public struct TweenAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		private static readonly Action<object> cancellationCallback;

		private readonly Tween tween;

		private readonly CancellationToken cancellationToken;

		public bool IsCompleted => default(bool);

		public TweenAwaiter(Tween tween, CancellationToken cancellationToken)
		{
		}

		public TweenAwaiter GetAwaiter()
		{
			return default(TweenAwaiter);
		}

		public void GetResult()
		{
		}

		public void OnCompleted(Action continuation)
		{
		}

		public void UnsafeOnCompleted(Action continuation)
		{
		}

		private static void RegisterCompleteEvent(Tween tween, CancellationTokenRegistration registration, Action continuation)
		{
		}

		private static void CancellationCallbackCore(object state)
		{
		}
	}

	public static TweenAwaiter GetAwaiter(this Tween tween)
	{
		return default(TweenAwaiter);
	}

	public static TweenAwaiter ConfigureAwait(this Tween tween, CancellationToken cancellationToken)
	{
		return default(TweenAwaiter);
	}
}
