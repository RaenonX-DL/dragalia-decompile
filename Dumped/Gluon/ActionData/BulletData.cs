using System;
using System.Collections.Generic;
using Gluon.Bullet;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class BulletData : ActionParts.PartsData
	{
		public enum AlignAxis
		{
			X,
			Y,
			Z
		}

		public enum ReboundType
		{
			None,
			Wall,
			Transmission
		}

		public enum GenerateStyle
		{
			Root,
			Center,
			CenterFront,
			FootGround,
			FootGroundFront,
			Node,
			Hostile,
			MarkerUpRandom,
			AreaAnchor,
			HostileGround,
			SpecifyId,
			StockBullet,
			SelfTarget,
			SelfTargetGround
		}

		[SerializeField]
		[HideInInspector]
		private InGameDef.CharacterType _characterType;

		[SerializeField]
		[HideInInspector]
		private string _hitAttrLabel;

		[SerializeField]
		[HideInInspector]
		private List<string> _hitAttrLabelSubList;

		[SerializeField]
		[HideInInspector]
		private bool _useSameComponent;

		[SerializeField]
		[HideInInspector]
		private bool _noHitCheck;

		[SerializeField]
		[HideInInspector]
		private bool _useElementalHit;

		[SerializeField]
		[HideInInspector]
		private string[] _elementalHitLabel;

		[SerializeField]
		[HideInInspector]
		private float _bulletDuration;

		[SerializeField]
		[HideInInspector]
		private float _waitTime;

		[SerializeField]
		[HideInInspector]
		private bool _isReserveFireBulletForWaiting;

		[SerializeField]
		[HideInInspector]
		private float _delayTime;

		[SerializeField]
		[HideInInspector]
		private bool _isDelayAffectedBySpeedFactor;

		[SerializeField]
		[HideInInspector]
		private bool _delayVisible;

		[SerializeField]
		[HideInInspector]
		private bool _isKeepDirectionOnFire;

		[SerializeField]
		[HideInInspector]
		private bool _isHitDelete;

		[SerializeField]
		[HideInInspector]
		private bool _isHitGroundDelete;

		[SerializeField]
		[HideInInspector]
		private bool _isHitInvisibleObstacle;

		[SerializeField]
		[HideInInspector]
		private bool _notHitObstacle;

		[SerializeField]
		[HideInInspector]
		private float _attenuationRate;

		[SerializeField]
		[HideInInspector]
		private ReboundType _rebound;

		[SerializeField]
		[HideInInspector]
		private string _reboundSEName;

		[SerializeField]
		[HideInInspector]
		private bool _isSyncHitProcess;

		[SerializeField]
		[HideInInspector]
		private bool _isUseBulletModel;

		[SerializeField]
		[HideInInspector]
		private DragonDecoration _decoId;

		[SerializeField]
		[HideInInspector]
		private string _effectName;

		[SerializeField]
		[HideInInspector]
		private string _effectNameForLowestQuality;

		[SerializeField]
		[HideInInspector]
		private string[] _elementalEffectName;

		[SerializeField]
		[HideInInspector]
		private bool _isHitAttributeShift;

		[SerializeField]
		[HideInInspector]
		private string _effectNameHAS;

		[SerializeField]
		[HideInInspector]
		private int _effectTriggerIdx;

		[SerializeField]
		[HideInInspector]
		private bool _effectInfluencedCharaterElement;

		[SerializeField]
		[HideInInspector]
		private bool _effectUseElementalTrigger;

		[SerializeField]
		[HideInInspector]
		private bool _effectUseMarkerTrigger;

		[SerializeField]
		[HideInInspector]
		private int _effectTimedTrigger;

		[SerializeField]
		[HideInInspector]
		private int _effectTimedTriggerFrame;

		[SerializeField]
		[HideInInspector]
		private EffectObject.EraseType _effectEraseType;

		[SerializeField]
		[HideInInspector]
		private float _effectDisappearTime;

		[SerializeField]
		[HideInInspector]
		private bool _isKeepEffectAfterStop;

		[SerializeField]
		[HideInInspector]
		private bool _isSeparatelyLoadEffect;

		[SerializeField]
		[HideInInspector]
		private string _fireSEName;

		[SerializeField]
		[HideInInspector]
		private string _hitSEName;

		[SerializeField]
		[HideInInspector]
		private bool _hitSEFlagTerrain;

		[SerializeField]
		[HideInInspector]
		private bool _disablePlayNormalHitSE;

		[SerializeField]
		[HideInInspector]
		private string _hitSENameTerrain;

		[SerializeField]
		[HideInInspector]
		private bool _useHitCameraShake;

		[SerializeField]
		[HideInInspector]
		private CameraController.ShakeType _hitCameraShake;

		[SerializeField]
		[HideInInspector]
		private CameraController.ShakePriority _cameraShakePriority;

		[SerializeField]
		[HideInInspector]
		private bool _hitCameraShakeFlagTerrain;

		[SerializeField]
		[HideInInspector]
		private CameraController.ShakeType _hitCameraShakeTerrain;

		[SerializeField]
		[HideInInspector]
		private CameraController.ShakePriority _cameraShakePriorityTerrain;

		[SerializeField]
		[HideInInspector]
		private bool _isAppearChild;

		[SerializeField]
		[HideInInspector]
		private int _childNumber;

		[SerializeField]
		[HideInInspector]
		private int _childActionId;

		[SerializeField]
		[HideInInspector]
		private BulletWithMarkerData.AppearChildRotationBase _appearChildRotationBase;

		[SerializeField]
		[HideInInspector]
		private float _childDirection;

		[SerializeField]
		[HideInInspector]
		private bool _childPopedInvincible;

		[SerializeField]
		[HideInInspector]
		private bool _isAppearChildHostSync;

		[SerializeField]
		[HideInInspector]
		private bool _isAppearChildOnHitChara;

		[SerializeField]
		[HideInInspector]
		private bool _isChildTargetHitChara;

		[SerializeField]
		[HideInInspector]
		private bool _isChildTargetBulletTargetChara;

		[SerializeField]
		[HideInInspector]
		private bool _ignoreInitInheritedHitAttr;

		[SerializeField]
		[HideInInspector]
		private GenerateStyle _generateStyle;

		[SerializeField]
		[HideInInspector]
		private string _generateNodeName;

		[SerializeField]
		[HideInInspector]
		private float _generateNear;

		[SerializeField]
		[HideInInspector]
		private int _loadPositionId;

		[SerializeField]
		[HideInInspector]
		private Vector3 _offsetPos;

		[SerializeField]
		[HideInInspector]
		private Vector3 _directionRot;

		[SerializeField]
		[HideInInspector]
		private Vector3 _offsetScale;

		[SerializeField]
		[HideInInspector]
		private bool _useOwnerScaleEffect;

		[SerializeField]
		[HideInInspector]
		private BulletObject.DirectionType _directionType;

		[SerializeField]
		[HideInInspector]
		private string _targetDistinctionTag;

		[SerializeField]
		[HideInInspector]
		private bool _deleteTargetBulletOnHit;

		[SerializeField]
		[HideInInspector]
		private float _nearest;

		[SerializeField]
		[HideInInspector]
		private bool _generateInTheWall;

		[SerializeField]
		[HideInInspector]
		private float _bulletSpeed;

		[SerializeField]
		[HideInInspector]
		private bool _useSpeedCurve;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve _speedCurve;

		[SerializeField]
		[HideInInspector]
		private float _distance;

		[SerializeField]
		[HideInInspector]
		private float _afterglow;

		[SerializeField]
		[HideInInspector]
		private float _floatingRange;

		[SerializeField]
		[HideInInspector]
		private float _homingStartSecond;

		[SerializeField]
		[HideInInspector]
		private float _homingEndSecond;

		[SerializeField]
		[HideInInspector]
		private float _homingInterpolationAngle;

		[SerializeField]
		[HideInInspector]
		private bool _useHomingInterpolationAngleCurve;

		[SerializeField]
		[HideInInspector]
		private AnimationCurve _homingInterpolationAngleCurve;

		[SerializeField]
		[HideInInspector]
		private bool _freezeHomingYAxis;

		[SerializeField]
		[HideInInspector]
		private bool _stopMovingForNoTarget;

		[SerializeField]
		[HideInInspector]
		private Vector3 _homingTargetOffsetL;

		[SerializeField]
		[HideInInspector]
		private Vector3 _homingTargetOffsetH;

		[SerializeField]
		[HideInInspector]
		private bool _isAimTargetGround;

		[SerializeField]
		[HideInInspector]
		private bool _isAimTargetNearest;

		[SerializeField]
		[HideInInspector]
		private bool _isHomingInvalidOnTargetDead;

		[SerializeField]
		[HideInInspector]
		private EffectData _hitEffect;

		[SerializeField]
		[HideInInspector]
		private EffectData _hitEffectGround;

		[SerializeField]
		[HideInInspector]
		private bool _useHitEffectGround;

		[SerializeField]
		[HideInInspector]
		private bool _isInvalidHitEffectOnDurationEnd;

		[SerializeField]
		[HideInInspector]
		private ActionCollision _collision;

		[SerializeField]
		[HideInInspector]
		private ActionCollisionPos _collisionPosId;

		[SerializeField]
		[HideInInspector]
		private bool _isCollisionSlotFront;

		[SerializeField]
		[HideInInspector]
		private Vector3 _collisionOffset;

		[SerializeField]
		[HideInInspector]
		private bool _useOwnerScaleCollision;

		[SerializeField]
		[HideInInspector]
		private float _collisionParams_01;

		[SerializeField]
		[HideInInspector]
		private float _collisionParams_02;

		[SerializeField]
		[HideInInspector]
		private float _collisionParams_03;

		[SerializeField]
		[HideInInspector]
		private float _collisionParams_05;

		[SerializeField]
		[HideInInspector]
		private float _collisionParams_06;

		public const float DEFAULT_BULLET_HIT_INTERVAL = 0.5f;

		[SerializeField]
		[HideInInspector]
		private float _collisionHitInterval;

		[SerializeField]
		[HideInInspector]
		private bool _useAccurateCollisionHitInterval;

		[SerializeField]
		[HideInInspector]
		private ArrangeBulletData _arrangeBullet;

		[SerializeField]
		[HideInInspector]
		private int _addNum;

		[SerializeField]
		[HideInInspector]
		private string _distinctionTag;

		[SerializeField]
		[HideInInspector]
		private ArrangeBulletData[] _additionalCollision;

		[SerializeField]
		[HideInInspector]
		private int _sameTimeHitId;

		[SerializeField]
		[HideInInspector]
		private bool _isAppearSpecialGimmick;

		[SerializeField]
		[HideInInspector]
		private float _appearSpecialGimmickLifeTime;

		[SerializeField]
		[HideInInspector]
		private bool _appearSpecialGimmickShowMarker;

		public InGameDef.CharacterType characterType => default(InGameDef.CharacterType);

		public string hitAttrLabel => null;

		public List<string> hitAttrLabelSubList => null;

		public bool useSameComponent => default(bool);

		public bool noHitCheck => default(bool);

		public bool useElementalHit => default(bool);

		public string[] elementalHitLabel => null;

		public float bulletDuration => default(float);

		public float waitTime => default(float);

		public bool isReserveFireBulletForWaiting => default(bool);

		public float delayTime => default(float);

		public bool isDelayAffectedBySpeedFactor => default(bool);

		public bool delayVisible => default(bool);

		public bool isKeepDirectionOnFire => default(bool);

		public bool isHitDelete => default(bool);

		public bool isHitGroundDelete => default(bool);

		public bool isHitInvisibleObstacle => default(bool);

		public bool notHitObstacle => default(bool);

		public float attenuationRate => default(float);

		public ReboundType rebound => default(ReboundType);

		public string reboundSEName => null;

		public bool isSyncHitProcess => default(bool);

		public bool isUseBulletModel => default(bool);

		public DragonDecoration decoId => default(DragonDecoration);

		public string effectName => null;

		public string effectNameForLowestQuality => null;

		public string[] elementalEffectName => null;

		public bool isHitAttributeShift => default(bool);

		public string effectNameHAS => null;

		public int effectTriggerIdx => default(int);

		public bool effectInfluencedCharaterElement => default(bool);

		public bool effectUseElementalTrigger => default(bool);

		public bool effectUseMarkerTrigger => default(bool);

		public int effectTimedTrigger => default(int);

		public int effectTimedTriggerFrame => default(int);

		public EffectObject.EraseType effectEraseType => default(EffectObject.EraseType);

		public float effectDisappearTime => default(float);

		public bool isKeepEffectAfterStop => default(bool);

		public bool isSeparatelyLoadEffect => default(bool);

		public string fireSEName => null;

		public string hitSEName => null;

		public bool hitSEFlagTerrain => default(bool);

		public bool disablePlayNormalHitSE => default(bool);

		public string hitSENameTerrain => null;

		public bool useHitCameraShake => default(bool);

		public CameraController.ShakeType hitCameraShake => default(CameraController.ShakeType);

		public CameraController.ShakePriority cameraShakePriority => default(CameraController.ShakePriority);

		public bool hitCameraShakeFlagTerrain => default(bool);

		public CameraController.ShakeType hitCameraShakeTerrain => default(CameraController.ShakeType);

		public CameraController.ShakePriority cameraShakePriorityTerrain => default(CameraController.ShakePriority);

		public bool isAppearChild => default(bool);

		public int childNumber => default(int);

		public int childActionId => default(int);

		public BulletWithMarkerData.AppearChildRotationBase appearChildRotationBase => default(BulletWithMarkerData.AppearChildRotationBase);

		public float childDirection => default(float);

		public bool childPopedInvincible => default(bool);

		public bool isAppearChildHostSync => default(bool);

		public bool isAppearChildOnHitChara => default(bool);

		public bool isChildTargetHitChara => default(bool);

		public bool isChildTargetBulletTargetChara => default(bool);

		public bool ignoreInitInheritedHitAttr => default(bool);

		public GenerateStyle generateStyle => default(GenerateStyle);

		public string generateNodeName => null;

		public float generateNear => default(float);

		public int loadPositionId => default(int);

		public Vector3 offsetPos => default(Vector3);

		public Vector3 directionRot => default(Vector3);

		public Vector3 offsetScale => default(Vector3);

		public bool useOwnerScaleEffect => default(bool);

		public BulletObject.DirectionType directionType => default(BulletObject.DirectionType);

		public string targetDistinctionTag => null;

		public bool deleteTargetBulletOnHit => default(bool);

		public float nearest => default(float);

		public bool generateInTheWall => default(bool);

		public float bulletSpeed => default(float);

		public bool useSpeedCurve => default(bool);

		public AnimationCurve speedCurve => null;

		public float distance => default(float);

		public float afterglow => default(float);

		public float floatingRange => default(float);

		public float homingStartSecond => default(float);

		public float homingEndSecond => default(float);

		public float homingInterpolationAngle => default(float);

		public bool useHomingInterpolationAngleCurve => default(bool);

		public AnimationCurve homingInterpolationAngleCurve => null;

		public bool freezeHomingYAxis => default(bool);

		public bool stopMovingForNoTarget => default(bool);

		public Vector3 homingTargetOffsetL => default(Vector3);

		public Vector3 homingTargetOffsetH => default(Vector3);

		public bool isAimTargetGround => default(bool);

		public bool isAimTargetNearest => default(bool);

		public bool isHomingInvalidOnTargetDead => default(bool);

		public EffectData hitEffect => null;

		public EffectData hitEffectGround => null;

		public bool useHitEffectGround => default(bool);

		public bool isInvalidHitEffectOnDurationEnd => default(bool);

		public ActionCollision collisionShape => default(ActionCollision);

		public ActionCollisionPos collisionPosId => default(ActionCollisionPos);

		public bool isCollisionSlotFront => default(bool);

		public Vector3 collisionOffset => default(Vector3);

		public bool useOwnerScaleCollision => default(bool);

		public float collisionParams01 => default(float);

		public float collisionParams02 => default(float);

		public float collisionParams03 => default(float);

		public float collisionParams05 => default(float);

		public float collisionParams06 => default(float);

		public float collisionHitInterval => default(float);

		public bool useAccurateCollisionHitInterval => default(bool);

		public ArrangeBulletData arrangeBullet => null;

		public int addNum => default(int);

		public string distinctionTag => null;

		public ArrangeBulletData[] additionalCollision => null;

		public int sameTimeHitId => default(int);

		public bool isAppearSpecialGimmick => default(bool);

		public float appearSpecialGimmickLifeTime => default(float);

		public bool appearSpecialGimmickShowMarker => default(bool);
	}
}
