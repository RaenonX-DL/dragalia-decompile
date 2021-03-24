/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FortCameraController : FastUpdateMonoBehaviour, FortCameraEventInterface
	{
		// Fields
		[CompilerGenerated]
		private CameraState _cameraState_k__BackingField;
		private const float FOCUS_ANIM_DURATION = 0.5f;
		private const float FOCUS_ANIM_ZOOM_FORWARD_VALUE = 10f;
		private const float FOCUS_ANIM_WAIT_TIME = 1f;
		private float oldDeltaDis;
		[Header]
		[SerializeField]
		public Vector2 viewLeftBottomPosMinDistance;
		[Header]
		[SerializeField]
		public Vector2 viewRightUpPosMinDistance;
		[Header]
		[SerializeField]
		public Vector2 viewLeftBottomPosMaxDistance;
		[Header]
		[SerializeField]
		public Vector2 viewRightUpPosMaxDistance;
		private Vector2 curViewLeftBottomPos;
		private Vector2 curViewRightUpPos;
		private Tweener moveIn;
		private Tweener targetIn;
		[SerializeField]
		private Transform target;
		private Vector3 focusTargetPos;
		[Header]
		[SerializeField]
		public Vector2 distanceRange;
		public float distance;
		public float focusDistance;
		private Vector3 originalPos;
		private Vector3 touchDownPos;
		[Header]
		[SerializeField]
		public Vector3[] cameraPosAfterSceneIn;
		[Header]
		[SerializeField]
		public float distanceCameraFall;
		[Header]
		[SerializeField]
		public Vector2 distanceBeforeSceneInAnimation;
		[Header]
		[SerializeField]
		public Vector2 sceneInDuration;
		[Header]
		[SerializeField]
		private float sceneInShowDragonDelay;
		[Header]
		[SerializeField]
		public Vector3 cameraRotationAfterSceneIn;
		private GameObject currentFocusAnimTarget;
		[Header]
		[SerializeField]
		public float dragFollowSpeed;
		[Header]
		[SerializeField]
		public float zoomFollowSpeed;
		public float mouseScrollWheelSpeed;
		[CompilerGenerated]
		private bool _isSelectedUI_k__BackingField;
		[CompilerGenerated]
		private bool _isSelectedFacility_k__BackingField;
		[CompilerGenerated]
		private bool _isProdctFaciliy_k__BackingField;
		[CompilerGenerated]
		private bool _isPullMenuButtonPressed_k__BackingField;
		[CompilerGenerated]
		private FortScene _fortScene_k__BackingField;
		private bool _canTouch;
		[CompilerGenerated]
		private bool _autoFollow_k__BackingField;
		[Header]
		[SerializeField]
		public float maxDeltaY;
		[CompilerGenerated]
		private Vector3 _originalDirTargetToCamera_k__BackingField;
		[Header]
		[SerializeField]
		private float scrollBackDuration;
		private SmoothMove smoothMove;
		[Header]
		[SerializeField]
		private float outRangeDistance;
		[CompilerGenerated]
		private float _zoomThresholdValue_k__BackingField;
		[CompilerGenerated]
		private float _dragThresholdValue_k__BackingField;
		private const float zoomThresholdValueMax = 400f;
		[CompilerGenerated]
		private Vector3 _previousScreenPos_k__BackingField;
		private StandaloneInputModuleCustom inputModule;
		private Sequence sequence;
		private Plane plane;
		private float distToPlane;
		private Ray rayToPlane;
		private FortAreaExtensionController _areaExtensionController;
		private bool isStartToDrag;
		[Header]
		[SerializeField]
		private GameObject fogTarget;
		[SerializeField]
		private float easingFogChangeModulus;
		[SerializeField]
		private float minFog;
		[SerializeField]
		private Color fogColor;
		[SerializeField]
		private float fogStartDistance;
		[SerializeField]
		private float fogEndDistance;
		[SerializeField]
		private Color bgFadeColor;
		[Header]
		[SerializeField]
		private DistanceBlurSetting[] distanceBlurSettings;
		[SerializeField]
		private float xzDistModulus;
		[SerializeField]
		private PointIrisSetting[] castlePointIrisSettings;
		[SerializeField]
		private PointIrisSetting[] dragonStagePointIrisSettings;
		private PostEffect fortPostEffect;
		private Vector3 pivot;
		private Transform cachedTransform;
		private bool isReflectTiltSettings;
		private List<RaycastResult> raycastResultCache;
		private PointerEventData pointerData;
	
		// Properties
		public CameraState cameraState { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Vector3 targetPosition { get; set; }
		public bool isSelectedUI { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isSelectedFacility { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isProdctFaciliy { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isPullMenuButtonPressed { [CompilerGenerated] get; [CompilerGenerated] set; }
		public FortScene fortScene { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool canTouch { get; set; }
		public bool autoFollow { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 originalDirTargetToCamera { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float zoomThresholdValue { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float dragThresholdValue { [CompilerGenerated] get; [CompilerGenerated] set; }
		private Vector3 previousScreenPos { [CompilerGenerated] get; [CompilerGenerated] set; }
		public FortAreaExtensionController areaExtensionController { get; set; }
	
		// Nested types
		public enum CameraState
		{
			None = 0,
			Static = 1,
			Dragging = 2,
			AfterDragging = 3,
			Zooming = 4,
			AfterZooming = 5,
			Cropping = 6
		}
	
		[Serializable]
		private struct DistanceBlurSetting
		{
			// Fields
			public float distStart;
			public float distEnd;
			public float blurAreaStart;
			public float blurAreaEnd;
		}
	
		[Serializable]
		private struct PointIrisSetting
		{
			// Fields
			public Transform[] targets;
			public int[] maxLevels;
			public float[] widths;
			public float[] heights;
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass121_0
		{
			// Fields
			public FlashPlayer flashPlayerDragon;
	
			// Constructors
			public __c__DisplayClass121_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass121_1
		{
			// Fields
			public bool isFlashInAnimFinished;
			public __c__DisplayClass121_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass121_1();
	
			// Methods
			internal void _ShowTutorialSceneInDragon_b__0();
			internal void _ShowTutorialSceneInDragon_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _ShowTutorialSceneInDragon_d__121 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FortCameraController __4__this;
			private __c__DisplayClass121_1 __8__1;
			private string _flashPath_5__2;
			private GameObject _fortTutorialObj_5__3;
			private GameObject _obj_5__4;
			private CanvasGroup _textCanvasGroup_5__5;
			private Canvas _fortTutorialCanvas_5__6;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ShowTutorialSceneInDragon_d__121(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass139_0
		{
			// Fields
			public FortCameraController __4__this;
			public GameObject focusTarget;
			public Action onCompleted;
			public bool isEnableDragOnComplete;
	
			// Constructors
			public __c__DisplayClass139_0();
	
			// Methods
			internal void _MoveToTargetPos_b__0();
			internal void _MoveToTargetPos_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass141_0
		{
			// Fields
			public GameObject focusTarget;
			public FortCameraController __4__this;
	
			// Constructors
			public __c__DisplayClass141_0();
	
			// Methods
			internal void _OnFinishedBuild_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static ExecuteEvents.EventFunction<FacilityEventInterface> __9__141_1;
			public static ExecuteEvents.EventFunction<FacilityEventInterface> __9__144_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _OnFinishedBuild_b__141_1(FacilityEventInterface reciever, BaseEventData eventData);
			internal void _OnFinishedMainFacilityFocusReverseAnim_b__144_0(FacilityEventInterface reciever, BaseEventData eventData);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass143_0
		{
			// Fields
			public FortCameraController __4__this;
			public GameObject focusTarget;
			public FacilityViewController facilityViewController;
	
			// Constructors
			public __c__DisplayClass143_0();
	
			// Methods
			internal void _Gluon.FortCameraEventInterface.OnMainFacilityLevelUpFnishedAnimStart_b__0();
			internal void _Gluon.FortCameraEventInterface.OnMainFacilityLevelUpFnishedAnimStart_b__1();
		}
	
		[CompilerGenerated]
		private sealed class _Tutorial_2_6_2_Coroutine_d__158 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public FortCameraController __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Tutorial_2_6_2_Coroutine_d__158(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public FortCameraController();
	
		// Methods
		public void OnInit(FortScene scene);
		private void OnDestroy();
		private void Update();
		public void UpdateCamera();
		public void RunSceneInAnimation();
		public void CameraInAnimationStart();
		[IteratorStateMachine]
		private IEnumerator ShowTutorialSceneInDragon();
		public void OnSceneInFinished();
		private void Drag();
		private bool IsSelectFacilityCanceled();
		private void UpdateDragBegin();
		public bool GetTouchDownPos(Vector3 screenPos, out Vector3 pos);
		private void UpdateDragging();
		private void UpdateDragEnd();
		private void UpdateTouchUp();
		private void Pinch(OutGameTouchManager.PinchState pinchState);
		private void PinchForDevice(OutGameTouchManager.PinchState pinchState);
		private void UpdateTiltShiftSetting();
		private void RefrectPointIrisSetting(PointIrisSetting[] settings, int startIndex = 0);
		private void Zoom(float deltaDistance);
		private void UpdateAfterZooming();
		private void RefreshDistToPlane();
		private void ZoomCamera(float deltaDistance);
		private bool IsZooming();
		public void MoveToTargetPos(GameObject focusTarget, float duration, Action onCompleted = null, bool isEnableDragOnComplete = true);
		void FortCameraEventInterface.OnFacilityBuildFnishedAnimStart(GameObject focusTarget, Facility.eFacilityStatus status);
		public void OnFinishedBuild(GameObject focusTarget, Facility.eFacilityStatus status);
		private void ShowTutorialWindow();
		void FortCameraEventInterface.OnMainFacilityLevelUpFnishedAnimStart(GameObject focusTarget, FacilityViewController facilityViewController);
		public void OnFinishedMainFacilityFocusReverseAnim();
		private void UpdateCameraPosition(Vector3 aimPos);
		public Vector3 SetTargetPosition(Vector3 position);
		public Vector3 CalculateCameraTargetPos(Vector3 targetPos, float distanceFromTargetToCamera);
		private Vector3 CalculateCameraFocusPoint(Vector3 cameraPos);
		public Vector3 CalculateCameraTargetPos();
		public bool IsSelectedFacility();
		public bool IsSelectedProcutFacility();
		public bool IsSelectedUI();
		private void RefreshViewRect();
		private float CalculateViewRectValue(float factor, float valueMinDistance, float valueMaxDistance);
		private float GetDistanceFromFogTarget();
		private void ApplyBgFade();
		private void Tutorial_2_6_2();
		[IteratorStateMachine]
		private IEnumerator Tutorial_2_6_2_Coroutine();
		public float AcquireMagnification();
		[CompilerGenerated]
		private void _RunSceneInAnimation_b__119_0();
		[CompilerGenerated]
		private void _RunSceneInAnimation_b__119_1();
		[CompilerGenerated]
		private void _Tutorial_2_6_2_b__157_0();
		[CompilerGenerated]
		private void _Tutorial_2_6_2_Coroutine_b__158_0();
	}
}
