using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class BuildCursor : FastUpdateMonoBehaviour
	{
		private enum State
		{
			None,
			WarpWatching,
			OnDown,
			OnDrag,
			OnLockingPos
		}

		public delegate void positionChangeDelegate();

		public static Color AREA_PANEL_PUT_ENABLE_COLOR;

		public static Color AREA_PANEL_PUT_DISABLE_COLOR;

		private static float ANIMATION_SPPED_THRESHOLD;

		private static float ANIMAION_ACCEL;

		public static float CURSOR_SIZE_UNIT_DIFF;

		private Vector3 originalTouchScreenPos;

		private Vector3[] arrowDirection;

		private List<Vector3> defaultArrowPosition;

		[SerializeField]
		private GameObject[] arrows;

		private GameObject _cursor2d;

		private Plane plane;

		public GameObject areaPanel;

		[SerializeField]
		private GameObject previewFacilityNode;

		private float animSpeed;

		private float animAccel;

		private bool onMouse;

		private const float MOVE_THRESHOLD_FACTOR_HEIGHT = 0.8f;

		private const float MOVE_THRESHOLD_FACTOR_WIDTH = 0.9f;

		private Rect cameraMoveThresholdRect;

		private positionChangeDelegate positionChangeCallbacks;

		private FortScene fortScene;

		private Vector3 originalTouchPos;

		private Vector3 oldTouchPos;

		private Vector3 moveDirection;

		private Vector3 originalCursorLocalPos;

		private Vector2 oldGridPosition;

		private Color facilityTintColor;

		private List<Renderer> facilityRendererList;

		private State curState;

		[SerializeField]
		[Header("æ\u0096½è\u00a8­ç§»å\u008b\u0095ã\u0081\u0099ã\u0082\u008bã\u0081\u00a8ã\u0081\u008dã\u0080\u0081å¤\u0096ã\u0081«ã\u0081§ã\u0082\u0088ã\u0081\u0086ã\u0081\u00a8ã\u0081\u0097ã\u0081\u009fã\u0082\u0089ã\u0080\u0081ã\u0082«ã\u0083¡ã\u0083©ã\u0082\u0092ä»\u0098ã\u0081\u0084ã\u0081¦ã\u0081\u0084ã\u0081\u008fé\u0080\u009fåº¦")]
		public float cameraFollowSpeed;

		private Vector3 oldWorldTouchPos;

		public bool isBlockMoveCursor;

		public Vector2 _gridPosition;

		public int cursorSize
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public GameObject cursor2d => null;

		public GameObject showingObj
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

		public bool isShowingObjFacility
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

		public FortSortingOrderSetter[] sortingOrderSetters
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

		public Vector2 gridPosition
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public void AddPositionChangeCallback(positionChangeDelegate callback)
		{
		}

		public void OnInit(FortScene curScene)
		{
		}

		private void Update()
		{
		}

		public void DisableMoveAtOnce()
		{
		}

		public void SetLockingCurPos(bool value)
		{
		}

		private void UpdateCursorAnimation()
		{
		}

		public Vector3 GetLeftTopGridOffset()
		{
			return default(Vector3);
		}

		private Vector3 GetArrowLocalPosition(int curSize, int arrowIndex)
		{
			return default(Vector3);
		}

		public void UpdateCursorSize(int curSize)
		{
		}

		public void StartToDrag()
		{
		}

		private void OnMouseDown()
		{
		}

		private void OnMouseDrag()
		{
		}

		private void OnMouseExit()
		{
		}

		private void OnMouseEnter()
		{
		}

		private void OnMouseUp()
		{
		}

		private Vector3 GetTouchDownPosition()
		{
			return default(Vector3);
		}

		private Vector3 GetWorldPositionInPlane(Vector3 touchPos)
		{
			return default(Vector3);
		}

		public void SetPlaneInPosition(float y)
		{
		}

		public void UpdateCursor()
		{
		}

		public void UpdateBuildCoursorColor()
		{
		}

		public void SetShowingObject(GameObject go, bool isFacilityObj)
		{
		}

		private void StartPingPongChageColor(float start, float goal, float duration)
		{
		}

		private void SetFacilityTintColor(float blendValue)
		{
		}

		public void SetPosition(Vector3 pos)
		{
		}

		public void SetLocalPosition(Vector3 pos)
		{
		}
	}
}
