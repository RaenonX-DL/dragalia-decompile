using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace FLATOUT.Main.Utility
{
	public class FlTouchInput : FlInputBase
	{
		private Vector3 _startFixScreenPosition;

		private Vector3 _currentFixScreenPosition;

		private Vector3 _prevFixScreenPosition;

		private Vector3 _currentFixScreenDirection;

		private float _currentFixScreenSpeed;

		private float _prevFixScreenSpeed;

		private float _currentFixScreenAccel;

		private Vector3 _startScreenPosition;

		private Vector3 _currentScreenPosition;

		private Vector3 _prevScreenPosition;

		private Vector3 _currentScreenDirection;

		private float _currentScreenSpeed;

		private float _prevScreenSpeed;

		private float _currentScreenAccel;

		private float _startDownTime;

		private float _currentDownTime;

		private float _prevDownTime;

		public List<Vector3> _fixScreenPositionList;

		public List<Vector3> _fixScreenDirectionList;

		public List<float> _fixScreenSpeedList;

		public List<float> _fixScreenAccelList;

		public List<Vector3> _screenPositionList;

		public List<Vector3> _screenDirectionList;

		public List<float> _screenSpeedList;

		public List<float> _screenAccelList;

		private int _listCapacity;

		public Vector3 CurrentFixScreenPosition => default(Vector3);

		public Vector3 StartFixScreenPosition => default(Vector3);

		public Vector3 CurrentScreenPosition => default(Vector3);

		public Vector3 StartScreenPosition => default(Vector3);

		public float CurrentFixScreenSpeed => default(float);

		public float CurrentFixScreenAccel => default(float);

		public Vector3 FixScreenVectorFromStart => default(Vector3);

		public Vector3 FixScreenNormalizeVectorFromStart => default(Vector3);

		public float FixScreenDistanceFromStart => default(float);

		public Vector3 AvarageFixScreenPosition => default(Vector3);

		public Vector3 AvarageScreenPosition => default(Vector3);

		public Vector3 AvarageFixScreenDirection => default(Vector3);

		public Vector3 AvarageScreenDirection => default(Vector3);

		public float AvarageFixScreenSpeed => default(float);

		public float AvarageScreenSpeed => default(float);

		public float AvarageFixScreenAccel => default(float);

		public float AvarageScreenAccel => default(float);

		public FlTouchInput(FlUIManager uiManager, int inputIndex)
		{
		}

		protected override void _Update_Common_End()
		{
		}

		protected override void _Update_Wait_Loop()
		{
		}

		protected override void _Update_Down_Init()
		{
		}

		protected override void _Update_Down_Loop()
		{
		}

		private Vector3 _CalculateAvarageFixScreenPosition()
		{
			return default(Vector3);
		}

		private Vector3 _CalculateAvarageScreenPosition()
		{
			return default(Vector3);
		}

		private Vector3 _CalculateAvarageFixScreenDirection()
		{
			return default(Vector3);
		}

		private Vector3 _CalculateAvarageScreenDirection()
		{
			return default(Vector3);
		}

		private float _CalculateAvarageFixScreenSpeed()
		{
			return default(float);
		}

		private float _CalculateAvarageScreenSpeed()
		{
			return default(float);
		}

		private float _CalculateAvarageFixScreenAccel()
		{
			return default(float);
		}

		private float _CalculateAvarageScreenAccel()
		{
			return default(float);
		}

		private float _CalculateLength()
		{
			return default(float);
		}

		public FlInputDownTypes _GetDown([Optional] Collider collision)
		{
			return default(FlInputDownTypes);
		}

		public FlInputDownLoopTypes _GetDownLoop(Collider collision)
		{
			return default(FlInputDownLoopTypes);
		}

		public FlInputUpTypes _GetUp(Collider collision)
		{
			return default(FlInputUpTypes);
		}

		public bool _GetScrollStart(Collider collision, FlUIDirectionTypes directionType)
		{
			return default(bool);
		}

		public bool _GetSwipeStart(Collider collision, FlUIDirectionTypes directionType)
		{
			return default(bool);
		}

		private Vector3 _GetScreenPosition()
		{
			return default(Vector3);
		}

		private Vector3 _GeTouchPosition()
		{
			return default(Vector3);
		}

		private bool _GetTouchDown()
		{
			return default(bool);
		}

		private bool _GetTouchUp()
		{
			return default(bool);
		}

		private bool _HitCollision(Collider collision)
		{
			return default(bool);
		}
	}
}
