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
	public class AsyncTriggerTrigger : AsyncTriggerBase
	{
		// Fields
		private AsyncTriggerPromise<Collider> onTriggerEnter;
		private AsyncTriggerPromiseDictionary<Collider> onTriggerEnters;
		private AsyncTriggerPromise<Collider> onTriggerExit;
		private AsyncTriggerPromiseDictionary<Collider> onTriggerExits;
		private AsyncTriggerPromise<Collider> onTriggerStay;
		private AsyncTriggerPromiseDictionary<Collider> onTriggerStays;
	
		// Constructors
		public AsyncTriggerTrigger();
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises();
		private void OnTriggerEnter(Collider other);
		public UniTask<Collider> OnTriggerEnterAsync(CancellationToken cancellationToken = default);
		private void OnTriggerExit(Collider other);
		public UniTask<Collider> OnTriggerExitAsync(CancellationToken cancellationToken = default);
		private void OnTriggerStay(Collider other);
		public UniTask<Collider> OnTriggerStayAsync(CancellationToken cancellationToken = default);
	}
}
