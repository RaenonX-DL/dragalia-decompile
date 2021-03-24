/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async;
using UnityEngine;

// Image 53: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace UniRx.Async.Triggers
{
	public static class AsyncTriggerExtensions
	{
		// Methods
		private static T GetOrAddComponent<T>(GameObject gameObject)
			where T : Component;
	
		// Extension methods
		public static UniTask OnDestroyAsync(this GameObject gameObject);
		public static UniTask OnDestroyAsync(this Component component);
		public static CancellationToken GetCancellationTokenOnDestroy(this GameObject gameObject);
		public static CancellationToken GetCancellationTokenOnDestroy(this Component component);
		public static UniTask StartAsync(this GameObject gameObject);
		public static UniTask StartAsync(this Component component);
		public static UniTask AwakeAsync(this GameObject gameObject);
		public static UniTask AwakeAsync(this Component component);
		public static AsyncAnimatorTrigger GetAsyncAnimatorTrigger(this GameObject gameObject);
		public static AsyncAnimatorTrigger GetAsyncAnimatorTrigger(this Component component);
		public static AsyncAwakeTrigger GetAsyncAwakeTrigger(this GameObject gameObject);
		public static AsyncAwakeTrigger GetAsyncAwakeTrigger(this Component component);
		public static AsyncBeginDragTrigger GetAsyncBeginDragTrigger(this GameObject gameObject);
		public static AsyncBeginDragTrigger GetAsyncBeginDragTrigger(this Component component);
		public static AsyncCancelTrigger GetAsyncCancelTrigger(this GameObject gameObject);
		public static AsyncCancelTrigger GetAsyncCancelTrigger(this Component component);
		public static AsyncCanvasGroupChangedTrigger GetAsyncCanvasGroupChangedTrigger(this GameObject gameObject);
		public static AsyncCanvasGroupChangedTrigger GetAsyncCanvasGroupChangedTrigger(this Component component);
		public static AsyncCollision2DTrigger GetAsyncCollision2DTrigger(this GameObject gameObject);
		public static AsyncCollision2DTrigger GetAsyncCollision2DTrigger(this Component component);
		public static AsyncCollisionTrigger GetAsyncCollisionTrigger(this GameObject gameObject);
		public static AsyncCollisionTrigger GetAsyncCollisionTrigger(this Component component);
		public static AsyncDeselectTrigger GetAsyncDeselectTrigger(this GameObject gameObject);
		public static AsyncDeselectTrigger GetAsyncDeselectTrigger(this Component component);
		public static AsyncDestroyTrigger GetAsyncDestroyTrigger(this GameObject gameObject);
		public static AsyncDestroyTrigger GetAsyncDestroyTrigger(this Component component);
		public static AsyncDragTrigger GetAsyncDragTrigger(this GameObject gameObject);
		public static AsyncDragTrigger GetAsyncDragTrigger(this Component component);
		public static AsyncDropTrigger GetAsyncDropTrigger(this GameObject gameObject);
		public static AsyncDropTrigger GetAsyncDropTrigger(this Component component);
		public static AsyncEnableDisableTrigger GetAsyncEnableDisableTrigger(this GameObject gameObject);
		public static AsyncEnableDisableTrigger GetAsyncEnableDisableTrigger(this Component component);
		public static AsyncEndDragTrigger GetAsyncEndDragTrigger(this GameObject gameObject);
		public static AsyncEndDragTrigger GetAsyncEndDragTrigger(this Component component);
		public static AsyncFixedUpdateTrigger GetAsyncFixedUpdateTrigger(this GameObject gameObject);
		public static AsyncFixedUpdateTrigger GetAsyncFixedUpdateTrigger(this Component component);
		public static AsyncInitializePotentialDragTrigger GetAsyncInitializePotentialDragTrigger(this GameObject gameObject);
		public static AsyncInitializePotentialDragTrigger GetAsyncInitializePotentialDragTrigger(this Component component);
		public static AsyncJointTrigger GetAsyncJointTrigger(this GameObject gameObject);
		public static AsyncJointTrigger GetAsyncJointTrigger(this Component component);
		public static AsyncLateUpdateTrigger GetAsyncLateUpdateTrigger(this GameObject gameObject);
		public static AsyncLateUpdateTrigger GetAsyncLateUpdateTrigger(this Component component);
		public static AsyncMoveTrigger GetAsyncMoveTrigger(this GameObject gameObject);
		public static AsyncMoveTrigger GetAsyncMoveTrigger(this Component component);
		public static AsyncParticleTrigger GetAsyncParticleTrigger(this GameObject gameObject);
		public static AsyncParticleTrigger GetAsyncParticleTrigger(this Component component);
		public static AsyncPointerClickTrigger GetAsyncPointerClickTrigger(this GameObject gameObject);
		public static AsyncPointerClickTrigger GetAsyncPointerClickTrigger(this Component component);
		public static AsyncPointerDownTrigger GetAsyncPointerDownTrigger(this GameObject gameObject);
		public static AsyncPointerDownTrigger GetAsyncPointerDownTrigger(this Component component);
		public static AsyncPointerEnterTrigger GetAsyncPointerEnterTrigger(this GameObject gameObject);
		public static AsyncPointerEnterTrigger GetAsyncPointerEnterTrigger(this Component component);
		public static AsyncPointerExitTrigger GetAsyncPointerExitTrigger(this GameObject gameObject);
		public static AsyncPointerExitTrigger GetAsyncPointerExitTrigger(this Component component);
		public static AsyncPointerUpTrigger GetAsyncPointerUpTrigger(this GameObject gameObject);
		public static AsyncPointerUpTrigger GetAsyncPointerUpTrigger(this Component component);
		public static AsyncRectTransformTrigger GetAsyncRectTransformTrigger(this GameObject gameObject);
		public static AsyncRectTransformTrigger GetAsyncRectTransformTrigger(this Component component);
		public static AsyncScrollTrigger GetAsyncScrollTrigger(this GameObject gameObject);
		public static AsyncScrollTrigger GetAsyncScrollTrigger(this Component component);
		public static AsyncSelectTrigger GetAsyncSelectTrigger(this GameObject gameObject);
		public static AsyncSelectTrigger GetAsyncSelectTrigger(this Component component);
		public static AsyncStartTrigger GetAsyncStartTrigger(this GameObject gameObject);
		public static AsyncStartTrigger GetAsyncStartTrigger(this Component component);
		public static AsyncSubmitTrigger GetAsyncSubmitTrigger(this GameObject gameObject);
		public static AsyncSubmitTrigger GetAsyncSubmitTrigger(this Component component);
		public static AsyncTransformChangedTrigger GetAsyncTransformChangedTrigger(this GameObject gameObject);
		public static AsyncTransformChangedTrigger GetAsyncTransformChangedTrigger(this Component component);
		public static AsyncTrigger2DTrigger GetAsyncTrigger2DTrigger(this GameObject gameObject);
		public static AsyncTrigger2DTrigger GetAsyncTrigger2DTrigger(this Component component);
		public static AsyncTriggerTrigger GetAsyncTriggerTrigger(this GameObject gameObject);
		public static AsyncTriggerTrigger GetAsyncTriggerTrigger(this Component component);
		public static AsyncUpdateSelectedTrigger GetAsyncUpdateSelectedTrigger(this GameObject gameObject);
		public static AsyncUpdateSelectedTrigger GetAsyncUpdateSelectedTrigger(this Component component);
		public static AsyncUpdateTrigger GetAsyncUpdateTrigger(this GameObject gameObject);
		public static AsyncUpdateTrigger GetAsyncUpdateTrigger(this Component component);
		public static AsyncVisibleTrigger GetAsyncVisibleTrigger(this GameObject gameObject);
		public static AsyncVisibleTrigger GetAsyncVisibleTrigger(this Component component);
	}
}
