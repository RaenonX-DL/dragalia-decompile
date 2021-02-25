/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using Gluon.Bullet;
using Gluon.CharacterUniqueGimmick;
using Gluon.Dungeon;
using Gluon.Dungeon.Gimmick;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterBase : CharacterRenderBase
	{
		// Fields
		protected string attackCueName;
		protected string dashAttackCueName;
		protected string burstAttackCueName;
		protected string skillCueName;
		protected string damageCueName;
		protected string blastCueName;
		protected string avoidCueName;
		protected string continueCueName;
		protected string changePlayerCueName;
		protected string dragonTransformCueName;
		protected string winCueName;
		protected string questFailedCueName;
		protected string talkCueNamePrefix;
		[CompilerGenerated]
		private CharacterBase _lastAttackedCharacter_k__BackingField;
		[CompilerGenerated]
		private Vector3 _lastAttackedPosition_k__BackingField;
		private Vector3 _lastHitPosition;
		private Quaternion _lastHitRotation;
		public List<Vector3> registeredPositionList;
		private bool _enableSetSp;
		[CompilerGenerated]
		private int _characterId_k__BackingField;
		protected int _thisLayer;
		[CompilerGenerated]
		private int _dungeonPartyIndex_k__BackingField;
		[CompilerGenerated]
		private int _actorIndex_k__BackingField;
		[CompilerGenerated]
		private int _partySwitchIndex_k__BackingField;
		[CompilerGenerated]
		private int _dungeonPartyPosition_k__BackingField;
		[CompilerGenerated]
		private CharacterId _multiPlayId_k__BackingField;
		[CompilerGenerated]
		private int _battleGroup_k__BackingField;
		[CompilerGenerated]
		private InGameDef.CharacterType _type_k__BackingField;
		[CompilerGenerated]
		private HitType _hitType_k__BackingField;
		[CompilerGenerated]
		private CharacterParameter _param_k__BackingField;
		[CompilerGenerated]
		private bool _isSharingParam_k__BackingField;
		[CompilerGenerated]
		private float _prevHp_k__BackingField;
		private int[] prevSp;
		[CompilerGenerated]
		private int _attackWhenAdditionalAttackBuffReceived_k__BackingField;
		public string additionAttackEffect;
		[CompilerGenerated]
		private float _defCoef_k__BackingField;
		[CompilerGenerated]
		private ElementalType _element_k__BackingField;
		[CompilerGenerated]
		private SecondElementsUniqueCtrl.ElementType _secondElement_k__BackingField;
		[CompilerGenerated]
		private bool _resistBuffDebuff_k__BackingField;
		[CompilerGenerated]
		private CharacterAbnormalStatus _abnormalStatus_k__BackingField;
		[CompilerGenerated]
		private bool _resistAllAbnormal_k__BackingField;
		[CompilerGenerated]
		private float _hpDrainValue_k__BackingField;
		[CompilerGenerated]
		private float _hpDrainBuffValue_k__BackingField;
		[CompilerGenerated]
		private CharacterBase _hpDrainTarget_k__BackingField;
		[CompilerGenerated]
		private bool _isExecSelfDamage_k__BackingField;
		[CompilerGenerated]
		private int _timeStopDamage_k__BackingField;
		[CompilerGenerated]
		private float _exAbility2ImmutableHp_k__BackingField;
		[CompilerGenerated]
		private bool _nextCtrlChara_k__BackingField;
		public FollowerController followerController;
		[CompilerGenerated]
		private float _disableAvoidSecForFollower_k__BackingField;
		[CompilerGenerated]
		private bool _isGuest_k__BackingField;
		[CompilerGenerated]
		private int _aiType_k__BackingField;
		[CompilerGenerated]
		private bool _isEnemyTarget_k__BackingField;
		[CompilerGenerated]
		private ChainCtrl _chainCtrl_k__BackingField;
		[CompilerGenerated]
		private CharacterColor _colorCtrl_k__BackingField;
		[CompilerGenerated]
		private CharacterEffect _effectCtrl_k__BackingField;
		[CompilerGenerated]
		private CharacterSound _soundCtrl_k__BackingField;
		[CompilerGenerated]
		private InvincibleControl _invincibleCtrl_k__BackingField;
		protected bool _isDamageImmunity;
		[CompilerGenerated]
		private bool _isStop1_k__BackingField;
		[CompilerGenerated]
		private bool _isForceDead_k__BackingField;
		[CompilerGenerated]
		private bool _wasForcedDead_k__BackingField;
		protected ControlDeath _ctrlDeath;
		[CompilerGenerated]
		private bool _isBreakMode_k__BackingField;
		[CompilerGenerated]
		private bool _isBarrierMode_k__BackingField;
		[CompilerGenerated]
		private bool _isPause_k__BackingField;
		[CompilerGenerated]
		private bool _isPauseAction_k__BackingField;
		[CompilerGenerated]
		private bool _hasDesignatedHitEffect_k__BackingField;
		[CompilerGenerated]
		private bool _hasDesignatedHitSE_k__BackingField;
		[CompilerGenerated]
		private bool _isPlayNormalHitSE_k__BackingField;
		[CompilerGenerated]
		private bool _isNoSound_k__BackingField;
		[CompilerGenerated]
		private bool _isNoReaction_k__BackingField;
		[CompilerGenerated]
		private bool _isSuperArmor_k__BackingField;
		[CompilerGenerated]
		private bool _isDisableExternalVelocity_k__BackingField;
		[CompilerGenerated]
		private bool _isExtraActionMode_k__BackingField;
		[CompilerGenerated]
		private bool _isSpacialDead_k__BackingField;
		[CompilerGenerated]
		private bool _isNoTarget_k__BackingField;
		private bool isInvalidBlastForNoDamage;
		[CompilerGenerated]
		private bool _isEnableAdditionalInput_k__BackingField;
		[CompilerGenerated]
		private int _additionalInputCount_k__BackingField;
		[CompilerGenerated]
		private bool _reachMaxAdditionalInput_k__BackingField;
		[CompilerGenerated]
		private int _additionalCount_k__BackingField;
		public readonly int AdditionalActionEffectBeginTrigger;
		public int AdditionalInputlastKickedTrigger;
		[CompilerGenerated]
		private bool _isUnusualPosture_k__BackingField;
		[CompilerGenerated]
		private bool _isNoCancelActionOnFreese_k__BackingField;
		[SerializeField]
		private bool _isSpecialHate;
		[CompilerGenerated]
		private int _superArmorLv_k__BackingField;
		private CharacterStates _state;
		[CompilerGenerated]
		private CharacterStates _prevState_k__BackingField;
		protected StateMachine<CharacterBase> stateMachine;
		[CompilerGenerated]
		private short _stateIndex_k__BackingField;
		private short bulletIndex;
		private BulletManager _bulletManager;
		protected float _moveSpeed;
		protected float _dashSpeedRatio;
		[CompilerGenerated]
		private float _curseMoveSpeedRatio_k__BackingField;
		[CompilerGenerated]
		private Vector3 _actionMoveVelocity_k__BackingField;
		[CompilerGenerated]
		private Vector3 _externalVelocity_k__BackingField;
		[CompilerGenerated]
		private Vector3 _panelMoveVelocity_k__BackingField;
		[CompilerGenerated]
		private Vector3 _skillMoveVelocity_k__BackingField;
		[CompilerGenerated]
		private Vector3 _slipMoveVelocity_k__BackingField;
		[CompilerGenerated]
		private ChargeMarker _chargeMarker_k__BackingField;
		[CompilerGenerated]
		private ChargeMarker[] _nextLevelChargeMarkers_k__BackingField;
		[CompilerGenerated]
		private ChargeMarker _originalChargeMarker_k__BackingField;
		[CompilerGenerated]
		private int _chargeMarkerBulletEffectTriggerId_k__BackingField;
		[CompilerGenerated]
		private float _chargePullLength_k__BackingField;
		[CompilerGenerated]
		private Vector3 _chargeMovePosition_k__BackingField;
		[CompilerGenerated]
		private Vector3 _chargeForward_k__BackingField;
		[CompilerGenerated]
		private Vector3 _chargeMarkerPos_k__BackingField;
		protected AttackHit attackHit;
		private CharacterDamageIntermediate _damageIntermediate;
		[SerializeField]
		public float _rotateSpeed;
		private float _speedRate;
		[CompilerGenerated]
		private float _motionSpeed_k__BackingField;
		[CompilerGenerated]
		private float _actionSpeedScale_k__BackingField;
		public CharacterHitStopCaster hitStopCaster;
		public CharacterHitStopPlayer hitStopPlayer;
		[SerializeField]
		protected float _scaleRate;
		protected float _prevScaleRate;
		[CompilerGenerated]
		private float _baseScaleRate_k__BackingField;
		private float _baseRadius;
		private float _baseHeight;
		[CompilerGenerated]
		private NavMeshAgent _navMeshAgent_k__BackingField;
		[CompilerGenerated]
		private Collider _collisionCollide_k__BackingField;
		public EnemyCylinderCollider enemyCylinderCollider;
		[CompilerGenerated]
		private Animator _animator_k__BackingField;
		[CompilerGenerated]
		private RuntimeAnimatorController _defaultAnimatorController_k__BackingField;
		private AnimatorCullingMode _defaultAnimatorCullMode;
		[CompilerGenerated]
		private Rigidbody _rigidBody_k__BackingField;
		protected CharacterExternalMove externalMove;
		[CompilerGenerated]
		private CharacterFreeFall _freeFall_k__BackingField;
		[CompilerGenerated]
		private CharacterSlipCtrl _slipCtrl_k__BackingField;
		[CompilerGenerated]
		private Transform _rootTransform_k__BackingField;
		[CompilerGenerated]
		private Transform _centerTransform_k__BackingField;
		[CompilerGenerated]
		private Transform _headTransform_k__BackingField;
		[CompilerGenerated]
		private Transform _hipTransform_k__BackingField;
		[CompilerGenerated]
		private Transform _weaponLTransform_k__BackingField;
		[CompilerGenerated]
		private Transform _weaponRTransform_k__BackingField;
		[CompilerGenerated]
		private Transform _muzzleTransform_k__BackingField;
		protected float _localTimeScale;
		private Dictionary<int, ActionContainer> dictAction;
		protected List<ActionBase> _actions;
		[CompilerGenerated]
		private int _lastActionId_k__BackingField;
		[CompilerGenerated]
		private int _nextActionIdForSendSignal_k__BackingField;
		[CompilerGenerated]
		private bool _useAction_k__BackingField;
		[CompilerGenerated]
		private bool _hasFirstAction_k__BackingField;
		[CompilerGenerated]
		private int _carrySequenceId_k__BackingField;
		private CharacterBase _carryTarget;
		[CompilerGenerated]
		private bool _isCarryConfirmed_k__BackingField;
		[CompilerGenerated]
		private float _carryTimer_k__BackingField;
		private float releaseCarriedTimer;
		[CompilerGenerated]
		private int _ParentBulletId_k__BackingField;
		private List<ReserveAction> _reserveActions;
		[CompilerGenerated]
		private CommonObjectStatus _targetObject_k__BackingField;
		[CompilerGenerated]
		private Action<int, int[], float[], RunActionEvent, bool> stateChangedEvent;
		[CompilerGenerated]
		private Action<CharacterBase> deadEvent;
		public Action deadEndEvent;
		[CompilerGenerated]
		private Action initStateEvent;
		private List<ResponseEventAction> _responseEventActions;
		[CompilerGenerated]
		private float _approachEventActionRange_k__BackingField;
		[CompilerGenerated]
		private EventActionData.TargetType _approachEventActionTargetType_k__BackingField;
		[CompilerGenerated]
		private string _approachEventTargetEnemyName_k__BackingField;
		[CompilerGenerated]
		private int _approachEventId_k__BackingField;
		private int _receivedApproachEventId;
		private Coroutine _delayActionCoroutine;
		public CharacterBase murdererCharacter;
		private List<EffectObject> _attachEffects;
		private List<EffectObject> stateAttackEffects;
		private Vector3 _pivotBase;
		[CompilerGenerated]
		private Vector3 _basePosition_k__BackingField;
		private Transform _areaAnchor;
		[CompilerGenerated]
		private EnemyOutsideWall _enemyCheckOutside_k__BackingField;
		private Vector3 _previousPosition;
		private bool _isCheckWall;
		private bool slipMoving;
		private static CharacterManager _charaManForOutside;
		private List<int> _listActionId;
		[CompilerGenerated]
		private int _currentCombo_k__BackingField;
		[CompilerGenerated]
		private bool _isShiftPrevCombo_k__BackingField;
		[CompilerGenerated]
		private float _chargePrepareTime_k__BackingField;
		[CompilerGenerated]
		private Vector3 _moveStartDirection_k__BackingField;
		[CompilerGenerated]
		private int _reserveActionId_k__BackingField;
		[CompilerGenerated]
		private int _reserveSkillIndex_k__BackingField;
		protected CharacterStateBase reserveActionState;
		[CompilerGenerated]
		private Vector3? _reserveDirection_k__BackingField;
		protected CommonObjectStatus reserveActionTarget;
		public Dictionary<int, int> actionHitCountDic;
		public Dictionary<int, List<CharacterBase>> actionHitCharaDic;
		[CompilerGenerated]
		private ActionHitRecord _actionHitRecord_k__BackingField;
		public List<int> _listOneTimeTalkAction;
		private GameObject[] _shadowObject;
		private Transform _shadowTrans;
		private Projector _shadowProjector;
		private const float kShadowSizeCoef = 0.6f;
		public float dynamicShadowScale;
		private List<ReservableActionInfo> _reservableActionIdList;
		private List<int> _activeCancelActionIdList;
		private List<int> _needCheckListOfActionShiftByInputSkillActionId;
		protected Dictionary<int, AttachObject> _attachObjects;
		private int mainWeaponIndex;
		private int decoWeaponIndex;
		private int defaultMainWeaponIndex;
		private int defaultDecoWeaponIndex;
		private bool ignoreCheckWeaponVisible;
		[CompilerGenerated]
		private GameObject _bulletObject_k__BackingField;
		[CompilerGenerated]
		private bool _isUsedTransformDragon_k__BackingField;
		private bool enableGlobalTimeScale;
		private static readonly float[] kCastMargin;
		private ShadowCastMethod _shadowCastMethod;
		private NotifyCharacter.Damage damageUI;
		[CompilerGenerated]
		private CharacterMoveEventClock _moveEventClock_k__BackingField;
		[CompilerGenerated]
		private AbnormalStatusMultiPlayService _AbnormalStatusMultiPlayService_k__BackingField;
		[CompilerGenerated]
		private WarpRoom.RoomGroup _warpRoomGroupId_k__BackingField;
		[CompilerGenerated]
		private bool _isSkipActionEndPlayIdleMotion_k__BackingField;
		[CompilerGenerated]
		private readonly CUGCtrl _uniqueGimmick_k__BackingField;
		[CompilerGenerated]
		private CtrlBind _ctrlBind_k__BackingField;
		public List<CharacterBase> BindTargets;
		public CharacterBase BindOwner;
		public DungeonObjectStatus BindOwnerGimmick;
		private CharacterDamageRecord damageRecord;
		[CompilerGenerated]
		private float _idleBlendDuration_k__BackingField;
		private AnimationBlendDurationOverrider animBlender;
		private CharacterSwitchingTexture[] characterSwitchingTextures;
		public Dictionary<int, int> usedSkillCountDictForAI;
		private int hidingLevel;
		public float brMoveSpeedRatio;
		public float brAttackRangeRatio;
		public float brSkillItemAtkRatio;
		public float brRecoverySpPerSec;
		public float brRecoverySp;
		public float brRecoveryDpPerSec;
		public float brRecoveryDp;
		public float brMinDamageCoef;
		public float brDecayStartDistance;
		public float brDecayEndDistance;
		[CompilerGenerated]
		private bool _isInvisibleByInsideBRHouse_k__BackingField;
		public Dictionary<int, int> skillProductIdDic;
		private const int ResourceIdOffset = 10000;
		private List<Coroutine> _coDelayEffects;
		private bool isResetChangeMeshRequested;
		private float lastWakeOnCollidedTime;
	
		// Properties
		public CharacterBase lastAttackedCharacter { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 lastAttackedPosition { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 lastHitPosition { get; set; }
		public Quaternion LastHitRotation { get; }
		public bool enableSetSp { get; set; }
		public int characterId { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public int dungeonPartyIndex { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int actorIndex { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int partySwitchIndex { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int dungeonPartyPosition { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CharacterId multiPlayId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int battleGroup { [CompilerGenerated] get; [CompilerGenerated] set; }
		public InGameDef.CharacterType type { [CompilerGenerated] get; [CompilerGenerated] set; }
		public HitType hitType { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CharacterParameter param { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isSharingParam { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int level { get; }
		public int hp { get; set; }
		public int maxHp { get; }
		public float hpRate { get; }
		public float prevHp { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float shpRate { get; }
		public int attack { get; }
		public int attackWhenAdditionalAttackBuffReceived { [CompilerGenerated] get; [CompilerGenerated] set; }
		public virtual float defense { get; }
		public float defCoef { [CompilerGenerated] get; [CompilerGenerated] set; }
		public ElementalType element { [CompilerGenerated] get; [CompilerGenerated] set; }
		public SecondElementsUniqueCtrl.ElementType secondElement { [CompilerGenerated] get; [CompilerGenerated] set; }
		public virtual CharacterBuff buffCtrl { get; }
		public bool resistBuffDebuff { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CharacterAbnormalStatus abnormalStatus { [CompilerGenerated] get; [CompilerGenerated] set; }
		public virtual CharacterAbnormalStatus abnormalStatusForDamageCalc { get; }
		public bool resistAllAbnormal { [CompilerGenerated] get; [CompilerGenerated] set; }
		protected float hpDrainValue { [CompilerGenerated] get; [CompilerGenerated] set; }
		protected float hpDrainBuffValue { [CompilerGenerated] get; [CompilerGenerated] set; }
		protected CharacterBase hpDrainTarget { [CompilerGenerated] get; [CompilerGenerated] set; }
		protected bool isExecSelfDamage { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int timeStopDamage { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float exAbility2ImmutableHp { [CompilerGenerated] get; [CompilerGenerated] set; }
		public virtual bool IsBoss { get; }
		public virtual bool IsRaidBoss { get; }
		public virtual bool IsStronger { get; }
		public bool nextCtrlChara { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isFollower { get; }
		protected float disableAvoidSecForFollower { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isGuest { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int aiType { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isEnemyTarget { [CompilerGenerated] get; [CompilerGenerated] set; }
		public ChainCtrl chainCtrl { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		protected CharacterColor colorCtrl { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CharacterEffect effectCtrl { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CharacterSound soundCtrl { [CompilerGenerated] get; [CompilerGenerated] set; }
		public InvincibleControl invincibleCtrl { [CompilerGenerated] get; [CompilerGenerated] set; }
		public virtual bool isDamageImmunity { get; set; }
		public bool isStop1 { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isDead { get; }
		public bool isForceDead { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool wasForcedDead { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public ControlDeath ctrlDeath { get; }
		public virtual bool isOverdriveMode { get; }
		public virtual bool isBreakMode { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public virtual bool isBarrierMode { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public virtual bool isActiveBoundaryAction { get; }
		public bool isPause { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isPauseAction { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool canFinishDragonOnPause { get; }
		public bool hasDesignatedHitEffect { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool hasDesignatedHitSE { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isPlayNormalHitSE { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isNoSound { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isNoReaction { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isSuperArmor { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isDisableExternalVelocity { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isExtraActionMode { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isSpacialDead { [CompilerGenerated] get; [CompilerGenerated] set; }
		public virtual bool isNoTarget { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isEnableAdditionalInput { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int additionalInputCount { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool reachMaxAdditionalInput { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int additionalCount { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isUnusualPosture { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isNoCancelActionOnFreese { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isSpecialHate { get; set; }
		public int superArmorLv { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CharacterStates state { get; set; }
		public CharacterStates prevState { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public short stateIndex { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public BulletManager bulletManager { get; }
		public float moveSpeed { get; }
		public float dashSpeedRatio { get; }
		public float curseMoveSpeedRatio { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 actionMoveVelocity { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 externalVelocity { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 panelMoveVelocity { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 skillMoveVelocity { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 slipMoveVelocity { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isChargeCompleted { get; }
		public ChargeMarker chargeMarker { [CompilerGenerated] get; [CompilerGenerated] set; }
		public ChargeMarker[] nextLevelChargeMarkers { [CompilerGenerated] get; [CompilerGenerated] set; }
		public ChargeMarker originalChargeMarker { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int chargeMarkerBulletEffectTriggerId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float chargePullLength { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 chargeMovePosition { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 chargeForward { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 chargeMarkerPos { [CompilerGenerated] get; [CompilerGenerated] set; }
		protected CharacterDamageIntermediate damageIntermediate { get; }
		public float speedRate { get; set; }
		public float motionSpeed { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float actionSpeedScale { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float scaleRate { get; set; }
		public Vector3 scale { get; }
		public float baseScaleRate { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public float baseRadius { get; protected set; }
		public float radius { get; }
		public float baseHeight { get; protected set; }
		public float height { get; }
		public virtual int IsHitCollisionOnCenter { get; }
		public NavMeshAgent navMeshAgent { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Collider collisionCollide { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public Vector3 colliderPosition { get; }
		public Animator animator { [CompilerGenerated] get; [CompilerGenerated] private set; }
		protected RuntimeAnimatorController defaultAnimatorController { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Rigidbody rigidBody { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool IsExternalMoveAffected { get; }
		public CharacterFreeFall freeFall { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public CharacterSlipCtrl slipCtrl { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Transform rootTransform { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Transform centerTransform { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Transform headTransform { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Transform hipTransform { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Transform weaponLTransform { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Transform weaponRTransform { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Transform muzzleTransform { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float localTimeScale { get; set; }
		public List<ActionBase> actions { get; }
		public int lastActionId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int nextActionIdForSendSignal { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool useAction { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool hasFirstAction { [CompilerGenerated] get; [CompilerGenerated] set; }
		public ActionContainer lastActionContainer { get; }
		public int carrySequenceId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isCarryMode { get; }
		public bool isCarryConfirmed { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float carryTimer { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int ParentBulletId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CommonObjectStatus targetObject { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float approachEventActionRange { [CompilerGenerated] get; [CompilerGenerated] set; }
		public EventActionData.TargetType approachEventActionTargetType { [CompilerGenerated] get; [CompilerGenerated] set; }
		public string approachEventTargetEnemyName { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int approachEventId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Vector3 pivotBase { get; set; }
		public Vector3 basePosition { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Transform areaAnchor { get; set; }
		public EnemyOutsideWall enemyCheckOutside { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		public Vector3 previousPosition { get; set; }
		public bool isCheckWall { get; set; }
		public CharacterManager charaManager { get; set; }
		protected Dictionary<int, ActionContainerElement> dictActionDataResource { get; }
		public List<int> listActionId { get; }
		public int currentCombo { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isShiftPrevCombo { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float chargePrepareTime { [CompilerGenerated] get; [CompilerGenerated] protected set; }
		protected Vector3 moveStartDirection { [CompilerGenerated] get; [CompilerGenerated] private set; }
		protected int reserveActionId { [CompilerGenerated] get; [CompilerGenerated] set; }
		protected int reserveSkillIndex { [CompilerGenerated] get; [CompilerGenerated] set; }
		protected Vector3? reserveDirection { [CompilerGenerated] get; [CompilerGenerated] set; }
		public ActionHitRecord actionHitRecord { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public GameObject bulletObject { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isUsedTransformDragon { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CharacterMoveEventClock moveEventClock { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public AbnormalStatusMultiPlayService AbnormalStatusMultiPlayService { [CompilerGenerated] get; [CompilerGenerated] set; }
		public BuffMultiPlayService BuffMultiPlayService { get; }
		public virtual SkillPointMultiPlayService SkillPointMultiPlayService { get; }
		public virtual EnergyPointMultiPlayService EnergyPointMultiPlayService { get; }
		public virtual AbilityGaugeMultiPlayService AbilityGaugeMultiPlayService { get; }
		public virtual WarpRoom.RoomGroup warpRoomGroupId { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isSkipActionEndPlayIdleMotion { [CompilerGenerated] get; [CompilerGenerated] set; }
		public CUGCtrl uniqueGimmick { [CompilerGenerated] get; }
		public CtrlBind ctrlBind { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isBind { get; }
		public bool isBindOnTransform { get; }
		public CharacterDamageRecord DamageRecord { get; }
		public float idleBlendDuration { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool IsInsideBRBush { get; }
		public bool isInvisibleByInsideBRHouse { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool IsInsideBRBushOrHouse { get; }
		public virtual string effNameCriticalHit { get; }
		public virtual string IdleStateName { get; }
		public virtual string WalkStateName { get; }
	
		// Events
		public event Action<int, int[], float[], RunActionEvent, bool> stateChangedEvent {
			add;
			remove;
		}
		public event Action<CharacterBase> deadEvent {
			add;
			remove;
		}
		public event Action initStateEvent {
			add;
			remove;
		}
	
		// Nested types
		public enum ModelType
		{
			Normal = 0,
			Simple = 1
		}
	
		public enum HandID
		{
			LeftHand = 0,
			RightHand = 1
		}
	
		public enum ActionSignal
		{
			Input = 0,
			SuperArmor = 1,
			Invincible = 2,
			AttachWeaponLeft = 3,
			AttachWeaponRight = 4,
			NonUse01 = 5,
			NonUse02 = 6,
			PutUpEffect = 7,
			Show = 8,
			Hide = 9,
			NoReaction = 10,
			SuperArmorLv1 = 11,
			SuperArmorLv2 = 12,
			SuperArmorLv3 = 13,
			Omit01 = 14,
			AdditionalInput = 15,
			InvincibleLv1 = 16,
			InvincibleLv2 = 17,
			InvincibleLv3 = 18,
			SpecialDead = 19,
			NoTarget = 20,
			SuperArmorLv4 = 21,
			DisableCheckOutside = 22,
			DisableExternalVelocity = 23,
			ShowWeapon = 24,
			HideWeapon = 25,
			DamageCounter = 26,
			CancelInvincible = 27,
			ChangePartsMesh = 28,
			EnableAction = 29,
			RecordHitTarget = 30,
			GuardCounter = 31,
			GuardReactionInCharge = 32,
			HideStockBullet = 33,
			Stop1 = 34,
			HitCount = 35,
			RESERVE_02 = 36,
			RESERVE_03 = 37,
			RESERVE_04 = 38,
			RESERVE_05 = 39,
			RESERVE_06 = 40,
			RESERVE_07 = 41,
			RESERVE_08 = 42,
			RESERVE_09 = 43,
			RESERVE_10 = 44
		}
	
		public static class NodeName
		{
			// Fields
			public const string Root = "jGameRoot";
			public const string Center = "jRoot";
			public const string Head = "jHead";
			public const string Hip = "jHip";
			public const string WeaponL = "jWeaponL";
			public const string WeaponR = "jWeaponR";
			public const string Muzzle = "eff_muzzle";
		}
	
		public enum HitType
		{
			Player = 0,
			Enemy = 1,
			AllyPlayer = 2,
			EnemyPlayer = 3,
			HostEnemy = 4,
			GuestEnemy = 5,
			Other = 6
		}
	
		public enum HitProduction
		{
			None = 0,
			HitValue = 1,
			HitEffect = 2,
			HitFlash = 4,
			HitFont = 8,
			HpGage = 16,
			HitSE = 32,
			All = 47
		}
	
		public enum DamageReaction
		{
			Normal = 0,
			BlastUp = 1,
			BlastHalf = 2,
			BlastDown = 3,
			BlastInherit = 4,
			NoReaction = 5,
			SuperArmor = 6,
			Invincible = 7,
			SuperArmorBreak = 8,
			Throw = 9,
			Freeze = 10
		}
	
		private enum ShadowCastMethod
		{
			TexturedQuad = 0,
			TextureProjection = 1,
			MaxNum = 2
		}
	
		private struct ReserveAction
		{
			// Fields
			public int actionId;
			public CommonObjectStatus target;
			public int skill;
			public CharacterBase murderer;
			public Action<ActionBase> actionFinishCallback;
			public bool resistClearExcludeDead;
			public bool viaAttackState;
		}
	
		private struct ResponseEventAction
		{
			// Fields
			public EventActionData.EventType type;
			public UnityEvent responseEvent;
		}
	
		private struct ReservableActionInfo
		{
			// Fields
			public ActionSignal type;
			public int actionId;
		}
	
		[CompilerGenerated]
		private sealed class _DelayRunAction_d__913 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public float delay;
			public CharacterBase __4__this;
			public int actionId;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _DelayRunAction_d__913(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass947_0
		{
			// Fields
			public UnityEvent resEvent;
	
			// Constructors
			public __c__DisplayClass947_0();
	
			// Methods
			internal bool _DelEventAction_b__0(ResponseEventAction i);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass1107_0
		{
			// Fields
			public int hitCount;
			public CharacterBase __4__this;
			public CollisionHitAttribute attr;
	
			// Constructors
			public __c__DisplayClass1107_0();
	
			// Methods
			internal void _RecoveryHpOnHitCount_b__0(AbilityDataElement ade, int idx);
		}
	
		[CompilerGenerated]
		private sealed class _RebornCoroutine_d__1233 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CharacterBase __4__this;
			private InGameSettings.RebornParams _rebornParam_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _RebornCoroutine_d__1233(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CoDelayEffect_d__1282 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CharacterBase __4__this;
			public float delayTime;
			public string nodeName;
			public string ctrl_key;
			public string effectName;
			public Vector3 offset;
			private int _idx_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoDelayEffect_d__1282(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public CharacterBase();
		static CharacterBase();
	
		// Methods
		public virtual void SetModelType(ModelType type);
		public virtual void UpdateFace();
		public virtual void SetCharaColor();
		public static bool IsHitTypeManagedOhter(HitType hitType);
		public bool IsPlayer(out PlayerCharacter player);
		public bool IsPlayerCharacter(bool ignoreTransform = false);
		public bool IsSupportCharacter();
		public bool IsSupportRequestCharacter();
		public bool IsServantForPlayerCharacter();
		private bool IsLAN5WATER04();
		public bool IsRockman();
		public bool IsRockmanBoss();
		public bool IsEightPt();
		public bool IsEightServant();
		public bool IsAttackHitResistAbnormalStatus();
		public virtual void IgnoreCollide(CharacterBase target, bool isIgnore = true);
		public void SetDefaultAnimatorController(RuntimeAnimatorController value);
		public void disableFreeFall();
		public void EnterCarryMode(CharacterBase targetChara);
		public void LeaveCarryMode(bool isThrow);
		public void SetIsCheckWallForcibly(bool value);
		public bool IsHiding();
		public bool IsHidingOrInsideBRBushOrHouse(bool exceptsCameraFocusChara = true);
		protected override void Awake();
		public void Initialize(InGameDef.CharacterType charaType, bool isNeedShadow);
		protected void InitializeParts();
		public virtual void SetupAbilityCommonData();
		protected virtual void SetupCharacterState();
		public void InvokeStateChangedEvent(int[] param, float[] paramf, RunActionEvent runActionEvent, bool ignoreSync);
		public virtual Vector3 EffectScale();
		public virtual Vector3 AuraScale(bool isDynamicScale = false);
		public virtual Vector4 EmotionIconParam();
		public virtual float ShadowSize();
		private void ChangeShadowCastMethod(ShadowCastMethod method);
		private void UpdateShadowSizeByHeight();
		private float GetShadowSizeHeightCoef();
		public virtual void ChangeState(CharacterState characterState);
		public int GetBulletId();
		public virtual bool RunningBarrier(CollisionHitAttribute data);
		public virtual bool IsCounterAction(Vector3 attackDir, CollisionHitAttribute data);
		public bool IsGuardState();
		public bool IsValidTarget();
		public virtual bool IsTimeStop();
		public virtual bool IsTimeStopInput();
		public virtual bool IsTimeStopBuffAbnormalStatusDragonTimer();
		protected virtual bool IsSuperArmor();
		public bool IsInvincible(int breakLevel = 0);
		protected bool IsBreakInvincible(int breakLevel);
		public bool IsInvincibleOnHitCheck(CollisionHitAttribute attr);
		public virtual void AddInvincible(InvincibleControl.Type type, int level, float sec, int uid = 0);
		public virtual void RemoveInvincible(InvincibleControl.Type type, int uid = 0);
		public void AddInvincibleFromAction(int level);
		public void CancelInvincible();
		public void CancelUnderLevelInvincible(int level);
		public void CancelInvincibleForAllKillAttack();
		public void ActivateDownRecovery();
		public void InactivateDownRecovery();
		protected virtual bool IsHitFlash();
		protected virtual bool IsResistBlast();
		protected virtual bool IsBreakAction();
		public virtual void StartBreak();
		public virtual void BreakFinish();
		public virtual void CutoffBreak();
		public virtual void OnBreakDamage(int breakDamage);
		protected virtual bool DropDp(float prevHpRate, CharacterBase triggerChara, float coef);
		public virtual void FreezePosition();
		public virtual void UnFreezePosition();
		protected virtual bool IsTurnToDamageDir(DamageReaction reaction);
		public bool IsTransformDragonOrUnique();
		public bool CancelTransformDragonOrUnique();
		public virtual bool IsTransformDragon();
		public virtual bool IsEnhanceDragon();
		public virtual bool IsServant();
		public virtual void CancelTransform();
		public virtual bool IsUniqueTransformMode();
		public virtual void ReleaseUniqueTransform();
		public void CancelTransformForAnnihilationAttack();
		public virtual void SetIsPauseDragonTime(bool isPause);
		public virtual bool IsPauseDragonTime();
		public void LoadAnimationController(string path, Action<CharacterAnimationEvent> animEventSetupAction, int baseId = -1, int variationId = -1, bool ignoreBRSkin = false);
		protected void LoadActionContainerElements(InGameDef.CharacterType characterType, string groupName, bool isOtherPlayer, bool exceptOtherSkills = false, bool isShareSkill = false);
		public void LoadActionResources();
		protected void LoadActionContainers(List<int> actions, string groupName, bool isOtherPlayer, bool exceptOtherSkills = false, bool isShareSkill = false);
		protected void AddLoadActions(List<int> actions, SkillDataElement skillData);
		protected void AddLoadActions(List<int> actions, int actionId);
		public int GetAdvancedActionId(SkillDataElement skillData);
		public int GetBaseIdActionId(SkillDataElement skillData);
		private bool LoadActionPartsSpecificAction(List<int> actions, int actionId);
		private bool LoadEnhancedSkillAction(List<int> actions, int actionId, int skillId, string groupName, bool isOtherPlayer, int depth = 0);
		public bool LoadEnhancedAbilityBurstAttackAction(List<int> actions, int actionId);
		protected bool LoadNextAction(List<int> actions, int actionId);
		private bool LoadCastingAction(List<int> actions, int actionId);
		public void AddAttachEffect(EffectObject effectObject);
		public void ClearAttachEffect();
		public void SetPauseAttachEffect(bool isPause);
		public void SetPauseAttachEffectForTimeStop(bool isPause);
		public void AddStateAttackEffect(EffectObject eo);
		public void ClearStateAttackEffect();
		protected override void OnDestroy();
		public override void FastUpdate();
		public void SetSlip(bool b);
		private void FixedUpdate();
		private void UpdateAction();
		private void FixedUpdateAction();
		protected void UpdateCheckWall();
		public override void LateUpdate();
		public Vector3 GetCenterPosition();
		public Transform GetCenterTransform();
		public Transform GetHeadTransform();
		protected void SetMuzzleTransform();
		public Transform GetMuzzleTransform();
		public bool GetAutoDashPosition(out Vector3 pos);
		public Vector3 GetForwardMove();
		public void SetMoveStartDirection();
		public bool UpdateRotateToTarget(CommonObjectStatus target, bool useLegacyRotate);
		public bool UpdateRotateToTarget(Vector3 targetPos, bool useLegacyRotate, float speed = 1f);
		public float CalcRotateSpeed(float speed = 1f);
		public bool IsLookTarget(Vector3 targetPos, float speed = 1f);
		public void LookAt(Vector3 position);
		public void LookTo(Vector3 direction);
		private void LookToDamageDirection(CollisionHitAttribute attr);
		public void PlayAnimation(string stateName);
		public void PlayBlendAnimation(string stateName, float blendDuration, bool checkSame);
		public void PlayAnimationForAttachObject(string stateName);
		public void PlayBlendAnimationForAttachObject(string stateName, float blendDuration, bool checkSame);
		public virtual void PlayDefaultMoveAnimationForEventRecevier();
		public void PlayDefaultIdleAnimationForEventRecevier(float blendDuration, bool checkSame);
		public bool CanPlayAnimationForEventRecevier();
		public float GetAnimationTime();
		public float GetAnimationLength();
		public float GetAnimationNormalizedTime();
		public bool IsAnimationState(string stateName);
		public bool IsNextAnimationState(string stateName);
		public int GetNextAnimationCount();
		public bool IsLoopAnimation();
		public void SetAnimationTime(float time);
		public void RestoreAnimation();
		public bool IsEnableAction();
		protected void AddReserveAction(int actionId, int skillId, CommonObjectStatus target, Action<ActionBase> argActionEndCallback = null, bool resistClear = false, bool viaAttackState = false);
		public virtual void AddAction(int actionId, int skillId = 0, CommonObjectStatus target = null, Action<ActionBase> argActionEndCallback = null, bool viaAttackState = false);
		public bool IsContainsReserveAction(int actionId);
		public void RemoveReserveAction(int actionId);
		private void ClearReserveActionList();
		public void DelayAction(float delay, int actionId);
		[IteratorStateMachine]
		public IEnumerator DelayRunAction(float delay, int actionId);
		protected ActionContainer LoadActionContainer(int actionId);
		public static long GetActionPartsResouceId(int actionId, int partsIndex);
		public ActionParts.PartsData GetActionPartsResource(long resourceId);
		public RunActionResult RunAction(int actionId, int skillId = 0, float tempoScale = 1f, CommonObjectStatus target = null, Action<ActionBase> actionFinishCallback = null, RunActionParameterBase startActionContext = null, int overrideActionProductId = -1, bool setUseActionFlag = true, bool isFromOption = false, bool dontLootAtReservedTarget = false);
		public bool IsActionDataResource(int actionId);
		public bool GetActionContainer(int actionId, out ActionContainer container);
		public RunActionResult RunAction(ActionBase action, RunActionParameterBase runActionParam = null, bool setUseActionFlag = true, bool isFromOption = false);
		public void ClearActionIdList();
		public void RemoveAction(ActionBase action);
		public void ClearActionByActionId(int actionId);
		public void ForceClearAllActions();
		public void ClearAction(bool allClear = true, int excludeId = 0);
		private void ResetReserveAction();
		public void ClearReserveAction();
		protected void ClearInputReserveAction();
		public void ResetAction(bool bResetHitStopPlayer = true, bool allClear = true, int excludeId = 0, bool resetReserve = true, bool stopAdditionalInputUI = true);
		public void PauseAction(bool isPause);
		public void StopAdditionalInputUI();
		public bool IsRunningAction(bool excludeOptionActions = false);
		public int RunningActionNum(bool excludeOptionActions = false);
		public int GetCurrentActionId(bool excludeOptionActions = false);
		public virtual void ResetSuperArmorLevel();
		public void SendSignal(SendSignalData sendSignalData, ActionSignal type, int actionId, int decoId);
		public void RemoveSignal(SendSignalData sendSignalData, ActionSignal type, int actionId, int decoId, bool isActionEnd = false);
		protected virtual void ResetAttachSignal(int actionId, int skillId);
		public bool IsReservableActionID(ActionSignal type, int actionId);
		public void SetActiveCancelActionID(int id);
		public void RemoveActiveCancelActionID(int id);
		public bool CanCancelAction(int nextActionId);
		public bool CanCancelReservedAction();
		public bool CanAttackAction();
		public void AddEventAction(EventActionData.EventType type, UnityEvent resEvent);
		public void DelEventAction(UnityEvent resEvent);
		public void ResponseEventActions(EventActionData.EventType type);
		private void UpdateEventActionCondition();
		private void CheckApproachEventAction();
		protected virtual void CheckStopAbnormalEventAction();
		public virtual bool ReserveMoveAction();
		private void RunAvoidAction(Vector3 dir, InGameDef.Direction dirType);
		public bool ReserveAvoidAction(Vector3 dir, bool withStateChange = true);
		public bool IsEnableAvoidActionImmediately();
		private bool IsEnableAvoidAction();
		public bool CanReserveAvoidAction(CollisionHitAttribute hitAttr, bool withStateChange);
		protected virtual float AvoidDirectionCoef(InGameDef.Direction dirType, int actionId);
		public virtual void UpdateChargeMarker();
		public virtual void CreateChargeBullet(string effectName);
		public virtual void DeleteChargeBullet();
		public void ClearChargeMarker(bool setImpact, bool setNull);
		public virtual void AdvanceChargeLevel(int level);
		public virtual float GetSuperArmorTimeOnCharge();
		public bool EnableChargeStart();
		public bool ShouldDisableSkillByRequiredBuff(int i, out int spGaugeCount);
		public bool EnableSkillAction(int idx, int nextActionIdForActiveCancel = 0);
		public bool NeedRunSkillCastAction(int actionId);
		public bool RunSkillAction(int idx, int actionId, CommonObjectStatus target, bool checkEnable = true, bool SkillProduction = false);
		public bool RunSkillCastAction(int skillIdx, int actionId, CommonObjectStatus target, bool checkEnable = true);
		public bool IsActivateSkill(int idx);
		public bool EnableSupportSkill();
		public int GetActiveSkillId();
		public virtual void SetupSkillMoveInput(MoveInputData data);
		public virtual void ResetSkillMoveInput();
		public virtual void SetupSkillRotateInput(RotateInputData data);
		public virtual void ResetSkillRotateInput();
		public virtual bool RunGuardAction();
		public void RunGuardCancel();
		public bool RunGuardCancelAttack();
		public bool RunBlastRecoveryAction(Vector3 look, bool isCtrl);
		public GameObject GetAttachObject(int decoId);
		private void SetVisible(bool visible, int decoId);
		public bool SetVisibleMainWeapon(bool visible);
		protected void SetVisibleDecoWeapon(bool visible);
		public void SetVisibleMainWeaponWithIgnoreCheck(bool visible);
		private void SetVisibleWeaponForSendSignal(bool visible, int actionId);
		public void SetVisibleWeaponForCommand(bool visible, int key);
		public void ChangeAttachWeapon(HandID handId, int weaponKey = -1);
		protected void ChangeAttachWeaponForSendSignal(HandID handId, int actionId);
		public GameObject GetMainAttachWeapon();
		public GameObject GetDecoAttachWeapon();
		protected void AttachHumanWeapon(int weaponId, bool isNondominanntHand = false);
		public void AttachHumanWeaponSkin(int weaponSkinId, bool isNondominanntHand = false);
		public void SwitchHumanWeaponSkinAsMainWeapon(int weaponSkinId, bool isDeco);
		private int ConvertWeaponSkinIdToIndex(int weaponSkinId);
		private int ConvertWeaponSkinIdToIndex(int baseId, int varId);
		public int AttachHumanWeaponSkinForCommand(CommandData partsData);
		public void DestroyAttachedHumanWeapon();
		protected int AttachHumanWeapon(int baseId, int variationId, string nodeName);
		public GameObject LoadHumanWeapon(int baseId, int variationId);
		public void AttachHumanEnemyObject(string eoModelStr);
		public virtual WeaponType GetWeaponType();
		public virtual WeaponTypeElement GetWeaponTypeElement();
		public virtual ElementalType GetWeaponElement();
		public virtual ElementalType GetDragonElement();
		public virtual CharacterBase GetOriginalChara();
		public virtual CharacterBase GetDragonChara();
		public virtual CharacterBase GetCurrentChara();
		public virtual TribeType GetTribe();
		public virtual int GetComboAttackId(int idx, bool ex);
		public int GetNextAttackId(bool ex);
		public virtual int GetMaxCombo();
		public virtual int GetAvoidActionId(InGameDef.Direction dir);
		public virtual int GetDashAttackActionId();
		public virtual int GetBurstAttackActionId();
		public virtual int GetGuardActionId();
		public virtual int GetGuardCancelAttackId();
		public virtual int GetDamagedActionId();
		public virtual int GetParalysisActionId();
		public virtual int GetDragonTransformActionId();
		public virtual bool IsTurnToTarget(int id);
		public virtual bool IsRequestGuardRigor();
		public virtual void CancelRequestGuardRigor();
		public virtual bool IsCombo(int actionId);
		public bool IsSkill(int actionId, bool includeTransSkill = false, bool includeEnhancedSkill = false, bool includeChainSkill = false, bool includeActionShiftByInput = false);
		public bool IsNormalSkill(int actionId, bool includeTransSkill, bool includeEnhancedSkill, bool includeChainSkill);
		public bool IsSkill1(int actionId, bool includeTransSkill = false, bool includeEnhancedSkill = false, bool includeChainSkill = false, bool includeActionShiftByInput = false);
		public bool IsSkill2(int actionId, bool includeTransSkill = false, bool includeEnhancedSkill = false, bool includeChainSkill = false, bool includeActionShiftByInput = false);
		public bool IsWeaponSkill(int actionId, bool includeTransSkill = false, bool includeEnhancedSkill = false);
		public bool IsSkill3(int actionId, bool includeTransSkill = false, bool includeEnhancedSkill = false);
		public bool IsSkill4(int actionId, bool includeTransSkill = false, bool includeEnhancedSkill = false);
		public bool IsSkillFA(int actionId, bool includeTransSkill = false, bool includeEnhancedSkill = false);
		private bool IsSkillForSkillIndex(int skillIndex, int actionId, bool includeTransSkill, bool includeEnhancedSkill, bool includeChainSkill, bool includeActionShiftByInput);
		private bool IsTransSkill(int skillIndex, int actionId);
		private bool IsEnhancedSkill(int skillIndex, int actionId);
		private bool IsChainSkill(int skillIndex, int actionId);
		private bool IsActionShiftByInputSkill(SkillDataElement sde, int skillIndex, int actionId);
		protected bool IsSkill(SkillDataElement sde, int actionId);
		public virtual bool IsDashAttack(int actionId);
		public virtual bool IsBurstAttack(int actionId);
		public virtual bool IsInputCharge();
		public virtual bool IsInputMove();
		protected virtual float GetAbnormalStatusProbability(CollisionHitAttribute attr, int type, float probablity);
		protected virtual float GetAbnormalStatusResistRate(int type);
		public virtual float GetSearchRange();
		public bool ReserveNextAttackAction(CommonObjectStatus target, bool isAI);
		private bool ReserveNextAttackAction(int nextId);
		public int DashAttack();
		public bool IsDashAttackAction();
		public void StartCharge(int chargePhase);
		public void CancelCharge(bool keepCurrentAction = false);
		public bool IsChargeCancel();
		public bool IsRunningBurstAttack();
		public bool IsMovingBurstAttack();
		public bool IsActionReserved();
		public bool IsReserveDisturbanceAction();
		public bool IsReserveFreezeAction();
		public bool IsReserveSwoonAction();
		public bool IsReserveSleepAction();
		public bool IsReserveParalysisAction();
		public virtual int GetSkillNum();
		public virtual CharacterSkillData GetSkillData(int index);
		public virtual SkillDataElement GetSkillDataElement(int index);
		public virtual SkillDataElement GetTransSkillDataElement(int index, int phase);
		public virtual SkillDataElement GetNextTransSkillDataElement(int index);
		public virtual AbilityDataElement GetAbilityDataElement(int index);
		public virtual AbilityDataElement GetAmuletAbilityDataElement(int crestSlotNo, int abilitySlotNo);
		public virtual AbilityDataElement GetDragonAbilityDataElement(int idx);
		public virtual AbilityDataElement GetWeaponAbilityDataElement(int idx);
		public virtual AbilityDataElement GetSkillAbilityDataElement(int index);
		public virtual AbilityDataElement GetExAbility2DataElement(int index);
		public virtual AbilityDataElement GetEventAbilityDataElement(int index);
		public virtual PlayerActionElement GetParentNextActionDataElement(int actionId);
		public virtual string GetAttackCueName(int comboIndex);
		public virtual string GetDashAttackCueName();
		public virtual string GetSkillCueName(int idx);
		public virtual string GetDamageCueName();
		public virtual string GetBlastCueName();
		public virtual string GetAvoidCueName();
		public virtual string GetContinueCueName();
		public virtual string GetChangePlayerCueName();
		public virtual string GetDragonTransformCueName();
		public virtual string GetWinCueName();
		public virtual string GetQuestFailedCueName();
		public virtual string GetTalkCueNamePrefix();
		public void ChargePrepare();
		public void ResetChargePrepare();
		public void RestartSlip();
		public virtual void CallbackHitAction(CollisionHitAttribute attr);
		public virtual void SetEnhancedBurstAttackId(int actionId, int modifyChargeLevel);
		public virtual void ResetEnhancedBurstAttackId();
		public virtual int GetEnhancedBurstAttackId();
		public virtual int GetActualEnhancedBurstAttackId();
		public virtual void SetEnhancedAbilityBurstAttackId(int actionId);
		public virtual void SetEnhancedSkillId(int enhancedIndex, int enhancedId, int skillId, int depth);
		public virtual int GetEnhancedSkillId(int skillIndex, int depth);
		public virtual void SetupEnhancedSkill(int enhancedIndex, int enhancedId, int skillId);
		public virtual void ResetEnhancedSkill(CharacterBuffType buffType, int conditionId);
		public virtual void ResetEnhancedSkill(int skillIndex);
		public virtual void CheckTransSkill(CollisionHitAttribute attr);
		public virtual void TransformSkillForSkillId(int skillId);
		public virtual void ResetTransSkill(int skillId);
		public virtual void DisableTrans(int skillIndex);
		public virtual bool IsPauseTransBuff(int skillId);
		public virtual void PauseTransBuff(int skillIndex, bool pause);
		public void RecoveryHpOnHitCount(CollisionHitAttribute attr, int hitCount);
		protected void ActivateAbilityOnDamaged();
		protected void ActivateAbilityOnHeal();
		protected void ActivateAbilityOnAvoid(CharacterBase attacker);
		public bool CheckOnAttackedDuringInvincible(int invincibleBreakLv);
		private void OnAttackedDuringInvincible(CharacterBase attacker, int invincibleBreakLv);
		public bool CheckFollowerAvoid(int probability);
		public virtual bool OnCollided(CollisionHitAttribute hitAttr, HitProduction hitProduction = HitProduction.All, int followerAvoid = 0);
		public virtual void OnDamaged(AttackHit hitData, CollisionHitAttribute hitAttr, CharacterBase from);
		private bool CanDispHeadText(CollisionHitAttribute hitAttr);
		public virtual void BuildDamage(int damage, CollisionHitAttribute hitAttr, Vector3 hitPos, CharacterDamageIntermediate outIntermediate);
		public virtual void ApplyDamage(CharacterDamageIntermediate intermediate);
		private void CalcDrainValue(CharacterDamageIntermediate intermediate);
		public virtual void DrainHp(CollisionHitAttribute attr);
		public void ResetDrainValue();
		public virtual void ExecSelfDamage(CollisionHitAttribute attr);
		public void ThrowDamage(CharacterBase attacker);
		public void CalcParalysisDamage(int slipDamage, bool isFollower, bool isNotify);
		public void CalcAbnormalStatusDamage(CharacterBase attacker, int damage, bool isFollower, AbnormalStatusType type, Dictionary<CharacterBase, int> froms = null);
		public virtual void ApplySlipDamage(CharacterBase attacker, int damage, bool isFollower, AbnormalStatusType abnormalStatusType, CharacterBuffType buffType, int uniqueBuffIcon, Dictionary<CharacterBase, int> froms = null);
		public virtual bool ApplyDragonTimerSlipDamage(int damage, bool isFollower, CharacterBuffType buffType, int uniqueBuffIcon, float dragonTimerDamageFromMulti = 0f);
		public bool IsCorrosionSlipDamage(CharacterBuffType buffType, int uniqueBuffIcon);
		public void CalcHitPosAndRot(CollisionHitAttribute attr, out Vector3 pos, out Quaternion rot);
		private void PlayDamageEffect(CollisionHitAttribute hitAttr, Vector3 hitPos, Quaternion rot, bool isCritical, bool isKiller, bool isTolerance, bool isLethal, HitProduction hitProduction, DamageReaction reaction, string additionalAttackEffect = "");
		private void PlayDamageEffect(CharacterBase owner, int actionId, string fontEffectName, Vector3 hitPos, Quaternion rot, bool isCritical, bool isKiller, bool isTolerance, bool isLethal, HitProduction hitProduction, DamageReaction reaction, string additionalAttackEffect = "");
		protected virtual void DamageHitFlash();
		private bool CheckGraphicQualityForPlayEffect();
		private void PlaySPHealEffect(CollisionHitAttribute attr);
		private void PlayHealEffect(CollisionHitAttribute attr);
		private void PlayHealSE();
		private void PlayDefaultHealEffect();
		public void PlayCommonHealEffectAndSE();
		protected void PlayHpPotionEffect();
		public void PlaySpPotionEffect();
		protected virtual void PlayHitEffect(CharacterBase owner, Vector3 hitPos, Quaternion rot, bool isCritical, bool isKiller, bool isTolerance, bool isTorpedo, string additionalAttackEffect = "");
		protected virtual void PlayHitFontEffect(CharacterBase owner, string fontEffectName, Vector3 hitPos);
		protected virtual void PlayDamageSE(CharacterBase owner, int actionId, Vector3 hitPos, bool isCritical, bool isLethal);
		protected void PlayDamageSE(Vector3 hitPos, bool isCritical, CharacterBase damagedChara);
		protected virtual void PlayHitSE(int actionId, Vector3 hitPos, bool isCritical, bool isLethal, CharacterBase damagedChara);
		private void PlayDamageCameraShake(CharacterBase owner, int actionId, bool isCritical, DamageReaction reaction);
		protected virtual void PlayHitCameraShake(CameraController.ShakeType shakeType);
		public void ShowDamageUI(CharacterBase attacker, int damage, Vector3 hitPos, bool isCritical, float pureElementRate, float delaySec, int splitDmgNum = 0, bool isSelf = false, AbnormalStatusType abnormalStatusType = AbnormalStatusType.NONE, CharacterBuffType buffType = CharacterBuffType.None, int splitDmgNum2 = 0, bool isSkill = false, Dictionary<CharacterBase, int> slipDamageOwners = null, CharacterBase extraDamageOwner = null, int uniqueBuffIcon = 0, bool isDebuffExtraDamage = false, CharacterBase additionAttackFrom = null, bool isAdditionAttackDamage = false, bool isQuestSKill = false);
		protected virtual bool IsDamageReaction(CollisionHitAttribute attr, int damage);
		protected virtual DamageReaction CheckDamageReaction(CollisionHitAttribute attr, int damage);
		private DamageReaction CheckDamageReaction(CollisionHitAttribute attr);
		protected virtual int CheckOverwhelm(int attack);
		protected virtual int CheckParameterDisparity();
		private bool IsDamagedFromEnemyPlayerInBattle(CollisionHitAttribute attr);
		protected DamageReaction SetupDamageAction(CollisionHitAttribute attr, Vector3 collisionPos, int damage);
		private bool SetupDamageActionCommon(CollisionHitAttribute attr, Vector3 collisionPos);
		private void SetupDamageActionNormal(CollisionHitAttribute attr, Vector3 collisionPos);
		private void SetupDamageActionBlastUp(CollisionHitAttribute attr, Vector3 collisionPos, DamageReaction reaction);
		private void SetupDamageActionBlastDown(CollisionHitAttribute attr, Vector3 collisionPos);
		private void SetupDamageActionNoReaction(CollisionHitAttribute attr, Vector3 collisionPos);
		private void SetupDamageActionSuperArmor(CollisionHitAttribute attr, Vector3 collisionPos);
		private void SetupDamageActionSuperArmorBreak(CollisionHitAttribute attr, Vector3 collisionPos);
		private void SetupDamageActionFreeze(CollisionHitAttribute attr, Vector3 collisionPos);
		protected virtual void SetupExternalMove(CollisionHitAttribute attr, Vector3 collisionPos);
		protected virtual void SetupSuperArmorBreakMove(CollisionHitAttribute attr, Vector3 collisionPos);
		protected virtual void ActivateGrantedBuff(CollisionHitAttribute attr);
		public static void VisitActivateGrantedBuff(CollisionHitAttribute attr, Action<CollisionHitAttribute, int> callback);
		private static void VisitGrantedBuff(List<CharacterBuff.GrantData> list, CollisionHitAttribute attr, Action<CollisionHitAttribute, int> callback);
		private static void VisitGrantedBuff(AbilityTargetAction targetAction, CollisionHitAttribute attr, Action<CollisionHitAttribute, int> callback);
		public virtual ApplyAbnormalStatusResult CheckAbnormalStatus(CollisionHitAttribute attr, int damage, DamageReaction reaction);
		private ApplyAbnormalStatusResult ActivateGrantedAbnormalStatus(CollisionHitAttribute attr, int damage, DamageReaction reaction);
		private ApplyAbnormalStatusResult ApplyGrantedAbnormalStatus(CollisionHitAttribute attr, List<CharacterBuff.GrantData> list, int damage, DamageReaction reaction);
		private ApplyAbnormalStatusResult ApplyAbnormalStatus(CollisionHitAttribute attr, int conditionId, int damage, DamageReaction reaction);
		protected virtual ApplyAbnormalStatusResult SetAbnormalStatus(CollisionHitAttribute attr, int conditionId, int damage, DamageReaction reaction);
		private ApplyAbnormalStatusResult SetAbnormalSwoon(CollisionHitAttribute attr, int conditionId, int damage, DamageReaction reaction, float dbgEnchant);
		private ApplyAbnormalStatusResult SetAbnormalSleep(CollisionHitAttribute attr, int conditionId, int damage, DamageReaction reaction, float dbgEnchant);
		private ApplyAbnormalStatusResult RecoveryAbnormalStatus(CollisionHitAttribute attr, ActionConditionElement ace, int conditionId);
		private bool IsRecoveryAbnormalStatus(int conditionId);
		public virtual void ResistUpAbnormalStatus(int type);
		private void ReleaseAbnormalKillerState(CollisionHitAttribute attr);
		private void ReserveAbnormalStatus(CollisionHitAttribute hitAttr, ActionConditionElement ace);
		public bool RunAbnormalStatusAction();
		private bool ReleaseAbnormalStatus(AbnormalStatusType type);
		private void ReleaseAbnormalStatus(int damage);
		public bool HasAbnormalStatus(AbnormalStatusType type, bool noneIsInvalid = false);
		public bool HasDebuff(CharacterBuff.ActionDefDebuff debuffType, int slipHpGroupId = -1);
		public void Idle();
		public void Guard();
		public virtual void Damaged(float motionTimeScale = 1f);
		protected virtual void Freeze();
		public virtual bool CheckParalysis(CharacterBase attacker, int slipDamage);
		protected virtual bool Paralysis(int slipDamage, bool isFollower);
		protected virtual void Swoon();
		protected virtual void Sleep();
		public void Bind(CharacterBase bindOwner, bool change_state = false, bool freeze = true, bool ground = false, int invincible = 0);
		public void BindForGimmick(DungeonObjectStatus bindOwner, bool change_state = false, bool freeze = true);
		public void BlastUp(float gravity, float angle, float height, DamageReaction reaction, CharacterBase attacker);
		public void BlastDown(float gravity, float angle, float height);
		public void BlastSp(float gravity, float angle, float height);
		private void Fall();
		public void Fallout(CharacterBase from);
		public virtual void PlayFallMotion();
		public virtual void PlayLandingMotion();
		public virtual void PlayIdleMotion();
		public void ControlDead();
		protected virtual void OnDead(bool isPlayMotion, bool isRestoreMotion, CollisionHitAttribute hitAttr);
		public virtual void Dead(bool isPlayMotion = true, bool isRestoreMotion = false, CollisionHitAttribute hitAttr = null);
		public virtual void SuddenDeath();
		public virtual void ForcedDead(bool isRegistLastDead = true, bool isShowRareDefeat = true, bool isInvolveBossDead = false);
		public virtual void PlayDeadAction();
		public bool HasDisappearAction();
		public void EnterSuppression();
		public void LeaveSuppression();
		public void Carry(CharacterBase carriedChara);
		public void Carried(CharacterBase carryChara);
		public void Throw();
		public void Torpedo(CharacterBase throwChara);
		public bool CanAcceptThrowCarry();
		public void ReleaseCarried();
		public void SetZeroHeight();
		public void ResetPitchRoll();
		public void SetQuestClear();
		public void SetQuestFailure();
		public virtual void InitState(bool isContinue = false, float hpRatio = 1f);
		public void Continue();
		public void Reborn();
		[IteratorStateMachine]
		private IEnumerator RebornCoroutine();
		public virtual void Revive(bool production = true, bool hasInvincibleTime = true, bool isReborn = false, float respawnInvincibleSec = 0f, float hpRatio = 1f);
		public void SetReviveState();
		public bool HasReviveAction();
		public void ReserverIn();
		public void SetEventMode(CharacterStates eventState, FaceType faceType = FaceType.NORMAL);
		public void Event(FaceType faceType = FaceType.NORMAL);
		public void EventMove();
		public void StartAreaChange();
		public void EndAreaChange();
		public void PrevState();
		public void StopStatusEffectForLowQualitySetting();
		public virtual void StopStatusEffect();
		public void RestoreStatusEffectForLowQualitySetting();
		public virtual void RestoreStatusEffect();
		public static Transform FindNode(Transform current, string name);
		public bool IsDown();
		public bool IsStopAbnormal();
		public bool IsFreeze();
		public bool IsParalysis();
		public ActionBlastBase GetBlastAction();
		public bool IsFallingOnCarriedState();
		public virtual bool EnableReduceFreezeTime(CollisionHitAttribute attr);
		private bool IsPartyAttackForUnfreeze(CollisionHitAttribute attr);
		public bool IsSwoon();
		public bool IsSleep();
		public bool IsDisabledControlAbnormalStatus();
		public bool IsPartyAttackForUnDoll(CollisionHitAttribute attr);
		public bool IsBlastState();
		public bool IsAerialState();
		private bool IsAerial();
		public bool IsDeadEnd();
		public virtual void RecoveryHpPotion(int value, bool disp);
		public void RecoverySpPotion(int value, int idx);
		public void RecoveryHp(int value);
		public void RecoverySpOnHit(int value, float originValue, float rate);
		public void RecoverySp(int value, int idx, bool withSE = true);
		public bool IsSpAvailable(int idx);
		public bool IsSpFull(int idx);
		public float GetSpRate(int idx);
		public int GetMaxSp(int idx);
		public int GetConsumeSp(int idx);
		public int GetSp(int idx);
		public int GetPrevSp(int idx);
		public void SetSp(int value, int idx, bool immediate = false);
		public EffectObject PlayEffect(string effectName, GameObject go, int trig = 0);
		public EffectObject PlayEffect(string effectName, GameObject go, Vector3 offset, int trig = 0);
		public void DelayEffect(string effectName, float delayTime, string nodeName, Vector3 offset, string ctrl_key = null);
		[IteratorStateMachine]
		private IEnumerator CoDelayEffect(string effectName, float delayTime, string nodeName, Vector3 offset, string ctrl_key);
		public void CancelAllDelayEffect();
		public virtual void PlayDashEffect();
		private void PlayPutUpEffect();
		public void ForceStopActionEffect();
		public bool IsFinishedActionMove();
		public ActionContainer GetActionContainer();
		public virtual void ClearColor();
		public bool IsColorActive();
		public virtual void SetColorState(CharacterColor.State state, bool forwardToParts = true);
		public virtual void FinishColorState(CharacterColor.State state, bool forwardToParts = true);
		public void SetColorSmooth(ColorParam toBasicColor, float smoothSec, bool forwardToParts = true);
		public void StopEffectOnChangeCharacter();
		public virtual void AddStockBullet(StockBulletObject bullet);
		public virtual List<StockBulletObject> GetStockBullets();
		public virtual void RemoveStockBullet(StockBulletObject bullet);
		public virtual void RemoveStockBulletAll();
		public virtual void RestartStockBullet();
		protected override void OnDisable();
		public virtual void NotifyLeaveActor(int actorId);
		public virtual void OnEntry();
		public virtual string GetFacePath();
		public virtual int GetFaceID();
		private bool CanFollowerAvoidAction();
		public virtual void StartupChargeMarker();
		public virtual void FinishChargeMarker(bool isAttack, bool isGuard);
		public virtual void ForceCompleteChargeMarker();
		public virtual bool IsAttackHitSender(AttackHit attackHit);
		public void SetHpZero();
		public bool IsExistWallBetweenTarget(CommonObjectStatus target, Collider ignoreCollider = null);
		public static bool IsExistWallBetweenTarget(Vector3 fromPos, CommonObjectStatus target, Collider ignoreCollider = null);
		public void PlaySwitchingTexture(int in_idx, int out_idx, float duration);
		public bool CanPlaySwitchingTexture();
		public virtual void OnCharacterSpecialState(CharacterSpecialState state);
		public virtual void RefreshDashSpeedRatio();
		private void InitUniqueGimmick(bool isContinue);
		public bool IsTransformDontEscapeMarkerDragon();
		public void AddHidingLevel(int value);
		public void AddSkillCounter(int skillId);
		public void SetModelVisibility(bool visibility, bool force = false);
		public void RequestResetChangeMesh();
		public void SendDodge(CharacterBase attacker, bool showDodge = false);
		public void OnRecieveDodge(Dodge recvEvent);
		public virtual float GetOriginalDragonTime();
		private void WakeOnCollided(CharacterBase target);
		public void UpdateLastWakeOnCollidedTime();
		public float GetElapsedSecFromLastWakeOnCollided();
	}
}
