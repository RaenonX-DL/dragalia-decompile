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
	public class AsyncParticleTrigger : AsyncTriggerBase
	{
		// Fields
		private AsyncTriggerPromise<GameObject> onParticleCollision;
		private AsyncTriggerPromiseDictionary<GameObject> onParticleCollisions;
	
		// Constructors
		public AsyncParticleTrigger();
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises();
		private void OnParticleCollision(GameObject other);
		public UniTask<GameObject> OnParticleCollisionAsync(CancellationToken cancellationToken = default);
	}
}
