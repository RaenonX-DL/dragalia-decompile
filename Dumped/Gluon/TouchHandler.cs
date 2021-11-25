using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

namespace Gluon
{
	public class TouchHandler : BaseRaycaster, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler, IEndDragHandler
	{
		private struct PointerData
		{
			public int pointerId;

			public Vector2 startPos;

			public float pointerDownTime;

			public Vector2 pointerDownPosition;

			public Vector2 position;

			public bool dragging;

			public List<Vector2> positions;
		}

		[SerializeField]
		[Header("component")]
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

		[SerializeField]
		[Header("parameter")]
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
		[Tooltip("ã\u0082¹ã\u0083\u00afã\u0082¤ã\u0083\u0097å\u0088¤å®\u009aæ\u0099\u0082é\u0096\u0093")]
		private float SwipeSec;

		[SerializeField]
		[Tooltip("ã\u0082¹ã\u0083\u00afã\u0082¤ã\u0083\u0097å\u0088¤å®\u009aè·\u009dé\u009b¢")]
		private float SwipeLength;

		[SerializeField]
		[Tooltip("ã\u0082\u00afã\u0082¤ã\u0083\u0083ã\u0082\u00afã\u0082¿ã\u0083¼ã\u0083³è·\u009dé\u009b¢é\u0096¾å\u0080¤")]
		private float quickTurnLength;

		[SerializeField]
		[Tooltip("ã\u0082\u00afã\u0082¤ã\u0083\u0083ã\u0082\u00afã\u0082¿ã\u0083¼ã\u0083³è§\u0092åº¦é\u0096¾å\u0080¤")]
		private float quickTurnAngle;

		[SerializeField]
		[Tooltip("ã\u0082\u00afã\u0082¤ã\u0083\u0083ã\u0082\u00afã\u0082µã\u0082¤ã\u0083\u0089ã\u0082¿ã\u0083¼ã\u0083³è·\u009dé\u009b¢é\u0096¾å\u0080¤")]
		private float quickSideTurnLength;

		[SerializeField]
		[Tooltip("ã\u0082\u00afã\u0082¤ã\u0083\u0083ã\u0082\u00afã\u0082µã\u0082¤ã\u0083\u0089ã\u0082¿ã\u0083¼ã\u0083³è§\u0092åº¦é\u0096¾å\u0080¤")]
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

		public static float avoidInputSec
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static float QuickTurnAngle
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public static float QuickSideTurnAngle
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public override Camera eventCamera => null;

		protected override void Awake()
		{
		}

		public void SetCamera(Camera uiCamera)
		{
		}

		public void SetFlickSensitivity()
		{
		}

		public void SetupClickButtonEffectSortingOrder()
		{
		}

		private void Update()
		{
		}

		private void CreateVirtualAxes()
		{
		}

		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		private float UpdateVirtualAxes(Vector3 value, Vector3 startPos)
		{
			return default(float);
		}

		public void OnPointerDown(PointerEventData data)
		{
		}

		public void OnPointerUp(PointerEventData data)
		{
		}

		public void OnDrag(PointerEventData data)
		{
		}

		private void SetLocalPosition(Transform trans, float x, float y, float z)
		{
		}

		public void OnEndDrag(PointerEventData data)
		{
		}

		public static bool CheckQuickTurnForAutoPlay(Vector3 prevDir, Vector3 currDir)
		{
			return default(bool);
		}

		private int FindPointerData(int pointerId)
		{
			return default(int);
		}

		private void SetPointerDataList(PointerData pointerData, int idx)
		{
		}

		private Vector2 Screen2Local(Vector2 spos)
		{
			return default(Vector2);
		}

		public void SetActiveUI(bool active)
		{
		}

		public void DisplayTap()
		{
		}

		public void DisplaySwipe()
		{
		}

		public void DisplayCharge(bool value)
		{
		}

		public void DisplayChargeEnd()
		{
		}

		private void OnStartCharge()
		{
		}

		private void OnUpdateCharge(float v)
		{
		}

		private void OnStartChargeEnd()
		{
		}

		private void OnUpdateChargeEnd(float v)
		{
		}

		private void OnCompleteChargeEnd()
		{
		}

		public void ResetInput()
		{
		}

		private void ResetCharge()
		{
		}

		public void InputBurst()
		{
		}

		private void ResetQuickTurn()
		{
		}

		public void DisplayEffectClickButton()
		{
		}

		private void OnEndClickButton(SpriteControlUI sender)
		{
		}

		protected override void OnDestroy()
		{
		}

		public bool IsMultiTouch()
		{
			return default(bool);
		}

		private void SetVisibleArrowBase(bool visible)
		{
		}

		private void SetVisibleArrow(bool visible)
		{
		}
	}
}
