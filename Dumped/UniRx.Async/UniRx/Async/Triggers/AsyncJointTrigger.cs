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
	public class AsyncJointTrigger : AsyncTriggerBase
	{
		// Fields
		private AsyncTriggerPromise<float> onJointBreak;
		private AsyncTriggerPromiseDictionary<float> onJointBreaks;
		private AsyncTriggerPromise<Joint2D> onJointBreak2D;
		private AsyncTriggerPromiseDictionary<Joint2D> onJointBreak2Ds;
	
		// Constructors
		public AsyncJointTrigger();
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises();
		private void OnJointBreak(float breakForce);
		public UniTask<float> OnJointBreakAsync(CancellationToken cancellationToken = default);
		private void OnJointBreak2D(Joint2D brokenJoint);
		public UniTask<Joint2D> OnJointBreak2DAsync(CancellationToken cancellationToken = default);
	}
}
