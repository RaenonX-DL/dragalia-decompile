/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class TouchHandler : BaseRaycaster, IPointerDownHandler, IPointerUpHandler, IDragHandler, IEndDragHandler
	{
		// Fields
		[Header]
		[SerializeField]
		private Transform swipeRT;
		[SerializeField]
		private Transform tapRT;
		[SerializeField]
		private RectTransform chargeInRT;
		[SerializeField]
		private RectTransform chargeOutRT;
		[SerializeField]
		private GameObject visibleComponent;
		[SerializeField]
		private RectTransform clickButtonRt;
		[SerializeField]
		private SpriteControlUI clickButton;
		[SerializeField]
		private SpriteRenderer arrowBase;
		[SerializeField]
		private SpriteRenderer[] arrow;
		[SerializeField]
		private Sprite arrowSprtS;
		[SerializeField]
		private Sprite arrowSprtL;
		[Header]
		[SerializeField]
		private float movementRange;
		[SerializeField]
		private float movementRangeAdjust;
		[SerializeField]
		private float chargePullRange;
		[SerializeField]
		private float chargePullRangeAdjust;
		[SerializeField]
		private float tapAnimSec;
		[SerializeField]
		private float tapAnimScale;
		[SerializeField]
		private float swipeAnimSec;
		[SerializeField]
		private float swipeHeight;
		[SerializeField]
		private float arrowHeight;
		[SerializeField]
		private float thresholdMin;
		[SerializeField]
		private float correctiveValue;
		[SerializeField]
		private float arrowScaleMinX;
		[SerializeField]
		private float arrowScaleMinY;
		[SerializeField]
		private float arrowScaleLimit;
		[SerializeField]
		private float chargeAnimSec;
		[SerializeField]
		private float chargeAnimWaitSec;
		[SerializeField]
		private float chargeEndAnimSec;
		[SerializeField]
		private float ClickButtonAnimSec;
		[SerializeField]
		[Tooltip]
		private float SwipeSec;
		[SerializeField]
		[Tooltip]
		private float SwipeLength;
		[SerializeField]
		[Tooltip]
		private float quickTurnLength;
		[SerializeField]
		[Tooltip]
		private float quickTurnAngle;
		[SerializeField]
		[Tooltip]
		private float quickSideTurnLength;
		[SerializeField]
		[Tooltip]
		private float quickSideTurnAngle;
		private CrossPlatformInputManager.VirtualAxis horizontalVirtualAxis;
		private CrossPlatformInputManager.VirtualAxis verticalVirtualAxis;
		private CrossPlatformInputManager.VirtualAxis horizontalSwipe;
		private CrossPlatformInputManager.VirtualAxis verticalSwipe;
		private CrossPlatformInputManager.VirtualAxis horizontalCharge;
		private CrossPlatformInputManager.VirtualAxis verticalCharge;
		private CrossPlatformInputManager.VirtualAxis zoomPinch;
		private const int pointerMax = 2;
		private const float clickEffectScale = 2f;
		private const float movementRangeDefault = 100f;
		private const float chargePullRangeDefault = 100f;
		[CompilerGenerated]
		private static float _avoidInputSec_k__BackingField;
		[CompilerGenerated]
		private static float _QuickTurnAngle_k__BackingField;
		[CompilerGenerated]
		private static float _QuickSideTurnAngle_k__BackingField;
		private Camera uiCamera;
		private RectTransform parent;
		private SpriteRenderer swipeImage;
		private SpriteRenderer tapImage;
		private Image chargeInImage;
		private Image chargeOutImage;
		private Vector2 inputDelta;
		private Vector2 lastTapPos;
		private Vector2 lastSwipePos;
		private Vector2 lastSwipeVec;
		private Vector3 workPos;
		private float tapAnimLaps;
		private float swipeAnimLaps;
		private Tweener _chargeLoopTweener;
		private Tweener _chargeEndTweener;
		private VisibleUIObject chargeInVisible;
		private VisibleUIObject chargeOutVisible;
		private VisibleUIObject rootVisible;
		private OptionModel.Setting.GameSetting.SensorySetting sensorySetting;
		private static readonly float[] swipeLengthStep;
		private float currTime;
		private List<PointerData> pointerDataList;
		private int arrowVisibleCount;
		private int arrowTypeIndex;
		private readonly float[] arrowSize;
		private float lastDragTime;
		private float longestStaySec;
		private Vector2 longestStayPos;
	
		// Properties
		public static float avoidInputSec { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static float QuickTurnAngle { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public static float QuickSideTurnAngle { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public override Camera eventCamera { get; }
	
		// Nested types
		private struct PointerData
		{
			// Fields
			public int pointerId;
			public Vector2 startPos;
			public float pointerDownTime;
			public Vector2 pointerDownPosition;
			public Vector2 position;
			public bool dragging;
			public List<Vector2> positions;
		}
	
		// Constructors
		public TouchHandler();
		static TouchHandler();
	
		// Methods
		protected override void Awake();
		public void SetCamera(Camera uiCamera);
		public void SetFlickSensitivity();
		public void SetupClickButtonEffectSortingOrder();
		private void Update();
		private void CreateVirtualAxes();
		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);
		private float UpdateVirtualAxes(Vector3 value, Vector3 startPos);
		public void OnPointerDown(PointerEventData data);
		public void OnPointerUp(PointerEventData data);
		public void OnDrag(PointerEventData data);
		private void SetLocalPosition(Transform trans, float x, float y, float z);
		public void OnEndDrag(PointerEventData data);
		public static bool CheckQuickTurnForAutoPlay(Vector3 prevDir, Vector3 currDir);
		private int FindPointerData(int pointerId);
		private void SetPointerDataList(PointerData pointerData, int idx);
		private Vector2 Screen2Local(Vector2 spos);
		public void SetActiveUI(bool active);
		public void DisplayTap();
		public void DisplaySwipe();
		public void DisplayCharge(bool value);
		public void DisplayChargeEnd();
		private void OnStartCharge();
		private void OnUpdateCharge(float v);
		private void OnStartChargeEnd();
		private void OnUpdateChargeEnd(float v);
		private void OnCompleteChargeEnd();
		public void ResetInput();
		private void ResetCharge();
		public void InputBurst();
		private void ResetQuickTurn();
		public void DisplayEffectClickButton();
		private void OnEndClickButton(SpriteControlUI sender);
		protected override void OnDestroy();
		public bool IsMultiTouch();
		private void SetVisibleArrowBase(bool visible);
		private void SetVisibleArrow(bool visible);
	}
}
