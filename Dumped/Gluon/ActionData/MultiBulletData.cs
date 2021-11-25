using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class MultiBulletData : BulletData
	{
		public enum MultiGenerateStyle
		{
			Hostile,
			RootRandom,
			WarldOriginRandom,
			RootFrontRandom,
			TargetRandom,
			LineForward,
			MultiPlayerRandom,
			MultiPlayerAtkMin,
			MultiPlayerAtkMax,
			MultiPlayerLongRange,
			AreaAnchorRandom,
			NearRange,
			NearRootToNearRange,
			FireStock_RootToNearRage,
			LockOnDebuffRandom,
			LockOnDebuffNear,
			LockOnDebuffFar,
			LockOnDebuffHpLower,
			LockOnDebuffHpHigher,
			LockOnDebuffOrLongRangeWeapon
		}

		public enum NoticeEffectBase
		{
			Owner,
			AreaAnchor
		}

		public enum FirePositionPattern
		{
			None,
			Horizontal,
			Radial,
			Circle
		}

		public enum FireStockPattern
		{
			None,
			StockBullet,
			BuffCount,
			SpecifiedNum
		}

		[SerializeField]
		[HideInInspector]
		private MultiGenerateStyle _multiGenerateStyle;

		[SerializeField]
		[HideInInspector]
		private float _generateRangeMin;

		[SerializeField]
		[HideInInspector]
		private float _generateRangeMax;

		[SerializeField]
		[HideInInspector]
		private bool _isGenerateRangeRandom;

		[SerializeField]
		[HideInInspector]
		private bool _isGenerateToDeadTarget;

		[SerializeField]
		[HideInInspector]
		private bool _checkWallOnGen;

		[SerializeField]
		[HideInInspector]
		private int _generateNum;

		[SerializeField]
		[HideInInspector]
		private bool _stopWhenAllTargetsGen;

		[SerializeField]
		[HideInInspector]
		private bool _generateNumDependOnBuffCount;

		[SerializeField]
		[HideInInspector]
		private int _buffCountConditionId;

		[SerializeField]
		[HideInInspector]
		private float _generateDelay;

		[SerializeField]
		[HideInInspector]
		private bool _useMarker;

		[SerializeField]
		[HideInInspector]
		private MarkerData _marker;

		[SerializeField]
		[HideInInspector]
		private int _traceDelay;

		[SerializeField]
		[HideInInspector]
		private float _bulletDelay;

		[SerializeField]
		[HideInInspector]
		private float[] _markerDelay;

		[SerializeField]
		[HideInInspector]
		private bool _setBulletDelayOneByOne;

		[SerializeField]
		[HideInInspector]
		private float[] _bulletDelayTime;

		public static int MARKER_DELAY_MAX;

		[SerializeField]
		[HideInInspector]
		private bool _useLegacyClearMarker;

		[SerializeField]
		[HideInInspector]
		private float _spaceDistance;

		[SerializeField]
		[HideInInspector]
		private EffectData _noticeEffect;

		[SerializeField]
		[HideInInspector]
		private NoticeEffectBase _noticeEffectBase;

		[SerializeField]
		[HideInInspector]
		private Vector3 _noticeEffectOffsetRot;

		[SerializeField]
		[HideInInspector]
		private float _noticeEffectDelay;

		[SerializeField]
		[HideInInspector]
		private float _fromCharaToMarkerTime;

		[SerializeField]
		[HideInInspector]
		private bool _isfromCharaToMarker;

		[SerializeField]
		[HideInInspector]
		private bool _isfromCharaToMarkerWithCollision;

		[SerializeField]
		[HideInInspector]
		private float _collisonDelayTime;

		[SerializeField]
		[HideInInspector]
		private bool _canBeSameTarget;

		[SerializeField]
		[HideInInspector]
		private bool _ignoreHeightOnSearchTarget;

		[SerializeField]
		[HideInInspector]
		private bool _useFireStockBulletParam;

		[SerializeField]
		[HideInInspector]
		private bool _useSameRandomSeed;

		[SerializeField]
		[HideInInspector]
		private FirePositionPattern _firePositionPattern;

		[SerializeField]
		[HideInInspector]
		private FireStockPattern _fireStockPattern;

		[SerializeField]
		[HideInInspector]
		private float _baseInterval;

		[SerializeField]
		[HideInInspector]
		private float _maxWidth;

		[SerializeField]
		[HideInInspector]
		private float _radius;

		[SerializeField]
		[HideInInspector]
		private float _pitch;

		[SerializeField]
		[HideInInspector]
		private float _fireAngle;

		[SerializeField]
		[HideInInspector]
		private float[] _delayFireSec;

		[SerializeField]
		[HideInInspector]
		private int _bulletNum;

		[SerializeField]
		[HideInInspector]
		private Vector3 _uniqueOffsetPos;

		[SerializeField]
		[HideInInspector]
		private bool _useInterpolationAngleCurve;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve[] _interpolationAngleCurve;

		[SerializeField]
		[HideInInspector]
		private bool _removeStockBulletOnFinish;

		public MultiGenerateStyle multiGenerateStyle => default(MultiGenerateStyle);

		public float generateRangeMin => default(float);

		public float generateRangeMax => default(float);

		public bool isGenerateRangeRandom => default(bool);

		public bool isGenerateToDeadTarget => default(bool);

		public bool checkWallOnGen => default(bool);

		public int generateNum => default(int);

		public bool stopWhenAllTargetsGen => default(bool);

		public bool generateNumDependOnBuffCount => default(bool);

		public int buffCountConditionId => default(int);

		public float generateInterval => default(float);

		public bool useMarker => default(bool);

		public MarkerData markerData => null;

		public int traceDelay => default(int);

		public float bulletDelay => default(float);

		public float[] markerDelay => null;

		public bool setBulletDelayOneByOne => default(bool);

		public float[] bulletDelayTime => null;

		public bool useLegacyClearMarker => default(bool);

		public float spaceDistance => default(float);

		public EffectData noticeEffect => null;

		public NoticeEffectBase noticeEffectBase => default(NoticeEffectBase);

		public Vector3 noticeEffectOffsetRot => default(Vector3);

		public float noticeEffectDelay => default(float);

		public float fromCharaToMarkerTime => default(float);

		public bool isfromCharaToMarker => default(bool);

		public bool isfromCharaToMarkerWithCollision => default(bool);

		public float collisonDelayTime => default(float);

		public bool canBeSameTarget => default(bool);

		public bool ignoreHeightOnSearchTarget => default(bool);

		public bool useFireStockBulletParam => default(bool);

		public bool useSameRandomSeed => default(bool);

		public FirePositionPattern firePositionPattern => default(FirePositionPattern);

		public FireStockPattern fireStockPattern => default(FireStockPattern);

		public float baseInterval => default(float);

		public float maxWidth => default(float);

		public float radius => default(float);

		public float pitch => default(float);

		public float fireAngle => default(float);

		public float[] delayFireSec => null;

		public int bulletNum => default(int);

		public Vector3 uniqueOffsetPos => default(Vector3);

		public bool useInterpolationAngleCurve => default(bool);

		public AnimationCurve[] interpolationAngleCurve => null;

		public bool removeStockBulletOnFinish => default(bool);
	}
}
