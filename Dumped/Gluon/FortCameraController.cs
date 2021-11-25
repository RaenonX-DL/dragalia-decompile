using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gluon
{
	public class FortCameraController : FastUpdateMonoBehaviour, FortCameraEventInterface, IEventSystemHandler
	{
		public enum CameraState
		{
			None,
			Static,
			Dragging,
			AfterDragging,
			Zooming,
			AfterZooming,
			Cropping
		}

		[Serializable]
		private struct DistanceBlurSetting
		{
			public float distStart;

			public float distEnd;

			public float blurAreaStart;

			public float blurAreaEnd;
		}

		[Serializable]
		private struct PointIrisSetting
		{
			public Transform[] targets;

			public int[] maxLevels;

			public float[] widths;

			public float[] heights;
		}

		private const float FOCUS_ANIM_DURATION = 0.5f;

		private const float FOCUS_ANIM_ZOOM_FORWARD_VALUE = 10f;

		private const float FOCUS_ANIM_WAIT_TIME = 1f;

		private float oldDeltaDis;

		[SerializeField]
		[Header("ã\u0082«ã\u0083¡ã\u0083©ã\u0081\u008cä\u00b8\u0080ç\u0095ªè¿\u0091ã\u0081\u0084æ\u0099\u0082ã\u0080\u0081å·¦ä\u00b8\u008bã\u0082¿ã\u0082²ã\u0083\u0083ã\u0083\u0088ç\u0082¹")]
		public Vector2 viewLeftBottomPosMinDistance;

		[SerializeField]
		[Header("ã\u0082«ã\u0083¡ã\u0083©ã\u0081\u008cä\u00b8\u0080ç\u0095ªè¿\u0091ã\u0081\u0084æ\u0099\u0082ã\u0080\u0081å\u008f³ä\u00b8\u008aã\u0082¿ã\u0082²ã\u0083\u0083ã\u0083\u0088ç\u0082¹")]
		public Vector2 viewRightUpPosMinDistance;

		[SerializeField]
		[Header("ã\u0082«ã\u0083¡ã\u0083©ã\u0081\u008cä\u00b8\u0080ç\u0095ªé\u0081\u00a0ã\u0081\u0084æ\u0099\u0082ã\u0080\u0081å·¦ä\u00b8\u008bã\u0082¿ã\u0082²ã\u0083\u0083ã\u0083\u0088ç\u0082¹")]
		public Vector2 viewLeftBottomPosMaxDistance;

		[SerializeField]
		[Header("ã\u0082«ã\u0083¡ã\u0083©ã\u0081\u008cä\u00b8\u0080ç\u0095ªé\u0081\u00a0ã\u0081\u0084æ\u0099\u0082ã\u0080\u0081å\u008f³ä\u00b8\u008aã\u0082¿ã\u0082²ã\u0083\u0083ã\u0083\u0088ç\u0082¹")]
		public Vector2 viewRightUpPosMaxDistance;

		private Vector2 curViewLeftBottomPos;

		private Vector2 curViewRightUpPos;

		private Tweener moveIn;

		private Tweener targetIn;

		[SerializeField]
		private Transform target;

		private Vector3 focusTargetPos;

		[SerializeField]
		[Header("X: æ\u009c\u0080å°\u008fè·\u009dé\u009b¢ã\u0080\u0080Y: æ\u009c\u0080å¤§è·\u009dé\u009b¢")]
		public Vector2 distanceRange;

		public float distance;

		public float focusDistance;

		private Vector3 originalPos;

		private Vector3 touchDownPos;

		[SerializeField]
		[Header("SceneInå¾\u008cã\u0081®ã\u0082«ã\u0083¡ã\u0083©ã\u0081®ä½\u008dç½® 0: å\u0088\u009då\u009b\u009e 1: é\u0080\u009aå\u00b8\u00b8 2:é\u008d\u009bå\u0086¶å±\u008b")]
		public Vector3[] cameraPosAfterSceneIn;

		[SerializeField]
		[Header("ã\u0082«ã\u0083¡ã\u0083©å\u0080\u0092ã\u0082\u008cã\u0081\u00afã\u0081\u0098ã\u0082\u0081ã\u0081®è·\u009dé\u009b¢")]
		public float distanceCameraFall;

		[SerializeField]
		[Header("ã\u0082«ã\u0083¡ã\u0083©SceneIn Animationå\u0089\u008dã\u0081®è·\u009dé\u009b¢ X: å\u0088\u009då\u009b\u009e Y: é\u0080\u009aå\u00b8\u00b8")]
		public Vector2 distanceBeforeSceneInAnimation;

		[SerializeField]
		[Header("SceneIn animation duration")]
		public Vector2 sceneInDuration;

		[SerializeField]
		[Header("SceneIn ShowDragon Delay")]
		private float sceneInShowDragonDelay;

		[SerializeField]
		[Header("SceneInå¾\u008c ã\u0082«ã\u0083¡ã\u0083©ã\u0081®rotation")]
		public Vector3 cameraRotationAfterSceneIn;

		private GameObject currentFocusAnimTarget;

		[SerializeField]
		[Header("Dragæ\u0099\u0082ã\u0082«ã\u0083¡ã\u0083©å\u008b\u0095ã\u0081\u008fé\u0080\u009fåº¦")]
		public float dragFollowSpeed;

		[SerializeField]
		[Header("Zoomæ\u0099\u0082ã\u0082«ã\u0083¡ã\u0083©å\u008b\u0095ã\u0081\u008fé\u0080\u009fåº¦")]
		public float zoomFollowSpeed;

		public float mouseScrollWheelSpeed;

		private bool _canTouch;

		[SerializeField]
		[Header("ã\u0082«ã\u0083¡ã\u0083©å\u0080\u0092ã\u0082\u008cã\u0082\u008bæ\u009c\u0080å¤§ã\u0081®è·\u009dé\u009b¢")]
		public float maxDeltaY;

		[SerializeField]
		[Header("ã\u0082«ã\u0083¡ã\u0083©ã\u0081\u008cç\u00af\u0084å\u009b²å¤\u0096ã\u0081«ã\u0081\u0082ã\u0081£ã\u0081\u009fã\u0082\u0089æ\u0088»ã\u0082\u008bæ\u0099\u0082é\u0096\u0093")]
		private float scrollBackDuration;

		private SmoothMove smoothMove;

		[SerializeField]
		[Header("ã\u0082«ã\u0083¡ã\u0083©ã\u0081\u008cç\u00af\u0084å\u009b²å¤\u0096ã\u0081«ã\u0081\u0082ã\u0082\u008bè·\u009dé\u009b¢")]
		private float outRangeDistance;

		private const float zoomThresholdValueMax = 400f;

		private StandaloneInputModuleCustom inputModule;

		private Sequence sequence;

		private Plane plane;

		private float distToPlane;

		private Ray rayToPlane;

		private FortAreaExtensionController _areaExtensionController;

		private bool isStartToDrag;

		[SerializeField]
		[Header("ã\u0083\u0095ã\u0082©ã\u0082°é\u0096¢é\u0080£")]
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

		[SerializeField]
		[Header("TiltShifté\u0096¢é\u0080£")]
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

		public CameraState cameraState
		{
			[CompilerGenerated]
			get
			{
				return default(CameraState);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 targetPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public bool isSelectedUI
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isSelectedFacility
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isProdctFaciliy
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool isPullMenuButtonPressed
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public FortScene fortScene
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

		public bool canTouch
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool autoFollow
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Vector3 originalDirTargetToCamera
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public float zoomThresholdValue
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public float dragThresholdValue
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private Vector3 previousScreenPos
		{
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public FortAreaExtensionController areaExtensionController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void OnInit(FortScene scene)
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public void UpdateCamera()
		{
		}

		public void RunSceneInAnimation()
		{
		}

		public void CameraInAnimationStart()
		{
		}

		private IEnumerator ShowTutorialSceneInDragon()
		{
			return null;
		}

		public void OnSceneInFinished()
		{
		}

		private void Drag()
		{
		}

		private bool IsSelectFacilityCanceled()
		{
			return default(bool);
		}

		private void UpdateDragBegin()
		{
		}

		public bool GetTouchDownPos(Vector3 screenPos, out Vector3 pos)
		{
			return default(bool);
		}

		private void UpdateDragging()
		{
		}

		private void UpdateDragEnd()
		{
		}

		private void UpdateTouchUp()
		{
		}

		private void Pinch(OutGameTouchManager.PinchState pinchState)
		{
		}

		private void PinchForDevice(OutGameTouchManager.PinchState pinchState)
		{
		}

		private void UpdateTiltShiftSetting()
		{
		}

		private void RefrectPointIrisSetting(PointIrisSetting[] settings, int startIndex = 0)
		{
		}

		private void Zoom(float deltaDistance)
		{
		}

		private void UpdateAfterZooming()
		{
		}

		private void RefreshDistToPlane()
		{
		}

		private void ZoomCamera(float deltaDistance)
		{
		}

		private bool IsZooming()
		{
			return default(bool);
		}

		public void MoveToTargetPos(GameObject focusTarget, float duration, [Optional] Action onCompleted, bool isEnableDragOnComplete = true)
		{
		}

		void FortCameraEventInterface.OnFacilityBuildFnishedAnimStart(GameObject focusTarget, Facility.eFacilityStatus status)
		{
		}

		public void OnFinishedBuild(GameObject focusTarget, Facility.eFacilityStatus status)
		{
		}

		private void OnFinishCompleteBuildAnimation(GameObject facilityObj, bool playSlideIn)
		{
		}

		private void ShowTutorialWindow()
		{
		}

		void FortCameraEventInterface.OnMainFacilityLevelUpFnishedAnimStart(GameObject focusTarget, FacilityViewController facilityViewController)
		{
		}

		public void OnFinishedMainFacilityFocusReverseAnim()
		{
		}

		private void UpdateCameraPosition(Vector3 aimPos)
		{
		}

		public Vector3 SetTargetPosition(Vector3 position)
		{
			return default(Vector3);
		}

		public Vector3 CalculateCameraTargetPos(Vector3 targetPos, float distanceFromTargetToCamera)
		{
			return default(Vector3);
		}

		private Vector3 CalculateCameraFocusPoint(Vector3 cameraPos)
		{
			return default(Vector3);
		}

		public Vector3 CalculateCameraTargetPos()
		{
			return default(Vector3);
		}

		public bool IsSelectedFacility()
		{
			return default(bool);
		}

		public bool IsSelectedProcutFacility()
		{
			return default(bool);
		}

		public bool IsSelectedUI()
		{
			return default(bool);
		}

		private void RefreshViewRect()
		{
		}

		private float CalculateViewRectValue(float factor, float valueMinDistance, float valueMaxDistance)
		{
			return default(float);
		}

		private float GetDistanceFromFogTarget()
		{
			return default(float);
		}

		private void ApplyBgFade()
		{
		}

		private void Tutorial_2_6_2()
		{
		}

		private IEnumerator Tutorial_2_6_2_Coroutine()
		{
			return null;
		}

		public float AcquireMagnification()
		{
			return default(float);
		}
	}
}
