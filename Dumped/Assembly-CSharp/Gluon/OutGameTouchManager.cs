/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class OutGameTouchManager : SingletonMonoBehaviour<Gluon.OutGameTouchManager>
	{
		// Fields
		private const float FLICK_SEC = 0.5f;
		private const float PREV_DRAG_SEC = 6f;
		private const float LONG_PRESS_SEC = 0.5f;
		private const float MIN_DRAG_LENGTH = 10f;
		private const float BAN_MOVE_VEC = 30f;
		public const int TOUCH_MAX = 2;
		private readonly Vector3 NONE_POS;
		private readonly eTouch[] TOUCH_TABLE;
		private BitArray _flag;
		[SerializeField]
		private Camera _camera;
		private TouchData[] _touchDatas;
		private Vector3 _touchFirstPos;
		private int _touchCount;
		private int _oldTouchCount;
		private int _layerMask;
		private float _draggingSec;
		private List<FlickParam> flickList;
		private List<TouchParam> touchList;
		[CompilerGenerated]
		private Action<PinchState> _pinchListener_k__BackingField;
		[CompilerGenerated]
		private bool _isIPhoneXSafeArea_k__BackingField;
	
		// Properties
		public Camera mainCamera { get; }
		public int touchCount { get; }
		public int layerMask { get; }
		public float draggingSec { get; }
		public Action<PinchState> pinchListener { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isIPhoneXSafeArea { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum eLayer
		{
			None = 0,
			UI = 32,
			All = 65535
		}
	
		private enum eFlag
		{
			Pinch = 0,
			FlickLeft = 1,
			FlickRight = 2,
			Drag = 3,
			PrevDrag = 4,
			PrevDragNoTime = 5,
			LongPress = 6,
			NotLongPress = 7,
			LayerMask = 8,
			Max = 9
		}
	
		public enum eTouch
		{
			None = 0,
			Press = 1,
			Down = 2,
			Up = 3,
			Stay = 4,
			Max = 5
		}
	
		public enum eFlick
		{
			LEFT = 0,
			RIGHT = 1
		}
	
		public enum PinchState
		{
			BEGIN = 0,
			PINCHING = 1,
			END = 2,
			START_DRAG = 3
		}
	
		public struct TouchData
		{
			// Fields
			public eTouch _type;
			public Vector3 _pos;
			public Vector3 _oldPos;
			public int _fingerID;
		}
	
		public class TouchParam
		{
			// Fields
			public bool isTouch;
			public BoxCollider collider;
			public Action callback;
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c
			{
				// Fields
				public static readonly __c __9;
				public static Action __9__3_0;
	
				// Constructors
				static __c();
				public __c();
	
				// Methods
				internal void _.ctor_b__3_0();
			}
	
			// Constructors
			public TouchParam(BoxCollider setCollider, Action setCallback);
		}
	
		public class FlickParam
		{
			// Fields
			public bool isTouch;
			public BoxCollider collider;
			public Action<eFlick> callback;
	
			// Nested types
			[Serializable]
			[CompilerGenerated]
			private sealed class __c
			{
				// Fields
				public static readonly __c __9;
				public static Action<eFlick> __9__3_0;
	
				// Constructors
				static __c();
				public __c();
	
				// Methods
				internal void _.ctor_b__3_0(eFlick _p0_);
			}
	
			// Constructors
			public FlickParam(BoxCollider setCollider, Action<eFlick> setCallback);
		}
	
		// Constructors
		public OutGameTouchManager();
	
		// Methods
		public void AddFlick(BoxCollider setCollider, Action<eFlick> setCallback);
		public void AddTouch(BoxCollider setCollider, Action setCallback);
		protected override void Awake();
		protected override void OnDestroy();
		private void Update();
		public void Reset();
		public void ResetView();
		private void InitParam();
		private void Mouse();
		public void Touch();
		private void Flick();
		private void Drag();
		private void CheckLayerMask();
		public void SetActive(bool active);
		public void InitLayerMask();
		public void SetLayerMask(int layerMask);
		public void SetMultiTouchOn();
		public void SetMultiTouchOff();
		private Vector3 GetVec();
		public float GetTouchLength();
		public float GetTouchLengthEx();
		public Vector3 GetTouchVec();
		public Vector3 GetFirstTouchVec();
		public float GetFirstTouchLength();
		public Vector3 GetTouchPos(int index = 0);
		public int GetTouchFingerId(int index = 0);
		public eTouch GetState(int index);
		public bool IsNone();
		public bool IsPress();
		public bool IsDown();
		public bool IsUp();
		public bool IsStay();
		public bool IsFlickLeft();
		public bool IsFlickRight();
		public bool IsPinch();
		public bool IsDrag();
		public bool IsPrevDrag();
		public bool IsPrevDragNoTime();
		public bool IsLongPress();
		public bool IsNotLongPress();
	}
}
