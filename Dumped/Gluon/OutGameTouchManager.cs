using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class OutGameTouchManager : SingletonMonoBehaviour<OutGameTouchManager>
	{
		public enum eLayer
		{
			None = 0,
			UI = 0x20,
			All = 0xFFFF
		}

		private enum eFlag
		{
			Pinch,
			FlickLeft,
			FlickRight,
			Drag,
			PrevDrag,
			PrevDragNoTime,
			LongPress,
			NotLongPress,
			LayerMask,
			Max
		}

		public enum eTouch
		{
			None,
			Press,
			Down,
			Up,
			Stay,
			Max
		}

		public enum eFlick
		{
			LEFT,
			RIGHT
		}

		public enum PinchState
		{
			BEGIN,
			PINCHING,
			END,
			START_DRAG
		}

		public struct TouchData
		{
			public eTouch _type;

			public Vector3 _pos;

			public Vector3 _oldPos;

			public int _fingerID;
		}

		public class TouchParam
		{
			public bool isTouch;

			public BoxCollider collider;

			public Action callback;

			public TouchParam(BoxCollider setCollider, Action setCallback)
			{
			}
		}

		public class FlickParam
		{
			public bool isTouch;

			public BoxCollider collider;

			public Action<eFlick> callback;

			public FlickParam(BoxCollider setCollider, Action<eFlick> setCallback)
			{
			}
		}

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

		public Camera mainCamera => null;

		public int touchCount => default(int);

		public int layerMask => default(int);

		public float draggingSec => default(float);

		public Action<PinchState> pinchListener
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

		public bool isIPhoneXSafeArea
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

		public void AddFlick(BoxCollider setCollider, Action<eFlick> setCallback)
		{
		}

		public void AddTouch(BoxCollider setCollider, Action setCallback)
		{
		}

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public void Reset()
		{
		}

		public void ResetView()
		{
		}

		private void InitParam()
		{
		}

		private void Mouse()
		{
		}

		public void Touch()
		{
		}

		private void Flick()
		{
		}

		private void Drag()
		{
		}

		private void CheckLayerMask()
		{
		}

		public void SetActive(bool active)
		{
		}

		public void InitLayerMask()
		{
		}

		public void SetLayerMask(int layerMask)
		{
		}

		public void SetMultiTouchOn()
		{
		}

		public void SetMultiTouchOff()
		{
		}

		private Vector3 GetVec()
		{
			return default(Vector3);
		}

		public float GetTouchLength()
		{
			return default(float);
		}

		public float GetTouchLengthEx()
		{
			return default(float);
		}

		public Vector3 GetTouchVec()
		{
			return default(Vector3);
		}

		public Vector3 GetFirstTouchVec()
		{
			return default(Vector3);
		}

		public float GetFirstTouchLength()
		{
			return default(float);
		}

		public Vector3 GetTouchPos(int index = 0)
		{
			return default(Vector3);
		}

		public int GetTouchFingerId(int index = 0)
		{
			return default(int);
		}

		public eTouch GetState(int index)
		{
			return default(eTouch);
		}

		public bool IsNone()
		{
			return default(bool);
		}

		public bool IsPress()
		{
			return default(bool);
		}

		public bool IsDown()
		{
			return default(bool);
		}

		public bool IsUp()
		{
			return default(bool);
		}

		public bool IsStay()
		{
			return default(bool);
		}

		public bool IsFlickLeft()
		{
			return default(bool);
		}

		public bool IsFlickRight()
		{
			return default(bool);
		}

		public bool IsPinch()
		{
			return default(bool);
		}

		public bool IsDrag()
		{
			return default(bool);
		}

		public bool IsPrevDrag()
		{
			return default(bool);
		}

		public bool IsPrevDragNoTime()
		{
			return default(bool);
		}

		public bool IsLongPress()
		{
			return default(bool);
		}

		public bool IsNotLongPress()
		{
			return default(bool);
		}
	}
}
