/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class ParabolaBulletData : BulletWithMarkerData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private AimType _aimType;
		[HideInInspector]
		[SerializeField]
		private TargetCharacterStatus _targetCharaStatus;
		[HideInInspector]
		[SerializeField]
		private Vector3 _fixedPos;
		[HideInInspector]
		[SerializeField]
		private Vector3 _offsetPos;
		[HideInInspector]
		[SerializeField]
		private Vector3 _targetOffsetPos;
		[HideInInspector]
		[SerializeField]
		private float _topOffsetY;
		[HideInInspector]
		[SerializeField]
		private float _range;
		[HideInInspector]
		[SerializeField]
		private float _reachSec;
		[HideInInspector]
		[SerializeField]
		private ActionCollisionPos _collisionPosId;
		[HideInInspector]
		[SerializeField]
		private bool _isCollisionSlotFront;
		[HideInInspector]
		[SerializeField]
		private ImpactType _impactType;
		[HideInInspector]
		[SerializeField]
		private int _boundNumPerSec;
		[HideInInspector]
		[SerializeField]
		private float _boundStopHeight;
		[HideInInspector]
		[SerializeField]
		private float _boundPostStopTime;
		[HideInInspector]
		[SerializeField]
		private float _mineDuration;
		[HideInInspector]
		[SerializeField]
		private bool _fireFromTop;
		[HideInInspector]
		[SerializeField]
		private float _dropAndRushTime;
		[HideInInspector]
		[SerializeField]
		private float _dropTime;
		[HideInInspector]
		[SerializeField]
		private float _durationAfterRush;
		[HideInInspector]
		[SerializeField]
		private float _lengthOfMarker;
		[HideInInspector]
		[SerializeField]
		private float _lengthOfHopBullet;
		[HideInInspector]
		[SerializeField]
		private bool _isHopBullet;
		[HideInInspector]
		[SerializeField]
		private bool _wallDisappear;
		[HideInInspector]
		[SerializeField]
		private float _boundCoefficient;
		[HideInInspector]
		[SerializeField]
		private float _maxLengthOfBoundParabola;
		[HideInInspector]
		[SerializeField]
		private float _minLengthOfBoundParabola;
		[HideInInspector]
		[SerializeField]
		private bool _autoPeriodOfBoundParabola;
		[HideInInspector]
		[SerializeField]
		private ChargeMarker.eColorType _markerType;
		[HideInInspector]
		[SerializeField]
		private int _effectTriggerSlideLanding;
		[HideInInspector]
		[SerializeField]
		private int _effectTriggerSlideRunning;
		[HideInInspector]
		[SerializeField]
		private float _mineRange;
		[HideInInspector]
		[SerializeField]
		private bool _isMineExplodeTimeUp;
		[HideInInspector]
		[SerializeField]
		private bool _isMineExplodeHit;
	
		// Properties
		public AimType aimType { get; }
		public TargetCharacterStatus targetCharaStatus { get; }
		public Vector3 fixedPos { get; }
		public Vector3 offsetPos { get; }
		public Vector3 targetOffsetPos { get; }
		public float topOffsetPosY { get; }
		public float range { get; }
		public float reachSec { get; }
		public ActionCollisionPos collisionPosId { get; }
		public bool isCollisionSlotFront { get; }
		public ImpactType impactType { get; }
		public int boundNumPerSec { get; }
		public float boundStopHeight { get; }
		public float boundPostStopTime { get; }
		public float mineDuration { get; }
		public bool fireFromTop { get; }
		public float dropAndRushTime { get; }
		public float dropTime { get; }
		public float durationAfterRush { get; }
		public float lengthOfMarker { get; }
		public float lengthOfHopBullet { get; }
		public bool isHopBullet { get; }
		public bool wallDisappear { get; }
		public float boundCoefficient { get; }
		public float maxLengthOfBoundParabola { get; }
		public float minLengthOfBoundParabola { get; }
		public bool autoPeriodOfBoundParabola { get; }
		public ChargeMarker.eColorType markerType { get; }
		public int effectTriggerSlideLanding { get; }
		public int effectTriggerSlideRunning { get; }
		public float mineRange { get; }
		public bool isMineExplodeTimeUp { get; }
		public bool isMineExplodeHit { get; }
	
		// Nested types
		public enum AimType
		{
			Marker = 0,
			FixedPosition = 1,
			AreaAnchor = 2,
			Character = 3,
			StartActionCharacter = 4
		}
	
		public enum TargetCharacterStatus
		{
			None = 0,
			TargetEffect = 1,
			AllyHpRateLowest = 2
		}
	
		public enum ImpactType
		{
			Crash = 0,
			Bound = 1,
			Mine = 2,
			Slide = 3
		}
	
		// Constructors
		public ParabolaBulletData();
	}
}
