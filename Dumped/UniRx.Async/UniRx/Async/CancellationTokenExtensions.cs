/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async
{
	public static class CancellationTokenExtensions
	{
		// Fields
		private static readonly Action<object> cancellationTokenCallback;
	
		// Constructors
		static CancellationTokenExtensions();
	
		// Methods
		private static void Callback(object state);
	
		// Extension methods
		public static ValueTuple<UniTask, CancellationTokenRegistration> ToUniTask(this CancellationToken cts);
		public static CancellationTokenRegistration RegisterWithoutCaptureExecutionContext(this CancellationToken cancellationToken, Action callback);
		public static CancellationTokenRegistration RegisterWithoutCaptureExecutionContext(this CancellationToken cancellationToken, Action<object> callback, object state);
	}
}
