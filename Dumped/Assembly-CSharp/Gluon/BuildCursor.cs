/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BuildCursor : FastUpdateMonoBehaviour
	{
		// Fields
		public static Color AREA_PANEL_PUT_ENABLE_COLOR;
		public static Color AREA_PANEL_PUT_DISABLE_COLOR;
		private static float ANIMATION_SPPED_THRESHOLD;
		private static float ANIMAION_ACCEL;
		public static float CURSOR_SIZE_UNIT_DIFF;
		[CompilerGenerated]
		private int _cursorSize_k__BackingField;
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
		[Header]
		[SerializeField]
		public float cameraFollowSpeed;
		private Vector3 oldWorldTouchPos;
		[CompilerGenerated]
		private GameObject _showingObj_k__BackingField;
		[CompilerGenerated]
		private bool _isShowingObjFacility_k__BackingField;
		public bool isBlockMoveCursor;
		[CompilerGenerated]
		private FortSortingOrderSetter[] _sortingOrderSetters_k__BackingField;
		public Vector2 _gridPosition;
	
		// Properties
		public int cursorSize { [CompilerGenerated] get; [CompilerGenerated] set; }
		public GameObject cursor2d { get; }
		public GameObject showingObj { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isShowingObjFacility { [CompilerGenerated] get; [CompilerGenerated] set; }
		public FortSortingOrderSetter[] sortingOrderSetters { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector2 gridPosition { get; set; }
	
		// Nested types
		private enum State
		{
			None = 0,
			WarpWatching = 1,
			OnDown = 2,
			OnDrag = 3,
			OnLockingPos = 4
		}
	
		public delegate void positionChangeDelegate();
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass77_0
		{
			// Fields
			public BuildCursor __4__this;
			public float goal;
			public float start;
			public float duration;
	
			// Constructors
			public __c__DisplayClass77_0();
	
			// Methods
			internal void _StartPingPongChageColor_b__0(float blendValue);
			internal void _StartPingPongChageColor_b__1();
		}
	
		// Constructors
		public BuildCursor();
		static BuildCursor();
	
		// Methods
		public void AddPositionChangeCallback(positionChangeDelegate callback);
		public void OnInit(FortScene curScene);
		private void Update();
		public void DisableMoveAtOnce();
		public void SetLockingCurPos(bool value);
		private void UpdateCursorAnimation();
		public Vector3 GetLeftTopGridOffset();
		private Vector3 GetArrowLocalPosition(int curSize, int arrowIndex);
		public void UpdateCursorSize(int curSize);
		public void StartToDrag();
		private void OnMouseDown();
		private void OnMouseDrag();
		private void OnMouseExit();
		private void OnMouseEnter();
		private void OnMouseUp();
		private Vector3 GetTouchDownPosition();
		private Vector3 GetWorldPositionInPlane(Vector3 touchPos);
		public void SetPlaneInPosition(float y);
		public void UpdateCursor();
		public void UpdateBuildCoursorColor();
		public void SetShowingObject(GameObject go, bool isFacilityObj);
		private void StartPingPongChageColor(float start, float goal, float duration);
		private void SetFacilityTintColor(float blendValue);
		public void SetPosition(Vector3 pos);
		public void SetLocalPosition(Vector3 pos);
	}
}
