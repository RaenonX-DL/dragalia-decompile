using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class GrowthManaCircleObjectsController : MonoBehaviour
	{
		public GrowthManaCircleScene scene;

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

		public GrowthManaCircleManaCircleObject currentTargetCircle
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isObjectLoaded
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		private void OnDestroy()
		{
		}

		public virtual void Init()
		{
		}

		protected virtual IEnumerator LoadMotifEffect()
		{
			return null;
		}

		public void StopAllEffect()
		{
		}

		public EffectObject CreateSymbolObject()
		{
			return null;
		}

		public EffectObject CreateSymbolObject(bool isAllPointReleased)
		{
			return null;
		}

		public EffectObject SwitchSymbolObject(bool isAllPointReleased)
		{
			return null;
		}

		public IEnumerator PlaySecondManacircleSceneReleaseEffect()
		{
			return null;
		}

		public void InitMoveUp()
		{
		}

		public void InitRotate()
		{
		}

		private IEnumerator InitRotateCoroutine()
		{
			return null;
		}

		public GrowthManaCircleManaCircleObject GetCurrentTargetCircle()
		{
			return null;
		}

		public GrowthManaCircleManaCircleObject GetCircle(int index)
		{
			return null;
		}

		public int GetCurrentTargetCircleIndex()
		{
			return default(int);
		}

		public bool isCurrentTargetCircleLast()
		{
			return default(bool);
		}

		public GrowthManaCircleMotifObject GetCurrentTargetMotif()
		{
			return null;
		}

		public GrowthManaCircleLockObject GetNextTargetLockObject()
		{
			return null;
		}

		public GrowthManaCircleLockObject GetCurrentTargetLockObject()
		{
			return null;
		}

		public virtual int GetCenterTouchPointIndex()
		{
			return default(int);
		}

		public bool isReleasableCircle(int index)
		{
			return default(bool);
		}

		public bool isCurrentTargetCircleReleasable()
		{
			return default(bool);
		}

		public virtual int GetNumOfUnReleasedPointOnCurrentMaxCircle()
		{
			return default(int);
		}

		public List<int> GetUnReleasedPointListOnCurrentMaxCircle()
		{
			return null;
		}

		public int GetDistanceBetweenCurrentToMaxCircle()
		{
			return default(int);
		}

		public bool IsReleaseLimitDescVisible()
		{
			return default(bool);
		}

		public void ReleaseCircle()
		{
		}

		public void ReleaseCircle(int index)
		{
		}

		public void ReleaseLimitObject(int index)
		{
		}

		public void ReleaseCircleLockObject(int index)
		{
		}

		public void UpdateRotateBgObjects(float deltaTime)
		{
		}

		public void UpdateMoveDownStars(float deltaTime)
		{
		}

		private void AdjustLowerCirclePosition()
		{
		}

		private void AdjustLowerCirclePositionTransform(Transform t, float y)
		{
		}

		public void StartAdjustLowerCirclePosition()
		{
		}

		private void StartAdjustLowerCirclePositionTransformAnimation(Transform t, float y)
		{
		}

		public void CancelAdjustLowerCirclePosition()
		{
		}

		private void CancelAdjustLowerCirclePositionTransformAnimation(Transform t)
		{
		}

		public void ReplaceReleaseObject()
		{
		}

		public void DestroyLockObject()
		{
		}

		public virtual void RotateCircle(float value)
		{
		}

		public virtual void MovePointToFront(int index)
		{
		}

		public void MovePointToFrontCounterClockWise(int index)
		{
		}

		public virtual void UpdateCircleRotation()
		{
		}

		private void StartCircleAdjustAnimation()
		{
		}

		private void OnCircleAnimationUpdate(float value)
		{
		}

		private void OnCircleAnimationComplete()
		{
		}

		public bool CanMovableUpDown()
		{
			return default(bool);
		}

		public void MoveUpCircle(float value)
		{
		}

		public void UpdateMoveUp()
		{
		}

		private void OnApplicationPause(bool pause)
		{
		}

		public void ForceMoveUp(float duration = 1.5f)
		{
		}

		public void ForceMoveUpToCircle(int index, float duration)
		{
		}

		public void ForceMoveUpByDeltaY(float deltaY, float duration)
		{
		}

		public void ForceMoveUpToMaxCircle(float duration)
		{
		}

		private void StartMoveUpAdjustAnimation(bool isNoBackingMode = false, bool isForceMove = false)
		{
		}

		private void OnMoveUpAnimationUpdate(float value, bool updateMoveY = true)
		{
		}

		public void SetMoveUp(float value, bool updateMoveY = true)
		{
		}

		private void OnMoveUpAnimationComplete()
		{
		}

		private void OnMoveUpForceAnimationComplete()
		{
		}

		private void OnMoveUpForceAnimationWithLimitZoomComplete()
		{
		}

		public void MoveRootObject(float deltaY, float duration)
		{
		}

		public virtual void LateUpdateCircle()
		{
		}

		public virtual bool ShouldPointDescDraw()
		{
			return default(bool);
		}

		public void KickAllReleasedTrigger()
		{
		}

		public void AllReleaseForDebug()
		{
		}

		public virtual void Reset()
		{
		}
	}
}
