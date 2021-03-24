/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleObjectsController : MonoBehaviour
	{
		// Fields
		public GrowthManaCircleScene scene;
		[CompilerGenerated]
		private GrowthManaCircleManaCircleObject _currentTargetCircle_k__BackingField;
		public int currentTargetCircleIndex;
		public GameObject rootObject;
		public GameObject[] circleRoots;
		public GameObject[] lockRoots;
		public GameObject symbolNode1;
		public GameObject symbolNode2;
		private bool _isObjectLoaded;
		[HideInInspector]
		public float rotateSpeed;
		[HideInInspector]
		public float moveUpSpeed;
		[HideInInspector]
		public bool isCircleAdjustAnimating;
		[HideInInspector]
		public bool isCircleAdjustCompleted;
		[HideInInspector]
		public float circleAdjustTargetRotationY;
		[HideInInspector]
		public bool isMoveUpAdjustAnimating;
		[HideInInspector]
		public bool isMoveUpAdjustCompleted;
		[HideInInspector]
		public bool isDragAreaDragging;
		[HideInInspector]
		public bool isTouchPointDragging;
		[HideInInspector]
		public bool isMotifDragging;
		[HideInInspector]
		public float moveUpY;
		private GameObject symbolMotifObject;
		private EffectObject symbolObject1;
		protected EffectObject symbolObject2;
		protected GrowthManaCircleManaCircleObject[] circles;
		protected EffectObject[] circleEffectObjects;
		private GameObject[] lockObjects;
		private EffectObject[] lockEffectObjects;
		private EffectObject[] releaseLimitObjects;
		protected GameObject spaceSpace;
		protected GameObject spaceCloud;
		protected GameObject[] spaceStar;
		protected EffectObject spaceEffect;
		private Tweener moveUpTweener;
		protected Tweener rotateTweener;
		protected GrowthManaCircleObjectSettings objectSettings;
		protected GrowthManaCircleCameraSettings cameraSettings;
		protected GrowthManaCircleModel model;
		private float adjustMoveUpY;
		protected ElementalType elementalType;
		private bool isInitialRotationDone;
		private EffectObject releaseEffect;
		public const int numOfPoint = 10;
		protected const float minMoveDelta = 0.0001f;
	
		// Properties
		public GrowthManaCircleManaCircleObject currentTargetCircle { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isObjectLoaded { get; set; }
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__51_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _LoadMotifEffect_b__51_0();
		}
	
		[CompilerGenerated]
		private sealed class _LoadMotifEffect_d__51 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleObjectsController __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadMotifEffect_d__51(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _PlaySecondManacircleSceneReleaseEffect_d__56 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleObjectsController __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _PlaySecondManacircleSceneReleaseEffect_d__56(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _InitRotateCoroutine_d__59 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthManaCircleObjectsController __4__this;
			private float _startTime_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _InitRotateCoroutine_d__59(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass80_0
		{
			// Fields
			public Transform t;
			public Quaternion srcDir;
			public Quaternion dstDir;
	
			// Constructors
			public __c__DisplayClass80_0();
	
			// Methods
			internal void _StartAdjustLowerCirclePositionTransformAnimation_b__0(float value);
			internal void _StartAdjustLowerCirclePositionTransformAnimation_b__1(float value);
			internal void _StartAdjustLowerCirclePositionTransformAnimation_b__2(float value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass82_0
		{
			// Fields
			public Transform t;
			public Quaternion srcDir;
			public Quaternion dstDir;
	
			// Constructors
			public __c__DisplayClass82_0();
	
			// Methods
			internal void _CancelAdjustLowerCirclePositionTransformAnimation_b__0(float value);
			internal void _CancelAdjustLowerCirclePositionTransformAnimation_b__1(float value);
			internal void _CancelAdjustLowerCirclePositionTransformAnimation_b__2(float value);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass106_0
		{
			// Fields
			public GrowthManaCircleObjectsController __4__this;
			public Vector3 initialPosition;
			public Vector3 targetPosition;
	
			// Constructors
			public __c__DisplayClass106_0();
	
			// Methods
			internal void _MoveRootObject_b__0(float value);
		}
	
		// Constructors
		public GrowthManaCircleObjectsController();
	
		// Methods
		private void OnDestroy();
		public virtual void Init();
		[IteratorStateMachine]
		protected virtual IEnumerator LoadMotifEffect();
		public void StopAllEffect();
		public EffectObject CreateSymbolObject();
		public EffectObject CreateSymbolObject(bool isAllPointReleased);
		public EffectObject SwitchSymbolObject(bool isAllPointReleased);
		[IteratorStateMachine]
		public IEnumerator PlaySecondManacircleSceneReleaseEffect();
		public void InitMoveUp();
		public void InitRotate();
		[IteratorStateMachine]
		private IEnumerator InitRotateCoroutine();
		public GrowthManaCircleManaCircleObject GetCurrentTargetCircle();
		public GrowthManaCircleManaCircleObject GetCircle(int index);
		public int GetCurrentTargetCircleIndex();
		public bool isCurrentTargetCircleLast();
		public GrowthManaCircleMotifObject GetCurrentTargetMotif();
		public GrowthManaCircleLockObject GetNextTargetLockObject();
		public GrowthManaCircleLockObject GetCurrentTargetLockObject();
		public virtual int GetCenterTouchPointIndex();
		public bool isReleasableCircle(int index);
		public bool isCurrentTargetCircleReleasable();
		public virtual int GetNumOfUnReleasedPointOnCurrentMaxCircle();
		public List<int> GetUnReleasedPointListOnCurrentMaxCircle();
		public int GetDistanceBetweenCurrentToMaxCircle();
		public bool IsReleaseLimitDescVisible();
		public void ReleaseCircle();
		public void UpdateRotateBgObjects(float deltaTime);
		public void UpdateMoveDownStars(float deltaTime);
		private void AdjustLowerCirclePosition();
		private void AdjustLowerCirclePositionTransform(Transform t, float y);
		public void StartAdjustLowerCirclePosition();
		private void StartAdjustLowerCirclePositionTransformAnimation(Transform t, float y);
		public void CancelAdjustLowerCirclePosition();
		private void CancelAdjustLowerCirclePositionTransformAnimation(Transform t);
		public void ReplaceReleaseObject();
		public void DestroyLockObject();
		public virtual void RotateCircle(float value);
		public virtual void MovePointToFront(int index);
		public void MovePointToFrontCounterClockWise(int index);
		public virtual void UpdateCircleRotation();
		private void StartCircleAdjustAnimation();
		private void OnCircleAnimationUpdate(float value);
		private void OnCircleAnimationComplete();
		public bool CanMovableUpDown();
		public void MoveUpCircle(float value);
		public void UpdateMoveUp();
		private void OnApplicationPause(bool pause);
		public void ForceMoveUp(float duration = 1.5f);
		public void ForceMoveUpToCircle(int index, float duration);
		public void ForceMoveUpByDeltaY(float deltaY, float duration);
		public void ForceMoveUpToMaxCircle(float duration);
		private void StartMoveUpAdjustAnimation(bool isNoBackingMode = false, bool isForceMove = false);
		private void OnMoveUpAnimationUpdate(float value, bool updateMoveY = true);
		public void SetMoveUp(float value, bool updateMoveY = true);
		private void OnMoveUpAnimationComplete();
		private void OnMoveUpForceAnimationComplete();
		private void OnMoveUpForceAnimationWithLimitZoomComplete();
		public void MoveRootObject(float deltaY, float duration);
		public virtual void LateUpdateCircle();
		public virtual bool ShouldPointDescDraw();
		public void KickAllReleasedTrigger();
		public void AllReleaseForDebug();
		public virtual void Reset();
		[CompilerGenerated]
		private void _PlaySecondManacircleSceneReleaseEffect_b__56_0();
		[CompilerGenerated]
		private void _MovePointToFront_b__86_0(float value);
		[CompilerGenerated]
		private void _MovePointToFront_b__86_1();
		[CompilerGenerated]
		private void _MovePointToFrontCounterClockWise_b__87_0(float value);
		[CompilerGenerated]
		private void _MovePointToFrontCounterClockWise_b__87_1();
		[CompilerGenerated]
		private void _StartCircleAdjustAnimation_b__89_0(float value);
		[CompilerGenerated]
		private void _StartCircleAdjustAnimation_b__89_1();
		[CompilerGenerated]
		private void _ForceMoveUpToCircle_b__97_0(float value);
		[CompilerGenerated]
		private void _ForceMoveUpToCircle_b__97_1();
		[CompilerGenerated]
		private void _ForceMoveUpByDeltaY_b__98_0(float value);
		[CompilerGenerated]
		private void _ForceMoveUpByDeltaY_b__98_1();
		[CompilerGenerated]
		private void _StartMoveUpAdjustAnimation_b__100_0(float value);
		[CompilerGenerated]
		private void _StartMoveUpAdjustAnimation_b__100_1();
	}
}
