using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class MarkerData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private ActionCollisionPos _posId;

		[SerializeField]
		[HideInInspector]
		private bool _ignoreRotForTargetP;

		[SerializeField]
		[HideInInspector]
		private Vector3 _offsetPos;

		[SerializeField]
		[HideInInspector]
		private float _angle;

		[SerializeField]
		[HideInInspector]
		private CollisionTransform.SlotFrontType _slotFront;

		[SerializeField]
		[HideInInspector]
		private ChargeMarker.eType _shapeType;

		[SerializeField]
		[HideInInspector]
		private ChargeMarker.eColorType _colorType;

		[SerializeField]
		[HideInInspector]
		private bool _useDifficultyColor;

		[SerializeField]
		[HideInInspector]
		private bool _isMarkerToTarget;

		[SerializeField]
		[HideInInspector]
		private bool _isDynamicLengthToTarget;

		[SerializeField]
		[HideInInspector]
		private float _offsetLengthToTarget;

		[SerializeField]
		[HideInInspector]
		private ChargeMarker.eColorType[] _difficultyColorType;

		[SerializeField]
		[HideInInspector]
		private ChargeMarker.eColorType _difficultyColorType_Hell;

		[SerializeField]
		[HideInInspector]
		private ChargeMarker.eColorType _difficultyColorType_Ultimate;

		[SerializeField]
		[HideInInspector]
		private float _length;

		[SerializeField]
		[HideInInspector]
		private float _width;

		[SerializeField]
		[HideInInspector]
		private float _distanceMin;

		[SerializeField]
		[HideInInspector]
		private float _distanceMax;

		[SerializeField]
		[HideInInspector]
		private bool _useForEachChargeTime;

		[SerializeField]
		[HideInInspector]
		private float _chargeSec;

		[SerializeField]
		[HideInInspector]
		private float[] _chargeLvSec;

		[SerializeField]
		[HideInInspector]
		private float _chargeAfterSec;

		[SerializeField]
		[HideInInspector]
		private float _traceSec;

		[SerializeField]
		[HideInInspector]
		private bool _useSkinScale;

		[SerializeField]
		[HideInInspector]
		private bool _useScaleAtTheTime;

		[SerializeField]
		[HideInInspector]
		private ChargeMarker.TraceType _traceType;

		[SerializeField]
		[HideInInspector]
		private bool _sudden;

		[SerializeField]
		[HideInInspector]
		private int _groupId;

		[SerializeField]
		[HideInInspector]
		private bool _ignoredByPlayerAI;

		[SerializeField]
		[HideInInspector]
		private bool _invisibleForPlayerAI;

		[SerializeField]
		[HideInInspector]
		private ChargeMarker.PlayerAIEscapeDirection _playerAIEscapeDir;

		[SerializeField]
		[HideInInspector]
		private bool _ignoredImpactWaitForPlayerColor;

		[SerializeField]
		[HideInInspector]
		private bool _isGroundHeight;

		[SerializeField]
		[HideInInspector]
		private int[] _activateOnChargeImpact;

		[SerializeField]
		[HideInInspector]
		private int _nextLevelMarkerCount;

		[SerializeField]
		[HideInInspector]
		private MarkerData[] _nextLevelMarkerData;

		[SerializeField]
		[HideInInspector]
		private string _chargeBulletEffect;

		[SerializeField]
		[HideInInspector]
		private int _minRandomBulletEffectTrigger;

		[SerializeField]
		[HideInInspector]
		private int _maxRandomBulletEffectTrigger;

		public ActionCollisionPos posId => default(ActionCollisionPos);

		public bool ignoreRotForTargetP => default(bool);

		public Vector3 offsetPos => default(Vector3);

		public float angle => default(float);

		public CollisionTransform.SlotFrontType slotFront => default(CollisionTransform.SlotFrontType);

		public ChargeMarker.eType shapeType => default(ChargeMarker.eType);

		public ChargeMarker.eColorType colorType => default(ChargeMarker.eColorType);

		public bool useDifficultyColor => default(bool);

		public bool isMarkerToTarget => default(bool);

		public bool isDynamicLengthToTarget => default(bool);

		public float offsetLengthToTarget => default(float);

		public ChargeMarker.eColorType[] difficultyColorType => null;

		public ChargeMarker.eColorType difficultyColorType_Hell => default(ChargeMarker.eColorType);

		public ChargeMarker.eColorType difficultyColorType_Ultimate => default(ChargeMarker.eColorType);

		public float length => default(float);

		public float width => default(float);

		public float distanceMin => default(float);

		public float distanceMax => default(float);

		public bool useForEachChargeTime => default(bool);

		public float chargeSec => default(float);

		public float[] chargeLvSec => null;

		public float chargeAfterSec => default(float);

		public float traceSec => default(float);

		public bool useSkinScale => default(bool);

		public bool useScaleAtTheTime => default(bool);

		public ChargeMarker.TraceType traceType => default(ChargeMarker.TraceType);

		public bool sudden => default(bool);

		public int groupId => default(int);

		public bool ignoredByPlayerAI => default(bool);

		public bool invisibleForPlayerAI => default(bool);

		public ChargeMarker.PlayerAIEscapeDirection playerAIEscapeDir => default(ChargeMarker.PlayerAIEscapeDirection);

		public bool ignoredImpactWaitForPlayerColor => default(bool);

		public bool isGroundHeight
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int[] activateOnChargeImpact => null;

		public int nextLevelMarkerCount => default(int);

		public MarkerData[] nextLevelMarkerData => null;

		public string chargeBulletEffect => null;

		public int minRandomBulletEffectTrigger => default(int);

		public int maxRandomBulletEffectTrigger => default(int);

		public void Copy(MarkerData src)
		{
		}
	}
}
