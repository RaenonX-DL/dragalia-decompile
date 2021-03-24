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
using UnityEngine.EventSystems;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncMoveTrigger : AsyncTriggerBase, IMoveHandler
	{
		// Fields
		private AsyncTriggerPromise<AxisEventData> onMove;
		private AsyncTriggerPromiseDictionary<AxisEventData> onMoves;
	
		// Constructors
		public AsyncMoveTrigger();
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises();
		void IMoveHandler.OnMove(AxisEventData eventData);
		public UniTask<AxisEventData> OnMoveAsync(CancellationToken cancellationToken = default);
	}
}
