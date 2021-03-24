/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main.Utility
{
	public class FlTouchInput : FlInputBase
	{
		// Fields
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
	
		// Properties
		public Vector3 CurrentFixScreenPosition { get; }
		public Vector3 StartFixScreenPosition { get; }
		public Vector3 CurrentScreenPosition { get; }
		public Vector3 StartScreenPosition { get; }
		public float CurrentFixScreenSpeed { get; }
		public float CurrentFixScreenAccel { get; }
		public Vector3 FixScreenVectorFromStart { get; }
		public Vector3 FixScreenNormalizeVectorFromStart { get; }
		public float FixScreenDistanceFromStart { get; }
		public Vector3 AvarageFixScreenPosition { get; }
		public Vector3 AvarageScreenPosition { get; }
		public Vector3 AvarageFixScreenDirection { get; }
		public Vector3 AvarageScreenDirection { get; }
		public float AvarageFixScreenSpeed { get; }
		public float AvarageScreenSpeed { get; }
		public float AvarageFixScreenAccel { get; }
		public float AvarageScreenAccel { get; }
	
		// Constructors
		public FlTouchInput(FlUIManager uiManager, int inputIndex);
	
		// Methods
		protected override void _Update_Common_End();
		protected override void _Update_Wait_Loop();
		protected override void _Update_Down_Init();
		protected override void _Update_Down_Loop();
		private Vector3 _CalculateAvarageFixScreenPosition();
		private Vector3 _CalculateAvarageScreenPosition();
		private Vector3 _CalculateAvarageFixScreenDirection();
		private Vector3 _CalculateAvarageScreenDirection();
		private float _CalculateAvarageFixScreenSpeed();
		private float _CalculateAvarageScreenSpeed();
		private float _CalculateAvarageFixScreenAccel();
		private float _CalculateAvarageScreenAccel();
		private float _CalculateLength();
		public FlInputDownTypes _GetDown(Collider collision = null);
		public FlInputDownLoopTypes _GetDownLoop(Collider collision);
		public FlInputUpTypes _GetUp(Collider collision);
		public bool _GetScrollStart(Collider collision, FlUIDirectionTypes directionType);
		public bool _GetSwipeStart(Collider collision, FlUIDirectionTypes directionType);
		private Vector3 _GetScreenPosition();
		private Vector3 _GeTouchPosition();
		private bool _GetTouchDown();
		private bool _GetTouchUp();
		private bool _HitCollision(Collider collision);
	}
}
