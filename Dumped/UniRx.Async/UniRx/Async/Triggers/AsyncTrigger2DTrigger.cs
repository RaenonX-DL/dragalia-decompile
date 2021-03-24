/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async;
using UnityEngine;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncTrigger2DTrigger : AsyncTriggerBase
	{
		// Fields
		private AsyncTriggerPromise<Collider2D> onTriggerEnter2D;
		private AsyncTriggerPromiseDictionary<Collider2D> onTriggerEnter2Ds;
		private AsyncTriggerPromise<Collider2D> onTriggerExit2D;
		private AsyncTriggerPromiseDictionary<Collider2D> onTriggerExit2Ds;
		private AsyncTriggerPromise<Collider2D> onTriggerStay2D;
		private AsyncTriggerPromiseDictionary<Collider2D> onTriggerStay2Ds;
	
		// Constructors
		public AsyncTrigger2DTrigger();
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises();
		private void OnTriggerEnter2D(Collider2D other);
		public UniTask<Collider2D> OnTriggerEnter2DAsync(CancellationToken cancellationToken = default);
		private void OnTriggerExit2D(Collider2D other);
		public UniTask<Collider2D> OnTriggerExit2DAsync(CancellationToken cancellationToken = default);
		private void OnTriggerStay2D(Collider2D other);
		public UniTask<Collider2D> OnTriggerStay2DAsync(CancellationToken cancellationToken = default);
	}
}
