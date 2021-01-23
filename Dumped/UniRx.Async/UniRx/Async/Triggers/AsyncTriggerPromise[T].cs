/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async;
using UniRx.Async.Internal;

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Triggers
{
	public class AsyncTriggerPromise<T> : ReusablePromise<T>, IPromise<T>, ICancelablePromise
	{
		// Fields
		[CompilerGenerated]
		private CancellationToken _RegisteredCancellationToken_k__BackingField;
	
		// Properties
		public CancellationToken RegisteredCancellationToken { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public AsyncTriggerPromise();
		public AsyncTriggerPromise(CancellationToken cancellationToken);
	
		// Methods
		public override T GetResult();
		public override bool TrySetResult(T result);
		public override bool TrySetCanceled();
	}
}
