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

// Image 50: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncCollision2DTrigger : AsyncTriggerBase
	{
		// Fields
		private AsyncTriggerPromise<Collision2D> onCollisionEnter2D;
		private AsyncTriggerPromiseDictionary<Collision2D> onCollisionEnter2Ds;
		private AsyncTriggerPromise<Collision2D> onCollisionExit2D;
		private AsyncTriggerPromiseDictionary<Collision2D> onCollisionExit2Ds;
		private AsyncTriggerPromise<Collision2D> onCollisionStay2D;
		private AsyncTriggerPromiseDictionary<Collision2D> onCollisionStay2Ds;
	
		// Constructors
		public AsyncCollision2DTrigger();
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises();
		private void OnCollisionEnter2D(Collision2D coll);
		public UniTask<Collision2D> OnCollisionEnter2DAsync(CancellationToken cancellationToken = default);
		private void OnCollisionExit2D(Collision2D coll);
		public UniTask<Collision2D> OnCollisionExit2DAsync(CancellationToken cancellationToken = default);
		private void OnCollisionStay2D(Collision2D coll);
		public UniTask<Collision2D> OnCollisionStay2DAsync(CancellationToken cancellationToken = default);
	}
}
