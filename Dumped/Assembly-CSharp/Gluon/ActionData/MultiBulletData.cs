/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class MultiBulletData : BulletData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private MultiGenerateStyle _multiGenerateStyle;
		[HideInInspector]
		[SerializeField]
		private float _generateRangeMin;
		[HideInInspector]
		[SerializeField]
		private float _generateRangeMax;
		[HideInInspector]
		[SerializeField]
		private bool _isGenerateRangeRandom;
		[HideInInspector]
		[SerializeField]
		private bool _isGenerateToDeadTarget;
		[HideInInspector]
		[SerializeField]
		private int _generateNum;
		[HideInInspector]
		[SerializeField]
		private bool _stopWhenAllTargetsGen;
		[HideInInspector]
		[SerializeField]
		private bool _generateNumDependOnBuffCount;
		[HideInInspector]
		[SerializeField]
		private int _buffCountConditionId;
		[HideInInspector]
		[SerializeField]
		private float _generateDelay;
		[HideInInspector]
		[SerializeField]
		private bool _useMarker;
		[HideInInspector]
		[SerializeField]
		private MarkerData _marker;
		[HideInInspector]
		[SerializeField]
		private int _traceDelay;
		[HideInInspector]
		[SerializeField]
		private float _bulletDelay;
		[HideInInspector]
		[SerializeField]
		private float[] _markerDelay;
		[HideInInspector]
		[SerializeField]
		private bool _setBulletDelayOneByOne;
		[HideInInspector]
		[SerializeField]
		private float[] _bulletDelayTime;
		public static int MARKER_DELAY_MAX;
		[HideInInspector]
		[SerializeField]
		private bool _useLegacyClearMarker;
		[HideInInspector]
		[SerializeField]
		private float _spaceDistance;
		[HideInInspector]
		[SerializeField]
		private EffectData _noticeEffect;
		[HideInInspector]
		[SerializeField]
		private NoticeEffectBase _noticeEffectBase;
		[HideInInspector]
		[SerializeField]
		private Vector3 _noticeEffectOffsetRot;
		[HideInInspector]
		[SerializeField]
		private float _noticeEffectDelay;
		[HideInInspector]
		[SerializeField]
		private float _fromCharaToMarkerTime;
		[HideInInspector]
		[SerializeField]
		private bool _isfromCharaToMarker;
		[HideInInspector]
		[SerializeField]
		private bool _isfromCharaToMarkerWithCollision;
		[HideInInspector]
		[SerializeField]
		private float _collisonDelayTime;
		[HideInInspector]
		[SerializeField]
		private bool _canBeSameTarget;
		[HideInInspector]
		[SerializeField]
		private bool _useFireStockBulletParam;
		[HideInInspector]
		[SerializeField]
		private bool _useSameRandomSeed;
		[HideInInspector]
		[SerializeField]
		private FirePositionPattern _firePositionPattern;
		[HideInInspector]
		[SerializeField]
		private FireStockPattern _fireStockPattern;
		[HideInInspector]
		[SerializeField]
		private float _baseInterval;
		[HideInInspector]
		[SerializeField]
		private float _maxWidth;
		[HideInInspector]
		[SerializeField]
		private float _radius;
		[HideInInspector]
		[SerializeField]
		private float _pitch;
		[HideInInspector]
		[SerializeField]
		private float _fireAngle;
		[HideInInspector]
		[SerializeField]
		private float[] _delayFireSec;
		[HideInInspector]
		[SerializeField]
		private int _bulletNum;
		[HideInInspector]
		[SerializeField]
		private Vector3 _uniqueOffsetPos;
		[HideInInspector]
		[SerializeField]
		private bool _useInterpolationAngleCurve;
		[HideInInspector]
		[SerializeField]
		private AnimationCurve[] _interpolationAngleCurve;
		[HideInInspector]
		[SerializeField]
		private bool _removeStockBulletOnFinish;
	
		// Properties
		public MultiGenerateStyle multiGenerateStyle { get; }
		public float generateRangeMin { get; }
		public float generateRangeMax { get; }
		public bool isGenerateRangeRandom { get; }
		public bool isGenerateToDeadTarget { get; }
		public int generateNum { get; }
		public bool stopWhenAllTargetsGen { get; }
		public bool generateNumDependOnBuffCount { get; }
		public int buffCountConditionId { get; }
		public float generateInterval { get; }
		public bool useMarker { get; }
		public MarkerData markerData { get; }
		public int traceDelay { get; }
		public float bulletDelay { get; }
		public float[] markerDelay { get; }
		public bool setBulletDelayOneByOne { get; }
		public float[] bulletDelayTime { get; }
		public bool useLegacyClearMarker { get; }
		public float spaceDistance { get; }
		public EffectData noticeEffect { get; }
		public NoticeEffectBase noticeEffectBase { get; }
		public Vector3 noticeEffectOffsetRot { get; }
		public float noticeEffectDelay { get; }
		public float fromCharaToMarkerTime { get; }
		public bool isfromCharaToMarker { get; }
		public bool isfromCharaToMarkerWithCollision { get; }
		public float collisonDelayTime { get; }
		public bool canBeSameTarget { get; }
		public bool useFireStockBulletParam { get; }
		public bool useSameRandomSeed { get; }
		public FirePositionPattern firePositionPattern { get; }
		public FireStockPattern fireStockPattern { get; }
		public float baseInterval { get; }
		public float maxWidth { get; }
		public float radius { get; }
		public float pitch { get; }
		public float fireAngle { get; }
		public float[] delayFireSec { get; }
		public int bulletNum { get; }
		public Vector3 uniqueOffsetPos { get; }
		public bool useInterpolationAngleCurve { get; }
		public AnimationCurve[] interpolationAngleCurve { get; }
		public bool removeStockBulletOnFinish { get; }
	
		// Nested types
		public enum MultiGenerateStyle
		{
			Hostile = 0,
			RootRandom = 1,
			WarldOriginRandom = 2,
			RootFrontRandom = 3,
			TargetRandom = 4,
			LineForward = 5,
			MultiPlayerRandom = 6,
			MultiPlayerAtkMin = 7,
			MultiPlayerAtkMax = 8,
			MultiPlayerLongRange = 9,
			AreaAnchorRandom = 10,
			NearRange = 11,
			NearRootToNearRange = 12,
			FireStock_RootToNearRage = 13,
			LockOnDebuffRandom = 14,
			LockOnDebuffNear = 15,
			LockOnDebuffFar = 16,
			LockOnDebuffHpLower = 17,
			LockOnDebuffHpHigher = 18,
			LockOnDebuffOrLongRangeWeapon = 19
		}
	
		public enum NoticeEffectBase
		{
			Owner = 0,
			AreaAnchor = 1
		}
	
		public enum FirePositionPattern
		{
			None = 0,
			Horizontal = 1,
			Radial = 2,
			Circle = 3
		}
	
		public enum FireStockPattern
		{
			None = 0,
			StockBullet = 1,
			BuffCount = 2,
			SpecifiedNum = 3
		}
	
		// Constructors
		public MultiBulletData();
		static MultiBulletData();
	}
}
