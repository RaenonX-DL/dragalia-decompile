using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class ParabolaBulletData : BulletWithMarkerData
	{
		public enum AimType
		{
			Marker,
			FixedPosition,
			AreaAnchor,
			Character,
			StartActionCharacter,
			ChargeMarkerPos
		}

		public enum TargetCharacterStatus
		{
			None,
			TargetEffect,
			AllyHpRateLowest
		}

		public enum ImpactType
		{
			Crash,
			Bound,
			Mine,
			Slide
		}

		[SerializeField]
		[HideInInspector]
		private AimType _aimType;

		[SerializeField]
		[HideInInspector]
		private TargetCharacterStatus _targetCharaStatus;

		[SerializeField]
		[HideInInspector]
		private Vector3 _fixedPos;

		[SerializeField]
		[HideInInspector]
		private Vector3 _offsetPos;

		[SerializeField]
		[HideInInspector]
		private Vector3 _targetOffsetPos;

		[SerializeField]
		[HideInInspector]
		private float _topOffsetY;

		[SerializeField]
		[HideInInspector]
		private float _range;

		[SerializeField]
		[HideInInspector]
		private float _reachSec;

		[SerializeField]
		[HideInInspector]
		private ActionCollisionPos _collisionPosId;

		[SerializeField]
		[HideInInspector]
		private bool _isCollisionSlotFront;

		[SerializeField]
		[HideInInspector]
		private bool _registerArrangeBulletHitAttr;

		[SerializeField]
		[HideInInspector]
		private ImpactType _impactType;

		[SerializeField]
		[HideInInspector]
		private int _boundNumPerSec;

		[SerializeField]
		[HideInInspector]
		private float _boundStopHeight;

		[SerializeField]
		[HideInInspector]
		private float _boundPostStopTime;

		[SerializeField]
		[HideInInspector]
		private float _mineDuration;

		[SerializeField]
		[HideInInspector]
		private bool _fireFromTop;

		[SerializeField]
		[HideInInspector]
		private float _dropAndRushTime;

		[SerializeField]
		[HideInInspector]
		private float _dropTime;

		[SerializeField]
		[HideInInspector]
		private float _durationAfterRush;

		[SerializeField]
		[HideInInspector]
		private float _lengthOfMarker;

		[SerializeField]
		[HideInInspector]
		private float _lengthOfHopBullet;

		[SerializeField]
		[HideInInspector]
		private bool _isHopBullet;

		[SerializeField]
		[HideInInspector]
		private bool _wallDisappear;

		[SerializeField]
		[HideInInspector]
		private float _boundCoefficient;

		[SerializeField]
		[HideInInspector]
		private float _maxLengthOfBoundParabola;

		[SerializeField]
		[HideInInspector]
		private float _minLengthOfBoundParabola;

		[SerializeField]
		[HideInInspector]
		private bool _autoPeriodOfBoundParabola;

		[SerializeField]
		[HideInInspector]
		private ChargeMarker.eColorType _markerType;

		[SerializeField]
		[HideInInspector]
		private int _effectTriggerSlideLanding;

		[SerializeField]
		[HideInInspector]
		private int _effectTriggerSlideRunning;

		[SerializeField]
		[HideInInspector]
		private float _mineRange;

		[SerializeField]
		[HideInInspector]
		private bool _isMineExplodeTimeUp;

		[SerializeField]
		[HideInInspector]
		private bool _isMineExplodeHit;

		public AimType aimType => default(AimType);

		public TargetCharacterStatus targetCharaStatus => default(TargetCharacterStatus);

		public Vector3 fixedPos => default(Vector3);

		public Vector3 offsetPos => default(Vector3);

		public Vector3 targetOffsetPos => default(Vector3);

		public float topOffsetPosY => default(float);

		public float range => default(float);

		public float reachSec => default(float);

		public ActionCollisionPos collisionPosId => default(ActionCollisionPos);

		public bool isCollisionSlotFront => default(bool);

		public bool registerArrangeBulletHitAttr => default(bool);

		public ImpactType impactType => default(ImpactType);

		public int boundNumPerSec => default(int);

		public float boundStopHeight => default(float);

		public float boundPostStopTime => default(float);

		public float mineDuration => default(float);

		public bool fireFromTop => default(bool);

		public float dropAndRushTime => default(float);

		public float dropTime => default(float);

		public float durationAfterRush => default(float);

		public float lengthOfMarker => default(float);

		public float lengthOfHopBullet => default(float);

		public bool isHopBullet => default(bool);

		public bool wallDisappear => default(bool);

		public float boundCoefficient => default(float);

		public float maxLengthOfBoundParabola => default(float);

		public float minLengthOfBoundParabola => default(float);

		public bool autoPeriodOfBoundParabola => default(bool);

		public ChargeMarker.eColorType markerType => default(ChargeMarker.eColorType);

		public int effectTriggerSlideLanding => default(int);

		public int effectTriggerSlideRunning => default(int);

		public float mineRange => default(float);

		public bool isMineExplodeTimeUp => default(bool);

		public bool isMineExplodeHit => default(bool);
	}
}
