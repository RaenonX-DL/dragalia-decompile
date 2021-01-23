/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async;
using UnityEngine;

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncDestroyTrigger : MonoBehaviour
	{
		// Fields
		private bool called;
		private UniTaskCompletionSource promise;
		private CancellationTokenSource cancellationTokenSource;
		private object canellationTokenSourceOrQueue;
	
		// Properties
		public CancellationToken CancellationToken { get; }
	
		// Constructors
		public AsyncDestroyTrigger();
	
		// Methods
		private void OnDestroy();
		public UniTask OnDestroyAsync();
		public void AddCancellationTriggerOnDestory(CancellationTokenSource cts);
	}
}
