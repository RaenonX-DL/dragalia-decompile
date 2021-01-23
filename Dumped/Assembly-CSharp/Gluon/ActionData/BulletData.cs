/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Bullet;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class BulletData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private InGameDef.CharacterType _characterType;
		[HideInInspector]
		[SerializeField]
		private string _hitAttrLabel;
		[HideInInspector]
		[SerializeField]
		private string _hitAttrLabel2nd;
		[HideInInspector]
		[SerializeField]
		private bool _useSameComponent;
		[HideInInspector]
		[SerializeField]
		private bool _useElementalHit;
		[HideInInspector]
		[SerializeField]
		private string[] _elementalHitLabel;
		[HideInInspector]
		[SerializeField]
		private float _bulletDuration;
		[HideInInspector]
		[SerializeField]
		private float _waitTime;
		[HideInInspector]
		[SerializeField]
		private float _delayTime;
		[HideInInspector]
		[SerializeField]
		private bool _delayVisible;
		[HideInInspector]
		[SerializeField]
		private bool _isKeepDirectionOnFire;
		[HideInInspector]
		[SerializeField]
		private bool _isHitDelete;
		[HideInInspector]
		[SerializeField]
		private bool _isHitGroundDelete;
		[HideInInspector]
		[SerializeField]
		private bool _isHitInvisibleObstacle;
		[HideInInspector]
		[SerializeField]
		private bool _notHitObstacle;
		[HideInInspector]
		[SerializeField]
		private float _attenuationRate;
		[HideInInspector]
		[SerializeField]
		private ReboundType _rebound;
		[HideInInspector]
		[SerializeField]
		private string _reboundSEName;
		[HideInInspector]
		[SerializeField]
		private bool _isSyncHitProcess;
		[HideInInspector]
		[SerializeField]
		private bool _isUseBulletModel;
		[HideInInspector]
		[SerializeField]
		private DragonDecoration _decoId;
		[HideInInspector]
		[SerializeField]
		private string _effectName;
		[HideInInspector]
		[SerializeField]
		private string _effectNameForLowestQuality;
		[HideInInspector]
		[SerializeField]
		private string[] _elementalEffectName;
		[HideInInspector]
		[SerializeField]
		private bool _isHitAttributeShift;
		[HideInInspector]
		[SerializeField]
		private string _effectNameHAS;
		[HideInInspector]
		[SerializeField]
		private int _effectTriggerIdx;
		[HideInInspector]
		[SerializeField]
		private bool _effectInfluencedCharaterElement;
		[HideInInspector]
		[SerializeField]
		private bool _effectUseElementalTrigger;
		[HideInInspector]
		[SerializeField]
		private bool _effectUseMarkerTrigger;
		[HideInInspector]
		[SerializeField]
		private int _effectTimedTrigger;
		[HideInInspector]
		[SerializeField]
		private int _effectTimedTriggerFrame;
		[HideInInspector]
		[SerializeField]
		private EffectObject.EraseType _effectEraseType;
		[HideInInspector]
		[SerializeField]
		private float _effectDisappearTime;
		[HideInInspector]
		[SerializeField]
		private bool _isKeepEffectAfterStop;
		[HideInInspector]
		[SerializeField]
		private string _fireSEName;
		[HideInInspector]
		[SerializeField]
		private string _hitSEName;
		[HideInInspector]
		[SerializeField]
		private bool _hitSEFlagTerrain;
		[HideInInspector]
		[SerializeField]
		private bool _disablePlayNormalHitSE;
		[HideInInspector]
		[SerializeField]
		private string _hitSENameTerrain;
		[HideInInspector]
		[SerializeField]
		private bool _useHitCameraShake;
		[HideInInspector]
		[SerializeField]
		private CameraController.ShakeType _hitCameraShake;
		[HideInInspector]
		[SerializeField]
		private CameraController.ShakePriority _cameraShakePriority;
		[HideInInspector]
		[SerializeField]
		private bool _hitCameraShakeFlagTerrain;
		[HideInInspector]
		[SerializeField]
		private CameraController.ShakeType _hitCameraShakeTerrain;
		[HideInInspector]
		[SerializeField]
		private CameraController.ShakePriority _cameraShakePriorityTerrain;
		[HideInInspector]
		[SerializeField]
		private bool _isAppearChild;
		[HideInInspector]
		[SerializeField]
		private int _childNumber;
		[HideInInspector]
		[SerializeField]
		private int _childActionId;
		[HideInInspector]
		[SerializeField]
		private BulletWithMarkerData.AppearChildRotationBase _appearChildRotationBase;
		[HideInInspector]
		[SerializeField]
		private float _childDirection;
		[HideInInspector]
		[SerializeField]
		private bool _childPopedInvincible;
		[HideInInspector]
		[SerializeField]
		private bool _isAppearChildHostSync;
		[HideInInspector]
		[SerializeField]
		private bool _isAppearChildOnHitChara;
		[HideInInspector]
		[SerializeField]
		private bool _isChildTargetHitChara;
		[HideInInspector]
		[SerializeField]
		private bool _isChildTargetBulletTargetChara;
		[HideInInspector]
		[SerializeField]
		private GenerateStyle _generateStyle;
		[HideInInspector]
		[SerializeField]
		private string _generateNodeName;
		[HideInInspector]
		[SerializeField]
		private float _generateNear;
		[HideInInspector]
		[SerializeField]
		private int _loadPositionId;
		[HideInInspector]
		[SerializeField]
		private Vector3 _offsetPos;
		[HideInInspector]
		[SerializeField]
		private Vector3 _directionRot;
		[HideInInspector]
		[SerializeField]
		private Vector3 _offsetScale;
		[HideInInspector]
		[SerializeField]
		private bool _useOwnerScaleEffect;
		[HideInInspector]
		[SerializeField]
		private BulletObject.DirectionType _directionType;
		[HideInInspector]
		[SerializeField]
		private string _targetDistinctionTag;
		[HideInInspector]
		[SerializeField]
		private bool _deleteTargetBulletOnHit;
		[HideInInspector]
		[SerializeField]
		private float _nearest;
		[HideInInspector]
		[SerializeField]
		private bool _generateInTheWall;
		[HideInInspector]
		[SerializeField]
		private float _bulletSpeed;
		[HideInInspector]
		[SerializeField]
		private bool _useSpeedCurve;
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _speedCurve;
		[HideInInspector]
		[SerializeField]
		private float _distance;
		[HideInInspector]
		[SerializeField]
		private float _afterglow;
		[HideInInspector]
		[SerializeField]
		private float _floatingRange;
		[HideInInspector]
		[SerializeField]
		private float _homingStartSecond;
		[HideInInspector]
		[SerializeField]
		private float _homingEndSecond;
		[HideInInspector]
		[SerializeField]
		private float _homingInterpolationAngle;
		[HideInInspector]
		[SerializeField]
		private bool _useHomingInterpolationAngleCurve;
		[HideInInspector]
		[SerializeField]
		private AnimationCurve _homingInterpolationAngleCurve;
		[HideInInspector]
		[SerializeField]
		private Vector3 _homingTargetOffsetL;
		[HideInInspector]
		[SerializeField]
		private Vector3 _homingTargetOffsetH;
		[HideInInspector]
		[SerializeField]
		private bool _isAimTargetGround;
		[HideInInspector]
		[SerializeField]
		private bool _isAimTargetNearest;
		[HideInInspector]
		[SerializeField]
		private bool _isHomingInvalidOnTargetDead;
		[HideInInspector]
		[SerializeField]
		private EffectData _hitEffect;
		[HideInInspector]
		[SerializeField]
		private EffectData _hitEffectGround;
		[HideInInspector]
		[SerializeField]
		private bool _useHitEffectGround;
		[HideInInspector]
		[SerializeField]
		private bool _isInvalidHitEffectOnDurationEnd;
		[HideInInspector]
		[SerializeField]
		private ActionCollision _collision;
		[HideInInspector]
		[SerializeField]
		private ActionCollisionPos _collisionPosId;
		[HideInInspector]
		[SerializeField]
		private bool _isCollisionSlotFront;
		[HideInInspector]
		[SerializeField]
		private Vector3 _collisionOffset;
		[HideInInspector]
		[SerializeField]
		private bool _useOwnerScaleCollision;
		[HideInInspector]
		[SerializeField]
		private float _collisionParams_01;
		[HideInInspector]
		[SerializeField]
		private float _collisionParams_02;
		[HideInInspector]
		[SerializeField]
		private float _collisionParams_03;
		[HideInInspector]
		[SerializeField]
		private float _collisionParams_05;
		[HideInInspector]
		[SerializeField]
		private float _collisionParams_06;
		public const float DEFAULT_BULLET_HIT_INTERVAL = 0.5f;
		[HideInInspector]
		[SerializeField]
		private float _collisionHitInterval;
		[HideInInspector]
		[SerializeField]
		private ArrangeBulletData _arrangeBullet;
		[HideInInspector]
		[SerializeField]
		private int _addNum;
		[HideInInspector]
		[SerializeField]
		private string _distinctionTag;
		[HideInInspector]
		[SerializeField]
		private ArrangeBulletData[] _additionalCollision;
		[HideInInspector]
		[SerializeField]
		private int _sameTimeHitId;
		[HideInInspector]
		[SerializeField]
		private bool _isAppearSpecialGimmick;
		[HideInInspector]
		[SerializeField]
		private float _appearSpecialGimmickLifeTime;
		[HideInInspector]
		[SerializeField]
		private bool _appearSpecialGimmickShowMarker;
	
		// Properties
		public InGameDef.CharacterType characterType { get; }
		public string hitAttrLabel { get; }
		public string hitAttrLabel2nd { get; }
		public bool useSameComponent { get; }
		public bool useElementalHit { get; }
		public string[] elementalHitLabel { get; }
		public float bulletDuration { get; }
		public float waitTime { get; }
		public float delayTime { get; }
		public bool delayVisible { get; }
		public bool isKeepDirectionOnFire { get; }
		public bool isHitDelete { get; }
		public bool isHitGroundDelete { get; }
		public bool isHitInvisibleObstacle { get; }
		public bool notHitObstacle { get; }
		public float attenuationRate { get; }
		public ReboundType rebound { get; }
		public string reboundSEName { get; }
		public bool isSyncHitProcess { get; }
		public bool isUseBulletModel { get; }
		public DragonDecoration decoId { get; }
		public string effectName { get; }
		public string effectNameForLowestQuality { get; }
		public string[] elementalEffectName { get; }
		public bool isHitAttributeShift { get; }
		public string effectNameHAS { get; }
		public int effectTriggerIdx { get; }
		public bool effectInfluencedCharaterElement { get; }
		public bool effectUseElementalTrigger { get; }
		public bool effectUseMarkerTrigger { get; }
		public int effectTimedTrigger { get; }
		public int effectTimedTriggerFrame { get; }
		public EffectObject.EraseType effectEraseType { get; }
		public float effectDisappearTime { get; }
		public bool isKeepEffectAfterStop { get; }
		public string fireSEName { get; }
		public string hitSEName { get; }
		public bool hitSEFlagTerrain { get; }
		public bool disablePlayNormalHitSE { get; }
		public string hitSENameTerrain { get; }
		public bool useHitCameraShake { get; }
		public CameraController.ShakeType hitCameraShake { get; }
		public CameraController.ShakePriority cameraShakePriority { get; }
		public bool hitCameraShakeFlagTerrain { get; }
		public CameraController.ShakeType hitCameraShakeTerrain { get; }
		public CameraController.ShakePriority cameraShakePriorityTerrain { get; }
		public bool isAppearChild { get; }
		public int childNumber { get; }
		public int childActionId { get; }
		public BulletWithMarkerData.AppearChildRotationBase appearChildRotationBase { get; }
		public float childDirection { get; }
		public bool childPopedInvincible { get; }
		public bool isAppearChildHostSync { get; }
		public bool isAppearChildOnHitChara { get; }
		public bool isChildTargetHitChara { get; }
		public bool isChildTargetBulletTargetChara { get; }
		public GenerateStyle generateStyle { get; }
		public string generateNodeName { get; }
		public float generateNear { get; }
		public int loadPositionId { get; }
		public Vector3 offsetPos { get; }
		public Vector3 directionRot { get; }
		public Vector3 offsetScale { get; }
		public bool useOwnerScaleEffect { get; }
		public BulletObject.DirectionType directionType { get; }
		public string targetDistinctionTag { get; }
		public bool deleteTargetBulletOnHit { get; }
		public float nearest { get; }
		public bool generateInTheWall { get; }
		public float bulletSpeed { get; }
		public bool useSpeedCurve { get; }
		public AnimationCurve speedCurve { get; }
		public float distance { get; }
		public float afterglow { get; }
		public float floatingRange { get; }
		public float homingStartSecond { get; }
		public float homingEndSecond { get; }
		public float homingInterpolationAngle { get; }
		public bool useHomingInterpolationAngleCurve { get; }
		public AnimationCurve homingInterpolationAngleCurve { get; }
		public Vector3 homingTargetOffsetL { get; }
		public Vector3 homingTargetOffsetH { get; }
		public bool isAimTargetGround { get; }
		public bool isAimTargetNearest { get; }
		public bool isHomingInvalidOnTargetDead { get; }
		public EffectData hitEffect { get; }
		public EffectData hitEffectGround { get; }
		public bool useHitEffectGround { get; }
		public bool isInvalidHitEffectOnDurationEnd { get; }
		public ActionCollision collisionShape { get; }
		public ActionCollisionPos collisionPosId { get; }
		public bool isCollisionSlotFront { get; }
		public Vector3 collisionOffset { get; }
		public bool useOwnerScaleCollision { get; }
		public float collisionParams01 { get; }
		public float collisionParams02 { get; }
		public float collisionParams03 { get; }
		public float collisionParams05 { get; }
		public float collisionParams06 { get; }
		public float collisionHitInterval { get; }
		public ArrangeBulletData arrangeBullet { get; }
		public int addNum { get; }
		public string distinctionTag { get; }
		public ArrangeBulletData[] additionalCollision { get; }
		public int sameTimeHitId { get; }
		public bool isAppearSpecialGimmick { get; }
		public float appearSpecialGimmickLifeTime { get; }
		public bool appearSpecialGimmickShowMarker { get; }
	
		// Nested types
		public enum AlignAxis
		{
			X = 0,
			Y = 1,
			Z = 2
		}
	
		public enum ReboundType
		{
			None = 0,
			Wall = 1,
			Transmission = 2
		}
	
		public enum GenerateStyle
		{
			Root = 0,
			Center = 1,
			CenterFront = 2,
			FootGround = 3,
			FootGroundFront = 4,
			Node = 5,
			Hostile = 6,
			MarkerUpRandom = 7,
			AreaAnchor = 8,
			HostileGround = 9,
			SpecifyId = 10,
			StockBullet = 11
		}
	
		// Constructors
		public BulletData();
	}
}
